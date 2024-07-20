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
    // Type: UnityEditor.BuildAssetBundleOptions
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_BuildAssetBundleOptions
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("BuildAssetBundleOptions", typeof(UnityEditor.BuildAssetBundleOptions));
            cls.AddConstValue("None", 0);
            cls.AddConstValue("UncompressedAssetBundle", 1);
            cls.AddConstValue("CollectDependencies", 2);
            cls.AddConstValue("CompleteAssets", 4);
            cls.AddConstValue("DisableWriteTypeTree", 8);
            cls.AddConstValue("DeterministicAssetBundle", 16);
            cls.AddConstValue("ForceRebuildAssetBundle", 32);
            cls.AddConstValue("IgnoreTypeTreeChanges", 64);
            cls.AddConstValue("AppendHashToAssetBundleName", 128);
            cls.AddConstValue("ChunkBasedCompression", 256);
            cls.AddConstValue("StrictMode", 512);
            cls.AddConstValue("DryRunBuild", 1024);
            cls.AddConstValue("DisableLoadAssetByFileName", 4096);
            cls.AddConstValue("DisableLoadAssetByFileNameWithExtension", 8192);
            cls.AddConstValue("AssetBundleStripUnityVersion", 32768);
            cls.AddConstValue("UseContentHash", 65536);
            return cls;
        }
    }
}
#endif
#endif
