// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_ROOT_DESCRIPTOR_FLAGS")]
    public enum RootDescriptorFlags
    {
        [NativeName("Name", "D3D12_ROOT_DESCRIPTOR_FLAG_NONE")]
        RootDescriptorFlagNone = 0x0,
        [NativeName("Name", "D3D12_ROOT_DESCRIPTOR_FLAG_DATA_VOLATILE")]
        RootDescriptorFlagDataVolatile = 0x2,
        [NativeName("Name", "D3D12_ROOT_DESCRIPTOR_FLAG_DATA_STATIC_WHILE_SET_AT_EXECUTE")]
        RootDescriptorFlagDataStaticWhileSetATExecute = 0x4,
        [NativeName("Name", "D3D12_ROOT_DESCRIPTOR_FLAG_DATA_STATIC")]
        RootDescriptorFlagDataStatic = 0x8,
    }
}
