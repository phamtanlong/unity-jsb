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
    // Type: UnityEditor.ShaderKeywordFilter.RemoveIfNotAttribute
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_ShaderKeywordFilter_RemoveIfNotAttribute
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                if (argc >= 4)
                {
                    if (Values.js_match_type(ctx, argv[0], typeof(object)) && Values.js_match_type(ctx, argv[1], typeof(bool)) && Values.js_match_type(ctx, argv[2], typeof(string)) && Values.js_match_type(ctx, argv[3], typeof(int)) && Values.js_match_param_types(ctx, 4, argv, typeof(string)))
                    {
                        object arg0;
                        if (!Values.js_get_var(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderKeywordFilter.RemoveIfNotAttribute), ".ctor", typeof(object), 0);
                        }
                        bool arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderKeywordFilter.RemoveIfNotAttribute), ".ctor", typeof(bool), 1);
                        }
                        string arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderKeywordFilter.RemoveIfNotAttribute), ".ctor", typeof(string), 2);
                        }
                        int arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderKeywordFilter.RemoveIfNotAttribute), ".ctor", typeof(int), 3);
                        }
                        string[] arg4 = null;
                        if (argc - 4 > 0)
                        {
                            arg4 = new string[argc - 4];
                            for (var i = 4; i < argc; i++)
                            {
                                QuickJS.Binding.Values.js_get_primitive(ctx, argv[i], out arg4[i - 4]);
                            }
                        }
                        var o = new UnityEditor.ShaderKeywordFilter.RemoveIfNotAttribute(arg0, arg1, arg2, arg3, arg4);
                        var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                        return val;
                    }
                }
                throw new NoSuitableMethodException("constructor", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("RemoveIfNotAttribute", typeof(UnityEditor.ShaderKeywordFilter.RemoveIfNotAttribute), BindConstructor);
            return cls;
        }
    }
}
#endif
#endif
