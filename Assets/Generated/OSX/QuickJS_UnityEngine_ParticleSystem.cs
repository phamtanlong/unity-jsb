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
    // Assembly: UnityEngine.ParticleSystemModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Applications/Unity/Hub/Editor/2019.4.40f1/Unity.app/Contents/Managed/UnityEngine/UnityEngine.ParticleSystemModule.dll
    // Type: UnityEngine.ParticleSystem
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_ParticleSystem
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                if (argc == 0)
                {
                    var o = new UnityEngine.ParticleSystem();
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
        public static JSValue Bind_SetParticles(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        UnityEngine.ParticleSystem self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.ParticleSystem.Particle[] arg0;
                        if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.ParticleSystem), "SetParticles", typeof(UnityEngine.ParticleSystem.Particle[]), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.ParticleSystem), "SetParticles", typeof(int), 1);
                        }
                        int arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.ParticleSystem), "SetParticles", typeof(int), 2);
                        }
                        self.SetParticles(arg0, arg1, arg2);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 2)
                    {
                        UnityEngine.ParticleSystem self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.ParticleSystem.Particle[] arg0;
                        if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.ParticleSystem), "SetParticles", typeof(UnityEngine.ParticleSystem.Particle[]), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.ParticleSystem), "SetParticles", typeof(int), 1);
                        }
                        self.SetParticles(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 1)
                    {
                        UnityEngine.ParticleSystem self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.ParticleSystem.Particle[] arg0;
                        if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.ParticleSystem), "SetParticles", typeof(UnityEngine.ParticleSystem.Particle[]), 0);
                        }
                        self.SetParticles(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("SetParticles", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetParticles(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        UnityEngine.ParticleSystem self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.ParticleSystem.Particle[] arg0;
                        if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.ParticleSystem), "GetParticles", typeof(UnityEngine.ParticleSystem.Particle[]), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.ParticleSystem), "GetParticles", typeof(int), 1);
                        }
                        int arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.ParticleSystem), "GetParticles", typeof(int), 2);
                        }
                        var ret = self.GetParticles(arg0, arg1, arg2);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 2)
                    {
                        UnityEngine.ParticleSystem self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.ParticleSystem.Particle[] arg0;
                        if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.ParticleSystem), "GetParticles", typeof(UnityEngine.ParticleSystem.Particle[]), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.ParticleSystem), "GetParticles", typeof(int), 1);
                        }
                        var ret = self.GetParticles(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        UnityEngine.ParticleSystem self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.ParticleSystem.Particle[] arg0;
                        if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.ParticleSystem), "GetParticles", typeof(UnityEngine.ParticleSystem.Particle[]), 0);
                        }
                        var ret = self.GetParticles(arg0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("GetParticles", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetCustomParticleData(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.ParticleSystem self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    System.Collections.Generic.List<UnityEngine.Vector4> arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.ParticleSystem), "SetCustomParticleData", typeof(System.Collections.Generic.List<UnityEngine.Vector4>), 0);
                    }
                    UnityEngine.ParticleSystemCustomData arg1;
                    if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.ParticleSystem), "SetCustomParticleData", typeof(UnityEngine.ParticleSystemCustomData), 1);
                    }
                    self.SetCustomParticleData(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetCustomParticleData", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetCustomParticleData(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.ParticleSystem self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    System.Collections.Generic.List<UnityEngine.Vector4> arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.ParticleSystem), "GetCustomParticleData", typeof(System.Collections.Generic.List<UnityEngine.Vector4>), 0);
                    }
                    UnityEngine.ParticleSystemCustomData arg1;
                    if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.ParticleSystem), "GetCustomParticleData", typeof(UnityEngine.ParticleSystemCustomData), 1);
                    }
                    var ret = self.GetCustomParticleData(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetCustomParticleData", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetPlaybackState(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.ParticleSystem self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.GetPlaybackState();
                    return Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetPlaybackState", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetPlaybackState(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.ParticleSystem self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.ParticleSystem.PlaybackState arg0;
                    if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.ParticleSystem), "SetPlaybackState", typeof(UnityEngine.ParticleSystem.PlaybackState), 0);
                    }
                    self.SetPlaybackState(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetPlaybackState", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetTrails(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.ParticleSystem self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.GetTrails();
                    return Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetTrails", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetTrails(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.ParticleSystem self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.ParticleSystem.Trails arg0;
                    if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.ParticleSystem), "SetTrails", typeof(UnityEngine.ParticleSystem.Trails), 0);
                    }
                    self.SetTrails(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetTrails", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Simulate(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        UnityEngine.ParticleSystem self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        float arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.ParticleSystem), "Simulate", typeof(float), 0);
                        }
                        bool arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.ParticleSystem), "Simulate", typeof(bool), 1);
                        }
                        bool arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.ParticleSystem), "Simulate", typeof(bool), 2);
                        }
                        bool arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.ParticleSystem), "Simulate", typeof(bool), 3);
                        }
                        self.Simulate(arg0, arg1, arg2, arg3);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 3)
                    {
                        UnityEngine.ParticleSystem self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        float arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.ParticleSystem), "Simulate", typeof(float), 0);
                        }
                        bool arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.ParticleSystem), "Simulate", typeof(bool), 1);
                        }
                        bool arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.ParticleSystem), "Simulate", typeof(bool), 2);
                        }
                        self.Simulate(arg0, arg1, arg2);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 2)
                    {
                        UnityEngine.ParticleSystem self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        float arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.ParticleSystem), "Simulate", typeof(float), 0);
                        }
                        bool arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.ParticleSystem), "Simulate", typeof(bool), 1);
                        }
                        self.Simulate(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 1)
                    {
                        UnityEngine.ParticleSystem self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        float arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.ParticleSystem), "Simulate", typeof(float), 0);
                        }
                        self.Simulate(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("Simulate", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Play(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        UnityEngine.ParticleSystem self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        bool arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.ParticleSystem), "Play", typeof(bool), 0);
                        }
                        self.Play(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 0)
                    {
                        UnityEngine.ParticleSystem self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        self.Play();
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("Play", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Pause(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        UnityEngine.ParticleSystem self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        bool arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.ParticleSystem), "Pause", typeof(bool), 0);
                        }
                        self.Pause(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 0)
                    {
                        UnityEngine.ParticleSystem self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        self.Pause();
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("Pause", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Stop(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        UnityEngine.ParticleSystem self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        bool arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.ParticleSystem), "Stop", typeof(bool), 0);
                        }
                        UnityEngine.ParticleSystemStopBehavior arg1;
                        if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.ParticleSystem), "Stop", typeof(UnityEngine.ParticleSystemStopBehavior), 1);
                        }
                        self.Stop(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 1)
                    {
                        UnityEngine.ParticleSystem self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        bool arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.ParticleSystem), "Stop", typeof(bool), 0);
                        }
                        self.Stop(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 0)
                    {
                        UnityEngine.ParticleSystem self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        self.Stop();
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("Stop", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Clear(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        UnityEngine.ParticleSystem self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        bool arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.ParticleSystem), "Clear", typeof(bool), 0);
                        }
                        self.Clear(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 0)
                    {
                        UnityEngine.ParticleSystem self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        self.Clear();
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("Clear", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_IsAlive(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        UnityEngine.ParticleSystem self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        bool arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.ParticleSystem), "IsAlive", typeof(bool), 0);
                        }
                        var ret = self.IsAlive(arg0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 0)
                    {
                        UnityEngine.ParticleSystem self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        var ret = self.IsAlive();
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("IsAlive", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Emit(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        UnityEngine.ParticleSystem self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.ParticleSystem.EmitParams arg0;
                        if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.ParticleSystem), "Emit", typeof(UnityEngine.ParticleSystem.EmitParams), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.ParticleSystem), "Emit", typeof(int), 1);
                        }
                        self.Emit(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 1)
                    {
                        UnityEngine.ParticleSystem self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        int arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.ParticleSystem), "Emit", typeof(int), 0);
                        }
                        self.Emit(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("Emit", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_TriggerSubEmitter(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type_hint(ctx, argv[1], typeof(UnityEngine.ParticleSystem.Particle)))
                        {
                            UnityEngine.ParticleSystem self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.ParticleSystem), "TriggerSubEmitter", typeof(int), 0);
                            }
                            UnityEngine.ParticleSystem.Particle arg1;
                            var refVal1 = Values.js_read_wrap(ctx, argv[1]);
                            if (refVal1.IsException())
                            {
                                return refVal1;
                            }
                            if (!Values.js_get_structvalue(ctx, refVal1, out arg1))
                            {
                                JSApi.JS_FreeValue(ctx, refVal1);
                                throw new ParameterException(typeof(UnityEngine.ParticleSystem), "TriggerSubEmitter", typeof(UnityEngine.ParticleSystem.Particle), 1);
                            }
                            JSApi.JS_FreeValue(ctx, refVal1);
                            self.TriggerSubEmitter(arg0, ref arg1);
                            var out0 = Values.js_push_structvalue(ctx, arg1);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out0);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle>)))
                        {
                            UnityEngine.ParticleSystem self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.ParticleSystem), "TriggerSubEmitter", typeof(int), 0);
                            }
                            System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle> arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.ParticleSystem), "TriggerSubEmitter", typeof(System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle>), 1);
                            }
                            self.TriggerSubEmitter(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 1)
                    {
                        UnityEngine.ParticleSystem self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        int arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.ParticleSystem), "TriggerSubEmitter", typeof(int), 0);
                        }
                        self.TriggerSubEmitter(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("TriggerSubEmitter", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetSafeCollisionEventSize(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.ParticleSystem self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = UnityEngine.ParticlePhysicsExtensions.GetSafeCollisionEventSize(self);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetSafeCollisionEventSize", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetCollisionEvents(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.ParticleSystem self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.GameObject arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.ParticlePhysicsExtensions), "GetCollisionEvents", typeof(UnityEngine.GameObject), 0);
                    }
                    System.Collections.Generic.List<UnityEngine.ParticleCollisionEvent> arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.ParticlePhysicsExtensions), "GetCollisionEvents", typeof(System.Collections.Generic.List<UnityEngine.ParticleCollisionEvent>), 1);
                    }
                    var ret = UnityEngine.ParticlePhysicsExtensions.GetCollisionEvents(self, arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetCollisionEvents", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetSafeTriggerParticlesSize(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.ParticleSystem self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.ParticleSystemTriggerEventType arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.ParticlePhysicsExtensions), "GetSafeTriggerParticlesSize", typeof(UnityEngine.ParticleSystemTriggerEventType), 0);
                    }
                    var ret = UnityEngine.ParticlePhysicsExtensions.GetSafeTriggerParticlesSize(self, arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetSafeTriggerParticlesSize", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetTriggerParticles(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.ParticleSystem self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.ParticleSystemTriggerEventType arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.ParticlePhysicsExtensions), "GetTriggerParticles", typeof(UnityEngine.ParticleSystemTriggerEventType), 0);
                    }
                    System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle> arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.ParticlePhysicsExtensions), "GetTriggerParticles", typeof(System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle>), 1);
                    }
                    var ret = UnityEngine.ParticlePhysicsExtensions.GetTriggerParticles(self, arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetTriggerParticles", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetTriggerParticles(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        UnityEngine.ParticleSystem self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.ParticleSystemTriggerEventType arg0;
                        if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.ParticlePhysicsExtensions), "SetTriggerParticles", typeof(UnityEngine.ParticleSystemTriggerEventType), 0);
                        }
                        System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle> arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.ParticlePhysicsExtensions), "SetTriggerParticles", typeof(System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle>), 1);
                        }
                        int arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.ParticlePhysicsExtensions), "SetTriggerParticles", typeof(int), 2);
                        }
                        int arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.ParticlePhysicsExtensions), "SetTriggerParticles", typeof(int), 3);
                        }
                        UnityEngine.ParticlePhysicsExtensions.SetTriggerParticles(self, arg0, arg1, arg2, arg3);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 2)
                    {
                        UnityEngine.ParticleSystem self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.ParticleSystemTriggerEventType arg0;
                        if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.ParticlePhysicsExtensions), "SetTriggerParticles", typeof(UnityEngine.ParticleSystemTriggerEventType), 0);
                        }
                        System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle> arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.ParticlePhysicsExtensions), "SetTriggerParticles", typeof(System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle>), 1);
                        }
                        UnityEngine.ParticlePhysicsExtensions.SetTriggerParticles(self, arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("SetTriggerParticles", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ResetPreMappedBufferMemory(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.ParticleSystem.ResetPreMappedBufferMemory();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ResetPreMappedBufferMemory", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetMaximumPreMappedBufferCounts(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.ParticleSystem), "SetMaximumPreMappedBufferCounts", typeof(int), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.ParticleSystem), "SetMaximumPreMappedBufferCounts", typeof(int), 1);
                    }
                    UnityEngine.ParticleSystem.SetMaximumPreMappedBufferCounts(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetMaximumPreMappedBufferCounts", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_isPlaying(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.ParticleSystem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.isPlaying;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_isEmitting(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.ParticleSystem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.isEmitting;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_isStopped(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.ParticleSystem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.isStopped;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_isPaused(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.ParticleSystem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.isPaused;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_particleCount(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.ParticleSystem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.particleCount;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_time(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.ParticleSystem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.time;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_time(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.ParticleSystem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.ParticleSystem), "time", typeof(float), 0);
                }
                self.time = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_randomSeed(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.ParticleSystem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.randomSeed;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_randomSeed(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.ParticleSystem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                uint value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.ParticleSystem), "randomSeed", typeof(uint), 0);
                }
                self.randomSeed = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_useAutoRandomSeed(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.ParticleSystem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.useAutoRandomSeed;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_useAutoRandomSeed(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.ParticleSystem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.ParticleSystem), "useAutoRandomSeed", typeof(bool), 0);
                }
                self.useAutoRandomSeed = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_proceduralSimulationSupported(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.ParticleSystem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.proceduralSimulationSupported;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_main(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.ParticleSystem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.main;
                return Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_emission(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.ParticleSystem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.emission;
                return Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_shape(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.ParticleSystem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.shape;
                return Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_velocityOverLifetime(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.ParticleSystem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.velocityOverLifetime;
                return Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_limitVelocityOverLifetime(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.ParticleSystem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.limitVelocityOverLifetime;
                return Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_inheritVelocity(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.ParticleSystem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.inheritVelocity;
                return Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_forceOverLifetime(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.ParticleSystem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.forceOverLifetime;
                return Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_colorOverLifetime(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.ParticleSystem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.colorOverLifetime;
                return Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_colorBySpeed(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.ParticleSystem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.colorBySpeed;
                return Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_sizeOverLifetime(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.ParticleSystem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.sizeOverLifetime;
                return Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_sizeBySpeed(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.ParticleSystem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.sizeBySpeed;
                return Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_rotationOverLifetime(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.ParticleSystem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.rotationOverLifetime;
                return Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_rotationBySpeed(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.ParticleSystem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.rotationBySpeed;
                return Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_externalForces(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.ParticleSystem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.externalForces;
                return Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_noise(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.ParticleSystem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.noise;
                return Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_collision(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.ParticleSystem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.collision;
                return Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_trigger(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.ParticleSystem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.trigger;
                return Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_subEmitters(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.ParticleSystem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.subEmitters;
                return Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_textureSheetAnimation(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.ParticleSystem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.textureSheetAnimation;
                return Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_lights(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.ParticleSystem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.lights;
                return Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_trails(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.ParticleSystem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.trails;
                return Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_customData(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.ParticleSystem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.customData;
                return Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("ParticleSystem", typeof(UnityEngine.ParticleSystem), BindConstructor);
            cls.AddMethod(false, "SetParticles", Bind_SetParticles);
            cls.AddMethod(false, "GetParticles", Bind_GetParticles);
            cls.AddMethod(false, "SetCustomParticleData", Bind_SetCustomParticleData);
            cls.AddMethod(false, "GetCustomParticleData", Bind_GetCustomParticleData);
            cls.AddMethod(false, "GetPlaybackState", Bind_GetPlaybackState);
            cls.AddMethod(false, "SetPlaybackState", Bind_SetPlaybackState);
            cls.AddMethod(false, "GetTrails", Bind_GetTrails);
            cls.AddMethod(false, "SetTrails", Bind_SetTrails);
            cls.AddMethod(false, "Simulate", Bind_Simulate);
            cls.AddMethod(false, "Play", Bind_Play);
            cls.AddMethod(false, "Pause", Bind_Pause);
            cls.AddMethod(false, "Stop", Bind_Stop);
            cls.AddMethod(false, "Clear", Bind_Clear);
            cls.AddMethod(false, "IsAlive", Bind_IsAlive);
            cls.AddMethod(false, "Emit", Bind_Emit);
            cls.AddMethod(false, "TriggerSubEmitter", Bind_TriggerSubEmitter);
            cls.AddMethod(false, "GetSafeCollisionEventSize", Bind_GetSafeCollisionEventSize);
            cls.AddMethod(false, "GetCollisionEvents", Bind_GetCollisionEvents);
            cls.AddMethod(false, "GetSafeTriggerParticlesSize", Bind_GetSafeTriggerParticlesSize);
            cls.AddMethod(false, "GetTriggerParticles", Bind_GetTriggerParticles);
            cls.AddMethod(false, "SetTriggerParticles", Bind_SetTriggerParticles);
            cls.AddMethod(true, "ResetPreMappedBufferMemory", BindStatic_ResetPreMappedBufferMemory);
            cls.AddMethod(true, "SetMaximumPreMappedBufferCounts", BindStatic_SetMaximumPreMappedBufferCounts);
            cls.AddProperty(false, "isPlaying", BindRead_isPlaying, null);
            cls.AddProperty(false, "isEmitting", BindRead_isEmitting, null);
            cls.AddProperty(false, "isStopped", BindRead_isStopped, null);
            cls.AddProperty(false, "isPaused", BindRead_isPaused, null);
            cls.AddProperty(false, "particleCount", BindRead_particleCount, null);
            cls.AddProperty(false, "time", BindRead_time, BindWrite_time);
            cls.AddProperty(false, "randomSeed", BindRead_randomSeed, BindWrite_randomSeed);
            cls.AddProperty(false, "useAutoRandomSeed", BindRead_useAutoRandomSeed, BindWrite_useAutoRandomSeed);
            cls.AddProperty(false, "proceduralSimulationSupported", BindRead_proceduralSimulationSupported, null);
            cls.AddProperty(false, "main", BindRead_main, null);
            cls.AddProperty(false, "emission", BindRead_emission, null);
            cls.AddProperty(false, "shape", BindRead_shape, null);
            cls.AddProperty(false, "velocityOverLifetime", BindRead_velocityOverLifetime, null);
            cls.AddProperty(false, "limitVelocityOverLifetime", BindRead_limitVelocityOverLifetime, null);
            cls.AddProperty(false, "inheritVelocity", BindRead_inheritVelocity, null);
            cls.AddProperty(false, "forceOverLifetime", BindRead_forceOverLifetime, null);
            cls.AddProperty(false, "colorOverLifetime", BindRead_colorOverLifetime, null);
            cls.AddProperty(false, "colorBySpeed", BindRead_colorBySpeed, null);
            cls.AddProperty(false, "sizeOverLifetime", BindRead_sizeOverLifetime, null);
            cls.AddProperty(false, "sizeBySpeed", BindRead_sizeBySpeed, null);
            cls.AddProperty(false, "rotationOverLifetime", BindRead_rotationOverLifetime, null);
            cls.AddProperty(false, "rotationBySpeed", BindRead_rotationBySpeed, null);
            cls.AddProperty(false, "externalForces", BindRead_externalForces, null);
            cls.AddProperty(false, "noise", BindRead_noise, null);
            cls.AddProperty(false, "collision", BindRead_collision, null);
            cls.AddProperty(false, "trigger", BindRead_trigger, null);
            cls.AddProperty(false, "subEmitters", BindRead_subEmitters, null);
            cls.AddProperty(false, "textureSheetAnimation", BindRead_textureSheetAnimation, null);
            cls.AddProperty(false, "lights", BindRead_lights, null);
            cls.AddProperty(false, "trails", BindRead_trails, null);
            cls.AddProperty(false, "customData", BindRead_customData, null);
            return cls;
        }
    }
}
#endif
