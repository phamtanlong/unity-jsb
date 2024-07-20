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
    // Type: UnityEditor.Lightmapping
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_Lightmapping
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ClearDiskCache(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.Lightmapping.ClearDiskCache();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ClearDiskCache", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_BakeAsync(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.Lightmapping.BakeAsync();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("BakeAsync", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Bake(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.Lightmapping.Bake();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("Bake", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Cancel(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.Lightmapping.Cancel();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Cancel", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ForceStop(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.Lightmapping.ForceStop();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ForceStop", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Clear(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.Lightmapping.Clear();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Clear", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ClearLightingDataAsset(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.Lightmapping.ClearLightingDataAsset();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ClearLightingDataAsset", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Tetrahedralize(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Vector3[] arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Lightmapping), "Tetrahedralize", typeof(UnityEngine.Vector3[]), 0);
                    }
                    int[] arg1;
                    UnityEngine.Vector3[] arg2;
                    UnityEditor.Lightmapping.Tetrahedralize(arg0, out arg1, out arg2);
                    var out0 = Values.js_push_classvalue(ctx, arg1);
                    if (JSApi.JS_IsException(out0))
                    {
                        return out0;
                    }
                    var context = ScriptEngine.GetContext(ctx);
                    JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out0);
                    var out1 = Values.js_push_classvalue(ctx, arg2);
                    if (JSApi.JS_IsException(out1))
                    {
                        return out1;
                    }
                    JSApi.JS_SetProperty(ctx, argv[2], context.GetAtom("value"), out1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Tetrahedralize", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_BakeReflectionProbe(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.ReflectionProbe arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Lightmapping), "BakeReflectionProbe", typeof(UnityEngine.ReflectionProbe), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Lightmapping), "BakeReflectionProbe", typeof(string), 1);
                    }
                    var ret = UnityEditor.Lightmapping.BakeReflectionProbe(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("BakeReflectionProbe", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetTerrainGIChunks(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Terrain arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Lightmapping), "GetTerrainGIChunks", typeof(UnityEngine.Terrain), 0);
                    }
                    int arg1;
                    var refVal1 = Values.js_read_wrap(ctx, argv[1]);
                    if (refVal1.IsException())
                    {
                        return refVal1;
                    }
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, refVal1, out arg1))
                    {
                        JSApi.JS_FreeValue(ctx, refVal1);
                        throw new ParameterException(typeof(UnityEditor.Lightmapping), "GetTerrainGIChunks", typeof(int), 1);
                    }
                    JSApi.JS_FreeValue(ctx, refVal1);
                    int arg2;
                    var refVal2 = Values.js_read_wrap(ctx, argv[2]);
                    if (refVal2.IsException())
                    {
                        return refVal2;
                    }
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, refVal2, out arg2))
                    {
                        JSApi.JS_FreeValue(ctx, refVal2);
                        throw new ParameterException(typeof(UnityEditor.Lightmapping), "GetTerrainGIChunks", typeof(int), 2);
                    }
                    JSApi.JS_FreeValue(ctx, refVal2);
                    UnityEditor.Lightmapping.GetTerrainGIChunks(arg0, ref arg1, ref arg2);
                    var out0 = QuickJS.Binding.Values.js_push_primitive(ctx, arg1);
                    if (JSApi.JS_IsException(out0))
                    {
                        return out0;
                    }
                    var context = ScriptEngine.GetContext(ctx);
                    JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out0);
                    var out1 = QuickJS.Binding.Values.js_push_primitive(ctx, arg2);
                    if (JSApi.JS_IsException(out1))
                    {
                        return out1;
                    }
                    JSApi.JS_SetProperty(ctx, argv[2], context.GetAtom("value"), out1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("GetTerrainGIChunks", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_TryGetLightingSettings(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.LightingSettings arg0;
                    var ret = UnityEditor.Lightmapping.TryGetLightingSettings(out arg0);
                    var out0 = Values.js_push_classvalue(ctx, arg0);
                    if (JSApi.JS_IsException(out0))
                    {
                        return out0;
                    }
                    var context = ScriptEngine.GetContext(ctx);
                    JSApi.JS_SetProperty(ctx, argv[0], context.GetAtom("value"), out0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("TryGetLightingSettings", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetLightingSettingsForScene(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.SceneManagement.Scene arg0;
                    if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Lightmapping), "SetLightingSettingsForScene", typeof(UnityEngine.SceneManagement.Scene), 0);
                    }
                    UnityEngine.LightingSettings arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Lightmapping), "SetLightingSettingsForScene", typeof(UnityEngine.LightingSettings), 1);
                    }
                    UnityEditor.Lightmapping.SetLightingSettingsForScene(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetLightingSettingsForScene", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetLightingSettingsForScenes(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.SceneManagement.Scene[] arg0;
                    if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Lightmapping), "SetLightingSettingsForScenes", typeof(UnityEngine.SceneManagement.Scene[]), 0);
                    }
                    UnityEngine.LightingSettings arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Lightmapping), "SetLightingSettingsForScenes", typeof(UnityEngine.LightingSettings), 1);
                    }
                    UnityEditor.Lightmapping.SetLightingSettingsForScenes(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetLightingSettingsForScenes", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetLightingSettingsForScene(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.SceneManagement.Scene arg0;
                    if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Lightmapping), "GetLightingSettingsForScene", typeof(UnityEngine.SceneManagement.Scene), 0);
                    }
                    var ret = UnityEditor.Lightmapping.GetLightingSettingsForScene(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetLightingSettingsForScene", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_BakeMultipleScenes(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string[] arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Lightmapping), "BakeMultipleScenes", typeof(string[]), 0);
                    }
                    UnityEditor.Lightmapping.BakeMultipleScenes(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("BakeMultipleScenes", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_giWorkflowMode(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Lightmapping.giWorkflowMode;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_giWorkflowMode(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.Lightmapping.GIWorkflowMode value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.Lightmapping), "giWorkflowMode", typeof(UnityEditor.Lightmapping.GIWorkflowMode), 0);
                }
                UnityEditor.Lightmapping.giWorkflowMode = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_realtimeGI(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Lightmapping.realtimeGI;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_realtimeGI(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.Lightmapping), "realtimeGI", typeof(bool), 0);
                }
                UnityEditor.Lightmapping.realtimeGI = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_bakedGI(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Lightmapping.bakedGI;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_bakedGI(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.Lightmapping), "bakedGI", typeof(bool), 0);
                }
                UnityEditor.Lightmapping.bakedGI = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_isRunning(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Lightmapping.isRunning;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_buildProgress(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Lightmapping.buildProgress;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_lightingDataAsset(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Lightmapping.lightingDataAsset;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_lightingDataAsset(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.LightingDataAsset value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.Lightmapping), "lightingDataAsset", typeof(UnityEditor.LightingDataAsset), 0);
                }
                UnityEditor.Lightmapping.lightingDataAsset = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_lightingSettings(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Lightmapping.lightingSettings;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_lightingSettings(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.LightingSettings value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.Lightmapping), "lightingSettings", typeof(UnityEngine.LightingSettings), 0);
                }
                UnityEditor.Lightmapping.lightingSettings = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_lightingSettingsDefaults(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Lightmapping.lightingSettingsDefaults;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticEvent_bakeStarted(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
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
                            throw new ParameterException(typeof(UnityEditor.Lightmapping), "bakeStarted", typeof(System.Action), 1);
                        }
                        UnityEditor.Lightmapping.bakeStarted += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.Lightmapping), "bakeStarted", typeof(System.Action), 1);
                        }
                        UnityEditor.Lightmapping.bakeStarted -= value;
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
        public static JSValue BindStaticEvent_lightingDataUpdated(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
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
                            throw new ParameterException(typeof(UnityEditor.Lightmapping), "lightingDataUpdated", typeof(System.Action), 1);
                        }
                        UnityEditor.Lightmapping.lightingDataUpdated += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.Lightmapping), "lightingDataUpdated", typeof(System.Action), 1);
                        }
                        UnityEditor.Lightmapping.lightingDataUpdated -= value;
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
        public static JSValue BindStaticEvent_lightingDataCleared(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
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
                            throw new ParameterException(typeof(UnityEditor.Lightmapping), "lightingDataCleared", typeof(System.Action), 1);
                        }
                        UnityEditor.Lightmapping.lightingDataCleared += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.Lightmapping), "lightingDataCleared", typeof(System.Action), 1);
                        }
                        UnityEditor.Lightmapping.lightingDataCleared -= value;
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
        public static JSValue BindStaticEvent_lightingDataAssetCleared(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
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
                            throw new ParameterException(typeof(UnityEditor.Lightmapping), "lightingDataAssetCleared", typeof(System.Action), 1);
                        }
                        UnityEditor.Lightmapping.lightingDataAssetCleared += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.Lightmapping), "lightingDataAssetCleared", typeof(System.Action), 1);
                        }
                        UnityEditor.Lightmapping.lightingDataAssetCleared -= value;
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
        public static JSValue BindStaticEvent_bakeCompleted(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
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
                            throw new ParameterException(typeof(UnityEditor.Lightmapping), "bakeCompleted", typeof(System.Action), 1);
                        }
                        UnityEditor.Lightmapping.bakeCompleted += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.Lightmapping), "bakeCompleted", typeof(System.Action), 1);
                        }
                        UnityEditor.Lightmapping.bakeCompleted -= value;
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
            var cls = register.CreateClass("Lightmapping", typeof(UnityEditor.Lightmapping), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "ClearDiskCache", BindStatic_ClearDiskCache);
            cls.AddMethod(true, "BakeAsync", BindStatic_BakeAsync);
            cls.AddMethod(true, "Bake", BindStatic_Bake);
            cls.AddMethod(true, "Cancel", BindStatic_Cancel);
            cls.AddMethod(true, "ForceStop", BindStatic_ForceStop);
            cls.AddMethod(true, "Clear", BindStatic_Clear);
            cls.AddMethod(true, "ClearLightingDataAsset", BindStatic_ClearLightingDataAsset);
            cls.AddMethod(true, "Tetrahedralize", BindStatic_Tetrahedralize);
            cls.AddMethod(true, "BakeReflectionProbe", BindStatic_BakeReflectionProbe);
            cls.AddMethod(true, "GetTerrainGIChunks", BindStatic_GetTerrainGIChunks);
            cls.AddMethod(true, "TryGetLightingSettings", BindStatic_TryGetLightingSettings);
            cls.AddMethod(true, "SetLightingSettingsForScene", BindStatic_SetLightingSettingsForScene);
            cls.AddMethod(true, "SetLightingSettingsForScenes", BindStatic_SetLightingSettingsForScenes);
            cls.AddMethod(true, "GetLightingSettingsForScene", BindStatic_GetLightingSettingsForScene);
            cls.AddMethod(true, "BakeMultipleScenes", BindStatic_BakeMultipleScenes);
            cls.AddProperty(true, "giWorkflowMode", BindStaticRead_giWorkflowMode, BindStaticWrite_giWorkflowMode);
            cls.AddProperty(true, "realtimeGI", BindStaticRead_realtimeGI, BindStaticWrite_realtimeGI);
            cls.AddProperty(true, "bakedGI", BindStaticRead_bakedGI, BindStaticWrite_bakedGI);
            cls.AddProperty(true, "isRunning", BindStaticRead_isRunning, null);
            cls.AddProperty(true, "buildProgress", BindStaticRead_buildProgress, null);
            cls.AddProperty(true, "lightingDataAsset", BindStaticRead_lightingDataAsset, BindStaticWrite_lightingDataAsset);
            cls.AddProperty(true, "lightingSettings", BindStaticRead_lightingSettings, BindStaticWrite_lightingSettings);
            cls.AddProperty(true, "lightingSettingsDefaults", BindStaticRead_lightingSettingsDefaults, null);
            cls.AddMethod(true, "bakeStarted", BindStaticEvent_bakeStarted);
            cls.AddMethod(true, "lightingDataUpdated", BindStaticEvent_lightingDataUpdated);
            cls.AddMethod(true, "lightingDataCleared", BindStaticEvent_lightingDataCleared);
            cls.AddMethod(true, "lightingDataAssetCleared", BindStaticEvent_lightingDataAssetCleared);
            cls.AddMethod(true, "bakeCompleted", BindStaticEvent_bakeCompleted);
            return cls;
        }
    }
}
#endif
#endif
