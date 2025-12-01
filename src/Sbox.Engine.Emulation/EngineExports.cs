using System.Runtime.InteropServices;
using Sbox.Engine.Emulation.Generated;
using Sbox.Engine.Emulation.Physics;
using Sbox.Engine;
using NativeEngine;
using Silk.NET.Maths;
using System.IO;
using Silk.NET.GLFW;
using Sandbox;
using Silk.NET.OpenGL;

namespace Sbox.Engine.Emulation;

public static unsafe class EngineExports
{
    private static bool _isReady = false;
    private static Glfw? _glfw;
    private static WindowHandle* _windowHandle;
    private static Silk.NET.OpenGL.GL? _gl;

    /// <summary>
    /// Main engine initialization function called by the managed runtime.
    /// This is the entry point that receives function pointers from both sides.
    /// </summary>
    [UnmanagedCallersOnly(EntryPoint = "igen_engine")]
    public static void IGenEngine(int hash, void* managedFunctions, void* nativeFunctions, int* structSizes)
    {
        Console.WriteLine($"[NativeAOT Engine] igen_engine called with hash: {hash}");

        void** managed = (void**)managedFunctions;
        void** native  = (void**)nativeFunctions;

        // 1. Store managed function pointers (Imports)
        EngineGlue.StoreImports(managed);

        // 2. Fill native function pointers (Exports)
        Exports.FillNativeFunctionsEngine(managed, native, structSizes);
        
        // 3. Patch native function pointers with our implementations
        // Indices calculated from engine.Generated.cs (LineNumber - 13)
        
        // CMtrlSystm2ppSys_Create: Line 511 -> Index 498
        native[498] = (void*)(delegate* unmanaged<void*, void*>)&CMtrlSystm2ppSys_Create;

        // CMtrlSystm2ppSys_Init: Line 513 -> Index 500
        native[500] = (void*)(delegate* unmanaged<void*, int>)&CMtrlSystm2ppSys_Init;

        // CMtrlSystm2ppSys_GetAppWindow: Line 516 -> Index 503
        native[503] = (void*)(delegate* unmanaged<void*, void*>)&CMtrlSystm2ppSys_GetAppWindow;

        // CMtrlSystm2ppSys_CreateAppWindow: Line 544 -> Index 531
        native[531] = (void*)(delegate* unmanaged<void*, void*, int, int, int, int, int, int, void*>)&CreateAppWindow;

        native[1421] = (void*)(delegate* unmanaged< void*, void*, void* >)&GetEngineSwapChainSize;

        native[1474] = (void*)(delegate* unmanaged< void*, int, void*, void*, int, void* >)&FindOrCreateTexture2;
        
        // global_Plat_MessageBox: Line 1584 -> Index 1571
        native[1571] = (void*)(delegate* unmanaged<void*, void*, void*>)&Plat_MessageBox;

        // global_Plat_SetCurrentFrame: Line 1591 -> Index 1578
        native[1578] = (void*)(delegate* unmanaged<ulong, void*>)&Plat_SetCurrentFrame;
        
        // global_GetGameRootFolder: Line 1602 -> Index 1589
        native[1589] = (void*)(delegate* unmanaged<void*>)&GetGameRootFolder;

        // global_SourceEnginePreInit: Line 1605 -> Index 1592
        native[1592] = (void*)(delegate* unmanaged<void*, void*, int>)&SourceEnginePreInit;
        
        // global_SourceEngineInit: Line 1606 -> Index 1593
        native[1593] = (void*)(delegate* unmanaged<void*, int>)&SourceEngineInit;
        
        // global_SourceEngineFrame: Line 1607 -> Index 1594
        native[1594] = (void*)(delegate* unmanaged<void*, double, double, int>)&SourceEngineFrame;
        
        // global_UpdateWindowSize: Line 1609 -> Index 1596
        native[1596] = (void*)(delegate* unmanaged<void*>)&UpdateWindowSize;

        // Physics System Exports
        // g_pPhysicsSystem_CreateWorld: Index 1464
        native[1464] = (void*)(delegate* unmanaged<int>)&Physics_CreateWorld;
        // g_pPhysicsSystem_DestroyWorld: Index 1465
        native[1465] = (void*)(delegate* unmanaged<void*, void>)&Physics_DestroyWorld;
        // IPhysicsWorld_SetWorldReferenceBody: Index 2019
        native[2019] = (void*)(delegate* unmanaged<void*, void*, void>)&Physics_SetWorldReferenceBody;
        // IPhysicsWorld_GetGravity: Index 2022
        native[2022] = (void*)(delegate* unmanaged<void*, Vector3>)&Physics_GetGravity;
        // IPhysicsWorld_SetDebugScene: Index 2041
        native[2041] = (void*)(delegate* unmanaged<void*, void*, void>)&Physics_SetDebugScene;
        // IPhysicsWorld_GetDebugScene: Index 2042
        native[2042] = (void*)(delegate* unmanaged<void*, int>)&Physics_GetDebugScene;
        // IPhysicsWorld_AddBody: Index 2043
        native[2043] = (void*)(delegate* unmanaged<void*, int>)&Physics_AddBody;
        // IPhysicsWorld_Step: Index 2044
        native[2044] = (void*)(delegate* unmanaged<void*, float, void>)&Physics_Step;
    

        _isReady = true;
    }

    [UnmanagedCallersOnly(EntryPoint = "Debug_Error")]
    public static void DebugError(IntPtr message)
    {
        string? msg = Marshal.PtrToStringUTF8(message);
        Console.WriteLine($"[NativeAOT ERROR] {msg}");
    }

    [UnmanagedCallersOnly]
    public static void* CMtrlSystm2ppSys_Create(void* createInfo)
    {
        Console.WriteLine("[NativeAOT] CMtrlSystm2ppSys_Create");
        return (void*)1; // Return a dummy non-null pointer
    }

    [UnmanagedCallersOnly]
    public static int CMtrlSystm2ppSys_Init(void* self)
    {
        Console.WriteLine("[NativeAOT] CMtrlSystm2ppSys_Init");
        return 1; // Success
    }

    [UnmanagedCallersOnly]
    public static void* CMtrlSystm2ppSys_GetAppWindow(void* self)
    {
        Console.WriteLine("[NativeAOT] CMtrlSystm2ppSys_GetAppWindow");
        return (void*)_windowHandle;
    }

    [UnmanagedCallersOnly]
    public static void* FindOrCreateTexture2(void* pResourceName, int bIsAnonymous, void* pDescriptor, void* data, int dataSize)
    {
        if (_gl == null) return null;
        var gl = _gl;

        var desc = (TextureCreationConfig_t*)pDescriptor;

        if (desc->m_nWidth <= 0)
            desc->m_nWidth = 1;

        if (desc->m_nHeight <= 0)
            desc->m_nHeight = 1;

        if (desc->m_nDepth <= 0)
            desc->m_nDepth = 1;

        if (desc->m_nNumMipLevels <= 0)
            desc->m_nNumMipLevels = 1;

        if (desc->m_nImageFormat == ImageFormat.None)
            desc->m_nImageFormat = ImageFormat.RGBA8888;

        desc->m_nDisplayRectWidth = desc->m_nWidth;
        desc->m_nDisplayRectHeight = desc->m_nHeight;

        uint tex;
        gl.GenTextures(1, out tex);
        gl.BindTexture(GLEnum.Texture2D, tex);

        gl.TexParameter(GLEnum.Texture2D, GLEnum.TextureMinFilter, (int)GLEnum.Linear);
        gl.TexParameter(GLEnum.Texture2D, GLEnum.TextureMagFilter, (int)GLEnum.Linear);
        gl.TexParameter(GLEnum.Texture2D, GLEnum.TextureWrapS, (int)GLEnum.ClampToEdge);
        gl.TexParameter(GLEnum.Texture2D, GLEnum.TextureWrapT, (int)GLEnum.ClampToEdge);

        gl.TexImage2D(
            GLEnum.Texture2D,
            0,
            (int)GLEnum.Rgba8,
            (uint)desc->m_nWidth,
            (uint)desc->m_nHeight,
            0,
            GLEnum.Rgba,
            GLEnum.UnsignedByte,
            data
        );
        return (void*)tex;
    }

    [UnmanagedCallersOnly]
    public static void* Plat_MessageBox(void* title, void* message)
    {
        string? t = Marshal.PtrToStringUTF8((IntPtr)title);
        string? m = Marshal.PtrToStringUTF8((IntPtr)message);
        Console.WriteLine($"[NativeAOT MESSAGEBOX] {t}: {m}");
        return null;
    }

    [UnmanagedCallersOnly]
    public static void* Plat_SetCurrentFrame(ulong frame)
    {
        // Console.WriteLine($"[NativeAOT] Plat_SetCurrentFrame({frame})");
        return null;
    }

    [UnmanagedCallersOnly]
    public static void* GetGameRootFolder()
    {
        string cwd = Directory.GetCurrentDirectory();
        Console.WriteLine($"[NativeAOT] GetGameRootFolder: {cwd}");
        return (void*)Marshal.StringToHGlobalAnsi(cwd); // Leak memory for now
    }

    [UnmanagedCallersOnly]
    public static int SourceEnginePreInit(void* lpCmdLine, void* appDict)
    {
        Console.WriteLine("[NativeAOT] SourceEnginePreInit");
        return 1; // Success
    }

    // Internal helper that can be called directly
    private static void* CreateAppWindowInternal(string title, int w, int h)
    {
        Console.WriteLine($"[NativeAOT] Creating Window (GLFW): {title} ({w}x{h})");

        try
        {
            _glfw = Glfw.GetApi();
            if (!_glfw.Init())
            {
                Console.WriteLine("[NativeAOT] GLFW Init failed!");
                return null;
            }

            _glfw.WindowHint(WindowHintClientApi.ClientApi, ClientApi.OpenGL);
            _glfw.WindowHint(WindowHintInt.ContextVersionMajor, 3);
            _glfw.WindowHint(WindowHintInt.ContextVersionMinor, 3);
            _glfw.WindowHint(WindowHintOpenGlProfile.OpenGlProfile, OpenGlProfile.Core);

            _windowHandle = _glfw.CreateWindow(w > 0 ? w : 1280, h > 0 ? h : 720, title, null, null);
            
            if (_windowHandle == null)
            {
                Console.WriteLine("[NativeAOT] GLFW CreateWindow failed!");
                // Try to get error
                byte* errorDesc;
                var errorCode = _glfw.GetError(out errorDesc);
                string? errorStr = Marshal.PtrToStringUTF8((IntPtr)errorDesc);
                Console.WriteLine($"[NativeAOT] GLFW Error: {errorCode} - {errorStr}");
                return null;
            }

            _glfw.MakeContextCurrent(_windowHandle);
            
            // Initialize GL
            _gl = GL.GetApi(new GlfwContext(_glfw, _windowHandle));

            Console.WriteLine($"[NativeAOT] Window Initialized (Handle: {(long)_windowHandle:X})");
            return (void*)_windowHandle;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[NativeAOT] Exception in CreateAppWindowInternal: {ex}");
            return null;
        }
    }

    [UnmanagedCallersOnly]
    public static void* CreateAppWindow(void* self, void* pTitle, int nPlatWindowFlags, int x, int y, int w, int h, int nRefreshRateHz)
    {
        string title = Marshal.PtrToStringUTF8((IntPtr)pTitle) ?? "S&box NativeAOT";
        return CreateAppWindowInternal(title, w, h);
    }

    [UnmanagedCallersOnly]
    public static void* GetEngineSwapChainSize( void* w, void* h )
    {
        if (_windowHandle == null || _glfw == null)
            return null;

        int width, height;
        _glfw.GetFramebufferSize(_windowHandle, out width, out height);

        *(int*)w = width;
        *(int*)h = height;

        return null;
    }

    [UnmanagedCallersOnly]
    public static int SourceEngineInit(void* appDict)
    {
        Console.WriteLine("[NativeAOT] SourceEngineInit - Forcing Window Creation");
        
        // Force create window
        CreateAppWindowInternal("S&box NativeAOT", 1280, 720);
        
        return 1; // Success
    }

    [UnmanagedCallersOnly]
    public static int SourceEngineFrame(void* appDict, double currentTime, double previousTime)
    {
        if (_windowHandle == null || _glfw == null) return 0;

        _glfw.PollEvents();
        
        if (_glfw.WindowShouldClose(_windowHandle)) return 0;

        // Render loop would go here
        // _gl.Clear((uint)ClearBufferMask.ColorBufferBit);
        
        _glfw.SwapBuffers(_windowHandle);
        
        return 1;
    }

    [UnmanagedCallersOnly]
    public static void* UpdateWindowSize()
    {
        Console.WriteLine("[NativeAOT] UpdateWindowSize");
        return null;
    }

    // Physics Stubs
    [UnmanagedCallersOnly]
    public static int Physics_CreateWorld()
    {
        Console.WriteLine("[NativeAOT] Physics_CreateWorld (Bepu)");
        var world = new BepuPhysicsWorld();
        int handle = HandleManager.Register(world);
        return handle;
    }

    [UnmanagedCallersOnly]
    public static void Physics_DestroyWorld(void* worldPtr)
    {
        int handle = (int)(long)worldPtr;
        var world = HandleManager.Get<BepuPhysicsWorld>(handle);
        world?.Dispose();
        HandleManager.Unregister(handle);
        Console.WriteLine("[NativeAOT] Physics_DestroyWorld (Bepu) handle=" + handle);
    }

    [UnmanagedCallersOnly]
    public static void Physics_SetWorldReferenceBody(void* world, void* body)
    {
        // Console.WriteLine("[NativeAOT] Physics_SetWorldReferenceBody");
    }

    [UnmanagedCallersOnly]
    public static Vector3 Physics_GetGravity(void* worldPtr)
    {
        int handle = (int)(long)worldPtr;
        var world = HandleManager.Get<BepuPhysicsWorld>(handle);
        return world?.Gravity ?? new Vector3(0, 0, -800);
    }

    private static readonly Dictionary<int, IntPtr> _debugScenes = new();

    [UnmanagedCallersOnly]
    public static void Physics_SetDebugScene(void* worldPtr, void* scenePtr)
    {
        int handle = (int)(long)worldPtr;
        IntPtr scene = (IntPtr)scenePtr;
        _debugScenes[handle] = scene;
        Console.WriteLine($"[NativeAOT] Physics_SetDebugScene: world={handle} scene=0x{scene.ToInt64():X}");
    }

    [UnmanagedCallersOnly]
    public static int Physics_GetDebugScene(void* worldPtr)
    {
        int handle = (int)(long)worldPtr;
        if (_debugScenes.TryGetValue(handle, out var scene))
            return (int)scene;
        return 0;
    }

    // IPhysicsBody Stubs
    [UnmanagedCallersOnly]
    public static Vector3 IPhysicsBody_GetPosition(void* bodyPtr)
    {
        int handle = (int)(long)bodyPtr;
        var body = HandleManager.Get<BepuPhysicsBody>(handle);
        return body?.GetPosition() ?? Vector3.Zero;
    }

    [UnmanagedCallersOnly]
    public static void IPhysicsBody_SetPosition(void* bodyPtr, Vector3 pos)
    {
        int handle = (int)(long)bodyPtr;
        var body = HandleManager.Get<BepuPhysicsBody>(handle);
        body?.SetPosition(pos);
    }

    [UnmanagedCallersOnly]
    public static System.Numerics.Quaternion IPhysicsBody_GetOrientation(void* bodyPtr)
    {
        int handle = (int)(long)bodyPtr;
        var body = HandleManager.Get<BepuPhysicsBody>(handle);
        return body != null ? body.GetOrientation() : new System.Numerics.Quaternion(0,0,0,1);
    }

    [UnmanagedCallersOnly]
    public static void IPhysicsBody_SetOrientation(void* bodyPtr, System.Numerics.Quaternion orientation)
    {
        int handle = (int)(long)bodyPtr;
        var body = HandleManager.Get<BepuPhysicsBody>(handle);
        body?.SetOrientation(orientation);
    }

    [UnmanagedCallersOnly]
    public static Vector3 IPhysicsBody_GetLinearVelocity(void* bodyPtr)
    {
        int handle = (int)(long)bodyPtr;
        var body = HandleManager.Get<BepuPhysicsBody>(handle);
        return body?.GetLinearVelocity() ?? Vector3.Zero;
    }

    [UnmanagedCallersOnly]
    public static void IPhysicsBody_SetLinearVelocity(void* bodyPtr, Vector3 velocity)
    {
        int handle = (int)(long)bodyPtr;
        var body = HandleManager.Get<BepuPhysicsBody>(handle);
        body?.SetLinearVelocity(velocity);
    }

    [UnmanagedCallersOnly]
    public static Vector3 IPhysicsBody_GetAngularVelocity(void* bodyPtr)
    {
        int handle = (int)(long)bodyPtr;
        var body = HandleManager.Get<BepuPhysicsBody>(handle);
        return body?.GetAngularVelocity() ?? Vector3.Zero;
    }

    [UnmanagedCallersOnly]
    public static void IPhysicsBody_SetAngularVelocity(void* bodyPtr, Vector3 velocity)
    {
        int handle = (int)(long)bodyPtr;
        var body = HandleManager.Get<BepuPhysicsBody>(handle);
        body?.SetAngularVelocity(velocity);
    }

    [UnmanagedCallersOnly]
    public static float IPhysicsBody_GetMass(void* bodyPtr)
    {
        int handle = (int)(long)bodyPtr;
        var body = HandleManager.Get<BepuPhysicsBody>(handle);
        return body?.GetMass() ?? 0f;
    }

    [UnmanagedCallersOnly]
    public static void IPhysicsBody_SetMass(void* bodyPtr, float mass)
    {
        int handle = (int)(long)bodyPtr;
        var body = HandleManager.Get<BepuPhysicsBody>(handle);
        body?.SetMass(mass);
    }

    [UnmanagedCallersOnly]
    public static void IPhysicsBody_Enable(void* bodyPtr)
    {
        int handle = (int)(long)bodyPtr;
        var body = HandleManager.Get<BepuPhysicsBody>(handle);
        body?.Enable();
    }

    [UnmanagedCallersOnly]
    public static void IPhysicsBody_Disable(void* bodyPtr)
    {
        int handle = (int)(long)bodyPtr;
        var body = HandleManager.Get<BepuPhysicsBody>(handle);
        body?.Disable();
    }

    [UnmanagedCallersOnly]
    public static int Physics_AddBody(void* worldPtr)
    {
        int handle = (int)(long)worldPtr;
        var world = HandleManager.Get<BepuPhysicsWorld>(handle);
        if (world == null) return 0;
        var bodyHandle = world.AddBody();
        var body = new BepuPhysicsBody(world, bodyHandle);
        int bodyId = HandleManager.Register(body);
        return bodyId;
    }

    [UnmanagedCallersOnly]
    public static void Physics_Step(void* worldPtr, float dt)
    {
        int handle = (int)(long)worldPtr;
        var world = HandleManager.Get<BepuPhysicsWorld>(handle);
        world?.Step(dt);
    }
}
