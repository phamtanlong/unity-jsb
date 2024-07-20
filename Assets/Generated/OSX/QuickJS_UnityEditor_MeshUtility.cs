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
    // Type: UnityEditor.MeshUtility
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_MeshUtility
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Optimize(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Mesh arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.MeshUtility), "Optimize", typeof(UnityEngine.Mesh), 0);
                    }
                    UnityEditor.MeshUtility.Optimize(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Optimize", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetMeshCompression(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Mesh arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.MeshUtility), "SetMeshCompression", typeof(UnityEngine.Mesh), 0);
                    }
                    UnityEditor.ModelImporterMeshCompression arg1;
                    if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.MeshUtility), "SetMeshCompression", typeof(UnityEditor.ModelImporterMeshCompression), 1);
                    }
                    UnityEditor.MeshUtility.SetMeshCompression(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetMeshCompression", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetMeshCompression(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Mesh arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.MeshUtility), "GetMeshCompression", typeof(UnityEngine.Mesh), 0);
                    }
                    var ret = UnityEditor.MeshUtility.GetMeshCompression(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
                }
                throw new NoSuitableMethodException("GetMeshCompression", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetPerTriangleUV2(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Mesh arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.MeshUtility), "SetPerTriangleUV2", typeof(UnityEngine.Mesh), 0);
                    }
                    UnityEngine.Vector2[] arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.MeshUtility), "SetPerTriangleUV2", typeof(UnityEngine.Vector2[]), 1);
                    }
                    UnityEditor.MeshUtility.SetPerTriangleUV2(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetPerTriangleUV2", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_AcquireReadOnlyMeshData(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Mesh)))
                        {
                            UnityEngine.Mesh arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.MeshUtility), "AcquireReadOnlyMeshData", typeof(UnityEngine.Mesh), 0);
                            }
                            var ret = UnityEditor.MeshUtility.AcquireReadOnlyMeshData(arg0);
                            return Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Mesh[])))
                        {
                            UnityEngine.Mesh[] arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.MeshUtility), "AcquireReadOnlyMeshData", typeof(UnityEngine.Mesh[]), 0);
                            }
                            var ret = UnityEditor.MeshUtility.AcquireReadOnlyMeshData(arg0);
                            return Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(System.Collections.Generic.List<UnityEngine.Mesh>)))
                        {
                            System.Collections.Generic.List<UnityEngine.Mesh> arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.MeshUtility), "AcquireReadOnlyMeshData", typeof(System.Collections.Generic.List<UnityEngine.Mesh>), 0);
                            }
                            var ret = UnityEditor.MeshUtility.AcquireReadOnlyMeshData(arg0);
                            return Values.js_push_structvalue(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("AcquireReadOnlyMeshData", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("MeshUtility", typeof(UnityEditor.MeshUtility), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "Optimize", BindStatic_Optimize);
            cls.AddMethod(true, "SetMeshCompression", BindStatic_SetMeshCompression);
            cls.AddMethod(true, "GetMeshCompression", BindStatic_GetMeshCompression);
            cls.AddMethod(true, "SetPerTriangleUV2", BindStatic_SetPerTriangleUV2);
            cls.AddMethod(true, "AcquireReadOnlyMeshData", BindStatic_AcquireReadOnlyMeshData);
            return cls;
        }
    }
}
#endif
#endif
