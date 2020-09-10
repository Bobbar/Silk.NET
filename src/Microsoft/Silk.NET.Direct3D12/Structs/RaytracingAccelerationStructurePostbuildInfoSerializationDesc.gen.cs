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
    [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_SERIALIZATION_DESC")]
    public unsafe partial struct RaytracingAccelerationStructurePostbuildInfoSerializationDesc
    {
        public RaytracingAccelerationStructurePostbuildInfoSerializationDesc
        (
            ulong serializedSizeInBytes = default,
            ulong numBottomLevelAccelerationStructurePointers = default
        )
        {
            SerializedSizeInBytes = serializedSizeInBytes;
            NumBottomLevelAccelerationStructurePointers = numBottomLevelAccelerationStructurePointers;
        }


        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "SerializedSizeInBytes")]
        public ulong SerializedSizeInBytes;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "NumBottomLevelAccelerationStructurePointers")]
        public ulong NumBottomLevelAccelerationStructurePointers;
    }
}
