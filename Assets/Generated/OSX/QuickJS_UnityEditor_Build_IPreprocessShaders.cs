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
    // Type: UnityEditor.Build.IPreprocessShaders
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_Build_IPreprocessShaders
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_OnProcessShader(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEditor.Build.IPreprocessShaders self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Shader arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Build.IPreprocessShaders), "OnProcessShader", typeof(UnityEngine.Shader), 0);
                    }
                    UnityEditor.Rendering.ShaderSnippetData arg1;
                    if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Build.IPreprocessShaders), "OnProcessShader", typeof(UnityEditor.Rendering.ShaderSnippetData), 1);
                    }
                    System.Collections.Generic.IList<UnityEditor.Rendering.ShaderCompilerData> arg2;
                    if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.Build.IPreprocessShaders), "OnProcessShader", typeof(System.Collections.Generic.IList<UnityEditor.Rendering.ShaderCompilerData>), 2);
                    }
                    self.OnProcessShader(arg0, arg1, arg2);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("OnProcessShader", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("IPreprocessShaders", typeof(UnityEditor.Build.IPreprocessShaders), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(false, "OnProcessShader", Bind_OnProcessShader);
            return cls;
        }
    }
}
#endif
#endif
