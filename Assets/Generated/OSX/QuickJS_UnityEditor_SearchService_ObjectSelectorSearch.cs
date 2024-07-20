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
    // Type: UnityEditor.SearchService.ObjectSelectorSearch
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_SearchService_ObjectSelectorSearch
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RegisterEngine(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.SearchService.IObjectSelectorEngine arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.SearchService.ObjectSelectorSearch), "RegisterEngine", typeof(UnityEditor.SearchService.IObjectSelectorEngine), 0);
                    }
                    UnityEditor.SearchService.ObjectSelectorSearch.RegisterEngine(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RegisterEngine", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_UnregisterEngine(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.SearchService.IObjectSelectorEngine arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.SearchService.ObjectSelectorSearch), "UnregisterEngine", typeof(UnityEditor.SearchService.IObjectSelectorEngine), 0);
                    }
                    UnityEditor.SearchService.ObjectSelectorSearch.UnregisterEngine(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("UnregisterEngine", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("ObjectSelectorSearch", typeof(UnityEditor.SearchService.ObjectSelectorSearch), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "RegisterEngine", BindStatic_RegisterEngine);
            cls.AddMethod(true, "UnregisterEngine", BindStatic_UnregisterEngine);
            cls.AddConstValue("EngineScope", 2);
            return cls;
        }
    }
}
#endif
#endif
