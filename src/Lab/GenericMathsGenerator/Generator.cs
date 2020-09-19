// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.CodeAnalysis.Text;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace GenericMathsGenerator
{
    [Generator]
    public class Generator : ISourceGenerator
    {
        public void Initialize(GeneratorInitializationContext context)
        {
            context.RegisterForSyntaxNotifications(() => new SyntaxReceiver());
        }
        
        public void Execute(GeneratorExecutionContext context)
        {
            try
            {
                context.AddSource
                (
                    "attribute", SourceText.From
                    (
                        @"
using System;

namespace GenericMaths
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class | AttributeTargets.Struct)]
    public class GenericMathsAttribute : Attribute
    {
        
    }
}
", Encoding.UTF8
                    )
                );

                if (!(context.SyntaxReceiver is SyntaxReceiver sr))
                    return;
                
                var methods = sr.Methods.Select
                    (
                        x => (x,
                            ModelExtensions.GetDeclaredSymbol
                                (context.Compilation.GetSemanticModel(x.SyntaxTree), x) as IMethodSymbol)
                    )
                    .Select
                    (
                        x => (x.x, x.Item2,
                            x.Item2.GetAttributes()
                                .FirstOrDefault(x2 => x2.AttributeClass.Name == "GenericMaths"))
                    )
                    .Where(att => att.Item3 is not null)
                    .ToArray();
                
                foreach (var (declaration, symbol, attribute) in methods)
                {
                    ProcessMethod(context, context.Compilation.GetSemanticModel(declaration.SyntaxTree), declaration.Body);
                }
            }
            catch (DiagnosticException ex)
            {
                context.ReportDiagnostic(ex.Diagnostic);
            }
            catch (Exception ex)
            {
                Debugger.Launch();
                Debugger.Break();
                throw;
            }
        }

        public static void ProcessMethod(GeneratorExecutionContext context, SemanticModel model, BlockSyntax body)
        {
            var op = model.GetOperation(body);
            if (op is null)
                return;
            ProcessMethodOperation(context, model, op);
        }

        public static void ProcessMethod(GeneratorExecutionContext context, SemanticModel model, ArrowExpressionClauseSyntax body)
        {
            var op = model.GetOperation(body);
            if (op is null)
                return;
            ProcessMethodOperation(context, model, op);
        }

        private static IValueProcessor[] _valueProcessors = new IValueProcessor[]
        {
            new ConstantFolder(),
            new VariableInliner(),
        };

        private static void ProcessMethodOperation(GeneratorExecutionContext context, SemanticModel model, IOperation operation)
        {
            var variables = new OperationWalker().RootVisit(context, operation);

            variables = _valueProcessors.Aggregate(variables, (current, valueProcessor) => valueProcessor.Process(current));
            
            var steps = ResolveSteps(variables);
        }

        private static IEnumerable<IStep> ResolveSteps(IEnumerable<IVariable> variables)
        {
            var groups = new Dictionary<int, List<IValue>>();
            var stack = new Stack<IValue>(variables.Select(x => x.Value));

            while (stack.Count != 0)
            {
                var current = stack.Pop();
                foreach (var child in current.Children) stack.Push(child);

                if (!groups.ContainsKey(current.Step))
                    groups[current.Step] = new List<IValue>();
                groups[current.Step].Add(current);
            }

            return groups.OrderBy(x => x.Key).Select(x => new Step(x.Value.SelectMany(x2 => x2.Children).ToArray(), x.Value));
        }

        private static List<TypeSyntax> GetPossibleTypes(GeneratorExecutionContext context, SyntaxTree syntaxTree)
        {
            var options = context.AnalyzerConfigOptions.GetOptions(syntaxTree);

            var possibleTypes = new List<TypeSyntax>();
            if (options.TryGetValue
                ("generic_maths_possible_types", out var possibleTypesStr) && !string.IsNullOrWhiteSpace(possibleTypesStr))
            {
                foreach (var t in possibleTypesStr.Split(','))
                {
                    var parsed = ParseTypeName(t);
                    if (!(parsed is null))
                        possibleTypes.Add(parsed);
                }
            }

            if (possibleTypes.Count == 0)
            {
                possibleTypes.AddRange
                (
                    new TypeSyntax[]
                    {
                        IdentifierName(nameof(System) + "." + nameof(Byte)),
                        IdentifierName(nameof(System) + "." + nameof(SByte)),
                        IdentifierName(nameof(System) + "." + nameof(Int16)),
                        IdentifierName(nameof(System) + "." + nameof(UInt16)),
                        IdentifierName(nameof(System) + "." + nameof(Int32)),
                        IdentifierName(nameof(System) + "." + nameof(UInt32)),
                        IdentifierName(nameof(System) + "." + nameof(Int64)),
                        IdentifierName(nameof(System) + "." + nameof(UInt64)),
                    }
                );
            }

            return possibleTypes;
        }
#if FALSE
        public class GeneralizingRewriter : CSharpSyntaxRewriter
        {
            private readonly GeneratorExecutionContext _context;
            private readonly TypeSyntax[] _possibleTypes;
            private readonly Dictionary<(ITypeSymbol, bool), TypeSyntax> _remaps;
            private readonly SemanticModel _semanticModel;
            private readonly TypeSyntax? _parentType;
            public List<MemberDeclarationSyntax> ExtraMembers { get; }

            public GeneralizingRewriter
            (
                GeneratorExecutionContext context,
                TypeSyntax[] possibleTypes,
                Dictionary<(ITypeSymbol, bool), TypeSyntax> remaps,
                SemanticModel semanticModel,
                TypeSyntax? parentType
            )
            {
                _context = context;
                _possibleTypes = possibleTypes;
                _remaps = remaps;
                _semanticModel = semanticModel;
                _parentType = parentType;
                _remaps.Add((_semanticModel.Compilation.GetSpecialType(SpecialType.System_Single), false), IdentifierName(typeParam));
                _remaps.Add
                (
                    (_semanticModel.Compilation.GetSpecialType(SpecialType.System_Single), true),
                    GenericName
                    (
                        Identifier("Silk.NET.Maths.Scalar"),
                        TypeArgumentList(SingletonSeparatedList((TypeSyntax) IdentifierName(typeParam)))
                    )
                );
                ExtraMembers = new List<MemberDeclarationSyntax>();
            }
            
            public override SyntaxNode? VisitMethodDeclaration(MethodDeclarationSyntax original)
            {
                var node = original.Update
                (
                    VisitList(original.AttributeLists), VisitList(original.Modifiers),
                    (TypeSyntax?) Visit(original.ReturnType) ?? throw new ArgumentNullException("returnType"),
                    (ExplicitInterfaceSpecifierSyntax?) Visit(original.ExplicitInterfaceSpecifier),
                    VisitToken(original.Identifier), (TypeParameterListSyntax?) Visit(original.TypeParameterList),
                    (ParameterListSyntax?) Visit(original.ParameterList) ??
                    throw new ArgumentNullException("parameterList"), VisitList(original.ConstraintClauses),
                    original.Body, original.ExpressionBody,
                    VisitToken(original.SemicolonToken)
                ); // base but do not visit Body/ExpressionBody

                var body = original.Body is not null
                    ? VisitMethodBody
                    (
                        node.Identifier.Text, node.ReturnType, node.ParameterList, node.TypeParameterList,
                        node.Modifiers, original.Body!, (_semanticModel.GetSymbolInfo(original.ReturnType).Symbol as ITypeSymbol).SpecialType != SpecialType.System_Void, true, false
                    )
                    : VisitExpressionBody
                    (
                        node.Identifier.Text, node.ReturnType, node.ParameterList, node.TypeParameterList,
                        node.Modifiers, original.ExpressionBody!.Expression, (_semanticModel.GetSymbolInfo(original.ReturnType).Symbol as ITypeSymbol).SpecialType != SpecialType.System_Void, true, false
                    );
                
                return node.WithBody(Block(body)).WithExpressionBody(null).WithSemicolonToken(default);
            }

            public override SyntaxNode? VisitOperatorDeclaration(OperatorDeclarationSyntax original)
            {
                var node = original.Update
                (
                    VisitList(original.AttributeLists), VisitList(original.Modifiers),
                    (TypeSyntax?) Visit(original.ReturnType) ?? throw new ArgumentNullException("returnType"),
                    VisitToken(original.OperatorKeyword), VisitToken(original.OperatorToken),
                    (ParameterListSyntax?) Visit(original.ParameterList) ??
                    throw new ArgumentNullException("parameterList"), original.Body, original.ExpressionBody, VisitToken(original.SemicolonToken)
                ); // base but do not visit Body/ExpressionBody

                var identifier = node.OperatorToken.Text switch
                {
                    "+" => "Add",
                    "-" => "Subtract",
                    "*" => "Multiply",
                    "/" => "Divide",
                    "%" => "Modulo",
                    "==" => "Equals",
                    "!=" => "NotEquals",
                    _ => throw new DiagnosticException(Diagnostic.Create(Diagnostics.UnsupportedOperator, null, node.OperatorToken.Text))
                };

                identifier = identifier + "_OP";

                var body = original.Body is not null
                    ? VisitMethodBody
                    (
                        identifier, node.ReturnType, node.ParameterList, null,
                        node.Modifiers, original.Body!, (_semanticModel.GetSymbolInfo(original.ReturnType).Symbol as ITypeSymbol).SpecialType != SpecialType.System_Void, true, false
                    )
                    : VisitExpressionBody
                    (
                        identifier, node.ReturnType, node.ParameterList, null,
                        node.Modifiers, original.ExpressionBody!.Expression, (_semanticModel.GetSymbolInfo(original.ReturnType).Symbol as ITypeSymbol).SpecialType != SpecialType.System_Void, true, false
                    );

                return node.WithBody(Block(body)).WithExpressionBody(null).WithSemicolonToken(default);
            }

            public StatementSyntax VisitExpressionBody
            (
                string methodName,
                TypeSyntax returnType,
                ParameterListSyntax parameterList,
                TypeParameterListSyntax? typeParameterList,
                SyntaxTokenList modifiers,
                ExpressionSyntax body,
                bool generateReturn, bool generateExtraMethods, bool useDirectThrows
            )
            {
                Func<ExpressionSyntax, StatementSyntax> toFinalStatement = generateReturn
                    ? (Func<ExpressionSyntax, StatementSyntax>) ReturnStatement
                    : ExpressionStatement;

                var statements = new List<StatementSyntax>();
                statements.Add
                (
                    !useDirectThrows
                        ? (StatementSyntax) ExpressionStatement
                        (
                            InvocationExpression
                            (
                                MemberAccessExpression
                                (
                                    SyntaxKind.SimpleMemberAccessExpression,
                                    GenericName
                                    (
                                        Identifier("Silk.NET.Maths.Scalar"),
                                        TypeArgumentList(SingletonSeparatedList((TypeSyntax) IdentifierName(typeParam)))
                                    ), IdentifierName("ThrowInvalidType")
                                ), ArgumentList()
                            )
                        )
                        : ThrowStatement
                        (
                            ObjectCreationExpression
                            (
                                IdentifierName("System.NotSupportedException"),
                                ArgumentList
                                (
                                    SingletonSeparatedList
                                    (
                                        Argument
                                        (
                                            LiteralExpression
                                            (
                                                SyntaxKind.StringLiteralExpression,
                                                Literal("This operation isn't supported for the current type.")
                                            )
                                        )
                                    )
                                ), null
                            )
                        )
                );

                foreach (var parameter in parameterList.Parameters)
                {
                    if (parameter.Modifiers.Any(x => x.IsKind(SyntaxKind.OutKeyword)))
                        statements.Add
                        (
                            ExpressionStatement
                            (
                                AssignmentExpression
                                (
                                    SyntaxKind.SimpleAssignmentExpression, IdentifierName(parameter.Identifier.Text),
                                    DefaultExpression(parameter.Type)
                                )
                            )
                        );
                }
                
                if (generateReturn)
                    statements.Add(ReturnStatement(DefaultExpression(returnType)));
                
                StatementSyntax lastStatement = Block(statements);
                foreach (var possibleType in _possibleTypes)
                {
                    var name = $"{methodName}_SUB_{(uint) _context.GetHashCode()}_{ExtraMembers.Count}";

                    var m = TokenList
                    (
                        modifiers.Select
                            (
                                x => x.Kind() switch
                                {
                                    SyntaxKind.PublicKeyword => Token(SyntaxKind.PublicKeyword),
                                    SyntaxKind.PrivateKeyword => Token(SyntaxKind.PublicKeyword),
                                    SyntaxKind.InternalKeyword => Token(SyntaxKind.PublicKeyword),
                                    SyntaxKind.ProtectedKeyword => Token(SyntaxKind.PublicKeyword),
                                    _ => x
                                }
                            )
                            .Where(x => x.Kind() != SyntaxKind.OverrideKeyword)
                    );
                    var specialBody = (((ExpressionSyntax) new SpecializingRewriter
                        (possibleType, _remaps, _semanticModel, returnType, this).Visit(body))!);
                    if (generateExtraMethods)
                        ExtraMembers.Add
                        (
                            MethodDeclaration
                                    (IdentifierName(typeParam), name)
                                .WithExpressionBody(ArrowExpressionClause(specialBody))
                                .WithParameterList(parameterList)
                                .WithTypeParameterList(typeParameterList)
                                .WithReturnType(returnType)
                                .WithModifiers(m)
                                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                        );
                    lastStatement = IfStatement
                    (
                        BinaryExpression
                        (
                            SyntaxKind.EqualsExpression, TypeOfExpression(IdentifierName(typeParam)),
                            TypeOfExpression(possibleType)
                        ), toFinalStatement
                        (
                            generateExtraMethods ? InvocationExpression
                            (
                                IdentifierName(name), ArgumentList
                                (
                                    SeparatedList
                                    (
                                        parameterList.Parameters.Select
                                        (
                                            x => Argument
                                            (
                                                NameColon(x.Identifier.Text), x.Modifiers.FirstOrDefault
                                                (
                                                    x => x.Kind() switch
                                                    {
                                                        SyntaxKind.ReferenceKeyword => true,
                                                        SyntaxKind.OutKeyword => true,
                                                        SyntaxKind.InKeyword => true,
                                                        _ => false
                                                    }
                                                ), IdentifierName(x.Identifier)
                                            )
                                        )
                                    )
                                )
                            ) : specialBody
                        ), ElseClause(lastStatement)
                    );
                }

                return lastStatement;
            }

            public StatementSyntax VisitMethodBody
            (
                string methodName,
                TypeSyntax returnType,
                ParameterListSyntax parameterList,
                TypeParameterListSyntax? typeParameterList,
                SyntaxTokenList modifiers,
                BlockSyntax body,
                bool generateReturn,
                bool generateExtraMembers,
                bool useDirectThrows
            )
            {
                Func<ExpressionSyntax, StatementSyntax> toFinalStatement = generateReturn
                    ? (Func<ExpressionSyntax, StatementSyntax>) ReturnStatement
                    : ExpressionStatement;
                var statements = new List<StatementSyntax>();
                statements.Add
                (
                    !useDirectThrows
                        ? (StatementSyntax) ExpressionStatement
                        (
                            InvocationExpression
                            (
                                MemberAccessExpression
                                (
                                    SyntaxKind.SimpleMemberAccessExpression,
                                    GenericName
                                    (
                                        Identifier("Silk.NET.Maths.Scalar"),
                                        TypeArgumentList(SingletonSeparatedList((TypeSyntax) IdentifierName(typeParam)))
                                    ), IdentifierName("ThrowInvalidType")
                                ), ArgumentList()
                            )
                        )
                        : ThrowStatement
                        (
                            ObjectCreationExpression
                            (
                                IdentifierName("System.NotSupportedException"),
                                ArgumentList
                                (
                                    SingletonSeparatedList
                                    (
                                        Argument
                                        (
                                            LiteralExpression
                                            (
                                                SyntaxKind.StringLiteralExpression,
                                                Literal("This operation isn't supported for the current type.")
                                            )
                                        )
                                    )
                                ), null
                            )
                        )
                );

                foreach (var parameter in parameterList.Parameters)
                {
                    if (parameter.Modifiers.Any(x => x.IsKind(SyntaxKind.OutKeyword)))
                        statements.Add
                        (
                            ExpressionStatement
                            (
                                AssignmentExpression
                                (
                                    SyntaxKind.SimpleAssignmentExpression, IdentifierName(parameter.Identifier.Text),
                                    DefaultExpression(parameter.Type)
                                )
                            )
                        );
                }
                
                if (generateReturn)
                    statements.Add(ReturnStatement(DefaultExpression(returnType)));
                
                StatementSyntax lastStatement = Block(statements);
                foreach (var possibleType in _possibleTypes)
                {
                    var name = $"{methodName}_SUB_{(uint)_context.GetHashCode()}_{ExtraMembers.Count}";

                    var m = modifiers.Select
                        (
                            x => x.Kind() switch
                            {
                                SyntaxKind.PublicKeyword => Token(SyntaxKind.PrivateKeyword),
                                SyntaxKind.PrivateKeyword => Token(SyntaxKind.PrivateKeyword),
                                SyntaxKind.InternalKeyword => Token(SyntaxKind.PrivateKeyword),
                                SyntaxKind.ProtectedKeyword => Token(SyntaxKind.PrivateKeyword),
                                _ => x
                            }
                        )
                        .Where(x => x.Kind() != SyntaxKind.OverrideKeyword).ToArray();
                    
                    if (!m.Any(x => x.IsKind(SyntaxKind.PrivateKeyword)))
                        m = m.Append(Token(SyntaxKind.PrivateKeyword)).ToArray();

                    var specialBody = Block
                    (
                        ((StatementSyntax) new SpecializingRewriter
                            (possibleType, _remaps, _semanticModel, returnType, this).Visit(body))!
                    );
                    if (generateExtraMembers)
                        ExtraMembers.Add
                        (
                            MethodDeclaration
                                    (IdentifierName(typeParam), name)
                                .WithBody(specialBody)
                                .WithParameterList(parameterList)
                                .WithTypeParameterList(typeParameterList)
                                .WithReturnType(returnType)
                                .WithModifiers(TokenList(m))
                        );
                    lastStatement = IfStatement
                    (
                        BinaryExpression
                        (
                            SyntaxKind.EqualsExpression, TypeOfExpression(IdentifierName(typeParam)),
                            TypeOfExpression(possibleType)
                        ), generateExtraMembers
                            ? toFinalStatement
                            (
                                InvocationExpression
                                (
                                    IdentifierName(name), ArgumentList
                                    (
                                        SeparatedList
                                        (
                                            parameterList.Parameters.Select
                                            (
                                                x => Argument
                                                (
                                                    NameColon(x.Identifier.Text), x.Modifiers.FirstOrDefault
                                                    (
                                                        x => x.Kind() switch
                                                        {
                                                            SyntaxKind.ReferenceKeyword => true,
                                                            SyntaxKind.OutKeyword => true,
                                                            SyntaxKind.InKeyword => true,
                                                            _ => false
                                                        }
                                                    ), IdentifierName(x.Identifier)
                                                )
                                            )
                                        )
                                    )
                                )
                            )
                            : specialBody, ElseClause(lastStatement)
                    );
                }

                return Block(lastStatement).WithLeadingTrivia(SyntaxTrivia(SyntaxKind.MultiLineCommentTrivia, "/* Processed by specialization rewriter */"));
            }

            public override SyntaxNode? VisitConstructorDeclaration(ConstructorDeclarationSyntax original)
            {
                var node = original.Update
                (
                    VisitList(original.AttributeLists), VisitList(original.Modifiers), VisitToken(original.Identifier),
                    (ParameterListSyntax?) Visit(original.ParameterList) ??
                    throw new ArgumentNullException("parameterList"),
                    (ConstructorInitializerSyntax?) Visit(original.Initializer), original.Body, original.ExpressionBody, VisitToken(original.SemicolonToken)
                ); // base but do not visit Body/ExpressionBody

                Debug.Assert(_parentType is not null, nameof(_parentType) + " is null");
                
                var body = original.Body is not null
                    ? VisitMethodBody
                        (node.Identifier.Text, _parentType, node.ParameterList, null, node.Modifiers, original.Body!, false, false, true)
                    : VisitExpressionBody
                        (node.Identifier.Text, _parentType, node.ParameterList, null, node.Modifiers, original.ExpressionBody!.Expression, false, false, true);

                return node.WithBody(Block(body)).WithExpressionBody(null).WithSemicolonToken(default);
            }

            public override SyntaxNode? VisitPropertyDeclaration(PropertyDeclarationSyntax original)
            {
                var node = original.Update
                (
                    VisitList(original.AttributeLists), VisitList(original.Modifiers),
                    (TypeSyntax?) Visit(original.Type) ?? throw new ArgumentNullException("type"),
                    (ExplicitInterfaceSpecifierSyntax?) Visit(original.ExplicitInterfaceSpecifier),
                    VisitToken(original.Identifier), original.AccessorList,
                    (ArrowExpressionClauseSyntax?) Visit(original.ExpressionBody),
                    (EqualsValueClauseSyntax?) Visit(original.Initializer), VisitToken(original.SemicolonToken)
                ); // base but do not visit AccessorList
                Debug.Assert(_parentType is not null, nameof(_parentType) + " is null");

                return
                    (node.AccessorList is not null ? node.WithAccessorList
                    (
                        AccessorList
                        (
                            List
                            (
                                original.AccessorList!.Accessors.Select
                                (
                                    o =>
                                    {
                                        var x = o.Update
                                        (
                                            VisitList(o.AttributeLists), VisitList(o.Modifiers),
                                            VisitToken(o.Keyword), o.Body,
                                            o.ExpressionBody,
                                            VisitToken(o.SemicolonToken)
                                        ); // base but do not visit Body/ExpressionBody
                                        if (x is null)
                                            return x;
                                        
                                        var body = x.Body is not null
                                            ? VisitMethodBody
                                            (
                                                $"{node.Identifier.Text}_accessor_{x.Keyword.Text}", node.Type,
                                                ParameterList(), null, x.Modifiers, o.Body!, (_semanticModel.GetSymbolInfo(original.Type).Symbol as ITypeSymbol).SpecialType != SpecialType.System_Void, false, false
                                            )
                                            : VisitExpressionBody
                                            (
                                                $"{node.Identifier.Text}_accessor_{x.Keyword.Text}", node.Type,
                                                ParameterList(), null, x.Modifiers, o.ExpressionBody!.Expression, (_semanticModel.GetSymbolInfo(original.Type).Symbol as ITypeSymbol).SpecialType != SpecialType.System_Void, false, false
                                            );

                                        return x.WithBody(Block(body)).WithExpressionBody(null).WithSemicolonToken(default);
                                    }
                                )
                            )
                        )
                    ): node);
            }

            public override SyntaxNode? Visit(SyntaxNode? original)
            {
                var node = base.Visit(original);
                if (original is TypeSyntax s)
                {
                    var symbol = _semanticModel.GetSymbolInfo(s).Symbol;

                    if (symbol is ITypeSymbol ts)
                    {
                        bool foundData = false;
                        bool isStatic = false;
                        if (!foundData && s.Parent is MemberAccessExpressionSyntax mae && mae.Expression == original)
                        {
                            if (_semanticModel.GetOperation(mae) is IMemberReferenceOperation mro)
                            {
                                foundData = true;
                                isStatic = mro.Member.IsStatic;
                            }

                            if (!foundData && mae.Parent is InvocationExpressionSyntax ies && ies.Expression == mae)
                            {
                                if (_semanticModel.GetOperation(ies) is IInvocationOperation io)
                                {
                                    foundData = true;
                                    isStatic = io.TargetMethod.IsStatic;
                                }
                            }
                        }

                        if (_remaps.TryGetValue((ts, isStatic), out var n))
                            node = n;
                    }
                }

                return node;
            }
            
            public override SyntaxNode? VisitFieldDeclaration(FieldDeclarationSyntax original)
            {
                var node = (FieldDeclarationSyntax) base.VisitFieldDeclaration(original);
                if (node is null)
                    return node;
                
                var modifiers = node.Modifiers;
                modifiers = modifiers.TryRemove(x => x.IsKind(SyntaxKind.ConstKeyword));

                if (!modifiers.Any(x => x.IsKind(SyntaxKind.StaticKeyword)))
                    modifiers = modifiers.Add(Token(SyntaxKind.StaticKeyword));

                modifiers = modifiers.TryRemove(x => x.IsKind(SyntaxKind.ReadOnlyKeyword));

                if (node.Declaration.Variables.Count == 1 && node.Declaration.Variables[0].Initializer != null)
                {
                    var variable = node.Declaration.Variables[0];
                    return PropertyDeclaration
                    (
                        List<AttributeListSyntax>(), modifiers, node.Declaration.Type, null,
                        node.Declaration.Variables[0].Identifier,
                        AccessorList
                        (
                            SingletonList
                            (
                                AccessorDeclaration
                                (
                                    SyntaxKind.GetAccessorDeclaration, List<AttributeListSyntax>(), TokenList(),
                                    Block
                                    (
                                        VisitExpressionBody
                                        (
                                            "VAR_" + variable.Identifier.Text, node.Declaration.Type, ParameterList(),
                                            null, modifiers,
                                            original.Declaration.Variables[0].Initializer.Value,
                                            true, false, false
                                        )
                                    )
                                )
                            )
                        )
                    );
                }

                return node.WithModifiers(modifiers);
            }
        }
        
        private class SpecializingRewriter : CSharpSyntaxRewriter
        {
            private readonly TypeSyntax _specializedType;
            private readonly Dictionary<(ITypeSymbol, bool), TypeSyntax> _remaps;
            private readonly SemanticModel _semanticModel;
            private readonly TypeSyntax? _returnType;
            private readonly GeneralizingRewriter _parent;

            public SpecializingRewriter(TypeSyntax specializedType, Dictionary<(ITypeSymbol, bool), TypeSyntax> remaps, SemanticModel semanticModel, TypeSyntax? returnType, GeneralizingRewriter parent)
            {
                _specializedType = specializedType;
                _remaps = remaps;
                _semanticModel = semanticModel;
                _returnType = returnType;
                _parent = parent;
            }

            public override SyntaxNode? VisitLiteralExpression(LiteralExpressionSyntax original)
            {
                var node = (LiteralExpressionSyntax)base.VisitLiteralExpression(original);
                if (node is null)
                    return node;

                var operation = _semanticModel.GetOperation(original);
                if (operation is ILiteralOperation lo)
                {
                    if (lo.Type.SpecialType == SpecialType.System_Single)
                    {
                        return CheckedExpression(SyntaxKind.UncheckedExpression, ToGeneric
                        (
                            CastExpression
                            (
                                _specializedType,
                                original
                            )
                        ));
                    }
                }

                return node;
            }

            public override SyntaxNode? VisitReturnStatement(ReturnStatementSyntax node)
            {
                node = (ReturnStatementSyntax) base.VisitReturnStatement(node);
                if (node is null)
                    return node;
                // this should handle implicit conversions, by explicitly converting.
                return _returnType is null
                    ? node
                    : ReturnStatement
                    (
                        CastExpression
                        (
                            _returnType,
                            CastExpression
                            (
                                PredefinedType(Token(SyntaxKind.ObjectKeyword)),
                                ParenthesizedExpression(node.Expression)
                            )
                        )
                    );
            }

            public override SyntaxNode? Visit(SyntaxNode? original)
            {
                var node = base.Visit(original);
                if (original is TypeSyntax s)
                {
                    var symbol = _semanticModel.GetSymbolInfo(s).Symbol;

                    if (symbol is ITypeSymbol ts)
                    {
                        bool foundData = false;
                        bool isStatic = false;
                        if (!foundData && s.Parent is MemberAccessExpressionSyntax mae && mae.Expression == original)
                        {
                            if (_semanticModel.GetOperation(mae) is IMemberReferenceOperation mro)
                            {
                                foundData = true;
                                isStatic = mro.Member.IsStatic;
                            }

                            if (!foundData && mae.Parent is InvocationExpressionSyntax ies && ies.Expression == mae)
                            {
                                if (_semanticModel.GetOperation(ies) is IInvocationOperation io)
                                {
                                    foundData = true;
                                    isStatic = io.TargetMethod.IsStatic;
                                }
                            }
                        }

                        if (_remaps.TryGetValue((ts, isStatic), out var n))
                            node = n;
                    }
                }

                return node;
            }

            private static TypeSyntax SilkNetMathsScalar = GenericName
            (
                Identifier("Silk.NET.Maths.Scalar"),
                TypeArgumentList(SingletonSeparatedList((TypeSyntax) IdentifierName(typeParam)))
            );

            private static ExpressionSyntax AddMethod = MemberAccessExpression
                (SyntaxKind.SimpleMemberAccessExpression, SilkNetMathsScalar, IdentifierName("Add"));

            private static ExpressionSyntax SubtractMethod = MemberAccessExpression
                (SyntaxKind.SimpleMemberAccessExpression, SilkNetMathsScalar, IdentifierName("Subtract"));
            
            private static ExpressionSyntax MultiplyMethod = MemberAccessExpression
                (SyntaxKind.SimpleMemberAccessExpression, SilkNetMathsScalar, IdentifierName("Multiply"));
            
            private static ExpressionSyntax DivideMethod = MemberAccessExpression
                (SyntaxKind.SimpleMemberAccessExpression, SilkNetMathsScalar, IdentifierName("Divide"));

            private static ExpressionSyntax ModMethod = MemberAccessExpression
                (SyntaxKind.SimpleMemberAccessExpression, SilkNetMathsScalar, IdentifierName("Mod"));

            private static ExpressionSyntax SmallerMethod = MemberAccessExpression
                (SyntaxKind.SimpleMemberAccessExpression, SilkNetMathsScalar, IdentifierName("Smaller"));
            
            private static ExpressionSyntax LargerMethod = MemberAccessExpression
                (SyntaxKind.SimpleMemberAccessExpression, SilkNetMathsScalar, IdentifierName("Larger"));
            
            private static ExpressionSyntax SmallerEqualsMethod = MemberAccessExpression
                (SyntaxKind.SimpleMemberAccessExpression, SilkNetMathsScalar, IdentifierName("SmallerEquals"));
            
            private static ExpressionSyntax LargerEqualsMethod = MemberAccessExpression
                (SyntaxKind.SimpleMemberAccessExpression, SilkNetMathsScalar, IdentifierName("LargerEquals"));
            
            private static ExpressionSyntax EqualMethod = MemberAccessExpression
                (SyntaxKind.SimpleMemberAccessExpression, SilkNetMathsScalar, IdentifierName("Equal"));

            private static ExpressionSyntax NotEqualMethod = MemberAccessExpression
                (SyntaxKind.SimpleMemberAccessExpression, SilkNetMathsScalar, IdentifierName("NotEqual"));

            public override SyntaxNode? VisitBinaryExpression(BinaryExpressionSyntax original)
            {
                var node = (BinaryExpressionSyntax)base.VisitBinaryExpression(original);
                if (node is null)
                    return node;
                
                // check whether the left/right are actually operating on `TNumeric`/`float`. We don't want to replace custom operators.
                var leftInfo = _semanticModel.GetTypeInfo
                    (original.Left);
                var rightInfo = _semanticModel.GetTypeInfo
                    (original.Right);

                var leftType = leftInfo.ConvertedType ?? leftInfo.Type;
                var rightType = rightInfo.ConvertedType ?? rightInfo.Type;
                var floatType = _semanticModel.Compilation.GetSpecialType(SpecialType.System_Single);

                var b = (SymbolEqualityComparer.Default.Equals
                        (leftType, floatType) && SymbolEqualityComparer.Default.Equals
                        (rightType, floatType)) // both are float
                    /*|| // OR
                    (((leftType?.TypeKind == TypeKind.TypeParameter && // left if a type param
                             (leftType as ITypeParameterSymbol)?.Name == typeParam) // with name "<typeParam>"
                         &&    // AND
                            (rightType?.TypeKind == TypeKind.TypeParameter && // right is a type param
                             (rightType as ITypeParameterSymbol)?.Name == typeParam))) // with name "<typeParam>"
                             
                             I DONT THINK THIS IS NEEDED??
                             
                             */
                    ;
                if (!b)
                    return node;
                
                var (method, boolMethod) = node.OperatorToken.Text switch
                {
                    "+" => (AddMethod, false),
                    "-" => (SubtractMethod, false),
                    "*" => (MultiplyMethod, false),
                    "/" => (DivideMethod, false),
                    "%" => (ModMethod, false),
                    "<" => (SmallerMethod, true),
                    ">" => (LargerMethod, true),
                    "<=" => (SmallerEqualsMethod, true),
                    ">=" => (LargerEqualsMethod, true),
                    "==" => (EqualMethod, true),
                    "!=" => (NotEqualMethod, true),
                    _ => (null, default)
                };

                if (method is null)
                    return node;

                var expr = InvocationExpression
                (
                    method, ArgumentList
                    (
                        SeparatedList
                        (
                            new[]
                            {
                                Argument(FromGeneric(node.Left)), Argument(FromGeneric(node.Right))
                            }
                        )
                    )
                );
                
                return boolMethod ? expr : ToGeneric(expr);
            }
            
            private static ExpressionSyntax NegateMethod = MemberAccessExpression
                (SyntaxKind.SimpleMemberAccessExpression, SilkNetMathsScalar, IdentifierName("Negate"));
            
            private static ExpressionSyntax UnaryPlusMethod = MemberAccessExpression
                (SyntaxKind.SimpleMemberAccessExpression, SilkNetMathsScalar, IdentifierName("UnaryPlus"));
            
            public override SyntaxNode? VisitPrefixUnaryExpression(PrefixUnaryExpressionSyntax original)
            {
                var node = (PrefixUnaryExpressionSyntax) base.VisitPrefixUnaryExpression(original);
                if (node is null)
                    return node;

                TypeInfo info;
                // check whether we are actually operating on `TNumeric`/`float`. We don't want to replace custom operators.
                info = _semanticModel.GetTypeInfo(original.Operand);

                var type = info.ConvertedType ?? info.Type;
                var floatType = _semanticModel.Compilation.GetSpecialType(SpecialType.System_Single);

                var b = SymbolEqualityComparer.Default.Equals
                        (type, floatType)
                    /*||
                    (((leftType?.TypeKind == TypeKind.TypeParameter &&
                             (leftType as ITypeParameterSymbol)?.Name == typeParam)
                                                          
                             I DONT THINK THIS IS NEEDED??
                             
                             */
                    ;
                if (!b)
                    return node;
                
                var method = node.OperatorToken.Text switch
                {
                    "-" => NegateMethod,
                    "+" => UnaryPlusMethod,
                    _ => null
                };

                if (method is null)
                    return node;
                
                return ToGeneric(
                    InvocationExpression
                    (
                        method, ArgumentList
                        (
                            SeparatedList
                            (
                                new[]
                                {
                                    Argument(FromGeneric(node.Operand))
                                }
                            )
                        )
                    )
                );
            }

            private ExpressionSyntax FromGeneric(ExpressionSyntax syntax)
                => ToGeneric(CastExpression
                (
                    _specializedType, CastExpression(PredefinedType(Token(SyntaxKind.ObjectKeyword)), syntax)
                ));

            public override SyntaxNode? VisitLocalFunctionStatement(LocalFunctionStatementSyntax original)
            {
                var node = original.Update
                (
                    VisitList(original.AttributeLists), VisitList(original.Modifiers),
                    (TypeSyntax?) Visit(original.ReturnType) ?? throw new ArgumentNullException("returnType"),
                    VisitToken(original.Identifier), (TypeParameterListSyntax?) Visit(original.TypeParameterList),
                    (ParameterListSyntax?) Visit(original.ParameterList) ??
                    throw new ArgumentNullException("parameterList"), VisitList(original.ConstraintClauses),
                    original.Body, original.ExpressionBody,
                    VisitToken(original.SemicolonToken)
                ); // base but do not visit Body/ExpressionBody

                // this function essentially delegates to the `_parent` Generializer, which then delegates to another Specializer, before returning to this one
                
                var body = original.Body is not null
                    ? _parent.VisitMethodBody
                    (
                        node.Identifier.Text, node.ReturnType, node.ParameterList, node.TypeParameterList,
                        node.Modifiers, original.Body!, (_semanticModel.GetSymbolInfo(original.ReturnType).Symbol as ITypeSymbol).SpecialType != SpecialType.System_Void, true, false
                    )
                    : _parent.VisitExpressionBody
                    (
                        node.Identifier.Text, node.ReturnType, node.ParameterList, node.TypeParameterList,
                        node.Modifiers, original.ExpressionBody!.Expression, (_semanticModel.GetSymbolInfo(original.ReturnType).Symbol as ITypeSymbol).SpecialType != SpecialType.System_Void, true, false
                    );

                return node.WithBody(Block(body)).WithExpressionBody(null).WithSemicolonToken(default);
            }
        }
        
        private static ExpressionSyntax ToGeneric(ExpressionSyntax syntax)
            => CastExpression
            (
                IdentifierName(typeParam), CastExpression(PredefinedType(Token(SyntaxKind.ObjectKeyword)), syntax)
            );
        
#endif
        const string typeParam = "TNumeric";

        public class SyntaxReceiver : ISyntaxReceiver
        {
            public List<ClassDeclarationSyntax> Classes = new List<ClassDeclarationSyntax>();
            public List<StructDeclarationSyntax> Structs = new List<StructDeclarationSyntax>();
            public List<MethodDeclarationSyntax> Methods = new List<MethodDeclarationSyntax>();

            public void OnVisitSyntaxNode(SyntaxNode syntaxNode)
            {
                switch (syntaxNode)
                {
                    case ClassDeclarationSyntax cds:
                        Classes.Add(cds);
                        break;
                    case StructDeclarationSyntax sds:
                        Structs.Add(sds);
                        break;
                    case MethodDeclarationSyntax mds:
                        Methods.Add(mds);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
