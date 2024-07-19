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
    // Type: SampleBehaviour
    [JSBindingAttribute]
    public class QuickJS_SampleBehaviour
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                if (argc == 0)
                {
                    var o = new SampleBehaviour();
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
        public static JSValue Bind_SimpleWait(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    SampleBehaviour self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    QuickJS.ScriptContext arg0;
                    arg0 = ScriptEngine.GetContext(ctx);
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg1))
                    {
                        throw new ParameterException(typeof(SampleBehaviour), "SimpleWait", typeof(int), 0);
                    }
                    var ret = self.SimpleWait(arg0, arg1);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("SimpleWait", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_AnotherWait(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    SampleBehaviour self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    QuickJS.ScriptContext arg0;
                    arg0 = ScriptEngine.GetContext(ctx);
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg1))
                    {
                        throw new ParameterException(typeof(SampleBehaviour), "AnotherWait", typeof(int), 0);
                    }
                    var ret = self.AnotherWait(arg0, arg1);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("AnotherWait", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("SampleBehaviour", typeof(SampleBehaviour), BindConstructor);
            cls.AddMethod(false, "SimpleWait", Bind_SimpleWait);
            cls.AddMethod(false, "AnotherWait", Bind_AnotherWait);
            cls.AddRawMethod(false, "PrimitiveCall", SampleBehaviour.PrimitiveCall);
            return cls;
        }
    }
}
#endif
