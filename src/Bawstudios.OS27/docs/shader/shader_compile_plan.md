# Shader Compile Bridge (HLSL → SPIR-V → SPIRV-Cross) for libengine2

Objectif: décrire clairement le flux build-shaders (CLI) et la consommation runtime (`./game/sbox`), en tenant compte de l’état actuel: la commande retourne des buffers en mémoire mais n’écrit pas encore de `.shader_c` sur disque dans l’émulation.

## Vue d’ensemble
- Entrée: fichiers `.shader` HLSL.
- Toolchain: DXC → SPIR-V → SPIRV-Cross (émulé dans `VfxModule`).
- Sortie attendue (idéal): fichiers `.shader_c` par profil GLSL/GLSL ES (GL330, GL120/130, ES300, éventuellement ES100), lisibles par le runtime.
- État actuel (émulation): `GenerateResourceBytes` renvoie des bytes en mémoire (`CUtlBuffer`) puis libère; aucune écriture disque. Les `.shader_c` doivent donc provenir d’un build externe ou être ajoutés dans l’émulation.

## Interfaces natives clés (indices depuis `engine/Sandbox.Engine/obj/.generated/Interop.Engine.cs`)
- `IShaderCompileContext`: 2200 (`Delete`), 2201 (`SetMaskedCode`)
- `IVfx`: 2297 (`Init`), 2298 (`CompileShader`), 2299 (`ClearShaderCache`), 2300 (`CreateSharedContext`)
- `CVfx` (dont write path): 1262 (`WriteProgramToBuffer`), 1263 (`WriteCombo`), et aussi `CreateFromShaderFile`, `CreateFromResourceFile`, `GetProgramData`, `FinalizeCompile`, `InitializeWrite`, `CopyStrongHandle`, `DestroyStrongHandle`, `IsStrongHandleValid/Loaded`, `GetBindingPtr`, `GetFilename`
- `CVfxByteCodeManager`: `Create`, `OnStaticCombo`, `OnDynamicCombo`, `Delete`

## Flux build-shaders (commande CLI)
Commande: `dotnet run --project ./engine/Tools/SboxBuild/SboxBuild.csproj -- build-shaders --openengine`

Ce que fait l’émulation actuellement:
- Appelle `IVfx.CompileShader` → génère un `VfxCompiledShaderInfo_t` en mémoire.
- Appelle `g_pRsrcCmplrSyst_GenerateResourceBytes` → remplit un `CUtlBuffer` en mémoire.
- Libère ensuite le buffer. Aucun log “writing …shader_c”, aucun fichier créé.

Ce qui manque pour une sortie disque exploitable:
- Écrire le contenu du `CUtlBuffer` vers un fichier `.shader_c` (chemin à définir: idéalement à côté du `.shader` source ou dans `game/addons/.../Assets/...`).
- Nom d’artefact recommandé: même base que `.shader`, extension `.shader_c`; pour multi-profil, suffixer (ex: `.glsl330.shader_c`, `.glsl120.shader_c`, `.gles300.shader_c`), ou structurer en sous-dossiers par profil.
- Logger explicitement: `writing <path> size=<n>` pour traçabilité.

## Flux runtime (`./game/sbox`)
- La matérialisation attend des `.shader_c` déjà présents sur disque.
- `g_pMtrlSystm2_CreateRawMaterial` doit localiser, lire et parser le conteneur `.shader_c`, puis choisir la variante correspondant au profil GL actif (GL330 prioritaire ici).
- Reste à implémenter: parsing du format `.shader_c` (VCS2) pour extraire les blocs GLSL par stage/profil, création des shaders OpenGL et du program.

## Prochaines étapes recommandées
1) **Sortie disque dans build-shaders**: ajouter une écriture `CUtlBuffer → .shader_c`, logs clairs, et (optionnel) un paramètre `--emit-shaderc` pour forcer la sortie.
2) **Multi-profil**: produire plusieurs artefacts ou un conteneur multi-profils; documenter la sélection (ordre: GL330 > GL120/130 > ES300 > ES100).
3) **Runtime loader**: dans `MaterialSystem` au moment où on crée un material, parser `.shader_c`, extraire la variante GL330 et créer les shaders OpenGL. Documenter la responsabilité mémoire et les erreurs. La struct Material doit rester iso avec la struct Material côté moteur (bindings/fields attendus) pour éviter les divergences.
4) **Tests**:
   - CLI: `build-shaders --openengine` doit écrire des `.shader_c` et logguer les chemins.
   - Runtime: lancer `./game/sbox`, vérifier que chaque material charge une variante trouvée et loggue le profil choisi.

## Notes / Logging
- Garder les logs `[NativeAOT][VFX]`/`[NativeAOT][RC]` explicites: entrée `.shader`, profil ciblé, taille des blobs, chemin écrit.
- Éviter les crashs: fallback profil inférieur si artefact manquant, signaler clairement dans les logs.
