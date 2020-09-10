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
    [NativeName("Name", "D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC")]
    public unsafe partial struct VideoProcessOutputStreamDesc
    {
        public VideoProcessOutputStreamDesc
        (
            Silk.NET.DXGI.Format format = default,
            Silk.NET.DXGI.ColorSpaceType colorSpace = default,
            VideoProcessAlphaFillMode alphaFillMode = default,
            uint alphaFillModeSourceStreamIndex = default,
            Silk.NET.DXGI.Rational frameRate = default,
            int enableStereo = default
        )
        {
            Format = format;
            ColorSpace = colorSpace;
            AlphaFillMode = alphaFillMode;
            AlphaFillModeSourceStreamIndex = alphaFillModeSourceStreamIndex;
            FrameRate = frameRate;
            EnableStereo = enableStereo;
        }


        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "Format")]
        public Silk.NET.DXGI.Format Format;

        [NativeName("Type", "DXGI_COLOR_SPACE_TYPE")]
        [NativeName("Type.Name", "DXGI_COLOR_SPACE_TYPE")]
        [NativeName("Name", "ColorSpace")]
        public Silk.NET.DXGI.ColorSpaceType ColorSpace;

        [NativeName("Type", "D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE")]
        [NativeName("Name", "AlphaFillMode")]
        public VideoProcessAlphaFillMode AlphaFillMode;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "AlphaFillModeSourceStreamIndex")]
        public uint AlphaFillModeSourceStreamIndex;
        [NativeName("Type", "FLOAT [4]")]
        [NativeName("Type.Name", "FLOAT [4]")]
        [NativeName("Name", "BackgroundColor")]
        public fixed float BackgroundColor[4];

        [NativeName("Type", "DXGI_RATIONAL")]
        [NativeName("Type.Name", "DXGI_RATIONAL")]
        [NativeName("Name", "FrameRate")]
        public Silk.NET.DXGI.Rational FrameRate;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "EnableStereo")]
        public int EnableStereo;
    }
}
