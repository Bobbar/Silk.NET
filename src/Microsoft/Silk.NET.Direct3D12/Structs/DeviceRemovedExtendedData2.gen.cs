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
    [NativeName("Name", "D3D12_DEVICE_REMOVED_EXTENDED_DATA2")]
    public unsafe partial struct DeviceRemovedExtendedData2
    {
        public DeviceRemovedExtendedData2
        (
            int deviceRemovedReason = default,
            DredAutoBreadcrumbsOutput1 autoBreadcrumbsOutput = default,
            DredPageFaultOutput1 pageFaultOutput = default
        )
        {
            DeviceRemovedReason = deviceRemovedReason;
            AutoBreadcrumbsOutput = autoBreadcrumbsOutput;
            PageFaultOutput = pageFaultOutput;
        }


        [NativeName("Type", "HRESULT")]
        [NativeName("Type.Name", "HRESULT")]
        [NativeName("Name", "DeviceRemovedReason")]
        public int DeviceRemovedReason;

        [NativeName("Type", "D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT1")]
        [NativeName("Type.Name", "D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT1")]
        [NativeName("Name", "AutoBreadcrumbsOutput")]
        public DredAutoBreadcrumbsOutput1 AutoBreadcrumbsOutput;

        [NativeName("Type", "D3D12_DRED_PAGE_FAULT_OUTPUT1")]
        [NativeName("Type.Name", "D3D12_DRED_PAGE_FAULT_OUTPUT1")]
        [NativeName("Name", "PageFaultOutput")]
        public DredPageFaultOutput1 PageFaultOutput;
    }
}
