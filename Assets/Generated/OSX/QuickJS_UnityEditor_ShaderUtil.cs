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
    // Type: UnityEditor.ShaderUtil
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_ShaderUtil
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_HasProceduralInstancing(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Shader arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "HasProceduralInstancing", typeof(UnityEngine.Shader), 0);
                    }
                    var ret = UnityEditor.ShaderUtil.HasProceduralInstancing(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("HasProceduralInstancing", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetShaderMessageCount(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Shader arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetShaderMessageCount", typeof(UnityEngine.Shader), 0);
                    }
                    var ret = UnityEditor.ShaderUtil.GetShaderMessageCount(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetShaderMessageCount", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetShaderMessages(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        UnityEngine.Shader arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetShaderMessages", typeof(UnityEngine.Shader), 0);
                        }
                        UnityEditor.Rendering.ShaderCompilerPlatform arg1;
                        if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetShaderMessages", typeof(UnityEditor.Rendering.ShaderCompilerPlatform), 1);
                        }
                        var ret = UnityEditor.ShaderUtil.GetShaderMessages(arg0, arg1);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        UnityEngine.Shader arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetShaderMessages", typeof(UnityEngine.Shader), 0);
                        }
                        var ret = UnityEditor.ShaderUtil.GetShaderMessages(arg0);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("GetShaderMessages", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ClearShaderMessages(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Shader arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "ClearShaderMessages", typeof(UnityEngine.Shader), 0);
                    }
                    UnityEditor.ShaderUtil.ClearShaderMessages(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ClearShaderMessages", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetComputeShaderMessageCount(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.ComputeShader arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetComputeShaderMessageCount", typeof(UnityEngine.ComputeShader), 0);
                    }
                    var ret = UnityEditor.ShaderUtil.GetComputeShaderMessageCount(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetComputeShaderMessageCount", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetComputeShaderMessages(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.ComputeShader arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetComputeShaderMessages", typeof(UnityEngine.ComputeShader), 0);
                    }
                    var ret = UnityEditor.ShaderUtil.GetComputeShaderMessages(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetComputeShaderMessages", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetRayTracingShaderMessageCount(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Experimental.Rendering.RayTracingShader arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetRayTracingShaderMessageCount", typeof(UnityEngine.Experimental.Rendering.RayTracingShader), 0);
                    }
                    var ret = UnityEditor.ShaderUtil.GetRayTracingShaderMessageCount(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetRayTracingShaderMessageCount", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetRayTracingShaderMessages(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Experimental.Rendering.RayTracingShader arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetRayTracingShaderMessages", typeof(UnityEngine.Experimental.Rendering.RayTracingShader), 0);
                    }
                    var ret = UnityEditor.ShaderUtil.GetRayTracingShaderMessages(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetRayTracingShaderMessages", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetRayGenerationShaderCount(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Experimental.Rendering.RayTracingShader arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetRayGenerationShaderCount", typeof(UnityEngine.Experimental.Rendering.RayTracingShader), 0);
                    }
                    var ret = UnityEditor.ShaderUtil.GetRayGenerationShaderCount(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetRayGenerationShaderCount", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetRayGenerationShaderName(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Experimental.Rendering.RayTracingShader arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetRayGenerationShaderName", typeof(UnityEngine.Experimental.Rendering.RayTracingShader), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetRayGenerationShaderName", typeof(int), 1);
                    }
                    var ret = UnityEditor.ShaderUtil.GetRayGenerationShaderName(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetRayGenerationShaderName", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetMissShaderCount(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Experimental.Rendering.RayTracingShader arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetMissShaderCount", typeof(UnityEngine.Experimental.Rendering.RayTracingShader), 0);
                    }
                    var ret = UnityEditor.ShaderUtil.GetMissShaderCount(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetMissShaderCount", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetMissShaderName(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Experimental.Rendering.RayTracingShader arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetMissShaderName", typeof(UnityEngine.Experimental.Rendering.RayTracingShader), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetMissShaderName", typeof(int), 1);
                    }
                    var ret = UnityEditor.ShaderUtil.GetMissShaderName(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetMissShaderName", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetMissShaderRayPayloadSize(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Experimental.Rendering.RayTracingShader arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetMissShaderRayPayloadSize", typeof(UnityEngine.Experimental.Rendering.RayTracingShader), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetMissShaderRayPayloadSize", typeof(int), 1);
                    }
                    var ret = UnityEditor.ShaderUtil.GetMissShaderRayPayloadSize(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetMissShaderRayPayloadSize", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetCallableShaderCount(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Experimental.Rendering.RayTracingShader arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetCallableShaderCount", typeof(UnityEngine.Experimental.Rendering.RayTracingShader), 0);
                    }
                    var ret = UnityEditor.ShaderUtil.GetCallableShaderCount(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetCallableShaderCount", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetCallableShaderName(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Experimental.Rendering.RayTracingShader arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetCallableShaderName", typeof(UnityEngine.Experimental.Rendering.RayTracingShader), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetCallableShaderName", typeof(int), 1);
                    }
                    var ret = UnityEditor.ShaderUtil.GetCallableShaderName(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetCallableShaderName", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetCallableShaderParamSize(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Experimental.Rendering.RayTracingShader arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetCallableShaderParamSize", typeof(UnityEngine.Experimental.Rendering.RayTracingShader), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetCallableShaderParamSize", typeof(int), 1);
                    }
                    var ret = UnityEditor.ShaderUtil.GetCallableShaderParamSize(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetCallableShaderParamSize", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ClearCachedData(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Shader arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "ClearCachedData", typeof(UnityEngine.Shader), 0);
                    }
                    UnityEditor.ShaderUtil.ClearCachedData(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ClearCachedData", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CreateShaderAsset(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        UnityEditor.AssetImporters.AssetImportContext arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderUtil), "CreateShaderAsset", typeof(UnityEditor.AssetImporters.AssetImportContext), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderUtil), "CreateShaderAsset", typeof(string), 1);
                        }
                        bool arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderUtil), "CreateShaderAsset", typeof(bool), 2);
                        }
                        var ret = UnityEditor.ShaderUtil.CreateShaderAsset(arg0, arg1, arg2);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 2)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderUtil), "CreateShaderAsset", typeof(string), 0);
                        }
                        bool arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderUtil), "CreateShaderAsset", typeof(bool), 1);
                        }
                        var ret = UnityEditor.ShaderUtil.CreateShaderAsset(arg0, arg1);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderUtil), "CreateShaderAsset", typeof(string), 0);
                        }
                        var ret = UnityEditor.ShaderUtil.CreateShaderAsset(arg0);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("CreateShaderAsset", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_UpdateShaderAsset(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        UnityEditor.AssetImporters.AssetImportContext arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderUtil), "UpdateShaderAsset", typeof(UnityEditor.AssetImporters.AssetImportContext), 0);
                        }
                        UnityEngine.Shader arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderUtil), "UpdateShaderAsset", typeof(UnityEngine.Shader), 1);
                        }
                        string arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderUtil), "UpdateShaderAsset", typeof(string), 2);
                        }
                        bool arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderUtil), "UpdateShaderAsset", typeof(bool), 3);
                        }
                        UnityEditor.ShaderUtil.UpdateShaderAsset(arg0, arg1, arg2, arg3);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 3)
                    {
                        UnityEngine.Shader arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderUtil), "UpdateShaderAsset", typeof(UnityEngine.Shader), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderUtil), "UpdateShaderAsset", typeof(string), 1);
                        }
                        bool arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderUtil), "UpdateShaderAsset", typeof(bool), 2);
                        }
                        UnityEditor.ShaderUtil.UpdateShaderAsset(arg0, arg1, arg2);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Shader arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderUtil), "UpdateShaderAsset", typeof(UnityEngine.Shader), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderUtil), "UpdateShaderAsset", typeof(string), 1);
                        }
                        UnityEditor.ShaderUtil.UpdateShaderAsset(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("UpdateShaderAsset", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RegisterShader(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Shader arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "RegisterShader", typeof(UnityEngine.Shader), 0);
                    }
                    UnityEditor.ShaderUtil.RegisterShader(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RegisterShader", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetAllShaderInfo(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.ShaderUtil.GetAllShaderInfo();
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetAllShaderInfo", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetShaderInfo(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Shader arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetShaderInfo", typeof(UnityEngine.Shader), 0);
                    }
                    var ret = UnityEditor.ShaderUtil.GetShaderInfo(arg0);
                    return Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetShaderInfo", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetAsyncCompilation(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Rendering.CommandBuffer arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "SetAsyncCompilation", typeof(UnityEngine.Rendering.CommandBuffer), 0);
                    }
                    bool arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "SetAsyncCompilation", typeof(bool), 1);
                    }
                    UnityEditor.ShaderUtil.SetAsyncCompilation(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetAsyncCompilation", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RestoreAsyncCompilation(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Rendering.CommandBuffer arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "RestoreAsyncCompilation", typeof(UnityEngine.Rendering.CommandBuffer), 0);
                    }
                    UnityEditor.ShaderUtil.RestoreAsyncCompilation(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RestoreAsyncCompilation", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsPassCompiled(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Material arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "IsPassCompiled", typeof(UnityEngine.Material), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "IsPassCompiled", typeof(int), 1);
                    }
                    var ret = UnityEditor.ShaderUtil.IsPassCompiled(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsPassCompiled", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CompilePass(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Material arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "CompilePass", typeof(UnityEngine.Material), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "CompilePass", typeof(int), 1);
                    }
                    bool arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "CompilePass", typeof(bool), 2);
                    }
                    UnityEditor.ShaderUtil.CompilePass(arg0, arg1, arg2);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("CompilePass", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetCustomEditorForRenderPipeline(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Shader)) && Values.js_match_type(ctx, argv[1], typeof(string)))
                        {
                            UnityEngine.Shader arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetCustomEditorForRenderPipeline", typeof(UnityEngine.Shader), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetCustomEditorForRenderPipeline", typeof(string), 1);
                            }
                            var ret = UnityEditor.ShaderUtil.GetCustomEditorForRenderPipeline(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Shader)) && Values.js_match_type(ctx, argv[1], typeof(System.Type)))
                        {
                            UnityEngine.Shader arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetCustomEditorForRenderPipeline", typeof(UnityEngine.Shader), 0);
                            }
                            System.Type arg1;
                            if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetCustomEditorForRenderPipeline", typeof(System.Type), 1);
                            }
                            var ret = UnityEditor.ShaderUtil.GetCustomEditorForRenderPipeline(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("GetCustomEditorForRenderPipeline", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetCurrentCustomEditor(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Shader arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetCurrentCustomEditor", typeof(UnityEngine.Shader), 0);
                    }
                    var ret = UnityEditor.ShaderUtil.GetCurrentCustomEditor(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetCurrentCustomEditor", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetShaderPlatformKeywordsForBuildTarget(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        UnityEditor.Rendering.ShaderCompilerPlatform arg0;
                        if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetShaderPlatformKeywordsForBuildTarget", typeof(UnityEditor.Rendering.ShaderCompilerPlatform), 0);
                        }
                        UnityEditor.BuildTarget arg1;
                        if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetShaderPlatformKeywordsForBuildTarget", typeof(UnityEditor.BuildTarget), 1);
                        }
                        UnityEngine.Rendering.GraphicsTier arg2;
                        if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetShaderPlatformKeywordsForBuildTarget", typeof(UnityEngine.Rendering.GraphicsTier), 2);
                        }
                        var ret = UnityEditor.ShaderUtil.GetShaderPlatformKeywordsForBuildTarget(arg0, arg1, arg2);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 2)
                    {
                        UnityEditor.Rendering.ShaderCompilerPlatform arg0;
                        if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetShaderPlatformKeywordsForBuildTarget", typeof(UnityEditor.Rendering.ShaderCompilerPlatform), 0);
                        }
                        UnityEditor.BuildTarget arg1;
                        if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetShaderPlatformKeywordsForBuildTarget", typeof(UnityEditor.BuildTarget), 1);
                        }
                        var ret = UnityEditor.ShaderUtil.GetShaderPlatformKeywordsForBuildTarget(arg0, arg1);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("GetShaderPlatformKeywordsForBuildTarget", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetPassKeywords(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        UnityEngine.Shader arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetPassKeywords", typeof(UnityEngine.Shader), 0);
                        }
                        UnityEngine.Rendering.PassIdentifier arg1;
                        var refVal1 = Values.js_read_wrap(ctx, argv[1]);
                        if (refVal1.IsException())
                        {
                            return refVal1;
                        }
                        if (!Values.js_get_structvalue(ctx, refVal1, out arg1))
                        {
                            JSApi.JS_FreeValue(ctx, refVal1);
                            throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetPassKeywords", typeof(UnityEngine.Rendering.PassIdentifier), 1);
                        }
                        JSApi.JS_FreeValue(ctx, refVal1);
                        UnityEditor.Rendering.ShaderType arg2;
                        if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetPassKeywords", typeof(UnityEditor.Rendering.ShaderType), 2);
                        }
                        UnityEditor.Rendering.ShaderCompilerPlatform arg3;
                        if (!Values.js_get_enumvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetPassKeywords", typeof(UnityEditor.Rendering.ShaderCompilerPlatform), 3);
                        }
                        var ret = UnityEditor.ShaderUtil.GetPassKeywords(arg0, in arg1, arg2, arg3);
                        var out0 = Values.js_push_structvalue(ctx, arg1);
                        if (JSApi.JS_IsException(out0))
                        {
                            return out0;
                        }
                        var context = ScriptEngine.GetContext(ctx);
                        JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out0);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 3)
                    {
                        UnityEngine.Shader arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetPassKeywords", typeof(UnityEngine.Shader), 0);
                        }
                        UnityEngine.Rendering.PassIdentifier arg1;
                        var refVal1 = Values.js_read_wrap(ctx, argv[1]);
                        if (refVal1.IsException())
                        {
                            return refVal1;
                        }
                        if (!Values.js_get_structvalue(ctx, refVal1, out arg1))
                        {
                            JSApi.JS_FreeValue(ctx, refVal1);
                            throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetPassKeywords", typeof(UnityEngine.Rendering.PassIdentifier), 1);
                        }
                        JSApi.JS_FreeValue(ctx, refVal1);
                        UnityEditor.Rendering.ShaderType arg2;
                        if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetPassKeywords", typeof(UnityEditor.Rendering.ShaderType), 2);
                        }
                        var ret = UnityEditor.ShaderUtil.GetPassKeywords(arg0, in arg1, arg2);
                        var out0 = Values.js_push_structvalue(ctx, arg1);
                        if (JSApi.JS_IsException(out0))
                        {
                            return out0;
                        }
                        var context = ScriptEngine.GetContext(ctx);
                        JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out0);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Shader arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetPassKeywords", typeof(UnityEngine.Shader), 0);
                        }
                        UnityEngine.Rendering.PassIdentifier arg1;
                        var refVal1 = Values.js_read_wrap(ctx, argv[1]);
                        if (refVal1.IsException())
                        {
                            return refVal1;
                        }
                        if (!Values.js_get_structvalue(ctx, refVal1, out arg1))
                        {
                            JSApi.JS_FreeValue(ctx, refVal1);
                            throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetPassKeywords", typeof(UnityEngine.Rendering.PassIdentifier), 1);
                        }
                        JSApi.JS_FreeValue(ctx, refVal1);
                        var ret = UnityEditor.ShaderUtil.GetPassKeywords(arg0, in arg1);
                        var out0 = Values.js_push_structvalue(ctx, arg1);
                        if (JSApi.JS_IsException(out0))
                        {
                            return out0;
                        }
                        var context = ScriptEngine.GetContext(ctx);
                        JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out0);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("GetPassKeywords", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_PassHasKeyword(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 5)
                    {
                        UnityEngine.Shader arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderUtil), "PassHasKeyword", typeof(UnityEngine.Shader), 0);
                        }
                        UnityEngine.Rendering.PassIdentifier arg1;
                        var refVal1 = Values.js_read_wrap(ctx, argv[1]);
                        if (refVal1.IsException())
                        {
                            return refVal1;
                        }
                        if (!Values.js_get_structvalue(ctx, refVal1, out arg1))
                        {
                            JSApi.JS_FreeValue(ctx, refVal1);
                            throw new ParameterException(typeof(UnityEditor.ShaderUtil), "PassHasKeyword", typeof(UnityEngine.Rendering.PassIdentifier), 1);
                        }
                        JSApi.JS_FreeValue(ctx, refVal1);
                        UnityEngine.Rendering.LocalKeyword arg2;
                        var refVal2 = Values.js_read_wrap(ctx, argv[2]);
                        if (refVal2.IsException())
                        {
                            return refVal2;
                        }
                        if (!Values.js_get_structvalue(ctx, refVal2, out arg2))
                        {
                            JSApi.JS_FreeValue(ctx, refVal2);
                            throw new ParameterException(typeof(UnityEditor.ShaderUtil), "PassHasKeyword", typeof(UnityEngine.Rendering.LocalKeyword), 2);
                        }
                        JSApi.JS_FreeValue(ctx, refVal2);
                        UnityEditor.Rendering.ShaderType arg3;
                        if (!Values.js_get_enumvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderUtil), "PassHasKeyword", typeof(UnityEditor.Rendering.ShaderType), 3);
                        }
                        UnityEditor.Rendering.ShaderCompilerPlatform arg4;
                        if (!Values.js_get_enumvalue(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderUtil), "PassHasKeyword", typeof(UnityEditor.Rendering.ShaderCompilerPlatform), 4);
                        }
                        var ret = UnityEditor.ShaderUtil.PassHasKeyword(arg0, in arg1, in arg2, arg3, arg4);
                        var out0 = Values.js_push_structvalue(ctx, arg1);
                        if (JSApi.JS_IsException(out0))
                        {
                            return out0;
                        }
                        var context = ScriptEngine.GetContext(ctx);
                        JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out0);
                        var out1 = Values.js_push_structvalue(ctx, arg2);
                        if (JSApi.JS_IsException(out1))
                        {
                            return out1;
                        }
                        JSApi.JS_SetProperty(ctx, argv[2], context.GetAtom("value"), out1);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 4)
                    {
                        UnityEngine.Shader arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderUtil), "PassHasKeyword", typeof(UnityEngine.Shader), 0);
                        }
                        UnityEngine.Rendering.PassIdentifier arg1;
                        var refVal1 = Values.js_read_wrap(ctx, argv[1]);
                        if (refVal1.IsException())
                        {
                            return refVal1;
                        }
                        if (!Values.js_get_structvalue(ctx, refVal1, out arg1))
                        {
                            JSApi.JS_FreeValue(ctx, refVal1);
                            throw new ParameterException(typeof(UnityEditor.ShaderUtil), "PassHasKeyword", typeof(UnityEngine.Rendering.PassIdentifier), 1);
                        }
                        JSApi.JS_FreeValue(ctx, refVal1);
                        UnityEngine.Rendering.LocalKeyword arg2;
                        var refVal2 = Values.js_read_wrap(ctx, argv[2]);
                        if (refVal2.IsException())
                        {
                            return refVal2;
                        }
                        if (!Values.js_get_structvalue(ctx, refVal2, out arg2))
                        {
                            JSApi.JS_FreeValue(ctx, refVal2);
                            throw new ParameterException(typeof(UnityEditor.ShaderUtil), "PassHasKeyword", typeof(UnityEngine.Rendering.LocalKeyword), 2);
                        }
                        JSApi.JS_FreeValue(ctx, refVal2);
                        UnityEditor.Rendering.ShaderType arg3;
                        if (!Values.js_get_enumvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderUtil), "PassHasKeyword", typeof(UnityEditor.Rendering.ShaderType), 3);
                        }
                        var ret = UnityEditor.ShaderUtil.PassHasKeyword(arg0, in arg1, in arg2, arg3);
                        var out0 = Values.js_push_structvalue(ctx, arg1);
                        if (JSApi.JS_IsException(out0))
                        {
                            return out0;
                        }
                        var context = ScriptEngine.GetContext(ctx);
                        JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out0);
                        var out1 = Values.js_push_structvalue(ctx, arg2);
                        if (JSApi.JS_IsException(out1))
                        {
                            return out1;
                        }
                        JSApi.JS_SetProperty(ctx, argv[2], context.GetAtom("value"), out1);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 3)
                    {
                        UnityEngine.Shader arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderUtil), "PassHasKeyword", typeof(UnityEngine.Shader), 0);
                        }
                        UnityEngine.Rendering.PassIdentifier arg1;
                        var refVal1 = Values.js_read_wrap(ctx, argv[1]);
                        if (refVal1.IsException())
                        {
                            return refVal1;
                        }
                        if (!Values.js_get_structvalue(ctx, refVal1, out arg1))
                        {
                            JSApi.JS_FreeValue(ctx, refVal1);
                            throw new ParameterException(typeof(UnityEditor.ShaderUtil), "PassHasKeyword", typeof(UnityEngine.Rendering.PassIdentifier), 1);
                        }
                        JSApi.JS_FreeValue(ctx, refVal1);
                        UnityEngine.Rendering.LocalKeyword arg2;
                        var refVal2 = Values.js_read_wrap(ctx, argv[2]);
                        if (refVal2.IsException())
                        {
                            return refVal2;
                        }
                        if (!Values.js_get_structvalue(ctx, refVal2, out arg2))
                        {
                            JSApi.JS_FreeValue(ctx, refVal2);
                            throw new ParameterException(typeof(UnityEditor.ShaderUtil), "PassHasKeyword", typeof(UnityEngine.Rendering.LocalKeyword), 2);
                        }
                        JSApi.JS_FreeValue(ctx, refVal2);
                        var ret = UnityEditor.ShaderUtil.PassHasKeyword(arg0, in arg1, in arg2);
                        var out0 = Values.js_push_structvalue(ctx, arg1);
                        if (JSApi.JS_IsException(out0))
                        {
                            return out0;
                        }
                        var context = ScriptEngine.GetContext(ctx);
                        JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out0);
                        var out1 = Values.js_push_structvalue(ctx, arg2);
                        if (JSApi.JS_IsException(out1))
                        {
                            return out1;
                        }
                        JSApi.JS_SetProperty(ctx, argv[2], context.GetAtom("value"), out1);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("PassHasKeyword", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetPropertyCount(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Shader arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetPropertyCount", typeof(UnityEngine.Shader), 0);
                    }
                    var ret = UnityEditor.ShaderUtil.GetPropertyCount(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetPropertyCount", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetPropertyName(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Shader arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetPropertyName", typeof(UnityEngine.Shader), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetPropertyName", typeof(int), 1);
                    }
                    var ret = UnityEditor.ShaderUtil.GetPropertyName(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetPropertyName", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetPropertyType(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Shader arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetPropertyType", typeof(UnityEngine.Shader), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetPropertyType", typeof(int), 1);
                    }
                    var ret = UnityEditor.ShaderUtil.GetPropertyType(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
                }
                throw new NoSuitableMethodException("GetPropertyType", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetPropertyDescription(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Shader arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetPropertyDescription", typeof(UnityEngine.Shader), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetPropertyDescription", typeof(int), 1);
                    }
                    var ret = UnityEditor.ShaderUtil.GetPropertyDescription(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetPropertyDescription", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetRangeLimits(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Shader arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetRangeLimits", typeof(UnityEngine.Shader), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetRangeLimits", typeof(int), 1);
                    }
                    int arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetRangeLimits", typeof(int), 2);
                    }
                    var ret = UnityEditor.ShaderUtil.GetRangeLimits(arg0, arg1, arg2);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetRangeLimits", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetTexDim(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Shader arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetTexDim", typeof(UnityEngine.Shader), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetTexDim", typeof(int), 1);
                    }
                    var ret = UnityEditor.ShaderUtil.GetTexDim(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
                }
                throw new NoSuitableMethodException("GetTexDim", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsShaderPropertyHidden(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Shader arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "IsShaderPropertyHidden", typeof(UnityEngine.Shader), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "IsShaderPropertyHidden", typeof(int), 1);
                    }
                    var ret = UnityEditor.ShaderUtil.IsShaderPropertyHidden(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsShaderPropertyHidden", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsShaderPropertyNonModifiableTexureProperty(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Shader arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "IsShaderPropertyNonModifiableTexureProperty", typeof(UnityEngine.Shader), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "IsShaderPropertyNonModifiableTexureProperty", typeof(int), 1);
                    }
                    var ret = UnityEditor.ShaderUtil.IsShaderPropertyNonModifiableTexureProperty(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsShaderPropertyNonModifiableTexureProperty", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetShaderData(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Shader arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "GetShaderData", typeof(UnityEngine.Shader), 0);
                    }
                    var ret = UnityEditor.ShaderUtil.GetShaderData(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetShaderData", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ShaderHasError(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Shader arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "ShaderHasError", typeof(UnityEngine.Shader), 0);
                    }
                    var ret = UnityEditor.ShaderUtil.ShaderHasError(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("ShaderHasError", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ShaderHasWarnings(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Shader arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderUtil), "ShaderHasWarnings", typeof(UnityEngine.Shader), 0);
                    }
                    var ret = UnityEditor.ShaderUtil.ShaderHasWarnings(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("ShaderHasWarnings", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_hardwareSupportsRectRenderTexture(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.ShaderUtil.hardwareSupportsRectRenderTexture;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_anythingCompiling(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.ShaderUtil.anythingCompiling;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_allowAsyncCompilation(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.ShaderUtil.allowAsyncCompilation;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_allowAsyncCompilation(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.ShaderUtil), "allowAsyncCompilation", typeof(bool), 0);
                }
                UnityEditor.ShaderUtil.allowAsyncCompilation = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("ShaderUtil", typeof(UnityEditor.ShaderUtil), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "HasProceduralInstancing", BindStatic_HasProceduralInstancing);
            cls.AddMethod(true, "GetShaderMessageCount", BindStatic_GetShaderMessageCount);
            cls.AddMethod(true, "GetShaderMessages", BindStatic_GetShaderMessages);
            cls.AddMethod(true, "ClearShaderMessages", BindStatic_ClearShaderMessages);
            cls.AddMethod(true, "GetComputeShaderMessageCount", BindStatic_GetComputeShaderMessageCount);
            cls.AddMethod(true, "GetComputeShaderMessages", BindStatic_GetComputeShaderMessages);
            cls.AddMethod(true, "GetRayTracingShaderMessageCount", BindStatic_GetRayTracingShaderMessageCount);
            cls.AddMethod(true, "GetRayTracingShaderMessages", BindStatic_GetRayTracingShaderMessages);
            cls.AddMethod(true, "GetRayGenerationShaderCount", BindStatic_GetRayGenerationShaderCount);
            cls.AddMethod(true, "GetRayGenerationShaderName", BindStatic_GetRayGenerationShaderName);
            cls.AddMethod(true, "GetMissShaderCount", BindStatic_GetMissShaderCount);
            cls.AddMethod(true, "GetMissShaderName", BindStatic_GetMissShaderName);
            cls.AddMethod(true, "GetMissShaderRayPayloadSize", BindStatic_GetMissShaderRayPayloadSize);
            cls.AddMethod(true, "GetCallableShaderCount", BindStatic_GetCallableShaderCount);
            cls.AddMethod(true, "GetCallableShaderName", BindStatic_GetCallableShaderName);
            cls.AddMethod(true, "GetCallableShaderParamSize", BindStatic_GetCallableShaderParamSize);
            cls.AddMethod(true, "ClearCachedData", BindStatic_ClearCachedData);
            cls.AddMethod(true, "CreateShaderAsset", BindStatic_CreateShaderAsset);
            cls.AddMethod(true, "UpdateShaderAsset", BindStatic_UpdateShaderAsset);
            cls.AddMethod(true, "RegisterShader", BindStatic_RegisterShader);
            cls.AddMethod(true, "GetAllShaderInfo", BindStatic_GetAllShaderInfo);
            cls.AddMethod(true, "GetShaderInfo", BindStatic_GetShaderInfo);
            cls.AddMethod(true, "SetAsyncCompilation", BindStatic_SetAsyncCompilation);
            cls.AddMethod(true, "RestoreAsyncCompilation", BindStatic_RestoreAsyncCompilation);
            cls.AddMethod(true, "IsPassCompiled", BindStatic_IsPassCompiled);
            cls.AddMethod(true, "CompilePass", BindStatic_CompilePass);
            cls.AddMethod(true, "GetCustomEditorForRenderPipeline", BindStatic_GetCustomEditorForRenderPipeline);
            cls.AddMethod(true, "GetCurrentCustomEditor", BindStatic_GetCurrentCustomEditor);
            cls.AddMethod(true, "GetShaderPlatformKeywordsForBuildTarget", BindStatic_GetShaderPlatformKeywordsForBuildTarget);
            cls.AddMethod(true, "GetPassKeywords", BindStatic_GetPassKeywords);
            cls.AddMethod(true, "PassHasKeyword", BindStatic_PassHasKeyword);
            cls.AddMethod(true, "GetPropertyCount", BindStatic_GetPropertyCount);
            cls.AddMethod(true, "GetPropertyName", BindStatic_GetPropertyName);
            cls.AddMethod(true, "GetPropertyType", BindStatic_GetPropertyType);
            cls.AddMethod(true, "GetPropertyDescription", BindStatic_GetPropertyDescription);
            cls.AddMethod(true, "GetRangeLimits", BindStatic_GetRangeLimits);
            cls.AddMethod(true, "GetTexDim", BindStatic_GetTexDim);
            cls.AddMethod(true, "IsShaderPropertyHidden", BindStatic_IsShaderPropertyHidden);
            cls.AddMethod(true, "IsShaderPropertyNonModifiableTexureProperty", BindStatic_IsShaderPropertyNonModifiableTexureProperty);
            cls.AddMethod(true, "GetShaderData", BindStatic_GetShaderData);
            cls.AddMethod(true, "ShaderHasError", BindStatic_ShaderHasError);
            cls.AddMethod(true, "ShaderHasWarnings", BindStatic_ShaderHasWarnings);
            cls.AddProperty(true, "hardwareSupportsRectRenderTexture", BindStaticRead_hardwareSupportsRectRenderTexture, null);
            cls.AddProperty(true, "anythingCompiling", BindStaticRead_anythingCompiling, null);
            cls.AddProperty(true, "allowAsyncCompilation", BindStaticRead_allowAsyncCompilation, BindStaticWrite_allowAsyncCompilation);
            return cls;
        }
    }
}
#endif
#endif
