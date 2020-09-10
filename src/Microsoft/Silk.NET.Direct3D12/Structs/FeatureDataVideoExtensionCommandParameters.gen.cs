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
    [NativeName("Name", "D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETERS")]
    public unsafe partial struct FeatureDataVideoExtensionCommandParameters
    {
        public FeatureDataVideoExtensionCommandParameters
        (
            Guid commandId = default,
            VideoExtensionCommandParameterStage stage = default,
            uint parameterCount = default,
            VideoExtensionCommandParameterInfo* pParameterInfos = default
        )
        {
            CommandId = commandId;
            Stage = stage;
            ParameterCount = parameterCount;
            PParameterInfos = pParameterInfos;
        }


        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "CommandId")]
        public Guid CommandId;

        [NativeName("Type", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE")]
        [NativeName("Type.Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE")]
        [NativeName("Name", "Stage")]
        public VideoExtensionCommandParameterStage Stage;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ParameterCount")]
        public uint ParameterCount;

        [NativeName("Type", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_INFO *")]
        [NativeName("Type.Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_INFO *")]
        [NativeName("Name", "pParameterInfos")]
        public VideoExtensionCommandParameterInfo* PParameterInfos;
    }
}
