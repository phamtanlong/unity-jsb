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
    // Type: UnityEditor.AssemblyReloadEvents
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_AssemblyReloadEvents
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticEvent_beforeAssemblyReload(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                UnityEditor.AssemblyReloadEvents.AssemblyReloadCallback value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.AssemblyReloadEvents), "beforeAssemblyReload", typeof(UnityEditor.AssemblyReloadEvents.AssemblyReloadCallback), 1);
                        }
                        UnityEditor.AssemblyReloadEvents.beforeAssemblyReload += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.AssemblyReloadEvents), "beforeAssemblyReload", typeof(UnityEditor.AssemblyReloadEvents.AssemblyReloadCallback), 1);
                        }
                        UnityEditor.AssemblyReloadEvents.beforeAssemblyReload -= value;
                        break;
                    default: throw new JSException("invalid event op");
                }
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticEvent_afterAssemblyReload(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                UnityEditor.AssemblyReloadEvents.AssemblyReloadCallback value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.AssemblyReloadEvents), "afterAssemblyReload", typeof(UnityEditor.AssemblyReloadEvents.AssemblyReloadCallback), 1);
                        }
                        UnityEditor.AssemblyReloadEvents.afterAssemblyReload += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.AssemblyReloadEvents), "afterAssemblyReload", typeof(UnityEditor.AssemblyReloadEvents.AssemblyReloadCallback), 1);
                        }
                        UnityEditor.AssemblyReloadEvents.afterAssemblyReload -= value;
                        break;
                    default: throw new JSException("invalid event op");
                }
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("AssemblyReloadEvents", typeof(UnityEditor.AssemblyReloadEvents), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "beforeAssemblyReload", BindStaticEvent_beforeAssemblyReload);
            cls.AddMethod(true, "afterAssemblyReload", BindStaticEvent_afterAssemblyReload);
            return cls;
        }
    }
}
#endif
#endif
