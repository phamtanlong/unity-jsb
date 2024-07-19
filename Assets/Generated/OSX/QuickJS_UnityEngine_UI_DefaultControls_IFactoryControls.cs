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
    // Assembly: UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Users/longpt/Documents/SkyMavis/unity-jsb-2/Library/ScriptAssemblies/UnityEngine.UI.dll
    // Type: UnityEngine.UI.DefaultControls+IFactoryControls
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_UI_DefaultControls_IFactoryControls
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_CreateGameObject(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc >= 1)
                {
                    if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_param_types(ctx, 1, argv, typeof(System.Type)))
                    {
                        UnityEngine.UI.DefaultControls.IFactoryControls self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.UI.DefaultControls.IFactoryControls), "CreateGameObject", typeof(string), 0);
                        }
                        System.Type[] arg1 = null;
                        if (argc - 1 > 0)
                        {
                            arg1 = new System.Type[argc - 1];
                            for (var i = 1; i < argc; i++)
                            {
                                QuickJS.Binding.Values.js_get_classvalue(ctx, argv[i], out arg1[i - 1]);
                            }
                        }
                        var ret = self.CreateGameObject(arg0, arg1);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                }
                throw new NoSuitableMethodException("CreateGameObject", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("IFactoryControls", typeof(UnityEngine.UI.DefaultControls.IFactoryControls), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(false, "CreateGameObject", Bind_CreateGameObject);
            return cls;
        }
    }
}
#endif
