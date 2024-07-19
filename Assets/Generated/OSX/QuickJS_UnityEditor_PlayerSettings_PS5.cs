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
    // Type: UnityEditor.PlayerSettings+PS5
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_PlayerSettings_PS5
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                if (argc == 0)
                {
                    var o = new UnityEditor.PlayerSettings.PS5();
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
        public static JSValue BindStaticRead_passcode(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS5.passcode;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_passcode(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS5), "passcode", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.PS5.passcode = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_monoEnv(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS5.monoEnv;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_monoEnv(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS5), "monoEnv", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.PS5.monoEnv = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_playerPrefsSupport(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS5.playerPrefsSupport;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_playerPrefsSupport(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS5), "playerPrefsSupport", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.PS5.playerPrefsSupport = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_restrictedAudioUsageRights(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS5.restrictedAudioUsageRights;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_restrictedAudioUsageRights(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS5), "restrictedAudioUsageRights", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.PS5.restrictedAudioUsageRights = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_paramFilePath(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS5.paramFilePath;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_paramFilePath(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS5), "paramFilePath", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.PS5.paramFilePath = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_videoOutPixelFormat(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS5.videoOutPixelFormat;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_videoOutPixelFormat(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS5), "videoOutPixelFormat", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.PS5.videoOutPixelFormat = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_videoOutInitialWidth(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS5.videoOutInitialWidth;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_videoOutInitialWidth(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS5), "videoOutInitialWidth", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.PS5.videoOutInitialWidth = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_useResolutionFallback(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS5.useResolutionFallback;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_useResolutionFallback(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS5), "useResolutionFallback", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.PS5.useResolutionFallback = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_videoOutOutputMode(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS5.videoOutOutputMode;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_videoOutOutputMode(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS5), "videoOutOutputMode", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.PS5.videoOutOutputMode = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_SdkOverride(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS5.SdkOverride;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_SdkOverride(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS5), "SdkOverride", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.PS5.SdkOverride = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_BackgroundImagePath(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS5.BackgroundImagePath;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_BackgroundImagePath(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS5), "BackgroundImagePath", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.PS5.BackgroundImagePath = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_Pic2Path(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS5.Pic2Path;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_Pic2Path(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS5), "Pic2Path", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.PS5.Pic2Path = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_StartupImagePath(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS5.StartupImagePath;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_StartupImagePath(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS5), "StartupImagePath", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.PS5.StartupImagePath = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_startupImagesFolder(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS5.startupImagesFolder;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_startupImagesFolder(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS5), "startupImagesFolder", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.PS5.startupImagesFolder = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_iconImagesFolder(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS5.iconImagesFolder;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_iconImagesFolder(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS5), "iconImagesFolder", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.PS5.iconImagesFolder = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_SaveDataImagePath(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS5.SaveDataImagePath;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_SaveDataImagePath(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS5), "SaveDataImagePath", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.PS5.SaveDataImagePath = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_BGMPath(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS5.BGMPath;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_BGMPath(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS5), "BGMPath", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.PS5.BGMPath = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_ShareOverlayImagePath(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS5.ShareOverlayImagePath;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_ShareOverlayImagePath(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS5), "ShareOverlayImagePath", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.PS5.ShareOverlayImagePath = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_npConfigZipPath(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS5.npConfigZipPath;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_npConfigZipPath(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS5), "npConfigZipPath", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.PS5.npConfigZipPath = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_scriptOptimizationLevel(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS5.scriptOptimizationLevel;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_scriptOptimizationLevel(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS5), "scriptOptimizationLevel", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.PS5.scriptOptimizationLevel = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_disableAutoHideSplash(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS5.disableAutoHideSplash;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_disableAutoHideSplash(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS5), "disableAutoHideSplash", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.PS5.disableAutoHideSplash = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_includedModules(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS5.includedModules;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_includedModules(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string[] value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS5), "includedModules", typeof(string[]), 0);
                }
                UnityEditor.PlayerSettings.PS5.includedModules = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_updateReferencePackage(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS5.updateReferencePackage;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_updateReferencePackage(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS5), "updateReferencePackage", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.PS5.updateReferencePackage = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_sharedBinaryContentLabels(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS5.sharedBinaryContentLabels;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_sharedBinaryContentLabels(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string[] value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS5), "sharedBinaryContentLabels", typeof(string[]), 0);
                }
                UnityEditor.PlayerSettings.PS5.sharedBinaryContentLabels = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_sharedBinarySystemFolders(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS5.sharedBinarySystemFolders;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_sharedBinarySystemFolders(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string[] value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS5), "sharedBinarySystemFolders", typeof(string[]), 0);
                }
                UnityEditor.PlayerSettings.PS5.sharedBinarySystemFolders = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_enableApplicationExit(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS5.enableApplicationExit;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_enableApplicationExit(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS5), "enableApplicationExit", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.PS5.enableApplicationExit = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_resetTempFolder(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS5.resetTempFolder;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_resetTempFolder(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS5), "resetTempFolder", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.PS5.resetTempFolder = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_playerPrefsMaxSize(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS5.playerPrefsMaxSize;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_playerPrefsMaxSize(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS5), "playerPrefsMaxSize", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.PS5.playerPrefsMaxSize = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_operatingSystemCanDisableSplashScreen(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS5.operatingSystemCanDisableSplashScreen;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_operatingSystemCanDisableSplashScreen(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS5), "operatingSystemCanDisableSplashScreen", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.PS5.operatingSystemCanDisableSplashScreen = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_vrrSupport(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS5.vrrSupport;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_vrrSupport(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.PS5VRRSupport value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS5), "vrrSupport", typeof(UnityEditor.PS5VRRSupport), 0);
                }
                UnityEditor.PlayerSettings.PS5.vrrSupport = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("PS5", typeof(UnityEditor.PlayerSettings.PS5), BindConstructor);
            cls.AddProperty(true, "passcode", BindStaticRead_passcode, BindStaticWrite_passcode);
            cls.AddProperty(true, "monoEnv", BindStaticRead_monoEnv, BindStaticWrite_monoEnv);
            cls.AddProperty(true, "playerPrefsSupport", BindStaticRead_playerPrefsSupport, BindStaticWrite_playerPrefsSupport);
            cls.AddProperty(true, "restrictedAudioUsageRights", BindStaticRead_restrictedAudioUsageRights, BindStaticWrite_restrictedAudioUsageRights);
            cls.AddProperty(true, "paramFilePath", BindStaticRead_paramFilePath, BindStaticWrite_paramFilePath);
            cls.AddProperty(true, "videoOutPixelFormat", BindStaticRead_videoOutPixelFormat, BindStaticWrite_videoOutPixelFormat);
            cls.AddProperty(true, "videoOutInitialWidth", BindStaticRead_videoOutInitialWidth, BindStaticWrite_videoOutInitialWidth);
            cls.AddProperty(true, "useResolutionFallback", BindStaticRead_useResolutionFallback, BindStaticWrite_useResolutionFallback);
            cls.AddProperty(true, "videoOutOutputMode", BindStaticRead_videoOutOutputMode, BindStaticWrite_videoOutOutputMode);
            cls.AddProperty(true, "SdkOverride", BindStaticRead_SdkOverride, BindStaticWrite_SdkOverride);
            cls.AddProperty(true, "BackgroundImagePath", BindStaticRead_BackgroundImagePath, BindStaticWrite_BackgroundImagePath);
            cls.AddProperty(true, "Pic2Path", BindStaticRead_Pic2Path, BindStaticWrite_Pic2Path);
            cls.AddProperty(true, "StartupImagePath", BindStaticRead_StartupImagePath, BindStaticWrite_StartupImagePath);
            cls.AddProperty(true, "startupImagesFolder", BindStaticRead_startupImagesFolder, BindStaticWrite_startupImagesFolder);
            cls.AddProperty(true, "iconImagesFolder", BindStaticRead_iconImagesFolder, BindStaticWrite_iconImagesFolder);
            cls.AddProperty(true, "SaveDataImagePath", BindStaticRead_SaveDataImagePath, BindStaticWrite_SaveDataImagePath);
            cls.AddProperty(true, "BGMPath", BindStaticRead_BGMPath, BindStaticWrite_BGMPath);
            cls.AddProperty(true, "ShareOverlayImagePath", BindStaticRead_ShareOverlayImagePath, BindStaticWrite_ShareOverlayImagePath);
            cls.AddProperty(true, "npConfigZipPath", BindStaticRead_npConfigZipPath, BindStaticWrite_npConfigZipPath);
            cls.AddProperty(true, "scriptOptimizationLevel", BindStaticRead_scriptOptimizationLevel, BindStaticWrite_scriptOptimizationLevel);
            cls.AddProperty(true, "disableAutoHideSplash", BindStaticRead_disableAutoHideSplash, BindStaticWrite_disableAutoHideSplash);
            cls.AddProperty(true, "includedModules", BindStaticRead_includedModules, BindStaticWrite_includedModules);
            cls.AddProperty(true, "updateReferencePackage", BindStaticRead_updateReferencePackage, BindStaticWrite_updateReferencePackage);
            cls.AddProperty(true, "sharedBinaryContentLabels", BindStaticRead_sharedBinaryContentLabels, BindStaticWrite_sharedBinaryContentLabels);
            cls.AddProperty(true, "sharedBinarySystemFolders", BindStaticRead_sharedBinarySystemFolders, BindStaticWrite_sharedBinarySystemFolders);
            cls.AddProperty(true, "enableApplicationExit", BindStaticRead_enableApplicationExit, BindStaticWrite_enableApplicationExit);
            cls.AddProperty(true, "resetTempFolder", BindStaticRead_resetTempFolder, BindStaticWrite_resetTempFolder);
            cls.AddProperty(true, "playerPrefsMaxSize", BindStaticRead_playerPrefsMaxSize, BindStaticWrite_playerPrefsMaxSize);
            cls.AddProperty(true, "operatingSystemCanDisableSplashScreen", BindStaticRead_operatingSystemCanDisableSplashScreen, BindStaticWrite_operatingSystemCanDisableSplashScreen);
            cls.AddProperty(true, "vrrSupport", BindStaticRead_vrrSupport, BindStaticWrite_vrrSupport);
            return cls;
        }
    }
}
#endif
#endif
