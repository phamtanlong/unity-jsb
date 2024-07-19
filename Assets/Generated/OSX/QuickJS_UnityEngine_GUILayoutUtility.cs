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
    // Assembly: UnityEngine.IMGUIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Applications/Unity/Hub/Editor/2019.4.40f1/Unity.app/Contents/Managed/UnityEngine/UnityEngine.IMGUIModule.dll
    // Type: UnityEngine.GUILayoutUtility
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_GUILayoutUtility
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetRect(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 5)
                    {
                        if (argc == 5)
                        {
                            if (Values.js_match_type(ctx, argv[0], typeof(float)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(float)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.GUIStyle)))
                            {
                                float arg0;
                                if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                                {
                                    throw new ParameterException(typeof(UnityEngine.GUILayoutUtility), "GetRect", typeof(float), 0);
                                }
                                float arg1;
                                if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                                {
                                    throw new ParameterException(typeof(UnityEngine.GUILayoutUtility), "GetRect", typeof(float), 1);
                                }
                                float arg2;
                                if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                                {
                                    throw new ParameterException(typeof(UnityEngine.GUILayoutUtility), "GetRect", typeof(float), 2);
                                }
                                float arg3;
                                if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                                {
                                    throw new ParameterException(typeof(UnityEngine.GUILayoutUtility), "GetRect", typeof(float), 3);
                                }
                                UnityEngine.GUIStyle arg4;
                                if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                                {
                                    throw new ParameterException(typeof(UnityEngine.GUILayoutUtility), "GetRect", typeof(UnityEngine.GUIStyle), 4);
                                }
                                var ret = UnityEngine.GUILayoutUtility.GetRect(arg0, arg1, arg2, arg3, arg4);
                                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                            }
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(float)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(float)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 5, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            float arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayoutUtility), "GetRect", typeof(float), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayoutUtility), "GetRect", typeof(float), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayoutUtility), "GetRect", typeof(float), 2);
                            }
                            float arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayoutUtility), "GetRect", typeof(float), 3);
                            }
                            UnityEngine.GUIStyle arg4;
                            if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayoutUtility), "GetRect", typeof(UnityEngine.GUIStyle), 4);
                            }
                            UnityEngine.GUILayoutOption[] arg5 = null;
                            if (argc - 5 > 0)
                            {
                                arg5 = new UnityEngine.GUILayoutOption[argc - 5];
                                for (var i = 5; i < argc; i++)
                                {
                                    Values.js_get_classvalue(ctx, argv[i], out arg5[i - 5]);
                                }
                            }
                            var ret = UnityEngine.GUILayoutUtility.GetRect(arg0, arg1, arg2, arg3, arg4, arg5);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                    if (argc >= 4)
                    {
                        if (argc == 4)
                        {
                            if (Values.js_match_type(ctx, argv[0], typeof(float)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(float)))
                            {
                                float arg0;
                                if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                                {
                                    throw new ParameterException(typeof(UnityEngine.GUILayoutUtility), "GetRect", typeof(float), 0);
                                }
                                float arg1;
                                if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                                {
                                    throw new ParameterException(typeof(UnityEngine.GUILayoutUtility), "GetRect", typeof(float), 1);
                                }
                                float arg2;
                                if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                                {
                                    throw new ParameterException(typeof(UnityEngine.GUILayoutUtility), "GetRect", typeof(float), 2);
                                }
                                float arg3;
                                if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                                {
                                    throw new ParameterException(typeof(UnityEngine.GUILayoutUtility), "GetRect", typeof(float), 3);
                                }
                                var ret = UnityEngine.GUILayoutUtility.GetRect(arg0, arg1, arg2, arg3);
                                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                            }
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(float)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(float)) && Values.js_match_param_types(ctx, 4, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            float arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayoutUtility), "GetRect", typeof(float), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayoutUtility), "GetRect", typeof(float), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayoutUtility), "GetRect", typeof(float), 2);
                            }
                            float arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayoutUtility), "GetRect", typeof(float), 3);
                            }
                            UnityEngine.GUILayoutOption[] arg4 = null;
                            if (argc - 4 > 0)
                            {
                                arg4 = new UnityEngine.GUILayoutOption[argc - 4];
                                for (var i = 4; i < argc; i++)
                                {
                                    Values.js_get_classvalue(ctx, argv[i], out arg4[i - 4]);
                                }
                            }
                            var ret = UnityEngine.GUILayoutUtility.GetRect(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                    if (argc >= 3)
                    {
                        if (argc == 3)
                        {
                            if (Values.js_match_type(ctx, argv[0], typeof(float)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)))
                            {
                                float arg0;
                                if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                                {
                                    throw new ParameterException(typeof(UnityEngine.GUILayoutUtility), "GetRect", typeof(float), 0);
                                }
                                float arg1;
                                if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                                {
                                    throw new ParameterException(typeof(UnityEngine.GUILayoutUtility), "GetRect", typeof(float), 1);
                                }
                                UnityEngine.GUIStyle arg2;
                                if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                                {
                                    throw new ParameterException(typeof(UnityEngine.GUILayoutUtility), "GetRect", typeof(UnityEngine.GUIStyle), 2);
                                }
                                var ret = UnityEngine.GUILayoutUtility.GetRect(arg0, arg1, arg2);
                                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                            }
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(float)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            float arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayoutUtility), "GetRect", typeof(float), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayoutUtility), "GetRect", typeof(float), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayoutUtility), "GetRect", typeof(UnityEngine.GUIStyle), 2);
                            }
                            UnityEngine.GUILayoutOption[] arg3 = null;
                            if (argc - 3 > 0)
                            {
                                arg3 = new UnityEngine.GUILayoutOption[argc - 3];
                                for (var i = 3; i < argc; i++)
                                {
                                    Values.js_get_classvalue(ctx, argv[i], out arg3[i - 3]);
                                }
                            }
                            var ret = UnityEngine.GUILayoutUtility.GetRect(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                    if (argc >= 2)
                    {
                        if (argc == 2)
                        {
                            if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)))
                            {
                                UnityEngine.GUIContent arg0;
                                if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                                {
                                    throw new ParameterException(typeof(UnityEngine.GUILayoutUtility), "GetRect", typeof(UnityEngine.GUIContent), 0);
                                }
                                UnityEngine.GUIStyle arg1;
                                if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                                {
                                    throw new ParameterException(typeof(UnityEngine.GUILayoutUtility), "GetRect", typeof(UnityEngine.GUIStyle), 1);
                                }
                                var ret = UnityEngine.GUILayoutUtility.GetRect(arg0, arg1);
                                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                            }
                            if (Values.js_match_type(ctx, argv[0], typeof(float)) && Values.js_match_type(ctx, argv[1], typeof(float)))
                            {
                                float arg0;
                                if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                                {
                                    throw new ParameterException(typeof(UnityEngine.GUILayoutUtility), "GetRect", typeof(float), 0);
                                }
                                float arg1;
                                if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                                {
                                    throw new ParameterException(typeof(UnityEngine.GUILayoutUtility), "GetRect", typeof(float), 1);
                                }
                                var ret = UnityEngine.GUILayoutUtility.GetRect(arg0, arg1);
                                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                            }
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayoutUtility), "GetRect", typeof(UnityEngine.GUIContent), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayoutUtility), "GetRect", typeof(UnityEngine.GUIStyle), 1);
                            }
                            UnityEngine.GUILayoutOption[] arg2 = null;
                            if (argc - 2 > 0)
                            {
                                arg2 = new UnityEngine.GUILayoutOption[argc - 2];
                                for (var i = 2; i < argc; i++)
                                {
                                    Values.js_get_classvalue(ctx, argv[i], out arg2[i - 2]);
                                }
                            }
                            var ret = UnityEngine.GUILayoutUtility.GetRect(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(float)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            float arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayoutUtility), "GetRect", typeof(float), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayoutUtility), "GetRect", typeof(float), 1);
                            }
                            UnityEngine.GUILayoutOption[] arg2 = null;
                            if (argc - 2 > 0)
                            {
                                arg2 = new UnityEngine.GUILayoutOption[argc - 2];
                                for (var i = 2; i < argc; i++)
                                {
                                    Values.js_get_classvalue(ctx, argv[i], out arg2[i - 2]);
                                }
                            }
                            var ret = UnityEngine.GUILayoutUtility.GetRect(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("GetRect", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetLastRect(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEngine.GUILayoutUtility.GetLastRect();
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetLastRect", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetAspectRect(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 2)
                    {
                        if (argc == 2)
                        {
                            if (Values.js_match_type(ctx, argv[0], typeof(float)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)))
                            {
                                float arg0;
                                if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                                {
                                    throw new ParameterException(typeof(UnityEngine.GUILayoutUtility), "GetAspectRect", typeof(float), 0);
                                }
                                UnityEngine.GUIStyle arg1;
                                if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                                {
                                    throw new ParameterException(typeof(UnityEngine.GUILayoutUtility), "GetAspectRect", typeof(UnityEngine.GUIStyle), 1);
                                }
                                var ret = UnityEngine.GUILayoutUtility.GetAspectRect(arg0, arg1);
                                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                            }
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(float)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            float arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayoutUtility), "GetAspectRect", typeof(float), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayoutUtility), "GetAspectRect", typeof(UnityEngine.GUIStyle), 1);
                            }
                            UnityEngine.GUILayoutOption[] arg2 = null;
                            if (argc - 2 > 0)
                            {
                                arg2 = new UnityEngine.GUILayoutOption[argc - 2];
                                for (var i = 2; i < argc; i++)
                                {
                                    Values.js_get_classvalue(ctx, argv[i], out arg2[i - 2]);
                                }
                            }
                            var ret = UnityEngine.GUILayoutUtility.GetAspectRect(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                    if (argc >= 1)
                    {
                        if (argc == 1)
                        {
                            if (Values.js_match_type(ctx, argv[0], typeof(float)))
                            {
                                float arg0;
                                if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                                {
                                    throw new ParameterException(typeof(UnityEngine.GUILayoutUtility), "GetAspectRect", typeof(float), 0);
                                }
                                var ret = UnityEngine.GUILayoutUtility.GetAspectRect(arg0);
                                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                            }
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(float)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            float arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayoutUtility), "GetAspectRect", typeof(float), 0);
                            }
                            UnityEngine.GUILayoutOption[] arg1 = null;
                            if (argc - 1 > 0)
                            {
                                arg1 = new UnityEngine.GUILayoutOption[argc - 1];
                                for (var i = 1; i < argc; i++)
                                {
                                    Values.js_get_classvalue(ctx, argv[i], out arg1[i - 1]);
                                }
                            }
                            var ret = UnityEngine.GUILayoutUtility.GetAspectRect(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("GetAspectRect", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("GUILayoutUtility", typeof(UnityEngine.GUILayoutUtility), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "GetRect", BindStatic_GetRect);
            cls.AddMethod(true, "GetLastRect", BindStatic_GetLastRect);
            cls.AddMethod(true, "GetAspectRect", BindStatic_GetAspectRect);
            return cls;
        }
    }
}
#endif
