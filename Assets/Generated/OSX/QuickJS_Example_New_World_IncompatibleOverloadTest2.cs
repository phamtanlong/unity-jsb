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
    // Type: Example.New.World.IncompatibleOverloadTest2
    [JSBindingAttribute]
    public class QuickJS_Example_New_World_IncompatibleOverloadTest2
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                if (argc == 0)
                {
                    var o = new Example.New.World.IncompatibleOverloadTest2();
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
        public static JSValue Bind_Test(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        Example.New.World.IncompatibleOverloadTest2 self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        int arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(Example.New.World.IncompatibleOverloadTest2), "Test", typeof(int), 0);
                        }
                        self.Test(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 0)
                    {
                        Example.New.World.IncompatibleOverloadTest1 self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        self.Test();
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("Test", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("IncompatibleOverloadTest2", typeof(Example.New.World.IncompatibleOverloadTest2), BindConstructor);
            cls.AddMethod(false, "Test", Bind_Test);
            return cls;
        }
    }
}
#endif
