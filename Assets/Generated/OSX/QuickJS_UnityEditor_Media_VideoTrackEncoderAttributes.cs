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
    // Type: UnityEditor.Media.VideoTrackEncoderAttributes
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_Media_VideoTrackEncoderAttributes
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.Media.H264EncoderAttributes)))
                        {
                            UnityEditor.Media.H264EncoderAttributes arg0;
                            if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.Media.VideoTrackEncoderAttributes), ".ctor", typeof(UnityEditor.Media.H264EncoderAttributes), 0);
                            }
                            var o = new UnityEditor.Media.VideoTrackEncoderAttributes(arg0);
                            var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                            return val;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.Media.VP8EncoderAttributes)))
                        {
                            UnityEditor.Media.VP8EncoderAttributes arg0;
                            if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.Media.VideoTrackEncoderAttributes), ".ctor", typeof(UnityEditor.Media.VP8EncoderAttributes), 0);
                            }
                            var o = new UnityEditor.Media.VideoTrackEncoderAttributes(arg0);
                            var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                            return val;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("constructor", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_frameRate(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.Media.VideoTrackEncoderAttributes self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.frameRate;
                return Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_frameRate(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.Media.VideoTrackEncoderAttributes self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEditor.Media.MediaRational value;
                if (!Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.Media.VideoTrackEncoderAttributes), "frameRate", typeof(UnityEditor.Media.MediaRational), 0);
                }
                self.frameRate = value;
                Values.js_rebind_this(ctx, this_obj, ref self);
                return JSApi.JS_UNDEFINED;
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
                UnityEditor.Media.VideoTrackEncoderAttributes self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
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
                UnityEditor.Media.VideoTrackEncoderAttributes self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                uint value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.Media.VideoTrackEncoderAttributes), "width", typeof(uint), 0);
                }
                self.width = value;
                Values.js_rebind_this(ctx, this_obj, ref self);
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
                UnityEditor.Media.VideoTrackEncoderAttributes self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
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
                UnityEditor.Media.VideoTrackEncoderAttributes self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                uint value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.Media.VideoTrackEncoderAttributes), "height", typeof(uint), 0);
                }
                self.height = value;
                Values.js_rebind_this(ctx, this_obj, ref self);
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_targetBitRate(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.Media.VideoTrackEncoderAttributes self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.targetBitRate;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_targetBitRate(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.Media.VideoTrackEncoderAttributes self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                uint value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.Media.VideoTrackEncoderAttributes), "targetBitRate", typeof(uint), 0);
                }
                self.targetBitRate = value;
                Values.js_rebind_this(ctx, this_obj, ref self);
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_bitRateMode(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.Media.VideoTrackEncoderAttributes self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.bitRateMode;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_bitRateMode(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.Media.VideoTrackEncoderAttributes self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEditor.VideoBitrateMode value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.Media.VideoTrackEncoderAttributes), "bitRateMode", typeof(UnityEditor.VideoBitrateMode), 0);
                }
                self.bitRateMode = value;
                Values.js_rebind_this(ctx, this_obj, ref self);
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_includeAlpha(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.Media.VideoTrackEncoderAttributes self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.includeAlpha;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_includeAlpha(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.Media.VideoTrackEncoderAttributes self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.Media.VideoTrackEncoderAttributes), "includeAlpha", typeof(bool), 0);
                }
                self.includeAlpha = value;
                Values.js_rebind_this(ctx, this_obj, ref self);
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("VideoTrackEncoderAttributes", typeof(UnityEditor.Media.VideoTrackEncoderAttributes), BindConstructor);
            cls.AddField(false, "frameRate", BindRead_frameRate, BindWrite_frameRate);
            cls.AddField(false, "width", BindRead_width, BindWrite_width);
            cls.AddField(false, "height", BindRead_height, BindWrite_height);
            cls.AddField(false, "targetBitRate", BindRead_targetBitRate, BindWrite_targetBitRate);
            cls.AddField(false, "bitRateMode", BindRead_bitRateMode, BindWrite_bitRateMode);
            cls.AddField(false, "includeAlpha", BindRead_includeAlpha, BindWrite_includeAlpha);
            return cls;
        }
    }
}
#endif
#endif
