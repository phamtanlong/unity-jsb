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
    // Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Applications/Unity/Hub/Editor/2021.3.37f1/Unity.app/Contents/Managed/UnityEngine/UnityEngine.CoreModule.dll
    // Type: UnityEngine.Component
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_Component
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                if (argc == 0)
                {
                    var o = new UnityEngine.Component();
                    var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                    return val;
                }
                throw new NoSuitableMethodException("constructor", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_TryGetComponent(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Component self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    System.Type arg0;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Component), "TryGetComponent", typeof(System.Type), 0);
                    }
                    UnityEngine.Component arg1;
                    var ret = self.TryGetComponent(arg0, out arg1);
                    var out0 = Values.js_push_classvalue(ctx, arg1);
                    if (JSApi.JS_IsException(out0))
                    {
                        return out0;
                    }
                    var context = ScriptEngine.GetContext(ctx);
                    JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("TryGetComponent", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_CompareTag(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Component self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Component), "CompareTag", typeof(string), 0);
                    }
                    var ret = self.CompareTag(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("CompareTag", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SendMessageUpwards(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        UnityEngine.Component self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Component), "SendMessageUpwards", typeof(string), 0);
                        }
                        object arg1;
                        if (!Values.js_get_var(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Component), "SendMessageUpwards", typeof(object), 1);
                        }
                        UnityEngine.SendMessageOptions arg2;
                        if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Component), "SendMessageUpwards", typeof(UnityEngine.SendMessageOptions), 2);
                        }
                        self.SendMessageUpwards(arg0, arg1, arg2);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(object)))
                        {
                            UnityEngine.Component self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Component), "SendMessageUpwards", typeof(string), 0);
                            }
                            object arg1;
                            if (!Values.js_get_var(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Component), "SendMessageUpwards", typeof(object), 1);
                            }
                            self.SendMessageUpwards(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.SendMessageOptions)))
                        {
                            UnityEngine.Component self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Component), "SendMessageUpwards", typeof(string), 0);
                            }
                            UnityEngine.SendMessageOptions arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Component), "SendMessageUpwards", typeof(UnityEngine.SendMessageOptions), 1);
                            }
                            self.SendMessageUpwards(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 1)
                    {
                        UnityEngine.Component self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Component), "SendMessageUpwards", typeof(string), 0);
                        }
                        self.SendMessageUpwards(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("SendMessageUpwards", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SendMessage(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        UnityEngine.Component self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Component), "SendMessage", typeof(string), 0);
                        }
                        object arg1;
                        if (!Values.js_get_var(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Component), "SendMessage", typeof(object), 1);
                        }
                        UnityEngine.SendMessageOptions arg2;
                        if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Component), "SendMessage", typeof(UnityEngine.SendMessageOptions), 2);
                        }
                        self.SendMessage(arg0, arg1, arg2);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(object)))
                        {
                            UnityEngine.Component self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Component), "SendMessage", typeof(string), 0);
                            }
                            object arg1;
                            if (!Values.js_get_var(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Component), "SendMessage", typeof(object), 1);
                            }
                            self.SendMessage(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.SendMessageOptions)))
                        {
                            UnityEngine.Component self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Component), "SendMessage", typeof(string), 0);
                            }
                            UnityEngine.SendMessageOptions arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Component), "SendMessage", typeof(UnityEngine.SendMessageOptions), 1);
                            }
                            self.SendMessage(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 1)
                    {
                        UnityEngine.Component self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Component), "SendMessage", typeof(string), 0);
                        }
                        self.SendMessage(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("SendMessage", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_BroadcastMessage(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        UnityEngine.Component self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Component), "BroadcastMessage", typeof(string), 0);
                        }
                        object arg1;
                        if (!Values.js_get_var(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Component), "BroadcastMessage", typeof(object), 1);
                        }
                        UnityEngine.SendMessageOptions arg2;
                        if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Component), "BroadcastMessage", typeof(UnityEngine.SendMessageOptions), 2);
                        }
                        self.BroadcastMessage(arg0, arg1, arg2);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(object)))
                        {
                            UnityEngine.Component self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Component), "BroadcastMessage", typeof(string), 0);
                            }
                            object arg1;
                            if (!Values.js_get_var(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Component), "BroadcastMessage", typeof(object), 1);
                            }
                            self.BroadcastMessage(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.SendMessageOptions)))
                        {
                            UnityEngine.Component self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Component), "BroadcastMessage", typeof(string), 0);
                            }
                            UnityEngine.SendMessageOptions arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Component), "BroadcastMessage", typeof(UnityEngine.SendMessageOptions), 1);
                            }
                            self.BroadcastMessage(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 1)
                    {
                        UnityEngine.Component self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Component), "BroadcastMessage", typeof(string), 0);
                        }
                        self.BroadcastMessage(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("BroadcastMessage", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_transform(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Component self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.transform;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_gameObject(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Component self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.gameObject;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_tag(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Component self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.tag;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_tag(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Component self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Component), "tag", typeof(string), 0);
                }
                self.tag = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("Component", typeof(UnityEngine.Component), BindConstructor);
            cls.AddMethod(false, "GetComponent", QuickJS.Unity.ComponentFix.Bind_GetComponent);
            cls.AddMethod(false, "TryGetComponent", Bind_TryGetComponent);
            cls.AddMethod(false, "GetComponentInChildren", QuickJS.Unity.ComponentFix.Bind_GetComponentInChildren);
            cls.AddMethod(false, "GetComponentsInChildren", QuickJS.Unity.ComponentFix.Bind_GetComponentsInChildren);
            cls.AddMethod(false, "GetComponentInParent", QuickJS.Unity.ComponentFix.Bind_GetComponentInParent);
            cls.AddMethod(false, "GetComponentsInParent", QuickJS.Unity.ComponentFix.Bind_GetComponentsInParent);
            cls.AddMethod(false, "GetComponents", QuickJS.Unity.ComponentFix.Bind_GetComponents);
            cls.AddMethod(false, "CompareTag", Bind_CompareTag);
            cls.AddMethod(false, "SendMessageUpwards", Bind_SendMessageUpwards);
            cls.AddMethod(false, "SendMessage", Bind_SendMessage);
            cls.AddMethod(false, "BroadcastMessage", Bind_BroadcastMessage);
            cls.AddProperty(false, "transform", BindRead_transform, null);
            cls.AddProperty(false, "gameObject", BindRead_gameObject, null);
            cls.AddProperty(false, "tag", BindRead_tag, BindWrite_tag);
            return cls;
        }
    }
}
#endif
