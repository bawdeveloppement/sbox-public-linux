using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Sandbox.Engine.Emulation.Common;
using Sandbox.Engine.Emulation.CUtl;
using System.Diagnostics;
using System.Text;
using System.IO;
using Sandbox;

namespace Sandbox.Engine.Emulation.Vfx;

/// <summary>
/// Minimal VFX emulation surface to satisfy ShaderCompile. Produces placeholder
/// compiled data (not real GPU bytecode yet).
/// </summary>
public static unsafe class VfxModule
{
    private static void Log(string message) => Console.WriteLine($"[NativeAOT][VFX] {message}");
    private static int _vfxInterfaceHandle;
    private static int _filesystemStubHandle;

    private class VfxContextData
    {
        public string MaskedSource = string.Empty;
    }

    private class VfxCompiledShaderInfoData
    {
        public string CompilerOutput = string.Empty;
        public bool CompileFailed;
        public byte[]? SpirvBytes;
        public string? Glsl;
    }

    private class VfxByteCodeManagerData
    {
        public ulong CurrentStatic;
        public readonly List<VfxCompiledShaderInfoData> Dynamic = new();
    }

    private class VfxComboIteratorData
    {
        public ulong CurrentStatic;
        public ulong CurrentDynamic;
    }

    private class VfxShaderData
    {
        public string FileName = string.Empty;
        public Dictionary<(long program, ulong stat, ulong dyn), VfxCompiledShaderInfoData> Combos = new();
        public CVfxProgramData ProgramData = new();
        public Dictionary<long, VfxCompiledShaderInfoData> ProgramByType = new();
        public HashSet<long> AvailablePrograms = new();
    }

    private class CVfxProgramData
    {
        public int LoadedFromVcsFile;
    }

    public static void Init(void** native)
    {
        // IShaderCompileContext (see Interop.Engine.cs)
        native[2203] = (void*)(delegate* unmanaged<IntPtr, void>)&Ctx_Delete;
        native[2204] = (void*)(delegate* unmanaged<IntPtr, IntPtr, void>)&Ctx_SetMaskedCode;

        // IVfx (see Interop.Engine.cs)
        native[2300] = (void*)(delegate* unmanaged<IntPtr, IntPtr, void>)&IVfx_Init;
        native[2301] = (void*)(delegate* unmanaged<IntPtr, IntPtr, ulong, ulong, IntPtr, long, long, int, uint, IntPtr>)&IVfx_CompileShader;
        native[2302] = (void*)(delegate* unmanaged<IntPtr, void>)&IVfx_ClearShaderCache;
        native[2303] = (void*)(delegate* unmanaged<IntPtr, IntPtr>)&IVfx_CreateSharedContext;

        // CVfx (indices from Interop.Engine.cs)
        native[1246] = (void*)(delegate* unmanaged<IntPtr, IntPtr>)&CVfx_DestroyStrongHandle;
        native[1247] = (void*)(delegate* unmanaged<IntPtr, int>)&CVfx_IsStrongHandleValid;
        native[1248] = (void*)(delegate* unmanaged<IntPtr, int>)&CVfx_IsError;
        native[1249] = (void*)(delegate* unmanaged<IntPtr, int>)&CVfx_IsStrongHandleLoaded;
        native[1250] = (void*)(delegate* unmanaged<IntPtr, IntPtr>)&CVfx_CopyStrongHandle;
        native[1251] = (void*)(delegate* unmanaged<IntPtr, IntPtr>)&CVfx_GetBindingPtr;
        native[1252] = (void*)(delegate* unmanaged<IntPtr, IntPtr>)&CVfx_Create;
        native[1253] = (void*)(delegate* unmanaged<IntPtr, IntPtr>)&CVfx_GetFilename;
        native[1254] = (void*)(delegate* unmanaged<IntPtr, IntPtr, long, uint, int, int>)&CVfx_CreateFromResourceFile;
        native[1255] = (void*)(delegate* unmanaged<IntPtr, IntPtr, long, uint, int>)&CVfx_CreateFromShaderFile;
        native[1256] = (void*)(delegate* unmanaged<IntPtr, long, IntPtr>)&CVfx_GetProgramData;
        native[1257] = (void*)(delegate* unmanaged<IntPtr, long, IntPtr>)&CVfx_GetIterator;
        native[1258] = (void*)(delegate* unmanaged<IntPtr, IntPtr>)&CVfx_Serialize;
        native[1259] = (void*)(delegate* unmanaged<IntPtr, long, int>)&CVfx_HasShaderProgram;
        native[1260] = (void*)(delegate* unmanaged<IntPtr, int>)&CVfx_InitializeWrite;
        native[1261] = (void*)(delegate* unmanaged<IntPtr, int>)&CVfx_FinalizeCompile;
        native[1262] = (void*)(delegate* unmanaged<IntPtr, long, IntPtr, IntPtr, int>)&CVfx_WriteProgramToBuffer;
        native[1263] = (void*)(delegate* unmanaged<IntPtr, long, ulong, ulong, IntPtr, int>)&CVfx_WriteCombo;
        native[1264] = (void*)(delegate* unmanaged<IntPtr, IntPtr>)&CVfx_GetPropertiesJson;

        // CVfxByteCodeManager
        native[1265] = (void*)(delegate* unmanaged<IntPtr>)&CVfxBytCdMngr_Create;
        native[1266] = (void*)(delegate* unmanaged<IntPtr, void>)&CVfxBytCdMngr_Delete;
        native[1267] = (void*)(delegate* unmanaged<IntPtr, ulong, void>)&CVfxBytCdMngr_OnStaticCombo;
        native[1268] = (void*)(delegate* unmanaged<IntPtr, IntPtr, void>)&CVfxBytCdMngr_OnDynamicCombo;
        native[1269] = (void*)(delegate* unmanaged<IntPtr, void>)&CVfxBytCdMngr_Reset;

        // CVfxComboIterator (indices from Interop.Engine.cs)
        native[1276] = (void*)(delegate* unmanaged<IntPtr, void>)&CVfxCmbtrtr_Delete;
        native[1277] = (void*)(delegate* unmanaged<IntPtr, ulong>)&CVfxCmbtrtr_InvalidIndex;
        native[1278] = (void*)(delegate* unmanaged<IntPtr, ulong, ulong>)&CVfxCmbtrtr_SetStaticCombo;
        native[1279] = (void*)(delegate* unmanaged<IntPtr, ulong>)&CVfxCmbtrtr_FirstStaticCombo;
        native[1280] = (void*)(delegate* unmanaged<IntPtr, ulong>)&CVfxCmbtrtr_NextStaticCombo;
        native[1281] = (void*)(delegate* unmanaged<IntPtr, ulong, ulong>)&CVfxCmbtrtr_SetDynamicCombo;
        native[1282] = (void*)(delegate* unmanaged<IntPtr, ulong>)&CVfxCmbtrtr_FirstDynamicCombo;
        native[1283] = (void*)(delegate* unmanaged<IntPtr, ulong>)&CVfxCmbtrtr_NextDynamicCombo;

        // VfxCompiledShaderInfo_t accessors (see Interop.Engine.cs)
        native[2647] = (void*)(delegate* unmanaged<IntPtr, void>)&VfxCmpldShdrnf_t_Delete;
        native[2648] = (void*)(delegate* unmanaged<IntPtr, IntPtr>)&Get__VfxCmpldShdrnf_t_compilerOutput;
        native[2649] = (void*)(delegate* unmanaged<IntPtr, IntPtr, void>)&Set__VfxCmpldShdrnf_t_compilerOutput;
        native[2650] = (void*)(delegate* unmanaged<IntPtr, int>)&Get__VfxCmpldShdrnf_t_compileFailed;
        native[2651] = (void*)(delegate* unmanaged<IntPtr, int, void>)&Set__VfxCmpldShdrnf_t_compileFailed;

        // CVfxProgramData field accessors (see Interop.Engine.cs)
        native[1284] = (void*)(delegate* unmanaged<IntPtr, int>)&Get__CVfxProgramData_m_bLoadedFromVcsFile;
        native[1285] = (void*)(delegate* unmanaged<IntPtr, int, void>)&Set__CVfxProgramData_m_bLoadedFromVcsFile;

        Console.WriteLine("[NativeAOT] VfxModule initialized");
        Log("Init patched VFX/ShaderCompile exports");
    }

    public static IntPtr GetVfxInterface()
    {
        Log("GetVfxInterface");
        if (_vfxInterfaceHandle == 0)
        {
            _vfxInterfaceHandle = HandleManager.Register(new object());
        }
        Log($"GetVfxInterface handle={_vfxInterfaceHandle}");
        return (IntPtr)_vfxInterfaceHandle;
    }

    public static IntPtr GetFilesystemStub()
    {
        Log("GetFilesystemStub");
        if (_filesystemStubHandle == 0)
        {
            _filesystemStubHandle = HandleManager.Register(new object());
        }
        Log($"GetFilesystemStub handle={_filesystemStubHandle}");
        return (IntPtr)_filesystemStubHandle;
    }

    #region IShaderCompileContext
    [UnmanagedCallersOnly]
    private static void Ctx_Delete(IntPtr self)
    {
        Log($"Ctx_Delete self=0x{self.ToInt64():X}");
        if (self == IntPtr.Zero) return;
        HandleManager.Unregister((int)self);
    }

    [UnmanagedCallersOnly]
    private static void Ctx_SetMaskedCode(IntPtr self, IntPtr code)
    {
        Log($"Ctx_SetMaskedCode self=0x{self.ToInt64():X} codeLen={(code==IntPtr.Zero?0:(Marshal.PtrToStringUTF8(code)?.Length ?? 0))}");
        if (self == IntPtr.Zero) return;
        var ctx = HandleManager.Get<VfxContextData>((int)self);
        if (ctx == null) return;
        ctx.MaskedSource = code == IntPtr.Zero ? string.Empty : Marshal.PtrToStringUTF8(code) ?? string.Empty;
    }
    #endregion

    #region IVfx
    [UnmanagedCallersOnly]
    private static void IVfx_Init(IntPtr self, IntPtr factory)
    {
        // Factory is unused in emulation; accept and return.
        Log($"IVfx_Init self=0x{self.ToInt64():X} factory=0x{factory.ToInt64():X}");
    }

    [UnmanagedCallersOnly]
    private static IntPtr IVfx_CreateSharedContext(IntPtr self)
    {
        Log($"IVfx_CreateSharedContext self=0x{self.ToInt64():X}");
        
        var ctx = new VfxContextData();
        int handle = HandleManager.Register(ctx);
        Log($"IVfx_CreateSharedContext handle={handle}");
        return handle == 0 ? IntPtr.Zero : (IntPtr)handle;
    }

    [UnmanagedCallersOnly]
    private static void IVfx_ClearShaderCache(IntPtr self)
    {
        Log($"IVfx_ClearShaderCache self=0x{self.ToInt64():X}");
        // No-op stub.
    }

    [UnmanagedCallersOnly]
    private static IntPtr IVfx_CompileShader(IntPtr self, IntPtr ctxPtr, ulong staticcombo, ulong dynamiccombo, IntPtr pVfx, long compileTarget, long programType, int useShaderCache, uint flags)
    {
        Log($"IVfx_CompileShader self=0x{self.ToInt64():X} ctx=0x{ctxPtr.ToInt64():X} static={staticcombo} dynamic={dynamiccombo} pVfx=0x{pVfx.ToInt64():X} target={compileTarget} prog={programType} cache={useShaderCache} flags={flags}");
        var info = new VfxCompiledShaderInfoData();
        try
        {
            var ctx = HandleManager.Get<VfxContextData>((int)ctxPtr);
            var shaderData = HandleManager.Get<VfxShaderData>((int)pVfx);

            var source = ctx?.MaskedSource ?? string.Empty;
            var stage = (ShaderProgramType)programType;

            var dxcPath = FindToolPath("dxc");
            var spvcPath = FindToolPath("spirv-cross");

            // Write HLSL to temp
            var hlslFile = Path.GetTempFileName();
            File.WriteAllText(hlslFile, source, Encoding.UTF8);
            var spvFile = Path.GetTempFileName();
            var glslFile = Path.GetTempFileName();

            try
            {
                var dxcArgs = BuildDxcArgs(stage, hlslFile, spvFile);
                var dxcRes = RunTool(dxcPath, dxcArgs);
                info.CompilerOutput = dxcRes.Stdout + dxcRes.Stderr;
                info.CompileFailed = !dxcRes.Success;

                if (!info.CompileFailed && File.Exists(spvFile))
                {
                    info.SpirvBytes = File.ReadAllBytes(spvFile);

                    var spvcArgs = BuildSpirvCrossArgs(stage, spvFile, glslFile);
                    var spvcRes = RunTool(spvcPath, spvcArgs);
                    info.CompilerOutput += spvcRes.Stdout + spvcRes.Stderr;
                    info.CompileFailed = !spvcRes.Success;

                    if (!info.CompileFailed)
                    {
                        if (File.Exists(glslFile))
                            info.Glsl = File.ReadAllText(glslFile, Encoding.UTF8);
                    }
                }
            }
            finally
            {
                TryDelete(hlslFile);
                TryDelete(spvFile);
                TryDelete(glslFile);
            }

            // Register GLSL per program type for later serialization
            if (shaderData != null && !info.CompileFailed)
            {
                shaderData.ProgramByType[(long)stage] = info;
            }
        }
        catch (Exception ex)
        {
            info.CompilerOutput = "[NativeAOT][VFX] Compile error: " + ex;
            info.CompileFailed = true;
        }

        int handle = HandleManager.Register(info);
        return handle == 0 ? IntPtr.Zero : (IntPtr)handle;
    }
    #endregion

    #region CVfx
    [UnmanagedCallersOnly]
    private static IntPtr CVfx_DestroyStrongHandle(IntPtr self)
    {
        Log($"CVfx_DestroyStrongHandle self=0x{self.ToInt64():X}");
        if (self != IntPtr.Zero)
        {
            HandleManager.Unregister((int)self);
        }
        return IntPtr.Zero;
    }

    [UnmanagedCallersOnly]
    private static int CVfx_IsStrongHandleValid(IntPtr self)
    {
        var ok = HandleManager.Get<VfxShaderData>((int)self) != null ? 1 : 0;
        Log($"CVfx_IsStrongHandleValid self=0x{self.ToInt64():X} -> {ok}");
        return ok;
    }

    [UnmanagedCallersOnly]
    private static int CVfx_IsError(IntPtr self)
    {
        Log($"CVfx_IsError self=0x{self.ToInt64():X}");
        return 0;
    }

    [UnmanagedCallersOnly]
    private static int CVfx_IsStrongHandleLoaded(IntPtr self)
    {
        Log($"CVfx_IsStrongHandleLoaded self=0x{self.ToInt64():X}");
        return 1;
    }

    [UnmanagedCallersOnly]
    private static IntPtr CVfx_CopyStrongHandle(IntPtr self)
    {
        Log($"CVfx_CopyStrongHandle self=0x{self.ToInt64():X}");
        return self;
    }

    [UnmanagedCallersOnly]
    private static IntPtr CVfx_GetBindingPtr(IntPtr self)
    {
        Log($"CVfx_GetBindingPtr self=0x{self.ToInt64():X}");
        return self;
    }

    [UnmanagedCallersOnly]
    private static IntPtr CVfx_Create(IntPtr debugName)
    {
        Log($"CVfx_Create debugName='{(debugName==IntPtr.Zero?string.Empty:Marshal.PtrToStringUTF8(debugName))}'");
        var data = new VfxShaderData
        {
            FileName = debugName == IntPtr.Zero ? string.Empty : Marshal.PtrToStringUTF8(debugName) ?? string.Empty
        };
        int handle = HandleManager.Register(data);
        Log($"CVfx_Create handle={handle}");
        return handle == 0 ? IntPtr.Zero : (IntPtr)handle;
    }


    [UnmanagedCallersOnly]
    private static IntPtr CVfx_GetFilename(IntPtr self)
    {
        Log($"CVfx_GetFilename self=0x{self.ToInt64():X}");
        var data = HandleManager.Get<VfxShaderData>((int)self);
        if (data == null) return IntPtr.Zero;
        return Marshal.StringToHGlobalAnsi(data.FileName ?? string.Empty);
    }

    [UnmanagedCallersOnly]
    private static int CVfx_CreateFromResourceFile(IntPtr self, IntPtr pShaderFile, long compileTarget, uint nCreateFlags, int bFailSilently)
    {
        Log($"CVfx_CreateFromResourceFile self=0x{self.ToInt64():X} file='{(pShaderFile==IntPtr.Zero?string.Empty:Marshal.PtrToStringUTF8(pShaderFile))}' target={compileTarget} flags={nCreateFlags} failSilent={bFailSilently}");
        var data = HandleManager.Get<VfxShaderData>((int)self);
        if (data != null)
        {
            data.FileName = pShaderFile == IntPtr.Zero ? string.Empty : Marshal.PtrToStringUTF8(pShaderFile) ?? string.Empty;
        }
        return 1;
    }

    [UnmanagedCallersOnly]
    private static int CVfx_CreateFromShaderFile(IntPtr self, IntPtr pShaderFile, long compileTarget, uint nCreateFlags)
    {
        Log($"CVfx_CreateFromShaderFile self=0x{self.ToInt64():X} file='{(pShaderFile==IntPtr.Zero?string.Empty:Marshal.PtrToStringUTF8(pShaderFile))}' target={compileTarget} flags={nCreateFlags}");
        var data = HandleManager.Get<VfxShaderData>((int)self);
        if (data != null)
        {
            data.FileName = pShaderFile == IntPtr.Zero ? string.Empty : Marshal.PtrToStringUTF8(pShaderFile) ?? string.Empty;
        }
        return 1;
    }

    [UnmanagedCallersOnly]
    private static IntPtr CVfx_GetProgramData(IntPtr self, long pass)
    {
        Log($"CVfx_GetProgramData self=0x{self.ToInt64():X} pass={pass}");
        var data = HandleManager.Get<VfxShaderData>((int)self);
        int handle = data != null ? HandleManager.Register(data.ProgramData) : 0;
        return handle == 0 ? IntPtr.Zero : (IntPtr)handle;
    }

    [UnmanagedCallersOnly]
    private static IntPtr CVfx_GetIterator(IntPtr self, long program)
    {
        Log($"CVfx_GetIterator self=0x{self.ToInt64():X} program={program}");
        int handle = HandleManager.Register(new VfxComboIteratorData());
        return handle == 0 ? IntPtr.Zero : (IntPtr)handle;
    }

    [UnmanagedCallersOnly]
    private static IntPtr CVfx_Serialize(IntPtr self)
    {
        Log($"CVfx_Serialize self=0x{self.ToInt64():X}");
        // Return an empty CUtlBuffer handle (managed allocation)
        var bufferData = new global::Sandbox.Engine.Emulation.CUtl.CUtlBuffer.BufferData
        {
            DataPtr = IntPtr.Zero,
            Size = 0,
            MaxPut = 0
        };
        int handle = HandleManager.Register(bufferData);
        return handle == 0 ? IntPtr.Zero : (IntPtr)handle;
    }

    [UnmanagedCallersOnly]
    private static int CVfx_HasShaderProgram(IntPtr self, long programType)
    {
        var data = HandleManager.Get<VfxShaderData>((int)self);
        var has = data != null && data.AvailablePrograms.Contains(programType) ? 1 : 0;
        Log($"CVfx_HasShaderProgram self=0x{self.ToInt64():X} program={programType} -> {has}");
        return has;
    }

    [UnmanagedCallersOnly]
    private static int CVfx_InitializeWrite(IntPtr self)
    {
        Log($"CVfx_InitializeWrite self=0x{self.ToInt64():X}");
        return 1;
    }

    [UnmanagedCallersOnly]
    private static int CVfx_FinalizeCompile(IntPtr self)
    {
        Log($"CVfx_FinalizeCompile self=0x{self.ToInt64():X}");
        return 1;
    }

    [UnmanagedCallersOnly]
    private static int CVfx_WriteProgramToBuffer(IntPtr self, long programType, IntPtr byteCodeManagerPtr, IntPtr outBufferPtr)
    {
        Log($"CVfx_WriteProgramToBuffer self=0x{self.ToInt64():X} program={programType} bcm=0x{byteCodeManagerPtr.ToInt64():X} outBuf=0x{outBufferPtr.ToInt64():X}");
        var buffer = HandleManager.Get<global::Sandbox.Engine.Emulation.CUtl.CUtlBuffer.BufferData>((int)outBufferPtr);
        var shader = HandleManager.Get<VfxShaderData>((int)self);
        if (buffer == null || shader == null) return 0;

        var data = shader.ProgramByType.TryGetValue(programType, out var info) ? info.Glsl ?? string.Empty : string.Empty;
        var bytes = Encoding.UTF8.GetBytes(data);

        buffer.Size = bytes.Length;
        buffer.MaxPut = bytes.Length;
        if (buffer.DataPtr != IntPtr.Zero)
        {
            Marshal.FreeHGlobal(buffer.DataPtr);
        }
        buffer.DataPtr = Marshal.AllocHGlobal(buffer.Size);
        Marshal.Copy(bytes, 0, buffer.DataPtr, buffer.Size);
        return 1;
    }

    [UnmanagedCallersOnly]
    private static int CVfx_WriteCombo(IntPtr self, long programType, ulong staticId, ulong dynamicId, IntPtr shaderInfoPtr)
    {
        Log($"CVfx_WriteCombo self=0x{self.ToInt64():X} program={programType} static={staticId} dynamic={dynamicId} shaderInfo=0x{shaderInfoPtr.ToInt64():X}");
        var shaderInfo = HandleManager.Get<VfxCompiledShaderInfoData>((int)shaderInfoPtr);
        // Store association if available
        var shader = HandleManager.Get<VfxShaderData>((int)self);
        if (shader != null && shaderInfo != null)
        {
            shader.Combos[(programType, staticId, dynamicId)] = shaderInfo;
            shader.ProgramByType[programType] = shaderInfo;
            shader.AvailablePrograms.Add(programType);
        }
        return 1;
    }

    [UnmanagedCallersOnly]
    private static IntPtr CVfx_GetPropertiesJson(IntPtr self)
    {
        // Return empty JSON object
        Log($"CVfx_GetPropertiesJson self=0x{self.ToInt64():X}");
        return Marshal.StringToHGlobalAnsi("{}");
    }
    #endregion

    #region CVfxByteCodeManager
    [UnmanagedCallersOnly]
    private static IntPtr CVfxBytCdMngr_Create()
    {
        Log("CVfxBytCdMngr_Create");
        int handle = HandleManager.Register(new VfxByteCodeManagerData());
        Log($"CVfxBytCdMngr_Create handle={handle}");
        return handle == 0 ? IntPtr.Zero : (IntPtr)handle;
    }

    [UnmanagedCallersOnly]
    private static void CVfxBytCdMngr_Delete(IntPtr self)
    {
        Log($"CVfxBytCdMngr_Delete self=0x{self.ToInt64():X}");
        if (self != IntPtr.Zero)
        {
            HandleManager.Unregister((int)self);
        }
    }

    [UnmanagedCallersOnly]
    private static void CVfxBytCdMngr_OnStaticCombo(IntPtr self, ulong id)
    {
        Log($"CVfxBytCdMngr_OnStaticCombo self=0x{self.ToInt64():X} id={id}");
        var mgr = HandleManager.Get<VfxByteCodeManagerData>((int)self);
        if (mgr != null)
        {
            mgr.CurrentStatic = id;
        }
    }

    [UnmanagedCallersOnly]
    private static void CVfxBytCdMngr_OnDynamicCombo(IntPtr self, IntPtr dataPtr)
    {
        Log($"CVfxBytCdMngr_OnDynamicCombo self=0x{self.ToInt64():X} data=0x{dataPtr.ToInt64():X}");
        var mgr = HandleManager.Get<VfxByteCodeManagerData>((int)self);
        var info = HandleManager.Get<VfxCompiledShaderInfoData>((int)dataPtr);
        if (mgr != null && info != null)
        {
            mgr.Dynamic.Add(info);
        }
    }

    [UnmanagedCallersOnly]
    private static void CVfxBytCdMngr_Reset(IntPtr self)
    {
        Log($"CVfxBytCdMngr_Reset self=0x{self.ToInt64():X}");
        var mgr = HandleManager.Get<VfxByteCodeManagerData>((int)self);
        if (mgr != null)
        {
            mgr.CurrentStatic = 0;
            mgr.Dynamic.Clear();
        }
    }
    #endregion

    #region VfxCompiledShaderInfo_t accessors
    [UnmanagedCallersOnly]
    private static void VfxCmpldShdrnf_t_Delete(IntPtr self)
    {
        Log($"VfxCmpldShdrnf_t_Delete self=0x{self.ToInt64():X}");
        if (self != IntPtr.Zero)
        {
            HandleManager.Unregister((int)self);
        }
    }

    [UnmanagedCallersOnly]
    private static IntPtr Get__VfxCmpldShdrnf_t_compilerOutput(IntPtr self)
    {
        Log($"Get__VfxCmpldShdrnf_t_compilerOutput self=0x{self.ToInt64():X}");
        var info = HandleManager.Get<VfxCompiledShaderInfoData>((int)self);
        return info == null ? IntPtr.Zero : Marshal.StringToHGlobalAnsi(info.CompilerOutput ?? string.Empty);
    }

    [UnmanagedCallersOnly]
    private static void Set__VfxCmpldShdrnf_t_compilerOutput(IntPtr self, IntPtr value)
    {
        Log($"Set__VfxCmpldShdrnf_t_compilerOutput self=0x{self.ToInt64():X}");
        var info = HandleManager.Get<VfxCompiledShaderInfoData>((int)self);
        if (info == null) return;
        info.CompilerOutput = value == IntPtr.Zero ? string.Empty : Marshal.PtrToStringUTF8(value) ?? string.Empty;
    }

    [UnmanagedCallersOnly]
    private static int Get__VfxCmpldShdrnf_t_compileFailed(IntPtr self)
    {
        Log($"Get__VfxCmpldShdrnf_t_compileFailed self=0x{self.ToInt64():X}");
        var info = HandleManager.Get<VfxCompiledShaderInfoData>((int)self);
        return info != null && info.CompileFailed ? 1 : 0;
    }

    [UnmanagedCallersOnly]
    private static void Set__VfxCmpldShdrnf_t_compileFailed(IntPtr self, int value)
    {
        Log($"Set__VfxCmpldShdrnf_t_compileFailed self=0x{self.ToInt64():X} value={value}");
        var info = HandleManager.Get<VfxCompiledShaderInfoData>((int)self);
        if (info == null) return;
        info.CompileFailed = value != 0;
    }
    #endregion

    #region CVfxProgramData accessors
    [UnmanagedCallersOnly]
    private static int Get__CVfxProgramData_m_bLoadedFromVcsFile(IntPtr self)
    {
        Log($"Get__CVfxProgramData_m_bLoadedFromVcsFile self=0x{self.ToInt64():X}");
        var data = HandleManager.Get<CVfxProgramData>((int)self);
        return data?.LoadedFromVcsFile ?? 0;
    }

    [UnmanagedCallersOnly]
    private static void Set__CVfxProgramData_m_bLoadedFromVcsFile(IntPtr self, int value)
    {
        Log($"Set__CVfxProgramData_m_bLoadedFromVcsFile self=0x{self.ToInt64():X} value={value}");
        var data = HandleManager.Get<CVfxProgramData>((int)self);
        if (data != null)
        {
            data.LoadedFromVcsFile = value;
        }
    }
    #endregion

    #region CVfxComboIterator
    [UnmanagedCallersOnly]
    private static void CVfxCmbtrtr_Delete(IntPtr self)
    {
        Log($"CVfxCmbtrtr_Delete self=0x{self.ToInt64():X}");
        if (self != IntPtr.Zero)
        {
            HandleManager.Unregister((int)self);
        }
    }

    private const ulong InvalidComboIndex = ulong.MaxValue;
    private static readonly Dictionary<ShaderProgramType, string> DxcTargets = new()
    {
        { ShaderProgramType.VFX_PROGRAM_VS, "vs_6_0" },
        { ShaderProgramType.VFX_PROGRAM_PS, "ps_6_0" },
        { ShaderProgramType.VFX_PROGRAM_CS, "cs_6_0" },
    };

    [UnmanagedCallersOnly]
    private static ulong CVfxCmbtrtr_InvalidIndex(IntPtr self)
    {
        Log($"CVfxCmbtrtr_InvalidIndex self=0x{self.ToInt64():X}");
        return InvalidComboIndex;
    }

    [UnmanagedCallersOnly]
    private static ulong CVfxCmbtrtr_SetStaticCombo(IntPtr self, ulong c)
    {
        Log($"CVfxCmbtrtr_SetStaticCombo self=0x{self.ToInt64():X} c={c}");
        var it = HandleManager.Get<VfxComboIteratorData>((int)self);
        if (it != null) it.CurrentStatic = c;
        return c;
    }

    [UnmanagedCallersOnly]
    private static ulong CVfxCmbtrtr_FirstStaticCombo(IntPtr self)
    {
        Log($"CVfxCmbtrtr_FirstStaticCombo self=0x{self.ToInt64():X}");
        // No static combos available in stub: return invalid
        return InvalidComboIndex;
    }

    [UnmanagedCallersOnly]
    private static ulong CVfxCmbtrtr_NextStaticCombo(IntPtr self)
    {
        Log($"CVfxCmbtrtr_NextStaticCombo self=0x{self.ToInt64():X}");
        // No iteration; always invalid
        return InvalidComboIndex;
    }

    [UnmanagedCallersOnly]
    private static ulong CVfxCmbtrtr_SetDynamicCombo(IntPtr self, ulong c)
    {
        Log($"CVfxCmbtrtr_SetDynamicCombo self=0x{self.ToInt64():X} c={c}");
        var it = HandleManager.Get<VfxComboIteratorData>((int)self);
        if (it != null) it.CurrentDynamic = c;
        return c;
    }

    [UnmanagedCallersOnly]
    private static ulong CVfxCmbtrtr_FirstDynamicCombo(IntPtr self)
    {
        Log($"CVfxCmbtrtr_FirstDynamicCombo self=0x{self.ToInt64():X}");
        return InvalidComboIndex;
    }

    [UnmanagedCallersOnly]
    private static ulong CVfxCmbtrtr_NextDynamicCombo(IntPtr self)
    {
        Log($"CVfxCmbtrtr_NextDynamicCombo self=0x{self.ToInt64():X}");
        return InvalidComboIndex;
    }
    #endregion

    #region Tool helpers
    private struct ToolResult
    {
        public bool Success;
        public string Stdout;
        public string Stderr;
    }

    private static string FindToolPath(string toolName)
    {
        // Allow env override: DXC_PATH / SPVC_PATH
        var env = Environment.GetEnvironmentVariable(toolName.ToUpperInvariant() + "_PATH");
        if (!string.IsNullOrEmpty(env) && File.Exists(env))
            return env;

        // Try alongside executable (linuxsteamrt64)
        var baseDir = AppContext.BaseDirectory ?? Directory.GetCurrentDirectory();
        var candidate = Path.GetFullPath(Path.Combine(baseDir, "..", "linuxsteamrt64", toolName));
        if (File.Exists(candidate))
            return candidate;

        return toolName; // fallback to PATH
    }

    private static string BuildDxcArgs(ShaderProgramType stage, string hlslPath, string spvOut)
    {
        var target = DxcTargets.TryGetValue(stage, out var t) ? t : "cs_6_0";
        return $"-spirv -T {target} -E main -Fo \"{spvOut}\" \"{hlslPath}\"";
    }

    private static string BuildSpirvCrossArgs(ShaderProgramType stage, string spvPath, string glslOut)
    {
        var version = "--version 330";
        var args = new StringBuilder();
        args.Append($"{version} ");
        switch (stage)
        {
            case ShaderProgramType.VFX_PROGRAM_VS:
                args.Append("--vertex ");
                break;
            case ShaderProgramType.VFX_PROGRAM_PS:
                args.Append("--fragment ");
                break;
            case ShaderProgramType.VFX_PROGRAM_CS:
                // spirv-cross will detect compute; no extra flag needed
                break;
        }
        args.Append($"\"{spvPath}\" --output \"{glslOut}\"");
        return args.ToString();
    }

    private static ToolResult RunTool(string tool, string args)
    {
        var psi = new ProcessStartInfo
        {
            FileName = tool,
            Arguments = args,
            UseShellExecute = false,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            CreateNoWindow = true
        };

        var stdout = new StringBuilder();
        var stderr = new StringBuilder();

        try
        {
            using var p = Process.Start(psi);
            if (p == null) return new ToolResult { Success = false, Stdout = "", Stderr = $"Failed to start {tool}" };
            p.OutputDataReceived += (_, e) => { if (e.Data != null) stdout.AppendLine(e.Data); };
            p.ErrorDataReceived += (_, e) => { if (e.Data != null) stderr.AppendLine(e.Data); };
            p.BeginOutputReadLine();
            p.BeginErrorReadLine();
            p.WaitForExit();
            return new ToolResult
            {
                Success = p.ExitCode == 0,
                Stdout = stdout.ToString(),
                Stderr = stderr.ToString()
            };
        }
        catch (Exception ex)
        {
            return new ToolResult { Success = false, Stdout = stdout.ToString(), Stderr = ex.ToString() };
        }
    }

    private static void TryDelete(string path)
    {
        try
        {
            if (!string.IsNullOrEmpty(path) && File.Exists(path))
                File.Delete(path);
        }
        catch { }
    }
    #endregion
}
