using System;
using System.Linq;

namespace Sandbox;

public static class Program
{
	/// <summary>
	/// Because the dlls aren't next to the exe, we need to do a dance to init all the paths before
	/// any of the types are touched. To do this we init in the main, here, and then call Launch which
	/// will call your applcation defined code.
	/// </summary>
	[STAThread]
	public static int Main( string[] args )
	{
		ApplyEngineArgument( args ?? Array.Empty<string>() );
		LauncherEnvironment.Init();
		return Launch();
	}

	static int Launch()
	{
		return Launcher.Main();
	}

	static void ApplyEngineArgument( string[] args )
	{
		const string defaultEngine = "source2";
		var engine = defaultEngine;

		var engineArg = args.FirstOrDefault( a => a.StartsWith( "--engine=", StringComparison.OrdinalIgnoreCase ) );
		if ( engineArg is not null )
		{
			var value = engineArg["--engine=".Length..].Trim().ToLowerInvariant();
			if ( value is "source2" or "os27" )
			{
				engine = value;
			}
			else
			{
				Console.WriteLine( $"[Launcher] Valeur --engine invalide '{value}'. Options valides : source2 | os27." );
				Environment.Exit( 1 );
			}
		}

		var libName = ResolveEngineLibName( engine );
		Environment.SetEnvironmentVariable( "SBOX_ENGINE", engine );
		Environment.SetEnvironmentVariable( "SBOX_ENGINE_LIB", libName );
		Console.WriteLine( $"[Startup] Engine sélectionné: {engine}, lib: {libName}" );
	}

	static string ResolveEngineLibName( string engine )
	{
		var linux = OperatingSystem.IsLinux();
		var windows = OperatingSystem.IsWindows();

		return engine switch
		{
			"os27" when linux => "libos27.so",
			"os27" when windows => "os27.dll",
			"os27" => "libos27.dylib",
			_ when linux => "libengine2.so",
			_ when windows => "engine2.dll",
			_ => "libengine2.dylib"
		};
	}
}
