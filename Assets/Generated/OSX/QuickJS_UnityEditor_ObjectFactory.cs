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
    // Type: UnityEditor.ObjectFactory
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_ObjectFactory
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CreateInstance(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    System.Type arg0;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ObjectFactory), "CreateInstance", typeof(System.Type), 0);
                    }
                    var ret = UnityEditor.ObjectFactory.CreateInstance(arg0);
                    return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("CreateInstance", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_AddComponent(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.GameObject arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ObjectFactory), "AddComponent", typeof(UnityEngine.GameObject), 0);
                    }
                    System.Type arg1;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.ObjectFactory), "AddComponent", typeof(System.Type), 1);
                    }
                    var ret = UnityEditor.ObjectFactory.AddComponent(arg0, arg1);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("AddComponent", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CreateGameObject(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.SceneManagement.Scene)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.HideFlags)) && Values.js_match_type(ctx, argv[2], typeof(string)) && Values.js_match_param_types(ctx, 3, argv, typeof(System.Type)))
                        {
                            UnityEngine.SceneManagement.Scene arg0;
                            if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.ObjectFactory), "CreateGameObject", typeof(UnityEngine.SceneManagement.Scene), 0);
                            }
                            UnityEngine.HideFlags arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.ObjectFactory), "CreateGameObject", typeof(UnityEngine.HideFlags), 1);
                            }
                            string arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.ObjectFactory), "CreateGameObject", typeof(string), 2);
                            }
                            System.Type[] arg3 = null;
                            if (argc - 3 > 0)
                            {
                                arg3 = new System.Type[argc - 3];
                                for (var i = 3; i < argc; i++)
                                {
                                    QuickJS.Binding.Values.js_get_classvalue(ctx, argv[i], out arg3[i - 3]);
                                }
                            }
                            var ret = UnityEditor.ObjectFactory.CreateGameObject(arg0, arg1, arg2, arg3);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                    if (argc >= 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_param_types(ctx, 1, argv, typeof(System.Type)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.ObjectFactory), "CreateGameObject", typeof(string), 0);
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
                            var ret = UnityEditor.ObjectFactory.CreateGameObject(arg0, arg1);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("CreateGameObject", argc);
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
                        throw new ParameterException(typeof(UnityEditor.ObjectFactory), "CreatePrimitive", typeof(UnityEngine.PrimitiveType), 0);
                    }
                    var ret = UnityEditor.ObjectFactory.CreatePrimitive(arg0);
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
        public static JSValue BindStaticEvent_componentWasAdded(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                System.Action<UnityEngine.Component> value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.ObjectFactory), "componentWasAdded", typeof(System.Action<UnityEngine.Component>), 1);
                        }
                        UnityEditor.ObjectFactory.componentWasAdded += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.ObjectFactory), "componentWasAdded", typeof(System.Action<UnityEngine.Component>), 1);
                        }
                        UnityEditor.ObjectFactory.componentWasAdded -= value;
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
            var cls = register.CreateClass("ObjectFactory", typeof(UnityEditor.ObjectFactory), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "CreateInstance", BindStatic_CreateInstance);
            cls.AddMethod(true, "AddComponent", BindStatic_AddComponent);
            cls.AddMethod(true, "CreateGameObject", BindStatic_CreateGameObject);
            cls.AddMethod(true, "CreatePrimitive", BindStatic_CreatePrimitive);
            cls.AddMethod(true, "componentWasAdded", BindStaticEvent_componentWasAdded);
            return cls;
        }
    }
}
#endif
#endif
