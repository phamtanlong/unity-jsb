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
    // Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Applications/Unity/Hub/Editor/2019.4.40f1/Unity.app/Contents/Managed/UnityEngine/UnityEngine.CoreModule.dll
    // Type: UnityEngine.Texture
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_Texture
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetNativeTexturePtr(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.Texture self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.GetNativeTexturePtr();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetNativeTexturePtr", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_IncrementUpdateCount(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.Texture self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.IncrementUpdateCount();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("IncrementUpdateCount", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetGlobalAnisotropicFilteringLimits(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Texture), "SetGlobalAnisotropicFilteringLimits", typeof(int), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Texture), "SetGlobalAnisotropicFilteringLimits", typeof(int), 1);
                    }
                    UnityEngine.Texture.SetGlobalAnisotropicFilteringLimits(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetGlobalAnisotropicFilteringLimits", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetStreamingTextureMaterialDebugProperties(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.Texture.SetStreamingTextureMaterialDebugProperties();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetStreamingTextureMaterialDebugProperties", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_masterTextureLimit(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Texture.masterTextureLimit;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_masterTextureLimit(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Texture), "masterTextureLimit", typeof(int), 0);
                }
                UnityEngine.Texture.masterTextureLimit = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_mipmapCount(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Texture self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.mipmapCount;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_anisotropicFiltering(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Texture.anisotropicFiltering;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_anisotropicFiltering(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.AnisotropicFiltering value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Texture), "anisotropicFiltering", typeof(UnityEngine.AnisotropicFiltering), 0);
                }
                UnityEngine.Texture.anisotropicFiltering = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_graphicsFormat(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Texture self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.graphicsFormat;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_width(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Texture self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.width;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_width(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Texture self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Texture), "width", typeof(int), 0);
                }
                self.width = value;
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
                UnityEngine.Texture self;
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
                UnityEngine.Texture self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Texture), "height", typeof(int), 0);
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
        public static JSValue BindRead_dimension(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Texture self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.dimension;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_dimension(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Texture self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Rendering.TextureDimension value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Texture), "dimension", typeof(UnityEngine.Rendering.TextureDimension), 0);
                }
                self.dimension = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_isReadable(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Texture self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.isReadable;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_wrapMode(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Texture self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.wrapMode;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_wrapMode(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Texture self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.TextureWrapMode value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Texture), "wrapMode", typeof(UnityEngine.TextureWrapMode), 0);
                }
                self.wrapMode = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_wrapModeU(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Texture self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.wrapModeU;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_wrapModeU(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Texture self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.TextureWrapMode value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Texture), "wrapModeU", typeof(UnityEngine.TextureWrapMode), 0);
                }
                self.wrapModeU = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_wrapModeV(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Texture self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.wrapModeV;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_wrapModeV(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Texture self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.TextureWrapMode value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Texture), "wrapModeV", typeof(UnityEngine.TextureWrapMode), 0);
                }
                self.wrapModeV = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_wrapModeW(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Texture self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.wrapModeW;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_wrapModeW(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Texture self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.TextureWrapMode value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Texture), "wrapModeW", typeof(UnityEngine.TextureWrapMode), 0);
                }
                self.wrapModeW = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_filterMode(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Texture self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.filterMode;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_filterMode(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Texture self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.FilterMode value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Texture), "filterMode", typeof(UnityEngine.FilterMode), 0);
                }
                self.filterMode = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_anisoLevel(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Texture self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.anisoLevel;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_anisoLevel(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Texture self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Texture), "anisoLevel", typeof(int), 0);
                }
                self.anisoLevel = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_mipMapBias(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Texture self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.mipMapBias;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_mipMapBias(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Texture self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Texture), "mipMapBias", typeof(float), 0);
                }
                self.mipMapBias = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_texelSize(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Texture self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.texelSize;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_updateCount(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Texture self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.updateCount;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_totalTextureMemory(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Texture.totalTextureMemory;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_desiredTextureMemory(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Texture.desiredTextureMemory;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_targetTextureMemory(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Texture.targetTextureMemory;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_currentTextureMemory(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Texture.currentTextureMemory;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_nonStreamingTextureMemory(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Texture.nonStreamingTextureMemory;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_streamingMipmapUploadCount(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Texture.streamingMipmapUploadCount;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_streamingRendererCount(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Texture.streamingRendererCount;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_streamingTextureCount(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Texture.streamingTextureCount;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_nonStreamingTextureCount(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Texture.nonStreamingTextureCount;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_streamingTexturePendingLoadCount(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Texture.streamingTexturePendingLoadCount;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_streamingTextureLoadingCount(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Texture.streamingTextureLoadingCount;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_streamingTextureForceLoadAll(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Texture.streamingTextureForceLoadAll;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_streamingTextureForceLoadAll(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Texture), "streamingTextureForceLoadAll", typeof(bool), 0);
                }
                UnityEngine.Texture.streamingTextureForceLoadAll = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_streamingTextureDiscardUnusedMips(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Texture.streamingTextureDiscardUnusedMips;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_streamingTextureDiscardUnusedMips(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Texture), "streamingTextureDiscardUnusedMips", typeof(bool), 0);
                }
                UnityEngine.Texture.streamingTextureDiscardUnusedMips = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_allowThreadedTextureCreation(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Texture.allowThreadedTextureCreation;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_allowThreadedTextureCreation(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Texture), "allowThreadedTextureCreation", typeof(bool), 0);
                }
                UnityEngine.Texture.allowThreadedTextureCreation = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_GenerateAllMips(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Texture.GenerateAllMips;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("Texture", typeof(UnityEngine.Texture), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(false, "GetNativeTexturePtr", Bind_GetNativeTexturePtr);
            cls.AddMethod(false, "IncrementUpdateCount", Bind_IncrementUpdateCount);
            cls.AddMethod(true, "SetGlobalAnisotropicFilteringLimits", BindStatic_SetGlobalAnisotropicFilteringLimits);
            cls.AddMethod(true, "SetStreamingTextureMaterialDebugProperties", BindStatic_SetStreamingTextureMaterialDebugProperties);
            cls.AddProperty(true, "masterTextureLimit", BindStaticRead_masterTextureLimit, BindStaticWrite_masterTextureLimit);
            cls.AddProperty(false, "mipmapCount", BindRead_mipmapCount, null);
            cls.AddProperty(true, "anisotropicFiltering", BindStaticRead_anisotropicFiltering, BindStaticWrite_anisotropicFiltering);
            cls.AddProperty(false, "graphicsFormat", BindRead_graphicsFormat, null);
            cls.AddProperty(false, "width", BindRead_width, BindWrite_width);
            cls.AddProperty(false, "height", BindRead_height, BindWrite_height);
            cls.AddProperty(false, "dimension", BindRead_dimension, BindWrite_dimension);
            cls.AddProperty(false, "isReadable", BindRead_isReadable, null);
            cls.AddProperty(false, "wrapMode", BindRead_wrapMode, BindWrite_wrapMode);
            cls.AddProperty(false, "wrapModeU", BindRead_wrapModeU, BindWrite_wrapModeU);
            cls.AddProperty(false, "wrapModeV", BindRead_wrapModeV, BindWrite_wrapModeV);
            cls.AddProperty(false, "wrapModeW", BindRead_wrapModeW, BindWrite_wrapModeW);
            cls.AddProperty(false, "filterMode", BindRead_filterMode, BindWrite_filterMode);
            cls.AddProperty(false, "anisoLevel", BindRead_anisoLevel, BindWrite_anisoLevel);
            cls.AddProperty(false, "mipMapBias", BindRead_mipMapBias, BindWrite_mipMapBias);
            cls.AddProperty(false, "texelSize", BindRead_texelSize, null);
            cls.AddProperty(false, "updateCount", BindRead_updateCount, null);
            cls.AddProperty(true, "totalTextureMemory", BindStaticRead_totalTextureMemory, null);
            cls.AddProperty(true, "desiredTextureMemory", BindStaticRead_desiredTextureMemory, null);
            cls.AddProperty(true, "targetTextureMemory", BindStaticRead_targetTextureMemory, null);
            cls.AddProperty(true, "currentTextureMemory", BindStaticRead_currentTextureMemory, null);
            cls.AddProperty(true, "nonStreamingTextureMemory", BindStaticRead_nonStreamingTextureMemory, null);
            cls.AddProperty(true, "streamingMipmapUploadCount", BindStaticRead_streamingMipmapUploadCount, null);
            cls.AddProperty(true, "streamingRendererCount", BindStaticRead_streamingRendererCount, null);
            cls.AddProperty(true, "streamingTextureCount", BindStaticRead_streamingTextureCount, null);
            cls.AddProperty(true, "nonStreamingTextureCount", BindStaticRead_nonStreamingTextureCount, null);
            cls.AddProperty(true, "streamingTexturePendingLoadCount", BindStaticRead_streamingTexturePendingLoadCount, null);
            cls.AddProperty(true, "streamingTextureLoadingCount", BindStaticRead_streamingTextureLoadingCount, null);
            cls.AddProperty(true, "streamingTextureForceLoadAll", BindStaticRead_streamingTextureForceLoadAll, BindStaticWrite_streamingTextureForceLoadAll);
            cls.AddProperty(true, "streamingTextureDiscardUnusedMips", BindStaticRead_streamingTextureDiscardUnusedMips, BindStaticWrite_streamingTextureDiscardUnusedMips);
            cls.AddProperty(true, "allowThreadedTextureCreation", BindStaticRead_allowThreadedTextureCreation, BindStaticWrite_allowThreadedTextureCreation);
            cls.AddField(true, "GenerateAllMips", BindStaticRead_GenerateAllMips, null);
            return cls;
        }
    }
}
#endif
