using System.Runtime.InteropServices;
using System.IO;
using System;
using System.Diagnostics;
using System.Text;
using System.Text.Json;
using Bawstudios.OS27.CUtl;
using Bawstudios.OS27.Common;
using NativeEngine;

namespace Bawstudios.OS27.Resource;

/// <summary>
/// Module d'émulation pour ResourceCompilerSystem (g_pRsrcCmplrSyst_*).
/// Gère la compilation des ressources depuis leur format source vers des fichiers compilés.
/// </summary>
public static unsafe class ResourceCompilerSystem
{
    private static bool LogMinimal = true;
    private static bool LogAll = true;
    private static void LogCall(string name, bool minimal, string message = "")
    {
        if (!(LogAll || (LogMinimal && minimal))) return;
        Console.WriteLine($"[NativeAOT][RC] {name} {message}");
    }

    /// <summary>
    /// Initialise le module ResourceCompilerSystem en patchant toutes les fonctions natives.
    /// </summary>
    public static void Init(void** native)
    {
        LogCall(nameof(Init), minimal: true);
        // ResourceCompilerSystem functions (indices 1512-1514 depuis Interop.Engine.cs ligne 16259-16261)
        native[1512] = (void*)(delegate* unmanaged<IntPtr, IntPtr, int, int>)&g_pRsrcCmplrSyst_GenerateResourceFile;
        native[1513] = (void*)(delegate* unmanaged<IntPtr, IntPtr, int>)&g_pRsrcCmplrSyst_GenerateResourceFile_1;
        native[1514] = (void*)(delegate* unmanaged<IntPtr, IntPtr, int, IntPtr>)&g_pRsrcCmplrSyst_GenerateResourceBytes;
    }

    // ============================================================================
    // ResourceCompilerSystem Functions (g_pRsrcCmplrSyst_*)
    // Signatures exactes depuis Interop.Engine.cs ligne 7020-7022
    // ============================================================================

    /// <summary>
    /// Génère un fichier de ressource depuis des données binaires.
    /// Cette fonction compile des ressources (matériaux, modèles, etc.) en fichiers binaires compilés.
    /// Signature exacte depuis Interop.Engine.cs: delegate* unmanaged&lt; IntPtr, IntPtr, int, int &gt;
    /// Retourne 1 en cas de succès, 0 en cas d'échec.
    /// </summary>
    [UnmanagedCallersOnly]
    public static int g_pRsrcCmplrSyst_GenerateResourceFile(IntPtr path, IntPtr pData, int size)
    {
        LogCall(nameof(g_pRsrcCmplrSyst_GenerateResourceFile), minimal: true, message: $"path=0x{path.ToInt64():X} data=0x{pData.ToInt64():X} size={size}");
        if (path == IntPtr.Zero || pData == IntPtr.Zero || size <= 0)
        {
            LogCall(nameof(g_pRsrcCmplrSyst_GenerateResourceFile), minimal: true, message: "invalid parameters");
            return 0; // Échec
        }
        
        string? pathStr = Marshal.PtrToStringUTF8(path);
        LogCall(nameof(g_pRsrcCmplrSyst_GenerateResourceFile), minimal: true, message: $"path={pathStr} size={size}");
        
        try
        {
            // Lire les données depuis le pointeur
            byte[] data = new byte[size];
            Marshal.Copy(pData, data, 0, size);
            
            // Écrire le fichier compilé
            if (!string.IsNullOrEmpty(pathStr))
            {
                // S'assurer que le répertoire existe
                string? directory = Path.GetDirectoryName(pathStr);
                if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                
                File.WriteAllBytes(pathStr, data);
                Console.WriteLine($"[NativeAOT] g_pRsrcCmplrSyst_GenerateResourceFile: Successfully wrote {size} bytes to {pathStr}");
                return 1; // Succès
            }
        }
        catch (Exception ex)
        {
            LogCall(nameof(g_pRsrcCmplrSyst_GenerateResourceFile), minimal: true, message: $"exception={ex.Message}");
        }
        
        return 0; // Échec
    }

    /// <summary>
    /// Génère un fichier de ressource depuis du texte (JSON, etc.).
    /// Cette fonction compile des ressources depuis leur format texte source vers un fichier compilé.
    /// Signature exacte depuis Interop.Engine.cs: delegate* unmanaged&lt; IntPtr, IntPtr, int &gt;
    /// Retourne 1 en cas de succès, 0 en cas d'échec.
    /// </summary>
    [UnmanagedCallersOnly]
    public static int g_pRsrcCmplrSyst_GenerateResourceFile_1(IntPtr path, IntPtr text)
    {
        LogCall(nameof(g_pRsrcCmplrSyst_GenerateResourceFile_1), minimal: true, message: $"path=0x{path.ToInt64():X} text=0x{text.ToInt64():X}");
        if (path == IntPtr.Zero || text == IntPtr.Zero)
        {
            LogCall(nameof(g_pRsrcCmplrSyst_GenerateResourceFile_1), minimal: true, message: "invalid parameters");
            return 0; // Échec
        }
        
        string? pathStr = Marshal.PtrToStringUTF8(path);
        string? textStr = Marshal.PtrToStringUTF8(text);
        LogCall(nameof(g_pRsrcCmplrSyst_GenerateResourceFile_1), minimal: true, message: $"path={pathStr} textLen={textStr?.Length ?? 0}");
        
        try
        {
            if (!string.IsNullOrEmpty(pathStr) && !string.IsNullOrEmpty(textStr))
            {
                // S'assurer que le répertoire existe
                string? directory = Path.GetDirectoryName(pathStr);
                if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                
                // Écrire le texte dans le fichier
                File.WriteAllText(pathStr, textStr);
                Console.WriteLine($"[NativeAOT] g_pRsrcCmplrSyst_GenerateResourceFile_1: Successfully wrote text to {pathStr}");
                return 1; // Succès
            }
        }
        catch (Exception ex)
        {
            LogCall(nameof(g_pRsrcCmplrSyst_GenerateResourceFile_1), minimal: true, message: $"exception={ex.Message}");
        }
        
        return 0; // Échec
    }

    /// <summary>
    /// Génère des bytes de ressource depuis des données binaires.
    /// Cette fonction compile des ressources et retourne un CUtlBuffer contenant les données compilées.
    /// Signature exacte depuis Interop.Engine.cs: delegate* unmanaged&lt; IntPtr, IntPtr, int, IntPtr &gt;
    /// Retourne un IntPtr vers un CUtlBuffer, ou IntPtr.Zero en cas d'échec.
    /// </summary>
    [UnmanagedCallersOnly]
    public static IntPtr g_pRsrcCmplrSyst_GenerateResourceBytes(IntPtr path, IntPtr pData, int size)
    {
        LogCall(nameof(g_pRsrcCmplrSyst_GenerateResourceBytes), minimal: true, message: $"path=0x{path.ToInt64():X} data=0x{pData.ToInt64():X} size={size}");
        if (path == IntPtr.Zero || pData == IntPtr.Zero || size <= 0)
        {
            LogCall(nameof(g_pRsrcCmplrSyst_GenerateResourceBytes), minimal: true, message: "invalid parameters");
            return IntPtr.Zero;
        }
        
        string? pathStr = Marshal.PtrToStringUTF8(path);
        LogCall(nameof(g_pRsrcCmplrSyst_GenerateResourceBytes), minimal: true, message: $"path={pathStr} size={size}");
        
        try
        {
            // Copier les données dans un buffer managé (pour inspection/écriture)
            byte[] data = new byte[size];
            Marshal.Copy(pData, data, 0, size);

            // Tentative de conversion HLSL -> GLSL (profil GL330) si le payload contient du texte JSON avec "Programs"
            byte[]? glslPayload = TryConvertToGlsl330(pathStr, data);
            if (glslPayload != null)
            {
                data = glslPayload;
                size = data.Length;
            }

            IntPtr bufferPtr = Marshal.AllocHGlobal(size);
            unsafe
            {
                fixed (byte* src = data)
                {
                byte* dst = (byte*)bufferPtr;
                    Buffer.MemoryCopy(src, dst, size, size);
                }
            }

            // Envelopper dans un CUtlBuffer.BufferData pour que le wrapper CUtlBuffer (C#) connaisse Size/MaxPut
            var bufferData = new Bawstudios.OS27.CUtl.CUtlBuffer.BufferData
            {
                DataPtr = bufferPtr,
                Size = size,
                MaxPut = size
            };

            int handle = HandleManager.Register(bufferData);
            if (handle == 0)
            {
                Marshal.FreeHGlobal(bufferPtr);
                return IntPtr.Zero;
            }

            // Écrire aussi un artefact .shader_c sur disque pour réutilisation runtime
            if (!string.IsNullOrEmpty(pathStr))
            {
                try
                {
                    string outPath = Path.ChangeExtension(pathStr, ".shader_c");
                    string? directory = Path.GetDirectoryName(outPath);
                    if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
                    {
                        Directory.CreateDirectory(directory);
                    }

                    File.WriteAllBytes(outPath, data);
                    Console.WriteLine($"[NativeAOT] g_pRsrcCmplrSyst_GenerateResourceBytes: wrote {size} bytes to {outPath}");
                }
                catch (Exception ex)
                {
                    LogCall(nameof(g_pRsrcCmplrSyst_GenerateResourceBytes), minimal: true, message: $"write shader_c failed: {ex.Message}");
                }
            }

            Console.WriteLine($"[NativeAOT] g_pRsrcCmplrSyst_GenerateResourceBytes: Allocated {size} bytes at 0x{bufferPtr.ToInt64():X} handle={handle}");
            return (IntPtr)handle;
        }
        catch (Exception ex)
        {
            LogCall(nameof(g_pRsrcCmplrSyst_GenerateResourceBytes), minimal: true, message: $"exception={ex.Message}");
            return IntPtr.Zero;
        }
    }

    /// <summary>
    /// Si possible, convertit un payload HLSL (JSON "Programs") en GLSL 330. Retourne null si non applicable.
    /// </summary>
    private static byte[]? TryConvertToGlsl330(string? pathStr, byte[] data)
    {
        try
        {
            // Chercher le premier '{' pour isoler un éventuel JSON
            string text = Encoding.UTF8.GetString(data);
            int brace = text.IndexOf('{');
            if (brace < 0) return null;
            string json = text.Substring(brace);

            using var doc = JsonDocument.Parse(json);
            if (!doc.RootElement.TryGetProperty("Programs", out var programs))
                return null;

            var ms = new MemoryStream();
            var outJson = new Utf8JsonWriter(ms, new JsonWriterOptions { Indented = false });
            outJson.WriteStartObject();
            outJson.WriteString("Profile", "glsl330");
            outJson.WritePropertyName("Programs");
            outJson.WriteStartObject();

            foreach (var prop in programs.EnumerateObject())
            {
                string stageKey = prop.Name;
                string hlsl = prop.Value.GetString() ?? string.Empty;
                string? glsl = CompileHlslToGlsl(stageKey, hlsl, pathStr);
                if (glsl == null)
                {
                    // fallback: garder l’original
                    glsl = hlsl;
                }
                outJson.WriteString(stageKey, glsl);
            }

            outJson.WriteEndObject(); // Programs
            outJson.WriteEndObject(); // Root
            outJson.Flush();

            return ms.ToArray();
        }
        catch (Exception ex)
        {
            LogCall(nameof(TryConvertToGlsl330), minimal: true, message: $"convert failed: {ex.Message}");
            return null;
        }
    }

    private static string? CompileHlslToGlsl(string stageKey, string hlslSource, string? pathStr)
    {
        // Map stage
        string entry = stageKey switch
        {
            "VFX_PROGRAM_VS" => "MainVs",
            "VFX_PROGRAM_PS" => "MainPs",
            "VFX_PROGRAM_CS" => "MainCs",
            _ => "main"
        };
        string target = stageKey switch
        {
            "VFX_PROGRAM_VS" => "vs_6_0",
            "VFX_PROGRAM_PS" => "ps_6_0",
            "VFX_PROGRAM_CS" => "cs_6_0",
            _ => "vs_6_0"
        };
        string programDefine = stageKey switch
        {
            "VFX_PROGRAM_VS" => "VFX_PROGRAM_VS",
            "VFX_PROGRAM_PS" => "VFX_PROGRAM_PS",
            "VFX_PROGRAM_CS" => "VFX_PROGRAM_CS",
            "VFX_PROGRAM_GS" => "VFX_PROGRAM_GS",
            "VFX_PROGRAM_HS" => "VFX_PROGRAM_HS",
            "VFX_PROGRAM_DS" => "VFX_PROGRAM_DS",
            _ => "VFX_PROGRAM_VS"
        };

        string tempHlsl = Path.GetTempFileName();
        string tempSpv = Path.GetTempFileName();
        string tempGlsl = Path.GetTempFileName();

        try
        {
            // Stripping VFX-specific blocks (FEATURES/MODES) not understood by dxc.
            // TODO: Implémenter un préprocesseur VFX qui génère les permutations (FEATURES/MODES) avant dxc,
            //       ici on retire juste ces blocs pour compiler une variante par défaut.
            var processedSource = PreprocessShaderSource(hlslSource);
            File.WriteAllText(tempHlsl, processedSource, Encoding.UTF8);

            var dxcPath = FindTool("dxc");
            var spvcPath = FindTool("spirv-cross");
            if (dxcPath == null || spvcPath == null)
            {
                LogCall(nameof(CompileHlslToGlsl), minimal: true, message: "tool not found (dxc/spirv-cross)");
                return null;
            }

            // DXC -> SPV
            var includeArgs = BuildIncludeArgs(pathStr);
            var dxcArgs = $"{includeArgs}-D PROGRAM={programDefine} -spirv -T {target} -E {entry} -fvk-use-dx-layout -fspv-target-env=vulkan1.1 -Fo \"{tempSpv}\" \"{tempHlsl}\"";
            var dxcRes = RunTool(dxcPath, dxcArgs);
            if (!dxcRes.Success || !File.Exists(tempSpv))
            {
                LogCall(nameof(CompileHlslToGlsl), minimal: true, message: $"dxc failed: {dxcRes.Stdout} {dxcRes.Stderr}");
                return null;
            }

            // SPIRV-Cross -> GLSL 330
            var spvcArgs = $"--version 330 --output \"{tempGlsl}\" \"{tempSpv}\"";
            var spvcRes = RunTool(spvcPath, spvcArgs);
            if (!spvcRes.Success || !File.Exists(tempGlsl))
            {
                LogCall(nameof(CompileHlslToGlsl), minimal: true, message: $"spirv-cross failed: {spvcRes.Stdout} {spvcRes.Stderr}");
                return null;
            }

            string glsl = File.ReadAllText(tempGlsl, Encoding.UTF8);
            return glsl;
        }
        catch (Exception ex)
        {
            LogCall(nameof(CompileHlslToGlsl), minimal: true, message: $"exception: {ex.Message}");
            return null;
        }
        finally
        {
            TryDelete(tempHlsl);
            TryDelete(tempSpv);
            TryDelete(tempGlsl);
        }
    }

    private static string? FindTool(string name)
    {
        // Simple PATH lookup
        var envPath = Environment.GetEnvironmentVariable("PATH") ?? string.Empty;
        foreach (var p in envPath.Split(Path.PathSeparator, StringSplitOptions.RemoveEmptyEntries))
        {
            var cand = Path.Combine(p, name);
            if (File.Exists(cand)) return cand;
            if (OperatingSystem.IsWindows())
            {
                var exe = cand + ".exe";
                if (File.Exists(exe)) return exe;
            }
        }
        return null;
    }

    private static (bool Success, string Stdout, string Stderr) RunTool(string exe, string args)
    {
        var psi = new ProcessStartInfo
        {
            FileName = exe,
            Arguments = args,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };
        var p = Process.Start(psi)!;
        var stdout = p.StandardOutput.ReadToEnd();
        var stderr = p.StandardError.ReadToEnd();
        p.WaitForExit();
        return (p.ExitCode == 0, stdout, stderr);
    }

    private static string PreprocessShaderSource(string src)
    {
        // Supprime les blocs FEATURES/MODES (langage VFX non supporté par dxc).
        // TODO: implémenter un préprocesseur VFX qui génère les permutations avant la compilation.
        string StripBlock(string text, string keyword)
        {
            int start = text.IndexOf(keyword, StringComparison.OrdinalIgnoreCase);
            while (start >= 0)
            {
                int brace = text.IndexOf('{', start);
                if (brace < 0) break;
                int depth = 0;
                int i = brace;
                for (; i < text.Length; i++)
                {
                    if (text[i] == '{') depth++;
                    else if (text[i] == '}')
                    {
                        depth--;
                        if (depth == 0)
                        {
                            text = text.Remove(start, (i - start) + 1);
                            break;
                        }
                    }
                }
                if (i >= text.Length) break;
                start = text.IndexOf(keyword, start, StringComparison.OrdinalIgnoreCase);
            }
            return text;
        }

        string result = src;
        result = StripBlock(result, "FEATURES");
        result = StripBlock(result, "MODES");
        return result;
    }

    private static string BuildIncludeArgs(string? pathStr)
    {
        var sb = new StringBuilder();
        var dirs = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        void AddDir(string? dir)
        {
            if (string.IsNullOrWhiteSpace(dir)) return;
            var full = Path.GetFullPath(dir);
            if (Directory.Exists(full))
            {
                dirs.Add(full);
            }
        }

        try
        {
            // 1) Dossier du fichier source
            if (!string.IsNullOrEmpty(pathStr))
            {
                AddDir(Path.GetDirectoryName(pathStr));
                // Trouver le dossier contenant system.fxc en remontant depuis le shader
                var systemFxcDirFromShader = FindDirContaining("game/core/shaders/system.fxc", Path.GetDirectoryName(pathStr)!);
                AddDir(systemFxcDirFromShader);
                if (!string.IsNullOrEmpty(systemFxcDirFromShader))
                {
                    var gameRoot = Directory.GetParent(systemFxcDirFromShader)?.Parent?.FullName; // .../game
                    AddDir(gameRoot);
                    if (!string.IsNullOrEmpty(gameRoot))
                    {
                        AddDir(Path.Combine(gameRoot, "addons", "base", "Assets", "shaders"));
                    }
                }
            }

            // 2) CWD
            AddDir(Directory.GetCurrentDirectory());

            // 3) Racine repo candidate en partant de CWD (cherche system.fxc)
            var rootFromCwd = FindDirContaining("game/core/shaders/system.fxc", Directory.GetCurrentDirectory());
            AddDir(rootFromCwd);
            if (!string.IsNullOrEmpty(rootFromCwd))
            {
                AddDir(Path.Combine(rootFromCwd, "game")); // au cas où
                AddDir(Path.Combine(rootFromCwd, "game", "addons", "base", "Assets", "shaders"));
            }

            // 4) Racine repo candidate en partant de AppContext.BaseDirectory (cas Tool)
            var rootFromBase = FindDirContaining("game/core/shaders/system.fxc", AppContext.BaseDirectory ?? Directory.GetCurrentDirectory());
            AddDir(rootFromBase);
            if (!string.IsNullOrEmpty(rootFromBase))
            {
                AddDir(Path.Combine(rootFromBase, "game"));
                AddDir(Path.Combine(rootFromBase, "game", "addons", "base", "Assets", "shaders"));
            }

            // 5) Dossier game/core/shaders si trouvé
            var coreFromCwd = Path.Combine(Directory.GetCurrentDirectory(), "game", "core", "shaders");
            AddDir(coreFromCwd);
            var coreFromBase = Path.Combine(AppContext.BaseDirectory ?? Directory.GetCurrentDirectory(), "..", "..", "..", "..", "game", "core", "shaders");
            AddDir(coreFromBase);

            // 6) Dossier shaders communs addon base (features.hlsl, etc.) depuis CWD/base dir direct
            var baseShadersFromCwd = Path.Combine(Directory.GetCurrentDirectory(), "game", "addons", "base", "Assets", "shaders");
            AddDir(baseShadersFromCwd);
            var baseShadersFromBase = Path.Combine(AppContext.BaseDirectory ?? Directory.GetCurrentDirectory(), "..", "..", "..", "..", "game", "addons", "base", "Assets", "shaders");
            AddDir(baseShadersFromBase);
        }
        catch
        {
            // ignore include resolution failure
        }

        foreach (var d in dirs)
        {
            sb.Append($"-I \"{d}\" ");
        }

        return sb.ToString();
    }

    private static string? FindDirContaining(string relativePath, string startDir)
    {
        try
        {
            var dir = Path.GetFullPath(startDir);
            for (int i = 0; i < 6; i++)
            {
                var candidate = Path.Combine(dir, relativePath);
                if (File.Exists(candidate))
                {
                    return Path.GetDirectoryName(candidate);
                }
                var parent = Directory.GetParent(dir);
                if (parent == null) break;
                dir = parent.FullName;
            }
        }
        catch
        {
            // ignore
        }
        return null;
    }

    private static void TryDelete(string path)
    {
        try { if (!string.IsNullOrEmpty(path) && File.Exists(path)) File.Delete(path); }
        catch { /* ignore */ }
    }
}

