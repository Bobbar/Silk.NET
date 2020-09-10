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
    [NativeName("Name", "D3D12_GPU_VIRTUAL_ADDRESS_AND_STRIDE")]
    public unsafe partial struct GpuVirtualAddressAndStride
    {
        public GpuVirtualAddressAndStride
        (
            ulong startAddress = default,
            ulong strideInBytes = default
        )
        {
            StartAddress = startAddress;
            StrideInBytes = strideInBytes;
        }


        [NativeName("Type", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Type.Name", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Name", "StartAddress")]
        public ulong StartAddress;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "StrideInBytes")]
        public ulong StrideInBytes;
    }
}
