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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_AUTHENTICATED_QUERY_ACESSIBILITY_OUTPUT")]
    public unsafe partial struct AuthenticatedQueryAcessibilityOutput
    {
        public AuthenticatedQueryAcessibilityOutput
        (
            AuthenticatedQueryOutput output = default,
            BusType busType = default,
            int accessibleInContiguousBlocks = default,
            int accessibleInNonContiguousBlocks = default
        )
        {
            Output = output;
            BusType = busType;
            AccessibleInContiguousBlocks = accessibleInContiguousBlocks;
            AccessibleInNonContiguousBlocks = accessibleInNonContiguousBlocks;
        }


        [NativeName("Type", "D3D11_AUTHENTICATED_QUERY_OUTPUT")]
        [NativeName("Type.Name", "D3D11_AUTHENTICATED_QUERY_OUTPUT")]
        [NativeName("Name", "Output")]
        public AuthenticatedQueryOutput Output;

        [NativeName("Type", "D3D11_BUS_TYPE")]
        [NativeName("Type.Name", "D3D11_BUS_TYPE")]
        [NativeName("Name", "BusType")]
        public BusType BusType;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "AccessibleInContiguousBlocks")]
        public int AccessibleInContiguousBlocks;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "AccessibleInNonContiguousBlocks")]
        public int AccessibleInNonContiguousBlocks;
    }
}
