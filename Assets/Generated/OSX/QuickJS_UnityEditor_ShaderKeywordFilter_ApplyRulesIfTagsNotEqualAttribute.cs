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
    // Type: UnityEditor.ShaderKeywordFilter.ApplyRulesIfTagsNotEqualAttribute
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_ShaderKeywordFilter_ApplyRulesIfTagsNotEqualAttribute
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                if (Values.js_match_param_types(ctx, 0, argv, typeof(string)))
                {
                    string[] arg0 = null;
                    if (argc > 0)
                    {
                        arg0 = new string[argc];
                        for (var i = 0; i < argc; i++)
                        {
                            QuickJS.Binding.Values.js_get_primitive(ctx, argv[i], out arg0[i]);
                        }
                    }
                    var o = new UnityEditor.ShaderKeywordFilter.ApplyRulesIfTagsNotEqualAttribute(arg0);
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
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("ApplyRulesIfTagsNotEqualAttribute", typeof(UnityEditor.ShaderKeywordFilter.ApplyRulesIfTagsNotEqualAttribute), BindConstructor);
            return cls;
        }
    }
}
#endif
#endif
