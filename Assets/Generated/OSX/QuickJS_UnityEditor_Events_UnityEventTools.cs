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
    // Type: UnityEditor.Events.UnityEventTools
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_Events_UnityEventTools
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_AddPersistentListener(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        UnityEngine.Events.UnityEvent arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.Events.UnityEventTools), "AddPersistentListener", typeof(UnityEngine.Events.UnityEvent), 0);
                        }
                        UnityEngine.Events.UnityAction arg1;
                        if (!Values.js_get_delegate(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.Events.UnityEventTools), "AddPersistentListener", typeof(UnityEngine.Events.UnityAction), 1);
                        }
                        UnityEditor.Events.UnityEventTools.AddPersistentListener(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 1)
                    {
                        UnityEngine.Events.UnityEventBase arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.Events.UnityEventTools), "AddPersistentListener", typeof(UnityEngine.Events.UnityEventBase), 0);
                        }
                        UnityEditor.Events.UnityEventTools.AddPersistentListener(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("AddPersistentListener", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RemovePersistentListener(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Events.UnityEventBase)) && Values.js_match_type(ctx, argv[1], typeof(int)))
                        {
                            UnityEngine.Events.UnityEventBase arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.Events.UnityEventTools), "RemovePersistentListener", typeof(UnityEngine.Events.UnityEventBase), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.Events.UnityEventTools), "RemovePersistentListener", typeof(int), 1);
                            }
                            UnityEditor.Events.UnityEventTools.RemovePersistentListener(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Events.UnityEventBase)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Events.UnityAction)))
                        {
                            UnityEngine.Events.UnityEventBase arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.Events.UnityEventTools), "RemovePersistentListener", typeof(UnityEngine.Events.UnityEventBase), 0);
                            }
                            UnityEngine.Events.UnityAction arg1;
                            if (!Values.js_get_delegate(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.Events.UnityEventTools), "RemovePersistentListener", typeof(UnityEngine.Events.UnityAction), 1);
                            }
                            UnityEditor.Events.UnityEventTools.RemovePersistentListener(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("RemovePersistentListener", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RegisterPersistentListener(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Events.UnityEvent arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Events.UnityEventTools), "RegisterPersistentListener", typeof(UnityEngine.Events.UnityEvent), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Events.UnityEventTools), "RegisterPersistentListener", typeof(int), 1);
                    }
                    UnityEngine.Events.UnityAction arg2;
                    if (!Values.js_get_delegate(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.Events.UnityEventTools), "RegisterPersistentListener", typeof(UnityEngine.Events.UnityAction), 2);
                    }
                    UnityEditor.Events.UnityEventTools.RegisterPersistentListener(arg0, arg1, arg2);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RegisterPersistentListener", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_UnregisterPersistentListener(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Events.UnityEventBase arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Events.UnityEventTools), "UnregisterPersistentListener", typeof(UnityEngine.Events.UnityEventBase), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Events.UnityEventTools), "UnregisterPersistentListener", typeof(int), 1);
                    }
                    UnityEditor.Events.UnityEventTools.UnregisterPersistentListener(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("UnregisterPersistentListener", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_AddVoidPersistentListener(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Events.UnityEventBase arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Events.UnityEventTools), "AddVoidPersistentListener", typeof(UnityEngine.Events.UnityEventBase), 0);
                    }
                    UnityEngine.Events.UnityAction arg1;
                    if (!Values.js_get_delegate(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Events.UnityEventTools), "AddVoidPersistentListener", typeof(UnityEngine.Events.UnityAction), 1);
                    }
                    UnityEditor.Events.UnityEventTools.AddVoidPersistentListener(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("AddVoidPersistentListener", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RegisterVoidPersistentListener(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Events.UnityEventBase arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Events.UnityEventTools), "RegisterVoidPersistentListener", typeof(UnityEngine.Events.UnityEventBase), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Events.UnityEventTools), "RegisterVoidPersistentListener", typeof(int), 1);
                    }
                    UnityEngine.Events.UnityAction arg2;
                    if (!Values.js_get_delegate(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.Events.UnityEventTools), "RegisterVoidPersistentListener", typeof(UnityEngine.Events.UnityAction), 2);
                    }
                    UnityEditor.Events.UnityEventTools.RegisterVoidPersistentListener(arg0, arg1, arg2);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RegisterVoidPersistentListener", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_AddIntPersistentListener(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Events.UnityEventBase arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Events.UnityEventTools), "AddIntPersistentListener", typeof(UnityEngine.Events.UnityEventBase), 0);
                    }
                    UnityEngine.Events.UnityAction<int> arg1;
                    if (!Values.js_get_delegate(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Events.UnityEventTools), "AddIntPersistentListener", typeof(UnityEngine.Events.UnityAction<int>), 1);
                    }
                    int arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.Events.UnityEventTools), "AddIntPersistentListener", typeof(int), 2);
                    }
                    UnityEditor.Events.UnityEventTools.AddIntPersistentListener(arg0, arg1, arg2);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("AddIntPersistentListener", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RegisterIntPersistentListener(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 4)
                {
                    UnityEngine.Events.UnityEventBase arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Events.UnityEventTools), "RegisterIntPersistentListener", typeof(UnityEngine.Events.UnityEventBase), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Events.UnityEventTools), "RegisterIntPersistentListener", typeof(int), 1);
                    }
                    UnityEngine.Events.UnityAction<int> arg2;
                    if (!Values.js_get_delegate(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.Events.UnityEventTools), "RegisterIntPersistentListener", typeof(UnityEngine.Events.UnityAction<int>), 2);
                    }
                    int arg3;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.Events.UnityEventTools), "RegisterIntPersistentListener", typeof(int), 3);
                    }
                    UnityEditor.Events.UnityEventTools.RegisterIntPersistentListener(arg0, arg1, arg2, arg3);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RegisterIntPersistentListener", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_AddFloatPersistentListener(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Events.UnityEventBase arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Events.UnityEventTools), "AddFloatPersistentListener", typeof(UnityEngine.Events.UnityEventBase), 0);
                    }
                    UnityEngine.Events.UnityAction<float> arg1;
                    if (!Values.js_get_delegate(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Events.UnityEventTools), "AddFloatPersistentListener", typeof(UnityEngine.Events.UnityAction<float>), 1);
                    }
                    float arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.Events.UnityEventTools), "AddFloatPersistentListener", typeof(float), 2);
                    }
                    UnityEditor.Events.UnityEventTools.AddFloatPersistentListener(arg0, arg1, arg2);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("AddFloatPersistentListener", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RegisterFloatPersistentListener(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 4)
                {
                    UnityEngine.Events.UnityEventBase arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Events.UnityEventTools), "RegisterFloatPersistentListener", typeof(UnityEngine.Events.UnityEventBase), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Events.UnityEventTools), "RegisterFloatPersistentListener", typeof(int), 1);
                    }
                    UnityEngine.Events.UnityAction<float> arg2;
                    if (!Values.js_get_delegate(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.Events.UnityEventTools), "RegisterFloatPersistentListener", typeof(UnityEngine.Events.UnityAction<float>), 2);
                    }
                    float arg3;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.Events.UnityEventTools), "RegisterFloatPersistentListener", typeof(float), 3);
                    }
                    UnityEditor.Events.UnityEventTools.RegisterFloatPersistentListener(arg0, arg1, arg2, arg3);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RegisterFloatPersistentListener", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_AddBoolPersistentListener(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Events.UnityEventBase arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Events.UnityEventTools), "AddBoolPersistentListener", typeof(UnityEngine.Events.UnityEventBase), 0);
                    }
                    UnityEngine.Events.UnityAction<bool> arg1;
                    if (!Values.js_get_delegate(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Events.UnityEventTools), "AddBoolPersistentListener", typeof(UnityEngine.Events.UnityAction<bool>), 1);
                    }
                    bool arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.Events.UnityEventTools), "AddBoolPersistentListener", typeof(bool), 2);
                    }
                    UnityEditor.Events.UnityEventTools.AddBoolPersistentListener(arg0, arg1, arg2);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("AddBoolPersistentListener", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RegisterBoolPersistentListener(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 4)
                {
                    UnityEngine.Events.UnityEventBase arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Events.UnityEventTools), "RegisterBoolPersistentListener", typeof(UnityEngine.Events.UnityEventBase), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Events.UnityEventTools), "RegisterBoolPersistentListener", typeof(int), 1);
                    }
                    UnityEngine.Events.UnityAction<bool> arg2;
                    if (!Values.js_get_delegate(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.Events.UnityEventTools), "RegisterBoolPersistentListener", typeof(UnityEngine.Events.UnityAction<bool>), 2);
                    }
                    bool arg3;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.Events.UnityEventTools), "RegisterBoolPersistentListener", typeof(bool), 3);
                    }
                    UnityEditor.Events.UnityEventTools.RegisterBoolPersistentListener(arg0, arg1, arg2, arg3);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RegisterBoolPersistentListener", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_AddStringPersistentListener(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Events.UnityEventBase arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Events.UnityEventTools), "AddStringPersistentListener", typeof(UnityEngine.Events.UnityEventBase), 0);
                    }
                    UnityEngine.Events.UnityAction<string> arg1;
                    if (!Values.js_get_delegate(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Events.UnityEventTools), "AddStringPersistentListener", typeof(UnityEngine.Events.UnityAction<string>), 1);
                    }
                    string arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.Events.UnityEventTools), "AddStringPersistentListener", typeof(string), 2);
                    }
                    UnityEditor.Events.UnityEventTools.AddStringPersistentListener(arg0, arg1, arg2);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("AddStringPersistentListener", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RegisterStringPersistentListener(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 4)
                {
                    UnityEngine.Events.UnityEventBase arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Events.UnityEventTools), "RegisterStringPersistentListener", typeof(UnityEngine.Events.UnityEventBase), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Events.UnityEventTools), "RegisterStringPersistentListener", typeof(int), 1);
                    }
                    UnityEngine.Events.UnityAction<string> arg2;
                    if (!Values.js_get_delegate(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.Events.UnityEventTools), "RegisterStringPersistentListener", typeof(UnityEngine.Events.UnityAction<string>), 2);
                    }
                    string arg3;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.Events.UnityEventTools), "RegisterStringPersistentListener", typeof(string), 3);
                    }
                    UnityEditor.Events.UnityEventTools.RegisterStringPersistentListener(arg0, arg1, arg2, arg3);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RegisterStringPersistentListener", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("UnityEventTools", typeof(UnityEditor.Events.UnityEventTools), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "AddPersistentListener", BindStatic_AddPersistentListener);
            cls.AddMethod(true, "RemovePersistentListener", BindStatic_RemovePersistentListener);
            cls.AddMethod(true, "RegisterPersistentListener", BindStatic_RegisterPersistentListener);
            cls.AddMethod(true, "UnregisterPersistentListener", BindStatic_UnregisterPersistentListener);
            cls.AddMethod(true, "AddVoidPersistentListener", BindStatic_AddVoidPersistentListener);
            cls.AddMethod(true, "RegisterVoidPersistentListener", BindStatic_RegisterVoidPersistentListener);
            cls.AddMethod(true, "AddIntPersistentListener", BindStatic_AddIntPersistentListener);
            cls.AddMethod(true, "RegisterIntPersistentListener", BindStatic_RegisterIntPersistentListener);
            cls.AddMethod(true, "AddFloatPersistentListener", BindStatic_AddFloatPersistentListener);
            cls.AddMethod(true, "RegisterFloatPersistentListener", BindStatic_RegisterFloatPersistentListener);
            cls.AddMethod(true, "AddBoolPersistentListener", BindStatic_AddBoolPersistentListener);
            cls.AddMethod(true, "RegisterBoolPersistentListener", BindStatic_RegisterBoolPersistentListener);
            cls.AddMethod(true, "AddStringPersistentListener", BindStatic_AddStringPersistentListener);
            cls.AddMethod(true, "RegisterStringPersistentListener", BindStatic_RegisterStringPersistentListener);
            return cls;
        }
    }
}
#endif
#endif
