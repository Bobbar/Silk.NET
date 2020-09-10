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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "ID3D11Module")]
    public unsafe partial struct ID3D11Module
    {
        public ID3D11Module
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
            fixed (ID3D11Module* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11Module*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (ID3D11Module* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<ID3D11Module*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (ID3D11Module* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D11Module*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (ID3D11Module* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<ID3D11Module*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (ID3D11Module* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D11Module*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (ID3D11Module* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D11Module*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateInstance(byte* pNamespace, ID3D11ModuleInstance** ppModuleInstance)
        {
            fixed (ID3D11Module* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11Module*, byte*, ID3D11ModuleInstance**, int>)LpVtbl[3])(@this, pNamespace, ppModuleInstance);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateInstance(byte* pNamespace, ref ID3D11ModuleInstance* ppModuleInstance)
        {
            fixed (ID3D11Module* @this = &this)
            {
                int ret = default;
                fixed (ID3D11ModuleInstance** ppModuleInstancePtr = &ppModuleInstance)
                {
                    ret = ((delegate* cdecl<ID3D11Module*, byte*, ID3D11ModuleInstance**, int>)LpVtbl[3])(@this, pNamespace, ppModuleInstancePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateInstance(ref byte pNamespace, ID3D11ModuleInstance** ppModuleInstance)
        {
            fixed (ID3D11Module* @this = &this)
            {
                int ret = default;
                fixed (byte* pNamespacePtr = &pNamespace)
                {
                    ret = ((delegate* cdecl<ID3D11Module*, byte*, ID3D11ModuleInstance**, int>)LpVtbl[3])(@this, pNamespacePtr, ppModuleInstance);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateInstance(ref byte pNamespace, ref ID3D11ModuleInstance* ppModuleInstance)
        {
            fixed (ID3D11Module* @this = &this)
            {
                int ret = default;
                fixed (byte* pNamespacePtr = &pNamespace)
                {
                    fixed (ID3D11ModuleInstance** ppModuleInstancePtr = &ppModuleInstance)
                    {
                        ret = ((delegate* cdecl<ID3D11Module*, byte*, ID3D11ModuleInstance**, int>)LpVtbl[3])(@this, pNamespacePtr, ppModuleInstancePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateInstance(string pNamespace, ID3D11ModuleInstance** ppModuleInstance)
        {
            fixed (ID3D11Module* @this = &this)
            {
                int ret = default;
            var pNamespacePtr = (byte*) Marshal.StringToHGlobalAnsi(pNamespace);
                ret = ((delegate* cdecl<ID3D11Module*, byte*, ID3D11ModuleInstance**, int>)LpVtbl[3])(@this, pNamespacePtr, ppModuleInstance);
            Marshal.FreeHGlobal((IntPtr)pNamespacePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateInstance(string pNamespace, ref ID3D11ModuleInstance* ppModuleInstance)
        {
            fixed (ID3D11Module* @this = &this)
            {
                int ret = default;
            var pNamespacePtr = (byte*) Marshal.StringToHGlobalAnsi(pNamespace);
                fixed (ID3D11ModuleInstance** ppModuleInstancePtr = &ppModuleInstance)
                {
                    ret = ((delegate* cdecl<ID3D11Module*, byte*, ID3D11ModuleInstance**, int>)LpVtbl[3])(@this, pNamespacePtr, ppModuleInstancePtr);
                }
            Marshal.FreeHGlobal((IntPtr)pNamespacePtr);
                return ret;
            }
        }

    }
}
