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
    [NativeName("Name", "D3D12_BLEND_DESC")]
    public unsafe partial struct BlendDesc
    {
        public BlendDesc
        (
            int alphaToCoverageEnable = default,
            int independentBlendEnable = default
        )
        {
            AlphaToCoverageEnable = alphaToCoverageEnable;
            IndependentBlendEnable = independentBlendEnable;
           RenderTarget_0 = default;
           RenderTarget_1 = default;
           RenderTarget_2 = default;
           RenderTarget_3 = default;
           RenderTarget_4 = default;
           RenderTarget_5 = default;
           RenderTarget_6 = default;
           RenderTarget_7 = default;
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "AlphaToCoverageEnable")]
        public int AlphaToCoverageEnable;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "IndependentBlendEnable")]
        public int IndependentBlendEnable;
        
        [NativeName("Type", "D3D12_RENDER_TARGET_BLEND_DESC [8]")]
        [NativeName("Type.Name", "D3D12_RENDER_TARGET_BLEND_DESC [8]")]
        [NativeName("Name", "RenderTarget")]
        public RenderTargetBlendDesc RenderTarget_0;
        
        [NativeName("Type", "D3D12_RENDER_TARGET_BLEND_DESC [8]")]
        [NativeName("Type.Name", "D3D12_RENDER_TARGET_BLEND_DESC [8]")]
        [NativeName("Name", "RenderTarget")]
        public RenderTargetBlendDesc RenderTarget_1;
        
        [NativeName("Type", "D3D12_RENDER_TARGET_BLEND_DESC [8]")]
        [NativeName("Type.Name", "D3D12_RENDER_TARGET_BLEND_DESC [8]")]
        [NativeName("Name", "RenderTarget")]
        public RenderTargetBlendDesc RenderTarget_2;
        
        [NativeName("Type", "D3D12_RENDER_TARGET_BLEND_DESC [8]")]
        [NativeName("Type.Name", "D3D12_RENDER_TARGET_BLEND_DESC [8]")]
        [NativeName("Name", "RenderTarget")]
        public RenderTargetBlendDesc RenderTarget_3;
        
        [NativeName("Type", "D3D12_RENDER_TARGET_BLEND_DESC [8]")]
        [NativeName("Type.Name", "D3D12_RENDER_TARGET_BLEND_DESC [8]")]
        [NativeName("Name", "RenderTarget")]
        public RenderTargetBlendDesc RenderTarget_4;
        
        [NativeName("Type", "D3D12_RENDER_TARGET_BLEND_DESC [8]")]
        [NativeName("Type.Name", "D3D12_RENDER_TARGET_BLEND_DESC [8]")]
        [NativeName("Name", "RenderTarget")]
        public RenderTargetBlendDesc RenderTarget_5;
        
        [NativeName("Type", "D3D12_RENDER_TARGET_BLEND_DESC [8]")]
        [NativeName("Type.Name", "D3D12_RENDER_TARGET_BLEND_DESC [8]")]
        [NativeName("Name", "RenderTarget")]
        public RenderTargetBlendDesc RenderTarget_6;
        
        [NativeName("Type", "D3D12_RENDER_TARGET_BLEND_DESC [8]")]
        [NativeName("Type.Name", "D3D12_RENDER_TARGET_BLEND_DESC [8]")]
        [NativeName("Name", "RenderTarget")]
        public RenderTargetBlendDesc RenderTarget_7;
    }
}
