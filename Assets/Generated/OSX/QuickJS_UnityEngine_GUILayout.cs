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
    // Assembly: UnityEngine.IMGUIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Applications/Unity/Hub/Editor/2021.3.37f1/Unity.app/Contents/Managed/UnityEngine/UnityEngine.IMGUIModule.dll
    // Type: UnityEngine.GUILayout
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_GUILayout
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Label(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Texture)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.Texture arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Label", typeof(UnityEngine.Texture), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Label", typeof(UnityEngine.GUIStyle), 1);
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
                            UnityEngine.GUILayout.Label(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Label", typeof(string), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Label", typeof(UnityEngine.GUIStyle), 1);
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
                            UnityEngine.GUILayout.Label(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Label", typeof(UnityEngine.GUIContent), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Label", typeof(UnityEngine.GUIStyle), 1);
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
                            UnityEngine.GUILayout.Label(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc >= 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Texture)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.Texture arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Label", typeof(UnityEngine.Texture), 0);
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
                            UnityEngine.GUILayout.Label(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Label", typeof(string), 0);
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
                            UnityEngine.GUILayout.Label(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Label", typeof(UnityEngine.GUIContent), 0);
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
                            UnityEngine.GUILayout.Label(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("Label", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Box(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Texture)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.Texture arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Box", typeof(UnityEngine.Texture), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Box", typeof(UnityEngine.GUIStyle), 1);
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
                            UnityEngine.GUILayout.Box(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Box", typeof(string), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Box", typeof(UnityEngine.GUIStyle), 1);
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
                            UnityEngine.GUILayout.Box(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Box", typeof(UnityEngine.GUIContent), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Box", typeof(UnityEngine.GUIStyle), 1);
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
                            UnityEngine.GUILayout.Box(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc >= 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Texture)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.Texture arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Box", typeof(UnityEngine.Texture), 0);
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
                            UnityEngine.GUILayout.Box(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Box", typeof(string), 0);
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
                            UnityEngine.GUILayout.Box(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Box", typeof(UnityEngine.GUIContent), 0);
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
                            UnityEngine.GUILayout.Box(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("Box", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Button(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Texture)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.Texture arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Button", typeof(UnityEngine.Texture), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Button", typeof(UnityEngine.GUIStyle), 1);
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
                            var ret = UnityEngine.GUILayout.Button(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Button", typeof(string), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Button", typeof(UnityEngine.GUIStyle), 1);
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
                            var ret = UnityEngine.GUILayout.Button(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Button", typeof(UnityEngine.GUIContent), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Button", typeof(UnityEngine.GUIStyle), 1);
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
                            var ret = UnityEngine.GUILayout.Button(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc >= 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Texture)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.Texture arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Button", typeof(UnityEngine.Texture), 0);
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
                            var ret = UnityEngine.GUILayout.Button(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Button", typeof(string), 0);
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
                            var ret = UnityEngine.GUILayout.Button(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Button", typeof(UnityEngine.GUIContent), 0);
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
                            var ret = UnityEngine.GUILayout.Button(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("Button", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RepeatButton(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Texture)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.Texture arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "RepeatButton", typeof(UnityEngine.Texture), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "RepeatButton", typeof(UnityEngine.GUIStyle), 1);
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
                            var ret = UnityEngine.GUILayout.RepeatButton(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "RepeatButton", typeof(string), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "RepeatButton", typeof(UnityEngine.GUIStyle), 1);
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
                            var ret = UnityEngine.GUILayout.RepeatButton(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "RepeatButton", typeof(UnityEngine.GUIContent), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "RepeatButton", typeof(UnityEngine.GUIStyle), 1);
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
                            var ret = UnityEngine.GUILayout.RepeatButton(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc >= 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Texture)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.Texture arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "RepeatButton", typeof(UnityEngine.Texture), 0);
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
                            var ret = UnityEngine.GUILayout.RepeatButton(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "RepeatButton", typeof(string), 0);
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
                            var ret = UnityEngine.GUILayout.RepeatButton(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "RepeatButton", typeof(UnityEngine.GUIContent), 0);
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
                            var ret = UnityEngine.GUILayout.RepeatButton(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("RepeatButton", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_TextField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "TextField", typeof(string), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "TextField", typeof(int), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "TextField", typeof(UnityEngine.GUIStyle), 2);
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
                            var ret = UnityEngine.GUILayout.TextField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "TextField", typeof(string), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "TextField", typeof(int), 1);
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
                            var ret = UnityEngine.GUILayout.TextField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "TextField", typeof(string), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "TextField", typeof(UnityEngine.GUIStyle), 1);
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
                            var ret = UnityEngine.GUILayout.TextField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc >= 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "TextField", typeof(string), 0);
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
                            var ret = UnityEngine.GUILayout.TextField(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("TextField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_PasswordField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(char)) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 4, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "PasswordField", typeof(string), 0);
                            }
                            char arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "PasswordField", typeof(char), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "PasswordField", typeof(int), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "PasswordField", typeof(UnityEngine.GUIStyle), 3);
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
                            var ret = UnityEngine.GUILayout.PasswordField(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc >= 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(char)) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "PasswordField", typeof(string), 0);
                            }
                            char arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "PasswordField", typeof(char), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "PasswordField", typeof(int), 2);
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
                            var ret = UnityEngine.GUILayout.PasswordField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(char)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "PasswordField", typeof(string), 0);
                            }
                            char arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "PasswordField", typeof(char), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "PasswordField", typeof(UnityEngine.GUIStyle), 2);
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
                            var ret = UnityEngine.GUILayout.PasswordField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(char)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "PasswordField", typeof(string), 0);
                            }
                            char arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "PasswordField", typeof(char), 1);
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
                            var ret = UnityEngine.GUILayout.PasswordField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("PasswordField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_TextArea(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "TextArea", typeof(string), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "TextArea", typeof(int), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "TextArea", typeof(UnityEngine.GUIStyle), 2);
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
                            var ret = UnityEngine.GUILayout.TextArea(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "TextArea", typeof(string), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "TextArea", typeof(int), 1);
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
                            var ret = UnityEngine.GUILayout.TextArea(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "TextArea", typeof(string), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "TextArea", typeof(UnityEngine.GUIStyle), 1);
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
                            var ret = UnityEngine.GUILayout.TextArea(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc >= 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "TextArea", typeof(string), 0);
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
                            var ret = UnityEngine.GUILayout.TextArea(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("TextArea", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Toggle(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(bool)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Texture)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            bool arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toggle", typeof(bool), 0);
                            }
                            UnityEngine.Texture arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toggle", typeof(UnityEngine.Texture), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toggle", typeof(UnityEngine.GUIStyle), 2);
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
                            var ret = UnityEngine.GUILayout.Toggle(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(bool)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            bool arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toggle", typeof(bool), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toggle", typeof(string), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toggle", typeof(UnityEngine.GUIStyle), 2);
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
                            var ret = UnityEngine.GUILayout.Toggle(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(bool)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            bool arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toggle", typeof(bool), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toggle", typeof(UnityEngine.GUIContent), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toggle", typeof(UnityEngine.GUIStyle), 2);
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
                            var ret = UnityEngine.GUILayout.Toggle(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(bool)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Texture)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            bool arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toggle", typeof(bool), 0);
                            }
                            UnityEngine.Texture arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toggle", typeof(UnityEngine.Texture), 1);
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
                            var ret = UnityEngine.GUILayout.Toggle(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(bool)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            bool arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toggle", typeof(bool), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toggle", typeof(string), 1);
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
                            var ret = UnityEngine.GUILayout.Toggle(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(bool)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            bool arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toggle", typeof(bool), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toggle", typeof(UnityEngine.GUIContent), 1);
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
                            var ret = UnityEngine.GUILayout.Toggle(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("Toggle", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Toolbar(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 5)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent[])) && Values.js_match_type(ctx, argv[2], typeof(bool[])) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.GUI.ToolbarButtonSize)) && Values.js_match_param_types(ctx, 5, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toolbar", typeof(int), 0);
                            }
                            UnityEngine.GUIContent[] arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toolbar", typeof(UnityEngine.GUIContent[]), 1);
                            }
                            bool[] arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toolbar", typeof(bool[]), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toolbar", typeof(UnityEngine.GUIStyle), 3);
                            }
                            UnityEngine.GUI.ToolbarButtonSize arg4;
                            if (!Values.js_get_enumvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toolbar", typeof(UnityEngine.GUI.ToolbarButtonSize), 4);
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
                            var ret = UnityEngine.GUILayout.Toolbar(arg0, arg1, arg2, arg3, arg4, arg5);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc >= 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(string[])) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUI.ToolbarButtonSize)) && Values.js_match_param_types(ctx, 4, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toolbar", typeof(int), 0);
                            }
                            string[] arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toolbar", typeof(string[]), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toolbar", typeof(UnityEngine.GUIStyle), 2);
                            }
                            UnityEngine.GUI.ToolbarButtonSize arg3;
                            if (!Values.js_get_enumvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toolbar", typeof(UnityEngine.GUI.ToolbarButtonSize), 3);
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
                            var ret = UnityEngine.GUILayout.Toolbar(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Texture[])) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUI.ToolbarButtonSize)) && Values.js_match_param_types(ctx, 4, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toolbar", typeof(int), 0);
                            }
                            UnityEngine.Texture[] arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toolbar", typeof(UnityEngine.Texture[]), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toolbar", typeof(UnityEngine.GUIStyle), 2);
                            }
                            UnityEngine.GUI.ToolbarButtonSize arg3;
                            if (!Values.js_get_enumvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toolbar", typeof(UnityEngine.GUI.ToolbarButtonSize), 3);
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
                            var ret = UnityEngine.GUILayout.Toolbar(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent[])) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUI.ToolbarButtonSize)) && Values.js_match_param_types(ctx, 4, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toolbar", typeof(int), 0);
                            }
                            UnityEngine.GUIContent[] arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toolbar", typeof(UnityEngine.GUIContent[]), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toolbar", typeof(UnityEngine.GUIStyle), 2);
                            }
                            UnityEngine.GUI.ToolbarButtonSize arg3;
                            if (!Values.js_get_enumvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toolbar", typeof(UnityEngine.GUI.ToolbarButtonSize), 3);
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
                            var ret = UnityEngine.GUILayout.Toolbar(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent[])) && Values.js_match_type(ctx, argv[2], typeof(bool[])) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 4, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toolbar", typeof(int), 0);
                            }
                            UnityEngine.GUIContent[] arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toolbar", typeof(UnityEngine.GUIContent[]), 1);
                            }
                            bool[] arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toolbar", typeof(bool[]), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toolbar", typeof(UnityEngine.GUIStyle), 3);
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
                            var ret = UnityEngine.GUILayout.Toolbar(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc >= 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(string[])) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toolbar", typeof(int), 0);
                            }
                            string[] arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toolbar", typeof(string[]), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toolbar", typeof(UnityEngine.GUIStyle), 2);
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
                            var ret = UnityEngine.GUILayout.Toolbar(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Texture[])) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toolbar", typeof(int), 0);
                            }
                            UnityEngine.Texture[] arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toolbar", typeof(UnityEngine.Texture[]), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toolbar", typeof(UnityEngine.GUIStyle), 2);
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
                            var ret = UnityEngine.GUILayout.Toolbar(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent[])) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toolbar", typeof(int), 0);
                            }
                            UnityEngine.GUIContent[] arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toolbar", typeof(UnityEngine.GUIContent[]), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toolbar", typeof(UnityEngine.GUIStyle), 2);
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
                            var ret = UnityEngine.GUILayout.Toolbar(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(string[])) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toolbar", typeof(int), 0);
                            }
                            string[] arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toolbar", typeof(string[]), 1);
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
                            var ret = UnityEngine.GUILayout.Toolbar(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Texture[])) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toolbar", typeof(int), 0);
                            }
                            UnityEngine.Texture[] arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toolbar", typeof(UnityEngine.Texture[]), 1);
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
                            var ret = UnityEngine.GUILayout.Toolbar(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent[])) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toolbar", typeof(int), 0);
                            }
                            UnityEngine.GUIContent[] arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Toolbar", typeof(UnityEngine.GUIContent[]), 1);
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
                            var ret = UnityEngine.GUILayout.Toolbar(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("Toolbar", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SelectionGrid(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(string[])) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 4, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "SelectionGrid", typeof(int), 0);
                            }
                            string[] arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "SelectionGrid", typeof(string[]), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "SelectionGrid", typeof(int), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "SelectionGrid", typeof(UnityEngine.GUIStyle), 3);
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
                            var ret = UnityEngine.GUILayout.SelectionGrid(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Texture[])) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 4, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "SelectionGrid", typeof(int), 0);
                            }
                            UnityEngine.Texture[] arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "SelectionGrid", typeof(UnityEngine.Texture[]), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "SelectionGrid", typeof(int), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "SelectionGrid", typeof(UnityEngine.GUIStyle), 3);
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
                            var ret = UnityEngine.GUILayout.SelectionGrid(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent[])) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 4, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "SelectionGrid", typeof(int), 0);
                            }
                            UnityEngine.GUIContent[] arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "SelectionGrid", typeof(UnityEngine.GUIContent[]), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "SelectionGrid", typeof(int), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "SelectionGrid", typeof(UnityEngine.GUIStyle), 3);
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
                            var ret = UnityEngine.GUILayout.SelectionGrid(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc >= 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(string[])) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "SelectionGrid", typeof(int), 0);
                            }
                            string[] arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "SelectionGrid", typeof(string[]), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "SelectionGrid", typeof(int), 2);
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
                            var ret = UnityEngine.GUILayout.SelectionGrid(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Texture[])) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "SelectionGrid", typeof(int), 0);
                            }
                            UnityEngine.Texture[] arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "SelectionGrid", typeof(UnityEngine.Texture[]), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "SelectionGrid", typeof(int), 2);
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
                            var ret = UnityEngine.GUILayout.SelectionGrid(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent[])) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "SelectionGrid", typeof(int), 0);
                            }
                            UnityEngine.GUIContent[] arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "SelectionGrid", typeof(UnityEngine.GUIContent[]), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "SelectionGrid", typeof(int), 2);
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
                            var ret = UnityEngine.GUILayout.SelectionGrid(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("SelectionGrid", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_HorizontalSlider(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 5)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(float)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 5, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            float arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "HorizontalSlider", typeof(float), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "HorizontalSlider", typeof(float), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "HorizontalSlider", typeof(float), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "HorizontalSlider", typeof(UnityEngine.GUIStyle), 3);
                            }
                            UnityEngine.GUIStyle arg4;
                            if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "HorizontalSlider", typeof(UnityEngine.GUIStyle), 4);
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
                            var ret = UnityEngine.GUILayout.HorizontalSlider(arg0, arg1, arg2, arg3, arg4, arg5);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc >= 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(float)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            float arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "HorizontalSlider", typeof(float), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "HorizontalSlider", typeof(float), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "HorizontalSlider", typeof(float), 2);
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
                            var ret = UnityEngine.GUILayout.HorizontalSlider(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("HorizontalSlider", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_VerticalSlider(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 5)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(float)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 5, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            float arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "VerticalSlider", typeof(float), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "VerticalSlider", typeof(float), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "VerticalSlider", typeof(float), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "VerticalSlider", typeof(UnityEngine.GUIStyle), 3);
                            }
                            UnityEngine.GUIStyle arg4;
                            if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "VerticalSlider", typeof(UnityEngine.GUIStyle), 4);
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
                            var ret = UnityEngine.GUILayout.VerticalSlider(arg0, arg1, arg2, arg3, arg4, arg5);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc >= 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(float)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            float arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "VerticalSlider", typeof(float), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "VerticalSlider", typeof(float), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "VerticalSlider", typeof(float), 2);
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
                            var ret = UnityEngine.GUILayout.VerticalSlider(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("VerticalSlider", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_HorizontalScrollbar(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 5)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(float)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(float)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 5, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            float arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "HorizontalScrollbar", typeof(float), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "HorizontalScrollbar", typeof(float), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "HorizontalScrollbar", typeof(float), 2);
                            }
                            float arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "HorizontalScrollbar", typeof(float), 3);
                            }
                            UnityEngine.GUIStyle arg4;
                            if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "HorizontalScrollbar", typeof(UnityEngine.GUIStyle), 4);
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
                            var ret = UnityEngine.GUILayout.HorizontalScrollbar(arg0, arg1, arg2, arg3, arg4, arg5);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc >= 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(float)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(float)) && Values.js_match_param_types(ctx, 4, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            float arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "HorizontalScrollbar", typeof(float), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "HorizontalScrollbar", typeof(float), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "HorizontalScrollbar", typeof(float), 2);
                            }
                            float arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "HorizontalScrollbar", typeof(float), 3);
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
                            var ret = UnityEngine.GUILayout.HorizontalScrollbar(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("HorizontalScrollbar", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_VerticalScrollbar(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 5)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(float)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(float)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 5, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            float arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "VerticalScrollbar", typeof(float), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "VerticalScrollbar", typeof(float), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "VerticalScrollbar", typeof(float), 2);
                            }
                            float arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "VerticalScrollbar", typeof(float), 3);
                            }
                            UnityEngine.GUIStyle arg4;
                            if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "VerticalScrollbar", typeof(UnityEngine.GUIStyle), 4);
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
                            var ret = UnityEngine.GUILayout.VerticalScrollbar(arg0, arg1, arg2, arg3, arg4, arg5);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc >= 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(float)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(float)) && Values.js_match_param_types(ctx, 4, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            float arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "VerticalScrollbar", typeof(float), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "VerticalScrollbar", typeof(float), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "VerticalScrollbar", typeof(float), 2);
                            }
                            float arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "VerticalScrollbar", typeof(float), 3);
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
                            var ret = UnityEngine.GUILayout.VerticalScrollbar(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("VerticalScrollbar", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Space(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    float arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUILayout), "Space", typeof(float), 0);
                    }
                    UnityEngine.GUILayout.Space(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Space", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_FlexibleSpace(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.GUILayout.FlexibleSpace();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("FlexibleSpace", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_BeginHorizontal(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginHorizontal", typeof(string), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginHorizontal", typeof(UnityEngine.GUIStyle), 1);
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
                            UnityEngine.GUILayout.BeginHorizontal(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Texture)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.Texture arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginHorizontal", typeof(UnityEngine.Texture), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginHorizontal", typeof(UnityEngine.GUIStyle), 1);
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
                            UnityEngine.GUILayout.BeginHorizontal(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginHorizontal", typeof(UnityEngine.GUIContent), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginHorizontal", typeof(UnityEngine.GUIStyle), 1);
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
                            UnityEngine.GUILayout.BeginHorizontal(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc >= 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIStyle arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginHorizontal", typeof(UnityEngine.GUIStyle), 0);
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
                            UnityEngine.GUILayout.BeginHorizontal(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (Values.js_match_param_types(ctx, 0, argv, typeof(UnityEngine.GUILayoutOption)))
                    {
                        UnityEngine.GUILayoutOption[] arg0 = null;
                        if (argc > 0)
                        {
                            arg0 = new UnityEngine.GUILayoutOption[argc];
                            for (var i = 0; i < argc; i++)
                            {
                                Values.js_get_classvalue(ctx, argv[i], out arg0[i]);
                            }
                        }
                        UnityEngine.GUILayout.BeginHorizontal(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("BeginHorizontal", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_EndHorizontal(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.GUILayout.EndHorizontal();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("EndHorizontal", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_BeginVertical(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginVertical", typeof(string), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginVertical", typeof(UnityEngine.GUIStyle), 1);
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
                            UnityEngine.GUILayout.BeginVertical(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Texture)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.Texture arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginVertical", typeof(UnityEngine.Texture), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginVertical", typeof(UnityEngine.GUIStyle), 1);
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
                            UnityEngine.GUILayout.BeginVertical(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginVertical", typeof(UnityEngine.GUIContent), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginVertical", typeof(UnityEngine.GUIStyle), 1);
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
                            UnityEngine.GUILayout.BeginVertical(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc >= 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIStyle arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginVertical", typeof(UnityEngine.GUIStyle), 0);
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
                            UnityEngine.GUILayout.BeginVertical(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (Values.js_match_param_types(ctx, 0, argv, typeof(UnityEngine.GUILayoutOption)))
                    {
                        UnityEngine.GUILayoutOption[] arg0 = null;
                        if (argc > 0)
                        {
                            arg0 = new UnityEngine.GUILayoutOption[argc];
                            for (var i = 0; i < argc; i++)
                            {
                                Values.js_get_classvalue(ctx, argv[i], out arg0[i]);
                            }
                        }
                        UnityEngine.GUILayout.BeginVertical(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("BeginVertical", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_EndVertical(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.GUILayout.EndVertical();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("EndVertical", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_BeginArea(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginArea", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginArea", typeof(string), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginArea", typeof(UnityEngine.GUIStyle), 2);
                            }
                            UnityEngine.GUILayout.BeginArea(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Texture)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginArea", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.Texture arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginArea", typeof(UnityEngine.Texture), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginArea", typeof(UnityEngine.GUIStyle), 2);
                            }
                            UnityEngine.GUILayout.BeginArea(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginArea", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginArea", typeof(UnityEngine.GUIContent), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginArea", typeof(UnityEngine.GUIStyle), 2);
                            }
                            UnityEngine.GUILayout.BeginArea(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginArea", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginArea", typeof(string), 1);
                            }
                            UnityEngine.GUILayout.BeginArea(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Texture)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginArea", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.Texture arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginArea", typeof(UnityEngine.Texture), 1);
                            }
                            UnityEngine.GUILayout.BeginArea(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginArea", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginArea", typeof(UnityEngine.GUIContent), 1);
                            }
                            UnityEngine.GUILayout.BeginArea(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginArea", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginArea", typeof(UnityEngine.GUIStyle), 1);
                            }
                            UnityEngine.GUILayout.BeginArea(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 1)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginArea", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.GUILayout.BeginArea(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("BeginArea", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_EndArea(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.GUILayout.EndArea();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("EndArea", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_BeginScrollView(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 6)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector2)) && Values.js_match_type(ctx, argv[1], typeof(bool)) && Values.js_match_type(ctx, argv[2], typeof(bool)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.GUIStyle)) && Values.js_match_type(ctx, argv[5], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 6, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.Vector2 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginScrollView", typeof(UnityEngine.Vector2), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginScrollView", typeof(bool), 1);
                            }
                            bool arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginScrollView", typeof(bool), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginScrollView", typeof(UnityEngine.GUIStyle), 3);
                            }
                            UnityEngine.GUIStyle arg4;
                            if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginScrollView", typeof(UnityEngine.GUIStyle), 4);
                            }
                            UnityEngine.GUIStyle arg5;
                            if (!Values.js_get_classvalue(ctx, argv[5], out arg5))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginScrollView", typeof(UnityEngine.GUIStyle), 5);
                            }
                            UnityEngine.GUILayoutOption[] arg6 = null;
                            if (argc - 6 > 0)
                            {
                                arg6 = new UnityEngine.GUILayoutOption[argc - 6];
                                for (var i = 6; i < argc; i++)
                                {
                                    Values.js_get_classvalue(ctx, argv[i], out arg6[i - 6]);
                                }
                            }
                            var ret = UnityEngine.GUILayout.BeginScrollView(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                    if (argc >= 5)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector2)) && Values.js_match_type(ctx, argv[1], typeof(bool)) && Values.js_match_type(ctx, argv[2], typeof(bool)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 5, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.Vector2 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginScrollView", typeof(UnityEngine.Vector2), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginScrollView", typeof(bool), 1);
                            }
                            bool arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginScrollView", typeof(bool), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginScrollView", typeof(UnityEngine.GUIStyle), 3);
                            }
                            UnityEngine.GUIStyle arg4;
                            if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginScrollView", typeof(UnityEngine.GUIStyle), 4);
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
                            var ret = UnityEngine.GUILayout.BeginScrollView(arg0, arg1, arg2, arg3, arg4, arg5);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                    if (argc >= 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector2)) && Values.js_match_type(ctx, argv[1], typeof(bool)) && Values.js_match_type(ctx, argv[2], typeof(bool)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.Vector2 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginScrollView", typeof(UnityEngine.Vector2), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginScrollView", typeof(bool), 1);
                            }
                            bool arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginScrollView", typeof(bool), 2);
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
                            var ret = UnityEngine.GUILayout.BeginScrollView(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector2)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.Vector2 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginScrollView", typeof(UnityEngine.Vector2), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginScrollView", typeof(UnityEngine.GUIStyle), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginScrollView", typeof(UnityEngine.GUIStyle), 2);
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
                            var ret = UnityEngine.GUILayout.BeginScrollView(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                    if (argc >= 2)
                    {
                        if (argc == 2)
                        {
                            if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector2)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)))
                            {
                                UnityEngine.Vector2 arg0;
                                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                                {
                                    throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginScrollView", typeof(UnityEngine.Vector2), 0);
                                }
                                UnityEngine.GUIStyle arg1;
                                if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                                {
                                    throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginScrollView", typeof(UnityEngine.GUIStyle), 1);
                                }
                                var ret = UnityEngine.GUILayout.BeginScrollView(arg0, arg1);
                                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                            }
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector2)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.Vector2 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginScrollView", typeof(UnityEngine.Vector2), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginScrollView", typeof(UnityEngine.GUIStyle), 1);
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
                            var ret = UnityEngine.GUILayout.BeginScrollView(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                    if (argc >= 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector2)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.Vector2 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "BeginScrollView", typeof(UnityEngine.Vector2), 0);
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
                            var ret = UnityEngine.GUILayout.BeginScrollView(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("BeginScrollView", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_EndScrollView(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.GUILayout.EndScrollView();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("EndScrollView", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Window(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 5)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUI.WindowFunction)) && Values.js_match_type(ctx, argv[3], typeof(string)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 5, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Window", typeof(int), 0);
                            }
                            UnityEngine.Rect arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Window", typeof(UnityEngine.Rect), 1);
                            }
                            UnityEngine.GUI.WindowFunction arg2;
                            if (!Values.js_get_delegate(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Window", typeof(UnityEngine.GUI.WindowFunction), 2);
                            }
                            string arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Window", typeof(string), 3);
                            }
                            UnityEngine.GUIStyle arg4;
                            if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Window", typeof(UnityEngine.GUIStyle), 4);
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
                            var ret = UnityEngine.GUILayout.Window(arg0, arg1, arg2, arg3, arg4, arg5);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUI.WindowFunction)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.Texture)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 5, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Window", typeof(int), 0);
                            }
                            UnityEngine.Rect arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Window", typeof(UnityEngine.Rect), 1);
                            }
                            UnityEngine.GUI.WindowFunction arg2;
                            if (!Values.js_get_delegate(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Window", typeof(UnityEngine.GUI.WindowFunction), 2);
                            }
                            UnityEngine.Texture arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Window", typeof(UnityEngine.Texture), 3);
                            }
                            UnityEngine.GUIStyle arg4;
                            if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Window", typeof(UnityEngine.GUIStyle), 4);
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
                            var ret = UnityEngine.GUILayout.Window(arg0, arg1, arg2, arg3, arg4, arg5);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUI.WindowFunction)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 5, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Window", typeof(int), 0);
                            }
                            UnityEngine.Rect arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Window", typeof(UnityEngine.Rect), 1);
                            }
                            UnityEngine.GUI.WindowFunction arg2;
                            if (!Values.js_get_delegate(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Window", typeof(UnityEngine.GUI.WindowFunction), 2);
                            }
                            UnityEngine.GUIContent arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Window", typeof(UnityEngine.GUIContent), 3);
                            }
                            UnityEngine.GUIStyle arg4;
                            if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Window", typeof(UnityEngine.GUIStyle), 4);
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
                            var ret = UnityEngine.GUILayout.Window(arg0, arg1, arg2, arg3, arg4, arg5);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                    if (argc >= 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUI.WindowFunction)) && Values.js_match_type(ctx, argv[3], typeof(string)) && Values.js_match_param_types(ctx, 4, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Window", typeof(int), 0);
                            }
                            UnityEngine.Rect arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Window", typeof(UnityEngine.Rect), 1);
                            }
                            UnityEngine.GUI.WindowFunction arg2;
                            if (!Values.js_get_delegate(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Window", typeof(UnityEngine.GUI.WindowFunction), 2);
                            }
                            string arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Window", typeof(string), 3);
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
                            var ret = UnityEngine.GUILayout.Window(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUI.WindowFunction)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.Texture)) && Values.js_match_param_types(ctx, 4, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Window", typeof(int), 0);
                            }
                            UnityEngine.Rect arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Window", typeof(UnityEngine.Rect), 1);
                            }
                            UnityEngine.GUI.WindowFunction arg2;
                            if (!Values.js_get_delegate(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Window", typeof(UnityEngine.GUI.WindowFunction), 2);
                            }
                            UnityEngine.Texture arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Window", typeof(UnityEngine.Texture), 3);
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
                            var ret = UnityEngine.GUILayout.Window(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUI.WindowFunction)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIContent)) && Values.js_match_param_types(ctx, 4, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Window", typeof(int), 0);
                            }
                            UnityEngine.Rect arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Window", typeof(UnityEngine.Rect), 1);
                            }
                            UnityEngine.GUI.WindowFunction arg2;
                            if (!Values.js_get_delegate(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Window", typeof(UnityEngine.GUI.WindowFunction), 2);
                            }
                            UnityEngine.GUIContent arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUILayout), "Window", typeof(UnityEngine.GUIContent), 3);
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
                            var ret = UnityEngine.GUILayout.Window(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("Window", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Width(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    float arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUILayout), "Width", typeof(float), 0);
                    }
                    var ret = UnityEngine.GUILayout.Width(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("Width", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_MinWidth(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    float arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUILayout), "MinWidth", typeof(float), 0);
                    }
                    var ret = UnityEngine.GUILayout.MinWidth(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("MinWidth", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_MaxWidth(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    float arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUILayout), "MaxWidth", typeof(float), 0);
                    }
                    var ret = UnityEngine.GUILayout.MaxWidth(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("MaxWidth", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Height(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    float arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUILayout), "Height", typeof(float), 0);
                    }
                    var ret = UnityEngine.GUILayout.Height(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("Height", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_MinHeight(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    float arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUILayout), "MinHeight", typeof(float), 0);
                    }
                    var ret = UnityEngine.GUILayout.MinHeight(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("MinHeight", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_MaxHeight(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    float arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUILayout), "MaxHeight", typeof(float), 0);
                    }
                    var ret = UnityEngine.GUILayout.MaxHeight(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("MaxHeight", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ExpandWidth(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    bool arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUILayout), "ExpandWidth", typeof(bool), 0);
                    }
                    var ret = UnityEngine.GUILayout.ExpandWidth(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("ExpandWidth", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ExpandHeight(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    bool arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUILayout), "ExpandHeight", typeof(bool), 0);
                    }
                    var ret = UnityEngine.GUILayout.ExpandHeight(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("ExpandHeight", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("GUILayout", typeof(UnityEngine.GUILayout), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "Label", BindStatic_Label);
            cls.AddMethod(true, "Box", BindStatic_Box);
            cls.AddMethod(true, "Button", BindStatic_Button);
            cls.AddMethod(true, "RepeatButton", BindStatic_RepeatButton);
            cls.AddMethod(true, "TextField", BindStatic_TextField);
            cls.AddMethod(true, "PasswordField", BindStatic_PasswordField);
            cls.AddMethod(true, "TextArea", BindStatic_TextArea);
            cls.AddMethod(true, "Toggle", BindStatic_Toggle);
            cls.AddMethod(true, "Toolbar", BindStatic_Toolbar);
            cls.AddMethod(true, "SelectionGrid", BindStatic_SelectionGrid);
            cls.AddMethod(true, "HorizontalSlider", BindStatic_HorizontalSlider);
            cls.AddMethod(true, "VerticalSlider", BindStatic_VerticalSlider);
            cls.AddMethod(true, "HorizontalScrollbar", BindStatic_HorizontalScrollbar);
            cls.AddMethod(true, "VerticalScrollbar", BindStatic_VerticalScrollbar);
            cls.AddMethod(true, "Space", BindStatic_Space);
            cls.AddMethod(true, "FlexibleSpace", BindStatic_FlexibleSpace);
            cls.AddMethod(true, "BeginHorizontal", BindStatic_BeginHorizontal);
            cls.AddMethod(true, "EndHorizontal", BindStatic_EndHorizontal);
            cls.AddMethod(true, "BeginVertical", BindStatic_BeginVertical);
            cls.AddMethod(true, "EndVertical", BindStatic_EndVertical);
            cls.AddMethod(true, "BeginArea", BindStatic_BeginArea);
            cls.AddMethod(true, "EndArea", BindStatic_EndArea);
            cls.AddMethod(true, "BeginScrollView", BindStatic_BeginScrollView);
            cls.AddMethod(true, "EndScrollView", BindStatic_EndScrollView);
            cls.AddMethod(true, "Window", BindStatic_Window);
            cls.AddMethod(true, "Width", BindStatic_Width);
            cls.AddMethod(true, "MinWidth", BindStatic_MinWidth);
            cls.AddMethod(true, "MaxWidth", BindStatic_MaxWidth);
            cls.AddMethod(true, "Height", BindStatic_Height);
            cls.AddMethod(true, "MinHeight", BindStatic_MinHeight);
            cls.AddMethod(true, "MaxHeight", BindStatic_MaxHeight);
            cls.AddMethod(true, "ExpandWidth", BindStatic_ExpandWidth);
            cls.AddMethod(true, "ExpandHeight", BindStatic_ExpandHeight);
            return cls;
        }
    }
}
#endif
