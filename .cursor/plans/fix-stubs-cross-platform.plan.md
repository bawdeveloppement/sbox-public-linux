# Plan correction stubs (cross-plateforme)

## 1) Physics (Bepu) – joints et traces

- Implémenter `IPhysicsWorld_Add*Joint` (weld, spring, revolute, prismatic, spherical, motor, wheel) avec contraintes Bepu v2, gestion des handles via `HandleManager`, validation null, et logs `[NativeAOT]`.
- Remplacer le placeholder de joint par structures Bepu réelles; définir un stockage/cleanup des joints.
- Implémenter `CtlVctrPhyscsTrc_Result_Element` avec un mapping minimal vers une struct managée (ou lever NotImplemented explicite si données manquantes) au lieu de `null`.

## 2) Rendering (OpenGL première passe)

- `EmulatedRenderContext` : lier/binder Vertex/Index buffers (VAO/VBO/EBO), binding textures, render targets (RT / swapchain), mipmaps, instanced draw; retourner bool cohérent.
- `RenderDevice` :  
- Compilation/creation shader OpenGL (`CompileAndCreateShader`) en s’appuyant sur `BasicShaders` comme fallback.  
- Création buffers GPU (`CreateGPUBuffer`) complète (usage, taille, destruction, HandleManager).  
- Textures : `FindOrCreateFileTexture` (chargement minimal via STB/GL), `GetTextureDesc` avec dimensions réelles, tracking swapchain texture, sequence/sheet info (au moins NotImplemented explicite ou valeurs cohérentes).  
- Contextes : remplacer `object` placeholder par struct/context réel ou au moins un wrapper avec GL ref.
- `EmulatedSceneView` : retourner des handles cohérents ou lever NotImplemented explicite pour les layers/render targets.
- `CameraRenderer` : pipeline minimal de rendu vers swapchain/texture et versions stéréo/blit (même simplifiées).

## 3) Input

- Implémenter les mappings `CodeToString`, `StringToButtonCode`, `VirtualKey<->ButtonCode` pour Linux/Windows/macOS (GLFW keycodes) et prévoir Android/iOS plus tard ; éviter retours 0/IntPtr.Zero silencieux.
- IME : lever NotImplemented explicite ou brancher IME GLFW/OSX/Win32 si supporté; ne pas no-op silencieux.
- Cursors : implémenter standard + user cursors (GLFW) et chargement fichier; gérer cleanup.
- InputService : remplir `Key_NameForBinding` et `GetBinding` avec mapping simple ou NotImplemented explicite.

## 4) Resources

- `g_pRsrcSystm_GetAllCodeManifests` : remplir le `CUtlVectorString` natif (P/Invoke helper) ou lever NotImplemented clair si l’API manque, pour éviter log-only.

## 5) Audio / Video

- `DspPreset_Instantiate` : créer des effets OpenAL/Efx réels (ou lever NotImplemented explicite plutôt que handle factice).
- `VideoPlayer` : choisir backend (FFmpeg/MediaCodec/AVFoundation). À défaut, lever NotImplemented sur playback/spectrum plutôt que faux succès; implémenter update temps/décodage minimal si possible.

## 6) Platform

- Compléter la table des ~27 fonctions `Plat_*` manquantes; valider clipboard, résolution, focus, paths, etc., selon OS.

## 7) Tests & cross-plateforme

- Build/publish NativeAOT par OS (linux-x64, win-x64, osx-arm64/x64, android-arm64).  
- Smoke tests : rendu (triangle), physique (joint), input (round-trip mapping), texture load/bind/mipmaps.  
- Vérifier alignement/endianness des structs Interop pour ARM.  
- Documenter NotImplemented restants dans `report.md` ou un changelog et ajouter logs `[NativeAOT]`.