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
    // Type: UnityEditor.EditorGUILayout
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_EditorGUILayout
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Foldout(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(bool)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(bool)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)))
                        {
                            bool arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Foldout", typeof(bool), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Foldout", typeof(string), 1);
                            }
                            bool arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Foldout", typeof(bool), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Foldout", typeof(UnityEngine.GUIStyle), 3);
                            }
                            var ret = UnityEditor.EditorGUILayout.Foldout(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(bool)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(bool)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)))
                        {
                            bool arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Foldout", typeof(bool), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Foldout", typeof(UnityEngine.GUIContent), 1);
                            }
                            bool arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Foldout", typeof(bool), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Foldout", typeof(UnityEngine.GUIStyle), 3);
                            }
                            var ret = UnityEditor.EditorGUILayout.Foldout(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(bool)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)))
                        {
                            bool arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Foldout", typeof(bool), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Foldout", typeof(string), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Foldout", typeof(UnityEngine.GUIStyle), 2);
                            }
                            var ret = UnityEditor.EditorGUILayout.Foldout(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(bool)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)))
                        {
                            bool arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Foldout", typeof(bool), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Foldout", typeof(UnityEngine.GUIContent), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Foldout", typeof(UnityEngine.GUIStyle), 2);
                            }
                            var ret = UnityEditor.EditorGUILayout.Foldout(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(bool)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(bool)))
                        {
                            bool arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Foldout", typeof(bool), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Foldout", typeof(string), 1);
                            }
                            bool arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Foldout", typeof(bool), 2);
                            }
                            var ret = UnityEditor.EditorGUILayout.Foldout(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(bool)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(bool)))
                        {
                            bool arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Foldout", typeof(bool), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Foldout", typeof(UnityEngine.GUIContent), 1);
                            }
                            bool arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Foldout", typeof(bool), 2);
                            }
                            var ret = UnityEditor.EditorGUILayout.Foldout(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(bool)) && Values.js_match_type(ctx, argv[1], typeof(string)))
                        {
                            bool arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Foldout", typeof(bool), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Foldout", typeof(string), 1);
                            }
                            var ret = UnityEditor.EditorGUILayout.Foldout(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(bool)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)))
                        {
                            bool arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Foldout", typeof(bool), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Foldout", typeof(UnityEngine.GUIContent), 1);
                            }
                            var ret = UnityEditor.EditorGUILayout.Foldout(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("Foldout", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_PrefixLabel(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "PrefixLabel", typeof(string), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "PrefixLabel", typeof(UnityEngine.GUIStyle), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "PrefixLabel", typeof(UnityEngine.GUIStyle), 2);
                            }
                            UnityEditor.EditorGUILayout.PrefixLabel(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "PrefixLabel", typeof(UnityEngine.GUIContent), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "PrefixLabel", typeof(UnityEngine.GUIStyle), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "PrefixLabel", typeof(UnityEngine.GUIStyle), 2);
                            }
                            UnityEditor.EditorGUILayout.PrefixLabel(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "PrefixLabel", typeof(string), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "PrefixLabel", typeof(UnityEngine.GUIStyle), 1);
                            }
                            UnityEditor.EditorGUILayout.PrefixLabel(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "PrefixLabel", typeof(UnityEngine.GUIContent), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "PrefixLabel", typeof(UnityEngine.GUIStyle), 1);
                            }
                            UnityEditor.EditorGUILayout.PrefixLabel(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "PrefixLabel", typeof(string), 0);
                            }
                            UnityEditor.EditorGUILayout.PrefixLabel(arg0);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "PrefixLabel", typeof(UnityEngine.GUIContent), 0);
                            }
                            UnityEditor.EditorGUILayout.PrefixLabel(arg0);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("PrefixLabel", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_LabelField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "LabelField", typeof(string), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "LabelField", typeof(string), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "LabelField", typeof(UnityEngine.GUIStyle), 2);
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
                            UnityEditor.EditorGUILayout.LabelField(arg0, arg1, arg2, arg3);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "LabelField", typeof(UnityEngine.GUIContent), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "LabelField", typeof(UnityEngine.GUIContent), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "LabelField", typeof(UnityEngine.GUIStyle), 2);
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
                            UnityEditor.EditorGUILayout.LabelField(arg0, arg1, arg2, arg3);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "LabelField", typeof(string), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "LabelField", typeof(UnityEngine.GUIStyle), 1);
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
                            UnityEditor.EditorGUILayout.LabelField(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "LabelField", typeof(UnityEngine.GUIContent), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "LabelField", typeof(UnityEngine.GUIStyle), 1);
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
                            UnityEditor.EditorGUILayout.LabelField(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "LabelField", typeof(string), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "LabelField", typeof(string), 1);
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
                            UnityEditor.EditorGUILayout.LabelField(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "LabelField", typeof(UnityEngine.GUIContent), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "LabelField", typeof(UnityEngine.GUIContent), 1);
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
                            UnityEditor.EditorGUILayout.LabelField(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc >= 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "LabelField", typeof(string), 0);
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
                            UnityEditor.EditorGUILayout.LabelField(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "LabelField", typeof(UnityEngine.GUIContent), 0);
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
                            UnityEditor.EditorGUILayout.LabelField(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("LabelField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_LinkButton(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "LinkButton", typeof(string), 0);
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
                            var ret = UnityEditor.EditorGUILayout.LinkButton(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "LinkButton", typeof(UnityEngine.GUIContent), 0);
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
                            var ret = UnityEditor.EditorGUILayout.LinkButton(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("LinkButton", argc);
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
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(bool)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Toggle", typeof(string), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Toggle", typeof(bool), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Toggle", typeof(UnityEngine.GUIStyle), 2);
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
                            var ret = UnityEditor.EditorGUILayout.Toggle(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(bool)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Toggle", typeof(UnityEngine.GUIContent), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Toggle", typeof(bool), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Toggle", typeof(UnityEngine.GUIStyle), 2);
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
                            var ret = UnityEditor.EditorGUILayout.Toggle(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(bool)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Toggle", typeof(string), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Toggle", typeof(bool), 1);
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
                            var ret = UnityEditor.EditorGUILayout.Toggle(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(bool)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Toggle", typeof(UnityEngine.GUIContent), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Toggle", typeof(bool), 1);
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
                            var ret = UnityEditor.EditorGUILayout.Toggle(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(bool)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            bool arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Toggle", typeof(bool), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Toggle", typeof(UnityEngine.GUIStyle), 1);
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
                            var ret = UnityEditor.EditorGUILayout.Toggle(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc >= 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(bool)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            bool arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Toggle", typeof(bool), 0);
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
                            var ret = UnityEditor.EditorGUILayout.Toggle(arg0, arg1);
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
        public static JSValue BindStatic_ToggleLeft(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(bool)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ToggleLeft", typeof(string), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ToggleLeft", typeof(bool), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ToggleLeft", typeof(UnityEngine.GUIStyle), 2);
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
                            var ret = UnityEditor.EditorGUILayout.ToggleLeft(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(bool)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ToggleLeft", typeof(UnityEngine.GUIContent), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ToggleLeft", typeof(bool), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ToggleLeft", typeof(UnityEngine.GUIStyle), 2);
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
                            var ret = UnityEditor.EditorGUILayout.ToggleLeft(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(bool)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ToggleLeft", typeof(string), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ToggleLeft", typeof(bool), 1);
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
                            var ret = UnityEditor.EditorGUILayout.ToggleLeft(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(bool)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ToggleLeft", typeof(UnityEngine.GUIContent), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ToggleLeft", typeof(bool), 1);
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
                            var ret = UnityEditor.EditorGUILayout.ToggleLeft(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("ToggleLeft", argc);
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
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "TextField", typeof(string), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "TextField", typeof(string), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "TextField", typeof(UnityEngine.GUIStyle), 2);
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
                            var ret = UnityEditor.EditorGUILayout.TextField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "TextField", typeof(UnityEngine.GUIContent), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "TextField", typeof(string), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "TextField", typeof(UnityEngine.GUIStyle), 2);
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
                            var ret = UnityEditor.EditorGUILayout.TextField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "TextField", typeof(string), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "TextField", typeof(UnityEngine.GUIStyle), 1);
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
                            var ret = UnityEditor.EditorGUILayout.TextField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "TextField", typeof(string), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "TextField", typeof(string), 1);
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
                            var ret = UnityEditor.EditorGUILayout.TextField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "TextField", typeof(UnityEngine.GUIContent), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "TextField", typeof(string), 1);
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
                            var ret = UnityEditor.EditorGUILayout.TextField(arg0, arg1, arg2);
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
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "TextField", typeof(string), 0);
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
                            var ret = UnityEditor.EditorGUILayout.TextField(arg0, arg1);
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
        public static JSValue BindStatic_DelayedTextField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedTextField", typeof(string), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedTextField", typeof(string), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedTextField", typeof(UnityEngine.GUIStyle), 2);
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
                            var ret = UnityEditor.EditorGUILayout.DelayedTextField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedTextField", typeof(UnityEngine.GUIContent), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedTextField", typeof(string), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedTextField", typeof(UnityEngine.GUIStyle), 2);
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
                            var ret = UnityEditor.EditorGUILayout.DelayedTextField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedTextField", typeof(string), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedTextField", typeof(UnityEngine.GUIStyle), 1);
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
                            var ret = UnityEditor.EditorGUILayout.DelayedTextField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedTextField", typeof(string), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedTextField", typeof(string), 1);
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
                            var ret = UnityEditor.EditorGUILayout.DelayedTextField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedTextField", typeof(UnityEngine.GUIContent), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedTextField", typeof(string), 1);
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
                            var ret = UnityEditor.EditorGUILayout.DelayedTextField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.SerializedProperty)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEditor.SerializedProperty arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedTextField", typeof(UnityEditor.SerializedProperty), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedTextField", typeof(UnityEngine.GUIContent), 1);
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
                            UnityEditor.EditorGUILayout.DelayedTextField(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc >= 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedTextField", typeof(string), 0);
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
                            var ret = UnityEditor.EditorGUILayout.DelayedTextField(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.SerializedProperty)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEditor.SerializedProperty arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedTextField", typeof(UnityEditor.SerializedProperty), 0);
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
                            UnityEditor.EditorGUILayout.DelayedTextField(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("DelayedTextField", argc);
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
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "TextArea", typeof(string), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "TextArea", typeof(UnityEngine.GUIStyle), 1);
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
                            var ret = UnityEditor.EditorGUILayout.TextArea(arg0, arg1, arg2);
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
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "TextArea", typeof(string), 0);
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
                            var ret = UnityEditor.EditorGUILayout.TextArea(arg0, arg1);
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
        public static JSValue BindStatic_SelectableLabel(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
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
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "SelectableLabel", typeof(string), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "SelectableLabel", typeof(UnityEngine.GUIStyle), 1);
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
                            UnityEditor.EditorGUILayout.SelectableLabel(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc >= 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "SelectableLabel", typeof(string), 0);
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
                            UnityEditor.EditorGUILayout.SelectableLabel(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("SelectableLabel", argc);
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
                    if (argc >= 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "PasswordField", typeof(string), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "PasswordField", typeof(string), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "PasswordField", typeof(UnityEngine.GUIStyle), 2);
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
                            var ret = UnityEditor.EditorGUILayout.PasswordField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "PasswordField", typeof(UnityEngine.GUIContent), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "PasswordField", typeof(string), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "PasswordField", typeof(UnityEngine.GUIStyle), 2);
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
                            var ret = UnityEditor.EditorGUILayout.PasswordField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "PasswordField", typeof(string), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "PasswordField", typeof(UnityEngine.GUIStyle), 1);
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
                            var ret = UnityEditor.EditorGUILayout.PasswordField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "PasswordField", typeof(string), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "PasswordField", typeof(string), 1);
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
                            var ret = UnityEditor.EditorGUILayout.PasswordField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "PasswordField", typeof(UnityEngine.GUIContent), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "PasswordField", typeof(string), 1);
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
                            var ret = UnityEditor.EditorGUILayout.PasswordField(arg0, arg1, arg2);
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
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "PasswordField", typeof(string), 0);
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
                            var ret = UnityEditor.EditorGUILayout.PasswordField(arg0, arg1);
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
        public static JSValue BindStatic_FloatField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "FloatField", typeof(string), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "FloatField", typeof(float), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "FloatField", typeof(UnityEngine.GUIStyle), 2);
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
                            var ret = UnityEditor.EditorGUILayout.FloatField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "FloatField", typeof(UnityEngine.GUIContent), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "FloatField", typeof(float), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "FloatField", typeof(UnityEngine.GUIStyle), 2);
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
                            var ret = UnityEditor.EditorGUILayout.FloatField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(float)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            float arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "FloatField", typeof(float), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "FloatField", typeof(UnityEngine.GUIStyle), 1);
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
                            var ret = UnityEditor.EditorGUILayout.FloatField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "FloatField", typeof(string), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "FloatField", typeof(float), 1);
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
                            var ret = UnityEditor.EditorGUILayout.FloatField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "FloatField", typeof(UnityEngine.GUIContent), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "FloatField", typeof(float), 1);
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
                            var ret = UnityEditor.EditorGUILayout.FloatField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc >= 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(float)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            float arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "FloatField", typeof(float), 0);
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
                            var ret = UnityEditor.EditorGUILayout.FloatField(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("FloatField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DelayedFloatField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedFloatField", typeof(string), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedFloatField", typeof(float), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedFloatField", typeof(UnityEngine.GUIStyle), 2);
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
                            var ret = UnityEditor.EditorGUILayout.DelayedFloatField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedFloatField", typeof(UnityEngine.GUIContent), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedFloatField", typeof(float), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedFloatField", typeof(UnityEngine.GUIStyle), 2);
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
                            var ret = UnityEditor.EditorGUILayout.DelayedFloatField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(float)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            float arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedFloatField", typeof(float), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedFloatField", typeof(UnityEngine.GUIStyle), 1);
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
                            var ret = UnityEditor.EditorGUILayout.DelayedFloatField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedFloatField", typeof(string), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedFloatField", typeof(float), 1);
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
                            var ret = UnityEditor.EditorGUILayout.DelayedFloatField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedFloatField", typeof(UnityEngine.GUIContent), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedFloatField", typeof(float), 1);
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
                            var ret = UnityEditor.EditorGUILayout.DelayedFloatField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.SerializedProperty)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEditor.SerializedProperty arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedFloatField", typeof(UnityEditor.SerializedProperty), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedFloatField", typeof(UnityEngine.GUIContent), 1);
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
                            UnityEditor.EditorGUILayout.DelayedFloatField(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc >= 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(float)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            float arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedFloatField", typeof(float), 0);
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
                            var ret = UnityEditor.EditorGUILayout.DelayedFloatField(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.SerializedProperty)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEditor.SerializedProperty arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedFloatField", typeof(UnityEditor.SerializedProperty), 0);
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
                            UnityEditor.EditorGUILayout.DelayedFloatField(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("DelayedFloatField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DoubleField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(double)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DoubleField", typeof(string), 0);
                            }
                            double arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DoubleField", typeof(double), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DoubleField", typeof(UnityEngine.GUIStyle), 2);
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
                            var ret = UnityEditor.EditorGUILayout.DoubleField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(double)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DoubleField", typeof(UnityEngine.GUIContent), 0);
                            }
                            double arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DoubleField", typeof(double), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DoubleField", typeof(UnityEngine.GUIStyle), 2);
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
                            var ret = UnityEditor.EditorGUILayout.DoubleField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(double)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            double arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DoubleField", typeof(double), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DoubleField", typeof(UnityEngine.GUIStyle), 1);
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
                            var ret = UnityEditor.EditorGUILayout.DoubleField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(double)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DoubleField", typeof(string), 0);
                            }
                            double arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DoubleField", typeof(double), 1);
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
                            var ret = UnityEditor.EditorGUILayout.DoubleField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(double)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DoubleField", typeof(UnityEngine.GUIContent), 0);
                            }
                            double arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DoubleField", typeof(double), 1);
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
                            var ret = UnityEditor.EditorGUILayout.DoubleField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc >= 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(double)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            double arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DoubleField", typeof(double), 0);
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
                            var ret = UnityEditor.EditorGUILayout.DoubleField(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("DoubleField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DelayedDoubleField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(double)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedDoubleField", typeof(string), 0);
                            }
                            double arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedDoubleField", typeof(double), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedDoubleField", typeof(UnityEngine.GUIStyle), 2);
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
                            var ret = UnityEditor.EditorGUILayout.DelayedDoubleField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(double)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedDoubleField", typeof(UnityEngine.GUIContent), 0);
                            }
                            double arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedDoubleField", typeof(double), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedDoubleField", typeof(UnityEngine.GUIStyle), 2);
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
                            var ret = UnityEditor.EditorGUILayout.DelayedDoubleField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(double)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            double arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedDoubleField", typeof(double), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedDoubleField", typeof(UnityEngine.GUIStyle), 1);
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
                            var ret = UnityEditor.EditorGUILayout.DelayedDoubleField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(double)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedDoubleField", typeof(string), 0);
                            }
                            double arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedDoubleField", typeof(double), 1);
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
                            var ret = UnityEditor.EditorGUILayout.DelayedDoubleField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(double)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedDoubleField", typeof(UnityEngine.GUIContent), 0);
                            }
                            double arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedDoubleField", typeof(double), 1);
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
                            var ret = UnityEditor.EditorGUILayout.DelayedDoubleField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc >= 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(double)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            double arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedDoubleField", typeof(double), 0);
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
                            var ret = UnityEditor.EditorGUILayout.DelayedDoubleField(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("DelayedDoubleField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IntField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
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
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntField", typeof(string), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntField", typeof(int), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntField", typeof(UnityEngine.GUIStyle), 2);
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
                            var ret = UnityEditor.EditorGUILayout.IntField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntField", typeof(UnityEngine.GUIContent), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntField", typeof(int), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntField", typeof(UnityEngine.GUIStyle), 2);
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
                            var ret = UnityEditor.EditorGUILayout.IntField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntField", typeof(int), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntField", typeof(UnityEngine.GUIStyle), 1);
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
                            var ret = UnityEditor.EditorGUILayout.IntField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntField", typeof(string), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntField", typeof(int), 1);
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
                            var ret = UnityEditor.EditorGUILayout.IntField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntField", typeof(UnityEngine.GUIContent), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntField", typeof(int), 1);
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
                            var ret = UnityEditor.EditorGUILayout.IntField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc >= 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntField", typeof(int), 0);
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
                            var ret = UnityEditor.EditorGUILayout.IntField(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("IntField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DelayedIntField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
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
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedIntField", typeof(string), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedIntField", typeof(int), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedIntField", typeof(UnityEngine.GUIStyle), 2);
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
                            var ret = UnityEditor.EditorGUILayout.DelayedIntField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedIntField", typeof(UnityEngine.GUIContent), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedIntField", typeof(int), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedIntField", typeof(UnityEngine.GUIStyle), 2);
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
                            var ret = UnityEditor.EditorGUILayout.DelayedIntField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedIntField", typeof(int), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedIntField", typeof(UnityEngine.GUIStyle), 1);
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
                            var ret = UnityEditor.EditorGUILayout.DelayedIntField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedIntField", typeof(string), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedIntField", typeof(int), 1);
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
                            var ret = UnityEditor.EditorGUILayout.DelayedIntField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedIntField", typeof(UnityEngine.GUIContent), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedIntField", typeof(int), 1);
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
                            var ret = UnityEditor.EditorGUILayout.DelayedIntField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.SerializedProperty)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEditor.SerializedProperty arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedIntField", typeof(UnityEditor.SerializedProperty), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedIntField", typeof(UnityEngine.GUIContent), 1);
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
                            UnityEditor.EditorGUILayout.DelayedIntField(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc >= 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedIntField", typeof(int), 0);
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
                            var ret = UnityEditor.EditorGUILayout.DelayedIntField(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.SerializedProperty)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEditor.SerializedProperty arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DelayedIntField", typeof(UnityEditor.SerializedProperty), 0);
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
                            UnityEditor.EditorGUILayout.DelayedIntField(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("DelayedIntField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_LongField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(long)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "LongField", typeof(string), 0);
                            }
                            long arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "LongField", typeof(long), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "LongField", typeof(UnityEngine.GUIStyle), 2);
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
                            var ret = UnityEditor.EditorGUILayout.LongField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(long)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "LongField", typeof(UnityEngine.GUIContent), 0);
                            }
                            long arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "LongField", typeof(long), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "LongField", typeof(UnityEngine.GUIStyle), 2);
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
                            var ret = UnityEditor.EditorGUILayout.LongField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(long)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            long arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "LongField", typeof(long), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "LongField", typeof(UnityEngine.GUIStyle), 1);
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
                            var ret = UnityEditor.EditorGUILayout.LongField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(long)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "LongField", typeof(string), 0);
                            }
                            long arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "LongField", typeof(long), 1);
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
                            var ret = UnityEditor.EditorGUILayout.LongField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(long)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "LongField", typeof(UnityEngine.GUIContent), 0);
                            }
                            long arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "LongField", typeof(long), 1);
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
                            var ret = UnityEditor.EditorGUILayout.LongField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc >= 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(long)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            long arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "LongField", typeof(long), 0);
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
                            var ret = UnityEditor.EditorGUILayout.LongField(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("LongField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Slider(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(float)) && Values.js_match_param_types(ctx, 4, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Slider", typeof(string), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Slider", typeof(float), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Slider", typeof(float), 2);
                            }
                            float arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Slider", typeof(float), 3);
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
                            var ret = UnityEditor.EditorGUILayout.Slider(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(float)) && Values.js_match_param_types(ctx, 4, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Slider", typeof(UnityEngine.GUIContent), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Slider", typeof(float), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Slider", typeof(float), 2);
                            }
                            float arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Slider", typeof(float), 3);
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
                            var ret = UnityEditor.EditorGUILayout.Slider(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.SerializedProperty)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(string)) && Values.js_match_param_types(ctx, 4, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEditor.SerializedProperty arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Slider", typeof(UnityEditor.SerializedProperty), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Slider", typeof(float), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Slider", typeof(float), 2);
                            }
                            string arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Slider", typeof(string), 3);
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
                            UnityEditor.EditorGUILayout.Slider(arg0, arg1, arg2, arg3, arg4);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.SerializedProperty)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIContent)) && Values.js_match_param_types(ctx, 4, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEditor.SerializedProperty arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Slider", typeof(UnityEditor.SerializedProperty), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Slider", typeof(float), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Slider", typeof(float), 2);
                            }
                            UnityEngine.GUIContent arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Slider", typeof(UnityEngine.GUIContent), 3);
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
                            UnityEditor.EditorGUILayout.Slider(arg0, arg1, arg2, arg3, arg4);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc >= 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(float)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            float arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Slider", typeof(float), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Slider", typeof(float), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Slider", typeof(float), 2);
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
                            var ret = UnityEditor.EditorGUILayout.Slider(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.SerializedProperty)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEditor.SerializedProperty arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Slider", typeof(UnityEditor.SerializedProperty), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Slider", typeof(float), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Slider", typeof(float), 2);
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
                            UnityEditor.EditorGUILayout.Slider(arg0, arg1, arg2, arg3);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("Slider", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IntSlider(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(int)) && Values.js_match_param_types(ctx, 4, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntSlider", typeof(string), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntSlider", typeof(int), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntSlider", typeof(int), 2);
                            }
                            int arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntSlider", typeof(int), 3);
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
                            var ret = UnityEditor.EditorGUILayout.IntSlider(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(int)) && Values.js_match_param_types(ctx, 4, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntSlider", typeof(UnityEngine.GUIContent), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntSlider", typeof(int), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntSlider", typeof(int), 2);
                            }
                            int arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntSlider", typeof(int), 3);
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
                            var ret = UnityEditor.EditorGUILayout.IntSlider(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.SerializedProperty)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(string)) && Values.js_match_param_types(ctx, 4, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEditor.SerializedProperty arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntSlider", typeof(UnityEditor.SerializedProperty), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntSlider", typeof(int), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntSlider", typeof(int), 2);
                            }
                            string arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntSlider", typeof(string), 3);
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
                            UnityEditor.EditorGUILayout.IntSlider(arg0, arg1, arg2, arg3, arg4);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.SerializedProperty)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIContent)) && Values.js_match_param_types(ctx, 4, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEditor.SerializedProperty arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntSlider", typeof(UnityEditor.SerializedProperty), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntSlider", typeof(int), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntSlider", typeof(int), 2);
                            }
                            UnityEngine.GUIContent arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntSlider", typeof(UnityEngine.GUIContent), 3);
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
                            UnityEditor.EditorGUILayout.IntSlider(arg0, arg1, arg2, arg3, arg4);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc >= 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntSlider", typeof(int), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntSlider", typeof(int), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntSlider", typeof(int), 2);
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
                            var ret = UnityEditor.EditorGUILayout.IntSlider(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.SerializedProperty)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEditor.SerializedProperty arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntSlider", typeof(UnityEditor.SerializedProperty), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntSlider", typeof(int), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntSlider", typeof(int), 2);
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
                            UnityEditor.EditorGUILayout.IntSlider(arg0, arg1, arg2, arg3);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("IntSlider", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_MinMaxSlider(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 5)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type_hint(ctx, argv[1], typeof(float)) && Values.js_match_type_hint(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(float)) && Values.js_match_type(ctx, argv[4], typeof(float)) && Values.js_match_param_types(ctx, 5, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "MinMaxSlider", typeof(string), 0);
                            }
                            float arg1;
                            var refVal1 = Values.js_read_wrap(ctx, argv[1]);
                            if (refVal1.IsException())
                            {
                                return refVal1;
                            }
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, refVal1, out arg1))
                            {
                                JSApi.JS_FreeValue(ctx, refVal1);
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "MinMaxSlider", typeof(float), 1);
                            }
                            JSApi.JS_FreeValue(ctx, refVal1);
                            float arg2;
                            var refVal2 = Values.js_read_wrap(ctx, argv[2]);
                            if (refVal2.IsException())
                            {
                                return refVal2;
                            }
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, refVal2, out arg2))
                            {
                                JSApi.JS_FreeValue(ctx, refVal2);
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "MinMaxSlider", typeof(float), 2);
                            }
                            JSApi.JS_FreeValue(ctx, refVal2);
                            float arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "MinMaxSlider", typeof(float), 3);
                            }
                            float arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "MinMaxSlider", typeof(float), 4);
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
                            UnityEditor.EditorGUILayout.MinMaxSlider(arg0, ref arg1, ref arg2, arg3, arg4, arg5);
                            var out0 = QuickJS.Binding.Values.js_push_primitive(ctx, arg1);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out0);
                            var out1 = QuickJS.Binding.Values.js_push_primitive(ctx, arg2);
                            if (JSApi.JS_IsException(out1))
                            {
                                return out1;
                            }
                            JSApi.JS_SetProperty(ctx, argv[2], context.GetAtom("value"), out1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type_hint(ctx, argv[1], typeof(float)) && Values.js_match_type_hint(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(float)) && Values.js_match_type(ctx, argv[4], typeof(float)) && Values.js_match_param_types(ctx, 5, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "MinMaxSlider", typeof(UnityEngine.GUIContent), 0);
                            }
                            float arg1;
                            var refVal1 = Values.js_read_wrap(ctx, argv[1]);
                            if (refVal1.IsException())
                            {
                                return refVal1;
                            }
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, refVal1, out arg1))
                            {
                                JSApi.JS_FreeValue(ctx, refVal1);
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "MinMaxSlider", typeof(float), 1);
                            }
                            JSApi.JS_FreeValue(ctx, refVal1);
                            float arg2;
                            var refVal2 = Values.js_read_wrap(ctx, argv[2]);
                            if (refVal2.IsException())
                            {
                                return refVal2;
                            }
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, refVal2, out arg2))
                            {
                                JSApi.JS_FreeValue(ctx, refVal2);
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "MinMaxSlider", typeof(float), 2);
                            }
                            JSApi.JS_FreeValue(ctx, refVal2);
                            float arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "MinMaxSlider", typeof(float), 3);
                            }
                            float arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "MinMaxSlider", typeof(float), 4);
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
                            UnityEditor.EditorGUILayout.MinMaxSlider(arg0, ref arg1, ref arg2, arg3, arg4, arg5);
                            var out0 = QuickJS.Binding.Values.js_push_primitive(ctx, arg1);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out0);
                            var out1 = QuickJS.Binding.Values.js_push_primitive(ctx, arg2);
                            if (JSApi.JS_IsException(out1))
                            {
                                return out1;
                            }
                            JSApi.JS_SetProperty(ctx, argv[2], context.GetAtom("value"), out1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc >= 4)
                    {
                        if (Values.js_match_type_hint(ctx, argv[0], typeof(float)) && Values.js_match_type_hint(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(float)) && Values.js_match_param_types(ctx, 4, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            float arg0;
                            var refVal0 = Values.js_read_wrap(ctx, argv[0]);
                            if (refVal0.IsException())
                            {
                                return refVal0;
                            }
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, refVal0, out arg0))
                            {
                                JSApi.JS_FreeValue(ctx, refVal0);
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "MinMaxSlider", typeof(float), 0);
                            }
                            JSApi.JS_FreeValue(ctx, refVal0);
                            float arg1;
                            var refVal1 = Values.js_read_wrap(ctx, argv[1]);
                            if (refVal1.IsException())
                            {
                                return refVal1;
                            }
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, refVal1, out arg1))
                            {
                                JSApi.JS_FreeValue(ctx, refVal1);
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "MinMaxSlider", typeof(float), 1);
                            }
                            JSApi.JS_FreeValue(ctx, refVal1);
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "MinMaxSlider", typeof(float), 2);
                            }
                            float arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "MinMaxSlider", typeof(float), 3);
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
                            UnityEditor.EditorGUILayout.MinMaxSlider(ref arg0, ref arg1, arg2, arg3, arg4);
                            var out0 = QuickJS.Binding.Values.js_push_primitive(ctx, arg0);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[0], context.GetAtom("value"), out0);
                            var out1 = QuickJS.Binding.Values.js_push_primitive(ctx, arg1);
                            if (JSApi.JS_IsException(out1))
                            {
                                return out1;
                            }
                            JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("MinMaxSlider", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Popup(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(string[])) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 4, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Popup", typeof(string), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Popup", typeof(int), 1);
                            }
                            string[] arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Popup", typeof(string[]), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Popup", typeof(UnityEngine.GUIStyle), 3);
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
                            var ret = UnityEditor.EditorGUILayout.Popup(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIContent[])) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 4, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Popup", typeof(UnityEngine.GUIContent), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Popup", typeof(int), 1);
                            }
                            UnityEngine.GUIContent[] arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Popup", typeof(UnityEngine.GUIContent[]), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Popup", typeof(UnityEngine.GUIStyle), 3);
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
                            var ret = UnityEditor.EditorGUILayout.Popup(arg0, arg1, arg2, arg3, arg4);
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
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Popup", typeof(int), 0);
                            }
                            string[] arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Popup", typeof(string[]), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Popup", typeof(UnityEngine.GUIStyle), 2);
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
                            var ret = UnityEditor.EditorGUILayout.Popup(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent[])) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Popup", typeof(int), 0);
                            }
                            UnityEngine.GUIContent[] arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Popup", typeof(UnityEngine.GUIContent[]), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Popup", typeof(UnityEngine.GUIStyle), 2);
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
                            var ret = UnityEditor.EditorGUILayout.Popup(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(string[])) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Popup", typeof(string), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Popup", typeof(int), 1);
                            }
                            string[] arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Popup", typeof(string[]), 2);
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
                            var ret = UnityEditor.EditorGUILayout.Popup(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(string[])) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Popup", typeof(UnityEngine.GUIContent), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Popup", typeof(int), 1);
                            }
                            string[] arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Popup", typeof(string[]), 2);
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
                            var ret = UnityEditor.EditorGUILayout.Popup(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIContent[])) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Popup", typeof(UnityEngine.GUIContent), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Popup", typeof(int), 1);
                            }
                            UnityEngine.GUIContent[] arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Popup", typeof(UnityEngine.GUIContent[]), 2);
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
                            var ret = UnityEditor.EditorGUILayout.Popup(arg0, arg1, arg2, arg3);
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
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Popup", typeof(int), 0);
                            }
                            string[] arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Popup", typeof(string[]), 1);
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
                            var ret = UnityEditor.EditorGUILayout.Popup(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent[])) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Popup", typeof(int), 0);
                            }
                            UnityEngine.GUIContent[] arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Popup", typeof(UnityEngine.GUIContent[]), 1);
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
                            var ret = UnityEditor.EditorGUILayout.Popup(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("Popup", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_EnumPopup(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 5)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(System.Enum)) && Values.js_match_type(ctx, argv[2], typeof(System.Func<System.Enum, bool>)) && Values.js_match_type(ctx, argv[3], typeof(bool)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 5, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "EnumPopup", typeof(UnityEngine.GUIContent), 0);
                            }
                            System.Enum arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "EnumPopup", typeof(System.Enum), 1);
                            }
                            System.Func<System.Enum, bool> arg2;
                            if (!Values.js_get_delegate(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "EnumPopup", typeof(System.Func<System.Enum, bool>), 2);
                            }
                            bool arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "EnumPopup", typeof(bool), 3);
                            }
                            UnityEngine.GUIStyle arg4;
                            if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "EnumPopup", typeof(UnityEngine.GUIStyle), 4);
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
                            var ret = UnityEditor.EditorGUILayout.EnumPopup(arg0, arg1, arg2, arg3, arg4, arg5);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                    if (argc >= 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(System.Enum)) && Values.js_match_type(ctx, argv[2], typeof(System.Func<System.Enum, bool>)) && Values.js_match_type(ctx, argv[3], typeof(bool)) && Values.js_match_param_types(ctx, 4, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "EnumPopup", typeof(UnityEngine.GUIContent), 0);
                            }
                            System.Enum arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "EnumPopup", typeof(System.Enum), 1);
                            }
                            System.Func<System.Enum, bool> arg2;
                            if (!Values.js_get_delegate(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "EnumPopup", typeof(System.Func<System.Enum, bool>), 2);
                            }
                            bool arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "EnumPopup", typeof(bool), 3);
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
                            var ret = UnityEditor.EditorGUILayout.EnumPopup(arg0, arg1, arg2, arg3, arg4);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                    if (argc >= 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(System.Enum)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "EnumPopup", typeof(string), 0);
                            }
                            System.Enum arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "EnumPopup", typeof(System.Enum), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "EnumPopup", typeof(UnityEngine.GUIStyle), 2);
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
                            var ret = UnityEditor.EditorGUILayout.EnumPopup(arg0, arg1, arg2, arg3);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(System.Enum)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "EnumPopup", typeof(UnityEngine.GUIContent), 0);
                            }
                            System.Enum arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "EnumPopup", typeof(System.Enum), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "EnumPopup", typeof(UnityEngine.GUIStyle), 2);
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
                            var ret = UnityEditor.EditorGUILayout.EnumPopup(arg0, arg1, arg2, arg3);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(System.Enum)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            System.Enum arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "EnumPopup", typeof(System.Enum), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "EnumPopup", typeof(UnityEngine.GUIStyle), 1);
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
                            var ret = UnityEditor.EditorGUILayout.EnumPopup(arg0, arg1, arg2);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(System.Enum)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "EnumPopup", typeof(string), 0);
                            }
                            System.Enum arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "EnumPopup", typeof(System.Enum), 1);
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
                            var ret = UnityEditor.EditorGUILayout.EnumPopup(arg0, arg1, arg2);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(System.Enum)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "EnumPopup", typeof(UnityEngine.GUIContent), 0);
                            }
                            System.Enum arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "EnumPopup", typeof(System.Enum), 1);
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
                            var ret = UnityEditor.EditorGUILayout.EnumPopup(arg0, arg1, arg2);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                    if (argc >= 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(System.Enum)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            System.Enum arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "EnumPopup", typeof(System.Enum), 0);
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
                            var ret = UnityEditor.EditorGUILayout.EnumPopup(arg0, arg1);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("EnumPopup", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IntPopup(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 5)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(string[])) && Values.js_match_type(ctx, argv[3], typeof(int[])) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 5, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntPopup", typeof(string), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntPopup", typeof(int), 1);
                            }
                            string[] arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntPopup", typeof(string[]), 2);
                            }
                            int[] arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntPopup", typeof(int[]), 3);
                            }
                            UnityEngine.GUIStyle arg4;
                            if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntPopup", typeof(UnityEngine.GUIStyle), 4);
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
                            var ret = UnityEditor.EditorGUILayout.IntPopup(arg0, arg1, arg2, arg3, arg4, arg5);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIContent[])) && Values.js_match_type(ctx, argv[3], typeof(int[])) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 5, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntPopup", typeof(UnityEngine.GUIContent), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntPopup", typeof(int), 1);
                            }
                            UnityEngine.GUIContent[] arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntPopup", typeof(UnityEngine.GUIContent[]), 2);
                            }
                            int[] arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntPopup", typeof(int[]), 3);
                            }
                            UnityEngine.GUIStyle arg4;
                            if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntPopup", typeof(UnityEngine.GUIStyle), 4);
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
                            var ret = UnityEditor.EditorGUILayout.IntPopup(arg0, arg1, arg2, arg3, arg4, arg5);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc >= 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(string[])) && Values.js_match_type(ctx, argv[2], typeof(int[])) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 4, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntPopup", typeof(int), 0);
                            }
                            string[] arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntPopup", typeof(string[]), 1);
                            }
                            int[] arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntPopup", typeof(int[]), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntPopup", typeof(UnityEngine.GUIStyle), 3);
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
                            var ret = UnityEditor.EditorGUILayout.IntPopup(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent[])) && Values.js_match_type(ctx, argv[2], typeof(int[])) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 4, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntPopup", typeof(int), 0);
                            }
                            UnityEngine.GUIContent[] arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntPopup", typeof(UnityEngine.GUIContent[]), 1);
                            }
                            int[] arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntPopup", typeof(int[]), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntPopup", typeof(UnityEngine.GUIStyle), 3);
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
                            var ret = UnityEditor.EditorGUILayout.IntPopup(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(string[])) && Values.js_match_type(ctx, argv[3], typeof(int[])) && Values.js_match_param_types(ctx, 4, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntPopup", typeof(string), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntPopup", typeof(int), 1);
                            }
                            string[] arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntPopup", typeof(string[]), 2);
                            }
                            int[] arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntPopup", typeof(int[]), 3);
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
                            var ret = UnityEditor.EditorGUILayout.IntPopup(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIContent[])) && Values.js_match_type(ctx, argv[3], typeof(int[])) && Values.js_match_param_types(ctx, 4, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntPopup", typeof(UnityEngine.GUIContent), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntPopup", typeof(int), 1);
                            }
                            UnityEngine.GUIContent[] arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntPopup", typeof(UnityEngine.GUIContent[]), 2);
                            }
                            int[] arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntPopup", typeof(int[]), 3);
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
                            var ret = UnityEditor.EditorGUILayout.IntPopup(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.SerializedProperty)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent[])) && Values.js_match_type(ctx, argv[2], typeof(int[])) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIContent)) && Values.js_match_param_types(ctx, 4, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEditor.SerializedProperty arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntPopup", typeof(UnityEditor.SerializedProperty), 0);
                            }
                            UnityEngine.GUIContent[] arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntPopup", typeof(UnityEngine.GUIContent[]), 1);
                            }
                            int[] arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntPopup", typeof(int[]), 2);
                            }
                            UnityEngine.GUIContent arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntPopup", typeof(UnityEngine.GUIContent), 3);
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
                            UnityEditor.EditorGUILayout.IntPopup(arg0, arg1, arg2, arg3, arg4);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc >= 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(string[])) && Values.js_match_type(ctx, argv[2], typeof(int[])) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntPopup", typeof(int), 0);
                            }
                            string[] arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntPopup", typeof(string[]), 1);
                            }
                            int[] arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntPopup", typeof(int[]), 2);
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
                            var ret = UnityEditor.EditorGUILayout.IntPopup(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent[])) && Values.js_match_type(ctx, argv[2], typeof(int[])) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntPopup", typeof(int), 0);
                            }
                            UnityEngine.GUIContent[] arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntPopup", typeof(UnityEngine.GUIContent[]), 1);
                            }
                            int[] arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntPopup", typeof(int[]), 2);
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
                            var ret = UnityEditor.EditorGUILayout.IntPopup(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.SerializedProperty)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent[])) && Values.js_match_type(ctx, argv[2], typeof(int[])) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEditor.SerializedProperty arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntPopup", typeof(UnityEditor.SerializedProperty), 0);
                            }
                            UnityEngine.GUIContent[] arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntPopup", typeof(UnityEngine.GUIContent[]), 1);
                            }
                            int[] arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "IntPopup", typeof(int[]), 2);
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
                            UnityEditor.EditorGUILayout.IntPopup(arg0, arg1, arg2, arg3);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("IntPopup", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_TagField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "TagField", typeof(string), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "TagField", typeof(string), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "TagField", typeof(UnityEngine.GUIStyle), 2);
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
                            var ret = UnityEditor.EditorGUILayout.TagField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "TagField", typeof(UnityEngine.GUIContent), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "TagField", typeof(string), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "TagField", typeof(UnityEngine.GUIStyle), 2);
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
                            var ret = UnityEditor.EditorGUILayout.TagField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "TagField", typeof(string), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "TagField", typeof(UnityEngine.GUIStyle), 1);
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
                            var ret = UnityEditor.EditorGUILayout.TagField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "TagField", typeof(string), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "TagField", typeof(string), 1);
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
                            var ret = UnityEditor.EditorGUILayout.TagField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "TagField", typeof(UnityEngine.GUIContent), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "TagField", typeof(string), 1);
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
                            var ret = UnityEditor.EditorGUILayout.TagField(arg0, arg1, arg2);
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
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "TagField", typeof(string), 0);
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
                            var ret = UnityEditor.EditorGUILayout.TagField(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("TagField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_LayerField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
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
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "LayerField", typeof(string), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "LayerField", typeof(int), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "LayerField", typeof(UnityEngine.GUIStyle), 2);
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
                            var ret = UnityEditor.EditorGUILayout.LayerField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "LayerField", typeof(UnityEngine.GUIContent), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "LayerField", typeof(int), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "LayerField", typeof(UnityEngine.GUIStyle), 2);
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
                            var ret = UnityEditor.EditorGUILayout.LayerField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "LayerField", typeof(int), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "LayerField", typeof(UnityEngine.GUIStyle), 1);
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
                            var ret = UnityEditor.EditorGUILayout.LayerField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "LayerField", typeof(string), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "LayerField", typeof(int), 1);
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
                            var ret = UnityEditor.EditorGUILayout.LayerField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "LayerField", typeof(UnityEngine.GUIContent), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "LayerField", typeof(int), 1);
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
                            var ret = UnityEditor.EditorGUILayout.LayerField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc >= 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "LayerField", typeof(int), 0);
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
                            var ret = UnityEditor.EditorGUILayout.LayerField(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("LayerField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_MaskField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(string[])) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 4, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "MaskField", typeof(UnityEngine.GUIContent), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "MaskField", typeof(int), 1);
                            }
                            string[] arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "MaskField", typeof(string[]), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "MaskField", typeof(UnityEngine.GUIStyle), 3);
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
                            var ret = UnityEditor.EditorGUILayout.MaskField(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(string[])) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 4, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "MaskField", typeof(string), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "MaskField", typeof(int), 1);
                            }
                            string[] arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "MaskField", typeof(string[]), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "MaskField", typeof(UnityEngine.GUIStyle), 3);
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
                            var ret = UnityEditor.EditorGUILayout.MaskField(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc >= 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(string[])) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "MaskField", typeof(UnityEngine.GUIContent), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "MaskField", typeof(int), 1);
                            }
                            string[] arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "MaskField", typeof(string[]), 2);
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
                            var ret = UnityEditor.EditorGUILayout.MaskField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(string[])) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "MaskField", typeof(string), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "MaskField", typeof(int), 1);
                            }
                            string[] arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "MaskField", typeof(string[]), 2);
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
                            var ret = UnityEditor.EditorGUILayout.MaskField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(string[])) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "MaskField", typeof(int), 0);
                            }
                            string[] arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "MaskField", typeof(string[]), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "MaskField", typeof(UnityEngine.GUIStyle), 2);
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
                            var ret = UnityEditor.EditorGUILayout.MaskField(arg0, arg1, arg2, arg3);
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
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "MaskField", typeof(int), 0);
                            }
                            string[] arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "MaskField", typeof(string[]), 1);
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
                            var ret = UnityEditor.EditorGUILayout.MaskField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("MaskField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_EnumFlagsField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(System.Enum)) && Values.js_match_type(ctx, argv[2], typeof(bool)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 4, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "EnumFlagsField", typeof(UnityEngine.GUIContent), 0);
                            }
                            System.Enum arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "EnumFlagsField", typeof(System.Enum), 1);
                            }
                            bool arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "EnumFlagsField", typeof(bool), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "EnumFlagsField", typeof(UnityEngine.GUIStyle), 3);
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
                            var ret = UnityEditor.EditorGUILayout.EnumFlagsField(arg0, arg1, arg2, arg3, arg4);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                    if (argc >= 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(System.Enum)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "EnumFlagsField", typeof(string), 0);
                            }
                            System.Enum arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "EnumFlagsField", typeof(System.Enum), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "EnumFlagsField", typeof(UnityEngine.GUIStyle), 2);
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
                            var ret = UnityEditor.EditorGUILayout.EnumFlagsField(arg0, arg1, arg2, arg3);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(System.Enum)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "EnumFlagsField", typeof(UnityEngine.GUIContent), 0);
                            }
                            System.Enum arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "EnumFlagsField", typeof(System.Enum), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "EnumFlagsField", typeof(UnityEngine.GUIStyle), 2);
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
                            var ret = UnityEditor.EditorGUILayout.EnumFlagsField(arg0, arg1, arg2, arg3);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(System.Enum)) && Values.js_match_type(ctx, argv[2], typeof(bool)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "EnumFlagsField", typeof(UnityEngine.GUIContent), 0);
                            }
                            System.Enum arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "EnumFlagsField", typeof(System.Enum), 1);
                            }
                            bool arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "EnumFlagsField", typeof(bool), 2);
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
                            var ret = UnityEditor.EditorGUILayout.EnumFlagsField(arg0, arg1, arg2, arg3);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(System.Enum)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            System.Enum arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "EnumFlagsField", typeof(System.Enum), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "EnumFlagsField", typeof(UnityEngine.GUIStyle), 1);
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
                            var ret = UnityEditor.EditorGUILayout.EnumFlagsField(arg0, arg1, arg2);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(System.Enum)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "EnumFlagsField", typeof(string), 0);
                            }
                            System.Enum arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "EnumFlagsField", typeof(System.Enum), 1);
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
                            var ret = UnityEditor.EditorGUILayout.EnumFlagsField(arg0, arg1, arg2);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(System.Enum)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "EnumFlagsField", typeof(UnityEngine.GUIContent), 0);
                            }
                            System.Enum arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "EnumFlagsField", typeof(System.Enum), 1);
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
                            var ret = UnityEditor.EditorGUILayout.EnumFlagsField(arg0, arg1, arg2);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                    if (argc >= 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(System.Enum)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            System.Enum arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "EnumFlagsField", typeof(System.Enum), 0);
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
                            var ret = UnityEditor.EditorGUILayout.EnumFlagsField(arg0, arg1);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("EnumFlagsField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ObjectField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Object)) && Values.js_match_type(ctx, argv[2], typeof(System.Type)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.Object)) && Values.js_match_param_types(ctx, 4, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ObjectField", typeof(string), 0);
                            }
                            UnityEngine.Object arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ObjectField", typeof(UnityEngine.Object), 1);
                            }
                            System.Type arg2;
                            if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ObjectField", typeof(System.Type), 2);
                            }
                            UnityEngine.Object arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ObjectField", typeof(UnityEngine.Object), 3);
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
                            var ret = UnityEditor.EditorGUILayout.ObjectField(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Object)) && Values.js_match_type(ctx, argv[2], typeof(System.Type)) && Values.js_match_type(ctx, argv[3], typeof(bool)) && Values.js_match_param_types(ctx, 4, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ObjectField", typeof(string), 0);
                            }
                            UnityEngine.Object arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ObjectField", typeof(UnityEngine.Object), 1);
                            }
                            System.Type arg2;
                            if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ObjectField", typeof(System.Type), 2);
                            }
                            bool arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ObjectField", typeof(bool), 3);
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
                            var ret = UnityEditor.EditorGUILayout.ObjectField(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Object)) && Values.js_match_type(ctx, argv[2], typeof(System.Type)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.Object)) && Values.js_match_param_types(ctx, 4, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ObjectField", typeof(UnityEngine.GUIContent), 0);
                            }
                            UnityEngine.Object arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ObjectField", typeof(UnityEngine.Object), 1);
                            }
                            System.Type arg2;
                            if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ObjectField", typeof(System.Type), 2);
                            }
                            UnityEngine.Object arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ObjectField", typeof(UnityEngine.Object), 3);
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
                            var ret = UnityEditor.EditorGUILayout.ObjectField(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Object)) && Values.js_match_type(ctx, argv[2], typeof(System.Type)) && Values.js_match_type(ctx, argv[3], typeof(bool)) && Values.js_match_param_types(ctx, 4, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ObjectField", typeof(UnityEngine.GUIContent), 0);
                            }
                            UnityEngine.Object arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ObjectField", typeof(UnityEngine.Object), 1);
                            }
                            System.Type arg2;
                            if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ObjectField", typeof(System.Type), 2);
                            }
                            bool arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ObjectField", typeof(bool), 3);
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
                            var ret = UnityEditor.EditorGUILayout.ObjectField(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
                        }
                    }
                    if (argc >= 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Object)) && Values.js_match_type(ctx, argv[1], typeof(System.Type)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Object)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.Object arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ObjectField", typeof(UnityEngine.Object), 0);
                            }
                            System.Type arg1;
                            if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ObjectField", typeof(System.Type), 1);
                            }
                            UnityEngine.Object arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ObjectField", typeof(UnityEngine.Object), 2);
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
                            var ret = UnityEditor.EditorGUILayout.ObjectField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Object)) && Values.js_match_type(ctx, argv[1], typeof(System.Type)) && Values.js_match_type(ctx, argv[2], typeof(bool)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.Object arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ObjectField", typeof(UnityEngine.Object), 0);
                            }
                            System.Type arg1;
                            if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ObjectField", typeof(System.Type), 1);
                            }
                            bool arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ObjectField", typeof(bool), 2);
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
                            var ret = UnityEditor.EditorGUILayout.ObjectField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.SerializedProperty)) && Values.js_match_type(ctx, argv[1], typeof(System.Type)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIContent)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEditor.SerializedProperty arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ObjectField", typeof(UnityEditor.SerializedProperty), 0);
                            }
                            System.Type arg1;
                            if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ObjectField", typeof(System.Type), 1);
                            }
                            UnityEngine.GUIContent arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ObjectField", typeof(UnityEngine.GUIContent), 2);
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
                            UnityEditor.EditorGUILayout.ObjectField(arg0, arg1, arg2, arg3);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.SerializedProperty)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEditor.SerializedProperty arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ObjectField", typeof(UnityEditor.SerializedProperty), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ObjectField", typeof(UnityEngine.GUIContent), 1);
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
                            UnityEditor.EditorGUILayout.ObjectField(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.SerializedProperty)) && Values.js_match_type(ctx, argv[1], typeof(System.Type)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEditor.SerializedProperty arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ObjectField", typeof(UnityEditor.SerializedProperty), 0);
                            }
                            System.Type arg1;
                            if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ObjectField", typeof(System.Type), 1);
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
                            UnityEditor.EditorGUILayout.ObjectField(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc >= 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.SerializedProperty)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEditor.SerializedProperty arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ObjectField", typeof(UnityEditor.SerializedProperty), 0);
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
                            UnityEditor.EditorGUILayout.ObjectField(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("ObjectField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Vector2Field(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector2)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Vector2Field", typeof(string), 0);
                            }
                            UnityEngine.Vector2 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Vector2Field", typeof(UnityEngine.Vector2), 1);
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
                            var ret = UnityEditor.EditorGUILayout.Vector2Field(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector2)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Vector2Field", typeof(UnityEngine.GUIContent), 0);
                            }
                            UnityEngine.Vector2 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Vector2Field", typeof(UnityEngine.Vector2), 1);
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
                            var ret = UnityEditor.EditorGUILayout.Vector2Field(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("Vector2Field", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Vector3Field(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector3)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Vector3Field", typeof(string), 0);
                            }
                            UnityEngine.Vector3 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Vector3Field", typeof(UnityEngine.Vector3), 1);
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
                            var ret = UnityEditor.EditorGUILayout.Vector3Field(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector3)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Vector3Field", typeof(UnityEngine.GUIContent), 0);
                            }
                            UnityEngine.Vector3 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Vector3Field", typeof(UnityEngine.Vector3), 1);
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
                            var ret = UnityEditor.EditorGUILayout.Vector3Field(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("Vector3Field", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Vector4Field(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector4)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Vector4Field", typeof(string), 0);
                            }
                            UnityEngine.Vector4 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Vector4Field", typeof(UnityEngine.Vector4), 1);
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
                            var ret = UnityEditor.EditorGUILayout.Vector4Field(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector4)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Vector4Field", typeof(UnityEngine.GUIContent), 0);
                            }
                            UnityEngine.Vector4 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Vector4Field", typeof(UnityEngine.Vector4), 1);
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
                            var ret = UnityEditor.EditorGUILayout.Vector4Field(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("Vector4Field", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Vector2IntField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector2Int)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Vector2IntField", typeof(string), 0);
                            }
                            UnityEngine.Vector2Int arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Vector2IntField", typeof(UnityEngine.Vector2Int), 1);
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
                            var ret = UnityEditor.EditorGUILayout.Vector2IntField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector2Int)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Vector2IntField", typeof(UnityEngine.GUIContent), 0);
                            }
                            UnityEngine.Vector2Int arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Vector2IntField", typeof(UnityEngine.Vector2Int), 1);
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
                            var ret = UnityEditor.EditorGUILayout.Vector2IntField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("Vector2IntField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Vector3IntField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector3Int)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Vector3IntField", typeof(string), 0);
                            }
                            UnityEngine.Vector3Int arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Vector3IntField", typeof(UnityEngine.Vector3Int), 1);
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
                            var ret = UnityEditor.EditorGUILayout.Vector3IntField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector3Int)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Vector3IntField", typeof(UnityEngine.GUIContent), 0);
                            }
                            UnityEngine.Vector3Int arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Vector3IntField", typeof(UnityEngine.Vector3Int), 1);
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
                            var ret = UnityEditor.EditorGUILayout.Vector3IntField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("Vector3IntField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RectField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Rect)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "RectField", typeof(string), 0);
                            }
                            UnityEngine.Rect arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "RectField", typeof(UnityEngine.Rect), 1);
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
                            var ret = UnityEditor.EditorGUILayout.RectField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Rect)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "RectField", typeof(UnityEngine.GUIContent), 0);
                            }
                            UnityEngine.Rect arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "RectField", typeof(UnityEngine.Rect), 1);
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
                            var ret = UnityEditor.EditorGUILayout.RectField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                    if (argc >= 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "RectField", typeof(UnityEngine.Rect), 0);
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
                            var ret = UnityEditor.EditorGUILayout.RectField(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("RectField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RectIntField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.RectInt)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "RectIntField", typeof(string), 0);
                            }
                            UnityEngine.RectInt arg1;
                            if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "RectIntField", typeof(UnityEngine.RectInt), 1);
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
                            var ret = UnityEditor.EditorGUILayout.RectIntField(arg0, arg1, arg2);
                            return Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.RectInt)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "RectIntField", typeof(UnityEngine.GUIContent), 0);
                            }
                            UnityEngine.RectInt arg1;
                            if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "RectIntField", typeof(UnityEngine.RectInt), 1);
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
                            var ret = UnityEditor.EditorGUILayout.RectIntField(arg0, arg1, arg2);
                            return Values.js_push_structvalue(ctx, ret);
                        }
                    }
                    if (argc >= 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.RectInt)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.RectInt arg0;
                            if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "RectIntField", typeof(UnityEngine.RectInt), 0);
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
                            var ret = UnityEditor.EditorGUILayout.RectIntField(arg0, arg1);
                            return Values.js_push_structvalue(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("RectIntField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_BoundsField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Bounds)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "BoundsField", typeof(string), 0);
                            }
                            UnityEngine.Bounds arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "BoundsField", typeof(UnityEngine.Bounds), 1);
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
                            var ret = UnityEditor.EditorGUILayout.BoundsField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Bounds)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "BoundsField", typeof(UnityEngine.GUIContent), 0);
                            }
                            UnityEngine.Bounds arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "BoundsField", typeof(UnityEngine.Bounds), 1);
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
                            var ret = UnityEditor.EditorGUILayout.BoundsField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                    if (argc >= 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Bounds)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.Bounds arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "BoundsField", typeof(UnityEngine.Bounds), 0);
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
                            var ret = UnityEditor.EditorGUILayout.BoundsField(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("BoundsField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_BoundsIntField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.BoundsInt)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "BoundsIntField", typeof(string), 0);
                            }
                            UnityEngine.BoundsInt arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "BoundsIntField", typeof(UnityEngine.BoundsInt), 1);
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
                            var ret = UnityEditor.EditorGUILayout.BoundsIntField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.BoundsInt)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "BoundsIntField", typeof(UnityEngine.GUIContent), 0);
                            }
                            UnityEngine.BoundsInt arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "BoundsIntField", typeof(UnityEngine.BoundsInt), 1);
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
                            var ret = UnityEditor.EditorGUILayout.BoundsIntField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                    if (argc >= 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.BoundsInt)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.BoundsInt arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "BoundsIntField", typeof(UnityEngine.BoundsInt), 0);
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
                            var ret = UnityEditor.EditorGUILayout.BoundsIntField(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("BoundsIntField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ColorField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 5)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Color)) && Values.js_match_type(ctx, argv[2], typeof(bool)) && Values.js_match_type(ctx, argv[3], typeof(bool)) && Values.js_match_type(ctx, argv[4], typeof(bool)) && Values.js_match_param_types(ctx, 5, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ColorField", typeof(UnityEngine.GUIContent), 0);
                            }
                            UnityEngine.Color arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ColorField", typeof(UnityEngine.Color), 1);
                            }
                            bool arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ColorField", typeof(bool), 2);
                            }
                            bool arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ColorField", typeof(bool), 3);
                            }
                            bool arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ColorField", typeof(bool), 4);
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
                            var ret = UnityEditor.EditorGUILayout.ColorField(arg0, arg1, arg2, arg3, arg4, arg5);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Color)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ColorField", typeof(string), 0);
                            }
                            UnityEngine.Color arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ColorField", typeof(UnityEngine.Color), 1);
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
                            var ret = UnityEditor.EditorGUILayout.ColorField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Color)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ColorField", typeof(UnityEngine.GUIContent), 0);
                            }
                            UnityEngine.Color arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ColorField", typeof(UnityEngine.Color), 1);
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
                            var ret = UnityEditor.EditorGUILayout.ColorField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                    if (argc >= 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Color)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.Color arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ColorField", typeof(UnityEngine.Color), 0);
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
                            var ret = UnityEditor.EditorGUILayout.ColorField(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("ColorField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CurveField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.AnimationCurve)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Color)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.Rect)) && Values.js_match_param_types(ctx, 4, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "CurveField", typeof(string), 0);
                            }
                            UnityEngine.AnimationCurve arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "CurveField", typeof(UnityEngine.AnimationCurve), 1);
                            }
                            UnityEngine.Color arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "CurveField", typeof(UnityEngine.Color), 2);
                            }
                            UnityEngine.Rect arg3;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "CurveField", typeof(UnityEngine.Rect), 3);
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
                            var ret = UnityEditor.EditorGUILayout.CurveField(arg0, arg1, arg2, arg3, arg4);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.AnimationCurve)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Color)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.Rect)) && Values.js_match_param_types(ctx, 4, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "CurveField", typeof(UnityEngine.GUIContent), 0);
                            }
                            UnityEngine.AnimationCurve arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "CurveField", typeof(UnityEngine.AnimationCurve), 1);
                            }
                            UnityEngine.Color arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "CurveField", typeof(UnityEngine.Color), 2);
                            }
                            UnityEngine.Rect arg3;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "CurveField", typeof(UnityEngine.Rect), 3);
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
                            var ret = UnityEditor.EditorGUILayout.CurveField(arg0, arg1, arg2, arg3, arg4);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.SerializedProperty)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Color)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIContent)) && Values.js_match_param_types(ctx, 4, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEditor.SerializedProperty arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "CurveField", typeof(UnityEditor.SerializedProperty), 0);
                            }
                            UnityEngine.Color arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "CurveField", typeof(UnityEngine.Color), 1);
                            }
                            UnityEngine.Rect arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "CurveField", typeof(UnityEngine.Rect), 2);
                            }
                            UnityEngine.GUIContent arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "CurveField", typeof(UnityEngine.GUIContent), 3);
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
                            UnityEditor.EditorGUILayout.CurveField(arg0, arg1, arg2, arg3, arg4);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc >= 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.AnimationCurve)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Color)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Rect)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.AnimationCurve arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "CurveField", typeof(UnityEngine.AnimationCurve), 0);
                            }
                            UnityEngine.Color arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "CurveField", typeof(UnityEngine.Color), 1);
                            }
                            UnityEngine.Rect arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "CurveField", typeof(UnityEngine.Rect), 2);
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
                            var ret = UnityEditor.EditorGUILayout.CurveField(arg0, arg1, arg2, arg3);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.SerializedProperty)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Color)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Rect)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEditor.SerializedProperty arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "CurveField", typeof(UnityEditor.SerializedProperty), 0);
                            }
                            UnityEngine.Color arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "CurveField", typeof(UnityEngine.Color), 1);
                            }
                            UnityEngine.Rect arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "CurveField", typeof(UnityEngine.Rect), 2);
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
                            UnityEditor.EditorGUILayout.CurveField(arg0, arg1, arg2, arg3);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.AnimationCurve)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "CurveField", typeof(string), 0);
                            }
                            UnityEngine.AnimationCurve arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "CurveField", typeof(UnityEngine.AnimationCurve), 1);
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
                            var ret = UnityEditor.EditorGUILayout.CurveField(arg0, arg1, arg2);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.AnimationCurve)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "CurveField", typeof(UnityEngine.GUIContent), 0);
                            }
                            UnityEngine.AnimationCurve arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "CurveField", typeof(UnityEngine.AnimationCurve), 1);
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
                            var ret = UnityEditor.EditorGUILayout.CurveField(arg0, arg1, arg2);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                    if (argc >= 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.AnimationCurve)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.AnimationCurve arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "CurveField", typeof(UnityEngine.AnimationCurve), 0);
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
                            var ret = UnityEditor.EditorGUILayout.CurveField(arg0, arg1);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("CurveField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_InspectorTitlebar(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(bool)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Object)) && Values.js_match_type(ctx, argv[2], typeof(bool)))
                        {
                            bool arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "InspectorTitlebar", typeof(bool), 0);
                            }
                            UnityEngine.Object arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "InspectorTitlebar", typeof(UnityEngine.Object), 1);
                            }
                            bool arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "InspectorTitlebar", typeof(bool), 2);
                            }
                            var ret = UnityEditor.EditorGUILayout.InspectorTitlebar(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(bool)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Object[])) && Values.js_match_type(ctx, argv[2], typeof(bool)))
                        {
                            bool arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "InspectorTitlebar", typeof(bool), 0);
                            }
                            UnityEngine.Object[] arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "InspectorTitlebar", typeof(UnityEngine.Object[]), 1);
                            }
                            bool arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "InspectorTitlebar", typeof(bool), 2);
                            }
                            var ret = UnityEditor.EditorGUILayout.InspectorTitlebar(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(bool)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Object)))
                        {
                            bool arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "InspectorTitlebar", typeof(bool), 0);
                            }
                            UnityEngine.Object arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "InspectorTitlebar", typeof(UnityEngine.Object), 1);
                            }
                            var ret = UnityEditor.EditorGUILayout.InspectorTitlebar(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(bool)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Object[])))
                        {
                            bool arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "InspectorTitlebar", typeof(bool), 0);
                            }
                            UnityEngine.Object[] arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "InspectorTitlebar", typeof(UnityEngine.Object[]), 1);
                            }
                            var ret = UnityEditor.EditorGUILayout.InspectorTitlebar(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(bool)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.Editor)))
                        {
                            bool arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "InspectorTitlebar", typeof(bool), 0);
                            }
                            UnityEditor.Editor arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "InspectorTitlebar", typeof(UnityEditor.Editor), 1);
                            }
                            var ret = UnityEditor.EditorGUILayout.InspectorTitlebar(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 1)
                    {
                        UnityEngine.Object[] arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "InspectorTitlebar", typeof(UnityEngine.Object[]), 0);
                        }
                        UnityEditor.EditorGUILayout.InspectorTitlebar(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("InspectorTitlebar", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_HelpBox(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "HelpBox", typeof(string), 0);
                        }
                        UnityEditor.MessageType arg1;
                        if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "HelpBox", typeof(UnityEditor.MessageType), 1);
                        }
                        bool arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "HelpBox", typeof(bool), 2);
                        }
                        UnityEditor.EditorGUILayout.HelpBox(arg0, arg1, arg2);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.MessageType)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "HelpBox", typeof(string), 0);
                            }
                            UnityEditor.MessageType arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "HelpBox", typeof(UnityEditor.MessageType), 1);
                            }
                            UnityEditor.EditorGUILayout.HelpBox(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(bool)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "HelpBox", typeof(UnityEngine.GUIContent), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "HelpBox", typeof(bool), 1);
                            }
                            UnityEditor.EditorGUILayout.HelpBox(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("HelpBox", argc);
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
                do
                {
                    if (argc == 2)
                    {
                        float arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Space", typeof(float), 0);
                        }
                        bool arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Space", typeof(bool), 1);
                        }
                        UnityEditor.EditorGUILayout.Space(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 1)
                    {
                        float arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Space", typeof(float), 0);
                        }
                        UnityEditor.EditorGUILayout.Space(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 0)
                    {
                        UnityEditor.EditorGUILayout.Space();
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("Space", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Separator(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.EditorGUILayout.Separator();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Separator", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_BeginToggleGroup(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(bool)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "BeginToggleGroup", typeof(string), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "BeginToggleGroup", typeof(bool), 1);
                            }
                            var ret = UnityEditor.EditorGUILayout.BeginToggleGroup(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(bool)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "BeginToggleGroup", typeof(UnityEngine.GUIContent), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "BeginToggleGroup", typeof(bool), 1);
                            }
                            var ret = UnityEditor.EditorGUILayout.BeginToggleGroup(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("BeginToggleGroup", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_EndToggleGroup(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.EditorGUILayout.EndToggleGroup();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("EndToggleGroup", argc);
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
                    if (argc >= 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIStyle arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "BeginHorizontal", typeof(UnityEngine.GUIStyle), 0);
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
                            var ret = UnityEditor.EditorGUILayout.BeginHorizontal(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
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
                        var ret = UnityEditor.EditorGUILayout.BeginHorizontal(arg0);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
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
                    UnityEditor.EditorGUILayout.EndHorizontal();
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
                    if (argc >= 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIStyle arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "BeginVertical", typeof(UnityEngine.GUIStyle), 0);
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
                            var ret = UnityEditor.EditorGUILayout.BeginVertical(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
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
                        var ret = UnityEditor.EditorGUILayout.BeginVertical(arg0);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
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
                    UnityEditor.EditorGUILayout.EndVertical();
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
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "BeginScrollView", typeof(UnityEngine.Vector2), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "BeginScrollView", typeof(bool), 1);
                            }
                            bool arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "BeginScrollView", typeof(bool), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "BeginScrollView", typeof(UnityEngine.GUIStyle), 3);
                            }
                            UnityEngine.GUIStyle arg4;
                            if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "BeginScrollView", typeof(UnityEngine.GUIStyle), 4);
                            }
                            UnityEngine.GUIStyle arg5;
                            if (!Values.js_get_classvalue(ctx, argv[5], out arg5))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "BeginScrollView", typeof(UnityEngine.GUIStyle), 5);
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
                            var ret = UnityEditor.EditorGUILayout.BeginScrollView(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
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
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "BeginScrollView", typeof(UnityEngine.Vector2), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "BeginScrollView", typeof(bool), 1);
                            }
                            bool arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "BeginScrollView", typeof(bool), 2);
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
                            var ret = UnityEditor.EditorGUILayout.BeginScrollView(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector2)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.Vector2 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "BeginScrollView", typeof(UnityEngine.Vector2), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "BeginScrollView", typeof(UnityEngine.GUIStyle), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "BeginScrollView", typeof(UnityEngine.GUIStyle), 2);
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
                            var ret = UnityEditor.EditorGUILayout.BeginScrollView(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector2)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.Vector2 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "BeginScrollView", typeof(UnityEngine.Vector2), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "BeginScrollView", typeof(UnityEngine.GUIStyle), 1);
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
                            var ret = UnityEditor.EditorGUILayout.BeginScrollView(arg0, arg1, arg2);
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
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "BeginScrollView", typeof(UnityEngine.Vector2), 0);
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
                            var ret = UnityEditor.EditorGUILayout.BeginScrollView(arg0, arg1);
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
                    UnityEditor.EditorGUILayout.EndScrollView();
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
        public static JSValue BindStatic_PropertyField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.SerializedProperty)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(bool)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEditor.SerializedProperty arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "PropertyField", typeof(UnityEditor.SerializedProperty), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "PropertyField", typeof(UnityEngine.GUIContent), 1);
                            }
                            bool arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "PropertyField", typeof(bool), 2);
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
                            var ret = UnityEditor.EditorGUILayout.PropertyField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.SerializedProperty)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEditor.SerializedProperty arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "PropertyField", typeof(UnityEditor.SerializedProperty), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "PropertyField", typeof(UnityEngine.GUIContent), 1);
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
                            var ret = UnityEditor.EditorGUILayout.PropertyField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.SerializedProperty)) && Values.js_match_type(ctx, argv[1], typeof(bool)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEditor.SerializedProperty arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "PropertyField", typeof(UnityEditor.SerializedProperty), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "PropertyField", typeof(bool), 1);
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
                            var ret = UnityEditor.EditorGUILayout.PropertyField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc >= 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.SerializedProperty)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEditor.SerializedProperty arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "PropertyField", typeof(UnityEditor.SerializedProperty), 0);
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
                            var ret = UnityEditor.EditorGUILayout.PropertyField(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("PropertyField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetControlRect(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(bool)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            bool arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "GetControlRect", typeof(bool), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "GetControlRect", typeof(float), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "GetControlRect", typeof(UnityEngine.GUIStyle), 2);
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
                            var ret = UnityEditor.EditorGUILayout.GetControlRect(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(bool)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            bool arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "GetControlRect", typeof(bool), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "GetControlRect", typeof(float), 1);
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
                            var ret = UnityEditor.EditorGUILayout.GetControlRect(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                    if (argc >= 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(bool)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            bool arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "GetControlRect", typeof(bool), 0);
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
                            var ret = UnityEditor.EditorGUILayout.GetControlRect(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
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
                        var ret = UnityEditor.EditorGUILayout.GetControlRect(arg0);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("GetControlRect", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_BeginFadeGroup(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    float arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "BeginFadeGroup", typeof(float), 0);
                    }
                    var ret = UnityEditor.EditorGUILayout.BeginFadeGroup(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("BeginFadeGroup", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_EndFadeGroup(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.EditorGUILayout.EndFadeGroup();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("EndFadeGroup", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_BeginBuildTargetSelectionGrouping(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.EditorGUILayout.BeginBuildTargetSelectionGrouping();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
                }
                throw new NoSuitableMethodException("BeginBuildTargetSelectionGrouping", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_EndBuildTargetSelectionGrouping(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.EditorGUILayout.EndBuildTargetSelectionGrouping();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("EndBuildTargetSelectionGrouping", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DropdownButton(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.FocusType)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DropdownButton", typeof(UnityEngine.GUIContent), 0);
                            }
                            UnityEngine.FocusType arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DropdownButton", typeof(UnityEngine.FocusType), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DropdownButton", typeof(UnityEngine.GUIStyle), 2);
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
                            var ret = UnityEditor.EditorGUILayout.DropdownButton(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.FocusType)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DropdownButton", typeof(UnityEngine.GUIContent), 0);
                            }
                            UnityEngine.FocusType arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "DropdownButton", typeof(UnityEngine.FocusType), 1);
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
                            var ret = UnityEditor.EditorGUILayout.DropdownButton(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("DropdownButton", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_BeginFoldoutHeaderGroup(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 5)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(bool)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_type(ctx, argv[3], typeof(System.Action<UnityEngine.Rect>)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.GUIStyle)))
                        {
                            bool arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "BeginFoldoutHeaderGroup", typeof(bool), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "BeginFoldoutHeaderGroup", typeof(string), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "BeginFoldoutHeaderGroup", typeof(UnityEngine.GUIStyle), 2);
                            }
                            System.Action<UnityEngine.Rect> arg3;
                            if (!Values.js_get_delegate(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "BeginFoldoutHeaderGroup", typeof(System.Action<UnityEngine.Rect>), 3);
                            }
                            UnityEngine.GUIStyle arg4;
                            if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "BeginFoldoutHeaderGroup", typeof(UnityEngine.GUIStyle), 4);
                            }
                            var ret = UnityEditor.EditorGUILayout.BeginFoldoutHeaderGroup(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(bool)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_type(ctx, argv[3], typeof(System.Action<UnityEngine.Rect>)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.GUIStyle)))
                        {
                            bool arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "BeginFoldoutHeaderGroup", typeof(bool), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "BeginFoldoutHeaderGroup", typeof(UnityEngine.GUIContent), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "BeginFoldoutHeaderGroup", typeof(UnityEngine.GUIStyle), 2);
                            }
                            System.Action<UnityEngine.Rect> arg3;
                            if (!Values.js_get_delegate(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "BeginFoldoutHeaderGroup", typeof(System.Action<UnityEngine.Rect>), 3);
                            }
                            UnityEngine.GUIStyle arg4;
                            if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "BeginFoldoutHeaderGroup", typeof(UnityEngine.GUIStyle), 4);
                            }
                            var ret = UnityEditor.EditorGUILayout.BeginFoldoutHeaderGroup(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("BeginFoldoutHeaderGroup", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_EndFoldoutHeaderGroup(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.EditorGUILayout.EndFoldoutHeaderGroup();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("EndFoldoutHeaderGroup", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GradientField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Gradient)) && Values.js_match_type(ctx, argv[2], typeof(bool)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "GradientField", typeof(UnityEngine.GUIContent), 0);
                            }
                            UnityEngine.Gradient arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "GradientField", typeof(UnityEngine.Gradient), 1);
                            }
                            bool arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "GradientField", typeof(bool), 2);
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
                            var ret = UnityEditor.EditorGUILayout.GradientField(arg0, arg1, arg2, arg3);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Gradient)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "GradientField", typeof(string), 0);
                            }
                            UnityEngine.Gradient arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "GradientField", typeof(UnityEngine.Gradient), 1);
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
                            var ret = UnityEditor.EditorGUILayout.GradientField(arg0, arg1, arg2);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Gradient)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "GradientField", typeof(UnityEngine.GUIContent), 0);
                            }
                            UnityEngine.Gradient arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "GradientField", typeof(UnityEngine.Gradient), 1);
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
                            var ret = UnityEditor.EditorGUILayout.GradientField(arg0, arg1, arg2);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                    if (argc >= 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Gradient)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.Gradient arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "GradientField", typeof(UnityEngine.Gradient), 0);
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
                            var ret = UnityEditor.EditorGUILayout.GradientField(arg0, arg1);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("GradientField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Knob(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc >= 8)
                {
                    if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector2)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(float)) && Values.js_match_type(ctx, argv[4], typeof(string)) && Values.js_match_type(ctx, argv[5], typeof(UnityEngine.Color)) && Values.js_match_type(ctx, argv[6], typeof(UnityEngine.Color)) && Values.js_match_type(ctx, argv[7], typeof(bool)) && Values.js_match_param_types(ctx, 8, argv, typeof(UnityEngine.GUILayoutOption)))
                    {
                        UnityEngine.Vector2 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Knob", typeof(UnityEngine.Vector2), 0);
                        }
                        float arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Knob", typeof(float), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Knob", typeof(float), 2);
                        }
                        float arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Knob", typeof(float), 3);
                        }
                        string arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Knob", typeof(string), 4);
                        }
                        UnityEngine.Color arg5;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Knob", typeof(UnityEngine.Color), 5);
                        }
                        UnityEngine.Color arg6;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[6], out arg6))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Knob", typeof(UnityEngine.Color), 6);
                        }
                        bool arg7;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[7], out arg7))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "Knob", typeof(bool), 7);
                        }
                        UnityEngine.GUILayoutOption[] arg8 = null;
                        if (argc - 8 > 0)
                        {
                            arg8 = new UnityEngine.GUILayoutOption[argc - 8];
                            for (var i = 8; i < argc; i++)
                            {
                                Values.js_get_classvalue(ctx, argv[i], out arg8[i - 8]);
                            }
                        }
                        var ret = UnityEditor.EditorGUILayout.Knob(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                }
                throw new NoSuitableMethodException("Knob", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_EditorToolbarForTarget(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        UnityEngine.GUIContent arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "EditorToolbarForTarget", typeof(UnityEngine.GUIContent), 0);
                        }
                        UnityEngine.Object arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "EditorToolbarForTarget", typeof(UnityEngine.Object), 1);
                        }
                        UnityEditor.EditorGUILayout.EditorToolbarForTarget(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 1)
                    {
                        UnityEngine.Object arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "EditorToolbarForTarget", typeof(UnityEngine.Object), 0);
                        }
                        UnityEditor.EditorGUILayout.EditorToolbarForTarget(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("EditorToolbarForTarget", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ToolContextToolbarForTarget(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.GUIContent arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ToolContextToolbarForTarget", typeof(UnityEngine.GUIContent), 0);
                    }
                    UnityEngine.Object arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorGUILayout), "ToolContextToolbarForTarget", typeof(UnityEngine.Object), 1);
                    }
                    UnityEditor.EditorGUILayout.ToolContextToolbarForTarget(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ToolContextToolbarForTarget", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_EditorToolbar(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (Values.js_match_param_types(ctx, 0, argv, typeof(UnityEditor.EditorTools.EditorTool)))
                {
                    UnityEditor.EditorTools.EditorTool[] arg0 = null;
                    if (argc > 0)
                    {
                        arg0 = new UnityEditor.EditorTools.EditorTool[argc];
                        for (var i = 0; i < argc; i++)
                        {
                            Values.js_get_classvalue(ctx, argv[i], out arg0[i]);
                        }
                    }
                    UnityEditor.EditorGUILayout.EditorToolbar(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("EditorToolbar", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("EditorGUILayout", typeof(UnityEditor.EditorGUILayout), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "Foldout", BindStatic_Foldout);
            cls.AddMethod(true, "PrefixLabel", BindStatic_PrefixLabel);
            cls.AddMethod(true, "LabelField", BindStatic_LabelField);
            cls.AddMethod(true, "LinkButton", BindStatic_LinkButton);
            cls.AddMethod(true, "Toggle", BindStatic_Toggle);
            cls.AddMethod(true, "ToggleLeft", BindStatic_ToggleLeft);
            cls.AddMethod(true, "TextField", BindStatic_TextField);
            cls.AddMethod(true, "DelayedTextField", BindStatic_DelayedTextField);
            cls.AddMethod(true, "TextArea", BindStatic_TextArea);
            cls.AddMethod(true, "SelectableLabel", BindStatic_SelectableLabel);
            cls.AddMethod(true, "PasswordField", BindStatic_PasswordField);
            cls.AddMethod(true, "FloatField", BindStatic_FloatField);
            cls.AddMethod(true, "DelayedFloatField", BindStatic_DelayedFloatField);
            cls.AddMethod(true, "DoubleField", BindStatic_DoubleField);
            cls.AddMethod(true, "DelayedDoubleField", BindStatic_DelayedDoubleField);
            cls.AddMethod(true, "IntField", BindStatic_IntField);
            cls.AddMethod(true, "DelayedIntField", BindStatic_DelayedIntField);
            cls.AddMethod(true, "LongField", BindStatic_LongField);
            cls.AddMethod(true, "Slider", BindStatic_Slider);
            cls.AddMethod(true, "IntSlider", BindStatic_IntSlider);
            cls.AddMethod(true, "MinMaxSlider", BindStatic_MinMaxSlider);
            cls.AddMethod(true, "Popup", BindStatic_Popup);
            cls.AddMethod(true, "EnumPopup", BindStatic_EnumPopup);
            cls.AddMethod(true, "IntPopup", BindStatic_IntPopup);
            cls.AddMethod(true, "TagField", BindStatic_TagField);
            cls.AddMethod(true, "LayerField", BindStatic_LayerField);
            cls.AddMethod(true, "MaskField", BindStatic_MaskField);
            cls.AddMethod(true, "EnumFlagsField", BindStatic_EnumFlagsField);
            cls.AddMethod(true, "ObjectField", BindStatic_ObjectField);
            cls.AddMethod(true, "Vector2Field", BindStatic_Vector2Field);
            cls.AddMethod(true, "Vector3Field", BindStatic_Vector3Field);
            cls.AddMethod(true, "Vector4Field", BindStatic_Vector4Field);
            cls.AddMethod(true, "Vector2IntField", BindStatic_Vector2IntField);
            cls.AddMethod(true, "Vector3IntField", BindStatic_Vector3IntField);
            cls.AddMethod(true, "RectField", BindStatic_RectField);
            cls.AddMethod(true, "RectIntField", BindStatic_RectIntField);
            cls.AddMethod(true, "BoundsField", BindStatic_BoundsField);
            cls.AddMethod(true, "BoundsIntField", BindStatic_BoundsIntField);
            cls.AddMethod(true, "ColorField", BindStatic_ColorField);
            cls.AddMethod(true, "CurveField", BindStatic_CurveField);
            cls.AddMethod(true, "InspectorTitlebar", BindStatic_InspectorTitlebar);
            cls.AddMethod(true, "HelpBox", BindStatic_HelpBox);
            cls.AddMethod(true, "Space", BindStatic_Space);
            cls.AddMethod(true, "Separator", BindStatic_Separator);
            cls.AddMethod(true, "BeginToggleGroup", BindStatic_BeginToggleGroup);
            cls.AddMethod(true, "EndToggleGroup", BindStatic_EndToggleGroup);
            cls.AddMethod(true, "BeginHorizontal", BindStatic_BeginHorizontal);
            cls.AddMethod(true, "EndHorizontal", BindStatic_EndHorizontal);
            cls.AddMethod(true, "BeginVertical", BindStatic_BeginVertical);
            cls.AddMethod(true, "EndVertical", BindStatic_EndVertical);
            cls.AddMethod(true, "BeginScrollView", BindStatic_BeginScrollView);
            cls.AddMethod(true, "EndScrollView", BindStatic_EndScrollView);
            cls.AddMethod(true, "PropertyField", BindStatic_PropertyField);
            cls.AddMethod(true, "GetControlRect", BindStatic_GetControlRect);
            cls.AddMethod(true, "BeginFadeGroup", BindStatic_BeginFadeGroup);
            cls.AddMethod(true, "EndFadeGroup", BindStatic_EndFadeGroup);
            cls.AddMethod(true, "BeginBuildTargetSelectionGrouping", BindStatic_BeginBuildTargetSelectionGrouping);
            cls.AddMethod(true, "EndBuildTargetSelectionGrouping", BindStatic_EndBuildTargetSelectionGrouping);
            cls.AddMethod(true, "DropdownButton", BindStatic_DropdownButton);
            cls.AddMethod(true, "BeginFoldoutHeaderGroup", BindStatic_BeginFoldoutHeaderGroup);
            cls.AddMethod(true, "EndFoldoutHeaderGroup", BindStatic_EndFoldoutHeaderGroup);
            cls.AddMethod(true, "GradientField", BindStatic_GradientField);
            cls.AddMethod(true, "Knob", BindStatic_Knob);
            cls.AddMethod(true, "EditorToolbarForTarget", BindStatic_EditorToolbarForTarget);
            cls.AddMethod(true, "ToolContextToolbarForTarget", BindStatic_ToolContextToolbarForTarget);
            cls.AddMethod(true, "EditorToolbar", BindStatic_EditorToolbar);
            return cls;
        }
    }
}
#endif
#endif
