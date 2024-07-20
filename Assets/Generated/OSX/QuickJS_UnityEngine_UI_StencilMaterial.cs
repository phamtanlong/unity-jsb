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
    // Assembly: UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Users/longpt/Documents/SkyMavis/unity-jsb-2021/Library/ScriptAssemblies/UnityEngine.UI.dll
    // Type: UnityEngine.UI.StencilMaterial
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_UI_StencilMaterial
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Add(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 7)
                    {
                        UnityEngine.Material arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.UI.StencilMaterial), "Add", typeof(UnityEngine.Material), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.UI.StencilMaterial), "Add", typeof(int), 1);
                        }
                        UnityEngine.Rendering.StencilOp arg2;
                        if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.UI.StencilMaterial), "Add", typeof(UnityEngine.Rendering.StencilOp), 2);
                        }
                        UnityEngine.Rendering.CompareFunction arg3;
                        if (!Values.js_get_enumvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.UI.StencilMaterial), "Add", typeof(UnityEngine.Rendering.CompareFunction), 3);
                        }
                        UnityEngine.Rendering.ColorWriteMask arg4;
                        if (!Values.js_get_enumvalue(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.UI.StencilMaterial), "Add", typeof(UnityEngine.Rendering.ColorWriteMask), 4);
                        }
                        int arg5;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEngine.UI.StencilMaterial), "Add", typeof(int), 5);
                        }
                        int arg6;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[6], out arg6))
                        {
                            throw new ParameterException(typeof(UnityEngine.UI.StencilMaterial), "Add", typeof(int), 6);
                        }
                        var ret = UnityEngine.UI.StencilMaterial.Add(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 5)
                    {
                        UnityEngine.Material arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.UI.StencilMaterial), "Add", typeof(UnityEngine.Material), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.UI.StencilMaterial), "Add", typeof(int), 1);
                        }
                        UnityEngine.Rendering.StencilOp arg2;
                        if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.UI.StencilMaterial), "Add", typeof(UnityEngine.Rendering.StencilOp), 2);
                        }
                        UnityEngine.Rendering.CompareFunction arg3;
                        if (!Values.js_get_enumvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.UI.StencilMaterial), "Add", typeof(UnityEngine.Rendering.CompareFunction), 3);
                        }
                        UnityEngine.Rendering.ColorWriteMask arg4;
                        if (!Values.js_get_enumvalue(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.UI.StencilMaterial), "Add", typeof(UnityEngine.Rendering.ColorWriteMask), 4);
                        }
                        var ret = UnityEngine.UI.StencilMaterial.Add(arg0, arg1, arg2, arg3, arg4);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("Add", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Remove(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Material arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.StencilMaterial), "Remove", typeof(UnityEngine.Material), 0);
                    }
                    UnityEngine.UI.StencilMaterial.Remove(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Remove", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ClearAll(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.UI.StencilMaterial.ClearAll();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ClearAll", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("StencilMaterial", typeof(UnityEngine.UI.StencilMaterial), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "Add", BindStatic_Add);
            cls.AddMethod(true, "Remove", BindStatic_Remove);
            cls.AddMethod(true, "ClearAll", BindStatic_ClearAll);
            return cls;
        }
    }
}
#endif
