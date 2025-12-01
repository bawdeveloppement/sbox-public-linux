using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using Silk.NET.Core.Native;

namespace Sbox.Engine.Emulation.Generated
{
    public static unsafe partial class Exports
    {
	public static unsafe void FillNativeFunctionsEngine(void** managedFunctions, void** nativeFunctions, int* structSizes)
 	{
 		var i = 0;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged<IntPtr, void>)&Sbox.Engine.Emulation.EngineExports.DebugError;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CnmtnGrpBldr_DeleteThis;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&CnmtnGrpBldr_Create;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CnmtnGrpBldr_AddAnimation;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void*, int, void* >)&CnmtnGrpBldr_AddFrame;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void*, void* >)&CnmtnGrpBldr_SetName;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, float, void* >)&CnmtnGrpBldr_SetFrameRate;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int, void* >)&CnmtnGrpBldr_SetLooping;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int, void* >)&CnmtnGrpBldr_SetDelta;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int, void* >)&CnmtnGrpBldr_SetDisableInterpolation;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CAttachment_GetInfluenceName;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CAttachment_GetInfluenceOffset;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CAttachment_GetInfluenceRotation;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&_Get__CAttachment_m_name;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*, void*>)&_Set__CAttachment_m_name;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, byte>)&_Get__CAttachment_m_nInfluences;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, byte, void*>)&_Set__CAttachment_m_nInfluences;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__CAttachment_m_bIgnoreRotation;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__CAttachment_m_bIgnoreRotation;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void* >)&CAudioMixBuffer_Create;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, void* >)&CAudioMixBuffer_Dispose;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, void* >)&CAudioMixBuffer_GetDataPointer;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, void* >)&CAudioMixBuffer_Silence;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, float >)&CAudioMixBuffer_AbsLevel;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, float >)&CAudioMixBuffer_AvergeLevel;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, float, float, void* >)&CAudioMixBuffer_Ramp;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, void*, void* >)&CAudioMixBuffer_CopyFrom;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, void*, float, void* >)&CAudioMixBuffer_Mix;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, void*, float, float, void* >)&CAudioMixBuffer_MixRamp;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< int, void* >)&CdMxDvcBffrs_Create;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, void* >)&CdMxDvcBffrs_Destroy;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, int, void* >)&CdMxDvcBffrs_GetBuffer;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, void* >)&CAudioMixer_Dispose;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, int >)&CAudioMixer_GetSamplePosition;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, int >)&CAudioMixer_ShouldContinueMixing;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CAudioMixer_SetSamplePosition;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, uint, void* >)&CAudioMixer_SetSampleEnd;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, int, void* >)&CAudioMixer_DelayOrSkipSamples;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CAudioMixer_IsReadyToMix;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, int >)&CAudioMixer_GetPositionForSave;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CAudioMixer_SetPositionFromSaved;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CAudioMixer_UpdateMixerState;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CAudioMixer_GetIndexState;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, void* >)&CAudioMixer_GetSfxTable;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, int >)&CAudioMixer_GetSampleCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, int >)&CAudioMixer_GetChannelCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, float, int >)&CAudioMixer_SetTimeScale;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, int, void* >)&CAudioMixer_EnableLooping;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void*, void* >)&CAudioMixer_ReadToBuffer;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CAudioProcessor_Dispose;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, int, void* >)&CAudioProcessor_Process;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, float, int >)&CAudioProcessor_SetControlParameter;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, int >)&CAudioProcessor_SetNameParameter;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int, void* >)&CAudioProcessor_CreateDelay;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int, void* >)&CAudioProcessor_CreatePitchShift;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int, uint, int >)&CdStrmMngd_Create;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CdStrmMngd_Destroy;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, uint, uint, void* >)&CdStrmMngd_WriteAudioData;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint >)&CdStrmMngd_QueuedSampleCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint >)&CdStrmMngd_MaxWriteSampleCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint >)&CdStrmMngd_LatencySamplesCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CdStrmMngd_Pause;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CdStrmMngd_Resume;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CdStrmMngd_GetName;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CdStrmMngd_GetSfxTable;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void* >)&CBinauralEffect_Create;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, void* >)&CBinauralEffect_Dispose;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, void*, float, void*, void*, void* >)&CBinauralEffect_Apply;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CBldrMtrlGrp_AddMaterial;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&_Get__CBldrMtrlGrp_m_name;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*, void*>)&_Set__CBldrMtrlGrp_m_name;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CBldrMtrlGrprry_DeleteThis;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int, void* >)&CBldrMtrlGrprry_Create;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CBldrMtrlGrprry_Get;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CCameraRenderer_DeleteThis;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CCameraRenderer_Create;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CCameraRenderer_ClearSceneWorlds;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CCameraRenderer_AddSceneWorld;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CCameraRenderer_SetRenderAttributes;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CCameraRenderer_Render;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&CCameraRenderer_RenderToTexture;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, void* >)&CCameraRenderer_RenderToCubeTexture;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, int, int, void* >)&CCameraRenderer_RenderToBitmap;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int, int, int, void* >)&CCameraRenderer_RenderStereo;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int, void* >)&CCameraRenderer_SubmitStereo;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int, void* >)&CCameraRenderer_BlitStereo;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CCameraRenderer_ClearRenderTags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CCameraRenderer_ClearExcludeTags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, void* >)&CCameraRenderer_AddRenderTag;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, void* >)&CCameraRenderer_AddExcludeTag;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__CCameraRenderer_ViewUniqueId;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__CCameraRenderer_ViewUniqueId;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&_Get__CCameraRenderer_CameraPosition;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*, void*>)&_Set__CCameraRenderer_CameraPosition;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&_Get__CCameraRenderer_CameraRotation;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*, void*>)&_Set__CCameraRenderer_CameraRotation;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float>)&_Get__CCameraRenderer_FieldOfView;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float, void*>)&_Set__CCameraRenderer_FieldOfView;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float>)&_Get__CCameraRenderer_ZNear;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float, void*>)&_Set__CCameraRenderer_ZNear;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float>)&_Get__CCameraRenderer_ZFar;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float, void*>)&_Set__CCameraRenderer_ZFar;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&_Get__CCameraRenderer_Rect;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*, void*>)&_Set__CCameraRenderer_Rect;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&_Get__CCameraRenderer_Viewport;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*, void*>)&_Set__CCameraRenderer_Viewport;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&_Get__CCameraRenderer_ClipSpaceBounds;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*, void*>)&_Set__CCameraRenderer_ClipSpaceBounds;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__CCameraRenderer_EnablePostprocessing;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__CCameraRenderer_EnablePostprocessing;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__CCameraRenderer_EnableEngineOverlays;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__CCameraRenderer_EnableEngineOverlays;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__CCameraRenderer_Ortho;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__CCameraRenderer_Ortho;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float>)&_Get__CCameraRenderer_OrthoSize;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float, void*>)&_Set__CCameraRenderer_OrthoSize;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__CCameraRenderer_NeedTonemapRenderer;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__CCameraRenderer_NeedTonemapRenderer;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, long>)&_Get__CCameraRenderer_SceneViewFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, long, void*>)&_Set__CCameraRenderer_SceneViewFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__CCameraRenderer_IsRenderingStereo;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__CCameraRenderer_IsRenderingStereo;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&_Get__CCameraRenderer_MiddleEyePosition;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*, void*>)&_Set__CCameraRenderer_MiddleEyePosition;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&_Get__CCameraRenderer_MiddleEyeRotation;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*, void*>)&_Set__CCameraRenderer_MiddleEyeRotation;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&_Get__CCameraRenderer_OverrideProjection;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*, void*>)&_Set__CCameraRenderer_OverrideProjection;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__CCameraRenderer_HasOverrideProjection;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__CCameraRenderer_HasOverrideProjection;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__CCameraRenderer_FlipX;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__CCameraRenderer_FlipX;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__CCameraRenderer_FlipY;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__CCameraRenderer_FlipY;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&From_CSceneObject_To_CDecalSceneObject;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&To_CSceneObject_From_CDecalSceneObject;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, long, void* >)&CDclScnbjct_ChangeFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void* >)&CDclScnbjct_SetFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, int >)&CDclScnbjct_HasFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&CDclScnbjct_GetFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&CDclScnbjct_GetOriginalFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void* >)&CDclScnbjct_ClearFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&CDclScnbjct_SetCullDistance;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CDclScnbjct_EnableLightingCache;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, void* >)&CDclScnbjct_SetLightingOrigin;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CDclScnbjct_GetLightingOrigin;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CDclScnbjct_HasLightingOrigin;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CDclScnbjct_SetTintRGBA;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CDclScnbjct_GetTintRGBA;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&CDclScnbjct_SetAlphaFade;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CDclScnbjct_GetAlphaFade;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CDclScnbjct_SetMaterialOverrideForMeshInstances;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CDclScnbjct_ClearMaterialOverrideList;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, int, void* >)&CDclScnbjct_SetMaterialOverride;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CDclScnbjct_IsLoaded;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CDclScnbjct_IsRenderingEnabled;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CDclScnbjct_SetLoaded;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CDclScnbjct_ClearLoaded;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CDclScnbjct_DisableRendering;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CDclScnbjct_EnableRendering;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CDclScnbjct_SetRenderingEnabled;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CDclScnbjct_GetBoundingSphereRadius;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CDclScnbjct_SetTransform;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CDclScnbjct_GetCTransform;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CDclScnbjct_SetBounds;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CDclScnbjct_GetBounds;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CDclScnbjct_SetBoundsInfinite;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CDclScnbjct_GetParent;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, uint, void* >)&CDclScnbjct_AddChildObject;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CDclScnbjct_RemoveChild;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CDclScnbjct_GetAttributesPtrForModify;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong, void* >)&CDclScnbjct_EnableMeshGroups;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong, void* >)&CDclScnbjct_DisableMeshGroups;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong, void* >)&CDclScnbjct_ResetMeshGroups;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong >)&CDclScnbjct_GetCurrentMeshGroupMask;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CDclScnbjct_GetWorld;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CDclScnbjct_SetLOD;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CDclScnbjct_DisableLOD;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong >)&CDclScnbjct_GetCurrentLODGroupMask;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CDclScnbjct_GetCurrentLODLevel;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CDclScnbjct_GetModelHandle;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CDclScnbjct_SetMaterialGroup;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, void* >)&CDclScnbjct_SetBodyGroup;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CDclScnbjct_SetBatchable;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CDclScnbjct_IsNotBatchable;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CDclScnbjct_SetUniqueBatchGroup;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, void* >)&CDclScnbjct_RemoveTag;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CDclScnbjct_RemoveAllTags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CDclScnbjct_GetTagCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, uint >)&CDclScnbjct_GetTagAt;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, void* >)&CDclScnbjct_AddTag;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, int >)&CDclScnbjct_HasTag;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CDclScnbjct_SetForceLayerID;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CDclScnbjct_SetLayerMatchID;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CDclScnbjct_UpdateFlagsBasedOnMaterial;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void*, void* >)&CDclScnbjct_SetMaterialOverrideByIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&_Get__CDclScnbjct_m_hColor;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*, void*>)&_Set__CDclScnbjct_m_hColor;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&_Get__CDclScnbjct_m_hNormal;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*, void*>)&_Set__CDclScnbjct_m_hNormal;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&_Get__CDclScnbjct_m_hRMO;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*, void*>)&_Set__CDclScnbjct_m_hRMO;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__CDclScnbjct_m_nSortOrder;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__CDclScnbjct_m_nSortOrder;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__CDclScnbjct_m_nExclusionBitMask;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__CDclScnbjct_m_nExclusionBitMask;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&_Get__CDclScnbjct_m_vColorTint;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*, void*>)&_Set__CDclScnbjct_m_vColorTint;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float>)&_Get__CDclScnbjct_m_flAttenuationAngle;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float, void*>)&_Set__CDclScnbjct_m_flAttenuationAngle;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float>)&_Get__CDclScnbjct_m_flColorMix;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float, void*>)&_Set__CDclScnbjct_m_flColorMix;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&_Get__CDclScnbjct_m_hEmission;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*, void*>)&_Set__CDclScnbjct_m_hEmission;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float>)&_Get__CDclScnbjct_m_flEmissionEnergy;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float, void*>)&_Set__CDclScnbjct_m_flEmissionEnergy;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__CDclScnbjct_m_nSequenceIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__CDclScnbjct_m_nSequenceIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&_Get__CDclScnbjct_m_hHeight;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*, void*>)&_Set__CDclScnbjct_m_hHeight;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float>)&_Get__CDclScnbjct_m_flParallaxStrength;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float, void*>)&_Set__CDclScnbjct_m_flParallaxStrength;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__CDclScnbjct_m_nSamplerIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__CDclScnbjct_m_nSamplerIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&From_CSceneObject_To_CDynamicSceneObject;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&To_CSceneObject_From_CDynamicSceneObject;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CDynmcScnbjct_Create;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, long, int, void* >)&CDynmcScnbjct_Begin;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, void* >)&CDynmcScnbjct_End;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, void*, void* >)&CDynmcScnbjct_AddVertex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, void*, int, void* >)&CDynmcScnbjct_AddVertexRange;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, void* >)&CDynmcScnbjct_Reset;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, long, void* >)&CDynmcScnbjct_ChangeFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void* >)&CDynmcScnbjct_SetFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, int >)&CDynmcScnbjct_HasFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&CDynmcScnbjct_GetFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&CDynmcScnbjct_GetOriginalFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void* >)&CDynmcScnbjct_ClearFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&CDynmcScnbjct_SetCullDistance;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CDynmcScnbjct_EnableLightingCache;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, void* >)&CDynmcScnbjct_SetLightingOrigin;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CDynmcScnbjct_GetLightingOrigin;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CDynmcScnbjct_HasLightingOrigin;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CDynmcScnbjct_SetTintRGBA;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CDynmcScnbjct_GetTintRGBA;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&CDynmcScnbjct_SetAlphaFade;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CDynmcScnbjct_GetAlphaFade;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CDynmcScnbjct_SetMaterialOverrideForMeshInstances;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CDynmcScnbjct_ClearMaterialOverrideList;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, int, void* >)&CDynmcScnbjct_SetMaterialOverride;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CDynmcScnbjct_IsLoaded;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CDynmcScnbjct_IsRenderingEnabled;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CDynmcScnbjct_SetLoaded;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CDynmcScnbjct_ClearLoaded;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CDynmcScnbjct_DisableRendering;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CDynmcScnbjct_EnableRendering;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CDynmcScnbjct_SetRenderingEnabled;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CDynmcScnbjct_GetBoundingSphereRadius;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CDynmcScnbjct_SetTransform;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CDynmcScnbjct_GetCTransform;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CDynmcScnbjct_SetBounds;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CDynmcScnbjct_GetBounds;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CDynmcScnbjct_SetBoundsInfinite;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CDynmcScnbjct_GetParent;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, uint, void* >)&CDynmcScnbjct_AddChildObject;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CDynmcScnbjct_RemoveChild;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CDynmcScnbjct_GetAttributesPtrForModify;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong, void* >)&CDynmcScnbjct_EnableMeshGroups;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong, void* >)&CDynmcScnbjct_DisableMeshGroups;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong, void* >)&CDynmcScnbjct_ResetMeshGroups;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong >)&CDynmcScnbjct_GetCurrentMeshGroupMask;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CDynmcScnbjct_GetWorld;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CDynmcScnbjct_SetLOD;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CDynmcScnbjct_DisableLOD;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong >)&CDynmcScnbjct_GetCurrentLODGroupMask;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CDynmcScnbjct_GetCurrentLODLevel;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CDynmcScnbjct_GetModelHandle;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CDynmcScnbjct_SetMaterialGroup;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, void* >)&CDynmcScnbjct_SetBodyGroup;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CDynmcScnbjct_SetBatchable;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CDynmcScnbjct_IsNotBatchable;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CDynmcScnbjct_SetUniqueBatchGroup;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, void* >)&CDynmcScnbjct_RemoveTag;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CDynmcScnbjct_RemoveAllTags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CDynmcScnbjct_GetTagCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, uint >)&CDynmcScnbjct_GetTagAt;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, void* >)&CDynmcScnbjct_AddTag;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, int >)&CDynmcScnbjct_HasTag;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CDynmcScnbjct_SetForceLayerID;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CDynmcScnbjct_SetLayerMatchID;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CDynmcScnbjct_UpdateFlagsBasedOnMaterial;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void*, void* >)&CDynmcScnbjct_SetMaterialOverrideByIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&_Get__CDynmcScnbjct_Material;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*, void*>)&_Set__CDynmcScnbjct_Material;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&CEntityKeyValues_GetValueString;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CEntityKeyValues_GetKeyCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, uint >)&CEntityKeyValues_GetKey;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, void*, void* >)&CEntityKeyValues_GetValueString_1;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&From_CSceneLightObject_To_CEnvMapSceneObject;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&To_CSceneLightObject_From_CEnvMapSceneObject;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&From_CSceneObject_To_CEnvMapSceneObject;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&To_CSceneObject_From_CEnvMapSceneObject;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CnvMpScnbjct_CalculateRadianceSH;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CnvMpScnbjct_CalculateRadianceSH_1;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CnvMpScnbjct_CalculateNormalizationSH;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CnvMpScnbjct_CalculateBounds;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CnvMpScnbjct_SetWorldPosition;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CnvMpScnbjct_GetWorldPosition;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CnvMpScnbjct_SetWorldDirection;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CnvMpScnbjct_GetWorldDirection;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CnvMpScnbjct_SetColor;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CnvMpScnbjct_SetBounceColor;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CnvMpScnbjct_GetColor;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&CnvMpScnbjct_SetRadius;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CnvMpScnbjct_GetRadius;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&CnvMpScnbjct_SetTheta;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CnvMpScnbjct_GetTheta;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&CnvMpScnbjct_SetPhi;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CnvMpScnbjct_GetPhi;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&CnvMpScnbjct_SetFallOff;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CnvMpScnbjct_GetFallOff;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CnvMpScnbjct_GetShadowTextureResolution;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CnvMpScnbjct_SetShadowTextureResolution;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CnvMpScnbjct_GetShadows;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CnvMpScnbjct_SetShadows;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&CnvMpScnbjct_SetConstantAttn;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CnvMpScnbjct_GetConstantAttn;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&CnvMpScnbjct_SetLinearAttn;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CnvMpScnbjct_GetLinearAttn;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&CnvMpScnbjct_SetQuadraticAttn;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CnvMpScnbjct_GetQuadraticAttn;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CnvMpScnbjct_SetLightCookie;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CnvMpScnbjct_GetLightCookie;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CnvMpScnbjct_GetShadowCascades;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CnvMpScnbjct_SetShadowCascades;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CnvMpScnbjct_GetCascadeDistanceScale;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&CnvMpScnbjct_SetCascadeDistanceScale;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CnvMpScnbjct_GetFogContributionStength;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&CnvMpScnbjct_SetFogContributionStength;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CnvMpScnbjct_GetFogLightingMode;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CnvMpScnbjct_SetFogLightingMode;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CnvMpScnbjct_SetBakeLightIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&CnvMpScnbjct_SetBakeLightIndexScale;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CnvMpScnbjct_SetUsesIndexedBakedLighting;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CnvMpScnbjct_SetRenderDiffuse;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CnvMpScnbjct_SetRenderSpecular;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CnvMpScnbjct_SetRenderTransmissive;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&CnvMpScnbjct_SetLightSourceSize0;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&CnvMpScnbjct_SetLightSourceSize1;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CnvMpScnbjct_SetShadowTextureWidth;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CnvMpScnbjct_SetShadowTextureHeight;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CnvMpScnbjct_GetShadowTextureWidth;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CnvMpScnbjct_GetShadowTextureHeight;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint >)&CnvMpScnbjct_GetLightFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, void* >)&CnvMpScnbjct_SetLightFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&CnvMpScnbjct_GetLightShape;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void* >)&CnvMpScnbjct_SetLightShape;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&CnvMpScnbjct_SetLightSourceDim0;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&CnvMpScnbjct_SetLightSourceDim1;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, long>)&_Get__CnvMpScnbjct_m_nProjectionMode;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, long, void*>)&_Set__CnvMpScnbjct_m_nProjectionMode;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&_Get__CnvMpScnbjct_m_vBoxProjectMins;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*, void*>)&_Set__CnvMpScnbjct_m_vBoxProjectMins;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&_Get__CnvMpScnbjct_m_vBoxProjectMaxs;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*, void*>)&_Set__CnvMpScnbjct_m_vBoxProjectMaxs;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&_Get__CnvMpScnbjct_m_vColor;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*, void*>)&_Set__CnvMpScnbjct_m_vColor;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__CnvMpScnbjct_m_nRenderPriority;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__CnvMpScnbjct_m_nRenderPriority;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&_Get__CnvMpScnbjct_m_hEnvMapTexture;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*, void*>)&_Set__CnvMpScnbjct_m_hEnvMapTexture;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&_Get__CnvMpScnbjct_m_vNormalizationSH;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*, void*>)&_Set__CnvMpScnbjct_m_vNormalizationSH;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float>)&_Get__CnvMpScnbjct_m_flFeathering;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float, void*>)&_Set__CnvMpScnbjct_m_flFeathering;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&CFrustum_Create;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CFrustum_Delete;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, float, float, float, float, float, float, float, float, void* >)&CFrustum_InitCamera;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, float, float, float, float, void* >)&CFrustum_InitCamera_1;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, float, float, float, float, void* >)&CFrustum_InitOrthoCamera;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, float, void* >)&CFrustum_SetCameraWidthHeight;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CFrustum_GetProj;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CFrustum_GetInvProj;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CFrustum_GetReverseZProj;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CFrustum_GetInvReverseZProj;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CFrustum_GetViewProj;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CFrustum_GetInvViewProj;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int >)&CFrustum_BoundingVolumeIntersectsFrustum;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, int >)&CFrustum_ScreenTransform;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&CFrustum_WorldToView;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&CFrustum_ViewToWorld;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CFrustum_GetCameraPosition;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CFrustum_GetCameraAngles;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CFrustum_GetCameraNearPlane;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CFrustum_GetCameraFarPlane;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CFrustum_GetCameraFOV;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CFrustum_GetCameraAspect;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void*, void*, void* >)&CFrustum_GetPlane;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CHitBox_GetTag;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&_Get__CHitBox_m_vMinBounds;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*, void*>)&_Set__CHitBox_m_vMinBounds;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&_Get__CHitBox_m_vMaxBounds;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*, void*>)&_Set__CHitBox_m_vMaxBounds;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&_Get__CHitBox_m_name;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*, void*>)&_Set__CHitBox_m_name;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&_Get__CHitBox_m_sSurfaceProperty;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*, void*>)&_Set__CHitBox_m_sSurfaceProperty;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&_Get__CHitBox_m_sBoneName;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*, void*>)&_Set__CHitBox_m_sBoneName;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float>)&_Get__CHitBox_m_flShapeRadius;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float, void*>)&_Set__CHitBox_m_flShapeRadius;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__CHitBox_m_nBoneNameHash;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__CHitBox_m_nBoneNameHash;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&_Get__CHitBox_m_cRenderColor;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*, void*>)&_Set__CHitBox_m_cRenderColor;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, ushort>)&_Get__CHitBox_m_nHitBoxIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, ushort, void*>)&_Set__CHitBox_m_nHitBoxIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, byte>)&_Get__CHitBox_m_nShapeType;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, byte, void*>)&_Set__CHitBox_m_nShapeType;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__CHitBox_m_bForcedTransform;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__CHitBox_m_bForcedTransform;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__CHitBox_m_bTranslationOnly;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__CHitBox_m_bTranslationOnly;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__CHitBox_m_bVisible;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__CHitBox_m_bVisible;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__CHitBox_m_bSelected;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__CHitBox_m_bSelected;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CHitBoxSet_numhitboxes;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CHitBoxSet_pHitbox;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&_Get__CHitBoxSet_m_name;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*, void*>)&_Set__CHitBoxSet_m_name;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&_Get__CHitBoxSet_m_SourceFilename;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*, void*>)&_Set__CHitBoxSet_m_SourceFilename;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&From_CSceneObject_To_CManagedSceneObject;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&To_CSceneObject_From_CManagedSceneObject;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CMngdScnbjct_Create;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, long, void* >)&CMngdScnbjct_ChangeFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void* >)&CMngdScnbjct_SetFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, int >)&CMngdScnbjct_HasFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&CMngdScnbjct_GetFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&CMngdScnbjct_GetOriginalFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void* >)&CMngdScnbjct_ClearFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&CMngdScnbjct_SetCullDistance;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CMngdScnbjct_EnableLightingCache;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, void* >)&CMngdScnbjct_SetLightingOrigin;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CMngdScnbjct_GetLightingOrigin;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CMngdScnbjct_HasLightingOrigin;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CMngdScnbjct_SetTintRGBA;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CMngdScnbjct_GetTintRGBA;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&CMngdScnbjct_SetAlphaFade;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CMngdScnbjct_GetAlphaFade;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CMngdScnbjct_SetMaterialOverrideForMeshInstances;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CMngdScnbjct_ClearMaterialOverrideList;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, int, void* >)&CMngdScnbjct_SetMaterialOverride;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CMngdScnbjct_IsLoaded;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CMngdScnbjct_IsRenderingEnabled;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CMngdScnbjct_SetLoaded;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CMngdScnbjct_ClearLoaded;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CMngdScnbjct_DisableRendering;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CMngdScnbjct_EnableRendering;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CMngdScnbjct_SetRenderingEnabled;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CMngdScnbjct_GetBoundingSphereRadius;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CMngdScnbjct_SetTransform;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CMngdScnbjct_GetCTransform;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CMngdScnbjct_SetBounds;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CMngdScnbjct_GetBounds;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CMngdScnbjct_SetBoundsInfinite;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CMngdScnbjct_GetParent;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, uint, void* >)&CMngdScnbjct_AddChildObject;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CMngdScnbjct_RemoveChild;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CMngdScnbjct_GetAttributesPtrForModify;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong, void* >)&CMngdScnbjct_EnableMeshGroups;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong, void* >)&CMngdScnbjct_DisableMeshGroups;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong, void* >)&CMngdScnbjct_ResetMeshGroups;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong >)&CMngdScnbjct_GetCurrentMeshGroupMask;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CMngdScnbjct_GetWorld;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CMngdScnbjct_SetLOD;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CMngdScnbjct_DisableLOD;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong >)&CMngdScnbjct_GetCurrentLODGroupMask;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CMngdScnbjct_GetCurrentLODLevel;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CMngdScnbjct_GetModelHandle;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CMngdScnbjct_SetMaterialGroup;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, void* >)&CMngdScnbjct_SetBodyGroup;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CMngdScnbjct_SetBatchable;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CMngdScnbjct_IsNotBatchable;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CMngdScnbjct_SetUniqueBatchGroup;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, void* >)&CMngdScnbjct_RemoveTag;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CMngdScnbjct_RemoveAllTags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CMngdScnbjct_GetTagCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, uint >)&CMngdScnbjct_GetTagAt;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, void* >)&CMngdScnbjct_AddTag;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, int >)&CMngdScnbjct_HasTag;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CMngdScnbjct_SetForceLayerID;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CMngdScnbjct_SetLayerMatchID;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CMngdScnbjct_UpdateFlagsBasedOnMaterial;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void*, void* >)&CMngdScnbjct_SetMaterialOverrideByIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__CMngdScnbjct_ExecuteOnMainThread;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__CMngdScnbjct_ExecuteOnMainThread;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CMtrlSystm2ppSys_Create;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CMtrlSystm2ppSys_Destroy;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CMtrlSystm2ppSys_Init;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CMtrlSystm2ppSys_InitWithoutMaterialSystem;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CMtrlSystm2ppSys_InitFinishSetupMaterialSystem;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CMtrlSystm2ppSys_GetAppWindow;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CMtrlSystm2ppSys_GetAppWindowSwapChain;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CMtrlSystm2ppSys_SetAppWindowTitle;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CMtrlSystm2ppSys_SetAppWindowIcon;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CMtrlSystm2ppSys_SetInitialAppWindowImage;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CMtrlSystm2ppSys_SetAppWindowDiscardMouseFocusClick;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CMtrlSystm2ppSys_DrawInitialWindowImage;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CMtrlSystm2ppSys_SuppressStartupManifestLoad;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CMtrlSystm2ppSys_SetModuleSearchPath;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CMtrlSystm2ppSys_SetModGameSubdir;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, void* >)&CMtrlSystm2ppSys_SetModFromFileName;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CMtrlSystm2ppSys_DisableModPathCheck;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CMtrlSystm2ppSys_SetDefaultRenderSystemOption;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CMtrlSystm2ppSys_SetInitializationPhase;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CMtrlSystm2ppSys_GetInitializationPhase;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CMtrlSystm2ppSys_PreShutdown;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, int >)&CMtrlSystm2ppSys_InitSDL;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CMtrlSystm2ppSys_ShutdownSDL;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CMtrlSystm2ppSys_IsConsoleApp;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CMtrlSystm2ppSys_IsGameApp;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CMtrlSystm2ppSys_SetDedicatedServer;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CMtrlSystm2ppSys_IsDedicatedServer;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CMtrlSystm2ppSys_GetContentPath;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CMtrlSystm2ppSys_GetModGameSubdir;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CMtrlSystm2ppSys_SetInToolsMode;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CMtrlSystm2ppSys_IsInToolsMode;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CMtrlSystm2ppSys_IsInDeveloperMode;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CMtrlSystm2ppSys_IsInVRMode;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, int, int, int, int, int, void* >)&CMtrlSystm2ppSys_CreateAppWindow;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CMtrlSystm2ppSys_SuppressCOMInitialization;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CMtrlSystm2ppSys_IsRunningOnCustomerMachine;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&CMtrlSystm2ppSys_AddSystem;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CMtrlSystm2ppSys_SetInTestMode;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CMtrlSystm2ppSys_IsInTestMode;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CMtrlSystm2ppSys_SetInStandaloneApp;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CMtrlSystm2ppSys_IsStandaloneApp;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, void* >)&CMtrlSystm2ppSys_SetSteamAppId;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint >)&CMtrlSystm2ppSys_GetSteamAppId;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CModel_DestroyStrongHandle;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, int >)&CModel_IsStrongHandleValid;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, int >)&CModel_IsError;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, int >)&CModel_IsStrongHandleLoaded;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, void* >)&CModel_CopyStrongHandle;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, void* >)&CModel_GetBindingPtr;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CModel_GetModelName;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CModel_IsTranslucent;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CModel_IsTranslucentTwoPass;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CModel_HasPhysics;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CModel_FindModelSubKey;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, int >)&CModel_GetAttachmentTransform;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CModel_GetAttachmentNameFromIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int >)&CModel_GetBodyPartForName;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CModel_GetBodyPartName;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CModel_GetNumBodyParts;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int >)&CModel_GetNumBodyPartMeshes;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, ulong >)&CModel_GetBodyPartMask;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int, ulong >)&CModel_GetBodyPartMeshMask;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, ulong, int >)&CModel_FindMeshIndexForMask;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CModel_GetNumMeshGroups;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong >)&CModel_GetDefaultMeshGroupMask;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int, void* >)&CModel_GetBodyPartMeshName;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CModel_GetNumMaterialGroups;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CModel_GetMaterialGroupName;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int >)&CModel_GetMaterialGroupIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int >)&CModel_GetNumMaterialsInGroup;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int, void* >)&CModel_GetMaterialInGroup;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int >)&CModel_GetNumSceneObjects;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int, int >)&CModel_GetNumDrawCalls;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int, int, void* >)&CModel_GetMaterial;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CModel_GetNumMeshes;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CModel_GetMeshBounds;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CModel_GetPhysicsBounds;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CModel_GetModelRenderBounds;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CModel_NumBones;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int >)&CModel_FindBoneIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CModel_boneName;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int >)&CModel_boneParent;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CModel_GetBoneTransform;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CModel_bonePosParentSpace;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CModel_boneRotParentSpace;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CModel_NumFlexControllers;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CModel_GetFlexControllerName;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, float >)&CModel_GetVisemeMorph;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CModel_GetNumAnim;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CModel_GetAnimationName;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CModel_GetSequenceNames;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, int >)&CModel_HasSceneObjects;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, int >)&CModel_MeshTrace;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CModel_GetAnimationGraph;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CModel_GetPhysicsContainer;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, void* >)&CModel_FindHitboxSetByName;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, int >)&CModel_FindHitboxSetIndexByName;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int, void* >)&CModel_GetHitboxSetByIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int >)&CModel_GetBoneIndexForHitbox;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int >)&CModel_GetHitboxSetCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CModel_HasSkinnedMeshes;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CModel_HasAnimationDrivenFlexes;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, long >)&CModel_boneFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CModel_GetNumAttachments;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CModel_GetAttachment;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CModel_GetMaterialIndexCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CModel_GetMaterialByIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&ConCommand_GetName;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&ConCommand_GetHelpText;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&ConCommand_GetFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&ConCommand_Run;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&ConVar_GetName;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&ConVar_GetHelpText;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&ConVar_SetValue;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&ConVar_SetValue_1;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&ConVar_SetValue_2;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&ConVar_GetString;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&ConVar_Revert;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&ConVar_HasMin;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&ConVar_HasMax;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&ConVar_GetMinValue;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&ConVar_GetMaxValue;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&ConVar_GetDefault;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&ConVar_GetFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CPhysggrgtDt_AddRef;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CPhysggrgtDt_Release;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint >)&CPhysggrgtDt_GetChecksum;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CPhysggrgtDt_GetBoneCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CPhysggrgtDt_GetBoneName;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CPhysggrgtDt_GetPartCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, uint >)&CPhysggrgtDt_GetBoneHash;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, uint >)&CPhysggrgtDt_GetIndexHash;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CPhysggrgtDt_GetBindPose;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CPhysggrgtDt_GetPart;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CPhysggrgtDt_GetSurfaceProperties;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CPhysggrgtDt_GetSurfacePropertiesCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CPhysggrgtDt_GetCollisionAttributeCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int, void* >)&CPhysggrgtDt_GetTag;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int >)&CPhysggrgtDt_GetTagCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CPhysggrgtDt_GetJointCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CPhysggrgtDt_GetJoint;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, ushort>)&_Get__CPhysggrgtDt_m_nFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, ushort, void*>)&_Set__CPhysggrgtDt_m_nFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CPhysBodyDesc_SetBoneName;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CPhysBodyDesc_SetSurface;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CPhysBodyDesc_SetBindPose;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CPhysBodyDesc_AddSphere;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CPhysBodyDesc_AddCapsule;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, void*, float, float, int, int, int, int, void* >)&CPhysBodyDesc_AddHull;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, uint, void*, uint, void*, void* >)&CPhysBodyDesc_AddMesh;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float>)&_Get__CPhysBodyDesc_m_flMass;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float, void*>)&_Set__CPhysBodyDesc_m_flMass;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CPhysBdyDscrry_DeleteThis;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int, int, void* >)&CPhysBdyDscrry_Create;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CPhysBdyDscrry_Get;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CPhysBdyDscrry_GetJoint;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, float, float, float, float, void* >)&CPhysSrfcPrprts_UpdatePhysics;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&_Get__CPhysSrfcPrprts_m_name;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*, void*>)&_Set__CPhysSrfcPrprts_m_name;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__CPhysSrfcPrprts_m_nameHash;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__CPhysSrfcPrprts_m_nameHash;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__CPhysSrfcPrprts_m_baseNameHash;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__CPhysSrfcPrprts_m_baseNameHash;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__CPhysSrfcPrprts_m_nIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__CPhysSrfcPrprts_m_nIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__CPhysSrfcPrprts_m_nBaseIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__CPhysSrfcPrprts_m_nBaseIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__CPhysSrfcPrprts_m_AudioSurface;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__CPhysSrfcPrprts_m_AudioSurface;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__CPhysSrfcPrprts_m_bHidden;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__CPhysSrfcPrprts_m_bHidden;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&_Get__CPhysSrfcPrprts_m_description;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*, void*>)&_Set__CPhysSrfcPrprts_m_description;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CQueryResult_DeleteThis;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&CQueryResult_Create;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CQueryResult_Count;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int >)&CQueryResult_Element;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&From_IReadBufferCallback_To_CReadBufferManagedCallback;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&To_IReadBufferCallback_From_CReadBufferManagedCallback;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CRdBffrMngdCllbc_DeleteThis;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&CRdBffrMngdCllbc_Create;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CRdBffrMngdCllbc_SetManagedId;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CRdBffrMngdCllbc_GetManagedId;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CRdBffrMngdCllbc_Done;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&From_IReadTexturePixelsCallback_To_CReadTexturePixelsManagedCallback;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&To_IReadTexturePixelsCallback_From_CReadTexturePixelsManagedCallback;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CRdTxtrPxlsMngdC_DeleteThis;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&CRdTxtrPxlsMngdC_Create;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CRdTxtrPxlsMngdC_SetManagedId;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CRdTxtrPxlsMngdC_GetManagedId;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CRdTxtrPxlsMngdC_Done;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CRndrttrbts_DeleteThis;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&CRndrttrbts_Create;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, float, void* >)&CRndrttrbts_SetFloatValue;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, float, float >)&CRndrttrbts_GetFloatValue;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CRndrttrbts_DeleteFloatValue;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&CRndrttrbts_SetVector2DValue;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&CRndrttrbts_GetVector2DValue;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CRndrttrbts_DeleteVector2DValue;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&CRndrttrbts_SetVectorValue;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&CRndrttrbts_GetVectorValue;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CRndrttrbts_DeleteVectorValue;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&CRndrttrbts_SetVector4DValue;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&CRndrttrbts_GetVector4DValue;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CRndrttrbts_DeleteVector4DValue;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&CRndrttrbts_SetVMatrixValue;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&CRndrttrbts_GetVMatrixValue;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CRndrttrbts_DeleteVMatrixValue;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&CRndrttrbts_SetStringValue;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CRndrttrbts_DeleteStringValue;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, void* >)&CRndrttrbts_SetIntValue;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, int >)&CRndrttrbts_GetIntValue;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CRndrttrbts_DeleteIntValue;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, byte, void* >)&CRndrttrbts_SetComboValue;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, byte, byte >)&CRndrttrbts_GetComboValue;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CRndrttrbts_DeleteComboValue;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, void* >)&CRndrttrbts_SetBoolValue;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, int >)&CRndrttrbts_GetBoolValue;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CRndrttrbts_DeleteBoolValue;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, int, void* >)&CRndrttrbts_SetTextureValue;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&CRndrttrbts_GetTextureValue;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CRndrttrbts_DeleteTextureValue;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&CRndrttrbts_SetSamplerValue;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&CRndrttrbts_SetBufferValue;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&CRndrttrbts_SetPtrValue;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CRndrttrbts_DeletePtrValue;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, int, int, int, void* >)&CRndrttrbts_SetIntVector4DValue;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CRndrttrbts_MergeToPtr;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CRndrttrbts_IsEmpty;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int, void* >)&CRndrttrbts_Clear;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CRenderMesh_DestroyStrongHandle;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, int >)&CRenderMesh_IsStrongHandleValid;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, int >)&CRenderMesh_IsError;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, int >)&CRenderMesh_IsStrongHandleLoaded;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, void* >)&CRenderMesh_CopyStrongHandle;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, void* >)&CRenderMesh_GetBindingPtr;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&From_CSceneObject_To_CSceneAnimatableObject;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&To_CSceneObject_From_CSceneAnimatableObject;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void*, void* >)&CScnnmtblbjct_SetWorldSpaceRenderBoneTransform;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CScnnmtblbjct_GetWorldSpaceRenderBoneTransform;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnnmtblbjct_GetWorldSpaceRenderBoneTransform_1;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CScnnmtblbjct_GetWorldSpaceRenderBonePreviousTransform;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnnmtblbjct_GetWorldSpaceRenderBonePreviousTransform_1;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CScnnmtblbjct_GetLocalSpaceRenderBoneTransform;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnnmtblbjct_GetLocalSpaceRenderBoneTransform_1;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CScnnmtblbjct_GetWorldSpaceAnimationTransform;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&CScnnmtblbjct_Update;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnnmtblbjct_MergeFrom;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnnmtblbjct_SetBindPose;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnnmtblbjct_CalculateWorldSpaceBones;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnnmtblbjct_FinishUpdate;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnnmtblbjct_ResetGraphParameters;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CScnnmtblbjct_GetParentSpaceBone;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void*, void* >)&CScnnmtblbjct_SetParentSpaceBone;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnnmtblbjct_InitAnimGraph;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnnmtblbjct_SetAnimGraph;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnnmtblbjct_SetAnimGraph_1;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnnmtblbjct_GetAnimGraph;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, float, void* >)&CScnnmtblbjct_SBox_SetFlexOverride;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, float, void* >)&CScnnmtblbjct_SBox_SetFlexOverride_1;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, float >)&CScnnmtblbjct_SBox_GetFlexOverride;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, float >)&CScnnmtblbjct_SBox_GetFlexOverride_1;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnnmtblbjct_SBox_ClearFlexOverride;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnnmtblbjct_DirectPlayback_PlaySequence;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, float, float, void* >)&CScnnmtblbjct_DirectPlayback_PlaySequence_1;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnnmtblbjct_DirectPlayback_CancelSequence;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CScnnmtblbjct_DirectPlayback_GetSequenceCycle;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnnmtblbjct_DirectPlayback_GetSequence;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&CScnnmtblbjct_DirectPlayback_SetSequenceStartTime;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CScnnmtblbjct_DirectPlayback_GetSequenceDuration;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, void*, int >)&CScnnmtblbjct_SBox_GetAttachment;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CScnnmtblbjct_SetShouldUseAnimGraph;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CScnnmtblbjct_GetShouldUseAnimGraph;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnnmtblbjct_GetSequence;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnnmtblbjct_SetSequence;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CScnnmtblbjct_GetSequenceDuration;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CScnnmtblbjct_GetSequenceCycle;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&CScnnmtblbjct_SetSequenceCycle;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CScnnmtblbjct_SetSequenceLooping;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CScnnmtblbjct_IsSequenceFinished;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CScnnmtblbjct_SetSequenceBlending;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CScnnmtblbjct_GetPlaybackRate;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&CScnnmtblbjct_SetPlaybackRate;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int >)&CScnnmtblbjct_GetParameterInt;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, float >)&CScnnmtblbjct_GetParameterFloat;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnnmtblbjct_GetParameterVector3;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnnmtblbjct_GetParameterRotation;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CScnnmtblbjct_PendingAnimationEvents;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnnmtblbjct_RunAnimationEvents;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnnmtblbjct_DispatchTagEvents;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnnmtblbjct_ClearPhysicsBones;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ushort, void*, void* >)&CScnnmtblbjct_SetPhysicsBone;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnnmtblbjct_GetRootMotion;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CScnnmtblbjct_HasPhysicsBones;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnnmtblbjct_GetAnimParameter;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CScnnmtblbjct_GetAnimParameter_1;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, long, void* >)&CScnnmtblbjct_ChangeFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void* >)&CScnnmtblbjct_SetFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, int >)&CScnnmtblbjct_HasFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&CScnnmtblbjct_GetFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&CScnnmtblbjct_GetOriginalFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void* >)&CScnnmtblbjct_ClearFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&CScnnmtblbjct_SetCullDistance;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnnmtblbjct_EnableLightingCache;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, void* >)&CScnnmtblbjct_SetLightingOrigin;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnnmtblbjct_GetLightingOrigin;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CScnnmtblbjct_HasLightingOrigin;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnnmtblbjct_SetTintRGBA;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnnmtblbjct_GetTintRGBA;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&CScnnmtblbjct_SetAlphaFade;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CScnnmtblbjct_GetAlphaFade;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnnmtblbjct_SetMaterialOverrideForMeshInstances;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnnmtblbjct_ClearMaterialOverrideList;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, int, void* >)&CScnnmtblbjct_SetMaterialOverride;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CScnnmtblbjct_IsLoaded;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CScnnmtblbjct_IsRenderingEnabled;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnnmtblbjct_SetLoaded;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnnmtblbjct_ClearLoaded;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnnmtblbjct_DisableRendering;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnnmtblbjct_EnableRendering;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CScnnmtblbjct_SetRenderingEnabled;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CScnnmtblbjct_GetBoundingSphereRadius;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnnmtblbjct_SetTransform;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnnmtblbjct_GetCTransform;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnnmtblbjct_SetBounds;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnnmtblbjct_GetBounds;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnnmtblbjct_SetBoundsInfinite;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CScnnmtblbjct_GetParent;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, uint, void* >)&CScnnmtblbjct_AddChildObject;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnnmtblbjct_RemoveChild;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnnmtblbjct_GetAttributesPtrForModify;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong, void* >)&CScnnmtblbjct_EnableMeshGroups;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong, void* >)&CScnnmtblbjct_DisableMeshGroups;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong, void* >)&CScnnmtblbjct_ResetMeshGroups;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong >)&CScnnmtblbjct_GetCurrentMeshGroupMask;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CScnnmtblbjct_GetWorld;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CScnnmtblbjct_SetLOD;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnnmtblbjct_DisableLOD;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong >)&CScnnmtblbjct_GetCurrentLODGroupMask;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CScnnmtblbjct_GetCurrentLODLevel;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnnmtblbjct_GetModelHandle;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnnmtblbjct_SetMaterialGroup;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, void* >)&CScnnmtblbjct_SetBodyGroup;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CScnnmtblbjct_SetBatchable;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CScnnmtblbjct_IsNotBatchable;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CScnnmtblbjct_SetUniqueBatchGroup;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, void* >)&CScnnmtblbjct_RemoveTag;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnnmtblbjct_RemoveAllTags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CScnnmtblbjct_GetTagCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, uint >)&CScnnmtblbjct_GetTagAt;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, void* >)&CScnnmtblbjct_AddTag;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, int >)&CScnnmtblbjct_HasTag;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnnmtblbjct_SetForceLayerID;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnnmtblbjct_SetLayerMatchID;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnnmtblbjct_UpdateFlagsBasedOnMaterial;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void*, void* >)&CScnnmtblbjct_SetMaterialOverrideByIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float>)&_Get__CScnnmtblbjct_m_flDeltaTime;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float, void*>)&_Set__CScnnmtblbjct_m_flDeltaTime;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&_Get__CScnnmtblbjct_m_worldBounds;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*, void*>)&_Set__CScnnmtblbjct_m_worldBounds;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&_Get__CScnnmtblbjct_m_localBounds;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*, void*>)&_Set__CScnnmtblbjct_m_localBounds;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&From_CSceneObject_To_CSceneLightObject;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&To_CSceneObject_From_CSceneLightObject;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnLghtbjct_SetWorldPosition;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnLghtbjct_GetWorldPosition;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnLghtbjct_SetWorldDirection;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnLghtbjct_GetWorldDirection;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnLghtbjct_SetColor;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnLghtbjct_SetBounceColor;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnLghtbjct_GetColor;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&CScnLghtbjct_SetRadius;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CScnLghtbjct_GetRadius;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&CScnLghtbjct_SetTheta;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CScnLghtbjct_GetTheta;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&CScnLghtbjct_SetPhi;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CScnLghtbjct_GetPhi;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&CScnLghtbjct_SetFallOff;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CScnLghtbjct_GetFallOff;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CScnLghtbjct_GetShadowTextureResolution;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CScnLghtbjct_SetShadowTextureResolution;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CScnLghtbjct_GetShadows;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CScnLghtbjct_SetShadows;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&CScnLghtbjct_SetConstantAttn;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CScnLghtbjct_GetConstantAttn;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&CScnLghtbjct_SetLinearAttn;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CScnLghtbjct_GetLinearAttn;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&CScnLghtbjct_SetQuadraticAttn;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CScnLghtbjct_GetQuadraticAttn;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnLghtbjct_SetLightCookie;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnLghtbjct_GetLightCookie;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CScnLghtbjct_GetShadowCascades;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CScnLghtbjct_SetShadowCascades;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CScnLghtbjct_GetCascadeDistanceScale;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&CScnLghtbjct_SetCascadeDistanceScale;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CScnLghtbjct_GetFogContributionStength;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&CScnLghtbjct_SetFogContributionStength;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CScnLghtbjct_GetFogLightingMode;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CScnLghtbjct_SetFogLightingMode;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CScnLghtbjct_SetBakeLightIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&CScnLghtbjct_SetBakeLightIndexScale;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CScnLghtbjct_SetUsesIndexedBakedLighting;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CScnLghtbjct_SetRenderDiffuse;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CScnLghtbjct_SetRenderSpecular;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CScnLghtbjct_SetRenderTransmissive;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&CScnLghtbjct_SetLightSourceSize0;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&CScnLghtbjct_SetLightSourceSize1;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CScnLghtbjct_SetShadowTextureWidth;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CScnLghtbjct_SetShadowTextureHeight;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CScnLghtbjct_GetShadowTextureWidth;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CScnLghtbjct_GetShadowTextureHeight;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint >)&CScnLghtbjct_GetLightFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, void* >)&CScnLghtbjct_SetLightFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&CScnLghtbjct_GetLightShape;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void* >)&CScnLghtbjct_SetLightShape;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&CScnLghtbjct_SetLightSourceDim0;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&CScnLghtbjct_SetLightSourceDim1;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, long, void* >)&CScnLghtbjct_ChangeFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void* >)&CScnLghtbjct_SetFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, int >)&CScnLghtbjct_HasFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&CScnLghtbjct_GetFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&CScnLghtbjct_GetOriginalFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void* >)&CScnLghtbjct_ClearFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&CScnLghtbjct_SetCullDistance;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnLghtbjct_EnableLightingCache;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, void* >)&CScnLghtbjct_SetLightingOrigin;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnLghtbjct_GetLightingOrigin;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CScnLghtbjct_HasLightingOrigin;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnLghtbjct_SetTintRGBA;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnLghtbjct_GetTintRGBA;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&CScnLghtbjct_SetAlphaFade;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CScnLghtbjct_GetAlphaFade;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnLghtbjct_SetMaterialOverrideForMeshInstances;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnLghtbjct_ClearMaterialOverrideList;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, int, void* >)&CScnLghtbjct_SetMaterialOverride;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CScnLghtbjct_IsLoaded;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CScnLghtbjct_IsRenderingEnabled;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnLghtbjct_SetLoaded;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnLghtbjct_ClearLoaded;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnLghtbjct_DisableRendering;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnLghtbjct_EnableRendering;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CScnLghtbjct_SetRenderingEnabled;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CScnLghtbjct_GetBoundingSphereRadius;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnLghtbjct_SetTransform;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnLghtbjct_GetCTransform;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnLghtbjct_SetBounds;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnLghtbjct_GetBounds;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnLghtbjct_SetBoundsInfinite;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CScnLghtbjct_GetParent;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, uint, void* >)&CScnLghtbjct_AddChildObject;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnLghtbjct_RemoveChild;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnLghtbjct_GetAttributesPtrForModify;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong, void* >)&CScnLghtbjct_EnableMeshGroups;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong, void* >)&CScnLghtbjct_DisableMeshGroups;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong, void* >)&CScnLghtbjct_ResetMeshGroups;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong >)&CScnLghtbjct_GetCurrentMeshGroupMask;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CScnLghtbjct_GetWorld;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CScnLghtbjct_SetLOD;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnLghtbjct_DisableLOD;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong >)&CScnLghtbjct_GetCurrentLODGroupMask;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CScnLghtbjct_GetCurrentLODLevel;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnLghtbjct_GetModelHandle;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnLghtbjct_SetMaterialGroup;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, void* >)&CScnLghtbjct_SetBodyGroup;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CScnLghtbjct_SetBatchable;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CScnLghtbjct_IsNotBatchable;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CScnLghtbjct_SetUniqueBatchGroup;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, void* >)&CScnLghtbjct_RemoveTag;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnLghtbjct_RemoveAllTags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CScnLghtbjct_GetTagCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, uint >)&CScnLghtbjct_GetTagAt;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, void* >)&CScnLghtbjct_AddTag;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, int >)&CScnLghtbjct_HasTag;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnLghtbjct_SetForceLayerID;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnLghtbjct_SetLayerMatchID;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnLghtbjct_UpdateFlagsBasedOnMaterial;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void*, void* >)&CScnLghtbjct_SetMaterialOverrideByIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&From_CSceneObject_To_CSceneLightProbeVolumeObject;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&To_CSceneObject_From_CSceneLightProbeVolumeObject;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnLghtPrbVlmbj_CreateConstants;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, long, void* >)&CScnLghtPrbVlmbj_ChangeFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void* >)&CScnLghtPrbVlmbj_SetFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, int >)&CScnLghtPrbVlmbj_HasFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&CScnLghtPrbVlmbj_GetFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&CScnLghtPrbVlmbj_GetOriginalFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void* >)&CScnLghtPrbVlmbj_ClearFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&CScnLghtPrbVlmbj_SetCullDistance;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnLghtPrbVlmbj_EnableLightingCache;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, void* >)&CScnLghtPrbVlmbj_SetLightingOrigin;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnLghtPrbVlmbj_GetLightingOrigin;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CScnLghtPrbVlmbj_HasLightingOrigin;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnLghtPrbVlmbj_SetTintRGBA;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnLghtPrbVlmbj_GetTintRGBA;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&CScnLghtPrbVlmbj_SetAlphaFade;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CScnLghtPrbVlmbj_GetAlphaFade;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnLghtPrbVlmbj_SetMaterialOverrideForMeshInstances;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnLghtPrbVlmbj_ClearMaterialOverrideList;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, int, void* >)&CScnLghtPrbVlmbj_SetMaterialOverride;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CScnLghtPrbVlmbj_IsLoaded;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CScnLghtPrbVlmbj_IsRenderingEnabled;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnLghtPrbVlmbj_SetLoaded;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnLghtPrbVlmbj_ClearLoaded;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnLghtPrbVlmbj_DisableRendering;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnLghtPrbVlmbj_EnableRendering;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CScnLghtPrbVlmbj_SetRenderingEnabled;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CScnLghtPrbVlmbj_GetBoundingSphereRadius;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnLghtPrbVlmbj_SetTransform;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnLghtPrbVlmbj_GetCTransform;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnLghtPrbVlmbj_SetBounds;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnLghtPrbVlmbj_GetBounds;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnLghtPrbVlmbj_SetBoundsInfinite;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CScnLghtPrbVlmbj_GetParent;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, uint, void* >)&CScnLghtPrbVlmbj_AddChildObject;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnLghtPrbVlmbj_RemoveChild;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnLghtPrbVlmbj_GetAttributesPtrForModify;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong, void* >)&CScnLghtPrbVlmbj_EnableMeshGroups;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong, void* >)&CScnLghtPrbVlmbj_DisableMeshGroups;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong, void* >)&CScnLghtPrbVlmbj_ResetMeshGroups;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong >)&CScnLghtPrbVlmbj_GetCurrentMeshGroupMask;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CScnLghtPrbVlmbj_GetWorld;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CScnLghtPrbVlmbj_SetLOD;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnLghtPrbVlmbj_DisableLOD;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong >)&CScnLghtPrbVlmbj_GetCurrentLODGroupMask;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CScnLghtPrbVlmbj_GetCurrentLODLevel;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnLghtPrbVlmbj_GetModelHandle;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnLghtPrbVlmbj_SetMaterialGroup;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, void* >)&CScnLghtPrbVlmbj_SetBodyGroup;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CScnLghtPrbVlmbj_SetBatchable;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CScnLghtPrbVlmbj_IsNotBatchable;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CScnLghtPrbVlmbj_SetUniqueBatchGroup;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, void* >)&CScnLghtPrbVlmbj_RemoveTag;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnLghtPrbVlmbj_RemoveAllTags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CScnLghtPrbVlmbj_GetTagCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, uint >)&CScnLghtPrbVlmbj_GetTagAt;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, void* >)&CScnLghtPrbVlmbj_AddTag;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, int >)&CScnLghtPrbVlmbj_HasTag;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnLghtPrbVlmbj_SetForceLayerID;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnLghtPrbVlmbj_SetLayerMatchID;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnLghtPrbVlmbj_UpdateFlagsBasedOnMaterial;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void*, void* >)&CScnLghtPrbVlmbj_SetMaterialOverrideByIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&_Get__CScnLghtPrbVlmbj_m_vBoxMins;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*, void*>)&_Set__CScnLghtPrbVlmbj_m_vBoxMins;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&_Get__CScnLghtPrbVlmbj_m_vBoxMaxs;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*, void*>)&_Set__CScnLghtPrbVlmbj_m_vBoxMaxs;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__CScnLghtPrbVlmbj_m_nHandshake;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__CScnLghtPrbVlmbj_m_nHandshake;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__CScnLghtPrbVlmbj_m_nRenderPriority;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__CScnLghtPrbVlmbj_m_nRenderPriority;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&_Get__CScnLghtPrbVlmbj_m_hLightProbeTexture;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*, void*>)&_Set__CScnLghtPrbVlmbj_m_hLightProbeTexture;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&_Get__CScnLghtPrbVlmbj_m_hLightProbeDirectLightIndicesTexture;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*, void*>)&_Set__CScnLghtPrbVlmbj_m_hLightProbeDirectLightIndicesTexture;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&_Get__CScnLghtPrbVlmbj_m_hLightProbeDirectLightScalarsTexture;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*, void*>)&_Set__CScnLghtPrbVlmbj_m_hLightProbeDirectLightScalarsTexture;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, long, void* >)&CSceneObject_ChangeFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void* >)&CSceneObject_SetFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, int >)&CSceneObject_HasFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&CSceneObject_GetFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&CSceneObject_GetOriginalFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void* >)&CSceneObject_ClearFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&CSceneObject_SetCullDistance;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CSceneObject_EnableLightingCache;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, void* >)&CSceneObject_SetLightingOrigin;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CSceneObject_GetLightingOrigin;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CSceneObject_HasLightingOrigin;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CSceneObject_SetTintRGBA;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CSceneObject_GetTintRGBA;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&CSceneObject_SetAlphaFade;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CSceneObject_GetAlphaFade;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CSceneObject_SetMaterialOverrideForMeshInstances;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CSceneObject_ClearMaterialOverrideList;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, int, void* >)&CSceneObject_SetMaterialOverride;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CSceneObject_IsLoaded;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CSceneObject_IsRenderingEnabled;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CSceneObject_SetLoaded;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CSceneObject_ClearLoaded;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CSceneObject_DisableRendering;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CSceneObject_EnableRendering;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CSceneObject_SetRenderingEnabled;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CSceneObject_GetBoundingSphereRadius;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CSceneObject_SetTransform;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CSceneObject_GetCTransform;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CSceneObject_SetBounds;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CSceneObject_GetBounds;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CSceneObject_SetBoundsInfinite;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CSceneObject_GetParent;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, uint, void* >)&CSceneObject_AddChildObject;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CSceneObject_RemoveChild;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CSceneObject_GetAttributesPtrForModify;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong, void* >)&CSceneObject_EnableMeshGroups;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong, void* >)&CSceneObject_DisableMeshGroups;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong, void* >)&CSceneObject_ResetMeshGroups;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong >)&CSceneObject_GetCurrentMeshGroupMask;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CSceneObject_GetWorld;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CSceneObject_SetLOD;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CSceneObject_DisableLOD;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong >)&CSceneObject_GetCurrentLODGroupMask;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CSceneObject_GetCurrentLODLevel;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CSceneObject_GetModelHandle;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CSceneObject_SetMaterialGroup;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, void* >)&CSceneObject_SetBodyGroup;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CSceneObject_SetBatchable;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CSceneObject_IsNotBatchable;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CSceneObject_SetUniqueBatchGroup;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, void* >)&CSceneObject_RemoveTag;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CSceneObject_RemoveAllTags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CSceneObject_GetTagCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, uint >)&CSceneObject_GetTagAt;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, void* >)&CSceneObject_AddTag;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, int >)&CSceneObject_HasTag;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CSceneObject_SetForceLayerID;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CSceneObject_SetLayerMatchID;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CSceneObject_UpdateFlagsBasedOnMaterial;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void*, void* >)&CSceneObject_SetMaterialOverrideByIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&From_CSceneObject_To_CSceneSkyBoxObject;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&To_CSceneObject_From_CSceneSkyBoxObject;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnSkyBxbjct_SetLighting_ConstantColorHemisphere;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, int, void* >)&CScnSkyBxbjct_SetLighting_Samples;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnSkyBxbjct_GetMaterial;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnSkyBxbjct_SetMaterial;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnSkyBxbjct_SetSkyTint;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnSkyBxbjct_GetSkyTint;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CScnSkyBxbjct_SetFogType;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CScnSkyBxbjct_GetFogType;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, float, float, float, void* >)&CScnSkyBxbjct_SetAngularFogParams;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CScnSkyBxbjct_GetFogMinStart;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CScnSkyBxbjct_GetFogMinEnd;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CScnSkyBxbjct_GetFogMaxStart;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CScnSkyBxbjct_GetFogMaxEnd;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, long, void* >)&CScnSkyBxbjct_ChangeFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void* >)&CScnSkyBxbjct_SetFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, int >)&CScnSkyBxbjct_HasFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&CScnSkyBxbjct_GetFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&CScnSkyBxbjct_GetOriginalFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void* >)&CScnSkyBxbjct_ClearFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&CScnSkyBxbjct_SetCullDistance;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnSkyBxbjct_EnableLightingCache;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, void* >)&CScnSkyBxbjct_SetLightingOrigin;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnSkyBxbjct_GetLightingOrigin;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CScnSkyBxbjct_HasLightingOrigin;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnSkyBxbjct_SetTintRGBA;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnSkyBxbjct_GetTintRGBA;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&CScnSkyBxbjct_SetAlphaFade;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CScnSkyBxbjct_GetAlphaFade;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnSkyBxbjct_SetMaterialOverrideForMeshInstances;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnSkyBxbjct_ClearMaterialOverrideList;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, int, void* >)&CScnSkyBxbjct_SetMaterialOverride;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CScnSkyBxbjct_IsLoaded;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CScnSkyBxbjct_IsRenderingEnabled;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnSkyBxbjct_SetLoaded;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnSkyBxbjct_ClearLoaded;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnSkyBxbjct_DisableRendering;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnSkyBxbjct_EnableRendering;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CScnSkyBxbjct_SetRenderingEnabled;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CScnSkyBxbjct_GetBoundingSphereRadius;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnSkyBxbjct_SetTransform;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnSkyBxbjct_GetCTransform;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnSkyBxbjct_SetBounds;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnSkyBxbjct_GetBounds;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnSkyBxbjct_SetBoundsInfinite;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CScnSkyBxbjct_GetParent;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, uint, void* >)&CScnSkyBxbjct_AddChildObject;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnSkyBxbjct_RemoveChild;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnSkyBxbjct_GetAttributesPtrForModify;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong, void* >)&CScnSkyBxbjct_EnableMeshGroups;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong, void* >)&CScnSkyBxbjct_DisableMeshGroups;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong, void* >)&CScnSkyBxbjct_ResetMeshGroups;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong >)&CScnSkyBxbjct_GetCurrentMeshGroupMask;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CScnSkyBxbjct_GetWorld;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CScnSkyBxbjct_SetLOD;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnSkyBxbjct_DisableLOD;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong >)&CScnSkyBxbjct_GetCurrentLODGroupMask;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CScnSkyBxbjct_GetCurrentLODLevel;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnSkyBxbjct_GetModelHandle;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnSkyBxbjct_SetMaterialGroup;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, void* >)&CScnSkyBxbjct_SetBodyGroup;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CScnSkyBxbjct_SetBatchable;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CScnSkyBxbjct_IsNotBatchable;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CScnSkyBxbjct_SetUniqueBatchGroup;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, void* >)&CScnSkyBxbjct_RemoveTag;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnSkyBxbjct_RemoveAllTags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CScnSkyBxbjct_GetTagCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, uint >)&CScnSkyBxbjct_GetTagAt;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, void* >)&CScnSkyBxbjct_AddTag;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, int >)&CScnSkyBxbjct_HasTag;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnSkyBxbjct_SetForceLayerID;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CScnSkyBxbjct_SetLayerMatchID;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CScnSkyBxbjct_UpdateFlagsBasedOnMaterial;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void*, void* >)&CScnSkyBxbjct_SetMaterialOverrideByIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< uint, void* >)&CServerList_Create;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CServerList_Destroy;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CServerList_StartQuery;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&CServerList_AddFilter;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CSfxTable_GetCacheStatus;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CSfxTable_GetSampleCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, uint, int >)&CSfxTable_GetSamples;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, void* >)&CSfxTable_GetSound;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CSfxTable_IsValidForPlayback;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CSfxTable_FailedResourceLoad;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CSfxTable_CreateMixer;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CStmnvntryRslt_Destroy;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CStmnvntryRslt_IsPending;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CStmnvntryRslt_IsOk;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong, int >)&CStmnvntryRslt_CheckSteamId;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint >)&CStmnvntryRslt_GetTimestamp;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CStmnvntryRslt_Count;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CStmnvntryRslt_Get;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong >)&CStmtmnstnc_ItemId;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint >)&CStmtmnstnc_DefinitionId;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CTextureBase_DestroyStrongHandle;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, int >)&CTextureBase_IsStrongHandleValid;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, int >)&CTextureBase_IsError;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, int >)&CTextureBase_IsStrongHandleLoaded;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, void* >)&CTextureBase_CopyStrongHandle;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, void* >)&CTextureBase_GetBindingPtr;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&CUtlBuffer_Create;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CUtlBuffer_Dispose;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CUtlBuffer_Base;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CUtlBuffer_TellMaxPut;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CUtlSymbolTable_AddString;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CtlVctrCtlStrng_DeleteThis;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int, int, void* >)&CtlVctrCtlStrng_Create;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CtlVctrCtlStrng_Count;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CtlVctrCtlStrng_SetCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CtlVctrCtlStrng_Element;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CtlVctrflt_DeleteThis;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int, int, void* >)&CtlVctrflt_Create;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CtlVctrflt_Count;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CtlVctrflt_SetCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, float >)&CtlVctrflt_Element;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CtlVctrHRndrTxtr_DeleteThis;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int, int, void* >)&CtlVctrHRndrTxtr_Create;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CtlVctrHRndrTxtr_Count;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CtlVctrHRndrTxtr_Element;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CtlVctrPhyscsTrc_Result_DeleteThis;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int, int, void* >)&CtlVctrPhyscsTrc_Result_Create;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CtlVctrPhyscsTrc_Result_Count;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CtlVctrPhyscsTrc_Result_Element;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CtlVctrnt32_DeleteThis;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int, int, void* >)&CtlVctrnt32_Create;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CtlVctrnt32_Count;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CtlVctrnt32_SetCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, uint >)&CtlVctrnt32_Element;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CtlVctrVctr_DeleteThis;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int, int, void* >)&CtlVctrVctr_Create;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CtlVctrVctr_Count;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CtlVctrVctr_SetCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CtlVctrVctr_Element;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CVfx_DestroyStrongHandle;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, int >)&CVfx_IsStrongHandleValid;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, int >)&CVfx_IsError;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, int >)&CVfx_IsStrongHandleLoaded;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, void* >)&CVfx_CopyStrongHandle;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, void* >)&CVfx_GetBindingPtr;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CVfx_Create;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CVfx_GetFilename;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, long, uint, int, int >)&CVfx_CreateFromResourceFile;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, long, uint, int >)&CVfx_CreateFromShaderFile;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void* >)&CVfx_GetProgramData;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void* >)&CVfx_GetIterator;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CVfx_Serialize;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, int >)&CVfx_HasShaderProgram;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CVfx_InitializeWrite;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CVfx_FinalizeCompile;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void*, void*, int >)&CVfx_WriteProgramToBuffer;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, ulong, ulong, void*, int >)&CVfx_WriteCombo;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CVfx_GetPropertiesJson;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&CVfxBytCdMngr_Create;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CVfxBytCdMngr_Delete;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong, void* >)&CVfxBytCdMngr_OnStaticCombo;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CVfxBytCdMngr_OnDynamicCombo;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CVfxBytCdMngr_Reset;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CVfxCombo_GetName;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CVfxCombo_GetGroup;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, byte>)&_Get__CVfxCombo_m_nMin;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, byte, void*>)&_Set__CVfxCombo_m_nMin;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, byte>)&_Get__CVfxCombo_m_nMax;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, byte, void*>)&_Set__CVfxCombo_m_nMax;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CVfxCmbtrtr_Delete;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong >)&CVfxCmbtrtr_InvalidIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong, ulong >)&CVfxCmbtrtr_SetStaticCombo;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong >)&CVfxCmbtrtr_FirstStaticCombo;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong >)&CVfxCmbtrtr_NextStaticCombo;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong, ulong >)&CVfxCmbtrtr_SetDynamicCombo;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong >)&CVfxCmbtrtr_FirstDynamicCombo;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong >)&CVfxCmbtrtr_NextDynamicCombo;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__CVfxProgramData_m_bLoadedFromVcsFile;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__CVfxProgramData_m_bLoadedFromVcsFile;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< uint, void* >)&CVideoPlayer_Create;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CVideoPlayer_Destroy;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, int >)&CVideoPlayer_Play;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CVideoPlayer_Resume;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CVideoPlayer_Stop;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CVideoPlayer_Pause;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, double, void* >)&CVideoPlayer_Seek;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CVideoPlayer_GetRepeat;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CVideoPlayer_SetRepeat;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CVideoPlayer_GetDuration;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CVideoPlayer_GetPlaybackTime;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CVideoPlayer_HasAudioStream;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CVideoPlayer_Update;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CVideoPlayer_IsPaused;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CVideoPlayer_IsMuted;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CVideoPlayer_SetMuted;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CVideoPlayer_GetWidth;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CVideoPlayer_GetHeight;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CVideoPlayer_SetVideoOnly;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CVideoPlayer_GetMetadata;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CVideoPlayer_GetSpectrum;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&CVideoPlayer_GetAmplitude;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CVideoPlayer_GetTexture;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&CVideoPlayer_GetAudioStream;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&CVideoRecorder_Create;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CVideoRecorder_Destroy;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CVideoRecorder_Stop;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, long, void* >)&CVideoRecorder_AddVideoFrame;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CVideoRecorder_AddAudioSamples;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, int, int, int, int, int, void*, int >)&CVideoRecorder_Initialize;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&DspInstance_Dispose;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, int, void* >)&DspInstance_ProcessChannel;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&DspPreset_Create;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&DspPreset_Dispose;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void*, uint, void* >)&DspPreset_AddProcessor;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&DspPreset_FinishBuilding;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&DspPreset_Instantiate;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&EngineGlue_JsonToKeyValues3;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&EngineGlue_KeyValuesToJson;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&EngineGlue_KeyValues3ToJson;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&EngineGlue_LoadKeyValues3;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint >)&EngineGlue_GetStringToken;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< uint, void* >)&EngineGlue_GetStringTokenValue;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, void* >)&EngineGlue_AddSearchPath;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int >)&EngineGlue_RemoveSearchPath;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< ulong >)&EngineGlue_ApproximateProcessMemoryUsage;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&EngineGlue_ReadCompiledResourceFileJson;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&EngineGlue_ReadCompiledResourceFileBlock;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&EngineGlue_ReadCompiledResourceFileJsonFromFilesystem;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int, void* >)&EngineGlue_SetEngineLoggingVerbose;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&EngineGlue_RequestWebAuthTicket;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&EngineGlue_CancelWebAuthTicket;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&EngineGlue_GetWebAuthTicket;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&ErrorReports_SetTag;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int, void*, void*, void* >)&ErrorReports_Breadcrumb;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&FloatBitMap_t_Create;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int, int, void* >)&FloatBitMap_t_Create_1;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&FloatBitMap_t_Delete;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, long, int >)&FloatBitMap_t_LoadFromFile;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int >)&FloatBitMap_t_LoadFromPFM;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, long, int >)&FloatBitMap_t_LoadFromPSD;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, long, int >)&FloatBitMap_t_LoadFromTIF;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, long, int >)&FloatBitMap_t_LoadFromPNG;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, long, int >)&FloatBitMap_t_LoadFromJPG;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int >)&FloatBitMap_t_LoadFromEXR;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, long, long, void* >)&FloatBitMap_t_LoadFromBuffer;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int, int, void* >)&FloatBitMap_t_Init;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&FloatBitMap_t_Shutdown;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, float, void* >)&FloatBitMap_t_SetChannel;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&FloatBitMap_t_Rotate90DegreesCW;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&FloatBitMap_t_Rotate90DegreesCCW;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&FloatBitMap_t_Rotate180Degrees;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&FloatBitMap_t_MirrorHorizontally;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&FloatBitMap_t_MirrorVertically;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int >)&FloatBitMap_t_WriteTGAFile;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int >)&FloatBitMap_t_WritePFM;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, int >)&FloatBitMap_t_WriteEXR;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, int >)&FloatBitMap_t_LoadFromInMemoryTGA;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, int >)&FloatBitMap_t_LoadFromInMemoryPSD;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, int >)&FloatBitMap_t_LoadFromInMemoryTIF;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int, int, int, float >)&FloatBitMap_t_Pixel;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int, int, int, float >)&FloatBitMap_t_PixelWrapped;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int, int, int, float >)&FloatBitMap_t_PixelClamped;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int, int, float >)&FloatBitMap_t_Alpha;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int, int, void* >)&FloatBitMap_t_RGBPixelAsVector;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&FloatBitMap_t_Width;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&FloatBitMap_t_Height;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&FloatBitMap_t_Depth;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int, int, void* >)&FloatBitMap_t_Resize2D;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, long, int, int, uint, int >)&FloatBitMap_t_WriteToBuffer;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&fpxr_pplctnCnfg_SetDebugCallback;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&fpxr_pplctnCnfg_SetErrorCallback;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&fpxr_Compositor_EventManager;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, long >)&fpxr_Compositor_Submit;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&fpxr_Compositor_BeginFrame;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&fpxr_Compositor_EndFrame;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint >)&fpxr_Compositor_GetEyeWidth;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint >)&fpxr_Compositor_GetEyeHeight;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint >)&fpxr_Compositor_GetRenderTargetWidth;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint >)&fpxr_Compositor_GetRenderTargetHeight;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&fpxr_Compositor_GetDisplayRefreshRate;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, void*, long >)&fpxr_Compositor_GetViewInfo;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, float, float, void*, long >)&fpxr_Compositor_GetProjectionMatrix;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, long >)&fpxr_EventManager_PumpEvent;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, long, void*, long >)&fpxr_Input_GetBooleanActionState;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, long, void*, long >)&fpxr_Input_GetFloatActionState;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, long, void*, long >)&fpxr_Input_GetVector2ActionState;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, long, void*, long >)&fpxr_Input_GetPoseActionState;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, float, float, long, long >)&fpxr_Input_TriggerHapticVibration;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, long, void*, long >)&fpxr_Input_GetHandPoseState;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, long, float >)&fpxr_Input_GetFingerCurl;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&fpxr_Instance_Create;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int >)&fpxr_Instance_HasHeadset;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&fpxr_Instance_Compositor;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&fpxr_Instance_Input;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&fpxr_Instance_GetRequiredDeviceExtensions;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&fpxr_Instance_GetRequiredInstanceExtensions;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&fpxr_Instance_GetProperties;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&g_pAudioDevice_Name;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< uint >)&g_pAudioDevice_ChannelCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< uint >)&g_pAudioDevice_MixChannelCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< uint >)&g_pAudioDevice_BitsPerSample;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< uint >)&g_pAudioDevice_BytesPerSample;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< uint >)&g_pAudioDevice_SampleRate;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int >)&g_pAudioDevice_IsActive;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&g_pAudioDevice_CancelOutput;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&g_pAudioDevice_WaitForComplete;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int, void* >)&g_pAudioDevice_MuteDevice;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&g_pAudioDevice_ClearBuffer;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&g_pAudioDevice_OutputDebugInfo;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int >)&g_pAudioDevice_IsValid;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&g_pAudioDevice_SendOutput;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&g_pngnPVSMngr_BuildPvs;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&g_pngnPVSMngr_DestroyPvs;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&g_pngnSrvcMgr_GetEngineSwapChain;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&g_pngnSrvcMgr_GetEngineSwapChainSize;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&g_pngnSrvcMgr_SetEngineState;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&g_pngnSrvcMgr_ExitMainLoop;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&g_pFllFlSystm_GetSymLink;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&g_pFllFlSystm_AddSymLink;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&g_pFllFlSystm_RemoveSymLink;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int, void* >)&g_pFllFlSystm_ResetProjectPaths;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&g_pFllFlSystm_AddProjectPath;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&g_pFllFlSystm_AddCloudPath;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int >)&g_pInputService_IsAppActive;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int >)&g_pInputService_HasMouseFocus;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&g_pInputService_Key_NameForBinding;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< long, void* >)&g_pInputService_GetBinding;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int, int, void* >)&g_pInputService_SetCursorPosition;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&g_pInputService_Pump;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&g_pInputSystem_RegisterWindowWithSDL;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&g_pInputSystem_UnregisterWindowFromSDL;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&g_pInputSystem_SetEditorMainWindow;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&g_pInputSystem_OnEditorGameFocusChange;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int, int, void*, void* >)&g_pInputSystem_SetCursorPosition;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int >)&g_pInputSystem_HasMouseFocus;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int >)&g_pInputSystem_IsAppActive;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int >)&g_pInputSystem_IsIMEAllowed;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int, void* >)&g_pInputSystem_SetIMEAllowed;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int, int, int, int, void* >)&g_pInputSystem_SetIMETextLocation;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&g_pInputSystem_DismissIME;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< long, void* >)&g_pInputSystem_CodeToString;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&g_pInputSystem_StringToButtonCode;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int, long >)&g_pInputSystem_VirtualKeyToButtonCode;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< long, int >)&g_pInputSystem_ButtonCodeToVirtualKey;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int, void* >)&g_pInputSystem_SetRelativeMouseMode;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int >)&g_pInputSystem_GetRelativeMouseMode;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< long, void* >)&g_pInputSystem_SetCursorStandard;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&g_pInputSystem_SetCursorUser;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, int, int >)&g_pInputSystem_LoadCursorFromFile;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&g_pInputSystem_ShutdownUserCursors;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, void* >)&g_pMtrlSystm2_CreateRawMaterial;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int, void* >)&g_pMtrlSystm2_CreateProceduralMaterialCopy;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&g_pMtrlSystm2_FindOrCreateMaterialFromResource;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&g_pMtrlSystm2_FrameUpdate;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, long, long, void*, int, int >)&g_pMeshSystem_CreateSceneObject;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&g_pMeshSystem_ChangeModel;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int >)&g_pPhysicsSystem_NumWorlds;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int >)&g_pPhysicsSystem_CreateWorld;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&g_pPhysicsSystem_DestroyWorld;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&g_pPhysicsSystem_GetSurfacePropertyController;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void*, int, int, float, float, int >)&g_pPhysicsSystem_CastHeightField;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&g_pPhysicsSystem_GetAggregateData;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&g_pPhysicsSystem_UpdateSurfaceProperties;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&g_pRenderDevice_FindOrCreateSamplerState;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&g_pRenderDevice_GetSamplerIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&g_pRenderDevice_GetSwapChainInfo;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void* >)&g_pRenderDevice_FindOrCreateFileTexture;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void*, void*, int, void* >)&g_pRenderDevice_FindOrCreateTexture2;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&g_pRenderDevice_ClearTexture;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, void*, void* >)&g_pRenderDevice_AsyncSetTextureData2;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void* >)&g_pRenderDevice_GetSwapChainTexture;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, int >)&g_pRenderDevice_GetGPUFrameTimeMS;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&g_pRenderDevice_GetTextureDesc;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&g_pRenderDevice_GetOnDiskTextureDesc;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&g_pRenderDevice_GetTextureMultisampleType;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< uint, void* >)&g_pRenderDevice_CreateRenderContext;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&g_pRenderDevice_ReleaseRenderContext;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, int, void*, void*, long, int, int >)&g_pRenderDevice_ReadTexturePixels;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&g_pRenderDevice_DestroySwapChain;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&g_pRenderDevice_Present;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&g_pRenderDevice_Flush;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&g_pRenderDevice_CanRenderToSwapChain;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int >)&g_pRenderDevice_IsUsing32BitDepthBuffer;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&g_pRenderDevice_GetBackbufferDimensions;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< long, void*, uint, void*, void*, void* >)&g_pRenderDevice_CompileAndCreateShader;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&g_pRenderDevice_GetTextureLastUsed;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< uint, void* >)&g_pRenderDevice_UnThrottleTextureStreamingForNFrames;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int >)&g_pRenderDevice_GetNumTextureLoadsInFlight;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int, void* >)&g_pRenderDevice_SetForcePreloadStreamingData;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< long >)&g_pRenderDevice_GetRenderDeviceAPI;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&g_pRenderDevice_MarkTextureUsed;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&g_pRenderDevice_IsTextureRenderTarget;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int >)&g_pRenderDevice_IsRayTracingSupported;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< long, void*, long, void*, void* >)&g_pRenderDevice_CreateGPUBuffer;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&g_pRenderDevice_DestroyGPUBuffer;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, void*, uint, int >)&g_pRenderDevice_ReadBuffer;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< long, void* >)&g_pRenderDevice_GetDeviceSpecificInfo;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&g_pRenderDevice_GetGraphicsAPISpecificTextureHandle;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&g_pRenderDevice_GetDeviceSpecificTexture;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, byte, long, int >)&g_pRenderDevice_GetTextureViewIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&g_pRenderDevice_GetTextureResidencyInfo;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&g_pRenderDevice_GetSheetInfo;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&g_pRenderDevice_GetSequenceCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&g_pRenderDevice_GetSequence;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< long >)&g_pRenderService_GetMultisampleType;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, int >)&g_pRsrcCmplrSyst_GenerateResourceFile;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int >)&g_pRsrcCmplrSyst_GenerateResourceFile_1;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, void* >)&g_pRsrcCmplrSyst_GenerateResourceBytes;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&g_pRsrcSystm_ReloadSymlinkedResidentResources;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&g_pRsrcSystm_UpdateSimple;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int >)&g_pRsrcSystm_HasPendingWork;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&g_pRsrcSystm_LoadResourceInManifest;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&g_pRsrcSystm_DestroyResourceManifest;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&g_pRsrcSystm_IsManifestLoaded;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&g_pRsrcSystm_GetAllCodeManifests;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&g_pSceneSystem_DeleteSceneObject;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&g_pSceneSystem_DeleteSceneObjectAtFrameEnd;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int >)&g_pSceneSystem_CreateSkyBox;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&g_pSceneSystem_CreateDecal;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&g_pSceneSystem_BeginRenderingDynamicView;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< long, void* >)&g_pSceneSystem_GetWellKnownTexture;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< long, void* >)&g_pSceneSystem_GetWellKnownMaterialHandle;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&g_pSceneSystem_GetPerFrameStats;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&g_pSceneSystem_CreateWorld;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&g_pSceneSystem_DestroyWorld;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&g_pSceneSystem_SetupPerObjectLighting;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&g_pSceneSystem_CreatePointLight;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&g_pSceneSystem_CreateSpotLight;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&g_pSceneSystem_CreateOrthoLight;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int >)&g_pSceneSystem_CreateDirectionalLight;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int >)&g_pSceneSystem_CreateEnvMap;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&g_pSceneSystem_CreateLightProbeVolume;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&g_pSceneSystem_MarkEnvironmentMapObjectUpdated;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&g_pSceneSystem_MarkLightProbeVolumeObjectUpdated;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void*, void*, void*, uint >)&g_pSceneSystem_AddCullingBox;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, void* >)&g_pSceneSystem_RemoveCullingBox;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, uint >)&g_pSceneSystem_AddVolumetricFogVolume;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, void* >)&g_pSceneSystem_RemoveVolumetricFogVolume;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, byte, void* >)&g_pSceneSystem_DownsampleTexture;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&g_pSceneSystem_RenderTiledLightCulling;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int, void* >)&g_pSceneSystem_BindTransformSlot;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&g_pSceneSystem_CreateRayTraceWorld;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&g_pSceneSystem_DestroyRayTraceWorld;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&g_pSceneUtils_CreateTonemapSystem;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&g_pSceneUtils_DestroyTonemapSystem;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&g_pSceneUtils_CreateVolumetricFog;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&g_pSceneUtils_DestroyVolumetricFog;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int >)&g_pSndSystmntrnl_GetNumAudioDevices;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int, void* >)&g_pSndSystmntrnl_GetAudioDeviceDesc;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int, void* >)&g_pSndSystmntrnl_GetAudioDeviceId;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int, void* >)&g_pSndSystmntrnl_GetAudioDeviceName;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&g_pSndSystmntrnl_GetActiveAudioDevice;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&g_pSndSystmntrnl_SetActiveAudioDevice;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&g_pSndSystmntrnl_PlaySoundAtOSLevel;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&g_pSndSystmntrnl_PrecacheSound;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int, int, int, float, int, void*, int, void* >)&g_pSndSystmntrnl_CreateSound;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&g_pSndSystmntrnl_PreloadSound;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&g_pWrldRndrrMgr_ServiceWorldRequests;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, float, float, uint >)&g_pWrldRndrrMgr_UpdateObjectsForRendering;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, int, int, int, void*, void*, void* >)&g_pWrldRndrrMgr_CreateWorld;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int >)&g_pWrldRndrrMgr_MountWorldVPK;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&g_pWrldRndrrMgr_UnmountWorldVPK;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&global_Plat_ScreenToWindowCoords;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&global_Plat_WindowToScreenCoords;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&global_Plat_MessageBox;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int, void*, void*, void*, int >)&global_Plat_GetDesktopResolution;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int >)&global_Plat_GetDefaultMonitorIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&global_Plat_SafeRemoveFile;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&global_Plat_SetModuleFilename;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&global_Plat_SetCurrentDirectory;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< ulong >)&global_Plat_GetCurrentFrame;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< ulong, void* >)&global_Plat_SetCurrentFrame;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< long, void* >)&global_Plat_ChangeCurrentFrame;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int >)&global_Plat_IsRunningOnCustomerMachine;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int >)&global_Plat_HasClipboardText;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&global_Plat_SetClipboardText;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&global_Plat_GetClipboardText;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&global_Plat_ClearClipboardText;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int >)&global_IsWindowFocused;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int >)&global_IsRetail;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&global_HasLaunchParameter;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&global_Plat_SetNoAssert;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&global_GetGameRootFolder;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&global_GetGameSearchPath;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int >)&global_SourceEngineUnitTestInit;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int >)&global_SourceEnginePreInit;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&global_SourceEngineInit;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, double, double, int >)&global_SourceEngineFrame;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&global_SourceEngineShutdown;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&global_UpdateWindowSize;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< float >)&global_GetDiagonalDpi;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int >)&global_AppIsDedicatedServer;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&global_ToolsStallMonitor_IndicateActivity;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int, int, long >)&globalOVRLipSync_ovrLipSync_Initialize;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< long >)&globalOVRLipSync_ovrLipSync_Shutdown;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< uint, long >)&globalOVRLipSync_ovrLipSync_DestroyContext;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< uint, long >)&globalOVRLipSync_ovrLipSync_ResetContext;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, long >)&globalOVRLipSync_ovrLipSync_CreateContext;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, int, int, long >)&globalOVRLipSync_ovrLipSync_CreateContextEx;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< uint, long, int, int, long >)&globalOVRLipSync_ovrLipSync_SendSignal;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< uint, void*, int, long, void*, long >)&globalOVRLipSync_ovrLipSync_ProcessFrameEx;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&globalSteam_SteamHTMLSurface;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&globalSteam_SteamAPI_RunCallbacks;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&globalSteam_SteamGameServer_RunCallbacks;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&globalSteam_SteamUser;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&globalSteam_SteamFriends;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&globalSteam_SteamNetworkingMessages;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&globalSteam_SteamNetworkingUtils;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&globalSteam_SteamMatchmaking;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&globalSteam_SteamGameServer;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&globalSteam_SteamApps;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&globalSteam_SteamUtils;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int >)&globalSteam_SteamGameServer_BSecure;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< ulong >)&globalSteam_SteamGameServer_GetSteamID;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&globalSteam_SteamGameServer_Shutdown;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&globalSteam_SteamGameServer_ReleaseCurrentThreadMemory;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&globalSteam_SteamNetworkingSockets;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int, int, void*, void* >)&globalSteam_SteamGameServer_Init;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&globalYoga_YGNodeNew;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&globalYoga_YGNodeNewWithConfig;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&globalYoga_YGNodeFree;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&globalYoga_YGNodeReset;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, float, long, void* >)&globalYoga_YGNodeCalculateLayout;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&globalYoga_YGNodeGetHasNewLayout;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&globalYoga_YGNodeSetHasNewLayout;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&globalYoga_YGNodeIsDirty;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&globalYoga_YGNodeMarkDirty;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, void* >)&globalYoga_YGNodeInsertChild;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&globalYoga_YGNodeRemoveChild;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&globalYoga_YGNodeRemoveAllChildren;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong >)&globalYoga_YGNodeGetChildCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&globalYoga_YGNodeGetParent;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&globalYoga_YGNodeSetConfig;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&globalYoga_YGNodeLayoutGetLeft;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&globalYoga_YGNodeLayoutGetTop;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&globalYoga_YGNodeLayoutGetRight;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&globalYoga_YGNodeLayoutGetBottom;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&globalYoga_YGNodeLayoutGetWidth;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&globalYoga_YGNodeLayoutGetHeight;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&globalYoga_YGNodeLayoutGetDirection;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&globalYoga_YGNodeLayoutGetHadOverflow;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, float >)&globalYoga_YGNodeLayoutGetMargin;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, float >)&globalYoga_YGNodeLayoutGetBorder;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, float >)&globalYoga_YGNodeLayoutGetPadding;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&globalYoga_YGConfigNew;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&globalYoga_YGConfigFree;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&globalYoga_YGConfigSetUseWebDefaults;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&globalYoga_YGConfigSetPointScaleFactor;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&globalYoga_YGNodeCopyStyle;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void* >)&globalYoga_YGNodeStyleSetDirection;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&globalYoga_YGNodeStyleGetDirection;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void* >)&globalYoga_YGNodeStyleSetFlexDirection;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&globalYoga_YGNodeStyleGetFlexDirection;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void* >)&globalYoga_YGNodeStyleSetJustifyContent;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&globalYoga_YGNodeStyleGetJustifyContent;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void* >)&globalYoga_YGNodeStyleSetAlignContent;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&globalYoga_YGNodeStyleGetAlignContent;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void* >)&globalYoga_YGNodeStyleSetAlignItems;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&globalYoga_YGNodeStyleGetAlignItems;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void* >)&globalYoga_YGNodeStyleSetAlignSelf;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&globalYoga_YGNodeStyleGetAlignSelf;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void* >)&globalYoga_YGNodeStyleSetPositionType;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&globalYoga_YGNodeStyleGetPositionType;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void* >)&globalYoga_YGNodeStyleSetFlexWrap;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&globalYoga_YGNodeStyleGetFlexWrap;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void* >)&globalYoga_YGNodeStyleSetOverflow;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&globalYoga_YGNodeStyleGetOverflow;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void* >)&globalYoga_YGNodeStyleSetDisplay;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&globalYoga_YGNodeStyleGetDisplay;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&globalYoga_YGNodeStyleSetFlex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&globalYoga_YGNodeStyleGetFlex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&globalYoga_YGNodeStyleSetFlexGrow;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&globalYoga_YGNodeStyleGetFlexGrow;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&globalYoga_YGNodeStyleSetFlexShrink;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&globalYoga_YGNodeStyleGetFlexShrink;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&globalYoga_YGNodeStyleSetFlexBasis;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&globalYoga_YGNodeStyleSetFlexBasisPercent;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&globalYoga_YGNodeStyleSetFlexBasisAuto;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&globalYoga_YGNodeStyleGetFlexBasis;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, float, void* >)&globalYoga_YGNodeStyleSetPosition;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, float, void* >)&globalYoga_YGNodeStyleSetPositionPercent;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void* >)&globalYoga_YGNodeStyleGetPosition;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, float, void* >)&globalYoga_YGNodeStyleSetMargin;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, float, void* >)&globalYoga_YGNodeStyleSetMarginPercent;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void* >)&globalYoga_YGNodeStyleSetMarginAuto;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void* >)&globalYoga_YGNodeStyleGetMargin;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, float, void* >)&globalYoga_YGNodeStyleSetPadding;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, float, void* >)&globalYoga_YGNodeStyleSetPaddingPercent;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void* >)&globalYoga_YGNodeStyleGetPadding;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, float, void* >)&globalYoga_YGNodeStyleSetBorder;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, float >)&globalYoga_YGNodeStyleGetBorder;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, float, void* >)&globalYoga_YGNodeStyleSetGap;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, float >)&globalYoga_YGNodeStyleGetGap;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&globalYoga_YGNodeStyleSetWidth;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&globalYoga_YGNodeStyleSetWidthPercent;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&globalYoga_YGNodeStyleSetWidthAuto;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&globalYoga_YGNodeStyleGetWidth;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&globalYoga_YGNodeStyleSetHeight;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&globalYoga_YGNodeStyleSetHeightPercent;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&globalYoga_YGNodeStyleSetHeightAuto;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&globalYoga_YGNodeStyleGetHeight;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&globalYoga_YGNodeStyleSetMinWidth;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&globalYoga_YGNodeStyleSetMinWidthPercent;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&globalYoga_YGNodeStyleGetMinWidth;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&globalYoga_YGNodeStyleSetMinHeight;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&globalYoga_YGNodeStyleSetMinHeightPercent;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&globalYoga_YGNodeStyleGetMinHeight;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&globalYoga_YGNodeStyleSetMaxWidth;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&globalYoga_YGNodeStyleSetMaxWidthPercent;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&globalYoga_YGNodeStyleGetMaxWidth;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&globalYoga_YGNodeStyleSetMaxHeight;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&globalYoga_YGNodeStyleSetMaxHeightPercent;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&globalYoga_YGNodeStyleGetMaxHeight;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&globalYoga_YGNodeStyleSetAspectRatio;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&globalYoga_YGNodeStyleGetAspectRatio;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&globalYoga_YGNodeSetMeasureFunc;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&globalYoga_YGNodeHasMeasureFunc;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&Glue_Networking_RunCallbacks;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int, void*, void* >)&Glue_Networking_SetDebugFunction;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&Glue_Networking_GetAuthenticationStatus;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&Glue_Networking_GetRelayNetworkStatus;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int, void* >)&Glue_Networking_CreateSocket;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int, void* >)&Glue_Networking_CreateIpBasedSocket;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&Glue_Networking_CloseSocket;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&Glue_Networking_GetSocketAddress;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&Glue_Networking_BeginAsyncRequestFakeIP;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&Glue_Networking_GetIdentity;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&Glue_Networking_CreatePollGroup;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&Glue_Networking_DestroyPollGroup;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&Glue_Networking_SetPollGroup;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, int >)&Glue_Networking_GetPollGroupMessages;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< ulong, int, void* >)&Glue_Networking_ConnectToSteamId;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&Glue_Networking_ConnectToIpAddress;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void*, void* >)&Glue_Networking_CloseConnection;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&Glue_Networking_AcceptConnection;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&Glue_Networking_FlushMessagesOnConnection;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, int, long >)&Glue_Networking_SendMessage;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, int >)&Glue_Networking_GetConnectionMessages;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&Glue_Networking_GetConnectionState;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&Glue_Networking_GetConnectionDescription;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong >)&Glue_Networking_GetConnectionSteamId;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&Glue_RndrDvcMngr_WriteVideoConfig;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&Glue_RndrDvcMngr_ResetVideoConfig;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int, int, int, int, int, long, void* >)&Glue_RndrDvcMngr_ChangeVideoMode;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int, int >)&Glue_RndrDvcMngr_GetDisplayModes;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&Glue_Resources_GetMaterial;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&Glue_Resources_GetTexture;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&Glue_Resources_GetModel;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&Glue_Resources_GetAnimationGraph;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&Glue_Resources_GetShader;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IAnimationGraph_DestroyStrongHandle;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, int >)&IAnimationGraph_IsStrongHandleValid;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, int >)&IAnimationGraph_IsError;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, int >)&IAnimationGraph_IsStrongHandleLoaded;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, void* >)&IAnimationGraph_CopyStrongHandle;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, void* >)&IAnimationGraph_GetBindingPtr;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IAnimationGraph_GetResourceName;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IAnimationGraph_GetParameterList;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IAnimParameter_GetName;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&IAnimParameter_GetParameterType;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IAnimParameter_GetDefaultValue;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IAnimParameter_GetMinValue;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IAnimParameter_GetMaxValue;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&IAnimParameter_GetNumOptionNames;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&IAnimParameter_GetOptionName;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&nmPrmtrnstnc_SetValue;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&nmPrmtrnstnc_SetValue_1;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&nmPrmtrnstnc_SetValue_2;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&nmPrmtrnstnc_SetValue_3;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&nmPrmtrnstnc_SetValue_4;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&nmPrmtrnstnc_SetEnumValue;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&nmPrmtrnstnc_GetName;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&nmPrmtrnstnc_IsAutoReset;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&nmPrmtrnstnc_GetParameterType;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&nmPrmtrLst_Count;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&nmPrmtrLst_GetParameter;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&nmPrmtrLst_GetParameter_1;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&syncRsrcDtRqst_GetFileName;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&syncRsrcDtRqst_GetResultBuffer;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&syncRsrcDtRqst_GetResultBufferSize;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int, int, int, long, int, int >)&ImageLoader_GetMemRequired;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int, int, int, int, long, int >)&ImageLoader_GetMemRequired_1;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void*, long, int, int, int, int, int >)&ImageLoader_ConvertImageFormat;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IMaterial2_DestroyStrongHandle;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, int >)&IMaterial2_IsStrongHandleValid;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, int >)&IMaterial2_IsError;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, int >)&IMaterial2_IsStrongHandleLoaded;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, void* >)&IMaterial2_CopyStrongHandle;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, void* >)&IMaterial2_GetBindingPtr;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IMaterial2_GetName;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IMaterial2_GetNameWithMod;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong >)&IMaterial2_GetSimilarityKey;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&IMaterial2_IsLoaded;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&IMaterial2_GetMode;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IMaterial2_GetMode_1;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&IMaterial2_GetMode_2;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IMaterial2_GetRenderAttributes;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IMaterial2_RecreateAllStaticConstantAndCommandBuffers;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IMaterial2_GetFirstTextureAttribute;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, int >)&IMaterial2_GetBoolAttributeOrDefault;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, int >)&IMaterial2_GetIntAttributeOrDefault;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, float, float >)&IMaterial2_GetFloatAttributeOrDefault;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&IMaterial2_GetTextureAttributeOrDefault;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int >)&IMaterial2_HasParam;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&IMaterial2_Set;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&IMaterial2_GetString;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&IMaterial2_Set_1;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&IMaterial2_GetVector4;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&IMaterial2_Set_2;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&IMaterial2_GetTexture;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&IMaterial2_SetEdited;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&IMaterial2_IsEdited;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IMaterial2_ReloadStaticCombos;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&Physggrgtnstnc_WakeUp;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&Physggrgtnstnc_PutToSleep;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&Physggrgtnstnc_IsAsleep;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&Physggrgtnstnc_SetVelocity;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&Physggrgtnstnc_AddVelocity;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&Physggrgtnstnc_SetAngularVelocity;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&Physggrgtnstnc_AddAngularVelocity;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&Physggrgtnstnc_GetBodyCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int >)&Physggrgtnstnc_GetBodyHandle;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&Physggrgtnstnc_GetBodyName;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, uint >)&Physggrgtnstnc_GetBodyNameHash;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int >)&Physggrgtnstnc_GetBodyByNameHash;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int >)&Physggrgtnstnc_GetBodyIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int >)&Physggrgtnstnc_FindBodyByName;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&Physggrgtnstnc_GetJointCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int >)&Physggrgtnstnc_GetJointHandle;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&Physggrgtnstnc_RemoveJoint;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&Physggrgtnstnc_GetOrigin;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&Physggrgtnstnc_GetMassCenter;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&Physggrgtnstnc_SetSurfaceProperties;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&Physggrgtnstnc_GetTotalMass;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&Physggrgtnstnc_SetTotalMass;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&Physggrgtnstnc_SetLinearDamping;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&Physggrgtnstnc_SetAngularDamping;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&Physggrgtnstnc_GetWorld;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&IPhysicsBody_GetWorld;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&IPhysicsBody_SetGravityScale;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&IPhysicsBody_GetGravityScale;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&IPhysicsBody_IsGravityEnabled;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&IPhysicsBody_EnableGravity;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&IPhysicsBody_SetMass;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&IPhysicsBody_GetMass;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IPhysicsBody_GetMassCenter;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IPhysicsBody_GetLocalMassCenter;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&IPhysicsBody_SetLocalMassCenter;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&IPhysicsBody_SetOverrideMassCenter;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&IPhysicsBody_GetOverrideMassCenter;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&IPhysicsBody_SetPosition;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IPhysicsBody_GetPosition;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&IPhysicsBody_SetOrientation;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IPhysicsBody_GetOrientation;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&IPhysicsBody_SetTransform;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IPhysicsBody_GetTransform;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&IPhysicsBody_SetLinearVelocity;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IPhysicsBody_GetLinearVelocity;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&IPhysicsBody_GetVelocityAtPoint;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&IPhysicsBody_AddLinearVelocity;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&IPhysicsBody_SetAngularVelocity;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IPhysicsBody_GetAngularVelocity;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IPhysicsBody_Wake;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IPhysicsBody_Sleep;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&IPhysicsBody_IsSleeping;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IPhysicsBody_EnableAutoSleeping;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IPhysicsBody_DisableAutoSleeping;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IPhysicsBody_EnableTouchEvents;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IPhysicsBody_DisableTouchEvents;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&IPhysicsBody_IsTouchEventEnabled;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&IPhysicsBody_GetType;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void* >)&IPhysicsBody_SetType;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&IPhysicsBody_GetShapeCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int >)&IPhysicsBody_GetShape;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, float, int >)&IPhysicsBody_AddSphereShape;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, float, int >)&IPhysicsBody_AddCapsuleShape;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void*, int >)&IPhysicsBody_AddBoxShape;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, int, void*, int >)&IPhysicsBody_AddHullShape;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, int >)&IPhysicsBody_AddHullShape_1;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, int >)&IPhysicsBody_AddHullShape_2;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void*, int, void*, int, int >)&IPhysicsBody_AddMeshShape;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, int, int >)&IPhysicsBody_AddMeshShape_1;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, int, int, float, float, int, int >)&IPhysicsBody_AddHeightFieldShape;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&IPhysicsBody_RemoveShape;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IPhysicsBody_PurgeShapes;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&IPhysicsBody_ApplyLinearImpulse;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&IPhysicsBody_ApplyLinearImpulseAtWorldSpace;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&IPhysicsBody_ApplyAngularImpulse;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&IPhysicsBody_ApplyForce;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&IPhysicsBody_ApplyForceAt;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&IPhysicsBody_ApplyTorque;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IPhysicsBody_ClearForces;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IPhysicsBody_ClearTorque;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IPhysicsBody_Enable;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IPhysicsBody_Disable;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&IPhysicsBody_IsEnabled;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IPhysicsBody_BuildMass;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&IPhysicsBody_SetLinearDamping;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&IPhysicsBody_GetLinearDamping;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&IPhysicsBody_SetAngularDamping;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&IPhysicsBody_GetAngularDamping;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IPhysicsBody_BuildBounds;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&IPhysicsBody_GetDensity;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&IPhysicsBody_GetClosestPoint;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&IPhysicsBody_SetMaterialIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&IPhysicsBody_GetAggregate;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, float, void* >)&IPhysicsBody_SetTargetTransform;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, int >)&IPhysicsBody_CheckOverlap;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IPhysicsBody_GetLocalInertiaVector;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IPhysicsBody_GetLocalInertiaOrientation;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&IPhysicsBody_SetLocalInertia;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IPhysicsBody_ResetLocalInertia;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&IPhysicsBody_ManagedObject;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int, int, int, int, int, void* >)&IPhysicsBody_SetMotionLocks;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, int >)&IPhysicsBody_IsTouching;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, int >)&IPhysicsBody_IsTouching_1;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&IPhysicsBody_SetTrigger;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&IPhysicsJoint_GetWorld;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&IPhysicsJoint_GetBody1;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&IPhysicsJoint_GetBody2;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&IPhysicsJoint_GetLocalFrameA;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&IPhysicsJoint_GetLocalFrameB;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&IPhysicsJoint_SetLocalFrameA;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&IPhysicsJoint_SetLocalFrameB;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&IPhysicsJoint_SetEnableCollision;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&IPhysicsJoint_IsCollisionEnabled;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&IPhysicsJoint_GetType;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&IPhysicsJoint_SetLinearSpring;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IPhysicsJoint_GetLinearSpring;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&IPhysicsJoint_SetAngularSpring;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IPhysicsJoint_GetAngularSpring;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, float, void* >)&IPhysicsJoint_SetAngularMotor;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&IPhysicsJoint_SetMinLength;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&IPhysicsJoint_GetMinLength;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&IPhysicsJoint_SetMaxLength;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&IPhysicsJoint_GetMaxLength;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&IPhysicsJoint_SetMinForce;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&IPhysicsJoint_GetMinForce;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&IPhysicsJoint_SetMaxForce;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&IPhysicsJoint_GetMaxForce;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&IPhysicsJoint_SetFriction;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&IPhysicsJoint_SetLimit;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, void* >)&IPhysicsJoint_SetLimitEnabled;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&IPhysicsJoint_GetAngle;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&IPhysicsJoint_GetLinearImpulse;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&IPhysicsJoint_GetAngularImpulse;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&IPhysicsJoint_GetMaxLinearImpulse;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&IPhysicsJoint_GetMaxAngularImpulse;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&IPhysicsJoint_SetMaxLinearImpulse;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&IPhysicsJoint_SetMaxAngularImpulse;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, float, void* >)&IPhysicsJoint_SetMotorVelocity;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, float, float, void* >)&IPhysicsJoint_SetTargetRotation;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&IPhysicsJoint_Motor_SetLinearVelocity;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&IPhysicsJoint_Motor_SetAngularVelocity;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&IPhysicsJoint_Motor_SetMaxVelocityForce;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&IPhysicsJoint_Motor_SetMaxVelocityTorque;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&IPhysicsJoint_Motor_SetLinearHertz;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&IPhysicsJoint_Motor_SetLinearDampingRatio;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&IPhysicsJoint_Motor_SetAngularHertz;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&IPhysicsJoint_Motor_SetAngularDampingRatio;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&IPhysicsJoint_Motor_SetMaxSpringForce;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&IPhysicsJoint_Motor_SetMaxSpringTorque;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IPhysicsJoint_Motor_GetLinearVelocity;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IPhysicsJoint_Motor_GetAngularVelocity;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&IPhysicsJoint_Motor_GetMaxVelocityForce;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&IPhysicsJoint_Motor_GetMaxVelocityTorque;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&IPhysicsJoint_Motor_GetLinearHertz;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&IPhysicsJoint_Motor_GetLinearDampingRatio;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&IPhysicsJoint_Motor_GetAngularHertz;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&IPhysicsJoint_Motor_GetAngularDampingRatio;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&IPhysicsJoint_Motor_GetMaxSpringForce;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&IPhysicsJoint_Motor_GetMaxSpringTorque;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, byte, void* >)&IPhysicsShape_AddCollisionFunctionMask;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, byte, void* >)&IPhysicsShape_RemoveCollisionFunctionMask;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, byte >)&IPhysicsShape_GetCollisionFunctionMask;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, int >)&IPhysicsShape_HasTag;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, int >)&IPhysicsShape_AddTag;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, int >)&IPhysicsShape_RemoveTag;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&IPhysicsShape_ClearTags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&IPhysicsShape_GetBody;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&IPhysicsShape_SetMaterialIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int, void* >)&IPhysicsShape_SetSurfaceIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IPhysicsShape_GetMaterialName;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&IPhysicsShape_GetType;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void*, int, void*, void* >)&IPhysicsShape_UpdateMeshShape;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, int, int, int, int, float, float, void* >)&IPhysicsShape_UpdateHeightShape;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, float, void* >)&IPhysicsShape_UpdateSphereShape;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, float, void* >)&IPhysicsShape_UpdateCapsuleShape;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, int, void*, void* >)&IPhysicsShape_UpdateHullShape;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&IPhysicsShape_ManagedObject;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&IPhysicsShape_SetTrigger;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&IPhysicsShape_IsTrigger;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&IPhysicsShape_GetTriangulation;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void*, void* >)&IPhysicsShape_GetTriangulationForNavmesh;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&IPhysicsShape_GetOutline;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IPhysicsShape_AsSphere;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IPhysicsShape_AsCapsule;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void*, void* >)&IPhysicsShape_UpdateBoxShape;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&IPhysicsShape_SetFriction;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&IPhysicsShape_GetFriction;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&IPhysicsShape_SetLocalVelocity;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IPhysicsShape_GetLocalVelocity;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&IPhysicsShape_SetElasticity;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&IPhysicsShape_SetRollingResistance;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&IPhysicsShape_SetIgnoreTraces;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&IPhysicsShape_SetHasNoMass;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IPhysicsShape_BuildBounds;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IPhysicsShape_LocalBounds;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, int >)&IPhysicsShape_IsTouching;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&IPhysicsWorld_AddBody;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&IPhysicsWorld_RemoveBody;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&IPhysicsWorld_GetWorldReferenceBody;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&IPhysicsWorld_SetWorldReferenceBody;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&IPhysicsWorld_RemoveJoint;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&IPhysicsWorld_SetGravity;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IPhysicsWorld_GetGravity;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void* >)&IPhysicsWorld_SetSimulation;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&IPhysicsWorld_GetSimulation;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IPhysicsWorld_EnableSleeping;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IPhysicsWorld_DisableSleeping;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&IPhysicsWorld_IsSleepingEnabled;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&IPhysicsWorld_SetMaximumLinearSpeed;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void*, void*, int >)&IPhysicsWorld_AddWeldJoint;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void*, void*, int >)&IPhysicsWorld_AddSpringJoint;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void*, void*, int >)&IPhysicsWorld_AddRevoluteJoint;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void*, void*, int >)&IPhysicsWorld_AddPrismaticJoint;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void*, void*, int >)&IPhysicsWorld_AddSphericalJoint;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void*, void*, int >)&IPhysicsWorld_AddMotorJoint;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&IPhysicsWorld_SetCollisionRulesFromJson;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, int, void* >)&IPhysicsWorld_StepSimulation;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&IPhysicsWorld_ProcessIntersections;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&IPhysicsWorld_DestroyAggregateInstance;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, ulong, long, int >)&IPhysicsWorld_CreateAggregateInstance;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, ulong, long, int >)&IPhysicsWorld_CreateAggregateInstance_1;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&IPhysicsWorld_SetDebugScene;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&IPhysicsWorld_GetDebugScene;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&IPhysicsWorld_Draw;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&IPhysicsWorld_ManagedObject;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, float, ushort, void* >)&IPhysicsWorld_Query;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, ushort, void* >)&IPhysicsWorld_Query_1;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, int, ushort, void* >)&IPhysicsWorld_Query_2;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&PhysSrfcPrprtyCn_GetSurfacePropCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&PhysSrfcPrprtyCn_GetSurfaceProperty;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void*, void* >)&PhysSrfcPrprtyCn_AddProperty;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&IPVS_IsEmptyPVS;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void*, void*, int >)&IPVS_IsInPVS;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void*, void*, void*, int >)&IPVS_IsAbsBoxInPVS;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int >)&IPVS_IsSkyVisibleFromPosition;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int >)&IPVS_IsSunVisibleFromPosition;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&RyTrcScnWrld_BeginBuild;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&RyTrcScnWrld_AddSceneWorldToBuild;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, int >)&RyTrcScnWrld_EndBuild;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, int >)&RyTrcScnWrld_BuildTLASForWorld;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&RD_RgstrRsrcDttl_SetDataRegistrationFailed;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&RD_RgstrRsrcDttl_IsReloading;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&RD_RgstrRsrcDttl_SetFinalResourceData;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&RD_RgstrRsrcDttl_GetDataRegistrationFailed;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&RD_RgstrRsrcDttl_GetFinalResourceData;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&RD_RgstrRsrcDttl_GetResultBufferSize;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, int, int, void* >)&IRenderContext_Draw;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, int, int, int, void* >)&IRenderContext_DrawInstanced;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, int, int, int, int, void* >)&IRenderContext_DrawIndexed;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, int, int, int, int, int, void* >)&IRenderContext_DrawIndexedInstanced;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void*, uint, void* >)&IRenderContext_DrawInstancedIndirect;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void*, uint, void* >)&IRenderContext_DrawIndexedInstancedIndirect;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, long, long, long, long, long, void* >)&IRenderContext_TextureBarrierTransition;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, long, long, long, long, void* >)&IRenderContext_BufferBarrierTransition;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&IRenderContext_SetScissorRect;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IRenderContext_GetAttributesPtrForModify;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&IRenderContext_GenerateMipMaps;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, int, int, void* >)&IRenderContext_Clear;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void*, void* >)&IRenderContext_BindRenderTargets;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&IRenderContext_RestoreRenderTargets;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&IRenderContext_SetViewport;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&IRenderContext_SetViewport_1;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int, int, int, void* >)&IRenderContext_SetViewport_2;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IRenderContext_GetViewport;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IRenderContext_Submit;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IRenderContext_SetAssociatedThreadIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, int, void* >)&IRenderContext_BindRenderTargets_1;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, int >)&IRenderContext_BindIndexBuffer;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, int, int >)&IRenderContext_BindIndexBuffer_1;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void*, int, int >)&IRenderContext_BindVertexBuffer;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void*, int, int, int >)&IRenderContext_BindVertexBuffer_1;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void*, int, int >)&IRenderContext_BindVertexBuffer_2;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void*, int, int, int >)&IRenderContext_BindVertexBuffer_3;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&IRenderContext_BindVertexShader;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&IRenderContext_BindPixelShader;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void*, int, int, void* >)&IRenderContext_SetDynamicConstantBufferData;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void*, void* >)&IRenderContext_BindTexture;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void*, int, int, int, void* >)&IRenderContext_ReadTexturePixels;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, int, int, int, void* >)&IRenderContext_ReadBuffer;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&IRenderContext_BeginPixEvent;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IRenderContext_EndPixEvent;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&IRenderContext_PixSetMarker;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&ISceneLayer_SetObjectMatchID;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void* >)&ISceneLayer_AddObjectFlagsRequiredMask;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void* >)&ISceneLayer_AddObjectFlagsExcludedMask;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void* >)&ISceneLayer_RemoveObjectFlagsRequiredMask;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void* >)&ISceneLayer_RemoveObjectFlagsExcludedMask;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&ISceneLayer_GetObjectFlagsRequiredMask;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&ISceneLayer_GetObjectFlagsExcludedMask;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&ISceneLayer_GetDebugName;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&ISceneLayer_GetRenderAttributesPtr;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, long, uint, void* >)&ISceneLayer_SetAttr;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&ISceneLayer_SetBoundingVolumeSizeCullThresholdInPercent;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, void* >)&ISceneLayer_SetClearColor;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&ISceneLayer_GetTextureValue;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&ISceneLayer_GetTextureValue_1;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&ISceneLayer_GetColorTarget;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&ISceneLayer_GetDepthTarget;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&ISceneLayer_SetOutput;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, long>)&_Get__ISceneLayer_m_nLayerFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, long, void*>)&_Set__ISceneLayer_m_nLayerFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, long>)&_Get__ISceneLayer_LayerEnum;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, long, void*>)&_Set__ISceneLayer_LayerEnum;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&_Get__ISceneLayer_m_viewport;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*, void*>)&_Set__ISceneLayer_m_viewport;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__ISceneLayer_m_nClearFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__ISceneLayer_m_nClearFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&ISceneView_GetMainViewport;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&ISceneView_GetSwapChain;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, void* >)&ISceneView_AddDependentView;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&ISceneView_GetRenderAttributesPtr;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void*, void*, void* >)&ISceneView_AddRenderLayer;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void*, void*, int, void* >)&ISceneView_AddManagedProceduralLayer;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void* >)&ISceneView_SetDefaultLayerObjectRequiredFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void* >)&ISceneView_SetDefaultLayerObjectExcludedFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&ISceneView_GetDefaultLayerObjectRequiredFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&ISceneView_GetDefaultLayerObjectExcludedFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&ISceneView_AddWorldToRenderList;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, int, void* >)&ISceneView_FindOrCreateRenderTarget;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&ISceneView_SetParent;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&ISceneView_GetParent;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&ISceneView_GetPriority;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&ISceneView_SetPriority;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&ISceneView_GetFrustum;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&ISceneView_GetPostProcessEnabled;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&ISceneView_GetToolsVisMode;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__ISceneView_m_ViewUniqueId;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__ISceneView_m_ViewUniqueId;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__ISceneView_m_ManagedCameraId;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__ISceneView_m_ManagedCameraId;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&ISceneWorld_DeleteAllObjects;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&ISceneWorld_Release;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&ISceneWorld_GetSceneObjectCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&ISceneWorld_IsEmpty;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&ISceneWorld_GetWorldDebugName;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&ISceneWorld_SetDeleteAtEndOfFrame;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&ISceneWorld_GetDeleteAtEndOfFrame;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&ISceneWorld_DeleteEndOfFrameObjects;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, int >)&ISceneWorld_MeshTrace;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&ISceneWorld_GetPVS;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&ISceneWorld_SetPVS;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&ISceneWorld_Add3DSkyboxWorld;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&ISceneWorld_Remove3DSkyboxWorld;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, float, void* >)&ISceneWorld_Set3DSkyboxParameters;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&ShdrCmplCntxt_Delete;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&ShdrCmplCntxt_SetMaskedCode;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int >)&ISteamApps_BIsAppInstalled;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&ISteamApps_BIsCybercafe;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int >)&ISteamApps_BIsDlcInstalled;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&ISteamApps_BIsLowViolence;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&ISteamApps_BIsSubscribed;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int >)&ISteamApps_BIsSubscribedApp;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&ISteamApps_GetAvailableGameLanguages;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&ISteamApps_GetCurrentGameLanguage;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&ISteamApps_GetAppBuildId;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&ISteamApps_BIsVACBanned;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&ISteamApps_GetCommandLine;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&ISteamApps_GetAppInstallDir;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong, int, int, void* >)&ISteamFriends_GetProfileItemPropertyString;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong, ulong >)&ISteamFriends_RequestEquippedProfileItems;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&ISteamFriends_GetPersonaName;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, int >)&ISteamFriends_SetRichPresence;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&ISteamFriends_ClearRichPresence;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&ISteamGameServer_SetServerName;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&ISteamGameServer_SetMapName;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&ISteamGameServer_SetGameTags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&ISteamGameServer_SetDedicatedServer;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&ISteamGameServer_SetAdvertiseServerActive;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&ISteamGameServer_SetMaxPlayerCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&ISteamGameServer_LogOnAnonymous;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&ISteamGameServer_LogOn;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&ISteamGameServer_LogOff;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&ISteamGameServer_SetGameDescription;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&ISteamGameServer_SetProduct;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&ISteamGameServer_SetModDir;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&ISteamGameServer_BLoggedOn;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong, void*, void*, void* >)&ISteamGameServer_GetAuthSessionTicket;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong, void*, int, long >)&ISteamGameServer_BeginAuthSession;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&ISteamGameServer_CancelAuthTicket;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong, void* >)&ISteamGameServer_EndAuthSession;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&StmHTMLSrfc_Init;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&StmHTMLSrfc_Shutdown;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, ulong >)&StmHTMLSrfc_CreateBrowser;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, void* >)&StmHTMLSrfc_RemoveBrowser;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, void*, void*, void* >)&StmHTMLSrfc_LoadURL;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, void*, void*, void* >)&StmHTMLSrfc_AddHeader;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, uint, uint, void* >)&StmHTMLSrfc_SetSize;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, uint, uint, void* >)&StmHTMLSrfc_GetLinkAtPosition;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, uint, void* >)&StmHTMLSrfc_SetHorizontalScroll;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, uint, void* >)&StmHTMLSrfc_SetVerticalScroll;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, int, void* >)&StmHTMLSrfc_SetKeyFocus;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, int, void* >)&StmHTMLSrfc_AllowStartRequest;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, int, void* >)&StmHTMLSrfc_JSDialogResponse;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, int, void* >)&StmHTMLSrfc_SetBackgroundMode;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, float, void* >)&StmHTMLSrfc_SetDPIScalingFactor;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, uint, int, int, void* >)&StmHTMLSrfc_KeyDown;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, uint, int, void* >)&StmHTMLSrfc_KeyUp;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, uint, int, void* >)&StmHTMLSrfc_KeyChar;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, int, void* >)&StmHTMLSrfc_MouseUp;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, int, void* >)&StmHTMLSrfc_MouseDown;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, int, void* >)&StmHTMLSrfc_MouseDoubleClick;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, int, int, void* >)&StmHTMLSrfc_MouseMove;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, int, void* >)&StmHTMLSrfc_MouseWheel;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void*, void*, uint, int, int, void* >)&StmHTMLSrfc_SetCookie;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong, void* >)&StmMtchmkng_LeaveLobby;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong, int >)&StmMtchmkng_GetNumLobbyMembers;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong, int, ulong >)&StmMtchmkng_GetLobbyMemberByIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong, void*, void* >)&StmMtchmkng_GetLobbyData;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong, void*, void*, int >)&StmMtchmkng_SetLobbyData;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong, int >)&StmMtchmkng_GetLobbyDataCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong, void*, void* >)&StmMtchmkng_DeleteLobbyData;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong, int, void*, int, void*, int, int >)&StmMtchmkng_GetLobbyDataByIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong, void*, int, int, int, int >)&StmNtwrkngMssgs_SendMessageToUser;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void*, int, int >)&StmNtwrkngMssgs_ReceiveMessagesOnChannel;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong, int >)&StmNtwrkngMssgs_AcceptSessionWithUser;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong, int, int >)&StmNtwrkngMssgs_CloseChannelWithUser;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&StmNtwrkngMssgs_ReleaseMessage;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong, void* >)&StmNtwrkngMssgs_GetConnectionInfo;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&StmNtwrkngSckts_GetConnectionInfo;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&StmNtwrkngSckts_StartAuthentication;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&StmNtwrkngSckts_BeginRequestFakeIP;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&StmNtwrkngSckts_ReleaseMessage;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, int, void* >)&StmNtwrkngtls_SetConfig;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void*, void* >)&StmNtwrkngtls_SetConfig_1;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&StmNtwrkngtls_InitializeRelayNetwork;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&ISteamUser_BLoggedOn;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong >)&ISteamUser_GetSteamID;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void*, uint, void*, int >)&ISteamUser_GetVoice;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int >)&ISteamUser_GetAvailableVoice;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint >)&ISteamUser_GetVoiceOptimalSampleRate;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, uint, void*, uint, void*, uint, int >)&ISteamUser_DecompressVoice;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&ISteamUser_StartVoiceRecording;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&ISteamUser_StopVoiceRecording;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong, void*, void*, void* >)&ISteamUser_GetAuthSessionTicket;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong, void*, int, long >)&ISteamUser_BeginAuthSession;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&ISteamUser_CancelAuthTicket;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong, void* >)&ISteamUser_EndAuthSession;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, int >)&ISteamUtils_InitFilterText;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, ulong, void*, void*, uint, int >)&ISteamUtils_FilterText;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&ITonemapSystem_SetTonemapParameters;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&ITonemapSystem_ResetTonemapParameters;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&IVfx_Init;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, ulong, ulong, void*, long, long, int, uint, void* >)&IVfx_CompileShader;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IVfx_ClearShaderCache;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IVfx_CreateSharedContext;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IVolumetricFog_IsFoggingEnabled;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&IVolumetricFog_SetParams;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IWorldReference_Release;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&IWorldReference_IsWorldLoaded;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&IWorldReference_IsErrorWorld;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&IWorldReference_IsMarkedForDeletion;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, int >)&IWorldReference_GetWorldBounds;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&IWorldReference_GetSceneWorld;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, void* >)&IWorldReference_PrecacheAllWorldNodes;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&IWorldReference_GetFolder;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int >)&IWorldReference_GetEntityCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, void* >)&IWorldReference_GetEntityKeyValues;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&IWorldReference_SetWorldTransform;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&KeyValues3_DeleteThis;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&KeyValues3_Create;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&KeyValues3_IsArray;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&KeyValues3_IsTable;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&KeyValues3_GetType;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&KeyValues3_GetValueBool;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&KeyValues3_GetValueInt;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&KeyValues3_GetValueInt64;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong >)&KeyValues3_GetValueUint64;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&KeyValues3_GetValueFloat;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, double >)&KeyValues3_GetValueDouble;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&KeyValues3_GetValueString;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&KeyValues3_GetValueVector;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&KeyValues3_GetValueColor;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&KeyValues3_SetValueBool;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&KeyValues3_SetValueString;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&KeyValues3_SetValueResourceString;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&KeyValues3_SetValueInt;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&KeyValues3_SetValueFloat;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&KeyValues3_SetMemberString;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, void* >)&KeyValues3_SetMemberInt;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, float, void* >)&KeyValues3_SetMemberFloat;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&KeyValues3_GetMemberString;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, int >)&KeyValues3_GetMemberInt;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, float, float >)&KeyValues3_GetMemberFloat;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&KeyValues3_GetMemberVector;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&KeyValues3_SetToEmptyArray;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&KeyValues3_GetArrayLength;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&KeyValues3_ArrayAddToTail;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&KeyValues3_GetArrayElement;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&KeyValues3_FindOrCreateMember;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&KeyValues3_SetToEmptyTable;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&KeyValues3_GetMemberCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&KeyValues3_GetMember;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&KeyValues3_GetMemberName;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void*, void* >)&MeshGlue_CreateRenderMesh;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, float, void*, void*, void*, int, void*, void*, void*, int, void*, int, void*, int, void*, int, void*, int, void*, int, void*, int, void*, int, void*, int, void*, int, int, int, int, ulong, void* >)&MeshGlue_CreateModel;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&MeshGlue_GetModelNumVertices;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, uint, void* >)&MeshGlue_GetModelVertices;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&MeshGlue_GetModelNumIndices;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, uint, void* >)&MeshGlue_GetModelIndices;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int >)&MeshGlue_GetModelIndexCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int >)&MeshGlue_GetModelIndexStart;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int >)&MeshGlue_GetModelBaseVertex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&MeshGlue_SetMeshMaterial;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&MeshGlue_SetMeshPrimType;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&MeshGlue_SetMeshBounds;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&MeshGlue_SetMeshUvDensity;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int, void* >)&MeshGlue_SetMeshVertexRange;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int, void* >)&MeshGlue_SetMeshIndexRange;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, int, void* >)&MeshGlue_SetMeshVertexBuffer;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, int, void* >)&MeshGlue_SetMeshIndexBuffer;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int, int, void*, void*, int, void*, int, void* >)&MeshGlue_CreateVertexBuffer;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int, int, void*, int, void* >)&MeshGlue_CreateIndexBuffer;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int, void* >)&MeshGlue_LockVertexBuffer;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, int, void* >)&MeshGlue_UnlockVertexBuffer;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, int, void* >)&MeshGlue_LockIndexBuffer;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, int, void* >)&MeshGlue_UnlockIndexBuffer;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, int, void* >)&MeshGlue_SetVertexBufferData;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, int, void* >)&MeshGlue_SetIndexBufferData;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&MeshGlue_SetVertexBufferSize;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&MeshGlue_SetIndexBufferSize;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void*, int, int >)&MeshGlue_TriangulatePolygon;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void*, void*, void*, void* >)&MeshGlue_ClipPolygonLineSegment;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int, long, int >)&NativeEngine_SDLGmCntrllr_GetAxis;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int, long >)&NativeEngine_SDLGmCntrllr_GetControllerType;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int, int >)&NativeEngine_SDLGmCntrllr_Close;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int, int, int, int, int >)&NativeEngine_SDLGmCntrllr_SetLEDColor;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int, int, int, int, int >)&NativeEngine_SDLGmCntrllr_Rumble;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int, int, int, int, int >)&NativeEngine_SDLGmCntrllr_RumbleTriggers;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int, void* >)&NativeEngine_SDLGmCntrllr_GetGyroscope;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int, void* >)&NativeEngine_SDLGmCntrllr_GetAccelerometer;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, void*, long, void* >)&NativeLowLevel_Copy;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, void*, uint, void* >)&PerformanceTrace_BeginEvent;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void* >)&PerformanceTrace_EndEvent;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&PhysicsTrace_Trace;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&PhysicsTrace_TraceAll;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&PhysicsTrace_TraceAgainstCapsule;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&PhysicsTrace_TraceAgainstBBox;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&PhysicsTrace_TraceAgainstSphere;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void*, void*, int >)&RenderTools_SetRenderState;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, void*, void*, int, void*, int, void*, void* >)&RenderTools_Draw;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&RenderTools_ResolveFrameBuffer;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&RenderTools_ResolveDepthBuffer;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void*, void*, void*, void*, void* >)&RenderTools_DrawSceneObject;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void*, int, void*, void* >)&RenderTools_DrawModel;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void*, int, void*, void* >)&RenderTools_DrawModel_1;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, int, int, int, void* >)&RenderTools_Compute;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void*, uint, void* >)&RenderTools_ComputeIndirect;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, uint, uint, uint, void* >)&RenderTools_TraceRays;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void*, uint, void* >)&RenderTools_TraceRaysIndirect;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void*, int, void* >)&RenderTools_SetDynamicConstantBufferData;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void*, int, int, uint, uint, uint, uint, void* >)&RenderTools_CopyTexture;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, uint, uint, void* >)&RenderTools_SetGPUBufferData;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, uint, void* >)&RenderTools_CopyGPUBufferHiddenStructureCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, uint, void* >)&RenderTools_SetGPUBufferHiddenStructureCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&_Get__RnCapsuleDesc_t_m_Capsule;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*, void*>)&_Set__RnCapsuleDesc_t_m_Capsule;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__RnCapsuleDesc_t_m_nCollisionAttributeIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__RnCapsuleDesc_t_m_nCollisionAttributeIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__RnCapsuleDesc_t_m_nSurfacePropertyIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__RnCapsuleDesc_t_m_nSurfacePropertyIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&RnHull_t_GetVertexCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&RnHull_t_GetEdgeCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&RnHull_t_GetVolume;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&RnHull_t_GetMassCenter;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&RnHull_t_GetCentroid;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&RnHull_t_GetSurfaceArea;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&RnHull_t_GetMemory;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&RnHull_t_GetBbox;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&RnHull_t_GetVertex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void*, void*, void* >)&RnHull_t_GetEdgeVertex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&RnHullDesc_t_GetHull;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__RnHullDesc_t_m_nCollisionAttributeIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__RnHullDesc_t_m_nCollisionAttributeIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__RnHullDesc_t_m_nSurfacePropertyIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__RnHullDesc_t_m_nSurfacePropertyIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&RnMesh_t_GetTriangleCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&RnMesh_t_GetHeight;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&RnMesh_t_GetMemory;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&RnMesh_t_GetBbox;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&RnMesh_t_GetMaterialCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void*, void*, void*, void* >)&RnMesh_t_GetTriangle;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&RnMeshDesc_t_GetMesh;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__RnMeshDesc_t_m_nCollisionAttributeIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__RnMeshDesc_t_m_nCollisionAttributeIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__RnMeshDesc_t_m_nSurfacePropertyIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__RnMeshDesc_t_m_nSurfacePropertyIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&_Get__RnSphereDesc_t_m_Sphere;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*, void*>)&_Set__RnSphereDesc_t_m_Sphere;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__RnSphereDesc_t_m_nCollisionAttributeIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__RnSphereDesc_t_m_nCollisionAttributeIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__RnSphereDesc_t_m_nSurfacePropertyIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__RnSphereDesc_t_m_nSurfacePropertyIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nTrianglesRendered;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nTrianglesRendered;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nArtistTrianglesRendered;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nArtistTrianglesRendered;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nRenderBatchDraws;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nRenderBatchDraws;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nDrawCalls;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nDrawCalls;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nDrawPrimitives;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nDrawPrimitives;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nBaseSceneObjectPrimDraws;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nBaseSceneObjectPrimDraws;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nAnimatableObjectPrimDraws;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nAnimatableObjectPrimDraws;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nAggregateSceneObjectPrimDraws;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nAggregateSceneObjectPrimDraws;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nAggregateSceneObjectsFullyCulled;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nAggregateSceneObjectsFullyCulled;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nAggregateSceneObjectDrawCalls;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nAggregateSceneObjectDrawCalls;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nNumMaterialCompute;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nNumMaterialCompute;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nNumMaterialSet;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nNumMaterialSet;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nNumSimilarMaterialSet;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nNumSimilarMaterialSet;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nNumTextureOnlyMaterialSet;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nNumTextureOnlyMaterialSet;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nNumVfxEval;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nNumVfxEval;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nNumVfxRule;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nNumVfxRule;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nNumConstantBufferUpdates;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nNumConstantBufferUpdates;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nNumConstantBufferBytes;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nNumConstantBufferBytes;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nMaterialChangesNonShadow;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nMaterialChangesNonShadow;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nMaterialChangesNonShadowInitial;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nMaterialChangesNonShadowInitial;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nMaterialChangesShadow;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nMaterialChangesShadow;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nMaterialChangesShadowInitial;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nMaterialChangesShadowInitial;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nMaterialChangesShadowAlphaTested;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nMaterialChangesShadowAlphaTested;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nCopyMaterialChangesNonShadow;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nCopyMaterialChangesNonShadow;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nMaxTransformRow;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nMaxTransformRow;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nNumRowsUsed;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nNumRowsUsed;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nNumObjectsTested;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nNumObjectsTested;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nNumObjectsPreCullCheck;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nNumObjectsPreCullCheck;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nNumObjectsPassingCullCheck;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nNumObjectsPassingCullCheck;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nNumVerticesReferenced;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nNumVerticesReferenced;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nNumPrimaryContexts;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nNumPrimaryContexts;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nNumSecondaryContexts;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nNumSecondaryContexts;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nNumDisplayListsSubmitted;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nNumDisplayListsSubmitted;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__ScnSystmPrFrmStt_m_nNumViewsRendered;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__ScnSystmPrFrmStt_m_nNumViewsRendered;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nNumResolves;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nNumResolves;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nNumCullBoxes;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nNumCullBoxes;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, ulong>)&_Get__ScnSystmPrFrmStt_m_nCullingBoxCycleCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, ulong, void*>)&_Set__ScnSystmPrFrmStt_m_nCullingBoxCycleCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nNumObjectsTestedAgainstCullingBoxes;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nNumObjectsTestedAgainstCullingBoxes;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nNumObjectsRejectedByBoundsIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nNumObjectsRejectedByBoundsIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nNumObjectsRejectedByCullBoxes;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nNumObjectsRejectedByCullBoxes;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nNumObjectsRejectedByVis;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nNumObjectsRejectedByVis;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nNumObjectsRejectedByBackfaceCulling;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nNumObjectsRejectedByBackfaceCulling;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nNumObjectsRejectedByScreenSizeCulling;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nNumObjectsRejectedByScreenSizeCulling;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nNumObjectsRejectedByFading;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nNumObjectsRejectedByFading;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nNumFadingObjects;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nNumFadingObjects;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nNumUniqueMaterialsSeen;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nNumUniqueMaterialsSeen;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nNumUnshadowedLightsInView;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nNumUnshadowedLightsInView;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nNumShadowedLightsInView;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nNumShadowedLightsInView;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nNumShadowMaps;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nNumShadowMaps;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nNumRenderTargetBinds;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nNumRenderTargetBinds;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__ScnSystmPrFrmStt_m_nPushConstantSets;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__ScnSystmPrFrmStt_m_nPushConstantSets;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&ShaderTools_GetShaderSource;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long, int, void* >)&ShaderTools_MaskShaderSource;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&SheetSequence_t_FrameCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__SheetSequence_t_m_nId;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__SheetSequence_t_m_nId;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__SheetSequence_t_m_bClamp;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__SheetSequence_t_m_bClamp;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__SheetSequence_t_m_bAlphaCrop;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__SheetSequence_t_m_bAlphaCrop;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__SheetSequence_t_m_bNoColor;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__SheetSequence_t_m_bNoColor;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__SheetSequence_t_m_bNoAlpha;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__SheetSequence_t_m_bNoAlpha;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float>)&_Get__SheetSequence_t_m_flTotalTime;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float, void*>)&_Set__SheetSequence_t_m_flTotalTime;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&ShtSqncFrm_t_ImageCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&ShtSqncFrm_t_GetImage;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float>)&_Get__ShtSqncFrm_t_m_flDisplayTime;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float, void*>)&_Set__ShtSqncFrm_t_m_flDisplayTime;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&Steam_Inventory_GetAllItems;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int >)&Steam_Inventory_DefinitionCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int, int >)&Steam_Inventory_GetDefinitionId;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int, void*, void* >)&Steam_Inventory_GetDefinitionProperty;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int, void*, void*, int >)&Steam_Inventory_GetDefinitionPrice;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int >)&Steam_Inventory_HasPrices;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&Steam_Inventory_GetCurrency;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&Steam_Inventory_CheckOut;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int >)&Steam_Inventory_IsCheckingOut;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< int >)&Steam_Inventory_WasCheckoutSuccessful;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, int, int, int >)&Steam_Screenshots_WriteScreenshot;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< ulong, void* >)&SteamUgc_CUgcInstall_Create;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&SteamUgc_CUgcInstall_Dispose;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&SteamUgc_CUgcInstall_GetResultJson;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__SteamUgc_CUgcInstall_m_complete;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__SteamUgc_CUgcInstall_m_complete;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__SteamUgc_CUgcInstall_m_success;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__SteamUgc_CUgcInstall_m_success;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__SteamUgc_CUgcInstall_m_resultCode;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__SteamUgc_CUgcInstall_m_resultCode;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&SteamUgc_CUgcQuery_CreateQuery;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&SteamUgc_CUgcQuery_Dispose;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&SteamUgc_CUgcQuery_GetResultJson;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__SteamUgc_CUgcQuery_m_complete;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__SteamUgc_CUgcQuery_m_complete;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__SteamUgc_CUgcQuery_m_success;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__SteamUgc_CUgcQuery_m_success;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__SteamUgc_CUgcQuery_m_resultCode;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__SteamUgc_CUgcQuery_m_resultCode;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&SteamUgc_CUgcUpdate_CreateCommunityItem;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&SteamUgc_CUgcUpdate_CreateMtxItem;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< ulong, void* >)&SteamUgc_CUgcUpdate_OpenCommunityItem;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&SteamUgc_CUgcUpdate_Dispose;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong >)&SteamUgc_CUgcUpdate_GetPublishedFileId;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&SteamUgc_CUgcUpdate_SetTitle;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&SteamUgc_CUgcUpdate_SetDescription;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&SteamUgc_CUgcUpdate_SetLanguage;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&SteamUgc_CUgcUpdate_SetMetadata;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&SteamUgc_CUgcUpdate_SetVisibility;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&SteamUgc_CUgcUpdate_SetTag;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&SteamUgc_CUgcUpdate_SetContentFolder;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&SteamUgc_CUgcUpdate_SetPreviewImage;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&SteamUgc_CUgcUpdate_SetAllowLegacyUpload;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&SteamUgc_CUgcUpdate_AddKeyValueTag;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&SteamUgc_CUgcUpdate_RemoveKeyValueTags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&SteamUgc_CUgcUpdate_RemoveAllKeyValueTags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, void* >)&SteamUgc_CUgcUpdate_AddPreviewFile;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&SteamUgc_CUgcUpdate_AddPreviewVideo;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, void*, void* >)&SteamUgc_CUgcUpdate_UpdatePreviewFile;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, void*, void* >)&SteamUgc_CUgcUpdate_UpdatePreviewVideo;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, uint, void* >)&SteamUgc_CUgcUpdate_RemovePreview;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, void* >)&SteamUgc_CUgcUpdate_SetRequiredGameVersions;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int >)&SteamUgc_CUgcUpdate_Submit;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&SteamUgc_CUgcUpdate_GetProgressPercent;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong >)&SteamUgc_CUgcUpdate_GetBytesProcessed;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, ulong >)&SteamUgc_CUgcUpdate_GetBytesTotal;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__SteamUgc_CUgcUpdate_m_creating;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__SteamUgc_CUgcUpdate_m_creating;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__SteamUgc_CUgcUpdate_m_created;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__SteamUgc_CUgcUpdate_m_created;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__SteamUgc_CUgcUpdate_m_submitted;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__SteamUgc_CUgcUpdate_m_submitted;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__SteamUgc_CUgcUpdate_m_complete;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__SteamUgc_CUgcUpdate_m_complete;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__SteamUgc_CUgcUpdate_m_success;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__SteamUgc_CUgcUpdate_m_success;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__SteamUgc_CUgcUpdate_m_bNeedsLegalAgreement;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__SteamUgc_CUgcUpdate_m_bNeedsLegalAgreement;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__SteamUgc_CUgcUpdate_m_resultCode;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__SteamUgc_CUgcUpdate_m_resultCode;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&VertexLayout_Create;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&VertexLayout_Destroy;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&VertexLayout_Free;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, uint, int, void* >)&VertexLayout_Add;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&VertexLayout_Build;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&VfxCmpldShdrnf_t_Delete;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&_Get__VfxCmpldShdrnf_t_compilerOutput;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*, void*>)&_Set__VfxCmpldShdrnf_t_compilerOutput;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__VfxCmpldShdrnf_t_compileFailed;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__VfxCmpldShdrnf_t_compileFailed;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&VPhysXBodyPart_t_GetSphereCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&VPhysXBodyPart_t_GetSphere;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&VPhysXBodyPart_t_GetCapsuleCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&VPhysXBodyPart_t_GetCapsule;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&VPhysXBodyPart_t_GetHullCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&VPhysXBodyPart_t_GetHull;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&VPhysXBodyPart_t_GetMeshCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&VPhysXBodyPart_t_GetMesh;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&VPhysXBodyPart_t_GetCollisionAttributeCount;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, ushort >)&VPhysXBodyPart_t_GetCollisionAttributeIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint>)&_Get__VPhysXBodyPart_t_m_nFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, uint, void*>)&_Set__VPhysXBodyPart_t_m_nFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float>)&_Get__VPhysXBodyPart_t_m_flMass;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float, void*>)&_Set__VPhysXBodyPart_t_m_flMass;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, ushort>)&_Get__VPhysXBodyPart_t_m_nCollisionAttributeIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, ushort, void*>)&_Set__VPhysXBodyPart_t_m_nCollisionAttributeIndex;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float>)&_Get__VPhysXBodyPart_t_m_flInertiaScale;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float, void*>)&_Set__VPhysXBodyPart_t_m_flInertiaScale;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float>)&_Get__VPhysXBodyPart_t_m_flLinearDamping;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float, void*>)&_Set__VPhysXBodyPart_t_m_flLinearDamping;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float>)&_Get__VPhysXBodyPart_t_m_flAngularDamping;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float, void*>)&_Set__VPhysXBodyPart_t_m_flAngularDamping;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__VPhysXBodyPart_t_m_bOverrideMassCenter;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__VPhysXBodyPart_t_m_bOverrideMassCenter;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&_Get__VPhysXBodyPart_t_m_vMassCenterOverride;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*, void*>)&_Set__VPhysXBodyPart_t_m_vMassCenterOverride;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&VPhysXJoint_t_GetLinearLimitMin;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&VPhysXJoint_t_GetLinearLimitMax;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&VPhysXJoint_t_GetSwingLimitMin;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&VPhysXJoint_t_GetSwingLimitMax;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&VPhysXJoint_t_GetTwistLimitMin;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&VPhysXJoint_t_GetTwistLimitMax;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&VPhysXJoint_t_SetLinearLimitMin;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&VPhysXJoint_t_SetLinearLimitMax;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&VPhysXJoint_t_SetSwingLimitMin;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&VPhysXJoint_t_SetSwingLimitMax;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&VPhysXJoint_t_SetTwistLimitMin;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float, void* >)&VPhysXJoint_t_SetTwistLimitMax;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, ushort>)&_Get__VPhysXJoint_t_m_nType;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, ushort, void*>)&_Set__VPhysXJoint_t_m_nType;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, ushort>)&_Get__VPhysXJoint_t_m_nBody1;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, ushort, void*>)&_Set__VPhysXJoint_t_m_nBody1;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, ushort>)&_Get__VPhysXJoint_t_m_nBody2;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, ushort, void*>)&_Set__VPhysXJoint_t_m_nBody2;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, ushort>)&_Get__VPhysXJoint_t_m_nFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, ushort, void*>)&_Set__VPhysXJoint_t_m_nFlags;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__VPhysXJoint_t_m_bEnableCollision;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__VPhysXJoint_t_m_bEnableCollision;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__VPhysXJoint_t_m_bEnableLinearLimit;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__VPhysXJoint_t_m_bEnableLinearLimit;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__VPhysXJoint_t_m_bEnableLinearMotor;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__VPhysXJoint_t_m_bEnableLinearMotor;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&_Get__VPhysXJoint_t_m_vLinearTargetVelocity;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*, void*>)&_Set__VPhysXJoint_t_m_vLinearTargetVelocity;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float>)&_Get__VPhysXJoint_t_m_flMaxForce;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float, void*>)&_Set__VPhysXJoint_t_m_flMaxForce;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__VPhysXJoint_t_m_bEnableSwingLimit;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__VPhysXJoint_t_m_bEnableSwingLimit;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__VPhysXJoint_t_m_bEnableTwistLimit;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__VPhysXJoint_t_m_bEnableTwistLimit;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int>)&_Get__VPhysXJoint_t_m_bEnableAngularMotor;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, int, void*>)&_Set__VPhysXJoint_t_m_bEnableAngularMotor;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&_Get__VPhysXJoint_t_m_vAngularTargetVelocity;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*, void*>)&_Set__VPhysXJoint_t_m_vAngularTargetVelocity;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float>)&_Get__VPhysXJoint_t_m_flMaxTorque;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float, void*>)&_Set__VPhysXJoint_t_m_flMaxTorque;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float>)&_Get__VPhysXJoint_t_m_flLinearFrequency;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float, void*>)&_Set__VPhysXJoint_t_m_flLinearFrequency;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float>)&_Get__VPhysXJoint_t_m_flLinearDampingRatio;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float, void*>)&_Set__VPhysXJoint_t_m_flLinearDampingRatio;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float>)&_Get__VPhysXJoint_t_m_flAngularFrequency;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float, void*>)&_Set__VPhysXJoint_t_m_flAngularFrequency;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float>)&_Get__VPhysXJoint_t_m_flAngularDampingRatio;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float, void*>)&_Set__VPhysXJoint_t_m_flAngularDampingRatio;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float>)&_Get__VPhysXJoint_t_m_flLinearStrength;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float, void*>)&_Set__VPhysXJoint_t_m_flLinearStrength;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float>)&_Get__VPhysXJoint_t_m_flAngularStrength;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, float, void*>)&_Set__VPhysXJoint_t_m_flAngularStrength;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&_Get__VPhysXJoint_t_m_Frame1;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*, void*>)&_Set__VPhysXJoint_t_m_Frame1;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*>)&_Get__VPhysXJoint_t_m_Frame2;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]<void*, void*, void*>)&_Set__VPhysXJoint_t_m_Frame2;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&VSound_t_DestroyStrongHandle;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, int >)&VSound_t_IsStrongHandleValid;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, int >)&VSound_t_IsError;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, int >)&VSound_t_IsStrongHandleLoaded;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, void* >)&VSound_t_CopyStrongHandle;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged[SuppressGCTransition]< void*, void* >)&VSound_t_GetBindingPtr;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, long >)&VSound_t_format;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&VSound_t_BitsPerSample;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&VSound_t_channels;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&VSound_t_BytesPerSample;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&VSound_t_m_sampleFrameSize;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int >)&VSound_t_m_rate;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, float >)&VSound_t_Duration;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&WindowsGlue_FindFile;
 	}

        [UnmanagedCallersOnly(EntryPoint = "CnmtnGrpBldr_DeleteThis")]
        public static void* CnmtnGrpBldr_DeleteThis( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnmtnGrpBldr_Create")]
        public static void* CnmtnGrpBldr_Create()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnmtnGrpBldr_AddAnimation")]
        public static int CnmtnGrpBldr_AddAnimation( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnmtnGrpBldr_AddFrame")]
        public static void* CnmtnGrpBldr_AddFrame( void* self, int nAnimation, void* pBoneTransforms, int nNumBoneTransforms )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnmtnGrpBldr_SetName")]
        public static void* CnmtnGrpBldr_SetName( void* self, int nAnimation, void* pName )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnmtnGrpBldr_SetFrameRate")]
        public static void* CnmtnGrpBldr_SetFrameRate( void* self, int nAnimation, float fps )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnmtnGrpBldr_SetLooping")]
        public static void* CnmtnGrpBldr_SetLooping( void* self, int nAnimation, int looping )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnmtnGrpBldr_SetDelta")]
        public static void* CnmtnGrpBldr_SetDelta( void* self, int nAnimation, int delta )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnmtnGrpBldr_SetDisableInterpolation")]
        public static void* CnmtnGrpBldr_SetDisableInterpolation( void* self, int nAnimation, int disableInterpolation )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CAttachment_GetInfluenceName")]
        public static void* CAttachment_GetInfluenceName( void* self, int index )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CAttachment_GetInfluenceOffset")]
        public static void* CAttachment_GetInfluenceOffset( void* self, int index )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CAttachment_GetInfluenceRotation")]
        public static void* CAttachment_GetInfluenceRotation( void* self, int index )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CAttachment_m_name", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Get__CAttachment_m_name( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CAttachment_m_name", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CAttachment_m_name( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CAttachment_m_nInfluences", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static byte _Get__CAttachment_m_nInfluences( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CAttachment_m_nInfluences", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CAttachment_m_nInfluences( void* self, byte value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CAttachment_m_bIgnoreRotation", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__CAttachment_m_bIgnoreRotation( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CAttachment_m_bIgnoreRotation", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CAttachment_m_bIgnoreRotation( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CAudioMixBuffer_Create", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* CAudioMixBuffer_Create()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CAudioMixBuffer_Dispose", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* CAudioMixBuffer_Dispose( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CAudioMixBuffer_GetDataPointer", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* CAudioMixBuffer_GetDataPointer( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CAudioMixBuffer_Silence", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* CAudioMixBuffer_Silence( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CAudioMixBuffer_AbsLevel", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static float CAudioMixBuffer_AbsLevel( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CAudioMixBuffer_AvergeLevel", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static float CAudioMixBuffer_AvergeLevel( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CAudioMixBuffer_Ramp", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* CAudioMixBuffer_Ramp( void* self, float flStart, float flEnd )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CAudioMixBuffer_CopyFrom", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* CAudioMixBuffer_CopyFrom( void* self, void* addThis )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CAudioMixBuffer_Mix", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* CAudioMixBuffer_Mix( void* self, void* addThis, float flScale )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CAudioMixBuffer_MixRamp", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* CAudioMixBuffer_MixRamp( void* self, void* addThis, float flScaleStart, float flScaleEnd )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CdMxDvcBffrs_Create", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* CdMxDvcBffrs_Create( int channels )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CdMxDvcBffrs_Destroy", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* CdMxDvcBffrs_Destroy( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CdMxDvcBffrs_GetBuffer", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* CdMxDvcBffrs_GetBuffer( void* self, int i )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CAudioMixer_Dispose", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* CAudioMixer_Dispose( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CAudioMixer_GetSamplePosition", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int CAudioMixer_GetSamplePosition( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CAudioMixer_ShouldContinueMixing", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int CAudioMixer_ShouldContinueMixing( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CAudioMixer_SetSamplePosition")]
        public static void* CAudioMixer_SetSamplePosition( void* self, int position )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CAudioMixer_SetSampleEnd", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* CAudioMixer_SetSampleEnd( void* self, uint nEndSample )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CAudioMixer_DelayOrSkipSamples", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* CAudioMixer_DelayOrSkipSamples( void* self, int nDelaySamples )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CAudioMixer_IsReadyToMix")]
        public static int CAudioMixer_IsReadyToMix( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CAudioMixer_GetPositionForSave", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int CAudioMixer_GetPositionForSave( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CAudioMixer_SetPositionFromSaved")]
        public static void* CAudioMixer_SetPositionFromSaved( void* self, int savedPosition )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CAudioMixer_UpdateMixerState")]
        public static void* CAudioMixer_UpdateMixerState( void* self, void* state )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CAudioMixer_GetIndexState")]
        public static void* CAudioMixer_GetIndexState( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CAudioMixer_GetSfxTable", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* CAudioMixer_GetSfxTable( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CAudioMixer_GetSampleCount", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int CAudioMixer_GetSampleCount( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CAudioMixer_GetChannelCount", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int CAudioMixer_GetChannelCount( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CAudioMixer_SetTimeScale", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int CAudioMixer_SetTimeScale( void* self, float flTimeScale )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CAudioMixer_EnableLooping", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* CAudioMixer_EnableLooping( void* self, int bEnable )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CAudioMixer_ReadToBuffer")]
        public static void* CAudioMixer_ReadToBuffer( void* self, float pitch, void* buffers )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CAudioProcessor_Dispose")]
        public static void* CAudioProcessor_Dispose( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CAudioProcessor_Process")]
        public static void* CAudioProcessor_Process( void* self, void* pInput, void* pOutput, int nChannelCount )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CAudioProcessor_SetControlParameter")]
        public static int CAudioProcessor_SetControlParameter( void* self, void* name, float flValue )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CAudioProcessor_SetNameParameter")]
        public static int CAudioProcessor_SetNameParameter( void* self, void* name, void* nNameValue )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CAudioProcessor_CreateDelay")]
        public static void* CAudioProcessor_CreateDelay( int channels )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CAudioProcessor_CreatePitchShift")]
        public static void* CAudioProcessor_CreatePitchShift( int channels )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CdStrmMngd_Create")]
        public static int CdStrmMngd_Create( int nChannels, uint nSampleRate )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CdStrmMngd_Destroy")]
        public static void* CdStrmMngd_Destroy( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CdStrmMngd_WriteAudioData")]
        public static void* CdStrmMngd_WriteAudioData( void* self, void* pData, uint nSampleCount, uint nChannels )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CdStrmMngd_QueuedSampleCount")]
        public static uint CdStrmMngd_QueuedSampleCount( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CdStrmMngd_MaxWriteSampleCount")]
        public static uint CdStrmMngd_MaxWriteSampleCount( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CdStrmMngd_LatencySamplesCount")]
        public static uint CdStrmMngd_LatencySamplesCount( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CdStrmMngd_Pause")]
        public static void* CdStrmMngd_Pause( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CdStrmMngd_Resume")]
        public static void* CdStrmMngd_Resume( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CdStrmMngd_GetName")]
        public static void* CdStrmMngd_GetName( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CdStrmMngd_GetSfxTable")]
        public static void* CdStrmMngd_GetSfxTable( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CBinauralEffect_Create", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* CBinauralEffect_Create()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CBinauralEffect_Dispose", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* CBinauralEffect_Dispose( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CBinauralEffect_Apply", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* CBinauralEffect_Apply( void* self, void* localDirection, float spatialBlend, void* input, void* output )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CBldrMtrlGrp_AddMaterial")]
        public static void* CBldrMtrlGrp_AddMaterial( void* self, void* hMat )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CBldrMtrlGrp_m_name", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Get__CBldrMtrlGrp_m_name( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CBldrMtrlGrp_m_name", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CBldrMtrlGrp_m_name( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CBldrMtrlGrprry_DeleteThis")]
        public static void* CBldrMtrlGrprry_DeleteThis( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CBldrMtrlGrprry_Create")]
        public static void* CBldrMtrlGrprry_Create( int count )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CBldrMtrlGrprry_Get")]
        public static void* CBldrMtrlGrprry_Get( void* self, int index )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CCameraRenderer_DeleteThis")]
        public static void* CCameraRenderer_DeleteThis( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CCameraRenderer_Create")]
        public static void* CCameraRenderer_Create( void* name, int cameraId )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CCameraRenderer_ClearSceneWorlds")]
        public static void* CCameraRenderer_ClearSceneWorlds( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CCameraRenderer_AddSceneWorld")]
        public static void* CCameraRenderer_AddSceneWorld( void* self, void* world )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CCameraRenderer_SetRenderAttributes")]
        public static void* CCameraRenderer_SetRenderAttributes( void* self, void* attributes )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CCameraRenderer_Render")]
        public static void* CCameraRenderer_Render( void* self, void* targetSwapChain )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CCameraRenderer_RenderToTexture")]
        public static void* CCameraRenderer_RenderToTexture( void* self, void* hTexture, void* parentView )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CCameraRenderer_RenderToCubeTexture")]
        public static void* CCameraRenderer_RenderToCubeTexture( void* self, void* hTexture, int nSlice )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CCameraRenderer_RenderToBitmap")]
        public static void* CCameraRenderer_RenderToBitmap( void* self, void* pixels, int width, int height, int bytesPerPixel )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CCameraRenderer_RenderStereo")]
        public static void* CCameraRenderer_RenderStereo( void* self, int eye, int eyeWidth, int eyeHeight, int bSubmitThisEye )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CCameraRenderer_SubmitStereo")]
        public static void* CCameraRenderer_SubmitStereo( void* self, int eyeWidth, int eyeHeight )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CCameraRenderer_BlitStereo")]
        public static void* CCameraRenderer_BlitStereo( void* self, int eyeWidth, int eyeHeight )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CCameraRenderer_ClearRenderTags")]
        public static void* CCameraRenderer_ClearRenderTags( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CCameraRenderer_ClearExcludeTags")]
        public static void* CCameraRenderer_ClearExcludeTags( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CCameraRenderer_AddRenderTag")]
        public static void* CCameraRenderer_AddRenderTag( void* self, uint hash )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CCameraRenderer_AddExcludeTag")]
        public static void* CCameraRenderer_AddExcludeTag( void* self, uint hash )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CCameraRenderer_ViewUniqueId", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__CCameraRenderer_ViewUniqueId( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CCameraRenderer_ViewUniqueId", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CCameraRenderer_ViewUniqueId( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CCameraRenderer_CameraPosition", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Get__CCameraRenderer_CameraPosition( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CCameraRenderer_CameraPosition", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CCameraRenderer_CameraPosition( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CCameraRenderer_CameraRotation", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Get__CCameraRenderer_CameraRotation( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CCameraRenderer_CameraRotation", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CCameraRenderer_CameraRotation( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CCameraRenderer_FieldOfView", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static float _Get__CCameraRenderer_FieldOfView( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CCameraRenderer_FieldOfView", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CCameraRenderer_FieldOfView( void* self, float value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CCameraRenderer_ZNear", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static float _Get__CCameraRenderer_ZNear( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CCameraRenderer_ZNear", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CCameraRenderer_ZNear( void* self, float value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CCameraRenderer_ZFar", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static float _Get__CCameraRenderer_ZFar( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CCameraRenderer_ZFar", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CCameraRenderer_ZFar( void* self, float value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CCameraRenderer_Rect", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Get__CCameraRenderer_Rect( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CCameraRenderer_Rect", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CCameraRenderer_Rect( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CCameraRenderer_Viewport", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Get__CCameraRenderer_Viewport( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CCameraRenderer_Viewport", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CCameraRenderer_Viewport( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CCameraRenderer_ClipSpaceBounds", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Get__CCameraRenderer_ClipSpaceBounds( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CCameraRenderer_ClipSpaceBounds", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CCameraRenderer_ClipSpaceBounds( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CCameraRenderer_EnablePostprocessing", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__CCameraRenderer_EnablePostprocessing( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CCameraRenderer_EnablePostprocessing", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CCameraRenderer_EnablePostprocessing( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CCameraRenderer_EnableEngineOverlays", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__CCameraRenderer_EnableEngineOverlays( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CCameraRenderer_EnableEngineOverlays", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CCameraRenderer_EnableEngineOverlays( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CCameraRenderer_Ortho", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__CCameraRenderer_Ortho( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CCameraRenderer_Ortho", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CCameraRenderer_Ortho( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CCameraRenderer_OrthoSize", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static float _Get__CCameraRenderer_OrthoSize( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CCameraRenderer_OrthoSize", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CCameraRenderer_OrthoSize( void* self, float value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CCameraRenderer_NeedTonemapRenderer", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__CCameraRenderer_NeedTonemapRenderer( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CCameraRenderer_NeedTonemapRenderer", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CCameraRenderer_NeedTonemapRenderer( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CCameraRenderer_SceneViewFlags", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static long _Get__CCameraRenderer_SceneViewFlags( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CCameraRenderer_SceneViewFlags", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CCameraRenderer_SceneViewFlags( void* self, long value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CCameraRenderer_IsRenderingStereo", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__CCameraRenderer_IsRenderingStereo( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CCameraRenderer_IsRenderingStereo", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CCameraRenderer_IsRenderingStereo( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CCameraRenderer_MiddleEyePosition", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Get__CCameraRenderer_MiddleEyePosition( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CCameraRenderer_MiddleEyePosition", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CCameraRenderer_MiddleEyePosition( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CCameraRenderer_MiddleEyeRotation", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Get__CCameraRenderer_MiddleEyeRotation( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CCameraRenderer_MiddleEyeRotation", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CCameraRenderer_MiddleEyeRotation( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CCameraRenderer_OverrideProjection", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Get__CCameraRenderer_OverrideProjection( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CCameraRenderer_OverrideProjection", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CCameraRenderer_OverrideProjection( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CCameraRenderer_HasOverrideProjection", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__CCameraRenderer_HasOverrideProjection( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CCameraRenderer_HasOverrideProjection", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CCameraRenderer_HasOverrideProjection( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CCameraRenderer_FlipX", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__CCameraRenderer_FlipX( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CCameraRenderer_FlipX", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CCameraRenderer_FlipX( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CCameraRenderer_FlipY", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__CCameraRenderer_FlipY( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CCameraRenderer_FlipY", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CCameraRenderer_FlipY( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "From_CSceneObject_To_CDecalSceneObject", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* From_CSceneObject_To_CDecalSceneObject( void* ptr ) => ptr;
        [UnmanagedCallersOnly(EntryPoint = "To_CSceneObject_From_CDecalSceneObject", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* To_CSceneObject_From_CDecalSceneObject( void* ptr ) => ptr;
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_ChangeFlags")]
        public static void* CDclScnbjct_ChangeFlags( void* self, long nNewFlags, long nNewFlagsMask )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_SetFlags")]
        public static void* CDclScnbjct_SetFlags( void* self, long nFlagsToOR )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_HasFlags")]
        public static int CDclScnbjct_HasFlags( void* self, long nFlags )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_GetFlags")]
        public static long CDclScnbjct_GetFlags( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_GetOriginalFlags")]
        public static long CDclScnbjct_GetOriginalFlags( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_ClearFlags")]
        public static void* CDclScnbjct_ClearFlags( void* self, long nFlagsToClear )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_SetCullDistance")]
        public static void* CDclScnbjct_SetCullDistance( void* self, float dist )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_EnableLightingCache")]
        public static void* CDclScnbjct_EnableLightingCache( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_SetLightingOrigin")]
        public static void* CDclScnbjct_SetLightingOrigin( void* self, void* vPos, int worldspace )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_GetLightingOrigin")]
        public static void* CDclScnbjct_GetLightingOrigin( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_HasLightingOrigin")]
        public static int CDclScnbjct_HasLightingOrigin( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_SetTintRGBA")]
        public static void* CDclScnbjct_SetTintRGBA( void* self, void* color )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_GetTintRGBA")]
        public static void* CDclScnbjct_GetTintRGBA( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_SetAlphaFade")]
        public static void* CDclScnbjct_SetAlphaFade( void* self, float nAlpha )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_GetAlphaFade")]
        public static float CDclScnbjct_GetAlphaFade( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_SetMaterialOverrideForMeshInstances")]
        public static void* CDclScnbjct_SetMaterialOverrideForMeshInstances( void* self, void* mat )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_ClearMaterialOverrideList")]
        public static void* CDclScnbjct_ClearMaterialOverrideList( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_SetMaterialOverride")]
        public static void* CDclScnbjct_SetMaterialOverride( void* self, void* hMaterial, void* nAttr, int nAttrValueMatch )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_IsLoaded")]
        public static int CDclScnbjct_IsLoaded( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_IsRenderingEnabled")]
        public static int CDclScnbjct_IsRenderingEnabled( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_SetLoaded")]
        public static void* CDclScnbjct_SetLoaded( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_ClearLoaded")]
        public static void* CDclScnbjct_ClearLoaded( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_DisableRendering")]
        public static void* CDclScnbjct_DisableRendering( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_EnableRendering")]
        public static void* CDclScnbjct_EnableRendering( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_SetRenderingEnabled")]
        public static void* CDclScnbjct_SetRenderingEnabled( void* self, int bEnabled )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_GetBoundingSphereRadius")]
        public static float CDclScnbjct_GetBoundingSphereRadius( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_SetTransform")]
        public static void* CDclScnbjct_SetTransform( void* self, void* tx )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_GetCTransform")]
        public static void* CDclScnbjct_GetCTransform( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_SetBounds")]
        public static void* CDclScnbjct_SetBounds( void* self, void* box )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_GetBounds")]
        public static void* CDclScnbjct_GetBounds( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_SetBoundsInfinite")]
        public static void* CDclScnbjct_SetBoundsInfinite( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_GetParent")]
        public static int CDclScnbjct_GetParent( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_AddChildObject")]
        public static void* CDclScnbjct_AddChildObject( void* self, void* nId, void* pChild, uint nChildUpdateFlags )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_RemoveChild")]
        public static void* CDclScnbjct_RemoveChild( void* self, void* obj )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_GetAttributesPtrForModify")]
        public static void* CDclScnbjct_GetAttributesPtrForModify( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_EnableMeshGroups")]
        public static void* CDclScnbjct_EnableMeshGroups( void* self, ulong nMask )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_DisableMeshGroups")]
        public static void* CDclScnbjct_DisableMeshGroups( void* self, ulong nMask )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_ResetMeshGroups")]
        public static void* CDclScnbjct_ResetMeshGroups( void* self, ulong nMask )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_GetCurrentMeshGroupMask")]
        public static ulong CDclScnbjct_GetCurrentMeshGroupMask( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_GetWorld")]
        public static int CDclScnbjct_GetWorld( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_SetLOD")]
        public static void* CDclScnbjct_SetLOD( void* self, int nLOD )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_DisableLOD")]
        public static void* CDclScnbjct_DisableLOD( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_GetCurrentLODGroupMask")]
        public static ulong CDclScnbjct_GetCurrentLODGroupMask( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_GetCurrentLODLevel")]
        public static int CDclScnbjct_GetCurrentLODLevel( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_GetModelHandle")]
        public static void* CDclScnbjct_GetModelHandle( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_SetMaterialGroup")]
        public static void* CDclScnbjct_SetMaterialGroup( void* self, void* token )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_SetBodyGroup")]
        public static void* CDclScnbjct_SetBodyGroup( void* self, void* token, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_SetBatchable")]
        public static void* CDclScnbjct_SetBatchable( void* self, int bIsBatchable )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_IsNotBatchable")]
        public static int CDclScnbjct_IsNotBatchable( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_SetUniqueBatchGroup")]
        public static void* CDclScnbjct_SetUniqueBatchGroup( void* self, int bUnique )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_RemoveTag")]
        public static void* CDclScnbjct_RemoveTag( void* self, uint tag )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_RemoveAllTags")]
        public static void* CDclScnbjct_RemoveAllTags( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_GetTagCount")]
        public static int CDclScnbjct_GetTagCount( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_GetTagAt")]
        public static uint CDclScnbjct_GetTagAt( void* self, int i )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_AddTag")]
        public static void* CDclScnbjct_AddTag( void* self, uint tag )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_HasTag")]
        public static int CDclScnbjct_HasTag( void* self, uint tag )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_SetForceLayerID")]
        public static void* CDclScnbjct_SetForceLayerID( void* self, void* nTok )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_SetLayerMatchID")]
        public static void* CDclScnbjct_SetLayerMatchID( void* self, void* nTok )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_UpdateFlagsBasedOnMaterial")]
        public static void* CDclScnbjct_UpdateFlagsBasedOnMaterial( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDclScnbjct_SetMaterialOverrideByIndex")]
        public static void* CDclScnbjct_SetMaterialOverrideByIndex( void* self, int index, void* material )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CDclScnbjct_m_hColor", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Get__CDclScnbjct_m_hColor( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CDclScnbjct_m_hColor", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CDclScnbjct_m_hColor( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CDclScnbjct_m_hNormal", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Get__CDclScnbjct_m_hNormal( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CDclScnbjct_m_hNormal", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CDclScnbjct_m_hNormal( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CDclScnbjct_m_hRMO", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Get__CDclScnbjct_m_hRMO( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CDclScnbjct_m_hRMO", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CDclScnbjct_m_hRMO( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CDclScnbjct_m_nSortOrder", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__CDclScnbjct_m_nSortOrder( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CDclScnbjct_m_nSortOrder", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CDclScnbjct_m_nSortOrder( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CDclScnbjct_m_nExclusionBitMask", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__CDclScnbjct_m_nExclusionBitMask( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CDclScnbjct_m_nExclusionBitMask", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CDclScnbjct_m_nExclusionBitMask( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CDclScnbjct_m_vColorTint", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Get__CDclScnbjct_m_vColorTint( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CDclScnbjct_m_vColorTint", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CDclScnbjct_m_vColorTint( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CDclScnbjct_m_flAttenuationAngle", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static float _Get__CDclScnbjct_m_flAttenuationAngle( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CDclScnbjct_m_flAttenuationAngle", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CDclScnbjct_m_flAttenuationAngle( void* self, float value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CDclScnbjct_m_flColorMix", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static float _Get__CDclScnbjct_m_flColorMix( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CDclScnbjct_m_flColorMix", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CDclScnbjct_m_flColorMix( void* self, float value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CDclScnbjct_m_hEmission", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Get__CDclScnbjct_m_hEmission( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CDclScnbjct_m_hEmission", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CDclScnbjct_m_hEmission( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CDclScnbjct_m_flEmissionEnergy", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static float _Get__CDclScnbjct_m_flEmissionEnergy( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CDclScnbjct_m_flEmissionEnergy", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CDclScnbjct_m_flEmissionEnergy( void* self, float value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CDclScnbjct_m_nSequenceIndex", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__CDclScnbjct_m_nSequenceIndex( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CDclScnbjct_m_nSequenceIndex", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CDclScnbjct_m_nSequenceIndex( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CDclScnbjct_m_hHeight", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Get__CDclScnbjct_m_hHeight( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CDclScnbjct_m_hHeight", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CDclScnbjct_m_hHeight( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CDclScnbjct_m_flParallaxStrength", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static float _Get__CDclScnbjct_m_flParallaxStrength( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CDclScnbjct_m_flParallaxStrength", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CDclScnbjct_m_flParallaxStrength( void* self, float value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CDclScnbjct_m_nSamplerIndex", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__CDclScnbjct_m_nSamplerIndex( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CDclScnbjct_m_nSamplerIndex", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CDclScnbjct_m_nSamplerIndex( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "From_CSceneObject_To_CDynamicSceneObject", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* From_CSceneObject_To_CDynamicSceneObject( void* ptr ) => ptr;
        [UnmanagedCallersOnly(EntryPoint = "To_CSceneObject_From_CDynamicSceneObject", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* To_CSceneObject_From_CDynamicSceneObject( void* ptr ) => ptr;
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_Create")]
        public static int CDynmcScnbjct_Create( void* world )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_Begin", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* CDynmcScnbjct_Begin( void* self, long type, int vertexCount )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_End", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* CDynmcScnbjct_End( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_AddVertex", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* CDynmcScnbjct_AddVertex( void* self, void* vertex )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_AddVertexRange", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* CDynmcScnbjct_AddVertexRange( void* self, void* vertex, int length )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_Reset", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* CDynmcScnbjct_Reset( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_ChangeFlags")]
        public static void* CDynmcScnbjct_ChangeFlags( void* self, long nNewFlags, long nNewFlagsMask )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_SetFlags")]
        public static void* CDynmcScnbjct_SetFlags( void* self, long nFlagsToOR )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_HasFlags")]
        public static int CDynmcScnbjct_HasFlags( void* self, long nFlags )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_GetFlags")]
        public static long CDynmcScnbjct_GetFlags( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_GetOriginalFlags")]
        public static long CDynmcScnbjct_GetOriginalFlags( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_ClearFlags")]
        public static void* CDynmcScnbjct_ClearFlags( void* self, long nFlagsToClear )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_SetCullDistance")]
        public static void* CDynmcScnbjct_SetCullDistance( void* self, float dist )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_EnableLightingCache")]
        public static void* CDynmcScnbjct_EnableLightingCache( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_SetLightingOrigin")]
        public static void* CDynmcScnbjct_SetLightingOrigin( void* self, void* vPos, int worldspace )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_GetLightingOrigin")]
        public static void* CDynmcScnbjct_GetLightingOrigin( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_HasLightingOrigin")]
        public static int CDynmcScnbjct_HasLightingOrigin( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_SetTintRGBA")]
        public static void* CDynmcScnbjct_SetTintRGBA( void* self, void* color )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_GetTintRGBA")]
        public static void* CDynmcScnbjct_GetTintRGBA( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_SetAlphaFade")]
        public static void* CDynmcScnbjct_SetAlphaFade( void* self, float nAlpha )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_GetAlphaFade")]
        public static float CDynmcScnbjct_GetAlphaFade( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_SetMaterialOverrideForMeshInstances")]
        public static void* CDynmcScnbjct_SetMaterialOverrideForMeshInstances( void* self, void* mat )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_ClearMaterialOverrideList")]
        public static void* CDynmcScnbjct_ClearMaterialOverrideList( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_SetMaterialOverride")]
        public static void* CDynmcScnbjct_SetMaterialOverride( void* self, void* hMaterial, void* nAttr, int nAttrValueMatch )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_IsLoaded")]
        public static int CDynmcScnbjct_IsLoaded( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_IsRenderingEnabled")]
        public static int CDynmcScnbjct_IsRenderingEnabled( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_SetLoaded")]
        public static void* CDynmcScnbjct_SetLoaded( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_ClearLoaded")]
        public static void* CDynmcScnbjct_ClearLoaded( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_DisableRendering")]
        public static void* CDynmcScnbjct_DisableRendering( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_EnableRendering")]
        public static void* CDynmcScnbjct_EnableRendering( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_SetRenderingEnabled")]
        public static void* CDynmcScnbjct_SetRenderingEnabled( void* self, int bEnabled )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_GetBoundingSphereRadius")]
        public static float CDynmcScnbjct_GetBoundingSphereRadius( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_SetTransform")]
        public static void* CDynmcScnbjct_SetTransform( void* self, void* tx )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_GetCTransform")]
        public static void* CDynmcScnbjct_GetCTransform( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_SetBounds")]
        public static void* CDynmcScnbjct_SetBounds( void* self, void* box )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_GetBounds")]
        public static void* CDynmcScnbjct_GetBounds( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_SetBoundsInfinite")]
        public static void* CDynmcScnbjct_SetBoundsInfinite( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_GetParent")]
        public static int CDynmcScnbjct_GetParent( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_AddChildObject")]
        public static void* CDynmcScnbjct_AddChildObject( void* self, void* nId, void* pChild, uint nChildUpdateFlags )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_RemoveChild")]
        public static void* CDynmcScnbjct_RemoveChild( void* self, void* obj )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_GetAttributesPtrForModify")]
        public static void* CDynmcScnbjct_GetAttributesPtrForModify( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_EnableMeshGroups")]
        public static void* CDynmcScnbjct_EnableMeshGroups( void* self, ulong nMask )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_DisableMeshGroups")]
        public static void* CDynmcScnbjct_DisableMeshGroups( void* self, ulong nMask )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_ResetMeshGroups")]
        public static void* CDynmcScnbjct_ResetMeshGroups( void* self, ulong nMask )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_GetCurrentMeshGroupMask")]
        public static ulong CDynmcScnbjct_GetCurrentMeshGroupMask( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_GetWorld")]
        public static int CDynmcScnbjct_GetWorld( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_SetLOD")]
        public static void* CDynmcScnbjct_SetLOD( void* self, int nLOD )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_DisableLOD")]
        public static void* CDynmcScnbjct_DisableLOD( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_GetCurrentLODGroupMask")]
        public static ulong CDynmcScnbjct_GetCurrentLODGroupMask( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_GetCurrentLODLevel")]
        public static int CDynmcScnbjct_GetCurrentLODLevel( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_GetModelHandle")]
        public static void* CDynmcScnbjct_GetModelHandle( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_SetMaterialGroup")]
        public static void* CDynmcScnbjct_SetMaterialGroup( void* self, void* token )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_SetBodyGroup")]
        public static void* CDynmcScnbjct_SetBodyGroup( void* self, void* token, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_SetBatchable")]
        public static void* CDynmcScnbjct_SetBatchable( void* self, int bIsBatchable )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_IsNotBatchable")]
        public static int CDynmcScnbjct_IsNotBatchable( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_SetUniqueBatchGroup")]
        public static void* CDynmcScnbjct_SetUniqueBatchGroup( void* self, int bUnique )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_RemoveTag")]
        public static void* CDynmcScnbjct_RemoveTag( void* self, uint tag )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_RemoveAllTags")]
        public static void* CDynmcScnbjct_RemoveAllTags( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_GetTagCount")]
        public static int CDynmcScnbjct_GetTagCount( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_GetTagAt")]
        public static uint CDynmcScnbjct_GetTagAt( void* self, int i )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_AddTag")]
        public static void* CDynmcScnbjct_AddTag( void* self, uint tag )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_HasTag")]
        public static int CDynmcScnbjct_HasTag( void* self, uint tag )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_SetForceLayerID")]
        public static void* CDynmcScnbjct_SetForceLayerID( void* self, void* nTok )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_SetLayerMatchID")]
        public static void* CDynmcScnbjct_SetLayerMatchID( void* self, void* nTok )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_UpdateFlagsBasedOnMaterial")]
        public static void* CDynmcScnbjct_UpdateFlagsBasedOnMaterial( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CDynmcScnbjct_SetMaterialOverrideByIndex")]
        public static void* CDynmcScnbjct_SetMaterialOverrideByIndex( void* self, int index, void* material )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CDynmcScnbjct_Material", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Get__CDynmcScnbjct_Material( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CDynmcScnbjct_Material", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CDynmcScnbjct_Material( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CEntityKeyValues_GetValueString")]
        public static void* CEntityKeyValues_GetValueString( void* self, void* key, void* pDefaultValue )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CEntityKeyValues_GetKeyCount")]
        public static int CEntityKeyValues_GetKeyCount( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CEntityKeyValues_GetKey")]
        public static uint CEntityKeyValues_GetKey( void* self, int nIdx )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CEntityKeyValues_GetValueString_1")]
        public static void* CEntityKeyValues_GetValueString_1( void* self, uint key, void* pDefaultValue )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "From_CSceneLightObject_To_CEnvMapSceneObject", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* From_CSceneLightObject_To_CEnvMapSceneObject( void* ptr ) => ptr;
        [UnmanagedCallersOnly(EntryPoint = "To_CSceneLightObject_From_CEnvMapSceneObject", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* To_CSceneLightObject_From_CEnvMapSceneObject( void* ptr ) => ptr;
        [UnmanagedCallersOnly(EntryPoint = "From_CSceneObject_To_CEnvMapSceneObject", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* From_CSceneObject_To_CEnvMapSceneObject( void* ptr ) => ptr;
        [UnmanagedCallersOnly(EntryPoint = "To_CSceneObject_From_CEnvMapSceneObject", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* To_CSceneObject_From_CEnvMapSceneObject( void* ptr ) => ptr;
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_CalculateRadianceSH")]
        public static void* CnvMpScnbjct_CalculateRadianceSH( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_CalculateRadianceSH_1")]
        public static void* CnvMpScnbjct_CalculateRadianceSH_1( void* self, void* hTexture )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_CalculateNormalizationSH")]
        public static void* CnvMpScnbjct_CalculateNormalizationSH( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_CalculateBounds")]
        public static void* CnvMpScnbjct_CalculateBounds( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_SetWorldPosition")]
        public static void* CnvMpScnbjct_SetWorldPosition( void* self, void* pos )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_GetWorldPosition")]
        public static void* CnvMpScnbjct_GetWorldPosition( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_SetWorldDirection")]
        public static void* CnvMpScnbjct_SetWorldDirection( void* self, void* dir )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_GetWorldDirection")]
        public static void* CnvMpScnbjct_GetWorldDirection( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_SetColor")]
        public static void* CnvMpScnbjct_SetColor( void* self, void* color )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_SetBounceColor")]
        public static void* CnvMpScnbjct_SetBounceColor( void* self, void* color )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_GetColor")]
        public static void* CnvMpScnbjct_GetColor( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_SetRadius")]
        public static void* CnvMpScnbjct_SetRadius( void* self, float radius )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_GetRadius")]
        public static float CnvMpScnbjct_GetRadius( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_SetTheta")]
        public static void* CnvMpScnbjct_SetTheta( void* self, float f )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_GetTheta")]
        public static float CnvMpScnbjct_GetTheta( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_SetPhi")]
        public static void* CnvMpScnbjct_SetPhi( void* self, float f )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_GetPhi")]
        public static float CnvMpScnbjct_GetPhi( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_SetFallOff")]
        public static void* CnvMpScnbjct_SetFallOff( void* self, float f )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_GetFallOff")]
        public static float CnvMpScnbjct_GetFallOff( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_GetShadowTextureResolution")]
        public static int CnvMpScnbjct_GetShadowTextureResolution( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_SetShadowTextureResolution")]
        public static void* CnvMpScnbjct_SetShadowTextureResolution( void* self, int v )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_GetShadows")]
        public static int CnvMpScnbjct_GetShadows( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_SetShadows")]
        public static void* CnvMpScnbjct_SetShadows( void* self, int v )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_SetConstantAttn")]
        public static void* CnvMpScnbjct_SetConstantAttn( void* self, float f )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_GetConstantAttn")]
        public static float CnvMpScnbjct_GetConstantAttn( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_SetLinearAttn")]
        public static void* CnvMpScnbjct_SetLinearAttn( void* self, float f )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_GetLinearAttn")]
        public static float CnvMpScnbjct_GetLinearAttn( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_SetQuadraticAttn")]
        public static void* CnvMpScnbjct_SetQuadraticAttn( void* self, float f )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_GetQuadraticAttn")]
        public static float CnvMpScnbjct_GetQuadraticAttn( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_SetLightCookie")]
        public static void* CnvMpScnbjct_SetLightCookie( void* self, void* f )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_GetLightCookie")]
        public static void* CnvMpScnbjct_GetLightCookie( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_GetShadowCascades")]
        public static int CnvMpScnbjct_GetShadowCascades( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_SetShadowCascades")]
        public static void* CnvMpScnbjct_SetShadowCascades( void* self, int v )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_GetCascadeDistanceScale")]
        public static float CnvMpScnbjct_GetCascadeDistanceScale( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_SetCascadeDistanceScale")]
        public static void* CnvMpScnbjct_SetCascadeDistanceScale( void* self, float dist )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_GetFogContributionStength")]
        public static float CnvMpScnbjct_GetFogContributionStength( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_SetFogContributionStength")]
        public static void* CnvMpScnbjct_SetFogContributionStength( void* self, float v )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_GetFogLightingMode")]
        public static int CnvMpScnbjct_GetFogLightingMode( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_SetFogLightingMode")]
        public static void* CnvMpScnbjct_SetFogLightingMode( void* self, int v )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_SetBakeLightIndex")]
        public static void* CnvMpScnbjct_SetBakeLightIndex( void* self, int v )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_SetBakeLightIndexScale")]
        public static void* CnvMpScnbjct_SetBakeLightIndexScale( void* self, float v )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_SetUsesIndexedBakedLighting")]
        public static void* CnvMpScnbjct_SetUsesIndexedBakedLighting( void* self, int v )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_SetRenderDiffuse")]
        public static void* CnvMpScnbjct_SetRenderDiffuse( void* self, int v )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_SetRenderSpecular")]
        public static void* CnvMpScnbjct_SetRenderSpecular( void* self, int v )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_SetRenderTransmissive")]
        public static void* CnvMpScnbjct_SetRenderTransmissive( void* self, int v )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_SetLightSourceSize0")]
        public static void* CnvMpScnbjct_SetLightSourceSize0( void* self, float v )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_SetLightSourceSize1")]
        public static void* CnvMpScnbjct_SetLightSourceSize1( void* self, float v )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_SetShadowTextureWidth")]
        public static void* CnvMpScnbjct_SetShadowTextureWidth( void* self, int v )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_SetShadowTextureHeight")]
        public static void* CnvMpScnbjct_SetShadowTextureHeight( void* self, int v )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_GetShadowTextureWidth")]
        public static int CnvMpScnbjct_GetShadowTextureWidth( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_GetShadowTextureHeight")]
        public static int CnvMpScnbjct_GetShadowTextureHeight( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_GetLightFlags")]
        public static uint CnvMpScnbjct_GetLightFlags( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_SetLightFlags")]
        public static void* CnvMpScnbjct_SetLightFlags( void* self, uint flags )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_GetLightShape")]
        public static long CnvMpScnbjct_GetLightShape( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_SetLightShape")]
        public static void* CnvMpScnbjct_SetLightShape( void* self, long shape )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_SetLightSourceDim0")]
        public static void* CnvMpScnbjct_SetLightSourceDim0( void* self, float v )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CnvMpScnbjct_SetLightSourceDim1")]
        public static void* CnvMpScnbjct_SetLightSourceDim1( void* self, float v )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CnvMpScnbjct_m_nProjectionMode", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static long _Get__CnvMpScnbjct_m_nProjectionMode( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CnvMpScnbjct_m_nProjectionMode", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CnvMpScnbjct_m_nProjectionMode( void* self, long value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CnvMpScnbjct_m_vBoxProjectMins", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Get__CnvMpScnbjct_m_vBoxProjectMins( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CnvMpScnbjct_m_vBoxProjectMins", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CnvMpScnbjct_m_vBoxProjectMins( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CnvMpScnbjct_m_vBoxProjectMaxs", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Get__CnvMpScnbjct_m_vBoxProjectMaxs( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CnvMpScnbjct_m_vBoxProjectMaxs", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CnvMpScnbjct_m_vBoxProjectMaxs( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CnvMpScnbjct_m_vColor", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Get__CnvMpScnbjct_m_vColor( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CnvMpScnbjct_m_vColor", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CnvMpScnbjct_m_vColor( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CnvMpScnbjct_m_nRenderPriority", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__CnvMpScnbjct_m_nRenderPriority( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CnvMpScnbjct_m_nRenderPriority", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CnvMpScnbjct_m_nRenderPriority( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CnvMpScnbjct_m_hEnvMapTexture", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Get__CnvMpScnbjct_m_hEnvMapTexture( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CnvMpScnbjct_m_hEnvMapTexture", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CnvMpScnbjct_m_hEnvMapTexture( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CnvMpScnbjct_m_vNormalizationSH", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Get__CnvMpScnbjct_m_vNormalizationSH( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CnvMpScnbjct_m_vNormalizationSH", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CnvMpScnbjct_m_vNormalizationSH( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CnvMpScnbjct_m_flFeathering", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static float _Get__CnvMpScnbjct_m_flFeathering( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CnvMpScnbjct_m_flFeathering", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CnvMpScnbjct_m_flFeathering( void* self, float value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CFrustum_Create")]
        public static void* CFrustum_Create()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CFrustum_Delete")]
        public static void* CFrustum_Delete( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CFrustum_InitCamera")]
        public static void* CFrustum_InitCamera( void* self, void* origin, void* angles, float flNear, float flFar, float flFOV, float flAspect, float flClipSpaceBottomLeftX, float flClipSpaceBottomLeftY, float flClipSpaceTopRightX, float flClipSpaceTopRightY )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CFrustum_InitCamera_1")]
        public static void* CFrustum_InitCamera_1( void* self, void* origin, void* angles, float flNear, float flFar, float flFOV, float flAspect )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CFrustum_InitOrthoCamera")]
        public static void* CFrustum_InitOrthoCamera( void* self, void* origin, void* angles, float flNear, float flFar, float flWidth, float flHeight )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CFrustum_SetCameraWidthHeight")]
        public static void* CFrustum_SetCameraWidthHeight( void* self, float flWidth, float flHeight )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CFrustum_GetProj")]
        public static void* CFrustum_GetProj( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CFrustum_GetInvProj")]
        public static void* CFrustum_GetInvProj( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CFrustum_GetReverseZProj")]
        public static void* CFrustum_GetReverseZProj( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CFrustum_GetInvReverseZProj")]
        public static void* CFrustum_GetInvReverseZProj( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CFrustum_GetViewProj")]
        public static void* CFrustum_GetViewProj( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CFrustum_GetInvViewProj")]
        public static void* CFrustum_GetInvViewProj( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CFrustum_BoundingVolumeIntersectsFrustum")]
        public static int CFrustum_BoundingVolumeIntersectsFrustum( void* self, void* box )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CFrustum_ScreenTransform")]
        public static int CFrustum_ScreenTransform( void* self, void* world, void* result )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CFrustum_WorldToView")]
        public static void* CFrustum_WorldToView( void* self, void* vWorld, void* pOutViewMinusOneToOne )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CFrustum_ViewToWorld")]
        public static void* CFrustum_ViewToWorld( void* self, void* vViewMinusOneToOne, void* pOutWorld )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CFrustum_GetCameraPosition")]
        public static void* CFrustum_GetCameraPosition( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CFrustum_GetCameraAngles")]
        public static void* CFrustum_GetCameraAngles( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CFrustum_GetCameraNearPlane")]
        public static float CFrustum_GetCameraNearPlane( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CFrustum_GetCameraFarPlane")]
        public static float CFrustum_GetCameraFarPlane( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CFrustum_GetCameraFOV")]
        public static float CFrustum_GetCameraFOV( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CFrustum_GetCameraAspect")]
        public static float CFrustum_GetCameraAspect( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CFrustum_GetPlane")]
        public static void* CFrustum_GetPlane( void* self, int index, void* normal, void* distance )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CHitBox_GetTag")]
        public static void* CHitBox_GetTag( void* self, int index )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CHitBox_m_vMinBounds", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Get__CHitBox_m_vMinBounds( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CHitBox_m_vMinBounds", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CHitBox_m_vMinBounds( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CHitBox_m_vMaxBounds", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Get__CHitBox_m_vMaxBounds( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CHitBox_m_vMaxBounds", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CHitBox_m_vMaxBounds( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CHitBox_m_name", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Get__CHitBox_m_name( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CHitBox_m_name", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CHitBox_m_name( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CHitBox_m_sSurfaceProperty", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Get__CHitBox_m_sSurfaceProperty( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CHitBox_m_sSurfaceProperty", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CHitBox_m_sSurfaceProperty( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CHitBox_m_sBoneName", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Get__CHitBox_m_sBoneName( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CHitBox_m_sBoneName", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CHitBox_m_sBoneName( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CHitBox_m_flShapeRadius", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static float _Get__CHitBox_m_flShapeRadius( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CHitBox_m_flShapeRadius", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CHitBox_m_flShapeRadius( void* self, float value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CHitBox_m_nBoneNameHash", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__CHitBox_m_nBoneNameHash( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CHitBox_m_nBoneNameHash", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CHitBox_m_nBoneNameHash( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CHitBox_m_cRenderColor", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Get__CHitBox_m_cRenderColor( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CHitBox_m_cRenderColor", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CHitBox_m_cRenderColor( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CHitBox_m_nHitBoxIndex", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static ushort _Get__CHitBox_m_nHitBoxIndex( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CHitBox_m_nHitBoxIndex", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CHitBox_m_nHitBoxIndex( void* self, ushort value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CHitBox_m_nShapeType", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static byte _Get__CHitBox_m_nShapeType( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CHitBox_m_nShapeType", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CHitBox_m_nShapeType( void* self, byte value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CHitBox_m_bForcedTransform", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__CHitBox_m_bForcedTransform( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CHitBox_m_bForcedTransform", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CHitBox_m_bForcedTransform( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CHitBox_m_bTranslationOnly", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__CHitBox_m_bTranslationOnly( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CHitBox_m_bTranslationOnly", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CHitBox_m_bTranslationOnly( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CHitBox_m_bVisible", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__CHitBox_m_bVisible( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CHitBox_m_bVisible", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CHitBox_m_bVisible( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CHitBox_m_bSelected", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__CHitBox_m_bSelected( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CHitBox_m_bSelected", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CHitBox_m_bSelected( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CHitBoxSet_numhitboxes")]
        public static int CHitBoxSet_numhitboxes( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CHitBoxSet_pHitbox")]
        public static void* CHitBoxSet_pHitbox( void* self, int nIndex )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CHitBoxSet_m_name", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Get__CHitBoxSet_m_name( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CHitBoxSet_m_name", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CHitBoxSet_m_name( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CHitBoxSet_m_SourceFilename", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Get__CHitBoxSet_m_SourceFilename( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CHitBoxSet_m_SourceFilename", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CHitBoxSet_m_SourceFilename( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "From_CSceneObject_To_CManagedSceneObject", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* From_CSceneObject_To_CManagedSceneObject( void* ptr ) => ptr;
        [UnmanagedCallersOnly(EntryPoint = "To_CSceneObject_From_CManagedSceneObject", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* To_CSceneObject_From_CManagedSceneObject( void* ptr ) => ptr;
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_Create")]
        public static int CMngdScnbjct_Create( void* world )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_ChangeFlags")]
        public static void* CMngdScnbjct_ChangeFlags( void* self, long nNewFlags, long nNewFlagsMask )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_SetFlags")]
        public static void* CMngdScnbjct_SetFlags( void* self, long nFlagsToOR )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_HasFlags")]
        public static int CMngdScnbjct_HasFlags( void* self, long nFlags )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_GetFlags")]
        public static long CMngdScnbjct_GetFlags( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_GetOriginalFlags")]
        public static long CMngdScnbjct_GetOriginalFlags( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_ClearFlags")]
        public static void* CMngdScnbjct_ClearFlags( void* self, long nFlagsToClear )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_SetCullDistance")]
        public static void* CMngdScnbjct_SetCullDistance( void* self, float dist )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_EnableLightingCache")]
        public static void* CMngdScnbjct_EnableLightingCache( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_SetLightingOrigin")]
        public static void* CMngdScnbjct_SetLightingOrigin( void* self, void* vPos, int worldspace )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_GetLightingOrigin")]
        public static void* CMngdScnbjct_GetLightingOrigin( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_HasLightingOrigin")]
        public static int CMngdScnbjct_HasLightingOrigin( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_SetTintRGBA")]
        public static void* CMngdScnbjct_SetTintRGBA( void* self, void* color )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_GetTintRGBA")]
        public static void* CMngdScnbjct_GetTintRGBA( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_SetAlphaFade")]
        public static void* CMngdScnbjct_SetAlphaFade( void* self, float nAlpha )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_GetAlphaFade")]
        public static float CMngdScnbjct_GetAlphaFade( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_SetMaterialOverrideForMeshInstances")]
        public static void* CMngdScnbjct_SetMaterialOverrideForMeshInstances( void* self, void* mat )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_ClearMaterialOverrideList")]
        public static void* CMngdScnbjct_ClearMaterialOverrideList( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_SetMaterialOverride")]
        public static void* CMngdScnbjct_SetMaterialOverride( void* self, void* hMaterial, void* nAttr, int nAttrValueMatch )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_IsLoaded")]
        public static int CMngdScnbjct_IsLoaded( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_IsRenderingEnabled")]
        public static int CMngdScnbjct_IsRenderingEnabled( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_SetLoaded")]
        public static void* CMngdScnbjct_SetLoaded( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_ClearLoaded")]
        public static void* CMngdScnbjct_ClearLoaded( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_DisableRendering")]
        public static void* CMngdScnbjct_DisableRendering( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_EnableRendering")]
        public static void* CMngdScnbjct_EnableRendering( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_SetRenderingEnabled")]
        public static void* CMngdScnbjct_SetRenderingEnabled( void* self, int bEnabled )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_GetBoundingSphereRadius")]
        public static float CMngdScnbjct_GetBoundingSphereRadius( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_SetTransform")]
        public static void* CMngdScnbjct_SetTransform( void* self, void* tx )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_GetCTransform")]
        public static void* CMngdScnbjct_GetCTransform( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_SetBounds")]
        public static void* CMngdScnbjct_SetBounds( void* self, void* box )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_GetBounds")]
        public static void* CMngdScnbjct_GetBounds( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_SetBoundsInfinite")]
        public static void* CMngdScnbjct_SetBoundsInfinite( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_GetParent")]
        public static int CMngdScnbjct_GetParent( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_AddChildObject")]
        public static void* CMngdScnbjct_AddChildObject( void* self, void* nId, void* pChild, uint nChildUpdateFlags )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_RemoveChild")]
        public static void* CMngdScnbjct_RemoveChild( void* self, void* obj )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_GetAttributesPtrForModify")]
        public static void* CMngdScnbjct_GetAttributesPtrForModify( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_EnableMeshGroups")]
        public static void* CMngdScnbjct_EnableMeshGroups( void* self, ulong nMask )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_DisableMeshGroups")]
        public static void* CMngdScnbjct_DisableMeshGroups( void* self, ulong nMask )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_ResetMeshGroups")]
        public static void* CMngdScnbjct_ResetMeshGroups( void* self, ulong nMask )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_GetCurrentMeshGroupMask")]
        public static ulong CMngdScnbjct_GetCurrentMeshGroupMask( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_GetWorld")]
        public static int CMngdScnbjct_GetWorld( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_SetLOD")]
        public static void* CMngdScnbjct_SetLOD( void* self, int nLOD )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_DisableLOD")]
        public static void* CMngdScnbjct_DisableLOD( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_GetCurrentLODGroupMask")]
        public static ulong CMngdScnbjct_GetCurrentLODGroupMask( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_GetCurrentLODLevel")]
        public static int CMngdScnbjct_GetCurrentLODLevel( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_GetModelHandle")]
        public static void* CMngdScnbjct_GetModelHandle( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_SetMaterialGroup")]
        public static void* CMngdScnbjct_SetMaterialGroup( void* self, void* token )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_SetBodyGroup")]
        public static void* CMngdScnbjct_SetBodyGroup( void* self, void* token, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_SetBatchable")]
        public static void* CMngdScnbjct_SetBatchable( void* self, int bIsBatchable )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_IsNotBatchable")]
        public static int CMngdScnbjct_IsNotBatchable( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_SetUniqueBatchGroup")]
        public static void* CMngdScnbjct_SetUniqueBatchGroup( void* self, int bUnique )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_RemoveTag")]
        public static void* CMngdScnbjct_RemoveTag( void* self, uint tag )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_RemoveAllTags")]
        public static void* CMngdScnbjct_RemoveAllTags( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_GetTagCount")]
        public static int CMngdScnbjct_GetTagCount( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_GetTagAt")]
        public static uint CMngdScnbjct_GetTagAt( void* self, int i )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_AddTag")]
        public static void* CMngdScnbjct_AddTag( void* self, uint tag )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_HasTag")]
        public static int CMngdScnbjct_HasTag( void* self, uint tag )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_SetForceLayerID")]
        public static void* CMngdScnbjct_SetForceLayerID( void* self, void* nTok )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_SetLayerMatchID")]
        public static void* CMngdScnbjct_SetLayerMatchID( void* self, void* nTok )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_UpdateFlagsBasedOnMaterial")]
        public static void* CMngdScnbjct_UpdateFlagsBasedOnMaterial( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMngdScnbjct_SetMaterialOverrideByIndex")]
        public static void* CMngdScnbjct_SetMaterialOverrideByIndex( void* self, int index, void* material )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CMngdScnbjct_ExecuteOnMainThread", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__CMngdScnbjct_ExecuteOnMainThread( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CMngdScnbjct_ExecuteOnMainThread", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CMngdScnbjct_ExecuteOnMainThread( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMtrlSystm2ppSys_Create")]
        public static void* CMtrlSystm2ppSys_Create( void* createInfo )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMtrlSystm2ppSys_Destroy")]
        public static void* CMtrlSystm2ppSys_Destroy( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMtrlSystm2ppSys_Init")]
        public static int CMtrlSystm2ppSys_Init( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMtrlSystm2ppSys_InitWithoutMaterialSystem")]
        public static int CMtrlSystm2ppSys_InitWithoutMaterialSystem( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMtrlSystm2ppSys_InitFinishSetupMaterialSystem")]
        public static int CMtrlSystm2ppSys_InitFinishSetupMaterialSystem( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMtrlSystm2ppSys_GetAppWindow")]
        public static void* CMtrlSystm2ppSys_GetAppWindow( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMtrlSystm2ppSys_GetAppWindowSwapChain")]
        public static void* CMtrlSystm2ppSys_GetAppWindowSwapChain( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMtrlSystm2ppSys_SetAppWindowTitle")]
        public static void* CMtrlSystm2ppSys_SetAppWindowTitle( void* self, void* title )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMtrlSystm2ppSys_SetAppWindowIcon")]
        public static void* CMtrlSystm2ppSys_SetAppWindowIcon( void* self, void* title )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMtrlSystm2ppSys_SetInitialAppWindowImage")]
        public static void* CMtrlSystm2ppSys_SetInitialAppWindowImage( void* self, void* vmat )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMtrlSystm2ppSys_SetAppWindowDiscardMouseFocusClick")]
        public static void* CMtrlSystm2ppSys_SetAppWindowDiscardMouseFocusClick( void* self, int discard )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMtrlSystm2ppSys_DrawInitialWindowImage")]
        public static void* CMtrlSystm2ppSys_DrawInitialWindowImage( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMtrlSystm2ppSys_SuppressStartupManifestLoad")]
        public static void* CMtrlSystm2ppSys_SuppressStartupManifestLoad( void* self, int b )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMtrlSystm2ppSys_SetModuleSearchPath")]
        public static void* CMtrlSystm2ppSys_SetModuleSearchPath( void* self, void* dir )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMtrlSystm2ppSys_SetModGameSubdir")]
        public static void* CMtrlSystm2ppSys_SetModGameSubdir( void* self, void* dir )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMtrlSystm2ppSys_SetModFromFileName")]
        public static void* CMtrlSystm2ppSys_SetModFromFileName( void* self, void* filename, int noExeCheck )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMtrlSystm2ppSys_DisableModPathCheck")]
        public static void* CMtrlSystm2ppSys_DisableModPathCheck( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMtrlSystm2ppSys_SetDefaultRenderSystemOption")]
        public static void* CMtrlSystm2ppSys_SetDefaultRenderSystemOption( void* self, void* system )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMtrlSystm2ppSys_SetInitializationPhase")]
        public static void* CMtrlSystm2ppSys_SetInitializationPhase( void* self, int p )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMtrlSystm2ppSys_GetInitializationPhase")]
        public static int CMtrlSystm2ppSys_GetInitializationPhase( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMtrlSystm2ppSys_PreShutdown")]
        public static void* CMtrlSystm2ppSys_PreShutdown( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMtrlSystm2ppSys_InitSDL")]
        public static int CMtrlSystm2ppSys_InitSDL( void* self, uint flags )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMtrlSystm2ppSys_ShutdownSDL")]
        public static void* CMtrlSystm2ppSys_ShutdownSDL( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMtrlSystm2ppSys_IsConsoleApp")]
        public static int CMtrlSystm2ppSys_IsConsoleApp( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMtrlSystm2ppSys_IsGameApp")]
        public static int CMtrlSystm2ppSys_IsGameApp( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMtrlSystm2ppSys_SetDedicatedServer")]
        public static void* CMtrlSystm2ppSys_SetDedicatedServer( void* self, int bIsDedicatedServer )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMtrlSystm2ppSys_IsDedicatedServer")]
        public static int CMtrlSystm2ppSys_IsDedicatedServer( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMtrlSystm2ppSys_GetContentPath")]
        public static void* CMtrlSystm2ppSys_GetContentPath( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMtrlSystm2ppSys_GetModGameSubdir")]
        public static void* CMtrlSystm2ppSys_GetModGameSubdir( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMtrlSystm2ppSys_SetInToolsMode")]
        public static void* CMtrlSystm2ppSys_SetInToolsMode( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMtrlSystm2ppSys_IsInToolsMode")]
        public static int CMtrlSystm2ppSys_IsInToolsMode( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMtrlSystm2ppSys_IsInDeveloperMode")]
        public static int CMtrlSystm2ppSys_IsInDeveloperMode( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMtrlSystm2ppSys_IsInVRMode")]
        public static int CMtrlSystm2ppSys_IsInVRMode( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMtrlSystm2ppSys_CreateAppWindow")]
        public static void* CMtrlSystm2ppSys_CreateAppWindow( void* self, void* pTitle, int nPlatWindowFlags, int x, int y, int w, int h, int nRefreshRateHz )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMtrlSystm2ppSys_SuppressCOMInitialization")]
        public static void* CMtrlSystm2ppSys_SuppressCOMInitialization( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMtrlSystm2ppSys_IsRunningOnCustomerMachine")]
        public static int CMtrlSystm2ppSys_IsRunningOnCustomerMachine( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMtrlSystm2ppSys_AddSystem")]
        public static void* CMtrlSystm2ppSys_AddSystem( void* self, void* dllName, void* interfaceName )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMtrlSystm2ppSys_SetInTestMode")]
        public static void* CMtrlSystm2ppSys_SetInTestMode( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMtrlSystm2ppSys_IsInTestMode")]
        public static int CMtrlSystm2ppSys_IsInTestMode( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMtrlSystm2ppSys_SetInStandaloneApp")]
        public static void* CMtrlSystm2ppSys_SetInStandaloneApp( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMtrlSystm2ppSys_IsStandaloneApp")]
        public static int CMtrlSystm2ppSys_IsStandaloneApp( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMtrlSystm2ppSys_SetSteamAppId")]
        public static void* CMtrlSystm2ppSys_SetSteamAppId( void* self, uint appId )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMtrlSystm2ppSys_GetSteamAppId")]
        public static uint CMtrlSystm2ppSys_GetSteamAppId( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_DestroyStrongHandle")]
        public static void* CModel_DestroyStrongHandle( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_IsStrongHandleValid", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int CModel_IsStrongHandleValid( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_IsError", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int CModel_IsError( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_IsStrongHandleLoaded", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int CModel_IsStrongHandleLoaded( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_CopyStrongHandle", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* CModel_CopyStrongHandle( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_GetBindingPtr", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* CModel_GetBindingPtr( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_GetModelName")]
        public static void* CModel_GetModelName( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_IsTranslucent")]
        public static int CModel_IsTranslucent( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_IsTranslucentTwoPass")]
        public static int CModel_IsTranslucentTwoPass( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_HasPhysics")]
        public static int CModel_HasPhysics( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_FindModelSubKey")]
        public static void* CModel_FindModelSubKey( void* self, void* name )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_GetAttachmentTransform")]
        public static int CModel_GetAttachmentTransform( void* self, void* name, void* tx )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_GetAttachmentNameFromIndex")]
        public static void* CModel_GetAttachmentNameFromIndex( void* self, int index )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_GetBodyPartForName")]
        public static int CModel_GetBodyPartForName( void* self, void* pName )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_GetBodyPartName")]
        public static void* CModel_GetBodyPartName( void* self, int nPart )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_GetNumBodyParts")]
        public static int CModel_GetNumBodyParts( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_GetNumBodyPartMeshes")]
        public static int CModel_GetNumBodyPartMeshes( void* self, int nPart )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_GetBodyPartMask")]
        public static ulong CModel_GetBodyPartMask( void* self, int nPart )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_GetBodyPartMeshMask")]
        public static ulong CModel_GetBodyPartMeshMask( void* self, int nPart, int nMesh )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_FindMeshIndexForMask")]
        public static int CModel_FindMeshIndexForMask( void* self, int nPart, ulong nMask )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_GetNumMeshGroups")]
        public static int CModel_GetNumMeshGroups( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_GetDefaultMeshGroupMask")]
        public static ulong CModel_GetDefaultMeshGroupMask( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_GetBodyPartMeshName")]
        public static void* CModel_GetBodyPartMeshName( void* self, int nPart, int nMesh )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_GetNumMaterialGroups")]
        public static int CModel_GetNumMaterialGroups( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_GetMaterialGroupName")]
        public static void* CModel_GetMaterialGroupName( void* self, int iGroup )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_GetMaterialGroupIndex")]
        public static int CModel_GetMaterialGroupIndex( void* self, void* nGroup )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_GetNumMaterialsInGroup")]
        public static int CModel_GetNumMaterialsInGroup( void* self, int iGroup )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_GetMaterialInGroup")]
        public static void* CModel_GetMaterialInGroup( void* self, int iGroup, int iIndex )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_GetNumSceneObjects")]
        public static int CModel_GetNumSceneObjects( void* self, int iMesh )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_GetNumDrawCalls")]
        public static int CModel_GetNumDrawCalls( void* self, int iMesh, int nSceneObject )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_GetMaterial")]
        public static void* CModel_GetMaterial( void* self, int iMesh, int nSceneObject, int nDrawCall )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_GetNumMeshes")]
        public static int CModel_GetNumMeshes( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_GetMeshBounds")]
        public static void* CModel_GetMeshBounds( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_GetPhysicsBounds")]
        public static void* CModel_GetPhysicsBounds( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_GetModelRenderBounds")]
        public static void* CModel_GetModelRenderBounds( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_NumBones")]
        public static int CModel_NumBones( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_FindBoneIndex")]
        public static int CModel_FindBoneIndex( void* self, void* name )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_boneName")]
        public static void* CModel_boneName( void* self, int iBone )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_boneParent")]
        public static int CModel_boneParent( void* self, int iBone )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_GetBoneTransform")]
        public static void* CModel_GetBoneTransform( void* self, int iBone )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_bonePosParentSpace")]
        public static void* CModel_bonePosParentSpace( void* self, int iBone )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_boneRotParentSpace")]
        public static void* CModel_boneRotParentSpace( void* self, int iBone )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_NumFlexControllers")]
        public static int CModel_NumFlexControllers( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_GetFlexControllerName")]
        public static void* CModel_GetFlexControllerName( void* self, int nFlexController )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_GetVisemeMorph")]
        public static float CModel_GetVisemeMorph( void* self, void* viseme, int morph )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_GetNumAnim")]
        public static int CModel_GetNumAnim( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_GetAnimationName")]
        public static void* CModel_GetAnimationName( void* self, int nAnimation )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_GetSequenceNames")]
        public static void* CModel_GetSequenceNames( void* self, void* names )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_HasSceneObjects", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int CModel_HasSceneObjects( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_MeshTrace")]
        public static int CModel_MeshTrace( void* self, void* input, void* output )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_GetAnimationGraph")]
        public static void* CModel_GetAnimationGraph( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_GetPhysicsContainer")]
        public static void* CModel_GetPhysicsContainer( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_FindHitboxSetByName")]
        public static void* CModel_FindHitboxSetByName( void* self, void* pName, int nMesh )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_FindHitboxSetIndexByName")]
        public static int CModel_FindHitboxSetIndexByName( void* self, void* pName, int nMesh )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_GetHitboxSetByIndex")]
        public static void* CModel_GetHitboxSetByIndex( void* self, int nIndex, int nMesh )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_GetBoneIndexForHitbox")]
        public static int CModel_GetBoneIndexForHitbox( void* self, void* pHitBox )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_GetHitboxSetCount")]
        public static int CModel_GetHitboxSetCount( void* self, int nMesh )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_HasSkinnedMeshes")]
        public static int CModel_HasSkinnedMeshes( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_HasAnimationDrivenFlexes")]
        public static int CModel_HasAnimationDrivenFlexes( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_boneFlags")]
        public static long CModel_boneFlags( void* self, int iBone )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_GetNumAttachments")]
        public static int CModel_GetNumAttachments( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_GetAttachment")]
        public static void* CModel_GetAttachment( void* self, int index )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_GetMaterialIndexCount")]
        public static int CModel_GetMaterialIndexCount( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModel_GetMaterialByIndex")]
        public static void* CModel_GetMaterialByIndex( void* self, int index )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ConCommand_GetName")]
        public static void* ConCommand_GetName( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ConCommand_GetHelpText")]
        public static void* ConCommand_GetHelpText( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ConCommand_GetFlags")]
        public static long ConCommand_GetFlags( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ConCommand_Run")]
        public static void* ConCommand_Run( void* self, void* command )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ConVar_GetName")]
        public static void* ConVar_GetName( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ConVar_GetHelpText")]
        public static void* ConVar_GetHelpText( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ConVar_SetValue")]
        public static void* ConVar_SetValue( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ConVar_SetValue_1")]
        public static void* ConVar_SetValue_1( void* self, float flValue )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ConVar_SetValue_2")]
        public static void* ConVar_SetValue_2( void* self, int nValue )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ConVar_GetString")]
        public static void* ConVar_GetString( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ConVar_Revert")]
        public static void* ConVar_Revert( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ConVar_HasMin")]
        public static int ConVar_HasMin( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ConVar_HasMax")]
        public static int ConVar_HasMax( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ConVar_GetMinValue")]
        public static float ConVar_GetMinValue( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ConVar_GetMaxValue")]
        public static float ConVar_GetMaxValue( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ConVar_GetDefault")]
        public static void* ConVar_GetDefault( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ConVar_GetFlags")]
        public static long ConVar_GetFlags( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CPhysggrgtDt_AddRef")]
        public static void* CPhysggrgtDt_AddRef( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CPhysggrgtDt_Release")]
        public static void* CPhysggrgtDt_Release( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CPhysggrgtDt_GetChecksum")]
        public static uint CPhysggrgtDt_GetChecksum( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CPhysggrgtDt_GetBoneCount")]
        public static int CPhysggrgtDt_GetBoneCount( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CPhysggrgtDt_GetBoneName")]
        public static void* CPhysggrgtDt_GetBoneName( void* self, int nBoneIndex )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CPhysggrgtDt_GetPartCount")]
        public static int CPhysggrgtDt_GetPartCount( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CPhysggrgtDt_GetBoneHash")]
        public static uint CPhysggrgtDt_GetBoneHash( void* self, int i )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CPhysggrgtDt_GetIndexHash")]
        public static uint CPhysggrgtDt_GetIndexHash( void* self, int i )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CPhysggrgtDt_GetBindPose")]
        public static void* CPhysggrgtDt_GetBindPose( void* self, int index )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CPhysggrgtDt_GetPart")]
        public static void* CPhysggrgtDt_GetPart( void* self, int index )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CPhysggrgtDt_GetSurfaceProperties")]
        public static void* CPhysggrgtDt_GetSurfaceProperties( void* self, int index )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CPhysggrgtDt_GetSurfacePropertiesCount")]
        public static int CPhysggrgtDt_GetSurfacePropertiesCount( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CPhysggrgtDt_GetCollisionAttributeCount")]
        public static int CPhysggrgtDt_GetCollisionAttributeCount( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CPhysggrgtDt_GetTag")]
        public static void* CPhysggrgtDt_GetTag( void* self, int nAttribute, int nIndex )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CPhysggrgtDt_GetTagCount")]
        public static int CPhysggrgtDt_GetTagCount( void* self, int nAttribute )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CPhysggrgtDt_GetJointCount")]
        public static int CPhysggrgtDt_GetJointCount( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CPhysggrgtDt_GetJoint")]
        public static void* CPhysggrgtDt_GetJoint( void* self, int index )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CPhysggrgtDt_m_nFlags", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static ushort _Get__CPhysggrgtDt_m_nFlags( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CPhysggrgtDt_m_nFlags", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CPhysggrgtDt_m_nFlags( void* self, ushort value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CPhysBodyDesc_SetBoneName")]
        public static void* CPhysBodyDesc_SetBoneName( void* self, void* boneName )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CPhysBodyDesc_SetSurface")]
        public static void* CPhysBodyDesc_SetSurface( void* self, void* surface )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CPhysBodyDesc_SetBindPose")]
        public static void* CPhysBodyDesc_SetBindPose( void* self, void* transform )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CPhysBodyDesc_AddSphere")]
        public static void* CPhysBodyDesc_AddSphere( void* self, void* sphere )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CPhysBodyDesc_AddCapsule")]
        public static void* CPhysBodyDesc_AddCapsule( void* self, void* capsule )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CPhysBodyDesc_AddHull")]
        public static void* CPhysBodyDesc_AddHull( void* self, void* pPoints, int nNumPoints, void* transform, float flPrecisionDegrees, float flPrecisionInches, int nMaxFaces, int nMaxEdges, int nMaxVerts, int nAlgo )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CPhysBodyDesc_AddMesh")]
        public static void* CPhysBodyDesc_AddMesh( void* self, void* pVertices, uint nNumVertices, void* pIndices, uint nNumIndices, void* pMaterials )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CPhysBodyDesc_m_flMass", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static float _Get__CPhysBodyDesc_m_flMass( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CPhysBodyDesc_m_flMass", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CPhysBodyDesc_m_flMass( void* self, float value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CPhysBdyDscrry_DeleteThis")]
        public static void* CPhysBdyDscrry_DeleteThis( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CPhysBdyDscrry_Create")]
        public static void* CPhysBdyDscrry_Create( int count, int jointCount )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CPhysBdyDscrry_Get")]
        public static void* CPhysBdyDscrry_Get( void* self, int index )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CPhysBdyDscrry_GetJoint")]
        public static void* CPhysBdyDscrry_GetJoint( void* self, int index )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CPhysSrfcPrprts_UpdatePhysics")]
        public static void* CPhysSrfcPrprts_UpdatePhysics( void* self, float Friction, float Elasticity, float Density, float RollingResistance, float BounceThreshold )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CPhysSrfcPrprts_m_name", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Get__CPhysSrfcPrprts_m_name( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CPhysSrfcPrprts_m_name", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CPhysSrfcPrprts_m_name( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CPhysSrfcPrprts_m_nameHash", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__CPhysSrfcPrprts_m_nameHash( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CPhysSrfcPrprts_m_nameHash", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CPhysSrfcPrprts_m_nameHash( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CPhysSrfcPrprts_m_baseNameHash", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__CPhysSrfcPrprts_m_baseNameHash( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CPhysSrfcPrprts_m_baseNameHash", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CPhysSrfcPrprts_m_baseNameHash( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CPhysSrfcPrprts_m_nIndex", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__CPhysSrfcPrprts_m_nIndex( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CPhysSrfcPrprts_m_nIndex", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CPhysSrfcPrprts_m_nIndex( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CPhysSrfcPrprts_m_nBaseIndex", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__CPhysSrfcPrprts_m_nBaseIndex( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CPhysSrfcPrprts_m_nBaseIndex", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CPhysSrfcPrprts_m_nBaseIndex( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CPhysSrfcPrprts_m_AudioSurface", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__CPhysSrfcPrprts_m_AudioSurface( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CPhysSrfcPrprts_m_AudioSurface", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CPhysSrfcPrprts_m_AudioSurface( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CPhysSrfcPrprts_m_bHidden", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__CPhysSrfcPrprts_m_bHidden( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CPhysSrfcPrprts_m_bHidden", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CPhysSrfcPrprts_m_bHidden( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CPhysSrfcPrprts_m_description", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Get__CPhysSrfcPrprts_m_description( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CPhysSrfcPrprts_m_description", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CPhysSrfcPrprts_m_description( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CQueryResult_DeleteThis")]
        public static void* CQueryResult_DeleteThis( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CQueryResult_Create")]
        public static void* CQueryResult_Create()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CQueryResult_Count")]
        public static int CQueryResult_Count( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CQueryResult_Element")]
        public static int CQueryResult_Element( void* self, int i )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "From_IReadBufferCallback_To_CReadBufferManagedCallback", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* From_IReadBufferCallback_To_CReadBufferManagedCallback( void* ptr ) => ptr;
        [UnmanagedCallersOnly(EntryPoint = "To_IReadBufferCallback_From_CReadBufferManagedCallback", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* To_IReadBufferCallback_From_CReadBufferManagedCallback( void* ptr ) => ptr;
        [UnmanagedCallersOnly(EntryPoint = "CRdBffrMngdCllbc_DeleteThis")]
        public static void* CRdBffrMngdCllbc_DeleteThis( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRdBffrMngdCllbc_Create")]
        public static void* CRdBffrMngdCllbc_Create()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRdBffrMngdCllbc_SetManagedId")]
        public static void* CRdBffrMngdCllbc_SetManagedId( void* self, int id )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRdBffrMngdCllbc_GetManagedId")]
        public static int CRdBffrMngdCllbc_GetManagedId( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRdBffrMngdCllbc_Done")]
        public static void* CRdBffrMngdCllbc_Done( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "From_IReadTexturePixelsCallback_To_CReadTexturePixelsManagedCallback", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* From_IReadTexturePixelsCallback_To_CReadTexturePixelsManagedCallback( void* ptr ) => ptr;
        [UnmanagedCallersOnly(EntryPoint = "To_IReadTexturePixelsCallback_From_CReadTexturePixelsManagedCallback", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* To_IReadTexturePixelsCallback_From_CReadTexturePixelsManagedCallback( void* ptr ) => ptr;
        [UnmanagedCallersOnly(EntryPoint = "CRdTxtrPxlsMngdC_DeleteThis")]
        public static void* CRdTxtrPxlsMngdC_DeleteThis( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRdTxtrPxlsMngdC_Create")]
        public static void* CRdTxtrPxlsMngdC_Create()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRdTxtrPxlsMngdC_SetManagedId")]
        public static void* CRdTxtrPxlsMngdC_SetManagedId( void* self, int id )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRdTxtrPxlsMngdC_GetManagedId")]
        public static int CRdTxtrPxlsMngdC_GetManagedId( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRdTxtrPxlsMngdC_Done")]
        public static void* CRdTxtrPxlsMngdC_Done( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRndrttrbts_DeleteThis")]
        public static void* CRndrttrbts_DeleteThis( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRndrttrbts_Create")]
        public static void* CRndrttrbts_Create()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRndrttrbts_SetFloatValue")]
        public static void* CRndrttrbts_SetFloatValue( void* self, void* nTokenID, float flValue )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRndrttrbts_GetFloatValue")]
        public static float CRndrttrbts_GetFloatValue( void* self, void* nTokenID, float flDefaultValue )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRndrttrbts_DeleteFloatValue")]
        public static void* CRndrttrbts_DeleteFloatValue( void* self, void* nTokenID )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRndrttrbts_SetVector2DValue")]
        public static void* CRndrttrbts_SetVector2DValue( void* self, void* nTokenID, void* vValue )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRndrttrbts_GetVector2DValue")]
        public static void* CRndrttrbts_GetVector2DValue( void* self, void* nTokenID, void* vDefaultValue )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRndrttrbts_DeleteVector2DValue")]
        public static void* CRndrttrbts_DeleteVector2DValue( void* self, void* nTokenID )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRndrttrbts_SetVectorValue")]
        public static void* CRndrttrbts_SetVectorValue( void* self, void* nTokenID, void* vValue )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRndrttrbts_GetVectorValue")]
        public static void* CRndrttrbts_GetVectorValue( void* self, void* nTokenID, void* vDefaultValue )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRndrttrbts_DeleteVectorValue")]
        public static void* CRndrttrbts_DeleteVectorValue( void* self, void* nTokenID )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRndrttrbts_SetVector4DValue")]
        public static void* CRndrttrbts_SetVector4DValue( void* self, void* nTokenID, void* vValue )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRndrttrbts_GetVector4DValue")]
        public static void* CRndrttrbts_GetVector4DValue( void* self, void* nTokenID, void* vDefaultValue )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRndrttrbts_DeleteVector4DValue")]
        public static void* CRndrttrbts_DeleteVector4DValue( void* self, void* nTokenID )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRndrttrbts_SetVMatrixValue")]
        public static void* CRndrttrbts_SetVMatrixValue( void* self, void* nTokenID, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRndrttrbts_GetVMatrixValue")]
        public static void* CRndrttrbts_GetVMatrixValue( void* self, void* nTokenID, void* vDefaultValue )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRndrttrbts_DeleteVMatrixValue")]
        public static void* CRndrttrbts_DeleteVMatrixValue( void* self, void* nTokenID )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRndrttrbts_SetStringValue")]
        public static void* CRndrttrbts_SetStringValue( void* self, void* nTokenID, void* str )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRndrttrbts_DeleteStringValue")]
        public static void* CRndrttrbts_DeleteStringValue( void* self, void* nTokenID )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRndrttrbts_SetIntValue")]
        public static void* CRndrttrbts_SetIntValue( void* self, void* nTokenID, int nValue )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRndrttrbts_GetIntValue")]
        public static int CRndrttrbts_GetIntValue( void* self, void* nTokenID, int nDefaultValue )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRndrttrbts_DeleteIntValue")]
        public static void* CRndrttrbts_DeleteIntValue( void* self, void* nTokenID )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRndrttrbts_SetComboValue")]
        public static void* CRndrttrbts_SetComboValue( void* self, void* nTokenID, byte nValue )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRndrttrbts_GetComboValue")]
        public static byte CRndrttrbts_GetComboValue( void* self, void* nTokenID, byte nValue )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRndrttrbts_DeleteComboValue")]
        public static void* CRndrttrbts_DeleteComboValue( void* self, void* nTokenID )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRndrttrbts_SetBoolValue")]
        public static void* CRndrttrbts_SetBoolValue( void* self, void* nTokenID, int bValue )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRndrttrbts_GetBoolValue")]
        public static int CRndrttrbts_GetBoolValue( void* self, void* nTokenID, int bValue )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRndrttrbts_DeleteBoolValue")]
        public static void* CRndrttrbts_DeleteBoolValue( void* self, void* nTokenID )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRndrttrbts_SetTextureValue")]
        public static void* CRndrttrbts_SetTextureValue( void* self, void* nTokenID, void* txtr, int nSingleMipLevelToBind )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRndrttrbts_GetTextureValue")]
        public static void* CRndrttrbts_GetTextureValue( void* self, void* nTokenID, void* defaultTxtr )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRndrttrbts_DeleteTextureValue")]
        public static void* CRndrttrbts_DeleteTextureValue( void* self, void* nTokenID )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRndrttrbts_SetSamplerValue")]
        public static void* CRndrttrbts_SetSamplerValue( void* self, void* nTokenID, void* samplerDesc )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRndrttrbts_SetBufferValue")]
        public static void* CRndrttrbts_SetBufferValue( void* self, void* nTokenID, void* hRenderBuffer )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRndrttrbts_SetPtrValue")]
        public static void* CRndrttrbts_SetPtrValue( void* self, void* nTokenID, void* ptr )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRndrttrbts_DeletePtrValue")]
        public static void* CRndrttrbts_DeletePtrValue( void* self, void* nTokenID )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRndrttrbts_SetIntVector4DValue")]
        public static void* CRndrttrbts_SetIntVector4DValue( void* self, void* nTokenID, int x, int y, int z, int w )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRndrttrbts_MergeToPtr")]
        public static void* CRndrttrbts_MergeToPtr( void* self, void* attrList )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRndrttrbts_IsEmpty")]
        public static int CRndrttrbts_IsEmpty( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRndrttrbts_Clear")]
        public static void* CRndrttrbts_Clear( void* self, int freeMemory, int resetParent )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRenderMesh_DestroyStrongHandle")]
        public static void* CRenderMesh_DestroyStrongHandle( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRenderMesh_IsStrongHandleValid", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int CRenderMesh_IsStrongHandleValid( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRenderMesh_IsError", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int CRenderMesh_IsError( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRenderMesh_IsStrongHandleLoaded", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int CRenderMesh_IsStrongHandleLoaded( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRenderMesh_CopyStrongHandle", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* CRenderMesh_CopyStrongHandle( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CRenderMesh_GetBindingPtr", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* CRenderMesh_GetBindingPtr( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "From_CSceneObject_To_CSceneAnimatableObject", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* From_CSceneObject_To_CSceneAnimatableObject( void* ptr ) => ptr;
        [UnmanagedCallersOnly(EntryPoint = "To_CSceneObject_From_CSceneAnimatableObject", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* To_CSceneObject_From_CSceneAnimatableObject( void* ptr ) => ptr;
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_SetWorldSpaceRenderBoneTransform")]
        public static void* CScnnmtblbjct_SetWorldSpaceRenderBoneTransform( void* self, int nBoneIndex, void* pRenderWorldTransform )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_GetWorldSpaceRenderBoneTransform")]
        public static void* CScnnmtblbjct_GetWorldSpaceRenderBoneTransform( void* self, int nBoneIndex )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_GetWorldSpaceRenderBoneTransform_1")]
        public static void* CScnnmtblbjct_GetWorldSpaceRenderBoneTransform_1( void* self, void* boneName )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_GetWorldSpaceRenderBonePreviousTransform")]
        public static void* CScnnmtblbjct_GetWorldSpaceRenderBonePreviousTransform( void* self, int nBoneIndex )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_GetWorldSpaceRenderBonePreviousTransform_1")]
        public static void* CScnnmtblbjct_GetWorldSpaceRenderBonePreviousTransform_1( void* self, void* boneName )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_GetLocalSpaceRenderBoneTransform")]
        public static void* CScnnmtblbjct_GetLocalSpaceRenderBoneTransform( void* self, int nBoneIndex )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_GetLocalSpaceRenderBoneTransform_1")]
        public static void* CScnnmtblbjct_GetLocalSpaceRenderBoneTransform_1( void* self, void* boneName )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_GetWorldSpaceAnimationTransform")]
        public static void* CScnnmtblbjct_GetWorldSpaceAnimationTransform( void* self, int nBoneIndex )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_Update")]
        public static void* CScnnmtblbjct_Update( void* self, float dt )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_MergeFrom")]
        public static void* CScnnmtblbjct_MergeFrom( void* self, void* other )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_SetBindPose")]
        public static void* CScnnmtblbjct_SetBindPose( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_CalculateWorldSpaceBones")]
        public static void* CScnnmtblbjct_CalculateWorldSpaceBones( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_FinishUpdate")]
        public static void* CScnnmtblbjct_FinishUpdate( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_ResetGraphParameters")]
        public static void* CScnnmtblbjct_ResetGraphParameters( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_GetParentSpaceBone")]
        public static void* CScnnmtblbjct_GetParentSpaceBone( void* self, int index )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_SetParentSpaceBone")]
        public static void* CScnnmtblbjct_SetParentSpaceBone( void* self, int index, void* tx )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_InitAnimGraph")]
        public static void* CScnnmtblbjct_InitAnimGraph( void* self, void* pAnimGraphChangedCallback )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_SetAnimGraph")]
        public static void* CScnnmtblbjct_SetAnimGraph( void* self, void* graphName )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_SetAnimGraph_1")]
        public static void* CScnnmtblbjct_SetAnimGraph_1( void* self, void* hGraph )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_GetAnimGraph")]
        public static void* CScnnmtblbjct_GetAnimGraph( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_SBox_SetFlexOverride")]
        public static void* CScnnmtblbjct_SBox_SetFlexOverride( void* self, void* name, float flWeight )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_SBox_SetFlexOverride_1")]
        public static void* CScnnmtblbjct_SBox_SetFlexOverride_1( void* self, int flexId, float flWeight )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_SBox_GetFlexOverride")]
        public static float CScnnmtblbjct_SBox_GetFlexOverride( void* self, int flexId )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_SBox_GetFlexOverride_1")]
        public static float CScnnmtblbjct_SBox_GetFlexOverride_1( void* self, void* name )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_SBox_ClearFlexOverride")]
        public static void* CScnnmtblbjct_SBox_ClearFlexOverride( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_DirectPlayback_PlaySequence")]
        public static void* CScnnmtblbjct_DirectPlayback_PlaySequence( void* self, void* pSequenceName )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_DirectPlayback_PlaySequence_1")]
        public static void* CScnnmtblbjct_DirectPlayback_PlaySequence_1( void* self, void* pSequenceName, void* vTargetPos, float flFacingHeading, float flInterpTime )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_DirectPlayback_CancelSequence")]
        public static void* CScnnmtblbjct_DirectPlayback_CancelSequence( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_DirectPlayback_GetSequenceCycle")]
        public static float CScnnmtblbjct_DirectPlayback_GetSequenceCycle( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_DirectPlayback_GetSequence")]
        public static void* CScnnmtblbjct_DirectPlayback_GetSequence( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_DirectPlayback_SetSequenceStartTime")]
        public static void* CScnnmtblbjct_DirectPlayback_SetSequenceStartTime( void* self, float flStartTime )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_DirectPlayback_GetSequenceDuration")]
        public static float CScnnmtblbjct_DirectPlayback_GetSequenceDuration( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_SBox_GetAttachment")]
        public static int CScnnmtblbjct_SBox_GetAttachment( void* self, void* name, int worldspace, void* tx )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_SetShouldUseAnimGraph")]
        public static void* CScnnmtblbjct_SetShouldUseAnimGraph( void* self, int bEnabled )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_GetShouldUseAnimGraph")]
        public static int CScnnmtblbjct_GetShouldUseAnimGraph( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_GetSequence")]
        public static void* CScnnmtblbjct_GetSequence( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_SetSequence")]
        public static void* CScnnmtblbjct_SetSequence( void* self, void* pSequenceName )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_GetSequenceDuration")]
        public static float CScnnmtblbjct_GetSequenceDuration( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_GetSequenceCycle")]
        public static float CScnnmtblbjct_GetSequenceCycle( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_SetSequenceCycle")]
        public static void* CScnnmtblbjct_SetSequenceCycle( void* self, float flCycle )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_SetSequenceLooping")]
        public static void* CScnnmtblbjct_SetSequenceLooping( void* self, int bLooping )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_IsSequenceFinished")]
        public static int CScnnmtblbjct_IsSequenceFinished( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_SetSequenceBlending")]
        public static void* CScnnmtblbjct_SetSequenceBlending( void* self, int bBlending )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_GetPlaybackRate")]
        public static float CScnnmtblbjct_GetPlaybackRate( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_SetPlaybackRate")]
        public static void* CScnnmtblbjct_SetPlaybackRate( void* self, float flPlaybackRate )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_GetParameterInt")]
        public static int CScnnmtblbjct_GetParameterInt( void* self, void* name )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_GetParameterFloat")]
        public static float CScnnmtblbjct_GetParameterFloat( void* self, void* name )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_GetParameterVector3")]
        public static void* CScnnmtblbjct_GetParameterVector3( void* self, void* name )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_GetParameterRotation")]
        public static void* CScnnmtblbjct_GetParameterRotation( void* self, void* name )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_PendingAnimationEvents")]
        public static int CScnnmtblbjct_PendingAnimationEvents( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_RunAnimationEvents")]
        public static void* CScnnmtblbjct_RunAnimationEvents( void* self, void* callback )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_DispatchTagEvents")]
        public static void* CScnnmtblbjct_DispatchTagEvents( void* self, void* callback )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_ClearPhysicsBones")]
        public static void* CScnnmtblbjct_ClearPhysicsBones( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_SetPhysicsBone")]
        public static void* CScnnmtblbjct_SetPhysicsBone( void* self, ushort bone, void* transform )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_GetRootMotion")]
        public static void* CScnnmtblbjct_GetRootMotion( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_HasPhysicsBones")]
        public static int CScnnmtblbjct_HasPhysicsBones( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_GetAnimParameter")]
        public static void* CScnnmtblbjct_GetAnimParameter( void* self, void* name )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_GetAnimParameter_1")]
        public static void* CScnnmtblbjct_GetAnimParameter_1( void* self, int index )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_ChangeFlags")]
        public static void* CScnnmtblbjct_ChangeFlags( void* self, long nNewFlags, long nNewFlagsMask )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_SetFlags")]
        public static void* CScnnmtblbjct_SetFlags( void* self, long nFlagsToOR )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_HasFlags")]
        public static int CScnnmtblbjct_HasFlags( void* self, long nFlags )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_GetFlags")]
        public static long CScnnmtblbjct_GetFlags( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_GetOriginalFlags")]
        public static long CScnnmtblbjct_GetOriginalFlags( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_ClearFlags")]
        public static void* CScnnmtblbjct_ClearFlags( void* self, long nFlagsToClear )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_SetCullDistance")]
        public static void* CScnnmtblbjct_SetCullDistance( void* self, float dist )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_EnableLightingCache")]
        public static void* CScnnmtblbjct_EnableLightingCache( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_SetLightingOrigin")]
        public static void* CScnnmtblbjct_SetLightingOrigin( void* self, void* vPos, int worldspace )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_GetLightingOrigin")]
        public static void* CScnnmtblbjct_GetLightingOrigin( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_HasLightingOrigin")]
        public static int CScnnmtblbjct_HasLightingOrigin( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_SetTintRGBA")]
        public static void* CScnnmtblbjct_SetTintRGBA( void* self, void* color )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_GetTintRGBA")]
        public static void* CScnnmtblbjct_GetTintRGBA( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_SetAlphaFade")]
        public static void* CScnnmtblbjct_SetAlphaFade( void* self, float nAlpha )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_GetAlphaFade")]
        public static float CScnnmtblbjct_GetAlphaFade( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_SetMaterialOverrideForMeshInstances")]
        public static void* CScnnmtblbjct_SetMaterialOverrideForMeshInstances( void* self, void* mat )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_ClearMaterialOverrideList")]
        public static void* CScnnmtblbjct_ClearMaterialOverrideList( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_SetMaterialOverride")]
        public static void* CScnnmtblbjct_SetMaterialOverride( void* self, void* hMaterial, void* nAttr, int nAttrValueMatch )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_IsLoaded")]
        public static int CScnnmtblbjct_IsLoaded( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_IsRenderingEnabled")]
        public static int CScnnmtblbjct_IsRenderingEnabled( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_SetLoaded")]
        public static void* CScnnmtblbjct_SetLoaded( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_ClearLoaded")]
        public static void* CScnnmtblbjct_ClearLoaded( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_DisableRendering")]
        public static void* CScnnmtblbjct_DisableRendering( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_EnableRendering")]
        public static void* CScnnmtblbjct_EnableRendering( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_SetRenderingEnabled")]
        public static void* CScnnmtblbjct_SetRenderingEnabled( void* self, int bEnabled )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_GetBoundingSphereRadius")]
        public static float CScnnmtblbjct_GetBoundingSphereRadius( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_SetTransform")]
        public static void* CScnnmtblbjct_SetTransform( void* self, void* tx )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_GetCTransform")]
        public static void* CScnnmtblbjct_GetCTransform( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_SetBounds")]
        public static void* CScnnmtblbjct_SetBounds( void* self, void* box )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_GetBounds")]
        public static void* CScnnmtblbjct_GetBounds( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_SetBoundsInfinite")]
        public static void* CScnnmtblbjct_SetBoundsInfinite( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_GetParent")]
        public static int CScnnmtblbjct_GetParent( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_AddChildObject")]
        public static void* CScnnmtblbjct_AddChildObject( void* self, void* nId, void* pChild, uint nChildUpdateFlags )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_RemoveChild")]
        public static void* CScnnmtblbjct_RemoveChild( void* self, void* obj )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_GetAttributesPtrForModify")]
        public static void* CScnnmtblbjct_GetAttributesPtrForModify( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_EnableMeshGroups")]
        public static void* CScnnmtblbjct_EnableMeshGroups( void* self, ulong nMask )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_DisableMeshGroups")]
        public static void* CScnnmtblbjct_DisableMeshGroups( void* self, ulong nMask )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_ResetMeshGroups")]
        public static void* CScnnmtblbjct_ResetMeshGroups( void* self, ulong nMask )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_GetCurrentMeshGroupMask")]
        public static ulong CScnnmtblbjct_GetCurrentMeshGroupMask( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_GetWorld")]
        public static int CScnnmtblbjct_GetWorld( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_SetLOD")]
        public static void* CScnnmtblbjct_SetLOD( void* self, int nLOD )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_DisableLOD")]
        public static void* CScnnmtblbjct_DisableLOD( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_GetCurrentLODGroupMask")]
        public static ulong CScnnmtblbjct_GetCurrentLODGroupMask( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_GetCurrentLODLevel")]
        public static int CScnnmtblbjct_GetCurrentLODLevel( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_GetModelHandle")]
        public static void* CScnnmtblbjct_GetModelHandle( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_SetMaterialGroup")]
        public static void* CScnnmtblbjct_SetMaterialGroup( void* self, void* token )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_SetBodyGroup")]
        public static void* CScnnmtblbjct_SetBodyGroup( void* self, void* token, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_SetBatchable")]
        public static void* CScnnmtblbjct_SetBatchable( void* self, int bIsBatchable )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_IsNotBatchable")]
        public static int CScnnmtblbjct_IsNotBatchable( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_SetUniqueBatchGroup")]
        public static void* CScnnmtblbjct_SetUniqueBatchGroup( void* self, int bUnique )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_RemoveTag")]
        public static void* CScnnmtblbjct_RemoveTag( void* self, uint tag )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_RemoveAllTags")]
        public static void* CScnnmtblbjct_RemoveAllTags( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_GetTagCount")]
        public static int CScnnmtblbjct_GetTagCount( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_GetTagAt")]
        public static uint CScnnmtblbjct_GetTagAt( void* self, int i )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_AddTag")]
        public static void* CScnnmtblbjct_AddTag( void* self, uint tag )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_HasTag")]
        public static int CScnnmtblbjct_HasTag( void* self, uint tag )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_SetForceLayerID")]
        public static void* CScnnmtblbjct_SetForceLayerID( void* self, void* nTok )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_SetLayerMatchID")]
        public static void* CScnnmtblbjct_SetLayerMatchID( void* self, void* nTok )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_UpdateFlagsBasedOnMaterial")]
        public static void* CScnnmtblbjct_UpdateFlagsBasedOnMaterial( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnnmtblbjct_SetMaterialOverrideByIndex")]
        public static void* CScnnmtblbjct_SetMaterialOverrideByIndex( void* self, int index, void* material )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CScnnmtblbjct_m_flDeltaTime", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static float _Get__CScnnmtblbjct_m_flDeltaTime( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CScnnmtblbjct_m_flDeltaTime", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CScnnmtblbjct_m_flDeltaTime( void* self, float value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CScnnmtblbjct_m_worldBounds", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Get__CScnnmtblbjct_m_worldBounds( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CScnnmtblbjct_m_worldBounds", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CScnnmtblbjct_m_worldBounds( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CScnnmtblbjct_m_localBounds", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Get__CScnnmtblbjct_m_localBounds( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CScnnmtblbjct_m_localBounds", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CScnnmtblbjct_m_localBounds( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "From_CSceneObject_To_CSceneLightObject", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* From_CSceneObject_To_CSceneLightObject( void* ptr ) => ptr;
        [UnmanagedCallersOnly(EntryPoint = "To_CSceneObject_From_CSceneLightObject", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* To_CSceneObject_From_CSceneLightObject( void* ptr ) => ptr;
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetWorldPosition")]
        public static void* CScnLghtbjct_SetWorldPosition( void* self, void* pos )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_GetWorldPosition")]
        public static void* CScnLghtbjct_GetWorldPosition( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetWorldDirection")]
        public static void* CScnLghtbjct_SetWorldDirection( void* self, void* dir )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_GetWorldDirection")]
        public static void* CScnLghtbjct_GetWorldDirection( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetColor")]
        public static void* CScnLghtbjct_SetColor( void* self, void* color )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetBounceColor")]
        public static void* CScnLghtbjct_SetBounceColor( void* self, void* color )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_GetColor")]
        public static void* CScnLghtbjct_GetColor( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetRadius")]
        public static void* CScnLghtbjct_SetRadius( void* self, float radius )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_GetRadius")]
        public static float CScnLghtbjct_GetRadius( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetTheta")]
        public static void* CScnLghtbjct_SetTheta( void* self, float f )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_GetTheta")]
        public static float CScnLghtbjct_GetTheta( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetPhi")]
        public static void* CScnLghtbjct_SetPhi( void* self, float f )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_GetPhi")]
        public static float CScnLghtbjct_GetPhi( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetFallOff")]
        public static void* CScnLghtbjct_SetFallOff( void* self, float f )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_GetFallOff")]
        public static float CScnLghtbjct_GetFallOff( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_GetShadowTextureResolution")]
        public static int CScnLghtbjct_GetShadowTextureResolution( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetShadowTextureResolution")]
        public static void* CScnLghtbjct_SetShadowTextureResolution( void* self, int v )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_GetShadows")]
        public static int CScnLghtbjct_GetShadows( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetShadows")]
        public static void* CScnLghtbjct_SetShadows( void* self, int v )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetConstantAttn")]
        public static void* CScnLghtbjct_SetConstantAttn( void* self, float f )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_GetConstantAttn")]
        public static float CScnLghtbjct_GetConstantAttn( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetLinearAttn")]
        public static void* CScnLghtbjct_SetLinearAttn( void* self, float f )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_GetLinearAttn")]
        public static float CScnLghtbjct_GetLinearAttn( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetQuadraticAttn")]
        public static void* CScnLghtbjct_SetQuadraticAttn( void* self, float f )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_GetQuadraticAttn")]
        public static float CScnLghtbjct_GetQuadraticAttn( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetLightCookie")]
        public static void* CScnLghtbjct_SetLightCookie( void* self, void* f )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_GetLightCookie")]
        public static void* CScnLghtbjct_GetLightCookie( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_GetShadowCascades")]
        public static int CScnLghtbjct_GetShadowCascades( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetShadowCascades")]
        public static void* CScnLghtbjct_SetShadowCascades( void* self, int v )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_GetCascadeDistanceScale")]
        public static float CScnLghtbjct_GetCascadeDistanceScale( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetCascadeDistanceScale")]
        public static void* CScnLghtbjct_SetCascadeDistanceScale( void* self, float dist )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_GetFogContributionStength")]
        public static float CScnLghtbjct_GetFogContributionStength( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetFogContributionStength")]
        public static void* CScnLghtbjct_SetFogContributionStength( void* self, float v )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_GetFogLightingMode")]
        public static int CScnLghtbjct_GetFogLightingMode( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetFogLightingMode")]
        public static void* CScnLghtbjct_SetFogLightingMode( void* self, int v )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetBakeLightIndex")]
        public static void* CScnLghtbjct_SetBakeLightIndex( void* self, int v )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetBakeLightIndexScale")]
        public static void* CScnLghtbjct_SetBakeLightIndexScale( void* self, float v )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetUsesIndexedBakedLighting")]
        public static void* CScnLghtbjct_SetUsesIndexedBakedLighting( void* self, int v )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetRenderDiffuse")]
        public static void* CScnLghtbjct_SetRenderDiffuse( void* self, int v )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetRenderSpecular")]
        public static void* CScnLghtbjct_SetRenderSpecular( void* self, int v )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetRenderTransmissive")]
        public static void* CScnLghtbjct_SetRenderTransmissive( void* self, int v )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetLightSourceSize0")]
        public static void* CScnLghtbjct_SetLightSourceSize0( void* self, float v )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetLightSourceSize1")]
        public static void* CScnLghtbjct_SetLightSourceSize1( void* self, float v )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetShadowTextureWidth")]
        public static void* CScnLghtbjct_SetShadowTextureWidth( void* self, int v )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetShadowTextureHeight")]
        public static void* CScnLghtbjct_SetShadowTextureHeight( void* self, int v )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_GetShadowTextureWidth")]
        public static int CScnLghtbjct_GetShadowTextureWidth( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_GetShadowTextureHeight")]
        public static int CScnLghtbjct_GetShadowTextureHeight( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_GetLightFlags")]
        public static uint CScnLghtbjct_GetLightFlags( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetLightFlags")]
        public static void* CScnLghtbjct_SetLightFlags( void* self, uint flags )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_GetLightShape")]
        public static long CScnLghtbjct_GetLightShape( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetLightShape")]
        public static void* CScnLghtbjct_SetLightShape( void* self, long shape )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetLightSourceDim0")]
        public static void* CScnLghtbjct_SetLightSourceDim0( void* self, float v )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetLightSourceDim1")]
        public static void* CScnLghtbjct_SetLightSourceDim1( void* self, float v )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_ChangeFlags")]
        public static void* CScnLghtbjct_ChangeFlags( void* self, long nNewFlags, long nNewFlagsMask )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetFlags")]
        public static void* CScnLghtbjct_SetFlags( void* self, long nFlagsToOR )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_HasFlags")]
        public static int CScnLghtbjct_HasFlags( void* self, long nFlags )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_GetFlags")]
        public static long CScnLghtbjct_GetFlags( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_GetOriginalFlags")]
        public static long CScnLghtbjct_GetOriginalFlags( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_ClearFlags")]
        public static void* CScnLghtbjct_ClearFlags( void* self, long nFlagsToClear )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetCullDistance")]
        public static void* CScnLghtbjct_SetCullDistance( void* self, float dist )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_EnableLightingCache")]
        public static void* CScnLghtbjct_EnableLightingCache( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetLightingOrigin")]
        public static void* CScnLghtbjct_SetLightingOrigin( void* self, void* vPos, int worldspace )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_GetLightingOrigin")]
        public static void* CScnLghtbjct_GetLightingOrigin( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_HasLightingOrigin")]
        public static int CScnLghtbjct_HasLightingOrigin( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetTintRGBA")]
        public static void* CScnLghtbjct_SetTintRGBA( void* self, void* color )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_GetTintRGBA")]
        public static void* CScnLghtbjct_GetTintRGBA( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetAlphaFade")]
        public static void* CScnLghtbjct_SetAlphaFade( void* self, float nAlpha )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_GetAlphaFade")]
        public static float CScnLghtbjct_GetAlphaFade( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetMaterialOverrideForMeshInstances")]
        public static void* CScnLghtbjct_SetMaterialOverrideForMeshInstances( void* self, void* mat )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_ClearMaterialOverrideList")]
        public static void* CScnLghtbjct_ClearMaterialOverrideList( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetMaterialOverride")]
        public static void* CScnLghtbjct_SetMaterialOverride( void* self, void* hMaterial, void* nAttr, int nAttrValueMatch )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_IsLoaded")]
        public static int CScnLghtbjct_IsLoaded( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_IsRenderingEnabled")]
        public static int CScnLghtbjct_IsRenderingEnabled( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetLoaded")]
        public static void* CScnLghtbjct_SetLoaded( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_ClearLoaded")]
        public static void* CScnLghtbjct_ClearLoaded( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_DisableRendering")]
        public static void* CScnLghtbjct_DisableRendering( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_EnableRendering")]
        public static void* CScnLghtbjct_EnableRendering( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetRenderingEnabled")]
        public static void* CScnLghtbjct_SetRenderingEnabled( void* self, int bEnabled )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_GetBoundingSphereRadius")]
        public static float CScnLghtbjct_GetBoundingSphereRadius( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetTransform")]
        public static void* CScnLghtbjct_SetTransform( void* self, void* tx )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_GetCTransform")]
        public static void* CScnLghtbjct_GetCTransform( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetBounds")]
        public static void* CScnLghtbjct_SetBounds( void* self, void* box )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_GetBounds")]
        public static void* CScnLghtbjct_GetBounds( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetBoundsInfinite")]
        public static void* CScnLghtbjct_SetBoundsInfinite( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_GetParent")]
        public static int CScnLghtbjct_GetParent( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_AddChildObject")]
        public static void* CScnLghtbjct_AddChildObject( void* self, void* nId, void* pChild, uint nChildUpdateFlags )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_RemoveChild")]
        public static void* CScnLghtbjct_RemoveChild( void* self, void* obj )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_GetAttributesPtrForModify")]
        public static void* CScnLghtbjct_GetAttributesPtrForModify( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_EnableMeshGroups")]
        public static void* CScnLghtbjct_EnableMeshGroups( void* self, ulong nMask )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_DisableMeshGroups")]
        public static void* CScnLghtbjct_DisableMeshGroups( void* self, ulong nMask )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_ResetMeshGroups")]
        public static void* CScnLghtbjct_ResetMeshGroups( void* self, ulong nMask )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_GetCurrentMeshGroupMask")]
        public static ulong CScnLghtbjct_GetCurrentMeshGroupMask( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_GetWorld")]
        public static int CScnLghtbjct_GetWorld( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetLOD")]
        public static void* CScnLghtbjct_SetLOD( void* self, int nLOD )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_DisableLOD")]
        public static void* CScnLghtbjct_DisableLOD( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_GetCurrentLODGroupMask")]
        public static ulong CScnLghtbjct_GetCurrentLODGroupMask( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_GetCurrentLODLevel")]
        public static int CScnLghtbjct_GetCurrentLODLevel( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_GetModelHandle")]
        public static void* CScnLghtbjct_GetModelHandle( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetMaterialGroup")]
        public static void* CScnLghtbjct_SetMaterialGroup( void* self, void* token )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetBodyGroup")]
        public static void* CScnLghtbjct_SetBodyGroup( void* self, void* token, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetBatchable")]
        public static void* CScnLghtbjct_SetBatchable( void* self, int bIsBatchable )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_IsNotBatchable")]
        public static int CScnLghtbjct_IsNotBatchable( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetUniqueBatchGroup")]
        public static void* CScnLghtbjct_SetUniqueBatchGroup( void* self, int bUnique )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_RemoveTag")]
        public static void* CScnLghtbjct_RemoveTag( void* self, uint tag )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_RemoveAllTags")]
        public static void* CScnLghtbjct_RemoveAllTags( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_GetTagCount")]
        public static int CScnLghtbjct_GetTagCount( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_GetTagAt")]
        public static uint CScnLghtbjct_GetTagAt( void* self, int i )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_AddTag")]
        public static void* CScnLghtbjct_AddTag( void* self, uint tag )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_HasTag")]
        public static int CScnLghtbjct_HasTag( void* self, uint tag )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetForceLayerID")]
        public static void* CScnLghtbjct_SetForceLayerID( void* self, void* nTok )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetLayerMatchID")]
        public static void* CScnLghtbjct_SetLayerMatchID( void* self, void* nTok )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_UpdateFlagsBasedOnMaterial")]
        public static void* CScnLghtbjct_UpdateFlagsBasedOnMaterial( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtbjct_SetMaterialOverrideByIndex")]
        public static void* CScnLghtbjct_SetMaterialOverrideByIndex( void* self, int index, void* material )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "From_CSceneObject_To_CSceneLightProbeVolumeObject", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* From_CSceneObject_To_CSceneLightProbeVolumeObject( void* ptr ) => ptr;
        [UnmanagedCallersOnly(EntryPoint = "To_CSceneObject_From_CSceneLightProbeVolumeObject", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* To_CSceneObject_From_CSceneLightProbeVolumeObject( void* ptr ) => ptr;
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_CreateConstants")]
        public static void* CScnLghtPrbVlmbj_CreateConstants( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_ChangeFlags")]
        public static void* CScnLghtPrbVlmbj_ChangeFlags( void* self, long nNewFlags, long nNewFlagsMask )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_SetFlags")]
        public static void* CScnLghtPrbVlmbj_SetFlags( void* self, long nFlagsToOR )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_HasFlags")]
        public static int CScnLghtPrbVlmbj_HasFlags( void* self, long nFlags )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_GetFlags")]
        public static long CScnLghtPrbVlmbj_GetFlags( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_GetOriginalFlags")]
        public static long CScnLghtPrbVlmbj_GetOriginalFlags( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_ClearFlags")]
        public static void* CScnLghtPrbVlmbj_ClearFlags( void* self, long nFlagsToClear )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_SetCullDistance")]
        public static void* CScnLghtPrbVlmbj_SetCullDistance( void* self, float dist )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_EnableLightingCache")]
        public static void* CScnLghtPrbVlmbj_EnableLightingCache( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_SetLightingOrigin")]
        public static void* CScnLghtPrbVlmbj_SetLightingOrigin( void* self, void* vPos, int worldspace )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_GetLightingOrigin")]
        public static void* CScnLghtPrbVlmbj_GetLightingOrigin( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_HasLightingOrigin")]
        public static int CScnLghtPrbVlmbj_HasLightingOrigin( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_SetTintRGBA")]
        public static void* CScnLghtPrbVlmbj_SetTintRGBA( void* self, void* color )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_GetTintRGBA")]
        public static void* CScnLghtPrbVlmbj_GetTintRGBA( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_SetAlphaFade")]
        public static void* CScnLghtPrbVlmbj_SetAlphaFade( void* self, float nAlpha )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_GetAlphaFade")]
        public static float CScnLghtPrbVlmbj_GetAlphaFade( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_SetMaterialOverrideForMeshInstances")]
        public static void* CScnLghtPrbVlmbj_SetMaterialOverrideForMeshInstances( void* self, void* mat )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_ClearMaterialOverrideList")]
        public static void* CScnLghtPrbVlmbj_ClearMaterialOverrideList( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_SetMaterialOverride")]
        public static void* CScnLghtPrbVlmbj_SetMaterialOverride( void* self, void* hMaterial, void* nAttr, int nAttrValueMatch )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_IsLoaded")]
        public static int CScnLghtPrbVlmbj_IsLoaded( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_IsRenderingEnabled")]
        public static int CScnLghtPrbVlmbj_IsRenderingEnabled( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_SetLoaded")]
        public static void* CScnLghtPrbVlmbj_SetLoaded( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_ClearLoaded")]
        public static void* CScnLghtPrbVlmbj_ClearLoaded( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_DisableRendering")]
        public static void* CScnLghtPrbVlmbj_DisableRendering( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_EnableRendering")]
        public static void* CScnLghtPrbVlmbj_EnableRendering( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_SetRenderingEnabled")]
        public static void* CScnLghtPrbVlmbj_SetRenderingEnabled( void* self, int bEnabled )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_GetBoundingSphereRadius")]
        public static float CScnLghtPrbVlmbj_GetBoundingSphereRadius( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_SetTransform")]
        public static void* CScnLghtPrbVlmbj_SetTransform( void* self, void* tx )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_GetCTransform")]
        public static void* CScnLghtPrbVlmbj_GetCTransform( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_SetBounds")]
        public static void* CScnLghtPrbVlmbj_SetBounds( void* self, void* box )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_GetBounds")]
        public static void* CScnLghtPrbVlmbj_GetBounds( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_SetBoundsInfinite")]
        public static void* CScnLghtPrbVlmbj_SetBoundsInfinite( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_GetParent")]
        public static int CScnLghtPrbVlmbj_GetParent( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_AddChildObject")]
        public static void* CScnLghtPrbVlmbj_AddChildObject( void* self, void* nId, void* pChild, uint nChildUpdateFlags )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_RemoveChild")]
        public static void* CScnLghtPrbVlmbj_RemoveChild( void* self, void* obj )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_GetAttributesPtrForModify")]
        public static void* CScnLghtPrbVlmbj_GetAttributesPtrForModify( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_EnableMeshGroups")]
        public static void* CScnLghtPrbVlmbj_EnableMeshGroups( void* self, ulong nMask )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_DisableMeshGroups")]
        public static void* CScnLghtPrbVlmbj_DisableMeshGroups( void* self, ulong nMask )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_ResetMeshGroups")]
        public static void* CScnLghtPrbVlmbj_ResetMeshGroups( void* self, ulong nMask )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_GetCurrentMeshGroupMask")]
        public static ulong CScnLghtPrbVlmbj_GetCurrentMeshGroupMask( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_GetWorld")]
        public static int CScnLghtPrbVlmbj_GetWorld( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_SetLOD")]
        public static void* CScnLghtPrbVlmbj_SetLOD( void* self, int nLOD )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_DisableLOD")]
        public static void* CScnLghtPrbVlmbj_DisableLOD( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_GetCurrentLODGroupMask")]
        public static ulong CScnLghtPrbVlmbj_GetCurrentLODGroupMask( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_GetCurrentLODLevel")]
        public static int CScnLghtPrbVlmbj_GetCurrentLODLevel( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_GetModelHandle")]
        public static void* CScnLghtPrbVlmbj_GetModelHandle( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_SetMaterialGroup")]
        public static void* CScnLghtPrbVlmbj_SetMaterialGroup( void* self, void* token )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_SetBodyGroup")]
        public static void* CScnLghtPrbVlmbj_SetBodyGroup( void* self, void* token, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_SetBatchable")]
        public static void* CScnLghtPrbVlmbj_SetBatchable( void* self, int bIsBatchable )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_IsNotBatchable")]
        public static int CScnLghtPrbVlmbj_IsNotBatchable( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_SetUniqueBatchGroup")]
        public static void* CScnLghtPrbVlmbj_SetUniqueBatchGroup( void* self, int bUnique )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_RemoveTag")]
        public static void* CScnLghtPrbVlmbj_RemoveTag( void* self, uint tag )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_RemoveAllTags")]
        public static void* CScnLghtPrbVlmbj_RemoveAllTags( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_GetTagCount")]
        public static int CScnLghtPrbVlmbj_GetTagCount( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_GetTagAt")]
        public static uint CScnLghtPrbVlmbj_GetTagAt( void* self, int i )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_AddTag")]
        public static void* CScnLghtPrbVlmbj_AddTag( void* self, uint tag )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_HasTag")]
        public static int CScnLghtPrbVlmbj_HasTag( void* self, uint tag )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_SetForceLayerID")]
        public static void* CScnLghtPrbVlmbj_SetForceLayerID( void* self, void* nTok )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_SetLayerMatchID")]
        public static void* CScnLghtPrbVlmbj_SetLayerMatchID( void* self, void* nTok )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_UpdateFlagsBasedOnMaterial")]
        public static void* CScnLghtPrbVlmbj_UpdateFlagsBasedOnMaterial( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnLghtPrbVlmbj_SetMaterialOverrideByIndex")]
        public static void* CScnLghtPrbVlmbj_SetMaterialOverrideByIndex( void* self, int index, void* material )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CScnLghtPrbVlmbj_m_vBoxMins", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Get__CScnLghtPrbVlmbj_m_vBoxMins( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CScnLghtPrbVlmbj_m_vBoxMins", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CScnLghtPrbVlmbj_m_vBoxMins( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CScnLghtPrbVlmbj_m_vBoxMaxs", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Get__CScnLghtPrbVlmbj_m_vBoxMaxs( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CScnLghtPrbVlmbj_m_vBoxMaxs", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CScnLghtPrbVlmbj_m_vBoxMaxs( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CScnLghtPrbVlmbj_m_nHandshake", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__CScnLghtPrbVlmbj_m_nHandshake( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CScnLghtPrbVlmbj_m_nHandshake", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CScnLghtPrbVlmbj_m_nHandshake( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CScnLghtPrbVlmbj_m_nRenderPriority", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__CScnLghtPrbVlmbj_m_nRenderPriority( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CScnLghtPrbVlmbj_m_nRenderPriority", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CScnLghtPrbVlmbj_m_nRenderPriority( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CScnLghtPrbVlmbj_m_hLightProbeTexture", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Get__CScnLghtPrbVlmbj_m_hLightProbeTexture( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CScnLghtPrbVlmbj_m_hLightProbeTexture", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CScnLghtPrbVlmbj_m_hLightProbeTexture( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CScnLghtPrbVlmbj_m_hLightProbeDirectLightIndicesTexture", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Get__CScnLghtPrbVlmbj_m_hLightProbeDirectLightIndicesTexture( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CScnLghtPrbVlmbj_m_hLightProbeDirectLightIndicesTexture", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CScnLghtPrbVlmbj_m_hLightProbeDirectLightIndicesTexture( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CScnLghtPrbVlmbj_m_hLightProbeDirectLightScalarsTexture", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Get__CScnLghtPrbVlmbj_m_hLightProbeDirectLightScalarsTexture( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CScnLghtPrbVlmbj_m_hLightProbeDirectLightScalarsTexture", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CScnLghtPrbVlmbj_m_hLightProbeDirectLightScalarsTexture( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_ChangeFlags")]
        public static void* CSceneObject_ChangeFlags( void* self, long nNewFlags, long nNewFlagsMask )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_SetFlags")]
        public static void* CSceneObject_SetFlags( void* self, long nFlagsToOR )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_HasFlags")]
        public static int CSceneObject_HasFlags( void* self, long nFlags )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_GetFlags")]
        public static long CSceneObject_GetFlags( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_GetOriginalFlags")]
        public static long CSceneObject_GetOriginalFlags( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_ClearFlags")]
        public static void* CSceneObject_ClearFlags( void* self, long nFlagsToClear )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_SetCullDistance")]
        public static void* CSceneObject_SetCullDistance( void* self, float dist )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_EnableLightingCache")]
        public static void* CSceneObject_EnableLightingCache( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_SetLightingOrigin")]
        public static void* CSceneObject_SetLightingOrigin( void* self, void* vPos, int worldspace )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_GetLightingOrigin")]
        public static void* CSceneObject_GetLightingOrigin( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_HasLightingOrigin")]
        public static int CSceneObject_HasLightingOrigin( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_SetTintRGBA")]
        public static void* CSceneObject_SetTintRGBA( void* self, void* color )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_GetTintRGBA")]
        public static void* CSceneObject_GetTintRGBA( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_SetAlphaFade")]
        public static void* CSceneObject_SetAlphaFade( void* self, float nAlpha )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_GetAlphaFade")]
        public static float CSceneObject_GetAlphaFade( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_SetMaterialOverrideForMeshInstances")]
        public static void* CSceneObject_SetMaterialOverrideForMeshInstances( void* self, void* mat )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_ClearMaterialOverrideList")]
        public static void* CSceneObject_ClearMaterialOverrideList( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_SetMaterialOverride")]
        public static void* CSceneObject_SetMaterialOverride( void* self, void* hMaterial, void* nAttr, int nAttrValueMatch )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_IsLoaded")]
        public static int CSceneObject_IsLoaded( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_IsRenderingEnabled")]
        public static int CSceneObject_IsRenderingEnabled( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_SetLoaded")]
        public static void* CSceneObject_SetLoaded( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_ClearLoaded")]
        public static void* CSceneObject_ClearLoaded( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_DisableRendering")]
        public static void* CSceneObject_DisableRendering( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_EnableRendering")]
        public static void* CSceneObject_EnableRendering( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_SetRenderingEnabled")]
        public static void* CSceneObject_SetRenderingEnabled( void* self, int bEnabled )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_GetBoundingSphereRadius")]
        public static float CSceneObject_GetBoundingSphereRadius( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_SetTransform")]
        public static void* CSceneObject_SetTransform( void* self, void* tx )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_GetCTransform")]
        public static void* CSceneObject_GetCTransform( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_SetBounds")]
        public static void* CSceneObject_SetBounds( void* self, void* box )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_GetBounds")]
        public static void* CSceneObject_GetBounds( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_SetBoundsInfinite")]
        public static void* CSceneObject_SetBoundsInfinite( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_GetParent")]
        public static int CSceneObject_GetParent( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_AddChildObject")]
        public static void* CSceneObject_AddChildObject( void* self, void* nId, void* pChild, uint nChildUpdateFlags )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_RemoveChild")]
        public static void* CSceneObject_RemoveChild( void* self, void* obj )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_GetAttributesPtrForModify")]
        public static void* CSceneObject_GetAttributesPtrForModify( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_EnableMeshGroups")]
        public static void* CSceneObject_EnableMeshGroups( void* self, ulong nMask )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_DisableMeshGroups")]
        public static void* CSceneObject_DisableMeshGroups( void* self, ulong nMask )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_ResetMeshGroups")]
        public static void* CSceneObject_ResetMeshGroups( void* self, ulong nMask )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_GetCurrentMeshGroupMask")]
        public static ulong CSceneObject_GetCurrentMeshGroupMask( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_GetWorld")]
        public static int CSceneObject_GetWorld( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_SetLOD")]
        public static void* CSceneObject_SetLOD( void* self, int nLOD )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_DisableLOD")]
        public static void* CSceneObject_DisableLOD( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_GetCurrentLODGroupMask")]
        public static ulong CSceneObject_GetCurrentLODGroupMask( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_GetCurrentLODLevel")]
        public static int CSceneObject_GetCurrentLODLevel( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_GetModelHandle")]
        public static void* CSceneObject_GetModelHandle( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_SetMaterialGroup")]
        public static void* CSceneObject_SetMaterialGroup( void* self, void* token )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_SetBodyGroup")]
        public static void* CSceneObject_SetBodyGroup( void* self, void* token, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_SetBatchable")]
        public static void* CSceneObject_SetBatchable( void* self, int bIsBatchable )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_IsNotBatchable")]
        public static int CSceneObject_IsNotBatchable( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_SetUniqueBatchGroup")]
        public static void* CSceneObject_SetUniqueBatchGroup( void* self, int bUnique )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_RemoveTag")]
        public static void* CSceneObject_RemoveTag( void* self, uint tag )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_RemoveAllTags")]
        public static void* CSceneObject_RemoveAllTags( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_GetTagCount")]
        public static int CSceneObject_GetTagCount( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_GetTagAt")]
        public static uint CSceneObject_GetTagAt( void* self, int i )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_AddTag")]
        public static void* CSceneObject_AddTag( void* self, uint tag )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_HasTag")]
        public static int CSceneObject_HasTag( void* self, uint tag )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_SetForceLayerID")]
        public static void* CSceneObject_SetForceLayerID( void* self, void* nTok )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_SetLayerMatchID")]
        public static void* CSceneObject_SetLayerMatchID( void* self, void* nTok )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_UpdateFlagsBasedOnMaterial")]
        public static void* CSceneObject_UpdateFlagsBasedOnMaterial( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSceneObject_SetMaterialOverrideByIndex")]
        public static void* CSceneObject_SetMaterialOverrideByIndex( void* self, int index, void* material )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "From_CSceneObject_To_CSceneSkyBoxObject", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* From_CSceneObject_To_CSceneSkyBoxObject( void* ptr ) => ptr;
        [UnmanagedCallersOnly(EntryPoint = "To_CSceneObject_From_CSceneSkyBoxObject", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* To_CSceneObject_From_CSceneSkyBoxObject( void* ptr ) => ptr;
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_SetLighting_ConstantColorHemisphere")]
        public static void* CScnSkyBxbjct_SetLighting_ConstantColorHemisphere( void* self, void* vSkyColor )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_SetLighting_Samples")]
        public static void* CScnSkyBxbjct_SetLighting_Samples( void* self, void* pSkyColors, void* pSkyDirections, int nSkyColors )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_GetMaterial")]
        public static void* CScnSkyBxbjct_GetMaterial( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_SetMaterial")]
        public static void* CScnSkyBxbjct_SetMaterial( void* self, void* hMaterial )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_SetSkyTint")]
        public static void* CScnSkyBxbjct_SetSkyTint( void* self, void* vTint )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_GetSkyTint")]
        public static void* CScnSkyBxbjct_GetSkyTint( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_SetFogType")]
        public static void* CScnSkyBxbjct_SetFogType( void* self, int nType )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_GetFogType")]
        public static int CScnSkyBxbjct_GetFogType( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_SetAngularFogParams")]
        public static void* CScnSkyBxbjct_SetAngularFogParams( void* self, float flFogMinStart, float flFogMinEnd, float flFogMaxStart, float flFogMaxEnd )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_GetFogMinStart")]
        public static float CScnSkyBxbjct_GetFogMinStart( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_GetFogMinEnd")]
        public static float CScnSkyBxbjct_GetFogMinEnd( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_GetFogMaxStart")]
        public static float CScnSkyBxbjct_GetFogMaxStart( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_GetFogMaxEnd")]
        public static float CScnSkyBxbjct_GetFogMaxEnd( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_ChangeFlags")]
        public static void* CScnSkyBxbjct_ChangeFlags( void* self, long nNewFlags, long nNewFlagsMask )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_SetFlags")]
        public static void* CScnSkyBxbjct_SetFlags( void* self, long nFlagsToOR )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_HasFlags")]
        public static int CScnSkyBxbjct_HasFlags( void* self, long nFlags )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_GetFlags")]
        public static long CScnSkyBxbjct_GetFlags( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_GetOriginalFlags")]
        public static long CScnSkyBxbjct_GetOriginalFlags( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_ClearFlags")]
        public static void* CScnSkyBxbjct_ClearFlags( void* self, long nFlagsToClear )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_SetCullDistance")]
        public static void* CScnSkyBxbjct_SetCullDistance( void* self, float dist )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_EnableLightingCache")]
        public static void* CScnSkyBxbjct_EnableLightingCache( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_SetLightingOrigin")]
        public static void* CScnSkyBxbjct_SetLightingOrigin( void* self, void* vPos, int worldspace )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_GetLightingOrigin")]
        public static void* CScnSkyBxbjct_GetLightingOrigin( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_HasLightingOrigin")]
        public static int CScnSkyBxbjct_HasLightingOrigin( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_SetTintRGBA")]
        public static void* CScnSkyBxbjct_SetTintRGBA( void* self, void* color )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_GetTintRGBA")]
        public static void* CScnSkyBxbjct_GetTintRGBA( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_SetAlphaFade")]
        public static void* CScnSkyBxbjct_SetAlphaFade( void* self, float nAlpha )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_GetAlphaFade")]
        public static float CScnSkyBxbjct_GetAlphaFade( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_SetMaterialOverrideForMeshInstances")]
        public static void* CScnSkyBxbjct_SetMaterialOverrideForMeshInstances( void* self, void* mat )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_ClearMaterialOverrideList")]
        public static void* CScnSkyBxbjct_ClearMaterialOverrideList( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_SetMaterialOverride")]
        public static void* CScnSkyBxbjct_SetMaterialOverride( void* self, void* hMaterial, void* nAttr, int nAttrValueMatch )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_IsLoaded")]
        public static int CScnSkyBxbjct_IsLoaded( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_IsRenderingEnabled")]
        public static int CScnSkyBxbjct_IsRenderingEnabled( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_SetLoaded")]
        public static void* CScnSkyBxbjct_SetLoaded( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_ClearLoaded")]
        public static void* CScnSkyBxbjct_ClearLoaded( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_DisableRendering")]
        public static void* CScnSkyBxbjct_DisableRendering( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_EnableRendering")]
        public static void* CScnSkyBxbjct_EnableRendering( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_SetRenderingEnabled")]
        public static void* CScnSkyBxbjct_SetRenderingEnabled( void* self, int bEnabled )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_GetBoundingSphereRadius")]
        public static float CScnSkyBxbjct_GetBoundingSphereRadius( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_SetTransform")]
        public static void* CScnSkyBxbjct_SetTransform( void* self, void* tx )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_GetCTransform")]
        public static void* CScnSkyBxbjct_GetCTransform( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_SetBounds")]
        public static void* CScnSkyBxbjct_SetBounds( void* self, void* box )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_GetBounds")]
        public static void* CScnSkyBxbjct_GetBounds( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_SetBoundsInfinite")]
        public static void* CScnSkyBxbjct_SetBoundsInfinite( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_GetParent")]
        public static int CScnSkyBxbjct_GetParent( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_AddChildObject")]
        public static void* CScnSkyBxbjct_AddChildObject( void* self, void* nId, void* pChild, uint nChildUpdateFlags )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_RemoveChild")]
        public static void* CScnSkyBxbjct_RemoveChild( void* self, void* obj )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_GetAttributesPtrForModify")]
        public static void* CScnSkyBxbjct_GetAttributesPtrForModify( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_EnableMeshGroups")]
        public static void* CScnSkyBxbjct_EnableMeshGroups( void* self, ulong nMask )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_DisableMeshGroups")]
        public static void* CScnSkyBxbjct_DisableMeshGroups( void* self, ulong nMask )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_ResetMeshGroups")]
        public static void* CScnSkyBxbjct_ResetMeshGroups( void* self, ulong nMask )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_GetCurrentMeshGroupMask")]
        public static ulong CScnSkyBxbjct_GetCurrentMeshGroupMask( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_GetWorld")]
        public static int CScnSkyBxbjct_GetWorld( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_SetLOD")]
        public static void* CScnSkyBxbjct_SetLOD( void* self, int nLOD )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_DisableLOD")]
        public static void* CScnSkyBxbjct_DisableLOD( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_GetCurrentLODGroupMask")]
        public static ulong CScnSkyBxbjct_GetCurrentLODGroupMask( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_GetCurrentLODLevel")]
        public static int CScnSkyBxbjct_GetCurrentLODLevel( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_GetModelHandle")]
        public static void* CScnSkyBxbjct_GetModelHandle( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_SetMaterialGroup")]
        public static void* CScnSkyBxbjct_SetMaterialGroup( void* self, void* token )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_SetBodyGroup")]
        public static void* CScnSkyBxbjct_SetBodyGroup( void* self, void* token, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_SetBatchable")]
        public static void* CScnSkyBxbjct_SetBatchable( void* self, int bIsBatchable )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_IsNotBatchable")]
        public static int CScnSkyBxbjct_IsNotBatchable( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_SetUniqueBatchGroup")]
        public static void* CScnSkyBxbjct_SetUniqueBatchGroup( void* self, int bUnique )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_RemoveTag")]
        public static void* CScnSkyBxbjct_RemoveTag( void* self, uint tag )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_RemoveAllTags")]
        public static void* CScnSkyBxbjct_RemoveAllTags( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_GetTagCount")]
        public static int CScnSkyBxbjct_GetTagCount( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_GetTagAt")]
        public static uint CScnSkyBxbjct_GetTagAt( void* self, int i )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_AddTag")]
        public static void* CScnSkyBxbjct_AddTag( void* self, uint tag )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_HasTag")]
        public static int CScnSkyBxbjct_HasTag( void* self, uint tag )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_SetForceLayerID")]
        public static void* CScnSkyBxbjct_SetForceLayerID( void* self, void* nTok )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_SetLayerMatchID")]
        public static void* CScnSkyBxbjct_SetLayerMatchID( void* self, void* nTok )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_UpdateFlagsBasedOnMaterial")]
        public static void* CScnSkyBxbjct_UpdateFlagsBasedOnMaterial( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CScnSkyBxbjct_SetMaterialOverrideByIndex")]
        public static void* CScnSkyBxbjct_SetMaterialOverrideByIndex( void* self, int index, void* material )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CServerList_Create")]
        public static void* CServerList_Create( uint serverObj )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CServerList_Destroy")]
        public static void* CServerList_Destroy( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CServerList_StartQuery")]
        public static void* CServerList_StartQuery( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CServerList_AddFilter")]
        public static void* CServerList_AddFilter( void* self, void* key, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSfxTable_GetCacheStatus")]
        public static int CSfxTable_GetCacheStatus( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSfxTable_GetSampleCount")]
        public static int CSfxTable_GetSampleCount( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSfxTable_GetSamples")]
        public static int CSfxTable_GetSamples( void* self, void* samples, uint numSamples )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSfxTable_GetSound", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* CSfxTable_GetSound( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSfxTable_IsValidForPlayback")]
        public static int CSfxTable_IsValidForPlayback( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSfxTable_FailedResourceLoad")]
        public static int CSfxTable_FailedResourceLoad( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CSfxTable_CreateMixer")]
        public static void* CSfxTable_CreateMixer( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CStmnvntryRslt_Destroy")]
        public static void* CStmnvntryRslt_Destroy( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CStmnvntryRslt_IsPending")]
        public static int CStmnvntryRslt_IsPending( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CStmnvntryRslt_IsOk")]
        public static int CStmnvntryRslt_IsOk( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CStmnvntryRslt_CheckSteamId")]
        public static int CStmnvntryRslt_CheckSteamId( void* self, ulong steamid )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CStmnvntryRslt_GetTimestamp")]
        public static uint CStmnvntryRslt_GetTimestamp( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CStmnvntryRslt_Count")]
        public static int CStmnvntryRslt_Count( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CStmnvntryRslt_Get")]
        public static void* CStmnvntryRslt_Get( void* self, int index )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CStmtmnstnc_ItemId")]
        public static ulong CStmtmnstnc_ItemId( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CStmtmnstnc_DefinitionId")]
        public static uint CStmtmnstnc_DefinitionId( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CTextureBase_DestroyStrongHandle")]
        public static void* CTextureBase_DestroyStrongHandle( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CTextureBase_IsStrongHandleValid", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int CTextureBase_IsStrongHandleValid( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CTextureBase_IsError", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int CTextureBase_IsError( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CTextureBase_IsStrongHandleLoaded", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int CTextureBase_IsStrongHandleLoaded( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CTextureBase_CopyStrongHandle", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* CTextureBase_CopyStrongHandle( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CTextureBase_GetBindingPtr", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* CTextureBase_GetBindingPtr( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CUtlBuffer_Create")]
        public static void* CUtlBuffer_Create()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CUtlBuffer_Dispose")]
        public static void* CUtlBuffer_Dispose( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CUtlBuffer_Base")]
        public static void* CUtlBuffer_Base( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CUtlBuffer_TellMaxPut")]
        public static int CUtlBuffer_TellMaxPut( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CUtlSymbolTable_AddString")]
        public static void* CUtlSymbolTable_AddString( void* self, void* pString )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CtlVctrCtlStrng_DeleteThis")]
        public static void* CtlVctrCtlStrng_DeleteThis( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CtlVctrCtlStrng_Create")]
        public static void* CtlVctrCtlStrng_Create( int growsize, int initialcapacity )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CtlVctrCtlStrng_Count")]
        public static int CtlVctrCtlStrng_Count( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CtlVctrCtlStrng_SetCount")]
        public static void* CtlVctrCtlStrng_SetCount( void* self, int count )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CtlVctrCtlStrng_Element")]
        public static void* CtlVctrCtlStrng_Element( void* self, int i )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CtlVctrflt_DeleteThis")]
        public static void* CtlVctrflt_DeleteThis( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CtlVctrflt_Create")]
        public static void* CtlVctrflt_Create( int growsize, int initialcapacity )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CtlVctrflt_Count")]
        public static int CtlVctrflt_Count( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CtlVctrflt_SetCount")]
        public static void* CtlVctrflt_SetCount( void* self, int count )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CtlVctrflt_Element")]
        public static float CtlVctrflt_Element( void* self, int i )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CtlVctrHRndrTxtr_DeleteThis")]
        public static void* CtlVctrHRndrTxtr_DeleteThis( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CtlVctrHRndrTxtr_Create")]
        public static void* CtlVctrHRndrTxtr_Create( int growsize, int initialcapacity )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CtlVctrHRndrTxtr_Count")]
        public static int CtlVctrHRndrTxtr_Count( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CtlVctrHRndrTxtr_Element")]
        public static void* CtlVctrHRndrTxtr_Element( void* self, int i )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CtlVctrPhyscsTrc_Result_DeleteThis")]
        public static void* CtlVctrPhyscsTrc_Result_DeleteThis( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CtlVctrPhyscsTrc_Result_Create")]
        public static void* CtlVctrPhyscsTrc_Result_Create( int growsize, int initialcapacity )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CtlVctrPhyscsTrc_Result_Count")]
        public static int CtlVctrPhyscsTrc_Result_Count( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CtlVctrPhyscsTrc_Result_Element")]
        public static void* CtlVctrPhyscsTrc_Result_Element( void* self, int i )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CtlVctrnt32_DeleteThis")]
        public static void* CtlVctrnt32_DeleteThis( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CtlVctrnt32_Create")]
        public static void* CtlVctrnt32_Create( int growsize, int initialcapacity )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CtlVctrnt32_Count")]
        public static int CtlVctrnt32_Count( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CtlVctrnt32_SetCount")]
        public static void* CtlVctrnt32_SetCount( void* self, int count )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CtlVctrnt32_Element")]
        public static uint CtlVctrnt32_Element( void* self, int i )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CtlVctrVctr_DeleteThis")]
        public static void* CtlVctrVctr_DeleteThis( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CtlVctrVctr_Create")]
        public static void* CtlVctrVctr_Create( int growsize, int initialcapacity )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CtlVctrVctr_Count")]
        public static int CtlVctrVctr_Count( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CtlVctrVctr_SetCount")]
        public static void* CtlVctrVctr_SetCount( void* self, int count )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CtlVctrVctr_Element")]
        public static void* CtlVctrVctr_Element( void* self, int i )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVfx_DestroyStrongHandle")]
        public static void* CVfx_DestroyStrongHandle( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVfx_IsStrongHandleValid", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int CVfx_IsStrongHandleValid( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVfx_IsError", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int CVfx_IsError( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVfx_IsStrongHandleLoaded", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int CVfx_IsStrongHandleLoaded( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVfx_CopyStrongHandle", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* CVfx_CopyStrongHandle( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVfx_GetBindingPtr", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* CVfx_GetBindingPtr( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVfx_Create")]
        public static void* CVfx_Create( void* debugName )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVfx_GetFilename")]
        public static void* CVfx_GetFilename( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVfx_CreateFromResourceFile")]
        public static int CVfx_CreateFromResourceFile( void* self, void* pShaderFile, long compileTarget, uint nCreateFlags, int bFailSilently )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVfx_CreateFromShaderFile")]
        public static int CVfx_CreateFromShaderFile( void* self, void* pShaderFile, long compileTarget, uint nCreateFlags )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVfx_GetProgramData")]
        public static void* CVfx_GetProgramData( void* self, long pass )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVfx_GetIterator")]
        public static void* CVfx_GetIterator( void* self, long program )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVfx_Serialize")]
        public static void* CVfx_Serialize( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVfx_HasShaderProgram")]
        public static int CVfx_HasShaderProgram( void* self, long programType )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVfx_InitializeWrite")]
        public static int CVfx_InitializeWrite( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVfx_FinalizeCompile")]
        public static int CVfx_FinalizeCompile( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVfx_WriteProgramToBuffer")]
        public static int CVfx_WriteProgramToBuffer( void* self, long programType, void* byteCodeManager, void* outBuffer )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVfx_WriteCombo")]
        public static int CVfx_WriteCombo( void* self, long programType, ulong staticId, ulong dynamicId, void* shaderInfo )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVfx_GetPropertiesJson")]
        public static void* CVfx_GetPropertiesJson( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVfxBytCdMngr_Create")]
        public static void* CVfxBytCdMngr_Create()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVfxBytCdMngr_Delete")]
        public static void* CVfxBytCdMngr_Delete( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVfxBytCdMngr_OnStaticCombo")]
        public static void* CVfxBytCdMngr_OnStaticCombo( void* self, ulong id )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVfxBytCdMngr_OnDynamicCombo")]
        public static void* CVfxBytCdMngr_OnDynamicCombo( void* self, void* data )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVfxBytCdMngr_Reset")]
        public static void* CVfxBytCdMngr_Reset( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVfxCombo_GetName")]
        public static void* CVfxCombo_GetName( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVfxCombo_GetGroup")]
        public static void* CVfxCombo_GetGroup( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CVfxCombo_m_nMin", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static byte _Get__CVfxCombo_m_nMin( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CVfxCombo_m_nMin", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CVfxCombo_m_nMin( void* self, byte value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CVfxCombo_m_nMax", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static byte _Get__CVfxCombo_m_nMax( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CVfxCombo_m_nMax", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CVfxCombo_m_nMax( void* self, byte value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVfxCmbtrtr_Delete")]
        public static void* CVfxCmbtrtr_Delete( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVfxCmbtrtr_InvalidIndex")]
        public static ulong CVfxCmbtrtr_InvalidIndex( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVfxCmbtrtr_SetStaticCombo")]
        public static ulong CVfxCmbtrtr_SetStaticCombo( void* self, ulong c )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVfxCmbtrtr_FirstStaticCombo")]
        public static ulong CVfxCmbtrtr_FirstStaticCombo( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVfxCmbtrtr_NextStaticCombo")]
        public static ulong CVfxCmbtrtr_NextStaticCombo( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVfxCmbtrtr_SetDynamicCombo")]
        public static ulong CVfxCmbtrtr_SetDynamicCombo( void* self, ulong c )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVfxCmbtrtr_FirstDynamicCombo")]
        public static ulong CVfxCmbtrtr_FirstDynamicCombo( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVfxCmbtrtr_NextDynamicCombo")]
        public static ulong CVfxCmbtrtr_NextDynamicCombo( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__CVfxProgramData_m_bLoadedFromVcsFile", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__CVfxProgramData_m_bLoadedFromVcsFile( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__CVfxProgramData_m_bLoadedFromVcsFile", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__CVfxProgramData_m_bLoadedFromVcsFile( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVideoPlayer_Create")]
        public static void* CVideoPlayer_Create( uint managedObject )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVideoPlayer_Destroy")]
        public static void* CVideoPlayer_Destroy( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVideoPlayer_Play")]
        public static int CVideoPlayer_Play( void* self, void* pUrl, void* pExt )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVideoPlayer_Resume")]
        public static void* CVideoPlayer_Resume( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVideoPlayer_Stop")]
        public static void* CVideoPlayer_Stop( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVideoPlayer_Pause")]
        public static void* CVideoPlayer_Pause( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVideoPlayer_Seek")]
        public static void* CVideoPlayer_Seek( void* self, double time )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVideoPlayer_GetRepeat")]
        public static int CVideoPlayer_GetRepeat( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVideoPlayer_SetRepeat")]
        public static void* CVideoPlayer_SetRepeat( void* self, int bRepeat )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVideoPlayer_GetDuration")]
        public static float CVideoPlayer_GetDuration( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVideoPlayer_GetPlaybackTime")]
        public static float CVideoPlayer_GetPlaybackTime( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVideoPlayer_HasAudioStream")]
        public static int CVideoPlayer_HasAudioStream( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVideoPlayer_Update")]
        public static void* CVideoPlayer_Update( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVideoPlayer_IsPaused")]
        public static int CVideoPlayer_IsPaused( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVideoPlayer_IsMuted")]
        public static int CVideoPlayer_IsMuted( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVideoPlayer_SetMuted")]
        public static void* CVideoPlayer_SetMuted( void* self, int bMuted )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVideoPlayer_GetWidth")]
        public static int CVideoPlayer_GetWidth( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVideoPlayer_GetHeight")]
        public static int CVideoPlayer_GetHeight( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVideoPlayer_SetVideoOnly")]
        public static void* CVideoPlayer_SetVideoOnly( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVideoPlayer_GetMetadata")]
        public static void* CVideoPlayer_GetMetadata( void* self, void* key )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVideoPlayer_GetSpectrum")]
        public static void* CVideoPlayer_GetSpectrum( void* self, void* outSpectrum )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVideoPlayer_GetAmplitude")]
        public static float CVideoPlayer_GetAmplitude( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVideoPlayer_GetTexture")]
        public static void* CVideoPlayer_GetTexture( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVideoPlayer_GetAudioStream")]
        public static int CVideoPlayer_GetAudioStream( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVideoRecorder_Create")]
        public static void* CVideoRecorder_Create()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVideoRecorder_Destroy")]
        public static void* CVideoRecorder_Destroy( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVideoRecorder_Stop")]
        public static void* CVideoRecorder_Stop( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVideoRecorder_AddVideoFrame")]
        public static void* CVideoRecorder_AddVideoFrame( void* self, void* rgbaData, long captureTimeMicroS )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVideoRecorder_AddAudioSamples")]
        public static void* CVideoRecorder_AddAudioSamples( void* self, void* none )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CVideoRecorder_Initialize")]
        public static int CVideoRecorder_Initialize( void* self, void* filename, int width, int height, int fps, int bitRateMb, int audioSampleRate, int audioChannels, void* videoCodec )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "DspInstance_Dispose")]
        public static void* DspInstance_Dispose( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "DspInstance_ProcessChannel")]
        public static void* DspInstance_ProcessChannel( void* self, void* pOutput, void* input, int nChannelIndex )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "DspPreset_Create")]
        public static void* DspPreset_Create( void* name )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "DspPreset_Dispose")]
        public static void* DspPreset_Dispose( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "DspPreset_AddProcessor")]
        public static void* DspPreset_AddProcessor( void* self, int nType, void* prms, uint prmsCount )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "DspPreset_FinishBuilding")]
        public static void* DspPreset_FinishBuilding( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "DspPreset_Instantiate")]
        public static void* DspPreset_Instantiate( void* self, int channels )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "EngineGlue_JsonToKeyValues3")]
        public static void* EngineGlue_JsonToKeyValues3( void* json )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "EngineGlue_KeyValuesToJson")]
        public static void* EngineGlue_KeyValuesToJson( void* kv )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "EngineGlue_KeyValues3ToJson")]
        public static void* EngineGlue_KeyValues3ToJson( void* kv )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "EngineGlue_LoadKeyValues3")]
        public static void* EngineGlue_LoadKeyValues3( void* kvString )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "EngineGlue_GetStringToken")]
        public static uint EngineGlue_GetStringToken( void* str )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "EngineGlue_GetStringTokenValue")]
        public static void* EngineGlue_GetStringTokenValue( uint token )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "EngineGlue_AddSearchPath")]
        public static void* EngineGlue_AddSearchPath( void* path, void* groupid, int head )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "EngineGlue_RemoveSearchPath")]
        public static int EngineGlue_RemoveSearchPath( void* path, void* groupid )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "EngineGlue_ApproximateProcessMemoryUsage")]
        public static ulong EngineGlue_ApproximateProcessMemoryUsage()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "EngineGlue_ReadCompiledResourceFileJson")]
        public static void* EngineGlue_ReadCompiledResourceFileJson( void* data )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "EngineGlue_ReadCompiledResourceFileBlock")]
        public static void* EngineGlue_ReadCompiledResourceFileBlock( void* blockName, void* pHeader, void* nSize )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "EngineGlue_ReadCompiledResourceFileJsonFromFilesystem")]
        public static void* EngineGlue_ReadCompiledResourceFileJsonFromFilesystem( void* filename )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "EngineGlue_SetEngineLoggingVerbose")]
        public static void* EngineGlue_SetEngineLoggingVerbose( int verbose )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "EngineGlue_RequestWebAuthTicket")]
        public static void* EngineGlue_RequestWebAuthTicket()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "EngineGlue_CancelWebAuthTicket")]
        public static void* EngineGlue_CancelWebAuthTicket()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "EngineGlue_GetWebAuthTicket")]
        public static void* EngineGlue_GetWebAuthTicket()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ErrorReports_SetTag")]
        public static void* ErrorReports_SetTag( void* key, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ErrorReports_Breadcrumb")]
        public static void* ErrorReports_Breadcrumb( int action, void* category, void* description )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "FloatBitMap_t_Create")]
        public static void* FloatBitMap_t_Create()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "FloatBitMap_t_Create_1")]
        public static void* FloatBitMap_t_Create_1( int width, int height )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "FloatBitMap_t_Delete")]
        public static void* FloatBitMap_t_Delete( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "FloatBitMap_t_LoadFromFile")]
        public static int FloatBitMap_t_LoadFromFile( void* self, void* filename, long gamma )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "FloatBitMap_t_LoadFromPFM")]
        public static int FloatBitMap_t_LoadFromPFM( void* self, void* pFilename )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "FloatBitMap_t_LoadFromPSD")]
        public static int FloatBitMap_t_LoadFromPSD( void* self, void* pFilename, long ldrFileGammaType )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "FloatBitMap_t_LoadFromTIF")]
        public static int FloatBitMap_t_LoadFromTIF( void* self, void* pFilename, long ldrFileGammaType )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "FloatBitMap_t_LoadFromPNG")]
        public static int FloatBitMap_t_LoadFromPNG( void* self, void* pFilename, long ldrFileGammaType )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "FloatBitMap_t_LoadFromJPG")]
        public static int FloatBitMap_t_LoadFromJPG( void* self, void* pFilename, long ldrFileGammaType )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "FloatBitMap_t_LoadFromEXR")]
        public static int FloatBitMap_t_LoadFromEXR( void* self, void* pFilename )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "FloatBitMap_t_LoadFromBuffer")]
        public static void* FloatBitMap_t_LoadFromBuffer( void* self, void* data, int size, long format, long gamma )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "FloatBitMap_t_Init")]
        public static void* FloatBitMap_t_Init( void* self, int nWidth, int nHeight, int depth )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "FloatBitMap_t_Shutdown")]
        public static void* FloatBitMap_t_Shutdown( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "FloatBitMap_t_SetChannel")]
        public static void* FloatBitMap_t_SetChannel( void* self, int nComponent, float flValue )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "FloatBitMap_t_Rotate90DegreesCW")]
        public static void* FloatBitMap_t_Rotate90DegreesCW( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "FloatBitMap_t_Rotate90DegreesCCW")]
        public static void* FloatBitMap_t_Rotate90DegreesCCW( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "FloatBitMap_t_Rotate180Degrees")]
        public static void* FloatBitMap_t_Rotate180Degrees( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "FloatBitMap_t_MirrorHorizontally")]
        public static void* FloatBitMap_t_MirrorHorizontally( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "FloatBitMap_t_MirrorVertically")]
        public static void* FloatBitMap_t_MirrorVertically( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "FloatBitMap_t_WriteTGAFile")]
        public static int FloatBitMap_t_WriteTGAFile( void* self, void* pFilename )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "FloatBitMap_t_WritePFM")]
        public static int FloatBitMap_t_WritePFM( void* self, void* pFilename )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "FloatBitMap_t_WriteEXR")]
        public static int FloatBitMap_t_WriteEXR( void* self, void* pFilename, int nExrCompressionTypeType )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "FloatBitMap_t_LoadFromInMemoryTGA")]
        public static int FloatBitMap_t_LoadFromInMemoryTGA( void* self, void* pBuffer, int nSize )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "FloatBitMap_t_LoadFromInMemoryPSD")]
        public static int FloatBitMap_t_LoadFromInMemoryPSD( void* self, void* pBuffer, int nSize )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "FloatBitMap_t_LoadFromInMemoryTIF")]
        public static int FloatBitMap_t_LoadFromInMemoryTIF( void* self, void* pBuffer, int nSize )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "FloatBitMap_t_Pixel")]
        public static float FloatBitMap_t_Pixel( void* self, int x, int y, int z, int comp )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "FloatBitMap_t_PixelWrapped")]
        public static float FloatBitMap_t_PixelWrapped( void* self, int x, int y, int z, int comp )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "FloatBitMap_t_PixelClamped")]
        public static float FloatBitMap_t_PixelClamped( void* self, int x, int y, int z, int comp )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "FloatBitMap_t_Alpha")]
        public static float FloatBitMap_t_Alpha( void* self, int x, int y, int z )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "FloatBitMap_t_RGBPixelAsVector")]
        public static void* FloatBitMap_t_RGBPixelAsVector( void* self, int nX, int nY, int nZ )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "FloatBitMap_t_Width")]
        public static int FloatBitMap_t_Width( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "FloatBitMap_t_Height")]
        public static int FloatBitMap_t_Height( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "FloatBitMap_t_Depth")]
        public static int FloatBitMap_t_Depth( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "FloatBitMap_t_Resize2D")]
        public static void* FloatBitMap_t_Resize2D( void* self, int nNewWidth, int nNewHeight, int bClamp )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "FloatBitMap_t_WriteToBuffer")]
        public static int FloatBitMap_t_WriteToBuffer( void* self, void* pBuffer, int nBufSize, long fmt, int bLowQualityFastCompile, int bIsSrgb, uint nFlags )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "fpxr_pplctnCnfg_SetDebugCallback")]
        public static void* fpxr_pplctnCnfg_SetDebugCallback( void* dbgCallback )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "fpxr_pplctnCnfg_SetErrorCallback")]
        public static void* fpxr_pplctnCnfg_SetErrorCallback( void* errCallback )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "fpxr_Compositor_EventManager")]
        public static void* fpxr_Compositor_EventManager( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "fpxr_Compositor_Submit")]
        public static long fpxr_Compositor_Submit( void* self, void* info )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "fpxr_Compositor_BeginFrame")]
        public static long fpxr_Compositor_BeginFrame( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "fpxr_Compositor_EndFrame")]
        public static long fpxr_Compositor_EndFrame( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "fpxr_Compositor_GetEyeWidth")]
        public static uint fpxr_Compositor_GetEyeWidth( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "fpxr_Compositor_GetEyeHeight")]
        public static uint fpxr_Compositor_GetEyeHeight( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "fpxr_Compositor_GetRenderTargetWidth")]
        public static uint fpxr_Compositor_GetRenderTargetWidth( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "fpxr_Compositor_GetRenderTargetHeight")]
        public static uint fpxr_Compositor_GetRenderTargetHeight( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "fpxr_Compositor_GetDisplayRefreshRate")]
        public static float fpxr_Compositor_GetDisplayRefreshRate( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "fpxr_Compositor_GetViewInfo")]
        public static long fpxr_Compositor_GetViewInfo( void* self, uint viewIndex, void* outViewInfo )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "fpxr_Compositor_GetProjectionMatrix")]
        public static long fpxr_Compositor_GetProjectionMatrix( void* self, uint viewIndex, float flNearZ, float flFarZ, void* outViewInfo )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "fpxr_EventManager_PumpEvent")]
        public static long fpxr_EventManager_PumpEvent( void* self, void* ev )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "fpxr_Input_GetBooleanActionState")]
        public static long fpxr_Input_GetBooleanActionState( void* self, void* path, long inputSource, void* outState )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "fpxr_Input_GetFloatActionState")]
        public static long fpxr_Input_GetFloatActionState( void* self, void* path, long inputSource, void* outState )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "fpxr_Input_GetVector2ActionState")]
        public static long fpxr_Input_GetVector2ActionState( void* self, void* path, long inputSource, void* outState )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "fpxr_Input_GetPoseActionState")]
        public static long fpxr_Input_GetPoseActionState( void* self, void* path, long inputSource, void* outState )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "fpxr_Input_TriggerHapticVibration")]
        public static long fpxr_Input_TriggerHapticVibration( void* self, float duration, float frequency, float amplitude, long inputSource )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "fpxr_Input_GetHandPoseState")]
        public static long fpxr_Input_GetHandPoseState( void* self, long inputSource, long motionRange, void* outState )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "fpxr_Input_GetFingerCurl")]
        public static float fpxr_Input_GetFingerCurl( void* self, long inputSource, long finger )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "fpxr_Instance_Create")]
        public static void* fpxr_Instance_Create( void* instanceInfo )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "fpxr_Instance_HasHeadset")]
        public static int fpxr_Instance_HasHeadset()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "fpxr_Instance_Compositor")]
        public static void* fpxr_Instance_Compositor( void* self, void* vulkanInfo )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "fpxr_Instance_Input")]
        public static void* fpxr_Instance_Input( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "fpxr_Instance_GetRequiredDeviceExtensions")]
        public static void* fpxr_Instance_GetRequiredDeviceExtensions( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "fpxr_Instance_GetRequiredInstanceExtensions")]
        public static void* fpxr_Instance_GetRequiredInstanceExtensions( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "fpxr_Instance_GetProperties")]
        public static void* fpxr_Instance_GetProperties( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pAudioDevice_Name")]
        public static void* g_pAudioDevice_Name()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pAudioDevice_ChannelCount")]
        public static uint g_pAudioDevice_ChannelCount()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pAudioDevice_MixChannelCount")]
        public static uint g_pAudioDevice_MixChannelCount()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pAudioDevice_BitsPerSample")]
        public static uint g_pAudioDevice_BitsPerSample()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pAudioDevice_BytesPerSample")]
        public static uint g_pAudioDevice_BytesPerSample()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pAudioDevice_SampleRate")]
        public static uint g_pAudioDevice_SampleRate()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pAudioDevice_IsActive")]
        public static int g_pAudioDevice_IsActive()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pAudioDevice_CancelOutput")]
        public static void* g_pAudioDevice_CancelOutput()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pAudioDevice_WaitForComplete")]
        public static void* g_pAudioDevice_WaitForComplete()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pAudioDevice_MuteDevice")]
        public static void* g_pAudioDevice_MuteDevice( int bMuteDevice )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pAudioDevice_ClearBuffer")]
        public static void* g_pAudioDevice_ClearBuffer()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pAudioDevice_OutputDebugInfo")]
        public static void* g_pAudioDevice_OutputDebugInfo()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pAudioDevice_IsValid")]
        public static int g_pAudioDevice_IsValid()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pAudioDevice_SendOutput")]
        public static void* g_pAudioDevice_SendOutput( void* buffers )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pngnPVSMngr_BuildPvs")]
        public static void* g_pngnPVSMngr_BuildPvs( void* world )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pngnPVSMngr_DestroyPvs")]
        public static void* g_pngnPVSMngr_DestroyPvs( void* pvs )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pngnSrvcMgr_GetEngineSwapChain")]
        public static void* g_pngnSrvcMgr_GetEngineSwapChain()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pngnSrvcMgr_GetEngineSwapChainSize")]
        public static void* g_pngnSrvcMgr_GetEngineSwapChainSize( void* w, void* h )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pngnSrvcMgr_SetEngineState")]
        public static void* g_pngnSrvcMgr_SetEngineState( void* hWnd, void* hSwapChain )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pngnSrvcMgr_ExitMainLoop")]
        public static void* g_pngnSrvcMgr_ExitMainLoop()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pFllFlSystm_GetSymLink")]
        public static void* g_pFllFlSystm_GetSymLink( void* pPath, void* pathID )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pFllFlSystm_AddSymLink")]
        public static void* g_pFllFlSystm_AddSymLink( void* pPath, void* pathID, void* realPath )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pFllFlSystm_RemoveSymLink")]
        public static void* g_pFllFlSystm_RemoveSymLink( void* pPath, void* pathID )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pFllFlSystm_ResetProjectPaths")]
        public static void* g_pFllFlSystm_ResetProjectPaths( int includeCloudAssets )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pFllFlSystm_AddProjectPath")]
        public static void* g_pFllFlSystm_AddProjectPath( void* ident, void* fullPath )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pFllFlSystm_AddCloudPath")]
        public static void* g_pFllFlSystm_AddCloudPath( void* ident, void* fullPath )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pInputService_IsAppActive")]
        public static int g_pInputService_IsAppActive()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pInputService_HasMouseFocus")]
        public static int g_pInputService_HasMouseFocus()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pInputService_Key_NameForBinding")]
        public static void* g_pInputService_Key_NameForBinding( void* binding )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pInputService_GetBinding")]
        public static void* g_pInputService_GetBinding( long button )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pInputService_SetCursorPosition")]
        public static void* g_pInputService_SetCursorPosition( int x, int y )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pInputService_Pump")]
        public static void* g_pInputService_Pump()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pInputSystem_RegisterWindowWithSDL")]
        public static void* g_pInputSystem_RegisterWindowWithSDL( void* hwnd )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pInputSystem_UnregisterWindowFromSDL")]
        public static void* g_pInputSystem_UnregisterWindowFromSDL( void* hwnd )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pInputSystem_SetEditorMainWindow")]
        public static void* g_pInputSystem_SetEditorMainWindow( void* hwnd )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pInputSystem_OnEditorGameFocusChange")]
        public static void* g_pInputSystem_OnEditorGameFocusChange( void* hwnd, int bIsFocused )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pInputSystem_SetCursorPosition")]
        public static void* g_pInputSystem_SetCursorPosition( int x, int y, void* window )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pInputSystem_HasMouseFocus")]
        public static int g_pInputSystem_HasMouseFocus()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pInputSystem_IsAppActive")]
        public static int g_pInputSystem_IsAppActive()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pInputSystem_IsIMEAllowed")]
        public static int g_pInputSystem_IsIMEAllowed()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pInputSystem_SetIMEAllowed")]
        public static void* g_pInputSystem_SetIMEAllowed( int bAllowed )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pInputSystem_SetIMETextLocation")]
        public static void* g_pInputSystem_SetIMETextLocation( int x, int y, int nWidth, int nHeight )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pInputSystem_DismissIME")]
        public static void* g_pInputSystem_DismissIME()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pInputSystem_CodeToString")]
        public static void* g_pInputSystem_CodeToString( long code )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pInputSystem_StringToButtonCode")]
        public static long g_pInputSystem_StringToButtonCode( void* pString )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pInputSystem_VirtualKeyToButtonCode")]
        public static long g_pInputSystem_VirtualKeyToButtonCode( int nVirtualKey )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pInputSystem_ButtonCodeToVirtualKey")]
        public static int g_pInputSystem_ButtonCodeToVirtualKey( long code )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pInputSystem_SetRelativeMouseMode")]
        public static void* g_pInputSystem_SetRelativeMouseMode( int bState )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pInputSystem_GetRelativeMouseMode")]
        public static int g_pInputSystem_GetRelativeMouseMode()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pInputSystem_SetCursorStandard")]
        public static void* g_pInputSystem_SetCursorStandard( long cursor )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pInputSystem_SetCursorUser")]
        public static void* g_pInputSystem_SetCursorUser( void* pName )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pInputSystem_LoadCursorFromFile")]
        public static int g_pInputSystem_LoadCursorFromFile( void* pFileName, void* pName, int nHotX, int nHotY )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pInputSystem_ShutdownUserCursors")]
        public static void* g_pInputSystem_ShutdownUserCursors()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pMtrlSystm2_CreateRawMaterial")]
        public static void* g_pMtrlSystm2_CreateRawMaterial( void* materialName, void* shader, int anonymous )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pMtrlSystm2_CreateProceduralMaterialCopy")]
        public static void* g_pMtrlSystm2_CreateProceduralMaterialCopy( void* hSrcMaterial, int nResourceType, int bRecreateStaticBuffers )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pMtrlSystm2_FindOrCreateMaterialFromResource")]
        public static void* g_pMtrlSystm2_FindOrCreateMaterialFromResource( void* pResourceName )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pMtrlSystm2_FrameUpdate")]
        public static void* g_pMtrlSystm2_FrameUpdate()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pMeshSystem_CreateSceneObject")]
        public static int g_pMeshSystem_CreateSceneObject( void* model, void* modelToWorld, void* pDescName, long nFlags, long nObjectTypeFlags, void* pWorld, int creationFlags )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pMeshSystem_ChangeModel")]
        public static void* g_pMeshSystem_ChangeModel( void* obj, void* model )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pPhysicsSystem_NumWorlds")]
        public static int g_pPhysicsSystem_NumWorlds()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pPhysicsSystem_CreateWorld")]
        public static int g_pPhysicsSystem_CreateWorld()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pPhysicsSystem_DestroyWorld")]
        public static void* g_pPhysicsSystem_DestroyWorld( void* world )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pPhysicsSystem_GetSurfacePropertyController")]
        public static void* g_pPhysicsSystem_GetSurfacePropertyController()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pPhysicsSystem_CastHeightField")]
        public static int g_pPhysicsSystem_CastHeightField( void* vOut, void* vRayStart, void* vRayDelta, void* Heights, int SizeX, int SizeY, float SizeScale, float HeightScale )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pPhysicsSystem_GetAggregateData")]
        public static void* g_pPhysicsSystem_GetAggregateData( void* resourceName )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pPhysicsSystem_UpdateSurfaceProperties")]
        public static void* g_pPhysicsSystem_UpdateSurfaceProperties( void* pSurfaceProperties )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRenderDevice_FindOrCreateSamplerState")]
        public static void* g_pRenderDevice_FindOrCreateSamplerState( void* samplerDesc )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRenderDevice_GetSamplerIndex")]
        public static int g_pRenderDevice_GetSamplerIndex( void* samplerState )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRenderDevice_GetSwapChainInfo")]
        public static void* g_pRenderDevice_GetSwapChainInfo( void* swapChain )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRenderDevice_FindOrCreateFileTexture")]
        public static void* g_pRenderDevice_FindOrCreateFileTexture( void* pFileName, long nLoadMode )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRenderDevice_FindOrCreateTexture2")]
        public static void* g_pRenderDevice_FindOrCreateTexture2( void* pResourceName, int bIsAnonymous, void* pDescriptor, void* data, int dataSize )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRenderDevice_ClearTexture")]
        public static void* g_pRenderDevice_ClearTexture( void* hTexture, void* color )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRenderDevice_AsyncSetTextureData2")]
        public static void* g_pRenderDevice_AsyncSetTextureData2( void* hTexture, void* pData, int nDataSize, void* rect )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRenderDevice_GetSwapChainTexture")]
        public static void* g_pRenderDevice_GetSwapChainTexture( void* swapChain, long bufferType )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRenderDevice_GetGPUFrameTimeMS")]
        public static int g_pRenderDevice_GetGPUFrameTimeMS( void* swapChain, void* pGPUFrameTimeMSOut, void* pFrameNumberOut )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRenderDevice_GetTextureDesc")]
        public static void* g_pRenderDevice_GetTextureDesc( void* hTexture )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRenderDevice_GetOnDiskTextureDesc")]
        public static void* g_pRenderDevice_GetOnDiskTextureDesc( void* hTexture )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRenderDevice_GetTextureMultisampleType")]
        public static long g_pRenderDevice_GetTextureMultisampleType( void* hTexture )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRenderDevice_CreateRenderContext")]
        public static void* g_pRenderDevice_CreateRenderContext( uint flags )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRenderDevice_ReleaseRenderContext")]
        public static void* g_pRenderDevice_ReleaseRenderContext( void* context )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRenderDevice_ReadTexturePixels")]
        public static int g_pRenderDevice_ReadTexturePixels( void* hTexture, void* pSrcRect, int nSrcSlice, int nSrcMip, void* pDstRect, void* pData, long dstFormat, int nDstStride )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRenderDevice_DestroySwapChain")]
        public static void* g_pRenderDevice_DestroySwapChain( void* hSwapChain )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRenderDevice_Present")]
        public static int g_pRenderDevice_Present( void* chain )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRenderDevice_Flush")]
        public static void* g_pRenderDevice_Flush()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRenderDevice_CanRenderToSwapChain")]
        public static int g_pRenderDevice_CanRenderToSwapChain( void* chain )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRenderDevice_IsUsing32BitDepthBuffer")]
        public static int g_pRenderDevice_IsUsing32BitDepthBuffer()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRenderDevice_GetBackbufferDimensions")]
        public static void* g_pRenderDevice_GetBackbufferDimensions( void* chain )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRenderDevice_CompileAndCreateShader")]
        public static void* g_pRenderDevice_CompileAndCreateShader( long nType, void* pProgram, uint nBufLen, void* pShaderVersion, void* pDebugName )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRenderDevice_GetTextureLastUsed")]
        public static int g_pRenderDevice_GetTextureLastUsed( void* hTexture )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRenderDevice_UnThrottleTextureStreamingForNFrames")]
        public static void* g_pRenderDevice_UnThrottleTextureStreamingForNFrames( uint nNumberOfFramesForUnthrottledTextureLoading )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRenderDevice_GetNumTextureLoadsInFlight")]
        public static int g_pRenderDevice_GetNumTextureLoadsInFlight()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRenderDevice_SetForcePreloadStreamingData")]
        public static void* g_pRenderDevice_SetForcePreloadStreamingData( int bForcePreloadStreamingData )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRenderDevice_GetRenderDeviceAPI")]
        public static long g_pRenderDevice_GetRenderDeviceAPI()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRenderDevice_MarkTextureUsed")]
        public static void* g_pRenderDevice_MarkTextureUsed( void* texture, int nRequiredMipSize )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRenderDevice_IsTextureRenderTarget")]
        public static int g_pRenderDevice_IsTextureRenderTarget( void* texture )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRenderDevice_IsRayTracingSupported")]
        public static int g_pRenderDevice_IsRayTracingSupported()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRenderDevice_CreateGPUBuffer")]
        public static void* g_pRenderDevice_CreateGPUBuffer( long nType, void* desc, long usage, void* pDebugName )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRenderDevice_DestroyGPUBuffer")]
        public static void* g_pRenderDevice_DestroyGPUBuffer( void* hGPUBuffer )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRenderDevice_ReadBuffer")]
        public static int g_pRenderDevice_ReadBuffer( void* hBuffer, uint nOffsetInBytes, void* pBuf, uint nBytesToRead )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRenderDevice_GetDeviceSpecificInfo")]
        public static void* g_pRenderDevice_GetDeviceSpecificInfo( long info )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRenderDevice_GetGraphicsAPISpecificTextureHandle")]
        public static void* g_pRenderDevice_GetGraphicsAPISpecificTextureHandle( void* hTexture )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRenderDevice_GetDeviceSpecificTexture")]
        public static void* g_pRenderDevice_GetDeviceSpecificTexture( void* hTexture )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRenderDevice_GetTextureViewIndex")]
        public static int g_pRenderDevice_GetTextureViewIndex( void* hTexture, byte colorSpace, long dim )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRenderDevice_GetTextureResidencyInfo")]
        public static void* g_pRenderDevice_GetTextureResidencyInfo( void* pTextures, void* pNames )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRenderDevice_GetSheetInfo")]
        public static void* g_pRenderDevice_GetSheetInfo( void* texture )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRenderDevice_GetSequenceCount")]
        public static int g_pRenderDevice_GetSequenceCount( void* texture )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRenderDevice_GetSequence")]
        public static void* g_pRenderDevice_GetSequence( void* texture, int index )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRenderService_GetMultisampleType")]
        public static long g_pRenderService_GetMultisampleType()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRsrcCmplrSyst_GenerateResourceFile")]
        public static int g_pRsrcCmplrSyst_GenerateResourceFile( void* path, void* pData, int size )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRsrcCmplrSyst_GenerateResourceFile_1")]
        public static int g_pRsrcCmplrSyst_GenerateResourceFile_1( void* path, void* text )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRsrcCmplrSyst_GenerateResourceBytes")]
        public static void* g_pRsrcCmplrSyst_GenerateResourceBytes( void* path, void* pData, int size )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRsrcSystm_ReloadSymlinkedResidentResources")]
        public static void* g_pRsrcSystm_ReloadSymlinkedResidentResources()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRsrcSystm_UpdateSimple")]
        public static void* g_pRsrcSystm_UpdateSimple()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRsrcSystm_HasPendingWork")]
        public static int g_pRsrcSystm_HasPendingWork()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRsrcSystm_LoadResourceInManifest")]
        public static void* g_pRsrcSystm_LoadResourceInManifest( void* name )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRsrcSystm_DestroyResourceManifest")]
        public static void* g_pRsrcSystm_DestroyResourceManifest( void* manifest )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRsrcSystm_IsManifestLoaded")]
        public static int g_pRsrcSystm_IsManifestLoaded( void* manifest )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pRsrcSystm_GetAllCodeManifests")]
        public static void* g_pRsrcSystm_GetAllCodeManifests( void* values )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pSceneSystem_DeleteSceneObject")]
        public static void* g_pSceneSystem_DeleteSceneObject( void* pObj )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pSceneSystem_DeleteSceneObjectAtFrameEnd")]
        public static void* g_pSceneSystem_DeleteSceneObjectAtFrameEnd( void* pObj )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pSceneSystem_CreateSkyBox")]
        public static int g_pSceneSystem_CreateSkyBox( void* skyMaterial, void* world )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pSceneSystem_CreateDecal")]
        public static int g_pSceneSystem_CreateDecal( void* world )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pSceneSystem_BeginRenderingDynamicView")]
        public static void* g_pSceneSystem_BeginRenderingDynamicView( void* pView )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pSceneSystem_GetWellKnownTexture")]
        public static void* g_pSceneSystem_GetWellKnownTexture( long a )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pSceneSystem_GetWellKnownMaterialHandle")]
        public static void* g_pSceneSystem_GetWellKnownMaterialHandle( long a )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pSceneSystem_GetPerFrameStats")]
        public static void* g_pSceneSystem_GetPerFrameStats()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pSceneSystem_CreateWorld")]
        public static int g_pSceneSystem_CreateWorld( void* debugName )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pSceneSystem_DestroyWorld")]
        public static void* g_pSceneSystem_DestroyWorld( void* world )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pSceneSystem_SetupPerObjectLighting")]
        public static void* g_pSceneSystem_SetupPerObjectLighting( void* renderAttributes, void* pSceneObject, void* pSceneLayerInterface )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pSceneSystem_CreatePointLight")]
        public static int g_pSceneSystem_CreatePointLight( void* pWorld )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pSceneSystem_CreateSpotLight")]
        public static int g_pSceneSystem_CreateSpotLight( void* pWorld )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pSceneSystem_CreateOrthoLight")]
        public static int g_pSceneSystem_CreateOrthoLight( void* pWorld )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pSceneSystem_CreateDirectionalLight")]
        public static int g_pSceneSystem_CreateDirectionalLight( void* pWorld, void* direction )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pSceneSystem_CreateEnvMap")]
        public static int g_pSceneSystem_CreateEnvMap( void* pWorld, int nProjectionMode )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pSceneSystem_CreateLightProbeVolume")]
        public static int g_pSceneSystem_CreateLightProbeVolume( void* pWorld )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pSceneSystem_MarkEnvironmentMapObjectUpdated")]
        public static void* g_pSceneSystem_MarkEnvironmentMapObjectUpdated( void* pEnvMap )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pSceneSystem_MarkLightProbeVolumeObjectUpdated")]
        public static void* g_pSceneSystem_MarkLightProbeVolumeObjectUpdated( void* pLightProbe )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pSceneSystem_AddCullingBox")]
        public static uint g_pSceneSystem_AddCullingBox( void* pWorld, int nCullMode, void* vOrigin, void* vAngles, void* vExtents )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pSceneSystem_RemoveCullingBox")]
        public static void* g_pSceneSystem_RemoveCullingBox( void* pWorld, uint nBoxId )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pSceneSystem_AddVolumetricFogVolume")]
        public static uint g_pSceneSystem_AddVolumetricFogVolume( void* pWorld, void* volume )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pSceneSystem_RemoveVolumetricFogVolume")]
        public static void* g_pSceneSystem_RemoveVolumetricFogVolume( void* pWorld, uint nId )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pSceneSystem_DownsampleTexture")]
        public static void* g_pSceneSystem_DownsampleTexture( void* ctx, void* src, byte nDownsampleType )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pSceneSystem_RenderTiledLightCulling")]
        public static void* g_pSceneSystem_RenderTiledLightCulling( void* pCtx, void* pView, void* viewport )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pSceneSystem_BindTransformSlot")]
        public static void* g_pSceneSystem_BindTransformSlot( void* pCtx, int nVBSlot, int nTransformSlotIndex )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pSceneSystem_CreateRayTraceWorld")]
        public static void* g_pSceneSystem_CreateRayTraceWorld( void* pWorldDebugName, int nMaxRayTypes )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pSceneSystem_DestroyRayTraceWorld")]
        public static void* g_pSceneSystem_DestroyRayTraceWorld( void* pRayTraceSceneWorld )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pSceneUtils_CreateTonemapSystem")]
        public static void* g_pSceneUtils_CreateTonemapSystem()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pSceneUtils_DestroyTonemapSystem")]
        public static void* g_pSceneUtils_DestroyTonemapSystem( void* pTonemapSystem )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pSceneUtils_CreateVolumetricFog")]
        public static void* g_pSceneUtils_CreateVolumetricFog()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pSceneUtils_DestroyVolumetricFog")]
        public static void* g_pSceneUtils_DestroyVolumetricFog( void* pVolumetricFog )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pSndSystmntrnl_GetNumAudioDevices")]
        public static int g_pSndSystmntrnl_GetNumAudioDevices()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pSndSystmntrnl_GetAudioDeviceDesc")]
        public static void* g_pSndSystmntrnl_GetAudioDeviceDesc( int index )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pSndSystmntrnl_GetAudioDeviceId")]
        public static void* g_pSndSystmntrnl_GetAudioDeviceId( int index )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pSndSystmntrnl_GetAudioDeviceName")]
        public static void* g_pSndSystmntrnl_GetAudioDeviceName( int index )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pSndSystmntrnl_GetActiveAudioDevice")]
        public static void* g_pSndSystmntrnl_GetActiveAudioDevice()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pSndSystmntrnl_SetActiveAudioDevice")]
        public static void* g_pSndSystmntrnl_SetActiveAudioDevice( void* id )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pSndSystmntrnl_PlaySoundAtOSLevel")]
        public static void* g_pSndSystmntrnl_PlaySoundAtOSLevel( void* filename )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pSndSystmntrnl_PrecacheSound")]
        public static void* g_pSndSystmntrnl_PrecacheSound( void* pSoundName )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pSndSystmntrnl_CreateSound")]
        public static void* g_pSndSystmntrnl_CreateSound( void* pSoundName, int nChannels, int nRate, int nFormat, int nSampleCount, float flDuration, int bLoop, void* pData, int nDataSize )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pSndSystmntrnl_PreloadSound")]
        public static void* g_pSndSystmntrnl_PreloadSound( void* pSfx )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pWrldRndrrMgr_ServiceWorldRequests")]
        public static void* g_pWrldRndrrMgr_ServiceWorldRequests()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pWrldRndrrMgr_UpdateObjectsForRendering")]
        public static uint g_pWrldRndrrMgr_UpdateObjectsForRendering( void* worldGroupId, void* eyePos, float flLODScale, float flMaxVisibleDistance )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pWrldRndrrMgr_CreateWorld")]
        public static void* g_pWrldRndrrMgr_CreateWorld( void* pMapName, void* pSceneWorld, int bAsyncLoad, int bIgnoreExistingWorlds, int bLoadVis, int bPrecacheOnly, void* worldGroupId, void* transform )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pWrldRndrrMgr_MountWorldVPK")]
        public static int g_pWrldRndrrMgr_MountWorldVPK( void* pWorldName, void* pVpkPath )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pWrldRndrrMgr_UnmountWorldVPK")]
        public static int g_pWrldRndrrMgr_UnmountWorldVPK( void* pWorldName )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "global_Plat_ScreenToWindowCoords")]
        public static void* global_Plat_ScreenToWindowCoords( void* hwnd, void* x, void* y )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "global_Plat_WindowToScreenCoords")]
        public static void* global_Plat_WindowToScreenCoords( void* hwnd, void* x, void* y )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "global_Plat_MessageBox")]
        public static void* global_Plat_MessageBox( void* title, void* message )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "global_Plat_GetDesktopResolution")]
        public static int global_Plat_GetDesktopResolution( int nMonitorIndex, void* pWidth, void* pHeight, void* pRefreshRate )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "global_Plat_GetDefaultMonitorIndex")]
        public static int global_Plat_GetDefaultMonitorIndex()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "global_Plat_SafeRemoveFile")]
        public static int global_Plat_SafeRemoveFile( void* file )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "global_Plat_SetModuleFilename")]
        public static void* global_Plat_SetModuleFilename( void* filename )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "global_Plat_SetCurrentDirectory")]
        public static void* global_Plat_SetCurrentDirectory( void* filename )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "global_Plat_GetCurrentFrame")]
        public static ulong global_Plat_GetCurrentFrame()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "global_Plat_SetCurrentFrame")]
        public static void* global_Plat_SetCurrentFrame( ulong nFrame )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "global_Plat_ChangeCurrentFrame")]
        public static void* global_Plat_ChangeCurrentFrame( long nDelta )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "global_Plat_IsRunningOnCustomerMachine")]
        public static int global_Plat_IsRunningOnCustomerMachine()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "global_Plat_HasClipboardText")]
        public static int global_Plat_HasClipboardText()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "global_Plat_SetClipboardText")]
        public static void* global_Plat_SetClipboardText( void* text )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "global_Plat_GetClipboardText")]
        public static void* global_Plat_GetClipboardText()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "global_Plat_ClearClipboardText")]
        public static void* global_Plat_ClearClipboardText()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "global_IsWindowFocused")]
        public static int global_IsWindowFocused()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "global_IsRetail")]
        public static int global_IsRetail()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "global_HasLaunchParameter")]
        public static int global_HasLaunchParameter( void* name )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "global_Plat_SetNoAssert")]
        public static void* global_Plat_SetNoAssert()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "global_GetGameRootFolder")]
        public static void* global_GetGameRootFolder()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "global_GetGameSearchPath")]
        public static void* global_GetGameSearchPath()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "global_SourceEngineUnitTestInit")]
        public static int global_SourceEngineUnitTestInit()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "global_SourceEnginePreInit")]
        public static int global_SourceEnginePreInit( void* lpCmdLine, void* appDict )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "global_SourceEngineInit")]
        public static int global_SourceEngineInit( void* appDict )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "global_SourceEngineFrame")]
        public static int global_SourceEngineFrame( void* appDict, double currentTime, double previousTime )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "global_SourceEngineShutdown")]
        public static void* global_SourceEngineShutdown( void* appDict, int forced )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "global_UpdateWindowSize")]
        public static void* global_UpdateWindowSize()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "global_GetDiagonalDpi")]
        public static float global_GetDiagonalDpi()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "global_AppIsDedicatedServer")]
        public static int global_AppIsDedicatedServer()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "global_ToolsStallMonitor_IndicateActivity")]
        public static void* global_ToolsStallMonitor_IndicateActivity()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalOVRLipSync_ovrLipSync_Initialize")]
        public static long globalOVRLipSync_ovrLipSync_Initialize( int sampleRate, int bufferSize )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalOVRLipSync_ovrLipSync_Shutdown")]
        public static long globalOVRLipSync_ovrLipSync_Shutdown()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalOVRLipSync_ovrLipSync_DestroyContext")]
        public static long globalOVRLipSync_ovrLipSync_DestroyContext( uint context )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalOVRLipSync_ovrLipSync_ResetContext")]
        public static long globalOVRLipSync_ovrLipSync_ResetContext( uint context )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalOVRLipSync_ovrLipSync_CreateContext")]
        public static long globalOVRLipSync_ovrLipSync_CreateContext( void* pContext, long provider )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalOVRLipSync_ovrLipSync_CreateContextEx")]
        public static long globalOVRLipSync_ovrLipSync_CreateContextEx( void* pContext, long provider, int sampleRate, int enableAcceleration )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalOVRLipSync_ovrLipSync_SendSignal")]
        public static long globalOVRLipSync_ovrLipSync_SendSignal( uint context, long signal, int arg1, int arg2 )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalOVRLipSync_ovrLipSync_ProcessFrameEx")]
        public static long globalOVRLipSync_ovrLipSync_ProcessFrameEx( uint context, void* audioBuffer, int sampleCount, long dataType, void* frame )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalSteam_SteamHTMLSurface")]
        public static void* globalSteam_SteamHTMLSurface()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalSteam_SteamAPI_RunCallbacks")]
        public static void* globalSteam_SteamAPI_RunCallbacks()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalSteam_SteamGameServer_RunCallbacks")]
        public static void* globalSteam_SteamGameServer_RunCallbacks()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalSteam_SteamUser")]
        public static void* globalSteam_SteamUser()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalSteam_SteamFriends")]
        public static void* globalSteam_SteamFriends()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalSteam_SteamNetworkingMessages")]
        public static void* globalSteam_SteamNetworkingMessages()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalSteam_SteamNetworkingUtils")]
        public static void* globalSteam_SteamNetworkingUtils()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalSteam_SteamMatchmaking")]
        public static void* globalSteam_SteamMatchmaking()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalSteam_SteamGameServer")]
        public static void* globalSteam_SteamGameServer()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalSteam_SteamApps")]
        public static void* globalSteam_SteamApps()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalSteam_SteamUtils")]
        public static void* globalSteam_SteamUtils()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalSteam_SteamGameServer_BSecure")]
        public static int globalSteam_SteamGameServer_BSecure()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalSteam_SteamGameServer_GetSteamID")]
        public static ulong globalSteam_SteamGameServer_GetSteamID()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalSteam_SteamGameServer_Shutdown")]
        public static void* globalSteam_SteamGameServer_Shutdown()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalSteam_SteamGameServer_ReleaseCurrentThreadMemory")]
        public static void* globalSteam_SteamGameServer_ReleaseCurrentThreadMemory()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalSteam_SteamNetworkingSockets")]
        public static void* globalSteam_SteamNetworkingSockets()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalSteam_SteamGameServer_Init")]
        public static void* globalSteam_SteamGameServer_Init( int gamePort, int queryPort, void* serverVersion )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeNew")]
        public static void* globalYoga_YGNodeNew()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeNewWithConfig")]
        public static void* globalYoga_YGNodeNewWithConfig( void* config )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeFree")]
        public static void* globalYoga_YGNodeFree( void* r )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeReset")]
        public static void* globalYoga_YGNodeReset( void* r )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeCalculateLayout")]
        public static void* globalYoga_YGNodeCalculateLayout( void* r, float ownerWidth, float ownerHeight, long direction )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeGetHasNewLayout")]
        public static int globalYoga_YGNodeGetHasNewLayout( void* r )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeSetHasNewLayout")]
        public static void* globalYoga_YGNodeSetHasNewLayout( void* r, int b )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeIsDirty")]
        public static void* globalYoga_YGNodeIsDirty( void* r )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeMarkDirty")]
        public static void* globalYoga_YGNodeMarkDirty( void* r )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeInsertChild")]
        public static void* globalYoga_YGNodeInsertChild( void* owner, void* child, int index )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeRemoveChild")]
        public static void* globalYoga_YGNodeRemoveChild( void* owner, void* child )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeRemoveAllChildren")]
        public static void* globalYoga_YGNodeRemoveAllChildren( void* owner )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeGetChildCount")]
        public static ulong globalYoga_YGNodeGetChildCount( void* owner )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeGetParent")]
        public static void* globalYoga_YGNodeGetParent( void* owner )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeSetConfig")]
        public static void* globalYoga_YGNodeSetConfig( void* r, void* congig )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeLayoutGetLeft")]
        public static float globalYoga_YGNodeLayoutGetLeft( void* r )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeLayoutGetTop")]
        public static float globalYoga_YGNodeLayoutGetTop( void* r )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeLayoutGetRight")]
        public static float globalYoga_YGNodeLayoutGetRight( void* r )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeLayoutGetBottom")]
        public static float globalYoga_YGNodeLayoutGetBottom( void* r )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeLayoutGetWidth")]
        public static float globalYoga_YGNodeLayoutGetWidth( void* r )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeLayoutGetHeight")]
        public static float globalYoga_YGNodeLayoutGetHeight( void* r )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeLayoutGetDirection")]
        public static long globalYoga_YGNodeLayoutGetDirection( void* r )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeLayoutGetHadOverflow")]
        public static float globalYoga_YGNodeLayoutGetHadOverflow( void* r )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeLayoutGetMargin")]
        public static float globalYoga_YGNodeLayoutGetMargin( void* node, long edge )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeLayoutGetBorder")]
        public static float globalYoga_YGNodeLayoutGetBorder( void* node, long edge )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeLayoutGetPadding")]
        public static float globalYoga_YGNodeLayoutGetPadding( void* node, long edge )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGConfigNew")]
        public static void* globalYoga_YGConfigNew()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGConfigFree")]
        public static void* globalYoga_YGConfigFree( void* c )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGConfigSetUseWebDefaults")]
        public static void* globalYoga_YGConfigSetUseWebDefaults( void* config, int enabled )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGConfigSetPointScaleFactor")]
        public static void* globalYoga_YGConfigSetPointScaleFactor( void* config, float pixelsInPoint )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeCopyStyle")]
        public static void* globalYoga_YGNodeCopyStyle( void* dstNode, void* srcNode )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleSetDirection")]
        public static void* globalYoga_YGNodeStyleSetDirection( void* node, long direction )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleGetDirection")]
        public static long globalYoga_YGNodeStyleGetDirection( void* node )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleSetFlexDirection")]
        public static void* globalYoga_YGNodeStyleSetFlexDirection( void* node, long flexDirection )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleGetFlexDirection")]
        public static long globalYoga_YGNodeStyleGetFlexDirection( void* node )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleSetJustifyContent")]
        public static void* globalYoga_YGNodeStyleSetJustifyContent( void* node, long justifyContent )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleGetJustifyContent")]
        public static long globalYoga_YGNodeStyleGetJustifyContent( void* node )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleSetAlignContent")]
        public static void* globalYoga_YGNodeStyleSetAlignContent( void* node, long alignContent )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleGetAlignContent")]
        public static long globalYoga_YGNodeStyleGetAlignContent( void* node )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleSetAlignItems")]
        public static void* globalYoga_YGNodeStyleSetAlignItems( void* node, long alignItems )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleGetAlignItems")]
        public static long globalYoga_YGNodeStyleGetAlignItems( void* node )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleSetAlignSelf")]
        public static void* globalYoga_YGNodeStyleSetAlignSelf( void* node, long alignSelf )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleGetAlignSelf")]
        public static long globalYoga_YGNodeStyleGetAlignSelf( void* node )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleSetPositionType")]
        public static void* globalYoga_YGNodeStyleSetPositionType( void* node, long positionType )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleGetPositionType")]
        public static long globalYoga_YGNodeStyleGetPositionType( void* node )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleSetFlexWrap")]
        public static void* globalYoga_YGNodeStyleSetFlexWrap( void* node, long flexWrap )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleGetFlexWrap")]
        public static long globalYoga_YGNodeStyleGetFlexWrap( void* node )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleSetOverflow")]
        public static void* globalYoga_YGNodeStyleSetOverflow( void* node, long overflow )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleGetOverflow")]
        public static long globalYoga_YGNodeStyleGetOverflow( void* node )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleSetDisplay")]
        public static void* globalYoga_YGNodeStyleSetDisplay( void* node, long display )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleGetDisplay")]
        public static long globalYoga_YGNodeStyleGetDisplay( void* node )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleSetFlex")]
        public static void* globalYoga_YGNodeStyleSetFlex( void* node, float flex )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleGetFlex")]
        public static float globalYoga_YGNodeStyleGetFlex( void* node )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleSetFlexGrow")]
        public static void* globalYoga_YGNodeStyleSetFlexGrow( void* node, float flexGrow )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleGetFlexGrow")]
        public static float globalYoga_YGNodeStyleGetFlexGrow( void* node )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleSetFlexShrink")]
        public static void* globalYoga_YGNodeStyleSetFlexShrink( void* node, float flexShrink )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleGetFlexShrink")]
        public static float globalYoga_YGNodeStyleGetFlexShrink( void* node )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleSetFlexBasis")]
        public static void* globalYoga_YGNodeStyleSetFlexBasis( void* node, float flexBasis )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleSetFlexBasisPercent")]
        public static void* globalYoga_YGNodeStyleSetFlexBasisPercent( void* node, float flexBasis )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleSetFlexBasisAuto")]
        public static void* globalYoga_YGNodeStyleSetFlexBasisAuto( void* node )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleGetFlexBasis")]
        public static void* globalYoga_YGNodeStyleGetFlexBasis( void* node )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleSetPosition")]
        public static void* globalYoga_YGNodeStyleSetPosition( void* node, long edge, float position )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleSetPositionPercent")]
        public static void* globalYoga_YGNodeStyleSetPositionPercent( void* node, long edge, float position )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleGetPosition")]
        public static void* globalYoga_YGNodeStyleGetPosition( void* node, long edge )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleSetMargin")]
        public static void* globalYoga_YGNodeStyleSetMargin( void* node, long edge, float margin )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleSetMarginPercent")]
        public static void* globalYoga_YGNodeStyleSetMarginPercent( void* node, long edge, float margin )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleSetMarginAuto")]
        public static void* globalYoga_YGNodeStyleSetMarginAuto( void* node, long edge )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleGetMargin")]
        public static void* globalYoga_YGNodeStyleGetMargin( void* node, long edge )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleSetPadding")]
        public static void* globalYoga_YGNodeStyleSetPadding( void* node, long edge, float padding )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleSetPaddingPercent")]
        public static void* globalYoga_YGNodeStyleSetPaddingPercent( void* node, long edge, float padding )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleGetPadding")]
        public static void* globalYoga_YGNodeStyleGetPadding( void* node, long edge )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleSetBorder")]
        public static void* globalYoga_YGNodeStyleSetBorder( void* node, long edge, float border )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleGetBorder")]
        public static float globalYoga_YGNodeStyleGetBorder( void* node, long edge )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleSetGap")]
        public static void* globalYoga_YGNodeStyleSetGap( void* node, long gutter, float gapLength )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleGetGap")]
        public static float globalYoga_YGNodeStyleGetGap( void* node, long gutter )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleSetWidth")]
        public static void* globalYoga_YGNodeStyleSetWidth( void* node, float width )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleSetWidthPercent")]
        public static void* globalYoga_YGNodeStyleSetWidthPercent( void* node, float width )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleSetWidthAuto")]
        public static void* globalYoga_YGNodeStyleSetWidthAuto( void* node )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleGetWidth")]
        public static void* globalYoga_YGNodeStyleGetWidth( void* node )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleSetHeight")]
        public static void* globalYoga_YGNodeStyleSetHeight( void* node, float height )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleSetHeightPercent")]
        public static void* globalYoga_YGNodeStyleSetHeightPercent( void* node, float height )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleSetHeightAuto")]
        public static void* globalYoga_YGNodeStyleSetHeightAuto( void* node )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleGetHeight")]
        public static void* globalYoga_YGNodeStyleGetHeight( void* node )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleSetMinWidth")]
        public static void* globalYoga_YGNodeStyleSetMinWidth( void* node, float minWidth )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleSetMinWidthPercent")]
        public static void* globalYoga_YGNodeStyleSetMinWidthPercent( void* node, float minWidth )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleGetMinWidth")]
        public static void* globalYoga_YGNodeStyleGetMinWidth( void* node )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleSetMinHeight")]
        public static void* globalYoga_YGNodeStyleSetMinHeight( void* node, float minHeight )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleSetMinHeightPercent")]
        public static void* globalYoga_YGNodeStyleSetMinHeightPercent( void* node, float minHeight )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleGetMinHeight")]
        public static void* globalYoga_YGNodeStyleGetMinHeight( void* node )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleSetMaxWidth")]
        public static void* globalYoga_YGNodeStyleSetMaxWidth( void* node, float maxWidth )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleSetMaxWidthPercent")]
        public static void* globalYoga_YGNodeStyleSetMaxWidthPercent( void* node, float maxWidth )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleGetMaxWidth")]
        public static void* globalYoga_YGNodeStyleGetMaxWidth( void* node )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleSetMaxHeight")]
        public static void* globalYoga_YGNodeStyleSetMaxHeight( void* node, float maxHeight )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleSetMaxHeightPercent")]
        public static void* globalYoga_YGNodeStyleSetMaxHeightPercent( void* node, float maxHeight )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleGetMaxHeight")]
        public static void* globalYoga_YGNodeStyleGetMaxHeight( void* node )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleSetAspectRatio")]
        public static void* globalYoga_YGNodeStyleSetAspectRatio( void* node, float aspectRatio )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeStyleGetAspectRatio")]
        public static float globalYoga_YGNodeStyleGetAspectRatio( void* node )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeSetMeasureFunc")]
        public static void* globalYoga_YGNodeSetMeasureFunc( void* node, void* measureFunc )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "globalYoga_YGNodeHasMeasureFunc")]
        public static int globalYoga_YGNodeHasMeasureFunc( void* node )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Glue_Networking_RunCallbacks")]
        public static void* Glue_Networking_RunCallbacks()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Glue_Networking_SetDebugFunction")]
        public static void* Glue_Networking_SetDebugFunction( int level, void* func )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Glue_Networking_GetAuthenticationStatus")]
        public static long Glue_Networking_GetAuthenticationStatus( void* debugMsg )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Glue_Networking_GetRelayNetworkStatus")]
        public static long Glue_Networking_GetRelayNetworkStatus( void* debugMsg )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Glue_Networking_CreateSocket")]
        public static void* Glue_Networking_CreateSocket( int virtualPort )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Glue_Networking_CreateIpBasedSocket")]
        public static void* Glue_Networking_CreateIpBasedSocket( int useFakeIP )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Glue_Networking_CloseSocket")]
        public static void* Glue_Networking_CloseSocket( void* socket )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Glue_Networking_GetSocketAddress")]
        public static void* Glue_Networking_GetSocketAddress( void* socket )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Glue_Networking_BeginAsyncRequestFakeIP")]
        public static void* Glue_Networking_BeginAsyncRequestFakeIP()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Glue_Networking_GetIdentity")]
        public static void* Glue_Networking_GetIdentity()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Glue_Networking_CreatePollGroup")]
        public static void* Glue_Networking_CreatePollGroup()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Glue_Networking_DestroyPollGroup")]
        public static void* Glue_Networking_DestroyPollGroup( void* group )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Glue_Networking_SetPollGroup")]
        public static void* Glue_Networking_SetPollGroup( void* connection, void* group )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Glue_Networking_GetPollGroupMessages")]
        public static int Glue_Networking_GetPollGroupMessages( void* group, void* array_of_pointers, int maxmessages )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Glue_Networking_ConnectToSteamId")]
        public static void* Glue_Networking_ConnectToSteamId( ulong steamid, int virtualPort )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Glue_Networking_ConnectToIpAddress")]
        public static void* Glue_Networking_ConnectToIpAddress( void* address )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Glue_Networking_CloseConnection")]
        public static void* Glue_Networking_CloseConnection( void* c, int reason, void* debugReason )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Glue_Networking_AcceptConnection")]
        public static void* Glue_Networking_AcceptConnection( void* c )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Glue_Networking_FlushMessagesOnConnection")]
        public static void* Glue_Networking_FlushMessagesOnConnection( void* c )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Glue_Networking_SendMessage")]
        public static long Glue_Networking_SendMessage( void* c, void* data, int length, int flags )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Glue_Networking_GetConnectionMessages")]
        public static int Glue_Networking_GetConnectionMessages( void* c, void* array_of_pointers, int maxmessages )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Glue_Networking_GetConnectionState")]
        public static int Glue_Networking_GetConnectionState( void* c )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Glue_Networking_GetConnectionDescription")]
        public static void* Glue_Networking_GetConnectionDescription( void* c )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Glue_Networking_GetConnectionSteamId")]
        public static ulong Glue_Networking_GetConnectionSteamId( void* c )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Glue_RndrDvcMngr_WriteVideoConfig")]
        public static void* Glue_RndrDvcMngr_WriteVideoConfig()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Glue_RndrDvcMngr_ResetVideoConfig")]
        public static void* Glue_RndrDvcMngr_ResetVideoConfig()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Glue_RndrDvcMngr_ChangeVideoMode")]
        public static void* Glue_RndrDvcMngr_ChangeVideoMode( int fullscreen, int noborder, int vsync, int width, int height, long multisample )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Glue_RndrDvcMngr_GetDisplayModes")]
        public static int Glue_RndrDvcMngr_GetDisplayModes( void* modes, int max, int windowed )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Glue_Resources_GetMaterial")]
        public static void* Glue_Resources_GetMaterial( void* name )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Glue_Resources_GetTexture")]
        public static void* Glue_Resources_GetTexture( void* name )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Glue_Resources_GetModel")]
        public static void* Glue_Resources_GetModel( void* name )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Glue_Resources_GetAnimationGraph")]
        public static void* Glue_Resources_GetAnimationGraph( void* name )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Glue_Resources_GetShader")]
        public static void* Glue_Resources_GetShader( void* name )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IAnimationGraph_DestroyStrongHandle")]
        public static void* IAnimationGraph_DestroyStrongHandle( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IAnimationGraph_IsStrongHandleValid", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int IAnimationGraph_IsStrongHandleValid( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IAnimationGraph_IsError", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int IAnimationGraph_IsError( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IAnimationGraph_IsStrongHandleLoaded", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int IAnimationGraph_IsStrongHandleLoaded( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IAnimationGraph_CopyStrongHandle", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* IAnimationGraph_CopyStrongHandle( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IAnimationGraph_GetBindingPtr", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* IAnimationGraph_GetBindingPtr( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IAnimationGraph_GetResourceName")]
        public static void* IAnimationGraph_GetResourceName( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IAnimationGraph_GetParameterList")]
        public static void* IAnimationGraph_GetParameterList( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IAnimParameter_GetName")]
        public static void* IAnimParameter_GetName( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IAnimParameter_GetParameterType")]
        public static long IAnimParameter_GetParameterType( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IAnimParameter_GetDefaultValue")]
        public static void* IAnimParameter_GetDefaultValue( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IAnimParameter_GetMinValue")]
        public static void* IAnimParameter_GetMinValue( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IAnimParameter_GetMaxValue")]
        public static void* IAnimParameter_GetMaxValue( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IAnimParameter_GetNumOptionNames")]
        public static int IAnimParameter_GetNumOptionNames( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IAnimParameter_GetOptionName")]
        public static void* IAnimParameter_GetOptionName( void* self, int nIndex )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "nmPrmtrnstnc_SetValue")]
        public static void* nmPrmtrnstnc_SetValue( void* self, int val )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "nmPrmtrnstnc_SetValue_1")]
        public static void* nmPrmtrnstnc_SetValue_1( void* self, int val )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "nmPrmtrnstnc_SetValue_2")]
        public static void* nmPrmtrnstnc_SetValue_2( void* self, float val )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "nmPrmtrnstnc_SetValue_3")]
        public static void* nmPrmtrnstnc_SetValue_3( void* self, void* val )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "nmPrmtrnstnc_SetValue_4")]
        public static void* nmPrmtrnstnc_SetValue_4( void* self, void* val )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "nmPrmtrnstnc_SetEnumValue")]
        public static void* nmPrmtrnstnc_SetEnumValue( void* self, int val )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "nmPrmtrnstnc_GetName")]
        public static void* nmPrmtrnstnc_GetName( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "nmPrmtrnstnc_IsAutoReset")]
        public static int nmPrmtrnstnc_IsAutoReset( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "nmPrmtrnstnc_GetParameterType")]
        public static long nmPrmtrnstnc_GetParameterType( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "nmPrmtrLst_Count")]
        public static int nmPrmtrLst_Count( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "nmPrmtrLst_GetParameter")]
        public static void* nmPrmtrLst_GetParameter( void* self, int index )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "nmPrmtrLst_GetParameter_1")]
        public static void* nmPrmtrLst_GetParameter_1( void* self, void* name )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "syncRsrcDtRqst_GetFileName")]
        public static void* syncRsrcDtRqst_GetFileName( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "syncRsrcDtRqst_GetResultBuffer")]
        public static void* syncRsrcDtRqst_GetResultBuffer( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "syncRsrcDtRqst_GetResultBufferSize")]
        public static long syncRsrcDtRqst_GetResultBufferSize( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ImageLoader_GetMemRequired")]
        public static int ImageLoader_GetMemRequired( int width, int height, int depth, long imageFormat, int mipmap )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ImageLoader_GetMemRequired_1")]
        public static int ImageLoader_GetMemRequired_1( int width, int height, int depth, int mipmaps, long imageFormat )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ImageLoader_ConvertImageFormat")]
        public static int ImageLoader_ConvertImageFormat( void* src, long srcImageFormat, void* dst, long dstImageFormat, int width, int height, int srcStride, int dstStride )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IMaterial2_DestroyStrongHandle")]
        public static void* IMaterial2_DestroyStrongHandle( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IMaterial2_IsStrongHandleValid", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int IMaterial2_IsStrongHandleValid( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IMaterial2_IsError", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int IMaterial2_IsError( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IMaterial2_IsStrongHandleLoaded", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int IMaterial2_IsStrongHandleLoaded( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IMaterial2_CopyStrongHandle", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* IMaterial2_CopyStrongHandle( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IMaterial2_GetBindingPtr", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* IMaterial2_GetBindingPtr( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IMaterial2_GetName")]
        public static void* IMaterial2_GetName( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IMaterial2_GetNameWithMod")]
        public static void* IMaterial2_GetNameWithMod( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IMaterial2_GetSimilarityKey")]
        public static ulong IMaterial2_GetSimilarityKey( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IMaterial2_IsLoaded")]
        public static int IMaterial2_IsLoaded( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IMaterial2_GetMode")]
        public static void* IMaterial2_GetMode( void* self, void* token )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IMaterial2_GetMode_1")]
        public static void* IMaterial2_GetMode_1( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IMaterial2_GetMode_2")]
        public static void* IMaterial2_GetMode_2( void* self, void* layer )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IMaterial2_GetRenderAttributes")]
        public static void* IMaterial2_GetRenderAttributes( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IMaterial2_RecreateAllStaticConstantAndCommandBuffers")]
        public static void* IMaterial2_RecreateAllStaticConstantAndCommandBuffers( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IMaterial2_GetFirstTextureAttribute")]
        public static void* IMaterial2_GetFirstTextureAttribute( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IMaterial2_GetBoolAttributeOrDefault")]
        public static int IMaterial2_GetBoolAttributeOrDefault( void* self, void* name, int i )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IMaterial2_GetIntAttributeOrDefault")]
        public static int IMaterial2_GetIntAttributeOrDefault( void* self, void* name, int i )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IMaterial2_GetFloatAttributeOrDefault")]
        public static float IMaterial2_GetFloatAttributeOrDefault( void* self, void* name, float f )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IMaterial2_GetTextureAttributeOrDefault")]
        public static void* IMaterial2_GetTextureAttributeOrDefault( void* self, void* name )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IMaterial2_HasParam")]
        public static int IMaterial2_HasParam( void* self, void* name )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IMaterial2_Set")]
        public static void* IMaterial2_Set( void* self, void* name, void* val )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IMaterial2_GetString")]
        public static void* IMaterial2_GetString( void* self, void* name, void* defaultValue )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IMaterial2_Set_1")]
        public static void* IMaterial2_Set_1( void* self, void* name, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IMaterial2_GetVector4")]
        public static void* IMaterial2_GetVector4( void* self, void* name )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IMaterial2_Set_2")]
        public static void* IMaterial2_Set_2( void* self, void* name, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IMaterial2_GetTexture")]
        public static void* IMaterial2_GetTexture( void* self, void* name )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IMaterial2_SetEdited")]
        public static void* IMaterial2_SetEdited( void* self, int b )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IMaterial2_IsEdited")]
        public static int IMaterial2_IsEdited( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IMaterial2_ReloadStaticCombos")]
        public static void* IMaterial2_ReloadStaticCombos( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Physggrgtnstnc_WakeUp")]
        public static void* Physggrgtnstnc_WakeUp( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Physggrgtnstnc_PutToSleep")]
        public static void* Physggrgtnstnc_PutToSleep( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Physggrgtnstnc_IsAsleep")]
        public static int Physggrgtnstnc_IsAsleep( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Physggrgtnstnc_SetVelocity")]
        public static void* Physggrgtnstnc_SetVelocity( void* self, void* v )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Physggrgtnstnc_AddVelocity")]
        public static void* Physggrgtnstnc_AddVelocity( void* self, void* v )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Physggrgtnstnc_SetAngularVelocity")]
        public static void* Physggrgtnstnc_SetAngularVelocity( void* self, void* v )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Physggrgtnstnc_AddAngularVelocity")]
        public static void* Physggrgtnstnc_AddAngularVelocity( void* self, void* v )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Physggrgtnstnc_GetBodyCount")]
        public static int Physggrgtnstnc_GetBodyCount( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Physggrgtnstnc_GetBodyHandle")]
        public static int Physggrgtnstnc_GetBodyHandle( void* self, int i )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Physggrgtnstnc_GetBodyName")]
        public static void* Physggrgtnstnc_GetBodyName( void* self, int i )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Physggrgtnstnc_GetBodyNameHash")]
        public static uint Physggrgtnstnc_GetBodyNameHash( void* self, int i )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Physggrgtnstnc_GetBodyByNameHash")]
        public static int Physggrgtnstnc_GetBodyByNameHash( void* self, int i )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Physggrgtnstnc_GetBodyIndex")]
        public static int Physggrgtnstnc_GetBodyIndex( void* self, void* body )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Physggrgtnstnc_FindBodyByName")]
        public static int Physggrgtnstnc_FindBodyByName( void* self, void* name )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Physggrgtnstnc_GetJointCount")]
        public static int Physggrgtnstnc_GetJointCount( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Physggrgtnstnc_GetJointHandle")]
        public static int Physggrgtnstnc_GetJointHandle( void* self, int nIndex )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Physggrgtnstnc_RemoveJoint")]
        public static void* Physggrgtnstnc_RemoveJoint( void* self, void* pJoint )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Physggrgtnstnc_GetOrigin")]
        public static void* Physggrgtnstnc_GetOrigin( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Physggrgtnstnc_GetMassCenter")]
        public static void* Physggrgtnstnc_GetMassCenter( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Physggrgtnstnc_SetSurfaceProperties")]
        public static void* Physggrgtnstnc_SetSurfaceProperties( void* self, void* name )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Physggrgtnstnc_GetTotalMass")]
        public static float Physggrgtnstnc_GetTotalMass( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Physggrgtnstnc_SetTotalMass")]
        public static void* Physggrgtnstnc_SetTotalMass( void* self, float flMass )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Physggrgtnstnc_SetLinearDamping")]
        public static void* Physggrgtnstnc_SetLinearDamping( void* self, float flLinearDamping )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Physggrgtnstnc_SetAngularDamping")]
        public static void* Physggrgtnstnc_SetAngularDamping( void* self, float flAngularDamping )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Physggrgtnstnc_GetWorld")]
        public static int Physggrgtnstnc_GetWorld( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_GetWorld")]
        public static int IPhysicsBody_GetWorld( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_SetGravityScale")]
        public static void* IPhysicsBody_SetGravityScale( void* self, float f )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_GetGravityScale")]
        public static float IPhysicsBody_GetGravityScale( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_IsGravityEnabled")]
        public static int IPhysicsBody_IsGravityEnabled( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_EnableGravity")]
        public static void* IPhysicsBody_EnableGravity( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_SetMass")]
        public static void* IPhysicsBody_SetMass( void* self, float f )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_GetMass")]
        public static float IPhysicsBody_GetMass( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_GetMassCenter")]
        public static void* IPhysicsBody_GetMassCenter( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_GetLocalMassCenter")]
        public static void* IPhysicsBody_GetLocalMassCenter( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_SetLocalMassCenter")]
        public static void* IPhysicsBody_SetLocalMassCenter( void* self, void* v )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_SetOverrideMassCenter")]
        public static void* IPhysicsBody_SetOverrideMassCenter( void* self, int bOverride )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_GetOverrideMassCenter")]
        public static int IPhysicsBody_GetOverrideMassCenter( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_SetPosition")]
        public static void* IPhysicsBody_SetPosition( void* self, void* v )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_GetPosition")]
        public static void* IPhysicsBody_GetPosition( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_SetOrientation")]
        public static void* IPhysicsBody_SetOrientation( void* self, void* q )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_GetOrientation")]
        public static void* IPhysicsBody_GetOrientation( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_SetTransform")]
        public static void* IPhysicsBody_SetTransform( void* self, void* v, void* q )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_GetTransform")]
        public static void* IPhysicsBody_GetTransform( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_SetLinearVelocity")]
        public static void* IPhysicsBody_SetLinearVelocity( void* self, void* v )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_GetLinearVelocity")]
        public static void* IPhysicsBody_GetLinearVelocity( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_GetVelocityAtPoint")]
        public static void* IPhysicsBody_GetVelocityAtPoint( void* self, void* v )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_AddLinearVelocity")]
        public static void* IPhysicsBody_AddLinearVelocity( void* self, void* v )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_SetAngularVelocity")]
        public static void* IPhysicsBody_SetAngularVelocity( void* self, void* v )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_GetAngularVelocity")]
        public static void* IPhysicsBody_GetAngularVelocity( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_Wake")]
        public static void* IPhysicsBody_Wake( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_Sleep")]
        public static void* IPhysicsBody_Sleep( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_IsSleeping")]
        public static int IPhysicsBody_IsSleeping( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_EnableAutoSleeping")]
        public static void* IPhysicsBody_EnableAutoSleeping( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_DisableAutoSleeping")]
        public static void* IPhysicsBody_DisableAutoSleeping( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_EnableTouchEvents")]
        public static void* IPhysicsBody_EnableTouchEvents( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_DisableTouchEvents")]
        public static void* IPhysicsBody_DisableTouchEvents( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_IsTouchEventEnabled")]
        public static int IPhysicsBody_IsTouchEventEnabled( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_GetType")]
        public static long IPhysicsBody_GetType( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_SetType")]
        public static void* IPhysicsBody_SetType( void* self, long type )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_GetShapeCount")]
        public static int IPhysicsBody_GetShapeCount( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_GetShape")]
        public static int IPhysicsBody_GetShape( void* self, int nShape )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_AddSphereShape")]
        public static int IPhysicsBody_AddSphereShape( void* self, void* vCenter, float flRadius )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_AddCapsuleShape")]
        public static int IPhysicsBody_AddCapsuleShape( void* self, void* vCenter1, void* vCenter2, float flRadius )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_AddBoxShape")]
        public static int IPhysicsBody_AddBoxShape( void* self, void* position, void* rotation, void* extent )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_AddHullShape")]
        public static int IPhysicsBody_AddHullShape( void* self, void* position, void* rotation, int numVertices, void* vertices )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_AddHullShape_1")]
        public static int IPhysicsBody_AddHullShape_1( void* self, void* hull, void* xform )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_AddHullShape_2")]
        public static int IPhysicsBody_AddHullShape_2( void* self, void* mesh, void* xform )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_AddMeshShape")]
        public static int IPhysicsBody_AddMeshShape( void* self, int numVertices, void* vertices, int numIndices, void* indices, int nMaterialCount )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_AddMeshShape_1")]
        public static int IPhysicsBody_AddMeshShape_1( void* self, void* mesh, void* xform, int nMaterialCount )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_AddHeightFieldShape")]
        public static int IPhysicsBody_AddHeightFieldShape( void* self, void* pHeights, void* pMaterials, int sizeX, int sizeY, float sizeScale, float heightScale, int nMaterialCount )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_RemoveShape")]
        public static void* IPhysicsBody_RemoveShape( void* self, void* pShape )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_PurgeShapes")]
        public static void* IPhysicsBody_PurgeShapes( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_ApplyLinearImpulse")]
        public static void* IPhysicsBody_ApplyLinearImpulse( void* self, void* impulse )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_ApplyLinearImpulseAtWorldSpace")]
        public static void* IPhysicsBody_ApplyLinearImpulseAtWorldSpace( void* self, void* impulse, void* pos )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_ApplyAngularImpulse")]
        public static void* IPhysicsBody_ApplyAngularImpulse( void* self, void* impulse )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_ApplyForce")]
        public static void* IPhysicsBody_ApplyForce( void* self, void* F )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_ApplyForceAt")]
        public static void* IPhysicsBody_ApplyForceAt( void* self, void* F, void* r )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_ApplyTorque")]
        public static void* IPhysicsBody_ApplyTorque( void* self, void* M )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_ClearForces")]
        public static void* IPhysicsBody_ClearForces( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_ClearTorque")]
        public static void* IPhysicsBody_ClearTorque( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_Enable")]
        public static void* IPhysicsBody_Enable( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_Disable")]
        public static void* IPhysicsBody_Disable( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_IsEnabled")]
        public static int IPhysicsBody_IsEnabled( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_BuildMass")]
        public static void* IPhysicsBody_BuildMass( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_SetLinearDamping")]
        public static void* IPhysicsBody_SetLinearDamping( void* self, float d )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_GetLinearDamping")]
        public static float IPhysicsBody_GetLinearDamping( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_SetAngularDamping")]
        public static void* IPhysicsBody_SetAngularDamping( void* self, float d )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_GetAngularDamping")]
        public static float IPhysicsBody_GetAngularDamping( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_BuildBounds")]
        public static void* IPhysicsBody_BuildBounds( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_GetDensity")]
        public static float IPhysicsBody_GetDensity( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_GetClosestPoint")]
        public static void* IPhysicsBody_GetClosestPoint( void* self, void* vPoint )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_SetMaterialIndex")]
        public static void* IPhysicsBody_SetMaterialIndex( void* self, void* name )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_GetAggregate")]
        public static int IPhysicsBody_GetAggregate( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_SetTargetTransform")]
        public static void* IPhysicsBody_SetTargetTransform( void* self, void* vTargetPosition, void* vTargetAngles, float flTimeOffset )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_CheckOverlap")]
        public static int IPhysicsBody_CheckOverlap( void* self, void* body, void* transform )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_GetLocalInertiaVector")]
        public static void* IPhysicsBody_GetLocalInertiaVector( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_GetLocalInertiaOrientation")]
        public static void* IPhysicsBody_GetLocalInertiaOrientation( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_SetLocalInertia")]
        public static void* IPhysicsBody_SetLocalInertia( void* self, void* vInertia, void* qRotation )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_ResetLocalInertia")]
        public static void* IPhysicsBody_ResetLocalInertia( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_ManagedObject")]
        public static int IPhysicsBody_ManagedObject( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_SetMotionLocks")]
        public static void* IPhysicsBody_SetMotionLocks( void* self, int x, int y, int z, int pitch, int yaw, int roll )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_IsTouching")]
        public static int IPhysicsBody_IsTouching( void* self, void* pBody, int bTriggers )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_IsTouching_1")]
        public static int IPhysicsBody_IsTouching_1( void* self, void* pShape, int bTriggers )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsBody_SetTrigger")]
        public static void* IPhysicsBody_SetTrigger( void* self, int trigger )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_GetWorld")]
        public static int IPhysicsJoint_GetWorld( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_GetBody1")]
        public static int IPhysicsJoint_GetBody1( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_GetBody2")]
        public static int IPhysicsJoint_GetBody2( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_GetLocalFrameA")]
        public static void* IPhysicsJoint_GetLocalFrameA( void* self, void* position, void* rotation )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_GetLocalFrameB")]
        public static void* IPhysicsJoint_GetLocalFrameB( void* self, void* position, void* rotation )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_SetLocalFrameA")]
        public static void* IPhysicsJoint_SetLocalFrameA( void* self, void* position, void* rotation )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_SetLocalFrameB")]
        public static void* IPhysicsJoint_SetLocalFrameB( void* self, void* position, void* rotation )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_SetEnableCollision")]
        public static void* IPhysicsJoint_SetEnableCollision( void* self, int bEnabled )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_IsCollisionEnabled")]
        public static int IPhysicsJoint_IsCollisionEnabled( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_GetType")]
        public static long IPhysicsJoint_GetType( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_SetLinearSpring")]
        public static void* IPhysicsJoint_SetLinearSpring( void* self, void* vec )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_GetLinearSpring")]
        public static void* IPhysicsJoint_GetLinearSpring( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_SetAngularSpring")]
        public static void* IPhysicsJoint_SetAngularSpring( void* self, void* vec )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_GetAngularSpring")]
        public static void* IPhysicsJoint_GetAngularSpring( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_SetAngularMotor")]
        public static void* IPhysicsJoint_SetAngularMotor( void* self, float targetVelocity, float maxTorque )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_SetMinLength")]
        public static void* IPhysicsJoint_SetMinLength( void* self, float f )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_GetMinLength")]
        public static float IPhysicsJoint_GetMinLength( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_SetMaxLength")]
        public static void* IPhysicsJoint_SetMaxLength( void* self, float f )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_GetMaxLength")]
        public static float IPhysicsJoint_GetMaxLength( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_SetMinForce")]
        public static void* IPhysicsJoint_SetMinForce( void* self, float f )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_GetMinForce")]
        public static float IPhysicsJoint_GetMinForce( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_SetMaxForce")]
        public static void* IPhysicsJoint_SetMaxForce( void* self, float f )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_GetMaxForce")]
        public static float IPhysicsJoint_GetMaxForce( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_SetFriction")]
        public static void* IPhysicsJoint_SetFriction( void* self, float f )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_SetLimit")]
        public static void* IPhysicsJoint_SetLimit( void* self, void* name, void* limit )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_SetLimitEnabled")]
        public static void* IPhysicsJoint_SetLimitEnabled( void* self, void* name, int state )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_GetAngle")]
        public static float IPhysicsJoint_GetAngle( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_GetLinearImpulse")]
        public static float IPhysicsJoint_GetLinearImpulse( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_GetAngularImpulse")]
        public static float IPhysicsJoint_GetAngularImpulse( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_GetMaxLinearImpulse")]
        public static float IPhysicsJoint_GetMaxLinearImpulse( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_GetMaxAngularImpulse")]
        public static float IPhysicsJoint_GetMaxAngularImpulse( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_SetMaxLinearImpulse")]
        public static void* IPhysicsJoint_SetMaxLinearImpulse( void* self, float flMaxLinearImpulse )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_SetMaxAngularImpulse")]
        public static void* IPhysicsJoint_SetMaxAngularImpulse( void* self, float flMaxAngularImpulse )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_SetMotorVelocity")]
        public static void* IPhysicsJoint_SetMotorVelocity( void* self, void* velocity, float maxTorque )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_SetTargetRotation")]
        public static void* IPhysicsJoint_SetTargetRotation( void* self, void* rotation, float hertz, float damping )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_Motor_SetLinearVelocity")]
        public static void* IPhysicsJoint_Motor_SetLinearVelocity( void* self, void* velocity )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_Motor_SetAngularVelocity")]
        public static void* IPhysicsJoint_Motor_SetAngularVelocity( void* self, void* velocity )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_Motor_SetMaxVelocityForce")]
        public static void* IPhysicsJoint_Motor_SetMaxVelocityForce( void* self, float maxForce )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_Motor_SetMaxVelocityTorque")]
        public static void* IPhysicsJoint_Motor_SetMaxVelocityTorque( void* self, float maxTorque )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_Motor_SetLinearHertz")]
        public static void* IPhysicsJoint_Motor_SetLinearHertz( void* self, float hertz )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_Motor_SetLinearDampingRatio")]
        public static void* IPhysicsJoint_Motor_SetLinearDampingRatio( void* self, float damping )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_Motor_SetAngularHertz")]
        public static void* IPhysicsJoint_Motor_SetAngularHertz( void* self, float hertz )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_Motor_SetAngularDampingRatio")]
        public static void* IPhysicsJoint_Motor_SetAngularDampingRatio( void* self, float damping )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_Motor_SetMaxSpringForce")]
        public static void* IPhysicsJoint_Motor_SetMaxSpringForce( void* self, float maxForce )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_Motor_SetMaxSpringTorque")]
        public static void* IPhysicsJoint_Motor_SetMaxSpringTorque( void* self, float maxTorque )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_Motor_GetLinearVelocity")]
        public static void* IPhysicsJoint_Motor_GetLinearVelocity( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_Motor_GetAngularVelocity")]
        public static void* IPhysicsJoint_Motor_GetAngularVelocity( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_Motor_GetMaxVelocityForce")]
        public static float IPhysicsJoint_Motor_GetMaxVelocityForce( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_Motor_GetMaxVelocityTorque")]
        public static float IPhysicsJoint_Motor_GetMaxVelocityTorque( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_Motor_GetLinearHertz")]
        public static float IPhysicsJoint_Motor_GetLinearHertz( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_Motor_GetLinearDampingRatio")]
        public static float IPhysicsJoint_Motor_GetLinearDampingRatio( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_Motor_GetAngularHertz")]
        public static float IPhysicsJoint_Motor_GetAngularHertz( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_Motor_GetAngularDampingRatio")]
        public static float IPhysicsJoint_Motor_GetAngularDampingRatio( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_Motor_GetMaxSpringForce")]
        public static float IPhysicsJoint_Motor_GetMaxSpringForce( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsJoint_Motor_GetMaxSpringTorque")]
        public static float IPhysicsJoint_Motor_GetMaxSpringTorque( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsShape_AddCollisionFunctionMask")]
        public static void* IPhysicsShape_AddCollisionFunctionMask( void* self, byte nMask )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsShape_RemoveCollisionFunctionMask")]
        public static void* IPhysicsShape_RemoveCollisionFunctionMask( void* self, byte nMask )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsShape_GetCollisionFunctionMask")]
        public static byte IPhysicsShape_GetCollisionFunctionMask( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsShape_HasTag")]
        public static int IPhysicsShape_HasTag( void* self, uint tag )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsShape_AddTag")]
        public static int IPhysicsShape_AddTag( void* self, uint tag )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsShape_RemoveTag")]
        public static int IPhysicsShape_RemoveTag( void* self, uint tag )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsShape_ClearTags")]
        public static int IPhysicsShape_ClearTags( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsShape_GetBody")]
        public static int IPhysicsShape_GetBody( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsShape_SetMaterialIndex")]
        public static void* IPhysicsShape_SetMaterialIndex( void* self, void* name )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsShape_SetSurfaceIndex")]
        public static void* IPhysicsShape_SetSurfaceIndex( void* self, int nSurfaceIndex, int index )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsShape_GetMaterialName")]
        public static void* IPhysicsShape_GetMaterialName( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsShape_GetType")]
        public static long IPhysicsShape_GetType( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsShape_UpdateMeshShape")]
        public static void* IPhysicsShape_UpdateMeshShape( void* self, int numVertices, void* vertices, int numIndices, void* indices )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsShape_UpdateHeightShape")]
        public static void* IPhysicsShape_UpdateHeightShape( void* self, void* pHeights, void* pMaterials, int x, int y, int w, int h, float SizeScale, float HeightScale )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsShape_UpdateSphereShape")]
        public static void* IPhysicsShape_UpdateSphereShape( void* self, void* vCenter, float flRadius )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsShape_UpdateCapsuleShape")]
        public static void* IPhysicsShape_UpdateCapsuleShape( void* self, void* vCenter1, void* vCenter2, float flRadius )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsShape_UpdateHullShape")]
        public static void* IPhysicsShape_UpdateHullShape( void* self, void* position, void* rotation, int nVertexCount, void* pvVertexBase )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsShape_ManagedObject")]
        public static int IPhysicsShape_ManagedObject( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsShape_SetTrigger")]
        public static void* IPhysicsShape_SetTrigger( void* self, int trigger )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsShape_IsTrigger")]
        public static int IPhysicsShape_IsTrigger( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsShape_GetTriangulation")]
        public static void* IPhysicsShape_GetTriangulation( void* self, void* arrVectors, void* arrIndices )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsShape_GetTriangulationForNavmesh")]
        public static void* IPhysicsShape_GetTriangulationForNavmesh( void* self, void* arrVectors, void* arrIndices, void* bounds )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsShape_GetOutline")]
        public static void* IPhysicsShape_GetOutline( void* self, void* arrVectors )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsShape_AsSphere")]
        public static void* IPhysicsShape_AsSphere( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsShape_AsCapsule")]
        public static void* IPhysicsShape_AsCapsule( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsShape_UpdateBoxShape")]
        public static void* IPhysicsShape_UpdateBoxShape( void* self, void* vCenter, void* qRotation, void* vExtents )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsShape_SetFriction")]
        public static void* IPhysicsShape_SetFriction( void* self, float f )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsShape_GetFriction")]
        public static float IPhysicsShape_GetFriction( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsShape_SetLocalVelocity")]
        public static void* IPhysicsShape_SetLocalVelocity( void* self, void* v )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsShape_GetLocalVelocity")]
        public static void* IPhysicsShape_GetLocalVelocity( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsShape_SetElasticity")]
        public static void* IPhysicsShape_SetElasticity( void* self, float f )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsShape_SetRollingResistance")]
        public static void* IPhysicsShape_SetRollingResistance( void* self, float f )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsShape_SetIgnoreTraces")]
        public static void* IPhysicsShape_SetIgnoreTraces( void* self, int b )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsShape_SetHasNoMass")]
        public static void* IPhysicsShape_SetHasNoMass( void* self, int b )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsShape_BuildBounds")]
        public static void* IPhysicsShape_BuildBounds( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsShape_LocalBounds")]
        public static void* IPhysicsShape_LocalBounds( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsShape_IsTouching")]
        public static int IPhysicsShape_IsTouching( void* self, void* pShape, int bTriggers )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsWorld_AddBody")]
        public static int IPhysicsWorld_AddBody( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsWorld_RemoveBody")]
        public static void* IPhysicsWorld_RemoveBody( void* self, void* pBody )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsWorld_GetWorldReferenceBody")]
        public static int IPhysicsWorld_GetWorldReferenceBody( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsWorld_SetWorldReferenceBody")]
        public static void* IPhysicsWorld_SetWorldReferenceBody( void* self, void* pBody )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsWorld_RemoveJoint")]
        public static void* IPhysicsWorld_RemoveJoint( void* self, void* pJoint )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsWorld_SetGravity")]
        public static void* IPhysicsWorld_SetGravity( void* self, void* gravity )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsWorld_GetGravity")]
        public static void* IPhysicsWorld_GetGravity( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsWorld_SetSimulation")]
        public static void* IPhysicsWorld_SetSimulation( void* self, long simulation )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsWorld_GetSimulation")]
        public static long IPhysicsWorld_GetSimulation( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsWorld_EnableSleeping")]
        public static void* IPhysicsWorld_EnableSleeping( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsWorld_DisableSleeping")]
        public static void* IPhysicsWorld_DisableSleeping( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsWorld_IsSleepingEnabled")]
        public static int IPhysicsWorld_IsSleepingEnabled( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsWorld_SetMaximumLinearSpeed")]
        public static void* IPhysicsWorld_SetMaximumLinearSpeed( void* self, float flSpeed )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsWorld_AddWeldJoint")]
        public static int IPhysicsWorld_AddWeldJoint( void* self, void* pBody1, void* pBody2, void* localFrame1, void* localFrame2 )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsWorld_AddSpringJoint")]
        public static int IPhysicsWorld_AddSpringJoint( void* self, void* pBody1, void* pBody2, void* localFrame1, void* localFrame2 )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsWorld_AddRevoluteJoint")]
        public static int IPhysicsWorld_AddRevoluteJoint( void* self, void* pBody1, void* pBody2, void* localFrame1, void* localFrame2 )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsWorld_AddPrismaticJoint")]
        public static int IPhysicsWorld_AddPrismaticJoint( void* self, void* pBody1, void* pBody2, void* localFrame1, void* localFrame2 )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsWorld_AddSphericalJoint")]
        public static int IPhysicsWorld_AddSphericalJoint( void* self, void* pBody1, void* pBody2, void* localFrame1, void* localFrame2 )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsWorld_AddMotorJoint")]
        public static int IPhysicsWorld_AddMotorJoint( void* self, void* pBody1, void* pBody2, void* localFrame1, void* localFrame2 )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsWorld_SetCollisionRulesFromJson")]
        public static void* IPhysicsWorld_SetCollisionRulesFromJson( void* self, void* rules )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsWorld_StepSimulation")]
        public static void* IPhysicsWorld_StepSimulation( void* self, float flTimestep, int nNumSteps )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsWorld_ProcessIntersections")]
        public static void* IPhysicsWorld_ProcessIntersections( void* self, void* f )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsWorld_DestroyAggregateInstance")]
        public static void* IPhysicsWorld_DestroyAggregateInstance( void* self, void* pAggregate )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsWorld_CreateAggregateInstance")]
        public static int IPhysicsWorld_CreateAggregateInstance( void* self, void* resourceName, void* tmStart, ulong nGSNHandle, long nMotionType )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsWorld_CreateAggregateInstance_1")]
        public static int IPhysicsWorld_CreateAggregateInstance_1( void* self, void* model, void* tmStart, ulong nGSNHandle, long nMotionType )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsWorld_SetDebugScene")]
        public static void* IPhysicsWorld_SetDebugScene( void* self, void* world )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsWorld_GetDebugScene")]
        public static int IPhysicsWorld_GetDebugScene( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsWorld_Draw")]
        public static void* IPhysicsWorld_Draw( void* self, void* debugDrawFcn )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsWorld_ManagedObject")]
        public static int IPhysicsWorld_ManagedObject( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsWorld_Query")]
        public static void* IPhysicsWorld_Query( void* self, void* result, void* vCenter, float flRadius, ushort nObjectSetMask )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsWorld_Query_1")]
        public static void* IPhysicsWorld_Query_1( void* self, void* result, void* bounds, ushort nObjectSetMask )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPhysicsWorld_Query_2")]
        public static void* IPhysicsWorld_Query_2( void* self, void* result, void* pPoints, int nPoints, ushort nObjectSetMask )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "PhysSrfcPrprtyCn_GetSurfacePropCount")]
        public static int PhysSrfcPrprtyCn_GetSurfacePropCount( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "PhysSrfcPrprtyCn_GetSurfaceProperty")]
        public static void* PhysSrfcPrprtyCn_GetSurfaceProperty( void* self, int nIndex )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "PhysSrfcPrprtyCn_AddProperty")]
        public static void* PhysSrfcPrprtyCn_AddProperty( void* self, void* name, void* basename, void* description )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPVS_IsEmptyPVS")]
        public static int IPVS_IsEmptyPVS( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPVS_IsInPVS")]
        public static int IPVS_IsInPVS( void* self, int numSources, void* sources, void* position )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPVS_IsAbsBoxInPVS")]
        public static int IPVS_IsAbsBoxInPVS( void* self, int numSources, void* sources, void* mins, void* maxs )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPVS_IsSkyVisibleFromPosition")]
        public static int IPVS_IsSkyVisibleFromPosition( void* self, void* position )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IPVS_IsSunVisibleFromPosition")]
        public static int IPVS_IsSunVisibleFromPosition( void* self, void* position )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "RyTrcScnWrld_BeginBuild")]
        public static void* RyTrcScnWrld_BeginBuild( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "RyTrcScnWrld_AddSceneWorldToBuild")]
        public static void* RyTrcScnWrld_AddSceneWorldToBuild( void* self, void* pWorld, void* pRenderContext )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "RyTrcScnWrld_EndBuild")]
        public static int RyTrcScnWrld_EndBuild( void* self, void* pRenderContext, void* attrs )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "RyTrcScnWrld_BuildTLASForWorld")]
        public static int RyTrcScnWrld_BuildTLASForWorld( void* self, void* pWorld, void* attrs )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "RD_RgstrRsrcDttl_SetDataRegistrationFailed")]
        public static void* RD_RgstrRsrcDttl_SetDataRegistrationFailed( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "RD_RgstrRsrcDttl_IsReloading")]
        public static int RD_RgstrRsrcDttl_IsReloading( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "RD_RgstrRsrcDttl_SetFinalResourceData")]
        public static void* RD_RgstrRsrcDttl_SetFinalResourceData( void* self, void* pPtr )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "RD_RgstrRsrcDttl_GetDataRegistrationFailed")]
        public static int RD_RgstrRsrcDttl_GetDataRegistrationFailed( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "RD_RgstrRsrcDttl_GetFinalResourceData")]
        public static void* RD_RgstrRsrcDttl_GetFinalResourceData( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "RD_RgstrRsrcDttl_GetResultBufferSize")]
        public static long RD_RgstrRsrcDttl_GetResultBufferSize( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IRenderContext_Draw")]
        public static void* IRenderContext_Draw( void* self, long type, int nFirstVertex, int nVertexCount )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IRenderContext_DrawInstanced")]
        public static void* IRenderContext_DrawInstanced( void* self, long type, int nFirstVertex, int nVertexCountPerInstance, int nInstanceCount )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IRenderContext_DrawIndexed")]
        public static void* IRenderContext_DrawIndexed( void* self, long type, int nFirstIndex, int nIndexCount, int nMaxVertexCount, int nBaseVertex )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IRenderContext_DrawIndexedInstanced")]
        public static void* IRenderContext_DrawIndexedInstanced( void* self, long type, int nFirstIndex, int nIndexCountPerInstance, int nInstanceCount, int nMaxVertexCount, int nBaseVertex )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IRenderContext_DrawInstancedIndirect")]
        public static void* IRenderContext_DrawInstancedIndirect( void* self, long type, void* hDrawArgBuffer, uint nBufferOffset )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IRenderContext_DrawIndexedInstancedIndirect")]
        public static void* IRenderContext_DrawIndexedInstancedIndirect( void* self, long type, void* hDrawArgBuffer, uint nBufferOffset )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IRenderContext_TextureBarrierTransition")]
        public static void* IRenderContext_TextureBarrierTransition( void* self, void* hSrc, int mips, long srcStage, long dstStage, long layout, long srcFlags, long dstFlags )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IRenderContext_BufferBarrierTransition")]
        public static void* IRenderContext_BufferBarrierTransition( void* self, void* hSrc, long srcStage, long dstStage, long srcFlags, long dstFlags )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IRenderContext_SetScissorRect")]
        public static void* IRenderContext_SetScissorRect( void* self, void* rect )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IRenderContext_GetAttributesPtrForModify")]
        public static void* IRenderContext_GetAttributesPtrForModify( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IRenderContext_GenerateMipMaps")]
        public static void* IRenderContext_GenerateMipMaps( void* self, void* material )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IRenderContext_Clear")]
        public static void* IRenderContext_Clear( void* self, void* col, int clearColor, int clearDepth, int clearStencil )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IRenderContext_BindRenderTargets")]
        public static void* IRenderContext_BindRenderTargets( void* self, void* colorTexture, void* depthTexture, void* layer )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IRenderContext_RestoreRenderTargets")]
        public static void* IRenderContext_RestoreRenderTargets( void* self, void* layer )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IRenderContext_SetViewport")]
        public static void* IRenderContext_SetViewport( void* self, void* rect )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IRenderContext_SetViewport_1")]
        public static void* IRenderContext_SetViewport_1( void* self, void* viewport )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IRenderContext_SetViewport_2")]
        public static void* IRenderContext_SetViewport_2( void* self, int x, int y, int w, int h )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IRenderContext_GetViewport")]
        public static void* IRenderContext_GetViewport( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IRenderContext_Submit")]
        public static void* IRenderContext_Submit( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IRenderContext_SetAssociatedThreadIndex")]
        public static void* IRenderContext_SetAssociatedThreadIndex( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IRenderContext_BindRenderTargets_1")]
        public static void* IRenderContext_BindRenderTargets_1( void* self, void* swapChain, int color, int depth )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IRenderContext_BindIndexBuffer")]
        public static int IRenderContext_BindIndexBuffer( void* self, void* hIndexBuffer, int nOffset )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IRenderContext_BindIndexBuffer_1")]
        public static int IRenderContext_BindIndexBuffer_1( void* self, void* hIndexBuffer, int nIndexSize, int nOffset )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IRenderContext_BindVertexBuffer")]
        public static int IRenderContext_BindVertexBuffer( void* self, int nSlot, void* hVertexBuffer, int nOffset )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IRenderContext_BindVertexBuffer_1")]
        public static int IRenderContext_BindVertexBuffer_1( void* self, int nSlot, void* hVertexBuffer, int nOffset, int nStride )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IRenderContext_BindVertexBuffer_2")]
        public static int IRenderContext_BindVertexBuffer_2( void* self, int nSlot, void* hVertexBuffer, int nOffset )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IRenderContext_BindVertexBuffer_3")]
        public static int IRenderContext_BindVertexBuffer_3( void* self, int nSlot, void* hVertexBuffer, int nOffset, int nStride )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IRenderContext_BindVertexShader")]
        public static void* IRenderContext_BindVertexShader( void* self, void* hVertexShader, void* hInputLayout )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IRenderContext_BindPixelShader")]
        public static void* IRenderContext_BindPixelShader( void* self, void* hShader )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IRenderContext_SetDynamicConstantBufferData")]
        public static void* IRenderContext_SetDynamicConstantBufferData( void* self, long shaderType, void* pData, int nSize, int slot )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IRenderContext_BindTexture")]
        public static void* IRenderContext_BindTexture( void* self, int nTextureIndex, void* hTexture )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IRenderContext_ReadTexturePixels")]
        public static void* IRenderContext_ReadTexturePixels( void* self, void* hTexture, void* pCallback, void* srcRect, int nSrcSlice, int nSrcMip, int bDeleteCallbackWhenFinished )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IRenderContext_ReadBuffer")]
        public static void* IRenderContext_ReadBuffer( void* self, void* hBuffer, void* pCallback, int nOffset, int nBytesToRead, int bDeleteCallbackWhenFinished )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IRenderContext_BeginPixEvent")]
        public static void* IRenderContext_BeginPixEvent( void* self, void* name )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IRenderContext_EndPixEvent")]
        public static void* IRenderContext_EndPixEvent( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IRenderContext_PixSetMarker")]
        public static void* IRenderContext_PixSetMarker( void* self, void* name )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneLayer_SetObjectMatchID")]
        public static void* ISceneLayer_SetObjectMatchID( void* self, void* nTok )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneLayer_AddObjectFlagsRequiredMask")]
        public static void* ISceneLayer_AddObjectFlagsRequiredMask( void* self, long nRequiredFlags )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneLayer_AddObjectFlagsExcludedMask")]
        public static void* ISceneLayer_AddObjectFlagsExcludedMask( void* self, long nExcludedFlags )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneLayer_RemoveObjectFlagsRequiredMask")]
        public static void* ISceneLayer_RemoveObjectFlagsRequiredMask( void* self, long nRequiredFlags )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneLayer_RemoveObjectFlagsExcludedMask")]
        public static void* ISceneLayer_RemoveObjectFlagsExcludedMask( void* self, long nExcludedFlags )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneLayer_GetObjectFlagsRequiredMask")]
        public static long ISceneLayer_GetObjectFlagsRequiredMask( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneLayer_GetObjectFlagsExcludedMask")]
        public static long ISceneLayer_GetObjectFlagsExcludedMask( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneLayer_GetDebugName")]
        public static void* ISceneLayer_GetDebugName( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneLayer_GetRenderAttributesPtr")]
        public static void* ISceneLayer_GetRenderAttributesPtr( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneLayer_SetAttr")]
        public static void* ISceneLayer_SetAttr( void* self, void* nTokenID, void* hRenderTarget, long msaa, uint flags )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneLayer_SetBoundingVolumeSizeCullThresholdInPercent")]
        public static void* ISceneLayer_SetBoundingVolumeSizeCullThresholdInPercent( void* self, float flSizeCullThreshold )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneLayer_SetClearColor")]
        public static void* ISceneLayer_SetClearColor( void* self, void* vecColor, int nRenderTargetIndex )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneLayer_GetTextureValue")]
        public static void* ISceneLayer_GetTextureValue( void* self, void* nTokenID, void* nDefaultValue )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneLayer_GetTextureValue_1")]
        public static void* ISceneLayer_GetTextureValue_1( void* self, void* nTokenID )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneLayer_GetColorTarget")]
        public static void* ISceneLayer_GetColorTarget( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneLayer_GetDepthTarget")]
        public static void* ISceneLayer_GetDepthTarget( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneLayer_SetOutput")]
        public static void* ISceneLayer_SetOutput( void* self, void* hColor, void* hDepth )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ISceneLayer_m_nLayerFlags", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static long _Get__ISceneLayer_m_nLayerFlags( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ISceneLayer_m_nLayerFlags", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ISceneLayer_m_nLayerFlags( void* self, long value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ISceneLayer_LayerEnum", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static long _Get__ISceneLayer_LayerEnum( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ISceneLayer_LayerEnum", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ISceneLayer_LayerEnum( void* self, long value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ISceneLayer_m_viewport", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Get__ISceneLayer_m_viewport( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ISceneLayer_m_viewport", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ISceneLayer_m_viewport( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ISceneLayer_m_nClearFlags", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__ISceneLayer_m_nClearFlags( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ISceneLayer_m_nClearFlags", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ISceneLayer_m_nClearFlags( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneView_GetMainViewport")]
        public static void* ISceneView_GetMainViewport( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneView_GetSwapChain")]
        public static void* ISceneView_GetSwapChain( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneView_AddDependentView")]
        public static void* ISceneView_AddDependentView( void* self, void* pView, int nSlot )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneView_GetRenderAttributesPtr")]
        public static void* ISceneView_GetRenderAttributesPtr( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneView_AddRenderLayer")]
        public static void* ISceneView_AddRenderLayer( void* self, void* pszDebugName, void* viewport, void* eShaderMode, void* pAddBefore )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneView_AddManagedProceduralLayer")]
        public static void* ISceneView_AddManagedProceduralLayer( void* self, void* pszDebugName, void* viewport, void* renderCallback, void* pAddBefore, int bDeleteWhenDone )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneView_SetDefaultLayerObjectRequiredFlags")]
        public static void* ISceneView_SetDefaultLayerObjectRequiredFlags( void* self, long nFlags )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneView_SetDefaultLayerObjectExcludedFlags")]
        public static void* ISceneView_SetDefaultLayerObjectExcludedFlags( void* self, long nFlags )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneView_GetDefaultLayerObjectRequiredFlags")]
        public static long ISceneView_GetDefaultLayerObjectRequiredFlags( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneView_GetDefaultLayerObjectExcludedFlags")]
        public static long ISceneView_GetDefaultLayerObjectExcludedFlags( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneView_AddWorldToRenderList")]
        public static void* ISceneView_AddWorldToRenderList( void* self, void* pWorld )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneView_FindOrCreateRenderTarget")]
        public static void* ISceneView_FindOrCreateRenderTarget( void* self, void* pName, void* hTexture, int nFlags )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneView_SetParent")]
        public static void* ISceneView_SetParent( void* self, void* pParent )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneView_GetParent")]
        public static void* ISceneView_GetParent( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneView_GetPriority")]
        public static int ISceneView_GetPriority( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneView_SetPriority")]
        public static void* ISceneView_SetPriority( void* self, int nPriority )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneView_GetFrustum")]
        public static void* ISceneView_GetFrustum( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneView_GetPostProcessEnabled")]
        public static int ISceneView_GetPostProcessEnabled( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneView_GetToolsVisMode")]
        public static int ISceneView_GetToolsVisMode( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ISceneView_m_ViewUniqueId", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__ISceneView_m_ViewUniqueId( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ISceneView_m_ViewUniqueId", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ISceneView_m_ViewUniqueId( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ISceneView_m_ManagedCameraId", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__ISceneView_m_ManagedCameraId( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ISceneView_m_ManagedCameraId", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ISceneView_m_ManagedCameraId( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneWorld_DeleteAllObjects")]
        public static void* ISceneWorld_DeleteAllObjects( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneWorld_Release")]
        public static void* ISceneWorld_Release( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneWorld_GetSceneObjectCount")]
        public static int ISceneWorld_GetSceneObjectCount( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneWorld_IsEmpty")]
        public static int ISceneWorld_IsEmpty( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneWorld_GetWorldDebugName")]
        public static void* ISceneWorld_GetWorldDebugName( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneWorld_SetDeleteAtEndOfFrame")]
        public static void* ISceneWorld_SetDeleteAtEndOfFrame( void* self, int bDelete )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneWorld_GetDeleteAtEndOfFrame")]
        public static int ISceneWorld_GetDeleteAtEndOfFrame( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneWorld_DeleteEndOfFrameObjects")]
        public static void* ISceneWorld_DeleteEndOfFrameObjects( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneWorld_MeshTrace")]
        public static int ISceneWorld_MeshTrace( void* self, void* input, void* output )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneWorld_GetPVS")]
        public static void* ISceneWorld_GetPVS( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneWorld_SetPVS")]
        public static void* ISceneWorld_SetPVS( void* self, void* pPVS )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneWorld_Add3DSkyboxWorld")]
        public static void* ISceneWorld_Add3DSkyboxWorld( void* self, void* world )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneWorld_Remove3DSkyboxWorld")]
        public static void* ISceneWorld_Remove3DSkyboxWorld( void* self, void* world )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISceneWorld_Set3DSkyboxParameters")]
        public static void* ISceneWorld_Set3DSkyboxParameters( void* self, void* origin, void* angle, float scale )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ShdrCmplCntxt_Delete")]
        public static void* ShdrCmplCntxt_Delete( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ShdrCmplCntxt_SetMaskedCode")]
        public static void* ShdrCmplCntxt_SetMaskedCode( void* self, void* code )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISteamApps_BIsAppInstalled")]
        public static int ISteamApps_BIsAppInstalled( void* self, int appid )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISteamApps_BIsCybercafe")]
        public static int ISteamApps_BIsCybercafe( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISteamApps_BIsDlcInstalled")]
        public static int ISteamApps_BIsDlcInstalled( void* self, int appID )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISteamApps_BIsLowViolence")]
        public static int ISteamApps_BIsLowViolence( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISteamApps_BIsSubscribed")]
        public static int ISteamApps_BIsSubscribed( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISteamApps_BIsSubscribedApp")]
        public static int ISteamApps_BIsSubscribedApp( void* self, int appID )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISteamApps_GetAvailableGameLanguages")]
        public static void* ISteamApps_GetAvailableGameLanguages( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISteamApps_GetCurrentGameLanguage")]
        public static void* ISteamApps_GetCurrentGameLanguage( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISteamApps_GetAppBuildId")]
        public static int ISteamApps_GetAppBuildId( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISteamApps_BIsVACBanned")]
        public static int ISteamApps_BIsVACBanned( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISteamApps_GetCommandLine")]
        public static void* ISteamApps_GetCommandLine( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISteamApps_GetAppInstallDir")]
        public static void* ISteamApps_GetAppInstallDir( void* self, int appid )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISteamFriends_GetProfileItemPropertyString")]
        public static void* ISteamFriends_GetProfileItemPropertyString( void* self, ulong steamID, int itemType, int prop )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISteamFriends_RequestEquippedProfileItems")]
        public static ulong ISteamFriends_RequestEquippedProfileItems( void* self, ulong steamID )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISteamFriends_GetPersonaName")]
        public static void* ISteamFriends_GetPersonaName( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISteamFriends_SetRichPresence")]
        public static int ISteamFriends_SetRichPresence( void* self, void* pchKey, void* pchValue )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISteamFriends_ClearRichPresence")]
        public static void* ISteamFriends_ClearRichPresence( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISteamGameServer_SetServerName")]
        public static void* ISteamGameServer_SetServerName( void* self, void* name )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISteamGameServer_SetMapName")]
        public static void* ISteamGameServer_SetMapName( void* self, void* name )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISteamGameServer_SetGameTags")]
        public static void* ISteamGameServer_SetGameTags( void* self, void* tags )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISteamGameServer_SetDedicatedServer")]
        public static void* ISteamGameServer_SetDedicatedServer( void* self, int isDedicatedServer )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISteamGameServer_SetAdvertiseServerActive")]
        public static void* ISteamGameServer_SetAdvertiseServerActive( void* self, int heartbeats )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISteamGameServer_SetMaxPlayerCount")]
        public static void* ISteamGameServer_SetMaxPlayerCount( void* self, int maxPlayers )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISteamGameServer_LogOnAnonymous")]
        public static void* ISteamGameServer_LogOnAnonymous( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISteamGameServer_LogOn")]
        public static void* ISteamGameServer_LogOn( void* self, void* token )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISteamGameServer_LogOff")]
        public static void* ISteamGameServer_LogOff( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISteamGameServer_SetGameDescription")]
        public static void* ISteamGameServer_SetGameDescription( void* self, void* description )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISteamGameServer_SetProduct")]
        public static void* ISteamGameServer_SetProduct( void* self, void* productName )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISteamGameServer_SetModDir")]
        public static void* ISteamGameServer_SetModDir( void* self, void* modDir )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISteamGameServer_BLoggedOn")]
        public static int ISteamGameServer_BLoggedOn( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISteamGameServer_GetAuthSessionTicket")]
        public static void* ISteamGameServer_GetAuthSessionTicket( void* self, ulong targetSteamId, void* buffer, void* ticketLength )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISteamGameServer_BeginAuthSession")]
        public static long ISteamGameServer_BeginAuthSession( void* self, ulong senderSteamId, void* buffer, int length )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISteamGameServer_CancelAuthTicket")]
        public static void* ISteamGameServer_CancelAuthTicket( void* self, void* ticket )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISteamGameServer_EndAuthSession")]
        public static void* ISteamGameServer_EndAuthSession( void* self, ulong steamId )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "StmHTMLSrfc_Init")]
        public static int StmHTMLSrfc_Init( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "StmHTMLSrfc_Shutdown")]
        public static int StmHTMLSrfc_Shutdown( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "StmHTMLSrfc_CreateBrowser")]
        public static ulong StmHTMLSrfc_CreateBrowser( void* self, void* pchUserAgent, void* pchUserCSS )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "StmHTMLSrfc_RemoveBrowser")]
        public static void* StmHTMLSrfc_RemoveBrowser( void* self, uint bx )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "StmHTMLSrfc_LoadURL")]
        public static void* StmHTMLSrfc_LoadURL( void* self, uint bx, void* pchURL, void* pchPostData )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "StmHTMLSrfc_AddHeader")]
        public static void* StmHTMLSrfc_AddHeader( void* self, uint bx, void* key, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "StmHTMLSrfc_SetSize")]
        public static void* StmHTMLSrfc_SetSize( void* self, uint bx, uint w, uint h )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "StmHTMLSrfc_GetLinkAtPosition")]
        public static void* StmHTMLSrfc_GetLinkAtPosition( void* self, uint bx, uint w, uint h )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "StmHTMLSrfc_SetHorizontalScroll")]
        public static void* StmHTMLSrfc_SetHorizontalScroll( void* self, uint unBrowserHandle, uint nAbsolutePixelScroll )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "StmHTMLSrfc_SetVerticalScroll")]
        public static void* StmHTMLSrfc_SetVerticalScroll( void* self, uint unBrowserHandle, uint nAbsolutePixelScroll )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "StmHTMLSrfc_SetKeyFocus")]
        public static void* StmHTMLSrfc_SetKeyFocus( void* self, uint unBrowserHandle, int b )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "StmHTMLSrfc_AllowStartRequest")]
        public static void* StmHTMLSrfc_AllowStartRequest( void* self, uint bx, int b )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "StmHTMLSrfc_JSDialogResponse")]
        public static void* StmHTMLSrfc_JSDialogResponse( void* self, uint bx, int b )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "StmHTMLSrfc_SetBackgroundMode")]
        public static void* StmHTMLSrfc_SetBackgroundMode( void* self, uint bx, int b )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "StmHTMLSrfc_SetDPIScalingFactor")]
        public static void* StmHTMLSrfc_SetDPIScalingFactor( void* self, uint bx, float scale )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "StmHTMLSrfc_KeyDown")]
        public static void* StmHTMLSrfc_KeyDown( void* self, uint unBrowserHandle, uint key, int modifiers, int isSystemKey )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "StmHTMLSrfc_KeyUp")]
        public static void* StmHTMLSrfc_KeyUp( void* self, uint unBrowserHandle, uint key, int modifiers )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "StmHTMLSrfc_KeyChar")]
        public static void* StmHTMLSrfc_KeyChar( void* self, uint unBrowserHandle, uint unicodeChar, int modifiers )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "StmHTMLSrfc_MouseUp")]
        public static void* StmHTMLSrfc_MouseUp( void* self, uint unBrowserHandle, int eMouseButton )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "StmHTMLSrfc_MouseDown")]
        public static void* StmHTMLSrfc_MouseDown( void* self, uint unBrowserHandle, int eMouseButton )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "StmHTMLSrfc_MouseDoubleClick")]
        public static void* StmHTMLSrfc_MouseDoubleClick( void* self, uint unBrowserHandle, int eMouseButton )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "StmHTMLSrfc_MouseMove")]
        public static void* StmHTMLSrfc_MouseMove( void* self, uint unBrowserHandle, int x, int y )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "StmHTMLSrfc_MouseWheel")]
        public static void* StmHTMLSrfc_MouseWheel( void* self, uint unBrowserHandle, int nDelta )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "StmHTMLSrfc_SetCookie")]
        public static void* StmHTMLSrfc_SetCookie( void* self, void* pchHostname, void* pchKey, void* pchValue, void* pchPath, uint nExpires, int bSecure, int bHTTPOnly )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "StmMtchmkng_LeaveLobby")]
        public static void* StmMtchmkng_LeaveLobby( void* self, ulong steamid )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "StmMtchmkng_GetNumLobbyMembers")]
        public static int StmMtchmkng_GetNumLobbyMembers( void* self, ulong steamid )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "StmMtchmkng_GetLobbyMemberByIndex")]
        public static ulong StmMtchmkng_GetLobbyMemberByIndex( void* self, ulong steamid, int index )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "StmMtchmkng_GetLobbyData")]
        public static void* StmMtchmkng_GetLobbyData( void* self, ulong steamid, void* key )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "StmMtchmkng_SetLobbyData")]
        public static int StmMtchmkng_SetLobbyData( void* self, ulong steamid, void* key, void* data )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "StmMtchmkng_GetLobbyDataCount")]
        public static int StmMtchmkng_GetLobbyDataCount( void* self, ulong steamid )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "StmMtchmkng_DeleteLobbyData")]
        public static void* StmMtchmkng_DeleteLobbyData( void* self, ulong steamid, void* key )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "StmMtchmkng_GetLobbyDataByIndex")]
        public static int StmMtchmkng_GetLobbyDataByIndex( void* self, ulong steamid, int index, void* data, int datasize, void* value, int valueSize )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "StmNtwrkngMssgs_SendMessageToUser")]
        public static int StmNtwrkngMssgs_SendMessageToUser( void* self, ulong steamid, void* data, int dataSize, int flags, int channel )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "StmNtwrkngMssgs_ReceiveMessagesOnChannel")]
        public static int StmNtwrkngMssgs_ReceiveMessagesOnChannel( void* self, int channel, void* array_of_pointers, int maxmessages )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "StmNtwrkngMssgs_AcceptSessionWithUser")]
        public static int StmNtwrkngMssgs_AcceptSessionWithUser( void* self, ulong steamid )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "StmNtwrkngMssgs_CloseChannelWithUser")]
        public static int StmNtwrkngMssgs_CloseChannelWithUser( void* self, ulong steamid, int nLocalChannel )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "StmNtwrkngMssgs_ReleaseMessage")]
        public static void* StmNtwrkngMssgs_ReleaseMessage( void* self, void* message )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "StmNtwrkngMssgs_GetConnectionInfo")]
        public static void* StmNtwrkngMssgs_GetConnectionInfo( void* self, ulong steamid )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "StmNtwrkngSckts_GetConnectionInfo")]
        public static void* StmNtwrkngSckts_GetConnectionInfo( void* self, void* handle )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "StmNtwrkngSckts_StartAuthentication")]
        public static void* StmNtwrkngSckts_StartAuthentication( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "StmNtwrkngSckts_BeginRequestFakeIP")]
        public static void* StmNtwrkngSckts_BeginRequestFakeIP( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "StmNtwrkngSckts_ReleaseMessage")]
        public static void* StmNtwrkngSckts_ReleaseMessage( void* self, void* message )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "StmNtwrkngtls_SetConfig")]
        public static void* StmNtwrkngtls_SetConfig( void* self, long key, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "StmNtwrkngtls_SetConfig_1")]
        public static void* StmNtwrkngtls_SetConfig_1( void* self, long key, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "StmNtwrkngtls_InitializeRelayNetwork")]
        public static void* StmNtwrkngtls_InitializeRelayNetwork( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISteamUser_BLoggedOn")]
        public static int ISteamUser_BLoggedOn( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISteamUser_GetSteamID")]
        public static ulong ISteamUser_GetSteamID( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISteamUser_GetVoice")]
        public static int ISteamUser_GetVoice( void* self, int bWantCompressed, void* pDestBuffer, uint cbDestBufferSize, void* nBytesWritten )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISteamUser_GetAvailableVoice")]
        public static int ISteamUser_GetAvailableVoice( void* self, void* availableData )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISteamUser_GetVoiceOptimalSampleRate")]
        public static uint ISteamUser_GetVoiceOptimalSampleRate( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISteamUser_DecompressVoice")]
        public static int ISteamUser_DecompressVoice( void* self, void* pCompressed, uint cbCompressed, void* pDestBuffer, uint cbDestBufferSize, void* nBytesWritten, uint nDesiredSampleRate )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISteamUser_StartVoiceRecording")]
        public static void* ISteamUser_StartVoiceRecording( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISteamUser_StopVoiceRecording")]
        public static void* ISteamUser_StopVoiceRecording( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISteamUser_GetAuthSessionTicket")]
        public static void* ISteamUser_GetAuthSessionTicket( void* self, ulong targetSteamId, void* buffer, void* ticketLength )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISteamUser_BeginAuthSession")]
        public static long ISteamUser_BeginAuthSession( void* self, ulong senderSteamId, void* buffer, int length )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISteamUser_CancelAuthTicket")]
        public static void* ISteamUser_CancelAuthTicket( void* self, void* ticket )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISteamUser_EndAuthSession")]
        public static void* ISteamUser_EndAuthSession( void* self, ulong steamId )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISteamUtils_InitFilterText")]
        public static int ISteamUtils_InitFilterText( void* self, uint unFilterOptions )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ISteamUtils_FilterText")]
        public static int ISteamUtils_FilterText( void* self, long eContext, ulong sourceSteamID, void* pchInputMessage, void* pchOutFilteredText, uint nByteSizeOutFilteredText )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ITonemapSystem_SetTonemapParameters")]
        public static void* ITonemapSystem_SetTonemapParameters( void* self, void* pParams )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ITonemapSystem_ResetTonemapParameters")]
        public static void* ITonemapSystem_ResetTonemapParameters( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IVfx_Init")]
        public static void* IVfx_Init( void* self, void* factory )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IVfx_CompileShader")]
        public static void* IVfx_CompileShader( void* self, void* ctx, ulong staticcombo, ulong dynamiccombo, void* pVfx, long compileTarget, long programType, int useShaderCache, uint flags )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IVfx_ClearShaderCache")]
        public static void* IVfx_ClearShaderCache( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IVfx_CreateSharedContext")]
        public static void* IVfx_CreateSharedContext( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IVolumetricFog_IsFoggingEnabled")]
        public static void* IVolumetricFog_IsFoggingEnabled( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IVolumetricFog_SetParams")]
        public static void* IVolumetricFog_SetParams( void* self, void* parameters, void* bakedTexture )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IWorldReference_Release")]
        public static void* IWorldReference_Release( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IWorldReference_IsWorldLoaded")]
        public static int IWorldReference_IsWorldLoaded( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IWorldReference_IsErrorWorld")]
        public static int IWorldReference_IsErrorWorld( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IWorldReference_IsMarkedForDeletion")]
        public static int IWorldReference_IsMarkedForDeletion( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IWorldReference_GetWorldBounds")]
        public static int IWorldReference_GetWorldBounds( void* self, void* vMin, void* vMax )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IWorldReference_GetSceneWorld")]
        public static int IWorldReference_GetSceneWorld( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IWorldReference_PrecacheAllWorldNodes")]
        public static void* IWorldReference_PrecacheAllWorldNodes( void* self, uint flags )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IWorldReference_GetFolder")]
        public static void* IWorldReference_GetFolder( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IWorldReference_GetEntityCount")]
        public static int IWorldReference_GetEntityCount( void* self, void* pEntityLumpName )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IWorldReference_GetEntityKeyValues")]
        public static void* IWorldReference_GetEntityKeyValues( void* self, void* pEntityLumpName, int index )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "IWorldReference_SetWorldTransform")]
        public static void* IWorldReference_SetWorldTransform( void* self, void* transform )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "KeyValues3_DeleteThis")]
        public static void* KeyValues3_DeleteThis( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "KeyValues3_Create")]
        public static void* KeyValues3_Create()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "KeyValues3_IsArray")]
        public static int KeyValues3_IsArray( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "KeyValues3_IsTable")]
        public static int KeyValues3_IsTable( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "KeyValues3_GetType")]
        public static long KeyValues3_GetType( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "KeyValues3_GetValueBool")]
        public static int KeyValues3_GetValueBool( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "KeyValues3_GetValueInt")]
        public static int KeyValues3_GetValueInt( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "KeyValues3_GetValueInt64")]
        public static long KeyValues3_GetValueInt64( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "KeyValues3_GetValueUint64")]
        public static ulong KeyValues3_GetValueUint64( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "KeyValues3_GetValueFloat")]
        public static float KeyValues3_GetValueFloat( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "KeyValues3_GetValueDouble")]
        public static double KeyValues3_GetValueDouble( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "KeyValues3_GetValueString")]
        public static void* KeyValues3_GetValueString( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "KeyValues3_GetValueVector")]
        public static void* KeyValues3_GetValueVector( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "KeyValues3_GetValueColor")]
        public static void* KeyValues3_GetValueColor( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "KeyValues3_SetValueBool")]
        public static void* KeyValues3_SetValueBool( void* self, int o )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "KeyValues3_SetValueString")]
        public static void* KeyValues3_SetValueString( void* self, void* o )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "KeyValues3_SetValueResourceString")]
        public static void* KeyValues3_SetValueResourceString( void* self, void* o )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "KeyValues3_SetValueInt")]
        public static void* KeyValues3_SetValueInt( void* self, int o )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "KeyValues3_SetValueFloat")]
        public static void* KeyValues3_SetValueFloat( void* self, float o )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "KeyValues3_SetMemberString")]
        public static void* KeyValues3_SetMemberString( void* self, void* key, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "KeyValues3_SetMemberInt")]
        public static void* KeyValues3_SetMemberInt( void* self, void* key, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "KeyValues3_SetMemberFloat")]
        public static void* KeyValues3_SetMemberFloat( void* self, void* key, float value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "KeyValues3_GetMemberString")]
        public static void* KeyValues3_GetMemberString( void* self, void* key )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "KeyValues3_GetMemberInt")]
        public static int KeyValues3_GetMemberInt( void* self, void* key, int defaultValue )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "KeyValues3_GetMemberFloat")]
        public static float KeyValues3_GetMemberFloat( void* self, void* key, float defaultValue )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "KeyValues3_GetMemberVector")]
        public static void* KeyValues3_GetMemberVector( void* self, void* key, void* defaultValue )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "KeyValues3_SetToEmptyArray")]
        public static void* KeyValues3_SetToEmptyArray( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "KeyValues3_GetArrayLength")]
        public static int KeyValues3_GetArrayLength( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "KeyValues3_ArrayAddToTail")]
        public static void* KeyValues3_ArrayAddToTail( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "KeyValues3_GetArrayElement")]
        public static void* KeyValues3_GetArrayElement( void* self, int i )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "KeyValues3_FindOrCreateMember")]
        public static void* KeyValues3_FindOrCreateMember( void* self, void* name )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "KeyValues3_SetToEmptyTable")]
        public static void* KeyValues3_SetToEmptyTable( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "KeyValues3_GetMemberCount")]
        public static int KeyValues3_GetMemberCount( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "KeyValues3_GetMember")]
        public static void* KeyValues3_GetMember( void* self, int idx )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "KeyValues3_GetMemberName")]
        public static void* KeyValues3_GetMemberName( void* self, int idx )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "MeshGlue_CreateRenderMesh")]
        public static void* MeshGlue_CreateRenderMesh( void* material, int nPrimType, void* pName )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "MeshGlue_CreateModel")]
        public static void* MeshGlue_CreateModel( void* anim, void* pBodies, void* pMaterialGroups, float mass, void* surfaceProp, void* lodSwitchDistance, void* meshes, int numMeshes, void* lodMasks, void* meshGroupMasks, void* meshGroups, int numMeshGroups, void* vertices, int numVertices, void* indices, int numIndices, void* spheres, int numSpheres, void* capsules, int numCapsules, void* boxes, int numBoxes, void* hulls, int numHulls, void* meshShapes, int numMeshShapes, void* bones, int numBones, void* boneNames, int startTraceVertex, int startTraceIndex, int numTraceVertices, int numTraceIndices, ulong _defaultMeshGroupMask )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "MeshGlue_GetModelNumVertices")]
        public static int MeshGlue_GetModelNumVertices( void* model )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "MeshGlue_GetModelVertices")]
        public static void* MeshGlue_GetModelVertices( void* model, void* vertices, uint numVertices )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "MeshGlue_GetModelNumIndices")]
        public static int MeshGlue_GetModelNumIndices( void* model )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "MeshGlue_GetModelIndices")]
        public static void* MeshGlue_GetModelIndices( void* model, void* indices, uint numIndices )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "MeshGlue_GetModelIndexCount")]
        public static int MeshGlue_GetModelIndexCount( void* model, int drawCall )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "MeshGlue_GetModelIndexStart")]
        public static int MeshGlue_GetModelIndexStart( void* model, int drawCall )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "MeshGlue_GetModelBaseVertex")]
        public static int MeshGlue_GetModelBaseVertex( void* model, int drawCall )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "MeshGlue_SetMeshMaterial")]
        public static void* MeshGlue_SetMeshMaterial( void* renderMesh, void* material )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "MeshGlue_SetMeshPrimType")]
        public static void* MeshGlue_SetMeshPrimType( void* renderMesh, int nPrimType )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "MeshGlue_SetMeshBounds")]
        public static void* MeshGlue_SetMeshBounds( void* renderMesh, void* mins, void* maxs )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "MeshGlue_SetMeshUvDensity")]
        public static void* MeshGlue_SetMeshUvDensity( void* renderMesh, float flDensity )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "MeshGlue_SetMeshVertexRange")]
        public static void* MeshGlue_SetMeshVertexRange( void* renderMesh, int startVertex, int vertexCount )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "MeshGlue_SetMeshIndexRange")]
        public static void* MeshGlue_SetMeshIndexRange( void* renderMesh, int startIndex, int indexCount )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "MeshGlue_SetMeshVertexBuffer")]
        public static void* MeshGlue_SetMeshVertexBuffer( void* renderMesh, void* hVB, void* pData, int nDataSize )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "MeshGlue_SetMeshIndexBuffer")]
        public static void* MeshGlue_SetMeshIndexBuffer( void* renderMesh, void* hIB, void* pData, int nDataSize )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "MeshGlue_CreateVertexBuffer")]
        public static void* MeshGlue_CreateVertexBuffer( int nElementSizeInBytes, int nElementCount, void* fieldNames, void* pFields, int nFields, void* pData, int nDataSize )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "MeshGlue_CreateIndexBuffer")]
        public static void* MeshGlue_CreateIndexBuffer( int nElementCount, int b32Bit, void* pData, int nDataSize )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "MeshGlue_LockVertexBuffer")]
        public static void* MeshGlue_LockVertexBuffer( void* hVB, int nDataSize, int nDataOffset )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "MeshGlue_UnlockVertexBuffer")]
        public static void* MeshGlue_UnlockVertexBuffer( void* hVB, void* pData, int nDataSize, int nDataOffset )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "MeshGlue_LockIndexBuffer")]
        public static void* MeshGlue_LockIndexBuffer( void* hIB, int nDataSize, int nDataOffset )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "MeshGlue_UnlockIndexBuffer")]
        public static void* MeshGlue_UnlockIndexBuffer( void* hIB, void* pData, int nDataSize, int nDataOffset )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "MeshGlue_SetVertexBufferData")]
        public static void* MeshGlue_SetVertexBufferData( void* hVB, void* pData, int nDataSize, int nDataOffset )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "MeshGlue_SetIndexBufferData")]
        public static void* MeshGlue_SetIndexBufferData( void* hIB, void* pData, int nDataSize, int nDataOffset )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "MeshGlue_SetVertexBufferSize")]
        public static void* MeshGlue_SetVertexBufferSize( void* hVB, int nDataSize )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "MeshGlue_SetIndexBufferSize")]
        public static void* MeshGlue_SetIndexBufferSize( void* hIB, int nDataSize )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "MeshGlue_TriangulatePolygon")]
        public static int MeshGlue_TriangulatePolygon( void* pPolygonVerts, int nNumVerts, void* pOutIndexList, int nMaxIndices )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "MeshGlue_ClipPolygonLineSegment")]
        public static void* MeshGlue_ClipPolygonLineSegment( void* pPolygonVerts, int nNumVerts, void* vA, void* vB, void* pOutSegmentPointsInside )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "NativeEngine_SDLGmCntrllr_GetAxis")]
        public static int NativeEngine_SDLGmCntrllr_GetAxis( int joystickId, long axis )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "NativeEngine_SDLGmCntrllr_GetControllerType")]
        public static long NativeEngine_SDLGmCntrllr_GetControllerType( int joystickId )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "NativeEngine_SDLGmCntrllr_Close")]
        public static int NativeEngine_SDLGmCntrllr_Close( int joystickId )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "NativeEngine_SDLGmCntrllr_SetLEDColor")]
        public static int NativeEngine_SDLGmCntrllr_SetLEDColor( int joystickId, int red, int green, int blue )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "NativeEngine_SDLGmCntrllr_Rumble")]
        public static int NativeEngine_SDLGmCntrllr_Rumble( int joystickId, int lowFreq, int highFreq, int duration )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "NativeEngine_SDLGmCntrllr_RumbleTriggers")]
        public static int NativeEngine_SDLGmCntrllr_RumbleTriggers( int joystickId, int lowFreq, int highFreq, int duration )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "NativeEngine_SDLGmCntrllr_GetGyroscope")]
        public static void* NativeEngine_SDLGmCntrllr_GetGyroscope( int joystickId )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "NativeEngine_SDLGmCntrllr_GetAccelerometer")]
        public static void* NativeEngine_SDLGmCntrllr_GetAccelerometer( int joystickId )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "NativeLowLevel_Copy", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* NativeLowLevel_Copy( void* dest, void* src, long count )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "PerformanceTrace_BeginEvent", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* PerformanceTrace_BeginEvent( void* name, void* data, uint color )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "PerformanceTrace_EndEvent", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* PerformanceTrace_EndEvent()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "PhysicsTrace_Trace")]
        public static void* PhysicsTrace_Trace( void* request )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "PhysicsTrace_TraceAll")]
        public static void* PhysicsTrace_TraceAll( void* request, void* results )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "PhysicsTrace_TraceAgainstCapsule")]
        public static void* PhysicsTrace_TraceAgainstCapsule( void* request, void* capsule, void* tx )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "PhysicsTrace_TraceAgainstBBox")]
        public static void* PhysicsTrace_TraceAgainstBBox( void* request, void* box, void* tx )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "PhysicsTrace_TraceAgainstSphere")]
        public static void* PhysicsTrace_TraceAgainstSphere( void* request, void* sphere, void* tx )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "RenderTools_SetRenderState")]
        public static int RenderTools_SetRenderState( void* context, void* attributes, void* materialMode, void* layout, void* stats )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "RenderTools_Draw")]
        public static void* RenderTools_Draw( void* context, long type, void* layout, void* vertices, int numVertices, void* indices, int numIndices, void* stats )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "RenderTools_ResolveFrameBuffer")]
        public static void* RenderTools_ResolveFrameBuffer( void* renderContext, void* texture, void* viewport )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "RenderTools_ResolveDepthBuffer")]
        public static void* RenderTools_ResolveDepthBuffer( void* renderContext, void* texture, void* viewport )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "RenderTools_DrawSceneObject")]
        public static void* RenderTools_DrawSceneObject( void* renderContext, void* sceneLayer, void* sceneObject, void* transform, void* color, void* material, void* attributes )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "RenderTools_DrawModel")]
        public static void* RenderTools_DrawModel( void* renderContext, void* sceneLayer, void* hModel, void* transforms, int numTransforms, void* attributes )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "RenderTools_DrawModel_1")]
        public static void* RenderTools_DrawModel_1( void* renderContext, void* sceneLayer, void* hModel, void* hDrawArgBuffer, int nBufferOffset, void* attributes )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "RenderTools_Compute")]
        public static void* RenderTools_Compute( void* renderContext, void* attributes, void* pMode, int tx, int ty, int tz )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "RenderTools_ComputeIndirect")]
        public static void* RenderTools_ComputeIndirect( void* renderContext, void* attributes, void* pMode, void* hIndirectBuffer, uint nIndirectBufferOffset )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "RenderTools_TraceRays")]
        public static void* RenderTools_TraceRays( void* renderContext, void* attributes, void* pMode, uint tx, uint ty, uint tz )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "RenderTools_TraceRaysIndirect")]
        public static void* RenderTools_TraceRaysIndirect( void* renderContext, void* attributes, void* pMode, void* hIndirectBuffer, uint nIndirectBufferOffset )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "RenderTools_SetDynamicConstantBufferData")]
        public static void* RenderTools_SetDynamicConstantBufferData( void* attributes, void* nTokenID, void* renderContext, void* data, int dataSize )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "RenderTools_CopyTexture")]
        public static void* RenderTools_CopyTexture( void* renderContext, void* sourceTexture, void* destTexture, void* pSrcRect, int nDestX, int nDestY, uint nSrcMipSlice, uint nSrcArraySlice, uint nDstMipSlice, uint nDstArraySlice )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "RenderTools_SetGPUBufferData")]
        public static void* RenderTools_SetGPUBufferData( void* renderContext, void* hGpuBuffer, void* pData, uint nDataSize, uint nOffset )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "RenderTools_CopyGPUBufferHiddenStructureCount")]
        public static void* RenderTools_CopyGPUBufferHiddenStructureCount( void* renderContext, void* hSrcBuffer, void* hDestBuffer, uint nDestBufferOffset )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "RenderTools_SetGPUBufferHiddenStructureCount")]
        public static void* RenderTools_SetGPUBufferHiddenStructureCount( void* renderContext, void* hBuffer, uint nCounter )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__RnCapsuleDesc_t_m_Capsule", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Get__RnCapsuleDesc_t_m_Capsule( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__RnCapsuleDesc_t_m_Capsule", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__RnCapsuleDesc_t_m_Capsule( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__RnCapsuleDesc_t_m_nCollisionAttributeIndex", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__RnCapsuleDesc_t_m_nCollisionAttributeIndex( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__RnCapsuleDesc_t_m_nCollisionAttributeIndex", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__RnCapsuleDesc_t_m_nCollisionAttributeIndex( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__RnCapsuleDesc_t_m_nSurfacePropertyIndex", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__RnCapsuleDesc_t_m_nSurfacePropertyIndex( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__RnCapsuleDesc_t_m_nSurfacePropertyIndex", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__RnCapsuleDesc_t_m_nSurfacePropertyIndex( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "RnHull_t_GetVertexCount")]
        public static int RnHull_t_GetVertexCount( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "RnHull_t_GetEdgeCount")]
        public static int RnHull_t_GetEdgeCount( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "RnHull_t_GetVolume")]
        public static float RnHull_t_GetVolume( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "RnHull_t_GetMassCenter")]
        public static void* RnHull_t_GetMassCenter( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "RnHull_t_GetCentroid")]
        public static void* RnHull_t_GetCentroid( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "RnHull_t_GetSurfaceArea")]
        public static float RnHull_t_GetSurfaceArea( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "RnHull_t_GetMemory")]
        public static int RnHull_t_GetMemory( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "RnHull_t_GetBbox")]
        public static void* RnHull_t_GetBbox( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "RnHull_t_GetVertex")]
        public static void* RnHull_t_GetVertex( void* self, int nVertex )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "RnHull_t_GetEdgeVertex")]
        public static void* RnHull_t_GetEdgeVertex( void* self, int edge, void* a, void* b )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "RnHullDesc_t_GetHull")]
        public static void* RnHullDesc_t_GetHull( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__RnHullDesc_t_m_nCollisionAttributeIndex", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__RnHullDesc_t_m_nCollisionAttributeIndex( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__RnHullDesc_t_m_nCollisionAttributeIndex", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__RnHullDesc_t_m_nCollisionAttributeIndex( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__RnHullDesc_t_m_nSurfacePropertyIndex", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__RnHullDesc_t_m_nSurfacePropertyIndex( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__RnHullDesc_t_m_nSurfacePropertyIndex", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__RnHullDesc_t_m_nSurfacePropertyIndex( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "RnMesh_t_GetTriangleCount")]
        public static int RnMesh_t_GetTriangleCount( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "RnMesh_t_GetHeight")]
        public static int RnMesh_t_GetHeight( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "RnMesh_t_GetMemory")]
        public static int RnMesh_t_GetMemory( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "RnMesh_t_GetBbox")]
        public static void* RnMesh_t_GetBbox( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "RnMesh_t_GetMaterialCount")]
        public static int RnMesh_t_GetMaterialCount( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "RnMesh_t_GetTriangle")]
        public static void* RnMesh_t_GetTriangle( void* self, int triangle, void* a, void* b, void* c )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "RnMeshDesc_t_GetMesh")]
        public static void* RnMeshDesc_t_GetMesh( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__RnMeshDesc_t_m_nCollisionAttributeIndex", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__RnMeshDesc_t_m_nCollisionAttributeIndex( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__RnMeshDesc_t_m_nCollisionAttributeIndex", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__RnMeshDesc_t_m_nCollisionAttributeIndex( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__RnMeshDesc_t_m_nSurfacePropertyIndex", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__RnMeshDesc_t_m_nSurfacePropertyIndex( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__RnMeshDesc_t_m_nSurfacePropertyIndex", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__RnMeshDesc_t_m_nSurfacePropertyIndex( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__RnSphereDesc_t_m_Sphere", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Get__RnSphereDesc_t_m_Sphere( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__RnSphereDesc_t_m_Sphere", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__RnSphereDesc_t_m_Sphere( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__RnSphereDesc_t_m_nCollisionAttributeIndex", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__RnSphereDesc_t_m_nCollisionAttributeIndex( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__RnSphereDesc_t_m_nCollisionAttributeIndex", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__RnSphereDesc_t_m_nCollisionAttributeIndex( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__RnSphereDesc_t_m_nSurfacePropertyIndex", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__RnSphereDesc_t_m_nSurfacePropertyIndex( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__RnSphereDesc_t_m_nSurfacePropertyIndex", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__RnSphereDesc_t_m_nSurfacePropertyIndex( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nTrianglesRendered", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nTrianglesRendered( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nTrianglesRendered", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nTrianglesRendered( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nArtistTrianglesRendered", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nArtistTrianglesRendered( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nArtistTrianglesRendered", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nArtistTrianglesRendered( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nRenderBatchDraws", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nRenderBatchDraws( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nRenderBatchDraws", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nRenderBatchDraws( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nDrawCalls", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nDrawCalls( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nDrawCalls", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nDrawCalls( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nDrawPrimitives", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nDrawPrimitives( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nDrawPrimitives", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nDrawPrimitives( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nBaseSceneObjectPrimDraws", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nBaseSceneObjectPrimDraws( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nBaseSceneObjectPrimDraws", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nBaseSceneObjectPrimDraws( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nAnimatableObjectPrimDraws", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nAnimatableObjectPrimDraws( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nAnimatableObjectPrimDraws", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nAnimatableObjectPrimDraws( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nAggregateSceneObjectPrimDraws", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nAggregateSceneObjectPrimDraws( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nAggregateSceneObjectPrimDraws", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nAggregateSceneObjectPrimDraws( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nAggregateSceneObjectsFullyCulled", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nAggregateSceneObjectsFullyCulled( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nAggregateSceneObjectsFullyCulled", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nAggregateSceneObjectsFullyCulled( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nAggregateSceneObjectDrawCalls", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nAggregateSceneObjectDrawCalls( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nAggregateSceneObjectDrawCalls", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nAggregateSceneObjectDrawCalls( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nNumMaterialCompute", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nNumMaterialCompute( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nNumMaterialCompute", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nNumMaterialCompute( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nNumMaterialSet", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nNumMaterialSet( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nNumMaterialSet", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nNumMaterialSet( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nNumSimilarMaterialSet", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nNumSimilarMaterialSet( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nNumSimilarMaterialSet", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nNumSimilarMaterialSet( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nNumTextureOnlyMaterialSet", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nNumTextureOnlyMaterialSet( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nNumTextureOnlyMaterialSet", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nNumTextureOnlyMaterialSet( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nNumVfxEval", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nNumVfxEval( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nNumVfxEval", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nNumVfxEval( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nNumVfxRule", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nNumVfxRule( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nNumVfxRule", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nNumVfxRule( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nNumConstantBufferUpdates", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nNumConstantBufferUpdates( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nNumConstantBufferUpdates", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nNumConstantBufferUpdates( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nNumConstantBufferBytes", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nNumConstantBufferBytes( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nNumConstantBufferBytes", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nNumConstantBufferBytes( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nMaterialChangesNonShadow", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nMaterialChangesNonShadow( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nMaterialChangesNonShadow", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nMaterialChangesNonShadow( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nMaterialChangesNonShadowInitial", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nMaterialChangesNonShadowInitial( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nMaterialChangesNonShadowInitial", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nMaterialChangesNonShadowInitial( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nMaterialChangesShadow", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nMaterialChangesShadow( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nMaterialChangesShadow", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nMaterialChangesShadow( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nMaterialChangesShadowInitial", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nMaterialChangesShadowInitial( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nMaterialChangesShadowInitial", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nMaterialChangesShadowInitial( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nMaterialChangesShadowAlphaTested", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nMaterialChangesShadowAlphaTested( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nMaterialChangesShadowAlphaTested", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nMaterialChangesShadowAlphaTested( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nCopyMaterialChangesNonShadow", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nCopyMaterialChangesNonShadow( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nCopyMaterialChangesNonShadow", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nCopyMaterialChangesNonShadow( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nMaxTransformRow", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nMaxTransformRow( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nMaxTransformRow", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nMaxTransformRow( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nNumRowsUsed", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nNumRowsUsed( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nNumRowsUsed", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nNumRowsUsed( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nNumObjectsTested", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nNumObjectsTested( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nNumObjectsTested", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nNumObjectsTested( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nNumObjectsPreCullCheck", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nNumObjectsPreCullCheck( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nNumObjectsPreCullCheck", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nNumObjectsPreCullCheck( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nNumObjectsPassingCullCheck", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nNumObjectsPassingCullCheck( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nNumObjectsPassingCullCheck", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nNumObjectsPassingCullCheck( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nNumVerticesReferenced", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nNumVerticesReferenced( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nNumVerticesReferenced", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nNumVerticesReferenced( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nNumPrimaryContexts", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nNumPrimaryContexts( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nNumPrimaryContexts", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nNumPrimaryContexts( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nNumSecondaryContexts", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nNumSecondaryContexts( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nNumSecondaryContexts", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nNumSecondaryContexts( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nNumDisplayListsSubmitted", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nNumDisplayListsSubmitted( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nNumDisplayListsSubmitted", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nNumDisplayListsSubmitted( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nNumViewsRendered", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__ScnSystmPrFrmStt_m_nNumViewsRendered( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nNumViewsRendered", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nNumViewsRendered( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nNumResolves", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nNumResolves( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nNumResolves", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nNumResolves( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nNumCullBoxes", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nNumCullBoxes( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nNumCullBoxes", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nNumCullBoxes( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nCullingBoxCycleCount", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static ulong _Get__ScnSystmPrFrmStt_m_nCullingBoxCycleCount( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nCullingBoxCycleCount", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nCullingBoxCycleCount( void* self, ulong value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nNumObjectsTestedAgainstCullingBoxes", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nNumObjectsTestedAgainstCullingBoxes( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nNumObjectsTestedAgainstCullingBoxes", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nNumObjectsTestedAgainstCullingBoxes( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nNumObjectsRejectedByBoundsIndex", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nNumObjectsRejectedByBoundsIndex( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nNumObjectsRejectedByBoundsIndex", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nNumObjectsRejectedByBoundsIndex( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nNumObjectsRejectedByCullBoxes", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nNumObjectsRejectedByCullBoxes( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nNumObjectsRejectedByCullBoxes", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nNumObjectsRejectedByCullBoxes( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nNumObjectsRejectedByVis", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nNumObjectsRejectedByVis( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nNumObjectsRejectedByVis", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nNumObjectsRejectedByVis( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nNumObjectsRejectedByBackfaceCulling", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nNumObjectsRejectedByBackfaceCulling( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nNumObjectsRejectedByBackfaceCulling", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nNumObjectsRejectedByBackfaceCulling( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nNumObjectsRejectedByScreenSizeCulling", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nNumObjectsRejectedByScreenSizeCulling( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nNumObjectsRejectedByScreenSizeCulling", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nNumObjectsRejectedByScreenSizeCulling( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nNumObjectsRejectedByFading", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nNumObjectsRejectedByFading( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nNumObjectsRejectedByFading", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nNumObjectsRejectedByFading( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nNumFadingObjects", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nNumFadingObjects( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nNumFadingObjects", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nNumFadingObjects( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nNumUniqueMaterialsSeen", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nNumUniqueMaterialsSeen( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nNumUniqueMaterialsSeen", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nNumUniqueMaterialsSeen( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nNumUnshadowedLightsInView", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nNumUnshadowedLightsInView( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nNumUnshadowedLightsInView", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nNumUnshadowedLightsInView( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nNumShadowedLightsInView", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nNumShadowedLightsInView( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nNumShadowedLightsInView", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nNumShadowedLightsInView( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nNumShadowMaps", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nNumShadowMaps( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nNumShadowMaps", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nNumShadowMaps( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nNumRenderTargetBinds", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nNumRenderTargetBinds( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nNumRenderTargetBinds", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nNumRenderTargetBinds( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ScnSystmPrFrmStt_m_nPushConstantSets", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__ScnSystmPrFrmStt_m_nPushConstantSets( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ScnSystmPrFrmStt_m_nPushConstantSets", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ScnSystmPrFrmStt_m_nPushConstantSets( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ShaderTools_GetShaderSource")]
        public static void* ShaderTools_GetShaderSource( void* pShaderFile )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ShaderTools_MaskShaderSource")]
        public static void* ShaderTools_MaskShaderSource( void* sourcecode, long program, int bIsForCrc )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "SheetSequence_t_FrameCount")]
        public static int SheetSequence_t_FrameCount( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__SheetSequence_t_m_nId", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__SheetSequence_t_m_nId( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__SheetSequence_t_m_nId", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__SheetSequence_t_m_nId( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__SheetSequence_t_m_bClamp", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__SheetSequence_t_m_bClamp( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__SheetSequence_t_m_bClamp", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__SheetSequence_t_m_bClamp( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__SheetSequence_t_m_bAlphaCrop", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__SheetSequence_t_m_bAlphaCrop( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__SheetSequence_t_m_bAlphaCrop", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__SheetSequence_t_m_bAlphaCrop( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__SheetSequence_t_m_bNoColor", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__SheetSequence_t_m_bNoColor( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__SheetSequence_t_m_bNoColor", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__SheetSequence_t_m_bNoColor( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__SheetSequence_t_m_bNoAlpha", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__SheetSequence_t_m_bNoAlpha( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__SheetSequence_t_m_bNoAlpha", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__SheetSequence_t_m_bNoAlpha( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__SheetSequence_t_m_flTotalTime", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static float _Get__SheetSequence_t_m_flTotalTime( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__SheetSequence_t_m_flTotalTime", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__SheetSequence_t_m_flTotalTime( void* self, float value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ShtSqncFrm_t_ImageCount")]
        public static int ShtSqncFrm_t_ImageCount( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "ShtSqncFrm_t_GetImage")]
        public static void* ShtSqncFrm_t_GetImage( void* self, int i )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__ShtSqncFrm_t_m_flDisplayTime", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static float _Get__ShtSqncFrm_t_m_flDisplayTime( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__ShtSqncFrm_t_m_flDisplayTime", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__ShtSqncFrm_t_m_flDisplayTime( void* self, float value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Steam_Inventory_GetAllItems")]
        public static void* Steam_Inventory_GetAllItems()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Steam_Inventory_DefinitionCount")]
        public static int Steam_Inventory_DefinitionCount()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Steam_Inventory_GetDefinitionId")]
        public static int Steam_Inventory_GetDefinitionId( int index )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Steam_Inventory_GetDefinitionProperty")]
        public static void* Steam_Inventory_GetDefinitionProperty( int definitionId, void* propertyName )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Steam_Inventory_GetDefinitionPrice")]
        public static int Steam_Inventory_GetDefinitionPrice( int index, void* price, void* baseprice )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Steam_Inventory_HasPrices")]
        public static int Steam_Inventory_HasPrices()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Steam_Inventory_GetCurrency")]
        public static void* Steam_Inventory_GetCurrency()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Steam_Inventory_CheckOut")]
        public static void* Steam_Inventory_CheckOut( void* defs, int count )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Steam_Inventory_IsCheckingOut")]
        public static int Steam_Inventory_IsCheckingOut()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Steam_Inventory_WasCheckoutSuccessful")]
        public static int Steam_Inventory_WasCheckoutSuccessful()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "Steam_Screenshots_WriteScreenshot")]
        public static int Steam_Screenshots_WriteScreenshot( void* pubRGB, uint cubRGB, int nWidth, int nHeight )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "SteamUgc_CUgcInstall_Create")]
        public static void* SteamUgc_CUgcInstall_Create( ulong fileid )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "SteamUgc_CUgcInstall_Dispose")]
        public static void* SteamUgc_CUgcInstall_Dispose( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "SteamUgc_CUgcInstall_GetResultJson")]
        public static void* SteamUgc_CUgcInstall_GetResultJson( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__SteamUgc_CUgcInstall_m_complete", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__SteamUgc_CUgcInstall_m_complete( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__SteamUgc_CUgcInstall_m_complete", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__SteamUgc_CUgcInstall_m_complete( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__SteamUgc_CUgcInstall_m_success", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__SteamUgc_CUgcInstall_m_success( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__SteamUgc_CUgcInstall_m_success", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__SteamUgc_CUgcInstall_m_success( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__SteamUgc_CUgcInstall_m_resultCode", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__SteamUgc_CUgcInstall_m_resultCode( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__SteamUgc_CUgcInstall_m_resultCode", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__SteamUgc_CUgcInstall_m_resultCode( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "SteamUgc_CUgcQuery_CreateQuery")]
        public static void* SteamUgc_CUgcQuery_CreateQuery( void* json, void* cursor )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "SteamUgc_CUgcQuery_Dispose")]
        public static void* SteamUgc_CUgcQuery_Dispose( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "SteamUgc_CUgcQuery_GetResultJson")]
        public static void* SteamUgc_CUgcQuery_GetResultJson( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__SteamUgc_CUgcQuery_m_complete", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__SteamUgc_CUgcQuery_m_complete( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__SteamUgc_CUgcQuery_m_complete", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__SteamUgc_CUgcQuery_m_complete( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__SteamUgc_CUgcQuery_m_success", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__SteamUgc_CUgcQuery_m_success( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__SteamUgc_CUgcQuery_m_success", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__SteamUgc_CUgcQuery_m_success( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__SteamUgc_CUgcQuery_m_resultCode", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__SteamUgc_CUgcQuery_m_resultCode( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__SteamUgc_CUgcQuery_m_resultCode", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__SteamUgc_CUgcQuery_m_resultCode( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "SteamUgc_CUgcUpdate_CreateCommunityItem")]
        public static void* SteamUgc_CUgcUpdate_CreateCommunityItem()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "SteamUgc_CUgcUpdate_CreateMtxItem")]
        public static void* SteamUgc_CUgcUpdate_CreateMtxItem()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "SteamUgc_CUgcUpdate_OpenCommunityItem")]
        public static void* SteamUgc_CUgcUpdate_OpenCommunityItem( ulong itemid )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "SteamUgc_CUgcUpdate_Dispose")]
        public static void* SteamUgc_CUgcUpdate_Dispose( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "SteamUgc_CUgcUpdate_GetPublishedFileId")]
        public static ulong SteamUgc_CUgcUpdate_GetPublishedFileId( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "SteamUgc_CUgcUpdate_SetTitle")]
        public static void* SteamUgc_CUgcUpdate_SetTitle( void* self, void* title )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "SteamUgc_CUgcUpdate_SetDescription")]
        public static void* SteamUgc_CUgcUpdate_SetDescription( void* self, void* description )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "SteamUgc_CUgcUpdate_SetLanguage")]
        public static void* SteamUgc_CUgcUpdate_SetLanguage( void* self, void* language )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "SteamUgc_CUgcUpdate_SetMetadata")]
        public static void* SteamUgc_CUgcUpdate_SetMetadata( void* self, void* metadata )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "SteamUgc_CUgcUpdate_SetVisibility")]
        public static void* SteamUgc_CUgcUpdate_SetVisibility( void* self, int visibility )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "SteamUgc_CUgcUpdate_SetTag")]
        public static void* SteamUgc_CUgcUpdate_SetTag( void* self, void* tag )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "SteamUgc_CUgcUpdate_SetContentFolder")]
        public static void* SteamUgc_CUgcUpdate_SetContentFolder( void* self, void* contentFolder )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "SteamUgc_CUgcUpdate_SetPreviewImage")]
        public static void* SteamUgc_CUgcUpdate_SetPreviewImage( void* self, void* previewFile )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "SteamUgc_CUgcUpdate_SetAllowLegacyUpload")]
        public static void* SteamUgc_CUgcUpdate_SetAllowLegacyUpload( void* self, int allow )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "SteamUgc_CUgcUpdate_AddKeyValueTag")]
        public static void* SteamUgc_CUgcUpdate_AddKeyValueTag( void* self, void* key, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "SteamUgc_CUgcUpdate_RemoveKeyValueTags")]
        public static void* SteamUgc_CUgcUpdate_RemoveKeyValueTags( void* self, void* key )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "SteamUgc_CUgcUpdate_RemoveAllKeyValueTags")]
        public static void* SteamUgc_CUgcUpdate_RemoveAllKeyValueTags( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "SteamUgc_CUgcUpdate_AddPreviewFile")]
        public static void* SteamUgc_CUgcUpdate_AddPreviewFile( void* self, void* previewFile, int type )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "SteamUgc_CUgcUpdate_AddPreviewVideo")]
        public static void* SteamUgc_CUgcUpdate_AddPreviewVideo( void* self, void* videoId )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "SteamUgc_CUgcUpdate_UpdatePreviewFile")]
        public static void* SteamUgc_CUgcUpdate_UpdatePreviewFile( void* self, uint index, void* previewFile )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "SteamUgc_CUgcUpdate_UpdatePreviewVideo")]
        public static void* SteamUgc_CUgcUpdate_UpdatePreviewVideo( void* self, uint index, void* videoId )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "SteamUgc_CUgcUpdate_RemovePreview")]
        public static void* SteamUgc_CUgcUpdate_RemovePreview( void* self, uint index )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "SteamUgc_CUgcUpdate_SetRequiredGameVersions")]
        public static void* SteamUgc_CUgcUpdate_SetRequiredGameVersions( void* self, void* minVersion, void* maxVersion )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "SteamUgc_CUgcUpdate_Submit")]
        public static int SteamUgc_CUgcUpdate_Submit( void* self, void* changeNote )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "SteamUgc_CUgcUpdate_GetProgressPercent")]
        public static float SteamUgc_CUgcUpdate_GetProgressPercent( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "SteamUgc_CUgcUpdate_GetBytesProcessed")]
        public static ulong SteamUgc_CUgcUpdate_GetBytesProcessed( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "SteamUgc_CUgcUpdate_GetBytesTotal")]
        public static ulong SteamUgc_CUgcUpdate_GetBytesTotal( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__SteamUgc_CUgcUpdate_m_creating", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__SteamUgc_CUgcUpdate_m_creating( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__SteamUgc_CUgcUpdate_m_creating", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__SteamUgc_CUgcUpdate_m_creating( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__SteamUgc_CUgcUpdate_m_created", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__SteamUgc_CUgcUpdate_m_created( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__SteamUgc_CUgcUpdate_m_created", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__SteamUgc_CUgcUpdate_m_created( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__SteamUgc_CUgcUpdate_m_submitted", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__SteamUgc_CUgcUpdate_m_submitted( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__SteamUgc_CUgcUpdate_m_submitted", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__SteamUgc_CUgcUpdate_m_submitted( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__SteamUgc_CUgcUpdate_m_complete", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__SteamUgc_CUgcUpdate_m_complete( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__SteamUgc_CUgcUpdate_m_complete", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__SteamUgc_CUgcUpdate_m_complete( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__SteamUgc_CUgcUpdate_m_success", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__SteamUgc_CUgcUpdate_m_success( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__SteamUgc_CUgcUpdate_m_success", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__SteamUgc_CUgcUpdate_m_success( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__SteamUgc_CUgcUpdate_m_bNeedsLegalAgreement", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__SteamUgc_CUgcUpdate_m_bNeedsLegalAgreement( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__SteamUgc_CUgcUpdate_m_bNeedsLegalAgreement", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__SteamUgc_CUgcUpdate_m_bNeedsLegalAgreement( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__SteamUgc_CUgcUpdate_m_resultCode", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__SteamUgc_CUgcUpdate_m_resultCode( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__SteamUgc_CUgcUpdate_m_resultCode", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__SteamUgc_CUgcUpdate_m_resultCode( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "VertexLayout_Create")]
        public static void* VertexLayout_Create( void* name, int size )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "VertexLayout_Destroy")]
        public static void* VertexLayout_Destroy( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "VertexLayout_Free")]
        public static void* VertexLayout_Free( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "VertexLayout_Add")]
        public static void* VertexLayout_Add( void* self, void* semanticName, int semanticIndex, uint format, int offset )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "VertexLayout_Build")]
        public static void* VertexLayout_Build( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "VfxCmpldShdrnf_t_Delete")]
        public static void* VfxCmpldShdrnf_t_Delete( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__VfxCmpldShdrnf_t_compilerOutput", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Get__VfxCmpldShdrnf_t_compilerOutput( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__VfxCmpldShdrnf_t_compilerOutput", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__VfxCmpldShdrnf_t_compilerOutput( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__VfxCmpldShdrnf_t_compileFailed", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__VfxCmpldShdrnf_t_compileFailed( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__VfxCmpldShdrnf_t_compileFailed", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__VfxCmpldShdrnf_t_compileFailed( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "VPhysXBodyPart_t_GetSphereCount")]
        public static int VPhysXBodyPart_t_GetSphereCount( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "VPhysXBodyPart_t_GetSphere")]
        public static void* VPhysXBodyPart_t_GetSphere( void* self, int index )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "VPhysXBodyPart_t_GetCapsuleCount")]
        public static int VPhysXBodyPart_t_GetCapsuleCount( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "VPhysXBodyPart_t_GetCapsule")]
        public static void* VPhysXBodyPart_t_GetCapsule( void* self, int index )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "VPhysXBodyPart_t_GetHullCount")]
        public static int VPhysXBodyPart_t_GetHullCount( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "VPhysXBodyPart_t_GetHull")]
        public static void* VPhysXBodyPart_t_GetHull( void* self, int index )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "VPhysXBodyPart_t_GetMeshCount")]
        public static int VPhysXBodyPart_t_GetMeshCount( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "VPhysXBodyPart_t_GetMesh")]
        public static void* VPhysXBodyPart_t_GetMesh( void* self, int index )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "VPhysXBodyPart_t_GetCollisionAttributeCount")]
        public static int VPhysXBodyPart_t_GetCollisionAttributeCount( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "VPhysXBodyPart_t_GetCollisionAttributeIndex")]
        public static ushort VPhysXBodyPart_t_GetCollisionAttributeIndex( void* self, int index )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__VPhysXBodyPart_t_m_nFlags", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static uint _Get__VPhysXBodyPart_t_m_nFlags( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__VPhysXBodyPart_t_m_nFlags", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__VPhysXBodyPart_t_m_nFlags( void* self, uint value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__VPhysXBodyPart_t_m_flMass", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static float _Get__VPhysXBodyPart_t_m_flMass( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__VPhysXBodyPart_t_m_flMass", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__VPhysXBodyPart_t_m_flMass( void* self, float value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__VPhysXBodyPart_t_m_nCollisionAttributeIndex", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static ushort _Get__VPhysXBodyPart_t_m_nCollisionAttributeIndex( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__VPhysXBodyPart_t_m_nCollisionAttributeIndex", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__VPhysXBodyPart_t_m_nCollisionAttributeIndex( void* self, ushort value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__VPhysXBodyPart_t_m_flInertiaScale", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static float _Get__VPhysXBodyPart_t_m_flInertiaScale( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__VPhysXBodyPart_t_m_flInertiaScale", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__VPhysXBodyPart_t_m_flInertiaScale( void* self, float value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__VPhysXBodyPart_t_m_flLinearDamping", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static float _Get__VPhysXBodyPart_t_m_flLinearDamping( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__VPhysXBodyPart_t_m_flLinearDamping", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__VPhysXBodyPart_t_m_flLinearDamping( void* self, float value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__VPhysXBodyPart_t_m_flAngularDamping", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static float _Get__VPhysXBodyPart_t_m_flAngularDamping( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__VPhysXBodyPart_t_m_flAngularDamping", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__VPhysXBodyPart_t_m_flAngularDamping( void* self, float value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__VPhysXBodyPart_t_m_bOverrideMassCenter", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__VPhysXBodyPart_t_m_bOverrideMassCenter( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__VPhysXBodyPart_t_m_bOverrideMassCenter", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__VPhysXBodyPart_t_m_bOverrideMassCenter( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__VPhysXBodyPart_t_m_vMassCenterOverride", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Get__VPhysXBodyPart_t_m_vMassCenterOverride( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__VPhysXBodyPart_t_m_vMassCenterOverride", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__VPhysXBodyPart_t_m_vMassCenterOverride( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "VPhysXJoint_t_GetLinearLimitMin")]
        public static float VPhysXJoint_t_GetLinearLimitMin( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "VPhysXJoint_t_GetLinearLimitMax")]
        public static float VPhysXJoint_t_GetLinearLimitMax( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "VPhysXJoint_t_GetSwingLimitMin")]
        public static float VPhysXJoint_t_GetSwingLimitMin( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "VPhysXJoint_t_GetSwingLimitMax")]
        public static float VPhysXJoint_t_GetSwingLimitMax( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "VPhysXJoint_t_GetTwistLimitMin")]
        public static float VPhysXJoint_t_GetTwistLimitMin( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "VPhysXJoint_t_GetTwistLimitMax")]
        public static float VPhysXJoint_t_GetTwistLimitMax( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "VPhysXJoint_t_SetLinearLimitMin")]
        public static void* VPhysXJoint_t_SetLinearLimitMin( void* self, float value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "VPhysXJoint_t_SetLinearLimitMax")]
        public static void* VPhysXJoint_t_SetLinearLimitMax( void* self, float value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "VPhysXJoint_t_SetSwingLimitMin")]
        public static void* VPhysXJoint_t_SetSwingLimitMin( void* self, float value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "VPhysXJoint_t_SetSwingLimitMax")]
        public static void* VPhysXJoint_t_SetSwingLimitMax( void* self, float value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "VPhysXJoint_t_SetTwistLimitMin")]
        public static void* VPhysXJoint_t_SetTwistLimitMin( void* self, float value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "VPhysXJoint_t_SetTwistLimitMax")]
        public static void* VPhysXJoint_t_SetTwistLimitMax( void* self, float value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__VPhysXJoint_t_m_nType", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static ushort _Get__VPhysXJoint_t_m_nType( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__VPhysXJoint_t_m_nType", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__VPhysXJoint_t_m_nType( void* self, ushort value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__VPhysXJoint_t_m_nBody1", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static ushort _Get__VPhysXJoint_t_m_nBody1( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__VPhysXJoint_t_m_nBody1", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__VPhysXJoint_t_m_nBody1( void* self, ushort value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__VPhysXJoint_t_m_nBody2", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static ushort _Get__VPhysXJoint_t_m_nBody2( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__VPhysXJoint_t_m_nBody2", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__VPhysXJoint_t_m_nBody2( void* self, ushort value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__VPhysXJoint_t_m_nFlags", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static ushort _Get__VPhysXJoint_t_m_nFlags( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__VPhysXJoint_t_m_nFlags", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__VPhysXJoint_t_m_nFlags( void* self, ushort value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__VPhysXJoint_t_m_bEnableCollision", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__VPhysXJoint_t_m_bEnableCollision( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__VPhysXJoint_t_m_bEnableCollision", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__VPhysXJoint_t_m_bEnableCollision( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__VPhysXJoint_t_m_bEnableLinearLimit", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__VPhysXJoint_t_m_bEnableLinearLimit( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__VPhysXJoint_t_m_bEnableLinearLimit", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__VPhysXJoint_t_m_bEnableLinearLimit( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__VPhysXJoint_t_m_bEnableLinearMotor", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__VPhysXJoint_t_m_bEnableLinearMotor( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__VPhysXJoint_t_m_bEnableLinearMotor", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__VPhysXJoint_t_m_bEnableLinearMotor( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__VPhysXJoint_t_m_vLinearTargetVelocity", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Get__VPhysXJoint_t_m_vLinearTargetVelocity( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__VPhysXJoint_t_m_vLinearTargetVelocity", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__VPhysXJoint_t_m_vLinearTargetVelocity( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__VPhysXJoint_t_m_flMaxForce", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static float _Get__VPhysXJoint_t_m_flMaxForce( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__VPhysXJoint_t_m_flMaxForce", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__VPhysXJoint_t_m_flMaxForce( void* self, float value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__VPhysXJoint_t_m_bEnableSwingLimit", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__VPhysXJoint_t_m_bEnableSwingLimit( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__VPhysXJoint_t_m_bEnableSwingLimit", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__VPhysXJoint_t_m_bEnableSwingLimit( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__VPhysXJoint_t_m_bEnableTwistLimit", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__VPhysXJoint_t_m_bEnableTwistLimit( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__VPhysXJoint_t_m_bEnableTwistLimit", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__VPhysXJoint_t_m_bEnableTwistLimit( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__VPhysXJoint_t_m_bEnableAngularMotor", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int _Get__VPhysXJoint_t_m_bEnableAngularMotor( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__VPhysXJoint_t_m_bEnableAngularMotor", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__VPhysXJoint_t_m_bEnableAngularMotor( void* self, int value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__VPhysXJoint_t_m_vAngularTargetVelocity", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Get__VPhysXJoint_t_m_vAngularTargetVelocity( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__VPhysXJoint_t_m_vAngularTargetVelocity", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__VPhysXJoint_t_m_vAngularTargetVelocity( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__VPhysXJoint_t_m_flMaxTorque", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static float _Get__VPhysXJoint_t_m_flMaxTorque( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__VPhysXJoint_t_m_flMaxTorque", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__VPhysXJoint_t_m_flMaxTorque( void* self, float value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__VPhysXJoint_t_m_flLinearFrequency", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static float _Get__VPhysXJoint_t_m_flLinearFrequency( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__VPhysXJoint_t_m_flLinearFrequency", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__VPhysXJoint_t_m_flLinearFrequency( void* self, float value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__VPhysXJoint_t_m_flLinearDampingRatio", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static float _Get__VPhysXJoint_t_m_flLinearDampingRatio( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__VPhysXJoint_t_m_flLinearDampingRatio", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__VPhysXJoint_t_m_flLinearDampingRatio( void* self, float value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__VPhysXJoint_t_m_flAngularFrequency", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static float _Get__VPhysXJoint_t_m_flAngularFrequency( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__VPhysXJoint_t_m_flAngularFrequency", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__VPhysXJoint_t_m_flAngularFrequency( void* self, float value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__VPhysXJoint_t_m_flAngularDampingRatio", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static float _Get__VPhysXJoint_t_m_flAngularDampingRatio( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__VPhysXJoint_t_m_flAngularDampingRatio", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__VPhysXJoint_t_m_flAngularDampingRatio( void* self, float value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__VPhysXJoint_t_m_flLinearStrength", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static float _Get__VPhysXJoint_t_m_flLinearStrength( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__VPhysXJoint_t_m_flLinearStrength", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__VPhysXJoint_t_m_flLinearStrength( void* self, float value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__VPhysXJoint_t_m_flAngularStrength", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static float _Get__VPhysXJoint_t_m_flAngularStrength( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__VPhysXJoint_t_m_flAngularStrength", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__VPhysXJoint_t_m_flAngularStrength( void* self, float value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__VPhysXJoint_t_m_Frame1", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Get__VPhysXJoint_t_m_Frame1( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__VPhysXJoint_t_m_Frame1", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__VPhysXJoint_t_m_Frame1( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Get__VPhysXJoint_t_m_Frame2", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Get__VPhysXJoint_t_m_Frame2( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "_Set__VPhysXJoint_t_m_Frame2", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* _Set__VPhysXJoint_t_m_Frame2( void* self, void* value )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "VSound_t_DestroyStrongHandle")]
        public static void* VSound_t_DestroyStrongHandle( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "VSound_t_IsStrongHandleValid", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int VSound_t_IsStrongHandleValid( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "VSound_t_IsError", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int VSound_t_IsError( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "VSound_t_IsStrongHandleLoaded", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static int VSound_t_IsStrongHandleLoaded( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "VSound_t_CopyStrongHandle", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* VSound_t_CopyStrongHandle( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "VSound_t_GetBindingPtr", CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
        public static void* VSound_t_GetBindingPtr( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "VSound_t_format")]
        public static long VSound_t_format( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "VSound_t_BitsPerSample")]
        public static int VSound_t_BitsPerSample( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "VSound_t_channels")]
        public static int VSound_t_channels( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "VSound_t_BytesPerSample")]
        public static int VSound_t_BytesPerSample( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "VSound_t_m_sampleFrameSize")]
        public static int VSound_t_m_sampleFrameSize( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "VSound_t_m_rate")]
        public static int VSound_t_m_rate( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "VSound_t_Duration")]
        public static float VSound_t_Duration( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "WindowsGlue_FindFile")]
        public static void* WindowsGlue_FindFile()
        {
            return default;
        }
    }
    public static unsafe partial class Imports
    {
        public static delegate* unmanaged<void*, void*, long, void*, void*, void*, void*, void*> _ptr_Sandbox_AsyncGPUReadback_DispatchManagedReadTextureCallback;
        public static delegate* unmanaged<void*, void*, void*, void*> _ptr_Sandbox_AsyncGPUReadback_DispatchManagedReadBufferCallback;
        public static delegate* unmanaged<void*> _ptr_SandboxAudio_MixingThread_MixOneBuffer;
        public static delegate* unmanaged<void*, void*> _ptr_Sandbox_ConVarSystem_RegisterNativeVar;
        public static delegate* unmanaged<void*, void*> _ptr_Sandbox_ConVarSystem_RegisterNativeCommand;
        public static delegate* unmanaged<void*, void*, void*, void*> _ptr_Sandbox_ConVarSystem_OnConVarChanged;
        public static delegate* unmanaged<void*, void*, void*> _ptr_SndbxDgnstcs_Logging_RegisterEngineLogger;
        public static delegate* unmanaged<void*, void*> _ptr_SandboxEngine_Bootstrap_EnvironmentExit;
        public static delegate* unmanaged<float, float, void*> _ptr_SandboxEngine_InputRouter_OnMouseMotion;
        public static delegate* unmanaged<float, float, float, float, void*> _ptr_SandboxEngine_InputRouter_OnMousePositionChange;
        public static delegate* unmanaged<long, void*, void*, void*> _ptr_SandboxEngine_InputRouter_OnMouseButton;
        public static delegate* unmanaged<long, void*, void*, void*, void*, void*> _ptr_SandboxEngine_InputRouter_OnKey;
        public static delegate* unmanaged<void*, void*> _ptr_SandboxEngine_InputRouter_OnText;
        public static delegate* unmanaged<void*, void*> _ptr_SandboxEngine_InputRouter_OnWindowActive;
        public static delegate* unmanaged<void*, void*, void*, void*> _ptr_SandboxEngine_InputRouter_OnMouseWheel;
        public static delegate* unmanaged<void*> _ptr_SandboxEngine_InputRouter_OnImeStart;
        public static delegate* unmanaged<void*, void*, void*> _ptr_SandboxEngine_InputRouter_OnImeComposition;
        public static delegate* unmanaged<void*> _ptr_SandboxEngine_InputRouter_OnImeEnd;
        public static delegate* unmanaged<void*, long, void*, void*> _ptr_SandboxEngine_InputRouter_OnGameControllerButton;
        public static delegate* unmanaged<void*, long, void*, void*> _ptr_SandboxEngine_InputRouter_OnGameControllerAxis;
        public static delegate* unmanaged<void*, void*, void*> _ptr_SandboxEngine_InputRouter_OnGameControllerConnected;
        public static delegate* unmanaged<void*, void*> _ptr_SandboxEngine_InputRouter_OnGameControllerDisconnected;
        public static delegate* unmanaged<void*, void*> _ptr_SandboxEngine_InputRouter_OnConsoleCommand;
        public static delegate* unmanaged<void*> _ptr_SandboxEngine_InputRouter_CloseApplication;
        public static delegate* unmanaged<void*, void*, ulong, ulong, void*> _ptr_SandboxEngine_SystemInfo_Set;
        public static delegate* unmanaged<void*, void*, ulong, void*> _ptr_SandboxEngine_SystemInfo_SetGpu;
        public static delegate* unmanaged<void*, void*, void*, void*> _ptr_Sandbox_EngineLoop_Print;
        public static delegate* unmanaged<void*, void*, long, void*> _ptr_Sandbox_EngineLoop_DispatchConsoleCommand;
        public static delegate* unmanaged<void*> _ptr_Sandbox_EngineLoop_OnClientOutput;
        public static delegate* unmanaged<void*, void*> _ptr_Sandbox_EngineLoop_OnSceneViewSubmitted;
        public static delegate* unmanaged<void*, void*, void*> _ptr_Sandbox_Graphics_OnLayer;
        public static delegate* unmanaged<void*, void*, void*> _ptr_Sandbox_HandleIndex_RegisterHandle;
        public static delegate* unmanaged<void*, void*> _ptr_Sandbox_HandleIndex_FreeHandle;
        public static delegate* unmanaged<ulong, ulong, void*> _ptr_Sandbox_LobbyManager_OnLobbyInvite;
        public static delegate* unmanaged<ulong, ulong, void*> _ptr_Sandbox_LobbyManager_OnMemberEntered;
        public static delegate* unmanaged<ulong, ulong, void*> _ptr_Sandbox_LobbyManager_OnMemberLeave;
        public static delegate* unmanaged<ulong, void*> _ptr_Sandbox_LobbyManager_OnEntered;
        public static delegate* unmanaged<ulong, void*> _ptr_Sandbox_LobbyManager_OnCreated;
        public static delegate* unmanaged<ulong, ulong, void*> _ptr_Sandbox_LobbyManager_OnDataUpdate;
        public static delegate* unmanaged<ulong, ulong, void*, void*, void*> _ptr_Sandbox_LobbyManager_OnChatMessage;
        public static delegate* unmanaged<void*, void*, void*> _ptr_SandboxNetwork_SteamNetwork_OnSocketConnection;
        public static delegate* unmanaged<void*, void*, void*> _ptr_SandboxNetwork_SteamNetwork_OnSocketDisconnection;
        public static delegate* unmanaged<void*, void*, void*> _ptr_SandboxNetwork_SteamNetwork_ShouldAcceptConnection;
        public static delegate* unmanaged<void*, void*, void*, void*> _ptr_SandboxNetwork_SteamNetwork_OnDisconnection;
        public static delegate* unmanaged<ulong, void*> _ptr_SandboxNetwork_SteamNetwork_OnSessionEstablished;
        public static delegate* unmanaged<void*, ulong, void*> _ptr_SandboxNetwork_SteamNetwork_OnSessionFailed;
        public static delegate* unmanaged<void*, void*> _ptr_SandboxPhysics_PhysicsEngine_OnPhysicsJointBreak;
        public static delegate* unmanaged<void*, void*, void*, void*, void*> _ptr_SandboxPhysics_PhysicsEngine_OnActive;
        public static delegate* unmanaged<float, void*> _ptr_Sandbox_RealTime_Update;
        public static delegate* unmanaged<void*, void*, void*, void*, long, void*, void*, void*> _ptr_SndbxRndrng_RenderPipeline_InternalAddLayersToView;
        public static delegate* unmanaged<void*, void*, void*, void*, long, void*, void*, void*> _ptr_SndbxRndrng_RenderPipeline_InternalPipelineEnd;
        public static delegate* unmanaged<void*> _ptr_Sandbox_RenderTarget_Flush;
        public static delegate* unmanaged<void*, void*, void*> _ptr_Sandbox_Resource_OnResourceReloaded;
        public static delegate* unmanaged<void*, void*, void*> _ptr_Sandbox_ScnCstmbjctRndr_RenderObject;
        public static delegate* unmanaged<void*, void*, void*> _ptr_Sandbox_SceneSystem_OnBeforeRender;
        public static delegate* unmanaged<void*, void*, void*> _ptr_Sandbox_SceneSystem_OnAfterRender;
        public static delegate* unmanaged<void*> _ptr_SndbxSrvcs_Inventory_OnDefinitionUpdate;
        public static delegate* unmanaged<void*, void*, void*> _ptr_SndbxSrvcs_Inventory_OnPricesUpdate;
        public static delegate* unmanaged<void*, ulong, ulong, void*> _ptr_SndbxSrvcs_Inventory_OnPurchaseResult;
        public static delegate* unmanaged<void*, void*> _ptr_SndbxSrvcs_ServerList_OnStarted;
        public static delegate* unmanaged<void*, void*, ulong, void*> _ptr_SndbxSrvcs_ServerList_OnServerResponded;
        public static delegate* unmanaged<void*, void*> _ptr_SndbxSrvcs_ServerList_OnFinished;
        public static delegate* unmanaged<void*, void*> _ptr_Sandbox_VideoPlayer_OnTextureCreatedInternal;
        public static delegate* unmanaged<void*, void*, void*, void*> _ptr_Sandbox_VideoPlayer_OnInitAudioInternal;
        public static delegate* unmanaged<void*, void*> _ptr_Sandbox_VideoPlayer_OnFreeAudioInternal;
        public static delegate* unmanaged<void*, void*, void*, void*, void*> _ptr_Sandbox_VideoPlayer_OnTextureDataInternal;
        public static delegate* unmanaged<void*, void*> _ptr_Sandbox_VideoPlayer_OnLoadedInternal;
        public static delegate* unmanaged<void*, void*> _ptr_Sandbox_VideoPlayer_WantsTextureData;
        public static delegate* unmanaged<void*, void*> _ptr_Sandbox_VideoPlayer_OnFinishedInternal;
        public static delegate* unmanaged<void*, void*> _ptr_Sandbox_VideoPlayer_OnRepeatedInternal;
        public static delegate* unmanaged<void*> _ptr_SandboxVR_VRSystem_InternalIsActive;
        public static delegate* unmanaged<void*> _ptr_SandboxVR_VRSystem_InternalWantsInit;
        public static delegate* unmanaged<void*> _ptr_SandboxVR_VRSystem_BeginFrame;
        public static delegate* unmanaged<void*> _ptr_SandboxVR_VRSystem_EndFrame;
        public static delegate* unmanaged<void*, void*, void*> _ptr_SandboxVR_VRSystem_Submit;
        public static delegate* unmanaged<void*> _ptr_SandboxVR_VRSystem_GetVulkanInstanceExtensionsRequired;
        public static delegate* unmanaged<void*> _ptr_SandboxVR_VRSystem_GetVulkanDeviceExtensionsRequired;
        public static delegate* unmanaged<void*> _ptr_SandboxVR_VRSystem_RenderOverlays;
        public static delegate* unmanaged<void*, void*, void*, void*, void*> _ptr_Steamworks_Dispatch_OnClientCallback;
        public static void StoreImport_Sandbox_AsyncGPUReadback_DispatchManagedReadTextureCallback(void* ptr)
        {
            _ptr_Sandbox_AsyncGPUReadback_DispatchManagedReadTextureCallback = (delegate* unmanaged<void*, void*, long, void*, void*, void*, void*, void*>)ptr;
        }
        public static void StoreImport_Sandbox_AsyncGPUReadback_DispatchManagedReadBufferCallback(void* ptr)
        {
            _ptr_Sandbox_AsyncGPUReadback_DispatchManagedReadBufferCallback = (delegate* unmanaged<void*, void*, void*, void*>)ptr;
        }
        public static void StoreImport_SandboxAudio_MixingThread_MixOneBuffer(void* ptr)
        {
            _ptr_SandboxAudio_MixingThread_MixOneBuffer = (delegate* unmanaged<void*>)ptr;
        }
        public static void StoreImport_Sandbox_ConVarSystem_RegisterNativeVar(void* ptr)
        {
            _ptr_Sandbox_ConVarSystem_RegisterNativeVar = (delegate* unmanaged<void*, void*>)ptr;
        }
        public static void StoreImport_Sandbox_ConVarSystem_RegisterNativeCommand(void* ptr)
        {
            _ptr_Sandbox_ConVarSystem_RegisterNativeCommand = (delegate* unmanaged<void*, void*>)ptr;
        }
        public static void StoreImport_Sandbox_ConVarSystem_OnConVarChanged(void* ptr)
        {
            _ptr_Sandbox_ConVarSystem_OnConVarChanged = (delegate* unmanaged<void*, void*, void*, void*>)ptr;
        }
        public static void StoreImport_SndbxDgnstcs_Logging_RegisterEngineLogger(void* ptr)
        {
            _ptr_SndbxDgnstcs_Logging_RegisterEngineLogger = (delegate* unmanaged<void*, void*, void*>)ptr;
        }
        public static void StoreImport_SandboxEngine_Bootstrap_EnvironmentExit(void* ptr)
        {
            _ptr_SandboxEngine_Bootstrap_EnvironmentExit = (delegate* unmanaged<void*, void*>)ptr;
        }
        public static void StoreImport_SandboxEngine_InputRouter_OnMouseMotion(void* ptr)
        {
            _ptr_SandboxEngine_InputRouter_OnMouseMotion = (delegate* unmanaged<float, float, void*>)ptr;
        }
        public static void StoreImport_SandboxEngine_InputRouter_OnMousePositionChange(void* ptr)
        {
            _ptr_SandboxEngine_InputRouter_OnMousePositionChange = (delegate* unmanaged<float, float, float, float, void*>)ptr;
        }
        public static void StoreImport_SandboxEngine_InputRouter_OnMouseButton(void* ptr)
        {
            _ptr_SandboxEngine_InputRouter_OnMouseButton = (delegate* unmanaged<long, void*, void*, void*>)ptr;
        }
        public static void StoreImport_SandboxEngine_InputRouter_OnKey(void* ptr)
        {
            _ptr_SandboxEngine_InputRouter_OnKey = (delegate* unmanaged<long, void*, void*, void*, void*, void*>)ptr;
        }
        public static void StoreImport_SandboxEngine_InputRouter_OnText(void* ptr)
        {
            _ptr_SandboxEngine_InputRouter_OnText = (delegate* unmanaged<void*, void*>)ptr;
        }
        public static void StoreImport_SandboxEngine_InputRouter_OnWindowActive(void* ptr)
        {
            _ptr_SandboxEngine_InputRouter_OnWindowActive = (delegate* unmanaged<void*, void*>)ptr;
        }
        public static void StoreImport_SandboxEngine_InputRouter_OnMouseWheel(void* ptr)
        {
            _ptr_SandboxEngine_InputRouter_OnMouseWheel = (delegate* unmanaged<void*, void*, void*, void*>)ptr;
        }
        public static void StoreImport_SandboxEngine_InputRouter_OnImeStart(void* ptr)
        {
            _ptr_SandboxEngine_InputRouter_OnImeStart = (delegate* unmanaged<void*>)ptr;
        }
        public static void StoreImport_SandboxEngine_InputRouter_OnImeComposition(void* ptr)
        {
            _ptr_SandboxEngine_InputRouter_OnImeComposition = (delegate* unmanaged<void*, void*, void*>)ptr;
        }
        public static void StoreImport_SandboxEngine_InputRouter_OnImeEnd(void* ptr)
        {
            _ptr_SandboxEngine_InputRouter_OnImeEnd = (delegate* unmanaged<void*>)ptr;
        }
        public static void StoreImport_SandboxEngine_InputRouter_OnGameControllerButton(void* ptr)
        {
            _ptr_SandboxEngine_InputRouter_OnGameControllerButton = (delegate* unmanaged<void*, long, void*, void*>)ptr;
        }
        public static void StoreImport_SandboxEngine_InputRouter_OnGameControllerAxis(void* ptr)
        {
            _ptr_SandboxEngine_InputRouter_OnGameControllerAxis = (delegate* unmanaged<void*, long, void*, void*>)ptr;
        }
        public static void StoreImport_SandboxEngine_InputRouter_OnGameControllerConnected(void* ptr)
        {
            _ptr_SandboxEngine_InputRouter_OnGameControllerConnected = (delegate* unmanaged<void*, void*, void*>)ptr;
        }
        public static void StoreImport_SandboxEngine_InputRouter_OnGameControllerDisconnected(void* ptr)
        {
            _ptr_SandboxEngine_InputRouter_OnGameControllerDisconnected = (delegate* unmanaged<void*, void*>)ptr;
        }
        public static void StoreImport_SandboxEngine_InputRouter_OnConsoleCommand(void* ptr)
        {
            _ptr_SandboxEngine_InputRouter_OnConsoleCommand = (delegate* unmanaged<void*, void*>)ptr;
        }
        public static void StoreImport_SandboxEngine_InputRouter_CloseApplication(void* ptr)
        {
            _ptr_SandboxEngine_InputRouter_CloseApplication = (delegate* unmanaged<void*>)ptr;
        }
        public static void StoreImport_SandboxEngine_SystemInfo_Set(void* ptr)
        {
            _ptr_SandboxEngine_SystemInfo_Set = (delegate* unmanaged<void*, void*, ulong, ulong, void*>)ptr;
        }
        public static void StoreImport_SandboxEngine_SystemInfo_SetGpu(void* ptr)
        {
            _ptr_SandboxEngine_SystemInfo_SetGpu = (delegate* unmanaged<void*, void*, ulong, void*>)ptr;
        }
        public static void StoreImport_Sandbox_EngineLoop_Print(void* ptr)
        {
            _ptr_Sandbox_EngineLoop_Print = (delegate* unmanaged<void*, void*, void*, void*>)ptr;
        }
        public static void StoreImport_Sandbox_EngineLoop_DispatchConsoleCommand(void* ptr)
        {
            _ptr_Sandbox_EngineLoop_DispatchConsoleCommand = (delegate* unmanaged<void*, void*, long, void*>)ptr;
        }
        public static void StoreImport_Sandbox_EngineLoop_OnClientOutput(void* ptr)
        {
            _ptr_Sandbox_EngineLoop_OnClientOutput = (delegate* unmanaged<void*>)ptr;
        }
        public static void StoreImport_Sandbox_EngineLoop_OnSceneViewSubmitted(void* ptr)
        {
            _ptr_Sandbox_EngineLoop_OnSceneViewSubmitted = (delegate* unmanaged<void*, void*>)ptr;
        }
        public static void StoreImport_Sandbox_Graphics_OnLayer(void* ptr)
        {
            _ptr_Sandbox_Graphics_OnLayer = (delegate* unmanaged<void*, void*, void*>)ptr;
        }
        public static void StoreImport_Sandbox_HandleIndex_RegisterHandle(void* ptr)
        {
            _ptr_Sandbox_HandleIndex_RegisterHandle = (delegate* unmanaged<void*, void*, void*>)ptr;
        }
        public static void StoreImport_Sandbox_HandleIndex_FreeHandle(void* ptr)
        {
            _ptr_Sandbox_HandleIndex_FreeHandle = (delegate* unmanaged<void*, void*>)ptr;
        }
        public static void StoreImport_Sandbox_LobbyManager_OnLobbyInvite(void* ptr)
        {
            _ptr_Sandbox_LobbyManager_OnLobbyInvite = (delegate* unmanaged<ulong, ulong, void*>)ptr;
        }
        public static void StoreImport_Sandbox_LobbyManager_OnMemberEntered(void* ptr)
        {
            _ptr_Sandbox_LobbyManager_OnMemberEntered = (delegate* unmanaged<ulong, ulong, void*>)ptr;
        }
        public static void StoreImport_Sandbox_LobbyManager_OnMemberLeave(void* ptr)
        {
            _ptr_Sandbox_LobbyManager_OnMemberLeave = (delegate* unmanaged<ulong, ulong, void*>)ptr;
        }
        public static void StoreImport_Sandbox_LobbyManager_OnEntered(void* ptr)
        {
            _ptr_Sandbox_LobbyManager_OnEntered = (delegate* unmanaged<ulong, void*>)ptr;
        }
        public static void StoreImport_Sandbox_LobbyManager_OnCreated(void* ptr)
        {
            _ptr_Sandbox_LobbyManager_OnCreated = (delegate* unmanaged<ulong, void*>)ptr;
        }
        public static void StoreImport_Sandbox_LobbyManager_OnDataUpdate(void* ptr)
        {
            _ptr_Sandbox_LobbyManager_OnDataUpdate = (delegate* unmanaged<ulong, ulong, void*>)ptr;
        }
        public static void StoreImport_Sandbox_LobbyManager_OnChatMessage(void* ptr)
        {
            _ptr_Sandbox_LobbyManager_OnChatMessage = (delegate* unmanaged<ulong, ulong, void*, void*, void*>)ptr;
        }
        public static void StoreImport_SandboxNetwork_SteamNetwork_OnSocketConnection(void* ptr)
        {
            _ptr_SandboxNetwork_SteamNetwork_OnSocketConnection = (delegate* unmanaged<void*, void*, void*>)ptr;
        }
        public static void StoreImport_SandboxNetwork_SteamNetwork_OnSocketDisconnection(void* ptr)
        {
            _ptr_SandboxNetwork_SteamNetwork_OnSocketDisconnection = (delegate* unmanaged<void*, void*, void*>)ptr;
        }
        public static void StoreImport_SandboxNetwork_SteamNetwork_ShouldAcceptConnection(void* ptr)
        {
            _ptr_SandboxNetwork_SteamNetwork_ShouldAcceptConnection = (delegate* unmanaged<void*, void*, void*>)ptr;
        }
        public static void StoreImport_SandboxNetwork_SteamNetwork_OnDisconnection(void* ptr)
        {
            _ptr_SandboxNetwork_SteamNetwork_OnDisconnection = (delegate* unmanaged<void*, void*, void*, void*>)ptr;
        }
        public static void StoreImport_SandboxNetwork_SteamNetwork_OnSessionEstablished(void* ptr)
        {
            _ptr_SandboxNetwork_SteamNetwork_OnSessionEstablished = (delegate* unmanaged<ulong, void*>)ptr;
        }
        public static void StoreImport_SandboxNetwork_SteamNetwork_OnSessionFailed(void* ptr)
        {
            _ptr_SandboxNetwork_SteamNetwork_OnSessionFailed = (delegate* unmanaged<void*, ulong, void*>)ptr;
        }
        public static void StoreImport_SandboxPhysics_PhysicsEngine_OnPhysicsJointBreak(void* ptr)
        {
            _ptr_SandboxPhysics_PhysicsEngine_OnPhysicsJointBreak = (delegate* unmanaged<void*, void*>)ptr;
        }
        public static void StoreImport_SandboxPhysics_PhysicsEngine_OnActive(void* ptr)
        {
            _ptr_SandboxPhysics_PhysicsEngine_OnActive = (delegate* unmanaged<void*, void*, void*, void*, void*>)ptr;
        }
        public static void StoreImport_Sandbox_RealTime_Update(void* ptr)
        {
            _ptr_Sandbox_RealTime_Update = (delegate* unmanaged<float, void*>)ptr;
        }
        public static void StoreImport_SndbxRndrng_RenderPipeline_InternalAddLayersToView(void* ptr)
        {
            _ptr_SndbxRndrng_RenderPipeline_InternalAddLayersToView = (delegate* unmanaged<void*, void*, void*, void*, long, void*, void*, void*>)ptr;
        }
        public static void StoreImport_SndbxRndrng_RenderPipeline_InternalPipelineEnd(void* ptr)
        {
            _ptr_SndbxRndrng_RenderPipeline_InternalPipelineEnd = (delegate* unmanaged<void*, void*, void*, void*, long, void*, void*, void*>)ptr;
        }
        public static void StoreImport_Sandbox_RenderTarget_Flush(void* ptr)
        {
            _ptr_Sandbox_RenderTarget_Flush = (delegate* unmanaged<void*>)ptr;
        }
        public static void StoreImport_Sandbox_Resource_OnResourceReloaded(void* ptr)
        {
            _ptr_Sandbox_Resource_OnResourceReloaded = (delegate* unmanaged<void*, void*, void*>)ptr;
        }
        public static void StoreImport_Sandbox_ScnCstmbjctRndr_RenderObject(void* ptr)
        {
            _ptr_Sandbox_ScnCstmbjctRndr_RenderObject = (delegate* unmanaged<void*, void*, void*>)ptr;
        }
        public static void StoreImport_Sandbox_SceneSystem_OnBeforeRender(void* ptr)
        {
            _ptr_Sandbox_SceneSystem_OnBeforeRender = (delegate* unmanaged<void*, void*, void*>)ptr;
        }
        public static void StoreImport_Sandbox_SceneSystem_OnAfterRender(void* ptr)
        {
            _ptr_Sandbox_SceneSystem_OnAfterRender = (delegate* unmanaged<void*, void*, void*>)ptr;
        }
        public static void StoreImport_SndbxSrvcs_Inventory_OnDefinitionUpdate(void* ptr)
        {
            _ptr_SndbxSrvcs_Inventory_OnDefinitionUpdate = (delegate* unmanaged<void*>)ptr;
        }
        public static void StoreImport_SndbxSrvcs_Inventory_OnPricesUpdate(void* ptr)
        {
            _ptr_SndbxSrvcs_Inventory_OnPricesUpdate = (delegate* unmanaged<void*, void*, void*>)ptr;
        }
        public static void StoreImport_SndbxSrvcs_Inventory_OnPurchaseResult(void* ptr)
        {
            _ptr_SndbxSrvcs_Inventory_OnPurchaseResult = (delegate* unmanaged<void*, ulong, ulong, void*>)ptr;
        }
        public static void StoreImport_SndbxSrvcs_ServerList_OnStarted(void* ptr)
        {
            _ptr_SndbxSrvcs_ServerList_OnStarted = (delegate* unmanaged<void*, void*>)ptr;
        }
        public static void StoreImport_SndbxSrvcs_ServerList_OnServerResponded(void* ptr)
        {
            _ptr_SndbxSrvcs_ServerList_OnServerResponded = (delegate* unmanaged<void*, void*, ulong, void*>)ptr;
        }
        public static void StoreImport_SndbxSrvcs_ServerList_OnFinished(void* ptr)
        {
            _ptr_SndbxSrvcs_ServerList_OnFinished = (delegate* unmanaged<void*, void*>)ptr;
        }
        public static void StoreImport_Sandbox_VideoPlayer_OnTextureCreatedInternal(void* ptr)
        {
            _ptr_Sandbox_VideoPlayer_OnTextureCreatedInternal = (delegate* unmanaged<void*, void*>)ptr;
        }
        public static void StoreImport_Sandbox_VideoPlayer_OnInitAudioInternal(void* ptr)
        {
            _ptr_Sandbox_VideoPlayer_OnInitAudioInternal = (delegate* unmanaged<void*, void*, void*, void*>)ptr;
        }
        public static void StoreImport_Sandbox_VideoPlayer_OnFreeAudioInternal(void* ptr)
        {
            _ptr_Sandbox_VideoPlayer_OnFreeAudioInternal = (delegate* unmanaged<void*, void*>)ptr;
        }
        public static void StoreImport_Sandbox_VideoPlayer_OnTextureDataInternal(void* ptr)
        {
            _ptr_Sandbox_VideoPlayer_OnTextureDataInternal = (delegate* unmanaged<void*, void*, void*, void*, void*>)ptr;
        }
        public static void StoreImport_Sandbox_VideoPlayer_OnLoadedInternal(void* ptr)
        {
            _ptr_Sandbox_VideoPlayer_OnLoadedInternal = (delegate* unmanaged<void*, void*>)ptr;
        }
        public static void StoreImport_Sandbox_VideoPlayer_WantsTextureData(void* ptr)
        {
            _ptr_Sandbox_VideoPlayer_WantsTextureData = (delegate* unmanaged<void*, void*>)ptr;
        }
        public static void StoreImport_Sandbox_VideoPlayer_OnFinishedInternal(void* ptr)
        {
            _ptr_Sandbox_VideoPlayer_OnFinishedInternal = (delegate* unmanaged<void*, void*>)ptr;
        }
        public static void StoreImport_Sandbox_VideoPlayer_OnRepeatedInternal(void* ptr)
        {
            _ptr_Sandbox_VideoPlayer_OnRepeatedInternal = (delegate* unmanaged<void*, void*>)ptr;
        }
        public static void StoreImport_SandboxVR_VRSystem_InternalIsActive(void* ptr)
        {
            _ptr_SandboxVR_VRSystem_InternalIsActive = (delegate* unmanaged<void*>)ptr;
        }
        public static void StoreImport_SandboxVR_VRSystem_InternalWantsInit(void* ptr)
        {
            _ptr_SandboxVR_VRSystem_InternalWantsInit = (delegate* unmanaged<void*>)ptr;
        }
        public static void StoreImport_SandboxVR_VRSystem_BeginFrame(void* ptr)
        {
            _ptr_SandboxVR_VRSystem_BeginFrame = (delegate* unmanaged<void*>)ptr;
        }
        public static void StoreImport_SandboxVR_VRSystem_EndFrame(void* ptr)
        {
            _ptr_SandboxVR_VRSystem_EndFrame = (delegate* unmanaged<void*>)ptr;
        }
        public static void StoreImport_SandboxVR_VRSystem_Submit(void* ptr)
        {
            _ptr_SandboxVR_VRSystem_Submit = (delegate* unmanaged<void*, void*, void*>)ptr;
        }
        public static void StoreImport_SandboxVR_VRSystem_GetVulkanInstanceExtensionsRequired(void* ptr)
        {
            _ptr_SandboxVR_VRSystem_GetVulkanInstanceExtensionsRequired = (delegate* unmanaged<void*>)ptr;
        }
        public static void StoreImport_SandboxVR_VRSystem_GetVulkanDeviceExtensionsRequired(void* ptr)
        {
            _ptr_SandboxVR_VRSystem_GetVulkanDeviceExtensionsRequired = (delegate* unmanaged<void*>)ptr;
        }
        public static void StoreImport_SandboxVR_VRSystem_RenderOverlays(void* ptr)
        {
            _ptr_SandboxVR_VRSystem_RenderOverlays = (delegate* unmanaged<void*>)ptr;
        }
        public static void StoreImport_Steamworks_Dispatch_OnClientCallback(void* ptr)
        {
            _ptr_Steamworks_Dispatch_OnClientCallback = (delegate* unmanaged<void*, void*, void*, void*, void*>)ptr;
        }

// Sandbox.AsyncGPUReadback
[UnmanagedCallersOnly(EntryPoint = "Sandbox_AsyncGPUReadback_DispatchManagedReadTextureCallback")]
public static void* Sandbox_AsyncGPUReadback_DispatchManagedReadTextureCallback( void* caller, void* pData, long format, void* nMipLevel, void* nWidth, void* nHeight, void* nPitchInBytes )
{
    return (void*)Imports._ptr_Sandbox_AsyncGPUReadback_DispatchManagedReadTextureCallback( caller, pData, format, nMipLevel, nWidth, nHeight, nPitchInBytes );
}

[UnmanagedCallersOnly(EntryPoint = "Sandbox_AsyncGPUReadback_DispatchManagedReadBufferCallback")]
public static void* Sandbox_AsyncGPUReadback_DispatchManagedReadBufferCallback( void* caller, void* pData, void* nBytes )
{
    return (void*)Imports._ptr_Sandbox_AsyncGPUReadback_DispatchManagedReadBufferCallback( caller, pData, nBytes );
}

// Sandbox.Audio.MixingThread
[UnmanagedCallersOnly(EntryPoint = "SandboxAudio_MixingThread_MixOneBuffer")]
public static void* SandboxAudio_MixingThread_MixOneBuffer()
{
    return (void*)Imports._ptr_SandboxAudio_MixingThread_MixOneBuffer();
}

// Sandbox.ConVarSystem
[UnmanagedCallersOnly(EntryPoint = "Sandbox_ConVarSystem_RegisterNativeVar")]
public static void* Sandbox_ConVarSystem_RegisterNativeVar( void* convar )
{
    return (void*)Imports._ptr_Sandbox_ConVarSystem_RegisterNativeVar( convar );
}

[UnmanagedCallersOnly(EntryPoint = "Sandbox_ConVarSystem_RegisterNativeCommand")]
public static void* Sandbox_ConVarSystem_RegisterNativeCommand( void* concommand )
{
    return (void*)Imports._ptr_Sandbox_ConVarSystem_RegisterNativeCommand( concommand );
}

[UnmanagedCallersOnly(EntryPoint = "Sandbox_ConVarSystem_OnConVarChanged")]
public static void* Sandbox_ConVarSystem_OnConVarChanged( void* convarname, void* value, void* previous )
{
    return (void*)Imports._ptr_Sandbox_ConVarSystem_OnConVarChanged( convarname, value, previous );
}

// Sandbox.Diagnostics.Logging
[UnmanagedCallersOnly(EntryPoint = "SndbxDgnstcs_Logging_RegisterEngineLogger")]
public static void* SndbxDgnstcs_Logging_RegisterEngineLogger( void* id, void* name )
{
    return (void*)Imports._ptr_SndbxDgnstcs_Logging_RegisterEngineLogger( id, name );
}

// Sandbox.Engine.Bootstrap
[UnmanagedCallersOnly(EntryPoint = "SandboxEngine_Bootstrap_EnvironmentExit")]
public static void* SandboxEngine_Bootstrap_EnvironmentExit( void* nCode )
{
    return (void*)Imports._ptr_SandboxEngine_Bootstrap_EnvironmentExit( nCode );
}

// Sandbox.DecalSceneObject
// Sandbox.Engine.InputRouter
[UnmanagedCallersOnly(EntryPoint = "SandboxEngine_InputRouter_OnMouseMotion")]
public static void* SandboxEngine_InputRouter_OnMouseMotion( float dx, float dy )
{
    return (void*)Imports._ptr_SandboxEngine_InputRouter_OnMouseMotion( dx, dy );
}

[UnmanagedCallersOnly(EntryPoint = "SandboxEngine_InputRouter_OnMousePositionChange")]
public static void* SandboxEngine_InputRouter_OnMousePositionChange( float x, float y, float dx, float dy )
{
    return (void*)Imports._ptr_SandboxEngine_InputRouter_OnMousePositionChange( x, y, dx, dy );
}

[UnmanagedCallersOnly(EntryPoint = "SandboxEngine_InputRouter_OnMouseButton")]
public static void* SandboxEngine_InputRouter_OnMouseButton( long button, void* state, void* ikeymods )
{
    return (void*)Imports._ptr_SandboxEngine_InputRouter_OnMouseButton( button, state, ikeymods );
}

[UnmanagedCallersOnly(EntryPoint = "SandboxEngine_InputRouter_OnKey")]
public static void* SandboxEngine_InputRouter_OnKey( long button, void* state, void* repeating, void* ikeymods, void* vkcode )
{
    return (void*)Imports._ptr_SandboxEngine_InputRouter_OnKey( button, state, repeating, ikeymods, vkcode );
}

[UnmanagedCallersOnly(EntryPoint = "SandboxEngine_InputRouter_OnText")]
public static void* SandboxEngine_InputRouter_OnText( void* key )
{
    return (void*)Imports._ptr_SandboxEngine_InputRouter_OnText( key );
}

[UnmanagedCallersOnly(EntryPoint = "SandboxEngine_InputRouter_OnWindowActive")]
public static void* SandboxEngine_InputRouter_OnWindowActive( void* active )
{
    return (void*)Imports._ptr_SandboxEngine_InputRouter_OnWindowActive( active );
}

[UnmanagedCallersOnly(EntryPoint = "SandboxEngine_InputRouter_OnMouseWheel")]
public static void* SandboxEngine_InputRouter_OnMouseWheel( void* x, void* y, void* ikeymods )
{
    return (void*)Imports._ptr_SandboxEngine_InputRouter_OnMouseWheel( x, y, ikeymods );
}

[UnmanagedCallersOnly(EntryPoint = "SandboxEngine_InputRouter_OnImeStart")]
public static void* SandboxEngine_InputRouter_OnImeStart()
{
    return (void*)Imports._ptr_SandboxEngine_InputRouter_OnImeStart();
}

[UnmanagedCallersOnly(EntryPoint = "SandboxEngine_InputRouter_OnImeComposition")]
public static void* SandboxEngine_InputRouter_OnImeComposition( void* text, void* final )
{
    return (void*)Imports._ptr_SandboxEngine_InputRouter_OnImeComposition( text, final );
}

[UnmanagedCallersOnly(EntryPoint = "SandboxEngine_InputRouter_OnImeEnd")]
public static void* SandboxEngine_InputRouter_OnImeEnd()
{
    return (void*)Imports._ptr_SandboxEngine_InputRouter_OnImeEnd();
}

[UnmanagedCallersOnly(EntryPoint = "SandboxEngine_InputRouter_OnGameControllerButton")]
public static void* SandboxEngine_InputRouter_OnGameControllerButton( void* deviceId, long button, void* state )
{
    return (void*)Imports._ptr_SandboxEngine_InputRouter_OnGameControllerButton( deviceId, button, state );
}

[UnmanagedCallersOnly(EntryPoint = "SandboxEngine_InputRouter_OnGameControllerAxis")]
public static void* SandboxEngine_InputRouter_OnGameControllerAxis( void* deviceId, long axis, void* value )
{
    return (void*)Imports._ptr_SandboxEngine_InputRouter_OnGameControllerAxis( deviceId, axis, value );
}

[UnmanagedCallersOnly(EntryPoint = "SandboxEngine_InputRouter_OnGameControllerConnected")]
public static void* SandboxEngine_InputRouter_OnGameControllerConnected( void* joystickId, void* deviceId )
{
    return (void*)Imports._ptr_SandboxEngine_InputRouter_OnGameControllerConnected( joystickId, deviceId );
}

[UnmanagedCallersOnly(EntryPoint = "SandboxEngine_InputRouter_OnGameControllerDisconnected")]
public static void* SandboxEngine_InputRouter_OnGameControllerDisconnected( void* deviceId )
{
    return (void*)Imports._ptr_SandboxEngine_InputRouter_OnGameControllerDisconnected( deviceId );
}

[UnmanagedCallersOnly(EntryPoint = "SandboxEngine_InputRouter_OnConsoleCommand")]
public static void* SandboxEngine_InputRouter_OnConsoleCommand( void* command )
{
    return (void*)Imports._ptr_SandboxEngine_InputRouter_OnConsoleCommand( command );
}

[UnmanagedCallersOnly(EntryPoint = "SandboxEngine_InputRouter_CloseApplication")]
public static void* SandboxEngine_InputRouter_CloseApplication()
{
    return (void*)Imports._ptr_SandboxEngine_InputRouter_CloseApplication();
}

// Sandbox.PhysicsBody
// Sandbox.PhysicsGroup
// Sandbox.PhysicsShape
// Sandbox.PhysicsWorld
// Sandbox.SceneCubemap
// Sandbox.SceneCustomObject
// Sandbox.SceneLight
// Sandbox.SceneLightProbe
// Sandbox.SceneModel
// Sandbox.SceneObject
// Sandbox.SceneSkyBox
// Sandbox.SceneWorld
// Sandbox.SoundStream
// Sandbox.Engine.SystemInfo
[UnmanagedCallersOnly(EntryPoint = "SandboxEngine_SystemInfo_Set")]
public static void* SandboxEngine_SystemInfo_Set( void* cpu, void* processorCount, ulong frequency, ulong totalMemory )
{
    return (void*)Imports._ptr_SandboxEngine_SystemInfo_Set( cpu, processorCount, frequency, totalMemory );
}

[UnmanagedCallersOnly(EntryPoint = "SandboxEngine_SystemInfo_SetGpu")]
public static void* SandboxEngine_SystemInfo_SetGpu( void* driver, void* version, ulong memory )
{
    return (void*)Imports._ptr_SandboxEngine_SystemInfo_SetGpu( driver, version, memory );
}

// Sandbox.EngineLoop
[UnmanagedCallersOnly(EntryPoint = "Sandbox_EngineLoop_Print")]
public static void* Sandbox_EngineLoop_Print( void* severitty, void* logger, void* message )
{
    return (void*)Imports._ptr_Sandbox_EngineLoop_Print( severitty, logger, message );
}

[UnmanagedCallersOnly(EntryPoint = "Sandbox_EngineLoop_DispatchConsoleCommand")]
public static void* Sandbox_EngineLoop_DispatchConsoleCommand( void* name, void* args, long flags )
{
    return (void*)Imports._ptr_Sandbox_EngineLoop_DispatchConsoleCommand( name, args, flags );
}

[UnmanagedCallersOnly(EntryPoint = "Sandbox_EngineLoop_OnClientOutput")]
public static void* Sandbox_EngineLoop_OnClientOutput()
{
    return (void*)Imports._ptr_Sandbox_EngineLoop_OnClientOutput();
}

[UnmanagedCallersOnly(EntryPoint = "Sandbox_EngineLoop_OnSceneViewSubmitted")]
public static void* Sandbox_EngineLoop_OnSceneViewSubmitted( void* view )
{
    return (void*)Imports._ptr_Sandbox_EngineLoop_OnSceneViewSubmitted( view );
}

// Sandbox.Graphics
[UnmanagedCallersOnly(EntryPoint = "Sandbox_Graphics_OnLayer")]
public static void* Sandbox_Graphics_OnLayer( void* renderHookStage, void* setup )
{
    return (void*)Imports._ptr_Sandbox_Graphics_OnLayer( renderHookStage, setup );
}

// Sandbox.HandleIndex
[UnmanagedCallersOnly(EntryPoint = "Sandbox_HandleIndex_RegisterHandle")]
public static int Sandbox_HandleIndex_RegisterHandle( void* ptr, void* type )
{
    return (int)Imports._ptr_Sandbox_HandleIndex_RegisterHandle( ptr, type );
}

[UnmanagedCallersOnly(EntryPoint = "Sandbox_HandleIndex_FreeHandle")]
public static void* Sandbox_HandleIndex_FreeHandle( void* handle )
{
    return (void*)Imports._ptr_Sandbox_HandleIndex_FreeHandle( handle );
}

// Sandbox.LobbyManager
[UnmanagedCallersOnly(EntryPoint = "Sandbox_LobbyManager_OnLobbyInvite")]
public static void* Sandbox_LobbyManager_OnLobbyInvite( ulong lobbyid, ulong memberid )
{
    return (void*)Imports._ptr_Sandbox_LobbyManager_OnLobbyInvite( lobbyid, memberid );
}

[UnmanagedCallersOnly(EntryPoint = "Sandbox_LobbyManager_OnMemberEntered")]
public static void* Sandbox_LobbyManager_OnMemberEntered( ulong lobbyid, ulong memberid )
{
    return (void*)Imports._ptr_Sandbox_LobbyManager_OnMemberEntered( lobbyid, memberid );
}

[UnmanagedCallersOnly(EntryPoint = "Sandbox_LobbyManager_OnMemberLeave")]
public static void* Sandbox_LobbyManager_OnMemberLeave( ulong lobbyid, ulong memberid )
{
    return (void*)Imports._ptr_Sandbox_LobbyManager_OnMemberLeave( lobbyid, memberid );
}

[UnmanagedCallersOnly(EntryPoint = "Sandbox_LobbyManager_OnEntered")]
public static void* Sandbox_LobbyManager_OnEntered( ulong lobbyid )
{
    return (void*)Imports._ptr_Sandbox_LobbyManager_OnEntered( lobbyid );
}

[UnmanagedCallersOnly(EntryPoint = "Sandbox_LobbyManager_OnCreated")]
public static void* Sandbox_LobbyManager_OnCreated( ulong lobbyid )
{
    return (void*)Imports._ptr_Sandbox_LobbyManager_OnCreated( lobbyid );
}

[UnmanagedCallersOnly(EntryPoint = "Sandbox_LobbyManager_OnDataUpdate")]
public static void* Sandbox_LobbyManager_OnDataUpdate( ulong lobbyid, ulong targetid )
{
    return (void*)Imports._ptr_Sandbox_LobbyManager_OnDataUpdate( lobbyid, targetid );
}

[UnmanagedCallersOnly(EntryPoint = "Sandbox_LobbyManager_OnChatMessage")]
public static void* Sandbox_LobbyManager_OnChatMessage( ulong lobbyid, ulong memberid, void* message, void* length )
{
    return (void*)Imports._ptr_Sandbox_LobbyManager_OnChatMessage( lobbyid, memberid, message, length );
}

// Sandbox.Network.SteamNetwork
[UnmanagedCallersOnly(EntryPoint = "SandboxNetwork_SteamNetwork_OnSocketConnection")]
public static void* SandboxNetwork_SteamNetwork_OnSocketConnection( void* socket, void* connection )
{
    return (void*)Imports._ptr_SandboxNetwork_SteamNetwork_OnSocketConnection( socket, connection );
}

[UnmanagedCallersOnly(EntryPoint = "SandboxNetwork_SteamNetwork_OnSocketDisconnection")]
public static void* SandboxNetwork_SteamNetwork_OnSocketDisconnection( void* socket, void* connection )
{
    return (void*)Imports._ptr_SandboxNetwork_SteamNetwork_OnSocketDisconnection( socket, connection );
}

[UnmanagedCallersOnly(EntryPoint = "SandboxNetwork_SteamNetwork_ShouldAcceptConnection")]
public static int SandboxNetwork_SteamNetwork_ShouldAcceptConnection( void* socket, void* connection )
{
    return (int)Imports._ptr_SandboxNetwork_SteamNetwork_ShouldAcceptConnection( socket, connection );
}

[UnmanagedCallersOnly(EntryPoint = "SandboxNetwork_SteamNetwork_OnDisconnection")]
public static void* SandboxNetwork_SteamNetwork_OnDisconnection( void* connection, void* reasonCode, void* reasonString )
{
    return (void*)Imports._ptr_SandboxNetwork_SteamNetwork_OnDisconnection( connection, reasonCode, reasonString );
}

[UnmanagedCallersOnly(EntryPoint = "SandboxNetwork_SteamNetwork_OnSessionEstablished")]
public static void* SandboxNetwork_SteamNetwork_OnSessionEstablished( ulong steamId )
{
    return (void*)Imports._ptr_SandboxNetwork_SteamNetwork_OnSessionEstablished( steamId );
}

[UnmanagedCallersOnly(EntryPoint = "SandboxNetwork_SteamNetwork_OnSessionFailed")]
public static void* SandboxNetwork_SteamNetwork_OnSessionFailed( void* socket, ulong steamId )
{
    return (void*)Imports._ptr_SandboxNetwork_SteamNetwork_OnSessionFailed( socket, steamId );
}

// Sandbox.Physics.PhysicsJoint
// Sandbox.Physics.PhysicsEngine
[UnmanagedCallersOnly(EntryPoint = "SandboxPhysics_PhysicsEngine_OnPhysicsJointBreak")]
public static void* SandboxPhysics_PhysicsEngine_OnPhysicsJointBreak( void* joint )
{
    return (void*)Imports._ptr_SandboxPhysics_PhysicsEngine_OnPhysicsJointBreak( joint );
}

[UnmanagedCallersOnly(EntryPoint = "SandboxPhysics_PhysicsEngine_OnActive")]
public static void* SandboxPhysics_PhysicsEngine_OnActive( void* body, void* transform, void* velocity, void* linearVelocity )
{
    return (void*)Imports._ptr_SandboxPhysics_PhysicsEngine_OnActive( body, transform, velocity, linearVelocity );
}

// Sandbox.RealTime
[UnmanagedCallersOnly(EntryPoint = "Sandbox_RealTime_Update")]
public static void* Sandbox_RealTime_Update( float time )
{
    return (void*)Imports._ptr_Sandbox_RealTime_Update( time );
}

// Sandbox.Rendering.RenderPipeline
[UnmanagedCallersOnly(EntryPoint = "SndbxRndrng_RenderPipeline_InternalAddLayersToView")]
public static void* SndbxRndrng_RenderPipeline_InternalAddLayersToView( void* view, void* viewport, void* hColor, void* hDepth, long nMSAA, void* pipelineAttributes, void* screenDimensions )
{
    return (void*)Imports._ptr_SndbxRndrng_RenderPipeline_InternalAddLayersToView( view, viewport, hColor, hDepth, nMSAA, pipelineAttributes, screenDimensions );
}

[UnmanagedCallersOnly(EntryPoint = "SndbxRndrng_RenderPipeline_InternalPipelineEnd")]
public static void* SndbxRndrng_RenderPipeline_InternalPipelineEnd( void* view, void* viewport, void* hColor, void* hDepth, long nMSAA, void* pipelineAttributes, void* screenDimensions )
{
    return (void*)Imports._ptr_SndbxRndrng_RenderPipeline_InternalPipelineEnd( view, viewport, hColor, hDepth, nMSAA, pipelineAttributes, screenDimensions );
}

// Sandbox.RenderTarget
[UnmanagedCallersOnly(EntryPoint = "Sandbox_RenderTarget_Flush")]
public static void* Sandbox_RenderTarget_Flush()
{
    return (void*)Imports._ptr_Sandbox_RenderTarget_Flush();
}

// Sandbox.Resource
[UnmanagedCallersOnly(EntryPoint = "Sandbox_Resource_OnResourceReloaded")]
public static void* Sandbox_Resource_OnResourceReloaded( void* name, void* resourceBinding )
{
    return (void*)Imports._ptr_Sandbox_Resource_OnResourceReloaded( name, resourceBinding );
}

// Sandbox.SceneCustomObjectRender
[UnmanagedCallersOnly(EntryPoint = "Sandbox_ScnCstmbjctRndr_RenderObject")]
public static void* Sandbox_ScnCstmbjctRndr_RenderObject( void* setup, void* obj )
{
    return (void*)Imports._ptr_Sandbox_ScnCstmbjctRndr_RenderObject( setup, obj );
}

// Sandbox.SceneSystem
[UnmanagedCallersOnly(EntryPoint = "Sandbox_SceneSystem_OnBeforeRender")]
public static void* Sandbox_SceneSystem_OnBeforeRender( void* obj, void* setup )
{
    return (void*)Imports._ptr_Sandbox_SceneSystem_OnBeforeRender( obj, setup );
}

[UnmanagedCallersOnly(EntryPoint = "Sandbox_SceneSystem_OnAfterRender")]
public static void* Sandbox_SceneSystem_OnAfterRender( void* obj, void* setup )
{
    return (void*)Imports._ptr_Sandbox_SceneSystem_OnAfterRender( obj, setup );
}

// Sandbox.Services.Inventory
[UnmanagedCallersOnly(EntryPoint = "SndbxSrvcs_Inventory_OnDefinitionUpdate")]
public static void* SndbxSrvcs_Inventory_OnDefinitionUpdate()
{
    return (void*)Imports._ptr_SndbxSrvcs_Inventory_OnDefinitionUpdate();
}

[UnmanagedCallersOnly(EntryPoint = "SndbxSrvcs_Inventory_OnPricesUpdate")]
public static void* SndbxSrvcs_Inventory_OnPricesUpdate( void* success, void* currency )
{
    return (void*)Imports._ptr_SndbxSrvcs_Inventory_OnPricesUpdate( success, currency );
}

[UnmanagedCallersOnly(EntryPoint = "SndbxSrvcs_Inventory_OnPurchaseResult")]
public static void* SndbxSrvcs_Inventory_OnPurchaseResult( void* success, ulong orderid, ulong transid )
{
    return (void*)Imports._ptr_SndbxSrvcs_Inventory_OnPurchaseResult( success, orderid, transid );
}

// Sandbox.Services.ServerList
[UnmanagedCallersOnly(EntryPoint = "SndbxSrvcs_ServerList_OnStarted")]
public static void* SndbxSrvcs_ServerList_OnStarted( void* self )
{
    return (void*)Imports._ptr_SndbxSrvcs_ServerList_OnStarted( self );
}

[UnmanagedCallersOnly(EntryPoint = "SndbxSrvcs_ServerList_OnServerResponded")]
public static void* SndbxSrvcs_ServerList_OnServerResponded( void* self, void* ptr, ulong steamid )
{
    return (void*)Imports._ptr_SndbxSrvcs_ServerList_OnServerResponded( self, ptr, steamid );
}

[UnmanagedCallersOnly(EntryPoint = "SndbxSrvcs_ServerList_OnFinished")]
public static void* SndbxSrvcs_ServerList_OnFinished( void* self )
{
    return (void*)Imports._ptr_SndbxSrvcs_ServerList_OnFinished( self );
}

// Sandbox.VideoPlayer
[UnmanagedCallersOnly(EntryPoint = "Sandbox_VideoPlayer_OnTextureCreatedInternal")]
public static void* Sandbox_VideoPlayer_OnTextureCreatedInternal( void* self )
{
    return (void*)Imports._ptr_Sandbox_VideoPlayer_OnTextureCreatedInternal( self );
}

[UnmanagedCallersOnly(EntryPoint = "Sandbox_VideoPlayer_OnInitAudioInternal")]
public static void* Sandbox_VideoPlayer_OnInitAudioInternal( void* self, void* sampleRate, void* channels )
{
    return (void*)Imports._ptr_Sandbox_VideoPlayer_OnInitAudioInternal( self, sampleRate, channels );
}

[UnmanagedCallersOnly(EntryPoint = "Sandbox_VideoPlayer_OnFreeAudioInternal")]
public static void* Sandbox_VideoPlayer_OnFreeAudioInternal( void* self )
{
    return (void*)Imports._ptr_Sandbox_VideoPlayer_OnFreeAudioInternal( self );
}

[UnmanagedCallersOnly(EntryPoint = "Sandbox_VideoPlayer_OnTextureDataInternal")]
public static void* Sandbox_VideoPlayer_OnTextureDataInternal( void* self, void* data, void* width, void* height )
{
    return (void*)Imports._ptr_Sandbox_VideoPlayer_OnTextureDataInternal( self, data, width, height );
}

[UnmanagedCallersOnly(EntryPoint = "Sandbox_VideoPlayer_OnLoadedInternal")]
public static void* Sandbox_VideoPlayer_OnLoadedInternal( void* self )
{
    return (void*)Imports._ptr_Sandbox_VideoPlayer_OnLoadedInternal( self );
}

[UnmanagedCallersOnly(EntryPoint = "Sandbox_VideoPlayer_WantsTextureData")]
public static int Sandbox_VideoPlayer_WantsTextureData( void* self )
{
    return (int)Imports._ptr_Sandbox_VideoPlayer_WantsTextureData( self );
}

[UnmanagedCallersOnly(EntryPoint = "Sandbox_VideoPlayer_OnFinishedInternal")]
public static void* Sandbox_VideoPlayer_OnFinishedInternal( void* self )
{
    return (void*)Imports._ptr_Sandbox_VideoPlayer_OnFinishedInternal( self );
}

[UnmanagedCallersOnly(EntryPoint = "Sandbox_VideoPlayer_OnRepeatedInternal")]
public static void* Sandbox_VideoPlayer_OnRepeatedInternal( void* self )
{
    return (void*)Imports._ptr_Sandbox_VideoPlayer_OnRepeatedInternal( self );
}

// Sandbox.VR.VRSystem
[UnmanagedCallersOnly(EntryPoint = "SandboxVR_VRSystem_InternalIsActive")]
public static int SandboxVR_VRSystem_InternalIsActive()
{
    return (int)Imports._ptr_SandboxVR_VRSystem_InternalIsActive();
}

[UnmanagedCallersOnly(EntryPoint = "SandboxVR_VRSystem_InternalWantsInit")]
public static int SandboxVR_VRSystem_InternalWantsInit()
{
    return (int)Imports._ptr_SandboxVR_VRSystem_InternalWantsInit();
}

[UnmanagedCallersOnly(EntryPoint = "SandboxVR_VRSystem_BeginFrame")]
public static void* SandboxVR_VRSystem_BeginFrame()
{
    return (void*)Imports._ptr_SandboxVR_VRSystem_BeginFrame();
}

[UnmanagedCallersOnly(EntryPoint = "SandboxVR_VRSystem_EndFrame")]
public static void* SandboxVR_VRSystem_EndFrame()
{
    return (void*)Imports._ptr_SandboxVR_VRSystem_EndFrame();
}

[UnmanagedCallersOnly(EntryPoint = "SandboxVR_VRSystem_Submit")]
public static int SandboxVR_VRSystem_Submit( void* pTexture, void* pDepthTexture )
{
    return (int)Imports._ptr_SandboxVR_VRSystem_Submit( pTexture, pDepthTexture );
}

[UnmanagedCallersOnly(EntryPoint = "SandboxVR_VRSystem_GetVulkanInstanceExtensionsRequired")]
public static void* SandboxVR_VRSystem_GetVulkanInstanceExtensionsRequired()
{
    return (void*)Imports._ptr_SandboxVR_VRSystem_GetVulkanInstanceExtensionsRequired();
}

[UnmanagedCallersOnly(EntryPoint = "SandboxVR_VRSystem_GetVulkanDeviceExtensionsRequired")]
public static void* SandboxVR_VRSystem_GetVulkanDeviceExtensionsRequired()
{
    return (void*)Imports._ptr_SandboxVR_VRSystem_GetVulkanDeviceExtensionsRequired();
}

[UnmanagedCallersOnly(EntryPoint = "SandboxVR_VRSystem_RenderOverlays")]
public static void* SandboxVR_VRSystem_RenderOverlays()
{
    return (void*)Imports._ptr_SandboxVR_VRSystem_RenderOverlays();
}

// Steamworks.Dispatch
[UnmanagedCallersOnly(EntryPoint = "Steamworks_Dispatch_OnClientCallback")]
public static void* Steamworks_Dispatch_OnClientCallback( void* type, void* data, void* datasize, void* isServer )
{
    return (void*)Imports._ptr_Steamworks_Dispatch_OnClientCallback( type, data, datasize, isServer );
}

    }

}
