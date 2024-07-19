#if UNITY_EDITOR
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
    // Assembly: UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Applications/Unity/Hub/Editor/2019.4.40f1/Unity.app/Contents/Managed/UnityEditor.dll
    // Type: UnityEditor.LightingExplorerTab
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_LightingExplorerTab
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                if (argc == 3)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.LightingExplorerTab), ".ctor", typeof(string), 0);
                    }
                    System.Func<UnityEngine.Object[]> arg1;
                    if (!Values.js_get_delegate(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.LightingExplorerTab), ".ctor", typeof(System.Func<UnityEngine.Object[]>), 1);
                    }
                    System.Func<UnityEditor.LightingExplorerTableColumn[]> arg2;
                    if (!Values.js_get_delegate(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.LightingExplorerTab), ".ctor", typeof(System.Func<UnityEditor.LightingExplorerTableColumn[]>), 2);
                    }
                    var o = new UnityEditor.LightingExplorerTab(arg0, arg1, arg2);
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
            var cls = register.CreateClass("LightingExplorerTab", typeof(UnityEditor.LightingExplorerTab), BindConstructor);
            return cls;
        }
    }
}
#endif
#endif
