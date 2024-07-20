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
    // Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Users/longpt/Documents/SkyMavis/unity-jsb-2021/Library/ScriptAssemblies/Assembly-CSharp.dll
    // Type: NoNamespaceClass
    [JSBindingAttribute]
    public class QuickJS_NoNamespaceClass
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                if (argc == 0)
                {
                    var o = new NoNamespaceClass();
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
        public static JSValue BindStatic_V1(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(NoNamespaceClass), "V1", typeof(UnityEngine.Vector3), 0);
                            }
                            NoNamespaceClass.V1(arg0);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector2)))
                        {
                            UnityEngine.Vector2 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(NoNamespaceClass), "V1", typeof(UnityEngine.Vector2), 0);
                            }
                            NoNamespaceClass.V1(arg0);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("V1", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Moo(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    NoNamespaceClass.Moo();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Moo", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_MakeBytes(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = NoNamespaceClass.MakeBytes();
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("MakeBytes", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_TestBytes(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    byte[] arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(NoNamespaceClass), "TestBytes", typeof(byte[]), 0);
                    }
                    var ret = NoNamespaceClass.TestBytes(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("TestBytes", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_TestOut(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        if (Values.js_match_type_hint(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type_hint(ctx, argv[2], typeof(int)))
                        {
                            int arg0;
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(NoNamespaceClass), "TestOut", typeof(int), 1);
                            }
                            int arg2;
                            NoNamespaceClass.TestOut(out arg0, arg1, out arg2);
                            var out0 = QuickJS.Binding.Values.js_push_primitive(ctx, arg0);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[0], context.GetAtom("value"), out0);
                            var out1 = QuickJS.Binding.Values.js_push_primitive(ctx, arg2);
                            if (JSApi.JS_IsException(out1))
                            {
                                return out1;
                            }
                            JSApi.JS_SetProperty(ctx, argv[2], context.GetAtom("value"), out1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type_hint(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type_hint(ctx, argv[2], typeof(string)))
                        {
                            string arg0;
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(NoNamespaceClass), "TestOut", typeof(int), 1);
                            }
                            string arg2;
                            NoNamespaceClass.TestOut(out arg0, arg1, out arg2);
                            var out0 = QuickJS.Binding.Values.js_push_primitive(ctx, arg0);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[0], context.GetAtom("value"), out0);
                            var out1 = QuickJS.Binding.Values.js_push_primitive(ctx, arg2);
                            if (JSApi.JS_IsException(out1))
                            {
                                return out1;
                            }
                            JSApi.JS_SetProperty(ctx, argv[2], context.GetAtom("value"), out1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("TestOut", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_TestRefOut(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 4)
                {
                    int arg0;
                    var refVal0 = Values.js_read_wrap(ctx, argv[0]);
                    if (refVal0.IsException())
                    {
                        return refVal0;
                    }
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, refVal0, out arg0))
                    {
                        JSApi.JS_FreeValue(ctx, refVal0);
                        throw new ParameterException(typeof(NoNamespaceClass), "TestRefOut", typeof(int), 0);
                    }
                    JSApi.JS_FreeValue(ctx, refVal0);
                    int arg1;
                    int arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(NoNamespaceClass), "TestRefOut", typeof(int), 2);
                    }
                    int arg3;
                    NoNamespaceClass.TestRefOut(ref arg0, out arg1, arg2, out arg3);
                    var out0 = QuickJS.Binding.Values.js_push_primitive(ctx, arg0);
                    if (JSApi.JS_IsException(out0))
                    {
                        return out0;
                    }
                    var context = ScriptEngine.GetContext(ctx);
                    JSApi.JS_SetProperty(ctx, argv[0], context.GetAtom("value"), out0);
                    var out1 = QuickJS.Binding.Values.js_push_primitive(ctx, arg1);
                    if (JSApi.JS_IsException(out1))
                    {
                        return out1;
                    }
                    JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out1);
                    var out2 = QuickJS.Binding.Values.js_push_primitive(ctx, arg3);
                    if (JSApi.JS_IsException(out2))
                    {
                        return out2;
                    }
                    JSApi.JS_SetProperty(ctx, argv[3], context.GetAtom("value"), out2);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("TestRefOut", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_TestNullable(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(System.Nullable<int>)) && Values.js_match_type(ctx, argv[1], typeof(System.Nullable<int>)))
                        {
                            System.Nullable<int> arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(NoNamespaceClass), "TestNullable", typeof(System.Nullable<int>), 0);
                            }
                            System.Nullable<int> arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(NoNamespaceClass), "TestNullable", typeof(System.Nullable<int>), 1);
                            }
                            var ret = NoNamespaceClass.TestNullable(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(System.Nullable<UnityEngine.Vector2>)) && Values.js_match_type_hint(ctx, argv[1], typeof(System.Nullable<float>)))
                        {
                            System.Nullable<UnityEngine.Vector2> arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(NoNamespaceClass), "TestNullable", typeof(System.Nullable<UnityEngine.Vector2>), 0);
                            }
                            System.Nullable<float> arg1;
                            var refVal1 = Values.js_read_wrap(ctx, argv[1]);
                            if (refVal1.IsException())
                            {
                                return refVal1;
                            }
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, refVal1, out arg1))
                            {
                                JSApi.JS_FreeValue(ctx, refVal1);
                                throw new ParameterException(typeof(NoNamespaceClass), "TestNullable", typeof(System.Nullable<float>), 1);
                            }
                            JSApi.JS_FreeValue(ctx, refVal1);
                            var ret = NoNamespaceClass.TestNullable(arg0, ref arg1);
                            var out0 = QuickJS.Binding.Values.js_push_primitive(ctx, arg1);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 1)
                    {
                        System.Nullable<UnityEngine.Vector2> arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(NoNamespaceClass), "TestNullable", typeof(System.Nullable<UnityEngine.Vector2>), 0);
                        }
                        var ret = NoNamespaceClass.TestNullable(arg0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("TestNullable", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("NoNamespaceClass", typeof(NoNamespaceClass), BindConstructor);
            cls.AddMethod(true, "V1", BindStatic_V1);
            cls.AddMethod(true, "Moo", BindStatic_Moo);
            cls.AddMethod(true, "MakeBytes", BindStatic_MakeBytes);
            cls.AddMethod(true, "TestBytes", BindStatic_TestBytes);
            cls.AddMethod(true, "TestOut", BindStatic_TestOut);
            cls.AddMethod(true, "TestRefOut", BindStatic_TestRefOut);
            cls.AddMethod(true, "TestNullable", BindStatic_TestNullable);
            return cls;
        }
    }
}
#endif
