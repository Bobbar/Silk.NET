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
    [NativeName("Name", "D3D12_VIDEO_MOTION_ESTIMATOR_INPUT")]
    public unsafe partial struct VideoMotionEstimatorInput
    {
        public VideoMotionEstimatorInput
        (
            ID3D12Resource* pInputTexture2D = default,
            uint inputSubresourceIndex = default,
            ID3D12Resource* pReferenceTexture2D = default,
            uint referenceSubresourceIndex = default,
            ID3D12VideoMotionVectorHeap* pHintMotionVectorHeap = default
        )
        {
            PInputTexture2D = pInputTexture2D;
            InputSubresourceIndex = inputSubresourceIndex;
            PReferenceTexture2D = pReferenceTexture2D;
            ReferenceSubresourceIndex = referenceSubresourceIndex;
            PHintMotionVectorHeap = pHintMotionVectorHeap;
        }


        [NativeName("Type", "ID3D12Resource *")]
        [NativeName("Type.Name", "ID3D12Resource *")]
        [NativeName("Name", "pInputTexture2D")]
        public ID3D12Resource* PInputTexture2D;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "InputSubresourceIndex")]
        public uint InputSubresourceIndex;

        [NativeName("Type", "ID3D12Resource *")]
        [NativeName("Type.Name", "ID3D12Resource *")]
        [NativeName("Name", "pReferenceTexture2D")]
        public ID3D12Resource* PReferenceTexture2D;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ReferenceSubresourceIndex")]
        public uint ReferenceSubresourceIndex;

        [NativeName("Type", "ID3D12VideoMotionVectorHeap *")]
        [NativeName("Type.Name", "ID3D12VideoMotionVectorHeap *")]
        [NativeName("Name", "pHintMotionVectorHeap")]
        public ID3D12VideoMotionVectorHeap* PHintMotionVectorHeap;
    }
}
