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
    // Type: UnityEngine.GameObject
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_GameObject
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                do
                {
                    if (argc >= 1)
                    {
                        if (argc == 1)
                        {
                            if (Values.js_match_type(ctx, argv[0], typeof(string)))
                            {
                                string arg0;
                                if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                                {
                                    throw new ParameterException(typeof(UnityEngine.GameObject), ".ctor", typeof(string), 0);
                                }
                                var o = new UnityEngine.GameObject(arg0);
                                var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                                return val;
                            }
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_param_types(ctx, 1, argv, typeof(System.Type)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GameObject), ".ctor", typeof(string), 0);
                            }
                            System.Type[] arg1 = null;
                            if (argc - 1 > 0)
                            {
                                arg1 = new System.Type[argc - 1];
                                for (var i = 1; i < argc; i++)
                                {
                                    QuickJS.Binding.Values.js_get_classvalue(ctx, argv[i], out arg1[i - 1]);
                                }
                            }
                            var o = new UnityEngine.GameObject(arg0, arg1);
                            var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                            return val;
                        }
                    }
                    if (argc == 0)
                    {
                        var o = new UnityEngine.GameObject();
                        var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                        return val;
                    }
                } while(false);
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
                    UnityEngine.GameObject self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    System.Type arg0;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.GameObject), "TryGetComponent", typeof(System.Type), 0);
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
        public static JSValue Bind_SendMessageUpwards(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        UnityEngine.GameObject self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.GameObject), "SendMessageUpwards", typeof(string), 0);
                        }
                        object arg1;
                        if (!Values.js_get_var(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.GameObject), "SendMessageUpwards", typeof(object), 1);
                        }
                        UnityEngine.SendMessageOptions arg2;
                        if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.GameObject), "SendMessageUpwards", typeof(UnityEngine.SendMessageOptions), 2);
                        }
                        self.SendMessageUpwards(arg0, arg1, arg2);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.SendMessageOptions)))
                        {
                            UnityEngine.GameObject self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GameObject), "SendMessageUpwards", typeof(string), 0);
                            }
                            UnityEngine.SendMessageOptions arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GameObject), "SendMessageUpwards", typeof(UnityEngine.SendMessageOptions), 1);
                            }
                            self.SendMessageUpwards(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(object)))
                        {
                            UnityEngine.GameObject self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GameObject), "SendMessageUpwards", typeof(string), 0);
                            }
                            object arg1;
                            if (!Values.js_get_var(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GameObject), "SendMessageUpwards", typeof(object), 1);
                            }
                            self.SendMessageUpwards(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 1)
                    {
                        UnityEngine.GameObject self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.GameObject), "SendMessageUpwards", typeof(string), 0);
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
                        UnityEngine.GameObject self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.GameObject), "SendMessage", typeof(string), 0);
                        }
                        object arg1;
                        if (!Values.js_get_var(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.GameObject), "SendMessage", typeof(object), 1);
                        }
                        UnityEngine.SendMessageOptions arg2;
                        if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.GameObject), "SendMessage", typeof(UnityEngine.SendMessageOptions), 2);
                        }
                        self.SendMessage(arg0, arg1, arg2);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.SendMessageOptions)))
                        {
                            UnityEngine.GameObject self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GameObject), "SendMessage", typeof(string), 0);
                            }
                            UnityEngine.SendMessageOptions arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GameObject), "SendMessage", typeof(UnityEngine.SendMessageOptions), 1);
                            }
                            self.SendMessage(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(object)))
                        {
                            UnityEngine.GameObject self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GameObject), "SendMessage", typeof(string), 0);
                            }
                            object arg1;
                            if (!Values.js_get_var(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GameObject), "SendMessage", typeof(object), 1);
                            }
                            self.SendMessage(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 1)
                    {
                        UnityEngine.GameObject self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.GameObject), "SendMessage", typeof(string), 0);
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
                        UnityEngine.GameObject self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.GameObject), "BroadcastMessage", typeof(string), 0);
                        }
                        object arg1;
                        if (!Values.js_get_var(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.GameObject), "BroadcastMessage", typeof(object), 1);
                        }
                        UnityEngine.SendMessageOptions arg2;
                        if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.GameObject), "BroadcastMessage", typeof(UnityEngine.SendMessageOptions), 2);
                        }
                        self.BroadcastMessage(arg0, arg1, arg2);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.SendMessageOptions)))
                        {
                            UnityEngine.GameObject self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GameObject), "BroadcastMessage", typeof(string), 0);
                            }
                            UnityEngine.SendMessageOptions arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GameObject), "BroadcastMessage", typeof(UnityEngine.SendMessageOptions), 1);
                            }
                            self.BroadcastMessage(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(object)))
                        {
                            UnityEngine.GameObject self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GameObject), "BroadcastMessage", typeof(string), 0);
                            }
                            object arg1;
                            if (!Values.js_get_var(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GameObject), "BroadcastMessage", typeof(object), 1);
                            }
                            self.BroadcastMessage(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 1)
                    {
                        UnityEngine.GameObject self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.GameObject), "BroadcastMessage", typeof(string), 0);
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
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetActive(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.GameObject self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    bool arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.GameObject), "SetActive", typeof(bool), 0);
                    }
                    self.SetActive(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetActive", argc);
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
                    UnityEngine.GameObject self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.GameObject), "CompareTag", typeof(string), 0);
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
        public static JSValue BindStatic_CreatePrimitive(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.PrimitiveType arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.GameObject), "CreatePrimitive", typeof(UnityEngine.PrimitiveType), 0);
                    }
                    var ret = UnityEngine.GameObject.CreatePrimitive(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("CreatePrimitive", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_FindWithTag(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.GameObject), "FindWithTag", typeof(string), 0);
                    }
                    var ret = UnityEngine.GameObject.FindWithTag(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("FindWithTag", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_FindGameObjectWithTag(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.GameObject), "FindGameObjectWithTag", typeof(string), 0);
                    }
                    var ret = UnityEngine.GameObject.FindGameObjectWithTag(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("FindGameObjectWithTag", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_FindGameObjectsWithTag(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.GameObject), "FindGameObjectsWithTag", typeof(string), 0);
                    }
                    var ret = UnityEngine.GameObject.FindGameObjectsWithTag(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("FindGameObjectsWithTag", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Find(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.GameObject), "Find", typeof(string), 0);
                    }
                    var ret = UnityEngine.GameObject.Find(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("Find", argc);
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
                UnityEngine.GameObject self;
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
        public static JSValue BindRead_layer(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.GameObject self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.layer;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_layer(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.GameObject self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.GameObject), "layer", typeof(int), 0);
                }
                self.layer = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_activeSelf(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.GameObject self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.activeSelf;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_activeInHierarchy(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.GameObject self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.activeInHierarchy;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_isStatic(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.GameObject self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.isStatic;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_isStatic(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.GameObject self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.GameObject), "isStatic", typeof(bool), 0);
                }
                self.isStatic = value;
                return JSApi.JS_UNDEFINED;
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
                UnityEngine.GameObject self;
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
                UnityEngine.GameObject self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.GameObject), "tag", typeof(string), 0);
                }
                self.tag = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_scene(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.GameObject self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.scene;
                return Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_sceneCullingMask(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.GameObject self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.sceneCullingMask;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
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
                UnityEngine.GameObject self;
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
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("GameObject", typeof(UnityEngine.GameObject), BindConstructor);
            cls.AddMethod(false, "GetComponent", QuickJS.Unity.GameObjectFix.Bind_GetComponent);
            cls.AddMethod(false, "GetComponentInChildren", QuickJS.Unity.GameObjectFix.Bind_GetComponentInChildren);
            cls.AddMethod(false, "GetComponentInParent", QuickJS.Unity.GameObjectFix.Bind_GetComponentInParent);
            cls.AddMethod(false, "GetComponents", QuickJS.Unity.GameObjectFix.Bind_GetComponents);
            cls.AddMethod(false, "GetComponentsInChildren", QuickJS.Unity.GameObjectFix.Bind_GetComponentsInChildren);
            cls.AddMethod(false, "GetComponentsInParent", QuickJS.Unity.GameObjectFix.Bind_GetComponentsInParent);
            cls.AddMethod(false, "TryGetComponent", Bind_TryGetComponent);
            cls.AddMethod(false, "SendMessageUpwards", Bind_SendMessageUpwards);
            cls.AddMethod(false, "SendMessage", Bind_SendMessage);
            cls.AddMethod(false, "BroadcastMessage", Bind_BroadcastMessage);
            cls.AddMethod(false, "AddComponent", QuickJS.Unity.GameObjectFix.Bind_AddComponent);
            cls.AddMethod(false, "SetActive", Bind_SetActive);
            cls.AddMethod(false, "CompareTag", Bind_CompareTag);
            cls.AddMethod(true, "CreatePrimitive", BindStatic_CreatePrimitive);
            cls.AddMethod(true, "FindWithTag", BindStatic_FindWithTag);
            cls.AddMethod(true, "FindGameObjectWithTag", BindStatic_FindGameObjectWithTag);
            cls.AddMethod(true, "FindGameObjectsWithTag", BindStatic_FindGameObjectsWithTag);
            cls.AddMethod(true, "Find", BindStatic_Find);
            cls.AddProperty(false, "transform", BindRead_transform, null);
            cls.AddProperty(false, "layer", BindRead_layer, BindWrite_layer);
            cls.AddProperty(false, "activeSelf", BindRead_activeSelf, null);
            cls.AddProperty(false, "activeInHierarchy", BindRead_activeInHierarchy, null);
            cls.AddProperty(false, "isStatic", BindRead_isStatic, BindWrite_isStatic);
            cls.AddProperty(false, "tag", BindRead_tag, BindWrite_tag);
            cls.AddProperty(false, "scene", BindRead_scene, null);
            cls.AddProperty(false, "sceneCullingMask", BindRead_sceneCullingMask, null);
            cls.AddProperty(false, "gameObject", BindRead_gameObject, null);
            return cls;
        }
    }
}
#endif
