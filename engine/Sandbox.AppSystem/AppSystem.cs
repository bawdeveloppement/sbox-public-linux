using Sandbox.Diagnostics;
using Sandbox.Engine;
using Sandbox.Internal;
using Sandbox.Network;
using Sandbox.Rendering;
using System;
using System.Globalization;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.IO;
using System.Reflection;


namespace Sandbox;

public class AppSystem
{
	protected Logger log = new Logger( "AppSystem" );
	internal CMaterialSystem2AppSystemDict _appSystem { get; set; }
	private static bool _skiaResolverSet;
	private static IntPtr _skiaHandle = IntPtr.Zero;

	[DllImport( "user32.dll", CharSet = CharSet.Unicode )]
	private static extern int MessageBox( IntPtr hWnd, string text, string caption, uint type );

	/// <summary>
	/// We should check all the system requirements here as early as possible.
	/// </summary>
	public void TestSystemRequirements()
	{
		if ( !OperatingSystem.IsWindows() )
			return;

		// AVX is on any sane CPU since 2011
		if ( !Avx.IsSupported )
		{
			MessageBox( IntPtr.Zero, "Your CPU needs to support AVX instructions to run this game.", "Unsupported CPU", 0x10 );
			Environment.Exit( 1 );
		}

		// check core count, ram, os?
		// rendersystemvulkan ends up checking gpu, driver, vram later on

		MissingDependancyDiagnosis.Run();
	}

	public virtual void Init()
	{
		if ( !_skiaResolverSet )
		{
			NativeLibrary.SetDllImportResolver( typeof( SkiaSharp.SKTypeface ).Assembly, SkiaImportResolver );
			SkiaPreload();
			_skiaResolverSet = true;
		}

		GCSettings.LatencyMode = GCLatencyMode.SustainedLowLatency;
		NetCore.InitializeInterop( Environment.CurrentDirectory );
	}

	private static IntPtr SkiaImportResolver( string libraryName, Assembly assembly, DllImportSearchPath? searchPath )
	{
		if ( !OperatingSystem.IsLinux() )
			return IntPtr.Zero;

		if ( !libraryName.Contains( "skia", StringComparison.OrdinalIgnoreCase ) )
			return IntPtr.Zero;

		var bases = new[]
		{
			AppContext.BaseDirectory,
			Environment.CurrentDirectory
		};

		var names = new[]
		{
			"libSkiaSharp.so",
			"libSkiaSharp.so.2",
			"libSkiaSharp.so.1",
			"libskia.so",
			"libskia",
		};

		foreach ( var root in bases )
		{
			var folder = Path.Combine( root, "bin", "linuxsteamrt64" );
			foreach ( var name in names )
			{
				var candidate = Path.Combine( folder, name );
				if ( NativeLibrary.TryLoad( candidate, out var handle ) )
				{
					return handle;
				}
			}

			// Try any versioned libSkiaSharp* present in the folder
			if ( Directory.Exists( folder ) )
			{
				foreach ( var candidate in Directory.GetFiles( folder, "libSkiaSharp.so*" ) )
				{
					if ( NativeLibrary.TryLoad( candidate, out var handle ) )
					{
						return handle;
					}
				}
			}
		}

		return IntPtr.Zero;
	}

	private static void SkiaPreload()
	{
		if ( !OperatingSystem.IsLinux() || _skiaHandle != IntPtr.Zero )
			return;

		var bases = new[]
		{
			AppContext.BaseDirectory,
			Environment.CurrentDirectory
		};

		var names = new[]
		{
			"libSkiaSharp.so",
			"libSkiaSharp.so.2",
			"libSkiaSharp.so.1",
			"libskia.so",
			"libskia"
		};

		foreach ( var root in bases )
		{
			var folder = Path.Combine( root, "bin", "linuxsteamrt64" );
			foreach ( var name in names )
			{
				var candidate = Path.Combine( folder, name );
				if ( NativeLibrary.TryLoad( candidate, out var handle ) )
				{
					_skiaHandle = handle;
					Console.WriteLine( $"[NativeAOT] Skia preloaded from {candidate}" );
					return;
				}
			}

			// Try any versioned libSkiaSharp* present in the folder
			if ( Directory.Exists( folder ) )
			{
				foreach ( var candidate in Directory.GetFiles( folder, "libSkiaSharp.so*" ) )
				{
					if ( NativeLibrary.TryLoad( candidate, out var handle ) )
					{
						_skiaHandle = handle;
						Console.WriteLine( $"[NativeAOT] Skia preloaded from {candidate}" );
						return;
					}
				}
			}
		}

		Console.WriteLine( "[NativeAOT] Warning: failed to preload SkiaSharp from bin/linuxsteamrt64" );
	}

	void SetupEnvironment()
	{
		CultureInfo culture = (CultureInfo)CultureInfo.CurrentCulture.Clone();

		//
		// force GregorianCalendar, because that's how we're going to be parsing dates etc
		//
		if ( culture.DateTimeFormat.Calendar is not GregorianCalendar )
		{
			culture.DateTimeFormat.Calendar = new GregorianCalendar();
		}

		CultureInfo.DefaultThreadCurrentCulture = culture;
		CultureInfo.DefaultThreadCurrentUICulture = culture;
	}

	/// <summary>
	/// Create the Menu instance.
	/// </summary>
	protected void CreateMenu()
	{
		MenuDll.Create();
	}

	/// <summary>
	/// Create the Game (Sandbox.GameInstance)
	/// </summary>
	protected void CreateGame()
	{
		GameInstanceDll.Create();
	}

	/// <summary>
	/// Create the editor (Sandbox.Tools)
	/// </summary>
	protected void CreateEditor()
	{
		Editor.AssemblyInitialize.Initialize();
	}

	public void Run()
	{
		try
		{
			SetupEnvironment();

			Application.TryLoadVersionInfo( Environment.CurrentDirectory );

			//
			// Putting ErrorReporter.Initialize(); before Init here causes engine2.dll 
			// to be unable to load. I dont know wtf and I spent too much time looking into it.
			// It's finding the assemblies still, The last dll it loads is tier0.dll.
			//

			Init();

			NativeEngine.EngineGlobal.Plat_SetCurrentFrame( 0 );

			while ( RunFrame() )
			{
				BlockingLoopPumper.Run( () => RunFrame() );
			}

			Shutdown();
		}
		catch ( System.Exception e )
		{
			ErrorReporter.Initialize();
			ErrorReporter.ReportException( e );
			ErrorReporter.Flush();

			Console.WriteLine( $"Error: ({e.GetType()}) {e.Message}" );

			Environment.Exit( 1 );
		}
	}

	protected virtual bool RunFrame()
	{
		if ( !_appSystem.IsValid )
		{
			return false; // If appSystem is invalid, we want to quit.
		}

		EngineLoop.RunFrame( _appSystem, out bool wantsToQuit );

		return !wantsToQuit;
	}

	public virtual void Shutdown()
	{
		// Make sure game instance is closed
		IGameInstanceDll.Current?.CloseGame();

		// Send shutdown event, should allow us to track successful shutdown vs crash
		{
			var analytic = new Api.Events.EventRecord( "Exit" );
			analytic.SetValue( "uptime", RealTime.Now );
			// We could record a bunch of stats during the session and
			// submit them here. I'm thinking things like num games played
			// menus visited, time in menus, time in game, files downloaded.
			// Things to give us a whole session picture.
			analytic.Submit();
		}

		ConVarSystem.SaveAll();

		IToolsDll.Current?.Exiting();
		IMenuDll.Current?.Exiting();
		IGameInstanceDll.Current?.Exiting();

		SoundFile.Shutdown();
		SoundHandle.Shutdown();
		DedicatedServer.Shutdown();

		// Flush API
		Api.Shutdown();

		ConVarSystem.ClearNativeCommands();

		// Whatever package still exists needs to fuck off
		PackageManager.UnmountAll();

		// Clear static resources
		Texture.DisposeStatic();
		Model.DisposeStatic();
		Material.UI.DisposeStatic();
		Gizmo.GizmoDraw.DisposeStatic();
		CubemapRendering.DisposeStatic();
		Graphics.DisposeStatic();

		TextRendering.ClearCache();

		NativeResourceCache.Clear();

		// Renderpipeline may hold onto native resources, clear them out
		RenderPipeline.ClearPool();

		// Run GC and finalizers to clear any resources held by managed
		GC.Collect();
		GC.WaitForPendingFinalizers();

		// Run the queue one more time, since some finalizers queue tasks
		MainThread.RunQueues();

		// print each scene that is leaked
		foreach ( var leakedScene in Scene.All )
		{
			log.Warning( $"Leaked scene {leakedScene.Id} during shutdown." );
		}

		// Shut the engine down (close window etc)
		NativeEngine.EngineGlobal.SourceEngineShutdown( _appSystem, false );

		if ( _appSystem.IsValid )
		{
			_appSystem.Destroy();
			_appSystem = default;
		}

		if ( steamApiDll != IntPtr.Zero )
		{
			NativeLibrary.Free( steamApiDll );
			steamApiDll = default;
		}
		// Unload native dlls:
		// At this point we should no longer need them.
		// If we still hold references to native resources, we want it to crash here rather than on application exit.
		Managed.SandboxEngine.NativeInterop.Free();

		// No-ops if editor isn't loaded
		Managed.SourceTools.NativeInterop.Free();
		Managed.SourceAssetSytem.NativeInterop.Free();
		Managed.SourceHammer.NativeInterop.Free();
		Managed.SourceModelDoc.NativeInterop.Free();
		Managed.SourceAnimgraph.NativeInterop.Free();

		EngineFileSystem.Shutdown();
		Application.Shutdown();
	}

	// Backward-compatible overload: some callers expect the single-parameter signature.
	protected void InitGame( AppSystemCreateInfo createInfo )
	{
		InitGame( createInfo, null );
	}

	protected void InitGame( AppSystemCreateInfo createInfo, string commandLine = null )
	{
		commandLine ??= System.Environment.CommandLine;
		commandLine = commandLine.Replace( ".dll", ".exe" ); // uck

		_appSystem = CMaterialSystem2AppSystemDict.Create( createInfo.ToMaterialSystem2AppSystemDictCreateInfo() );

		if ( createInfo.Flags.HasFlag( AppSystemFlags.IsEditor ) )
		{
			_appSystem.SetInToolsMode();
		}

		if ( createInfo.Flags.HasFlag( AppSystemFlags.IsUnitTest ) )
		{
			_appSystem.SetInTestMode();
		}

		if ( createInfo.Flags.HasFlag( AppSystemFlags.IsStandaloneGame ) )
		{
			_appSystem.SetInStandaloneApp();
		}

		if ( createInfo.Flags.HasFlag( AppSystemFlags.IsDedicatedServer ) )
		{
			_appSystem.SetDedicatedServer( true );
		}

		_appSystem.SetSteamAppId( (uint)Application.AppId );

		if ( !NativeEngine.EngineGlobal.SourceEnginePreInit( commandLine, _appSystem ) )
		{
			throw new System.Exception( "SourceEnginePreInit failed" );
		}

		Bootstrap.PreInit( _appSystem );

		if ( createInfo.Flags.HasFlag( AppSystemFlags.IsStandaloneGame ) )
		{
			Standalone.Init();
		}

		if ( !NativeEngine.EngineGlobal.SourceEngineInit( _appSystem ) )
		{
			throw new System.Exception( "SourceEngineInit returned false" );
		}

		Bootstrap.Init();
	}

	protected void SetWindowTitle( string title )
	{
		if ( !_appSystem.IsValid ) return;
		_appSystem.SetAppWindowTitle( title );
	}
	IntPtr steamApiDll = IntPtr.Zero;

	/// <summary>
	/// Explicitly load the Steam Api dll from our bin folder, so that it doesn't accidentally
	/// load one from c:\system32\ or something. This is a problem when people have installed
	/// pirate versions of Steam in the past and have the assembly hanging around still. By loading
	/// it here we're saying use this version, and it won't try to load another one.
	/// </summary>
	protected void LoadSteamDll()
	{
		string dllName;
		if ( OperatingSystem.IsLinux() )
		{
			dllName = Path.Combine( Environment.CurrentDirectory, "bin", "linuxsteamrt64", "libsteam_api.so" );
		}
		else if ( OperatingSystem.IsWindows() )
		{
			dllName = $"{Environment.CurrentDirectory}\\bin\\win64\\steam_api64.dll";
		}
		else
		{
			// Unsupported platform for Steam API preload; let default probing handle it (will likely fail fast).
			return;
		}

		if ( !NativeLibrary.TryLoad( dllName, out steamApiDll ) )
		{
			throw new System.Exception( $"Couldn't load Steam API library: {dllName}" );
		}
	}
}
