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
    // Type: UnityEditor.BuildPlayerWindow+DefaultBuildMethods
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_BuildPlayerWindow_DefaultBuildMethods
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_BuildPlayer(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.BuildPlayerOptions arg0;
                    if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.BuildPlayerWindow.DefaultBuildMethods), "BuildPlayer", typeof(UnityEditor.BuildPlayerOptions), 0);
                    }
                    UnityEditor.BuildPlayerWindow.DefaultBuildMethods.BuildPlayer(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("BuildPlayer", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetBuildPlayerOptions(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.BuildPlayerOptions arg0;
                    if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.BuildPlayerWindow.DefaultBuildMethods), "GetBuildPlayerOptions", typeof(UnityEditor.BuildPlayerOptions), 0);
                    }
                    var ret = UnityEditor.BuildPlayerWindow.DefaultBuildMethods.GetBuildPlayerOptions(arg0);
                    return Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetBuildPlayerOptions", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("DefaultBuildMethods", typeof(UnityEditor.BuildPlayerWindow.DefaultBuildMethods), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "BuildPlayer", BindStatic_BuildPlayer);
            cls.AddMethod(true, "GetBuildPlayerOptions", BindStatic_GetBuildPlayerOptions);
            return cls;
        }
    }
}
#endif
#endif
