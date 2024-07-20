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
    // Type: UnityEditor.EditorStyles
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_EditorStyles
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                if (argc == 0)
                {
                    var o = new UnityEditor.EditorStyles();
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
        public static JSValue BindStatic_FromUSS(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        UnityEngine.GUIStyle arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorStyles), "FromUSS", typeof(UnityEngine.GUIStyle), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorStyles), "FromUSS", typeof(string), 1);
                        }
                        string arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorStyles), "FromUSS", typeof(string), 2);
                        }
                        var ret = UnityEditor.EditorStyles.FromUSS(arg0, arg1, arg2);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 2)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorStyles), "FromUSS", typeof(string), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorStyles), "FromUSS", typeof(string), 1);
                        }
                        var ret = UnityEditor.EditorStyles.FromUSS(arg0, arg1);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("FromUSS", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ApplyUSS(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.GUIStyle arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorStyles), "ApplyUSS", typeof(UnityEngine.GUIStyle), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorStyles), "ApplyUSS", typeof(string), 1);
                    }
                    string arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorStyles), "ApplyUSS", typeof(string), 2);
                    }
                    var ret = UnityEditor.EditorStyles.ApplyUSS(arg0, arg1, arg2);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("ApplyUSS", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_label(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.label;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_miniLabel(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.miniLabel;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_largeLabel(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.largeLabel;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_boldLabel(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.boldLabel;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_miniBoldLabel(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.miniBoldLabel;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_centeredGreyMiniLabel(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.centeredGreyMiniLabel;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_wordWrappedMiniLabel(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.wordWrappedMiniLabel;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_wordWrappedLabel(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.wordWrappedLabel;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_linkLabel(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.linkLabel;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_whiteLabel(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.whiteLabel;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_whiteMiniLabel(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.whiteMiniLabel;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_whiteLargeLabel(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.whiteLargeLabel;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_whiteBoldLabel(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.whiteBoldLabel;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_radioButton(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.radioButton;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_miniButton(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.miniButton;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_miniButtonLeft(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.miniButtonLeft;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_miniButtonMid(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.miniButtonMid;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_miniButtonRight(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.miniButtonRight;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_miniPullDown(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.miniPullDown;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_textField(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.textField;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_textArea(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.textArea;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_miniTextField(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.miniTextField;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_numberField(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.numberField;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_popup(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.popup;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_objectField(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.objectField;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_objectFieldThumb(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.objectFieldThumb;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_objectFieldMiniThumb(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.objectFieldMiniThumb;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_colorField(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.colorField;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_layerMaskField(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.layerMaskField;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_toggle(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.toggle;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_foldout(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.foldout;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_foldoutPreDrop(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.foldoutPreDrop;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_foldoutHeader(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.foldoutHeader;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_foldoutHeaderIcon(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.foldoutHeaderIcon;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_toggleGroup(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.toggleGroup;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_standardFont(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.standardFont;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_boldFont(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.boldFont;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_miniFont(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.miniFont;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_miniBoldFont(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.miniBoldFont;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_toolbar(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.toolbar;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_toolbarButton(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.toolbarButton;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_toolbarPopup(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.toolbarPopup;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_toolbarDropDown(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.toolbarDropDown;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_toolbarTextField(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.toolbarTextField;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_inspectorDefaultMargins(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.inspectorDefaultMargins;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_inspectorFullWidthMargins(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.inspectorFullWidthMargins;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_helpBox(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.helpBox;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_toolbarSearchField(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.toolbarSearchField;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_iconButton(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.iconButton;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_selectionRect(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorStyles.selectionRect;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("EditorStyles", typeof(UnityEditor.EditorStyles), BindConstructor);
            cls.AddMethod(true, "FromUSS", BindStatic_FromUSS);
            cls.AddMethod(true, "ApplyUSS", BindStatic_ApplyUSS);
            cls.AddProperty(true, "label", BindStaticRead_label, null);
            cls.AddProperty(true, "miniLabel", BindStaticRead_miniLabel, null);
            cls.AddProperty(true, "largeLabel", BindStaticRead_largeLabel, null);
            cls.AddProperty(true, "boldLabel", BindStaticRead_boldLabel, null);
            cls.AddProperty(true, "miniBoldLabel", BindStaticRead_miniBoldLabel, null);
            cls.AddProperty(true, "centeredGreyMiniLabel", BindStaticRead_centeredGreyMiniLabel, null);
            cls.AddProperty(true, "wordWrappedMiniLabel", BindStaticRead_wordWrappedMiniLabel, null);
            cls.AddProperty(true, "wordWrappedLabel", BindStaticRead_wordWrappedLabel, null);
            cls.AddProperty(true, "linkLabel", BindStaticRead_linkLabel, null);
            cls.AddProperty(true, "whiteLabel", BindStaticRead_whiteLabel, null);
            cls.AddProperty(true, "whiteMiniLabel", BindStaticRead_whiteMiniLabel, null);
            cls.AddProperty(true, "whiteLargeLabel", BindStaticRead_whiteLargeLabel, null);
            cls.AddProperty(true, "whiteBoldLabel", BindStaticRead_whiteBoldLabel, null);
            cls.AddProperty(true, "radioButton", BindStaticRead_radioButton, null);
            cls.AddProperty(true, "miniButton", BindStaticRead_miniButton, null);
            cls.AddProperty(true, "miniButtonLeft", BindStaticRead_miniButtonLeft, null);
            cls.AddProperty(true, "miniButtonMid", BindStaticRead_miniButtonMid, null);
            cls.AddProperty(true, "miniButtonRight", BindStaticRead_miniButtonRight, null);
            cls.AddProperty(true, "miniPullDown", BindStaticRead_miniPullDown, null);
            cls.AddProperty(true, "textField", BindStaticRead_textField, null);
            cls.AddProperty(true, "textArea", BindStaticRead_textArea, null);
            cls.AddProperty(true, "miniTextField", BindStaticRead_miniTextField, null);
            cls.AddProperty(true, "numberField", BindStaticRead_numberField, null);
            cls.AddProperty(true, "popup", BindStaticRead_popup, null);
            cls.AddProperty(true, "objectField", BindStaticRead_objectField, null);
            cls.AddProperty(true, "objectFieldThumb", BindStaticRead_objectFieldThumb, null);
            cls.AddProperty(true, "objectFieldMiniThumb", BindStaticRead_objectFieldMiniThumb, null);
            cls.AddProperty(true, "colorField", BindStaticRead_colorField, null);
            cls.AddProperty(true, "layerMaskField", BindStaticRead_layerMaskField, null);
            cls.AddProperty(true, "toggle", BindStaticRead_toggle, null);
            cls.AddProperty(true, "foldout", BindStaticRead_foldout, null);
            cls.AddProperty(true, "foldoutPreDrop", BindStaticRead_foldoutPreDrop, null);
            cls.AddProperty(true, "foldoutHeader", BindStaticRead_foldoutHeader, null);
            cls.AddProperty(true, "foldoutHeaderIcon", BindStaticRead_foldoutHeaderIcon, null);
            cls.AddProperty(true, "toggleGroup", BindStaticRead_toggleGroup, null);
            cls.AddProperty(true, "standardFont", BindStaticRead_standardFont, null);
            cls.AddProperty(true, "boldFont", BindStaticRead_boldFont, null);
            cls.AddProperty(true, "miniFont", BindStaticRead_miniFont, null);
            cls.AddProperty(true, "miniBoldFont", BindStaticRead_miniBoldFont, null);
            cls.AddProperty(true, "toolbar", BindStaticRead_toolbar, null);
            cls.AddProperty(true, "toolbarButton", BindStaticRead_toolbarButton, null);
            cls.AddProperty(true, "toolbarPopup", BindStaticRead_toolbarPopup, null);
            cls.AddProperty(true, "toolbarDropDown", BindStaticRead_toolbarDropDown, null);
            cls.AddProperty(true, "toolbarTextField", BindStaticRead_toolbarTextField, null);
            cls.AddProperty(true, "inspectorDefaultMargins", BindStaticRead_inspectorDefaultMargins, null);
            cls.AddProperty(true, "inspectorFullWidthMargins", BindStaticRead_inspectorFullWidthMargins, null);
            cls.AddProperty(true, "helpBox", BindStaticRead_helpBox, null);
            cls.AddProperty(true, "toolbarSearchField", BindStaticRead_toolbarSearchField, null);
            cls.AddProperty(true, "iconButton", BindStaticRead_iconButton, null);
            cls.AddProperty(true, "selectionRect", BindStaticRead_selectionRect, null);
            return cls;
        }
    }
}
#endif
#endif
