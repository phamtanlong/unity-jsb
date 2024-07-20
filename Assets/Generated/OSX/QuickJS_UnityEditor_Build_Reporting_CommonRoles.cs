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
    // Type: UnityEditor.Build.Reporting.CommonRoles
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_Build_Reporting_CommonRoles
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_scene(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Build.Reporting.CommonRoles.scene;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_sharedAssets(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Build.Reporting.CommonRoles.sharedAssets;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_resourcesFile(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Build.Reporting.CommonRoles.resourcesFile;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_assetBundle(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Build.Reporting.CommonRoles.assetBundle;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_manifestAssetBundle(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Build.Reporting.CommonRoles.manifestAssetBundle;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_assetBundleTextManifest(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Build.Reporting.CommonRoles.assetBundleTextManifest;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_managedLibrary(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Build.Reporting.CommonRoles.managedLibrary;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_dependentManagedLibrary(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Build.Reporting.CommonRoles.dependentManagedLibrary;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_executable(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Build.Reporting.CommonRoles.executable;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_streamingResourceFile(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Build.Reporting.CommonRoles.streamingResourceFile;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_streamingAsset(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Build.Reporting.CommonRoles.streamingAsset;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_bootConfig(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Build.Reporting.CommonRoles.bootConfig;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_builtInResources(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Build.Reporting.CommonRoles.builtInResources;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_builtInShaders(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Build.Reporting.CommonRoles.builtInShaders;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_appInfo(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Build.Reporting.CommonRoles.appInfo;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_managedEngineApi(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Build.Reporting.CommonRoles.managedEngineApi;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_monoRuntime(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Build.Reporting.CommonRoles.monoRuntime;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_monoConfig(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Build.Reporting.CommonRoles.monoConfig;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_debugInfo(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Build.Reporting.CommonRoles.debugInfo;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_globalGameManagers(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Build.Reporting.CommonRoles.globalGameManagers;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_crashHandler(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Build.Reporting.CommonRoles.crashHandler;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_engineLibrary(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Build.Reporting.CommonRoles.engineLibrary;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("CommonRoles", typeof(UnityEditor.Build.Reporting.CommonRoles), QuickJS.JSNative.class_private_ctor);
            cls.AddProperty(true, "scene", BindStaticRead_scene, null);
            cls.AddProperty(true, "sharedAssets", BindStaticRead_sharedAssets, null);
            cls.AddProperty(true, "resourcesFile", BindStaticRead_resourcesFile, null);
            cls.AddProperty(true, "assetBundle", BindStaticRead_assetBundle, null);
            cls.AddProperty(true, "manifestAssetBundle", BindStaticRead_manifestAssetBundle, null);
            cls.AddProperty(true, "assetBundleTextManifest", BindStaticRead_assetBundleTextManifest, null);
            cls.AddProperty(true, "managedLibrary", BindStaticRead_managedLibrary, null);
            cls.AddProperty(true, "dependentManagedLibrary", BindStaticRead_dependentManagedLibrary, null);
            cls.AddProperty(true, "executable", BindStaticRead_executable, null);
            cls.AddProperty(true, "streamingResourceFile", BindStaticRead_streamingResourceFile, null);
            cls.AddProperty(true, "streamingAsset", BindStaticRead_streamingAsset, null);
            cls.AddProperty(true, "bootConfig", BindStaticRead_bootConfig, null);
            cls.AddProperty(true, "builtInResources", BindStaticRead_builtInResources, null);
            cls.AddProperty(true, "builtInShaders", BindStaticRead_builtInShaders, null);
            cls.AddProperty(true, "appInfo", BindStaticRead_appInfo, null);
            cls.AddProperty(true, "managedEngineApi", BindStaticRead_managedEngineApi, null);
            cls.AddProperty(true, "monoRuntime", BindStaticRead_monoRuntime, null);
            cls.AddProperty(true, "monoConfig", BindStaticRead_monoConfig, null);
            cls.AddProperty(true, "debugInfo", BindStaticRead_debugInfo, null);
            cls.AddProperty(true, "globalGameManagers", BindStaticRead_globalGameManagers, null);
            cls.AddProperty(true, "crashHandler", BindStaticRead_crashHandler, null);
            cls.AddProperty(true, "engineLibrary", BindStaticRead_engineLibrary, null);
            return cls;
        }
    }
}
#endif
#endif
