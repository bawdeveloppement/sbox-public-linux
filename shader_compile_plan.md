# Shader Compile Bridge (HLSL → SPIR-V → SPIRV-Cross) for libengine2

Goal: unblock managed `ShaderCompile` by providing native stubs (`CreateInterface`, `IVfx`, `IShaderCompileContext`, minimal `CVfx` surface) in libengine2, then pave the way for a real SPIR-V → GLSL backend targeting OpenGL/GL ES (old PCs + mobile) with minimal content migration.

## Scope and Priorities
1) Boot-path stubs (no crashes): implement the native surface expected by managed `ShaderCompile` so the CLI and game can run without exceptions, even if the shader bytecode is placeholder.
2) Table binding: wire the correct indices in `EngineExports` to the stubs.
3) Real backend: integrate SPIRV-Cross and emit GLSL/GLSL ES per target profile.

## Required Native Interfaces (from `engine/Sandbox.Engine/obj/.generated/Interop.Engine.cs`)
- Cross-check the generated file for exact indices:
  - `IShaderCompileContext`: 2200 (`Delete`), 2201 (`SetMaskedCode`).
  - `IVfx`: 2297 (`Init`), 2298 (`CompileShader`), 2299 (`ClearShaderCache`), 2300 (`CreateSharedContext`).
  - `CVfx` write path: 1262 (`WriteProgramToBuffer`), 1263 (`WriteCombo`).
- `CVfx` surface used by managed pipeline (indices include 1262-1263 for write, plus create/load):
  - `CreateFromShaderFile`, `CreateFromResourceFile`, `GetProgramData`, `WriteCombo`, `WriteProgramToBuffer`, `FinalizeCompile`, `InitializeWrite`, `CopyStrongHandle`, `DestroyStrongHandle`, `IsStrongHandleValid/Loaded`, `GetBindingPtr`, `GetFilename`.
  - `CVfxByteCodeManager.Create/OnStaticCombo/OnDynamicCombo` are invoked via WriteCombo path.

## Implementation Plan
### 1) CreateInterface routing
- Update `src/Sandbox.Engine.Emulation/CreateInterfaceShim.cs` to:
  - Parse `name` and dispatch to factories for `VFX_DLL_001` and `filesystem_stdio`.
  - Return a valid pointer (handle) to our `IVfx` instance (or FS stub) and write `returnCode=0` on success; return null with `returnCode=1` on unsupported interface.

### 2) IShaderCompileContext stub (indices 2200-2201)
- Class with handle-backed storage:
  - `SetMaskedCode(string)`: store string, log `[NativeAOT]`.
  - `Delete()`: free handle; safe to call multiple times.
- Register handles via `HandleManager` to return stable pointers.

### 3) IVfx stub (indices 2297-2300)
- Methods:
  - `Init(factory)`: accept FS factory pointer; log; return.
  - `CreateSharedContext()`: allocate `IShaderCompileContext` handle; return pointer.
  - `CompileShader(...)`: produce a success `VfxCompiledShaderInfo_t` placeholder (sizes set to zero, pointers null), log inputs, ignore cache flags.
  - `ClearShaderCache()`: no-op + log.
- No crashes; always succeed for now.

### 4) CVfx minimal surface (key indices include 1262-1263)
- Implement the methods used by managed `Shader`/`ProgramSource` pipeline:
  - Creation/load: `CreateFromShaderFile`, `CreateFromResourceFile` → return true, store filename.
  - Strong-handle helpers: `CopyStrongHandle`, `DestroyStrongHandle`, `IsStrongHandleValid/Loaded`, `GetBindingPtr` → return stable handles.
  - Metadata: `GetFilename` → return stored name or empty.
  - Write path: `FinalizeCompile`, `InitializeWrite` → no-op + success.
  - `WriteCombo`: accept program type/static/dynamic and `VfxCompiledShaderInfo_t`; return true.
  - `WriteProgramToBuffer`: write empty buffer (zero-length) to `CUtlBuffer`; return true.
- Backed by simple managed objects registered in `HandleManager`.

### 5) CVfxByteCodeManager stubs
- Provide `Create`, `OnStaticCombo`, `OnDynamicCombo`, `Delete` as no-ops returning/accepting a handle, so `ProgramSource` aggregation succeeds.

### 6) Bind via module `Init(void** native)`
- Respect the existing pattern: each class in `Sandbox.Engine.Emulation` exposes `static void Init(void** native)` and writes into `native[...]` at the indices from `Interop.Engine.cs`; `EngineExports.IGenEngine` only calls these Init methods.
- Add a VFX module (or equivalent) called from `EngineExports` that assigns:
  - `native[2200] = IShaderCompileContext.Delete`
  - `native[2201] = IShaderCompileContext.SetMaskedCode`
  - `native[2297] = IVfx.Init`
  - `native[2298] = IVfx.CompileShader`
  - `native[2299] = IVfx.ClearShaderCache`
  - `native[2300] = IVfx.CreateSharedContext`
  - `native[1262] = CVfx.WriteProgramToBuffer`
  - `native[1263] = CVfx.WriteCombo`
  - And link the other CVfx methods (create/load/handles/metadata) according to their indices in `Interop.Engine.cs`.

### 7) Smoke test (stub mode)
- Run `dotnet run --project ./engine/Tools/SboxBuild/SboxBuild.csproj -- build-shaders` or launch the game.
- Expectation: no exceptions in `ShaderCompile`; `_c` files written (empty payload acceptable for now).

### 8) Real backend (HLSL → SPIR-V → SPIRV-Cross)
- Integrate SPIRV-Cross binaries (x86/x64/ARM).
- Emit GLSL profiles:
  - Desktop fallback: GLSL 120/130 (no UBO/layout).
  - GL 3.3+: GLSL 330 with `layout(location)`.
  - Mobile: GLSL ES 300 (ES 100 if needed) with `precision` qualifiers.
- In `IVfx_CompileShader`:
  - Compile HLSL → SPIR-V (DXC).
  - Run SPIRV-Cross with profile options.
  - Package result into `VfxCompiledShaderInfo_t`, write via `WriteCombo`/`WriteProgramToBuffer`.
- Limit features on old targets: no tessellation/geometry/compute; graceful fallback.

## Notes / Logging
- Prefix logs `[NativeAOT]` for clarity.
- Keep stubs non-throwing; always return success where feasible to unblock the toolchain.
