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
    // Type: UnityEditor.Build.IUnityLinkerProcessor
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_Build_IUnityLinkerProcessor
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GenerateAdditionalLinkXmlFile(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEditor.Build.IUnityLinkerProcessor self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEditor.Build.Reporting.BuildReport arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Build.IUnityLinkerProcessor), "GenerateAdditionalLinkXmlFile", typeof(UnityEditor.Build.Reporting.BuildReport), 0);
                    }
                    UnityEditor.UnityLinker.UnityLinkerBuildPipelineData arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Build.IUnityLinkerProcessor), "GenerateAdditionalLinkXmlFile", typeof(UnityEditor.UnityLinker.UnityLinkerBuildPipelineData), 1);
                    }
                    var ret = self.GenerateAdditionalLinkXmlFile(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GenerateAdditionalLinkXmlFile", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_OnBeforeRun(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEditor.Build.IUnityLinkerProcessor self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEditor.Build.Reporting.BuildReport arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Build.IUnityLinkerProcessor), "OnBeforeRun", typeof(UnityEditor.Build.Reporting.BuildReport), 0);
                    }
                    UnityEditor.UnityLinker.UnityLinkerBuildPipelineData arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Build.IUnityLinkerProcessor), "OnBeforeRun", typeof(UnityEditor.UnityLinker.UnityLinkerBuildPipelineData), 1);
                    }
                    self.OnBeforeRun(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("OnBeforeRun", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_OnAfterRun(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEditor.Build.IUnityLinkerProcessor self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEditor.Build.Reporting.BuildReport arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Build.IUnityLinkerProcessor), "OnAfterRun", typeof(UnityEditor.Build.Reporting.BuildReport), 0);
                    }
                    UnityEditor.UnityLinker.UnityLinkerBuildPipelineData arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Build.IUnityLinkerProcessor), "OnAfterRun", typeof(UnityEditor.UnityLinker.UnityLinkerBuildPipelineData), 1);
                    }
                    self.OnAfterRun(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("OnAfterRun", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("IUnityLinkerProcessor", typeof(UnityEditor.Build.IUnityLinkerProcessor), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(false, "GenerateAdditionalLinkXmlFile", Bind_GenerateAdditionalLinkXmlFile);
            cls.AddMethod(false, "OnBeforeRun", Bind_OnBeforeRun);
            cls.AddMethod(false, "OnAfterRun", Bind_OnAfterRun);
            return cls;
        }
    }
}
#endif
#endif
