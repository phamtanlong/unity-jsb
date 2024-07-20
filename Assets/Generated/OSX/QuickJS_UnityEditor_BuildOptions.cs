#if UNITY_EDITOR
#if UNITY_STANDALONE_OSX
// Unity: 2021.3.37f1
using System;
using System.Collections.Generic;

namespace jsb {
    using QuickJS.Errors;
    using JSValue = QuickJS.Native.JSValue;
    using JSApi = QuickJS.Native.JSApi;
    using JSNative = QuickJS.JSNative;
    using JSContext = QuickJS.Native.JSContext;
    using Values = QuickJS.Binding.Values;
    using ScriptEngine = QuickJS.ScriptEngine;
    using JSBindingAttribute = QuickJS.JSBindingAttribute;
    using MonoPInvokeCallbackAttribute = QuickJS.MonoPInvokeCallbackAttribute;
    // Assembly: UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Applications/Unity/Hub/Editor/2021.3.37f1/Unity.app/Contents/Managed/UnityEngine/UnityEditor.CoreModule.dll
    // Type: UnityEditor.BuildOptions
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_BuildOptions
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("BuildOptions", typeof(UnityEditor.BuildOptions));
            cls.AddConstValue("None", 0);
            cls.AddConstValue("CompressTextures", 0);
            cls.AddConstValue("StripDebugSymbols", 0);
            cls.AddConstValue("ForceOptimizeScriptCompilation", 0);
            cls.AddConstValue("Il2CPP", 0);
            cls.AddConstValue("Development", 1);
            cls.AddConstValue("AutoRunPlayer", 4);
            cls.AddConstValue("ShowBuiltPlayer", 8);
            cls.AddConstValue("BuildAdditionalStreamedScenes", 16);
            cls.AddConstValue("AcceptExternalModificationsToPlayer", 32);
            cls.AddConstValue("InstallInBuildFolder", 64);
            cls.AddConstValue("CleanBuildCache", 128);
            cls.AddConstValue("ConnectWithProfiler", 256);
            cls.AddConstValue("AllowDebugging", 512);
            cls.AddConstValue("SymlinkLibraries", 1024);
            cls.AddConstValue("SymlinkSources", 1024);
            cls.AddConstValue("UncompressedAssetBundle", 2048);
            cls.AddConstValue("ConnectToHost", 4096);
            cls.AddConstValue("CustomConnectionID", 8192);
            cls.AddConstValue("EnableHeadlessMode", 16384);
            cls.AddConstValue("BuildScriptsOnly", 32768);
            cls.AddConstValue("PatchPackage", 65536);
            cls.AddConstValue("ForceEnableAssertions", 131072);
            cls.AddConstValue("CompressWithLz4", 262144);
            cls.AddConstValue("CompressWithLz4HC", 524288);
            cls.AddConstValue("ComputeCRC", 1048576);
            cls.AddConstValue("StrictMode", 2097152);
            cls.AddConstValue("IncludeTestAssemblies", 4194304);
            cls.AddConstValue("NoUniqueIdentifier", 8388608);
            cls.AddConstValue("WaitForPlayerConnection", 33554432);
            cls.AddConstValue("EnableCodeCoverage", 67108864);
            cls.AddConstValue("EnableDeepProfilingSupport", 268435456);
            cls.AddConstValue("DetailedBuildReport", 536870912);
            cls.AddConstValue("ShaderLivelinkSupport", 1073741824);
            return cls;
        }
    }
}
#endif
#endif
