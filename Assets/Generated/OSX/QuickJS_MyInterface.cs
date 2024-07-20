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
    // Type: MyInterface
    [JSBindingAttribute]
    public class QuickJS_MyInterface
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Foo(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    MyInterface self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.Foo();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Foo", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("MyInterface", typeof(MyInterface), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(false, "Foo", Bind_Foo);
            return cls;
        }
    }
}
#endif
