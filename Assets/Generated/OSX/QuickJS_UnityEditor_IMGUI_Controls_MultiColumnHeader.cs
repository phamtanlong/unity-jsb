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
    // Type: UnityEditor.IMGUI.Controls.MultiColumnHeader
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_IMGUI_Controls_MultiColumnHeader
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.IMGUI.Controls.MultiColumnHeaderState arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.MultiColumnHeader), ".ctor", typeof(UnityEditor.IMGUI.Controls.MultiColumnHeaderState), 0);
                    }
                    var o = new UnityEditor.IMGUI.Controls.MultiColumnHeader(arg0);
                    var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                    return val;
                }
                throw new NoSuitableMethodException("constructor", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetSortingColumns(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEditor.IMGUI.Controls.MultiColumnHeader self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int[] arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.MultiColumnHeader), "SetSortingColumns", typeof(int[]), 0);
                    }
                    bool[] arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.MultiColumnHeader), "SetSortingColumns", typeof(bool[]), 1);
                    }
                    self.SetSortingColumns(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetSortingColumns", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetSorting(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEditor.IMGUI.Controls.MultiColumnHeader self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.MultiColumnHeader), "SetSorting", typeof(int), 0);
                    }
                    bool arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.MultiColumnHeader), "SetSorting", typeof(bool), 1);
                    }
                    self.SetSorting(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetSorting", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetSortDirection(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEditor.IMGUI.Controls.MultiColumnHeader self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.MultiColumnHeader), "SetSortDirection", typeof(int), 0);
                    }
                    bool arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.MultiColumnHeader), "SetSortDirection", typeof(bool), 1);
                    }
                    self.SetSortDirection(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetSortDirection", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_IsSortedAscending(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.IMGUI.Controls.MultiColumnHeader self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.MultiColumnHeader), "IsSortedAscending", typeof(int), 0);
                    }
                    var ret = self.IsSortedAscending(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsSortedAscending", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetColumn(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.IMGUI.Controls.MultiColumnHeader self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.MultiColumnHeader), "GetColumn", typeof(int), 0);
                    }
                    var ret = self.GetColumn(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetColumn", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_IsColumnVisible(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.IMGUI.Controls.MultiColumnHeader self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.MultiColumnHeader), "IsColumnVisible", typeof(int), 0);
                    }
                    var ret = self.IsColumnVisible(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsColumnVisible", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetVisibleColumnIndex(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.IMGUI.Controls.MultiColumnHeader self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.MultiColumnHeader), "GetVisibleColumnIndex", typeof(int), 0);
                    }
                    var ret = self.GetVisibleColumnIndex(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetVisibleColumnIndex", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetCellRect(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEditor.IMGUI.Controls.MultiColumnHeader self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.MultiColumnHeader), "GetCellRect", typeof(int), 0);
                    }
                    UnityEngine.Rect arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.MultiColumnHeader), "GetCellRect", typeof(UnityEngine.Rect), 1);
                    }
                    var ret = self.GetCellRect(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetCellRect", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetColumnRect(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.IMGUI.Controls.MultiColumnHeader self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.MultiColumnHeader), "GetColumnRect", typeof(int), 0);
                    }
                    var ret = self.GetColumnRect(arg0);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetColumnRect", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ResizeToFit(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.IMGUI.Controls.MultiColumnHeader self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.ResizeToFit();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ResizeToFit", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_OnGUI(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEditor.IMGUI.Controls.MultiColumnHeader self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Rect arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.MultiColumnHeader), "OnGUI", typeof(UnityEngine.Rect), 0);
                    }
                    float arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.MultiColumnHeader), "OnGUI", typeof(float), 1);
                    }
                    self.OnGUI(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("OnGUI", argc);
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
                    UnityEditor.IMGUI.Controls.MultiColumnHeader self;
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
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_sortedColumnIndex(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.IMGUI.Controls.MultiColumnHeader self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.sortedColumnIndex;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_sortedColumnIndex(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.IMGUI.Controls.MultiColumnHeader self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.MultiColumnHeader), "sortedColumnIndex", typeof(int), 0);
                }
                self.sortedColumnIndex = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_state(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.IMGUI.Controls.MultiColumnHeader self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.state;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_state(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.IMGUI.Controls.MultiColumnHeader self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEditor.IMGUI.Controls.MultiColumnHeaderState value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.MultiColumnHeader), "state", typeof(UnityEditor.IMGUI.Controls.MultiColumnHeaderState), 0);
                }
                self.state = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_height(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.IMGUI.Controls.MultiColumnHeader self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.height;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_height(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.IMGUI.Controls.MultiColumnHeader self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.MultiColumnHeader), "height", typeof(float), 0);
                }
                self.height = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_canSort(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.IMGUI.Controls.MultiColumnHeader self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.canSort;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_canSort(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.IMGUI.Controls.MultiColumnHeader self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.MultiColumnHeader), "canSort", typeof(bool), 0);
                }
                self.canSort = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindEvent_sortingChanged(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                UnityEditor.IMGUI.Controls.MultiColumnHeader self;
                Values.js_get_classvalue(ctx, this_obj, out self);
                UnityEditor.IMGUI.Controls.MultiColumnHeader.HeaderCallback value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.MultiColumnHeader), "sortingChanged", typeof(UnityEditor.IMGUI.Controls.MultiColumnHeader.HeaderCallback), 1);
                        }
                        self.sortingChanged += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.MultiColumnHeader), "sortingChanged", typeof(UnityEditor.IMGUI.Controls.MultiColumnHeader.HeaderCallback), 1);
                        }
                        self.sortingChanged -= value;
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
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindEvent_visibleColumnsChanged(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                UnityEditor.IMGUI.Controls.MultiColumnHeader self;
                Values.js_get_classvalue(ctx, this_obj, out self);
                UnityEditor.IMGUI.Controls.MultiColumnHeader.HeaderCallback value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.MultiColumnHeader), "visibleColumnsChanged", typeof(UnityEditor.IMGUI.Controls.MultiColumnHeader.HeaderCallback), 1);
                        }
                        self.visibleColumnsChanged += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.MultiColumnHeader), "visibleColumnsChanged", typeof(UnityEditor.IMGUI.Controls.MultiColumnHeader.HeaderCallback), 1);
                        }
                        self.visibleColumnsChanged -= value;
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
            var cls = register.CreateClass("MultiColumnHeader", typeof(UnityEditor.IMGUI.Controls.MultiColumnHeader), BindConstructor);
            cls.AddMethod(false, "SetSortingColumns", Bind_SetSortingColumns);
            cls.AddMethod(false, "SetSorting", Bind_SetSorting);
            cls.AddMethod(false, "SetSortDirection", Bind_SetSortDirection);
            cls.AddMethod(false, "IsSortedAscending", Bind_IsSortedAscending);
            cls.AddMethod(false, "GetColumn", Bind_GetColumn);
            cls.AddMethod(false, "IsColumnVisible", Bind_IsColumnVisible);
            cls.AddMethod(false, "GetVisibleColumnIndex", Bind_GetVisibleColumnIndex);
            cls.AddMethod(false, "GetCellRect", Bind_GetCellRect);
            cls.AddMethod(false, "GetColumnRect", Bind_GetColumnRect);
            cls.AddMethod(false, "ResizeToFit", Bind_ResizeToFit);
            cls.AddMethod(false, "OnGUI", Bind_OnGUI);
            cls.AddMethod(false, "Repaint", Bind_Repaint);
            cls.AddProperty(false, "sortedColumnIndex", BindRead_sortedColumnIndex, BindWrite_sortedColumnIndex);
            cls.AddProperty(false, "state", BindRead_state, BindWrite_state);
            cls.AddProperty(false, "height", BindRead_height, BindWrite_height);
            cls.AddProperty(false, "canSort", BindRead_canSort, BindWrite_canSort);
            cls.AddMethod(false, "sortingChanged", BindEvent_sortingChanged);
            cls.AddMethod(false, "visibleColumnsChanged", BindEvent_visibleColumnsChanged);
            return cls;
        }
    }
}
#endif
#endif
