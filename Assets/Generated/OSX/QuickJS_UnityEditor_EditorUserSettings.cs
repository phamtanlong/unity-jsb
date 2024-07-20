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
    // Type: UnityEditor.EditorUserSettings
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_EditorUserSettings
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetConfigValue(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUserSettings), "GetConfigValue", typeof(string), 0);
                    }
                    var ret = UnityEditor.EditorUserSettings.GetConfigValue(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetConfigValue", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetConfigValue(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUserSettings), "SetConfigValue", typeof(string), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUserSettings), "SetConfigValue", typeof(string), 1);
                    }
                    UnityEditor.EditorUserSettings.SetConfigValue(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetConfigValue", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_AutomaticAdd(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserSettings.AutomaticAdd;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_AutomaticAdd(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserSettings), "AutomaticAdd", typeof(bool), 0);
                }
                UnityEditor.EditorUserSettings.AutomaticAdd = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_WorkOffline(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserSettings.WorkOffline;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_WorkOffline(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserSettings), "WorkOffline", typeof(bool), 0);
                }
                UnityEditor.EditorUserSettings.WorkOffline = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_showFailedCheckout(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserSettings.showFailedCheckout;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_showFailedCheckout(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserSettings), "showFailedCheckout", typeof(bool), 0);
                }
                UnityEditor.EditorUserSettings.showFailedCheckout = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_overwriteFailedCheckoutAssets(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserSettings.overwriteFailedCheckoutAssets;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_overwriteFailedCheckoutAssets(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserSettings), "overwriteFailedCheckoutAssets", typeof(bool), 0);
                }
                UnityEditor.EditorUserSettings.overwriteFailedCheckoutAssets = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_overlayIcons(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserSettings.overlayIcons;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_overlayIcons(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserSettings), "overlayIcons", typeof(bool), 0);
                }
                UnityEditor.EditorUserSettings.overlayIcons = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_hierarchyOverlayIcons(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserSettings.hierarchyOverlayIcons;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_hierarchyOverlayIcons(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserSettings), "hierarchyOverlayIcons", typeof(bool), 0);
                }
                UnityEditor.EditorUserSettings.hierarchyOverlayIcons = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_otherOverlayIcons(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserSettings.otherOverlayIcons;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_otherOverlayIcons(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserSettings), "otherOverlayIcons", typeof(bool), 0);
                }
                UnityEditor.EditorUserSettings.otherOverlayIcons = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_allowAsyncStatusUpdate(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserSettings.allowAsyncStatusUpdate;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_allowAsyncStatusUpdate(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserSettings), "allowAsyncStatusUpdate", typeof(bool), 0);
                }
                UnityEditor.EditorUserSettings.allowAsyncStatusUpdate = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_artifactGarbageCollection(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserSettings.artifactGarbageCollection;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_artifactGarbageCollection(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserSettings), "artifactGarbageCollection", typeof(bool), 0);
                }
                UnityEditor.EditorUserSettings.artifactGarbageCollection = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_semanticMergeMode(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserSettings.semanticMergeMode;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_semanticMergeMode(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.SemanticMergeMode value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserSettings), "semanticMergeMode", typeof(UnityEditor.SemanticMergeMode), 0);
                }
                UnityEditor.EditorUserSettings.semanticMergeMode = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_desiredImportWorkerCount(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserSettings.desiredImportWorkerCount;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_desiredImportWorkerCount(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserSettings), "desiredImportWorkerCount", typeof(int), 0);
                }
                UnityEditor.EditorUserSettings.desiredImportWorkerCount = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_standbyImportWorkerCount(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserSettings.standbyImportWorkerCount;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_standbyImportWorkerCount(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserSettings), "standbyImportWorkerCount", typeof(int), 0);
                }
                UnityEditor.EditorUserSettings.standbyImportWorkerCount = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_idleImportWorkerShutdownDelayMilliseconds(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserSettings.idleImportWorkerShutdownDelayMilliseconds;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_idleImportWorkerShutdownDelayMilliseconds(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserSettings), "idleImportWorkerShutdownDelayMilliseconds", typeof(int), 0);
                }
                UnityEditor.EditorUserSettings.idleImportWorkerShutdownDelayMilliseconds = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("EditorUserSettings", typeof(UnityEditor.EditorUserSettings), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "GetConfigValue", BindStatic_GetConfigValue);
            cls.AddMethod(true, "SetConfigValue", BindStatic_SetConfigValue);
            cls.AddProperty(true, "AutomaticAdd", BindStaticRead_AutomaticAdd, BindStaticWrite_AutomaticAdd);
            cls.AddProperty(true, "WorkOffline", BindStaticRead_WorkOffline, BindStaticWrite_WorkOffline);
            cls.AddProperty(true, "showFailedCheckout", BindStaticRead_showFailedCheckout, BindStaticWrite_showFailedCheckout);
            cls.AddProperty(true, "overwriteFailedCheckoutAssets", BindStaticRead_overwriteFailedCheckoutAssets, BindStaticWrite_overwriteFailedCheckoutAssets);
            cls.AddProperty(true, "overlayIcons", BindStaticRead_overlayIcons, BindStaticWrite_overlayIcons);
            cls.AddProperty(true, "hierarchyOverlayIcons", BindStaticRead_hierarchyOverlayIcons, BindStaticWrite_hierarchyOverlayIcons);
            cls.AddProperty(true, "otherOverlayIcons", BindStaticRead_otherOverlayIcons, BindStaticWrite_otherOverlayIcons);
            cls.AddProperty(true, "allowAsyncStatusUpdate", BindStaticRead_allowAsyncStatusUpdate, BindStaticWrite_allowAsyncStatusUpdate);
            cls.AddProperty(true, "artifactGarbageCollection", BindStaticRead_artifactGarbageCollection, BindStaticWrite_artifactGarbageCollection);
            cls.AddProperty(true, "semanticMergeMode", BindStaticRead_semanticMergeMode, BindStaticWrite_semanticMergeMode);
            cls.AddProperty(true, "desiredImportWorkerCount", BindStaticRead_desiredImportWorkerCount, BindStaticWrite_desiredImportWorkerCount);
            cls.AddProperty(true, "standbyImportWorkerCount", BindStaticRead_standbyImportWorkerCount, BindStaticWrite_standbyImportWorkerCount);
            cls.AddProperty(true, "idleImportWorkerShutdownDelayMilliseconds", BindStaticRead_idleImportWorkerShutdownDelayMilliseconds, BindStaticWrite_idleImportWorkerShutdownDelayMilliseconds);
            return cls;
        }
    }
}
#endif
#endif
