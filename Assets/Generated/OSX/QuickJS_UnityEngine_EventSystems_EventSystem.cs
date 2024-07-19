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
    // Assembly: UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Users/longpt/Documents/SkyMavis/unity-jsb-2/Library/ScriptAssemblies/UnityEngine.UI.dll
    // Type: UnityEngine.EventSystems.EventSystem
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_EventSystems_EventSystem
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_UpdateModules(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.EventSystems.EventSystem self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.UpdateModules();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("UpdateModules", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetSelectedGameObject(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        UnityEngine.EventSystems.EventSystem self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.GameObject arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.EventSystems.EventSystem), "SetSelectedGameObject", typeof(UnityEngine.GameObject), 0);
                        }
                        UnityEngine.EventSystems.BaseEventData arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.EventSystems.EventSystem), "SetSelectedGameObject", typeof(UnityEngine.EventSystems.BaseEventData), 1);
                        }
                        self.SetSelectedGameObject(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 1)
                    {
                        UnityEngine.EventSystems.EventSystem self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.GameObject arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.EventSystems.EventSystem), "SetSelectedGameObject", typeof(UnityEngine.GameObject), 0);
                        }
                        self.SetSelectedGameObject(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("SetSelectedGameObject", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_RaycastAll(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.EventSystems.EventSystem self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.EventSystems.PointerEventData arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.EventSystems.EventSystem), "RaycastAll", typeof(UnityEngine.EventSystems.PointerEventData), 0);
                    }
                    System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.EventSystems.EventSystem), "RaycastAll", typeof(System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult>), 1);
                    }
                    self.RaycastAll(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RaycastAll", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_IsPointerOverGameObject(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        UnityEngine.EventSystems.EventSystem self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        int arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.EventSystems.EventSystem), "IsPointerOverGameObject", typeof(int), 0);
                        }
                        var ret = self.IsPointerOverGameObject(arg0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 0)
                    {
                        UnityEngine.EventSystems.EventSystem self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        var ret = self.IsPointerOverGameObject();
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("IsPointerOverGameObject", argc);
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
                    UnityEngine.EventSystems.EventSystem self;
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
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_current(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.EventSystems.EventSystem.current;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_current(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.EventSystems.EventSystem value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.EventSystems.EventSystem), "current", typeof(UnityEngine.EventSystems.EventSystem), 0);
                }
                UnityEngine.EventSystems.EventSystem.current = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_sendNavigationEvents(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.EventSystems.EventSystem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.sendNavigationEvents;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_sendNavigationEvents(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.EventSystems.EventSystem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.EventSystems.EventSystem), "sendNavigationEvents", typeof(bool), 0);
                }
                self.sendNavigationEvents = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_pixelDragThreshold(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.EventSystems.EventSystem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.pixelDragThreshold;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_pixelDragThreshold(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.EventSystems.EventSystem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.EventSystems.EventSystem), "pixelDragThreshold", typeof(int), 0);
                }
                self.pixelDragThreshold = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_currentInputModule(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.EventSystems.EventSystem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.currentInputModule;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_firstSelectedGameObject(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.EventSystems.EventSystem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.firstSelectedGameObject;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_firstSelectedGameObject(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.EventSystems.EventSystem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.GameObject value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.EventSystems.EventSystem), "firstSelectedGameObject", typeof(UnityEngine.GameObject), 0);
                }
                self.firstSelectedGameObject = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_currentSelectedGameObject(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.EventSystems.EventSystem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.currentSelectedGameObject;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_isFocused(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.EventSystems.EventSystem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.isFocused;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_alreadySelecting(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.EventSystems.EventSystem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.alreadySelecting;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("EventSystem", typeof(UnityEngine.EventSystems.EventSystem), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(false, "UpdateModules", Bind_UpdateModules);
            cls.AddMethod(false, "SetSelectedGameObject", Bind_SetSelectedGameObject);
            cls.AddMethod(false, "RaycastAll", Bind_RaycastAll);
            cls.AddMethod(false, "IsPointerOverGameObject", Bind_IsPointerOverGameObject);
            cls.AddMethod(false, "toString", Bind_ToString);
            cls.AddProperty(true, "current", BindStaticRead_current, BindStaticWrite_current);
            cls.AddProperty(false, "sendNavigationEvents", BindRead_sendNavigationEvents, BindWrite_sendNavigationEvents);
            cls.AddProperty(false, "pixelDragThreshold", BindRead_pixelDragThreshold, BindWrite_pixelDragThreshold);
            cls.AddProperty(false, "currentInputModule", BindRead_currentInputModule, null);
            cls.AddProperty(false, "firstSelectedGameObject", BindRead_firstSelectedGameObject, BindWrite_firstSelectedGameObject);
            cls.AddProperty(false, "currentSelectedGameObject", BindRead_currentSelectedGameObject, null);
            cls.AddProperty(false, "isFocused", BindRead_isFocused, null);
            cls.AddProperty(false, "alreadySelecting", BindRead_alreadySelecting, null);
            return cls;
        }
    }
}
#endif
