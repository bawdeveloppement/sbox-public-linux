using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using Silk.NET.Core.Native;

namespace Sbox.Engine.Emulation.Generated
{
    public static unsafe partial class Exports
    {
	public static unsafe void FillNativeFunctionsModeldoc(void** managedFunctions, void** nativeFunctions, int* structSizes)
 	{
 		var i = 0;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged<IntPtr, void>)&Sbox.Engine.Emulation.EngineExports.DebugError;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CModelDoc_DeleteThis;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&CModelDoc_Create;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int >)&CModelDoc_SaveToFile;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CMdlDcdtrpp_RefreshGameData;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CMdlDcdtrpp_GetSessionModel;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void* >)&CModelMesh_DeleteThis;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void* >)&CModelMesh_Create;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void* >)&CModelMesh_AddVertices;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void* >)&CModelMesh_AddFaceGroup;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, void* >)&CModelMesh_SetPositions;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, void* >)&CModelMesh_SetTexCoords;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, void* >)&CModelMesh_SetNormals;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, int, void*, int, void* >)&CModelMesh_AddFace;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int >)&g_pModelDocUtils_InitFromMesh;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, void*, int >)&NativeEngine_ModelDoc_CreateModelFromMeshFile;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int >)&NativeEngine_ModelDoc_CreateModelFromMesh;
 		nativeFunctions[i++] = (void*)(delegate* unmanaged< void*, void*, int, int >)&NativeEngine_ModelDoc_CreateModelFromMeshes;
 	}

        [UnmanagedCallersOnly(EntryPoint = "CModelDoc_DeleteThis")]
        public static void* CModelDoc_DeleteThis( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModelDoc_Create")]
        public static void* CModelDoc_Create()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModelDoc_SaveToFile")]
        public static int CModelDoc_SaveToFile( void* self, void* pFullPath )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMdlDcdtrpp_RefreshGameData")]
        public static void* CMdlDcdtrpp_RefreshGameData( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CMdlDcdtrpp_GetSessionModel")]
        public static void* CMdlDcdtrpp_GetSessionModel( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModelMesh_DeleteThis")]
        public static void* CModelMesh_DeleteThis( void* self )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModelMesh_Create")]
        public static void* CModelMesh_Create()
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModelMesh_AddVertices")]
        public static void* CModelMesh_AddVertices( void* self, int nNumVertices )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModelMesh_AddFaceGroup")]
        public static void* CModelMesh_AddFaceGroup( void* self, void* pMaterialName )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModelMesh_SetPositions")]
        public static void* CModelMesh_SetPositions( void* self, void* pPositions, int nNumPositions )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModelMesh_SetTexCoords")]
        public static void* CModelMesh_SetTexCoords( void* self, void* pTexCoords, int nNumTexCoords )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModelMesh_SetNormals")]
        public static void* CModelMesh_SetNormals( void* self, void* pNormals, int nNumNormals )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "CModelMesh_AddFace")]
        public static void* CModelMesh_AddFace( void* self, int nGroupIndex, void* pVertices, int nNumVertices )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "g_pModelDocUtils_InitFromMesh")]
        public static int g_pModelDocUtils_InitFromMesh( void* pModelDoc, void* pFilename )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "NativeEngine_ModelDoc_CreateModelFromMeshFile")]
        public static int NativeEngine_ModelDoc_CreateModelFromMeshFile( void* pVmdlFileFullPath, void* meshRelativePath, void* material )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "NativeEngine_ModelDoc_CreateModelFromMesh")]
        public static int NativeEngine_ModelDoc_CreateModelFromMesh( void* pVmdlFileFullPath, void* pMesh )
        {
            return default;
        }
        [UnmanagedCallersOnly(EntryPoint = "NativeEngine_ModelDoc_CreateModelFromMeshes")]
        public static int NativeEngine_ModelDoc_CreateModelFromMeshes( void* pVmdlFileFullPath, void* pMeshes, int nMeshCount )
        {
            return default;
        }
    }
    public static unsafe partial class Imports
    {
        public static delegate* unmanaged<void*, void*> _ptr_dtrMdldtr_ModelDoc_Init;
        public static delegate* unmanaged<void*, void*> _ptr_dtrMdldtr_ModelDoc_OnToolsMenu;
        public static void StoreImport_dtrMdldtr_ModelDoc_Init(void* ptr)
        {
            _ptr_dtrMdldtr_ModelDoc_Init = (delegate* unmanaged<void*, void*>)ptr;
        }
        public static void StoreImport_dtrMdldtr_ModelDoc_OnToolsMenu(void* ptr)
        {
            _ptr_dtrMdldtr_ModelDoc_OnToolsMenu = (delegate* unmanaged<void*, void*>)ptr;
        }

// Editor.ModelEditor.ModelDoc
[UnmanagedCallersOnly(EntryPoint = "dtrMdldtr_ModelDoc_Init")]
public static void* dtrMdldtr_ModelDoc_Init( void* app )
{
    return (void*)Imports._ptr_dtrMdldtr_ModelDoc_Init( app );
}

[UnmanagedCallersOnly(EntryPoint = "dtrMdldtr_ModelDoc_OnToolsMenu")]
public static void* dtrMdldtr_ModelDoc_OnToolsMenu( void* menu )
{
    return (void*)Imports._ptr_dtrMdldtr_ModelDoc_OnToolsMenu( menu );
}

// Sandbox.DecalSceneObject
// Sandbox.PhysicsBody
// Sandbox.PhysicsGroup
// Sandbox.PhysicsShape
// Sandbox.PhysicsWorld
// Sandbox.SceneCubemap
// Sandbox.SceneLight
// Sandbox.SceneLightProbe
// Sandbox.SceneModel
// Sandbox.SceneObject
// Sandbox.SceneSkyBox
// Sandbox.SceneWorld
// Sandbox.Physics.PhysicsJoint
    }

}
