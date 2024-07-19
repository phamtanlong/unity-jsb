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
    // Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Applications/Unity/Hub/Editor/2019.4.40f1/Unity.app/Contents/Managed/UnityEngine/UnityEngine.CoreModule.dll
    // Type: UnityEngine.Application
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_Application
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                if (argc == 0)
                {
                    var o = new UnityEngine.Application();
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
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Quit(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        int arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Application), "Quit", typeof(int), 0);
                        }
                        UnityEngine.Application.Quit(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 0)
                    {
                        UnityEngine.Application.Quit();
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("Quit", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Unload(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.Application.Unload();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Unload", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CanStreamedLevelBeLoaded(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(int)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Application), "CanStreamedLevelBeLoaded", typeof(int), 0);
                            }
                            var ret = UnityEngine.Application.CanStreamedLevelBeLoaded(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Application), "CanStreamedLevelBeLoaded", typeof(string), 0);
                            }
                            var ret = UnityEngine.Application.CanStreamedLevelBeLoaded(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("CanStreamedLevelBeLoaded", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsPlaying(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Application), "IsPlaying", typeof(UnityEngine.Object), 0);
                    }
                    var ret = UnityEngine.Application.IsPlaying(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsPlaying", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetBuildTags(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEngine.Application.GetBuildTags();
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetBuildTags", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetBuildTags(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string[] arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Application), "SetBuildTags", typeof(string[]), 0);
                    }
                    UnityEngine.Application.SetBuildTags(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetBuildTags", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_HasProLicense(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEngine.Application.HasProLicense();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("HasProLicense", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RequestAdvertisingIdentifierAsync(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Application.AdvertisingIdentifierCallback arg0;
                    if (!Values.js_get_delegate(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Application), "RequestAdvertisingIdentifierAsync", typeof(UnityEngine.Application.AdvertisingIdentifierCallback), 0);
                    }
                    var ret = UnityEngine.Application.RequestAdvertisingIdentifierAsync(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("RequestAdvertisingIdentifierAsync", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_OpenURL(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Application), "OpenURL", typeof(string), 0);
                    }
                    UnityEngine.Application.OpenURL(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("OpenURL", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetStackTraceLogType(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.LogType arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Application), "GetStackTraceLogType", typeof(UnityEngine.LogType), 0);
                    }
                    var ret = UnityEngine.Application.GetStackTraceLogType(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
                }
                throw new NoSuitableMethodException("GetStackTraceLogType", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetStackTraceLogType(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.LogType arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Application), "SetStackTraceLogType", typeof(UnityEngine.LogType), 0);
                    }
                    UnityEngine.StackTraceLogType arg1;
                    if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Application), "SetStackTraceLogType", typeof(UnityEngine.StackTraceLogType), 1);
                    }
                    UnityEngine.Application.SetStackTraceLogType(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetStackTraceLogType", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RequestUserAuthorization(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.UserAuthorization arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Application), "RequestUserAuthorization", typeof(UnityEngine.UserAuthorization), 0);
                    }
                    var ret = UnityEngine.Application.RequestUserAuthorization(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("RequestUserAuthorization", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_HasUserAuthorization(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.UserAuthorization arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Application), "HasUserAuthorization", typeof(UnityEngine.UserAuthorization), 0);
                    }
                    var ret = UnityEngine.Application.HasUserAuthorization(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("HasUserAuthorization", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_isPlaying(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Application.isPlaying;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_isFocused(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Application.isFocused;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_buildGUID(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Application.buildGUID;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_runInBackground(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Application.runInBackground;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_runInBackground(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Application), "runInBackground", typeof(bool), 0);
                }
                UnityEngine.Application.runInBackground = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_isBatchMode(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Application.isBatchMode;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_dataPath(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Application.dataPath;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_streamingAssetsPath(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Application.streamingAssetsPath;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_persistentDataPath(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Application.persistentDataPath;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_temporaryCachePath(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Application.temporaryCachePath;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_absoluteURL(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Application.absoluteURL;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_unityVersion(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Application.unityVersion;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_version(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Application.version;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_installerName(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Application.installerName;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_identifier(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Application.identifier;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_installMode(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Application.installMode;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_sandboxType(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Application.sandboxType;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_productName(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Application.productName;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_companyName(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Application.companyName;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_cloudProjectId(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Application.cloudProjectId;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_targetFrameRate(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Application.targetFrameRate;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_targetFrameRate(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Application), "targetFrameRate", typeof(int), 0);
                }
                UnityEngine.Application.targetFrameRate = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_consoleLogPath(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Application.consoleLogPath;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_backgroundLoadingPriority(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Application.backgroundLoadingPriority;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_backgroundLoadingPriority(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.ThreadPriority value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Application), "backgroundLoadingPriority", typeof(UnityEngine.ThreadPriority), 0);
                }
                UnityEngine.Application.backgroundLoadingPriority = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_genuine(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Application.genuine;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_genuineCheckAvailable(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Application.genuineCheckAvailable;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_platform(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Application.platform;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_isMobilePlatform(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Application.isMobilePlatform;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_isConsolePlatform(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Application.isConsolePlatform;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_systemLanguage(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Application.systemLanguage;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_internetReachability(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Application.internetReachability;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_isEditor(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Application.isEditor;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticEvent_lowMemory(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                UnityEngine.Application.LowMemoryCallback value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEngine.Application), "lowMemory", typeof(UnityEngine.Application.LowMemoryCallback), 1);
                        }
                        UnityEngine.Application.lowMemory += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEngine.Application), "lowMemory", typeof(UnityEngine.Application.LowMemoryCallback), 1);
                        }
                        UnityEngine.Application.lowMemory -= value;
                        break;
                    default: throw new JSException("invalid event op");
                }
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticEvent_logMessageReceived(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                UnityEngine.Application.LogCallback value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEngine.Application), "logMessageReceived", typeof(UnityEngine.Application.LogCallback), 1);
                        }
                        UnityEngine.Application.logMessageReceived += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEngine.Application), "logMessageReceived", typeof(UnityEngine.Application.LogCallback), 1);
                        }
                        UnityEngine.Application.logMessageReceived -= value;
                        break;
                    default: throw new JSException("invalid event op");
                }
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticEvent_logMessageReceivedThreaded(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                UnityEngine.Application.LogCallback value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEngine.Application), "logMessageReceivedThreaded", typeof(UnityEngine.Application.LogCallback), 1);
                        }
                        UnityEngine.Application.logMessageReceivedThreaded += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEngine.Application), "logMessageReceivedThreaded", typeof(UnityEngine.Application.LogCallback), 1);
                        }
                        UnityEngine.Application.logMessageReceivedThreaded -= value;
                        break;
                    default: throw new JSException("invalid event op");
                }
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticEvent_onBeforeRender(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                UnityEngine.Events.UnityAction value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEngine.Application), "onBeforeRender", typeof(UnityEngine.Events.UnityAction), 1);
                        }
                        UnityEngine.Application.onBeforeRender += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEngine.Application), "onBeforeRender", typeof(UnityEngine.Events.UnityAction), 1);
                        }
                        UnityEngine.Application.onBeforeRender -= value;
                        break;
                    default: throw new JSException("invalid event op");
                }
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticEvent_focusChanged(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                System.Action<bool> value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEngine.Application), "focusChanged", typeof(System.Action<bool>), 1);
                        }
                        UnityEngine.Application.focusChanged += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEngine.Application), "focusChanged", typeof(System.Action<bool>), 1);
                        }
                        UnityEngine.Application.focusChanged -= value;
                        break;
                    default: throw new JSException("invalid event op");
                }
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticEvent_deepLinkActivated(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                System.Action<string> value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEngine.Application), "deepLinkActivated", typeof(System.Action<string>), 1);
                        }
                        UnityEngine.Application.deepLinkActivated += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEngine.Application), "deepLinkActivated", typeof(System.Action<string>), 1);
                        }
                        UnityEngine.Application.deepLinkActivated -= value;
                        break;
                    default: throw new JSException("invalid event op");
                }
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticEvent_wantsToQuit(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                System.Func<bool> value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEngine.Application), "wantsToQuit", typeof(System.Func<bool>), 1);
                        }
                        UnityEngine.Application.wantsToQuit += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEngine.Application), "wantsToQuit", typeof(System.Func<bool>), 1);
                        }
                        UnityEngine.Application.wantsToQuit -= value;
                        break;
                    default: throw new JSException("invalid event op");
                }
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticEvent_quitting(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                System.Action value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEngine.Application), "quitting", typeof(System.Action), 1);
                        }
                        UnityEngine.Application.quitting += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEngine.Application), "quitting", typeof(System.Action), 1);
                        }
                        UnityEngine.Application.quitting -= value;
                        break;
                    default: throw new JSException("invalid event op");
                }
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("Application", typeof(UnityEngine.Application), BindConstructor);
            cls.AddMethod(true, "Quit", BindStatic_Quit);
            cls.AddMethod(true, "Unload", BindStatic_Unload);
            cls.AddMethod(true, "CanStreamedLevelBeLoaded", BindStatic_CanStreamedLevelBeLoaded);
            cls.AddMethod(true, "IsPlaying", BindStatic_IsPlaying);
            cls.AddMethod(true, "GetBuildTags", BindStatic_GetBuildTags);
            cls.AddMethod(true, "SetBuildTags", BindStatic_SetBuildTags);
            cls.AddMethod(true, "HasProLicense", BindStatic_HasProLicense);
            cls.AddMethod(true, "RequestAdvertisingIdentifierAsync", BindStatic_RequestAdvertisingIdentifierAsync);
            cls.AddMethod(true, "OpenURL", BindStatic_OpenURL);
            cls.AddMethod(true, "GetStackTraceLogType", BindStatic_GetStackTraceLogType);
            cls.AddMethod(true, "SetStackTraceLogType", BindStatic_SetStackTraceLogType);
            cls.AddMethod(true, "RequestUserAuthorization", BindStatic_RequestUserAuthorization);
            cls.AddMethod(true, "HasUserAuthorization", BindStatic_HasUserAuthorization);
            cls.AddProperty(true, "isPlaying", BindStaticRead_isPlaying, null);
            cls.AddProperty(true, "isFocused", BindStaticRead_isFocused, null);
            cls.AddProperty(true, "buildGUID", BindStaticRead_buildGUID, null);
            cls.AddProperty(true, "runInBackground", BindStaticRead_runInBackground, BindStaticWrite_runInBackground);
            cls.AddProperty(true, "isBatchMode", BindStaticRead_isBatchMode, null);
            cls.AddProperty(true, "dataPath", BindStaticRead_dataPath, null);
            cls.AddProperty(true, "streamingAssetsPath", BindStaticRead_streamingAssetsPath, null);
            cls.AddProperty(true, "persistentDataPath", BindStaticRead_persistentDataPath, null);
            cls.AddProperty(true, "temporaryCachePath", BindStaticRead_temporaryCachePath, null);
            cls.AddProperty(true, "absoluteURL", BindStaticRead_absoluteURL, null);
            cls.AddProperty(true, "unityVersion", BindStaticRead_unityVersion, null);
            cls.AddProperty(true, "version", BindStaticRead_version, null);
            cls.AddProperty(true, "installerName", BindStaticRead_installerName, null);
            cls.AddProperty(true, "identifier", BindStaticRead_identifier, null);
            cls.AddProperty(true, "installMode", BindStaticRead_installMode, null);
            cls.AddProperty(true, "sandboxType", BindStaticRead_sandboxType, null);
            cls.AddProperty(true, "productName", BindStaticRead_productName, null);
            cls.AddProperty(true, "companyName", BindStaticRead_companyName, null);
            cls.AddProperty(true, "cloudProjectId", BindStaticRead_cloudProjectId, null);
            cls.AddProperty(true, "targetFrameRate", BindStaticRead_targetFrameRate, BindStaticWrite_targetFrameRate);
            cls.AddProperty(true, "consoleLogPath", BindStaticRead_consoleLogPath, null);
            cls.AddProperty(true, "backgroundLoadingPriority", BindStaticRead_backgroundLoadingPriority, BindStaticWrite_backgroundLoadingPriority);
            cls.AddProperty(true, "genuine", BindStaticRead_genuine, null);
            cls.AddProperty(true, "genuineCheckAvailable", BindStaticRead_genuineCheckAvailable, null);
            cls.AddProperty(true, "platform", BindStaticRead_platform, null);
            cls.AddProperty(true, "isMobilePlatform", BindStaticRead_isMobilePlatform, null);
            cls.AddProperty(true, "isConsolePlatform", BindStaticRead_isConsolePlatform, null);
            cls.AddProperty(true, "systemLanguage", BindStaticRead_systemLanguage, null);
            cls.AddProperty(true, "internetReachability", BindStaticRead_internetReachability, null);
            cls.AddProperty(true, "isEditor", BindStaticRead_isEditor, null);
            cls.AddMethod(true, "lowMemory", BindStaticEvent_lowMemory);
            cls.AddMethod(true, "logMessageReceived", BindStaticEvent_logMessageReceived);
            cls.AddMethod(true, "logMessageReceivedThreaded", BindStaticEvent_logMessageReceivedThreaded);
            cls.AddMethod(true, "onBeforeRender", BindStaticEvent_onBeforeRender);
            cls.AddMethod(true, "focusChanged", BindStaticEvent_focusChanged);
            cls.AddMethod(true, "deepLinkActivated", BindStaticEvent_deepLinkActivated);
            cls.AddMethod(true, "wantsToQuit", BindStaticEvent_wantsToQuit);
            cls.AddMethod(true, "quitting", BindStaticEvent_quitting);
            return cls;
        }
    }
}
#endif
