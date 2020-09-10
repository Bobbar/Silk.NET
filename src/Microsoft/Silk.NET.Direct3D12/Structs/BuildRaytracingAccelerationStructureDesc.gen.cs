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
    [NativeName("Name", "D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_DESC")]
    public unsafe partial struct BuildRaytracingAccelerationStructureDesc
    {
        public BuildRaytracingAccelerationStructureDesc
        (
            ulong destAccelerationStructureData = default,
            BuildRaytracingAccelerationStructureInputs inputs = default,
            ulong sourceAccelerationStructureData = default,
            ulong scratchAccelerationStructureData = default
        )
        {
            DestAccelerationStructureData = destAccelerationStructureData;
            Inputs = inputs;
            SourceAccelerationStructureData = sourceAccelerationStructureData;
            ScratchAccelerationStructureData = scratchAccelerationStructureData;
        }


        [NativeName("Type", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Type.Name", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Name", "DestAccelerationStructureData")]
        public ulong DestAccelerationStructureData;

        [NativeName("Type", "D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS")]
        [NativeName("Type.Name", "D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS")]
        [NativeName("Name", "Inputs")]
        public BuildRaytracingAccelerationStructureInputs Inputs;

        [NativeName("Type", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Type.Name", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Name", "SourceAccelerationStructureData")]
        public ulong SourceAccelerationStructureData;

        [NativeName("Type", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Type.Name", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Name", "ScratchAccelerationStructureData")]
        public ulong ScratchAccelerationStructureData;
    }
}
