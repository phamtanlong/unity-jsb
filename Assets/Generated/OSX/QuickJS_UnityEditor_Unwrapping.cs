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
    // Type: UnityEditor.Unwrapping
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_Unwrapping
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GeneratePerTriangleUV(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        UnityEngine.Mesh arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.Unwrapping), "GeneratePerTriangleUV", typeof(UnityEngine.Mesh), 0);
                        }
                        UnityEditor.UnwrapParam arg1;
                        if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.Unwrapping), "GeneratePerTriangleUV", typeof(UnityEditor.UnwrapParam), 1);
                        }
                        var ret = UnityEditor.Unwrapping.GeneratePerTriangleUV(arg0, arg1);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        UnityEngine.Mesh arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.Unwrapping), "GeneratePerTriangleUV", typeof(UnityEngine.Mesh), 0);
                        }
                        var ret = UnityEditor.Unwrapping.GeneratePerTriangleUV(arg0);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("GeneratePerTriangleUV", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GenerateSecondaryUVSet(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        UnityEngine.Mesh arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.Unwrapping), "GenerateSecondaryUVSet", typeof(UnityEngine.Mesh), 0);
                        }
                        UnityEditor.UnwrapParam arg1;
                        if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.Unwrapping), "GenerateSecondaryUVSet", typeof(UnityEditor.UnwrapParam), 1);
                        }
                        UnityEditor.Unwrapping.GenerateSecondaryUVSet(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 1)
                    {
                        UnityEngine.Mesh arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.Unwrapping), "GenerateSecondaryUVSet", typeof(UnityEngine.Mesh), 0);
                        }
                        UnityEditor.Unwrapping.GenerateSecondaryUVSet(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("GenerateSecondaryUVSet", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("Unwrapping", typeof(UnityEditor.Unwrapping), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "GeneratePerTriangleUV", BindStatic_GeneratePerTriangleUV);
            cls.AddMethod(true, "GenerateSecondaryUVSet", BindStatic_GenerateSecondaryUVSet);
            return cls;
        }
    }
}
#endif
#endif
