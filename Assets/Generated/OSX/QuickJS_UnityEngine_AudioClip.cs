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
    // Assembly: UnityEngine.AudioModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Applications/Unity/Hub/Editor/2019.4.40f1/Unity.app/Contents/Managed/UnityEngine/UnityEngine.AudioModule.dll
    // Type: UnityEngine.AudioClip
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_AudioClip
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_LoadAudioData(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.AudioClip self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.LoadAudioData();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("LoadAudioData", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_UnloadAudioData(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.AudioClip self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.UnloadAudioData();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("UnloadAudioData", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetData(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.AudioClip self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    float[] arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.AudioClip), "GetData", typeof(float[]), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.AudioClip), "GetData", typeof(int), 1);
                    }
                    var ret = self.GetData(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetData", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetData(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.AudioClip self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    float[] arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.AudioClip), "SetData", typeof(float[]), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.AudioClip), "SetData", typeof(int), 1);
                    }
                    var ret = self.SetData(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("SetData", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Create(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 7)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.AudioClip), "Create", typeof(string), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.AudioClip), "Create", typeof(int), 1);
                        }
                        int arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.AudioClip), "Create", typeof(int), 2);
                        }
                        int arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.AudioClip), "Create", typeof(int), 3);
                        }
                        bool arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.AudioClip), "Create", typeof(bool), 4);
                        }
                        UnityEngine.AudioClip.PCMReaderCallback arg5;
                        if (!Values.js_get_delegate(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEngine.AudioClip), "Create", typeof(UnityEngine.AudioClip.PCMReaderCallback), 5);
                        }
                        UnityEngine.AudioClip.PCMSetPositionCallback arg6;
                        if (!Values.js_get_delegate(ctx, argv[6], out arg6))
                        {
                            throw new ParameterException(typeof(UnityEngine.AudioClip), "Create", typeof(UnityEngine.AudioClip.PCMSetPositionCallback), 6);
                        }
                        var ret = UnityEngine.AudioClip.Create(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 6)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.AudioClip), "Create", typeof(string), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.AudioClip), "Create", typeof(int), 1);
                        }
                        int arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.AudioClip), "Create", typeof(int), 2);
                        }
                        int arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.AudioClip), "Create", typeof(int), 3);
                        }
                        bool arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.AudioClip), "Create", typeof(bool), 4);
                        }
                        UnityEngine.AudioClip.PCMReaderCallback arg5;
                        if (!Values.js_get_delegate(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEngine.AudioClip), "Create", typeof(UnityEngine.AudioClip.PCMReaderCallback), 5);
                        }
                        var ret = UnityEngine.AudioClip.Create(arg0, arg1, arg2, arg3, arg4, arg5);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 5)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.AudioClip), "Create", typeof(string), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.AudioClip), "Create", typeof(int), 1);
                        }
                        int arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.AudioClip), "Create", typeof(int), 2);
                        }
                        int arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.AudioClip), "Create", typeof(int), 3);
                        }
                        bool arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.AudioClip), "Create", typeof(bool), 4);
                        }
                        var ret = UnityEngine.AudioClip.Create(arg0, arg1, arg2, arg3, arg4);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("Create", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_length(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.AudioClip self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.length;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_samples(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.AudioClip self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.samples;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_channels(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.AudioClip self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.channels;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_frequency(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.AudioClip self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.frequency;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_loadType(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.AudioClip self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.loadType;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_preloadAudioData(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.AudioClip self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.preloadAudioData;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_ambisonic(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.AudioClip self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.ambisonic;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_loadInBackground(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.AudioClip self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.loadInBackground;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_loadState(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.AudioClip self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.loadState;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("AudioClip", typeof(UnityEngine.AudioClip), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(false, "LoadAudioData", Bind_LoadAudioData);
            cls.AddMethod(false, "UnloadAudioData", Bind_UnloadAudioData);
            cls.AddMethod(false, "GetData", Bind_GetData);
            cls.AddMethod(false, "SetData", Bind_SetData);
            cls.AddMethod(true, "Create", BindStatic_Create);
            cls.AddProperty(false, "length", BindRead_length, null);
            cls.AddProperty(false, "samples", BindRead_samples, null);
            cls.AddProperty(false, "channels", BindRead_channels, null);
            cls.AddProperty(false, "frequency", BindRead_frequency, null);
            cls.AddProperty(false, "loadType", BindRead_loadType, null);
            cls.AddProperty(false, "preloadAudioData", BindRead_preloadAudioData, null);
            cls.AddProperty(false, "ambisonic", BindRead_ambisonic, null);
            cls.AddProperty(false, "loadInBackground", BindRead_loadInBackground, null);
            cls.AddProperty(false, "loadState", BindRead_loadState, null);
            return cls;
        }
    }
}
#endif
