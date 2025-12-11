# Shader Pipeline (build-shaders & runtime)

Public visé: devs build (CLI `build-shaders`) et devs runtime (`./game/sbox`) qui consomment des `.shader_c`.

## Résumé rapide
- Entrée: `.shader` HLSL.
- Toolchain: DXC → SPIR-V → SPIRV-Cross (dans l’émulation `VfxModule`).
- Sortie attendue: `.shader_c` par profil GLSL/GLSL ES (GL330, GL120/130, ES300, optionnel ES100).
- État actuel (émulation): les bytes sont produits en mémoire (`GenerateResourceBytes`) mais **pas écrits sur disque**; les `.shader_c` doivent donc venir d’un build externe ou on doit ajouter l’écriture.

## Build-shaders (CLI)
Commande: `dotnet run --project ./engine/Tools/SboxBuild/SboxBuild.csproj -- build-shaders --openengine`

Flux actuel:
- `IVfx.CompileShader` génère un `VfxCompiledShaderInfo_t` en mémoire.
- `g_pRsrcCmplrSyst_GenerateResourceBytes` remplit un `CUtlBuffer` puis le buffer est libéré.
- Aucun log “writing …shader_c”, aucun fichier créé.

À ajouter pour être exploitable:
- Écriture `CUtlBuffer → .shader_c` (même base que le `.shader`, extension `.shader_c`; pour multi-profil, suffixer ou séparer par dossier).
- Logs explicites: chemin écrit, taille.
- Option éventuelle: flag `--emit-shaderc` pour forcer la sortie disque.

## Runtime (`./game/sbox`)
- Attend des `.shader_c` présents sur disque.
- `g_pMtrlSystm2_CreateRawMaterial` doit trouver, lire et parser le conteneur `.shader_c`, choisir la variante correspondant au profil GL actif (priorité GL330).
- À implémenter: parsing VCS2 `.shader_c` → extraction GLSL par stage/profil → création shaders/programme OpenGL.

## Profils cibles
- Desktop moderne: GLSL 330 (layout(location), UBO quand dispo).
- Desktop legacy: GLSL 120/130 (pas de layout/UBO).
- Mobile: GLSL ES 300 (optionnel ES 100 avec precision).
- Ordre de fallback recommandé: GL330 > GL120/130 > ES300 > ES100.

## Interfaces natives (interop)
- `CreateInterface`: répondre `VFX_DLL_001` et `filesystem_stdio`.
- `IShaderCompileContext` indices 2200-2201.
- `IVfx` indices 2297-2300.
- `CVfx` dont write path 1262-1263 + création/handles/metadata.
- `CVfxByteCodeManager` (Create / OnStaticCombo / OnDynamicCombo / Delete).
- Binding via `Init(void** native)` depuis `EngineExports.IGenEngine`.

## Tests recommandés
- CLI: `build-shaders --openengine` doit logguer le chemin écrit et la taille pour chaque `.shader_c`.
- Runtime: lancement `./game/sbox`, vérifier que chaque material charge une variante trouvée, sinon fallback ou erreur claire.

## Notes
- Logs `[NativeAOT]` explicites (entrée `.shader`, profil ciblé, taille blob, chemin écrit).
- Pas de crash: si artefact manquant, fallback vers profil inférieur et loguer.

## Support Matrix
- [ ] GLSL 120 (legacy desktop)
- [ ] GLSL 130 (legacy desktop)
- [ ] GLSL 330 (modern desktop)
- [ ] GLSL ES 300 (mobile)
- [ ] GLSL ES 100 (fallback mobile)


## Origine
- Compilation of hlsl is not complete because valve implemented meta data as FEATURES/MODES. You need to write a tool like valve vfx does to correctly parse theses hlsl types.

