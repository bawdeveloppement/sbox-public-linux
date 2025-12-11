# Plan render complet (émulation OpenGL)

1) Appel de couche via hooks managés
- Dans `PlatformFunctions.SourceEngineFrame`, utiliser l’import `Sandbox_Graphics_OnLayer` (EngineGlue.Imports) pour les stages utiles (UI = -1, VS/PS/GS/CS) avec un `ManagedRenderSetup_t` complet (renderContext, sceneView/layer, rendertarget/swapchain, viewport, stats, cameraId non nul).
- Optionnel : invoquer aussi les imports pipeline managés `RenderPipeline_InternalAddLayersToView` / `InternalPipelineEnd` (indices 49/50 côté imports) si on veut laisser le pipeline ajouter les layers, puis appeler OnLayer.
- S’assurer que `EngineGlue.StoreImports` est exécuté avant d’utiliser ces pointeurs.

2) Initialisation et ordre interop
- S’assurer que `RenderAttributes.Init` et `RenderDevice/RenderTools.Init` patchent `native[]` avant la copie des pointeurs managés (FillNativeFunctionsEngine), ou relancer la copie après patch si besoin.
- Vérifier via logs la valeur de `native[689]` (CRenderAttributes_Create) avant que le managé s’y accroche.

3) SceneView / SceneLayer / Caméra
- Dans l’émulation SceneSystem, créer/activer une SceneView/SceneLayer par défaut (viewport GLFW), associer la swapchain RenderDevice comme rendertarget.
- Fournir une caméra managée (ManagedCameraId non nul) pour que `Graphics.OnLayer` puisse appeler `IManagedCamera.FindById`.
- Dimensions issues de la fenêtre GLFW (`GetFramebufferSize`), transmettre dans le viewport/rendertarget.

4) RenderDevice / RenderTools
- Assurer un clear + swap fonctionnel (déjà en place).
- Implémenter un chemin de draw minimal dans `RenderTools.Draw` : VAO basique, shader par défaut, VBO quad, projection identitaire.
- Gérer le `RenderAttributes` passé par le matériau : sampler/texture ignorés au début, mais ne pas planter.
- `CopyTexture/Resolve` peuvent rester FBO blit, mais vérifier qu’ils utilisent les textures créées par RenderDevice.

5) Matériaux / shaders par défaut
- Fournir un shader GLSL par défaut (VS/PS) pour le quad de test, chargé au démarrage (ou embarqué).
- `MaterialSystem.CreateRawMaterial` : retourner un matériau avec RenderAttributes valide et shader par défaut si le shader demandé est introuvable.

6) Réduction du bruit
- Limiter les `Console.WriteLine` dans `CRndrttrbts_Create` ou mettre en place un cache/reuse d’attributs pour éviter le spam (mais ne pas bloquer le draw).

7) Validation
- Lancer `./game/sbox` avec `LD_LIBRARY_PATH=./bin/linuxsteamrt64` et vérifier : plus d’exception, fenêtre non noire (quad rendu), logs RenderAttributes non-spam.
- Ajouter un mode debug (flag env) pour tracer les stages/renders sans flood par défaut.
