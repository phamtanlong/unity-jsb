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
    // Type: UnityEditor.EditorAnalyticsSessionInfo
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_EditorAnalyticsSessionInfo
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_id(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorAnalyticsSessionInfo.id;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_sessionCount(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorAnalyticsSessionInfo.sessionCount;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_elapsedTime(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorAnalyticsSessionInfo.elapsedTime;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_focusedElapsedTime(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorAnalyticsSessionInfo.focusedElapsedTime;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_playbackElapsedTime(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorAnalyticsSessionInfo.playbackElapsedTime;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_activeElapsedTime(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorAnalyticsSessionInfo.activeElapsedTime;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_userId(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorAnalyticsSessionInfo.userId;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("EditorAnalyticsSessionInfo", typeof(UnityEditor.EditorAnalyticsSessionInfo), QuickJS.JSNative.class_private_ctor);
            cls.AddProperty(true, "id", BindStaticRead_id, null);
            cls.AddProperty(true, "sessionCount", BindStaticRead_sessionCount, null);
            cls.AddProperty(true, "elapsedTime", BindStaticRead_elapsedTime, null);
            cls.AddProperty(true, "focusedElapsedTime", BindStaticRead_focusedElapsedTime, null);
            cls.AddProperty(true, "playbackElapsedTime", BindStaticRead_playbackElapsedTime, null);
            cls.AddProperty(true, "activeElapsedTime", BindStaticRead_activeElapsedTime, null);
            cls.AddProperty(true, "userId", BindStaticRead_userId, null);
            return cls;
        }
    }
}
#endif
#endif
