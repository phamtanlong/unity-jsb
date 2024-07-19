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
    // Type: UnityEditor.StaticOcclusionCulling
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_StaticOcclusionCulling
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Compute(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.StaticOcclusionCulling.Compute();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("Compute", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GenerateInBackground(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.StaticOcclusionCulling.GenerateInBackground();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GenerateInBackground", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RemoveCacheFolder(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.StaticOcclusionCulling.RemoveCacheFolder();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RemoveCacheFolder", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Cancel(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.StaticOcclusionCulling.Cancel();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Cancel", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Clear(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.StaticOcclusionCulling.Clear();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Clear", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetDefaultOcclusionBakeSettings(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.StaticOcclusionCulling.SetDefaultOcclusionBakeSettings();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetDefaultOcclusionBakeSettings", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_isRunning(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.StaticOcclusionCulling.isRunning;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_smallestOccluder(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.StaticOcclusionCulling.smallestOccluder;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_smallestOccluder(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.StaticOcclusionCulling), "smallestOccluder", typeof(float), 0);
                }
                UnityEditor.StaticOcclusionCulling.smallestOccluder = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_smallestHole(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.StaticOcclusionCulling.smallestHole;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_smallestHole(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.StaticOcclusionCulling), "smallestHole", typeof(float), 0);
                }
                UnityEditor.StaticOcclusionCulling.smallestHole = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_backfaceThreshold(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.StaticOcclusionCulling.backfaceThreshold;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_backfaceThreshold(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.StaticOcclusionCulling), "backfaceThreshold", typeof(float), 0);
                }
                UnityEditor.StaticOcclusionCulling.backfaceThreshold = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_doesSceneHaveManualPortals(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.StaticOcclusionCulling.doesSceneHaveManualPortals;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_umbraDataSize(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.StaticOcclusionCulling.umbraDataSize;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("StaticOcclusionCulling", typeof(UnityEditor.StaticOcclusionCulling), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "Compute", BindStatic_Compute);
            cls.AddMethod(true, "GenerateInBackground", BindStatic_GenerateInBackground);
            cls.AddMethod(true, "RemoveCacheFolder", BindStatic_RemoveCacheFolder);
            cls.AddMethod(true, "Cancel", BindStatic_Cancel);
            cls.AddMethod(true, "Clear", BindStatic_Clear);
            cls.AddMethod(true, "SetDefaultOcclusionBakeSettings", BindStatic_SetDefaultOcclusionBakeSettings);
            cls.AddProperty(true, "isRunning", BindStaticRead_isRunning, null);
            cls.AddProperty(true, "smallestOccluder", BindStaticRead_smallestOccluder, BindStaticWrite_smallestOccluder);
            cls.AddProperty(true, "smallestHole", BindStaticRead_smallestHole, BindStaticWrite_smallestHole);
            cls.AddProperty(true, "backfaceThreshold", BindStaticRead_backfaceThreshold, BindStaticWrite_backfaceThreshold);
            cls.AddProperty(true, "doesSceneHaveManualPortals", BindStaticRead_doesSceneHaveManualPortals, null);
            cls.AddProperty(true, "umbraDataSize", BindStaticRead_umbraDataSize, null);
            return cls;
        }
    }
}
#endif
#endif
