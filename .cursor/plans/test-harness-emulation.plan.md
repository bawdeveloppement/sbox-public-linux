# Mettre à jour les chemins de références (ProjectReference vers Sandbox.Engine.Emulation, packages Silk.NET OpenGLES/Vulkan, etc.).Plan test harness Sandbox.Engine.Emulation

## Objectif

Créer un projet de test isolé pour valider Sandbox.Engine.Emulation sur plusieurs plateformes. Deux axes :

- Desktop (Linux/Windows/macOS) : GL (ou Vulkan plus tard) avec smoke test (clear + triangle).
- Android (net10.0-android) : initialisation GL ES 3 (ou Vulkan si choisi), appel du moteur émulé, détection plateforme, conditionnement du build.

## Étapes

1) Desktop test harness

- Nouveau projet console ou sample (net10.0) référant `Sandbox.Engine.Emulation`.
- Initialisation fenêtre + GL (Silk.NET) ; charge un shader simple ; VBO/IBO ; draw triangle.
- Appeler minimalement EngineExports/RenderDevice pour s’assurer que le bootstrap ne crash pas.
2) Android (OpenEngine2Android)
- Étendre MainActivity pour créer un surface view GL ES 3 (ou choisir Vulkan si disponible, sinon fallback GLES3).
- Charger un shader simple et dessiner un triangle pour valider le contexte.
- Brancher une détection de plateforme (Compilation symbols/RuntimeInformation) pour sélectionner le backend GL ES.
- Référencer `Sandbox.Engine.Emulation` si possible, ou stubber les appels critiques si NativeAOT n’est pas encore prêt sur Android.
3) Conditionnement build multi-OS
- csproj : cibler net10.0 pour desktop, net10.0-android pour mobile ; définir RuntimeIdentifiers appropriés ; conditionner références natives (Silk.NET GL/Vulkan) selon TFM/RuntimeIdentifier.
4) Smoke tests
- Desktop : build + run triangle.
- Android : build apk, lancer sur émulateur/device, vérifier affichage triangle.
5) Documentation
- Ajouter une note dans README ou report sur l’état du test harness et les backends (GL ES 3, Vulkan éventuel).