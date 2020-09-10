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
    [NativeName("Name", "ID3D12GraphicsCommandList")]
    public unsafe partial struct ID3D12GraphicsCommandList
    {
        public ID3D12GraphicsCommandList
        (
            void** lpVtbl = default
        )
        {
            LpVtbl = lpVtbl;
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12GraphicsCommandList*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<ID3D12GraphicsCommandList*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D12GraphicsCommandList*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<ID3D12GraphicsCommandList*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D12GraphicsCommandList*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D12GraphicsCommandList*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12GraphicsCommandList*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D12GraphicsCommandList*, Guid*, uint*, T0*, int>)LpVtbl[3])(@this, guid, pDataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* guid, ref uint pDataSize, void* pData)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                int ret = default;
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* cdecl<ID3D12GraphicsCommandList*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSizePtr, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                int ret = default;
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D12GraphicsCommandList*, Guid*, uint*, T0*, int>)LpVtbl[3])(@this, guid, pDataSizePtr, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid guid, uint* pDataSize, void* pData)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    ret = ((delegate* cdecl<ID3D12GraphicsCommandList*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D12GraphicsCommandList*, Guid*, uint*, T0*, int>)LpVtbl[3])(@this, guidPtr, pDataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid guid, ref uint pDataSize, void* pData)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        ret = ((delegate* cdecl<ID3D12GraphicsCommandList*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSizePtr, pData);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetPrivateData<T0>(ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        fixed (T0* pDataPtr = &pData)
                        {
                            ret = ((delegate* cdecl<ID3D12GraphicsCommandList*, Guid*, uint*, T0*, int>)LpVtbl[3])(@this, guidPtr, pDataSizePtr, pDataPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(Guid* guid, uint DataSize, void* pData)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12GraphicsCommandList*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guid, DataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData<T0>(Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D12GraphicsCommandList*, Guid*, uint, T0*, int>)LpVtbl[4])(@this, guid, DataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(ref Guid guid, uint DataSize, void* pData)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    ret = ((delegate* cdecl<ID3D12GraphicsCommandList*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guidPtr, DataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateData<T0>(ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D12GraphicsCommandList*, Guid*, uint, T0*, int>)LpVtbl[4])(@this, guidPtr, DataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Runtime.Windows.IUnknown* pData)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12GraphicsCommandList*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[5])(@this, guid, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Runtime.Windows.IUnknown pData)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D12GraphicsCommandList*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[5])(@this, guid, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Runtime.Windows.IUnknown* pData)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    ret = ((delegate* cdecl<ID3D12GraphicsCommandList*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[5])(@this, guidPtr, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Runtime.Windows.IUnknown pData)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D12GraphicsCommandList*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[5])(@this, guidPtr, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetName(char* Name)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12GraphicsCommandList*, char*, int>)LpVtbl[6])(@this, Name);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetName(ref char Name)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                int ret = default;
                fixed (char* NamePtr = &Name)
                {
                    ret = ((delegate* cdecl<ID3D12GraphicsCommandList*, char*, int>)LpVtbl[6])(@this, NamePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetName(string Name)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                int ret = default;
            var NamePtr = (byte*) Marshal.StringToHGlobalAnsi(Name);
                ret = ((delegate* cdecl<ID3D12GraphicsCommandList*, byte*, int>)LpVtbl[6])(@this, NamePtr);
            Marshal.FreeHGlobal((IntPtr)NamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(Guid* riid, void** ppvDevice)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12GraphicsCommandList*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppvDevice);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(Guid* riid, ref void* ppvDevice)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                int ret = default;
                fixed (void** ppvDevicePtr = &ppvDevice)
                {
                    ret = ((delegate* cdecl<ID3D12GraphicsCommandList*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppvDevicePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(ref Guid riid, void** ppvDevice)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D12GraphicsCommandList*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppvDevice);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(ref Guid riid, ref void* ppvDevice)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvDevicePtr = &ppvDevice)
                    {
                        ret = ((delegate* cdecl<ID3D12GraphicsCommandList*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppvDevicePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public CommandListType GetType()
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                CommandListType ret = default;
                ret = ((delegate* cdecl<ID3D12GraphicsCommandList*, CommandListType>)LpVtbl[8])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int Close()
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12GraphicsCommandList*, int>)LpVtbl[9])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Reset(ID3D12CommandAllocator* pAllocator, ID3D12PipelineState* pInitialState)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12CommandAllocator*, ID3D12PipelineState*, int>)LpVtbl[10])(@this, pAllocator, pInitialState);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Reset(ID3D12CommandAllocator* pAllocator, ref ID3D12PipelineState pInitialState)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                int ret = default;
                fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
                {
                    ret = ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12CommandAllocator*, ID3D12PipelineState*, int>)LpVtbl[10])(@this, pAllocator, pInitialStatePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Reset(ref ID3D12CommandAllocator pAllocator, ID3D12PipelineState* pInitialState)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                int ret = default;
                fixed (ID3D12CommandAllocator* pAllocatorPtr = &pAllocator)
                {
                    ret = ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12CommandAllocator*, ID3D12PipelineState*, int>)LpVtbl[10])(@this, pAllocatorPtr, pInitialState);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int Reset(ref ID3D12CommandAllocator pAllocator, ref ID3D12PipelineState pInitialState)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                int ret = default;
                fixed (ID3D12CommandAllocator* pAllocatorPtr = &pAllocator)
                {
                    fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
                    {
                        ret = ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12CommandAllocator*, ID3D12PipelineState*, int>)LpVtbl[10])(@this, pAllocatorPtr, pInitialStatePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ClearState(ID3D12PipelineState* pPipelineState)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12PipelineState*, void>)LpVtbl[11])(@this, pPipelineState);
            }
        }

        /// <summary>To be added.</summary>
        public void ClearState(ref ID3D12PipelineState pPipelineState)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (ID3D12PipelineState* pPipelineStatePtr = &pPipelineState)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12PipelineState*, void>)LpVtbl[11])(@this, pPipelineStatePtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void DrawInstanced(uint VertexCountPerInstance, uint InstanceCount, uint StartVertexLocation, uint StartInstanceLocation)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, uint, uint, uint, uint, void>)LpVtbl[12])(@this, VertexCountPerInstance, InstanceCount, StartVertexLocation, StartInstanceLocation);
            }
        }

        /// <summary>To be added.</summary>
        public void DrawIndexedInstanced(uint IndexCountPerInstance, uint InstanceCount, uint StartIndexLocation, int BaseVertexLocation, uint StartInstanceLocation)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, uint, uint, uint, int, uint, void>)LpVtbl[13])(@this, IndexCountPerInstance, InstanceCount, StartIndexLocation, BaseVertexLocation, StartInstanceLocation);
            }
        }

        /// <summary>To be added.</summary>
        public void Dispatch(uint ThreadGroupCountX, uint ThreadGroupCountY, uint ThreadGroupCountZ)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, uint, uint, uint, void>)LpVtbl[14])(@this, ThreadGroupCountX, ThreadGroupCountY, ThreadGroupCountZ);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyBufferRegion(ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, ulong NumBytes)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, ulong, void>)LpVtbl[15])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, NumBytes);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyBufferRegion(ID3D12Resource* pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, ulong NumBytes)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, ulong, void>)LpVtbl[15])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, NumBytes);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyBufferRegion(ref ID3D12Resource pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, ulong NumBytes)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, ulong, void>)LpVtbl[15])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, NumBytes);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void CopyBufferRegion(ref ID3D12Resource pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, ulong NumBytes)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
                {
                    fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
                    {
                        ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, ulong, void>)LpVtbl[15])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, NumBytes);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTextureRegion(TextureCopyLocation* pDst, uint DstX, uint DstY, uint DstZ, TextureCopyLocation* pSrc, Box* pSrcBox)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)LpVtbl[16])(@this, pDst, DstX, DstY, DstZ, pSrc, pSrcBox);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTextureRegion(TextureCopyLocation* pDst, uint DstX, uint DstY, uint DstZ, TextureCopyLocation* pSrc, ref Box pSrcBox)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (Box* pSrcBoxPtr = &pSrcBox)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)LpVtbl[16])(@this, pDst, DstX, DstY, DstZ, pSrc, pSrcBoxPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTextureRegion(TextureCopyLocation* pDst, uint DstX, uint DstY, uint DstZ, ref TextureCopyLocation pSrc, Box* pSrcBox)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (TextureCopyLocation* pSrcPtr = &pSrc)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)LpVtbl[16])(@this, pDst, DstX, DstY, DstZ, pSrcPtr, pSrcBox);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTextureRegion(TextureCopyLocation* pDst, uint DstX, uint DstY, uint DstZ, ref TextureCopyLocation pSrc, ref Box pSrcBox)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (TextureCopyLocation* pSrcPtr = &pSrc)
                {
                    fixed (Box* pSrcBoxPtr = &pSrcBox)
                    {
                        ((delegate* cdecl<ID3D12GraphicsCommandList*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)LpVtbl[16])(@this, pDst, DstX, DstY, DstZ, pSrcPtr, pSrcBoxPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTextureRegion(ref TextureCopyLocation pDst, uint DstX, uint DstY, uint DstZ, TextureCopyLocation* pSrc, Box* pSrcBox)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (TextureCopyLocation* pDstPtr = &pDst)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)LpVtbl[16])(@this, pDstPtr, DstX, DstY, DstZ, pSrc, pSrcBox);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTextureRegion(ref TextureCopyLocation pDst, uint DstX, uint DstY, uint DstZ, TextureCopyLocation* pSrc, ref Box pSrcBox)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (TextureCopyLocation* pDstPtr = &pDst)
                {
                    fixed (Box* pSrcBoxPtr = &pSrcBox)
                    {
                        ((delegate* cdecl<ID3D12GraphicsCommandList*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)LpVtbl[16])(@this, pDstPtr, DstX, DstY, DstZ, pSrc, pSrcBoxPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTextureRegion(ref TextureCopyLocation pDst, uint DstX, uint DstY, uint DstZ, ref TextureCopyLocation pSrc, Box* pSrcBox)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (TextureCopyLocation* pDstPtr = &pDst)
                {
                    fixed (TextureCopyLocation* pSrcPtr = &pSrc)
                    {
                        ((delegate* cdecl<ID3D12GraphicsCommandList*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)LpVtbl[16])(@this, pDstPtr, DstX, DstY, DstZ, pSrcPtr, pSrcBox);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public void CopyTextureRegion(ref TextureCopyLocation pDst, uint DstX, uint DstY, uint DstZ, ref TextureCopyLocation pSrc, ref Box pSrcBox)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (TextureCopyLocation* pDstPtr = &pDst)
                {
                    fixed (TextureCopyLocation* pSrcPtr = &pSrc)
                    {
                        fixed (Box* pSrcBoxPtr = &pSrcBox)
                        {
                            ((delegate* cdecl<ID3D12GraphicsCommandList*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)LpVtbl[16])(@this, pDstPtr, DstX, DstY, DstZ, pSrcPtr, pSrcBoxPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyResource(ID3D12Resource* pDstResource, ID3D12Resource* pSrcResource)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12Resource*, ID3D12Resource*, void>)LpVtbl[17])(@this, pDstResource, pSrcResource);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyResource(ID3D12Resource* pDstResource, ref ID3D12Resource pSrcResource)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12Resource*, ID3D12Resource*, void>)LpVtbl[17])(@this, pDstResource, pSrcResourcePtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyResource(ref ID3D12Resource pDstResource, ID3D12Resource* pSrcResource)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12Resource*, ID3D12Resource*, void>)LpVtbl[17])(@this, pDstResourcePtr, pSrcResource);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void CopyResource(ref ID3D12Resource pDstResource, ref ID3D12Resource pSrcResource)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
                {
                    fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
                    {
                        ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12Resource*, ID3D12Resource*, void>)LpVtbl[17])(@this, pDstResourcePtr, pSrcResourcePtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTiles(ID3D12Resource* pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinate, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTiles(ID3D12Resource* pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ref ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (ID3D12Resource* pBufferPtr = &pBuffer)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinate, pTileRegionSize, pBufferPtr, BufferStartOffsetInBytes, Flags);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTiles(ID3D12Resource* pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinate, pTileRegionSizePtr, pBuffer, BufferStartOffsetInBytes, Flags);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTiles(ID3D12Resource* pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ref ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                {
                    fixed (ID3D12Resource* pBufferPtr = &pBuffer)
                    {
                        ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinate, pTileRegionSizePtr, pBufferPtr, BufferStartOffsetInBytes, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTiles(ID3D12Resource* pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinatePtr, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTiles(ID3D12Resource* pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ref ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
                {
                    fixed (ID3D12Resource* pBufferPtr = &pBuffer)
                    {
                        ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinatePtr, pTileRegionSize, pBufferPtr, BufferStartOffsetInBytes, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTiles(ID3D12Resource* pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
                {
                    fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                    {
                        ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinatePtr, pTileRegionSizePtr, pBuffer, BufferStartOffsetInBytes, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTiles(ID3D12Resource* pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ref ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
                {
                    fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                    {
                        fixed (ID3D12Resource* pBufferPtr = &pBuffer)
                        {
                            ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinatePtr, pTileRegionSizePtr, pBufferPtr, BufferStartOffsetInBytes, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTiles(ref ID3D12Resource pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinate, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTiles(ref ID3D12Resource pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ref ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (ID3D12Resource* pBufferPtr = &pBuffer)
                    {
                        ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinate, pTileRegionSize, pBufferPtr, BufferStartOffsetInBytes, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTiles(ref ID3D12Resource pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                    {
                        ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinate, pTileRegionSizePtr, pBuffer, BufferStartOffsetInBytes, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTiles(ref ID3D12Resource pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ref ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                    {
                        fixed (ID3D12Resource* pBufferPtr = &pBuffer)
                        {
                            ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinate, pTileRegionSizePtr, pBufferPtr, BufferStartOffsetInBytes, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTiles(ref ID3D12Resource pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
                    {
                        ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinatePtr, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTiles(ref ID3D12Resource pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ref ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
                    {
                        fixed (ID3D12Resource* pBufferPtr = &pBuffer)
                        {
                            ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinatePtr, pTileRegionSize, pBufferPtr, BufferStartOffsetInBytes, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTiles(ref ID3D12Resource pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
                    {
                        fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                        {
                            ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinatePtr, pTileRegionSizePtr, pBuffer, BufferStartOffsetInBytes, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public void CopyTiles(ref ID3D12Resource pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ref ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
                    {
                        fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                        {
                            fixed (ID3D12Resource* pBufferPtr = &pBuffer)
                            {
                                ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinatePtr, pTileRegionSizePtr, pBufferPtr, BufferStartOffsetInBytes, Flags);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ResolveSubresource(ID3D12Resource* pDstResource, uint DstSubresource, ID3D12Resource* pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12Resource*, uint, ID3D12Resource*, uint, Silk.NET.DXGI.Format, void>)LpVtbl[19])(@this, pDstResource, DstSubresource, pSrcResource, SrcSubresource, Format);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ResolveSubresource(ID3D12Resource* pDstResource, uint DstSubresource, ref ID3D12Resource pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12Resource*, uint, ID3D12Resource*, uint, Silk.NET.DXGI.Format, void>)LpVtbl[19])(@this, pDstResource, DstSubresource, pSrcResourcePtr, SrcSubresource, Format);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ResolveSubresource(ref ID3D12Resource pDstResource, uint DstSubresource, ID3D12Resource* pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12Resource*, uint, ID3D12Resource*, uint, Silk.NET.DXGI.Format, void>)LpVtbl[19])(@this, pDstResourcePtr, DstSubresource, pSrcResource, SrcSubresource, Format);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void ResolveSubresource(ref ID3D12Resource pDstResource, uint DstSubresource, ref ID3D12Resource pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
                {
                    fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
                    {
                        ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12Resource*, uint, ID3D12Resource*, uint, Silk.NET.DXGI.Format, void>)LpVtbl[19])(@this, pDstResourcePtr, DstSubresource, pSrcResourcePtr, SrcSubresource, Format);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public void IASetPrimitiveTopology(Silk.NET.Core.Native.PrimitiveTopology PrimitiveTopology)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, Silk.NET.Core.Native.PrimitiveTopology, void>)LpVtbl[20])(@this, PrimitiveTopology);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void RSSetViewports(uint NumViewports, Viewport* pViewports)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, uint, Viewport*, void>)LpVtbl[21])(@this, NumViewports, pViewports);
            }
        }

        /// <summary>To be added.</summary>
        public void RSSetViewports(uint NumViewports, ref Viewport pViewports)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (Viewport* pViewportsPtr = &pViewports)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, uint, Viewport*, void>)LpVtbl[21])(@this, NumViewports, pViewportsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void RSSetScissorRects(uint NumRects, Silk.NET.Core.Runtime.Windows.TagRect* pRects)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, uint, Silk.NET.Core.Runtime.Windows.TagRect*, void>)LpVtbl[22])(@this, NumRects, pRects);
            }
        }

        /// <summary>To be added.</summary>
        public void RSSetScissorRects(uint NumRects, ref Silk.NET.Core.Runtime.Windows.TagRect pRects)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (Silk.NET.Core.Runtime.Windows.TagRect* pRectsPtr = &pRects)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, uint, Silk.NET.Core.Runtime.Windows.TagRect*, void>)LpVtbl[22])(@this, NumRects, pRectsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMSetBlendFactor([Count(Count = 4)] float* BlendFactor)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, float*, void>)LpVtbl[23])(@this, BlendFactor);
            }
        }

        /// <summary>To be added.</summary>
        public void OMSetBlendFactor([Count(Count = 4)] ref float BlendFactor)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (float* BlendFactorPtr = &BlendFactor)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, float*, void>)LpVtbl[23])(@this, BlendFactorPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void OMSetStencilRef(uint StencilRef)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, uint, void>)LpVtbl[24])(@this, StencilRef);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void SetPipelineState(ID3D12PipelineState* pPipelineState)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12PipelineState*, void>)LpVtbl[25])(@this, pPipelineState);
            }
        }

        /// <summary>To be added.</summary>
        public void SetPipelineState(ref ID3D12PipelineState pPipelineState)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (ID3D12PipelineState* pPipelineStatePtr = &pPipelineState)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12PipelineState*, void>)LpVtbl[25])(@this, pPipelineStatePtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ResourceBarrier(uint NumBarriers, ResourceBarrier* pBarriers)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, uint, ResourceBarrier*, void>)LpVtbl[26])(@this, NumBarriers, pBarriers);
            }
        }

        /// <summary>To be added.</summary>
        public void ResourceBarrier(uint NumBarriers, ref ResourceBarrier pBarriers)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (ResourceBarrier* pBarriersPtr = &pBarriers)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, uint, ResourceBarrier*, void>)LpVtbl[26])(@this, NumBarriers, pBarriersPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ExecuteBundle(ID3D12GraphicsCommandList* pCommandList)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12GraphicsCommandList*, void>)LpVtbl[27])(@this, pCommandList);
            }
        }

        /// <summary>To be added.</summary>
        public void ExecuteBundle(ref ID3D12GraphicsCommandList pCommandList)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (ID3D12GraphicsCommandList* pCommandListPtr = &pCommandList)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12GraphicsCommandList*, void>)LpVtbl[27])(@this, pCommandListPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void SetDescriptorHeaps(uint NumDescriptorHeaps, ID3D12DescriptorHeap** ppDescriptorHeaps)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, uint, ID3D12DescriptorHeap**, void>)LpVtbl[28])(@this, NumDescriptorHeaps, ppDescriptorHeaps);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void SetDescriptorHeaps(uint NumDescriptorHeaps, ref ID3D12DescriptorHeap* ppDescriptorHeaps)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (ID3D12DescriptorHeap** ppDescriptorHeapsPtr = &ppDescriptorHeaps)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, uint, ID3D12DescriptorHeap**, void>)LpVtbl[28])(@this, NumDescriptorHeaps, ppDescriptorHeapsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void SetComputeRootSignature(ID3D12RootSignature* pRootSignature)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12RootSignature*, void>)LpVtbl[29])(@this, pRootSignature);
            }
        }

        /// <summary>To be added.</summary>
        public void SetComputeRootSignature(ref ID3D12RootSignature pRootSignature)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12RootSignature*, void>)LpVtbl[29])(@this, pRootSignaturePtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void SetGraphicsRootSignature(ID3D12RootSignature* pRootSignature)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12RootSignature*, void>)LpVtbl[30])(@this, pRootSignature);
            }
        }

        /// <summary>To be added.</summary>
        public void SetGraphicsRootSignature(ref ID3D12RootSignature pRootSignature)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12RootSignature*, void>)LpVtbl[30])(@this, pRootSignaturePtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void SetComputeRootDescriptorTable(uint RootParameterIndex, GpuDescriptorHandle BaseDescriptor)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, uint, GpuDescriptorHandle, void>)LpVtbl[31])(@this, RootParameterIndex, BaseDescriptor);
            }
        }

        /// <summary>To be added.</summary>
        public void SetGraphicsRootDescriptorTable(uint RootParameterIndex, GpuDescriptorHandle BaseDescriptor)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, uint, GpuDescriptorHandle, void>)LpVtbl[32])(@this, RootParameterIndex, BaseDescriptor);
            }
        }

        /// <summary>To be added.</summary>
        public void SetComputeRoot32BitConstant(uint RootParameterIndex, uint SrcData, uint DestOffsetIn32BitValues)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, uint, uint, uint, void>)LpVtbl[33])(@this, RootParameterIndex, SrcData, DestOffsetIn32BitValues);
            }
        }

        /// <summary>To be added.</summary>
        public void SetGraphicsRoot32BitConstant(uint RootParameterIndex, uint SrcData, uint DestOffsetIn32BitValues)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, uint, uint, uint, void>)LpVtbl[34])(@this, RootParameterIndex, SrcData, DestOffsetIn32BitValues);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void SetComputeRoot32BitConstants(uint RootParameterIndex, uint Num32BitValuesToSet, void* pSrcData, uint DestOffsetIn32BitValues)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, uint, uint, void*, uint, void>)LpVtbl[35])(@this, RootParameterIndex, Num32BitValuesToSet, pSrcData, DestOffsetIn32BitValues);
            }
        }

        /// <summary>To be added.</summary>
        public void SetComputeRoot32BitConstants<T0>(uint RootParameterIndex, uint Num32BitValuesToSet, ref T0 pSrcData, uint DestOffsetIn32BitValues) where T0 : unmanaged
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (T0* pSrcDataPtr = &pSrcData)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, uint, uint, T0*, uint, void>)LpVtbl[35])(@this, RootParameterIndex, Num32BitValuesToSet, pSrcDataPtr, DestOffsetIn32BitValues);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void SetGraphicsRoot32BitConstants(uint RootParameterIndex, uint Num32BitValuesToSet, void* pSrcData, uint DestOffsetIn32BitValues)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, uint, uint, void*, uint, void>)LpVtbl[36])(@this, RootParameterIndex, Num32BitValuesToSet, pSrcData, DestOffsetIn32BitValues);
            }
        }

        /// <summary>To be added.</summary>
        public void SetGraphicsRoot32BitConstants<T0>(uint RootParameterIndex, uint Num32BitValuesToSet, ref T0 pSrcData, uint DestOffsetIn32BitValues) where T0 : unmanaged
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (T0* pSrcDataPtr = &pSrcData)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, uint, uint, T0*, uint, void>)LpVtbl[36])(@this, RootParameterIndex, Num32BitValuesToSet, pSrcDataPtr, DestOffsetIn32BitValues);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void SetComputeRootConstantBufferView(uint RootParameterIndex, ulong BufferLocation)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, uint, ulong, void>)LpVtbl[37])(@this, RootParameterIndex, BufferLocation);
            }
        }

        /// <summary>To be added.</summary>
        public void SetGraphicsRootConstantBufferView(uint RootParameterIndex, ulong BufferLocation)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, uint, ulong, void>)LpVtbl[38])(@this, RootParameterIndex, BufferLocation);
            }
        }

        /// <summary>To be added.</summary>
        public void SetComputeRootShaderResourceView(uint RootParameterIndex, ulong BufferLocation)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, uint, ulong, void>)LpVtbl[39])(@this, RootParameterIndex, BufferLocation);
            }
        }

        /// <summary>To be added.</summary>
        public void SetGraphicsRootShaderResourceView(uint RootParameterIndex, ulong BufferLocation)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, uint, ulong, void>)LpVtbl[40])(@this, RootParameterIndex, BufferLocation);
            }
        }

        /// <summary>To be added.</summary>
        public void SetComputeRootUnorderedAccessView(uint RootParameterIndex, ulong BufferLocation)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, uint, ulong, void>)LpVtbl[41])(@this, RootParameterIndex, BufferLocation);
            }
        }

        /// <summary>To be added.</summary>
        public void SetGraphicsRootUnorderedAccessView(uint RootParameterIndex, ulong BufferLocation)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, uint, ulong, void>)LpVtbl[42])(@this, RootParameterIndex, BufferLocation);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void IASetIndexBuffer(IndexBufferView* pView)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, IndexBufferView*, void>)LpVtbl[43])(@this, pView);
            }
        }

        /// <summary>To be added.</summary>
        public void IASetIndexBuffer(ref IndexBufferView pView)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (IndexBufferView* pViewPtr = &pView)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, IndexBufferView*, void>)LpVtbl[43])(@this, pViewPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void IASetVertexBuffers(uint StartSlot, uint NumViews, VertexBufferView* pViews)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, uint, uint, VertexBufferView*, void>)LpVtbl[44])(@this, StartSlot, NumViews, pViews);
            }
        }

        /// <summary>To be added.</summary>
        public void IASetVertexBuffers(uint StartSlot, uint NumViews, ref VertexBufferView pViews)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (VertexBufferView* pViewsPtr = &pViews)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, uint, uint, VertexBufferView*, void>)LpVtbl[44])(@this, StartSlot, NumViews, pViewsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void SOSetTargets(uint StartSlot, uint NumViews, StreamOutputBufferView* pViews)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, uint, uint, StreamOutputBufferView*, void>)LpVtbl[45])(@this, StartSlot, NumViews, pViews);
            }
        }

        /// <summary>To be added.</summary>
        public void SOSetTargets(uint StartSlot, uint NumViews, ref StreamOutputBufferView pViews)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (StreamOutputBufferView* pViewsPtr = &pViews)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, uint, uint, StreamOutputBufferView*, void>)LpVtbl[45])(@this, StartSlot, NumViews, pViewsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMSetRenderTargets(uint NumRenderTargetDescriptors, CpuDescriptorHandle* pRenderTargetDescriptors, int RTsSingleHandleToDescriptorRange, CpuDescriptorHandle* pDepthStencilDescriptor)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, uint, CpuDescriptorHandle*, int, CpuDescriptorHandle*, void>)LpVtbl[46])(@this, NumRenderTargetDescriptors, pRenderTargetDescriptors, RTsSingleHandleToDescriptorRange, pDepthStencilDescriptor);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMSetRenderTargets(uint NumRenderTargetDescriptors, CpuDescriptorHandle* pRenderTargetDescriptors, int RTsSingleHandleToDescriptorRange, ref CpuDescriptorHandle pDepthStencilDescriptor)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (CpuDescriptorHandle* pDepthStencilDescriptorPtr = &pDepthStencilDescriptor)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, uint, CpuDescriptorHandle*, int, CpuDescriptorHandle*, void>)LpVtbl[46])(@this, NumRenderTargetDescriptors, pRenderTargetDescriptors, RTsSingleHandleToDescriptorRange, pDepthStencilDescriptorPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMSetRenderTargets(uint NumRenderTargetDescriptors, ref CpuDescriptorHandle pRenderTargetDescriptors, int RTsSingleHandleToDescriptorRange, CpuDescriptorHandle* pDepthStencilDescriptor)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (CpuDescriptorHandle* pRenderTargetDescriptorsPtr = &pRenderTargetDescriptors)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, uint, CpuDescriptorHandle*, int, CpuDescriptorHandle*, void>)LpVtbl[46])(@this, NumRenderTargetDescriptors, pRenderTargetDescriptorsPtr, RTsSingleHandleToDescriptorRange, pDepthStencilDescriptor);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void OMSetRenderTargets(uint NumRenderTargetDescriptors, ref CpuDescriptorHandle pRenderTargetDescriptors, int RTsSingleHandleToDescriptorRange, ref CpuDescriptorHandle pDepthStencilDescriptor)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (CpuDescriptorHandle* pRenderTargetDescriptorsPtr = &pRenderTargetDescriptors)
                {
                    fixed (CpuDescriptorHandle* pDepthStencilDescriptorPtr = &pDepthStencilDescriptor)
                    {
                        ((delegate* cdecl<ID3D12GraphicsCommandList*, uint, CpuDescriptorHandle*, int, CpuDescriptorHandle*, void>)LpVtbl[46])(@this, NumRenderTargetDescriptors, pRenderTargetDescriptorsPtr, RTsSingleHandleToDescriptorRange, pDepthStencilDescriptorPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ClearDepthStencilView(CpuDescriptorHandle DepthStencilView, ClearFlags ClearFlags, float Depth, byte Stencil, uint NumRects, Silk.NET.Core.Runtime.Windows.TagRect* pRects)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, CpuDescriptorHandle, ClearFlags, float, byte, uint, Silk.NET.Core.Runtime.Windows.TagRect*, void>)LpVtbl[47])(@this, DepthStencilView, ClearFlags, Depth, Stencil, NumRects, pRects);
            }
        }

        /// <summary>To be added.</summary>
        public void ClearDepthStencilView(CpuDescriptorHandle DepthStencilView, ClearFlags ClearFlags, float Depth, byte Stencil, uint NumRects, ref Silk.NET.Core.Runtime.Windows.TagRect pRects)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (Silk.NET.Core.Runtime.Windows.TagRect* pRectsPtr = &pRects)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, CpuDescriptorHandle, ClearFlags, float, byte, uint, Silk.NET.Core.Runtime.Windows.TagRect*, void>)LpVtbl[47])(@this, DepthStencilView, ClearFlags, Depth, Stencil, NumRects, pRectsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ClearRenderTargetView(CpuDescriptorHandle RenderTargetView, [Count(Count = 4)] float* ColorRGBA, uint NumRects, Silk.NET.Core.Runtime.Windows.TagRect* pRects)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, CpuDescriptorHandle, float*, uint, Silk.NET.Core.Runtime.Windows.TagRect*, void>)LpVtbl[48])(@this, RenderTargetView, ColorRGBA, NumRects, pRects);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ClearRenderTargetView(CpuDescriptorHandle RenderTargetView, [Count(Count = 4)] float* ColorRGBA, uint NumRects, ref Silk.NET.Core.Runtime.Windows.TagRect pRects)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (Silk.NET.Core.Runtime.Windows.TagRect* pRectsPtr = &pRects)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, CpuDescriptorHandle, float*, uint, Silk.NET.Core.Runtime.Windows.TagRect*, void>)LpVtbl[48])(@this, RenderTargetView, ColorRGBA, NumRects, pRectsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ClearRenderTargetView(CpuDescriptorHandle RenderTargetView, [Count(Count = 4)] ref float ColorRGBA, uint NumRects, Silk.NET.Core.Runtime.Windows.TagRect* pRects)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (float* ColorRGBAPtr = &ColorRGBA)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, CpuDescriptorHandle, float*, uint, Silk.NET.Core.Runtime.Windows.TagRect*, void>)LpVtbl[48])(@this, RenderTargetView, ColorRGBAPtr, NumRects, pRects);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void ClearRenderTargetView(CpuDescriptorHandle RenderTargetView, [Count(Count = 4)] ref float ColorRGBA, uint NumRects, ref Silk.NET.Core.Runtime.Windows.TagRect pRects)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (float* ColorRGBAPtr = &ColorRGBA)
                {
                    fixed (Silk.NET.Core.Runtime.Windows.TagRect* pRectsPtr = &pRects)
                    {
                        ((delegate* cdecl<ID3D12GraphicsCommandList*, CpuDescriptorHandle, float*, uint, Silk.NET.Core.Runtime.Windows.TagRect*, void>)LpVtbl[48])(@this, RenderTargetView, ColorRGBAPtr, NumRects, pRectsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ClearUnorderedAccessViewUint(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] uint* Values, uint NumRects, Silk.NET.Core.Runtime.Windows.TagRect* pRects)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Core.Runtime.Windows.TagRect*, void>)LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRects);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ClearUnorderedAccessViewUint(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] uint* Values, uint NumRects, ref Silk.NET.Core.Runtime.Windows.TagRect pRects)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (Silk.NET.Core.Runtime.Windows.TagRect* pRectsPtr = &pRects)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Core.Runtime.Windows.TagRect*, void>)LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRectsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ClearUnorderedAccessViewUint(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] ref uint Values, uint NumRects, Silk.NET.Core.Runtime.Windows.TagRect* pRects)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (uint* ValuesPtr = &Values)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Core.Runtime.Windows.TagRect*, void>)LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, ValuesPtr, NumRects, pRects);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ClearUnorderedAccessViewUint(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] ref uint Values, uint NumRects, ref Silk.NET.Core.Runtime.Windows.TagRect pRects)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (uint* ValuesPtr = &Values)
                {
                    fixed (Silk.NET.Core.Runtime.Windows.TagRect* pRectsPtr = &pRects)
                    {
                        ((delegate* cdecl<ID3D12GraphicsCommandList*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Core.Runtime.Windows.TagRect*, void>)LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, ValuesPtr, NumRects, pRectsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ClearUnorderedAccessViewUint(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ref ID3D12Resource pResource, [Count(Count = 4)] uint* Values, uint NumRects, Silk.NET.Core.Runtime.Windows.TagRect* pRects)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Core.Runtime.Windows.TagRect*, void>)LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, Values, NumRects, pRects);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ClearUnorderedAccessViewUint(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ref ID3D12Resource pResource, [Count(Count = 4)] uint* Values, uint NumRects, ref Silk.NET.Core.Runtime.Windows.TagRect pRects)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (Silk.NET.Core.Runtime.Windows.TagRect* pRectsPtr = &pRects)
                    {
                        ((delegate* cdecl<ID3D12GraphicsCommandList*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Core.Runtime.Windows.TagRect*, void>)LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, Values, NumRects, pRectsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ClearUnorderedAccessViewUint(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ref ID3D12Resource pResource, [Count(Count = 4)] ref uint Values, uint NumRects, Silk.NET.Core.Runtime.Windows.TagRect* pRects)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (uint* ValuesPtr = &Values)
                    {
                        ((delegate* cdecl<ID3D12GraphicsCommandList*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Core.Runtime.Windows.TagRect*, void>)LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, ValuesPtr, NumRects, pRects);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public void ClearUnorderedAccessViewUint(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ref ID3D12Resource pResource, [Count(Count = 4)] ref uint Values, uint NumRects, ref Silk.NET.Core.Runtime.Windows.TagRect pRects)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (uint* ValuesPtr = &Values)
                    {
                        fixed (Silk.NET.Core.Runtime.Windows.TagRect* pRectsPtr = &pRects)
                        {
                            ((delegate* cdecl<ID3D12GraphicsCommandList*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Core.Runtime.Windows.TagRect*, void>)LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, ValuesPtr, NumRects, pRectsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ClearUnorderedAccessViewFloat(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] float* Values, uint NumRects, Silk.NET.Core.Runtime.Windows.TagRect* pRects)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Core.Runtime.Windows.TagRect*, void>)LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRects);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ClearUnorderedAccessViewFloat(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] float* Values, uint NumRects, ref Silk.NET.Core.Runtime.Windows.TagRect pRects)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (Silk.NET.Core.Runtime.Windows.TagRect* pRectsPtr = &pRects)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Core.Runtime.Windows.TagRect*, void>)LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRectsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ClearUnorderedAccessViewFloat(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] ref float Values, uint NumRects, Silk.NET.Core.Runtime.Windows.TagRect* pRects)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (float* ValuesPtr = &Values)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Core.Runtime.Windows.TagRect*, void>)LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, ValuesPtr, NumRects, pRects);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ClearUnorderedAccessViewFloat(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] ref float Values, uint NumRects, ref Silk.NET.Core.Runtime.Windows.TagRect pRects)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (float* ValuesPtr = &Values)
                {
                    fixed (Silk.NET.Core.Runtime.Windows.TagRect* pRectsPtr = &pRects)
                    {
                        ((delegate* cdecl<ID3D12GraphicsCommandList*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Core.Runtime.Windows.TagRect*, void>)LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, ValuesPtr, NumRects, pRectsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ClearUnorderedAccessViewFloat(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ref ID3D12Resource pResource, [Count(Count = 4)] float* Values, uint NumRects, Silk.NET.Core.Runtime.Windows.TagRect* pRects)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Core.Runtime.Windows.TagRect*, void>)LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, Values, NumRects, pRects);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ClearUnorderedAccessViewFloat(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ref ID3D12Resource pResource, [Count(Count = 4)] float* Values, uint NumRects, ref Silk.NET.Core.Runtime.Windows.TagRect pRects)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (Silk.NET.Core.Runtime.Windows.TagRect* pRectsPtr = &pRects)
                    {
                        ((delegate* cdecl<ID3D12GraphicsCommandList*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Core.Runtime.Windows.TagRect*, void>)LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, Values, NumRects, pRectsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ClearUnorderedAccessViewFloat(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ref ID3D12Resource pResource, [Count(Count = 4)] ref float Values, uint NumRects, Silk.NET.Core.Runtime.Windows.TagRect* pRects)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (float* ValuesPtr = &Values)
                    {
                        ((delegate* cdecl<ID3D12GraphicsCommandList*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Core.Runtime.Windows.TagRect*, void>)LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, ValuesPtr, NumRects, pRects);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public void ClearUnorderedAccessViewFloat(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ref ID3D12Resource pResource, [Count(Count = 4)] ref float Values, uint NumRects, ref Silk.NET.Core.Runtime.Windows.TagRect pRects)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (float* ValuesPtr = &Values)
                    {
                        fixed (Silk.NET.Core.Runtime.Windows.TagRect* pRectsPtr = &pRects)
                        {
                            ((delegate* cdecl<ID3D12GraphicsCommandList*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Core.Runtime.Windows.TagRect*, void>)LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, ValuesPtr, NumRects, pRectsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DiscardResource(ID3D12Resource* pResource, DiscardRegion* pRegion)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12Resource*, DiscardRegion*, void>)LpVtbl[51])(@this, pResource, pRegion);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DiscardResource(ID3D12Resource* pResource, ref DiscardRegion pRegion)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (DiscardRegion* pRegionPtr = &pRegion)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12Resource*, DiscardRegion*, void>)LpVtbl[51])(@this, pResource, pRegionPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DiscardResource(ref ID3D12Resource pResource, DiscardRegion* pRegion)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12Resource*, DiscardRegion*, void>)LpVtbl[51])(@this, pResourcePtr, pRegion);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void DiscardResource(ref ID3D12Resource pResource, ref DiscardRegion pRegion)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (DiscardRegion* pRegionPtr = &pRegion)
                    {
                        ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12Resource*, DiscardRegion*, void>)LpVtbl[51])(@this, pResourcePtr, pRegionPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void BeginQuery(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint Index)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12QueryHeap*, QueryType, uint, void>)LpVtbl[52])(@this, pQueryHeap, Type, Index);
            }
        }

        /// <summary>To be added.</summary>
        public void BeginQuery(ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint Index)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12QueryHeap*, QueryType, uint, void>)LpVtbl[52])(@this, pQueryHeapPtr, Type, Index);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void EndQuery(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint Index)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12QueryHeap*, QueryType, uint, void>)LpVtbl[53])(@this, pQueryHeap, Type, Index);
            }
        }

        /// <summary>To be added.</summary>
        public void EndQuery(ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint Index)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12QueryHeap*, QueryType, uint, void>)LpVtbl[53])(@this, pQueryHeapPtr, Type, Index);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ResolveQueryData(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ID3D12Resource* pDestinationBuffer, ulong AlignedDestinationBufferOffset)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)LpVtbl[54])(@this, pQueryHeap, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ResolveQueryData(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ref ID3D12Resource pDestinationBuffer, ulong AlignedDestinationBufferOffset)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (ID3D12Resource* pDestinationBufferPtr = &pDestinationBuffer)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)LpVtbl[54])(@this, pQueryHeap, Type, StartIndex, NumQueries, pDestinationBufferPtr, AlignedDestinationBufferOffset);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ResolveQueryData(ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ID3D12Resource* pDestinationBuffer, ulong AlignedDestinationBufferOffset)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)LpVtbl[54])(@this, pQueryHeapPtr, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void ResolveQueryData(ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ref ID3D12Resource pDestinationBuffer, ulong AlignedDestinationBufferOffset)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
                {
                    fixed (ID3D12Resource* pDestinationBufferPtr = &pDestinationBuffer)
                    {
                        ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)LpVtbl[54])(@this, pQueryHeapPtr, Type, StartIndex, NumQueries, pDestinationBufferPtr, AlignedDestinationBufferOffset);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void SetPredication(ID3D12Resource* pBuffer, ulong AlignedBufferOffset, PredicationOp Operation)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12Resource*, ulong, PredicationOp, void>)LpVtbl[55])(@this, pBuffer, AlignedBufferOffset, Operation);
            }
        }

        /// <summary>To be added.</summary>
        public void SetPredication(ref ID3D12Resource pBuffer, ulong AlignedBufferOffset, PredicationOp Operation)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (ID3D12Resource* pBufferPtr = &pBuffer)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12Resource*, ulong, PredicationOp, void>)LpVtbl[55])(@this, pBufferPtr, AlignedBufferOffset, Operation);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void SetMarker(uint Metadata, void* pData, uint Size)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, uint, void*, uint, void>)LpVtbl[56])(@this, Metadata, pData, Size);
            }
        }

        /// <summary>To be added.</summary>
        public void SetMarker<T0>(uint Metadata, ref T0 pData, uint Size) where T0 : unmanaged
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (T0* pDataPtr = &pData)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, uint, T0*, uint, void>)LpVtbl[56])(@this, Metadata, pDataPtr, Size);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void BeginEvent(uint Metadata, void* pData, uint Size)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, uint, void*, uint, void>)LpVtbl[57])(@this, Metadata, pData, Size);
            }
        }

        /// <summary>To be added.</summary>
        public void BeginEvent<T0>(uint Metadata, ref T0 pData, uint Size) where T0 : unmanaged
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (T0* pDataPtr = &pData)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, uint, T0*, uint, void>)LpVtbl[57])(@this, Metadata, pDataPtr, Size);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void EndEvent()
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, void>)LpVtbl[58])(@this);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ExecuteIndirect(ID3D12CommandSignature* pCommandSignature, uint MaxCommandCount, ID3D12Resource* pArgumentBuffer, ulong ArgumentBufferOffset, ID3D12Resource* pCountBuffer, ulong CountBufferOffset)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)LpVtbl[59])(@this, pCommandSignature, MaxCommandCount, pArgumentBuffer, ArgumentBufferOffset, pCountBuffer, CountBufferOffset);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ExecuteIndirect(ID3D12CommandSignature* pCommandSignature, uint MaxCommandCount, ID3D12Resource* pArgumentBuffer, ulong ArgumentBufferOffset, ref ID3D12Resource pCountBuffer, ulong CountBufferOffset)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (ID3D12Resource* pCountBufferPtr = &pCountBuffer)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)LpVtbl[59])(@this, pCommandSignature, MaxCommandCount, pArgumentBuffer, ArgumentBufferOffset, pCountBufferPtr, CountBufferOffset);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ExecuteIndirect(ID3D12CommandSignature* pCommandSignature, uint MaxCommandCount, ref ID3D12Resource pArgumentBuffer, ulong ArgumentBufferOffset, ID3D12Resource* pCountBuffer, ulong CountBufferOffset)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (ID3D12Resource* pArgumentBufferPtr = &pArgumentBuffer)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)LpVtbl[59])(@this, pCommandSignature, MaxCommandCount, pArgumentBufferPtr, ArgumentBufferOffset, pCountBuffer, CountBufferOffset);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ExecuteIndirect(ID3D12CommandSignature* pCommandSignature, uint MaxCommandCount, ref ID3D12Resource pArgumentBuffer, ulong ArgumentBufferOffset, ref ID3D12Resource pCountBuffer, ulong CountBufferOffset)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (ID3D12Resource* pArgumentBufferPtr = &pArgumentBuffer)
                {
                    fixed (ID3D12Resource* pCountBufferPtr = &pCountBuffer)
                    {
                        ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)LpVtbl[59])(@this, pCommandSignature, MaxCommandCount, pArgumentBufferPtr, ArgumentBufferOffset, pCountBufferPtr, CountBufferOffset);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ExecuteIndirect(ref ID3D12CommandSignature pCommandSignature, uint MaxCommandCount, ID3D12Resource* pArgumentBuffer, ulong ArgumentBufferOffset, ID3D12Resource* pCountBuffer, ulong CountBufferOffset)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (ID3D12CommandSignature* pCommandSignaturePtr = &pCommandSignature)
                {
                    ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)LpVtbl[59])(@this, pCommandSignaturePtr, MaxCommandCount, pArgumentBuffer, ArgumentBufferOffset, pCountBuffer, CountBufferOffset);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ExecuteIndirect(ref ID3D12CommandSignature pCommandSignature, uint MaxCommandCount, ID3D12Resource* pArgumentBuffer, ulong ArgumentBufferOffset, ref ID3D12Resource pCountBuffer, ulong CountBufferOffset)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (ID3D12CommandSignature* pCommandSignaturePtr = &pCommandSignature)
                {
                    fixed (ID3D12Resource* pCountBufferPtr = &pCountBuffer)
                    {
                        ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)LpVtbl[59])(@this, pCommandSignaturePtr, MaxCommandCount, pArgumentBuffer, ArgumentBufferOffset, pCountBufferPtr, CountBufferOffset);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ExecuteIndirect(ref ID3D12CommandSignature pCommandSignature, uint MaxCommandCount, ref ID3D12Resource pArgumentBuffer, ulong ArgumentBufferOffset, ID3D12Resource* pCountBuffer, ulong CountBufferOffset)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (ID3D12CommandSignature* pCommandSignaturePtr = &pCommandSignature)
                {
                    fixed (ID3D12Resource* pArgumentBufferPtr = &pArgumentBuffer)
                    {
                        ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)LpVtbl[59])(@this, pCommandSignaturePtr, MaxCommandCount, pArgumentBufferPtr, ArgumentBufferOffset, pCountBuffer, CountBufferOffset);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public void ExecuteIndirect(ref ID3D12CommandSignature pCommandSignature, uint MaxCommandCount, ref ID3D12Resource pArgumentBuffer, ulong ArgumentBufferOffset, ref ID3D12Resource pCountBuffer, ulong CountBufferOffset)
        {
            fixed (ID3D12GraphicsCommandList* @this = &this)
            {
                fixed (ID3D12CommandSignature* pCommandSignaturePtr = &pCommandSignature)
                {
                    fixed (ID3D12Resource* pArgumentBufferPtr = &pArgumentBuffer)
                    {
                        fixed (ID3D12Resource* pCountBufferPtr = &pCountBuffer)
                        {
                            ((delegate* cdecl<ID3D12GraphicsCommandList*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)LpVtbl[59])(@this, pCommandSignaturePtr, MaxCommandCount, pArgumentBufferPtr, ArgumentBufferOffset, pCountBufferPtr, CountBufferOffset);
                        }
                    }
                }
            }
        }

    }
}
