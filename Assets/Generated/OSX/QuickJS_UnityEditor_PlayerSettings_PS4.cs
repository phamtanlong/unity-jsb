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
    // Type: UnityEditor.PlayerSettings+PS4
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_PlayerSettings_PS4
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                if (argc == 0)
                {
                    var o = new UnityEditor.PlayerSettings.PS4();
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
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_npTrophyPackPath(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.npTrophyPackPath;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_npTrophyPackPath(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "npTrophyPackPath", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.PS4.npTrophyPackPath = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_npAgeRating(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.npAgeRating;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_npAgeRating(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "npAgeRating", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.PS4.npAgeRating = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_npTitleSecret(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.npTitleSecret;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_npTitleSecret(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "npTitleSecret", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.PS4.npTitleSecret = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_parentalLevel(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.parentalLevel;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_parentalLevel(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "parentalLevel", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.PS4.parentalLevel = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_applicationParameter1(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.applicationParameter1;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_applicationParameter1(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "applicationParameter1", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.PS4.applicationParameter1 = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_applicationParameter2(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.applicationParameter2;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_applicationParameter2(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "applicationParameter2", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.PS4.applicationParameter2 = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_applicationParameter3(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.applicationParameter3;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_applicationParameter3(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "applicationParameter3", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.PS4.applicationParameter3 = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_applicationParameter4(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.applicationParameter4;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_applicationParameter4(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "applicationParameter4", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.PS4.applicationParameter4 = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_passcode(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.passcode;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_passcode(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "passcode", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.PS4.passcode = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_monoEnv(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.monoEnv;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_monoEnv(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "monoEnv", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.PS4.monoEnv = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_playerPrefsSupport(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.playerPrefsSupport;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_playerPrefsSupport(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "playerPrefsSupport", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.PS4.playerPrefsSupport = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_restrictedAudioUsageRights(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.restrictedAudioUsageRights;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_restrictedAudioUsageRights(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "restrictedAudioUsageRights", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.PS4.restrictedAudioUsageRights = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_useResolutionFallback(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.useResolutionFallback;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_useResolutionFallback(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "useResolutionFallback", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.PS4.useResolutionFallback = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_contentID(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.contentID;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_contentID(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "contentID", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.PS4.contentID = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_category(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.category;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_category(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.PlayerSettings.PS4.PS4AppCategory value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "category", typeof(UnityEditor.PlayerSettings.PS4.PS4AppCategory), 0);
                }
                UnityEditor.PlayerSettings.PS4.category = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_appType(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.appType;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_appType(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "appType", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.PS4.appType = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_masterVersion(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.masterVersion;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_masterVersion(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "masterVersion", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.PS4.masterVersion = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_appVersion(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.appVersion;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_appVersion(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "appVersion", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.PS4.appVersion = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_remotePlayKeyAssignment(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.remotePlayKeyAssignment;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_remotePlayKeyAssignment(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.PlayerSettings.PS4.PS4RemotePlayKeyAssignment value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "remotePlayKeyAssignment", typeof(UnityEditor.PlayerSettings.PS4.PS4RemotePlayKeyAssignment), 0);
                }
                UnityEditor.PlayerSettings.PS4.remotePlayKeyAssignment = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_remotePlayKeyMappingDir(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.remotePlayKeyMappingDir;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_remotePlayKeyMappingDir(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "remotePlayKeyMappingDir", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.PS4.remotePlayKeyMappingDir = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_playTogetherPlayerCount(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.playTogetherPlayerCount;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_playTogetherPlayerCount(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "playTogetherPlayerCount", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.PS4.playTogetherPlayerCount = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_enterButtonAssignment(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.enterButtonAssignment;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_enterButtonAssignment(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.PlayerSettings.PS4.PS4EnterButtonAssignment value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "enterButtonAssignment", typeof(UnityEditor.PlayerSettings.PS4.PS4EnterButtonAssignment), 0);
                }
                UnityEditor.PlayerSettings.PS4.enterButtonAssignment = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_paramSfxPath(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.paramSfxPath;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_paramSfxPath(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "paramSfxPath", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.PS4.paramSfxPath = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_videoOutPixelFormat(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.videoOutPixelFormat;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_videoOutPixelFormat(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "videoOutPixelFormat", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.PS4.videoOutPixelFormat = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_videoOutInitialWidth(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.videoOutInitialWidth;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_videoOutInitialWidth(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "videoOutInitialWidth", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.PS4.videoOutInitialWidth = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_SdkOverride(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.SdkOverride;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_SdkOverride(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "SdkOverride", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.PS4.SdkOverride = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_videoOutBaseModeInitialWidth(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.videoOutBaseModeInitialWidth;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_videoOutBaseModeInitialWidth(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "videoOutBaseModeInitialWidth", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.PS4.videoOutBaseModeInitialWidth = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_videoOutReprojectionRate(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.videoOutReprojectionRate;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_videoOutReprojectionRate(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "videoOutReprojectionRate", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.PS4.videoOutReprojectionRate = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_PronunciationXMLPath(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.PronunciationXMLPath;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_PronunciationXMLPath(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "PronunciationXMLPath", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.PS4.PronunciationXMLPath = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_PronunciationSIGPath(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.PronunciationSIGPath;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_PronunciationSIGPath(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "PronunciationSIGPath", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.PS4.PronunciationSIGPath = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_BackgroundImagePath(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.BackgroundImagePath;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_BackgroundImagePath(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "BackgroundImagePath", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.PS4.BackgroundImagePath = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_StartupImagePath(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.StartupImagePath;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_StartupImagePath(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "StartupImagePath", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.PS4.StartupImagePath = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_startupImagesFolder(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.startupImagesFolder;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_startupImagesFolder(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "startupImagesFolder", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.PS4.startupImagesFolder = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_iconImagesFolder(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.iconImagesFolder;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_iconImagesFolder(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "iconImagesFolder", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.PS4.iconImagesFolder = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_SaveDataImagePath(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.SaveDataImagePath;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_SaveDataImagePath(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "SaveDataImagePath", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.PS4.SaveDataImagePath = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_BGMPath(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.BGMPath;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_BGMPath(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "BGMPath", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.PS4.BGMPath = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_ShareFilePath(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.ShareFilePath;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_ShareFilePath(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "ShareFilePath", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.PS4.ShareFilePath = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_ShareOverlayImagePath(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.ShareOverlayImagePath;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_ShareOverlayImagePath(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "ShareOverlayImagePath", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.PS4.ShareOverlayImagePath = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_PrivacyGuardImagePath(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.PrivacyGuardImagePath;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_PrivacyGuardImagePath(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "PrivacyGuardImagePath", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.PS4.PrivacyGuardImagePath = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_ExtraSceSysFile(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.ExtraSceSysFile;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_ExtraSceSysFile(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "ExtraSceSysFile", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.PS4.ExtraSceSysFile = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_patchDayOne(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.patchDayOne;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_patchDayOne(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "patchDayOne", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.PS4.patchDayOne = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_PatchPkgPath(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.PatchPkgPath;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_PatchPkgPath(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "PatchPkgPath", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.PS4.PatchPkgPath = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_PatchLatestPkgPath(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.PatchLatestPkgPath;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_PatchLatestPkgPath(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "PatchLatestPkgPath", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.PS4.PatchLatestPkgPath = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_PatchChangeinfoPath(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.PatchChangeinfoPath;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_PatchChangeinfoPath(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "PatchChangeinfoPath", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.PS4.PatchChangeinfoPath = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_NPtitleDatPath(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.NPtitleDatPath;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_NPtitleDatPath(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "NPtitleDatPath", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.PS4.NPtitleDatPath = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_pnSessions(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.pnSessions;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_pnSessions(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "pnSessions", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.PS4.pnSessions = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_pnPresence(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.pnPresence;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_pnPresence(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "pnPresence", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.PS4.pnPresence = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_pnFriends(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.pnFriends;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_pnFriends(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "pnFriends", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.PS4.pnFriends = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_pnGameCustomData(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.pnGameCustomData;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_pnGameCustomData(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "pnGameCustomData", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.PS4.pnGameCustomData = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_downloadDataSize(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.downloadDataSize;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_downloadDataSize(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "downloadDataSize", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.PS4.downloadDataSize = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_garlicHeapSize(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.garlicHeapSize;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_garlicHeapSize(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "garlicHeapSize", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.PS4.garlicHeapSize = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_proGarlicHeapSize(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.proGarlicHeapSize;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_proGarlicHeapSize(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "proGarlicHeapSize", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.PS4.proGarlicHeapSize = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_reprojectionSupport(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.reprojectionSupport;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_reprojectionSupport(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "reprojectionSupport", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.PS4.reprojectionSupport = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_useAudio3dBackend(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.useAudio3dBackend;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_useAudio3dBackend(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "useAudio3dBackend", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.PS4.useAudio3dBackend = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_audio3dVirtualSpeakerCount(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.audio3dVirtualSpeakerCount;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_audio3dVirtualSpeakerCount(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "audio3dVirtualSpeakerCount", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.PS4.audio3dVirtualSpeakerCount = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_scriptOptimizationLevel(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.scriptOptimizationLevel;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_scriptOptimizationLevel(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "scriptOptimizationLevel", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.PS4.scriptOptimizationLevel = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_useLowGarlicFragmentationMode(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.useLowGarlicFragmentationMode;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_useLowGarlicFragmentationMode(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "useLowGarlicFragmentationMode", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.PS4.useLowGarlicFragmentationMode = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_socialScreenEnabled(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.socialScreenEnabled;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_socialScreenEnabled(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "socialScreenEnabled", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.PS4.socialScreenEnabled = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_attribUserManagement(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.attribUserManagement;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_attribUserManagement(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "attribUserManagement", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.PS4.attribUserManagement = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_attribMoveSupport(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.attribMoveSupport;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_attribMoveSupport(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "attribMoveSupport", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.PS4.attribMoveSupport = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_attrib3DSupport(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.attrib3DSupport;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_attrib3DSupport(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "attrib3DSupport", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.PS4.attrib3DSupport = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_attribShareSupport(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.attribShareSupport;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_attribShareSupport(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "attribShareSupport", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.PS4.attribShareSupport = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_attribExclusiveVR(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.attribExclusiveVR;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_attribExclusiveVR(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "attribExclusiveVR", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.PS4.attribExclusiveVR = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_disableAutoHideSplash(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.disableAutoHideSplash;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_disableAutoHideSplash(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "disableAutoHideSplash", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.PS4.disableAutoHideSplash = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_attribCpuUsage(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.attribCpuUsage;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_attribCpuUsage(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "attribCpuUsage", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.PS4.attribCpuUsage = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_videoRecordingFeaturesUsed(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.videoRecordingFeaturesUsed;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_videoRecordingFeaturesUsed(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "videoRecordingFeaturesUsed", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.PS4.videoRecordingFeaturesUsed = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_contentSearchFeaturesUsed(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.contentSearchFeaturesUsed;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_contentSearchFeaturesUsed(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "contentSearchFeaturesUsed", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.PS4.contentSearchFeaturesUsed = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_attribEyeToEyeDistanceSettingVR(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.attribEyeToEyeDistanceSettingVR;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_attribEyeToEyeDistanceSettingVR(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.PlayerSettings.PS4.PlayStationVREyeToEyeDistanceSettings value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "attribEyeToEyeDistanceSettingVR", typeof(UnityEditor.PlayerSettings.PS4.PlayStationVREyeToEyeDistanceSettings), 0);
                }
                UnityEditor.PlayerSettings.PS4.attribEyeToEyeDistanceSettingVR = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_includedModules(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.includedModules;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_includedModules(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string[] value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "includedModules", typeof(string[]), 0);
                }
                UnityEditor.PlayerSettings.PS4.includedModules = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_enableApplicationExit(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.enableApplicationExit;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_enableApplicationExit(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "enableApplicationExit", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.PS4.enableApplicationExit = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_resetTempFolder(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.resetTempFolder;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_resetTempFolder(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "resetTempFolder", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.PS4.resetTempFolder = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_playerPrefsMaxSize(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.playerPrefsMaxSize;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_playerPrefsMaxSize(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "playerPrefsMaxSize", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.PS4.playerPrefsMaxSize = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_attribVROutputEnabled(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.attribVROutputEnabled;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_attribVROutputEnabled(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "attribVROutputEnabled", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.PS4.attribVROutputEnabled = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_compatibilityPS5(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.compatibilityPS5;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_compatibilityPS5(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "compatibilityPS5", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.PS4.compatibilityPS5 = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_allowPS5Detection(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.allowPS5Detection;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_allowPS5Detection(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "allowPS5Detection", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.PS4.allowPS5Detection = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_gpu800MHz(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.PS4.gpu800MHz;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_gpu800MHz(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.PS4), "gpu800MHz", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.PS4.gpu800MHz = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("PS4", typeof(UnityEditor.PlayerSettings.PS4), BindConstructor);
            cls.AddProperty(true, "npTrophyPackPath", BindStaticRead_npTrophyPackPath, BindStaticWrite_npTrophyPackPath);
            cls.AddProperty(true, "npAgeRating", BindStaticRead_npAgeRating, BindStaticWrite_npAgeRating);
            cls.AddProperty(true, "npTitleSecret", BindStaticRead_npTitleSecret, BindStaticWrite_npTitleSecret);
            cls.AddProperty(true, "parentalLevel", BindStaticRead_parentalLevel, BindStaticWrite_parentalLevel);
            cls.AddProperty(true, "applicationParameter1", BindStaticRead_applicationParameter1, BindStaticWrite_applicationParameter1);
            cls.AddProperty(true, "applicationParameter2", BindStaticRead_applicationParameter2, BindStaticWrite_applicationParameter2);
            cls.AddProperty(true, "applicationParameter3", BindStaticRead_applicationParameter3, BindStaticWrite_applicationParameter3);
            cls.AddProperty(true, "applicationParameter4", BindStaticRead_applicationParameter4, BindStaticWrite_applicationParameter4);
            cls.AddProperty(true, "passcode", BindStaticRead_passcode, BindStaticWrite_passcode);
            cls.AddProperty(true, "monoEnv", BindStaticRead_monoEnv, BindStaticWrite_monoEnv);
            cls.AddProperty(true, "playerPrefsSupport", BindStaticRead_playerPrefsSupport, BindStaticWrite_playerPrefsSupport);
            cls.AddProperty(true, "restrictedAudioUsageRights", BindStaticRead_restrictedAudioUsageRights, BindStaticWrite_restrictedAudioUsageRights);
            cls.AddProperty(true, "useResolutionFallback", BindStaticRead_useResolutionFallback, BindStaticWrite_useResolutionFallback);
            cls.AddProperty(true, "contentID", BindStaticRead_contentID, BindStaticWrite_contentID);
            cls.AddProperty(true, "category", BindStaticRead_category, BindStaticWrite_category);
            cls.AddProperty(true, "appType", BindStaticRead_appType, BindStaticWrite_appType);
            cls.AddProperty(true, "masterVersion", BindStaticRead_masterVersion, BindStaticWrite_masterVersion);
            cls.AddProperty(true, "appVersion", BindStaticRead_appVersion, BindStaticWrite_appVersion);
            cls.AddProperty(true, "remotePlayKeyAssignment", BindStaticRead_remotePlayKeyAssignment, BindStaticWrite_remotePlayKeyAssignment);
            cls.AddProperty(true, "remotePlayKeyMappingDir", BindStaticRead_remotePlayKeyMappingDir, BindStaticWrite_remotePlayKeyMappingDir);
            cls.AddProperty(true, "playTogetherPlayerCount", BindStaticRead_playTogetherPlayerCount, BindStaticWrite_playTogetherPlayerCount);
            cls.AddProperty(true, "enterButtonAssignment", BindStaticRead_enterButtonAssignment, BindStaticWrite_enterButtonAssignment);
            cls.AddProperty(true, "paramSfxPath", BindStaticRead_paramSfxPath, BindStaticWrite_paramSfxPath);
            cls.AddProperty(true, "videoOutPixelFormat", BindStaticRead_videoOutPixelFormat, BindStaticWrite_videoOutPixelFormat);
            cls.AddProperty(true, "videoOutInitialWidth", BindStaticRead_videoOutInitialWidth, BindStaticWrite_videoOutInitialWidth);
            cls.AddProperty(true, "SdkOverride", BindStaticRead_SdkOverride, BindStaticWrite_SdkOverride);
            cls.AddProperty(true, "videoOutBaseModeInitialWidth", BindStaticRead_videoOutBaseModeInitialWidth, BindStaticWrite_videoOutBaseModeInitialWidth);
            cls.AddProperty(true, "videoOutReprojectionRate", BindStaticRead_videoOutReprojectionRate, BindStaticWrite_videoOutReprojectionRate);
            cls.AddProperty(true, "PronunciationXMLPath", BindStaticRead_PronunciationXMLPath, BindStaticWrite_PronunciationXMLPath);
            cls.AddProperty(true, "PronunciationSIGPath", BindStaticRead_PronunciationSIGPath, BindStaticWrite_PronunciationSIGPath);
            cls.AddProperty(true, "BackgroundImagePath", BindStaticRead_BackgroundImagePath, BindStaticWrite_BackgroundImagePath);
            cls.AddProperty(true, "StartupImagePath", BindStaticRead_StartupImagePath, BindStaticWrite_StartupImagePath);
            cls.AddProperty(true, "startupImagesFolder", BindStaticRead_startupImagesFolder, BindStaticWrite_startupImagesFolder);
            cls.AddProperty(true, "iconImagesFolder", BindStaticRead_iconImagesFolder, BindStaticWrite_iconImagesFolder);
            cls.AddProperty(true, "SaveDataImagePath", BindStaticRead_SaveDataImagePath, BindStaticWrite_SaveDataImagePath);
            cls.AddProperty(true, "BGMPath", BindStaticRead_BGMPath, BindStaticWrite_BGMPath);
            cls.AddProperty(true, "ShareFilePath", BindStaticRead_ShareFilePath, BindStaticWrite_ShareFilePath);
            cls.AddProperty(true, "ShareOverlayImagePath", BindStaticRead_ShareOverlayImagePath, BindStaticWrite_ShareOverlayImagePath);
            cls.AddProperty(true, "PrivacyGuardImagePath", BindStaticRead_PrivacyGuardImagePath, BindStaticWrite_PrivacyGuardImagePath);
            cls.AddProperty(true, "ExtraSceSysFile", BindStaticRead_ExtraSceSysFile, BindStaticWrite_ExtraSceSysFile);
            cls.AddProperty(true, "patchDayOne", BindStaticRead_patchDayOne, BindStaticWrite_patchDayOne);
            cls.AddProperty(true, "PatchPkgPath", BindStaticRead_PatchPkgPath, BindStaticWrite_PatchPkgPath);
            cls.AddProperty(true, "PatchLatestPkgPath", BindStaticRead_PatchLatestPkgPath, BindStaticWrite_PatchLatestPkgPath);
            cls.AddProperty(true, "PatchChangeinfoPath", BindStaticRead_PatchChangeinfoPath, BindStaticWrite_PatchChangeinfoPath);
            cls.AddProperty(true, "NPtitleDatPath", BindStaticRead_NPtitleDatPath, BindStaticWrite_NPtitleDatPath);
            cls.AddProperty(true, "pnSessions", BindStaticRead_pnSessions, BindStaticWrite_pnSessions);
            cls.AddProperty(true, "pnPresence", BindStaticRead_pnPresence, BindStaticWrite_pnPresence);
            cls.AddProperty(true, "pnFriends", BindStaticRead_pnFriends, BindStaticWrite_pnFriends);
            cls.AddProperty(true, "pnGameCustomData", BindStaticRead_pnGameCustomData, BindStaticWrite_pnGameCustomData);
            cls.AddProperty(true, "downloadDataSize", BindStaticRead_downloadDataSize, BindStaticWrite_downloadDataSize);
            cls.AddProperty(true, "garlicHeapSize", BindStaticRead_garlicHeapSize, BindStaticWrite_garlicHeapSize);
            cls.AddProperty(true, "proGarlicHeapSize", BindStaticRead_proGarlicHeapSize, BindStaticWrite_proGarlicHeapSize);
            cls.AddProperty(true, "reprojectionSupport", BindStaticRead_reprojectionSupport, BindStaticWrite_reprojectionSupport);
            cls.AddProperty(true, "useAudio3dBackend", BindStaticRead_useAudio3dBackend, BindStaticWrite_useAudio3dBackend);
            cls.AddProperty(true, "audio3dVirtualSpeakerCount", BindStaticRead_audio3dVirtualSpeakerCount, BindStaticWrite_audio3dVirtualSpeakerCount);
            cls.AddProperty(true, "scriptOptimizationLevel", BindStaticRead_scriptOptimizationLevel, BindStaticWrite_scriptOptimizationLevel);
            cls.AddProperty(true, "useLowGarlicFragmentationMode", BindStaticRead_useLowGarlicFragmentationMode, BindStaticWrite_useLowGarlicFragmentationMode);
            cls.AddProperty(true, "socialScreenEnabled", BindStaticRead_socialScreenEnabled, BindStaticWrite_socialScreenEnabled);
            cls.AddProperty(true, "attribUserManagement", BindStaticRead_attribUserManagement, BindStaticWrite_attribUserManagement);
            cls.AddProperty(true, "attribMoveSupport", BindStaticRead_attribMoveSupport, BindStaticWrite_attribMoveSupport);
            cls.AddProperty(true, "attrib3DSupport", BindStaticRead_attrib3DSupport, BindStaticWrite_attrib3DSupport);
            cls.AddProperty(true, "attribShareSupport", BindStaticRead_attribShareSupport, BindStaticWrite_attribShareSupport);
            cls.AddProperty(true, "attribExclusiveVR", BindStaticRead_attribExclusiveVR, BindStaticWrite_attribExclusiveVR);
            cls.AddProperty(true, "disableAutoHideSplash", BindStaticRead_disableAutoHideSplash, BindStaticWrite_disableAutoHideSplash);
            cls.AddProperty(true, "attribCpuUsage", BindStaticRead_attribCpuUsage, BindStaticWrite_attribCpuUsage);
            cls.AddProperty(true, "videoRecordingFeaturesUsed", BindStaticRead_videoRecordingFeaturesUsed, BindStaticWrite_videoRecordingFeaturesUsed);
            cls.AddProperty(true, "contentSearchFeaturesUsed", BindStaticRead_contentSearchFeaturesUsed, BindStaticWrite_contentSearchFeaturesUsed);
            cls.AddProperty(true, "attribEyeToEyeDistanceSettingVR", BindStaticRead_attribEyeToEyeDistanceSettingVR, BindStaticWrite_attribEyeToEyeDistanceSettingVR);
            cls.AddProperty(true, "includedModules", BindStaticRead_includedModules, BindStaticWrite_includedModules);
            cls.AddProperty(true, "enableApplicationExit", BindStaticRead_enableApplicationExit, BindStaticWrite_enableApplicationExit);
            cls.AddProperty(true, "resetTempFolder", BindStaticRead_resetTempFolder, BindStaticWrite_resetTempFolder);
            cls.AddProperty(true, "playerPrefsMaxSize", BindStaticRead_playerPrefsMaxSize, BindStaticWrite_playerPrefsMaxSize);
            cls.AddProperty(true, "attribVROutputEnabled", BindStaticRead_attribVROutputEnabled, BindStaticWrite_attribVROutputEnabled);
            cls.AddProperty(true, "compatibilityPS5", BindStaticRead_compatibilityPS5, BindStaticWrite_compatibilityPS5);
            cls.AddProperty(true, "allowPS5Detection", BindStaticRead_allowPS5Detection, BindStaticWrite_allowPS5Detection);
            cls.AddProperty(true, "gpu800MHz", BindStaticRead_gpu800MHz, BindStaticWrite_gpu800MHz);
            return cls;
        }
    }
}
#endif
#endif
