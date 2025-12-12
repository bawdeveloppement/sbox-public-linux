using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Sandbox;
using Bawstudios.OS27.Common;
using Bawstudios.OS27.RenderAttributes;
using Bawstudios.OS27;
using Silk.NET.GLFW;
using Silk.NET.OpenGL;

namespace Bawstudios.OS27.Material;

/// <summary>
/// Emulation module for MaterialSystem2 and IMaterial2.
/// Handles creation and management of materials.
/// </summary>
public static unsafe class MaterialSystem
{
    // Logging switches
    private static bool LogMinimal = true; // active for key calls
    private static bool LogAll = true;    // force logging for every call

    private static void LogCall(string name, bool minimal, string message = "")
    {
        if (!(LogAll || (LogMinimal && minimal))) return;
        Console.WriteLine($"[NativeAOT][Mat] {name} {message}");
    }

    private static string? TryFindCompiledShaderPath(string? shader)
    {
        if (string.IsNullOrWhiteSpace(shader))
            return null;

        string normalized = shader.Replace('\\', Path.DirectorySeparatorChar).Replace('/', Path.DirectorySeparatorChar);
        string relCandidate = Path.ChangeExtension(normalized, ".shader_c");
        var candidates = new List<string>
        {
            Path.GetFullPath(relCandidate, Directory.GetCurrentDirectory()),
            Path.Combine(Directory.GetCurrentDirectory(), "game", relCandidate),
            Path.Combine(Directory.GetCurrentDirectory(), Path.GetFileName(relCandidate))
        };

        foreach (var candidate in candidates)
        {
            if (!string.IsNullOrEmpty(candidate) && File.Exists(candidate))
                return candidate;
        }

        try
        {
            string fileName = Path.GetFileName(relCandidate);
            if (!string.IsNullOrEmpty(fileName))
            {
                foreach (var path in Directory.EnumerateFiles(Directory.GetCurrentDirectory(), fileName, SearchOption.AllDirectories))
                {
                    return path;
                }
            }
        }
        catch
        {
            // swallow and return null
        }

        return null;
    }
    /// <summary>
    /// Internal data for an emulated material.
    /// </summary>
    private class MaterialData
    {
        public string Name { get; set; } = "";
        public string Shader { get; set; } = "";
        public bool Anonymous { get; set; }
        public IntPtr RenderAttributes { get; set; } = IntPtr.Zero;
        public bool IsError { get; set; } = false;
        public bool IsLoaded { get; set; } = true; // By default, considered loaded
        public bool IsEdited { get; set; } = false;
        public ulong SimilarityKey { get; set; } = 0;
        public Dictionary<string, object> Parameters { get; } = new(); // Stocke les paramètres du matériau
        public IntPtr BindingPtr { get; set; } = IntPtr.Zero; // Unique binding pointer
        public IntPtr MaterialMode { get; set; } = IntPtr.Zero; // Material rendering mode
        public string? CompiledShaderPath { get; set; }
        public byte[]? CompiledShaderBytes { get; set; }
    }
    
    /// <summary>
    /// Initialise les fonctions natives de MaterialSystem2 et IMaterial2.
    /// </summary>
    public static void Init(void** native)
    {
        // CMtrlSystm2ppSys functions (indices 498-540)
        native[498] = (void*)(delegate* unmanaged<NativeEngine.MaterialSystem2AppSystemDictCreateInfo*, IntPtr>)&CMtrlSystm2ppSys_Create;
        native[499] = (void*)(delegate* unmanaged<IntPtr, void>)&CMtrlSystm2ppSys_Destroy;
        native[500] = (void*)(delegate* unmanaged<IntPtr, int>)&CMtrlSystm2ppSys_Init;
        native[501] = (void*)(delegate* unmanaged<IntPtr, int>)&CMtrlSystm2ppSys_InitWithoutMaterialSystem;
        native[503] = (void*)(delegate* unmanaged<IntPtr, IntPtr>)&CMtrlSystm2ppSys_GetAppWindow;
        native[504] = (void*)(delegate* unmanaged<IntPtr, IntPtr>)&CMtrlSystm2ppSys_GetAppWindowSwapChain;
        native[505] = (void*)(delegate* unmanaged<IntPtr, IntPtr, void>)&CMtrlSystm2ppSys_SetAppWindowTitle;
        native[506] = (void*)(delegate* unmanaged<IntPtr, IntPtr, void>)&CMtrlSystm2ppSys_SetAppWindowIcon;
        native[507] = (void*)(delegate* unmanaged<IntPtr, IntPtr, void>)&CMtrlSystm2ppSys_SetInitialAppWindowImage;
        native[508] = (void*)(delegate* unmanaged<IntPtr, int, void>)&CMtrlSystm2ppSys_SetAppWindowDiscardMouseFocusClick;
        native[509] = (void*)(delegate* unmanaged<IntPtr, void>)&CMtrlSystm2ppSys_DrawInitialWindowImage;
        native[511] = (void*)(delegate* unmanaged<IntPtr, IntPtr, void>)&CMtrlSystm2ppSys_SetModuleSearchPath;
        native[512] = (void*)(delegate* unmanaged<IntPtr, IntPtr, void>)&CMtrlSystm2ppSys_SetModGameSubdir;
        native[513] = (void*)(delegate* unmanaged<IntPtr, IntPtr, int, void>)&CMtrlSystm2ppSys_SetModFromFileName;
        native[514] = (void*)(delegate* unmanaged<IntPtr, void>)&CMtrlSystm2ppSys_DisableModPathCheck;
        native[515] = (void*)(delegate* unmanaged<IntPtr, IntPtr, void>)&CMtrlSystm2ppSys_SetDefaultRenderSystemOption;
        native[516] = (void*)(delegate* unmanaged<IntPtr, int, void>)&CMtrlSystm2ppSys_SetInitializationPhase;
        native[502] = (void*)(delegate* unmanaged<IntPtr, int>)&CMtrlSystm2ppSys_InitFinishSetupMaterialSystem;
        native[510] = (void*)(delegate* unmanaged<IntPtr, int, void>)&CMtrlSystm2ppSys_SuppressStartupManifestLoad;
        native[532] = (void*)(delegate* unmanaged<IntPtr, void>)&CMtrlSystm2ppSys_SuppressCOMInitialization;
        native[521] = (void*)(delegate* unmanaged<IntPtr, int>)&CMtrlSystm2ppSys_IsConsoleApp;
        native[522] = (void*)(delegate* unmanaged<IntPtr, int>)&CMtrlSystm2ppSys_IsGameApp;
        native[523] = (void*)(delegate* unmanaged<IntPtr, int, void>)&CMtrlSystm2ppSys_SetDedicatedServer;
        native[524] = (void*)(delegate* unmanaged<IntPtr, int>)&CMtrlSystm2ppSys_IsDedicatedServer;
        native[525] = (void*)(delegate* unmanaged<IntPtr, IntPtr>)&CMtrlSystm2ppSys_GetContentPath;
        native[526] = (void*)(delegate* unmanaged<IntPtr, IntPtr>)&CMtrlSystm2ppSys_GetModGameSubdir;
        native[528] = (void*)(delegate* unmanaged<IntPtr, int>)&CMtrlSystm2ppSys_IsInToolsMode;
        native[529] = (void*)(delegate* unmanaged<IntPtr, int>)&CMtrlSystm2ppSys_IsInDeveloperMode;
        native[530] = (void*)(delegate* unmanaged<IntPtr, int>)&CMtrlSystm2ppSys_IsInVRMode;
        native[533] = (void*)(delegate* unmanaged<IntPtr, int>)&CMtrlSystm2ppSys_IsRunningOnCustomerMachine;
        native[536] = (void*)(delegate* unmanaged<IntPtr, int>)&CMtrlSystm2ppSys_IsInTestMode;
        native[517] = (void*)(delegate* unmanaged<IntPtr, int>)&CMtrlSystm2ppSys_GetInitializationPhase;
        native[518] = (void*)(delegate* unmanaged<IntPtr, void>)&CMtrlSystm2ppSys_PreShutdown;
        native[519] = (void*)(delegate* unmanaged<IntPtr, uint, int>)&CMtrlSystm2ppSys_InitSDL;
        native[520] = (void*)(delegate* unmanaged<IntPtr, void>)&CMtrlSystm2ppSys_ShutdownSDL;
        native[531] = (void*)(delegate* unmanaged<IntPtr, IntPtr, int, int, int, int, int, int, IntPtr>)&CMtrlSystm2ppSys_CreateAppWindow;
        native[534] = (void*)(delegate* unmanaged<IntPtr, IntPtr, IntPtr, IntPtr>)&CMtrlSystm2ppSys_AddSystem;
        native[537] = (void*)(delegate* unmanaged<IntPtr, void>)&CMtrlSystm2ppSys_SetInStandaloneApp;
        native[538] = (void*)(delegate* unmanaged<IntPtr, int>)&CMtrlSystm2ppSys_IsStandaloneApp;
        native[535] = (void*)(delegate* unmanaged<IntPtr, void>)&CMtrlSystm2ppSys_SetInTestMode;
        native[527] = (void*)(delegate* unmanaged<IntPtr, void>)&CMtrlSystm2ppSys_SetInToolsMode;
        native[539] = (void*)(delegate* unmanaged<IntPtr, uint, void>)&CMtrlSystm2ppSys_SetSteamAppId;
        native[540] = (void*)(delegate* unmanaged<IntPtr, uint>)&CMtrlSystm2ppSys_GetSteamAppId;
        
        // g_pMtrlSystm2 functions (indices 1457-1460)
        native[1457] = (void*)(delegate* unmanaged<IntPtr, IntPtr, int, IntPtr>)&g_pMtrlSystm2_CreateRawMaterial;
        native[1458] = (void*)(delegate* unmanaged<IntPtr, int, int, IntPtr>)&g_pMtrlSystm2_CreateProceduralMaterialCopy;
        native[1459] = (void*)(delegate* unmanaged<IntPtr, IntPtr>)&g_pMtrlSystm2_FindOrCreateMaterialFromResource;
        native[1460] = (void*)(delegate* unmanaged<void>)&g_pMtrlSystm2_FrameUpdate;
        
        // IMaterial2 functions (indices depuis Interop.Engine.cs lignes 16654-16683)
        native[1789] = (void*)(delegate* unmanaged<IntPtr, void>)&IMaterial2_DestroyStrongHandle;
        native[1790] = (void*)(delegate* unmanaged<IntPtr, int>)&IMaterial2_IsStrongHandleValid;
        native[1791] = (void*)(delegate* unmanaged<IntPtr, int>)&IMaterial2_IsError;
        native[1792] = (void*)(delegate* unmanaged<IntPtr, int>)&IMaterial2_IsStrongHandleLoaded;
        native[1793] = (void*)(delegate* unmanaged<IntPtr, IntPtr>)&IMaterial2_CopyStrongHandle;
        native[1794] = (void*)(delegate* unmanaged<IntPtr, IntPtr>)&IMaterial2_GetBindingPtr;
        native[1795] = (void*)(delegate* unmanaged<IntPtr, IntPtr>)&IMaterial2_GetName;
        native[1796] = (void*)(delegate* unmanaged<IntPtr, IntPtr>)&IMaterial2_GetNameWithMod;
        native[1797] = (void*)(delegate* unmanaged<IntPtr, ulong>)&IMaterial2_GetSimilarityKey;
        native[1798] = (void*)(delegate* unmanaged<IntPtr, int>)&IMaterial2_IsLoaded;
        native[1799] = (void*)(delegate* unmanaged<IntPtr, Sandbox.StringToken, IntPtr>)&IMaterial2_GetMode;
        native[1800] = (void*)(delegate* unmanaged<IntPtr, IntPtr>)&IMaterial2_GetMode_1;
        native[1801] = (void*)(delegate* unmanaged<IntPtr, IntPtr, IntPtr>)&IMaterial2_GetMode_2;
        native[1802] = (void*)(delegate* unmanaged<IntPtr, IntPtr>)&IMaterial2_GetRenderAttributes;
        native[1803] = (void*)(delegate* unmanaged<IntPtr, void>)&IMaterial2_RecreateAllStaticConstantAndCommandBuffers;
        native[1804] = (void*)(delegate* unmanaged<IntPtr, IntPtr>)&IMaterial2_GetFirstTextureAttribute;
        native[1805] = (void*)(delegate* unmanaged<IntPtr, Sandbox.StringToken, int, int>)&IMaterial2_GetBoolAttributeOrDefault;
        native[1806] = (void*)(delegate* unmanaged<IntPtr, Sandbox.StringToken, int, int>)&IMaterial2_GetIntAttributeOrDefault;
        native[1807] = (void*)(delegate* unmanaged<IntPtr, Sandbox.StringToken, float, float>)&IMaterial2_GetFloatAttributeOrDefault;
        native[1808] = (void*)(delegate* unmanaged<IntPtr, Sandbox.StringToken, IntPtr>)&IMaterial2_GetTextureAttributeOrDefault;
        native[1809] = (void*)(delegate* unmanaged<IntPtr, IntPtr, int>)&IMaterial2_HasParam;
        native[1810] = (void*)(delegate* unmanaged<IntPtr, IntPtr, IntPtr, void>)&IMaterial2_Set;
        native[1811] = (void*)(delegate* unmanaged<IntPtr, IntPtr, IntPtr, IntPtr>)&IMaterial2_GetString;
        native[1812] = (void*)(delegate* unmanaged<IntPtr, IntPtr, Vector4*, void>)&IMaterial2_Set_1;
        native[1813] = (void*)(delegate* unmanaged<IntPtr, IntPtr, Vector4>)&IMaterial2_GetVector4;
        native[1814] = (void*)(delegate* unmanaged<IntPtr, IntPtr, IntPtr, void>)&IMaterial2_Set_2;
        native[1815] = (void*)(delegate* unmanaged<IntPtr, IntPtr, IntPtr>)&IMaterial2_GetTexture;
        native[1816] = (void*)(delegate* unmanaged<IntPtr, int, void>)&IMaterial2_SetEdited;
        native[1817] = (void*)(delegate* unmanaged<IntPtr, int>)&IMaterial2_IsEdited;
        native[1818] = (void*)(delegate* unmanaged<IntPtr, void>)&IMaterial2_ReloadStaticCombos;
    }
    
    // ========== CMtrlSystm2ppSys Functions ==========
    
    /// <summary>
    /// Creates a new MaterialSystem2AppSystemDict.
    /// </summary>
    [UnmanagedCallersOnly]
    public static IntPtr CMtrlSystm2ppSys_Create(NativeEngine.MaterialSystem2AppSystemDictCreateInfo* createInfo)
    {
        LogCall(nameof(CMtrlSystm2ppSys_Create), minimal: true, message: $"createInfo=0x{((IntPtr)createInfo).ToInt64():X}");
        return (IntPtr)1; // Return a dummy non-null pointer
    }
    
    /// <summary>
    /// Destroys the MaterialSystem2AppSystemDict.
    /// </summary>
    [UnmanagedCallersOnly]
    public static void CMtrlSystm2ppSys_Destroy(IntPtr self)
    {
        LogCall(nameof(CMtrlSystm2ppSys_Destroy), minimal: true, message: $"self=0x{self.ToInt64():X}");
        // Cleanup if needed
    }
    
    /// <summary>
    /// Initializes the MaterialSystem2AppSystemDict.
    /// </summary>
    [UnmanagedCallersOnly]
    public static int CMtrlSystm2ppSys_Init(IntPtr self)
    {
        LogCall(nameof(CMtrlSystm2ppSys_Init), minimal: true, message: $"self=0x{self.ToInt64():X}");
        return 1; // Success
    }
    
    // Référence à la fenêtre (sera initialisée depuis EngineExports ou PlatformFunctions)
    private static WindowHandle* _windowHandle = null;
    private static Glfw? _glfw;
    private static GL? _gl;
    
    /// <summary>
    /// Initializes the window reference (called from EngineExports or PlatformFunctions).
    /// </summary>
    internal static void SetWindowHandle(WindowHandle* handle)
    {
        _windowHandle = handle;
    }
    
    /// <summary>
    /// Obtient la fenêtre de l'application.
    /// </summary>
    [UnmanagedCallersOnly]
    public static IntPtr CMtrlSystm2ppSys_GetAppWindow(IntPtr self)
    {
        LogCall(nameof(CMtrlSystm2ppSys_GetAppWindow), minimal: true, message: $"self=0x{self.ToInt64():X}");
        if (_windowHandle == null)
            return IntPtr.Zero;
        return (IntPtr)_windowHandle;
    }
    
    /// <summary>
    /// Gets the application window SwapChain.
    /// </summary>
    [UnmanagedCallersOnly]
    public static IntPtr CMtrlSystm2ppSys_GetAppWindowSwapChain(IntPtr self)
    {
        LogCall(nameof(CMtrlSystm2ppSys_GetAppWindowSwapChain), minimal: true, message: $"self=0x{self.ToInt64():X}");
        if (_windowHandle == null)
            return IntPtr.Zero;
        // Return window handle as SwapChain (GLFW window handle serves as SwapChain)
        return (IntPtr)_windowHandle;
    }
    
    /// <summary>
    /// Creates an application window.
    /// Signature from Interop.Engine.cs line 15278: delegate* unmanaged&lt; IntPtr, IntPtr, int, int, int, int, int, int, IntPtr &gt;
    /// Parameters: self, pTitle, nPlatWindowFlags, x, y, w, h, nRefreshRateHz, icon
    /// Uses GLFW/GL instances from PlatformFunctions (shared).
    /// </summary>
    [UnmanagedCallersOnly]
    public static IntPtr CMtrlSystm2ppSys_CreateAppWindow(IntPtr self, IntPtr pTitle, int nPlatWindowFlags, int x, int y, int w, int h, int nRefreshRateHz)
    {
        string? title = Marshal.PtrToStringUTF8(pTitle) ?? "S&box NativeAOT";
        Console.WriteLine($"[NativeAOT] CMtrlSystm2ppSys_CreateAppWindow: {title} ({w}x{h})");

        try
        {
            // Use PlatformFunctions instances (shared)
            var glfw = Platform.PlatformFunctions.GetGlfw();
            var existingWindowHandle = Platform.PlatformFunctions.GetWindowHandle();
            
            // If a window already exists (created in SourceEngineInit), reuse it
            if (existingWindowHandle != null && glfw != null)
            {
                Console.WriteLine("[NativeAOT] CMtrlSystm2ppSys_CreateAppWindow: Reusing existing window");
                _windowHandle = existingWindowHandle;
                SetWindowHandle(_windowHandle);
                return (IntPtr)_windowHandle;
            }
            
            // Otherwise, create a new window (normally shouldn't happen as SourceEngineInit already creates a window)
            if (glfw == null)
            {
                glfw = Glfw.GetApi();
                if (!glfw.Init())
                {
                    Console.WriteLine("[NativeAOT] CMtrlSystm2ppSys_CreateAppWindow: GLFW Init failed!");
                    return IntPtr.Zero;
                }
                Platform.PlatformFunctions.SetSharedState(glfw, null, null);
            }

            glfw.WindowHint(WindowHintClientApi.ClientApi, ClientApi.OpenGL);
            glfw.WindowHint(WindowHintInt.ContextVersionMajor, 3);
            glfw.WindowHint(WindowHintInt.ContextVersionMinor, 3);
            glfw.WindowHint(WindowHintOpenGlProfile.OpenGlProfile, OpenGlProfile.Core);

            _windowHandle = glfw.CreateWindow(w > 0 ? w : 1280, h > 0 ? h : 720, title, null, null);

            if (_windowHandle == null)
            {
                Console.WriteLine("[NativeAOT] CMtrlSystm2ppSys_CreateAppWindow: GLFW CreateWindow failed!");
                byte* errorDesc;
                var errorCode = glfw.GetError(out errorDesc);
                string? errorStr = Marshal.PtrToStringUTF8((IntPtr)errorDesc);
                Console.WriteLine($"[NativeAOT] GLFW Error: {errorCode} - {errorStr}");
                return IntPtr.Zero;
            }

            glfw.MakeContextCurrent(_windowHandle);

            // Initialize GL if not already done
            var gl = Platform.PlatformFunctions.GetGL();
            if (gl == null)
            {
                gl = GL.GetApi(new GlfwContext(glfw, _windowHandle));
                Platform.PlatformFunctions.SetSharedState(glfw, _windowHandle, gl);
            }

            SetWindowHandle(_windowHandle);
            Console.WriteLine($"[NativeAOT] CMtrlSystm2ppSys_CreateAppWindow: Window Initialized (Handle: {(long)_windowHandle:X})");
            return (IntPtr)_windowHandle;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[NativeAOT] Exception in CMtrlSystm2ppSys_CreateAppWindow: {ex}");
            return IntPtr.Zero;
        }
    }
    
    /// <summary>
    /// Sets the application window title.
    /// </summary>
    [UnmanagedCallersOnly]
    public static void CMtrlSystm2ppSys_SetAppWindowTitle(IntPtr self, IntPtr titlePtr)
    {
        if (_windowHandle == null || titlePtr == IntPtr.Zero) return;
        
        string? title = Marshal.PtrToStringUTF8(titlePtr);
        if (!string.IsNullOrEmpty(title) && _glfw != null)
        {
            _glfw.SetWindowTitle(_windowHandle, title);
            Console.WriteLine($"[NativeAOT] CMtrlSystm2ppSys_SetAppWindowTitle: {title}");
        }
    }
    
    // Cache for GetContentPath (avoids repeated allocations)
    private static IntPtr? _cachedContentPath = null;
    
    /// <summary>
    /// Obtient le chemin du contenu du jeu.
    /// </summary>
    [UnmanagedCallersOnly]
    public static IntPtr CMtrlSystm2ppSys_GetContentPath(IntPtr self)
    {
        if (_cachedContentPath == null)
        {
            string contentPath = Directory.GetCurrentDirectory();
            _cachedContentPath = Marshal.StringToHGlobalAnsi(contentPath);
        }
        return _cachedContentPath.Value;
    }
    
    // MaterialSystem state
    private static string? _modGameSubdir = null;
    private static string? _moduleSearchPath = null;
    private static string? _defaultRenderSystemOption = null;
    private static bool _isInTestMode = false;
    private static bool _isInToolsMode = false;
    private static bool _isDedicatedServer = false;
    private static bool _isConsoleApp = false;
    private static bool _isGameApp = true; // By default, it's a game app
    private static bool _isInDeveloperMode = false;
    private static bool _isInVRMode = false;
    private static bool _isRunningOnCustomerMachine = true; // By default, assume it's a client machine
    private static bool _isStandaloneApp = false;
    private static bool _modPathCheckDisabled = false;
    private static bool _appWindowDiscardMouseFocusClick = false;
    private static int _initializationPhase = 0;
    private static bool _suppressCOMInitialization = false;
    private static bool _suppressStartupManifestLoad = false;
    private static uint _steamAppId = 0;
    private static bool _sdlInitialized = false;
    
    /// <summary>
    /// Définit le sous-répertoire du mod (ex: "core").
    /// </summary>
    [UnmanagedCallersOnly]
    public static void CMtrlSystm2ppSys_SetModGameSubdir(IntPtr self, IntPtr subdirPtr)
    {
        if (subdirPtr == IntPtr.Zero) return;
        
        _modGameSubdir = Marshal.PtrToStringUTF8(subdirPtr);
        Console.WriteLine($"[NativeAOT] CMtrlSystm2ppSys_SetModGameSubdir: {_modGameSubdir}");
    }
    
    /// <summary>
    /// Finalizes MaterialSystem configuration after initialization.
    /// </summary>
    [UnmanagedCallersOnly]
    public static int CMtrlSystm2ppSys_InitFinishSetupMaterialSystem(IntPtr self)
    {
        Console.WriteLine("[NativeAOT] CMtrlSystm2ppSys_InitFinishSetupMaterialSystem");
        return 1; // Success
    }
    
    /// <summary>
    /// Suppresses startup manifest loading.
    /// </summary>
    [UnmanagedCallersOnly]
    public static void CMtrlSystm2ppSys_SuppressStartupManifestLoad(IntPtr self, int suppress)
    {
        _suppressStartupManifestLoad = suppress != 0;
        Console.WriteLine($"[NativeAOT] CMtrlSystm2ppSys_SuppressStartupManifestLoad: {_suppressStartupManifestLoad}");
    }
    
    /// <summary>
    /// Supprime l'initialisation COM.
    /// </summary>
    [UnmanagedCallersOnly]
    public static void CMtrlSystm2ppSys_SuppressCOMInitialization(IntPtr self)
    {
        _suppressCOMInitialization = true;
        Console.WriteLine("[NativeAOT] CMtrlSystm2ppSys_SuppressCOMInitialization");
    }
    
    /// <summary>
    /// Enables test mode.
    /// </summary>
    [UnmanagedCallersOnly]
    public static void CMtrlSystm2ppSys_SetInTestMode(IntPtr self)
    {
        _isInTestMode = true;
        Console.WriteLine("[NativeAOT] CMtrlSystm2ppSys_SetInTestMode");
    }
    
    /// <summary>
    /// Active le mode outils.
    /// </summary>
    [UnmanagedCallersOnly]
    public static void CMtrlSystm2ppSys_SetInToolsMode(IntPtr self)
    {
        _isInToolsMode = true;
        Console.WriteLine("[NativeAOT] CMtrlSystm2ppSys_SetInToolsMode");
    }
    
    /// <summary>
    /// Sets the Steam application ID.
    /// </summary>
    [UnmanagedCallersOnly]
    public static void CMtrlSystm2ppSys_SetSteamAppId(IntPtr self, uint appId)
    {
        _steamAppId = appId;
        Console.WriteLine($"[NativeAOT] CMtrlSystm2ppSys_SetSteamAppId: {appId}");
    }
    
    /// <summary>
    /// Gets the Steam application ID.
    /// </summary>
    [UnmanagedCallersOnly]
    public static uint CMtrlSystm2ppSys_GetSteamAppId(IntPtr self)
    {
        return _steamAppId;
    }
    
    /// <summary>
    /// Définit si l'application est un serveur dédié.
    /// </summary>
    [UnmanagedCallersOnly]
    public static void CMtrlSystm2ppSys_SetDedicatedServer(IntPtr self, int isDedicated)
    {
        _isDedicatedServer = isDedicated != 0;
        Console.WriteLine($"[NativeAOT] CMtrlSystm2ppSys_SetDedicatedServer: {_isDedicatedServer}");
    }
    
    /// <summary>
    /// Checks if the application is a dedicated server.
    /// </summary>
    [UnmanagedCallersOnly]
    public static int CMtrlSystm2ppSys_IsDedicatedServer(IntPtr self)
    {
        return _isDedicatedServer ? 1 : 0;
    }
    
    /// <summary>
    /// Vérifie si l'application est une application console.
    /// </summary>
    [UnmanagedCallersOnly]
    public static int CMtrlSystm2ppSys_IsConsoleApp(IntPtr self)
    {
        return _isConsoleApp ? 1 : 0;
    }
    
    /// <summary>
    /// Checks if the application is a game application.
    /// </summary>
    [UnmanagedCallersOnly]
    public static int CMtrlSystm2ppSys_IsGameApp(IntPtr self)
    {
        return _isGameApp ? 1 : 0;
    }
    
    /// <summary>
    /// Obtient le sous-répertoire du mod.
    /// </summary>
    [UnmanagedCallersOnly]
    public static IntPtr CMtrlSystm2ppSys_GetModGameSubdir(IntPtr self)
    {
        if (string.IsNullOrEmpty(_modGameSubdir))
            return IntPtr.Zero;
        
        // Cache the result to avoid repeated allocations
        // Note: In a real implementation, memory deallocation would need to be managed
        return Marshal.StringToHGlobalAnsi(_modGameSubdir);
    }
    
    /// <summary>
    /// Vérifie si l'application est en mode outils.
    /// </summary>
    [UnmanagedCallersOnly]
    public static int CMtrlSystm2ppSys_IsInToolsMode(IntPtr self)
    {
        return _isInToolsMode ? 1 : 0;
    }
    
    /// <summary>
    /// Checks if the application is in developer mode.
    /// </summary>
    [UnmanagedCallersOnly]
    public static int CMtrlSystm2ppSys_IsInDeveloperMode(IntPtr self)
    {
        return _isInDeveloperMode ? 1 : 0;
    }
    
    /// <summary>
    /// Vérifie si l'application est en mode VR.
    /// </summary>
    [UnmanagedCallersOnly]
    public static int CMtrlSystm2ppSys_IsInVRMode(IntPtr self)
    {
        return _isInVRMode ? 1 : 0;
    }
    
    /// <summary>
    /// Checks if the application is running on a client machine.
    /// </summary>
    [UnmanagedCallersOnly]
    public static int CMtrlSystm2ppSys_IsRunningOnCustomerMachine(IntPtr self)
    {
        return _isRunningOnCustomerMachine ? 1 : 0;
    }
    
    /// <summary>
    /// Vérifie si l'application est en mode test.
    /// </summary>
    [UnmanagedCallersOnly]
    public static int CMtrlSystm2ppSys_IsInTestMode(IntPtr self)
    {
        return _isInTestMode ? 1 : 0;
    }
    
    /// <summary>
    /// Gets the current initialization phase.
    /// </summary>
    [UnmanagedCallersOnly]
    public static int CMtrlSystm2ppSys_GetInitializationPhase(IntPtr self)
    {
        return _initializationPhase;
    }
    
    /// <summary>
    /// Checks if the application is a standalone application.
    /// </summary>
    [UnmanagedCallersOnly]
    public static int CMtrlSystm2ppSys_IsStandaloneApp(IntPtr self)
    {
        return _isStandaloneApp ? 1 : 0;
    }
    
    /// <summary>
    /// Initialise le MaterialSystem sans le système de matériaux complet.
    /// </summary>
    [UnmanagedCallersOnly]
    public static int CMtrlSystm2ppSys_InitWithoutMaterialSystem(IntPtr self)
    {
        Console.WriteLine("[NativeAOT] CMtrlSystm2ppSys_InitWithoutMaterialSystem");
        return 1; // Success
    }
    
    /// <summary>
    /// Sets the application window icon.
    /// </summary>
    [UnmanagedCallersOnly]
    public static void CMtrlSystm2ppSys_SetAppWindowIcon(IntPtr self, IntPtr iconPtr)
    {
        // Note: GLFW ne supporte pas directement le changement d'icône après création
        // Cette fonction est principalement un stub pour la compatibilité
        Console.WriteLine("[NativeAOT] CMtrlSystm2ppSys_SetAppWindowIcon");
    }
    
    /// <summary>
    /// Sets the initial application window image.
    /// </summary>
    [UnmanagedCallersOnly]
    public static void CMtrlSystm2ppSys_SetInitialAppWindowImage(IntPtr self, IntPtr imagePtr)
    {
        // This function sets an image to display before the first render
        Console.WriteLine("[NativeAOT] CMtrlSystm2ppSys_SetInitialAppWindowImage");
    }
    
    /// <summary>
    /// Définit si la fenêtre doit ignorer le focus de la souris au clic.
    /// </summary>
    [UnmanagedCallersOnly]
    public static void CMtrlSystm2ppSys_SetAppWindowDiscardMouseFocusClick(IntPtr self, int discard)
    {
        _appWindowDiscardMouseFocusClick = discard != 0;
        Console.WriteLine($"[NativeAOT] CMtrlSystm2ppSys_SetAppWindowDiscardMouseFocusClick: {_appWindowDiscardMouseFocusClick}");
    }
    
    /// <summary>
    /// Draws the initial window image.
    /// </summary>
    [UnmanagedCallersOnly]
    public static void CMtrlSystm2ppSys_DrawInitialWindowImage(IntPtr self)
    {
        // Cette fonction dessine l'image initiale définie par SetInitialAppWindowImage
        Console.WriteLine("[NativeAOT] CMtrlSystm2ppSys_DrawInitialWindowImage");
    }
    
    /// <summary>
    /// Sets the module search path.
    /// </summary>
    [UnmanagedCallersOnly]
    public static void CMtrlSystm2ppSys_SetModuleSearchPath(IntPtr self, IntPtr pathPtr)
    {
        if (pathPtr == IntPtr.Zero) return;
        
        _moduleSearchPath = Marshal.PtrToStringUTF8(pathPtr);
        Console.WriteLine($"[NativeAOT] CMtrlSystm2ppSys_SetModuleSearchPath: {_moduleSearchPath}");
    }
    
    /// <summary>
    /// Définit le mod depuis un nom de fichier.
    /// </summary>
    [UnmanagedCallersOnly]
    public static void CMtrlSystm2ppSys_SetModFromFileName(IntPtr self, IntPtr fileNamePtr, int flags)
    {
        if (fileNamePtr == IntPtr.Zero) return;
        
        string? fileName = Marshal.PtrToStringUTF8(fileNamePtr);
        Console.WriteLine($"[NativeAOT] CMtrlSystm2ppSys_SetModFromFileName: {fileName}, flags={flags}");
        // Note: This function could extract the mod name from the file name
    }
    
    /// <summary>
    /// Désactive la vérification du chemin du mod.
    /// </summary>
    [UnmanagedCallersOnly]
    public static void CMtrlSystm2ppSys_DisableModPathCheck(IntPtr self)
    {
        _modPathCheckDisabled = true;
        Console.WriteLine("[NativeAOT] CMtrlSystm2ppSys_DisableModPathCheck");
    }
    
    /// <summary>
    /// Sets the default rendering system option (e.g., "-vulkan", "-opengl").
    /// </summary>
    [UnmanagedCallersOnly]
    public static void CMtrlSystm2ppSys_SetDefaultRenderSystemOption(IntPtr self, IntPtr optionPtr)
    {
        if (optionPtr == IntPtr.Zero) return;
        
        _defaultRenderSystemOption = Marshal.PtrToStringUTF8(optionPtr);
        Console.WriteLine($"[NativeAOT] CMtrlSystm2ppSys_SetDefaultRenderSystemOption: {_defaultRenderSystemOption}");
    }
    
    /// <summary>
    /// Définit la phase d'initialisation.
    /// </summary>
    [UnmanagedCallersOnly]
    public static void CMtrlSystm2ppSys_SetInitializationPhase(IntPtr self, int phase)
    {
        _initializationPhase = phase;
        Console.WriteLine($"[NativeAOT] CMtrlSystm2ppSys_SetInitializationPhase: {phase}");
    }
    
    /// <summary>
    /// Preparation before MaterialSystem shutdown.
    /// </summary>
    [UnmanagedCallersOnly]
    public static void CMtrlSystm2ppSys_PreShutdown(IntPtr self)
    {
        Console.WriteLine("[NativeAOT] CMtrlSystm2ppSys_PreShutdown");
        // Clean up resources if necessary
    }
    
    /// <summary>
    /// Initialise SDL pour le MaterialSystem.
    /// </summary>
    [UnmanagedCallersOnly]
    public static int CMtrlSystm2ppSys_InitSDL(IntPtr self, uint flags)
    {
        // Note: On Linux, we use GLFW instead of SDL
        // This function is mainly a stub for compatibility
        _sdlInitialized = true;
        Console.WriteLine($"[NativeAOT] CMtrlSystm2ppSys_InitSDL: flags={flags}");
        return 1; // Success
    }
    
    /// <summary>
    /// Arrête SDL pour le MaterialSystem.
    /// </summary>
    [UnmanagedCallersOnly]
    public static void CMtrlSystm2ppSys_ShutdownSDL(IntPtr self)
    {
        _sdlInitialized = false;
        Console.WriteLine("[NativeAOT] CMtrlSystm2ppSys_ShutdownSDL");
    }
    
    /// <summary>
    /// Adds a system to MaterialSystem.
    /// </summary>
    [UnmanagedCallersOnly]
    public static IntPtr CMtrlSystm2ppSys_AddSystem(IntPtr self, IntPtr moduleNamePtr, IntPtr systemNamePtr)
    {
        if (moduleNamePtr == IntPtr.Zero || systemNamePtr == IntPtr.Zero)
            return IntPtr.Zero;
        
        string? moduleName = Marshal.PtrToStringUTF8(moduleNamePtr);
        string? systemName = Marshal.PtrToStringUTF8(systemNamePtr);
        Console.WriteLine($"[NativeAOT] CMtrlSystm2ppSys_AddSystem: module={moduleName}, system={systemName}");
        
        // Retourner un pointeur vers le système ajouté (stub pour l'instant)
        return (IntPtr)1;
    }
    
    /// <summary>
    /// Enables standalone mode.
    /// </summary>
    [UnmanagedCallersOnly]
    public static void CMtrlSystm2ppSys_SetInStandaloneApp(IntPtr self)
    {
        _isStandaloneApp = true;
        Console.WriteLine("[NativeAOT] CMtrlSystm2ppSys_SetInStandaloneApp");
    }
    
    // ========== g_pMtrlSystm2 Functions ==========
    
    /// <summary>
    /// Crée un matériau brut (raw material).
    /// </summary>
    [UnmanagedCallersOnly]
    public static IntPtr g_pMtrlSystm2_CreateRawMaterial(IntPtr materialNamePtr, IntPtr shaderPtr, int anonymous)
    {
        string? materialName = Marshal.PtrToStringUTF8(materialNamePtr);
        string? shader = Marshal.PtrToStringUTF8(shaderPtr);
        LogCall(nameof(g_pMtrlSystm2_CreateRawMaterial), minimal: true, message: $"name='{materialName}' shader='{shader}' anonymous={anonymous}");
        
        // Create render attributes for this material
        IntPtr renderAttributes = RenderAttributes.RenderAttributes.CreateRenderAttributesInternal();
        
        var materialData = new MaterialData
        {
            Name = materialName ?? "",
            Shader = shader ?? "",
            Anonymous = anonymous != 0,
            RenderAttributes = renderAttributes
        };

        // Load compiled shader (.shader_c) if available
        string? compiledPath = TryFindCompiledShaderPath(shader);
        if (!string.IsNullOrEmpty(compiledPath) && File.Exists(compiledPath))
        {
            try
            {
                materialData.CompiledShaderPath = compiledPath;
                materialData.CompiledShaderBytes = File.ReadAllBytes(compiledPath);
                materialData.IsLoaded = true;
                materialData.IsError = false;
                LogCall(nameof(g_pMtrlSystm2_CreateRawMaterial), minimal: true, message: $"loaded shader_c='{compiledPath}' size={materialData.CompiledShaderBytes.Length}");
            }
            catch (Exception ex)
            {
                materialData.IsLoaded = false;
                materialData.IsError = true;
                LogCall(nameof(g_pMtrlSystm2_CreateRawMaterial), minimal: true, message: $"failed to load shader_c: {ex.Message}");
            }
        }
        else
        {
            materialData.IsLoaded = false;
            materialData.IsError = true;
            LogCall(nameof(g_pMtrlSystm2_CreateRawMaterial), minimal: true, message: "shader_c not found");
        }
        
        // Register MaterialData in HandleManager to get a unique handle
        int handle = HandleManager.Register(materialData);
        if (handle == 0) return IntPtr.Zero;
        
        int bindingHandle = HandleManager.GetBindingHandle(handle);
        materialData.BindingPtr = (IntPtr)bindingHandle;
        
        // Create a default rendering mode (we also use HandleManager for consistency)
        int modeHandle = HandleManager.Register(new object()); // Objet simple pour représenter le mode
        materialData.MaterialMode = (IntPtr)modeHandle;
        
        // Enregistrer dans l'index Name si le nom est fourni
        if (!string.IsNullOrEmpty(materialName))
        {
            HandleManager.RegisterNameIndex(materialName, bindingHandle);
        }
        
        return (IntPtr)handle;
    }
    
    // ========== IMaterial2 Functions ==========
    
    /// <summary>
    /// Returns the render attributes of a material.
    /// </summary>
    [UnmanagedCallersOnly]
    public static IntPtr IMaterial2_GetRenderAttributes(IntPtr self)
    {
        LogCall(nameof(IMaterial2_GetRenderAttributes), minimal: true, message: $"self=0x{self.ToInt64():X}");
        if (self == IntPtr.Zero) return IntPtr.Zero;
        
        // Get the material data and return its render attributes
        var materialData = HandleManager.Get<MaterialData>((int)self);
        if (materialData != null)
        {
            if (materialData.RenderAttributes != IntPtr.Zero)
                return materialData.RenderAttributes;
        }
        
        // If material not found or attributes not set, create new ones
        // This shouldn't happen in normal flow, but handle gracefully
        return RenderAttributes.RenderAttributes.CreateRenderAttributesInternal();
    }
    
    /// <summary>
    /// Gets the name of a material.
    /// </summary>
    [UnmanagedCallersOnly]
    public static IntPtr IMaterial2_GetName(IntPtr self)
    {
        LogCall(nameof(IMaterial2_GetName), minimal: true, message: $"self=0x{self.ToInt64():X}");
        if (self == IntPtr.Zero) return IntPtr.Zero;
        
        var materialData = HandleManager.Get<MaterialData>((int)self);
        if (materialData != null)
        {
            // Cache le nom en mémoire non managée pour éviter les allocations répétées
            // Note: Dans une implémentation réelle, il faudrait gérer la libération de cette mémoire
            return Marshal.StringToHGlobalAnsi(materialData.Name);
        }
        
        return IntPtr.Zero;
    }
    
    /// <summary>
    /// Gets the mode of a material for a given token.
    /// </summary>
    [UnmanagedCallersOnly]
    public static IntPtr IMaterial2_GetMode(IntPtr self, Sandbox.StringToken token)
    {
        LogCall(nameof(IMaterial2_GetMode), minimal: true, message: $"self=0x{self.ToInt64():X} token={token.Value}");
        if (self == IntPtr.Zero) return IntPtr.Zero;
        
        var materialData = HandleManager.Get<MaterialData>((int)self);
        if (materialData != null)
        {
            // Retourner le mode du matériau (ou créer un mode par défaut si nécessaire)
            if (materialData.MaterialMode == IntPtr.Zero)
            {
                // Créer un mode par défaut via HandleManager
                int modeHandle = HandleManager.Register(new object());
                materialData.MaterialMode = (IntPtr)modeHandle;
            }
            return materialData.MaterialMode;
        }
        
        return IntPtr.Zero;
    }
    
    /// <summary>
    /// Définit une valeur de paramètre de matériau (string).
    /// </summary>
    [UnmanagedCallersOnly]
    public static void IMaterial2_Set(IntPtr self, IntPtr namePtr, IntPtr valuePtr)
    {
        if (self == IntPtr.Zero || namePtr == IntPtr.Zero || valuePtr == IntPtr.Zero) return;
        
        string? name = Marshal.PtrToStringUTF8(namePtr);
        string? value = Marshal.PtrToStringUTF8(valuePtr);
        
        if (string.IsNullOrEmpty(name)) return;
        
        var materialData = HandleManager.Get<MaterialData>((int)self);
        if (materialData != null)
        {
            // Store the value in render attributes
            if (materialData.RenderAttributes != IntPtr.Zero)
            {
                RenderAttributes.RenderAttributes.SetStringValueHelper(materialData.RenderAttributes, name, value ?? "");
            }
            
            // Stocker aussi dans les paramètres du matériau
            materialData.Parameters[name] = value ?? "";
        }
    }
    
    // ========== g_pMtrlSystm2 Functions supplémentaires ==========
    
    /// <summary>
    /// Creates a procedural copy of a material.
    /// </summary>
    [UnmanagedCallersOnly]
    public static IntPtr g_pMtrlSystm2_CreateProceduralMaterialCopy(IntPtr hSrcMaterial, int nResourceType, int bRecreateStaticBuffers)
    {
        LogCall(nameof(g_pMtrlSystm2_CreateProceduralMaterialCopy), minimal: true, message: $"src=0x{hSrcMaterial.ToInt64():X} resType={nResourceType} recreate={bRecreateStaticBuffers}");
        if (hSrcMaterial == IntPtr.Zero) return IntPtr.Zero;
        
        var srcMaterial = HandleManager.Get<MaterialData>((int)hSrcMaterial);
        if (srcMaterial != null)
        {
            // Créer de nouveaux render attributes
            IntPtr renderAttributes = RenderAttributes.RenderAttributes.CreateRenderAttributesInternal();
            
            var newMaterial = new MaterialData
            {
                Name = srcMaterial.Name + "_copy",
                Shader = srcMaterial.Shader,
                Anonymous = srcMaterial.Anonymous,
                RenderAttributes = renderAttributes,
                IsLoaded = srcMaterial.IsLoaded,
                IsError = srcMaterial.IsError,
                SimilarityKey = srcMaterial.SimilarityKey
            };
            
            // Register the new MaterialData in HandleManager to get a unique handle
            int newHandle = HandleManager.Register(newMaterial);
            if (newHandle == 0) return IntPtr.Zero;
            
            int newBindingHandle = HandleManager.GetBindingHandle(newHandle);
            newMaterial.BindingPtr = (IntPtr)newBindingHandle;
            
            // Create a new rendering mode for the copy
            int newModeHandle = HandleManager.Register(new object());
            newMaterial.MaterialMode = (IntPtr)newModeHandle;
            
            // Copy parameters
            foreach (var kvp in srcMaterial.Parameters)
            {
                newMaterial.Parameters[kvp.Key] = kvp.Value;
            }
            
            // Enregistrer dans l'index Name si le nom est fourni
            if (!string.IsNullOrEmpty(newMaterial.Name))
            {
                HandleManager.RegisterNameIndex(newMaterial.Name, newBindingHandle);
            }
            
            return (IntPtr)newHandle;
        }
        
        return IntPtr.Zero;
    }
    
    /// <summary>
    /// Finds or creates a material from a resource.
    /// </summary>
    [UnmanagedCallersOnly]
    public static IntPtr g_pMtrlSystm2_FindOrCreateMaterialFromResource(IntPtr pResourceName)
    {
        LogCall(nameof(g_pMtrlSystm2_FindOrCreateMaterialFromResource), minimal: true, message: $"resource='{(pResourceName==IntPtr.Zero?string.Empty:Marshal.PtrToStringUTF8(pResourceName))}'");
        if (pResourceName == IntPtr.Zero) return IntPtr.Zero;
        
        string? resourceName = Marshal.PtrToStringUTF8(pResourceName);
        if (string.IsNullOrEmpty(resourceName)) return IntPtr.Zero;
        
        return FindOrCreateMaterialFromResourceHelper(resourceName);
    }
    
    /// <summary>
    /// Helper pour trouver ou créer un matériau depuis une ressource (appelable depuis le code managé).
    /// Utilisé par EngineGlue.Glue_Resources_GetMaterial.
    /// </summary>
    public static IntPtr FindOrCreateMaterialFromResourceHelper(string resourceName)
    {
        if (string.IsNullOrEmpty(resourceName)) return IntPtr.Zero;
        
        // Search for an existing material with this name (O(1) via index)
        var existingMaterial = HandleManager.FindByName<MaterialData>(resourceName);
        if (existingMaterial != null && existingMaterial.BindingPtr != IntPtr.Zero)
        {
            // Trouver un handle existant pour ce matériau via le BindingHandle
            int existingBindingHandle = (int)existingMaterial.BindingPtr;
            int existingHandle = HandleManager.GetHandleByBindingHandle(existingBindingHandle);
            if (existingHandle != 0)
            {
                // Get all handles for this material and return the first one
                var allHandles = HandleManager.GetAllHandles(existingHandle);
                if (allHandles.Length > 0)
                {
                    Console.WriteLine($"[NativeAOT] FindOrCreateMaterialFromResourceHelper: found existing {resourceName}");
                    return (IntPtr)allHandles[0];
                }
            }
        }
        
        // Créer un nouveau matériau
        IntPtr renderAttributes = RenderAttributes.RenderAttributes.CreateRenderAttributesInternal();
        
        var materialData = new MaterialData
        {
            Name = resourceName,
            Shader = "",
            Anonymous = false,
            RenderAttributes = renderAttributes
        };
        
        // Register MaterialData in HandleManager to get a unique handle
        int handle = HandleManager.Register(materialData);
        if (handle == 0) return IntPtr.Zero;
        
        int bindingHandle = HandleManager.GetBindingHandle(handle);
        materialData.BindingPtr = (IntPtr)bindingHandle;
        
        // Créer un mode de rendu par défaut
        int modeHandle = HandleManager.Register(new object());
        materialData.MaterialMode = (IntPtr)modeHandle;
        
        // Register in Name index for O(1) lookup
        HandleManager.RegisterNameIndex(resourceName, bindingHandle);
        
        Console.WriteLine($"[NativeAOT] FindOrCreateMaterialFromResourceHelper: created new {resourceName}, handle={handle}");
        return (IntPtr)handle;
    }
    
    /// <summary>
    /// Mise à jour par frame du MaterialSystem.
    /// </summary>
    [UnmanagedCallersOnly]
    public static void g_pMtrlSystm2_FrameUpdate()
    {
        LogCall(nameof(g_pMtrlSystm2_FrameUpdate), minimal: true);
    }
    
    // ========== IMaterial2 Functions supplémentaires ==========
    
    /// <summary>
    /// Destroys a strong material handle.
    /// </summary>
    [UnmanagedCallersOnly]
    public static void IMaterial2_DestroyStrongHandle(IntPtr self)
    {
        LogCall(nameof(IMaterial2_DestroyStrongHandle), minimal: true, message: $"self=0x{self.ToInt64():X}");
        if (self == IntPtr.Zero) return;
        
        var materialData = HandleManager.Get<MaterialData>((int)self);
        if (materialData != null)
        {
            // Libérer le MaterialMode depuis HandleManager
            if (materialData.MaterialMode != IntPtr.Zero)
            {
                HandleManager.Unregister((int)materialData.MaterialMode);
            }
            
            // Clean up secondary indexes before Unregister
            if (!string.IsNullOrEmpty(materialData.Name))
            {
                HandleManager.UnindexName(materialData.Name);
            }
        }
        
        HandleManager.Unregister((int)self);
    }
    
    /// <summary>
    /// Vérifie si un handle fort de matériau est valide.
    /// </summary>
    [UnmanagedCallersOnly]
    public static int IMaterial2_IsStrongHandleValid(IntPtr self)
    {
        LogCall(nameof(IMaterial2_IsStrongHandleValid), minimal: true, message: $"self=0x{self.ToInt64():X}");
        if (self == IntPtr.Zero) return 0;
        return HandleManager.Exists((int)self) ? 1 : 0;
    }
    
    /// <summary>
    /// Checks if a material is in error.
    /// </summary>
    [UnmanagedCallersOnly]
    public static int IMaterial2_IsError(IntPtr self)
    {
        LogCall(nameof(IMaterial2_IsError), minimal: true, message: $"self=0x{self.ToInt64():X}");
        if (self == IntPtr.Zero) return 1; // Null = erreur
        
        var materialData = HandleManager.Get<MaterialData>((int)self);
        if (materialData != null)
        {
            return materialData.IsError ? 1 : 0;
        }
        
        return 1; // Matériau non trouvé = erreur
    }
    
    /// <summary>
    /// Checks if a strong material handle is loaded.
    /// </summary>
    [UnmanagedCallersOnly]
    public static int IMaterial2_IsStrongHandleLoaded(IntPtr self)
    {
        LogCall(nameof(IMaterial2_IsStrongHandleLoaded), minimal: true, message: $"self=0x{self.ToInt64():X}");
        if (self == IntPtr.Zero) return 0;
        
        var materialData = HandleManager.Get<MaterialData>((int)self);
        if (materialData != null)
        {
            return materialData.IsLoaded ? 1 : 0;
        }
        
        return 0;
    }
    
    /// <summary>
    /// Copie un handle fort de matériau.
    /// </summary>
    [UnmanagedCallersOnly]
    public static IntPtr IMaterial2_CopyStrongHandle(IntPtr self)
    {
        LogCall(nameof(IMaterial2_CopyStrongHandle), minimal: true, message: $"self=0x{self.ToInt64():X}");
        if (self == IntPtr.Zero) return IntPtr.Zero;
        
        int newHandle = HandleManager.CopyHandle((int)self);
        if (newHandle != 0)
        {
            return (IntPtr)newHandle;
        }
        
        return IntPtr.Zero;
    }
    
    /// <summary>
    /// Gets the binding pointer of a material.
    /// The binding pointer is a unique identifier that identifies the native material,
    /// used to compare if two handles point to the same material.
    /// </summary>
    [UnmanagedCallersOnly]
    public static IntPtr IMaterial2_GetBindingPtr(IntPtr self)
    {
        LogCall(nameof(IMaterial2_GetBindingPtr), minimal: true, message: $"self=0x{self.ToInt64():X}");
        if (self == IntPtr.Zero) return IntPtr.Zero;
        
        int bindingHandle = HandleManager.GetBindingHandle((int)self);
        return bindingHandle != 0 ? (IntPtr)bindingHandle : IntPtr.Zero;
    }
    
    /// <summary>
    /// Obtient le nom d'un matériau avec le mod.
    /// </summary>
    [UnmanagedCallersOnly]
    public static IntPtr IMaterial2_GetNameWithMod(IntPtr self)
    {
        LogCall(nameof(IMaterial2_GetNameWithMod), minimal: true, message: $"self=0x{self.ToInt64():X}");
        if (self == IntPtr.Zero) return IntPtr.Zero;
        
        var materialData = HandleManager.Get<MaterialData>((int)self);
        if (materialData != null)
        {
            // Add mod prefix if available
            string nameWithMod = materialData.Name;
            if (!string.IsNullOrEmpty(_modGameSubdir))
            {
                nameWithMod = $"{_modGameSubdir}/{nameWithMod}";
            }
            
            return Marshal.StringToHGlobalAnsi(nameWithMod);
        }
        
        return IntPtr.Zero;
    }
    
    /// <summary>
    /// Obtient la clé de similarité d'un matériau.
    /// </summary>
    [UnmanagedCallersOnly]
    public static ulong IMaterial2_GetSimilarityKey(IntPtr self)
    {
        LogCall(nameof(IMaterial2_GetSimilarityKey), minimal: true, message: $"self=0x{self.ToInt64():X}");
        if (self == IntPtr.Zero) return 0;
        
        var materialData = HandleManager.Get<MaterialData>((int)self);
        if (materialData != null)
        {
            if (materialData.SimilarityKey == 0)
            {
                // Generate a similarity key based on name and shader
                // Uses MurmurHash2 to ensure compatibility with Source 2
                string keyString = $"{materialData.Name}:{materialData.Shader}";
                materialData.SimilarityKey = HashUtils.MurmurHash2(keyString, lowercase: true);
            }
            return materialData.SimilarityKey;
        }
        
        return 0;
    }
    
    /// <summary>
    /// Vérifie si un matériau est chargé.
    /// </summary>
    [UnmanagedCallersOnly]
    public static int IMaterial2_IsLoaded(IntPtr self)
    {
        LogCall(nameof(IMaterial2_IsLoaded), minimal: true, message: $"self=0x{self.ToInt64():X}");
        if (self == IntPtr.Zero) return 0;
        
        var materialData = HandleManager.Get<MaterialData>((int)self);
        if (materialData != null)
        {
            return materialData.IsLoaded ? 1 : 0;
        }
        
        return 0;
    }
    
    /// <summary>
    /// Gets the mode of a material (no parameter).
    /// </summary>
    [UnmanagedCallersOnly]
    public static IntPtr IMaterial2_GetMode_1(IntPtr self)
    {
        LogCall(nameof(IMaterial2_GetMode_1), minimal: true, message: $"self=0x{self.ToInt64():X}");
        if (self == IntPtr.Zero) return IntPtr.Zero;
        
        var materialData = HandleManager.Get<MaterialData>((int)self);
        if (materialData != null)
        {
            // Retourner le mode du matériau (ou créer un mode par défaut si nécessaire)
            if (materialData.MaterialMode == IntPtr.Zero)
            {
                // Créer un mode par défaut via HandleManager
                int modeHandle = HandleManager.Register(new object());
                materialData.MaterialMode = (IntPtr)modeHandle;
            }
            return materialData.MaterialMode;
        }
        
        return IntPtr.Zero;
    }
    
    /// <summary>
    /// Gets the mode of a material for a given scene layer.
    /// </summary>
    [UnmanagedCallersOnly]
    public static IntPtr IMaterial2_GetMode_2(IntPtr self, IntPtr layer)
    {
        LogCall(nameof(IMaterial2_GetMode_2), minimal: true, message: $"self=0x{self.ToInt64():X} layer=0x{layer.ToInt64():X}");
        if (self == IntPtr.Zero) return IntPtr.Zero;
        
        var materialData = HandleManager.Get<MaterialData>((int)self);
        if (materialData != null)
        {
            // Pour l'instant, retourner le même mode pour toutes les couches
            // Dans une implémentation complète, on pourrait avoir des modes différents par couche
            if (materialData.MaterialMode == IntPtr.Zero)
            {
                // Créer un mode par défaut via HandleManager
                int modeHandle = HandleManager.Register(new object());
                materialData.MaterialMode = (IntPtr)modeHandle;
            }
            return materialData.MaterialMode;
        }
        
        return IntPtr.Zero;
    }
    
    /// <summary>
    /// Recreates all static constant and command buffers.
    /// </summary>
    [UnmanagedCallersOnly]
    public static void IMaterial2_RecreateAllStaticConstantAndCommandBuffers(IntPtr self)
    {
        LogCall(nameof(IMaterial2_RecreateAllStaticConstantAndCommandBuffers), minimal: false, message: $"self=0x{self.ToInt64():X}");
        // Pour l'instant, rien à faire car on n'utilise pas de buffers statiques
        // Dans une implémentation complète, on recréerait les buffers GPU
    }
    
    /// <summary>
    /// Gets the first texture attribute of a material.
    /// </summary>
    [UnmanagedCallersOnly]
    public static IntPtr IMaterial2_GetFirstTextureAttribute(IntPtr self)
    {
        LogCall(nameof(IMaterial2_GetFirstTextureAttribute), minimal: false, message: $"self=0x{self.ToInt64():X}");
        if (self == IntPtr.Zero) return IntPtr.Zero;
        
        var materialData = HandleManager.Get<MaterialData>((int)self);
        if (materialData != null)
        {
            if (materialData.RenderAttributes != IntPtr.Zero)
            {
                return RenderAttributes.RenderAttributes.GetFirstTextureAttributeHelper(materialData.RenderAttributes);
            }
        }
        
        return IntPtr.Zero;
    }
    
    /// <summary>
    /// Gets a boolean attribute of a material with default value.
    /// </summary>
    [UnmanagedCallersOnly]
    public static int IMaterial2_GetBoolAttributeOrDefault(IntPtr self, Sandbox.StringToken name, int defaultValue)
    {
        LogCall(nameof(IMaterial2_GetBoolAttributeOrDefault), minimal: false, message: $"self=0x{self.ToInt64():X} token={name.Value} default={defaultValue}");
        if (self == IntPtr.Zero) return defaultValue;
        
        var materialData = HandleManager.Get<MaterialData>((int)self);
        if (materialData != null)
        {
            if (materialData.RenderAttributes != IntPtr.Zero)
            {
                string? nameStr = Sandbox.StringToken.GetValue(name.Value);
                if (!string.IsNullOrEmpty(nameStr))
                {
                    bool value = RenderAttributes.RenderAttributes.GetBoolValueHelper(materialData.RenderAttributes, nameStr, defaultValue != 0);
                    return value ? 1 : 0;
                }
            }
        }
        
        return defaultValue;
    }
    
    /// <summary>
    /// Gets an integer attribute of a material with default value.
    /// </summary>
    [UnmanagedCallersOnly]
    public static int IMaterial2_GetIntAttributeOrDefault(IntPtr self, Sandbox.StringToken name, int defaultValue)
    {
        LogCall(nameof(IMaterial2_GetIntAttributeOrDefault), minimal: false, message: $"self=0x{self.ToInt64():X} token={name.Value} default={defaultValue}");
        if (self == IntPtr.Zero) return defaultValue;
        
        var materialData = HandleManager.Get<MaterialData>((int)self);
        if (materialData != null)
        {
            if (materialData.RenderAttributes != IntPtr.Zero)
            {
                string? nameStr = Sandbox.StringToken.GetValue(name.Value);
                if (!string.IsNullOrEmpty(nameStr))
                {
                    return RenderAttributes.RenderAttributes.GetIntValueHelper(materialData.RenderAttributes, nameStr, defaultValue);
                }
            }
        }
        
        return defaultValue;
    }
    
    /// <summary>
    /// Obtient un attribut float d'un matériau avec valeur par défaut.
    /// </summary>
    [UnmanagedCallersOnly]
    public static float IMaterial2_GetFloatAttributeOrDefault(IntPtr self, Sandbox.StringToken name, float defaultValue)
    {
        LogCall(nameof(IMaterial2_GetFloatAttributeOrDefault), minimal: false, message: $"self=0x{self.ToInt64():X} token={name.Value} default={defaultValue}");
        if (self == IntPtr.Zero) return defaultValue;
        
        var materialData = HandleManager.Get<MaterialData>((int)self);
        if (materialData != null)
        {
            if (materialData.RenderAttributes != IntPtr.Zero)
            {
                string? nameStr = Sandbox.StringToken.GetValue(name.Value);
                if (!string.IsNullOrEmpty(nameStr))
                {
                    return RenderAttributes.RenderAttributes.GetFloatValueHelper(materialData.RenderAttributes, nameStr, defaultValue);
                }
            }
        }
        
        return defaultValue;
    }
    
    /// <summary>
    /// Gets a texture attribute of a material with default value.
    /// </summary>
    [UnmanagedCallersOnly]
    public static IntPtr IMaterial2_GetTextureAttributeOrDefault(IntPtr self, Sandbox.StringToken name)
    {
        LogCall(nameof(IMaterial2_GetTextureAttributeOrDefault), minimal: false, message: $"self=0x{self.ToInt64():X} token={name.Value}");
        if (self == IntPtr.Zero) return IntPtr.Zero;
        
        var materialData = HandleManager.Get<MaterialData>((int)self);
        if (materialData != null)
        {
            if (materialData.RenderAttributes != IntPtr.Zero)
            {
                string? nameStr = Sandbox.StringToken.GetValue(name.Value);
                if (!string.IsNullOrEmpty(nameStr))
                {
                    return RenderAttributes.RenderAttributes.GetTextureValueHelper(materialData.RenderAttributes, nameStr, IntPtr.Zero);
                }
            }
        }
        
        return IntPtr.Zero;
    }
    
    /// <summary>
    /// Vérifie si un matériau a un paramètre donné.
    /// </summary>
    [UnmanagedCallersOnly]
    public static int IMaterial2_HasParam(IntPtr self, IntPtr namePtr)
    {
        if (self == IntPtr.Zero || namePtr == IntPtr.Zero) return 0;
        
        string? name = Marshal.PtrToStringUTF8(namePtr);
        if (string.IsNullOrEmpty(name)) return 0;
        
        var materialData = HandleManager.Get<MaterialData>((int)self);
        if (materialData != null)
        {
            // Check in parameters
            if (materialData.Parameters.ContainsKey(name))
                return 1;
            
            // Vérifier aussi dans les render attributes
            if (materialData.RenderAttributes != IntPtr.Zero)
            {
                if (RenderAttributes.RenderAttributes.HasParamHelper(materialData.RenderAttributes, name))
                    return 1;
            }
        }
        
        return 0;
    }
    
    /// <summary>
    /// Gets a string parameter value of a material.
    /// </summary>
    [UnmanagedCallersOnly]
    public static IntPtr IMaterial2_GetString(IntPtr self, IntPtr namePtr, IntPtr defaultValuePtr)
    {
        if (self == IntPtr.Zero || namePtr == IntPtr.Zero) return defaultValuePtr;
        
        string? name = Marshal.PtrToStringUTF8(namePtr);
        if (string.IsNullOrEmpty(name)) return defaultValuePtr;
        
        var materialData = HandleManager.Get<MaterialData>((int)self);
        if (materialData != null)
        {
            // Chercher dans les paramètres
            if (materialData.Parameters.TryGetValue(name, out var value) && value is string strValue)
            {
                // Allocate and return the value
                return Marshal.StringToHGlobalAnsi(strValue);
            }
            
            // Also search in render attributes
            if (materialData.RenderAttributes != IntPtr.Zero)
            {
                string? attrValue = RenderAttributes.RenderAttributes.GetStringValueHelper(materialData.RenderAttributes, name);
                if (!string.IsNullOrEmpty(attrValue))
                {
                    return Marshal.StringToHGlobalAnsi(attrValue);
                }
            }
        }
        
        return defaultValuePtr;
    }
    
    /// <summary>
    /// Sets a Vector4 parameter value of a material.
    /// </summary>
    [UnmanagedCallersOnly]
    public static void IMaterial2_Set_1(IntPtr self, IntPtr namePtr, Vector4* value)
    {
        if (self == IntPtr.Zero || namePtr == IntPtr.Zero || value == null) return;
        
        string? name = Marshal.PtrToStringUTF8(namePtr);
        if (string.IsNullOrEmpty(name)) return;
        
        var materialData = HandleManager.Get<MaterialData>((int)self);
        if (materialData != null)
        {
            // Stocker dans les paramètres
            materialData.Parameters[name] = *value;
            
            // Also store in render attributes
            if (materialData.RenderAttributes != IntPtr.Zero)
            {
                RenderAttributes.RenderAttributes.SetVector4DValueHelper(materialData.RenderAttributes, name, *value);
            }
        }
    }
    
    /// <summary>
    /// Gets a Vector4 parameter value of a material.
    /// </summary>
    [UnmanagedCallersOnly]
    public static Vector4 IMaterial2_GetVector4(IntPtr self, IntPtr namePtr)
    {
        if (self == IntPtr.Zero || namePtr == IntPtr.Zero) return default;
        
        string? name = Marshal.PtrToStringUTF8(namePtr);
        if (string.IsNullOrEmpty(name)) return default;
        
        var materialData = HandleManager.Get<MaterialData>((int)self);
        if (materialData != null)
        {
            // Chercher dans les paramètres
            if (materialData.Parameters.TryGetValue(name, out var value))
            {
                if (value is Vector4 vec4)
                    return vec4;
            }
            
            // Also search in render attributes
            if (materialData.RenderAttributes != IntPtr.Zero)
            {
                return RenderAttributes.RenderAttributes.GetVector4DValueHelper(materialData.RenderAttributes, name, default);
            }
        }
        
        return default;
    }
    
    /// <summary>
    /// Définit une valeur de paramètre texture d'un matériau.
    /// </summary>
    [UnmanagedCallersOnly]
    public static void IMaterial2_Set_2(IntPtr self, IntPtr namePtr, IntPtr texture)
    {
        if (self == IntPtr.Zero || namePtr == IntPtr.Zero) return;
        
        string? name = Marshal.PtrToStringUTF8(namePtr);
        if (string.IsNullOrEmpty(name)) return;
        
        var materialData = HandleManager.Get<MaterialData>((int)self);
        if (materialData != null)
        {
            // Stocker dans les paramètres
            materialData.Parameters[name] = texture;
            
            // Also store in render attributes
            if (materialData.RenderAttributes != IntPtr.Zero)
            {
                RenderAttributes.RenderAttributes.SetTextureValueHelper(materialData.RenderAttributes, name, texture);
            }
        }
    }
    
    /// <summary>
    /// Gets a texture parameter value of a material.
    /// </summary>
    [UnmanagedCallersOnly]
    public static IntPtr IMaterial2_GetTexture(IntPtr self, IntPtr namePtr)
    {
        if (self == IntPtr.Zero || namePtr == IntPtr.Zero) return IntPtr.Zero;
        
        string? name = Marshal.PtrToStringUTF8(namePtr);
        if (string.IsNullOrEmpty(name)) return IntPtr.Zero;
        
        var materialData = HandleManager.Get<MaterialData>((int)self);
        if (materialData != null)
        {
            // Chercher dans les paramètres
            if (materialData.Parameters.TryGetValue(name, out var value))
            {
                if (value is IntPtr texturePtr)
                    return texturePtr;
            }
            
            // Also search in render attributes
            if (materialData.RenderAttributes != IntPtr.Zero)
            {
                return RenderAttributes.RenderAttributes.GetTextureValueHelper(materialData.RenderAttributes, name, IntPtr.Zero);
            }
        }
        
        return IntPtr.Zero;
    }
    
    /// <summary>
    /// Définit si un matériau est édité.
    /// </summary>
    [UnmanagedCallersOnly]
    public static void IMaterial2_SetEdited(IntPtr self, int edited)
    {
        if (self == IntPtr.Zero) return;
        
        var materialData = HandleManager.Get<MaterialData>((int)self);
        if (materialData != null)
        {
            materialData.IsEdited = edited != 0;
        }
    }
    
    /// <summary>
    /// Checks if a material is edited.
    /// </summary>
    [UnmanagedCallersOnly]
    public static int IMaterial2_IsEdited(IntPtr self)
    {
        if (self == IntPtr.Zero) return 0;
        
        var materialData = HandleManager.Get<MaterialData>((int)self);
        if (materialData != null)
        {
            return materialData.IsEdited ? 1 : 0;
        }
        
        return 0;
    }
    
    /// <summary>
    /// Recharge les combos statiques d'un matériau.
    /// </summary>
    [UnmanagedCallersOnly]
    public static void IMaterial2_ReloadStaticCombos(IntPtr self)
    {
        // For now, nothing to do as we don't use static combos
        // In a complete implementation, we would reload static shader combinations
    }
}

