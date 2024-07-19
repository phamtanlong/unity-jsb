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
    // Type: UnityEditor.EditorGUILayout+HorizontalScope
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_EditorGUILayout_HorizontalScope
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
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIStyle)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.GUILayoutOption)))
                        {
                            UnityEngine.GUIStyle arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUILayout.HorizontalScope), ".ctor", typeof(UnityEngine.GUIStyle), 0);
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
                            var o = new UnityEditor.EditorGUILayout.HorizontalScope(arg0, arg1);
                            var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                            return val;
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
                        var o = new UnityEditor.EditorGUILayout.HorizontalScope(arg0);
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
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_rect(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.EditorGUILayout.HorizontalScope self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.rect;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("HorizontalScope", typeof(UnityEditor.EditorGUILayout.HorizontalScope), BindConstructor);
            cls.AddProperty(false, "rect", BindRead_rect, null);
            return cls;
        }
    }
}
#endif
#endif
