# Plan de Refactorisation et Implémentation

## Objectifs

1. **Implémenter CCameraRenderer** : Fonctions natives requises pour `IManagedCamera` utilisées dans `Graphics.OnLayer` (PRIORITAIRE - bug actuel)
2. **Réfactoriser EngineExports.cs** : Séparer en modules par scope avec méthode `Init(void** native)` pour chaque module
3. **Migrer les fonctions existantes** : Déplacer toutes les fonctions déjà implémentées dans `EngineExports.cs` vers leurs modules respectifs
4. **Mettre à jour les règles Cursor** : Documenter la nouvelle architecture modulaire et le graphe de dépendances
5. **Identifier et documenter toutes les fonctions non implémentées** : Créer un inventaire complet pour implémentation future
6. **Organiser la catégorie "Other"** : Catégoriser les 1443 fonctions par préfixes logiques (ex: `CnvMpScnbjct` = CanvasMapSceneObject)

## Structure des Modules

Chaque module sera dans `src/Sbox.Engine.Emulation/` avec la structure suivante :

```
src/Sbox.Engine.Emulation/
├── EngineExports.cs (point d'entrée, appelle les Init())
├── Camera/
│   └── CameraRenderer.cs (CCameraRenderer functions)
├── Material/
│   └── MaterialSystem.cs (MaterialSystem2, IMaterial2)
├── RenderAttributes/
│   └── RenderAttributes.cs (CRenderAttributes)
├── Audio/
│   ├── AudioSystem.cs (DSP, AudioMixBuffer - déjà implémenté)
│   ├── AudioMixer.cs (CAudioMixer - à implémenter)
│   ├── AudioProcessor.cs (CAudioProcessor - à implémenter)
│   ├── AudioStream.cs (CdStrmMngd - à implémenter)
│   └── AudioDevice.cs (g_pAudioDevice_* - à implémenter)
├── Yoga/
│   └── YogaFunctions.cs (déjà dans EngineExports, à extraire)
├── RenderTools/
│   └── RenderTools.cs (RenderTools_SetRenderState, RenderTools_Draw)
├── Platform/
│   └── PlatformFunctions.cs (Plat_*, GetGameRootFolder, SourceEngine*)
├── FileSystem/
│   └── FileSystemFunctions.cs (g_pFllFlSystm_*)
├── Resource/
│   ├── ResourceSystem.cs (g_pRsrcSystm_*)
│   └── ResourceCompilerSystem.cs (g_pRsrcCmplrSyst_*)
├── Texture/
│   └── TextureSystem.cs (FindOrCreateTexture2)
├── Scene/
│   ├── SceneObject.cs (CSceneObject - à implémenter)
│   ├── DecalSceneObject.cs (CDclScnbjct - à implémenter)
│   ├── DynamicSceneObject.cs (CDynmcScnbjct - à implémenter)
│   ├── ManagedSceneObject.cs (CMngdScnbjct - à implémenter)
│   ├── SceneLightObject.cs (CScnLghtbjct - à implémenter)
│   ├── SceneLightProbeObject.cs (CScnLghtPrbVlmbj - à implémenter)
│   ├── SceneNametableObject.cs (CScnnmtblbjct - à implémenter)
│   └── SceneSkyBoxObject.cs (CScnSkyBxbjct - à implémenter)
├── Model/
│   ├── Model.cs (CModel - à implémenter)
│   └── RenderMesh.cs (CRenderMesh - à implémenter)
├── Frustum/
│   └── Frustum.cs (CFrustum - à implémenter)
├── Physics/
│   ├── PhysicsWorld.cs (déjà implémenté)
│   ├── PhysicsBodyDesc.cs (CPhysBodyDesc, CPhysBdyDscrry - à implémenter)
│   └── PhysicsAggregateData.cs (CPhysggrgtDt - à implémenter)
├── Input/
│   ├── InputService.cs (g_pInputService_* - à implémenter)
│   └── InputSystem.cs (g_pInputSystem_* - à implémenter)
├── Animation/
│   ├── AnimationGroupBuilder.cs (CnmtnGrpBldr - à implémenter)
│   └── Attachment.cs (CAttachment - à implémenter)
├── VFX/
│   ├── Vfx.cs (CVfx - à implémenter)
│   ├── VfxBytecodeManager.cs (CVfxBytCdMngr - à implémenter)
│   ├── VfxCombinator.cs (CVfxCmbtrtr - à implémenter)
│   └── VfxCombo.cs (CVfxCombo - à implémenter)
├── Video/
│   ├── VideoPlayer.cs (CVideoPlayer - à implémenter)
│   └── VideoRecorder.cs (CVideoRecorder - à implémenter)
└── Other/
    ├── EntityKeyValues.cs (CEntityKeyValues - à implémenter)
    ├── HitBox.cs (CHitBox, CHitBoxSet - à implémenter)
    ├── QueryResult.cs (CQueryResult - à implémenter)
    ├── ReadBufferManagedCallback.cs (CRdBffrMngdCllbc - à implémenter)
    ├── ReadTexturePixelsManaged.cs (CRdTxtrPxlsMngdC - à implémenter)
    ├── ServerList.cs (CServerList - à implémenter)
    ├── SfxTable.cs (CSfxTable - à implémenter)
    ├── StreamManagerInstance.cs (CStmtmnstnc - à implémenter)
    ├── StreamManagerEntryResult.cs (CStmnvntryRslt - à implémenter)
    ├── UtlBuffer.cs (CUtlBuffer - à implémenter)
    ├── UtlSymbolTable.cs (CUtlSymbolTable - à implémenter)
    └── MaterialGroup.cs (CBldrMtrlGrp, CBldrMtrlGrprry - à implémenter)
```

## Étapes d'Implémentation - Phase 1 (Prioritaire)

### 1. Implémenter CCameraRenderer (NOUVEAU - PRIORITAIRE)

**Fichier** : `src/Sbox.Engine.Emulation/Camera/CameraRenderer.cs`

- Créer la classe statique `CameraRenderer` avec méthode `Init(void** native)`
- Implémenter **toutes les 16 fonctions** listées dans la section "Inventaire Complet des Stubs par Module > Camera" ci-dessous
- Pour chaque fonction, obtenir l'index depuis `Interop.Engine.cs` (chercher `FunctionName.*nativeFunctions[`)
- **Liste complète des fonctions** : Voir section "Inventaire Complet des Stubs par Module > Camera" (16 fonctions)
- Créer une classe interne `EmulatedCameraRenderer` pour stocker l'état
- Utiliser `HandleManager` pour gérer les instances

**Indices** : Utiliser directement depuis `Interop.Engine.cs` lignes 14821-14880 (indices 74-133)

### 2. Créer le module RenderAttributes

**Fichier** : `src/Sbox.Engine.Emulation/RenderAttributes/RenderAttributes.cs`

**Sources de référence** :
- `engine.Generated.cs` : Chercher les fonctions `CRndrttrbts_*` qui retournent `return default;` (stubs à remplacer)
- `Interop.Engine.cs` lignes 15436-15474 : Obtenir les indices exacts (689-727) et les signatures

**Actions** :
- Créer classe statique `RenderAttributes` avec méthode `Init(void** native)`
- Créer classe interne `EmulatedRenderAttributes` pour stocker les données (réutiliser la logique de `EngineExports.cs` si déjà implémentée)
- Implémenter **toutes les 39 fonctions** listées dans la section "Inventaire Complet des Stubs par Module > RenderAttributes" ci-dessous
- Pour chaque fonction, obtenir l'index depuis `Interop.Engine.cs` (chercher `FunctionName.*nativeFunctions[`)
- Dans `Init(void** native)`, patcher tous les indices : `native[index] = (void*)(delegate* unmanaged<...>)&FunctionName;` etc.

**Liste complète des fonctions** : Voir section "Inventaire Complet des Stubs par Module > RenderAttributes" (39 fonctions)

**Note** : Si certaines fonctions sont déjà implémentées dans `EngineExports.cs`, réutiliser la logique mais dans le nouveau module.

### 3. Créer le module MaterialSystem

**Fichier** : `src/Sbox.Engine.Emulation/Material/MaterialSystem.cs`

**Sources de référence** :
- `engine.Generated.cs` : Chercher `g_pMtrlSystm2_CreateRawMaterial`, `IMaterial2_GetRenderAttributes`, `CMtrlSystm2ppSys_*` (stubs à remplacer)
- `Interop.Engine.cs` : Obtenir les indices et signatures exactes

**Actions** :
- Créer classe statique `MaterialSystem` avec méthode `Init(void** native)`
- Créer classe interne `MaterialData` pour stocker les données (réutiliser la logique de `EngineExports.cs` si déjà implémentée)
- Implémenter **toutes les 77 fonctions** listées dans la section "Inventaire Complet des Stubs par Module > Material" ci-dessous
- Pour chaque fonction, obtenir l'index depuis `Interop.Engine.cs` (chercher `FunctionName.*nativeFunctions[`)
- Dans `Init(void** native)`, patcher tous les indices

**Liste complète des fonctions** : Voir section "Inventaire Complet des Stubs par Module > Material" (77 fonctions)

**Note** : Réutiliser la logique existante de `EngineExports.cs` si disponible.

### 4. Créer le module AudioSystem (Base)

**Fichier** : `src/Sbox.Engine.Emulation/Audio/AudioSystem.cs`

**Sources de référence** :
- `engine.Generated.cs` : Chercher `DspPreset_*`, `CAudioMixBuffer_*`, `CdMxDvcBffrs_*` (stubs à remplacer)
- `Interop.Engine.cs` : Obtenir les indices et signatures exactes

**Actions** :
- Créer classe statique `AudioSystem` avec méthode `Init(void** native)`
- Créer classes helper `AudioMixBuffer`, `AudioMixDeviceBuffers`, `AudioHandleManager` (réutiliser de `EngineExports.cs` si déjà implémentées)
- Implémenter **toutes les 18 fonctions** listées dans la section "Inventaire Complet des Stubs par Module > Audio" ci-dessous
- Pour chaque fonction, obtenir l'index depuis `Interop.Engine.cs` (chercher `FunctionName.*nativeFunctions[`)
- Dans `Init(void** native)`, patcher tous les indices

**Liste complète des fonctions** : Voir section "Inventaire Complet des Stubs par Module > Audio" (18 fonctions)

**Note** : Réutiliser la logique existante de `EngineExports.cs` si disponible.

### 5. Créer le module YogaFunctions

**Fichier** : `src/Sbox.Engine.Emulation/Yoga/YogaFunctions.cs`

**Sources de référence** :
- `engine.Generated.cs` : Chercher `globalYoga_*` (stubs à remplacer)
- `Interop.Engine.cs` ligne 16372+ : Obtenir les indices exacts (commence à 1625)

**Actions** :
- Créer classe statique `YogaFunctions` avec méthode `Init(void** native)`
- Implémenter **toutes les 99 fonctions** listées dans la section "Inventaire Complet des Stubs par Module > Yoga" ci-dessous
- Pour chaque fonction, obtenir l'index depuis `Interop.Engine.cs` (chercher `FunctionName.*nativeFunctions[`)
- Dans `Init(void** native)`, patcher tous les indices (réutiliser la logique de `PatchYogaFunctions()` de `EngineExports.cs`)

**Liste complète des fonctions** : Voir section "Inventaire Complet des Stubs par Module > Yoga" (99 fonctions)

### 6. Créer le module RenderTools

**Fichier** : `src/Sbox.Engine.Emulation/RenderTools/RenderTools.cs`

**Sources de référence** :
- `engine.Generated.cs` : Chercher `RenderTools_SetRenderState`, `RenderTools_Draw` (stubs à remplacer)
- `Interop.Engine.cs` lignes 17105-17106 : Obtenir les indices exacts (2358-2359)

**Actions** :
- Créer classe statique `RenderTools` avec méthode `Init(void** native)`
- Implémenter **toutes les 16 fonctions** listées dans la section "Inventaire Complet des Stubs par Module > RenderTools" ci-dessous
- Pour chaque fonction, obtenir l'index depuis `Interop.Engine.cs` (chercher `FunctionName.*nativeFunctions[`)
- Dans `Init(void** native)`, patcher tous les indices

**Liste complète des fonctions** : Voir section "Inventaire Complet des Stubs par Module > RenderTools" (16 fonctions)

**Note** : Réutiliser la logique existante de `EngineExports.cs` si disponible.

### 7. Créer le module PlatformFunctions

**Fichier** : `src/Sbox.Engine.Emulation/Platform/PlatformFunctions.cs`

**Sources de référence** :
- `engine.Generated.cs` : Chercher `global_Plat_*`, `global_GetGameRootFolder`, `global_SourceEngine*`, `global_UpdateWindowSize` (stubs à remplacer)
- `Interop.Engine.cs` : Obtenir les indices et signatures exactes

**Actions** :
- Créer classe statique `PlatformFunctions` avec méthode `Init(void** native)`
- Déplacer les variables statiques `_glfw`, `_windowHandle`, `_gl`, `_renderContext`, `_sceneView`, `_sceneLayer` depuis `EngineExports.cs` (car elles sont partagées)
- Implémenter les fonctions :
  - `Plat_MessageBox` (index 1571 depuis `Interop.Engine.cs` ligne 16318)
  - `Plat_SetCurrentFrame` (index 1578 depuis `Interop.Engine.cs` ligne 16325)
  - `GetGameRootFolder` (index 1589 depuis `Interop.Engine.cs` ligne 16336)
  - `SourceEnginePreInit` (index 1592 depuis `Interop.Engine.cs` ligne 16339)
  - `SourceEngineInit` (index 1593 depuis `Interop.Engine.cs` ligne 16340)
  - `SourceEngineFrame` (index 1594 depuis `Interop.Engine.cs` ligne 16341)
  - `UpdateWindowSize` (index 1596 depuis `Interop.Engine.cs` ligne 16343)
  - `CreateAppWindow` et `CreateAppWindowInternal` (réutiliser de `EngineExports.cs`)
- Dans `Init(void** native)`, patcher tous les indices

**Note** : Réutiliser la logique existante de `EngineExports.cs` si disponible.

### 8. Créer le module FileSystemFunctions

**Fichier** : `src/Sbox.Engine.Emulation/FileSystem/FileSystemFunctions.cs`

**Sources de référence** :
- `engine.Generated.cs` : Chercher `g_pFllFlSystm_*` (stubs à remplacer)
- `Interop.Engine.cs` lignes 16174-16176 : Obtenir les indices exacts (1427-1429)

**Actions** :
- Créer classe statique `FileSystemFunctions` avec méthode `Init(void** native)`
- Implémenter **toutes les 6 fonctions** listées dans la section "Inventaire Complet des Stubs par Module > FileSystem" ci-dessous
- Pour chaque fonction, obtenir l'index depuis `Interop.Engine.cs` (chercher `FunctionName.*nativeFunctions[`)
- Dans `Init(void** native)`, patcher tous les indices

**Liste complète des fonctions** : Voir section "Inventaire Complet des Stubs par Module > FileSystem" (6 fonctions)

**Note** : Réutiliser la logique existante de `EngineExports.cs` si disponible.

### 9. Créer le module TextureSystem

**Fichier** : `src/Sbox.Engine.Emulation/Texture/TextureSystem.cs`

**Sources de référence** :
- `engine.Generated.cs` : Chercher `g_pRenderDevice_FindOrCreateTexture2`, `g_pngnSrvcMgr_GetEngineSwapChain`, `g_pngnSrvcMgr_GetEngineSwapChainSize` (stubs à remplacer)
- `Interop.Engine.cs` : Obtenir les indices et signatures exactes

**Actions** :
- Créer classe statique `TextureSystem` avec méthode `Init(void** native)`
- Implémenter **toutes les 3 fonctions** listées dans la section "Inventaire Complet des Stubs par Module > Texture" ci-dessous
- Pour chaque fonction, obtenir l'index depuis `Interop.Engine.cs` (chercher `FunctionName.*nativeFunctions[`)
- Dans `Init(void** native)`, patcher tous les indices

**Liste complète des fonctions** : Voir section "Inventaire Complet des Stubs par Module > Texture" (3 fonctions)

**Note** : Réutiliser la logique existante de `EngineExports.cs` si disponible.

### 10. Refactoriser EngineExports.cs

**Fichier** : `src/Sbox.Engine.Emulation/EngineExports.cs`

**Actions** :
- Supprimer les implémentations de fonctions qui ont été déplacées dans les modules
- Garder uniquement `IGenEngine()` et les appels aux `Init()` des modules
- Supprimer les patches directs dans `IGenEngine()` (ils seront dans les modules)
- Structure simplifiée :
  ```csharp
  public static void IGenEngine(...)
  {
      EngineGlue.StoreImports(managed);
      Exports.FillNativeFunctionsEngine(managed, native, structSizes);
      
      // Initialiser tous les modules (dans l'ordre de dépendance si nécessaire)
      CameraRenderer.Init(native);
      RenderAttributes.Init(native);
      MaterialSystem.Init(native);
      AudioSystem.Init(native);
      YogaFunctions.Init(native);
      RenderTools.Init(native);
      PlatformFunctions.Init(native);
      FileSystemFunctions.Init(native);
      TextureSystem.Init(native);
      // Physics déjà dans Physics/ mais pourrait avoir Init() aussi
  }
  ```

**Note** : Les fonctions qui ne sont pas encore dans des modules restent dans `EngineExports.cs` temporairement.

### 11. Mettre à jour les règles Cursor

**Fichier** : `.cursor/rules/project.mdc`

- Ajouter section "Architecture Modulaire" expliquant la structure
- Documenter le pattern `{Scope}.Init(void** native)`
- Ajouter les nouveaux fichiers dans "Fichiers Importants"
- Expliquer comment ajouter un nouveau module

## Inventaire Complet des Stubs par Module

**Total de stubs identifiés : 2686 fonctions**

Cette section liste **toutes** les fonctions qui retournent `return default;` dans `engine.Generated.cs`, organisées par module.

### Comment utiliser cette liste

1. Pour chaque module, toutes les fonctions listées doivent être implémentées
2. Les indices exacts se trouvent dans `Interop.Engine.cs` (chercher `FunctionName.*nativeFunctions[`)
3. Les signatures exactes se trouvent aussi dans `Interop.Engine.cs`
4. Les stubs à remplacer se trouvent dans `engine.Generated.cs` (chercher `EntryPoint = "FunctionName"`)


### Animation (12 fonctions)

- `CAttachment_GetInfluenceName`
- `CAttachment_GetInfluenceOffset`
- `CAttachment_GetInfluenceRotation`
- `CnmtnGrpBldr_AddAnimation`
- `CnmtnGrpBldr_AddFrame`
- `CnmtnGrpBldr_Create`
- `CnmtnGrpBldr_DeleteThis`
- `CnmtnGrpBldr_SetDelta`
- `CnmtnGrpBldr_SetDisableInterpolation`
- `CnmtnGrpBldr_SetFrameRate`
- `CnmtnGrpBldr_SetLooping`
- `CnmtnGrpBldr_SetName`

### Audio (18 fonctions)

- `CAudioMixBuffer_AbsLevel`
- `CAudioMixBuffer_AvergeLevel`
- `CAudioMixBuffer_CopyFrom`
- `CAudioMixBuffer_Create`
- `CAudioMixBuffer_Dispose`
- `CAudioMixBuffer_GetDataPointer`
- `CAudioMixBuffer_Mix`
- `CAudioMixBuffer_MixRamp`
- `CAudioMixBuffer_Ramp`
- `CAudioMixBuffer_Silence`
- `CdMxDvcBffrs_Create`
- `CdMxDvcBffrs_Destroy`
- `CdMxDvcBffrs_GetBuffer`
- `DspPreset_AddProcessor`
- `DspPreset_Create`
- `DspPreset_Dispose`
- `DspPreset_FinishBuilding`
- `DspPreset_Instantiate`

### AudioDevice (14 fonctions)

- `g_pAudioDevice_BitsPerSample`
- `g_pAudioDevice_BytesPerSample`
- `g_pAudioDevice_CancelOutput`
- `g_pAudioDevice_ChannelCount`
- `g_pAudioDevice_ClearBuffer`
- `g_pAudioDevice_IsActive`
- `g_pAudioDevice_IsValid`
- `g_pAudioDevice_MixChannelCount`
- `g_pAudioDevice_MuteDevice`
- `g_pAudioDevice_Name`
- `g_pAudioDevice_OutputDebugInfo`
- `g_pAudioDevice_SampleRate`
- `g_pAudioDevice_SendOutput`
- `g_pAudioDevice_WaitForComplete`

### AudioMixer (17 fonctions)

- `CAudioMixer_DelayOrSkipSamples`
- `CAudioMixer_Dispose`
- `CAudioMixer_EnableLooping`
- `CAudioMixer_GetChannelCount`
- `CAudioMixer_GetIndexState`
- `CAudioMixer_GetPositionForSave`
- `CAudioMixer_GetSampleCount`
- `CAudioMixer_GetSamplePosition`
- `CAudioMixer_GetSfxTable`
- `CAudioMixer_IsReadyToMix`
- `CAudioMixer_ReadToBuffer`
- `CAudioMixer_SetPositionFromSaved`
- `CAudioMixer_SetSampleEnd`
- `CAudioMixer_SetSamplePosition`
- `CAudioMixer_SetTimeScale`
- `CAudioMixer_ShouldContinueMixing`
- `CAudioMixer_UpdateMixerState`

### AudioProcessor (6 fonctions)

- `CAudioProcessor_CreateDelay`
- `CAudioProcessor_CreatePitchShift`
- `CAudioProcessor_Dispose`
- `CAudioProcessor_Process`
- `CAudioProcessor_SetControlParameter`
- `CAudioProcessor_SetNameParameter`

### AudioStream (10 fonctions)

- `CdStrmMngd_Create`
- `CdStrmMngd_Destroy`
- `CdStrmMngd_GetName`
- `CdStrmMngd_GetSfxTable`
- `CdStrmMngd_LatencySamplesCount`
- `CdStrmMngd_MaxWriteSampleCount`
- `CdStrmMngd_Pause`
- `CdStrmMngd_QueuedSampleCount`
- `CdStrmMngd_Resume`
- `CdStrmMngd_WriteAudioData`

### BinauralEffect (3 fonctions)

- `CBinauralEffect_Apply`
- `CBinauralEffect_Create`
- `CBinauralEffect_Dispose`

### Camera (16 fonctions)

- `CCameraRenderer_AddExcludeTag`
- `CCameraRenderer_AddRenderTag`
- `CCameraRenderer_AddSceneWorld`
- `CCameraRenderer_BlitStereo`
- `CCameraRenderer_ClearExcludeTags`
- `CCameraRenderer_ClearRenderTags`
- `CCameraRenderer_ClearSceneWorlds`
- `CCameraRenderer_Create`
- `CCameraRenderer_DeleteThis`
- `CCameraRenderer_Render`
- `CCameraRenderer_RenderStereo`
- `CCameraRenderer_RenderToBitmap`
- `CCameraRenderer_RenderToCubeTexture`
- `CCameraRenderer_RenderToTexture`
- `CCameraRenderer_SetRenderAttributes`
- `CCameraRenderer_SubmitStereo`

### DecalSceneObject (59 fonctions)

- `CDclScnbjct_AddChildObject`
- `CDclScnbjct_AddTag`
- `CDclScnbjct_ClearFlags`
- `CDclScnbjct_ClearLoaded`
- `CDclScnbjct_ClearMaterialOverrideList`
- `CDclScnbjct_DisableLOD`
- `CDclScnbjct_DisableMeshGroups`
- `CDclScnbjct_DisableRendering`
- `CDclScnbjct_EnableLightingCache`
- `CDclScnbjct_EnableMeshGroups`
- `CDclScnbjct_EnableRendering`
- `CDclScnbjct_GetAlphaFade`
- `CDclScnbjct_GetAttributesPtrForModify`
- `CDclScnbjct_GetBoundingSphereRadius`
- `CDclScnbjct_GetBounds`
- `CDclScnbjct_GetCTransform`
- `CDclScnbjct_GetCurrentLODGroupMask`
- `CDclScnbjct_GetCurrentLODLevel`
- `CDclScnbjct_GetCurrentMeshGroupMask`
- `CDclScnbjct_GetFlags`
- `CDclScnbjct_GetLightingOrigin`
- `CDclScnbjct_GetModelHandle`
- `CDclScnbjct_GetOriginalFlags`
- `CDclScnbjct_GetParent`
- `CDclScnbjct_GetTagAt`
- `CDclScnbjct_GetTagCount`
- `CDclScnbjct_GetTintRGBA`
- `CDclScnbjct_GetWorld`
- `CDclScnbjct_HasFlags`
- `CDclScnbjct_HasLightingOrigin`
- `CDclScnbjct_HasTag`
- `CDclScnbjct_IsLoaded`
- `CDclScnbjct_IsNotBatchable`
- `CDclScnbjct_IsRenderingEnabled`
- `CDclScnbjct_RemoveAllTags`
- `CDclScnbjct_RemoveChild`
- `CDclScnbjct_RemoveTag`
- `CDclScnbjct_ResetMeshGroups`
- `CDclScnbjct_SetAlphaFade`
- `CDclScnbjct_SetBatchable`
- `CDclScnbjct_SetBodyGroup`
- `CDclScnbjct_SetBounds`
- `CDclScnbjct_SetBoundsInfinite`
- `CDclScnbjct_SetCullDistance`
- `CDclScnbjct_SetFlags`
- `CDclScnbjct_SetForceLayerID`
- `CDclScnbjct_SetLOD`
- `CDclScnbjct_SetLayerMatchID`
- `CDclScnbjct_SetLightingOrigin`
- `CDclScnbjct_SetLoaded`
- `CDclScnbjct_SetMaterialGroup`
- `CDclScnbjct_SetMaterialOverride`
- `CDclScnbjct_SetMaterialOverrideByIndex`
- `CDclScnbjct_SetMaterialOverrideForMeshInstances`
- `CDclScnbjct_SetRenderingEnabled`
- `CDclScnbjct_SetTintRGBA`
- `CDclScnbjct_SetTransform`
- `CDclScnbjct_SetUniqueBatchGroup`
- `CDclScnbjct_UpdateFlagsBasedOnMaterial`

### DynamicSceneObject (65 fonctions)

- `CDynmcScnbjct_AddChildObject`
- `CDynmcScnbjct_AddTag`
- `CDynmcScnbjct_AddVertex`
- `CDynmcScnbjct_AddVertexRange`
- `CDynmcScnbjct_Begin`
- `CDynmcScnbjct_ChangeFlags`
- `CDynmcScnbjct_ClearFlags`
- `CDynmcScnbjct_ClearLoaded`
- `CDynmcScnbjct_ClearMaterialOverrideList`
- `CDynmcScnbjct_DisableLOD`
- `CDynmcScnbjct_DisableMeshGroups`
- `CDynmcScnbjct_DisableRendering`
- `CDynmcScnbjct_EnableLightingCache`
- `CDynmcScnbjct_EnableMeshGroups`
- `CDynmcScnbjct_EnableRendering`
- `CDynmcScnbjct_End`
- `CDynmcScnbjct_GetAlphaFade`
- `CDynmcScnbjct_GetAttributesPtrForModify`
- `CDynmcScnbjct_GetBoundingSphereRadius`
- `CDynmcScnbjct_GetBounds`
- `CDynmcScnbjct_GetCTransform`
- `CDynmcScnbjct_GetCurrentLODGroupMask`
- `CDynmcScnbjct_GetCurrentLODLevel`
- `CDynmcScnbjct_GetCurrentMeshGroupMask`
- `CDynmcScnbjct_GetFlags`
- `CDynmcScnbjct_GetLightingOrigin`
- `CDynmcScnbjct_GetModelHandle`
- `CDynmcScnbjct_GetOriginalFlags`
- `CDynmcScnbjct_GetParent`
- `CDynmcScnbjct_GetTagAt`
- `CDynmcScnbjct_GetTagCount`
- `CDynmcScnbjct_GetTintRGBA`
- `CDynmcScnbjct_GetWorld`
- `CDynmcScnbjct_HasFlags`
- `CDynmcScnbjct_HasLightingOrigin`
- `CDynmcScnbjct_HasTag`
- `CDynmcScnbjct_IsLoaded`
- `CDynmcScnbjct_IsNotBatchable`
- `CDynmcScnbjct_IsRenderingEnabled`
- `CDynmcScnbjct_RemoveAllTags`
- `CDynmcScnbjct_RemoveChild`
- `CDynmcScnbjct_RemoveTag`
- `CDynmcScnbjct_Reset`
- `CDynmcScnbjct_ResetMeshGroups`
- `CDynmcScnbjct_SetAlphaFade`
- `CDynmcScnbjct_SetBatchable`
- `CDynmcScnbjct_SetBodyGroup`
- `CDynmcScnbjct_SetBounds`
- `CDynmcScnbjct_SetBoundsInfinite`
- `CDynmcScnbjct_SetCullDistance`
- `CDynmcScnbjct_SetFlags`
- `CDynmcScnbjct_SetForceLayerID`
- `CDynmcScnbjct_SetLOD`
- `CDynmcScnbjct_SetLayerMatchID`
- `CDynmcScnbjct_SetLightingOrigin`
- `CDynmcScnbjct_SetLoaded`
- `CDynmcScnbjct_SetMaterialGroup`
- `CDynmcScnbjct_SetMaterialOverride`
- `CDynmcScnbjct_SetMaterialOverrideByIndex`
- `CDynmcScnbjct_SetMaterialOverrideForMeshInstances`
- `CDynmcScnbjct_SetRenderingEnabled`
- `CDynmcScnbjct_SetTintRGBA`
- `CDynmcScnbjct_SetTransform`
- `CDynmcScnbjct_SetUniqueBatchGroup`
- `CDynmcScnbjct_UpdateFlagsBasedOnMaterial`

### EntityKeyValues (4 fonctions)

- `CEntityKeyValues_GetKey`
- `CEntityKeyValues_GetKeyCount`
- `CEntityKeyValues_GetValueString`
- `CEntityKeyValues_GetValueString_1`

### FileSystem (6 fonctions)

- `g_pFllFlSystm_AddCloudPath`
- `g_pFllFlSystm_AddProjectPath`
- `g_pFllFlSystm_AddSymLink`
- `g_pFllFlSystm_GetSymLink`
- `g_pFllFlSystm_RemoveSymLink`
- `g_pFllFlSystm_ResetProjectPaths`

### Frustum (23 fonctions)

- `CFrustum_BoundingVolumeIntersectsFrustum`
- `CFrustum_Create`
- `CFrustum_Delete`
- `CFrustum_GetCameraAngles`
- `CFrustum_GetCameraAspect`
- `CFrustum_GetCameraFOV`
- `CFrustum_GetCameraFarPlane`
- `CFrustum_GetCameraNearPlane`
- `CFrustum_GetCameraPosition`
- `CFrustum_GetInvProj`
- `CFrustum_GetInvReverseZProj`
- `CFrustum_GetInvViewProj`
- `CFrustum_GetPlane`
- `CFrustum_GetProj`
- `CFrustum_GetReverseZProj`
- `CFrustum_GetViewProj`
- `CFrustum_InitCamera`
- `CFrustum_InitCamera_1`
- `CFrustum_InitOrthoCamera`
- `CFrustum_ScreenTransform`
- `CFrustum_SetCameraWidthHeight`
- `CFrustum_ViewToWorld`
- `CFrustum_WorldToView`

### HitBox (3 fonctions)

- `CHitBoxSet_numhitboxes`
- `CHitBoxSet_pHitbox`
- `CHitBox_GetTag`

### InputService (6 fonctions)

- `g_pInputService_GetBinding`
- `g_pInputService_HasMouseFocus`
- `g_pInputService_IsAppActive`
- `g_pInputService_Key_NameForBinding`
- `g_pInputService_Pump`
- `g_pInputService_SetCursorPosition`

### InputSystem (21 fonctions)

- `g_pInputSystem_ButtonCodeToVirtualKey`
- `g_pInputSystem_CodeToString`
- `g_pInputSystem_DismissIME`
- `g_pInputSystem_GetRelativeMouseMode`
- `g_pInputSystem_HasMouseFocus`
- `g_pInputSystem_IsAppActive`
- `g_pInputSystem_IsIMEAllowed`
- `g_pInputSystem_LoadCursorFromFile`
- `g_pInputSystem_OnEditorGameFocusChange`
- `g_pInputSystem_RegisterWindowWithSDL`
- `g_pInputSystem_SetCursorPosition`
- `g_pInputSystem_SetCursorStandard`
- `g_pInputSystem_SetCursorUser`
- `g_pInputSystem_SetEditorMainWindow`
- `g_pInputSystem_SetIMEAllowed`
- `g_pInputSystem_SetIMETextLocation`
- `g_pInputSystem_SetRelativeMouseMode`
- `g_pInputSystem_ShutdownUserCursors`
- `g_pInputSystem_StringToButtonCode`
- `g_pInputSystem_UnregisterWindowFromSDL`
- `g_pInputSystem_VirtualKeyToButtonCode`

### ManagedSceneObject (60 fonctions)

- `CMngdScnbjct_AddChildObject`
- `CMngdScnbjct_AddTag`
- `CMngdScnbjct_ChangeFlags`
- `CMngdScnbjct_ClearFlags`
- `CMngdScnbjct_ClearLoaded`
- `CMngdScnbjct_ClearMaterialOverrideList`
- `CMngdScnbjct_DisableLOD`
- `CMngdScnbjct_DisableMeshGroups`
- `CMngdScnbjct_DisableRendering`
- `CMngdScnbjct_EnableLightingCache`
- `CMngdScnbjct_EnableMeshGroups`
- `CMngdScnbjct_EnableRendering`
- `CMngdScnbjct_GetAlphaFade`
- `CMngdScnbjct_GetAttributesPtrForModify`
- `CMngdScnbjct_GetBoundingSphereRadius`
- `CMngdScnbjct_GetBounds`
- `CMngdScnbjct_GetCTransform`
- `CMngdScnbjct_GetCurrentLODGroupMask`
- `CMngdScnbjct_GetCurrentLODLevel`
- `CMngdScnbjct_GetCurrentMeshGroupMask`
- `CMngdScnbjct_GetFlags`
- `CMngdScnbjct_GetLightingOrigin`
- `CMngdScnbjct_GetModelHandle`
- `CMngdScnbjct_GetOriginalFlags`
- `CMngdScnbjct_GetParent`
- `CMngdScnbjct_GetTagAt`
- `CMngdScnbjct_GetTagCount`
- `CMngdScnbjct_GetTintRGBA`
- `CMngdScnbjct_GetWorld`
- `CMngdScnbjct_HasFlags`
- `CMngdScnbjct_HasLightingOrigin`
- `CMngdScnbjct_HasTag`
- `CMngdScnbjct_IsLoaded`
- `CMngdScnbjct_IsNotBatchable`
- `CMngdScnbjct_IsRenderingEnabled`
- `CMngdScnbjct_RemoveAllTags`
- `CMngdScnbjct_RemoveChild`
- `CMngdScnbjct_RemoveTag`
- `CMngdScnbjct_ResetMeshGroups`
- `CMngdScnbjct_SetAlphaFade`
- `CMngdScnbjct_SetBatchable`
- `CMngdScnbjct_SetBodyGroup`
- `CMngdScnbjct_SetBounds`
- `CMngdScnbjct_SetBoundsInfinite`
- `CMngdScnbjct_SetCullDistance`
- `CMngdScnbjct_SetFlags`
- `CMngdScnbjct_SetForceLayerID`
- `CMngdScnbjct_SetLOD`
- `CMngdScnbjct_SetLayerMatchID`
- `CMngdScnbjct_SetLightingOrigin`
- `CMngdScnbjct_SetLoaded`
- `CMngdScnbjct_SetMaterialGroup`
- `CMngdScnbjct_SetMaterialOverride`
- `CMngdScnbjct_SetMaterialOverrideByIndex`
- `CMngdScnbjct_SetMaterialOverrideForMeshInstances`
- `CMngdScnbjct_SetRenderingEnabled`
- `CMngdScnbjct_SetTintRGBA`
- `CMngdScnbjct_SetTransform`
- `CMngdScnbjct_SetUniqueBatchGroup`
- `CMngdScnbjct_UpdateFlagsBasedOnMaterial`

### Material (77 fonctions)

- `CMtrlSystm2ppSys_AddSystem`
- `CMtrlSystm2ppSys_Create`
- `CMtrlSystm2ppSys_CreateAppWindow`
- `CMtrlSystm2ppSys_Destroy`
- `CMtrlSystm2ppSys_DisableModPathCheck`
- `CMtrlSystm2ppSys_DrawInitialWindowImage`
- `CMtrlSystm2ppSys_GetAppWindow`
- `CMtrlSystm2ppSys_GetAppWindowSwapChain`
- `CMtrlSystm2ppSys_GetContentPath`
- `CMtrlSystm2ppSys_GetInitializationPhase`
- `CMtrlSystm2ppSys_GetModGameSubdir`
- `CMtrlSystm2ppSys_GetSteamAppId`
- `CMtrlSystm2ppSys_Init`
- `CMtrlSystm2ppSys_InitFinishSetupMaterialSystem`
- `CMtrlSystm2ppSys_InitSDL`
- `CMtrlSystm2ppSys_InitWithoutMaterialSystem`
- `CMtrlSystm2ppSys_IsConsoleApp`
- `CMtrlSystm2ppSys_IsDedicatedServer`
- `CMtrlSystm2ppSys_IsGameApp`
- `CMtrlSystm2ppSys_IsInDeveloperMode`
- `CMtrlSystm2ppSys_IsInTestMode`
- `CMtrlSystm2ppSys_IsInToolsMode`
- `CMtrlSystm2ppSys_IsInVRMode`
- `CMtrlSystm2ppSys_IsRunningOnCustomerMachine`
- `CMtrlSystm2ppSys_IsStandaloneApp`
- `CMtrlSystm2ppSys_PreShutdown`
- `CMtrlSystm2ppSys_SetAppWindowDiscardMouseFocusClick`
- `CMtrlSystm2ppSys_SetAppWindowIcon`
- `CMtrlSystm2ppSys_SetAppWindowTitle`
- `CMtrlSystm2ppSys_SetDedicatedServer`
- `CMtrlSystm2ppSys_SetDefaultRenderSystemOption`
- `CMtrlSystm2ppSys_SetInStandaloneApp`
- `CMtrlSystm2ppSys_SetInTestMode`
- `CMtrlSystm2ppSys_SetInToolsMode`
- `CMtrlSystm2ppSys_SetInitialAppWindowImage`
- `CMtrlSystm2ppSys_SetInitializationPhase`
- `CMtrlSystm2ppSys_SetModFromFileName`
- `CMtrlSystm2ppSys_SetModGameSubdir`
- `CMtrlSystm2ppSys_SetModuleSearchPath`
- `CMtrlSystm2ppSys_SetSteamAppId`
- `CMtrlSystm2ppSys_ShutdownSDL`
- `CMtrlSystm2ppSys_SuppressCOMInitialization`
- `CMtrlSystm2ppSys_SuppressStartupManifestLoad`
- `IMaterial2_CopyStrongHandle`
- `IMaterial2_DestroyStrongHandle`
- `IMaterial2_GetBindingPtr`
- `IMaterial2_GetBoolAttributeOrDefault`
- `IMaterial2_GetFirstTextureAttribute`
- `IMaterial2_GetFloatAttributeOrDefault`
- `IMaterial2_GetIntAttributeOrDefault`
- `IMaterial2_GetMode`
- `IMaterial2_GetMode_1`
- `IMaterial2_GetMode_2`
- `IMaterial2_GetName`
- `IMaterial2_GetNameWithMod`
- `IMaterial2_GetRenderAttributes`
- `IMaterial2_GetSimilarityKey`
- `IMaterial2_GetString`
- `IMaterial2_GetTexture`
- `IMaterial2_GetTextureAttributeOrDefault`
- `IMaterial2_GetVector4`
- `IMaterial2_HasParam`
- `IMaterial2_IsEdited`
- `IMaterial2_IsError`
- `IMaterial2_IsLoaded`
- `IMaterial2_IsStrongHandleLoaded`
- `IMaterial2_IsStrongHandleValid`
- `IMaterial2_RecreateAllStaticConstantAndCommandBuffers`
- `IMaterial2_ReloadStaticCombos`
- `IMaterial2_Set`
- `IMaterial2_SetEdited`
- `IMaterial2_Set_1`
- `IMaterial2_Set_2`
- `g_pMtrlSystm2_CreateProceduralMaterialCopy`
- `g_pMtrlSystm2_CreateRawMaterial`
- `g_pMtrlSystm2_FindOrCreateMaterialFromResource`
- `g_pMtrlSystm2_FrameUpdate`

### MaterialGroup (4 fonctions)

- `CBldrMtrlGrp_AddMaterial`
- `CBldrMtrlGrprry_Create`
- `CBldrMtrlGrprry_DeleteThis`
- `CBldrMtrlGrprry_Get`

### Model (64 fonctions)

- `CModel_CopyStrongHandle`
- `CModel_DestroyStrongHandle`
- `CModel_FindBoneIndex`
- `CModel_FindHitboxSetByName`
- `CModel_FindHitboxSetIndexByName`
- `CModel_FindMeshIndexForMask`
- `CModel_FindModelSubKey`
- `CModel_GetAnimationGraph`
- `CModel_GetAnimationName`
- `CModel_GetAttachment`
- `CModel_GetAttachmentNameFromIndex`
- `CModel_GetAttachmentTransform`
- `CModel_GetBindingPtr`
- `CModel_GetBodyPartForName`
- `CModel_GetBodyPartMask`
- `CModel_GetBodyPartMeshMask`
- `CModel_GetBodyPartMeshName`
- `CModel_GetBodyPartName`
- `CModel_GetBoneIndexForHitbox`
- `CModel_GetBoneTransform`
- `CModel_GetDefaultMeshGroupMask`
- `CModel_GetFlexControllerName`
- `CModel_GetHitboxSetByIndex`
- `CModel_GetHitboxSetCount`
- `CModel_GetMaterial`
- `CModel_GetMaterialByIndex`
- `CModel_GetMaterialGroupIndex`
- `CModel_GetMaterialGroupName`
- `CModel_GetMaterialInGroup`
- `CModel_GetMaterialIndexCount`
- `CModel_GetMeshBounds`
- `CModel_GetModelName`
- `CModel_GetModelRenderBounds`
- `CModel_GetNumAnim`
- `CModel_GetNumAttachments`
- `CModel_GetNumBodyPartMeshes`
- `CModel_GetNumBodyParts`
- `CModel_GetNumDrawCalls`
- `CModel_GetNumMaterialGroups`
- `CModel_GetNumMaterialsInGroup`
- `CModel_GetNumMeshGroups`
- `CModel_GetNumMeshes`
- `CModel_GetNumSceneObjects`
- `CModel_GetPhysicsBounds`
- `CModel_GetPhysicsContainer`
- `CModel_GetSequenceNames`
- `CModel_GetVisemeMorph`
- `CModel_HasAnimationDrivenFlexes`
- `CModel_HasPhysics`
- `CModel_HasSceneObjects`
- `CModel_HasSkinnedMeshes`
- `CModel_IsError`
- `CModel_IsStrongHandleLoaded`
- `CModel_IsStrongHandleValid`
- `CModel_IsTranslucent`
- `CModel_IsTranslucentTwoPass`
- `CModel_MeshTrace`
- `CModel_NumBones`
- `CModel_NumFlexControllers`
- `CModel_boneFlags`
- `CModel_boneName`
- `CModel_boneParent`
- `CModel_bonePosParentSpace`
- `CModel_boneRotParentSpace`

### Other (1443 fonctions)

- `CnvMpScnbjct_CalculateBounds`
- `CnvMpScnbjct_CalculateNormalizationSH`
- `CnvMpScnbjct_CalculateRadianceSH_1`
- `CnvMpScnbjct_GetCascadeDistanceScale`
- `CnvMpScnbjct_GetColor`
- `CnvMpScnbjct_GetConstantAttn`
- `CnvMpScnbjct_GetFallOff`
- `CnvMpScnbjct_GetFogContributionStength`
- `CnvMpScnbjct_GetFogLightingMode`
- `CnvMpScnbjct_GetLightCookie`
- `CnvMpScnbjct_GetLightFlags`
- `CnvMpScnbjct_GetLightShape`
- `CnvMpScnbjct_GetLinearAttn`
- `CnvMpScnbjct_GetPhi`
- `CnvMpScnbjct_GetQuadraticAttn`
- `CnvMpScnbjct_GetRadius`
- `CnvMpScnbjct_GetShadowCascades`
- `CnvMpScnbjct_GetShadowTextureHeight`
- `CnvMpScnbjct_GetShadowTextureResolution`
- `CnvMpScnbjct_GetShadowTextureWidth`
- `CnvMpScnbjct_GetShadows`
- `CnvMpScnbjct_GetTheta`
- `CnvMpScnbjct_GetWorldDirection`
- `CnvMpScnbjct_GetWorldPosition`
- `CnvMpScnbjct_SetBakeLightIndex`
- `CnvMpScnbjct_SetBakeLightIndexScale`
- `CnvMpScnbjct_SetBounceColor`
- `CnvMpScnbjct_SetCascadeDistanceScale`
- `CnvMpScnbjct_SetColor`
- `CnvMpScnbjct_SetConstantAttn`
- `CnvMpScnbjct_SetFallOff`
- `CnvMpScnbjct_SetFogContributionStength`
- `CnvMpScnbjct_SetFogLightingMode`
- `CnvMpScnbjct_SetLightCookie`
- `CnvMpScnbjct_SetLightFlags`
- `CnvMpScnbjct_SetLightShape`
- `CnvMpScnbjct_SetLightSourceDim0`
- `CnvMpScnbjct_SetLightSourceDim1`
- `CnvMpScnbjct_SetLightSourceSize0`
- `CnvMpScnbjct_SetLightSourceSize1`
- `CnvMpScnbjct_SetLinearAttn`
- `CnvMpScnbjct_SetPhi`
- `CnvMpScnbjct_SetQuadraticAttn`
- `CnvMpScnbjct_SetRadius`
- `CnvMpScnbjct_SetRenderDiffuse`
- `CnvMpScnbjct_SetRenderSpecular`
- `CnvMpScnbjct_SetRenderTransmissive`
- `CnvMpScnbjct_SetShadowCascades`
- `CnvMpScnbjct_SetShadowTextureHeight`
- `CnvMpScnbjct_SetShadowTextureResolution`
- `CnvMpScnbjct_SetShadowTextureWidth`
- `CnvMpScnbjct_SetShadows`
- `CnvMpScnbjct_SetTheta`
- `CnvMpScnbjct_SetUsesIndexedBakedLighting`
- `CnvMpScnbjct_SetWorldDirection`
- `CnvMpScnbjct_SetWorldPosition`
- `ConCommand_GetFlags`
- `ConCommand_GetHelpText`
- `ConCommand_GetName`
- `ConCommand_Run`
- `ConVar_GetDefault`
- `ConVar_GetFlags`
- `ConVar_GetHelpText`
- `ConVar_GetMaxValue`
- `ConVar_GetMinValue`
- `ConVar_GetName`
- `ConVar_GetString`
- `ConVar_HasMax`
- `ConVar_HasMin`
- `ConVar_Revert`
- `ConVar_SetValue`
- `ConVar_SetValue_1`
- `ConVar_SetValue_2`
- `CtlVctrCtlStrng_Count`
- `CtlVctrCtlStrng_Create`
- `CtlVctrCtlStrng_DeleteThis`
- `CtlVctrCtlStrng_Element`
- `CtlVctrCtlStrng_SetCount`
- `CtlVctrHRndrTxtr_Count`
- `CtlVctrHRndrTxtr_Create`
- `CtlVctrHRndrTxtr_DeleteThis`
- `CtlVctrHRndrTxtr_Element`
- `CtlVctrPhyscsTrc_Result_Count`
- `CtlVctrPhyscsTrc_Result_Create`
- `CtlVctrPhyscsTrc_Result_DeleteThis`
- `CtlVctrPhyscsTrc_Result_Element`
- `CtlVctrVctr_Count`
- `CtlVctrVctr_Create`
- `CtlVctrVctr_DeleteThis`
- `CtlVctrVctr_Element`
- `CtlVctrVctr_SetCount`
- `CtlVctrflt_Count`
- `CtlVctrflt_Create`
- `CtlVctrflt_DeleteThis`
- `CtlVctrflt_Element`
- `CtlVctrflt_SetCount`
- `CtlVctrnt32_Count`
- `CtlVctrnt32_Create`
- `CtlVctrnt32_DeleteThis`
- `CtlVctrnt32_Element`
- `CtlVctrnt32_SetCount`
- `DspInstance_Dispose`
- `DspInstance_ProcessChannel`
- `EngineGlue_AddSearchPath`
- `EngineGlue_ApproximateProcessMemoryUsage`
- `EngineGlue_CancelWebAuthTicket`
- `EngineGlue_GetStringToken`
- `EngineGlue_GetStringTokenValue`
- `EngineGlue_GetWebAuthTicket`
- `EngineGlue_JsonToKeyValues3`
- `EngineGlue_KeyValues3ToJson`
- `EngineGlue_KeyValuesToJson`
- `EngineGlue_LoadKeyValues3`
- `EngineGlue_ReadCompiledResourceFileBlock`
- `EngineGlue_ReadCompiledResourceFileJson`
- `EngineGlue_ReadCompiledResourceFileJsonFromFilesystem`
- `EngineGlue_RemoveSearchPath`
- `EngineGlue_RequestWebAuthTicket`
- `EngineGlue_SetEngineLoggingVerbose`
- `ErrorReports_Breadcrumb`
- `ErrorReports_SetTag`
- `FloatBitMap_t_Alpha`
- `FloatBitMap_t_Create`
- `FloatBitMap_t_Create_1`
- `FloatBitMap_t_Delete`
- `FloatBitMap_t_Depth`
- `FloatBitMap_t_Height`
- `FloatBitMap_t_Init`
- `FloatBitMap_t_LoadFromBuffer`
- `FloatBitMap_t_LoadFromEXR`
- `FloatBitMap_t_LoadFromFile`
- `FloatBitMap_t_LoadFromInMemoryPSD`
- `FloatBitMap_t_LoadFromInMemoryTGA`
- `FloatBitMap_t_LoadFromInMemoryTIF`
- `FloatBitMap_t_LoadFromJPG`
- `FloatBitMap_t_LoadFromPFM`
- `FloatBitMap_t_LoadFromPNG`
- `FloatBitMap_t_LoadFromPSD`
- `FloatBitMap_t_LoadFromTIF`
- `FloatBitMap_t_MirrorHorizontally`
- `FloatBitMap_t_MirrorVertically`
- `FloatBitMap_t_Pixel`
- `FloatBitMap_t_PixelClamped`
- `FloatBitMap_t_PixelWrapped`
- `FloatBitMap_t_RGBPixelAsVector`
- `FloatBitMap_t_Resize2D`
- `FloatBitMap_t_Rotate180Degrees`
- `FloatBitMap_t_Rotate90DegreesCCW`
- `FloatBitMap_t_Rotate90DegreesCW`
- `FloatBitMap_t_SetChannel`
- `FloatBitMap_t_Shutdown`
- `FloatBitMap_t_Width`
- `FloatBitMap_t_WriteEXR`
- `FloatBitMap_t_WritePFM`
- `FloatBitMap_t_WriteTGAFile`
- `FloatBitMap_t_WriteToBuffer`
- `Glue_Networking_AcceptConnection`
- `Glue_Networking_BeginAsyncRequestFakeIP`
- `Glue_Networking_CloseConnection`
- `Glue_Networking_CloseSocket`
- `Glue_Networking_ConnectToIpAddress`
- `Glue_Networking_ConnectToSteamId`
- `Glue_Networking_CreateIpBasedSocket`
- `Glue_Networking_CreatePollGroup`
- `Glue_Networking_CreateSocket`
- `Glue_Networking_DestroyPollGroup`
- `Glue_Networking_FlushMessagesOnConnection`
- `Glue_Networking_GetAuthenticationStatus`
- `Glue_Networking_GetConnectionDescription`
- `Glue_Networking_GetConnectionMessages`
- `Glue_Networking_GetConnectionState`
- `Glue_Networking_GetConnectionSteamId`
- `Glue_Networking_GetIdentity`
- `Glue_Networking_GetPollGroupMessages`
- `Glue_Networking_GetRelayNetworkStatus`
- `Glue_Networking_GetSocketAddress`
- `Glue_Networking_RunCallbacks`
- `Glue_Networking_SendMessage`
- `Glue_Networking_SetDebugFunction`
- `Glue_Networking_SetPollGroup`
- `Glue_Resources_GetAnimationGraph`
- `Glue_Resources_GetMaterial`
- `Glue_Resources_GetModel`
- `Glue_Resources_GetShader`
- `Glue_Resources_GetTexture`
- `Glue_RndrDvcMngr_ChangeVideoMode`
- `Glue_RndrDvcMngr_GetDisplayModes`
- `Glue_RndrDvcMngr_ResetVideoConfig`
- `Glue_RndrDvcMngr_WriteVideoConfig`
- `IAnimParameter_GetDefaultValue`
- `IAnimParameter_GetMaxValue`
- `IAnimParameter_GetMinValue`
- `IAnimParameter_GetName`
- `IAnimParameter_GetNumOptionNames`
- `IAnimParameter_GetOptionName`
- `IAnimParameter_GetParameterType`
- `IAnimationGraph_CopyStrongHandle`
- `IAnimationGraph_DestroyStrongHandle`
- `IAnimationGraph_GetBindingPtr`
- `IAnimationGraph_GetParameterList`
- `IAnimationGraph_GetResourceName`
- `IAnimationGraph_IsError`
- `IAnimationGraph_IsStrongHandleLoaded`
- `IAnimationGraph_IsStrongHandleValid`
- `IPVS_IsAbsBoxInPVS`
- `IPVS_IsEmptyPVS`
- `IPVS_IsInPVS`
- `IPVS_IsSkyVisibleFromPosition`
- `IPVS_IsSunVisibleFromPosition`
- `IPhysicsBody_AddBoxShape`
- `IPhysicsBody_AddCapsuleShape`
- `IPhysicsBody_AddHeightFieldShape`
- `IPhysicsBody_AddHullShape`
- `IPhysicsBody_AddHullShape_1`
- `IPhysicsBody_AddHullShape_2`
- `IPhysicsBody_AddLinearVelocity`
- `IPhysicsBody_AddMeshShape`
- `IPhysicsBody_AddMeshShape_1`
- `IPhysicsBody_AddSphereShape`
- `IPhysicsBody_ApplyAngularImpulse`
- `IPhysicsBody_ApplyForce`
- `IPhysicsBody_ApplyForceAt`
- `IPhysicsBody_ApplyLinearImpulse`
- `IPhysicsBody_ApplyLinearImpulseAtWorldSpace`
- `IPhysicsBody_ApplyTorque`
- `IPhysicsBody_BuildBounds`
- `IPhysicsBody_BuildMass`
- `IPhysicsBody_CheckOverlap`
- `IPhysicsBody_ClearForces`
- `IPhysicsBody_ClearTorque`
- `IPhysicsBody_Disable`
- `IPhysicsBody_DisableAutoSleeping`
- `IPhysicsBody_DisableTouchEvents`
- `IPhysicsBody_Enable`
- `IPhysicsBody_EnableAutoSleeping`
- `IPhysicsBody_EnableGravity`
- `IPhysicsBody_EnableTouchEvents`
- `IPhysicsBody_GetAggregate`
- `IPhysicsBody_GetAngularDamping`
- `IPhysicsBody_GetAngularVelocity`
- `IPhysicsBody_GetClosestPoint`
- `IPhysicsBody_GetDensity`
- `IPhysicsBody_GetGravityScale`
- `IPhysicsBody_GetLinearDamping`
- `IPhysicsBody_GetLinearVelocity`
- `IPhysicsBody_GetLocalInertiaOrientation`
- `IPhysicsBody_GetLocalInertiaVector`
- `IPhysicsBody_GetLocalMassCenter`
- `IPhysicsBody_GetMass`
- `IPhysicsBody_GetMassCenter`
- `IPhysicsBody_GetOrientation`
- `IPhysicsBody_GetOverrideMassCenter`
- `IPhysicsBody_GetPosition`
- `IPhysicsBody_GetShape`
- `IPhysicsBody_GetShapeCount`
- `IPhysicsBody_GetTransform`
- `IPhysicsBody_GetType`
- `IPhysicsBody_GetVelocityAtPoint`
- `IPhysicsBody_GetWorld`
- `IPhysicsBody_IsEnabled`
- `IPhysicsBody_IsGravityEnabled`
- `IPhysicsBody_IsSleeping`
- `IPhysicsBody_IsTouchEventEnabled`
- `IPhysicsBody_IsTouching`
- `IPhysicsBody_IsTouching_1`
- `IPhysicsBody_ManagedObject`
- `IPhysicsBody_PurgeShapes`
- `IPhysicsBody_RemoveShape`
- `IPhysicsBody_ResetLocalInertia`
- `IPhysicsBody_SetAngularDamping`
- `IPhysicsBody_SetAngularVelocity`
- `IPhysicsBody_SetGravityScale`
- `IPhysicsBody_SetLinearDamping`
- `IPhysicsBody_SetLinearVelocity`
- `IPhysicsBody_SetLocalInertia`
- `IPhysicsBody_SetLocalMassCenter`
- `IPhysicsBody_SetMass`
- `IPhysicsBody_SetMaterialIndex`
- `IPhysicsBody_SetMotionLocks`
- `IPhysicsBody_SetOrientation`
- `IPhysicsBody_SetOverrideMassCenter`
- `IPhysicsBody_SetPosition`
- `IPhysicsBody_SetTargetTransform`
- `IPhysicsBody_SetTransform`
- `IPhysicsBody_SetTrigger`
- `IPhysicsBody_SetType`
- `IPhysicsBody_Sleep`
- `IPhysicsBody_Wake`
- `IPhysicsJoint_GetAngle`
- `IPhysicsJoint_GetAngularImpulse`
- `IPhysicsJoint_GetAngularSpring`
- `IPhysicsJoint_GetBody1`
- `IPhysicsJoint_GetBody2`
- `IPhysicsJoint_GetLinearImpulse`
- `IPhysicsJoint_GetLinearSpring`
- `IPhysicsJoint_GetLocalFrameA`
- `IPhysicsJoint_GetLocalFrameB`
- `IPhysicsJoint_GetMaxAngularImpulse`
- `IPhysicsJoint_GetMaxForce`
- `IPhysicsJoint_GetMaxLength`
- `IPhysicsJoint_GetMaxLinearImpulse`
- `IPhysicsJoint_GetMinForce`
- `IPhysicsJoint_GetMinLength`
- `IPhysicsJoint_GetType`
- `IPhysicsJoint_GetWorld`
- `IPhysicsJoint_IsCollisionEnabled`
- `IPhysicsJoint_Motor_GetAngularDampingRatio`
- `IPhysicsJoint_Motor_GetAngularHertz`
- `IPhysicsJoint_Motor_GetAngularVelocity`
- `IPhysicsJoint_Motor_GetLinearDampingRatio`
- `IPhysicsJoint_Motor_GetLinearHertz`
- `IPhysicsJoint_Motor_GetLinearVelocity`
- `IPhysicsJoint_Motor_GetMaxSpringForce`
- `IPhysicsJoint_Motor_GetMaxSpringTorque`
- `IPhysicsJoint_Motor_GetMaxVelocityForce`
- `IPhysicsJoint_Motor_GetMaxVelocityTorque`
- `IPhysicsJoint_Motor_SetAngularDampingRatio`
- `IPhysicsJoint_Motor_SetAngularHertz`
- `IPhysicsJoint_Motor_SetAngularVelocity`
- `IPhysicsJoint_Motor_SetLinearDampingRatio`
- `IPhysicsJoint_Motor_SetLinearHertz`
- `IPhysicsJoint_Motor_SetLinearVelocity`
- `IPhysicsJoint_Motor_SetMaxSpringForce`
- `IPhysicsJoint_Motor_SetMaxSpringTorque`
- `IPhysicsJoint_Motor_SetMaxVelocityForce`
- `IPhysicsJoint_Motor_SetMaxVelocityTorque`
- `IPhysicsJoint_SetAngularMotor`
- `IPhysicsJoint_SetAngularSpring`
- `IPhysicsJoint_SetEnableCollision`
- `IPhysicsJoint_SetFriction`
- `IPhysicsJoint_SetLimit`
- `IPhysicsJoint_SetLimitEnabled`
- `IPhysicsJoint_SetLinearSpring`
- `IPhysicsJoint_SetLocalFrameA`
- `IPhysicsJoint_SetLocalFrameB`
- `IPhysicsJoint_SetMaxAngularImpulse`
- `IPhysicsJoint_SetMaxForce`
- `IPhysicsJoint_SetMaxLength`
- `IPhysicsJoint_SetMaxLinearImpulse`
- `IPhysicsJoint_SetMinForce`
- `IPhysicsJoint_SetMinLength`
- `IPhysicsJoint_SetMotorVelocity`
- `IPhysicsJoint_SetTargetRotation`
- `IPhysicsShape_AddCollisionFunctionMask`
- `IPhysicsShape_AddTag`
- `IPhysicsShape_AsCapsule`
- `IPhysicsShape_AsSphere`
- `IPhysicsShape_BuildBounds`
- `IPhysicsShape_ClearTags`
- `IPhysicsShape_GetBody`
- `IPhysicsShape_GetCollisionFunctionMask`
- `IPhysicsShape_GetFriction`
- `IPhysicsShape_GetLocalVelocity`
- `IPhysicsShape_GetMaterialName`
- `IPhysicsShape_GetOutline`
- `IPhysicsShape_GetTriangulation`
- `IPhysicsShape_GetTriangulationForNavmesh`
- `IPhysicsShape_GetType`
- `IPhysicsShape_HasTag`
- `IPhysicsShape_IsTouching`
- `IPhysicsShape_IsTrigger`
- `IPhysicsShape_LocalBounds`
- `IPhysicsShape_ManagedObject`
- `IPhysicsShape_RemoveCollisionFunctionMask`
- `IPhysicsShape_RemoveTag`
- `IPhysicsShape_SetElasticity`
- `IPhysicsShape_SetFriction`
- `IPhysicsShape_SetHasNoMass`
- `IPhysicsShape_SetIgnoreTraces`
- `IPhysicsShape_SetLocalVelocity`
- `IPhysicsShape_SetMaterialIndex`
- `IPhysicsShape_SetRollingResistance`
- `IPhysicsShape_SetSurfaceIndex`
- `IPhysicsShape_SetTrigger`
- `IPhysicsShape_UpdateBoxShape`
- `IPhysicsShape_UpdateCapsuleShape`
- `IPhysicsShape_UpdateHeightShape`
- `IPhysicsShape_UpdateHullShape`
- `IPhysicsShape_UpdateMeshShape`
- `IPhysicsShape_UpdateSphereShape`
- `IPhysicsWorld_AddBody`
- `IPhysicsWorld_AddMotorJoint`
- `IPhysicsWorld_AddPrismaticJoint`
- `IPhysicsWorld_AddRevoluteJoint`
- `IPhysicsWorld_AddSphericalJoint`
- `IPhysicsWorld_AddSpringJoint`
- `IPhysicsWorld_AddWeldJoint`
- `IPhysicsWorld_CreateAggregateInstance`
- `IPhysicsWorld_CreateAggregateInstance_1`
- `IPhysicsWorld_DestroyAggregateInstance`
- `IPhysicsWorld_DisableSleeping`
- `IPhysicsWorld_Draw`
- `IPhysicsWorld_EnableSleeping`
- `IPhysicsWorld_GetDebugScene`
- `IPhysicsWorld_GetGravity`
- `IPhysicsWorld_GetSimulation`
- `IPhysicsWorld_GetWorldReferenceBody`
- `IPhysicsWorld_IsSleepingEnabled`
- `IPhysicsWorld_ManagedObject`
- `IPhysicsWorld_ProcessIntersections`
- `IPhysicsWorld_Query`
- `IPhysicsWorld_Query_1`
- `IPhysicsWorld_Query_2`
- `IPhysicsWorld_RemoveBody`
- `IPhysicsWorld_RemoveJoint`
- `IPhysicsWorld_SetCollisionRulesFromJson`
- `IPhysicsWorld_SetDebugScene`
- `IPhysicsWorld_SetGravity`
- `IPhysicsWorld_SetMaximumLinearSpeed`
- `IPhysicsWorld_SetSimulation`
- `IPhysicsWorld_SetWorldReferenceBody`
- `IPhysicsWorld_StepSimulation`
- `IRenderContext_BeginPixEvent`
- `IRenderContext_BindIndexBuffer`
- `IRenderContext_BindIndexBuffer_1`
- `IRenderContext_BindPixelShader`
- `IRenderContext_BindRenderTargets`
- `IRenderContext_BindRenderTargets_1`
- `IRenderContext_BindTexture`
- `IRenderContext_BindVertexBuffer`
- `IRenderContext_BindVertexBuffer_1`
- `IRenderContext_BindVertexBuffer_2`
- `IRenderContext_BindVertexBuffer_3`
- `IRenderContext_BindVertexShader`
- `IRenderContext_BufferBarrierTransition`
- `IRenderContext_Clear`
- `IRenderContext_Draw`
- `IRenderContext_DrawIndexed`
- `IRenderContext_DrawIndexedInstanced`
- `IRenderContext_DrawIndexedInstancedIndirect`
- `IRenderContext_DrawInstanced`
- `IRenderContext_DrawInstancedIndirect`
- `IRenderContext_EndPixEvent`
- `IRenderContext_GenerateMipMaps`
- `IRenderContext_GetAttributesPtrForModify`
- `IRenderContext_GetViewport`
- `IRenderContext_PixSetMarker`
- `IRenderContext_ReadBuffer`
- `IRenderContext_ReadTexturePixels`
- `IRenderContext_RestoreRenderTargets`
- `IRenderContext_SetAssociatedThreadIndex`
- `IRenderContext_SetDynamicConstantBufferData`
- `IRenderContext_SetScissorRect`
- `IRenderContext_SetViewport`
- `IRenderContext_SetViewport_1`
- `IRenderContext_SetViewport_2`
- `IRenderContext_Submit`
- `IRenderContext_TextureBarrierTransition`
- `ISceneLayer_AddObjectFlagsExcludedMask`
- `ISceneLayer_AddObjectFlagsRequiredMask`
- `ISceneLayer_GetColorTarget`
- `ISceneLayer_GetDebugName`
- `ISceneLayer_GetDepthTarget`
- `ISceneLayer_GetObjectFlagsExcludedMask`
- `ISceneLayer_GetObjectFlagsRequiredMask`
- `ISceneLayer_GetRenderAttributesPtr`
- `ISceneLayer_GetTextureValue`
- `ISceneLayer_GetTextureValue_1`
- `ISceneLayer_RemoveObjectFlagsExcludedMask`
- `ISceneLayer_RemoveObjectFlagsRequiredMask`
- `ISceneLayer_SetAttr`
- `ISceneLayer_SetBoundingVolumeSizeCullThresholdInPercent`
- `ISceneLayer_SetClearColor`
- `ISceneLayer_SetObjectMatchID`
- `ISceneLayer_SetOutput`
- `ISceneView_AddDependentView`
- `ISceneView_AddManagedProceduralLayer`
- `ISceneView_AddRenderLayer`
- `ISceneView_AddWorldToRenderList`
- `ISceneView_FindOrCreateRenderTarget`
- `ISceneView_GetDefaultLayerObjectExcludedFlags`
- `ISceneView_GetDefaultLayerObjectRequiredFlags`
- `ISceneView_GetFrustum`
- `ISceneView_GetMainViewport`
- `ISceneView_GetParent`
- `ISceneView_GetPostProcessEnabled`
- `ISceneView_GetPriority`
- `ISceneView_GetRenderAttributesPtr`
- `ISceneView_GetSwapChain`
- `ISceneView_GetToolsVisMode`
- `ISceneView_SetDefaultLayerObjectExcludedFlags`
- `ISceneView_SetDefaultLayerObjectRequiredFlags`
- `ISceneView_SetParent`
- `ISceneView_SetPriority`
- `ISceneWorld_Add3DSkyboxWorld`
- `ISceneWorld_DeleteAllObjects`
- `ISceneWorld_DeleteEndOfFrameObjects`
- `ISceneWorld_GetDeleteAtEndOfFrame`
- `ISceneWorld_GetPVS`
- `ISceneWorld_GetSceneObjectCount`
- `ISceneWorld_GetWorldDebugName`
- `ISceneWorld_IsEmpty`
- `ISceneWorld_MeshTrace`
- `ISceneWorld_Release`
- `ISceneWorld_Remove3DSkyboxWorld`
- `ISceneWorld_Set3DSkyboxParameters`
- `ISceneWorld_SetDeleteAtEndOfFrame`
- `ISceneWorld_SetPVS`
- `ISteamApps_BIsAppInstalled`
- `ISteamApps_BIsCybercafe`
- `ISteamApps_BIsDlcInstalled`
- `ISteamApps_BIsLowViolence`
- `ISteamApps_BIsSubscribed`
- `ISteamApps_BIsSubscribedApp`
- `ISteamApps_BIsVACBanned`
- `ISteamApps_GetAppBuildId`
- `ISteamApps_GetAppInstallDir`
- `ISteamApps_GetAvailableGameLanguages`
- `ISteamApps_GetCommandLine`
- `ISteamApps_GetCurrentGameLanguage`
- `ISteamFriends_ClearRichPresence`
- `ISteamFriends_GetPersonaName`
- `ISteamFriends_GetProfileItemPropertyString`
- `ISteamFriends_RequestEquippedProfileItems`
- `ISteamFriends_SetRichPresence`
- `ISteamGameServer_BLoggedOn`
- `ISteamGameServer_BeginAuthSession`
- `ISteamGameServer_CancelAuthTicket`
- `ISteamGameServer_EndAuthSession`
- `ISteamGameServer_GetAuthSessionTicket`
- `ISteamGameServer_LogOff`
- `ISteamGameServer_LogOn`
- `ISteamGameServer_LogOnAnonymous`
- `ISteamGameServer_SetAdvertiseServerActive`
- `ISteamGameServer_SetDedicatedServer`
- `ISteamGameServer_SetGameDescription`
- `ISteamGameServer_SetGameTags`
- `ISteamGameServer_SetMapName`
- `ISteamGameServer_SetMaxPlayerCount`
- `ISteamGameServer_SetModDir`
- `ISteamGameServer_SetProduct`
- `ISteamGameServer_SetServerName`
- `ISteamUser_BLoggedOn`
- `ISteamUser_BeginAuthSession`
- `ISteamUser_CancelAuthTicket`
- `ISteamUser_DecompressVoice`
- `ISteamUser_EndAuthSession`
- `ISteamUser_GetAuthSessionTicket`
- `ISteamUser_GetAvailableVoice`
- `ISteamUser_GetSteamID`
- `ISteamUser_GetVoice`
- `ISteamUser_GetVoiceOptimalSampleRate`
- `ISteamUser_StartVoiceRecording`
- `ISteamUser_StopVoiceRecording`
- `ISteamUtils_FilterText`
- `ISteamUtils_InitFilterText`
- `ITonemapSystem_ResetTonemapParameters`
- `ITonemapSystem_SetTonemapParameters`
- `IVfx_ClearShaderCache`
- `IVfx_CompileShader`
- `IVfx_CreateSharedContext`
- `IVfx_Init`
- `IVolumetricFog_IsFoggingEnabled`
- `IVolumetricFog_SetParams`
- `IWorldReference_GetEntityCount`
- `IWorldReference_GetEntityKeyValues`
- `IWorldReference_GetFolder`
- `IWorldReference_GetSceneWorld`
- `IWorldReference_GetWorldBounds`
- `IWorldReference_IsErrorWorld`
- `IWorldReference_IsMarkedForDeletion`
- `IWorldReference_IsWorldLoaded`
- `IWorldReference_PrecacheAllWorldNodes`
- `IWorldReference_Release`
- `IWorldReference_SetWorldTransform`
- `ImageLoader_ConvertImageFormat`
- `ImageLoader_GetMemRequired`
- `ImageLoader_GetMemRequired_1`
- `KeyValues3_ArrayAddToTail`
- `KeyValues3_Create`
- `KeyValues3_DeleteThis`
- `KeyValues3_FindOrCreateMember`
- `KeyValues3_GetArrayElement`
- `KeyValues3_GetArrayLength`
- `KeyValues3_GetMember`
- `KeyValues3_GetMemberCount`
- `KeyValues3_GetMemberFloat`
- `KeyValues3_GetMemberInt`
- `KeyValues3_GetMemberName`
- `KeyValues3_GetMemberString`
- `KeyValues3_GetMemberVector`
- `KeyValues3_GetType`
- `KeyValues3_GetValueBool`
- `KeyValues3_GetValueColor`
- `KeyValues3_GetValueDouble`
- `KeyValues3_GetValueFloat`
- `KeyValues3_GetValueInt`
- `KeyValues3_GetValueInt64`
- `KeyValues3_GetValueString`
- `KeyValues3_GetValueUint64`
- `KeyValues3_GetValueVector`
- `KeyValues3_IsArray`
- `KeyValues3_IsTable`
- `KeyValues3_SetMemberFloat`
- `KeyValues3_SetMemberInt`
- `KeyValues3_SetMemberString`
- `KeyValues3_SetToEmptyArray`
- `KeyValues3_SetToEmptyTable`
- `KeyValues3_SetValueBool`
- `KeyValues3_SetValueFloat`
- `KeyValues3_SetValueInt`
- `KeyValues3_SetValueResourceString`
- `KeyValues3_SetValueString`
- `MeshGlue_ClipPolygonLineSegment`
- `MeshGlue_CreateIndexBuffer`
- `MeshGlue_CreateModel`
- `MeshGlue_CreateRenderMesh`
- `MeshGlue_CreateVertexBuffer`
- `MeshGlue_GetModelBaseVertex`
- `MeshGlue_GetModelIndexCount`
- `MeshGlue_GetModelIndexStart`
- `MeshGlue_GetModelIndices`
- `MeshGlue_GetModelNumIndices`
- `MeshGlue_GetModelNumVertices`
- `MeshGlue_GetModelVertices`
- `MeshGlue_LockIndexBuffer`
- `MeshGlue_LockVertexBuffer`
- `MeshGlue_SetIndexBufferData`
- `MeshGlue_SetIndexBufferSize`
- `MeshGlue_SetMeshBounds`
- `MeshGlue_SetMeshIndexBuffer`
- `MeshGlue_SetMeshIndexRange`
- `MeshGlue_SetMeshMaterial`
- `MeshGlue_SetMeshPrimType`
- `MeshGlue_SetMeshUvDensity`
- `MeshGlue_SetMeshVertexBuffer`
- `MeshGlue_SetMeshVertexRange`
- `MeshGlue_SetVertexBufferData`
- `MeshGlue_SetVertexBufferSize`
- `MeshGlue_TriangulatePolygon`
- `MeshGlue_UnlockIndexBuffer`
- `MeshGlue_UnlockVertexBuffer`
- `NativeEngine_SDLGmCntrllr_Close`
- `NativeEngine_SDLGmCntrllr_GetAccelerometer`
- `NativeEngine_SDLGmCntrllr_GetAxis`
- `NativeEngine_SDLGmCntrllr_GetControllerType`
- `NativeEngine_SDLGmCntrllr_GetGyroscope`
- `NativeEngine_SDLGmCntrllr_Rumble`
- `NativeEngine_SDLGmCntrllr_RumbleTriggers`
- `NativeEngine_SDLGmCntrllr_SetLEDColor`
- `NativeLowLevel_Copy`
- `PerformanceTrace_BeginEvent`
- `PerformanceTrace_EndEvent`
- `PhysSrfcPrprtyCn_AddProperty`
- `PhysSrfcPrprtyCn_GetSurfacePropCount`
- `PhysSrfcPrprtyCn_GetSurfaceProperty`
- `Physggrgtnstnc_AddAngularVelocity`
- `Physggrgtnstnc_AddVelocity`
- `Physggrgtnstnc_FindBodyByName`
- `Physggrgtnstnc_GetBodyByNameHash`
- `Physggrgtnstnc_GetBodyCount`
- `Physggrgtnstnc_GetBodyHandle`
- `Physggrgtnstnc_GetBodyIndex`
- `Physggrgtnstnc_GetBodyName`
- `Physggrgtnstnc_GetBodyNameHash`
- `Physggrgtnstnc_GetJointCount`
- `Physggrgtnstnc_GetJointHandle`
- `Physggrgtnstnc_GetMassCenter`
- `Physggrgtnstnc_GetOrigin`
- `Physggrgtnstnc_GetTotalMass`
- `Physggrgtnstnc_GetWorld`
- `Physggrgtnstnc_IsAsleep`
- `Physggrgtnstnc_PutToSleep`
- `Physggrgtnstnc_RemoveJoint`
- `Physggrgtnstnc_SetAngularDamping`
- `Physggrgtnstnc_SetAngularVelocity`
- `Physggrgtnstnc_SetLinearDamping`
- `Physggrgtnstnc_SetSurfaceProperties`
- `Physggrgtnstnc_SetTotalMass`
- `Physggrgtnstnc_SetVelocity`
- `Physggrgtnstnc_WakeUp`
- `PhysicsTrace_Trace`
- `PhysicsTrace_TraceAgainstBBox`
- `PhysicsTrace_TraceAgainstCapsule`
- `PhysicsTrace_TraceAgainstSphere`
- `PhysicsTrace_TraceAll`
- `RD_RgstrRsrcDttl_GetDataRegistrationFailed`
- `RD_RgstrRsrcDttl_GetFinalResourceData`
- `RD_RgstrRsrcDttl_GetResultBufferSize`
- `RD_RgstrRsrcDttl_IsReloading`
- `RD_RgstrRsrcDttl_SetDataRegistrationFailed`
- `RD_RgstrRsrcDttl_SetFinalResourceData`
- `RnHullDesc_t_GetHull`
- `RnHull_t_GetBbox`
- `RnHull_t_GetCentroid`
- `RnHull_t_GetEdgeCount`
- `RnHull_t_GetEdgeVertex`
- `RnHull_t_GetMassCenter`
- `RnHull_t_GetMemory`
- `RnHull_t_GetSurfaceArea`
- `RnHull_t_GetVertex`
- `RnHull_t_GetVertexCount`
- `RnHull_t_GetVolume`
- `RnMeshDesc_t_GetMesh`
- `RnMesh_t_GetBbox`
- `RnMesh_t_GetHeight`
- `RnMesh_t_GetMaterialCount`
- `RnMesh_t_GetMemory`
- `RnMesh_t_GetTriangle`
- `RnMesh_t_GetTriangleCount`
- `RyTrcScnWrld_AddSceneWorldToBuild`
- `RyTrcScnWrld_BeginBuild`
- `RyTrcScnWrld_BuildTLASForWorld`
- `RyTrcScnWrld_EndBuild`
- `ShaderTools_GetShaderSource`
- `ShaderTools_MaskShaderSource`
- `ShdrCmplCntxt_Delete`
- `ShdrCmplCntxt_SetMaskedCode`
- `SheetSequence_t_FrameCount`
- `ShtSqncFrm_t_GetImage`
- `ShtSqncFrm_t_ImageCount`
- `SteamUgc_CUgcInstall_Create`
- `SteamUgc_CUgcInstall_Dispose`
- `SteamUgc_CUgcInstall_GetResultJson`
- `SteamUgc_CUgcQuery_CreateQuery`
- `SteamUgc_CUgcQuery_Dispose`
- `SteamUgc_CUgcQuery_GetResultJson`
- `SteamUgc_CUgcUpdate_AddKeyValueTag`
- `SteamUgc_CUgcUpdate_AddPreviewFile`
- `SteamUgc_CUgcUpdate_AddPreviewVideo`
- `SteamUgc_CUgcUpdate_CreateCommunityItem`
- `SteamUgc_CUgcUpdate_CreateMtxItem`
- `SteamUgc_CUgcUpdate_Dispose`
- `SteamUgc_CUgcUpdate_GetBytesProcessed`
- `SteamUgc_CUgcUpdate_GetBytesTotal`
- `SteamUgc_CUgcUpdate_GetProgressPercent`
- `SteamUgc_CUgcUpdate_GetPublishedFileId`
- `SteamUgc_CUgcUpdate_OpenCommunityItem`
- `SteamUgc_CUgcUpdate_RemoveAllKeyValueTags`
- `SteamUgc_CUgcUpdate_RemoveKeyValueTags`
- `SteamUgc_CUgcUpdate_RemovePreview`
- `SteamUgc_CUgcUpdate_SetAllowLegacyUpload`
- `SteamUgc_CUgcUpdate_SetContentFolder`
- `SteamUgc_CUgcUpdate_SetDescription`
- `SteamUgc_CUgcUpdate_SetLanguage`
- `SteamUgc_CUgcUpdate_SetMetadata`
- `SteamUgc_CUgcUpdate_SetPreviewImage`
- `SteamUgc_CUgcUpdate_SetRequiredGameVersions`
- `SteamUgc_CUgcUpdate_SetTag`
- `SteamUgc_CUgcUpdate_SetTitle`
- `SteamUgc_CUgcUpdate_SetVisibility`
- `SteamUgc_CUgcUpdate_Submit`
- `SteamUgc_CUgcUpdate_UpdatePreviewFile`
- `SteamUgc_CUgcUpdate_UpdatePreviewVideo`
- `Steam_Inventory_CheckOut`
- `Steam_Inventory_DefinitionCount`
- `Steam_Inventory_GetAllItems`
- `Steam_Inventory_GetCurrency`
- `Steam_Inventory_GetDefinitionId`
- `Steam_Inventory_GetDefinitionPrice`
- `Steam_Inventory_GetDefinitionProperty`
- `Steam_Inventory_HasPrices`
- `Steam_Inventory_IsCheckingOut`
- `Steam_Inventory_WasCheckoutSuccessful`
- `Steam_Screenshots_WriteScreenshot`
- `StmHTMLSrfc_AddHeader`
- `StmHTMLSrfc_AllowStartRequest`
- `StmHTMLSrfc_CreateBrowser`
- `StmHTMLSrfc_GetLinkAtPosition`
- `StmHTMLSrfc_Init`
- `StmHTMLSrfc_JSDialogResponse`
- `StmHTMLSrfc_KeyChar`
- `StmHTMLSrfc_KeyDown`
- `StmHTMLSrfc_KeyUp`
- `StmHTMLSrfc_LoadURL`
- `StmHTMLSrfc_MouseDoubleClick`
- `StmHTMLSrfc_MouseDown`
- `StmHTMLSrfc_MouseMove`
- `StmHTMLSrfc_MouseUp`
- `StmHTMLSrfc_MouseWheel`
- `StmHTMLSrfc_RemoveBrowser`
- `StmHTMLSrfc_SetBackgroundMode`
- `StmHTMLSrfc_SetCookie`
- `StmHTMLSrfc_SetDPIScalingFactor`
- `StmHTMLSrfc_SetHorizontalScroll`
- `StmHTMLSrfc_SetKeyFocus`
- `StmHTMLSrfc_SetSize`
- `StmHTMLSrfc_SetVerticalScroll`
- `StmHTMLSrfc_Shutdown`
- `StmMtchmkng_DeleteLobbyData`
- `StmMtchmkng_GetLobbyData`
- `StmMtchmkng_GetLobbyDataByIndex`
- `StmMtchmkng_GetLobbyDataCount`
- `StmMtchmkng_GetLobbyMemberByIndex`
- `StmMtchmkng_GetNumLobbyMembers`
- `StmMtchmkng_LeaveLobby`
- `StmMtchmkng_SetLobbyData`
- `StmNtwrkngMssgs_AcceptSessionWithUser`
- `StmNtwrkngMssgs_CloseChannelWithUser`
- `StmNtwrkngMssgs_GetConnectionInfo`
- `StmNtwrkngMssgs_ReceiveMessagesOnChannel`
- `StmNtwrkngMssgs_ReleaseMessage`
- `StmNtwrkngMssgs_SendMessageToUser`
- `StmNtwrkngSckts_BeginRequestFakeIP`
- `StmNtwrkngSckts_GetConnectionInfo`
- `StmNtwrkngSckts_ReleaseMessage`
- `StmNtwrkngSckts_StartAuthentication`
- `StmNtwrkngtls_InitializeRelayNetwork`
- `StmNtwrkngtls_SetConfig`
- `StmNtwrkngtls_SetConfig_1`
- `To_IReadBufferCallback_From_CReadBufferManagedCallback`
- `To_IReadTexturePixelsCallback_From_CReadTexturePixelsManagedCallback`
- `VPhysXBodyPart_t_GetCapsule`
- `VPhysXBodyPart_t_GetCapsuleCount`
- `VPhysXBodyPart_t_GetCollisionAttributeCount`
- `VPhysXBodyPart_t_GetCollisionAttributeIndex`
- `VPhysXBodyPart_t_GetHull`
- `VPhysXBodyPart_t_GetHullCount`
- `VPhysXBodyPart_t_GetMesh`
- `VPhysXBodyPart_t_GetMeshCount`
- `VPhysXBodyPart_t_GetSphere`
- `VPhysXBodyPart_t_GetSphereCount`
- `VPhysXJoint_t_GetLinearLimitMax`
- `VPhysXJoint_t_GetLinearLimitMin`
- `VPhysXJoint_t_GetSwingLimitMax`
- `VPhysXJoint_t_GetSwingLimitMin`
- `VPhysXJoint_t_GetTwistLimitMax`
- `VPhysXJoint_t_GetTwistLimitMin`
- `VPhysXJoint_t_SetLinearLimitMax`
- `VPhysXJoint_t_SetLinearLimitMin`
- `VPhysXJoint_t_SetSwingLimitMax`
- `VPhysXJoint_t_SetSwingLimitMin`
- `VPhysXJoint_t_SetTwistLimitMax`
- `VPhysXJoint_t_SetTwistLimitMin`
- `VSound_t_BitsPerSample`
- `VSound_t_BytesPerSample`
- `VSound_t_CopyStrongHandle`
- `VSound_t_DestroyStrongHandle`
- `VSound_t_Duration`
- `VSound_t_GetBindingPtr`
- `VSound_t_IsError`
- `VSound_t_IsStrongHandleLoaded`
- `VSound_t_IsStrongHandleValid`
- `VSound_t_channels`
- `VSound_t_format`
- `VSound_t_m_rate`
- `VSound_t_m_sampleFrameSize`
- `VertexLayout_Add`
- `VertexLayout_Build`
- `VertexLayout_Create`
- `VertexLayout_Destroy`
- `VertexLayout_Free`
- `VfxCmpldShdrnf_t_Delete`
- `WindowsGlue_FindFile`
- `_Get__CAttachment_m_bIgnoreRotation`
- `_Get__CAttachment_m_nInfluences`
- `_Get__CAttachment_m_name`
- `_Get__CBldrMtrlGrp_m_name`
- `_Get__CCameraRenderer_CameraPosition`
- `_Get__CCameraRenderer_CameraRotation`
- `_Get__CCameraRenderer_ClipSpaceBounds`
- `_Get__CCameraRenderer_EnableEngineOverlays`
- `_Get__CCameraRenderer_EnablePostprocessing`
- `_Get__CCameraRenderer_FieldOfView`
- `_Get__CCameraRenderer_FlipX`
- `_Get__CCameraRenderer_FlipY`
- `_Get__CCameraRenderer_HasOverrideProjection`
- `_Get__CCameraRenderer_IsRenderingStereo`
- `_Get__CCameraRenderer_MiddleEyePosition`
- `_Get__CCameraRenderer_MiddleEyeRotation`
- `_Get__CCameraRenderer_NeedTonemapRenderer`
- `_Get__CCameraRenderer_Ortho`
- `_Get__CCameraRenderer_OrthoSize`
- `_Get__CCameraRenderer_OverrideProjection`
- `_Get__CCameraRenderer_Rect`
- `_Get__CCameraRenderer_SceneViewFlags`
- `_Get__CCameraRenderer_ViewUniqueId`
- `_Get__CCameraRenderer_Viewport`
- `_Get__CCameraRenderer_ZFar`
- `_Get__CCameraRenderer_ZNear`
- `_Get__CDclScnbjct_m_flAttenuationAngle`
- `_Get__CDclScnbjct_m_flColorMix`
- `_Get__CDclScnbjct_m_flEmissionEnergy`
- `_Get__CDclScnbjct_m_flParallaxStrength`
- `_Get__CDclScnbjct_m_hColor`
- `_Get__CDclScnbjct_m_hEmission`
- `_Get__CDclScnbjct_m_hHeight`
- `_Get__CDclScnbjct_m_hNormal`
- `_Get__CDclScnbjct_m_hRMO`
- `_Get__CDclScnbjct_m_nExclusionBitMask`
- `_Get__CDclScnbjct_m_nSamplerIndex`
- `_Get__CDclScnbjct_m_nSequenceIndex`
- `_Get__CDclScnbjct_m_nSortOrder`
- `_Get__CDclScnbjct_m_vColorTint`
- `_Get__CDynmcScnbjct_Material`
- `_Get__CHitBoxSet_m_SourceFilename`
- `_Get__CHitBoxSet_m_name`
- `_Get__CHitBox_m_bForcedTransform`
- `_Get__CHitBox_m_bSelected`
- `_Get__CHitBox_m_bTranslationOnly`
- `_Get__CHitBox_m_bVisible`
- `_Get__CHitBox_m_cRenderColor`
- `_Get__CHitBox_m_flShapeRadius`
- `_Get__CHitBox_m_nBoneNameHash`
- `_Get__CHitBox_m_nHitBoxIndex`
- `_Get__CHitBox_m_nShapeType`
- `_Get__CHitBox_m_name`
- `_Get__CHitBox_m_sBoneName`
- `_Get__CHitBox_m_sSurfaceProperty`
- `_Get__CHitBox_m_vMaxBounds`
- `_Get__CHitBox_m_vMinBounds`
- `_Get__CMngdScnbjct_ExecuteOnMainThread`
- `_Get__CPhysBodyDesc_m_flMass`
- `_Get__CPhysSrfcPrprts_m_AudioSurface`
- `_Get__CPhysSrfcPrprts_m_bHidden`
- `_Get__CPhysSrfcPrprts_m_baseNameHash`
- `_Get__CPhysSrfcPrprts_m_description`
- `_Get__CPhysSrfcPrprts_m_nBaseIndex`
- `_Get__CPhysSrfcPrprts_m_nIndex`
- `_Get__CPhysSrfcPrprts_m_name`
- `_Get__CPhysSrfcPrprts_m_nameHash`
- `_Get__CPhysggrgtDt_m_nFlags`
- `_Get__CScnLghtPrbVlmbj_m_hLightProbeDirectLightIndicesTexture`
- `_Get__CScnLghtPrbVlmbj_m_hLightProbeDirectLightScalarsTexture`
- `_Get__CScnLghtPrbVlmbj_m_hLightProbeTexture`
- `_Get__CScnLghtPrbVlmbj_m_nHandshake`
- `_Get__CScnLghtPrbVlmbj_m_nRenderPriority`
- `_Get__CScnLghtPrbVlmbj_m_vBoxMaxs`
- `_Get__CScnLghtPrbVlmbj_m_vBoxMins`
- `_Get__CScnnmtblbjct_m_flDeltaTime`
- `_Get__CScnnmtblbjct_m_localBounds`
- `_Get__CScnnmtblbjct_m_worldBounds`
- `_Get__CVfxCombo_m_nMax`
- `_Get__CVfxCombo_m_nMin`
- `_Get__CVfxProgramData_m_bLoadedFromVcsFile`
- `_Get__CnvMpScnbjct_m_flFeathering`
- `_Get__CnvMpScnbjct_m_hEnvMapTexture`
- `_Get__CnvMpScnbjct_m_nProjectionMode`
- `_Get__CnvMpScnbjct_m_nRenderPriority`
- `_Get__CnvMpScnbjct_m_vBoxProjectMaxs`
- `_Get__CnvMpScnbjct_m_vBoxProjectMins`
- `_Get__CnvMpScnbjct_m_vColor`
- `_Get__CnvMpScnbjct_m_vNormalizationSH`
- `_Get__ISceneLayer_LayerEnum`
- `_Get__ISceneLayer_m_nClearFlags`
- `_Get__ISceneLayer_m_nLayerFlags`
- `_Get__ISceneLayer_m_viewport`
- `_Get__ISceneView_m_ManagedCameraId`
- `_Get__ISceneView_m_ViewUniqueId`
- `_Get__RnCapsuleDesc_t_m_Capsule`
- `_Get__RnCapsuleDesc_t_m_nCollisionAttributeIndex`
- `_Get__RnCapsuleDesc_t_m_nSurfacePropertyIndex`
- `_Get__RnHullDesc_t_m_nCollisionAttributeIndex`
- `_Get__RnHullDesc_t_m_nSurfacePropertyIndex`
- `_Get__RnMeshDesc_t_m_nCollisionAttributeIndex`
- `_Get__RnMeshDesc_t_m_nSurfacePropertyIndex`
- `_Get__RnSphereDesc_t_m_Sphere`
- `_Get__RnSphereDesc_t_m_nCollisionAttributeIndex`
- `_Get__RnSphereDesc_t_m_nSurfacePropertyIndex`
- `_Get__ScnSystmPrFrmStt_m_nAggregateSceneObjectDrawCalls`
- `_Get__ScnSystmPrFrmStt_m_nAggregateSceneObjectPrimDraws`
- `_Get__ScnSystmPrFrmStt_m_nAggregateSceneObjectsFullyCulled`
- `_Get__ScnSystmPrFrmStt_m_nAnimatableObjectPrimDraws`
- `_Get__ScnSystmPrFrmStt_m_nArtistTrianglesRendered`
- `_Get__ScnSystmPrFrmStt_m_nBaseSceneObjectPrimDraws`
- `_Get__ScnSystmPrFrmStt_m_nCopyMaterialChangesNonShadow`
- `_Get__ScnSystmPrFrmStt_m_nCullingBoxCycleCount`
- `_Get__ScnSystmPrFrmStt_m_nDrawCalls`
- `_Get__ScnSystmPrFrmStt_m_nDrawPrimitives`
- `_Get__ScnSystmPrFrmStt_m_nMaterialChangesNonShadow`
- `_Get__ScnSystmPrFrmStt_m_nMaterialChangesNonShadowInitial`
- `_Get__ScnSystmPrFrmStt_m_nMaterialChangesShadow`
- `_Get__ScnSystmPrFrmStt_m_nMaterialChangesShadowAlphaTested`
- `_Get__ScnSystmPrFrmStt_m_nMaterialChangesShadowInitial`
- `_Get__ScnSystmPrFrmStt_m_nMaxTransformRow`
- `_Get__ScnSystmPrFrmStt_m_nNumConstantBufferBytes`
- `_Get__ScnSystmPrFrmStt_m_nNumConstantBufferUpdates`
- `_Get__ScnSystmPrFrmStt_m_nNumCullBoxes`
- `_Get__ScnSystmPrFrmStt_m_nNumDisplayListsSubmitted`
- `_Get__ScnSystmPrFrmStt_m_nNumFadingObjects`
- `_Get__ScnSystmPrFrmStt_m_nNumMaterialCompute`
- `_Get__ScnSystmPrFrmStt_m_nNumMaterialSet`
- `_Get__ScnSystmPrFrmStt_m_nNumObjectsPassingCullCheck`
- `_Get__ScnSystmPrFrmStt_m_nNumObjectsPreCullCheck`
- `_Get__ScnSystmPrFrmStt_m_nNumObjectsRejectedByBackfaceCulling`
- `_Get__ScnSystmPrFrmStt_m_nNumObjectsRejectedByBoundsIndex`
- `_Get__ScnSystmPrFrmStt_m_nNumObjectsRejectedByCullBoxes`
- `_Get__ScnSystmPrFrmStt_m_nNumObjectsRejectedByFading`
- `_Get__ScnSystmPrFrmStt_m_nNumObjectsRejectedByScreenSizeCulling`
- `_Get__ScnSystmPrFrmStt_m_nNumObjectsRejectedByVis`
- `_Get__ScnSystmPrFrmStt_m_nNumObjectsTested`
- `_Get__ScnSystmPrFrmStt_m_nNumObjectsTestedAgainstCullingBoxes`
- `_Get__ScnSystmPrFrmStt_m_nNumPrimaryContexts`
- `_Get__ScnSystmPrFrmStt_m_nNumRenderTargetBinds`
- `_Get__ScnSystmPrFrmStt_m_nNumResolves`
- `_Get__ScnSystmPrFrmStt_m_nNumRowsUsed`
- `_Get__ScnSystmPrFrmStt_m_nNumSecondaryContexts`
- `_Get__ScnSystmPrFrmStt_m_nNumShadowMaps`
- `_Get__ScnSystmPrFrmStt_m_nNumShadowedLightsInView`
- `_Get__ScnSystmPrFrmStt_m_nNumSimilarMaterialSet`
- `_Get__ScnSystmPrFrmStt_m_nNumTextureOnlyMaterialSet`
- `_Get__ScnSystmPrFrmStt_m_nNumUniqueMaterialsSeen`
- `_Get__ScnSystmPrFrmStt_m_nNumUnshadowedLightsInView`
- `_Get__ScnSystmPrFrmStt_m_nNumVerticesReferenced`
- `_Get__ScnSystmPrFrmStt_m_nNumVfxEval`
- `_Get__ScnSystmPrFrmStt_m_nNumVfxRule`
- `_Get__ScnSystmPrFrmStt_m_nNumViewsRendered`
- `_Get__ScnSystmPrFrmStt_m_nPushConstantSets`
- `_Get__ScnSystmPrFrmStt_m_nRenderBatchDraws`
- `_Get__ScnSystmPrFrmStt_m_nTrianglesRendered`
- `_Get__SheetSequence_t_m_bAlphaCrop`
- `_Get__SheetSequence_t_m_bClamp`
- `_Get__SheetSequence_t_m_bNoAlpha`
- `_Get__SheetSequence_t_m_bNoColor`
- `_Get__SheetSequence_t_m_flTotalTime`
- `_Get__SheetSequence_t_m_nId`
- `_Get__ShtSqncFrm_t_m_flDisplayTime`
- `_Get__SteamUgc_CUgcInstall_m_complete`
- `_Get__SteamUgc_CUgcInstall_m_resultCode`
- `_Get__SteamUgc_CUgcInstall_m_success`
- `_Get__SteamUgc_CUgcQuery_m_complete`
- `_Get__SteamUgc_CUgcQuery_m_resultCode`
- `_Get__SteamUgc_CUgcQuery_m_success`
- `_Get__SteamUgc_CUgcUpdate_m_bNeedsLegalAgreement`
- `_Get__SteamUgc_CUgcUpdate_m_complete`
- `_Get__SteamUgc_CUgcUpdate_m_created`
- `_Get__SteamUgc_CUgcUpdate_m_creating`
- `_Get__SteamUgc_CUgcUpdate_m_resultCode`
- `_Get__SteamUgc_CUgcUpdate_m_submitted`
- `_Get__SteamUgc_CUgcUpdate_m_success`
- `_Get__VPhysXBodyPart_t_m_bOverrideMassCenter`
- `_Get__VPhysXBodyPart_t_m_flAngularDamping`
- `_Get__VPhysXBodyPart_t_m_flInertiaScale`
- `_Get__VPhysXBodyPart_t_m_flLinearDamping`
- `_Get__VPhysXBodyPart_t_m_flMass`
- `_Get__VPhysXBodyPart_t_m_nCollisionAttributeIndex`
- `_Get__VPhysXBodyPart_t_m_nFlags`
- `_Get__VPhysXBodyPart_t_m_vMassCenterOverride`
- `_Get__VPhysXJoint_t_m_Frame1`
- `_Get__VPhysXJoint_t_m_Frame2`
- `_Get__VPhysXJoint_t_m_bEnableAngularMotor`
- `_Get__VPhysXJoint_t_m_bEnableCollision`
- `_Get__VPhysXJoint_t_m_bEnableLinearLimit`
- `_Get__VPhysXJoint_t_m_bEnableLinearMotor`
- `_Get__VPhysXJoint_t_m_bEnableSwingLimit`
- `_Get__VPhysXJoint_t_m_bEnableTwistLimit`
- `_Get__VPhysXJoint_t_m_flAngularDampingRatio`
- `_Get__VPhysXJoint_t_m_flAngularFrequency`
- `_Get__VPhysXJoint_t_m_flAngularStrength`
- `_Get__VPhysXJoint_t_m_flLinearDampingRatio`
- `_Get__VPhysXJoint_t_m_flLinearFrequency`
- `_Get__VPhysXJoint_t_m_flLinearStrength`
- `_Get__VPhysXJoint_t_m_flMaxForce`
- `_Get__VPhysXJoint_t_m_flMaxTorque`
- `_Get__VPhysXJoint_t_m_nBody1`
- `_Get__VPhysXJoint_t_m_nBody2`
- `_Get__VPhysXJoint_t_m_nFlags`
- `_Get__VPhysXJoint_t_m_nType`
- `_Get__VPhysXJoint_t_m_vAngularTargetVelocity`
- `_Get__VPhysXJoint_t_m_vLinearTargetVelocity`
- `_Get__VfxCmpldShdrnf_t_compileFailed`
- `_Get__VfxCmpldShdrnf_t_compilerOutput`
- `_Set__CAttachment_m_bIgnoreRotation`
- `_Set__CAttachment_m_nInfluences`
- `_Set__CAttachment_m_name`
- `_Set__CBldrMtrlGrp_m_name`
- `_Set__CCameraRenderer_CameraPosition`
- `_Set__CCameraRenderer_CameraRotation`
- `_Set__CCameraRenderer_ClipSpaceBounds`
- `_Set__CCameraRenderer_EnableEngineOverlays`
- `_Set__CCameraRenderer_EnablePostprocessing`
- `_Set__CCameraRenderer_FieldOfView`
- `_Set__CCameraRenderer_FlipX`
- `_Set__CCameraRenderer_FlipY`
- `_Set__CCameraRenderer_HasOverrideProjection`
- `_Set__CCameraRenderer_IsRenderingStereo`
- `_Set__CCameraRenderer_MiddleEyePosition`
- `_Set__CCameraRenderer_MiddleEyeRotation`
- `_Set__CCameraRenderer_NeedTonemapRenderer`
- `_Set__CCameraRenderer_Ortho`
- `_Set__CCameraRenderer_OrthoSize`
- `_Set__CCameraRenderer_OverrideProjection`
- `_Set__CCameraRenderer_Rect`
- `_Set__CCameraRenderer_SceneViewFlags`
- `_Set__CCameraRenderer_ViewUniqueId`
- `_Set__CCameraRenderer_Viewport`
- `_Set__CCameraRenderer_ZFar`
- `_Set__CCameraRenderer_ZNear`
- `_Set__CDclScnbjct_m_flAttenuationAngle`
- `_Set__CDclScnbjct_m_flColorMix`
- `_Set__CDclScnbjct_m_flEmissionEnergy`
- `_Set__CDclScnbjct_m_flParallaxStrength`
- `_Set__CDclScnbjct_m_hColor`
- `_Set__CDclScnbjct_m_hEmission`
- `_Set__CDclScnbjct_m_hHeight`
- `_Set__CDclScnbjct_m_hNormal`
- `_Set__CDclScnbjct_m_hRMO`
- `_Set__CDclScnbjct_m_nExclusionBitMask`
- `_Set__CDclScnbjct_m_nSamplerIndex`
- `_Set__CDclScnbjct_m_nSequenceIndex`
- `_Set__CDclScnbjct_m_nSortOrder`
- `_Set__CDclScnbjct_m_vColorTint`
- `_Set__CDynmcScnbjct_Material`
- `_Set__CHitBoxSet_m_SourceFilename`
- `_Set__CHitBoxSet_m_name`
- `_Set__CHitBox_m_bForcedTransform`
- `_Set__CHitBox_m_bSelected`
- `_Set__CHitBox_m_bTranslationOnly`
- `_Set__CHitBox_m_bVisible`
- `_Set__CHitBox_m_cRenderColor`
- `_Set__CHitBox_m_flShapeRadius`
- `_Set__CHitBox_m_nBoneNameHash`
- `_Set__CHitBox_m_nHitBoxIndex`
- `_Set__CHitBox_m_nShapeType`
- `_Set__CHitBox_m_name`
- `_Set__CHitBox_m_sBoneName`
- `_Set__CHitBox_m_sSurfaceProperty`
- `_Set__CHitBox_m_vMaxBounds`
- `_Set__CHitBox_m_vMinBounds`
- `_Set__CMngdScnbjct_ExecuteOnMainThread`
- `_Set__CPhysBodyDesc_m_flMass`
- `_Set__CPhysSrfcPrprts_m_AudioSurface`
- `_Set__CPhysSrfcPrprts_m_bHidden`
- `_Set__CPhysSrfcPrprts_m_baseNameHash`
- `_Set__CPhysSrfcPrprts_m_description`
- `_Set__CPhysSrfcPrprts_m_nBaseIndex`
- `_Set__CPhysSrfcPrprts_m_nIndex`
- `_Set__CPhysSrfcPrprts_m_name`
- `_Set__CPhysSrfcPrprts_m_nameHash`
- `_Set__CPhysggrgtDt_m_nFlags`
- `_Set__CScnLghtPrbVlmbj_m_hLightProbeDirectLightIndicesTexture`
- `_Set__CScnLghtPrbVlmbj_m_hLightProbeDirectLightScalarsTexture`
- `_Set__CScnLghtPrbVlmbj_m_hLightProbeTexture`
- `_Set__CScnLghtPrbVlmbj_m_nHandshake`
- `_Set__CScnLghtPrbVlmbj_m_nRenderPriority`
- `_Set__CScnLghtPrbVlmbj_m_vBoxMaxs`
- `_Set__CScnLghtPrbVlmbj_m_vBoxMins`
- `_Set__CScnnmtblbjct_m_flDeltaTime`
- `_Set__CScnnmtblbjct_m_localBounds`
- `_Set__CScnnmtblbjct_m_worldBounds`
- `_Set__CVfxCombo_m_nMax`
- `_Set__CVfxCombo_m_nMin`
- `_Set__CVfxProgramData_m_bLoadedFromVcsFile`
- `_Set__CnvMpScnbjct_m_flFeathering`
- `_Set__CnvMpScnbjct_m_hEnvMapTexture`
- `_Set__CnvMpScnbjct_m_nProjectionMode`
- `_Set__CnvMpScnbjct_m_nRenderPriority`
- `_Set__CnvMpScnbjct_m_vBoxProjectMaxs`
- `_Set__CnvMpScnbjct_m_vBoxProjectMins`
- `_Set__CnvMpScnbjct_m_vColor`
- `_Set__CnvMpScnbjct_m_vNormalizationSH`
- `_Set__ISceneLayer_LayerEnum`
- `_Set__ISceneLayer_m_nClearFlags`
- `_Set__ISceneLayer_m_nLayerFlags`
- `_Set__ISceneLayer_m_viewport`
- `_Set__ISceneView_m_ManagedCameraId`
- `_Set__ISceneView_m_ViewUniqueId`
- `_Set__RnCapsuleDesc_t_m_Capsule`
- `_Set__RnCapsuleDesc_t_m_nCollisionAttributeIndex`
- `_Set__RnCapsuleDesc_t_m_nSurfacePropertyIndex`
- `_Set__RnHullDesc_t_m_nCollisionAttributeIndex`
- `_Set__RnHullDesc_t_m_nSurfacePropertyIndex`
- `_Set__RnMeshDesc_t_m_nCollisionAttributeIndex`
- `_Set__RnMeshDesc_t_m_nSurfacePropertyIndex`
- `_Set__RnSphereDesc_t_m_Sphere`
- `_Set__RnSphereDesc_t_m_nCollisionAttributeIndex`
- `_Set__RnSphereDesc_t_m_nSurfacePropertyIndex`
- `_Set__ScnSystmPrFrmStt_m_nAggregateSceneObjectDrawCalls`
- `_Set__ScnSystmPrFrmStt_m_nAggregateSceneObjectPrimDraws`
- `_Set__ScnSystmPrFrmStt_m_nAggregateSceneObjectsFullyCulled`
- `_Set__ScnSystmPrFrmStt_m_nAnimatableObjectPrimDraws`
- `_Set__ScnSystmPrFrmStt_m_nArtistTrianglesRendered`
- `_Set__ScnSystmPrFrmStt_m_nBaseSceneObjectPrimDraws`
- `_Set__ScnSystmPrFrmStt_m_nCopyMaterialChangesNonShadow`
- `_Set__ScnSystmPrFrmStt_m_nCullingBoxCycleCount`
- `_Set__ScnSystmPrFrmStt_m_nDrawCalls`
- `_Set__ScnSystmPrFrmStt_m_nDrawPrimitives`
- `_Set__ScnSystmPrFrmStt_m_nMaterialChangesNonShadow`
- `_Set__ScnSystmPrFrmStt_m_nMaterialChangesNonShadowInitial`
- `_Set__ScnSystmPrFrmStt_m_nMaterialChangesShadow`
- `_Set__ScnSystmPrFrmStt_m_nMaterialChangesShadowAlphaTested`
- `_Set__ScnSystmPrFrmStt_m_nMaterialChangesShadowInitial`
- `_Set__ScnSystmPrFrmStt_m_nMaxTransformRow`
- `_Set__ScnSystmPrFrmStt_m_nNumConstantBufferBytes`
- `_Set__ScnSystmPrFrmStt_m_nNumConstantBufferUpdates`
- `_Set__ScnSystmPrFrmStt_m_nNumCullBoxes`
- `_Set__ScnSystmPrFrmStt_m_nNumDisplayListsSubmitted`
- `_Set__ScnSystmPrFrmStt_m_nNumFadingObjects`
- `_Set__ScnSystmPrFrmStt_m_nNumMaterialCompute`
- `_Set__ScnSystmPrFrmStt_m_nNumMaterialSet`
- `_Set__ScnSystmPrFrmStt_m_nNumObjectsPassingCullCheck`
- `_Set__ScnSystmPrFrmStt_m_nNumObjectsPreCullCheck`
- `_Set__ScnSystmPrFrmStt_m_nNumObjectsRejectedByBackfaceCulling`
- `_Set__ScnSystmPrFrmStt_m_nNumObjectsRejectedByBoundsIndex`
- `_Set__ScnSystmPrFrmStt_m_nNumObjectsRejectedByCullBoxes`
- `_Set__ScnSystmPrFrmStt_m_nNumObjectsRejectedByFading`
- `_Set__ScnSystmPrFrmStt_m_nNumObjectsRejectedByScreenSizeCulling`
- `_Set__ScnSystmPrFrmStt_m_nNumObjectsRejectedByVis`
- `_Set__ScnSystmPrFrmStt_m_nNumObjectsTested`
- `_Set__ScnSystmPrFrmStt_m_nNumObjectsTestedAgainstCullingBoxes`
- `_Set__ScnSystmPrFrmStt_m_nNumPrimaryContexts`
- `_Set__ScnSystmPrFrmStt_m_nNumRenderTargetBinds`
- `_Set__ScnSystmPrFrmStt_m_nNumResolves`
- `_Set__ScnSystmPrFrmStt_m_nNumRowsUsed`
- `_Set__ScnSystmPrFrmStt_m_nNumSecondaryContexts`
- `_Set__ScnSystmPrFrmStt_m_nNumShadowMaps`
- `_Set__ScnSystmPrFrmStt_m_nNumShadowedLightsInView`
- `_Set__ScnSystmPrFrmStt_m_nNumSimilarMaterialSet`
- `_Set__ScnSystmPrFrmStt_m_nNumTextureOnlyMaterialSet`
- `_Set__ScnSystmPrFrmStt_m_nNumUniqueMaterialsSeen`
- `_Set__ScnSystmPrFrmStt_m_nNumUnshadowedLightsInView`
- `_Set__ScnSystmPrFrmStt_m_nNumVerticesReferenced`
- `_Set__ScnSystmPrFrmStt_m_nNumVfxEval`
- `_Set__ScnSystmPrFrmStt_m_nNumVfxRule`
- `_Set__ScnSystmPrFrmStt_m_nNumViewsRendered`
- `_Set__ScnSystmPrFrmStt_m_nPushConstantSets`
- `_Set__ScnSystmPrFrmStt_m_nRenderBatchDraws`
- `_Set__ScnSystmPrFrmStt_m_nTrianglesRendered`
- `_Set__SheetSequence_t_m_bAlphaCrop`
- `_Set__SheetSequence_t_m_bClamp`
- `_Set__SheetSequence_t_m_bNoAlpha`
- `_Set__SheetSequence_t_m_bNoColor`
- `_Set__SheetSequence_t_m_flTotalTime`
- `_Set__SheetSequence_t_m_nId`
- `_Set__ShtSqncFrm_t_m_flDisplayTime`
- `_Set__SteamUgc_CUgcInstall_m_complete`
- `_Set__SteamUgc_CUgcInstall_m_resultCode`
- `_Set__SteamUgc_CUgcInstall_m_success`
- `_Set__SteamUgc_CUgcQuery_m_complete`
- `_Set__SteamUgc_CUgcQuery_m_resultCode`
- `_Set__SteamUgc_CUgcQuery_m_success`
- `_Set__SteamUgc_CUgcUpdate_m_bNeedsLegalAgreement`
- `_Set__SteamUgc_CUgcUpdate_m_complete`
- `_Set__SteamUgc_CUgcUpdate_m_created`
- `_Set__SteamUgc_CUgcUpdate_m_creating`
- `_Set__SteamUgc_CUgcUpdate_m_resultCode`
- `_Set__SteamUgc_CUgcUpdate_m_submitted`
- `_Set__SteamUgc_CUgcUpdate_m_success`
- `_Set__VPhysXBodyPart_t_m_bOverrideMassCenter`
- `_Set__VPhysXBodyPart_t_m_flAngularDamping`
- `_Set__VPhysXBodyPart_t_m_flInertiaScale`
- `_Set__VPhysXBodyPart_t_m_flLinearDamping`
- `_Set__VPhysXBodyPart_t_m_flMass`
- `_Set__VPhysXBodyPart_t_m_nCollisionAttributeIndex`
- `_Set__VPhysXBodyPart_t_m_nFlags`
- `_Set__VPhysXBodyPart_t_m_vMassCenterOverride`
- `_Set__VPhysXJoint_t_m_Frame1`
- `_Set__VPhysXJoint_t_m_Frame2`
- `_Set__VPhysXJoint_t_m_bEnableAngularMotor`
- `_Set__VPhysXJoint_t_m_bEnableCollision`
- `_Set__VPhysXJoint_t_m_bEnableLinearLimit`
- `_Set__VPhysXJoint_t_m_bEnableLinearMotor`
- `_Set__VPhysXJoint_t_m_bEnableSwingLimit`
- `_Set__VPhysXJoint_t_m_bEnableTwistLimit`
- `_Set__VPhysXJoint_t_m_flAngularDampingRatio`
- `_Set__VPhysXJoint_t_m_flAngularFrequency`
- `_Set__VPhysXJoint_t_m_flAngularStrength`
- `_Set__VPhysXJoint_t_m_flLinearDampingRatio`
- `_Set__VPhysXJoint_t_m_flLinearFrequency`
- `_Set__VPhysXJoint_t_m_flLinearStrength`
- `_Set__VPhysXJoint_t_m_flMaxForce`
- `_Set__VPhysXJoint_t_m_flMaxTorque`
- `_Set__VPhysXJoint_t_m_nBody1`
- `_Set__VPhysXJoint_t_m_nBody2`
- `_Set__VPhysXJoint_t_m_nFlags`
- `_Set__VPhysXJoint_t_m_nType`
- `_Set__VPhysXJoint_t_m_vAngularTargetVelocity`
- `_Set__VPhysXJoint_t_m_vLinearTargetVelocity`
- `_Set__VfxCmpldShdrnf_t_compileFailed`
- `_Set__VfxCmpldShdrnf_t_compilerOutput`
- `fpxr_Compositor_BeginFrame`
- `fpxr_Compositor_EndFrame`
- `fpxr_Compositor_EventManager`
- `fpxr_Compositor_GetDisplayRefreshRate`
- `fpxr_Compositor_GetEyeHeight`
- `fpxr_Compositor_GetEyeWidth`
- `fpxr_Compositor_GetProjectionMatrix`
- `fpxr_Compositor_GetRenderTargetHeight`
- `fpxr_Compositor_GetRenderTargetWidth`
- `fpxr_Compositor_GetViewInfo`
- `fpxr_Compositor_Submit`
- `fpxr_EventManager_PumpEvent`
- `fpxr_Input_GetBooleanActionState`
- `fpxr_Input_GetFingerCurl`
- `fpxr_Input_GetFloatActionState`
- `fpxr_Input_GetHandPoseState`
- `fpxr_Input_GetPoseActionState`
- `fpxr_Input_GetVector2ActionState`
- `fpxr_Input_TriggerHapticVibration`
- `fpxr_Instance_Compositor`
- `fpxr_Instance_Create`
- `fpxr_Instance_GetProperties`
- `fpxr_Instance_GetRequiredDeviceExtensions`
- `fpxr_Instance_GetRequiredInstanceExtensions`
- `fpxr_Instance_HasHeadset`
- `fpxr_Instance_Input`
- `fpxr_pplctnCnfg_SetDebugCallback`
- `fpxr_pplctnCnfg_SetErrorCallback`
- `g_pMeshSystem_ChangeModel`
- `g_pMeshSystem_CreateSceneObject`
- `g_pPhysicsSystem_CastHeightField`
- `g_pPhysicsSystem_CreateWorld`
- `g_pPhysicsSystem_DestroyWorld`
- `g_pPhysicsSystem_GetAggregateData`
- `g_pPhysicsSystem_GetSurfacePropertyController`
- `g_pPhysicsSystem_NumWorlds`
- `g_pPhysicsSystem_UpdateSurfaceProperties`
- `g_pRenderDevice_AsyncSetTextureData2`
- `g_pRenderDevice_CanRenderToSwapChain`
- `g_pRenderDevice_ClearTexture`
- `g_pRenderDevice_CompileAndCreateShader`
- `g_pRenderDevice_CreateGPUBuffer`
- `g_pRenderDevice_CreateRenderContext`
- `g_pRenderDevice_DestroyGPUBuffer`
- `g_pRenderDevice_DestroySwapChain`
- `g_pRenderDevice_FindOrCreateFileTexture`
- `g_pRenderDevice_FindOrCreateSamplerState`
- `g_pRenderDevice_Flush`
- `g_pRenderDevice_GetBackbufferDimensions`
- `g_pRenderDevice_GetDeviceSpecificInfo`
- `g_pRenderDevice_GetDeviceSpecificTexture`
- `g_pRenderDevice_GetGPUFrameTimeMS`
- `g_pRenderDevice_GetGraphicsAPISpecificTextureHandle`
- `g_pRenderDevice_GetNumTextureLoadsInFlight`
- `g_pRenderDevice_GetOnDiskTextureDesc`
- `g_pRenderDevice_GetRenderDeviceAPI`
- `g_pRenderDevice_GetSamplerIndex`
- `g_pRenderDevice_GetSequence`
- `g_pRenderDevice_GetSequenceCount`
- `g_pRenderDevice_GetSheetInfo`
- `g_pRenderDevice_GetSwapChainInfo`
- `g_pRenderDevice_GetSwapChainTexture`
- `g_pRenderDevice_GetTextureDesc`
- `g_pRenderDevice_GetTextureLastUsed`
- `g_pRenderDevice_GetTextureMultisampleType`
- `g_pRenderDevice_GetTextureResidencyInfo`
- `g_pRenderDevice_GetTextureViewIndex`
- `g_pRenderDevice_IsRayTracingSupported`
- `g_pRenderDevice_IsTextureRenderTarget`
- `g_pRenderDevice_IsUsing32BitDepthBuffer`
- `g_pRenderDevice_MarkTextureUsed`
- `g_pRenderDevice_Present`
- `g_pRenderDevice_ReadBuffer`
- `g_pRenderDevice_ReadTexturePixels`
- `g_pRenderDevice_ReleaseRenderContext`
- `g_pRenderDevice_SetForcePreloadStreamingData`
- `g_pRenderDevice_UnThrottleTextureStreamingForNFrames`
- `g_pRenderService_GetMultisampleType`
- `g_pRsrcCmplrSyst_GenerateResourceBytes`
- `g_pRsrcCmplrSyst_GenerateResourceFile`
- `g_pRsrcCmplrSyst_GenerateResourceFile_1`
- `g_pRsrcSystm_DestroyResourceManifest`
- `g_pRsrcSystm_GetAllCodeManifests`
- `g_pRsrcSystm_HasPendingWork`
- `g_pRsrcSystm_IsManifestLoaded`
- `g_pRsrcSystm_LoadResourceInManifest`
- `g_pRsrcSystm_ReloadSymlinkedResidentResources`
- `g_pRsrcSystm_UpdateSimple`
- `g_pSceneSystem_AddCullingBox`
- `g_pSceneSystem_AddVolumetricFogVolume`
- `g_pSceneSystem_BeginRenderingDynamicView`
- `g_pSceneSystem_BindTransformSlot`
- `g_pSceneSystem_CreateDecal`
- `g_pSceneSystem_CreateDirectionalLight`
- `g_pSceneSystem_CreateEnvMap`
- `g_pSceneSystem_CreateLightProbeVolume`
- `g_pSceneSystem_CreateOrthoLight`
- `g_pSceneSystem_CreatePointLight`
- `g_pSceneSystem_CreateRayTraceWorld`
- `g_pSceneSystem_CreateSkyBox`
- `g_pSceneSystem_CreateSpotLight`
- `g_pSceneSystem_CreateWorld`
- `g_pSceneSystem_DeleteSceneObject`
- `g_pSceneSystem_DeleteSceneObjectAtFrameEnd`
- `g_pSceneSystem_DestroyRayTraceWorld`
- `g_pSceneSystem_DestroyWorld`
- `g_pSceneSystem_DownsampleTexture`
- `g_pSceneSystem_GetPerFrameStats`
- `g_pSceneSystem_GetWellKnownMaterialHandle`
- `g_pSceneSystem_GetWellKnownTexture`
- `g_pSceneSystem_MarkEnvironmentMapObjectUpdated`
- `g_pSceneSystem_MarkLightProbeVolumeObjectUpdated`
- `g_pSceneSystem_RemoveCullingBox`
- `g_pSceneSystem_RemoveVolumetricFogVolume`
- `g_pSceneSystem_RenderTiledLightCulling`
- `g_pSceneSystem_SetupPerObjectLighting`
- `g_pSceneUtils_CreateTonemapSystem`
- `g_pSceneUtils_CreateVolumetricFog`
- `g_pSceneUtils_DestroyTonemapSystem`
- `g_pSceneUtils_DestroyVolumetricFog`
- `g_pSndSystmntrnl_CreateSound`
- `g_pSndSystmntrnl_GetActiveAudioDevice`
- `g_pSndSystmntrnl_GetAudioDeviceDesc`
- `g_pSndSystmntrnl_GetAudioDeviceId`
- `g_pSndSystmntrnl_GetAudioDeviceName`
- `g_pSndSystmntrnl_GetNumAudioDevices`
- `g_pSndSystmntrnl_PlaySoundAtOSLevel`
- `g_pSndSystmntrnl_PrecacheSound`
- `g_pSndSystmntrnl_PreloadSound`
- `g_pSndSystmntrnl_SetActiveAudioDevice`
- `g_pWrldRndrrMgr_CreateWorld`
- `g_pWrldRndrrMgr_MountWorldVPK`
- `g_pWrldRndrrMgr_ServiceWorldRequests`
- `g_pWrldRndrrMgr_UnmountWorldVPK`
- `g_pWrldRndrrMgr_UpdateObjectsForRendering`
- `g_pngnPVSMngr_BuildPvs`
- `g_pngnPVSMngr_DestroyPvs`
- `g_pngnSrvcMgr_ExitMainLoop`
- `g_pngnSrvcMgr_SetEngineState`
- `globalOVRLipSync_ovrLipSync_CreateContext`
- `globalOVRLipSync_ovrLipSync_CreateContextEx`
- `globalOVRLipSync_ovrLipSync_DestroyContext`
- `globalOVRLipSync_ovrLipSync_Initialize`
- `globalOVRLipSync_ovrLipSync_ProcessFrameEx`
- `globalOVRLipSync_ovrLipSync_ResetContext`
- `globalOVRLipSync_ovrLipSync_SendSignal`
- `globalOVRLipSync_ovrLipSync_Shutdown`
- `globalSteam_SteamAPI_RunCallbacks`
- `globalSteam_SteamApps`
- `globalSteam_SteamFriends`
- `globalSteam_SteamGameServer`
- `globalSteam_SteamGameServer_BSecure`
- `globalSteam_SteamGameServer_GetSteamID`
- `globalSteam_SteamGameServer_Init`
- `globalSteam_SteamGameServer_ReleaseCurrentThreadMemory`
- `globalSteam_SteamGameServer_RunCallbacks`
- `globalSteam_SteamGameServer_Shutdown`
- `globalSteam_SteamHTMLSurface`
- `globalSteam_SteamMatchmaking`
- `globalSteam_SteamNetworkingMessages`
- `globalSteam_SteamNetworkingSockets`
- `globalSteam_SteamNetworkingUtils`
- `globalSteam_SteamUser`
- `globalSteam_SteamUtils`
- `global_GetGameSearchPath`
- `global_HasLaunchParameter`
- `global_IsRetail`
- `global_IsWindowFocused`
- `nmPrmtrLst_Count`
- `nmPrmtrLst_GetParameter`
- `nmPrmtrLst_GetParameter_1`
- `nmPrmtrnstnc_GetName`
- `nmPrmtrnstnc_GetParameterType`
- `nmPrmtrnstnc_IsAutoReset`
- `nmPrmtrnstnc_SetEnumValue`
- `nmPrmtrnstnc_SetValue`
- `nmPrmtrnstnc_SetValue_1`
- `nmPrmtrnstnc_SetValue_2`
- `nmPrmtrnstnc_SetValue_3`
- `nmPrmtrnstnc_SetValue_4`
- `syncRsrcDtRqst_GetFileName`
- `syncRsrcDtRqst_GetResultBuffer`
- `syncRsrcDtRqst_GetResultBufferSize`

### Physics (29 fonctions)

- `CPhysBdyDscrry_Create`
- `CPhysBdyDscrry_DeleteThis`
- `CPhysBdyDscrry_Get`
- `CPhysBdyDscrry_GetJoint`
- `CPhysBodyDesc_AddCapsule`
- `CPhysBodyDesc_AddHull`
- `CPhysBodyDesc_AddMesh`
- `CPhysBodyDesc_AddSphere`
- `CPhysBodyDesc_SetBindPose`
- `CPhysBodyDesc_SetBoneName`
- `CPhysBodyDesc_SetSurface`
- `CPhysSrfcPrprts_UpdatePhysics`
- `CPhysggrgtDt_AddRef`
- `CPhysggrgtDt_GetBindPose`
- `CPhysggrgtDt_GetBoneCount`
- `CPhysggrgtDt_GetBoneHash`
- `CPhysggrgtDt_GetBoneName`
- `CPhysggrgtDt_GetChecksum`
- `CPhysggrgtDt_GetCollisionAttributeCount`
- `CPhysggrgtDt_GetIndexHash`
- `CPhysggrgtDt_GetJoint`
- `CPhysggrgtDt_GetJointCount`
- `CPhysggrgtDt_GetPart`
- `CPhysggrgtDt_GetPartCount`
- `CPhysggrgtDt_GetSurfaceProperties`
- `CPhysggrgtDt_GetSurfacePropertiesCount`
- `CPhysggrgtDt_GetTag`
- `CPhysggrgtDt_GetTagCount`
- `CPhysggrgtDt_Release`

### Platform (27 fonctions)

- `global_AppIsDedicatedServer`
- `global_GetDiagonalDpi`
- `global_GetGameRootFolder`
- `global_Plat_ChangeCurrentFrame`
- `global_Plat_ClearClipboardText`
- `global_Plat_GetClipboardText`
- `global_Plat_GetCurrentFrame`
- `global_Plat_GetDefaultMonitorIndex`
- `global_Plat_GetDesktopResolution`
- `global_Plat_HasClipboardText`
- `global_Plat_IsRunningOnCustomerMachine`
- `global_Plat_MessageBox`
- `global_Plat_SafeRemoveFile`
- `global_Plat_ScreenToWindowCoords`
- `global_Plat_SetClipboardText`
- `global_Plat_SetCurrentDirectory`
- `global_Plat_SetCurrentFrame`
- `global_Plat_SetModuleFilename`
- `global_Plat_SetNoAssert`
- `global_Plat_WindowToScreenCoords`
- `global_SourceEngineFrame`
- `global_SourceEngineInit`
- `global_SourceEnginePreInit`
- `global_SourceEngineShutdown`
- `global_SourceEngineUnitTestInit`
- `global_ToolsStallMonitor_IndicateActivity`
- `global_UpdateWindowSize`

### QueryResult (4 fonctions)

- `CQueryResult_Count`
- `CQueryResult_Create`
- `CQueryResult_DeleteThis`
- `CQueryResult_Element`

### ReadBuffer (8 fonctions)

- `CRdBffrMngdCllbc_Create`
- `CRdBffrMngdCllbc_Done`
- `CRdBffrMngdCllbc_GetManagedId`
- `CRdBffrMngdCllbc_SetManagedId`
- `CRdTxtrPxlsMngdC_Create`
- `CRdTxtrPxlsMngdC_Done`
- `CRdTxtrPxlsMngdC_GetManagedId`
- `CRdTxtrPxlsMngdC_SetManagedId`

### RenderAttributes (39 fonctions)

- `CRndrttrbts_Clear`
- `CRndrttrbts_Create`
- `CRndrttrbts_DeleteBoolValue`
- `CRndrttrbts_DeleteComboValue`
- `CRndrttrbts_DeleteFloatValue`
- `CRndrttrbts_DeleteIntValue`
- `CRndrttrbts_DeletePtrValue`
- `CRndrttrbts_DeleteStringValue`
- `CRndrttrbts_DeleteTextureValue`
- `CRndrttrbts_DeleteThis`
- `CRndrttrbts_DeleteVMatrixValue`
- `CRndrttrbts_DeleteVector2DValue`
- `CRndrttrbts_DeleteVector4DValue`
- `CRndrttrbts_DeleteVectorValue`
- `CRndrttrbts_GetBoolValue`
- `CRndrttrbts_GetComboValue`
- `CRndrttrbts_GetFloatValue`
- `CRndrttrbts_GetIntValue`
- `CRndrttrbts_GetTextureValue`
- `CRndrttrbts_GetVMatrixValue`
- `CRndrttrbts_GetVector2DValue`
- `CRndrttrbts_GetVector4DValue`
- `CRndrttrbts_GetVectorValue`
- `CRndrttrbts_IsEmpty`
- `CRndrttrbts_MergeToPtr`
- `CRndrttrbts_SetBoolValue`
- `CRndrttrbts_SetBufferValue`
- `CRndrttrbts_SetComboValue`
- `CRndrttrbts_SetFloatValue`
- `CRndrttrbts_SetIntValue`
- `CRndrttrbts_SetIntVector4DValue`
- `CRndrttrbts_SetPtrValue`
- `CRndrttrbts_SetSamplerValue`
- `CRndrttrbts_SetStringValue`
- `CRndrttrbts_SetTextureValue`
- `CRndrttrbts_SetVMatrixValue`
- `CRndrttrbts_SetVector2DValue`
- `CRndrttrbts_SetVector4DValue`
- `CRndrttrbts_SetVectorValue`

### RenderMesh (6 fonctions)

- `CRenderMesh_CopyStrongHandle`
- `CRenderMesh_DestroyStrongHandle`
- `CRenderMesh_GetBindingPtr`
- `CRenderMesh_IsError`
- `CRenderMesh_IsStrongHandleLoaded`
- `CRenderMesh_IsStrongHandleValid`

### RenderTools (16 fonctions)

- `RenderTools_Compute`
- `RenderTools_ComputeIndirect`
- `RenderTools_CopyGPUBufferHiddenStructureCount`
- `RenderTools_CopyTexture`
- `RenderTools_Draw`
- `RenderTools_DrawModel`
- `RenderTools_DrawModel_1`
- `RenderTools_DrawSceneObject`
- `RenderTools_ResolveDepthBuffer`
- `RenderTools_ResolveFrameBuffer`
- `RenderTools_SetDynamicConstantBufferData`
- `RenderTools_SetGPUBufferData`
- `RenderTools_SetGPUBufferHiddenStructureCount`
- `RenderTools_SetRenderState`
- `RenderTools_TraceRays`
- `RenderTools_TraceRaysIndirect`

### SceneLightObject (112 fonctions)

- `CScnLghtbjct_AddChildObject`
- `CScnLghtbjct_AddTag`
- `CScnLghtbjct_ChangeFlags`
- `CScnLghtbjct_ClearFlags`
- `CScnLghtbjct_ClearLoaded`
- `CScnLghtbjct_ClearMaterialOverrideList`
- `CScnLghtbjct_DisableLOD`
- `CScnLghtbjct_DisableMeshGroups`
- `CScnLghtbjct_DisableRendering`
- `CScnLghtbjct_EnableLightingCache`
- `CScnLghtbjct_EnableMeshGroups`
- `CScnLghtbjct_EnableRendering`
- `CScnLghtbjct_GetAlphaFade`
- `CScnLghtbjct_GetAttributesPtrForModify`
- `CScnLghtbjct_GetBoundingSphereRadius`
- `CScnLghtbjct_GetBounds`
- `CScnLghtbjct_GetCTransform`
- `CScnLghtbjct_GetCascadeDistanceScale`
- `CScnLghtbjct_GetColor`
- `CScnLghtbjct_GetConstantAttn`
- `CScnLghtbjct_GetCurrentLODGroupMask`
- `CScnLghtbjct_GetCurrentLODLevel`
- `CScnLghtbjct_GetCurrentMeshGroupMask`
- `CScnLghtbjct_GetFallOff`
- `CScnLghtbjct_GetFlags`
- `CScnLghtbjct_GetFogContributionStength`
- `CScnLghtbjct_GetFogLightingMode`
- `CScnLghtbjct_GetLightCookie`
- `CScnLghtbjct_GetLightFlags`
- `CScnLghtbjct_GetLightShape`
- `CScnLghtbjct_GetLightingOrigin`
- `CScnLghtbjct_GetLinearAttn`
- `CScnLghtbjct_GetModelHandle`
- `CScnLghtbjct_GetOriginalFlags`
- `CScnLghtbjct_GetParent`
- `CScnLghtbjct_GetPhi`
- `CScnLghtbjct_GetQuadraticAttn`
- `CScnLghtbjct_GetRadius`
- `CScnLghtbjct_GetShadowCascades`
- `CScnLghtbjct_GetShadowTextureHeight`
- `CScnLghtbjct_GetShadowTextureResolution`
- `CScnLghtbjct_GetShadowTextureWidth`
- `CScnLghtbjct_GetShadows`
- `CScnLghtbjct_GetTagAt`
- `CScnLghtbjct_GetTagCount`
- `CScnLghtbjct_GetTheta`
- `CScnLghtbjct_GetTintRGBA`
- `CScnLghtbjct_GetWorld`
- `CScnLghtbjct_GetWorldDirection`
- `CScnLghtbjct_GetWorldPosition`
- `CScnLghtbjct_HasFlags`
- `CScnLghtbjct_HasLightingOrigin`
- `CScnLghtbjct_HasTag`
- `CScnLghtbjct_IsLoaded`
- `CScnLghtbjct_IsNotBatchable`
- `CScnLghtbjct_IsRenderingEnabled`
- `CScnLghtbjct_RemoveAllTags`
- `CScnLghtbjct_RemoveChild`
- `CScnLghtbjct_RemoveTag`
- `CScnLghtbjct_ResetMeshGroups`
- `CScnLghtbjct_SetAlphaFade`
- `CScnLghtbjct_SetBakeLightIndex`
- `CScnLghtbjct_SetBakeLightIndexScale`
- `CScnLghtbjct_SetBatchable`
- `CScnLghtbjct_SetBodyGroup`
- `CScnLghtbjct_SetBounceColor`
- `CScnLghtbjct_SetBounds`
- `CScnLghtbjct_SetBoundsInfinite`
- `CScnLghtbjct_SetCascadeDistanceScale`
- `CScnLghtbjct_SetColor`
- `CScnLghtbjct_SetConstantAttn`
- `CScnLghtbjct_SetCullDistance`
- `CScnLghtbjct_SetFallOff`
- `CScnLghtbjct_SetFlags`
- `CScnLghtbjct_SetFogContributionStength`
- `CScnLghtbjct_SetFogLightingMode`
- `CScnLghtbjct_SetForceLayerID`
- `CScnLghtbjct_SetLOD`
- `CScnLghtbjct_SetLayerMatchID`
- `CScnLghtbjct_SetLightCookie`
- `CScnLghtbjct_SetLightFlags`
- `CScnLghtbjct_SetLightShape`
- `CScnLghtbjct_SetLightSourceDim0`
- `CScnLghtbjct_SetLightSourceDim1`
- `CScnLghtbjct_SetLightSourceSize0`
- `CScnLghtbjct_SetLightSourceSize1`
- `CScnLghtbjct_SetLightingOrigin`
- `CScnLghtbjct_SetLinearAttn`
- `CScnLghtbjct_SetLoaded`
- `CScnLghtbjct_SetMaterialGroup`
- `CScnLghtbjct_SetMaterialOverride`
- `CScnLghtbjct_SetMaterialOverrideByIndex`
- `CScnLghtbjct_SetMaterialOverrideForMeshInstances`
- `CScnLghtbjct_SetPhi`
- `CScnLghtbjct_SetQuadraticAttn`
- `CScnLghtbjct_SetRadius`
- `CScnLghtbjct_SetRenderDiffuse`
- `CScnLghtbjct_SetRenderSpecular`
- `CScnLghtbjct_SetRenderTransmissive`
- `CScnLghtbjct_SetRenderingEnabled`
- `CScnLghtbjct_SetShadowCascades`
- `CScnLghtbjct_SetShadowTextureHeight`
- `CScnLghtbjct_SetShadowTextureResolution`
- `CScnLghtbjct_SetShadowTextureWidth`
- `CScnLghtbjct_SetShadows`
- `CScnLghtbjct_SetTheta`
- `CScnLghtbjct_SetTintRGBA`
- `CScnLghtbjct_SetTransform`
- `CScnLghtbjct_SetUniqueBatchGroup`
- `CScnLghtbjct_SetUsesIndexedBakedLighting`
- `CScnLghtbjct_SetWorldDirection`
- `CScnLghtbjct_UpdateFlagsBasedOnMaterial`

### SceneLightProbeObject (60 fonctions)

- `CScnLghtPrbVlmbj_AddChildObject`
- `CScnLghtPrbVlmbj_AddTag`
- `CScnLghtPrbVlmbj_ChangeFlags`
- `CScnLghtPrbVlmbj_ClearFlags`
- `CScnLghtPrbVlmbj_ClearLoaded`
- `CScnLghtPrbVlmbj_ClearMaterialOverrideList`
- `CScnLghtPrbVlmbj_DisableLOD`
- `CScnLghtPrbVlmbj_DisableMeshGroups`
- `CScnLghtPrbVlmbj_DisableRendering`
- `CScnLghtPrbVlmbj_EnableLightingCache`
- `CScnLghtPrbVlmbj_EnableMeshGroups`
- `CScnLghtPrbVlmbj_EnableRendering`
- `CScnLghtPrbVlmbj_GetAlphaFade`
- `CScnLghtPrbVlmbj_GetAttributesPtrForModify`
- `CScnLghtPrbVlmbj_GetBoundingSphereRadius`
- `CScnLghtPrbVlmbj_GetBounds`
- `CScnLghtPrbVlmbj_GetCTransform`
- `CScnLghtPrbVlmbj_GetCurrentLODGroupMask`
- `CScnLghtPrbVlmbj_GetCurrentLODLevel`
- `CScnLghtPrbVlmbj_GetCurrentMeshGroupMask`
- `CScnLghtPrbVlmbj_GetFlags`
- `CScnLghtPrbVlmbj_GetLightingOrigin`
- `CScnLghtPrbVlmbj_GetModelHandle`
- `CScnLghtPrbVlmbj_GetOriginalFlags`
- `CScnLghtPrbVlmbj_GetParent`
- `CScnLghtPrbVlmbj_GetTagAt`
- `CScnLghtPrbVlmbj_GetTagCount`
- `CScnLghtPrbVlmbj_GetTintRGBA`
- `CScnLghtPrbVlmbj_GetWorld`
- `CScnLghtPrbVlmbj_HasFlags`
- `CScnLghtPrbVlmbj_HasLightingOrigin`
- `CScnLghtPrbVlmbj_HasTag`
- `CScnLghtPrbVlmbj_IsLoaded`
- `CScnLghtPrbVlmbj_IsNotBatchable`
- `CScnLghtPrbVlmbj_IsRenderingEnabled`
- `CScnLghtPrbVlmbj_RemoveAllTags`
- `CScnLghtPrbVlmbj_RemoveChild`
- `CScnLghtPrbVlmbj_RemoveTag`
- `CScnLghtPrbVlmbj_ResetMeshGroups`
- `CScnLghtPrbVlmbj_SetAlphaFade`
- `CScnLghtPrbVlmbj_SetBatchable`
- `CScnLghtPrbVlmbj_SetBodyGroup`
- `CScnLghtPrbVlmbj_SetBounds`
- `CScnLghtPrbVlmbj_SetBoundsInfinite`
- `CScnLghtPrbVlmbj_SetCullDistance`
- `CScnLghtPrbVlmbj_SetFlags`
- `CScnLghtPrbVlmbj_SetForceLayerID`
- `CScnLghtPrbVlmbj_SetLOD`
- `CScnLghtPrbVlmbj_SetLayerMatchID`
- `CScnLghtPrbVlmbj_SetLightingOrigin`
- `CScnLghtPrbVlmbj_SetLoaded`
- `CScnLghtPrbVlmbj_SetMaterialGroup`
- `CScnLghtPrbVlmbj_SetMaterialOverride`
- `CScnLghtPrbVlmbj_SetMaterialOverrideByIndex`
- `CScnLghtPrbVlmbj_SetMaterialOverrideForMeshInstances`
- `CScnLghtPrbVlmbj_SetRenderingEnabled`
- `CScnLghtPrbVlmbj_SetTintRGBA`
- `CScnLghtPrbVlmbj_SetTransform`
- `CScnLghtPrbVlmbj_SetUniqueBatchGroup`
- `CScnLghtPrbVlmbj_UpdateFlagsBasedOnMaterial`

### SceneNametableObject (117 fonctions)

- `CScnnmtblbjct_AddChildObject`
- `CScnnmtblbjct_AddTag`
- `CScnnmtblbjct_CalculateWorldSpaceBones`
- `CScnnmtblbjct_ChangeFlags`
- `CScnnmtblbjct_ClearFlags`
- `CScnnmtblbjct_ClearLoaded`
- `CScnnmtblbjct_ClearMaterialOverrideList`
- `CScnnmtblbjct_ClearPhysicsBones`
- `CScnnmtblbjct_DirectPlayback_CancelSequence`
- `CScnnmtblbjct_DirectPlayback_GetSequence`
- `CScnnmtblbjct_DirectPlayback_GetSequenceCycle`
- `CScnnmtblbjct_DirectPlayback_GetSequenceDuration`
- `CScnnmtblbjct_DirectPlayback_PlaySequence`
- `CScnnmtblbjct_DirectPlayback_PlaySequence_1`
- `CScnnmtblbjct_DirectPlayback_SetSequenceStartTime`
- `CScnnmtblbjct_DisableLOD`
- `CScnnmtblbjct_DisableMeshGroups`
- `CScnnmtblbjct_DisableRendering`
- `CScnnmtblbjct_DispatchTagEvents`
- `CScnnmtblbjct_EnableLightingCache`
- `CScnnmtblbjct_EnableMeshGroups`
- `CScnnmtblbjct_EnableRendering`
- `CScnnmtblbjct_FinishUpdate`
- `CScnnmtblbjct_GetAlphaFade`
- `CScnnmtblbjct_GetAnimGraph`
- `CScnnmtblbjct_GetAnimParameter`
- `CScnnmtblbjct_GetAnimParameter_1`
- `CScnnmtblbjct_GetAttributesPtrForModify`
- `CScnnmtblbjct_GetBoundingSphereRadius`
- `CScnnmtblbjct_GetBounds`
- `CScnnmtblbjct_GetCTransform`
- `CScnnmtblbjct_GetCurrentLODGroupMask`
- `CScnnmtblbjct_GetCurrentLODLevel`
- `CScnnmtblbjct_GetCurrentMeshGroupMask`
- `CScnnmtblbjct_GetFlags`
- `CScnnmtblbjct_GetLightingOrigin`
- `CScnnmtblbjct_GetLocalSpaceRenderBoneTransform`
- `CScnnmtblbjct_GetLocalSpaceRenderBoneTransform_1`
- `CScnnmtblbjct_GetModelHandle`
- `CScnnmtblbjct_GetOriginalFlags`
- `CScnnmtblbjct_GetParameterFloat`
- `CScnnmtblbjct_GetParameterInt`
- `CScnnmtblbjct_GetParameterRotation`
- `CScnnmtblbjct_GetParameterVector3`
- `CScnnmtblbjct_GetParent`
- `CScnnmtblbjct_GetParentSpaceBone`
- `CScnnmtblbjct_GetPlaybackRate`
- `CScnnmtblbjct_GetRootMotion`
- `CScnnmtblbjct_GetSequence`
- `CScnnmtblbjct_GetSequenceCycle`
- `CScnnmtblbjct_GetSequenceDuration`
- `CScnnmtblbjct_GetShouldUseAnimGraph`
- `CScnnmtblbjct_GetTagAt`
- `CScnnmtblbjct_GetTagCount`
- `CScnnmtblbjct_GetTintRGBA`
- `CScnnmtblbjct_GetWorld`
- `CScnnmtblbjct_GetWorldSpaceAnimationTransform`
- `CScnnmtblbjct_GetWorldSpaceRenderBonePreviousTransform`
- `CScnnmtblbjct_GetWorldSpaceRenderBonePreviousTransform_1`
- `CScnnmtblbjct_GetWorldSpaceRenderBoneTransform`
- `CScnnmtblbjct_GetWorldSpaceRenderBoneTransform_1`
- `CScnnmtblbjct_HasFlags`
- `CScnnmtblbjct_HasLightingOrigin`
- `CScnnmtblbjct_HasPhysicsBones`
- `CScnnmtblbjct_HasTag`
- `CScnnmtblbjct_InitAnimGraph`
- `CScnnmtblbjct_IsLoaded`
- `CScnnmtblbjct_IsNotBatchable`
- `CScnnmtblbjct_IsRenderingEnabled`
- `CScnnmtblbjct_IsSequenceFinished`
- `CScnnmtblbjct_MergeFrom`
- `CScnnmtblbjct_PendingAnimationEvents`
- `CScnnmtblbjct_RemoveAllTags`
- `CScnnmtblbjct_RemoveChild`
- `CScnnmtblbjct_RemoveTag`
- `CScnnmtblbjct_ResetGraphParameters`
- `CScnnmtblbjct_ResetMeshGroups`
- `CScnnmtblbjct_RunAnimationEvents`
- `CScnnmtblbjct_SBox_ClearFlexOverride`
- `CScnnmtblbjct_SBox_GetAttachment`
- `CScnnmtblbjct_SBox_GetFlexOverride`
- `CScnnmtblbjct_SBox_GetFlexOverride_1`
- `CScnnmtblbjct_SBox_SetFlexOverride`
- `CScnnmtblbjct_SBox_SetFlexOverride_1`
- `CScnnmtblbjct_SetAlphaFade`
- `CScnnmtblbjct_SetAnimGraph`
- `CScnnmtblbjct_SetAnimGraph_1`
- `CScnnmtblbjct_SetBatchable`
- `CScnnmtblbjct_SetBindPose`
- `CScnnmtblbjct_SetBodyGroup`
- `CScnnmtblbjct_SetBounds`
- `CScnnmtblbjct_SetBoundsInfinite`
- `CScnnmtblbjct_SetCullDistance`
- `CScnnmtblbjct_SetFlags`
- `CScnnmtblbjct_SetForceLayerID`
- `CScnnmtblbjct_SetLOD`
- `CScnnmtblbjct_SetLayerMatchID`
- `CScnnmtblbjct_SetLightingOrigin`
- `CScnnmtblbjct_SetLoaded`
- `CScnnmtblbjct_SetMaterialGroup`
- `CScnnmtblbjct_SetMaterialOverride`
- `CScnnmtblbjct_SetMaterialOverrideByIndex`
- `CScnnmtblbjct_SetMaterialOverrideForMeshInstances`
- `CScnnmtblbjct_SetParentSpaceBone`
- `CScnnmtblbjct_SetPhysicsBone`
- `CScnnmtblbjct_SetPlaybackRate`
- `CScnnmtblbjct_SetRenderingEnabled`
- `CScnnmtblbjct_SetSequence`
- `CScnnmtblbjct_SetSequenceBlending`
- `CScnnmtblbjct_SetSequenceCycle`
- `CScnnmtblbjct_SetSequenceLooping`
- `CScnnmtblbjct_SetShouldUseAnimGraph`
- `CScnnmtblbjct_SetTintRGBA`
- `CScnnmtblbjct_SetTransform`
- `CScnnmtblbjct_SetUniqueBatchGroup`
- `CScnnmtblbjct_Update`
- `CScnnmtblbjct_UpdateFlagsBasedOnMaterial`

### SceneObject (68 fonctions)

- `CSceneObject_AddChildObject`
- `CSceneObject_AddTag`
- `CSceneObject_ChangeFlags`
- `CSceneObject_ClearFlags`
- `CSceneObject_ClearLoaded`
- `CSceneObject_ClearMaterialOverrideList`
- `CSceneObject_DisableLOD`
- `CSceneObject_DisableMeshGroups`
- `CSceneObject_DisableRendering`
- `CSceneObject_EnableLightingCache`
- `CSceneObject_EnableMeshGroups`
- `CSceneObject_EnableRendering`
- `CSceneObject_GetAlphaFade`
- `CSceneObject_GetAttributesPtrForModify`
- `CSceneObject_GetBoundingSphereRadius`
- `CSceneObject_GetBounds`
- `CSceneObject_GetCTransform`
- `CSceneObject_GetCurrentLODGroupMask`
- `CSceneObject_GetCurrentLODLevel`
- `CSceneObject_GetCurrentMeshGroupMask`
- `CSceneObject_GetFlags`
- `CSceneObject_GetLightingOrigin`
- `CSceneObject_GetModelHandle`
- `CSceneObject_GetOriginalFlags`
- `CSceneObject_GetParent`
- `CSceneObject_GetTagAt`
- `CSceneObject_GetTagCount`
- `CSceneObject_GetTintRGBA`
- `CSceneObject_GetWorld`
- `CSceneObject_HasFlags`
- `CSceneObject_HasLightingOrigin`
- `CSceneObject_HasTag`
- `CSceneObject_IsLoaded`
- `CSceneObject_IsNotBatchable`
- `CSceneObject_IsRenderingEnabled`
- `CSceneObject_RemoveAllTags`
- `CSceneObject_RemoveChild`
- `CSceneObject_RemoveTag`
- `CSceneObject_ResetMeshGroups`
- `CSceneObject_SetAlphaFade`
- `CSceneObject_SetBatchable`
- `CSceneObject_SetBodyGroup`
- `CSceneObject_SetBounds`
- `CSceneObject_SetBoundsInfinite`
- `CSceneObject_SetCullDistance`
- `CSceneObject_SetFlags`
- `CSceneObject_SetForceLayerID`
- `CSceneObject_SetLOD`
- `CSceneObject_SetLayerMatchID`
- `CSceneObject_SetLightingOrigin`
- `CSceneObject_SetLoaded`
- `CSceneObject_SetMaterialGroup`
- `CSceneObject_SetMaterialOverride`
- `CSceneObject_SetMaterialOverrideByIndex`
- `CSceneObject_SetMaterialOverrideForMeshInstances`
- `CSceneObject_SetRenderingEnabled`
- `CSceneObject_SetTintRGBA`
- `CSceneObject_SetTransform`
- `CSceneObject_SetUniqueBatchGroup`
- `CSceneObject_UpdateFlagsBasedOnMaterial`
- `To_CSceneObject_From_CDecalSceneObject`
- `To_CSceneObject_From_CDynamicSceneObject`
- `To_CSceneObject_From_CEnvMapSceneObject`
- `To_CSceneObject_From_CManagedSceneObject`
- `To_CSceneObject_From_CSceneAnimatableObject`
- `To_CSceneObject_From_CSceneLightObject`
- `To_CSceneObject_From_CSceneLightProbeVolumeObject`
- `To_CSceneObject_From_CSceneSkyBoxObject`

### SceneSkyBoxObject (72 fonctions)

- `CScnSkyBxbjct_AddChildObject`
- `CScnSkyBxbjct_AddTag`
- `CScnSkyBxbjct_ChangeFlags`
- `CScnSkyBxbjct_ClearFlags`
- `CScnSkyBxbjct_ClearLoaded`
- `CScnSkyBxbjct_ClearMaterialOverrideList`
- `CScnSkyBxbjct_DisableLOD`
- `CScnSkyBxbjct_DisableMeshGroups`
- `CScnSkyBxbjct_DisableRendering`
- `CScnSkyBxbjct_EnableLightingCache`
- `CScnSkyBxbjct_EnableMeshGroups`
- `CScnSkyBxbjct_EnableRendering`
- `CScnSkyBxbjct_GetAlphaFade`
- `CScnSkyBxbjct_GetAttributesPtrForModify`
- `CScnSkyBxbjct_GetBoundingSphereRadius`
- `CScnSkyBxbjct_GetBounds`
- `CScnSkyBxbjct_GetCTransform`
- `CScnSkyBxbjct_GetCurrentLODGroupMask`
- `CScnSkyBxbjct_GetCurrentLODLevel`
- `CScnSkyBxbjct_GetCurrentMeshGroupMask`
- `CScnSkyBxbjct_GetFlags`
- `CScnSkyBxbjct_GetFogMaxEnd`
- `CScnSkyBxbjct_GetFogMaxStart`
- `CScnSkyBxbjct_GetFogMinEnd`
- `CScnSkyBxbjct_GetFogMinStart`
- `CScnSkyBxbjct_GetFogType`
- `CScnSkyBxbjct_GetLightingOrigin`
- `CScnSkyBxbjct_GetMaterial`
- `CScnSkyBxbjct_GetModelHandle`
- `CScnSkyBxbjct_GetOriginalFlags`
- `CScnSkyBxbjct_GetParent`
- `CScnSkyBxbjct_GetSkyTint`
- `CScnSkyBxbjct_GetTagAt`
- `CScnSkyBxbjct_GetTagCount`
- `CScnSkyBxbjct_GetTintRGBA`
- `CScnSkyBxbjct_GetWorld`
- `CScnSkyBxbjct_HasFlags`
- `CScnSkyBxbjct_HasLightingOrigin`
- `CScnSkyBxbjct_HasTag`
- `CScnSkyBxbjct_IsLoaded`
- `CScnSkyBxbjct_IsNotBatchable`
- `CScnSkyBxbjct_IsRenderingEnabled`
- `CScnSkyBxbjct_RemoveAllTags`
- `CScnSkyBxbjct_RemoveChild`
- `CScnSkyBxbjct_RemoveTag`
- `CScnSkyBxbjct_ResetMeshGroups`
- `CScnSkyBxbjct_SetAlphaFade`
- `CScnSkyBxbjct_SetAngularFogParams`
- `CScnSkyBxbjct_SetBatchable`
- `CScnSkyBxbjct_SetBodyGroup`
- `CScnSkyBxbjct_SetBounds`
- `CScnSkyBxbjct_SetBoundsInfinite`
- `CScnSkyBxbjct_SetCullDistance`
- `CScnSkyBxbjct_SetFlags`
- `CScnSkyBxbjct_SetFogType`
- `CScnSkyBxbjct_SetForceLayerID`
- `CScnSkyBxbjct_SetLOD`
- `CScnSkyBxbjct_SetLayerMatchID`
- `CScnSkyBxbjct_SetLightingOrigin`
- `CScnSkyBxbjct_SetLighting_Samples`
- `CScnSkyBxbjct_SetLoaded`
- `CScnSkyBxbjct_SetMaterial`
- `CScnSkyBxbjct_SetMaterialGroup`
- `CScnSkyBxbjct_SetMaterialOverride`
- `CScnSkyBxbjct_SetMaterialOverrideByIndex`
- `CScnSkyBxbjct_SetMaterialOverrideForMeshInstances`
- `CScnSkyBxbjct_SetRenderingEnabled`
- `CScnSkyBxbjct_SetSkyTint`
- `CScnSkyBxbjct_SetTintRGBA`
- `CScnSkyBxbjct_SetTransform`
- `CScnSkyBxbjct_SetUniqueBatchGroup`
- `CScnSkyBxbjct_UpdateFlagsBasedOnMaterial`

### ServerList (4 fonctions)

- `CServerList_AddFilter`
- `CServerList_Create`
- `CServerList_Destroy`
- `CServerList_StartQuery`

### SfxTable (7 fonctions)

- `CSfxTable_CreateMixer`
- `CSfxTable_FailedResourceLoad`
- `CSfxTable_GetCacheStatus`
- `CSfxTable_GetSampleCount`
- `CSfxTable_GetSamples`
- `CSfxTable_GetSound`
- `CSfxTable_IsValidForPlayback`

### StreamManager (9 fonctions)

- `CStmnvntryRslt_CheckSteamId`
- `CStmnvntryRslt_Count`
- `CStmnvntryRslt_Destroy`
- `CStmnvntryRslt_Get`
- `CStmnvntryRslt_GetTimestamp`
- `CStmnvntryRslt_IsOk`
- `CStmnvntryRslt_IsPending`
- `CStmtmnstnc_DefinitionId`
- `CStmtmnstnc_ItemId`

### Texture (3 fonctions)

- `g_pRenderDevice_FindOrCreateTexture2`
- `g_pngnSrvcMgr_GetEngineSwapChain`
- `g_pngnSrvcMgr_GetEngineSwapChainSize`

### TextureBase (6 fonctions)

- `CTextureBase_CopyStrongHandle`
- `CTextureBase_DestroyStrongHandle`
- `CTextureBase_GetBindingPtr`
- `CTextureBase_IsError`
- `CTextureBase_IsStrongHandleLoaded`
- `CTextureBase_IsStrongHandleValid`

### Utility (5 fonctions)

- `CUtlBuffer_Base`
- `CUtlBuffer_Create`
- `CUtlBuffer_Dispose`
- `CUtlBuffer_TellMaxPut`
- `CUtlSymbolTable_AddString`

### VFX (34 fonctions)

- `CVfxBytCdMngr_Create`
- `CVfxBytCdMngr_Delete`
- `CVfxBytCdMngr_OnDynamicCombo`
- `CVfxBytCdMngr_OnStaticCombo`
- `CVfxBytCdMngr_Reset`
- `CVfxCmbtrtr_Delete`
- `CVfxCmbtrtr_FirstDynamicCombo`
- `CVfxCmbtrtr_FirstStaticCombo`
- `CVfxCmbtrtr_InvalidIndex`
- `CVfxCmbtrtr_NextDynamicCombo`
- `CVfxCmbtrtr_NextStaticCombo`
- `CVfxCmbtrtr_SetDynamicCombo`
- `CVfxCmbtrtr_SetStaticCombo`
- `CVfxCombo_GetGroup`
- `CVfxCombo_GetName`
- `CVfx_CopyStrongHandle`
- `CVfx_Create`
- `CVfx_CreateFromResourceFile`
- `CVfx_CreateFromShaderFile`
- `CVfx_DestroyStrongHandle`
- `CVfx_FinalizeCompile`
- `CVfx_GetBindingPtr`
- `CVfx_GetFilename`
- `CVfx_GetIterator`
- `CVfx_GetProgramData`
- `CVfx_GetPropertiesJson`
- `CVfx_HasShaderProgram`
- `CVfx_InitializeWrite`
- `CVfx_IsError`
- `CVfx_IsStrongHandleLoaded`
- `CVfx_IsStrongHandleValid`
- `CVfx_Serialize`
- `CVfx_WriteCombo`
- `CVfx_WriteProgramToBuffer`

### Video (30 fonctions)

- `CVideoPlayer_Create`
- `CVideoPlayer_Destroy`
- `CVideoPlayer_GetAmplitude`
- `CVideoPlayer_GetAudioStream`
- `CVideoPlayer_GetDuration`
- `CVideoPlayer_GetHeight`
- `CVideoPlayer_GetMetadata`
- `CVideoPlayer_GetPlaybackTime`
- `CVideoPlayer_GetRepeat`
- `CVideoPlayer_GetSpectrum`
- `CVideoPlayer_GetTexture`
- `CVideoPlayer_GetWidth`
- `CVideoPlayer_HasAudioStream`
- `CVideoPlayer_IsMuted`
- `CVideoPlayer_IsPaused`
- `CVideoPlayer_Pause`
- `CVideoPlayer_Play`
- `CVideoPlayer_Resume`
- `CVideoPlayer_Seek`
- `CVideoPlayer_SetMuted`
- `CVideoPlayer_SetRepeat`
- `CVideoPlayer_SetVideoOnly`
- `CVideoPlayer_Stop`
- `CVideoPlayer_Update`
- `CVideoRecorder_AddAudioSamples`
- `CVideoRecorder_AddVideoFrame`
- `CVideoRecorder_Create`
- `CVideoRecorder_Destroy`
- `CVideoRecorder_Initialize`
- `CVideoRecorder_Stop`

### Yoga (99 fonctions)

- `globalYoga_YGConfigFree`
- `globalYoga_YGConfigNew`
- `globalYoga_YGConfigSetPointScaleFactor`
- `globalYoga_YGConfigSetUseWebDefaults`
- `globalYoga_YGNodeCalculateLayout`
- `globalYoga_YGNodeCopyStyle`
- `globalYoga_YGNodeFree`
- `globalYoga_YGNodeGetChildCount`
- `globalYoga_YGNodeGetHasNewLayout`
- `globalYoga_YGNodeGetParent`
- `globalYoga_YGNodeHasMeasureFunc`
- `globalYoga_YGNodeInsertChild`
- `globalYoga_YGNodeIsDirty`
- `globalYoga_YGNodeLayoutGetBorder`
- `globalYoga_YGNodeLayoutGetBottom`
- `globalYoga_YGNodeLayoutGetDirection`
- `globalYoga_YGNodeLayoutGetHadOverflow`
- `globalYoga_YGNodeLayoutGetHeight`
- `globalYoga_YGNodeLayoutGetLeft`
- `globalYoga_YGNodeLayoutGetMargin`
- `globalYoga_YGNodeLayoutGetPadding`
- `globalYoga_YGNodeLayoutGetRight`
- `globalYoga_YGNodeLayoutGetTop`
- `globalYoga_YGNodeLayoutGetWidth`
- `globalYoga_YGNodeMarkDirty`
- `globalYoga_YGNodeNew`
- `globalYoga_YGNodeNewWithConfig`
- `globalYoga_YGNodeRemoveAllChildren`
- `globalYoga_YGNodeRemoveChild`
- `globalYoga_YGNodeReset`
- `globalYoga_YGNodeSetConfig`
- `globalYoga_YGNodeSetHasNewLayout`
- `globalYoga_YGNodeSetMeasureFunc`
- `globalYoga_YGNodeStyleGetAlignContent`
- `globalYoga_YGNodeStyleGetAlignItems`
- `globalYoga_YGNodeStyleGetAlignSelf`
- `globalYoga_YGNodeStyleGetAspectRatio`
- `globalYoga_YGNodeStyleGetBorder`
- `globalYoga_YGNodeStyleGetDirection`
- `globalYoga_YGNodeStyleGetDisplay`
- `globalYoga_YGNodeStyleGetFlex`
- `globalYoga_YGNodeStyleGetFlexBasis`
- `globalYoga_YGNodeStyleGetFlexDirection`
- `globalYoga_YGNodeStyleGetFlexGrow`
- `globalYoga_YGNodeStyleGetFlexShrink`
- `globalYoga_YGNodeStyleGetFlexWrap`
- `globalYoga_YGNodeStyleGetGap`
- `globalYoga_YGNodeStyleGetHeight`
- `globalYoga_YGNodeStyleGetJustifyContent`
- `globalYoga_YGNodeStyleGetMargin`
- `globalYoga_YGNodeStyleGetMaxHeight`
- `globalYoga_YGNodeStyleGetMaxWidth`
- `globalYoga_YGNodeStyleGetMinHeight`
- `globalYoga_YGNodeStyleGetMinWidth`
- `globalYoga_YGNodeStyleGetOverflow`
- `globalYoga_YGNodeStyleGetPadding`
- `globalYoga_YGNodeStyleGetPosition`
- `globalYoga_YGNodeStyleGetPositionType`
- `globalYoga_YGNodeStyleGetWidth`
- `globalYoga_YGNodeStyleSetAlignContent`
- `globalYoga_YGNodeStyleSetAlignItems`
- `globalYoga_YGNodeStyleSetAlignSelf`
- `globalYoga_YGNodeStyleSetAspectRatio`
- `globalYoga_YGNodeStyleSetBorder`
- `globalYoga_YGNodeStyleSetDirection`
- `globalYoga_YGNodeStyleSetDisplay`
- `globalYoga_YGNodeStyleSetFlex`
- `globalYoga_YGNodeStyleSetFlexBasis`
- `globalYoga_YGNodeStyleSetFlexBasisAuto`
- `globalYoga_YGNodeStyleSetFlexBasisPercent`
- `globalYoga_YGNodeStyleSetFlexDirection`
- `globalYoga_YGNodeStyleSetFlexGrow`
- `globalYoga_YGNodeStyleSetFlexShrink`
- `globalYoga_YGNodeStyleSetFlexWrap`
- `globalYoga_YGNodeStyleSetGap`
- `globalYoga_YGNodeStyleSetHeight`
- `globalYoga_YGNodeStyleSetHeightAuto`
- `globalYoga_YGNodeStyleSetHeightPercent`
- `globalYoga_YGNodeStyleSetJustifyContent`
- `globalYoga_YGNodeStyleSetMargin`
- `globalYoga_YGNodeStyleSetMarginAuto`
- `globalYoga_YGNodeStyleSetMarginPercent`
- `globalYoga_YGNodeStyleSetMaxHeight`
- `globalYoga_YGNodeStyleSetMaxHeightPercent`
- `globalYoga_YGNodeStyleSetMaxWidth`
- `globalYoga_YGNodeStyleSetMaxWidthPercent`
- `globalYoga_YGNodeStyleSetMinHeight`
- `globalYoga_YGNodeStyleSetMinHeightPercent`
- `globalYoga_YGNodeStyleSetMinWidth`
- `globalYoga_YGNodeStyleSetMinWidthPercent`
- `globalYoga_YGNodeStyleSetOverflow`
- `globalYoga_YGNodeStyleSetPadding`
- `globalYoga_YGNodeStyleSetPaddingPercent`
- `globalYoga_YGNodeStyleSetPosition`
- `globalYoga_YGNodeStyleSetPositionPercent`
- `globalYoga_YGNodeStyleSetPositionType`
- `globalYoga_YGNodeStyleSetWidth`
- `globalYoga_YGNodeStyleSetWidthAuto`
- `globalYoga_YGNodeStyleSetWidthPercent`


## Architecture Commune et Partage de Code

### HandleManager Centralisé - IMPORTANCE CRITIQUE

**⚠️ IMPORTANCE CRITIQUE** : HandleManager est **fondamental** pour l'émulation. Tous les objets émulés (matériaux, textures, render attributes, cameras, etc.) doivent utiliser HandleManager pour gérer leur cycle de vie et permettre la comparaison via BindingPtr.

**Pourquoi HandleManager est essentiel** :
1. **Gestion du cycle de vie** : Tous les objets émulés sont gérés via HandleManager, permettant une libération propre des ressources
2. **BindingPtr** : Le BindingPtr retourné par `GetBindingPtr()` est le handle HandleManager, permettant de comparer si deux handles pointent vers le même objet natif
3. **Thread-safety** : HandleManager utilise ConcurrentDictionary pour la sécurité multi-thread
4. **Unification** : Évite la duplication de code et assure une gestion cohérente des handles dans tout le projet
5. **Comptage de références** : Permet de gérer les copies de handles forts (ex: `CopyStrongHandle`) avec comptage de références

**Règle absolue** : 
- ✅ **TOUJOURS** utiliser `HandleManager.Register()` pour créer un BindingPtr
- ✅ **TOUJOURS** utiliser `HandleManager.Unregister()` pour libérer un BindingPtr
- ❌ **JAMAIS** créer un BindingPtr avec un simple compteur ou pointeur arbitraire
- ❌ **JAMAIS** utiliser un BindingPtr sans l'enregistrer dans HandleManager

**Exemple correct** :
```csharp
// ✅ CORRECT : Utiliser HandleManager pour BindingPtr
var materialData = new MaterialData { ... };
int bindingHandle = HandleManager.Register(materialData);
materialData.BindingPtr = (IntPtr)bindingHandle;

// Lors de la libération
HandleManager.Unregister((int)materialData.BindingPtr);
```

**Exemple incorrect** :
```csharp
// ❌ INCORRECT : Ne pas utiliser HandleManager
private static long _nextBindingPtrId = 1;
materialData.BindingPtr = (IntPtr)_nextBindingPtrId++; // MAUVAIS !
```

**Problème actuel** : Il existe plusieurs implémentations de HandleManager (`HandleManager` dans Physics/, `AudioHandleManager` dans EngineExports.cs). Il faut unifier cela.

**Décision** : Créer `Common/HandleManager.cs` en **Phase 0** (avant toute implémentation de module).

**Solution** : Créer un `HandleManager` centralisé dans `src/Sbox.Engine.Emulation/Common/HandleManager.cs` :

```csharp
namespace Sbox.Engine.Emulation.Common;

/// <summary>
/// Gestionnaire centralisé de handles pour tous les objets émulés.
/// Thread-safe, utilise ConcurrentDictionary pour la sécurité multi-thread.
/// Les handles commencent à 1000 pour éviter les collisions avec les handles natifs.
/// </summary>
internal static class HandleManager
{
    private static int _nextHandle = 1000;
    private static readonly ConcurrentDictionary<int, object> _objects = new();
    
    /// <summary>
    /// Enregistre un objet et retourne un handle unique.
    /// </summary>
    public static int Register(object obj)
    {
        var handle = Interlocked.Increment(ref _nextHandle);
        _objects[handle] = obj;
        return handle;
    }
    
    /// <summary>
    /// Récupère un objet par son handle.
    /// </summary>
    public static T? Get<T>(int handle) where T : class
    {
        return _objects.TryGetValue(handle, out var obj) ? obj as T : null;
    }
    
    /// <summary>
    /// Libère un handle et son objet associé.
    /// </summary>
    public static void Unregister(int handle)
    {
        _objects.TryRemove(handle, out _);
    }
    
    /// <summary>
    /// Vérifie si un handle existe.
    /// </summary>
    public static bool Exists(int handle)
    {
        return _objects.ContainsKey(handle);
    }
}
```

**Migration** :
1. Créer `src/Sbox.Engine.Emulation/Common/HandleManager.cs`
2. Migrer `HandleManager` de `Physics/HandleManager.cs` vers `Common/`
3. Supprimer `AudioHandleManager` de `EngineExports.cs` et utiliser `HandleManager`
4. Mettre à jour tous les imports dans les modules

### Gestion des Dépendances entre Modules

**Problème** : Certains modules dépendent d'autres (ex: AudioSystem utilise AudioMixBuffer).

**Solution** : Utiliser des interfaces et des références explicites :

1. **Interfaces publiques** : Les modules exposent des interfaces pour leurs types internes
2. **Pas de dépendances circulaires** : Organiser les modules en couches (Core → Rendering → Scene → ...)
3. **Références explicites** : Si un module A a besoin d'un type du module B, il doit l'importer explicitement

**Exemple** :
```csharp
// Audio/AudioSystem.cs
namespace Sbox.Engine.Emulation.Audio;

public static class AudioSystem
{
    // AudioMixBuffer est interne à AudioSystem, mais peut être utilisé par d'autres modules
    internal class AudioMixBuffer { ... }
    
    // Fonction publique pour créer un buffer (utilisée par d'autres modules si nécessaire)
    public static AudioMixBuffer CreateBuffer() { ... }
}
```

### État Global vs Instances

**Problème** : Certains modules ont un état global (ex: PlatformFunctions avec `_glfw`, `_windowHandle`).

**Solution** : Utiliser un pattern Singleton avec initialisation explicite :

```csharp
namespace Sbox.Engine.Emulation.Platform;

public static class PlatformFunctions
{
    // État global (initialisé une fois)
    private static Glfw? _glfw;
    private static WindowHandle* _windowHandle;
    private static GL? _gl;
    private static bool _isInitialized = false;
    
    /// <summary>
    /// Initialise l'état global de la plateforme.
    /// Doit être appelé avant toute utilisation.
    /// </summary>
    public static void Initialize()
    {
        if (_isInitialized) return;
        
        _glfw = Glfw.GetApi();
        // ... initialisation
        _isInitialized = true;
    }
    
    /// <summary>
    /// Accès thread-safe à l'état global.
    /// </summary>
    public static Glfw? GetGlfw() => _glfw;
    public static WindowHandle* GetWindowHandle() => _windowHandle;
    public static GL? GetGL() => _gl;
}
```

**Règles** :
- L'état global doit être initialisé explicitement dans `IGenEngine()` avant les modules qui en dépendent
- Utiliser des propriétés ou méthodes pour accéder à l'état global (pas de champs publics)
- Documenter clairement quels modules ont un état global

## Gestion de la Mémoire et Cycles de Vie

### Responsabilité de Libération

**Règle générale** : Le créateur est responsable de la libération, sauf indication contraire.

**Patterns** :

1. **Handles retournés par Create()** : Le code appelant doit appeler Delete()/Dispose()
   ```csharp
   [UnmanagedCallersOnly]
   public static IntPtr CRenderAttributes_Create()
   {
       var attrs = new EmulatedRenderAttributes();
       int handle = HandleManager.Register(attrs);
       return (IntPtr)handle;
   }
   
   [UnmanagedCallersOnly]
   public static void CRenderAttributes_DeleteThis(IntPtr self)
   {
       int handle = (int)self;
       HandleManager.Unregister(handle);
   }
   ```

2. **Pointeurs retournés (ex: GetGameRootFolder)** : Le code appelant est responsable, mais on peut utiliser un cache
   ```csharp
   private static IntPtr? _cachedGameRootFolder = null;
   
   [UnmanagedCallersOnly]
   public static void* GetGameRootFolder()
   {
       if (_cachedGameRootFolder == null)
       {
           string cwd = Directory.GetCurrentDirectory();
           _cachedGameRootFolder = Marshal.StringToHGlobalAnsi(cwd);
       }
       return (void*)_cachedGameRootFolder.Value;
   }
   ```

3. **Objets internes (ex: EmulatedCameraRenderer)** : Gérés par HandleManager, libérés automatiquement via Delete()
   ```csharp
   private class EmulatedCameraRenderer
   {
       // Pas besoin de Dispose() explicite si tout est géré par HandleManager
       // Les ressources sont libérées quand HandleManager.Unregister() est appelé
   }
   ```

### Cycles de Vie des Objets Émulés

**Pattern recommandé** :

1. **Création** : `Create()` → `HandleManager.Register()` → retourne handle
2. **Utilisation** : `Get<T>(handle)` pour récupérer l'objet
3. **Libération** : `DeleteThis()` → `HandleManager.Unregister()` → objet éligible au GC

**Exemple complet** :
```csharp
[UnmanagedCallersOnly]
public static IntPtr CCameraRenderer_Create()
{
    var renderer = new EmulatedCameraRenderer();
    int handle = HandleManager.Register(renderer);
    Console.WriteLine($"[NativeAOT] CCameraRenderer_Create: handle={handle}");
    return (IntPtr)handle;
}

[UnmanagedCallersOnly]
public static void CCameraRenderer_DeleteThis(IntPtr self)
{
    if (self == IntPtr.Zero) return;
    
    int handle = (int)self;
    var renderer = HandleManager.Get<EmulatedCameraRenderer>(handle);
    if (renderer != null)
    {
        // Nettoyer les ressources si nécessaire
        renderer.Dispose();
        HandleManager.Unregister(handle);
        Console.WriteLine($"[NativeAOT] CCameraRenderer_DeleteThis: handle={handle}");
    }
}
```

## Performance et Optimisations (Raspberry Pi)

### Contraintes Matérielles

- **Cible** : Raspberry Pi (ARM Cortex-A72/A76, 4-8GB RAM, GPU VideoCore VI/VII)
- **CPU** : 4-8 cores ARM 64-bit, fréquence variable (1.5-2.4 GHz selon modèle)
- **Mémoire** : RAM limitée, pas de cache L3, cache L2 partagé
- **GPU** : VideoCore VI/VII, OpenGL ES 3.1, Vulkan 1.0
- **Hot paths** : Fonctions appelées chaque frame (ex: `SourceEngineFrame`, `RenderTools_Draw`, `Physics_Step`)

### Techniques d'Optimisation de Code (Niveau 1 - Critique)

#### 1. Zero-Allocation dans les Hot Paths

**Principe** : Éviter toute allocation heap (`new`, `Array.Resize`, etc.) dans les fonctions appelées chaque frame.

**Techniques** :
- **Pools d'objets** : Réutiliser les objets au lieu de les créer
- **Stack allocation** : Utiliser `stackalloc` pour les buffers temporaires
- **Structs au lieu de classes** : Préférer les structs pour les petits objets temporaires
- **Span<T> et Memory<T>** : Utiliser des vues sur des buffers pré-alloués

**Exemple de pool d'objets** :
```csharp
private static readonly ConcurrentQueue<EmulatedRenderAttributes> _attributePool = new();
private static readonly object _poolLock = new object();

private static EmulatedRenderAttributes GetOrCreateAttributes()
{
    if (_attributePool.TryDequeue(out var attrs))
    {
        attrs.Clear(true); // Réinitialiser
        return attrs;
    }
    return new EmulatedRenderAttributes();
}

private static void ReturnToPool(EmulatedRenderAttributes attrs)
{
    attrs.Clear(true);
    _attributePool.Enqueue(attrs);
}
```

**Exemple avec stackalloc** :
```csharp
[UnmanagedCallersOnly]
public static void ProcessVertices(void* vertices, int count)
{
    // Buffer temporaire sur la stack (pas d'allocation heap)
    Span<float> tempBuffer = stackalloc float[16];
    // ... traitement
}
```

#### 2. Cache Locality et Data-Oriented Design

**Principe** : Organiser les données pour maximiser l'utilisation du cache CPU.

**Techniques** :
- **SoA (Structure of Arrays)** au lieu de **AoS (Array of Structures)** pour les données traitées en batch
- **Padding** : Aligner les structures sur les limites de cache (64 bytes pour ARM)
- **Préchargement** : Accéder aux données de manière séquentielle
- **Éviter les pointeurs chaînés** : Préférer les tableaux contigus

**Exemple SoA vs AoS** :
```csharp
// ❌ MAUVAIS : AoS (mauvais cache locality)
struct Vertex { Vector3 pos; Vector3 normal; Vector2 uv; }
Vertex[] vertices = new Vertex[1000];

// ✅ BON : SoA (meilleur cache locality pour traitement batch)
struct VertexData
{
    Vector3[] positions;
    Vector3[] normals;
    Vector2[] uvs;
}
```

#### 3. Utilisation de Structs au lieu de Classes

**Principe** : Les structs sont alloués sur la stack, évitent le GC, et améliorent la cache locality.

**Règles** :
- Utiliser des structs pour les types de données < 16 bytes
- Utiliser des structs pour les types immutables
- Utiliser des structs pour les types passés par valeur fréquemment

**Exemple** :
```csharp
// ✅ Struct pour données petites et fréquentes
public struct RenderState
{
    public int ShaderId;
    public int TextureId;
    public BlendMode Blend;
}

// ❌ Classe pour données grandes ou mutables complexes
public class MaterialData
{
    public Dictionary<string, float> Parameters; // Nécessite une classe
}
```

#### 4. Span<T> et Memory<T> pour les Buffers

**Principe** : Utiliser `Span<T>` et `Memory<T>` pour éviter les allocations et améliorer les performances.

**Avantages** :
- Pas d'allocation heap
- Meilleure cache locality
- Vérifications de bounds à la compilation
- Support natif pour stackalloc

**Exemple** :
```csharp
[UnmanagedCallersOnly]
public static void ProcessBuffer(void* data, int length)
{
    unsafe
    {
        Span<byte> buffer = new Span<byte>(data, length);
        // Traitement sans allocation
        for (int i = 0; i < buffer.Length; i++)
        {
            buffer[i] = ProcessByte(buffer[i]);
        }
    }
}
```

#### 5. Minimisation des Conversions et Marshalling

**Principe** : Éviter les conversions coûteuses dans les hot paths.

**Techniques** :
- **Cache des conversions** : Mettre en cache les résultats de `Marshal.PtrToStringUTF8()`
- **Pointeurs natifs** : Utiliser `void*` au lieu de `IntPtr` dans les hot paths
- **Éviter les boxings** : Utiliser des génériques pour éviter le boxing
- **Unsafe code** : Utiliser `unsafe` pour éviter les vérifications de bounds

**Exemple de cache** :
```csharp
private static readonly Dictionary<IntPtr, string> _stringCache = new();
private static readonly object _cacheLock = new object();

private static string GetCachedString(IntPtr ptr)
{
    lock (_cacheLock)
    {
        if (!_stringCache.TryGetValue(ptr, out var str))
        {
            str = Marshal.PtrToStringUTF8(ptr) ?? "";
            _stringCache[ptr] = str;
        }
        return str;
    }
}
```

### Techniques d'Optimisation de Code (Niveau 2 - Important)

#### 6. Inlining et Méthodes Statiques

**Principe** : Aider le compilateur à inline les petites méthodes.

**Techniques** :
- Utiliser `[MethodImpl(MethodImplOptions.AggressiveInlining)]` pour les petites méthodes hot
- Préférer les méthodes statiques pour éviter les indirections
- Éviter les appels virtuels dans les hot paths

**Exemple** :
```csharp
[MethodImpl(MethodImplOptions.AggressiveInlining)]
private static float FastSqrt(float x)
{
    // Implémentation optimisée
    return MathF.Sqrt(x);
}
```

#### 7. Branch Prediction et Branchless Code

**Principe** : Réduire les branches conditionnelles dans les hot paths pour améliorer la prédiction de branche.

**Techniques** :
- Utiliser des opérations ternaires au lieu de if/else
- Utiliser des masques binaires pour les conditions
- Réorganiser les conditions pour privilégier les cas les plus fréquents

**Exemple** :
```csharp
// ❌ MAUVAIS : Branche conditionnelle
if (value > 0)
    result = value;
else
    result = 0;

// ✅ BON : Branchless
result = value > 0 ? value : 0;
// Ou mieux avec masque
result = value & ~(value >> 31); // Pour int32
```

#### 8. SIMD et Vectorisation (ARM NEON)

**Principe** : Utiliser les instructions SIMD pour traiter plusieurs données en parallèle.

**Techniques** :
- Utiliser `System.Numerics.Vector<T>` pour la vectorisation automatique
- Utiliser `System.Runtime.Intrinsics.Arm.AdvSimd` pour ARM NEON explicite
- Aligner les données sur 16 bytes pour NEON

**Exemple** :
```csharp
using System.Numerics;

[UnmanagedCallersOnly]
public static void ProcessVectors(Vector3* vectors, int count)
{
    int simdCount = count / Vector<float>.Count;
    for (int i = 0; i < simdCount; i++)
    {
        // Traite 4-8 floats en parallèle selon l'architecture
        var v1 = new Vector<float>(vectors[i * Vector<float>.Count]);
        var v2 = new Vector<float>(vectors[i * Vector<float>.Count + Vector<float>.Count]);
        var result = Vector.Multiply(v1, v2);
        // ... stocker result
    }
    // Traiter le reste
}
```

#### 9. Lookup Tables au lieu de Calculs

**Principe** : Pré-calculer les valeurs fréquemment utilisées.

**Techniques** :
- Créer des tables de lookup pour les fonctions mathématiques coûteuses
- Utiliser des tables de taille puissance de 2 pour des accès rapides (masquage au lieu de modulo)

**Exemple** :
```csharp
private static readonly float[] SinTable = new float[256];
private static readonly float SinTableScale = 256.0f / (2.0f * MathF.PI);

static RenderMath()
{
    for (int i = 0; i < 256; i++)
    {
        SinTable[i] = MathF.Sin(i / SinTableScale);
    }
}

[MethodImpl(MethodImplOptions.AggressiveInlining)]
public static float FastSin(float angle)
{
    int index = (int)(angle * SinTableScale) & 0xFF;
    return SinTable[index];
}
```

#### 10. Réduction des Appels de Fonctions

**Principe** : Minimiser les appels de fonctions dans les hot paths.

**Techniques** :
- Inline les petites fonctions
- Regrouper les opérations similaires
- Éviter les delegates et les callbacks dans les hot paths

### Techniques d'Optimisation de Code (Niveau 3 - Avancé)

#### 11. Memory Barriers et Cache Coherence

**Principe** : Comprendre et optimiser la cohérence du cache sur ARM.

**Techniques** :
- Utiliser `Volatile.Read()` et `Volatile.Write()` pour les accès partagés
- Éviter les false sharing (variables partagées sur la même ligne de cache)
- Utiliser `[StructLayout(LayoutKind.Explicit)]` pour contrôler l'alignement

**Exemple** :
```csharp
[StructLayout(LayoutKind.Explicit, Size = 64)] // Aligné sur ligne de cache
public struct CacheLineAligned
{
    [FieldOffset(0)]
    public int Value1;
    // Padding automatique jusqu'à 64 bytes
}
```

#### 12. Profiling et Mesure

**Principe** : Mesurer avant d'optimiser.

**Techniques** :
- Utiliser `System.Diagnostics.Stopwatch` pour mesurer les hot paths
- Utiliser des compteurs de performance pour identifier les bottlenecks
- Profiler avec `dotnet-trace` et `perf` sur Linux

**Exemple** :
```csharp
#if DEBUG
private static long _renderCallCount = 0;
private static long _renderTotalTicks = 0;
#endif

[UnmanagedCallersOnly]
public static void RenderTools_Draw(...)
{
#if DEBUG
    var sw = Stopwatch.StartNew();
#endif
    
    // ... code de rendu
    
#if DEBUG
    sw.Stop();
    Interlocked.Increment(ref _renderCallCount);
    Interlocked.Add(ref _renderTotalTicks, sw.ElapsedTicks);
    if (_renderCallCount % 1000 == 0)
    {
        Console.WriteLine($"[Perf] RenderTools_Draw: avg={_renderTotalTicks / _renderCallCount} ticks");
    }
#endif
}
```

### Optimisations Matérielles et Système (Recommandations)

#### 13. Configuration Système

**Recommandations** :
- **OS léger** : Utiliser Raspbian Lite ou DietPi
- **CPU Governor** : Configurer en mode "performance" : `echo performance | sudo tee /sys/devices/system/cpu/cpu*/cpufreq/scaling_governor`
- **ZRAM** : Activer ZRAM pour swap en mémoire : `sudo apt install zram-tools`
- **Désactiver services inutiles** : Désactiver Bluetooth, Wi-Fi si non utilisés
- **Alimentation** : Utiliser une alimentation 5V/3A minimum (5A recommandé pour Pi 4/5)

#### 14. Refroidissement

**Recommandations** :
- **Dissipateurs thermiques** : Installer sur CPU, GPU, et RAM
- **Ventilateur actif** : Pour utilisation intensive
- **Surveillance température** : `vcgencmd measure_temp` (maintenir < 70°C)
- **Throttling** : Surveiller avec `vcgencmd get_throttled`

#### 15. Stockage

**Recommandations** :
- **SSD via USB 3.0** : Pour de meilleures performances I/O
- **Carte SD classe 10+** : Si SD nécessaire, utiliser UHS-I A1/V30
- **Partition swap** : Éviter si possible (utiliser ZRAM)

### Checklist d'Optimisation par Fonction

Avant d'implémenter une fonction dans un hot path, vérifier :

- [ ] Aucune allocation heap (`new`, `Array.Resize`, etc.)
- [ ] Utilisation de structs pour petits objets
- [ ] Utilisation de `Span<T>` ou `stackalloc` pour buffers temporaires
- [ ] Cache des conversions coûteuses (`Marshal.PtrToStringUTF8`, etc.)
- [ ] Minimisation des branches conditionnelles
- [ ] Utilisation de `[MethodImpl(AggressiveInlining)]` pour petites fonctions
- [ ] Données alignées sur limites de cache (64 bytes)
- [ ] Logging conditionnel avec `#if DEBUG`
- [ ] Profiling activé pour mesurer les performances

### Exemple Complet : Fonction Optimisée

```csharp
[UnmanagedCallersOnly]
[MethodImpl(MethodImplOptions.AggressiveInlining)]
public static int RenderTools_Draw(
    void* context,
    long type,
    void* layout,
    void* vertices,
    int numVertices,
    void* indices,
    int numIndices,
    void* stats)
{
    // Validation rapide (branchless si possible)
    if (context == null || vertices == null || numVertices <= 0)
        return 0;
    
    // Récupération depuis HandleManager (pas d'allocation)
    int handle = (int)(long)context;
    var renderContext = HandleManager.Get<EmulatedRenderContext>(handle);
    if (renderContext == null)
        return 0;
    
    // Utilisation de Span pour éviter les allocations
    unsafe
    {
        Span<byte> vertexSpan = new Span<byte>(vertices, numVertices * 48); // 48 = sizeof(Vertex)
        renderContext.UploadVertexData(vertexSpan);
        
        if (indices != null && numIndices > 0)
        {
            Span<ushort> indexSpan = new Span<ushort>(indices, numIndices);
            renderContext.UploadIndexData(indexSpan);
        }
    }
    
    // Draw (implémentation optimisée)
    var primitiveType = (NativeEngine.RenderPrimitiveType)type;
    renderContext.Draw(primitiveType, numVertices, indices != null ? numIndices : 0);
    
    return 1; // Success
}
```

### Références et Ressources

- **ARM NEON** : https://developer.arm.com/architectures/instruction-sets/simd-isas/neon
- **Data-Oriented Design** : "Data-Oriented Design" par Richard Fabian
- **C# Performance** : https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/performance-warnings
- **NativeAOT** : https://github.com/dotnet/runtime/tree/main/src/coreclr/nativeaot

## Documentation

### Documentation des Fonctions

**Règle** : Chaque fonction `[UnmanagedCallersOnly]` doit être documentée avec :

```csharp
/// <summary>
/// Crée un nouveau CRenderAttributes.
/// 
/// **Responsabilité mémoire** : L'appelant doit appeler CRenderAttributes_DeleteThis() pour libérer.
/// 
/// **Comportement Source 2** : Crée un objet CRenderAttributes vide.
/// **Comportement émulation** : Identique, utilise HandleManager pour gérer le cycle de vie.
/// 
/// **Performance** : Allocation minimale (handle + dictionnaire), acceptable pour création occasionnelle.
/// </summary>
/// <returns>Handle vers le CRenderAttributes créé, ou IntPtr.Zero en cas d'erreur</returns>
[UnmanagedCallersOnly]
public static IntPtr CRenderAttributes_Create()
{
    // ...
}
```

### Documentation des Différences Source 2 vs Émulation

**Fichier** : `docs/emulation-differences.md`

Structure :
```markdown
# Différences entre Source 2 Native et Émulation Linux

## CRenderAttributes

### Comportement identique
- Création, suppression, Get/Set fonctionnent de la même manière

### Différences
- **Gestion mémoire** : Utilise HandleManager au lieu de la gestion native Source 2
- **Performance** : Légèrement plus lent (allocation C# vs native), mais négligeable

## CCameraRenderer

### À documenter lors de l'implémentation
- ...
```

## Propriétés Get/Set - Pattern Recommandé

**Problème** : Beaucoup de fonctions sont des accesseurs (ex: `_Get__CCameraRenderer_CameraPosition`, `_Set__CCameraRenderer_CameraPosition`).

**Solution** : Pattern clair et explicite avec validation :

```csharp
// Getter
[UnmanagedCallersOnly]
public static Vector3 CCameraRenderer_GetCameraPosition(IntPtr self)
{
    if (self == IntPtr.Zero) return Vector3.Zero;
    
    int handle = (int)self;
    var renderer = HandleManager.Get<EmulatedCameraRenderer>(handle);
    return renderer?.CameraPosition ?? Vector3.Zero;
}

// Setter
[UnmanagedCallersOnly]
public static void CCameraRenderer_SetCameraPosition(IntPtr self, Vector3 position)
{
    if (self == IntPtr.Zero) return;
    
    int handle = (int)self;
    var renderer = HandleManager.Get<EmulatedCameraRenderer>(handle);
    if (renderer != null)
    {
        renderer.CameraPosition = position;
    }
}
```

**Règles** :
- Toujours valider `self != IntPtr.Zero`
- Retourner des valeurs par défaut sûres si l'objet n'existe pas
- Utiliser des propriétés C# dans la classe interne pour stocker les valeurs

## Graphe de Dépendances

### Création et Mise à Jour

**Fichier** : `docs/dependency-graph.md`

**Règle** : 
- Créer le graphe au fur et à mesure de l'avancement
- Consulter le graphe avant d'implémenter un nouveau module
- Mettre à jour le graphe dès qu'une dépendance est identifiée

**Format** :
```markdown
# Graphe de Dépendances des Modules

## Niveau 0 - Core (aucune dépendance)
- Common (HandleManager)
- Platform (GLFW, OpenGL)

## Niveau 1 - Base Systems
- FileSystem (dépend de: Platform)
- Texture (dépend de: Platform, Common)

## Niveau 2 - Rendering Base
- RenderAttributes (dépend de: Common)
- Material (dépend de: RenderAttributes, Texture, Common)

## Niveau 3 - Rendering Advanced
- RenderTools (dépend de: RenderAttributes, Material, Platform)
- Scene (dépend de: RenderAttributes, Material, Texture, RenderTools)

## Niveau 4 - High Level
- Camera (dépend de: Scene, RenderTools, Material)
- Model (dépend de: Material, Texture)

## Indépendants (peuvent être parallélisés)
- Audio (dépend de: Common)
- Yoga (dépend de: Common)
- Physics (dépend de: Common)
- Input (dépend de: Platform)
```

**Ordre d'implémentation recommandé** :
1. Niveau 0 (Core)
2. Niveau 1 (Base Systems)
3. Niveau 2+ (selon les besoins)

## Migration des Fonctions Existantes

### Workflow de Migration

1. **Identifier les fonctions à migrer** dans `EngineExports.cs`
2. **Créer le module** correspondant (ou utiliser un module existant)
3. **Déplacer le code** :
   - Copier les fonctions `[UnmanagedCallersOnly]`
   - Copier les classes internes (ex: `EmulatedRenderAttributes`)
   - Copier les variables statiques si nécessaire
4. **Mettre à jour les patches** :
   - Déplacer les patches de `IGenEngine()` vers `Module.Init()`
   - Appeler `Module.Init(native)` dans `IGenEngine()`
5. **Tester** : Suivre le workflow build -> publish -> run
6. **Nettoyer** : Supprimer le code de `EngineExports.cs` une fois validé

### Exemple de Migration

**Avant** (dans `EngineExports.cs`) :
```csharp
// Dans IGenEngine()
native[690] = (void*)(delegate* unmanaged<IntPtr>)&CRndrttrbts_Create;

// Plus bas dans le fichier
[UnmanagedCallersOnly]
public static IntPtr CRndrttrbts_Create() { ... }
```

**Après** (dans `RenderAttributes/RenderAttributes.cs`) :
```csharp
public static void Init(void** native)
{
    native[690] = (void*)(delegate* unmanaged<IntPtr>)&CRndrttrbts_Create;
    // ... autres patches
}

[UnmanagedCallersOnly]
public static IntPtr CRndrttrbts_Create() { ... }
```

**Dans `EngineExports.cs`** :
```csharp
public static void IGenEngine(...)
{
    // ...
    Exports.FillNativeFunctionsEngine(managed, native, structSizes);
    
    // Initialiser tous les modules
    RenderAttributes.Init(native);
    // ...
}
```

## Tests par Module

### Workflow de Test

**Règle** : Après chaque module créé ou migré, exécuter le workflow complet :

1. **Build** : `dotnet build src/Sbox.Engine.Emulation/Sbox.Engine.Emulation.csproj`
2. **Publish** : `dotnet publish src/Sbox.Engine.Emulation/Sbox.Engine.Emulation.csproj -c Release -r linux-x64 /p:NativeLib=Shared /p:SelfContained=true`
3. **Copy** : `cp src/Sbox.Engine.Emulation/bin/Release/net10.0/linux-x64/publish/Sbox.Engine.Emulation.so game/bin/linuxsteamrt64/libengine2.so`
4. **Run** : `cd game && ./sbox`

**Validation** :
- Le jeu démarre sans erreur
- Les fonctionnalités du module testé fonctionnent
- Pas de régression sur les modules précédents

### Tests Unitaires (Futur)

**Note** : Pas de tests unitaires actuellement, mais à prévoir dans le plan :

- Créer `tests/Sbox.Engine.Emulation.Tests/` pour les tests unitaires
- Tester chaque module indépendamment
- Utiliser des mocks pour les dépendances

## Gestion des Erreurs

### Fonctions Non Implémentées

**Règle** : Si une fonction native est appelée mais non implémentée :

1. **Lancer une exception** avec un message clair :
   ```csharp
   [UnmanagedCallersOnly]
   public static IntPtr FunctionNotImplemented()
   {
       throw new NotImplementedException("FunctionNotImplemented is not yet implemented in the Linux emulation layer");
   }
   ```

2. **Logging conditionnel** (si pas trop coûteux) :
   ```csharp
   #if DEBUG
   Console.WriteLine($"[NativeAOT] WARNING: FunctionNotImplemented called but not implemented");
   #endif
   ```

3. **Alternative pour les fonctions non critiques** : Retourner une valeur par défaut sûre :
   ```csharp
   [UnmanagedCallersOnly]
   public static int FunctionNonCritical()
   {
       // Fonction non critique, retourner une valeur sûre
       return 0;
   }
   ```

## Organisation de la Catégorie "Other"

### Catégorisation par Préfixes Logiques

Les **1443 fonctions** de la catégorie "Other" ont été analysées et organisées par préfixes logiques.

**Document complet** : Voir `docs/other-categorized.md` pour la liste complète organisée par module.

### Modules Identifiés (Principaux)

#### Physics (déjà partiellement implémenté)
- `IPhysicsBody_*` (79 fonctions) → `Physics/PhysicsBody.cs`
- `IPhysicsJoint_*` (55 fonctions) → `Physics/PhysicsJoint.cs`
- `IPhysicsShape_*` (37 fonctions) → `Physics/PhysicsShape.cs`
- `IPhysicsWorld_*` (32 fonctions) → `Physics/PhysicsWorld.cs`
- `Physggrgtnstnc_*` (25 fonctions) → `Physics/PhysicsAggregateInstance.cs`
- `VPhysXBodyPart_*` (10 fonctions) → `Physics/VPhysXBodyPart.cs`
- `VPhysXJoint_*` (12 fonctions) → `Physics/VPhysXJoint.cs`

#### Scene
- `CnvMpScnbjct_*` (56 fonctions) → `Scene/CanvasMapSceneObject.cs`
- `ISceneView_*` (19 fonctions) → `Scene/SceneView.cs`
- `ISceneLayer_*` (17 fonctions) → `Scene/SceneLayer.cs`
- `ISceneWorld_*` (14 fonctions) → `Scene/SceneWorld.cs`
- `IWorldReference_*` (11 fonctions) → `Scene/WorldReference.cs`

#### Rendering
- `IRenderContext_*` (36 fonctions) → `Rendering/RenderContext.cs`
- `FloatBitMap_t_*` (35 fonctions) → `Image/FloatBitmap.cs`
- `MeshGlue_*` (29 fonctions) → `Mesh/MeshGlue.cs`
- `RnHull_t_*` (10 fonctions) → `Rendering/RnHull.cs`
- `RnMesh_t_*` (6 fonctions) → `Rendering/RnMesh.cs`

#### Steam
- `SteamUgc_*` (33 fonctions) → `Steam/SteamUGC.cs`
- `ISteamGameServer_*` (17 fonctions) → `Steam/SteamGameServer.cs`
- `ISteamApps_*` (12 fonctions) → `Steam/SteamApps.cs`
- `ISteamUser_*` (12 fonctions) → `Steam/SteamUser.cs`
- `globalSteam_*` (17 fonctions) → `Steam/SteamAPI.cs`
- `Steam_Inventory_*` (11 fonctions) → `Steam/SteamInventory.cs`
- `StmHTMLSrfc_*` (24 fonctions) → `Steam/SteamHTMLSurface.cs`
- `StmMtchmkng_*` (8 fonctions) → `Steam/SteamMatchmaking.cs`
- `StmNtwrkngMssgs_*` (6 fonctions) → `Steam/SteamNetworkingMessages.cs`

#### Networking
- `Glue_Networking_*` (33 fonctions) → `Networking/Networking.cs`

#### Console
- `ConVar_*` (13 fonctions) → `Console/ConsoleVariable.cs`
- `ConCommand_*` (4 fonctions) → `Console/ConsoleCommand.cs`

#### Engine/Glue
- `EngineGlue_*` (16 fonctions) → `Engine/EngineGlue.cs`
- `Glue_Resources_*` (5 fonctions) → `Engine/ResourcesGlue.cs`
- `Glue_RndrDvcMngr_*` (4 fonctions) → `Engine/RenderDeviceManagerGlue.cs`

#### Animation
- `IAnimationGraph_*` (8 fonctions) → `Animation/AnimationGraph.cs`
- `IAnimParameter_*` (7 fonctions) → `Animation/AnimationParameter.cs`
- `nmPrmtrnstnc_*` (9 fonctions) → `Animation/AnimationParameterInstance.cs`
- `nmPrmtrLst_*` (3 fonctions) → `Animation/AnimationParameterList.cs`

#### Audio
- `VSound_t_*` (13 fonctions) → `Audio/Sound.cs`

#### VR
- `fpxr_*` (28 fonctions) → `VR/OpenXR.cs`
- `globalOVRLipSync_*` (8 fonctions) → `VR/OVRLipSync.cs`

#### Input
- `NativeEngine_SDLGmCntrllr_*` (8 fonctions) → `Input/SDLGameController.cs`

#### KeyValues
- `KeyValues3_*` (35 fonctions) → `KeyValues/KeyValues3.cs`

#### Property Accessors
- `_Get__*` et `_Set__*` (416 fonctions) → `Other/PropertyAccessors.cs`
  - Ces fonctions sont des accesseurs de propriétés pour différents types
  - Elles doivent être implémentées dans leurs modules respectifs (ex: `_Get__CCameraRenderer_*` dans `Camera/`)

#### Global Functions
- `g_p*` (111 fonctions) → `Other/GlobalFunctions.cs`
  - Fonctions globales du moteur (ex: `g_pMeshSystem_*`, `g_pPhysicsSystem_*`, etc.)
  - À organiser par système dans leurs modules respectifs

#### Autres Modules
- Voir `docs/other-categorized.md` pour la liste complète

**Workflow** :
1. Consulter `docs/other-categorized.md` pour identifier le module d'une fonction
2. Vérifier le graphe de dépendances (`docs/dependency-graph.md`) avant d'implémenter
3. Créer ou utiliser le module existant
4. Implémenter toutes les fonctions du préfixe dans ce module

## Parallélisation

### Modules Indépendants

**Règle** : Les modules indépendants (sans dépendances entre eux) peuvent être implémentés en parallèle.

**Exemples de modules parallélisables** :
- Audio (dépend de: Common)
- Yoga (dépend de: Common)
- Input (dépend de: Platform)
- FileSystem (dépend de: Platform)

**Modules séquentiels** (doivent être implémentés dans l'ordre) :
- RenderAttributes → Material → RenderTools → Scene → Camera

## Pattern de Module

Chaque module suivra ce pattern :

```csharp
namespace Sbox.Engine.Emulation.{Scope};

public static unsafe class {ScopeName}
{
    // Données internes pour stocker l'état
    private static Dictionary<...> _data = new();
    
    // Méthode d'initialisation appelée depuis EngineExports
    // Cette méthode patche les fonctions natives dans le tableau native[]
    public static void Init(void** native)
    {
        // IMPORTANT : Les indices viennent de Interop.Engine.cs
        // Exemple : grep "FunctionName.*nativeFunctions\[" engine/Sandbox.Engine/Interop.Engine.cs
        native[index] = (void*)(delegate* unmanaged<...>)&FunctionName;
        // ...
    }
    
    // Fonctions [UnmanagedCallersOnly] - remplacent les stubs de engine.Generated.cs
    // Les signatures viennent de Interop.Engine.cs
    [UnmanagedCallersOnly]
    public static ReturnType FunctionName(...)
    {
        // Implémentation réelle (remplace le "return default;" de engine.Generated.cs)
    }
    
    // Classes internes pour stocker l'état
    private class InternalData { }
}
```

## Workflow de Création d'un Module

Pour créer un nouveau module, suivre ces étapes :

1. **Identifier les fonctions dans `engine.Generated.cs`** :
   - Chercher les fonctions avec `return default;` pour le scope concerné
   - Exemple : `grep "CRndrttrbts.*return default" src/Sbox.Engine.Emulation/Generated/engine.Generated.cs`
   - Ces fonctions sont les stubs à remplacer par de vraies implémentations

2. **Obtenir les indices depuis `Interop.Engine.cs`** :
   - Chercher chaque fonction : `grep "FunctionName.*nativeFunctions\[" engine/Sandbox.Engine/Interop.Engine.cs`
   - Noter l'index exact et la ligne pour référence
   - **IMPORTANT** : Utiliser directement les indices de `Interop.Engine.cs`, ne pas calculer depuis `engine.Generated.cs`

3. **Obtenir les signatures exactes depuis `Interop.Engine.cs`** :
   - ⚠️ **CRITIQUE** : Chercher la ligne `__N.FunctionName = (delegate* unmanaged<...>)` dans `Interop.Engine.cs`
   - Copier **EXACTEMENT** la signature complète, y compris le type de retour
   - Vérifier aussi la ligne wrapper (ex: `internal static ReturnType FunctionName(...)`) pour comprendre le type de retour réel
   - Exemple : `(delegate* unmanaged< IntPtr, IntPtr, int, IntPtr >) nativeFunctions[1514]` → signature exacte : `IntPtr, IntPtr, int, IntPtr`
   - Si le wrapper montre `internal static global::CUtlBuffer GenerateResourceBytes(...)`, alors le retour `IntPtr` représente un `CUtlBuffer`, pas un simple pointeur
   - **NE JAMAIS** modifier ou adapter les signatures - les copier exactement telles qu'elles sont dans `Interop.Engine.cs`

4. **Créer le module** :
   - Créer le fichier dans le dossier approprié (`src/Sbox.Engine.Emulation/{Scope}/`)
   - Implémenter les fonctions `[UnmanagedCallersOnly]` avec les bonnes signatures
   - Créer `Init(void** native)` qui patche tous les indices
   - Si des fonctions sont déjà implémentées dans `EngineExports.cs`, réutiliser la logique

5. **Appeler depuis EngineExports.cs** :
   - Ajouter `{ScopeName}.Init(native);` dans `IGenEngine()` après `Exports.FillNativeFunctionsEngine()`
   - Supprimer les patches directs de `IGenEngine()` pour les fonctions déplacées

## Décisions Stratégiques et Approche

### 1. HandleManager Centralisé

**Décision** : Créer `Common/HandleManager.cs` en **premier**, avant toute implémentation de module.

**Justification** :
- Tous les modules auront besoin de `HandleManager`
- Évite la duplication de code
- Permet une migration propre depuis `Physics/HandleManager.cs` et `AudioHandleManager`

**Actions** :
1. Créer `src/Sbox.Engine.Emulation/Common/HandleManager.cs` avec l'implémentation centralisée
2. Migrer `Physics/HandleManager.cs` vers `Common/` (copier et adapter)
3. Supprimer `AudioHandleManager` de `EngineExports.cs` et utiliser `Common/HandleManager`
4. Mettre à jour tous les imports : `using Sbox.Engine.Emulation.Common;`

### 2. Structure de Dossiers

**Décision** : Créer les dossiers **au fur et à mesure** lors de l'implémentation de chaque module.

**Justification** :
- Évite de créer des dossiers vides qui pourraient ne jamais être utilisés
- Structure plus claire et organisée
- Facilite le suivi de l'avancement

**Règle** : Créer le dossier `{Scope}/` uniquement quand on commence à implémenter le module correspondant.

### 3. Structure de Tests

**Décision** : Créer la structure de tests **maintenant**, même si elle reste vide initialement.

**Justification** :
- Structure prête pour les tests futurs
- Permet d'ajouter des tests au fur et à mesure
- Facilite la validation des modules

**Actions** :
1. Créer `tests/Sbox.Engine.Emulation.Tests/`
2. Créer le fichier `.csproj` de test
3. Ajouter des tests au fur et à mesure de l'implémentation des modules

### 4. Catégorisation "Other"

**Décision** : Catégoriser les 1443 fonctions "Other" **maintenant**, avant l'implémentation.

**Justification** :
- Donne une vue d'ensemble complète
- Facilite la planification et l'organisation
- Permet d'identifier les modules à créer
- Évite de se retrouver avec une catégorie "Other" non organisée

**Actions** :
1. Analyser tous les préfixes des fonctions "Other"
2. Déchiffrer les noms logiques (ex: `CnvMpScnbjct` = `CanvasMapSceneObject`)
3. Organiser par modules dans le plan
4. Mettre à jour la section "Inventaire Complet des Stubs par Module" avec les nouvelles catégories

### 5. Compatibilité pendant la Migration

**Décision** : Approche **A) Dupliquer puis supprimer** - Garder le code dans `EngineExports.cs` et le dupliquer dans les modules, puis supprimer après tests.

**Justification** :
- Plus sûr : évite les régressions
- Permet de tester le nouveau module sans casser l'existant
- Facilite le rollback en cas de problème
- Validation progressive module par module

**Workflow** :
1. **Dupliquer** : Copier le code de `EngineExports.cs` vers le nouveau module
2. **Adapter** : Adapter le code au pattern du module (namespace, structure)
3. **Tester** : Exécuter le workflow build -> publish -> run
4. **Valider** : Vérifier que tout fonctionne correctement
5. **Supprimer** : Retirer le code de `EngineExports.cs` et mettre à jour les appels
6. **Re-tester** : Valider que la migration est complète

### 6. Graphe de Dépendances Initial

**Décision** : Créer un graphe de dépendances **basique maintenant**, puis l'enrichir progressivement.

**Justification** :
- Donne une structure de base claire
- Facilite la compréhension des dépendances dès le début
- Peut être enrichi au fur et à mesure sans restructuration majeure
- Évite les dépendances circulaires

**Actions** :
1. Créer `docs/dependency-graph.md` avec une structure basique
2. Identifier les dépendances connues (ex: Scene dépend de RenderAttributes, Material, Texture)
3. Organiser en niveaux (Niveau 0 = Core, Niveau 1 = Base, etc.)
4. Enrichir le graphe à chaque nouvelle dépendance identifiée

## Ordre d'Exécution

### Phase 0 - Préparation (À faire en premier)

1. **Créer HandleManager centralisé** ⚠️ **PRIORITÉ ABSOLUE** :
   - **CRITIQUE** : HandleManager est la base de toute l'émulation. Sans lui, les BindingPtr ne fonctionnent pas correctement.
   - Créer `src/Sbox.Engine.Emulation/Common/HandleManager.cs`
   - Migrer depuis `Physics/HandleManager.cs`
   - Supprimer `AudioHandleManager` de `EngineExports.cs`
   - Mettre à jour tous les imports
   - **Vérifier** : Tous les modules utilisent HandleManager pour BindingPtr (pas de compteurs simples)

2. **Créer structure de tests** :
   - Créer `tests/Sbox.Engine.Emulation.Tests/`
   - Créer le fichier `.csproj` de test
   - Configurer les références

3. **Créer graphe de dépendances initial** :
   - Créer `docs/dependency-graph.md`
   - Documenter les dépendances connues
   - Organiser en niveaux

4. **Catégoriser les fonctions "Other"** :
   - Analyser les 1443 fonctions
   - Identifier les préfixes et créer les modules correspondants
   - Mettre à jour le plan avec les nouvelles catégories

### Phase 1 - Refactorisation (Prioritaire)

1. Implémenter CCameraRenderer (nouveau, prioritaire - bug actuel)
   - Créer `Camera/` lors de l'implémentation
   - Utiliser `Common/HandleManager`

2. Extraire les modules un par un (commencer par les plus simples)
   - Créer chaque dossier `{Scope}/` au moment de l'implémentation
   - Dupliquer le code depuis `EngineExports.cs`
   - Adapter au pattern du module
   - Tester avec build -> publish -> run
   - Supprimer le code de `EngineExports.cs` après validation

3. Refactoriser EngineExports.cs
   - Garder uniquement `IGenEngine()` et les appels aux `Init()`
   - Supprimer progressivement le code migré

4. Mettre à jour les règles Cursor
   - Documenter la nouvelle architecture
   - Mettre à jour le graphe de dépendances

### Phase 2+ - Implémentation des fonctions manquantes

- Implémenter les fonctions par ordre de priorité (selon les besoins du moteur)
- Suivre le même pattern modulaire
- Tester après chaque module
- Enrichir le graphe de dépendances à chaque nouvelle dépendance

## Notes Importantes

- **Interop.Engine.cs - SOURCE DE VÉRITÉ** : ⚠️ **CRITIQUE** - **TOUJOURS** vérifier `engine/Sandbox.Engine/Interop.Engine.cs` pour obtenir les signatures exactes, les types de retour, et les indices des fonctions natives. Ce fichier est la source de vérité pour toutes les fonctions natives. Ne jamais deviner ou supposer les signatures - toujours les copier exactement depuis `Interop.Engine.cs`.
- **Indices** : **TOUJOURS** récupérer depuis `engine/Sandbox.Engine/Interop.Engine.cs` en cherchant `nativeFunctions[index]` ou `__N.FunctionName = ... nativeFunctions[index]`
- **NE JAMAIS** calculer depuis `engine.Generated.cs` (ligne - 13) - utiliser directement les indices de `Interop.Engine.cs`
- **Signatures exactes** : ⚠️ **OBLIGATOIRE** - Copier les signatures exactes depuis `Interop.Engine.cs` ligne `__N.FunctionName = (delegate* unmanaged<...>)`. Ne jamais modifier les types de retour ou les paramètres. Si une fonction retourne `IntPtr` dans `Interop.Engine.cs`, elle doit retourner `IntPtr` dans l'implémentation, pas `void*` ou autre chose.
- **Types de retour** : Vérifier le type exact dans `Interop.Engine.cs`. Par exemple, `g_pRsrcCmplrSyst_GenerateResourceBytes` retourne `IntPtr` qui est un `CUtlBuffer`, pas un simple pointeur mémoire. `g_pRsrcSystm_LoadResourceInManifest` retourne `IntPtr` qui est un `HResourceManifest`, pas un simple handle.
- **Classes distinctes** : Si `Interop.Engine.cs` montre deux classes distinctes (ex: `IResourceCompilerSystem` et `NativeEngine.g_pResourceSystem`), créer deux modules séparés. Ne pas mélanger les fonctions de classes différentes dans un même module.
- **HandleManager** : ⚠️ **CRITIQUE** - Utiliser **TOUJOURS** `Common/HandleManager.cs` pour gérer tous les objets émulés (centralisé, créé en Phase 0). Le BindingPtr doit être un handle HandleManager, pas un simple compteur. Voir section "HandleManager Centralisé - IMPORTANCE CRITIQUE" pour les détails.
- **Tests** : Suivre le workflow build -> publish -> run après chaque module
- **Compatibilité** : Maintenir la compatibilité avec le code managé existant
- **Implémentation des fonctions** : ⚠️ **RÈGLE ABSOLUE** - **TOUJOURS** implémenter les fonctions de manière fonctionnelle. **JAMAIS** utiliser `return default;`. **JAMAIS** utiliser de placeholders (valeurs par défaut comme `return 0;`, `return IntPtr.Zero;`, `return false;`, etc.) car ils masquent les problèmes et empêchent le traçage au runtime. **TOUJOURS** utiliser `throw new NotImplementedException("FunctionName is not yet implemented in the linux emulation layer")` avec un message explicite pour permettre le traçage au runtime. Les stubs qui retournent des valeurs par défaut sont interdits car ils causent des crashes silencieux et rendent le débogage impossible.
- **Priorité** : Implémenter d'abord les fonctions utilisées dans le code managé (Graphics, Material, Scene, etc.)
- **Migration** : Dupliquer le code depuis `EngineExports.cs` vers les modules, tester, puis supprimer l'ancien code
- **Dossiers** : Créer les dossiers `{Scope}/` uniquement lors de l'implémentation du module correspondant

## Comment Trouver les Indices

Pour chaque fonction à implémenter :

1. Chercher dans `Interop.Engine.cs` : `grep "FunctionName.*nativeFunctions\[" engine/Sandbox.Engine/Interop.Engine.cs`
2. Lire la ligne pour obtenir l'index exact
3. Utiliser cet index dans `Init(void** native)` : `native[index] = (void*)(delegate* unmanaged<...>)&FunctionName;`

Exemple :
```bash
grep "CCameraRenderer_Create.*nativeFunctions\[" engine/Sandbox.Engine/Interop.Engine.cs
# Résultat : ligne 14822 avec index 75
```
