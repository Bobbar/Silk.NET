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
    [NativeName("Name", "D3D12_HEAP_PROPERTIES")]
    public unsafe partial struct HeapProperties
    {
        public HeapProperties
        (
            HeapType type = default,
            CpuPageProperty cPUPageProperty = default,
            MemoryPool memoryPoolPreference = default,
            uint creationNodeMask = default,
            uint visibleNodeMask = default
        )
        {
            Type = type;
            CPUPageProperty = cPUPageProperty;
            MemoryPoolPreference = memoryPoolPreference;
            CreationNodeMask = creationNodeMask;
            VisibleNodeMask = visibleNodeMask;
        }


        [NativeName("Type", "D3D12_HEAP_TYPE")]
        [NativeName("Type.Name", "D3D12_HEAP_TYPE")]
        [NativeName("Name", "Type")]
        public HeapType Type;

        [NativeName("Type", "D3D12_CPU_PAGE_PROPERTY")]
        [NativeName("Type.Name", "D3D12_CPU_PAGE_PROPERTY")]
        [NativeName("Name", "CPUPageProperty")]
        public CpuPageProperty CPUPageProperty;

        [NativeName("Type", "D3D12_MEMORY_POOL")]
        [NativeName("Type.Name", "D3D12_MEMORY_POOL")]
        [NativeName("Name", "MemoryPoolPreference")]
        public MemoryPool MemoryPoolPreference;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "CreationNodeMask")]
        public uint CreationNodeMask;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "VisibleNodeMask")]
        public uint VisibleNodeMask;
    }
}
