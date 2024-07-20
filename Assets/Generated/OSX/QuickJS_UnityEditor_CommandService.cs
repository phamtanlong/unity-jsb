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
    // Type: UnityEditor.CommandService
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_CommandService
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetCommandLabel(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.CommandService), "GetCommandLabel", typeof(string), 0);
                    }
                    var ret = UnityEditor.CommandService.GetCommandLabel(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetCommandLabel", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RegisterCommand(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.CommandService), "RegisterCommand", typeof(string), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.CommandService), "RegisterCommand", typeof(string), 1);
                        }
                        UnityEditor.CommandHandler arg2;
                        if (!Values.js_get_delegate(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.CommandService), "RegisterCommand", typeof(UnityEditor.CommandHandler), 2);
                        }
                        UnityEditor.CommandHint arg3;
                        if (!Values.js_get_enumvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.CommandService), "RegisterCommand", typeof(UnityEditor.CommandHint), 3);
                        }
                        UnityEditor.CommandService.RegisterCommand(arg0, arg1, arg2, arg3);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 3)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.CommandService), "RegisterCommand", typeof(string), 0);
                        }
                        UnityEditor.CommandHandler arg1;
                        if (!Values.js_get_delegate(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.CommandService), "RegisterCommand", typeof(UnityEditor.CommandHandler), 1);
                        }
                        UnityEditor.CommandHint arg2;
                        if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.CommandService), "RegisterCommand", typeof(UnityEditor.CommandHint), 2);
                        }
                        UnityEditor.CommandService.RegisterCommand(arg0, arg1, arg2);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("RegisterCommand", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_UnregisterCommand(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.CommandService), "UnregisterCommand", typeof(string), 0);
                    }
                    var ret = UnityEditor.CommandService.UnregisterCommand(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("UnregisterCommand", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Exists(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.CommandService), "Exists", typeof(string), 0);
                    }
                    var ret = UnityEditor.CommandService.Exists(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("Exists", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Execute(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 2)
                    {
                        if (argc == 2)
                        {
                            if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.CommandHint)))
                            {
                                string arg0;
                                if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                                {
                                    throw new ParameterException(typeof(UnityEditor.CommandService), "Execute", typeof(string), 0);
                                }
                                UnityEditor.CommandHint arg1;
                                if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                                {
                                    throw new ParameterException(typeof(UnityEditor.CommandService), "Execute", typeof(UnityEditor.CommandHint), 1);
                                }
                                var ret = UnityEditor.CommandService.Execute(arg0, arg1);
                                return QuickJS.Binding.Values.js_push_object(ctx, ret);
                            }
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.CommandHint)) && Values.js_match_param_types(ctx, 2, argv, typeof(object)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.CommandService), "Execute", typeof(string), 0);
                            }
                            UnityEditor.CommandHint arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.CommandService), "Execute", typeof(UnityEditor.CommandHint), 1);
                            }
                            object[] arg2 = null;
                            if (argc - 2 > 0)
                            {
                                arg2 = new object[argc - 2];
                                for (var i = 2; i < argc; i++)
                                {
                                    Values.js_get_var(ctx, argv[i], out arg2[i - 2]);
                                }
                            }
                            var ret = UnityEditor.CommandService.Execute(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_object(ctx, ret);
                        }
                    }
                    if (argc == 1)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.CommandService), "Execute", typeof(string), 0);
                        }
                        var ret = UnityEditor.CommandService.Execute(arg0);
                        return QuickJS.Binding.Values.js_push_object(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("Execute", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("CommandService", typeof(UnityEditor.CommandService), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "GetCommandLabel", BindStatic_GetCommandLabel);
            cls.AddMethod(true, "RegisterCommand", BindStatic_RegisterCommand);
            cls.AddMethod(true, "UnregisterCommand", BindStatic_UnregisterCommand);
            cls.AddMethod(true, "Exists", BindStatic_Exists);
            cls.AddMethod(true, "Execute", BindStatic_Execute);
            return cls;
        }
    }
}
#endif
#endif
