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
    // Type: UnityEditor.EditorGUILayout+ScrollViewScope
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_EditorGUILayout_ScrollViewScope
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
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
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout.ScrollViewScope), ".ctor", typeof(UnityEngine.Vector2), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout.ScrollViewScope), ".ctor", typeof(bool), 1);
                            }
                            bool arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout.ScrollViewScope), ".ctor", typeof(bool), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout.ScrollViewScope), ".ctor", typeof(UnityEngine.GUIStyle), 3);
                            }
                            UnityEngine.GUIStyle arg4;
                            if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout.ScrollViewScope), ".ctor", typeof(UnityEngine.GUIStyle), 4);
                            }
                            UnityEngine.GUIStyle arg5;
                            if (!Values.js_get_classvalue(ctx, argv[5], out arg5))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout.ScrollViewScope), ".ctor", typeof(UnityEngine.GUIStyle), 5);
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
                            var o = new UnityEditor.EditorGUILayout.ScrollViewScope(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
                            var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                            return val;
                        }
                    }
                    if (argc >= 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector2)) && Values.js_match_type(ctx, argv[1], typeof(bool)) && Values.js_match_type(ctx, argv[2], typeof(bool)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.Vector2 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout.ScrollViewScope), ".ctor", typeof(UnityEngine.Vector2), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout.ScrollViewScope), ".ctor", typeof(bool), 1);
                            }
                            bool arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout.ScrollViewScope), ".ctor", typeof(bool), 2);
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
                            var o = new UnityEditor.EditorGUILayout.ScrollViewScope(arg0, arg1, arg2, arg3);
                            var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                            return val;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector2)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 3, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.Vector2 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout.ScrollViewScope), ".ctor", typeof(UnityEngine.Vector2), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout.ScrollViewScope), ".ctor", typeof(UnityEngine.GUIStyle), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout.ScrollViewScope), ".ctor", typeof(UnityEngine.GUIStyle), 2);
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
                            var o = new UnityEditor.EditorGUILayout.ScrollViewScope(arg0, arg1, arg2, arg3);
                            var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                            return val;
                        }
                    }
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector2)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.Vector2 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout.ScrollViewScope), ".ctor", typeof(UnityEngine.Vector2), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout.ScrollViewScope), ".ctor", typeof(UnityEngine.GUIStyle), 1);
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
                            var o = new UnityEditor.EditorGUILayout.ScrollViewScope(arg0, arg1, arg2);
                            var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                            return val;
                        }
                    }
                    if (argc >= 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector2)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.Vector2 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout.ScrollViewScope), ".ctor", typeof(UnityEngine.Vector2), 0);
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
                            var o = new UnityEditor.EditorGUILayout.ScrollViewScope(arg0, arg1);
                            var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                            return val;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("constructor", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_scrollPosition(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.EditorGUILayout.ScrollViewScope self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.scrollPosition;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_handleScrollWheel(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.EditorGUILayout.ScrollViewScope self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.handleScrollWheel;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_handleScrollWheel(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.EditorGUILayout.ScrollViewScope self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorGUILayout.ScrollViewScope), "handleScrollWheel", typeof(bool), 0);
                }
                self.handleScrollWheel = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("ScrollViewScope", typeof(UnityEditor.EditorGUILayout.ScrollViewScope), BindConstructor);
            cls.AddProperty(false, "scrollPosition", BindRead_scrollPosition, null);
            cls.AddProperty(false, "handleScrollWheel", BindRead_handleScrollWheel, BindWrite_handleScrollWheel);
            return cls;
        }
    }
}
#endif
#endif
