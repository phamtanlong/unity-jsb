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
    // Type: UnityEditor.PlayerSettings
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_PlayerSettings
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_HasAspectRatio(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.AspectRatio arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PlayerSettings), "HasAspectRatio", typeof(UnityEditor.AspectRatio), 0);
                    }
                    var ret = UnityEditor.PlayerSettings.HasAspectRatio(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("HasAspectRatio", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetAspectRatio(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEditor.AspectRatio arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetAspectRatio", typeof(UnityEditor.AspectRatio), 0);
                    }
                    bool arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetAspectRatio", typeof(bool), 1);
                    }
                    UnityEditor.PlayerSettings.SetAspectRatio(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetAspectRatio", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetPreloadedAssets(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.PlayerSettings.GetPreloadedAssets();
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetPreloadedAssets", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetPreloadedAssets(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Object[] arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetPreloadedAssets", typeof(UnityEngine.Object[]), 0);
                    }
                    UnityEditor.PlayerSettings.SetPreloadedAssets(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetPreloadedAssets", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetShaderChunkSizeInMBForPlatform(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.BuildTarget arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetShaderChunkSizeInMBForPlatform", typeof(UnityEditor.BuildTarget), 0);
                    }
                    var ret = UnityEditor.PlayerSettings.GetShaderChunkSizeInMBForPlatform(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetShaderChunkSizeInMBForPlatform", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetShaderChunkSizeInMBForPlatform(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEditor.BuildTarget arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetShaderChunkSizeInMBForPlatform", typeof(UnityEditor.BuildTarget), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetShaderChunkSizeInMBForPlatform", typeof(int), 1);
                    }
                    UnityEditor.PlayerSettings.SetShaderChunkSizeInMBForPlatform(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetShaderChunkSizeInMBForPlatform", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetShaderChunkCountForPlatform(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.BuildTarget arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetShaderChunkCountForPlatform", typeof(UnityEditor.BuildTarget), 0);
                    }
                    var ret = UnityEditor.PlayerSettings.GetShaderChunkCountForPlatform(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetShaderChunkCountForPlatform", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetShaderChunkCountForPlatform(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEditor.BuildTarget arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetShaderChunkCountForPlatform", typeof(UnityEditor.BuildTarget), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetShaderChunkCountForPlatform", typeof(int), 1);
                    }
                    UnityEditor.PlayerSettings.SetShaderChunkCountForPlatform(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetShaderChunkCountForPlatform", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetDefaultShaderChunkSizeInMB(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.PlayerSettings.GetDefaultShaderChunkSizeInMB();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetDefaultShaderChunkSizeInMB", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetDefaultShaderChunkSizeInMB(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetDefaultShaderChunkSizeInMB", typeof(int), 0);
                    }
                    UnityEditor.PlayerSettings.SetDefaultShaderChunkSizeInMB(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetDefaultShaderChunkSizeInMB", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetDefaultShaderChunkCount(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.PlayerSettings.GetDefaultShaderChunkCount();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetDefaultShaderChunkCount", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetDefaultShaderChunkCount(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetDefaultShaderChunkCount", typeof(int), 0);
                    }
                    UnityEditor.PlayerSettings.SetDefaultShaderChunkCount(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetDefaultShaderChunkCount", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetOverrideShaderChunkSettingsForPlatform(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.BuildTarget arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetOverrideShaderChunkSettingsForPlatform", typeof(UnityEditor.BuildTarget), 0);
                    }
                    var ret = UnityEditor.PlayerSettings.GetOverrideShaderChunkSettingsForPlatform(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetOverrideShaderChunkSettingsForPlatform", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetOverrideShaderChunkSettingsForPlatform(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEditor.BuildTarget arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetOverrideShaderChunkSettingsForPlatform", typeof(UnityEditor.BuildTarget), 0);
                    }
                    bool arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetOverrideShaderChunkSettingsForPlatform", typeof(bool), 1);
                    }
                    UnityEditor.PlayerSettings.SetOverrideShaderChunkSettingsForPlatform(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetOverrideShaderChunkSettingsForPlatform", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetGraphicsAPIs(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.BuildTarget arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetGraphicsAPIs", typeof(UnityEditor.BuildTarget), 0);
                    }
                    var ret = UnityEditor.PlayerSettings.GetGraphicsAPIs(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetGraphicsAPIs", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetGraphicsAPIs(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEditor.BuildTarget arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetGraphicsAPIs", typeof(UnityEditor.BuildTarget), 0);
                    }
                    UnityEngine.Rendering.GraphicsDeviceType[] arg1;
                    if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetGraphicsAPIs", typeof(UnityEngine.Rendering.GraphicsDeviceType[]), 1);
                    }
                    UnityEditor.PlayerSettings.SetGraphicsAPIs(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetGraphicsAPIs", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetUseDefaultGraphicsAPIs(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.BuildTarget arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetUseDefaultGraphicsAPIs", typeof(UnityEditor.BuildTarget), 0);
                    }
                    var ret = UnityEditor.PlayerSettings.GetUseDefaultGraphicsAPIs(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetUseDefaultGraphicsAPIs", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetUseDefaultGraphicsAPIs(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEditor.BuildTarget arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetUseDefaultGraphicsAPIs", typeof(UnityEditor.BuildTarget), 0);
                    }
                    bool arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetUseDefaultGraphicsAPIs", typeof(bool), 1);
                    }
                    UnityEditor.PlayerSettings.SetUseDefaultGraphicsAPIs(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetUseDefaultGraphicsAPIs", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetTemplateCustomValue(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetTemplateCustomValue", typeof(string), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetTemplateCustomValue", typeof(string), 1);
                    }
                    UnityEditor.PlayerSettings.SetTemplateCustomValue(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetTemplateCustomValue", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetTemplateCustomValue(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetTemplateCustomValue", typeof(string), 0);
                    }
                    var ret = UnityEditor.PlayerSettings.GetTemplateCustomValue(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetTemplateCustomValue", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetScriptingDefineSymbolsForGroup(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        UnityEditor.BuildTargetGroup arg0;
                        if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetScriptingDefineSymbolsForGroup", typeof(UnityEditor.BuildTargetGroup), 0);
                        }
                        string[] arg1;
                        UnityEditor.PlayerSettings.GetScriptingDefineSymbolsForGroup(arg0, out arg1);
                        var out0 = Values.js_push_classvalue(ctx, arg1);
                        if (JSApi.JS_IsException(out0))
                        {
                            return out0;
                        }
                        var context = ScriptEngine.GetContext(ctx);
                        JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out0);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 1)
                    {
                        UnityEditor.BuildTargetGroup arg0;
                        if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetScriptingDefineSymbolsForGroup", typeof(UnityEditor.BuildTargetGroup), 0);
                        }
                        var ret = UnityEditor.PlayerSettings.GetScriptingDefineSymbolsForGroup(arg0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("GetScriptingDefineSymbolsForGroup", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetScriptingDefineSymbolsForGroup(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.BuildTargetGroup)) && Values.js_match_type(ctx, argv[1], typeof(string)))
                        {
                            UnityEditor.BuildTargetGroup arg0;
                            if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetScriptingDefineSymbolsForGroup", typeof(UnityEditor.BuildTargetGroup), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetScriptingDefineSymbolsForGroup", typeof(string), 1);
                            }
                            UnityEditor.PlayerSettings.SetScriptingDefineSymbolsForGroup(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.BuildTargetGroup)) && Values.js_match_type(ctx, argv[1], typeof(string[])))
                        {
                            UnityEditor.BuildTargetGroup arg0;
                            if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetScriptingDefineSymbolsForGroup", typeof(UnityEditor.BuildTargetGroup), 0);
                            }
                            string[] arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetScriptingDefineSymbolsForGroup", typeof(string[]), 1);
                            }
                            UnityEditor.PlayerSettings.SetScriptingDefineSymbolsForGroup(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("SetScriptingDefineSymbolsForGroup", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetAdditionalCompilerArgumentsForGroup(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.BuildTargetGroup arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetAdditionalCompilerArgumentsForGroup", typeof(UnityEditor.BuildTargetGroup), 0);
                    }
                    var ret = UnityEditor.PlayerSettings.GetAdditionalCompilerArgumentsForGroup(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetAdditionalCompilerArgumentsForGroup", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetAdditionalCompilerArgumentsForGroup(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEditor.BuildTargetGroup arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetAdditionalCompilerArgumentsForGroup", typeof(UnityEditor.BuildTargetGroup), 0);
                    }
                    string[] arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetAdditionalCompilerArgumentsForGroup", typeof(string[]), 1);
                    }
                    UnityEditor.PlayerSettings.SetAdditionalCompilerArgumentsForGroup(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetAdditionalCompilerArgumentsForGroup", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetArchitecture(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.BuildTargetGroup)))
                        {
                            UnityEditor.BuildTargetGroup arg0;
                            if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetArchitecture", typeof(UnityEditor.BuildTargetGroup), 0);
                            }
                            var ret = UnityEditor.PlayerSettings.GetArchitecture(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.Build.NamedBuildTarget)))
                        {
                            UnityEditor.Build.NamedBuildTarget arg0;
                            if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetArchitecture", typeof(UnityEditor.Build.NamedBuildTarget), 0);
                            }
                            var ret = UnityEditor.PlayerSettings.GetArchitecture(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("GetArchitecture", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetArchitecture(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.BuildTargetGroup)) && Values.js_match_type(ctx, argv[1], typeof(int)))
                        {
                            UnityEditor.BuildTargetGroup arg0;
                            if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetArchitecture", typeof(UnityEditor.BuildTargetGroup), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetArchitecture", typeof(int), 1);
                            }
                            UnityEditor.PlayerSettings.SetArchitecture(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.Build.NamedBuildTarget)) && Values.js_match_type(ctx, argv[1], typeof(int)))
                        {
                            UnityEditor.Build.NamedBuildTarget arg0;
                            if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetArchitecture", typeof(UnityEditor.Build.NamedBuildTarget), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetArchitecture", typeof(int), 1);
                            }
                            UnityEditor.PlayerSettings.SetArchitecture(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("SetArchitecture", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetScriptingBackend(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.BuildTargetGroup)))
                        {
                            UnityEditor.BuildTargetGroup arg0;
                            if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetScriptingBackend", typeof(UnityEditor.BuildTargetGroup), 0);
                            }
                            var ret = UnityEditor.PlayerSettings.GetScriptingBackend(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.Build.NamedBuildTarget)))
                        {
                            UnityEditor.Build.NamedBuildTarget arg0;
                            if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetScriptingBackend", typeof(UnityEditor.Build.NamedBuildTarget), 0);
                            }
                            var ret = UnityEditor.PlayerSettings.GetScriptingBackend(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("GetScriptingBackend", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetScriptingBackend(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.BuildTargetGroup)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.ScriptingImplementation)))
                        {
                            UnityEditor.BuildTargetGroup arg0;
                            if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetScriptingBackend", typeof(UnityEditor.BuildTargetGroup), 0);
                            }
                            UnityEditor.ScriptingImplementation arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetScriptingBackend", typeof(UnityEditor.ScriptingImplementation), 1);
                            }
                            UnityEditor.PlayerSettings.SetScriptingBackend(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.Build.NamedBuildTarget)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.ScriptingImplementation)))
                        {
                            UnityEditor.Build.NamedBuildTarget arg0;
                            if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetScriptingBackend", typeof(UnityEditor.Build.NamedBuildTarget), 0);
                            }
                            UnityEditor.ScriptingImplementation arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetScriptingBackend", typeof(UnityEditor.ScriptingImplementation), 1);
                            }
                            UnityEditor.PlayerSettings.SetScriptingBackend(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("SetScriptingBackend", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetDefaultScriptingBackend(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.BuildTargetGroup)))
                        {
                            UnityEditor.BuildTargetGroup arg0;
                            if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetDefaultScriptingBackend", typeof(UnityEditor.BuildTargetGroup), 0);
                            }
                            var ret = UnityEditor.PlayerSettings.GetDefaultScriptingBackend(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.Build.NamedBuildTarget)))
                        {
                            UnityEditor.Build.NamedBuildTarget arg0;
                            if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetDefaultScriptingBackend", typeof(UnityEditor.Build.NamedBuildTarget), 0);
                            }
                            var ret = UnityEditor.PlayerSettings.GetDefaultScriptingBackend(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("GetDefaultScriptingBackend", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetApplicationIdentifier(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.BuildTargetGroup)))
                        {
                            UnityEditor.BuildTargetGroup arg0;
                            if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetApplicationIdentifier", typeof(UnityEditor.BuildTargetGroup), 0);
                            }
                            var ret = UnityEditor.PlayerSettings.GetApplicationIdentifier(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.Build.NamedBuildTarget)))
                        {
                            UnityEditor.Build.NamedBuildTarget arg0;
                            if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetApplicationIdentifier", typeof(UnityEditor.Build.NamedBuildTarget), 0);
                            }
                            var ret = UnityEditor.PlayerSettings.GetApplicationIdentifier(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("GetApplicationIdentifier", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetApplicationIdentifier(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.BuildTargetGroup)) && Values.js_match_type(ctx, argv[1], typeof(string)))
                        {
                            UnityEditor.BuildTargetGroup arg0;
                            if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetApplicationIdentifier", typeof(UnityEditor.BuildTargetGroup), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetApplicationIdentifier", typeof(string), 1);
                            }
                            UnityEditor.PlayerSettings.SetApplicationIdentifier(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.Build.NamedBuildTarget)) && Values.js_match_type(ctx, argv[1], typeof(string)))
                        {
                            UnityEditor.Build.NamedBuildTarget arg0;
                            if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetApplicationIdentifier", typeof(UnityEditor.Build.NamedBuildTarget), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetApplicationIdentifier", typeof(string), 1);
                            }
                            UnityEditor.PlayerSettings.SetApplicationIdentifier(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("SetApplicationIdentifier", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetIl2CppCompilerConfiguration(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.BuildTargetGroup)))
                        {
                            UnityEditor.BuildTargetGroup arg0;
                            if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetIl2CppCompilerConfiguration", typeof(UnityEditor.BuildTargetGroup), 0);
                            }
                            var ret = UnityEditor.PlayerSettings.GetIl2CppCompilerConfiguration(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.Build.NamedBuildTarget)))
                        {
                            UnityEditor.Build.NamedBuildTarget arg0;
                            if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetIl2CppCompilerConfiguration", typeof(UnityEditor.Build.NamedBuildTarget), 0);
                            }
                            var ret = UnityEditor.PlayerSettings.GetIl2CppCompilerConfiguration(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("GetIl2CppCompilerConfiguration", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetIl2CppCompilerConfiguration(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.BuildTargetGroup)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.Il2CppCompilerConfiguration)))
                        {
                            UnityEditor.BuildTargetGroup arg0;
                            if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetIl2CppCompilerConfiguration", typeof(UnityEditor.BuildTargetGroup), 0);
                            }
                            UnityEditor.Il2CppCompilerConfiguration arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetIl2CppCompilerConfiguration", typeof(UnityEditor.Il2CppCompilerConfiguration), 1);
                            }
                            UnityEditor.PlayerSettings.SetIl2CppCompilerConfiguration(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.Build.NamedBuildTarget)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.Il2CppCompilerConfiguration)))
                        {
                            UnityEditor.Build.NamedBuildTarget arg0;
                            if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetIl2CppCompilerConfiguration", typeof(UnityEditor.Build.NamedBuildTarget), 0);
                            }
                            UnityEditor.Il2CppCompilerConfiguration arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetIl2CppCompilerConfiguration", typeof(UnityEditor.Il2CppCompilerConfiguration), 1);
                            }
                            UnityEditor.PlayerSettings.SetIl2CppCompilerConfiguration(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("SetIl2CppCompilerConfiguration", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetIncrementalIl2CppBuild(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.BuildTargetGroup)))
                        {
                            UnityEditor.BuildTargetGroup arg0;
                            if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetIncrementalIl2CppBuild", typeof(UnityEditor.BuildTargetGroup), 0);
                            }
                            var ret = UnityEditor.PlayerSettings.GetIncrementalIl2CppBuild(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.Build.NamedBuildTarget)))
                        {
                            UnityEditor.Build.NamedBuildTarget arg0;
                            if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetIncrementalIl2CppBuild", typeof(UnityEditor.Build.NamedBuildTarget), 0);
                            }
                            var ret = UnityEditor.PlayerSettings.GetIncrementalIl2CppBuild(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("GetIncrementalIl2CppBuild", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetIncrementalIl2CppBuild(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.BuildTargetGroup)) && Values.js_match_type(ctx, argv[1], typeof(bool)))
                        {
                            UnityEditor.BuildTargetGroup arg0;
                            if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetIncrementalIl2CppBuild", typeof(UnityEditor.BuildTargetGroup), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetIncrementalIl2CppBuild", typeof(bool), 1);
                            }
                            UnityEditor.PlayerSettings.SetIncrementalIl2CppBuild(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.Build.NamedBuildTarget)) && Values.js_match_type(ctx, argv[1], typeof(bool)))
                        {
                            UnityEditor.Build.NamedBuildTarget arg0;
                            if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetIncrementalIl2CppBuild", typeof(UnityEditor.Build.NamedBuildTarget), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetIncrementalIl2CppBuild", typeof(bool), 1);
                            }
                            UnityEditor.PlayerSettings.SetIncrementalIl2CppBuild(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("SetIncrementalIl2CppBuild", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetManagedStrippingLevel(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.BuildTargetGroup)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.ManagedStrippingLevel)))
                        {
                            UnityEditor.BuildTargetGroup arg0;
                            if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetManagedStrippingLevel", typeof(UnityEditor.BuildTargetGroup), 0);
                            }
                            UnityEditor.ManagedStrippingLevel arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetManagedStrippingLevel", typeof(UnityEditor.ManagedStrippingLevel), 1);
                            }
                            UnityEditor.PlayerSettings.SetManagedStrippingLevel(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.Build.NamedBuildTarget)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.ManagedStrippingLevel)))
                        {
                            UnityEditor.Build.NamedBuildTarget arg0;
                            if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetManagedStrippingLevel", typeof(UnityEditor.Build.NamedBuildTarget), 0);
                            }
                            UnityEditor.ManagedStrippingLevel arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetManagedStrippingLevel", typeof(UnityEditor.ManagedStrippingLevel), 1);
                            }
                            UnityEditor.PlayerSettings.SetManagedStrippingLevel(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("SetManagedStrippingLevel", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetManagedStrippingLevel(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.BuildTargetGroup)))
                        {
                            UnityEditor.BuildTargetGroup arg0;
                            if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetManagedStrippingLevel", typeof(UnityEditor.BuildTargetGroup), 0);
                            }
                            var ret = UnityEditor.PlayerSettings.GetManagedStrippingLevel(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.Build.NamedBuildTarget)))
                        {
                            UnityEditor.Build.NamedBuildTarget arg0;
                            if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetManagedStrippingLevel", typeof(UnityEditor.Build.NamedBuildTarget), 0);
                            }
                            var ret = UnityEditor.PlayerSettings.GetManagedStrippingLevel(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("GetManagedStrippingLevel", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetApiCompatibilityLevel(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.BuildTargetGroup)))
                        {
                            UnityEditor.BuildTargetGroup arg0;
                            if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetApiCompatibilityLevel", typeof(UnityEditor.BuildTargetGroup), 0);
                            }
                            var ret = UnityEditor.PlayerSettings.GetApiCompatibilityLevel(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.Build.NamedBuildTarget)))
                        {
                            UnityEditor.Build.NamedBuildTarget arg0;
                            if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetApiCompatibilityLevel", typeof(UnityEditor.Build.NamedBuildTarget), 0);
                            }
                            var ret = UnityEditor.PlayerSettings.GetApiCompatibilityLevel(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("GetApiCompatibilityLevel", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetApiCompatibilityLevel(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.BuildTargetGroup)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.ApiCompatibilityLevel)))
                        {
                            UnityEditor.BuildTargetGroup arg0;
                            if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetApiCompatibilityLevel", typeof(UnityEditor.BuildTargetGroup), 0);
                            }
                            UnityEditor.ApiCompatibilityLevel arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetApiCompatibilityLevel", typeof(UnityEditor.ApiCompatibilityLevel), 1);
                            }
                            UnityEditor.PlayerSettings.SetApiCompatibilityLevel(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.Build.NamedBuildTarget)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.ApiCompatibilityLevel)))
                        {
                            UnityEditor.Build.NamedBuildTarget arg0;
                            if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetApiCompatibilityLevel", typeof(UnityEditor.Build.NamedBuildTarget), 0);
                            }
                            UnityEditor.ApiCompatibilityLevel arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetApiCompatibilityLevel", typeof(UnityEditor.ApiCompatibilityLevel), 1);
                            }
                            UnityEditor.PlayerSettings.SetApiCompatibilityLevel(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("SetApiCompatibilityLevel", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetMobileMTRendering(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.BuildTargetGroup)))
                        {
                            UnityEditor.BuildTargetGroup arg0;
                            if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetMobileMTRendering", typeof(UnityEditor.BuildTargetGroup), 0);
                            }
                            var ret = UnityEditor.PlayerSettings.GetMobileMTRendering(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.Build.NamedBuildTarget)))
                        {
                            UnityEditor.Build.NamedBuildTarget arg0;
                            if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetMobileMTRendering", typeof(UnityEditor.Build.NamedBuildTarget), 0);
                            }
                            var ret = UnityEditor.PlayerSettings.GetMobileMTRendering(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("GetMobileMTRendering", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetMobileMTRendering(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.BuildTargetGroup)) && Values.js_match_type(ctx, argv[1], typeof(bool)))
                        {
                            UnityEditor.BuildTargetGroup arg0;
                            if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetMobileMTRendering", typeof(UnityEditor.BuildTargetGroup), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetMobileMTRendering", typeof(bool), 1);
                            }
                            UnityEditor.PlayerSettings.SetMobileMTRendering(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.Build.NamedBuildTarget)) && Values.js_match_type(ctx, argv[1], typeof(bool)))
                        {
                            UnityEditor.Build.NamedBuildTarget arg0;
                            if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetMobileMTRendering", typeof(UnityEditor.Build.NamedBuildTarget), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetMobileMTRendering", typeof(bool), 1);
                            }
                            UnityEditor.PlayerSettings.SetMobileMTRendering(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("SetMobileMTRendering", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetNormalMapEncoding(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.BuildTargetGroup)))
                        {
                            UnityEditor.BuildTargetGroup arg0;
                            if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetNormalMapEncoding", typeof(UnityEditor.BuildTargetGroup), 0);
                            }
                            var ret = UnityEditor.PlayerSettings.GetNormalMapEncoding(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.Build.NamedBuildTarget)))
                        {
                            UnityEditor.Build.NamedBuildTarget arg0;
                            if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetNormalMapEncoding", typeof(UnityEditor.Build.NamedBuildTarget), 0);
                            }
                            var ret = UnityEditor.PlayerSettings.GetNormalMapEncoding(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("GetNormalMapEncoding", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetNormalMapEncoding(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.BuildTargetGroup)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.NormalMapEncoding)))
                        {
                            UnityEditor.BuildTargetGroup arg0;
                            if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetNormalMapEncoding", typeof(UnityEditor.BuildTargetGroup), 0);
                            }
                            UnityEditor.NormalMapEncoding arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetNormalMapEncoding", typeof(UnityEditor.NormalMapEncoding), 1);
                            }
                            UnityEditor.PlayerSettings.SetNormalMapEncoding(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.Build.NamedBuildTarget)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.NormalMapEncoding)))
                        {
                            UnityEditor.Build.NamedBuildTarget arg0;
                            if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetNormalMapEncoding", typeof(UnityEditor.Build.NamedBuildTarget), 0);
                            }
                            UnityEditor.NormalMapEncoding arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetNormalMapEncoding", typeof(UnityEditor.NormalMapEncoding), 1);
                            }
                            UnityEditor.PlayerSettings.SetNormalMapEncoding(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("SetNormalMapEncoding", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetScriptingDefineSymbols(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        UnityEditor.Build.NamedBuildTarget arg0;
                        if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetScriptingDefineSymbols", typeof(UnityEditor.Build.NamedBuildTarget), 0);
                        }
                        string[] arg1;
                        UnityEditor.PlayerSettings.GetScriptingDefineSymbols(arg0, out arg1);
                        var out0 = Values.js_push_classvalue(ctx, arg1);
                        if (JSApi.JS_IsException(out0))
                        {
                            return out0;
                        }
                        var context = ScriptEngine.GetContext(ctx);
                        JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out0);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 1)
                    {
                        UnityEditor.Build.NamedBuildTarget arg0;
                        if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetScriptingDefineSymbols", typeof(UnityEditor.Build.NamedBuildTarget), 0);
                        }
                        var ret = UnityEditor.PlayerSettings.GetScriptingDefineSymbols(arg0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("GetScriptingDefineSymbols", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetScriptingDefineSymbols(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.Build.NamedBuildTarget)) && Values.js_match_type(ctx, argv[1], typeof(string)))
                        {
                            UnityEditor.Build.NamedBuildTarget arg0;
                            if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetScriptingDefineSymbols", typeof(UnityEditor.Build.NamedBuildTarget), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetScriptingDefineSymbols", typeof(string), 1);
                            }
                            UnityEditor.PlayerSettings.SetScriptingDefineSymbols(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.Build.NamedBuildTarget)) && Values.js_match_type(ctx, argv[1], typeof(string[])))
                        {
                            UnityEditor.Build.NamedBuildTarget arg0;
                            if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetScriptingDefineSymbols", typeof(UnityEditor.Build.NamedBuildTarget), 0);
                            }
                            string[] arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetScriptingDefineSymbols", typeof(string[]), 1);
                            }
                            UnityEditor.PlayerSettings.SetScriptingDefineSymbols(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("SetScriptingDefineSymbols", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetAdditionalCompilerArguments(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.Build.NamedBuildTarget arg0;
                    if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetAdditionalCompilerArguments", typeof(UnityEditor.Build.NamedBuildTarget), 0);
                    }
                    var ret = UnityEditor.PlayerSettings.GetAdditionalCompilerArguments(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetAdditionalCompilerArguments", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetAdditionalCompilerArguments(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEditor.Build.NamedBuildTarget arg0;
                    if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetAdditionalCompilerArguments", typeof(UnityEditor.Build.NamedBuildTarget), 0);
                    }
                    string[] arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetAdditionalCompilerArguments", typeof(string[]), 1);
                    }
                    UnityEditor.PlayerSettings.SetAdditionalCompilerArguments(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetAdditionalCompilerArguments", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetAdditionalIl2CppArgs(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.PlayerSettings.GetAdditionalIl2CppArgs();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetAdditionalIl2CppArgs", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetAdditionalIl2CppArgs(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetAdditionalIl2CppArgs", typeof(string), 0);
                    }
                    UnityEditor.PlayerSettings.SetAdditionalIl2CppArgs(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetAdditionalIl2CppArgs", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetWsaHolographicRemotingEnabled(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.PlayerSettings.GetWsaHolographicRemotingEnabled();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetWsaHolographicRemotingEnabled", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetWsaHolographicRemotingEnabled(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    bool arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetWsaHolographicRemotingEnabled", typeof(bool), 0);
                    }
                    UnityEditor.PlayerSettings.SetWsaHolographicRemotingEnabled(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetWsaHolographicRemotingEnabled", argc);
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
                        throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetStackTraceLogType", typeof(UnityEngine.LogType), 0);
                    }
                    var ret = UnityEditor.PlayerSettings.GetStackTraceLogType(arg0);
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
                        throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetStackTraceLogType", typeof(UnityEngine.LogType), 0);
                    }
                    UnityEngine.StackTraceLogType arg1;
                    if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetStackTraceLogType", typeof(UnityEngine.StackTraceLogType), 1);
                    }
                    UnityEditor.PlayerSettings.SetStackTraceLogType(arg0, arg1);
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
        public static JSValue BindStatic_GetVirtualTexturingSupportEnabled(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.PlayerSettings.GetVirtualTexturingSupportEnabled();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetVirtualTexturingSupportEnabled", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetVirtualTexturingSupportEnabled(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    bool arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetVirtualTexturingSupportEnabled", typeof(bool), 0);
                    }
                    UnityEditor.PlayerSettings.SetVirtualTexturingSupportEnabled(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetVirtualTexturingSupportEnabled", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetShaderPrecisionModel(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.PlayerSettings.GetShaderPrecisionModel();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
                }
                throw new NoSuitableMethodException("GetShaderPrecisionModel", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetShaderPrecisionModel(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.ShaderPrecisionModel arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetShaderPrecisionModel", typeof(UnityEditor.ShaderPrecisionModel), 0);
                    }
                    UnityEditor.PlayerSettings.SetShaderPrecisionModel(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetShaderPrecisionModel", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetPlatformIcons(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.BuildTargetGroup)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.PlatformIconKind)))
                        {
                            UnityEditor.BuildTargetGroup arg0;
                            if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetPlatformIcons", typeof(UnityEditor.BuildTargetGroup), 0);
                            }
                            UnityEditor.PlatformIconKind arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetPlatformIcons", typeof(UnityEditor.PlatformIconKind), 1);
                            }
                            var ret = UnityEditor.PlayerSettings.GetPlatformIcons(arg0, arg1);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.Build.NamedBuildTarget)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.PlatformIconKind)))
                        {
                            UnityEditor.Build.NamedBuildTarget arg0;
                            if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetPlatformIcons", typeof(UnityEditor.Build.NamedBuildTarget), 0);
                            }
                            UnityEditor.PlatformIconKind arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetPlatformIcons", typeof(UnityEditor.PlatformIconKind), 1);
                            }
                            var ret = UnityEditor.PlayerSettings.GetPlatformIcons(arg0, arg1);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("GetPlatformIcons", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetPlatformIcons(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.BuildTargetGroup)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.PlatformIconKind)) && Values.js_match_type(ctx, argv[2], typeof(UnityEditor.PlatformIcon[])))
                        {
                            UnityEditor.BuildTargetGroup arg0;
                            if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetPlatformIcons", typeof(UnityEditor.BuildTargetGroup), 0);
                            }
                            UnityEditor.PlatformIconKind arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetPlatformIcons", typeof(UnityEditor.PlatformIconKind), 1);
                            }
                            UnityEditor.PlatformIcon[] arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetPlatformIcons", typeof(UnityEditor.PlatformIcon[]), 2);
                            }
                            UnityEditor.PlayerSettings.SetPlatformIcons(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.Build.NamedBuildTarget)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.PlatformIconKind)) && Values.js_match_type(ctx, argv[2], typeof(UnityEditor.PlatformIcon[])))
                        {
                            UnityEditor.Build.NamedBuildTarget arg0;
                            if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetPlatformIcons", typeof(UnityEditor.Build.NamedBuildTarget), 0);
                            }
                            UnityEditor.PlatformIconKind arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetPlatformIcons", typeof(UnityEditor.PlatformIconKind), 1);
                            }
                            UnityEditor.PlatformIcon[] arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetPlatformIcons", typeof(UnityEditor.PlatformIcon[]), 2);
                            }
                            UnityEditor.PlayerSettings.SetPlatformIcons(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("SetPlatformIcons", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetSupportedIconKindsForPlatform(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.BuildTargetGroup arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetSupportedIconKindsForPlatform", typeof(UnityEditor.BuildTargetGroup), 0);
                    }
                    var ret = UnityEditor.PlayerSettings.GetSupportedIconKindsForPlatform(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetSupportedIconKindsForPlatform", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetSupportedIconKinds(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.Build.NamedBuildTarget arg0;
                    if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetSupportedIconKinds", typeof(UnityEditor.Build.NamedBuildTarget), 0);
                    }
                    var ret = UnityEditor.PlayerSettings.GetSupportedIconKinds(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetSupportedIconKinds", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetIconsForTargetGroup(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        UnityEditor.BuildTargetGroup arg0;
                        if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetIconsForTargetGroup", typeof(UnityEditor.BuildTargetGroup), 0);
                        }
                        UnityEngine.Texture2D[] arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetIconsForTargetGroup", typeof(UnityEngine.Texture2D[]), 1);
                        }
                        UnityEditor.IconKind arg2;
                        if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetIconsForTargetGroup", typeof(UnityEditor.IconKind), 2);
                        }
                        UnityEditor.PlayerSettings.SetIconsForTargetGroup(arg0, arg1, arg2);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 2)
                    {
                        UnityEditor.BuildTargetGroup arg0;
                        if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetIconsForTargetGroup", typeof(UnityEditor.BuildTargetGroup), 0);
                        }
                        UnityEngine.Texture2D[] arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetIconsForTargetGroup", typeof(UnityEngine.Texture2D[]), 1);
                        }
                        UnityEditor.PlayerSettings.SetIconsForTargetGroup(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("SetIconsForTargetGroup", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetIcons(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEditor.Build.NamedBuildTarget arg0;
                    if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetIcons", typeof(UnityEditor.Build.NamedBuildTarget), 0);
                    }
                    UnityEngine.Texture2D[] arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetIcons", typeof(UnityEngine.Texture2D[]), 1);
                    }
                    UnityEditor.IconKind arg2;
                    if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.PlayerSettings), "SetIcons", typeof(UnityEditor.IconKind), 2);
                    }
                    UnityEditor.PlayerSettings.SetIcons(arg0, arg1, arg2);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetIcons", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetIconsForTargetGroup(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        UnityEditor.BuildTargetGroup arg0;
                        if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetIconsForTargetGroup", typeof(UnityEditor.BuildTargetGroup), 0);
                        }
                        UnityEditor.IconKind arg1;
                        if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetIconsForTargetGroup", typeof(UnityEditor.IconKind), 1);
                        }
                        var ret = UnityEditor.PlayerSettings.GetIconsForTargetGroup(arg0, arg1);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        UnityEditor.BuildTargetGroup arg0;
                        if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetIconsForTargetGroup", typeof(UnityEditor.BuildTargetGroup), 0);
                        }
                        var ret = UnityEditor.PlayerSettings.GetIconsForTargetGroup(arg0);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("GetIconsForTargetGroup", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetIcons(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEditor.Build.NamedBuildTarget arg0;
                    if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetIcons", typeof(UnityEditor.Build.NamedBuildTarget), 0);
                    }
                    UnityEditor.IconKind arg1;
                    if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetIcons", typeof(UnityEditor.IconKind), 1);
                    }
                    var ret = UnityEditor.PlayerSettings.GetIcons(arg0, arg1);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetIcons", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetIconSizesForTargetGroup(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        UnityEditor.BuildTargetGroup arg0;
                        if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetIconSizesForTargetGroup", typeof(UnityEditor.BuildTargetGroup), 0);
                        }
                        UnityEditor.IconKind arg1;
                        if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetIconSizesForTargetGroup", typeof(UnityEditor.IconKind), 1);
                        }
                        var ret = UnityEditor.PlayerSettings.GetIconSizesForTargetGroup(arg0, arg1);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        UnityEditor.BuildTargetGroup arg0;
                        if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetIconSizesForTargetGroup", typeof(UnityEditor.BuildTargetGroup), 0);
                        }
                        var ret = UnityEditor.PlayerSettings.GetIconSizesForTargetGroup(arg0);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("GetIconSizesForTargetGroup", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetIconSizes(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEditor.Build.NamedBuildTarget arg0;
                    if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetIconSizes", typeof(UnityEditor.Build.NamedBuildTarget), 0);
                    }
                    UnityEditor.IconKind arg1;
                    if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.PlayerSettings), "GetIconSizes", typeof(UnityEditor.IconKind), 1);
                    }
                    var ret = UnityEditor.PlayerSettings.GetIconSizes(arg0, arg1);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetIconSizes", argc);
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
                var ret = UnityEditor.PlayerSettings.companyName;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_companyName(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "companyName", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.companyName = value;
                return JSApi.JS_UNDEFINED;
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
                var ret = UnityEditor.PlayerSettings.productName;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_productName(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "productName", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.productName = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_productGUID(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.productGUID;
                return Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_colorSpace(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.colorSpace;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_colorSpace(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.ColorSpace value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "colorSpace", typeof(UnityEngine.ColorSpace), 0);
                }
                UnityEditor.PlayerSettings.colorSpace = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_defaultScreenWidth(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.defaultScreenWidth;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_defaultScreenWidth(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "defaultScreenWidth", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.defaultScreenWidth = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_defaultScreenHeight(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.defaultScreenHeight;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_defaultScreenHeight(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "defaultScreenHeight", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.defaultScreenHeight = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_defaultWebScreenWidth(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.defaultWebScreenWidth;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_defaultWebScreenWidth(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "defaultWebScreenWidth", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.defaultWebScreenWidth = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_defaultWebScreenHeight(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.defaultWebScreenHeight;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_defaultWebScreenHeight(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "defaultWebScreenHeight", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.defaultWebScreenHeight = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_defaultIsNativeResolution(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.defaultIsNativeResolution;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_defaultIsNativeResolution(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "defaultIsNativeResolution", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.defaultIsNativeResolution = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_macRetinaSupport(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.macRetinaSupport;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_macRetinaSupport(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "macRetinaSupport", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.macRetinaSupport = value;
                return JSApi.JS_UNDEFINED;
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
                var ret = UnityEditor.PlayerSettings.runInBackground;
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
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "runInBackground", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.runInBackground = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_captureSingleScreen(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.captureSingleScreen;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_captureSingleScreen(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "captureSingleScreen", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.captureSingleScreen = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_usePlayerLog(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.usePlayerLog;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_usePlayerLog(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "usePlayerLog", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.usePlayerLog = value;
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
                var ret = UnityEditor.PlayerSettings.resizableWindow;
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
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "resizableWindow", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.resizableWindow = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_resetResolutionOnWindowResize(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.resetResolutionOnWindowResize;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_resetResolutionOnWindowResize(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "resetResolutionOnWindowResize", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.resetResolutionOnWindowResize = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_bakeCollisionMeshes(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.bakeCollisionMeshes;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_bakeCollisionMeshes(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "bakeCollisionMeshes", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.bakeCollisionMeshes = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_useMacAppStoreValidation(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.useMacAppStoreValidation;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_useMacAppStoreValidation(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "useMacAppStoreValidation", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.useMacAppStoreValidation = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_fullScreenMode(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.fullScreenMode;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_fullScreenMode(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.FullScreenMode value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "fullScreenMode", typeof(UnityEngine.FullScreenMode), 0);
                }
                UnityEditor.PlayerSettings.fullScreenMode = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_enable360StereoCapture(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.enable360StereoCapture;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_enable360StereoCapture(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "enable360StereoCapture", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.enable360StereoCapture = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_stereoRenderingPath(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.stereoRenderingPath;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_stereoRenderingPath(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.StereoRenderingPath value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "stereoRenderingPath", typeof(UnityEditor.StereoRenderingPath), 0);
                }
                UnityEditor.PlayerSettings.stereoRenderingPath = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_enableFrameTimingStats(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.enableFrameTimingStats;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_enableFrameTimingStats(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "enableFrameTimingStats", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.enableFrameTimingStats = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_enableOpenGLProfilerGPURecorders(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.enableOpenGLProfilerGPURecorders;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_enableOpenGLProfilerGPURecorders(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "enableOpenGLProfilerGPURecorders", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.enableOpenGLProfilerGPURecorders = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_useHDRDisplay(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.useHDRDisplay;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_useHDRDisplay(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "useHDRDisplay", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.useHDRDisplay = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_D3DHDRBitDepth(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.D3DHDRBitDepth;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_D3DHDRBitDepth(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.D3DHDRDisplayBitDepth value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "D3DHDRBitDepth", typeof(UnityEngine.D3DHDRDisplayBitDepth), 0);
                }
                UnityEditor.PlayerSettings.D3DHDRBitDepth = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_visibleInBackground(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.visibleInBackground;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_visibleInBackground(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "visibleInBackground", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.visibleInBackground = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_allowFullscreenSwitch(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.allowFullscreenSwitch;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_allowFullscreenSwitch(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "allowFullscreenSwitch", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.allowFullscreenSwitch = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_forceSingleInstance(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.forceSingleInstance;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_forceSingleInstance(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "forceSingleInstance", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.forceSingleInstance = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_useFlipModelSwapchain(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.useFlipModelSwapchain;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_useFlipModelSwapchain(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "useFlipModelSwapchain", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.useFlipModelSwapchain = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_openGLRequireES31(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.openGLRequireES31;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_openGLRequireES31(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "openGLRequireES31", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.openGLRequireES31 = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_openGLRequireES31AEP(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.openGLRequireES31AEP;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_openGLRequireES31AEP(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "openGLRequireES31AEP", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.openGLRequireES31AEP = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_openGLRequireES32(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.openGLRequireES32;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_openGLRequireES32(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "openGLRequireES32", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.openGLRequireES32 = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_virtualRealitySplashScreen(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.virtualRealitySplashScreen;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_virtualRealitySplashScreen(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Texture2D value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "virtualRealitySplashScreen", typeof(UnityEngine.Texture2D), 0);
                }
                UnityEditor.PlayerSettings.virtualRealitySplashScreen = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_assemblyVersionValidation(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.assemblyVersionValidation;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_assemblyVersionValidation(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "assemblyVersionValidation", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.assemblyVersionValidation = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_suppressCommonWarnings(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.suppressCommonWarnings;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_suppressCommonWarnings(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "suppressCommonWarnings", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.suppressCommonWarnings = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_allowUnsafeCode(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.allowUnsafeCode;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_allowUnsafeCode(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "allowUnsafeCode", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.allowUnsafeCode = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_gcIncremental(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.gcIncremental;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_gcIncremental(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "gcIncremental", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.gcIncremental = value;
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
                var ret = UnityEditor.PlayerSettings.keystorePass;
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
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "keystorePass", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.keystorePass = value;
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
                var ret = UnityEditor.PlayerSettings.keyaliasPass;
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
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "keyaliasPass", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.keyaliasPass = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_gpuSkinning(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.gpuSkinning;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_gpuSkinning(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "gpuSkinning", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.gpuSkinning = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_graphicsJobs(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.graphicsJobs;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_graphicsJobs(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "graphicsJobs", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.graphicsJobs = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_graphicsJobMode(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.graphicsJobMode;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_graphicsJobMode(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.GraphicsJobMode value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "graphicsJobMode", typeof(UnityEditor.GraphicsJobMode), 0);
                }
                UnityEditor.PlayerSettings.graphicsJobMode = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_xboxPIXTextureCapture(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.xboxPIXTextureCapture;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_xboxEnableAvatar(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.xboxEnableAvatar;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_xboxOneResolution(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.xboxOneResolution;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_enableInternalProfiler(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.enableInternalProfiler;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_enableInternalProfiler(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "enableInternalProfiler", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.enableInternalProfiler = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_actionOnDotNetUnhandledException(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.actionOnDotNetUnhandledException;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_actionOnDotNetUnhandledException(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.ActionOnDotNetUnhandledException value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "actionOnDotNetUnhandledException", typeof(UnityEditor.ActionOnDotNetUnhandledException), 0);
                }
                UnityEditor.PlayerSettings.actionOnDotNetUnhandledException = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_logObjCUncaughtExceptions(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.logObjCUncaughtExceptions;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_logObjCUncaughtExceptions(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "logObjCUncaughtExceptions", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.logObjCUncaughtExceptions = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_enableCrashReportAPI(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.enableCrashReportAPI;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_enableCrashReportAPI(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "enableCrashReportAPI", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.enableCrashReportAPI = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_applicationIdentifier(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.applicationIdentifier;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_applicationIdentifier(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "applicationIdentifier", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.applicationIdentifier = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_bundleVersion(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.bundleVersion;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_bundleVersion(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "bundleVersion", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.bundleVersion = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_statusBarHidden(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.statusBarHidden;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_statusBarHidden(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "statusBarHidden", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.statusBarHidden = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_stripEngineCode(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.stripEngineCode;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_stripEngineCode(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "stripEngineCode", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.stripEngineCode = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_defaultInterfaceOrientation(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.defaultInterfaceOrientation;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_defaultInterfaceOrientation(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.UIOrientation value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "defaultInterfaceOrientation", typeof(UnityEditor.UIOrientation), 0);
                }
                UnityEditor.PlayerSettings.defaultInterfaceOrientation = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_allowedAutorotateToPortrait(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.allowedAutorotateToPortrait;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_allowedAutorotateToPortrait(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "allowedAutorotateToPortrait", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.allowedAutorotateToPortrait = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_allowedAutorotateToPortraitUpsideDown(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.allowedAutorotateToPortraitUpsideDown;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_allowedAutorotateToPortraitUpsideDown(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "allowedAutorotateToPortraitUpsideDown", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.allowedAutorotateToPortraitUpsideDown = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_allowedAutorotateToLandscapeRight(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.allowedAutorotateToLandscapeRight;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_allowedAutorotateToLandscapeRight(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "allowedAutorotateToLandscapeRight", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.allowedAutorotateToLandscapeRight = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_allowedAutorotateToLandscapeLeft(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.allowedAutorotateToLandscapeLeft;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_allowedAutorotateToLandscapeLeft(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "allowedAutorotateToLandscapeLeft", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.allowedAutorotateToLandscapeLeft = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_useAnimatedAutorotation(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.useAnimatedAutorotation;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_useAnimatedAutorotation(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "useAnimatedAutorotation", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.useAnimatedAutorotation = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_use32BitDisplayBuffer(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.use32BitDisplayBuffer;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_use32BitDisplayBuffer(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "use32BitDisplayBuffer", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.use32BitDisplayBuffer = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_preserveFramebufferAlpha(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.preserveFramebufferAlpha;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_preserveFramebufferAlpha(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "preserveFramebufferAlpha", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.preserveFramebufferAlpha = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_stripUnusedMeshComponents(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.stripUnusedMeshComponents;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_stripUnusedMeshComponents(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "stripUnusedMeshComponents", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.stripUnusedMeshComponents = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_mipStripping(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.mipStripping;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_mipStripping(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "mipStripping", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.mipStripping = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_advancedLicense(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.advancedLicense;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_aotOptions(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.aotOptions;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_aotOptions(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "aotOptions", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.aotOptions = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_defaultCursor(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.defaultCursor;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_defaultCursor(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Texture2D value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "defaultCursor", typeof(UnityEngine.Texture2D), 0);
                }
                UnityEditor.PlayerSettings.defaultCursor = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_cursorHotspot(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.cursorHotspot;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_cursorHotspot(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Vector2 value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "cursorHotspot", typeof(UnityEngine.Vector2), 0);
                }
                UnityEditor.PlayerSettings.cursorHotspot = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_accelerometerFrequency(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.accelerometerFrequency;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_accelerometerFrequency(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "accelerometerFrequency", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.accelerometerFrequency = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_MTRendering(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.MTRendering;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_MTRendering(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "MTRendering", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.MTRendering = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_muteOtherAudioSources(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.muteOtherAudioSources;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_muteOtherAudioSources(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "muteOtherAudioSources", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.muteOtherAudioSources = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_legacyClampBlendShapeWeights(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.legacyClampBlendShapeWeights;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_legacyClampBlendShapeWeights(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "legacyClampBlendShapeWeights", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.legacyClampBlendShapeWeights = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_enableMetalAPIValidation(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.enableMetalAPIValidation;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_enableMetalAPIValidation(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "enableMetalAPIValidation", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.enableMetalAPIValidation = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_windowsGamepadBackendHint(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.windowsGamepadBackendHint;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_windowsGamepadBackendHint(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.WindowsGamepadBackendHint value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "windowsGamepadBackendHint", typeof(UnityEditor.WindowsGamepadBackendHint), 0);
                }
                UnityEditor.PlayerSettings.windowsGamepadBackendHint = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_vulkanEnableSetSRGBWrite(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.vulkanEnableSetSRGBWrite;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_vulkanEnableSetSRGBWrite(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "vulkanEnableSetSRGBWrite", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.vulkanEnableSetSRGBWrite = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_vulkanNumSwapchainBuffers(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.vulkanNumSwapchainBuffers;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_vulkanNumSwapchainBuffers(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                uint value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "vulkanNumSwapchainBuffers", typeof(uint), 0);
                }
                UnityEditor.PlayerSettings.vulkanNumSwapchainBuffers = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_vulkanEnableLateAcquireNextImage(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.vulkanEnableLateAcquireNextImage;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_vulkanEnableLateAcquireNextImage(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "vulkanEnableLateAcquireNextImage", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.vulkanEnableLateAcquireNextImage = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_vulkanEnablePreTransform(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.vulkanEnablePreTransform;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_vulkanEnablePreTransform(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings), "vulkanEnablePreTransform", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.vulkanEnablePreTransform = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("PlayerSettings", typeof(UnityEditor.PlayerSettings), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "HasAspectRatio", BindStatic_HasAspectRatio);
            cls.AddMethod(true, "SetAspectRatio", BindStatic_SetAspectRatio);
            cls.AddMethod(true, "GetPreloadedAssets", BindStatic_GetPreloadedAssets);
            cls.AddMethod(true, "SetPreloadedAssets", BindStatic_SetPreloadedAssets);
            cls.AddMethod(true, "GetShaderChunkSizeInMBForPlatform", BindStatic_GetShaderChunkSizeInMBForPlatform);
            cls.AddMethod(true, "SetShaderChunkSizeInMBForPlatform", BindStatic_SetShaderChunkSizeInMBForPlatform);
            cls.AddMethod(true, "GetShaderChunkCountForPlatform", BindStatic_GetShaderChunkCountForPlatform);
            cls.AddMethod(true, "SetShaderChunkCountForPlatform", BindStatic_SetShaderChunkCountForPlatform);
            cls.AddMethod(true, "GetDefaultShaderChunkSizeInMB", BindStatic_GetDefaultShaderChunkSizeInMB);
            cls.AddMethod(true, "SetDefaultShaderChunkSizeInMB", BindStatic_SetDefaultShaderChunkSizeInMB);
            cls.AddMethod(true, "GetDefaultShaderChunkCount", BindStatic_GetDefaultShaderChunkCount);
            cls.AddMethod(true, "SetDefaultShaderChunkCount", BindStatic_SetDefaultShaderChunkCount);
            cls.AddMethod(true, "GetOverrideShaderChunkSettingsForPlatform", BindStatic_GetOverrideShaderChunkSettingsForPlatform);
            cls.AddMethod(true, "SetOverrideShaderChunkSettingsForPlatform", BindStatic_SetOverrideShaderChunkSettingsForPlatform);
            cls.AddMethod(true, "GetGraphicsAPIs", BindStatic_GetGraphicsAPIs);
            cls.AddMethod(true, "SetGraphicsAPIs", BindStatic_SetGraphicsAPIs);
            cls.AddMethod(true, "GetUseDefaultGraphicsAPIs", BindStatic_GetUseDefaultGraphicsAPIs);
            cls.AddMethod(true, "SetUseDefaultGraphicsAPIs", BindStatic_SetUseDefaultGraphicsAPIs);
            cls.AddMethod(true, "SetTemplateCustomValue", BindStatic_SetTemplateCustomValue);
            cls.AddMethod(true, "GetTemplateCustomValue", BindStatic_GetTemplateCustomValue);
            cls.AddMethod(true, "GetScriptingDefineSymbolsForGroup", BindStatic_GetScriptingDefineSymbolsForGroup);
            cls.AddMethod(true, "SetScriptingDefineSymbolsForGroup", BindStatic_SetScriptingDefineSymbolsForGroup);
            cls.AddMethod(true, "GetAdditionalCompilerArgumentsForGroup", BindStatic_GetAdditionalCompilerArgumentsForGroup);
            cls.AddMethod(true, "SetAdditionalCompilerArgumentsForGroup", BindStatic_SetAdditionalCompilerArgumentsForGroup);
            cls.AddMethod(true, "GetArchitecture", BindStatic_GetArchitecture);
            cls.AddMethod(true, "SetArchitecture", BindStatic_SetArchitecture);
            cls.AddMethod(true, "GetScriptingBackend", BindStatic_GetScriptingBackend);
            cls.AddMethod(true, "SetScriptingBackend", BindStatic_SetScriptingBackend);
            cls.AddMethod(true, "GetDefaultScriptingBackend", BindStatic_GetDefaultScriptingBackend);
            cls.AddMethod(true, "GetApplicationIdentifier", BindStatic_GetApplicationIdentifier);
            cls.AddMethod(true, "SetApplicationIdentifier", BindStatic_SetApplicationIdentifier);
            cls.AddMethod(true, "GetIl2CppCompilerConfiguration", BindStatic_GetIl2CppCompilerConfiguration);
            cls.AddMethod(true, "SetIl2CppCompilerConfiguration", BindStatic_SetIl2CppCompilerConfiguration);
            cls.AddMethod(true, "GetIncrementalIl2CppBuild", BindStatic_GetIncrementalIl2CppBuild);
            cls.AddMethod(true, "SetIncrementalIl2CppBuild", BindStatic_SetIncrementalIl2CppBuild);
            cls.AddMethod(true, "SetManagedStrippingLevel", BindStatic_SetManagedStrippingLevel);
            cls.AddMethod(true, "GetManagedStrippingLevel", BindStatic_GetManagedStrippingLevel);
            cls.AddMethod(true, "GetApiCompatibilityLevel", BindStatic_GetApiCompatibilityLevel);
            cls.AddMethod(true, "SetApiCompatibilityLevel", BindStatic_SetApiCompatibilityLevel);
            cls.AddMethod(true, "GetMobileMTRendering", BindStatic_GetMobileMTRendering);
            cls.AddMethod(true, "SetMobileMTRendering", BindStatic_SetMobileMTRendering);
            cls.AddMethod(true, "GetNormalMapEncoding", BindStatic_GetNormalMapEncoding);
            cls.AddMethod(true, "SetNormalMapEncoding", BindStatic_SetNormalMapEncoding);
            cls.AddMethod(true, "GetScriptingDefineSymbols", BindStatic_GetScriptingDefineSymbols);
            cls.AddMethod(true, "SetScriptingDefineSymbols", BindStatic_SetScriptingDefineSymbols);
            cls.AddMethod(true, "GetAdditionalCompilerArguments", BindStatic_GetAdditionalCompilerArguments);
            cls.AddMethod(true, "SetAdditionalCompilerArguments", BindStatic_SetAdditionalCompilerArguments);
            cls.AddMethod(true, "GetAdditionalIl2CppArgs", BindStatic_GetAdditionalIl2CppArgs);
            cls.AddMethod(true, "SetAdditionalIl2CppArgs", BindStatic_SetAdditionalIl2CppArgs);
            cls.AddMethod(true, "GetWsaHolographicRemotingEnabled", BindStatic_GetWsaHolographicRemotingEnabled);
            cls.AddMethod(true, "SetWsaHolographicRemotingEnabled", BindStatic_SetWsaHolographicRemotingEnabled);
            cls.AddMethod(true, "GetStackTraceLogType", BindStatic_GetStackTraceLogType);
            cls.AddMethod(true, "SetStackTraceLogType", BindStatic_SetStackTraceLogType);
            cls.AddMethod(true, "GetVirtualTexturingSupportEnabled", BindStatic_GetVirtualTexturingSupportEnabled);
            cls.AddMethod(true, "SetVirtualTexturingSupportEnabled", BindStatic_SetVirtualTexturingSupportEnabled);
            cls.AddMethod(true, "GetShaderPrecisionModel", BindStatic_GetShaderPrecisionModel);
            cls.AddMethod(true, "SetShaderPrecisionModel", BindStatic_SetShaderPrecisionModel);
            cls.AddMethod(true, "GetPlatformIcons", BindStatic_GetPlatformIcons);
            cls.AddMethod(true, "SetPlatformIcons", BindStatic_SetPlatformIcons);
            cls.AddMethod(true, "GetSupportedIconKindsForPlatform", BindStatic_GetSupportedIconKindsForPlatform);
            cls.AddMethod(true, "GetSupportedIconKinds", BindStatic_GetSupportedIconKinds);
            cls.AddMethod(true, "SetIconsForTargetGroup", BindStatic_SetIconsForTargetGroup);
            cls.AddMethod(true, "SetIcons", BindStatic_SetIcons);
            cls.AddMethod(true, "GetIconsForTargetGroup", BindStatic_GetIconsForTargetGroup);
            cls.AddMethod(true, "GetIcons", BindStatic_GetIcons);
            cls.AddMethod(true, "GetIconSizesForTargetGroup", BindStatic_GetIconSizesForTargetGroup);
            cls.AddMethod(true, "GetIconSizes", BindStatic_GetIconSizes);
            cls.AddProperty(true, "companyName", BindStaticRead_companyName, BindStaticWrite_companyName);
            cls.AddProperty(true, "productName", BindStaticRead_productName, BindStaticWrite_productName);
            cls.AddProperty(true, "productGUID", BindStaticRead_productGUID, null);
            cls.AddProperty(true, "colorSpace", BindStaticRead_colorSpace, BindStaticWrite_colorSpace);
            cls.AddProperty(true, "defaultScreenWidth", BindStaticRead_defaultScreenWidth, BindStaticWrite_defaultScreenWidth);
            cls.AddProperty(true, "defaultScreenHeight", BindStaticRead_defaultScreenHeight, BindStaticWrite_defaultScreenHeight);
            cls.AddProperty(true, "defaultWebScreenWidth", BindStaticRead_defaultWebScreenWidth, BindStaticWrite_defaultWebScreenWidth);
            cls.AddProperty(true, "defaultWebScreenHeight", BindStaticRead_defaultWebScreenHeight, BindStaticWrite_defaultWebScreenHeight);
            cls.AddProperty(true, "defaultIsNativeResolution", BindStaticRead_defaultIsNativeResolution, BindStaticWrite_defaultIsNativeResolution);
            cls.AddProperty(true, "macRetinaSupport", BindStaticRead_macRetinaSupport, BindStaticWrite_macRetinaSupport);
            cls.AddProperty(true, "runInBackground", BindStaticRead_runInBackground, BindStaticWrite_runInBackground);
            cls.AddProperty(true, "captureSingleScreen", BindStaticRead_captureSingleScreen, BindStaticWrite_captureSingleScreen);
            cls.AddProperty(true, "usePlayerLog", BindStaticRead_usePlayerLog, BindStaticWrite_usePlayerLog);
            cls.AddProperty(true, "resizableWindow", BindStaticRead_resizableWindow, BindStaticWrite_resizableWindow);
            cls.AddProperty(true, "resetResolutionOnWindowResize", BindStaticRead_resetResolutionOnWindowResize, BindStaticWrite_resetResolutionOnWindowResize);
            cls.AddProperty(true, "bakeCollisionMeshes", BindStaticRead_bakeCollisionMeshes, BindStaticWrite_bakeCollisionMeshes);
            cls.AddProperty(true, "useMacAppStoreValidation", BindStaticRead_useMacAppStoreValidation, BindStaticWrite_useMacAppStoreValidation);
            cls.AddProperty(true, "fullScreenMode", BindStaticRead_fullScreenMode, BindStaticWrite_fullScreenMode);
            cls.AddProperty(true, "enable360StereoCapture", BindStaticRead_enable360StereoCapture, BindStaticWrite_enable360StereoCapture);
            cls.AddProperty(true, "stereoRenderingPath", BindStaticRead_stereoRenderingPath, BindStaticWrite_stereoRenderingPath);
            cls.AddProperty(true, "enableFrameTimingStats", BindStaticRead_enableFrameTimingStats, BindStaticWrite_enableFrameTimingStats);
            cls.AddProperty(true, "enableOpenGLProfilerGPURecorders", BindStaticRead_enableOpenGLProfilerGPURecorders, BindStaticWrite_enableOpenGLProfilerGPURecorders);
            cls.AddProperty(true, "useHDRDisplay", BindStaticRead_useHDRDisplay, BindStaticWrite_useHDRDisplay);
            cls.AddProperty(true, "D3DHDRBitDepth", BindStaticRead_D3DHDRBitDepth, BindStaticWrite_D3DHDRBitDepth);
            cls.AddProperty(true, "visibleInBackground", BindStaticRead_visibleInBackground, BindStaticWrite_visibleInBackground);
            cls.AddProperty(true, "allowFullscreenSwitch", BindStaticRead_allowFullscreenSwitch, BindStaticWrite_allowFullscreenSwitch);
            cls.AddProperty(true, "forceSingleInstance", BindStaticRead_forceSingleInstance, BindStaticWrite_forceSingleInstance);
            cls.AddProperty(true, "useFlipModelSwapchain", BindStaticRead_useFlipModelSwapchain, BindStaticWrite_useFlipModelSwapchain);
            cls.AddProperty(true, "openGLRequireES31", BindStaticRead_openGLRequireES31, BindStaticWrite_openGLRequireES31);
            cls.AddProperty(true, "openGLRequireES31AEP", BindStaticRead_openGLRequireES31AEP, BindStaticWrite_openGLRequireES31AEP);
            cls.AddProperty(true, "openGLRequireES32", BindStaticRead_openGLRequireES32, BindStaticWrite_openGLRequireES32);
            cls.AddProperty(true, "virtualRealitySplashScreen", BindStaticRead_virtualRealitySplashScreen, BindStaticWrite_virtualRealitySplashScreen);
            cls.AddProperty(true, "assemblyVersionValidation", BindStaticRead_assemblyVersionValidation, BindStaticWrite_assemblyVersionValidation);
            cls.AddProperty(true, "suppressCommonWarnings", BindStaticRead_suppressCommonWarnings, BindStaticWrite_suppressCommonWarnings);
            cls.AddProperty(true, "allowUnsafeCode", BindStaticRead_allowUnsafeCode, BindStaticWrite_allowUnsafeCode);
            cls.AddProperty(true, "gcIncremental", BindStaticRead_gcIncremental, BindStaticWrite_gcIncremental);
            cls.AddProperty(true, "keystorePass", BindStaticRead_keystorePass, BindStaticWrite_keystorePass);
            cls.AddProperty(true, "keyaliasPass", BindStaticRead_keyaliasPass, BindStaticWrite_keyaliasPass);
            cls.AddProperty(true, "gpuSkinning", BindStaticRead_gpuSkinning, BindStaticWrite_gpuSkinning);
            cls.AddProperty(true, "graphicsJobs", BindStaticRead_graphicsJobs, BindStaticWrite_graphicsJobs);
            cls.AddProperty(true, "graphicsJobMode", BindStaticRead_graphicsJobMode, BindStaticWrite_graphicsJobMode);
            cls.AddProperty(true, "xboxPIXTextureCapture", BindStaticRead_xboxPIXTextureCapture, null);
            cls.AddProperty(true, "xboxEnableAvatar", BindStaticRead_xboxEnableAvatar, null);
            cls.AddProperty(true, "xboxOneResolution", BindStaticRead_xboxOneResolution, null);
            cls.AddProperty(true, "enableInternalProfiler", BindStaticRead_enableInternalProfiler, BindStaticWrite_enableInternalProfiler);
            cls.AddProperty(true, "actionOnDotNetUnhandledException", BindStaticRead_actionOnDotNetUnhandledException, BindStaticWrite_actionOnDotNetUnhandledException);
            cls.AddProperty(true, "logObjCUncaughtExceptions", BindStaticRead_logObjCUncaughtExceptions, BindStaticWrite_logObjCUncaughtExceptions);
            cls.AddProperty(true, "enableCrashReportAPI", BindStaticRead_enableCrashReportAPI, BindStaticWrite_enableCrashReportAPI);
            cls.AddProperty(true, "applicationIdentifier", BindStaticRead_applicationIdentifier, BindStaticWrite_applicationIdentifier);
            cls.AddProperty(true, "bundleVersion", BindStaticRead_bundleVersion, BindStaticWrite_bundleVersion);
            cls.AddProperty(true, "statusBarHidden", BindStaticRead_statusBarHidden, BindStaticWrite_statusBarHidden);
            cls.AddProperty(true, "stripEngineCode", BindStaticRead_stripEngineCode, BindStaticWrite_stripEngineCode);
            cls.AddProperty(true, "defaultInterfaceOrientation", BindStaticRead_defaultInterfaceOrientation, BindStaticWrite_defaultInterfaceOrientation);
            cls.AddProperty(true, "allowedAutorotateToPortrait", BindStaticRead_allowedAutorotateToPortrait, BindStaticWrite_allowedAutorotateToPortrait);
            cls.AddProperty(true, "allowedAutorotateToPortraitUpsideDown", BindStaticRead_allowedAutorotateToPortraitUpsideDown, BindStaticWrite_allowedAutorotateToPortraitUpsideDown);
            cls.AddProperty(true, "allowedAutorotateToLandscapeRight", BindStaticRead_allowedAutorotateToLandscapeRight, BindStaticWrite_allowedAutorotateToLandscapeRight);
            cls.AddProperty(true, "allowedAutorotateToLandscapeLeft", BindStaticRead_allowedAutorotateToLandscapeLeft, BindStaticWrite_allowedAutorotateToLandscapeLeft);
            cls.AddProperty(true, "useAnimatedAutorotation", BindStaticRead_useAnimatedAutorotation, BindStaticWrite_useAnimatedAutorotation);
            cls.AddProperty(true, "use32BitDisplayBuffer", BindStaticRead_use32BitDisplayBuffer, BindStaticWrite_use32BitDisplayBuffer);
            cls.AddProperty(true, "preserveFramebufferAlpha", BindStaticRead_preserveFramebufferAlpha, BindStaticWrite_preserveFramebufferAlpha);
            cls.AddProperty(true, "stripUnusedMeshComponents", BindStaticRead_stripUnusedMeshComponents, BindStaticWrite_stripUnusedMeshComponents);
            cls.AddProperty(true, "mipStripping", BindStaticRead_mipStripping, BindStaticWrite_mipStripping);
            cls.AddProperty(true, "advancedLicense", BindStaticRead_advancedLicense, null);
            cls.AddProperty(true, "aotOptions", BindStaticRead_aotOptions, BindStaticWrite_aotOptions);
            cls.AddProperty(true, "defaultCursor", BindStaticRead_defaultCursor, BindStaticWrite_defaultCursor);
            cls.AddProperty(true, "cursorHotspot", BindStaticRead_cursorHotspot, BindStaticWrite_cursorHotspot);
            cls.AddProperty(true, "accelerometerFrequency", BindStaticRead_accelerometerFrequency, BindStaticWrite_accelerometerFrequency);
            cls.AddProperty(true, "MTRendering", BindStaticRead_MTRendering, BindStaticWrite_MTRendering);
            cls.AddProperty(true, "muteOtherAudioSources", BindStaticRead_muteOtherAudioSources, BindStaticWrite_muteOtherAudioSources);
            cls.AddProperty(true, "legacyClampBlendShapeWeights", BindStaticRead_legacyClampBlendShapeWeights, BindStaticWrite_legacyClampBlendShapeWeights);
            cls.AddProperty(true, "enableMetalAPIValidation", BindStaticRead_enableMetalAPIValidation, BindStaticWrite_enableMetalAPIValidation);
            cls.AddProperty(true, "windowsGamepadBackendHint", BindStaticRead_windowsGamepadBackendHint, BindStaticWrite_windowsGamepadBackendHint);
            cls.AddProperty(true, "vulkanEnableSetSRGBWrite", BindStaticRead_vulkanEnableSetSRGBWrite, BindStaticWrite_vulkanEnableSetSRGBWrite);
            cls.AddProperty(true, "vulkanNumSwapchainBuffers", BindStaticRead_vulkanNumSwapchainBuffers, BindStaticWrite_vulkanNumSwapchainBuffers);
            cls.AddProperty(true, "vulkanEnableLateAcquireNextImage", BindStaticRead_vulkanEnableLateAcquireNextImage, BindStaticWrite_vulkanEnableLateAcquireNextImage);
            cls.AddProperty(true, "vulkanEnablePreTransform", BindStaticRead_vulkanEnablePreTransform, BindStaticWrite_vulkanEnablePreTransform);
            return cls;
        }
    }
}
#endif
#endif
