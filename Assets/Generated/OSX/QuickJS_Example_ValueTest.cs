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
    // Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Users/longpt/Documents/SkyMavis/unity-jsb-2/Library/ScriptAssemblies/Assembly-CSharp.dll
    // Type: Example.ValueTest
    [JSBindingAttribute]
    public class QuickJS_Example_ValueTest
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                if (argc == 0)
                {
                    var o = new Example.ValueTest();
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
        public static JSValue Bind_ToString(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    Example.ValueTest self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.ToString();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("toString", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_TakeStringWithCache(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(Example.ValueTest), "TakeStringWithCache", typeof(string), 0);
                    }
                    Example.ValueTest.TakeStringWithCache(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("TakeStringWithCache", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_TakeString(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(Example.ValueTest), "TakeString", typeof(string), 0);
                    }
                    Example.ValueTest.TakeString(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("TakeString", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Foo(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(Example.ValueTest), "Foo", typeof(string), 0);
                    }
                    var ret = Example.ValueTest.Foo(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("Foo", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CheckArgs(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type_hint(ctx, argv[1], typeof(float)) && Values.js_match_type_hint(ctx, argv[2], typeof(string)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(Example.ValueTest), "CheckArgs", typeof(int), 0);
                            }
                            float arg1;
                            string arg2;
                            var refVal2 = Values.js_read_wrap(ctx, argv[2]);
                            if (refVal2.IsException())
                            {
                                return refVal2;
                            }
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, refVal2, out arg2))
                            {
                                JSApi.JS_FreeValue(ctx, refVal2);
                                throw new ParameterException(typeof(Example.ValueTest), "CheckArgs", typeof(string), 2);
                            }
                            JSApi.JS_FreeValue(ctx, refVal2);
                            var ret = Example.ValueTest.CheckArgs(arg0, out arg1, ref arg2);
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
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type_hint(ctx, argv[1], typeof(float)) && Values.js_match_type_hint(ctx, argv[2], typeof(UnityEngine.GameObject)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(Example.ValueTest), "CheckArgs", typeof(int), 0);
                            }
                            float arg1;
                            UnityEngine.GameObject arg2;
                            var refVal2 = Values.js_read_wrap(ctx, argv[2]);
                            if (refVal2.IsException())
                            {
                                return refVal2;
                            }
                            if (!Values.js_get_classvalue(ctx, refVal2, out arg2))
                            {
                                JSApi.JS_FreeValue(ctx, refVal2);
                                throw new ParameterException(typeof(Example.ValueTest), "CheckArgs", typeof(UnityEngine.GameObject), 2);
                            }
                            JSApi.JS_FreeValue(ctx, refVal2);
                            var ret = Example.ValueTest.CheckArgs(arg0, out arg1, ref arg2);
                            var out0 = QuickJS.Binding.Values.js_push_primitive(ctx, arg1);
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
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("CheckArgs", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_MakeTrouble(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    Example.ValueTest.MakeTrouble();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("MakeTrouble", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_values1(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = Example.ValueTest.values1;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_values1(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int[] value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(Example.ValueTest), "values1", typeof(int[]), 0);
                }
                Example.ValueTest.values1 = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_values2(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = Example.ValueTest.values2;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_values2(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int[,] value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(Example.ValueTest), "values2", typeof(int[,]), 0);
                }
                Example.ValueTest.values2 = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("ValueTest", typeof(Example.ValueTest), BindConstructor);
            cls.AddMethod(false, "toString", Bind_ToString);
            cls.AddMethod(true, "TakeStringWithCache", BindStatic_TakeStringWithCache);
            cls.AddMethod(true, "TakeString", BindStatic_TakeString);
            cls.AddMethod(true, "Foo", BindStatic_Foo);
            cls.AddMethod(true, "CheckArgs", BindStatic_CheckArgs);
            cls.AddMethod(true, "MakeTrouble", BindStatic_MakeTrouble);
            cls.AddField(true, "values1", BindStaticRead_values1, BindStaticWrite_values1);
            cls.AddField(true, "values2", BindStaticRead_values2, BindStaticWrite_values2);
            return cls;
        }
    }
}
#endif
