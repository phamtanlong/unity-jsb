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
    // Type: UnityEditor.Build.IPostBuildPlayerScriptDLLs
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_Build_IPostBuildPlayerScriptDLLs
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_OnPostBuildPlayerScriptDLLs(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.Build.IPostBuildPlayerScriptDLLs self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEditor.Build.Reporting.BuildReport arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Build.IPostBuildPlayerScriptDLLs), "OnPostBuildPlayerScriptDLLs", typeof(UnityEditor.Build.Reporting.BuildReport), 0);
                    }
                    self.OnPostBuildPlayerScriptDLLs(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("OnPostBuildPlayerScriptDLLs", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("IPostBuildPlayerScriptDLLs", typeof(UnityEditor.Build.IPostBuildPlayerScriptDLLs), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(false, "OnPostBuildPlayerScriptDLLs", Bind_OnPostBuildPlayerScriptDLLs);
            return cls;
        }
    }
}
#endif
#endif
