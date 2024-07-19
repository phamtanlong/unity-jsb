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
    // Type: UnityEditor.EditorSnapSettings
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_EditorSnapSettings
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ResetSnapSettings(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.EditorSnapSettings.ResetSnapSettings();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ResetSnapSettings", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_gridSnapEnabled(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorSnapSettings.gridSnapEnabled;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_gridSnapEnabled(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorSnapSettings), "gridSnapEnabled", typeof(bool), 0);
                }
                UnityEditor.EditorSnapSettings.gridSnapEnabled = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_move(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorSnapSettings.move;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_move(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Vector3 value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorSnapSettings), "move", typeof(UnityEngine.Vector3), 0);
                }
                UnityEditor.EditorSnapSettings.move = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_rotate(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorSnapSettings.rotate;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_rotate(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorSnapSettings), "rotate", typeof(float), 0);
                }
                UnityEditor.EditorSnapSettings.rotate = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_scale(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorSnapSettings.scale;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_scale(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorSnapSettings), "scale", typeof(float), 0);
                }
                UnityEditor.EditorSnapSettings.scale = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("EditorSnapSettings", typeof(UnityEditor.EditorSnapSettings), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "ResetSnapSettings", BindStatic_ResetSnapSettings);
            cls.AddProperty(true, "gridSnapEnabled", BindStaticRead_gridSnapEnabled, BindStaticWrite_gridSnapEnabled);
            cls.AddProperty(true, "move", BindStaticRead_move, BindStaticWrite_move);
            cls.AddProperty(true, "rotate", BindStaticRead_rotate, BindStaticWrite_rotate);
            cls.AddProperty(true, "scale", BindStaticRead_scale, BindStaticWrite_scale);
            return cls;
        }
    }
}
#endif
#endif
