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
    // Type: UnityEngine.Transform
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_Transform
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetParent(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        UnityEngine.Transform self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.Transform arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Transform), "SetParent", typeof(UnityEngine.Transform), 0);
                        }
                        bool arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Transform), "SetParent", typeof(bool), 1);
                        }
                        self.SetParent(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 1)
                    {
                        UnityEngine.Transform self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.Transform arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Transform), "SetParent", typeof(UnityEngine.Transform), 0);
                        }
                        self.SetParent(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("SetParent", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetPositionAndRotation(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Transform self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Vector3 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Transform), "SetPositionAndRotation", typeof(UnityEngine.Vector3), 0);
                    }
                    UnityEngine.Quaternion arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Transform), "SetPositionAndRotation", typeof(UnityEngine.Quaternion), 1);
                    }
                    self.SetPositionAndRotation(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetPositionAndRotation", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Translate(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(float)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.Space)))
                        {
                            UnityEngine.Transform self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            float arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Transform), "Translate", typeof(float), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Transform), "Translate", typeof(float), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Transform), "Translate", typeof(float), 2);
                            }
                            UnityEngine.Space arg3;
                            if (!Values.js_get_enumvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Transform), "Translate", typeof(UnityEngine.Space), 3);
                            }
                            self.Translate(arg0, arg1, arg2, arg3);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(float)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.Transform)))
                        {
                            UnityEngine.Transform self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            float arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Transform), "Translate", typeof(float), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Transform), "Translate", typeof(float), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Transform), "Translate", typeof(float), 2);
                            }
                            UnityEngine.Transform arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Transform), "Translate", typeof(UnityEngine.Transform), 3);
                            }
                            self.Translate(arg0, arg1, arg2, arg3);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 3)
                    {
                        UnityEngine.Transform self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        float arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Transform), "Translate", typeof(float), 0);
                        }
                        float arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Transform), "Translate", typeof(float), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Transform), "Translate", typeof(float), 2);
                        }
                        self.Translate(arg0, arg1, arg2);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Space)))
                        {
                            UnityEngine.Transform self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Transform), "Translate", typeof(UnityEngine.Vector3), 0);
                            }
                            UnityEngine.Space arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Transform), "Translate", typeof(UnityEngine.Space), 1);
                            }
                            self.Translate(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Transform)))
                        {
                            UnityEngine.Transform self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Transform), "Translate", typeof(UnityEngine.Vector3), 0);
                            }
                            UnityEngine.Transform arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Transform), "Translate", typeof(UnityEngine.Transform), 1);
                            }
                            self.Translate(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 1)
                    {
                        UnityEngine.Transform self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Transform), "Translate", typeof(UnityEngine.Vector3), 0);
                        }
                        self.Translate(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("Translate", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Rotate(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        UnityEngine.Transform self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        float arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Transform), "Rotate", typeof(float), 0);
                        }
                        float arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Transform), "Rotate", typeof(float), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Transform), "Rotate", typeof(float), 2);
                        }
                        UnityEngine.Space arg3;
                        if (!Values.js_get_enumvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Transform), "Rotate", typeof(UnityEngine.Space), 3);
                        }
                        self.Rotate(arg0, arg1, arg2, arg3);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(float)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(float)))
                        {
                            UnityEngine.Transform self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            float arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Transform), "Rotate", typeof(float), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Transform), "Rotate", typeof(float), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Transform), "Rotate", typeof(float), 2);
                            }
                            self.Rotate(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Space)))
                        {
                            UnityEngine.Transform self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Transform), "Rotate", typeof(UnityEngine.Vector3), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Transform), "Rotate", typeof(float), 1);
                            }
                            UnityEngine.Space arg2;
                            if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Transform), "Rotate", typeof(UnityEngine.Space), 2);
                            }
                            self.Rotate(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Space)))
                        {
                            UnityEngine.Transform self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Transform), "Rotate", typeof(UnityEngine.Vector3), 0);
                            }
                            UnityEngine.Space arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Transform), "Rotate", typeof(UnityEngine.Space), 1);
                            }
                            self.Rotate(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(float)))
                        {
                            UnityEngine.Transform self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Transform), "Rotate", typeof(UnityEngine.Vector3), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Transform), "Rotate", typeof(float), 1);
                            }
                            self.Rotate(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 1)
                    {
                        UnityEngine.Transform self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Transform), "Rotate", typeof(UnityEngine.Vector3), 0);
                        }
                        self.Rotate(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("Rotate", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_RotateAround(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Transform self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Vector3 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Transform), "RotateAround", typeof(UnityEngine.Vector3), 0);
                    }
                    UnityEngine.Vector3 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Transform), "RotateAround", typeof(UnityEngine.Vector3), 1);
                    }
                    float arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEngine.Transform), "RotateAround", typeof(float), 2);
                    }
                    self.RotateAround(arg0, arg1, arg2);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RotateAround", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_LookAt(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Transform)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector3)))
                        {
                            UnityEngine.Transform self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            UnityEngine.Transform arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Transform), "LookAt", typeof(UnityEngine.Transform), 0);
                            }
                            UnityEngine.Vector3 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Transform), "LookAt", typeof(UnityEngine.Vector3), 1);
                            }
                            self.LookAt(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector3)))
                        {
                            UnityEngine.Transform self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Transform), "LookAt", typeof(UnityEngine.Vector3), 0);
                            }
                            UnityEngine.Vector3 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Transform), "LookAt", typeof(UnityEngine.Vector3), 1);
                            }
                            self.LookAt(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Transform)))
                        {
                            UnityEngine.Transform self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            UnityEngine.Transform arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Transform), "LookAt", typeof(UnityEngine.Transform), 0);
                            }
                            self.LookAt(arg0);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)))
                        {
                            UnityEngine.Transform self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Transform), "LookAt", typeof(UnityEngine.Vector3), 0);
                            }
                            self.LookAt(arg0);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("LookAt", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_TransformDirection(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        UnityEngine.Transform self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        float arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Transform), "TransformDirection", typeof(float), 0);
                        }
                        float arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Transform), "TransformDirection", typeof(float), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Transform), "TransformDirection", typeof(float), 2);
                        }
                        var ret = self.TransformDirection(arg0, arg1, arg2);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        UnityEngine.Transform self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Transform), "TransformDirection", typeof(UnityEngine.Vector3), 0);
                        }
                        var ret = self.TransformDirection(arg0);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("TransformDirection", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_InverseTransformDirection(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        UnityEngine.Transform self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        float arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Transform), "InverseTransformDirection", typeof(float), 0);
                        }
                        float arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Transform), "InverseTransformDirection", typeof(float), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Transform), "InverseTransformDirection", typeof(float), 2);
                        }
                        var ret = self.InverseTransformDirection(arg0, arg1, arg2);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        UnityEngine.Transform self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Transform), "InverseTransformDirection", typeof(UnityEngine.Vector3), 0);
                        }
                        var ret = self.InverseTransformDirection(arg0);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("InverseTransformDirection", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_TransformVector(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        UnityEngine.Transform self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        float arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Transform), "TransformVector", typeof(float), 0);
                        }
                        float arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Transform), "TransformVector", typeof(float), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Transform), "TransformVector", typeof(float), 2);
                        }
                        var ret = self.TransformVector(arg0, arg1, arg2);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        UnityEngine.Transform self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Transform), "TransformVector", typeof(UnityEngine.Vector3), 0);
                        }
                        var ret = self.TransformVector(arg0);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("TransformVector", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_InverseTransformVector(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        UnityEngine.Transform self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        float arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Transform), "InverseTransformVector", typeof(float), 0);
                        }
                        float arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Transform), "InverseTransformVector", typeof(float), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Transform), "InverseTransformVector", typeof(float), 2);
                        }
                        var ret = self.InverseTransformVector(arg0, arg1, arg2);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        UnityEngine.Transform self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Transform), "InverseTransformVector", typeof(UnityEngine.Vector3), 0);
                        }
                        var ret = self.InverseTransformVector(arg0);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("InverseTransformVector", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_TransformPoint(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        UnityEngine.Transform self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        float arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Transform), "TransformPoint", typeof(float), 0);
                        }
                        float arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Transform), "TransformPoint", typeof(float), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Transform), "TransformPoint", typeof(float), 2);
                        }
                        var ret = self.TransformPoint(arg0, arg1, arg2);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        UnityEngine.Transform self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Transform), "TransformPoint", typeof(UnityEngine.Vector3), 0);
                        }
                        var ret = self.TransformPoint(arg0);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("TransformPoint", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_InverseTransformPoint(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        UnityEngine.Transform self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        float arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Transform), "InverseTransformPoint", typeof(float), 0);
                        }
                        float arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Transform), "InverseTransformPoint", typeof(float), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Transform), "InverseTransformPoint", typeof(float), 2);
                        }
                        var ret = self.InverseTransformPoint(arg0, arg1, arg2);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        UnityEngine.Transform self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Transform), "InverseTransformPoint", typeof(UnityEngine.Vector3), 0);
                        }
                        var ret = self.InverseTransformPoint(arg0);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("InverseTransformPoint", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_DetachChildren(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.Transform self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.DetachChildren();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DetachChildren", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetAsFirstSibling(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.Transform self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.SetAsFirstSibling();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetAsFirstSibling", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetAsLastSibling(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.Transform self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.SetAsLastSibling();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetAsLastSibling", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetSiblingIndex(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Transform self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Transform), "SetSiblingIndex", typeof(int), 0);
                    }
                    self.SetSiblingIndex(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetSiblingIndex", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetSiblingIndex(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.Transform self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.GetSiblingIndex();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetSiblingIndex", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Find(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Transform self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Transform), "Find", typeof(string), 0);
                    }
                    var ret = self.Find(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("Find", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_IsChildOf(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Transform self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Transform arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Transform), "IsChildOf", typeof(UnityEngine.Transform), 0);
                    }
                    var ret = self.IsChildOf(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsChildOf", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetEnumerator(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.Transform self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.GetEnumerator();
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetEnumerator", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetChild(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Transform self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Transform), "GetChild", typeof(int), 0);
                    }
                    var ret = self.GetChild(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetChild", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ResetAll(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.Transform self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    Example.ExtensionTest.ResetAll(self);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ResetAll", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_TestWithArgs(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Transform self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Vector3 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(Example.ExtensionTest), "TestWithArgs", typeof(UnityEngine.Vector3), 0);
                    }
                    UnityEngine.Quaternion arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(Example.ExtensionTest), "TestWithArgs", typeof(UnityEngine.Quaternion), 1);
                    }
                    UnityEngine.Vector3 arg2;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(Example.ExtensionTest), "TestWithArgs", typeof(UnityEngine.Vector3), 2);
                    }
                    Example.ExtensionTest.TestWithArgs(self, arg0, arg1, arg2);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("TestWithArgs", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_TestWithArgsAndOut(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 4)
                {
                    UnityEngine.Transform self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Vector3 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(Example.ExtensionTest), "TestWithArgsAndOut", typeof(UnityEngine.Vector3), 0);
                    }
                    UnityEngine.Quaternion arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(Example.ExtensionTest), "TestWithArgsAndOut", typeof(UnityEngine.Quaternion), 1);
                    }
                    UnityEngine.Vector3 arg2;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(Example.ExtensionTest), "TestWithArgsAndOut", typeof(UnityEngine.Vector3), 2);
                    }
                    float arg3;
                    var ret = Example.ExtensionTest.TestWithArgsAndOut(self, arg0, arg1, arg2, out arg3);
                    var out0 = QuickJS.Binding.Values.js_push_primitive(ctx, arg3);
                    if (JSApi.JS_IsException(out0))
                    {
                        return out0;
                    }
                    var context = ScriptEngine.GetContext(ctx);
                    JSApi.JS_SetProperty(ctx, argv[3], context.GetAtom("value"), out0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("TestWithArgsAndOut", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_TestWithScriptObject(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Transform self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    QuickJS.ScriptFunction arg0;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(Example.ExtensionTest), "TestWithScriptObject", typeof(QuickJS.ScriptFunction), 0);
                    }
                    Example.ExtensionTest.TestWithScriptObject(self, arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("TestWithScriptObject", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_position(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Transform self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.position;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_position(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Transform self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Vector3 value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Transform), "position", typeof(UnityEngine.Vector3), 0);
                }
                self.position = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_localPosition(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Transform self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.localPosition;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_localPosition(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Transform self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Vector3 value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Transform), "localPosition", typeof(UnityEngine.Vector3), 0);
                }
                self.localPosition = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_eulerAngles(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Transform self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.eulerAngles;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_eulerAngles(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Transform self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Vector3 value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Transform), "eulerAngles", typeof(UnityEngine.Vector3), 0);
                }
                self.eulerAngles = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_localEulerAngles(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Transform self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.localEulerAngles;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_localEulerAngles(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Transform self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Vector3 value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Transform), "localEulerAngles", typeof(UnityEngine.Vector3), 0);
                }
                self.localEulerAngles = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_right(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Transform self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.right;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_right(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Transform self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Vector3 value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Transform), "right", typeof(UnityEngine.Vector3), 0);
                }
                self.right = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_up(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Transform self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.up;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_up(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Transform self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Vector3 value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Transform), "up", typeof(UnityEngine.Vector3), 0);
                }
                self.up = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_forward(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Transform self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.forward;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_forward(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Transform self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Vector3 value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Transform), "forward", typeof(UnityEngine.Vector3), 0);
                }
                self.forward = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_rotation(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Transform self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.rotation;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_rotation(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Transform self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Quaternion value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Transform), "rotation", typeof(UnityEngine.Quaternion), 0);
                }
                self.rotation = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_localRotation(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Transform self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.localRotation;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_localRotation(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Transform self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Quaternion value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Transform), "localRotation", typeof(UnityEngine.Quaternion), 0);
                }
                self.localRotation = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_localScale(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Transform self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.localScale;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_localScale(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Transform self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Vector3 value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Transform), "localScale", typeof(UnityEngine.Vector3), 0);
                }
                self.localScale = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_parent(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Transform self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.parent;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_parent(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Transform self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Transform value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Transform), "parent", typeof(UnityEngine.Transform), 0);
                }
                self.parent = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_worldToLocalMatrix(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Transform self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.worldToLocalMatrix;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_localToWorldMatrix(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Transform self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.localToWorldMatrix;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_root(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Transform self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.root;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_childCount(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Transform self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.childCount;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_lossyScale(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Transform self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.lossyScale;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_hasChanged(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Transform self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.hasChanged;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_hasChanged(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Transform self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Transform), "hasChanged", typeof(bool), 0);
                }
                self.hasChanged = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_hierarchyCapacity(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Transform self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.hierarchyCapacity;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_hierarchyCapacity(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Transform self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Transform), "hierarchyCapacity", typeof(int), 0);
                }
                self.hierarchyCapacity = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_hierarchyCount(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Transform self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.hierarchyCount;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("Transform", typeof(UnityEngine.Transform), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(false, "SetParent", Bind_SetParent);
            cls.AddMethod(false, "SetPositionAndRotation", Bind_SetPositionAndRotation);
            cls.AddMethod(false, "Translate", Bind_Translate);
            cls.AddMethod(false, "Rotate", Bind_Rotate);
            cls.AddMethod(false, "RotateAround", Bind_RotateAround);
            cls.AddMethod(false, "LookAt", Bind_LookAt);
            cls.AddMethod(false, "TransformDirection", Bind_TransformDirection);
            cls.AddMethod(false, "InverseTransformDirection", Bind_InverseTransformDirection);
            cls.AddMethod(false, "TransformVector", Bind_TransformVector);
            cls.AddMethod(false, "InverseTransformVector", Bind_InverseTransformVector);
            cls.AddMethod(false, "TransformPoint", Bind_TransformPoint);
            cls.AddMethod(false, "InverseTransformPoint", Bind_InverseTransformPoint);
            cls.AddMethod(false, "DetachChildren", Bind_DetachChildren);
            cls.AddMethod(false, "SetAsFirstSibling", Bind_SetAsFirstSibling);
            cls.AddMethod(false, "SetAsLastSibling", Bind_SetAsLastSibling);
            cls.AddMethod(false, "SetSiblingIndex", Bind_SetSiblingIndex);
            cls.AddMethod(false, "GetSiblingIndex", Bind_GetSiblingIndex);
            cls.AddMethod(false, "Find", Bind_Find);
            cls.AddMethod(false, "IsChildOf", Bind_IsChildOf);
            cls.AddMethod(false, "GetEnumerator", Bind_GetEnumerator);
            cls.AddMethod(false, "GetChild", Bind_GetChild);
            cls.AddMethod(false, "ResetAll", Bind_ResetAll);
            cls.AddMethod(false, "TestWithArgs", Bind_TestWithArgs);
            cls.AddMethod(false, "TestWithArgsAndOut", Bind_TestWithArgsAndOut);
            cls.AddMethod(false, "TestWithScriptObject", Bind_TestWithScriptObject);
            cls.AddProperty(false, "position", BindRead_position, BindWrite_position);
            cls.AddProperty(false, "localPosition", BindRead_localPosition, BindWrite_localPosition);
            cls.AddProperty(false, "eulerAngles", BindRead_eulerAngles, BindWrite_eulerAngles);
            cls.AddProperty(false, "localEulerAngles", BindRead_localEulerAngles, BindWrite_localEulerAngles);
            cls.AddProperty(false, "right", BindRead_right, BindWrite_right);
            cls.AddProperty(false, "up", BindRead_up, BindWrite_up);
            cls.AddProperty(false, "forward", BindRead_forward, BindWrite_forward);
            cls.AddProperty(false, "rotation", BindRead_rotation, BindWrite_rotation);
            cls.AddProperty(false, "localRotation", BindRead_localRotation, BindWrite_localRotation);
            cls.AddProperty(false, "localScale", BindRead_localScale, BindWrite_localScale);
            cls.AddProperty(false, "parent", BindRead_parent, BindWrite_parent);
            cls.AddProperty(false, "worldToLocalMatrix", BindRead_worldToLocalMatrix, null);
            cls.AddProperty(false, "localToWorldMatrix", BindRead_localToWorldMatrix, null);
            cls.AddProperty(false, "root", BindRead_root, null);
            cls.AddProperty(false, "childCount", BindRead_childCount, null);
            cls.AddProperty(false, "lossyScale", BindRead_lossyScale, null);
            cls.AddProperty(false, "hasChanged", BindRead_hasChanged, BindWrite_hasChanged);
            cls.AddProperty(false, "hierarchyCapacity", BindRead_hierarchyCapacity, BindWrite_hierarchyCapacity);
            cls.AddProperty(false, "hierarchyCount", BindRead_hierarchyCount, null);
            return cls;
        }
    }
}
#endif
