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
    [NativeName("Name", "D3D12_RENDER_PASS_RENDER_TARGET_DESC")]
    public unsafe partial struct RenderPassRenderTargetDesc
    {
        public RenderPassRenderTargetDesc
        (
            CpuDescriptorHandle cpuDescriptor = default,
            RenderPassBeginningAccess beginningAccess = default,
            RenderPassEndingAccess endingAccess = default
        )
        {
            CpuDescriptor = cpuDescriptor;
            BeginningAccess = beginningAccess;
            EndingAccess = endingAccess;
        }


        [NativeName("Type", "D3D12_CPU_DESCRIPTOR_HANDLE")]
        [NativeName("Type.Name", "D3D12_CPU_DESCRIPTOR_HANDLE")]
        [NativeName("Name", "cpuDescriptor")]
        public CpuDescriptorHandle CpuDescriptor;

        [NativeName("Type", "D3D12_RENDER_PASS_BEGINNING_ACCESS")]
        [NativeName("Type.Name", "D3D12_RENDER_PASS_BEGINNING_ACCESS")]
        [NativeName("Name", "BeginningAccess")]
        public RenderPassBeginningAccess BeginningAccess;

        [NativeName("Type", "D3D12_RENDER_PASS_ENDING_ACCESS")]
        [NativeName("Type.Name", "D3D12_RENDER_PASS_ENDING_ACCESS")]
        [NativeName("Name", "EndingAccess")]
        public RenderPassEndingAccess EndingAccess;
    }
}
