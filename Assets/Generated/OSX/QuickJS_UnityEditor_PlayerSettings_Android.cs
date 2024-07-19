#if UNITY_EDITOR
#if UNITY_STANDALONE_OSX
// Unity: 2019.4.40f1
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
    // Assembly: UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Applications/Unity/Hub/Editor/2019.4.40f1/Unity.app/Contents/Managed/UnityEditor.dll
    // Type: UnityEditor.PlayerSettings+Android
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_PlayerSettings_Android
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                if (argc == 0)
                {
                    var o = new UnityEditor.PlayerSettings.Android();
                    var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                    return val;
                }
                throw new NoSuitableMethodException("constructor", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_disableDepthAndStencilBuffers(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Android.disableDepthAndStencilBuffers;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_disableDepthAndStencilBuffers(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Android), "disableDepthAndStencilBuffers", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.Android.disableDepthAndStencilBuffers = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_defaultWindowWidth(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Android.defaultWindowWidth;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_defaultWindowWidth(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Android), "defaultWindowWidth", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.Android.defaultWindowWidth = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_defaultWindowHeight(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Android.defaultWindowHeight;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_defaultWindowHeight(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Android), "defaultWindowHeight", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.Android.defaultWindowHeight = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_minimumWindowWidth(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Android.minimumWindowWidth;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_minimumWindowWidth(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Android), "minimumWindowWidth", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.Android.minimumWindowWidth = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_minimumWindowHeight(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Android.minimumWindowHeight;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_minimumWindowHeight(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Android), "minimumWindowHeight", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.Android.minimumWindowHeight = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_resizableWindow(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Android.resizableWindow;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_resizableWindow(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Android), "resizableWindow", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.Android.resizableWindow = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_fullscreenMode(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Android.fullscreenMode;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_fullscreenMode(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.FullScreenMode value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Android), "fullscreenMode", typeof(UnityEngine.FullScreenMode), 0);
                }
                UnityEditor.PlayerSettings.Android.fullscreenMode = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_bundleVersionCode(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Android.bundleVersionCode;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_bundleVersionCode(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Android), "bundleVersionCode", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.Android.bundleVersionCode = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_minSdkVersion(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Android.minSdkVersion;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_minSdkVersion(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.AndroidSdkVersions value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Android), "minSdkVersion", typeof(UnityEditor.AndroidSdkVersions), 0);
                }
                UnityEditor.PlayerSettings.Android.minSdkVersion = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_targetSdkVersion(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Android.targetSdkVersion;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_targetSdkVersion(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.AndroidSdkVersions value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Android), "targetSdkVersion", typeof(UnityEditor.AndroidSdkVersions), 0);
                }
                UnityEditor.PlayerSettings.Android.targetSdkVersion = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_preferredInstallLocation(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Android.preferredInstallLocation;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_preferredInstallLocation(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.AndroidPreferredInstallLocation value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Android), "preferredInstallLocation", typeof(UnityEditor.AndroidPreferredInstallLocation), 0);
                }
                UnityEditor.PlayerSettings.Android.preferredInstallLocation = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_forceInternetPermission(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Android.forceInternetPermission;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_forceInternetPermission(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Android), "forceInternetPermission", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.Android.forceInternetPermission = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_forceSDCardPermission(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Android.forceSDCardPermission;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_forceSDCardPermission(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Android), "forceSDCardPermission", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.Android.forceSDCardPermission = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_androidTVCompatibility(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Android.androidTVCompatibility;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_androidTVCompatibility(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Android), "androidTVCompatibility", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.Android.androidTVCompatibility = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_androidIsGame(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Android.androidIsGame;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_androidIsGame(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Android), "androidIsGame", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.Android.androidIsGame = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_ARCoreEnabled(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Android.ARCoreEnabled;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_ARCoreEnabled(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Android), "ARCoreEnabled", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.Android.ARCoreEnabled = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_chromeosInputEmulation(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Android.chromeosInputEmulation;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_chromeosInputEmulation(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Android), "chromeosInputEmulation", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.Android.chromeosInputEmulation = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_targetArchitectures(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Android.targetArchitectures;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (uint)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_targetArchitectures(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.AndroidArchitecture value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Android), "targetArchitectures", typeof(UnityEditor.AndroidArchitecture), 0);
                }
                UnityEditor.PlayerSettings.Android.targetArchitectures = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_buildApkPerCpuArchitecture(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Android.buildApkPerCpuArchitecture;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_buildApkPerCpuArchitecture(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Android), "buildApkPerCpuArchitecture", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.Android.buildApkPerCpuArchitecture = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_androidTargetDevices(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Android.androidTargetDevices;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_androidTargetDevices(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.AndroidTargetDevices value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Android), "androidTargetDevices", typeof(UnityEditor.AndroidTargetDevices), 0);
                }
                UnityEditor.PlayerSettings.Android.androidTargetDevices = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_splashScreenScale(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Android.splashScreenScale;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_splashScreenScale(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.AndroidSplashScreenScale value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Android), "splashScreenScale", typeof(UnityEditor.AndroidSplashScreenScale), 0);
                }
                UnityEditor.PlayerSettings.Android.splashScreenScale = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_useCustomKeystore(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Android.useCustomKeystore;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_useCustomKeystore(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Android), "useCustomKeystore", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.Android.useCustomKeystore = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_keystoreName(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Android.keystoreName;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_keystoreName(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Android), "keystoreName", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.Android.keystoreName = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_keystorePass(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Android.keystorePass;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_keystorePass(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Android), "keystorePass", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.Android.keystorePass = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_keyaliasName(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Android.keyaliasName;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_keyaliasName(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Android), "keyaliasName", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.Android.keyaliasName = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_keyaliasPass(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Android.keyaliasPass;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_keyaliasPass(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Android), "keyaliasPass", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.Android.keyaliasPass = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_licenseVerification(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Android.licenseVerification;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_useAPKExpansionFiles(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Android.useAPKExpansionFiles;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_useAPKExpansionFiles(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Android), "useAPKExpansionFiles", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.Android.useAPKExpansionFiles = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_showActivityIndicatorOnLoading(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Android.showActivityIndicatorOnLoading;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_showActivityIndicatorOnLoading(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.AndroidShowActivityIndicatorOnLoading value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Android), "showActivityIndicatorOnLoading", typeof(UnityEditor.AndroidShowActivityIndicatorOnLoading), 0);
                }
                UnityEditor.PlayerSettings.Android.showActivityIndicatorOnLoading = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_blitType(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Android.blitType;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_blitType(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.AndroidBlitType value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Android), "blitType", typeof(UnityEditor.AndroidBlitType), 0);
                }
                UnityEditor.PlayerSettings.Android.blitType = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_maxAspectRatio(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Android.maxAspectRatio;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_maxAspectRatio(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Android), "maxAspectRatio", typeof(float), 0);
                }
                UnityEditor.PlayerSettings.Android.maxAspectRatio = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_startInFullscreen(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Android.startInFullscreen;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_startInFullscreen(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Android), "startInFullscreen", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.Android.startInFullscreen = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_renderOutsideSafeArea(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Android.renderOutsideSafeArea;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_renderOutsideSafeArea(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Android), "renderOutsideSafeArea", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.Android.renderOutsideSafeArea = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_optimizedFramePacing(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Android.optimizedFramePacing;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_optimizedFramePacing(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Android), "optimizedFramePacing", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.Android.optimizedFramePacing = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("Android", typeof(UnityEditor.PlayerSettings.Android), BindConstructor);
            cls.AddProperty(true, "disableDepthAndStencilBuffers", BindStaticRead_disableDepthAndStencilBuffers, BindStaticWrite_disableDepthAndStencilBuffers);
            cls.AddProperty(true, "defaultWindowWidth", BindStaticRead_defaultWindowWidth, BindStaticWrite_defaultWindowWidth);
            cls.AddProperty(true, "defaultWindowHeight", BindStaticRead_defaultWindowHeight, BindStaticWrite_defaultWindowHeight);
            cls.AddProperty(true, "minimumWindowWidth", BindStaticRead_minimumWindowWidth, BindStaticWrite_minimumWindowWidth);
            cls.AddProperty(true, "minimumWindowHeight", BindStaticRead_minimumWindowHeight, BindStaticWrite_minimumWindowHeight);
            cls.AddProperty(true, "resizableWindow", BindStaticRead_resizableWindow, BindStaticWrite_resizableWindow);
            cls.AddProperty(true, "fullscreenMode", BindStaticRead_fullscreenMode, BindStaticWrite_fullscreenMode);
            cls.AddProperty(true, "bundleVersionCode", BindStaticRead_bundleVersionCode, BindStaticWrite_bundleVersionCode);
            cls.AddProperty(true, "minSdkVersion", BindStaticRead_minSdkVersion, BindStaticWrite_minSdkVersion);
            cls.AddProperty(true, "targetSdkVersion", BindStaticRead_targetSdkVersion, BindStaticWrite_targetSdkVersion);
            cls.AddProperty(true, "preferredInstallLocation", BindStaticRead_preferredInstallLocation, BindStaticWrite_preferredInstallLocation);
            cls.AddProperty(true, "forceInternetPermission", BindStaticRead_forceInternetPermission, BindStaticWrite_forceInternetPermission);
            cls.AddProperty(true, "forceSDCardPermission", BindStaticRead_forceSDCardPermission, BindStaticWrite_forceSDCardPermission);
            cls.AddProperty(true, "androidTVCompatibility", BindStaticRead_androidTVCompatibility, BindStaticWrite_androidTVCompatibility);
            cls.AddProperty(true, "androidIsGame", BindStaticRead_androidIsGame, BindStaticWrite_androidIsGame);
            cls.AddProperty(true, "ARCoreEnabled", BindStaticRead_ARCoreEnabled, BindStaticWrite_ARCoreEnabled);
            cls.AddProperty(true, "chromeosInputEmulation", BindStaticRead_chromeosInputEmulation, BindStaticWrite_chromeosInputEmulation);
            cls.AddProperty(true, "targetArchitectures", BindStaticRead_targetArchitectures, BindStaticWrite_targetArchitectures);
            cls.AddProperty(true, "buildApkPerCpuArchitecture", BindStaticRead_buildApkPerCpuArchitecture, BindStaticWrite_buildApkPerCpuArchitecture);
            cls.AddProperty(true, "androidTargetDevices", BindStaticRead_androidTargetDevices, BindStaticWrite_androidTargetDevices);
            cls.AddProperty(true, "splashScreenScale", BindStaticRead_splashScreenScale, BindStaticWrite_splashScreenScale);
            cls.AddProperty(true, "useCustomKeystore", BindStaticRead_useCustomKeystore, BindStaticWrite_useCustomKeystore);
            cls.AddProperty(true, "keystoreName", BindStaticRead_keystoreName, BindStaticWrite_keystoreName);
            cls.AddProperty(true, "keystorePass", BindStaticRead_keystorePass, BindStaticWrite_keystorePass);
            cls.AddProperty(true, "keyaliasName", BindStaticRead_keyaliasName, BindStaticWrite_keyaliasName);
            cls.AddProperty(true, "keyaliasPass", BindStaticRead_keyaliasPass, BindStaticWrite_keyaliasPass);
            cls.AddProperty(true, "licenseVerification", BindStaticRead_licenseVerification, null);
            cls.AddProperty(true, "useAPKExpansionFiles", BindStaticRead_useAPKExpansionFiles, BindStaticWrite_useAPKExpansionFiles);
            cls.AddProperty(true, "showActivityIndicatorOnLoading", BindStaticRead_showActivityIndicatorOnLoading, BindStaticWrite_showActivityIndicatorOnLoading);
            cls.AddProperty(true, "blitType", BindStaticRead_blitType, BindStaticWrite_blitType);
            cls.AddProperty(true, "maxAspectRatio", BindStaticRead_maxAspectRatio, BindStaticWrite_maxAspectRatio);
            cls.AddProperty(true, "startInFullscreen", BindStaticRead_startInFullscreen, BindStaticWrite_startInFullscreen);
            cls.AddProperty(true, "renderOutsideSafeArea", BindStaticRead_renderOutsideSafeArea, BindStaticWrite_renderOutsideSafeArea);
            cls.AddProperty(true, "optimizedFramePacing", BindStaticRead_optimizedFramePacing, BindStaticWrite_optimizedFramePacing);
            return cls;
        }
    }
}
#endif
#endif
