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
    // Type: UnityEditor.EditorWindow
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_EditorWindow
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_BeginWindows(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.EditorWindow self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.BeginWindows();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("BeginWindows", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_EndWindows(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.EditorWindow self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.EndWindows();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("EndWindows", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ShowNotification(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        UnityEditor.EditorWindow self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.GUIContent arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorWindow), "ShowNotification", typeof(UnityEngine.GUIContent), 0);
                        }
                        double arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorWindow), "ShowNotification", typeof(double), 1);
                        }
                        self.ShowNotification(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 1)
                    {
                        UnityEditor.EditorWindow self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.GUIContent arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorWindow), "ShowNotification", typeof(UnityEngine.GUIContent), 0);
                        }
                        self.ShowNotification(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("ShowNotification", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_RemoveNotification(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.EditorWindow self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.RemoveNotification();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RemoveNotification", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ShowTab(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.EditorWindow self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.ShowTab();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ShowTab", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Focus(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.EditorWindow self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.Focus();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Focus", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ShowUtility(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.EditorWindow self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.ShowUtility();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ShowUtility", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ShowPopup(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.EditorWindow self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.ShowPopup();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ShowPopup", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ShowModalUtility(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.EditorWindow self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.ShowModalUtility();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ShowModalUtility", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ShowAsDropDown(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEditor.EditorWindow self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Rect arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorWindow), "ShowAsDropDown", typeof(UnityEngine.Rect), 0);
                    }
                    UnityEngine.Vector2 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorWindow), "ShowAsDropDown", typeof(UnityEngine.Vector2), 1);
                    }
                    self.ShowAsDropDown(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ShowAsDropDown", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Show(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        UnityEditor.EditorWindow self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        bool arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorWindow), "Show", typeof(bool), 0);
                        }
                        self.Show(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 0)
                    {
                        UnityEditor.EditorWindow self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        self.Show();
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("Show", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ShowAuxWindow(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.EditorWindow self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.ShowAuxWindow();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ShowAuxWindow", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ShowModal(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.EditorWindow self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.ShowModal();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ShowModal", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Close(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.EditorWindow self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.Close();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Close", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Repaint(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.EditorWindow self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.Repaint();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Repaint", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SendEvent(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.EditorWindow self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Event arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorWindow), "SendEvent", typeof(UnityEngine.Event), 0);
                    }
                    var ret = self.SendEvent(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("SendEvent", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetExtraPaneTypes(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.EditorWindow self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.GetExtraPaneTypes();
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetExtraPaneTypes", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_FocusWindowIfItsOpen(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    System.Type arg0;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorWindow), "FocusWindowIfItsOpen", typeof(System.Type), 0);
                    }
                    UnityEditor.EditorWindow.FocusWindowIfItsOpen(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("FocusWindowIfItsOpen", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_rootVisualElement(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.EditorWindow self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.rootVisualElement;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_wantsMouseMove(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.EditorWindow self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.wantsMouseMove;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_wantsMouseMove(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.EditorWindow self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorWindow), "wantsMouseMove", typeof(bool), 0);
                }
                self.wantsMouseMove = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_wantsMouseEnterLeaveWindow(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.EditorWindow self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.wantsMouseEnterLeaveWindow;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_wantsMouseEnterLeaveWindow(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.EditorWindow self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorWindow), "wantsMouseEnterLeaveWindow", typeof(bool), 0);
                }
                self.wantsMouseEnterLeaveWindow = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_autoRepaintOnSceneChange(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.EditorWindow self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.autoRepaintOnSceneChange;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_autoRepaintOnSceneChange(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.EditorWindow self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorWindow), "autoRepaintOnSceneChange", typeof(bool), 0);
                }
                self.autoRepaintOnSceneChange = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_maximized(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.EditorWindow self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.maximized;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_maximized(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.EditorWindow self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorWindow), "maximized", typeof(bool), 0);
                }
                self.maximized = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_focusedWindow(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorWindow.focusedWindow;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_mouseOverWindow(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorWindow.mouseOverWindow;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_minSize(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.EditorWindow self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.minSize;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_minSize(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.EditorWindow self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Vector2 value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorWindow), "minSize", typeof(UnityEngine.Vector2), 0);
                }
                self.minSize = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_maxSize(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.EditorWindow self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.maxSize;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_maxSize(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.EditorWindow self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Vector2 value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorWindow), "maxSize", typeof(UnityEngine.Vector2), 0);
                }
                self.maxSize = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_titleContent(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.EditorWindow self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.titleContent;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_titleContent(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.EditorWindow self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.GUIContent value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorWindow), "titleContent", typeof(UnityEngine.GUIContent), 0);
                }
                self.titleContent = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_depthBufferBits(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.EditorWindow self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.depthBufferBits;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_depthBufferBits(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.EditorWindow self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorWindow), "depthBufferBits", typeof(int), 0);
                }
                self.depthBufferBits = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_position(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.EditorWindow self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.position;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_position(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.EditorWindow self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Rect value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorWindow), "position", typeof(UnityEngine.Rect), 0);
                }
                self.position = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("EditorWindow", typeof(UnityEditor.EditorWindow), QuickJS.Binding.CommonFix.CrossBindConstructor);
            cls.AddMethod(false, "BeginWindows", Bind_BeginWindows);
            cls.AddMethod(false, "EndWindows", Bind_EndWindows);
            cls.AddMethod(false, "ShowNotification", Bind_ShowNotification);
            cls.AddMethod(false, "RemoveNotification", Bind_RemoveNotification);
            cls.AddMethod(false, "ShowTab", Bind_ShowTab);
            cls.AddMethod(false, "Focus", Bind_Focus);
            cls.AddMethod(false, "ShowUtility", Bind_ShowUtility);
            cls.AddMethod(false, "ShowPopup", Bind_ShowPopup);
            cls.AddMethod(false, "ShowModalUtility", Bind_ShowModalUtility);
            cls.AddMethod(false, "ShowAsDropDown", Bind_ShowAsDropDown);
            cls.AddMethod(false, "Show", Bind_Show);
            cls.AddMethod(false, "ShowAuxWindow", Bind_ShowAuxWindow);
            cls.AddMethod(false, "ShowModal", Bind_ShowModal);
            cls.AddMethod(false, "Close", Bind_Close);
            cls.AddMethod(false, "Repaint", Bind_Repaint);
            cls.AddMethod(false, "SendEvent", Bind_SendEvent);
            cls.AddMethod(false, "GetExtraPaneTypes", Bind_GetExtraPaneTypes);
            cls.AddMethod(true, "GetWindow", QuickJS.Unity.EditorWindowFix.BindStatic_GetWindow);
            cls.AddMethod(true, "FocusWindowIfItsOpen", BindStatic_FocusWindowIfItsOpen);
            cls.AddRawMethod(true, "CreateWindow", QuickJS.Unity.EditorWindowFix.CreateWindow);
            cls.AddProperty(false, "rootVisualElement", BindRead_rootVisualElement, null);
            cls.AddProperty(false, "wantsMouseMove", BindRead_wantsMouseMove, BindWrite_wantsMouseMove);
            cls.AddProperty(false, "wantsMouseEnterLeaveWindow", BindRead_wantsMouseEnterLeaveWindow, BindWrite_wantsMouseEnterLeaveWindow);
            cls.AddProperty(false, "autoRepaintOnSceneChange", BindRead_autoRepaintOnSceneChange, BindWrite_autoRepaintOnSceneChange);
            cls.AddProperty(false, "maximized", BindRead_maximized, BindWrite_maximized);
            cls.AddProperty(true, "focusedWindow", BindStaticRead_focusedWindow, null);
            cls.AddProperty(true, "mouseOverWindow", BindStaticRead_mouseOverWindow, null);
            cls.AddProperty(false, "minSize", BindRead_minSize, BindWrite_minSize);
            cls.AddProperty(false, "maxSize", BindRead_maxSize, BindWrite_maxSize);
            cls.AddProperty(false, "titleContent", BindRead_titleContent, BindWrite_titleContent);
            cls.AddProperty(false, "depthBufferBits", BindRead_depthBufferBits, BindWrite_depthBufferBits);
            cls.AddProperty(false, "position", BindRead_position, BindWrite_position);
            return cls;
        }
    }
}
#endif
#endif
