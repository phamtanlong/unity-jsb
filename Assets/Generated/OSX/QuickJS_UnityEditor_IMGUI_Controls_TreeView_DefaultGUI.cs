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
    // Type: UnityEditor.IMGUI.Controls.TreeView+DefaultGUI
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_IMGUI_Controls_TreeView_DefaultGUI
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_FoldoutLabel(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 4)
                {
                    UnityEngine.Rect arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.TreeView.DefaultGUI), "FoldoutLabel", typeof(UnityEngine.Rect), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.TreeView.DefaultGUI), "FoldoutLabel", typeof(string), 1);
                    }
                    bool arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.TreeView.DefaultGUI), "FoldoutLabel", typeof(bool), 2);
                    }
                    bool arg3;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.TreeView.DefaultGUI), "FoldoutLabel", typeof(bool), 3);
                    }
                    UnityEditor.IMGUI.Controls.TreeView.DefaultGUI.FoldoutLabel(arg0, arg1, arg2, arg3);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("FoldoutLabel", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Label(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 4)
                {
                    UnityEngine.Rect arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.TreeView.DefaultGUI), "Label", typeof(UnityEngine.Rect), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.TreeView.DefaultGUI), "Label", typeof(string), 1);
                    }
                    bool arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.TreeView.DefaultGUI), "Label", typeof(bool), 2);
                    }
                    bool arg3;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.TreeView.DefaultGUI), "Label", typeof(bool), 3);
                    }
                    UnityEditor.IMGUI.Controls.TreeView.DefaultGUI.Label(arg0, arg1, arg2, arg3);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Label", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_LabelRightAligned(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 4)
                {
                    UnityEngine.Rect arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.TreeView.DefaultGUI), "LabelRightAligned", typeof(UnityEngine.Rect), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.TreeView.DefaultGUI), "LabelRightAligned", typeof(string), 1);
                    }
                    bool arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.TreeView.DefaultGUI), "LabelRightAligned", typeof(bool), 2);
                    }
                    bool arg3;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.TreeView.DefaultGUI), "LabelRightAligned", typeof(bool), 3);
                    }
                    UnityEditor.IMGUI.Controls.TreeView.DefaultGUI.LabelRightAligned(arg0, arg1, arg2, arg3);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("LabelRightAligned", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_BoldLabel(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 4)
                {
                    UnityEngine.Rect arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.TreeView.DefaultGUI), "BoldLabel", typeof(UnityEngine.Rect), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.TreeView.DefaultGUI), "BoldLabel", typeof(string), 1);
                    }
                    bool arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.TreeView.DefaultGUI), "BoldLabel", typeof(bool), 2);
                    }
                    bool arg3;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.TreeView.DefaultGUI), "BoldLabel", typeof(bool), 3);
                    }
                    UnityEditor.IMGUI.Controls.TreeView.DefaultGUI.BoldLabel(arg0, arg1, arg2, arg3);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("BoldLabel", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_BoldLabelRightAligned(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 4)
                {
                    UnityEngine.Rect arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.TreeView.DefaultGUI), "BoldLabelRightAligned", typeof(UnityEngine.Rect), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.TreeView.DefaultGUI), "BoldLabelRightAligned", typeof(string), 1);
                    }
                    bool arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.TreeView.DefaultGUI), "BoldLabelRightAligned", typeof(bool), 2);
                    }
                    bool arg3;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.TreeView.DefaultGUI), "BoldLabelRightAligned", typeof(bool), 3);
                    }
                    UnityEditor.IMGUI.Controls.TreeView.DefaultGUI.BoldLabelRightAligned(arg0, arg1, arg2, arg3);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("BoldLabelRightAligned", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("DefaultGUI", typeof(UnityEditor.IMGUI.Controls.TreeView.DefaultGUI), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "FoldoutLabel", BindStatic_FoldoutLabel);
            cls.AddMethod(true, "Label", BindStatic_Label);
            cls.AddMethod(true, "LabelRightAligned", BindStatic_LabelRightAligned);
            cls.AddMethod(true, "BoldLabel", BindStatic_BoldLabel);
            cls.AddMethod(true, "BoldLabelRightAligned", BindStatic_BoldLabelRightAligned);
            return cls;
        }
    }
}
#endif
#endif
