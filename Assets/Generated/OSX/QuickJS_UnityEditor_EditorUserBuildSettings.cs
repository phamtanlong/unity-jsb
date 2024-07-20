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
    // Type: UnityEditor.EditorUserBuildSettings
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_EditorUserBuildSettings
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SwitchActiveBuildTarget(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.BuildTargetGroup)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.BuildTarget)))
                        {
                            UnityEditor.BuildTargetGroup arg0;
                            if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "SwitchActiveBuildTarget", typeof(UnityEditor.BuildTargetGroup), 0);
                            }
                            UnityEditor.BuildTarget arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "SwitchActiveBuildTarget", typeof(UnityEditor.BuildTarget), 1);
                            }
                            var ret = UnityEditor.EditorUserBuildSettings.SwitchActiveBuildTarget(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.Build.NamedBuildTarget)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.BuildTarget)))
                        {
                            UnityEditor.Build.NamedBuildTarget arg0;
                            if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "SwitchActiveBuildTarget", typeof(UnityEditor.Build.NamedBuildTarget), 0);
                            }
                            UnityEditor.BuildTarget arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "SwitchActiveBuildTarget", typeof(UnityEditor.BuildTarget), 1);
                            }
                            var ret = UnityEditor.EditorUserBuildSettings.SwitchActiveBuildTarget(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("SwitchActiveBuildTarget", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SwitchActiveBuildTargetAsync(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEditor.BuildTargetGroup arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "SwitchActiveBuildTargetAsync", typeof(UnityEditor.BuildTargetGroup), 0);
                    }
                    UnityEditor.BuildTarget arg1;
                    if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "SwitchActiveBuildTargetAsync", typeof(UnityEditor.BuildTarget), 1);
                    }
                    var ret = UnityEditor.EditorUserBuildSettings.SwitchActiveBuildTargetAsync(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("SwitchActiveBuildTargetAsync", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetBuildLocation(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.BuildTarget arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "GetBuildLocation", typeof(UnityEditor.BuildTarget), 0);
                    }
                    var ret = UnityEditor.EditorUserBuildSettings.GetBuildLocation(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetBuildLocation", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetBuildLocation(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEditor.BuildTarget arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "SetBuildLocation", typeof(UnityEditor.BuildTarget), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "SetBuildLocation", typeof(string), 1);
                    }
                    UnityEditor.EditorUserBuildSettings.SetBuildLocation(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetBuildLocation", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetPlatformSettings(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "SetPlatformSettings", typeof(string), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "SetPlatformSettings", typeof(string), 1);
                        }
                        string arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "SetPlatformSettings", typeof(string), 2);
                        }
                        string arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "SetPlatformSettings", typeof(string), 3);
                        }
                        UnityEditor.EditorUserBuildSettings.SetPlatformSettings(arg0, arg1, arg2, arg3);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 3)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "SetPlatformSettings", typeof(string), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "SetPlatformSettings", typeof(string), 1);
                        }
                        string arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "SetPlatformSettings", typeof(string), 2);
                        }
                        UnityEditor.EditorUserBuildSettings.SetPlatformSettings(arg0, arg1, arg2);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("SetPlatformSettings", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetPlatformSettings(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "GetPlatformSettings", typeof(string), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "GetPlatformSettings", typeof(string), 1);
                        }
                        string arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "GetPlatformSettings", typeof(string), 2);
                        }
                        var ret = UnityEditor.EditorUserBuildSettings.GetPlatformSettings(arg0, arg1, arg2);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 2)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "GetPlatformSettings", typeof(string), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "GetPlatformSettings", typeof(string), 1);
                        }
                        var ret = UnityEditor.EditorUserBuildSettings.GetPlatformSettings(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("GetPlatformSettings", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_selectedBuildTargetGroup(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.selectedBuildTargetGroup;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_selectedBuildTargetGroup(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.BuildTargetGroup value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "selectedBuildTargetGroup", typeof(UnityEditor.BuildTargetGroup), 0);
                }
                UnityEditor.EditorUserBuildSettings.selectedBuildTargetGroup = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_selectedEmbeddedLinuxArchitecture(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.selectedEmbeddedLinuxArchitecture;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_selectedEmbeddedLinuxArchitecture(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.EmbeddedLinuxArchitecture value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "selectedEmbeddedLinuxArchitecture", typeof(UnityEditor.EmbeddedLinuxArchitecture), 0);
                }
                UnityEditor.EditorUserBuildSettings.selectedEmbeddedLinuxArchitecture = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_remoteDeviceInfo(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.remoteDeviceInfo;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_remoteDeviceInfo(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "remoteDeviceInfo", typeof(bool), 0);
                }
                UnityEditor.EditorUserBuildSettings.remoteDeviceInfo = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_remoteDeviceAddress(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.remoteDeviceAddress;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_remoteDeviceAddress(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "remoteDeviceAddress", typeof(string), 0);
                }
                UnityEditor.EditorUserBuildSettings.remoteDeviceAddress = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_remoteDeviceUsername(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.remoteDeviceUsername;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_remoteDeviceUsername(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "remoteDeviceUsername", typeof(string), 0);
                }
                UnityEditor.EditorUserBuildSettings.remoteDeviceUsername = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_remoteDeviceExports(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.remoteDeviceExports;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_remoteDeviceExports(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "remoteDeviceExports", typeof(string), 0);
                }
                UnityEditor.EditorUserBuildSettings.remoteDeviceExports = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_pathOnRemoteDevice(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.pathOnRemoteDevice;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_pathOnRemoteDevice(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "pathOnRemoteDevice", typeof(string), 0);
                }
                UnityEditor.EditorUserBuildSettings.pathOnRemoteDevice = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_selectedStandaloneTarget(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.selectedStandaloneTarget;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_selectedStandaloneTarget(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.BuildTarget value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "selectedStandaloneTarget", typeof(UnityEditor.BuildTarget), 0);
                }
                UnityEditor.EditorUserBuildSettings.selectedStandaloneTarget = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_standaloneBuildSubtarget(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.standaloneBuildSubtarget;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_standaloneBuildSubtarget(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.StandaloneBuildSubtarget value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "standaloneBuildSubtarget", typeof(UnityEditor.StandaloneBuildSubtarget), 0);
                }
                UnityEditor.EditorUserBuildSettings.standaloneBuildSubtarget = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_ps4BuildSubtarget(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.ps4BuildSubtarget;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_ps4BuildSubtarget(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.PS4BuildSubtarget value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "ps4BuildSubtarget", typeof(UnityEditor.PS4BuildSubtarget), 0);
                }
                UnityEditor.EditorUserBuildSettings.ps4BuildSubtarget = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_ps4HardwareTarget(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.ps4HardwareTarget;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_ps4HardwareTarget(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.PS4HardwareTarget value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "ps4HardwareTarget", typeof(UnityEditor.PS4HardwareTarget), 0);
                }
                UnityEditor.EditorUserBuildSettings.ps4HardwareTarget = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_explicitNullChecks(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.explicitNullChecks;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_explicitNullChecks(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "explicitNullChecks", typeof(bool), 0);
                }
                UnityEditor.EditorUserBuildSettings.explicitNullChecks = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_explicitDivideByZeroChecks(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.explicitDivideByZeroChecks;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_explicitDivideByZeroChecks(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "explicitDivideByZeroChecks", typeof(bool), 0);
                }
                UnityEditor.EditorUserBuildSettings.explicitDivideByZeroChecks = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_explicitArrayBoundsChecks(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.explicitArrayBoundsChecks;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_explicitArrayBoundsChecks(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "explicitArrayBoundsChecks", typeof(bool), 0);
                }
                UnityEditor.EditorUserBuildSettings.explicitArrayBoundsChecks = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_needSubmissionMaterials(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.needSubmissionMaterials;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_needSubmissionMaterials(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "needSubmissionMaterials", typeof(bool), 0);
                }
                UnityEditor.EditorUserBuildSettings.needSubmissionMaterials = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_forceInstallation(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.forceInstallation;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_forceInstallation(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "forceInstallation", typeof(bool), 0);
                }
                UnityEditor.EditorUserBuildSettings.forceInstallation = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_movePackageToDiscOuterEdge(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.movePackageToDiscOuterEdge;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_movePackageToDiscOuterEdge(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "movePackageToDiscOuterEdge", typeof(bool), 0);
                }
                UnityEditor.EditorUserBuildSettings.movePackageToDiscOuterEdge = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_compressFilesInPackage(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.compressFilesInPackage;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_compressFilesInPackage(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "compressFilesInPackage", typeof(bool), 0);
                }
                UnityEditor.EditorUserBuildSettings.compressFilesInPackage = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_buildScriptsOnly(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.buildScriptsOnly;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_buildScriptsOnly(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "buildScriptsOnly", typeof(bool), 0);
                }
                UnityEditor.EditorUserBuildSettings.buildScriptsOnly = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_xboxBuildSubtarget(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.xboxBuildSubtarget;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_xboxBuildSubtarget(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.XboxBuildSubtarget value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "xboxBuildSubtarget", typeof(UnityEditor.XboxBuildSubtarget), 0);
                }
                UnityEditor.EditorUserBuildSettings.xboxBuildSubtarget = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_streamingInstallLaunchRange(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.streamingInstallLaunchRange;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_streamingInstallLaunchRange(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "streamingInstallLaunchRange", typeof(int), 0);
                }
                UnityEditor.EditorUserBuildSettings.streamingInstallLaunchRange = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_xboxOneDeployMethod(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.xboxOneDeployMethod;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_xboxOneDeployMethod(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.XboxOneDeployMethod value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "xboxOneDeployMethod", typeof(UnityEditor.XboxOneDeployMethod), 0);
                }
                UnityEditor.EditorUserBuildSettings.xboxOneDeployMethod = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_xboxOneDeployDrive(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.xboxOneDeployDrive;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_xboxOneDeployDrive(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.XboxOneDeployDrive value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "xboxOneDeployDrive", typeof(UnityEditor.XboxOneDeployDrive), 0);
                }
                UnityEditor.EditorUserBuildSettings.xboxOneDeployDrive = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_xboxOneAdditionalDebugPorts(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.xboxOneAdditionalDebugPorts;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_xboxOneAdditionalDebugPorts(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "xboxOneAdditionalDebugPorts", typeof(string), 0);
                }
                UnityEditor.EditorUserBuildSettings.xboxOneAdditionalDebugPorts = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_xboxOneRebootIfDeployFailsAndRetry(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.xboxOneRebootIfDeployFailsAndRetry;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_xboxOneRebootIfDeployFailsAndRetry(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "xboxOneRebootIfDeployFailsAndRetry", typeof(bool), 0);
                }
                UnityEditor.EditorUserBuildSettings.xboxOneRebootIfDeployFailsAndRetry = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_androidBuildSubtarget(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.androidBuildSubtarget;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_androidBuildSubtarget(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.MobileTextureSubtarget value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "androidBuildSubtarget", typeof(UnityEditor.MobileTextureSubtarget), 0);
                }
                UnityEditor.EditorUserBuildSettings.androidBuildSubtarget = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_webGLBuildSubtarget(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.webGLBuildSubtarget;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_webGLBuildSubtarget(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.WebGLTextureSubtarget value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "webGLBuildSubtarget", typeof(UnityEditor.WebGLTextureSubtarget), 0);
                }
                UnityEditor.EditorUserBuildSettings.webGLBuildSubtarget = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_androidETC2Fallback(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.androidETC2Fallback;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_androidETC2Fallback(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.AndroidETC2Fallback value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "androidETC2Fallback", typeof(UnityEditor.AndroidETC2Fallback), 0);
                }
                UnityEditor.EditorUserBuildSettings.androidETC2Fallback = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_androidBuildSystem(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.androidBuildSystem;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_androidBuildSystem(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.AndroidBuildSystem value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "androidBuildSystem", typeof(UnityEditor.AndroidBuildSystem), 0);
                }
                UnityEditor.EditorUserBuildSettings.androidBuildSystem = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_androidBuildType(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.androidBuildType;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_androidBuildType(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.AndroidBuildType value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "androidBuildType", typeof(UnityEditor.AndroidBuildType), 0);
                }
                UnityEditor.EditorUserBuildSettings.androidBuildType = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_androidCreateSymbols(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.androidCreateSymbols;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_androidCreateSymbols(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.AndroidCreateSymbols value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "androidCreateSymbols", typeof(UnityEditor.AndroidCreateSymbols), 0);
                }
                UnityEditor.EditorUserBuildSettings.androidCreateSymbols = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_wsaUWPBuildType(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.wsaUWPBuildType;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_wsaUWPBuildType(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.WSAUWPBuildType value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "wsaUWPBuildType", typeof(UnityEditor.WSAUWPBuildType), 0);
                }
                UnityEditor.EditorUserBuildSettings.wsaUWPBuildType = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_wsaUWPSDK(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.wsaUWPSDK;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_wsaUWPSDK(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "wsaUWPSDK", typeof(string), 0);
                }
                UnityEditor.EditorUserBuildSettings.wsaUWPSDK = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_wsaMinUWPSDK(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.wsaMinUWPSDK;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_wsaMinUWPSDK(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "wsaMinUWPSDK", typeof(string), 0);
                }
                UnityEditor.EditorUserBuildSettings.wsaMinUWPSDK = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_wsaArchitecture(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.wsaArchitecture;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_wsaArchitecture(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "wsaArchitecture", typeof(string), 0);
                }
                UnityEditor.EditorUserBuildSettings.wsaArchitecture = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_wsaUWPVisualStudioVersion(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.wsaUWPVisualStudioVersion;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_wsaUWPVisualStudioVersion(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "wsaUWPVisualStudioVersion", typeof(string), 0);
                }
                UnityEditor.EditorUserBuildSettings.wsaUWPVisualStudioVersion = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_windowsDevicePortalAddress(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.windowsDevicePortalAddress;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_windowsDevicePortalAddress(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "windowsDevicePortalAddress", typeof(string), 0);
                }
                UnityEditor.EditorUserBuildSettings.windowsDevicePortalAddress = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_windowsDevicePortalUsername(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.windowsDevicePortalUsername;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_windowsDevicePortalUsername(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "windowsDevicePortalUsername", typeof(string), 0);
                }
                UnityEditor.EditorUserBuildSettings.windowsDevicePortalUsername = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_windowsDevicePortalPassword(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.windowsDevicePortalPassword;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_windowsDevicePortalPassword(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "windowsDevicePortalPassword", typeof(string), 0);
                }
                UnityEditor.EditorUserBuildSettings.windowsDevicePortalPassword = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_wsaBuildAndRunDeployTarget(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.wsaBuildAndRunDeployTarget;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_wsaBuildAndRunDeployTarget(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.WSABuildAndRunDeployTarget value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "wsaBuildAndRunDeployTarget", typeof(UnityEditor.WSABuildAndRunDeployTarget), 0);
                }
                UnityEditor.EditorUserBuildSettings.wsaBuildAndRunDeployTarget = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_overrideMaxTextureSize(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.overrideMaxTextureSize;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_overrideMaxTextureSize(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "overrideMaxTextureSize", typeof(int), 0);
                }
                UnityEditor.EditorUserBuildSettings.overrideMaxTextureSize = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_overrideTextureCompression(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.overrideTextureCompression;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_overrideTextureCompression(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.Build.OverrideTextureCompression value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "overrideTextureCompression", typeof(UnityEditor.Build.OverrideTextureCompression), 0);
                }
                UnityEditor.EditorUserBuildSettings.overrideTextureCompression = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_activeBuildTarget(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.activeBuildTarget;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_activeScriptCompilationDefines(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.activeScriptCompilationDefines;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_development(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.development;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_development(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "development", typeof(bool), 0);
                }
                UnityEditor.EditorUserBuildSettings.development = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_il2CppCodeGeneration(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.il2CppCodeGeneration;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_il2CppCodeGeneration(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.Build.Il2CppCodeGeneration value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "il2CppCodeGeneration", typeof(UnityEditor.Build.Il2CppCodeGeneration), 0);
                }
                UnityEditor.EditorUserBuildSettings.il2CppCodeGeneration = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_connectProfiler(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.connectProfiler;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_connectProfiler(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "connectProfiler", typeof(bool), 0);
                }
                UnityEditor.EditorUserBuildSettings.connectProfiler = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_buildWithDeepProfilingSupport(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.buildWithDeepProfilingSupport;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_buildWithDeepProfilingSupport(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "buildWithDeepProfilingSupport", typeof(bool), 0);
                }
                UnityEditor.EditorUserBuildSettings.buildWithDeepProfilingSupport = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_allowDebugging(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.allowDebugging;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_allowDebugging(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "allowDebugging", typeof(bool), 0);
                }
                UnityEditor.EditorUserBuildSettings.allowDebugging = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_waitForPlayerConnection(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.waitForPlayerConnection;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_waitForPlayerConnection(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "waitForPlayerConnection", typeof(bool), 0);
                }
                UnityEditor.EditorUserBuildSettings.waitForPlayerConnection = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_exportAsGoogleAndroidProject(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.exportAsGoogleAndroidProject;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_exportAsGoogleAndroidProject(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "exportAsGoogleAndroidProject", typeof(bool), 0);
                }
                UnityEditor.EditorUserBuildSettings.exportAsGoogleAndroidProject = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_buildAppBundle(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.buildAppBundle;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_buildAppBundle(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "buildAppBundle", typeof(bool), 0);
                }
                UnityEditor.EditorUserBuildSettings.buildAppBundle = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_symlinkSources(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.symlinkSources;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_symlinkSources(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "symlinkSources", typeof(bool), 0);
                }
                UnityEditor.EditorUserBuildSettings.symlinkSources = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_iOSXcodeBuildConfig(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.iOSXcodeBuildConfig;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_iOSXcodeBuildConfig(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.XcodeBuildConfig value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "iOSXcodeBuildConfig", typeof(UnityEditor.XcodeBuildConfig), 0);
                }
                UnityEditor.EditorUserBuildSettings.iOSXcodeBuildConfig = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_macOSXcodeBuildConfig(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.macOSXcodeBuildConfig;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_macOSXcodeBuildConfig(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.XcodeBuildConfig value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "macOSXcodeBuildConfig", typeof(UnityEditor.XcodeBuildConfig), 0);
                }
                UnityEditor.EditorUserBuildSettings.macOSXcodeBuildConfig = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_switchCreateRomFile(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.switchCreateRomFile;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_switchCreateRomFile(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "switchCreateRomFile", typeof(bool), 0);
                }
                UnityEditor.EditorUserBuildSettings.switchCreateRomFile = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_switchEnableRomCompression(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.switchEnableRomCompression;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_switchEnableRomCompression(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "switchEnableRomCompression", typeof(bool), 0);
                }
                UnityEditor.EditorUserBuildSettings.switchEnableRomCompression = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_switchSaveADF(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.switchSaveADF;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_switchSaveADF(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "switchSaveADF", typeof(bool), 0);
                }
                UnityEditor.EditorUserBuildSettings.switchSaveADF = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_switchRomCompressionType(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.switchRomCompressionType;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_switchRomCompressionType(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.SwitchRomCompressionType value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "switchRomCompressionType", typeof(UnityEditor.SwitchRomCompressionType), 0);
                }
                UnityEditor.EditorUserBuildSettings.switchRomCompressionType = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_switchRomCompressionLevel(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.switchRomCompressionLevel;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_switchRomCompressionLevel(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "switchRomCompressionLevel", typeof(int), 0);
                }
                UnityEditor.EditorUserBuildSettings.switchRomCompressionLevel = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_switchRomCompressionConfig(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.switchRomCompressionConfig;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_switchRomCompressionConfig(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "switchRomCompressionConfig", typeof(string), 0);
                }
                UnityEditor.EditorUserBuildSettings.switchRomCompressionConfig = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_switchNVNGraphicsDebugger(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.switchNVNGraphicsDebugger;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_switchNVNGraphicsDebugger(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "switchNVNGraphicsDebugger", typeof(bool), 0);
                }
                UnityEditor.EditorUserBuildSettings.switchNVNGraphicsDebugger = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_generateNintendoSwitchShaderInfo(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.generateNintendoSwitchShaderInfo;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_generateNintendoSwitchShaderInfo(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "generateNintendoSwitchShaderInfo", typeof(bool), 0);
                }
                UnityEditor.EditorUserBuildSettings.generateNintendoSwitchShaderInfo = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_switchNVNShaderDebugging(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.switchNVNShaderDebugging;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_switchNVNShaderDebugging(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "switchNVNShaderDebugging", typeof(bool), 0);
                }
                UnityEditor.EditorUserBuildSettings.switchNVNShaderDebugging = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_switchNVNDrawValidation_Light(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.switchNVNDrawValidation_Light;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_switchNVNDrawValidation_Light(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "switchNVNDrawValidation_Light", typeof(bool), 0);
                }
                UnityEditor.EditorUserBuildSettings.switchNVNDrawValidation_Light = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_switchNVNDrawValidation_Heavy(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.switchNVNDrawValidation_Heavy;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_switchNVNDrawValidation_Heavy(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "switchNVNDrawValidation_Heavy", typeof(bool), 0);
                }
                UnityEditor.EditorUserBuildSettings.switchNVNDrawValidation_Heavy = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_switchEnableMemoryTracker(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.switchEnableMemoryTracker;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_switchEnableMemoryTracker(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "switchEnableMemoryTracker", typeof(bool), 0);
                }
                UnityEditor.EditorUserBuildSettings.switchEnableMemoryTracker = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_switchWaitForMemoryTrackerOnStartup(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.switchWaitForMemoryTrackerOnStartup;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_switchWaitForMemoryTrackerOnStartup(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "switchWaitForMemoryTrackerOnStartup", typeof(bool), 0);
                }
                UnityEditor.EditorUserBuildSettings.switchWaitForMemoryTrackerOnStartup = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_switchEnableDebugPad(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.switchEnableDebugPad;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_switchEnableDebugPad(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "switchEnableDebugPad", typeof(bool), 0);
                }
                UnityEditor.EditorUserBuildSettings.switchEnableDebugPad = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_switchRedirectWritesToHostMount(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.switchRedirectWritesToHostMount;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_switchRedirectWritesToHostMount(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "switchRedirectWritesToHostMount", typeof(bool), 0);
                }
                UnityEditor.EditorUserBuildSettings.switchRedirectWritesToHostMount = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_switchHTCSScriptDebugging(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.switchHTCSScriptDebugging;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_switchHTCSScriptDebugging(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "switchHTCSScriptDebugging", typeof(bool), 0);
                }
                UnityEditor.EditorUserBuildSettings.switchHTCSScriptDebugging = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_switchUseLegacyNvnPoolAllocator(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.switchUseLegacyNvnPoolAllocator;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_switchUseLegacyNvnPoolAllocator(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "switchUseLegacyNvnPoolAllocator", typeof(bool), 0);
                }
                UnityEditor.EditorUserBuildSettings.switchUseLegacyNvnPoolAllocator = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_installInBuildFolder(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.installInBuildFolder;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_installInBuildFolder(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "installInBuildFolder", typeof(bool), 0);
                }
                UnityEditor.EditorUserBuildSettings.installInBuildFolder = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_waitForManagedDebugger(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.waitForManagedDebugger;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_waitForManagedDebugger(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "waitForManagedDebugger", typeof(bool), 0);
                }
                UnityEditor.EditorUserBuildSettings.waitForManagedDebugger = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_managedDebuggerFixedPort(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUserBuildSettings.managedDebuggerFixedPort;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_managedDebuggerFixedPort(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUserBuildSettings), "managedDebuggerFixedPort", typeof(int), 0);
                }
                UnityEditor.EditorUserBuildSettings.managedDebuggerFixedPort = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("EditorUserBuildSettings", typeof(UnityEditor.EditorUserBuildSettings), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "SwitchActiveBuildTarget", BindStatic_SwitchActiveBuildTarget);
            cls.AddMethod(true, "SwitchActiveBuildTargetAsync", BindStatic_SwitchActiveBuildTargetAsync);
            cls.AddMethod(true, "GetBuildLocation", BindStatic_GetBuildLocation);
            cls.AddMethod(true, "SetBuildLocation", BindStatic_SetBuildLocation);
            cls.AddMethod(true, "SetPlatformSettings", BindStatic_SetPlatformSettings);
            cls.AddMethod(true, "GetPlatformSettings", BindStatic_GetPlatformSettings);
            cls.AddProperty(true, "selectedBuildTargetGroup", BindStaticRead_selectedBuildTargetGroup, BindStaticWrite_selectedBuildTargetGroup);
            cls.AddProperty(true, "selectedEmbeddedLinuxArchitecture", BindStaticRead_selectedEmbeddedLinuxArchitecture, BindStaticWrite_selectedEmbeddedLinuxArchitecture);
            cls.AddProperty(true, "remoteDeviceInfo", BindStaticRead_remoteDeviceInfo, BindStaticWrite_remoteDeviceInfo);
            cls.AddProperty(true, "remoteDeviceAddress", BindStaticRead_remoteDeviceAddress, BindStaticWrite_remoteDeviceAddress);
            cls.AddProperty(true, "remoteDeviceUsername", BindStaticRead_remoteDeviceUsername, BindStaticWrite_remoteDeviceUsername);
            cls.AddProperty(true, "remoteDeviceExports", BindStaticRead_remoteDeviceExports, BindStaticWrite_remoteDeviceExports);
            cls.AddProperty(true, "pathOnRemoteDevice", BindStaticRead_pathOnRemoteDevice, BindStaticWrite_pathOnRemoteDevice);
            cls.AddProperty(true, "selectedStandaloneTarget", BindStaticRead_selectedStandaloneTarget, BindStaticWrite_selectedStandaloneTarget);
            cls.AddProperty(true, "standaloneBuildSubtarget", BindStaticRead_standaloneBuildSubtarget, BindStaticWrite_standaloneBuildSubtarget);
            cls.AddProperty(true, "ps4BuildSubtarget", BindStaticRead_ps4BuildSubtarget, BindStaticWrite_ps4BuildSubtarget);
            cls.AddProperty(true, "ps4HardwareTarget", BindStaticRead_ps4HardwareTarget, BindStaticWrite_ps4HardwareTarget);
            cls.AddProperty(true, "explicitNullChecks", BindStaticRead_explicitNullChecks, BindStaticWrite_explicitNullChecks);
            cls.AddProperty(true, "explicitDivideByZeroChecks", BindStaticRead_explicitDivideByZeroChecks, BindStaticWrite_explicitDivideByZeroChecks);
            cls.AddProperty(true, "explicitArrayBoundsChecks", BindStaticRead_explicitArrayBoundsChecks, BindStaticWrite_explicitArrayBoundsChecks);
            cls.AddProperty(true, "needSubmissionMaterials", BindStaticRead_needSubmissionMaterials, BindStaticWrite_needSubmissionMaterials);
            cls.AddProperty(true, "forceInstallation", BindStaticRead_forceInstallation, BindStaticWrite_forceInstallation);
            cls.AddProperty(true, "movePackageToDiscOuterEdge", BindStaticRead_movePackageToDiscOuterEdge, BindStaticWrite_movePackageToDiscOuterEdge);
            cls.AddProperty(true, "compressFilesInPackage", BindStaticRead_compressFilesInPackage, BindStaticWrite_compressFilesInPackage);
            cls.AddProperty(true, "buildScriptsOnly", BindStaticRead_buildScriptsOnly, BindStaticWrite_buildScriptsOnly);
            cls.AddProperty(true, "xboxBuildSubtarget", BindStaticRead_xboxBuildSubtarget, BindStaticWrite_xboxBuildSubtarget);
            cls.AddProperty(true, "streamingInstallLaunchRange", BindStaticRead_streamingInstallLaunchRange, BindStaticWrite_streamingInstallLaunchRange);
            cls.AddProperty(true, "xboxOneDeployMethod", BindStaticRead_xboxOneDeployMethod, BindStaticWrite_xboxOneDeployMethod);
            cls.AddProperty(true, "xboxOneDeployDrive", BindStaticRead_xboxOneDeployDrive, BindStaticWrite_xboxOneDeployDrive);
            cls.AddProperty(true, "xboxOneAdditionalDebugPorts", BindStaticRead_xboxOneAdditionalDebugPorts, BindStaticWrite_xboxOneAdditionalDebugPorts);
            cls.AddProperty(true, "xboxOneRebootIfDeployFailsAndRetry", BindStaticRead_xboxOneRebootIfDeployFailsAndRetry, BindStaticWrite_xboxOneRebootIfDeployFailsAndRetry);
            cls.AddProperty(true, "androidBuildSubtarget", BindStaticRead_androidBuildSubtarget, BindStaticWrite_androidBuildSubtarget);
            cls.AddProperty(true, "webGLBuildSubtarget", BindStaticRead_webGLBuildSubtarget, BindStaticWrite_webGLBuildSubtarget);
            cls.AddProperty(true, "androidETC2Fallback", BindStaticRead_androidETC2Fallback, BindStaticWrite_androidETC2Fallback);
            cls.AddProperty(true, "androidBuildSystem", BindStaticRead_androidBuildSystem, BindStaticWrite_androidBuildSystem);
            cls.AddProperty(true, "androidBuildType", BindStaticRead_androidBuildType, BindStaticWrite_androidBuildType);
            cls.AddProperty(true, "androidCreateSymbols", BindStaticRead_androidCreateSymbols, BindStaticWrite_androidCreateSymbols);
            cls.AddProperty(true, "wsaUWPBuildType", BindStaticRead_wsaUWPBuildType, BindStaticWrite_wsaUWPBuildType);
            cls.AddProperty(true, "wsaUWPSDK", BindStaticRead_wsaUWPSDK, BindStaticWrite_wsaUWPSDK);
            cls.AddProperty(true, "wsaMinUWPSDK", BindStaticRead_wsaMinUWPSDK, BindStaticWrite_wsaMinUWPSDK);
            cls.AddProperty(true, "wsaArchitecture", BindStaticRead_wsaArchitecture, BindStaticWrite_wsaArchitecture);
            cls.AddProperty(true, "wsaUWPVisualStudioVersion", BindStaticRead_wsaUWPVisualStudioVersion, BindStaticWrite_wsaUWPVisualStudioVersion);
            cls.AddProperty(true, "windowsDevicePortalAddress", BindStaticRead_windowsDevicePortalAddress, BindStaticWrite_windowsDevicePortalAddress);
            cls.AddProperty(true, "windowsDevicePortalUsername", BindStaticRead_windowsDevicePortalUsername, BindStaticWrite_windowsDevicePortalUsername);
            cls.AddProperty(true, "windowsDevicePortalPassword", BindStaticRead_windowsDevicePortalPassword, BindStaticWrite_windowsDevicePortalPassword);
            cls.AddProperty(true, "wsaBuildAndRunDeployTarget", BindStaticRead_wsaBuildAndRunDeployTarget, BindStaticWrite_wsaBuildAndRunDeployTarget);
            cls.AddProperty(true, "overrideMaxTextureSize", BindStaticRead_overrideMaxTextureSize, BindStaticWrite_overrideMaxTextureSize);
            cls.AddProperty(true, "overrideTextureCompression", BindStaticRead_overrideTextureCompression, BindStaticWrite_overrideTextureCompression);
            cls.AddProperty(true, "activeBuildTarget", BindStaticRead_activeBuildTarget, null);
            cls.AddProperty(true, "activeScriptCompilationDefines", BindStaticRead_activeScriptCompilationDefines, null);
            cls.AddProperty(true, "development", BindStaticRead_development, BindStaticWrite_development);
            cls.AddProperty(true, "il2CppCodeGeneration", BindStaticRead_il2CppCodeGeneration, BindStaticWrite_il2CppCodeGeneration);
            cls.AddProperty(true, "connectProfiler", BindStaticRead_connectProfiler, BindStaticWrite_connectProfiler);
            cls.AddProperty(true, "buildWithDeepProfilingSupport", BindStaticRead_buildWithDeepProfilingSupport, BindStaticWrite_buildWithDeepProfilingSupport);
            cls.AddProperty(true, "allowDebugging", BindStaticRead_allowDebugging, BindStaticWrite_allowDebugging);
            cls.AddProperty(true, "waitForPlayerConnection", BindStaticRead_waitForPlayerConnection, BindStaticWrite_waitForPlayerConnection);
            cls.AddProperty(true, "exportAsGoogleAndroidProject", BindStaticRead_exportAsGoogleAndroidProject, BindStaticWrite_exportAsGoogleAndroidProject);
            cls.AddProperty(true, "buildAppBundle", BindStaticRead_buildAppBundle, BindStaticWrite_buildAppBundle);
            cls.AddProperty(true, "symlinkSources", BindStaticRead_symlinkSources, BindStaticWrite_symlinkSources);
            cls.AddProperty(true, "iOSXcodeBuildConfig", BindStaticRead_iOSXcodeBuildConfig, BindStaticWrite_iOSXcodeBuildConfig);
            cls.AddProperty(true, "macOSXcodeBuildConfig", BindStaticRead_macOSXcodeBuildConfig, BindStaticWrite_macOSXcodeBuildConfig);
            cls.AddProperty(true, "switchCreateRomFile", BindStaticRead_switchCreateRomFile, BindStaticWrite_switchCreateRomFile);
            cls.AddProperty(true, "switchEnableRomCompression", BindStaticRead_switchEnableRomCompression, BindStaticWrite_switchEnableRomCompression);
            cls.AddProperty(true, "switchSaveADF", BindStaticRead_switchSaveADF, BindStaticWrite_switchSaveADF);
            cls.AddProperty(true, "switchRomCompressionType", BindStaticRead_switchRomCompressionType, BindStaticWrite_switchRomCompressionType);
            cls.AddProperty(true, "switchRomCompressionLevel", BindStaticRead_switchRomCompressionLevel, BindStaticWrite_switchRomCompressionLevel);
            cls.AddProperty(true, "switchRomCompressionConfig", BindStaticRead_switchRomCompressionConfig, BindStaticWrite_switchRomCompressionConfig);
            cls.AddProperty(true, "switchNVNGraphicsDebugger", BindStaticRead_switchNVNGraphicsDebugger, BindStaticWrite_switchNVNGraphicsDebugger);
            cls.AddProperty(true, "generateNintendoSwitchShaderInfo", BindStaticRead_generateNintendoSwitchShaderInfo, BindStaticWrite_generateNintendoSwitchShaderInfo);
            cls.AddProperty(true, "switchNVNShaderDebugging", BindStaticRead_switchNVNShaderDebugging, BindStaticWrite_switchNVNShaderDebugging);
            cls.AddProperty(true, "switchNVNDrawValidation_Light", BindStaticRead_switchNVNDrawValidation_Light, BindStaticWrite_switchNVNDrawValidation_Light);
            cls.AddProperty(true, "switchNVNDrawValidation_Heavy", BindStaticRead_switchNVNDrawValidation_Heavy, BindStaticWrite_switchNVNDrawValidation_Heavy);
            cls.AddProperty(true, "switchEnableMemoryTracker", BindStaticRead_switchEnableMemoryTracker, BindStaticWrite_switchEnableMemoryTracker);
            cls.AddProperty(true, "switchWaitForMemoryTrackerOnStartup", BindStaticRead_switchWaitForMemoryTrackerOnStartup, BindStaticWrite_switchWaitForMemoryTrackerOnStartup);
            cls.AddProperty(true, "switchEnableDebugPad", BindStaticRead_switchEnableDebugPad, BindStaticWrite_switchEnableDebugPad);
            cls.AddProperty(true, "switchRedirectWritesToHostMount", BindStaticRead_switchRedirectWritesToHostMount, BindStaticWrite_switchRedirectWritesToHostMount);
            cls.AddProperty(true, "switchHTCSScriptDebugging", BindStaticRead_switchHTCSScriptDebugging, BindStaticWrite_switchHTCSScriptDebugging);
            cls.AddProperty(true, "switchUseLegacyNvnPoolAllocator", BindStaticRead_switchUseLegacyNvnPoolAllocator, BindStaticWrite_switchUseLegacyNvnPoolAllocator);
            cls.AddProperty(true, "installInBuildFolder", BindStaticRead_installInBuildFolder, BindStaticWrite_installInBuildFolder);
            cls.AddProperty(true, "waitForManagedDebugger", BindStaticRead_waitForManagedDebugger, BindStaticWrite_waitForManagedDebugger);
            cls.AddProperty(true, "managedDebuggerFixedPort", BindStaticRead_managedDebuggerFixedPort, BindStaticWrite_managedDebuggerFixedPort);
            return cls;
        }
    }
}
#endif
#endif
