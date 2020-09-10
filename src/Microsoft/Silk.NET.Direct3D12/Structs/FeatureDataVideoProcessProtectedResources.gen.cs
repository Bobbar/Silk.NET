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
    [NativeName("Name", "D3D12_FEATURE_DATA_VIDEO_PROCESS_PROTECTED_RESOURCES")]
    public unsafe partial struct FeatureDataVideoProcessProtectedResources
    {
        public FeatureDataVideoProcessProtectedResources
        (
            uint nodeIndex = default,
            VideoProtectedResourceSupportFlags supportFlags = default
        )
        {
            NodeIndex = nodeIndex;
            SupportFlags = supportFlags;
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NodeIndex")]
        public uint NodeIndex;

        [NativeName("Type", "D3D12_VIDEO_PROTECTED_RESOURCE_SUPPORT_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROTECTED_RESOURCE_SUPPORT_FLAGS")]
        [NativeName("Name", "SupportFlags")]
        public VideoProtectedResourceSupportFlags SupportFlags;
    }
}
