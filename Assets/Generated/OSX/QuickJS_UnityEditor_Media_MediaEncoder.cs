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
    // Type: UnityEditor.Media.MediaEncoder
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_Media_MediaEncoder
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.Media.VideoTrackAttributes)) && Values.js_match_type(ctx, argv[2], typeof(UnityEditor.Media.AudioTrackAttributes[])))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.Media.MediaEncoder), ".ctor", typeof(string), 0);
                            }
                            UnityEditor.Media.VideoTrackAttributes arg1;
                            if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.Media.MediaEncoder), ".ctor", typeof(UnityEditor.Media.VideoTrackAttributes), 1);
                            }
                            UnityEditor.Media.AudioTrackAttributes[] arg2;
                            if (!Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.Media.MediaEncoder), ".ctor", typeof(UnityEditor.Media.AudioTrackAttributes[]), 2);
                            }
                            var o = new UnityEditor.Media.MediaEncoder(arg0, arg1, arg2);
                            var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                            return val;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.Media.VideoTrackEncoderAttributes)) && Values.js_match_type(ctx, argv[2], typeof(UnityEditor.Media.AudioTrackAttributes[])))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.Media.MediaEncoder), ".ctor", typeof(string), 0);
                            }
                            UnityEditor.Media.VideoTrackEncoderAttributes arg1;
                            if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.Media.MediaEncoder), ".ctor", typeof(UnityEditor.Media.VideoTrackEncoderAttributes), 1);
                            }
                            UnityEditor.Media.AudioTrackAttributes[] arg2;
                            if (!Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.Media.MediaEncoder), ".ctor", typeof(UnityEditor.Media.AudioTrackAttributes[]), 2);
                            }
                            var o = new UnityEditor.Media.MediaEncoder(arg0, arg1, arg2);
                            var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                            return val;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.Media.VideoTrackEncoderAttributes)) && Values.js_match_type(ctx, argv[2], typeof(UnityEditor.Media.AudioTrackAttributes)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.Media.MediaEncoder), ".ctor", typeof(string), 0);
                            }
                            UnityEditor.Media.VideoTrackEncoderAttributes arg1;
                            if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.Media.MediaEncoder), ".ctor", typeof(UnityEditor.Media.VideoTrackEncoderAttributes), 1);
                            }
                            UnityEditor.Media.AudioTrackAttributes arg2;
                            if (!Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.Media.MediaEncoder), ".ctor", typeof(UnityEditor.Media.AudioTrackAttributes), 2);
                            }
                            var o = new UnityEditor.Media.MediaEncoder(arg0, arg1, arg2);
                            var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                            return val;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.Media.VideoTrackAttributes)) && Values.js_match_type(ctx, argv[2], typeof(UnityEditor.Media.AudioTrackAttributes)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.Media.MediaEncoder), ".ctor", typeof(string), 0);
                            }
                            UnityEditor.Media.VideoTrackAttributes arg1;
                            if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.Media.MediaEncoder), ".ctor", typeof(UnityEditor.Media.VideoTrackAttributes), 1);
                            }
                            UnityEditor.Media.AudioTrackAttributes arg2;
                            if (!Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.Media.MediaEncoder), ".ctor", typeof(UnityEditor.Media.AudioTrackAttributes), 2);
                            }
                            var o = new UnityEditor.Media.MediaEncoder(arg0, arg1, arg2);
                            var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                            return val;
                        }
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.Media.VideoTrackEncoderAttributes)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.Media.MediaEncoder), ".ctor", typeof(string), 0);
                            }
                            UnityEditor.Media.VideoTrackEncoderAttributes arg1;
                            if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.Media.MediaEncoder), ".ctor", typeof(UnityEditor.Media.VideoTrackEncoderAttributes), 1);
                            }
                            var o = new UnityEditor.Media.MediaEncoder(arg0, arg1);
                            var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                            return val;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.Media.VideoTrackAttributes)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.Media.MediaEncoder), ".ctor", typeof(string), 0);
                            }
                            UnityEditor.Media.VideoTrackAttributes arg1;
                            if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.Media.MediaEncoder), ".ctor", typeof(UnityEditor.Media.VideoTrackAttributes), 1);
                            }
                            var o = new UnityEditor.Media.MediaEncoder(arg0, arg1);
                            var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                            return val;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.Media.AudioTrackAttributes[])))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.Media.MediaEncoder), ".ctor", typeof(string), 0);
                            }
                            UnityEditor.Media.AudioTrackAttributes[] arg1;
                            if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.Media.MediaEncoder), ".ctor", typeof(UnityEditor.Media.AudioTrackAttributes[]), 1);
                            }
                            var o = new UnityEditor.Media.MediaEncoder(arg0, arg1);
                            var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                            return val;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.Media.AudioTrackAttributes)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.Media.MediaEncoder), ".ctor", typeof(string), 0);
                            }
                            UnityEditor.Media.AudioTrackAttributes arg1;
                            if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.Media.MediaEncoder), ".ctor", typeof(UnityEditor.Media.AudioTrackAttributes), 1);
                            }
                            var o = new UnityEditor.Media.MediaEncoder(arg0, arg1);
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
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_AddFrame(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        UnityEditor.Media.MediaEncoder self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.Texture2D arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.Media.MediaEncoder), "AddFrame", typeof(UnityEngine.Texture2D), 0);
                        }
                        UnityEditor.Media.MediaTime arg1;
                        if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.Media.MediaEncoder), "AddFrame", typeof(UnityEditor.Media.MediaTime), 1);
                        }
                        var ret = self.AddFrame(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        UnityEditor.Media.MediaEncoder self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.Texture2D arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.Media.MediaEncoder), "AddFrame", typeof(UnityEngine.Texture2D), 0);
                        }
                        var ret = self.AddFrame(arg0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("AddFrame", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Dispose(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.Media.MediaEncoder self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.Dispose();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Dispose", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("MediaEncoder", typeof(UnityEditor.Media.MediaEncoder), BindConstructor);
            cls.AddMethod(false, "AddFrame", Bind_AddFrame);
            cls.AddMethod(false, "Dispose", Bind_Dispose);
            return cls;
        }
    }
}
#endif
#endif
