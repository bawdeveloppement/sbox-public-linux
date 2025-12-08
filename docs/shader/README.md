# Shader Pipeline Roadmap (OpenGL/GLSL Profiles)

## Goals
- Unblock managed `ShaderCompile` in the emulation layer (libengine2) without crashes.
- Support multiple GLSL/GLSL ES profiles (legacy → desktop → mobile) to cover a wide hardware range and allow targeted builds.
- Let Sandbox auto-select the appropriate profile based on the host machine, with safe fallbacks.

## Target Pipeline
1) Single front-end: HLSL → SPIR-V (DXC).
2) Transpile: SPIR-V → GLSL/GLSL ES via SPIRV-Cross.
3) Output profiles (separate artifacts, e.g., `_c` per profile):
   - Legacy desktop: GLSL 120/130 (no UBO/layout).
   - Modern desktop: GLSL 330 (layout(location), UBO when available).
   - Mobile: GLSL ES 300 (or ES 100 if required) with `precision`.
4) Low-profile limits: no tessellation/geometry/compute; graceful fallbacks.

## Native Surface to Provide (interop)
- `CreateInterface`: answer `VFX_DLL_001` and `filesystem_stdio`, return valid pointers.
- `IShaderCompileContext` (indices 2200-2201): `Delete`, `SetMaskedCode`.
- `IVfx` (indices 2297-2300): `Init`, `CompileShader`, `ClearShaderCache`, `CreateSharedContext`.
- `CVfx` (incl. write path 1262-1263): `CreateFromShaderFile`, `CreateFromResourceFile`, `GetProgramData`, `FinalizeCompile`, `InitializeWrite`, `WriteCombo`, `WriteProgramToBuffer`, handle/filename management.
- `CVfxByteCodeManager`: `Create`, `OnStaticCombo`, `OnDynamicCombo`, `Delete` (no-op acceptable).
- Binding via module `Init(void** native)` called from `EngineExports.IGenEngine` (follow existing pattern).

## “Boot” Mode (stubs)
- Everything must succeed without exceptions: `[NativeAOT]` logs, success returns, empty blobs acceptable.
- Test with `dotnet run --project ./engine/Tools/SboxBuild/SboxBuild.csproj -- build-shaders` or by launching the game; expect `_c` files generated without crashes.

## Real Backend (SPIR-V → GLSL)
- Integrate SPIRV-Cross (x64/ARM binaries). Set emission options per profile (version, es_profile, layout, uniform fallback).
- `IVfx_CompileShader`: HLSL→SPIR-V → SPIRV-Cross → fill `VfxCompiledShaderInfo_t`, write via `WriteCombo`/`WriteProgramToBuffer`.
- Produce one artifact per profile to enable multi-target distribution.

## Profile Selection in Sandbox
- Runtime detection (GPU/APIs available) → pick the highest supported profile with fallback (e.g., priority GL330 > GL120 > ES300 > ES100).
- If a profile artifact is missing, fallback explicitly or emit a clear error.

## Keep This Documentation Updated
- Native index tables (see `engine/Sandbox.Engine/obj/.generated/Interop.Engine.cs`).
- Supported profiles and their limitations.
- Multi-profile build process (commands, expected artifacts).
- Minimal test plan (CLI ShaderCompiler, launching Sandbox with auto-selection).

## Support Matrix (to track completion)
- [ ] GLSL 120 (legacy desktop)
- [ ] GLSL 130 (legacy desktop)
- [ ] GLSL 330 (modern desktop)
- [ ] GLSL ES 300 (mobile)
- [ ] GLSL ES 100 (fallback mobile, if required)

## Decisions (confirmed)
- Real bytecode required (no long-term stub): compile HLSL → SPIR-V → GLSL/GLSL ES and emit usable shaders per profile.
- All profiles above must be supported; use the checklist to mark progress.
- Smoke test command allowed: `dotnet run --project ./engine/Tools/SboxBuild/SboxBuild.csproj -- build-shaders` (or launch the game) to validate pipeline.
