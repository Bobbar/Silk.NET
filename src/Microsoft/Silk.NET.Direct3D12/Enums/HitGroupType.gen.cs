// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_HIT_GROUP_TYPE")]
    public enum HitGroupType
    {
        [NativeName("Name", "D3D12_HIT_GROUP_TYPE_TRIANGLES")]
        HitGroupTypeTriangles = 0x0,
        [NativeName("Name", "D3D12_HIT_GROUP_TYPE_PROCEDURAL_PRIMITIVE")]
        HitGroupTypeProceduralPrimitive = 0x1,
    }
}
