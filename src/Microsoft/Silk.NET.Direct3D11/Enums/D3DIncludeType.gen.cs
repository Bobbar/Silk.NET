// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "_D3D_INCLUDE_TYPE")]
    public enum D3DIncludeType
    {
        [NativeName("Name", "D3D_INCLUDE_LOCAL")]
        D3DIncludeLocal = 0x0,
        [NativeName("Name", "D3D_INCLUDE_SYSTEM")]
        D3DIncludeSystem = 0x1,
        [NativeName("Name", "D3D10_INCLUDE_LOCAL")]
        D3D10IncludeLocal = 0x0,
        [NativeName("Name", "D3D10_INCLUDE_SYSTEM")]
        D3D10IncludeSystem = 0x1,
        [NativeName("Name", "D3D_INCLUDE_FORCE_DWORD")]
        D3DIncludeForceDword = 0x7FFFFFFF,
    }
}
