# État des fichiers non commités

## Modifiés
- `engine/Sandbox.Engine/Systems/Render/ShaderCompile/ShaderCompile.cs` : résolution du chargement de libengine2.so, retrieval CreateInterface direct, init EngineFileSystem, suppression garde dedicated server, logs/paths ajustés.
- `engine/Sandbox.Tools/Interop.Animgraph.cs` / `Interop.AssetSystem.cs` / `Interop.Hammer.cs` / `Interop.ModelDoc.cs` / `Interop.Tools.cs` : mises à jour mineures de signatures/usings/generated (interop tools).
- `engine/Tools/SboxBuild/Program.cs` : ajustements CLI/build (propagation options publish/aot/disable android).
- `engine/Tools/SboxBuild/Steps/BuildManaged.cs` : propagation DisableAndroidTFM et options build managé, gestion flags supplémentaires.
- `engine/Tools/SboxBuild/Steps/BuildShaders.cs` : ajustements pipeline build shaders (args/out paths/logs).
- `engine/Tools/ShaderCompiler/Program.cs` : intégration/ajustements compilation HLSL→SPIR-V/GLSL (DXC/SPIRV-Cross) et gestion erreurs/logs.
- `docs/report_calls_tree.md` : notes/arbre d’appels enrichi.
- `src/Bawstudios.OS27/Audio/DspPreset.cs` : complétion presets DSP, add processors/handles et gestion création.
- `src/Bawstudios.OS27/CreateInterfaceShim.cs` : rooting explicite du shim CreateInterface exporté.
- `src/Bawstudios.OS27/EngineExports.cs` : ordre d’init modules ajusté (RenderAttributes avant MaterialSystem), rooting CreateInterfaceShim, calls supplémentaires.
- `src/Bawstudios.OS27/EngineGlue.cs` : mise à jour mapping de delegates/imports (RenderTarget_Flush, OnSceneViewSubmitted, etc.), nombreuses signatures.
- `src/Bawstudios.OS27/Generated/engine.Generated.cs` : petite mise à jour générée (1 ligne). 
- `src/Bawstudios.OS27/Physics/PhysicsSystem.cs` : enregistrement correct dans HandleManager/HandleIndex, world map par BindingHandle, fix Imports → EngineGlue.Imports.
- `src/Bawstudios.OS27/Physics/PhysicsWorld.cs` : commentaire/clarification bindingHandle.
- `src/Bawstudios.OS27/Platform/PlatformFunctions.cs` : SourceEngineFrame revisité (bind swapchain FBO, SafeCall* pipeline, flush rendertarget, OnSceneViewSubmitted, logs).
- `src/Bawstudios.OS27/RenderAttributes/RenderAttributes.cs` : logs throttle stacktrace sur création massive.
- `src/Bawstudios.OS27/Rendering/EmulatedRenderContext.cs` : bind swapchain si dispo, fallback DrawQuad, viewport/buffers/shader basiques.
- `src/Bawstudios.OS27/Rendering/EmulatedSceneLayer.cs` : mise à jour viewport/output gestion swapchain.
- `src/Bawstudios.OS27/Rendering/EmulatedSceneView.cs` : cache LayersByName, réutilisation layers, update viewport/swapchain.
- `src/Bawstudios.OS27/Rendering/RenderDevice.cs` : gestion swapchain (FBO, BindSwapChainForRender, PresentManaged), throttle logs compile shader.
- `src/Bawstudios.OS27/Rendering/RenderTools.cs` : logs first-call, fallback quad/cube, route draw/model/sceneobject minimal, structs de base.
- `src/Bawstudios.OS27/Scene/SceneSystem.cs` : réutilisation SceneView/SceneLayer actifs, set output swapchain, stats ptr.

## Commit title/description (EN)
**Title**: “Implement NativeAOT render/physics pipeline wiring and shader tooling”

**Description**:
- Replace stubbed native interop paths: load `CreateInterface` via direct export, initialize EngineFileSystem, reorder module init to fix physics/world handles.
- Propagate DisableAndroidTFM and shader compile flags through SboxBuild steps; enhance shader compilation (DXC/SPIRV-Cross) and ShaderTools masking/includes.
- Add robust render pipeline wiring: swapchain FBO bind/present, SafeCall RenderPipeline/OnLayer, RenderTarget flush, SceneView/SceneLayer reuse and caching, stats pointer hookup.
- Emulate RenderDevice/RenderTools with fallback quad/cube draw, basic GL context setup, swapchain texture/FBO management, and throttled logging.
- Extend audio/physics/material handling (DSP presets, PhysicsWorld handle registration) and adjust generated interop mappings/delegates.
- Add plans/docs and logs for current investigative runs (game_output/test2) and call-tree notes.
