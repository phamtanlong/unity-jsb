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
    // Type: UnityEditor.SearchService.ISelectorEngine
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_SearchService_ISelectorEngine
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SelectObject(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEditor.SearchService.ISelectorEngine self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEditor.SearchService.ISearchContext arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.SearchService.ISelectorEngine), "SelectObject", typeof(UnityEditor.SearchService.ISearchContext), 0);
                    }
                    System.Action<UnityEngine.Object, bool> arg1;
                    if (!Values.js_get_delegate(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.SearchService.ISelectorEngine), "SelectObject", typeof(System.Action<UnityEngine.Object, bool>), 1);
                    }
                    System.Action<UnityEngine.Object> arg2;
                    if (!Values.js_get_delegate(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.SearchService.ISelectorEngine), "SelectObject", typeof(System.Action<UnityEngine.Object>), 2);
                    }
                    var ret = self.SelectObject(arg0, arg1, arg2);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("SelectObject", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetSearchFilter(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEditor.SearchService.ISelectorEngine self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEditor.SearchService.ISearchContext arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.SearchService.ISelectorEngine), "SetSearchFilter", typeof(UnityEditor.SearchService.ISearchContext), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.SearchService.ISelectorEngine), "SetSearchFilter", typeof(string), 1);
                    }
                    self.SetSearchFilter(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetSearchFilter", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("ISelectorEngine", typeof(UnityEditor.SearchService.ISelectorEngine), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(false, "SelectObject", Bind_SelectObject);
            cls.AddMethod(false, "SetSearchFilter", Bind_SetSearchFilter);
            return cls;
        }
    }
}
#endif
#endif
