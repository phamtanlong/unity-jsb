using System;
using System.Collections.Generic;

namespace QuickJS.Binding
{
    /// <summary>
    /// [EDITOR_ONLY] configuration for BindingManager
    /// you can use a json file at './js-bridge.json' without modifying the source file 'Prefs.cs'
    /// </summary>
    public class Prefs
    {
        /// <summary>
        /// location of this configuration
        /// </summary>
        public const string PATH = "js-bridge.json";

        /// <summary>
        /// the actual location of this configuration (valid only if loaded from disk)
        /// </summary>
        [NonSerialized]
        public string filePath;

        #region Configurable Fields

        /// <summary>
        /// the log file generated by the binding process
        /// </summary>
        public string logPath = "Logs/js-bridge.log";

        /// <summary>
        /// JSBehaviourScriptRef will parse 'modulePath' from 'JSBehaviourScriptRef.sourceFile' with this 'sourceDir'
        /// </summary>
        public string sourceDir = "Scripts/src";

        /// <summary>
        /// [optional] read this property as javascript dir for js_reload (https://github.com/ialex32x/plover)
        /// !! this property is read only when tsconfig.json can not be located at the project root path or compilerOptions.outDir is not configured
        /// </summary>
        public string javascriptDir = ""; // Scripts/out

        /// <summary>
        /// the output directory for generating static binding code
        /// </summary>
        public string outDir = "Assets/Generated/${platform}";

        /// <summary>
        /// the location of the corresponding d.ts of the generated binding code
        /// </summary>
        public string typescriptDir = "Assets/Generated/Typings";

        /// <summary>
        /// used for editor scripting to find out all unity classes implemented in typescript
        /// </summary>
        public string typescriptExt = ".ts";

        /// <summary>
        /// location of XmlDoc generated from Assembly-CSharp.dll 
        /// </summary>
        public string xmlDocDir = "Assets/Generated/Docs";

        /// <summary>
        /// output as a const field in generated code
        /// </summary>
        public string vendor = "";

        /// <summary>
        /// all related modules information generated in the binding process will be written into this file. 
        /// it's useful to mark these modules as external when using webpack for packaging.
        /// </summary>
        public string jsModulePackInfoPath = "jsb-modules.json";

        /// <summary>
        /// whether to generate doc comments in d.ts or not
        /// </summary>
        public bool genTypescriptDoc = true;

        /// <summary>
        /// enable editor scripting feature
        /// </summary>
        public bool editorScripting = true;

        /// <summary>
        /// [EDITOR_ONLY] preferred to bind types by reflection in editor without generating any binding code (useful for development stage in editor)
        /// ("Reflect Bind", "In-Memory Bind", "Static Bind")
        /// </summary>
        public string preferredBindingMethod = "Reflect Bind";

        /// <summary>
        /// generate binding code for operator overloading support in QuickJS (not fully supported). 
        /// operators will be generated as ordinary method (op_XXX) if disabled
        /// </summary>
        public bool enableOperatorOverloading = true;

        /// <summary>
        /// emit binding code for operator methods even if operator overlaoding enabled
        /// </summary>
        public bool alwaysEmitOperatorMethod = true;

        /// <summary>
        /// all obsolete types/members will not be exported if set true
        /// </summary>
        public bool excludeObsoleteItems = true;

        /// <summary>
        /// optional entry point for editor scripting
        /// </summary>
        public string editorEntryPoint = "";

        /// <summary>
        /// Asset Postprocessor(s) implemented in scripts
        /// </summary>
        public List<string> assetPostProcessors = new List<string>(new string[]
        {
            // "editor/asset_postprocessor",
        });

        public List<string> editorRequires = new List<string>(new string[]
        {
            "plover/editor/js_reload",
        });

        public string editorDecoratorScript = "plover/editor/editor_decorators";

        /// <summary>
        /// generate totally commented staticbind code for more conveniently debugging the codegen process itself
        /// </summary>
        public bool debugCodegen = false;

        /// <summary>
        /// omit all delegates with ByRef parameter
        /// </summary>
        public bool skipDelegateWithByRefParams = false;

        /// <summary>
        /// output more details to the log file
        /// </summary>
        public bool verboseLog = true;

        /// <summary>
        /// automatically rename ToString() into toString()
        /// </summary>
        public bool optToString = true;

        /// <summary>
        /// the d.ts will be split into parts with this file length threshold 
        /// </summary>
        public int tsdSizeThreshold = 512 * 1024;

        /// <summary>
        /// enable parameter type checking for methods (even if no overloading exists)
        /// </summary>
        public bool alwaysCheckArgType = false;

        /// <summary>
        /// enable checking the number of parameters even if not overloading exists
        /// </summary>
        public bool alwaysCheckArgc = true;

        /// <summary>
        /// [EXPERIMENTAL, UNFINISHED] generate obfuscated binding code
        /// </summary>
        public bool randomizedBindingCode = false;

        /// <summary>
        /// prefix of the type of generated binding code
        /// </summary>
        public string typeBindingPrefix = "QuickJS_";

        /// <summary>
        /// C# namespace for the generated glue code
        /// </summary>
        public string ns = "jsb";

        /// <summary>
        /// module name for the C# global types
        /// </summary>
        public string defaultJSModule = "global";

        /// <summary>
        /// the optional suffix for the generated d.ts file
        /// </summary>
        public string extraExtForTypescript = "";

        /// <summary>
        /// the new-line style for codegen (cr, lf, crlf). 
        /// it will depend on the operating system if not assigned.
        /// </summary>
        public string newLineStyle = "";

        /// <summary>
        /// the indent block for codegen
        /// </summary>
        public string tab = "    ";

        /// <summary>
        /// a list of BindingProcess not to run (type.FullName)
        /// </summary>
        public List<string> skipBinding = new List<string>(new string[]
        {
            // "jsb.Editor.UnityEditorBinding",
        });

        /// <summary>
        /// the directories will be cleaned up after code generation (only unused files will be deleted)
        /// </summary>
        public List<string> cleanupDir = new List<string>(new string[]
        {
            "Assets/Generated",
        });

        /// <summary>
        /// all the types in the listed assemblies will not be exported automatically
        /// </summary>
        public List<string> explicitAssemblies = new List<string>(new string[]
        {
            // "Assembly-CSharp-firstpass",
            "Assembly-CSharp",
        });

        /// <summary>
        /// all the types in the listed assemblies will be exported automatically (except the manually blocked types in BindingManager)
        /// </summary>
        public List<string> implicitAssemblies = new List<string>(new string[]
        {
            // "UnityEngine",
            // "UnityEngine.CoreModule",
            // "UnityEngine.UIModule",
            // "UnityEngine.TextRenderingModule",
            // "UnityEngine.TextRenderingModule",
            // "UnityEngine.UnityWebRequestWWWModule",
            // "UnityEngine.Physics2DModule",
            // "UnityEngine.AnimationModule",
            // "UnityEngine.TextRenderingModule",
            // "UnityEngine.IMGUIModule",
            // "UnityEngine.UnityWebRequestModule",
            // "UnityEngine.PhysicsModule",
            // "UnityEngine.UI",
        });

        public List<string> typeFullNameBlacklist = new List<string>(new string[]
        {
            "System.SpanExtensions",
            "UnityEditor.MaterialEditorExtensions",
            "UnityEditor.AppleMobileArchitecture",
            "UnityEngine.AndroidJavaException",
            "UnityEngine.AndroidJavaProxy",
            "UnityEngine.AndroidJavaObject",
            "UnityEngine.AndroidJavaClass",
            "UnityEngine.AndroidJNIHelper",
            "UnityEngine.AndroidJNI",
            "UnityEngine.AndroidActivityIndicatorStyle",
            "UnityEngine.Android.AndroidDevice",
            "UnityEngine.Android.Permission",
            "UnityEngine.AndroidInput",
            "UnityEditor.AndroidETC2Fallback",
            "UnityEditor.AndroidBuildSystem",
            "UnityEditor.AndroidBuildType",
            "UnityEditor.AndroidMinification",
            "UnityEditor.AndroidArchitecture",
            "UnityEditor.AndroidSdkVersions",
            "UnityEditor.AndroidPreferredInstallLocation",
            "UnityEditor.AndroidShowActivityIndicatorOnLoading",
            "UnityEditor.AndroidGamepadSupportLevel",
            "UnityEditor.AndroidSplashScreenScale",
            "UnityEditor.AndroidBlitType",
            "UnityEditor.AndroidETC2FallbackOverride",
            "UnityEditor.Android.IPostGenerateGradleAndroidProject",
            "UnityEditor.WSASubtarget",
            "UnityEditor.WSASDK",
            "UnityEditor.WSAUWPBuildType",
            "UnityEditor.WSABuildAndRunDeployTarget",
            "UnityEditor.WSABuildType",
            "UnityEditor.HumanTemplate", 
            "UnityEditor.TakeInfo", 
            "UnityEditor.L10n", 
            "UnityEditor.Build.Reporting", 
            "UnityEditor.TypeCache", 
            "UnityEditor.SceneManagement.ObjectOverride", 
            "UnityEditor.SceneManagement.PrefabOverride", 
            "UnityEditor.SceneManagement.AddedGameObject", 
            "UnityEditor.SceneManagement.AddedComponent", 
            "UnityEditor.SceneManagement.RemovedComponent", 
        });

        public List<string> namespaceBlacklist = new List<string>(new string[]
        {
            "TreeEditor",
            "UnityEditor.U2D", 
            "UnityEditor.Rendering", 
            "UnityEditor.AssetImporters", 
            "UnityEditor.Audio", 
            "UnityEditor.Build.Player", 
            "Unity.CodeEditor",
            "UnityEditor.Sprites",
            "UnityEditor.Experimental",
            "UnityEngine.Assertions",
            "UnityEngine.Experimental.AI",
            "UnityEngine.Experimental.Animations",
            "UnityEngine.Experimental.AssetBundlePatching",
            "UnityEngine.Experimental.Audio",
            "UnityEngine.Experimental.Networking.PlayerConnection",
            "UnityEngine.Experimental.GlobalIllumination",
            "UnityEngine.Experimental.Playables",
            "UnityEngine.Experimental.Rendering",
            "UnityEngine.Experimental.TerrainAPI",
            "UnityEngine.Experimental.XR",
            "UnityEngine.Experimental.Video",
            "UnityEditor.Experimental.U2D",
            "UnityEngine.Jobs",
            "Unity.Jobs",
            "Unity.Profiling",
            "Unity.Profiling.LowLevel",
            "Unity.Jobs.LowLevel.Unsafe",
            "Unity.Collections.LowLevel.Unsafe",
            "UnityEngine.Apple.ReplayKit",
            "UnityEditor.VisualStudioIntegration",
            "UnityEditor.Profiling.Memory.Experimental",
            "UnityEditor.Profiling",
            "UnityEditor.UIElements",
            "UnityEditor.Animations",
            "UnityEditor.Experimental.AssetImporters",
            "UnityEditor.Experimental.SceneManagement",
            "UnityEngineInternal",
            "UnityEditorInternal",
            "UnityEditorInternal.VersionControl",
            "JetBrains.Annotations",
            "Unity.IO.LowLevel.Unsafe",
            "Unity.Collections",
            "UnityEditor.UnityLinker",
            "UnityEditor.Il2Cpp",
            "UnityEditor.Experimental.Rendering",
            "UnityEditor.Experimental.GraphView",
            "UnityEditor.Experimental.Licensing",
            "UnityEditor.Experimental.TerrainAPI",
            "UnityEditor.XR",
            "UnityEditor.XR.Daydream",
            "UnityEditorInternal.Profiling.Memory.Experimental",
            "UnityEditorInternal.Profiling.Memory.Experimental.FileFormat",
            "UnityEditor.Build.Content",
            "UnityEditor.AnimatedValues",
            "UnityEditor.AI",
            "UnityEditor.Macros",
            "UnityEditor.Experimental.Networking.PlayerConnection",
            "UnityEditor.Compilation",
            "UnityEditor.Networking.PlayerConnection",
            "UnityEditor.VersionControl",
            "UnityEditor.Localization.Editor",
            "UnityEditor.CrashReporting",
            "UnityEditor.ShaderProfiler",
            "UnityEditor.MemoryProfiler",
            "UnityEditor.ShortcutManagement",
            "UnityEditorInternal.VR",
            "UnityEditor.Presets",
            "UnityEditor.PackageManager",
            "UnityEditor.PackageManager.UI",
            "UnityEditor.PackageManager.Requests",
            "SyntaxTree.VisualStudio.Unity.Messaging", 
        });

        public List<string> assemblyBlacklist = new List<string>(new string[]
        {
            "ExCSS.Unity",
            "Unity.Cecil",
            "Unity.Cecil.Mdb",
            "Unity.Cecil.Pdb",
            "Unity.Cecil.Rocks",
            "Unity.CecilTools",
        });

        #endregion

        #region Runtime Methods

        public string newline
        {
            get
            {
                if (newLineStyle == null)
                {
                    return Environment.NewLine;
                }

                switch (newLineStyle.ToLower())
                {
                    case "cr": return "\r";
                    case "lf": return "\n";
                    case "crlf": return "\r\n";
                    case "":
                    case "auto": return Environment.NewLine;
                    default: return newLineStyle;
                }
            }
        }

        #endregion
    }
}