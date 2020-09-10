// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_BUFFER_UAV_FLAGS")]
    public enum BufferUavFlags
    {
        [NativeName("Name", "D3D12_BUFFER_UAV_FLAG_NONE")]
        BufferUavFlagNone = 0x0,
        [NativeName("Name", "D3D12_BUFFER_UAV_FLAG_RAW")]
        BufferUavFlagRaw = 0x1,
    }
}
