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
    // Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Applications/Unity/Hub/Editor/2019.4.40f1/Unity.app/Contents/Managed/UnityEngine/UnityEngine.CoreModule.dll
    // Type: UnityEngine.Events.UnityEvent`1[[UnityEngine.EventSystems.BaseEventData, UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_Events_UnityEvent_BaseEventData
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_AddListener(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.BaseEventData> self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Events.UnityAction<UnityEngine.EventSystems.BaseEventData> arg0;
                    if (!Values.js_get_delegate(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.BaseEventData>), "AddListener", typeof(UnityEngine.Events.UnityAction<UnityEngine.EventSystems.BaseEventData>), 0);
                    }
                    self.AddListener(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("AddListener", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_RemoveListener(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.BaseEventData> self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Events.UnityAction<UnityEngine.EventSystems.BaseEventData> arg0;
                    if (!Values.js_get_delegate(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.BaseEventData>), "RemoveListener", typeof(UnityEngine.Events.UnityAction<UnityEngine.EventSystems.BaseEventData>), 0);
                    }
                    self.RemoveListener(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RemoveListener", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Invoke(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.BaseEventData> self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.EventSystems.BaseEventData arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.BaseEventData>), "Invoke", typeof(UnityEngine.EventSystems.BaseEventData), 0);
                    }
                    self.Invoke(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Invoke", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("UnityEvent_BaseEventData", typeof(UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.BaseEventData>), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(false, "AddListener", Bind_AddListener);
            cls.AddMethod(false, "RemoveListener", Bind_RemoveListener);
            cls.AddMethod(false, "Invoke", Bind_Invoke);
            return cls;
        }
    }
}
#endif
