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
    // Type: UnityEditor.UnityStats
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_UnityStats
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                if (argc == 0)
                {
                    var o = new UnityEditor.UnityStats();
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
        public static JSValue BindStaticRead_batches(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.UnityStats.batches;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_drawCalls(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.UnityStats.drawCalls;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_dynamicBatchedDrawCalls(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.UnityStats.dynamicBatchedDrawCalls;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_staticBatchedDrawCalls(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.UnityStats.staticBatchedDrawCalls;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_instancedBatchedDrawCalls(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.UnityStats.instancedBatchedDrawCalls;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_dynamicBatches(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.UnityStats.dynamicBatches;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_staticBatches(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.UnityStats.staticBatches;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_instancedBatches(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.UnityStats.instancedBatches;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_setPassCalls(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.UnityStats.setPassCalls;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_triangles(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.UnityStats.triangles;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_vertices(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.UnityStats.vertices;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_shadowCasters(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.UnityStats.shadowCasters;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_renderTextureChanges(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.UnityStats.renderTextureChanges;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_frameTime(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.UnityStats.frameTime;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_renderTime(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.UnityStats.renderTime;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_audioLevel(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.UnityStats.audioLevel;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_audioClippingAmount(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.UnityStats.audioClippingAmount;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_audioDSPLoad(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.UnityStats.audioDSPLoad;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_audioStreamLoad(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.UnityStats.audioStreamLoad;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_renderTextureCount(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.UnityStats.renderTextureCount;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_renderTextureBytes(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.UnityStats.renderTextureBytes;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_usedTextureMemorySize(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.UnityStats.usedTextureMemorySize;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_usedTextureCount(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.UnityStats.usedTextureCount;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_screenRes(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.UnityStats.screenRes;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_screenBytes(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.UnityStats.screenBytes;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_vboTotal(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.UnityStats.vboTotal;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_vboTotalBytes(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.UnityStats.vboTotalBytes;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_vboUploads(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.UnityStats.vboUploads;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_vboUploadBytes(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.UnityStats.vboUploadBytes;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_ibUploads(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.UnityStats.ibUploads;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_ibUploadBytes(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.UnityStats.ibUploadBytes;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_visibleSkinnedMeshes(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.UnityStats.visibleSkinnedMeshes;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_animationComponentsPlaying(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.UnityStats.animationComponentsPlaying;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_animatorComponentsPlaying(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.UnityStats.animatorComponentsPlaying;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("UnityStats", typeof(UnityEditor.UnityStats), BindConstructor);
            cls.AddProperty(true, "batches", BindStaticRead_batches, null);
            cls.AddProperty(true, "drawCalls", BindStaticRead_drawCalls, null);
            cls.AddProperty(true, "dynamicBatchedDrawCalls", BindStaticRead_dynamicBatchedDrawCalls, null);
            cls.AddProperty(true, "staticBatchedDrawCalls", BindStaticRead_staticBatchedDrawCalls, null);
            cls.AddProperty(true, "instancedBatchedDrawCalls", BindStaticRead_instancedBatchedDrawCalls, null);
            cls.AddProperty(true, "dynamicBatches", BindStaticRead_dynamicBatches, null);
            cls.AddProperty(true, "staticBatches", BindStaticRead_staticBatches, null);
            cls.AddProperty(true, "instancedBatches", BindStaticRead_instancedBatches, null);
            cls.AddProperty(true, "setPassCalls", BindStaticRead_setPassCalls, null);
            cls.AddProperty(true, "triangles", BindStaticRead_triangles, null);
            cls.AddProperty(true, "vertices", BindStaticRead_vertices, null);
            cls.AddProperty(true, "shadowCasters", BindStaticRead_shadowCasters, null);
            cls.AddProperty(true, "renderTextureChanges", BindStaticRead_renderTextureChanges, null);
            cls.AddProperty(true, "frameTime", BindStaticRead_frameTime, null);
            cls.AddProperty(true, "renderTime", BindStaticRead_renderTime, null);
            cls.AddProperty(true, "audioLevel", BindStaticRead_audioLevel, null);
            cls.AddProperty(true, "audioClippingAmount", BindStaticRead_audioClippingAmount, null);
            cls.AddProperty(true, "audioDSPLoad", BindStaticRead_audioDSPLoad, null);
            cls.AddProperty(true, "audioStreamLoad", BindStaticRead_audioStreamLoad, null);
            cls.AddProperty(true, "renderTextureCount", BindStaticRead_renderTextureCount, null);
            cls.AddProperty(true, "renderTextureBytes", BindStaticRead_renderTextureBytes, null);
            cls.AddProperty(true, "usedTextureMemorySize", BindStaticRead_usedTextureMemorySize, null);
            cls.AddProperty(true, "usedTextureCount", BindStaticRead_usedTextureCount, null);
            cls.AddProperty(true, "screenRes", BindStaticRead_screenRes, null);
            cls.AddProperty(true, "screenBytes", BindStaticRead_screenBytes, null);
            cls.AddProperty(true, "vboTotal", BindStaticRead_vboTotal, null);
            cls.AddProperty(true, "vboTotalBytes", BindStaticRead_vboTotalBytes, null);
            cls.AddProperty(true, "vboUploads", BindStaticRead_vboUploads, null);
            cls.AddProperty(true, "vboUploadBytes", BindStaticRead_vboUploadBytes, null);
            cls.AddProperty(true, "ibUploads", BindStaticRead_ibUploads, null);
            cls.AddProperty(true, "ibUploadBytes", BindStaticRead_ibUploadBytes, null);
            cls.AddProperty(true, "visibleSkinnedMeshes", BindStaticRead_visibleSkinnedMeshes, null);
            cls.AddProperty(true, "animationComponentsPlaying", BindStaticRead_animationComponentsPlaying, null);
            cls.AddProperty(true, "animatorComponentsPlaying", BindStaticRead_animatorComponentsPlaying, null);
            return cls;
        }
    }
}
#endif
#endif
