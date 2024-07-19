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
    // Type: UnityEngine.Events.UnityEventBase
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_Events_UnityEventBase
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetPersistentEventCount(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.Events.UnityEventBase self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.GetPersistentEventCount();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetPersistentEventCount", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetPersistentTarget(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Events.UnityEventBase self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Events.UnityEventBase), "GetPersistentTarget", typeof(int), 0);
                    }
                    var ret = self.GetPersistentTarget(arg0);
                    return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetPersistentTarget", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetPersistentMethodName(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Events.UnityEventBase self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Events.UnityEventBase), "GetPersistentMethodName", typeof(int), 0);
                    }
                    var ret = self.GetPersistentMethodName(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetPersistentMethodName", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetPersistentListenerState(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Events.UnityEventBase self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Events.UnityEventBase), "SetPersistentListenerState", typeof(int), 0);
                    }
                    UnityEngine.Events.UnityEventCallState arg1;
                    if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Events.UnityEventBase), "SetPersistentListenerState", typeof(UnityEngine.Events.UnityEventCallState), 1);
                    }
                    self.SetPersistentListenerState(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetPersistentListenerState", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_RemoveAllListeners(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.Events.UnityEventBase self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.RemoveAllListeners();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RemoveAllListeners", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ToString(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.Events.UnityEventBase self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.ToString();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("toString", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetValidMethodInfo(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    object arg0;
                    if (!Values.js_get_var(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Events.UnityEventBase), "GetValidMethodInfo", typeof(object), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Events.UnityEventBase), "GetValidMethodInfo", typeof(string), 1);
                    }
                    System.Type[] arg2;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEngine.Events.UnityEventBase), "GetValidMethodInfo", typeof(System.Type[]), 2);
                    }
                    var ret = UnityEngine.Events.UnityEventBase.GetValidMethodInfo(arg0, arg1, arg2);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetValidMethodInfo", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("UnityEventBase", typeof(UnityEngine.Events.UnityEventBase), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(false, "GetPersistentEventCount", Bind_GetPersistentEventCount);
            cls.AddMethod(false, "GetPersistentTarget", Bind_GetPersistentTarget);
            cls.AddMethod(false, "GetPersistentMethodName", Bind_GetPersistentMethodName);
            cls.AddMethod(false, "SetPersistentListenerState", Bind_SetPersistentListenerState);
            cls.AddMethod(false, "RemoveAllListeners", Bind_RemoveAllListeners);
            cls.AddMethod(false, "toString", Bind_ToString);
            cls.AddMethod(true, "GetValidMethodInfo", BindStatic_GetValidMethodInfo);
            return cls;
        }
    }
}
#endif
