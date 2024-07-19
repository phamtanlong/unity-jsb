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
    // Type: UnityEditor.CustomEditorForRenderPipelineAttribute
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_CustomEditorForRenderPipelineAttribute
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        System.Type arg0;
                        if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.CustomEditorForRenderPipelineAttribute), ".ctor", typeof(System.Type), 0);
                        }
                        System.Type arg1;
                        if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.CustomEditorForRenderPipelineAttribute), ".ctor", typeof(System.Type), 1);
                        }
                        bool arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.CustomEditorForRenderPipelineAttribute), ".ctor", typeof(bool), 2);
                        }
                        var o = new UnityEditor.CustomEditorForRenderPipelineAttribute(arg0, arg1, arg2);
                        var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                        return val;
                    }
                    if (argc == 2)
                    {
                        System.Type arg0;
                        if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.CustomEditorForRenderPipelineAttribute), ".ctor", typeof(System.Type), 0);
                        }
                        System.Type arg1;
                        if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.CustomEditorForRenderPipelineAttribute), ".ctor", typeof(System.Type), 1);
                        }
                        var o = new UnityEditor.CustomEditorForRenderPipelineAttribute(arg0, arg1);
                        var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                        return val;
                    }
                } while(false);
                throw new NoSuitableMethodException("constructor", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("CustomEditorForRenderPipelineAttribute", typeof(UnityEditor.CustomEditorForRenderPipelineAttribute), BindConstructor);
            return cls;
        }
    }
}
#endif
#endif
