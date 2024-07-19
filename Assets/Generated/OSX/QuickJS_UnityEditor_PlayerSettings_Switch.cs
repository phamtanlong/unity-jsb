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
    // Type: UnityEditor.PlayerSettings+Switch
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_PlayerSettings_Switch
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                if (argc == 0)
                {
                    var o = new UnityEditor.PlayerSettings.Switch();
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
        public static JSValue BindStatic_GetRatingAge(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.PlayerSettings.Switch.RatingCategories arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "GetRatingAge", typeof(UnityEditor.PlayerSettings.Switch.RatingCategories), 0);
                    }
                    var ret = UnityEditor.PlayerSettings.Switch.GetRatingAge(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetRatingAge", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_socketMemoryPoolSize(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.socketMemoryPoolSize;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_socketMemoryPoolSize(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "socketMemoryPoolSize", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.Switch.socketMemoryPoolSize = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_socketAllocatorPoolSize(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.socketAllocatorPoolSize;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_socketAllocatorPoolSize(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "socketAllocatorPoolSize", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.Switch.socketAllocatorPoolSize = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_socketConcurrencyLimit(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.socketConcurrencyLimit;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_socketConcurrencyLimit(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "socketConcurrencyLimit", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.Switch.socketConcurrencyLimit = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_useSwitchCPUProfiler(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.useSwitchCPUProfiler;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_useSwitchCPUProfiler(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "useSwitchCPUProfiler", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.Switch.useSwitchCPUProfiler = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_systemResourceMemory(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.systemResourceMemory;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_systemResourceMemory(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "systemResourceMemory", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.Switch.systemResourceMemory = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_queueCommandMemory(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.queueCommandMemory;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_queueCommandMemory(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "queueCommandMemory", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.Switch.queueCommandMemory = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_defaultSwitchQueueCommandMemory(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.defaultSwitchQueueCommandMemory;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_minimumSwitchQueueCommandMemory(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.minimumSwitchQueueCommandMemory;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_queueControlMemory(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.queueControlMemory;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_queueControlMemory(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "queueControlMemory", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.Switch.queueControlMemory = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_defaultSwitchQueueControlMemory(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.defaultSwitchQueueControlMemory;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_minimumSwitchQueueControlMemory(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.minimumSwitchQueueControlMemory;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_queueComputeMemory(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.queueComputeMemory;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_queueComputeMemory(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "queueComputeMemory", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.Switch.queueComputeMemory = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_defaultSwitchQueueComputeMemory(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.defaultSwitchQueueComputeMemory;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_NVNShaderPoolsGranularity(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.NVNShaderPoolsGranularity;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_NVNShaderPoolsGranularity(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "NVNShaderPoolsGranularity", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.Switch.NVNShaderPoolsGranularity = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_NVNDefaultPoolsGranularity(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.NVNDefaultPoolsGranularity;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_NVNDefaultPoolsGranularity(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "NVNDefaultPoolsGranularity", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.Switch.NVNDefaultPoolsGranularity = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_NVNOtherPoolsGranularity(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.NVNOtherPoolsGranularity;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_NVNOtherPoolsGranularity(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "NVNOtherPoolsGranularity", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.Switch.NVNOtherPoolsGranularity = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_NVNMaxPublicTextureIDCount(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.NVNMaxPublicTextureIDCount;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_NVNMaxPublicTextureIDCount(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "NVNMaxPublicTextureIDCount", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.Switch.NVNMaxPublicTextureIDCount = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_NVNMaxPublicSamplerIDCount(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.NVNMaxPublicSamplerIDCount;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_NVNMaxPublicSamplerIDCount(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "NVNMaxPublicSamplerIDCount", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.Switch.NVNMaxPublicSamplerIDCount = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_screenResolutionBehavior(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.screenResolutionBehavior;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_screenResolutionBehavior(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.PlayerSettings.Switch.ScreenResolutionBehavior value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "screenResolutionBehavior", typeof(UnityEditor.PlayerSettings.Switch.ScreenResolutionBehavior), 0);
                }
                UnityEditor.PlayerSettings.Switch.screenResolutionBehavior = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_applicationID(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.applicationID;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_applicationID(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "applicationID", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.Switch.applicationID = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_nsoDependencies(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.nsoDependencies;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_nsoDependencies(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "nsoDependencies", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.Switch.nsoDependencies = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_titleNames(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.titleNames;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_titleNames(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string[] value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "titleNames", typeof(string[]), 0);
                }
                UnityEditor.PlayerSettings.Switch.titleNames = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_publisherNames(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.publisherNames;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_publisherNames(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string[] value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "publisherNames", typeof(string[]), 0);
                }
                UnityEditor.PlayerSettings.Switch.publisherNames = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_icons(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.icons;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_icons(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Texture2D[] value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "icons", typeof(UnityEngine.Texture2D[]), 0);
                }
                UnityEditor.PlayerSettings.Switch.icons = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_smallIcons(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.smallIcons;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_smallIcons(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Texture2D[] value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "smallIcons", typeof(UnityEngine.Texture2D[]), 0);
                }
                UnityEditor.PlayerSettings.Switch.smallIcons = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_manualHTMLPath(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.manualHTMLPath;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_manualHTMLPath(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "manualHTMLPath", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.Switch.manualHTMLPath = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_accessibleURLPath(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.accessibleURLPath;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_accessibleURLPath(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "accessibleURLPath", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.Switch.accessibleURLPath = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_legalInformationPath(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.legalInformationPath;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_legalInformationPath(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "legalInformationPath", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.Switch.legalInformationPath = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_mainThreadStackSize(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.mainThreadStackSize;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_mainThreadStackSize(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "mainThreadStackSize", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.Switch.mainThreadStackSize = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_presenceGroupId(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.presenceGroupId;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_presenceGroupId(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "presenceGroupId", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.Switch.presenceGroupId = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_logoHandling(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.logoHandling;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_logoHandling(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.PlayerSettings.Switch.LogoHandling value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "logoHandling", typeof(UnityEditor.PlayerSettings.Switch.LogoHandling), 0);
                }
                UnityEditor.PlayerSettings.Switch.logoHandling = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_releaseVersion(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.releaseVersion;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_releaseVersion(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "releaseVersion", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.Switch.releaseVersion = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_displayVersion(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.displayVersion;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_displayVersion(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "displayVersion", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.Switch.displayVersion = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_startupUserAccount(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.startupUserAccount;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_startupUserAccount(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.PlayerSettings.Switch.StartupUserAccount value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "startupUserAccount", typeof(UnityEditor.PlayerSettings.Switch.StartupUserAccount), 0);
                }
                UnityEditor.PlayerSettings.Switch.startupUserAccount = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_touchScreenUsage(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.touchScreenUsage;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_touchScreenUsage(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.PlayerSettings.Switch.TouchScreenUsage value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "touchScreenUsage", typeof(UnityEditor.PlayerSettings.Switch.TouchScreenUsage), 0);
                }
                UnityEditor.PlayerSettings.Switch.touchScreenUsage = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_supportedLanguages(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.supportedLanguages;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_supportedLanguages(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "supportedLanguages", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.Switch.supportedLanguages = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_logoType(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.logoType;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_logoType(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.PlayerSettings.Switch.LogoType value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "logoType", typeof(UnityEditor.PlayerSettings.Switch.LogoType), 0);
                }
                UnityEditor.PlayerSettings.Switch.logoType = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_applicationErrorCodeCategory(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.applicationErrorCodeCategory;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_applicationErrorCodeCategory(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "applicationErrorCodeCategory", typeof(string), 0);
                }
                UnityEditor.PlayerSettings.Switch.applicationErrorCodeCategory = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_userAccountSaveDataSize(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.userAccountSaveDataSize;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_userAccountSaveDataSize(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "userAccountSaveDataSize", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.Switch.userAccountSaveDataSize = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_userAccountSaveDataJournalSize(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.userAccountSaveDataJournalSize;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_userAccountSaveDataJournalSize(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "userAccountSaveDataJournalSize", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.Switch.userAccountSaveDataJournalSize = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_applicationAttribute(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.applicationAttribute;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_applicationAttribute(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.PlayerSettings.Switch.ApplicationAttribute value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "applicationAttribute", typeof(UnityEditor.PlayerSettings.Switch.ApplicationAttribute), 0);
                }
                UnityEditor.PlayerSettings.Switch.applicationAttribute = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_cardSpecSize(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.cardSpecSize;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_cardSpecSize(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "cardSpecSize", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.Switch.cardSpecSize = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_cardSpecClock(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.cardSpecClock;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_cardSpecClock(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "cardSpecClock", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.Switch.cardSpecClock = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_ratingsMask(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.ratingsMask;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_ratingsMask(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "ratingsMask", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.Switch.ratingsMask = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_localCommunicationIds(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.localCommunicationIds;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_localCommunicationIds(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string[] value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "localCommunicationIds", typeof(string[]), 0);
                }
                UnityEditor.PlayerSettings.Switch.localCommunicationIds = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_isUnderParentalControl(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.isUnderParentalControl;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_isUnderParentalControl(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "isUnderParentalControl", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.Switch.isUnderParentalControl = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_isScreenshotEnabled(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.isScreenshotEnabled;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_isScreenshotEnabled(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "isScreenshotEnabled", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.Switch.isScreenshotEnabled = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_isVideoCapturingEnabled(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.isVideoCapturingEnabled;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_isVideoCapturingEnabled(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "isVideoCapturingEnabled", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.Switch.isVideoCapturingEnabled = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_isRuntimeAddOnContentInstallEnabled(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.isRuntimeAddOnContentInstallEnabled;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_isRuntimeAddOnContentInstallEnabled(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "isRuntimeAddOnContentInstallEnabled", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.Switch.isRuntimeAddOnContentInstallEnabled = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_isDataLossConfirmationEnabled(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.isDataLossConfirmationEnabled;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_isDataLossConfirmationEnabled(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "isDataLossConfirmationEnabled", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.Switch.isDataLossConfirmationEnabled = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_isUserAccountLockEnabled(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.isUserAccountLockEnabled;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_isUserAccountLockEnabled(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "isUserAccountLockEnabled", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.Switch.isUserAccountLockEnabled = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_supportedNpadStyles(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.supportedNpadStyles;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_supportedNpadStyles(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.PlayerSettings.Switch.SupportedNpadStyle value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "supportedNpadStyles", typeof(UnityEditor.PlayerSettings.Switch.SupportedNpadStyle), 0);
                }
                UnityEditor.PlayerSettings.Switch.supportedNpadStyles = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_ratingAgeArray(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.ratingAgeArray;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_ratingAgeArray(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int[] value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "ratingAgeArray", typeof(int[]), 0);
                }
                UnityEditor.PlayerSettings.Switch.ratingAgeArray = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_nativeFsCacheSize(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.nativeFsCacheSize;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_nativeFsCacheSize(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "nativeFsCacheSize", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.Switch.nativeFsCacheSize = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_isHoldTypeHorizontal(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.isHoldTypeHorizontal;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_isHoldTypeHorizontal(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "isHoldTypeHorizontal", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.Switch.isHoldTypeHorizontal = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_supportedNpadCount(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.supportedNpadCount;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_supportedNpadCount(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "supportedNpadCount", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.Switch.supportedNpadCount = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_socketConfigEnabled(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.socketConfigEnabled;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_socketConfigEnabled(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "socketConfigEnabled", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.Switch.socketConfigEnabled = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_tcpInitialSendBufferSize(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.tcpInitialSendBufferSize;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_tcpInitialSendBufferSize(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "tcpInitialSendBufferSize", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.Switch.tcpInitialSendBufferSize = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_tcpInitialReceiveBufferSize(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.tcpInitialReceiveBufferSize;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_tcpInitialReceiveBufferSize(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "tcpInitialReceiveBufferSize", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.Switch.tcpInitialReceiveBufferSize = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_tcpAutoSendBufferSizeMax(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.tcpAutoSendBufferSizeMax;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_tcpAutoSendBufferSizeMax(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "tcpAutoSendBufferSizeMax", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.Switch.tcpAutoSendBufferSizeMax = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_tcpAutoReceiveBufferSizeMax(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.tcpAutoReceiveBufferSizeMax;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_tcpAutoReceiveBufferSizeMax(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "tcpAutoReceiveBufferSizeMax", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.Switch.tcpAutoReceiveBufferSizeMax = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_udpSendBufferSize(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.udpSendBufferSize;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_udpSendBufferSize(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "udpSendBufferSize", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.Switch.udpSendBufferSize = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_udpReceiveBufferSize(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.udpReceiveBufferSize;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_udpReceiveBufferSize(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "udpReceiveBufferSize", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.Switch.udpReceiveBufferSize = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_socketBufferEfficiency(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.socketBufferEfficiency;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_socketBufferEfficiency(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "socketBufferEfficiency", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.Switch.socketBufferEfficiency = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_socketInitializeEnabled(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.socketInitializeEnabled;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_socketInitializeEnabled(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "socketInitializeEnabled", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.Switch.socketInitializeEnabled = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_networkInterfaceManagerInitializeEnabled(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.networkInterfaceManagerInitializeEnabled;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_networkInterfaceManagerInitializeEnabled(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "networkInterfaceManagerInitializeEnabled", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.Switch.networkInterfaceManagerInitializeEnabled = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_playerConnectionEnabled(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.playerConnectionEnabled;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_playerConnectionEnabled(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "playerConnectionEnabled", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.Switch.playerConnectionEnabled = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_switchUseMicroSleepForYield(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.switchUseMicroSleepForYield;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_switchUseMicroSleepForYield(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "switchUseMicroSleepForYield", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.Switch.switchUseMicroSleepForYield = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_switchMicroSleepForYieldTime(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.switchMicroSleepForYieldTime;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_switchMicroSleepForYieldTime(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "switchMicroSleepForYieldTime", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.Switch.switchMicroSleepForYieldTime = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_switchEnableRamDiskSupport(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.switchEnableRamDiskSupport;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_switchEnableRamDiskSupport(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "switchEnableRamDiskSupport", typeof(bool), 0);
                }
                UnityEditor.PlayerSettings.Switch.switchEnableRamDiskSupport = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_switchRamDiskSpaceSize(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.Switch.switchRamDiskSpaceSize;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_switchRamDiskSpaceSize(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.Switch), "switchRamDiskSpaceSize", typeof(int), 0);
                }
                UnityEditor.PlayerSettings.Switch.switchRamDiskSpaceSize = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("Switch", typeof(UnityEditor.PlayerSettings.Switch), BindConstructor);
            cls.AddMethod(true, "GetRatingAge", BindStatic_GetRatingAge);
            cls.AddProperty(true, "socketMemoryPoolSize", BindStaticRead_socketMemoryPoolSize, BindStaticWrite_socketMemoryPoolSize);
            cls.AddProperty(true, "socketAllocatorPoolSize", BindStaticRead_socketAllocatorPoolSize, BindStaticWrite_socketAllocatorPoolSize);
            cls.AddProperty(true, "socketConcurrencyLimit", BindStaticRead_socketConcurrencyLimit, BindStaticWrite_socketConcurrencyLimit);
            cls.AddProperty(true, "useSwitchCPUProfiler", BindStaticRead_useSwitchCPUProfiler, BindStaticWrite_useSwitchCPUProfiler);
            cls.AddProperty(true, "systemResourceMemory", BindStaticRead_systemResourceMemory, BindStaticWrite_systemResourceMemory);
            cls.AddProperty(true, "queueCommandMemory", BindStaticRead_queueCommandMemory, BindStaticWrite_queueCommandMemory);
            cls.AddProperty(true, "defaultSwitchQueueCommandMemory", BindStaticRead_defaultSwitchQueueCommandMemory, null);
            cls.AddProperty(true, "minimumSwitchQueueCommandMemory", BindStaticRead_minimumSwitchQueueCommandMemory, null);
            cls.AddProperty(true, "queueControlMemory", BindStaticRead_queueControlMemory, BindStaticWrite_queueControlMemory);
            cls.AddProperty(true, "defaultSwitchQueueControlMemory", BindStaticRead_defaultSwitchQueueControlMemory, null);
            cls.AddProperty(true, "minimumSwitchQueueControlMemory", BindStaticRead_minimumSwitchQueueControlMemory, null);
            cls.AddProperty(true, "queueComputeMemory", BindStaticRead_queueComputeMemory, BindStaticWrite_queueComputeMemory);
            cls.AddProperty(true, "defaultSwitchQueueComputeMemory", BindStaticRead_defaultSwitchQueueComputeMemory, null);
            cls.AddProperty(true, "NVNShaderPoolsGranularity", BindStaticRead_NVNShaderPoolsGranularity, BindStaticWrite_NVNShaderPoolsGranularity);
            cls.AddProperty(true, "NVNDefaultPoolsGranularity", BindStaticRead_NVNDefaultPoolsGranularity, BindStaticWrite_NVNDefaultPoolsGranularity);
            cls.AddProperty(true, "NVNOtherPoolsGranularity", BindStaticRead_NVNOtherPoolsGranularity, BindStaticWrite_NVNOtherPoolsGranularity);
            cls.AddProperty(true, "NVNMaxPublicTextureIDCount", BindStaticRead_NVNMaxPublicTextureIDCount, BindStaticWrite_NVNMaxPublicTextureIDCount);
            cls.AddProperty(true, "NVNMaxPublicSamplerIDCount", BindStaticRead_NVNMaxPublicSamplerIDCount, BindStaticWrite_NVNMaxPublicSamplerIDCount);
            cls.AddProperty(true, "screenResolutionBehavior", BindStaticRead_screenResolutionBehavior, BindStaticWrite_screenResolutionBehavior);
            cls.AddProperty(true, "applicationID", BindStaticRead_applicationID, BindStaticWrite_applicationID);
            cls.AddProperty(true, "nsoDependencies", BindStaticRead_nsoDependencies, BindStaticWrite_nsoDependencies);
            cls.AddProperty(true, "titleNames", BindStaticRead_titleNames, BindStaticWrite_titleNames);
            cls.AddProperty(true, "publisherNames", BindStaticRead_publisherNames, BindStaticWrite_publisherNames);
            cls.AddProperty(true, "icons", BindStaticRead_icons, BindStaticWrite_icons);
            cls.AddProperty(true, "smallIcons", BindStaticRead_smallIcons, BindStaticWrite_smallIcons);
            cls.AddProperty(true, "manualHTMLPath", BindStaticRead_manualHTMLPath, BindStaticWrite_manualHTMLPath);
            cls.AddProperty(true, "accessibleURLPath", BindStaticRead_accessibleURLPath, BindStaticWrite_accessibleURLPath);
            cls.AddProperty(true, "legalInformationPath", BindStaticRead_legalInformationPath, BindStaticWrite_legalInformationPath);
            cls.AddProperty(true, "mainThreadStackSize", BindStaticRead_mainThreadStackSize, BindStaticWrite_mainThreadStackSize);
            cls.AddProperty(true, "presenceGroupId", BindStaticRead_presenceGroupId, BindStaticWrite_presenceGroupId);
            cls.AddProperty(true, "logoHandling", BindStaticRead_logoHandling, BindStaticWrite_logoHandling);
            cls.AddProperty(true, "releaseVersion", BindStaticRead_releaseVersion, BindStaticWrite_releaseVersion);
            cls.AddProperty(true, "displayVersion", BindStaticRead_displayVersion, BindStaticWrite_displayVersion);
            cls.AddProperty(true, "startupUserAccount", BindStaticRead_startupUserAccount, BindStaticWrite_startupUserAccount);
            cls.AddProperty(true, "touchScreenUsage", BindStaticRead_touchScreenUsage, BindStaticWrite_touchScreenUsage);
            cls.AddProperty(true, "supportedLanguages", BindStaticRead_supportedLanguages, BindStaticWrite_supportedLanguages);
            cls.AddProperty(true, "logoType", BindStaticRead_logoType, BindStaticWrite_logoType);
            cls.AddProperty(true, "applicationErrorCodeCategory", BindStaticRead_applicationErrorCodeCategory, BindStaticWrite_applicationErrorCodeCategory);
            cls.AddProperty(true, "userAccountSaveDataSize", BindStaticRead_userAccountSaveDataSize, BindStaticWrite_userAccountSaveDataSize);
            cls.AddProperty(true, "userAccountSaveDataJournalSize", BindStaticRead_userAccountSaveDataJournalSize, BindStaticWrite_userAccountSaveDataJournalSize);
            cls.AddProperty(true, "applicationAttribute", BindStaticRead_applicationAttribute, BindStaticWrite_applicationAttribute);
            cls.AddProperty(true, "cardSpecSize", BindStaticRead_cardSpecSize, BindStaticWrite_cardSpecSize);
            cls.AddProperty(true, "cardSpecClock", BindStaticRead_cardSpecClock, BindStaticWrite_cardSpecClock);
            cls.AddProperty(true, "ratingsMask", BindStaticRead_ratingsMask, BindStaticWrite_ratingsMask);
            cls.AddProperty(true, "localCommunicationIds", BindStaticRead_localCommunicationIds, BindStaticWrite_localCommunicationIds);
            cls.AddProperty(true, "isUnderParentalControl", BindStaticRead_isUnderParentalControl, BindStaticWrite_isUnderParentalControl);
            cls.AddProperty(true, "isScreenshotEnabled", BindStaticRead_isScreenshotEnabled, BindStaticWrite_isScreenshotEnabled);
            cls.AddProperty(true, "isVideoCapturingEnabled", BindStaticRead_isVideoCapturingEnabled, BindStaticWrite_isVideoCapturingEnabled);
            cls.AddProperty(true, "isRuntimeAddOnContentInstallEnabled", BindStaticRead_isRuntimeAddOnContentInstallEnabled, BindStaticWrite_isRuntimeAddOnContentInstallEnabled);
            cls.AddProperty(true, "isDataLossConfirmationEnabled", BindStaticRead_isDataLossConfirmationEnabled, BindStaticWrite_isDataLossConfirmationEnabled);
            cls.AddProperty(true, "isUserAccountLockEnabled", BindStaticRead_isUserAccountLockEnabled, BindStaticWrite_isUserAccountLockEnabled);
            cls.AddProperty(true, "supportedNpadStyles", BindStaticRead_supportedNpadStyles, BindStaticWrite_supportedNpadStyles);
            cls.AddProperty(true, "ratingAgeArray", BindStaticRead_ratingAgeArray, BindStaticWrite_ratingAgeArray);
            cls.AddProperty(true, "nativeFsCacheSize", BindStaticRead_nativeFsCacheSize, BindStaticWrite_nativeFsCacheSize);
            cls.AddProperty(true, "isHoldTypeHorizontal", BindStaticRead_isHoldTypeHorizontal, BindStaticWrite_isHoldTypeHorizontal);
            cls.AddProperty(true, "supportedNpadCount", BindStaticRead_supportedNpadCount, BindStaticWrite_supportedNpadCount);
            cls.AddProperty(true, "socketConfigEnabled", BindStaticRead_socketConfigEnabled, BindStaticWrite_socketConfigEnabled);
            cls.AddProperty(true, "tcpInitialSendBufferSize", BindStaticRead_tcpInitialSendBufferSize, BindStaticWrite_tcpInitialSendBufferSize);
            cls.AddProperty(true, "tcpInitialReceiveBufferSize", BindStaticRead_tcpInitialReceiveBufferSize, BindStaticWrite_tcpInitialReceiveBufferSize);
            cls.AddProperty(true, "tcpAutoSendBufferSizeMax", BindStaticRead_tcpAutoSendBufferSizeMax, BindStaticWrite_tcpAutoSendBufferSizeMax);
            cls.AddProperty(true, "tcpAutoReceiveBufferSizeMax", BindStaticRead_tcpAutoReceiveBufferSizeMax, BindStaticWrite_tcpAutoReceiveBufferSizeMax);
            cls.AddProperty(true, "udpSendBufferSize", BindStaticRead_udpSendBufferSize, BindStaticWrite_udpSendBufferSize);
            cls.AddProperty(true, "udpReceiveBufferSize", BindStaticRead_udpReceiveBufferSize, BindStaticWrite_udpReceiveBufferSize);
            cls.AddProperty(true, "socketBufferEfficiency", BindStaticRead_socketBufferEfficiency, BindStaticWrite_socketBufferEfficiency);
            cls.AddProperty(true, "socketInitializeEnabled", BindStaticRead_socketInitializeEnabled, BindStaticWrite_socketInitializeEnabled);
            cls.AddProperty(true, "networkInterfaceManagerInitializeEnabled", BindStaticRead_networkInterfaceManagerInitializeEnabled, BindStaticWrite_networkInterfaceManagerInitializeEnabled);
            cls.AddProperty(true, "playerConnectionEnabled", BindStaticRead_playerConnectionEnabled, BindStaticWrite_playerConnectionEnabled);
            cls.AddProperty(true, "switchUseMicroSleepForYield", BindStaticRead_switchUseMicroSleepForYield, BindStaticWrite_switchUseMicroSleepForYield);
            cls.AddProperty(true, "switchMicroSleepForYieldTime", BindStaticRead_switchMicroSleepForYieldTime, BindStaticWrite_switchMicroSleepForYieldTime);
            cls.AddProperty(true, "switchEnableRamDiskSupport", BindStaticRead_switchEnableRamDiskSupport, BindStaticWrite_switchEnableRamDiskSupport);
            cls.AddProperty(true, "switchRamDiskSpaceSize", BindStaticRead_switchRamDiskSpaceSize, BindStaticWrite_switchRamDiskSpaceSize);
            return cls;
        }
    }
}
#endif
#endif
