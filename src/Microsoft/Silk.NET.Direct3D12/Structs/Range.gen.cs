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
    [NativeName("Name", "D3D12_RANGE")]
    public unsafe partial struct Range
    {
        public Range
        (
            uint begin = default,
            uint end = default
        )
        {
            Begin = begin;
            End = end;
        }


        [NativeName("Type", "SIZE_T")]
        [NativeName("Type.Name", "SIZE_T")]
        [NativeName("Name", "Begin")]
        public uint Begin;

        [NativeName("Type", "SIZE_T")]
        [NativeName("Type.Name", "SIZE_T")]
        [NativeName("Name", "End")]
        public uint End;
    }
}
