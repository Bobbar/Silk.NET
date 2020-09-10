// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_AUTO_BREADCRUMB_NODE1")]
    public unsafe partial struct AutoBreadcrumbNode1
    {
        public AutoBreadcrumbNode1
        (
            byte* pCommandListDebugNameA = default,
            char* pCommandListDebugNameW = default,
            byte* pCommandQueueDebugNameA = default,
            char* pCommandQueueDebugNameW = default,
            ID3D12GraphicsCommandList* pCommandList = default,
            ID3D12CommandQueue* pCommandQueue = default,
            uint breadcrumbCount = default,
            uint* pLastBreadcrumbValue = default,
            AutoBreadcrumbOp* pCommandHistory = default,
            AutoBreadcrumbNode1* pNext = default,
            uint breadcrumbContextsCount = default,
            DredBreadcrumbContext* pBreadcrumbContexts = default
        )
        {
            PCommandListDebugNameA = pCommandListDebugNameA;
            PCommandListDebugNameW = pCommandListDebugNameW;
            PCommandQueueDebugNameA = pCommandQueueDebugNameA;
            PCommandQueueDebugNameW = pCommandQueueDebugNameW;
            PCommandList = pCommandList;
            PCommandQueue = pCommandQueue;
            BreadcrumbCount = breadcrumbCount;
            PLastBreadcrumbValue = pLastBreadcrumbValue;
            PCommandHistory = pCommandHistory;
            PNext = pNext;
            BreadcrumbContextsCount = breadcrumbContextsCount;
            PBreadcrumbContexts = pBreadcrumbContexts;
        }


        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "pCommandListDebugNameA")]
        public byte* PCommandListDebugNameA;

        [NativeName("Type", "const wchar_t *")]
        [NativeName("Type.Name", "const wchar_t *")]
        [NativeName("Name", "pCommandListDebugNameW")]
        public char* PCommandListDebugNameW;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "pCommandQueueDebugNameA")]
        public byte* PCommandQueueDebugNameA;

        [NativeName("Type", "const wchar_t *")]
        [NativeName("Type.Name", "const wchar_t *")]
        [NativeName("Name", "pCommandQueueDebugNameW")]
        public char* PCommandQueueDebugNameW;

        [NativeName("Type", "ID3D12GraphicsCommandList *")]
        [NativeName("Type.Name", "ID3D12GraphicsCommandList *")]
        [NativeName("Name", "pCommandList")]
        public ID3D12GraphicsCommandList* PCommandList;

        [NativeName("Type", "ID3D12CommandQueue *")]
        [NativeName("Type.Name", "ID3D12CommandQueue *")]
        [NativeName("Name", "pCommandQueue")]
        public ID3D12CommandQueue* PCommandQueue;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "BreadcrumbCount")]
        public uint BreadcrumbCount;

        [NativeName("Type", "const UINT *")]
        [NativeName("Type.Name", "const UINT *")]
        [NativeName("Name", "pLastBreadcrumbValue")]
        public uint* PLastBreadcrumbValue;

        [NativeName("Type", "const D3D12_AUTO_BREADCRUMB_OP *")]
        [NativeName("Type.Name", "const D3D12_AUTO_BREADCRUMB_OP *")]
        [NativeName("Name", "pCommandHistory")]
        public AutoBreadcrumbOp* PCommandHistory;

        [NativeName("Type", "const struct D3D12_AUTO_BREADCRUMB_NODE1 *")]
        [NativeName("Type.Name", "const struct D3D12_AUTO_BREADCRUMB_NODE1 *")]
        [NativeName("Name", "pNext")]
        public AutoBreadcrumbNode1* PNext;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "BreadcrumbContextsCount")]
        public uint BreadcrumbContextsCount;

        [NativeName("Type", "D3D12_DRED_BREADCRUMB_CONTEXT *")]
        [NativeName("Type.Name", "D3D12_DRED_BREADCRUMB_CONTEXT *")]
        [NativeName("Name", "pBreadcrumbContexts")]
        public DredBreadcrumbContext* PBreadcrumbContexts;
    }
}
