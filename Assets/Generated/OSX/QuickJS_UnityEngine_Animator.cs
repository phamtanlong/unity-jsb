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
    // Assembly: UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Applications/Unity/Hub/Editor/2019.4.40f1/Unity.app/Contents/Managed/UnityEngine/UnityEngine.AnimationModule.dll
    // Type: UnityEngine.Animator
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_Animator
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                if (argc == 0)
                {
                    var o = new UnityEngine.Animator();
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
        public static JSValue Bind_GetFloat(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)))
                        {
                            UnityEngine.Animator self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "GetFloat", typeof(string), 0);
                            }
                            var ret = self.GetFloat(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)))
                        {
                            UnityEngine.Animator self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "GetFloat", typeof(int), 0);
                            }
                            var ret = self.GetFloat(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("GetFloat", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetFloat(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(float)))
                        {
                            UnityEngine.Animator self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "SetFloat", typeof(string), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "SetFloat", typeof(float), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "SetFloat", typeof(float), 2);
                            }
                            float arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "SetFloat", typeof(float), 3);
                            }
                            self.SetFloat(arg0, arg1, arg2, arg3);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(float)))
                        {
                            UnityEngine.Animator self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "SetFloat", typeof(int), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "SetFloat", typeof(float), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "SetFloat", typeof(float), 2);
                            }
                            float arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "SetFloat", typeof(float), 3);
                            }
                            self.SetFloat(arg0, arg1, arg2, arg3);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(float)))
                        {
                            UnityEngine.Animator self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "SetFloat", typeof(string), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "SetFloat", typeof(float), 1);
                            }
                            self.SetFloat(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(float)))
                        {
                            UnityEngine.Animator self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "SetFloat", typeof(int), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "SetFloat", typeof(float), 1);
                            }
                            self.SetFloat(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("SetFloat", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetBool(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)))
                        {
                            UnityEngine.Animator self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "GetBool", typeof(string), 0);
                            }
                            var ret = self.GetBool(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)))
                        {
                            UnityEngine.Animator self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "GetBool", typeof(int), 0);
                            }
                            var ret = self.GetBool(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("GetBool", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetBool(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(bool)))
                        {
                            UnityEngine.Animator self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "SetBool", typeof(string), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "SetBool", typeof(bool), 1);
                            }
                            self.SetBool(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(bool)))
                        {
                            UnityEngine.Animator self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "SetBool", typeof(int), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "SetBool", typeof(bool), 1);
                            }
                            self.SetBool(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("SetBool", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetInteger(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)))
                        {
                            UnityEngine.Animator self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "GetInteger", typeof(string), 0);
                            }
                            var ret = self.GetInteger(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)))
                        {
                            UnityEngine.Animator self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "GetInteger", typeof(int), 0);
                            }
                            var ret = self.GetInteger(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("GetInteger", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetInteger(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(int)))
                        {
                            UnityEngine.Animator self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "SetInteger", typeof(string), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "SetInteger", typeof(int), 1);
                            }
                            self.SetInteger(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(int)))
                        {
                            UnityEngine.Animator self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "SetInteger", typeof(int), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "SetInteger", typeof(int), 1);
                            }
                            self.SetInteger(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("SetInteger", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetTrigger(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)))
                        {
                            UnityEngine.Animator self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "SetTrigger", typeof(string), 0);
                            }
                            self.SetTrigger(arg0);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)))
                        {
                            UnityEngine.Animator self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "SetTrigger", typeof(int), 0);
                            }
                            self.SetTrigger(arg0);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("SetTrigger", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ResetTrigger(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)))
                        {
                            UnityEngine.Animator self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "ResetTrigger", typeof(string), 0);
                            }
                            self.ResetTrigger(arg0);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)))
                        {
                            UnityEngine.Animator self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "ResetTrigger", typeof(int), 0);
                            }
                            self.ResetTrigger(arg0);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("ResetTrigger", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_IsParameterControlledByCurve(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)))
                        {
                            UnityEngine.Animator self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "IsParameterControlledByCurve", typeof(string), 0);
                            }
                            var ret = self.IsParameterControlledByCurve(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)))
                        {
                            UnityEngine.Animator self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "IsParameterControlledByCurve", typeof(int), 0);
                            }
                            var ret = self.IsParameterControlledByCurve(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("IsParameterControlledByCurve", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetIKPosition(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Animator self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.AvatarIKGoal arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Animator), "GetIKPosition", typeof(UnityEngine.AvatarIKGoal), 0);
                    }
                    var ret = self.GetIKPosition(arg0);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetIKPosition", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetIKPosition(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Animator self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.AvatarIKGoal arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Animator), "SetIKPosition", typeof(UnityEngine.AvatarIKGoal), 0);
                    }
                    UnityEngine.Vector3 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Animator), "SetIKPosition", typeof(UnityEngine.Vector3), 1);
                    }
                    self.SetIKPosition(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetIKPosition", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetIKRotation(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Animator self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.AvatarIKGoal arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Animator), "GetIKRotation", typeof(UnityEngine.AvatarIKGoal), 0);
                    }
                    var ret = self.GetIKRotation(arg0);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetIKRotation", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetIKRotation(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Animator self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.AvatarIKGoal arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Animator), "SetIKRotation", typeof(UnityEngine.AvatarIKGoal), 0);
                    }
                    UnityEngine.Quaternion arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Animator), "SetIKRotation", typeof(UnityEngine.Quaternion), 1);
                    }
                    self.SetIKRotation(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetIKRotation", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetIKPositionWeight(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Animator self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.AvatarIKGoal arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Animator), "GetIKPositionWeight", typeof(UnityEngine.AvatarIKGoal), 0);
                    }
                    var ret = self.GetIKPositionWeight(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetIKPositionWeight", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetIKPositionWeight(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Animator self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.AvatarIKGoal arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Animator), "SetIKPositionWeight", typeof(UnityEngine.AvatarIKGoal), 0);
                    }
                    float arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Animator), "SetIKPositionWeight", typeof(float), 1);
                    }
                    self.SetIKPositionWeight(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetIKPositionWeight", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetIKRotationWeight(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Animator self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.AvatarIKGoal arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Animator), "GetIKRotationWeight", typeof(UnityEngine.AvatarIKGoal), 0);
                    }
                    var ret = self.GetIKRotationWeight(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetIKRotationWeight", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetIKRotationWeight(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Animator self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.AvatarIKGoal arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Animator), "SetIKRotationWeight", typeof(UnityEngine.AvatarIKGoal), 0);
                    }
                    float arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Animator), "SetIKRotationWeight", typeof(float), 1);
                    }
                    self.SetIKRotationWeight(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetIKRotationWeight", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetIKHintPosition(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Animator self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.AvatarIKHint arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Animator), "GetIKHintPosition", typeof(UnityEngine.AvatarIKHint), 0);
                    }
                    var ret = self.GetIKHintPosition(arg0);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetIKHintPosition", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetIKHintPosition(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Animator self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.AvatarIKHint arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Animator), "SetIKHintPosition", typeof(UnityEngine.AvatarIKHint), 0);
                    }
                    UnityEngine.Vector3 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Animator), "SetIKHintPosition", typeof(UnityEngine.Vector3), 1);
                    }
                    self.SetIKHintPosition(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetIKHintPosition", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetIKHintPositionWeight(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Animator self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.AvatarIKHint arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Animator), "GetIKHintPositionWeight", typeof(UnityEngine.AvatarIKHint), 0);
                    }
                    var ret = self.GetIKHintPositionWeight(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetIKHintPositionWeight", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetIKHintPositionWeight(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Animator self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.AvatarIKHint arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Animator), "SetIKHintPositionWeight", typeof(UnityEngine.AvatarIKHint), 0);
                    }
                    float arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Animator), "SetIKHintPositionWeight", typeof(float), 1);
                    }
                    self.SetIKHintPositionWeight(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetIKHintPositionWeight", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetLookAtPosition(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Animator self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Vector3 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Animator), "SetLookAtPosition", typeof(UnityEngine.Vector3), 0);
                    }
                    self.SetLookAtPosition(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetLookAtPosition", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetLookAtWeight(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 5)
                    {
                        UnityEngine.Animator self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        float arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animator), "SetLookAtWeight", typeof(float), 0);
                        }
                        float arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animator), "SetLookAtWeight", typeof(float), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animator), "SetLookAtWeight", typeof(float), 2);
                        }
                        float arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animator), "SetLookAtWeight", typeof(float), 3);
                        }
                        float arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animator), "SetLookAtWeight", typeof(float), 4);
                        }
                        self.SetLookAtWeight(arg0, arg1, arg2, arg3, arg4);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 4)
                    {
                        UnityEngine.Animator self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        float arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animator), "SetLookAtWeight", typeof(float), 0);
                        }
                        float arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animator), "SetLookAtWeight", typeof(float), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animator), "SetLookAtWeight", typeof(float), 2);
                        }
                        float arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animator), "SetLookAtWeight", typeof(float), 3);
                        }
                        self.SetLookAtWeight(arg0, arg1, arg2, arg3);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 3)
                    {
                        UnityEngine.Animator self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        float arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animator), "SetLookAtWeight", typeof(float), 0);
                        }
                        float arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animator), "SetLookAtWeight", typeof(float), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animator), "SetLookAtWeight", typeof(float), 2);
                        }
                        self.SetLookAtWeight(arg0, arg1, arg2);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Animator self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        float arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animator), "SetLookAtWeight", typeof(float), 0);
                        }
                        float arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animator), "SetLookAtWeight", typeof(float), 1);
                        }
                        self.SetLookAtWeight(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 1)
                    {
                        UnityEngine.Animator self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        float arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animator), "SetLookAtWeight", typeof(float), 0);
                        }
                        self.SetLookAtWeight(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("SetLookAtWeight", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetBoneLocalRotation(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Animator self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.HumanBodyBones arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Animator), "SetBoneLocalRotation", typeof(UnityEngine.HumanBodyBones), 0);
                    }
                    UnityEngine.Quaternion arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Animator), "SetBoneLocalRotation", typeof(UnityEngine.Quaternion), 1);
                    }
                    self.SetBoneLocalRotation(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetBoneLocalRotation", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetBehaviours(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Animator self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Animator), "GetBehaviours", typeof(int), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Animator), "GetBehaviours", typeof(int), 1);
                    }
                    var ret = self.GetBehaviours(arg0, arg1);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetBehaviours", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetLayerName(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Animator self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Animator), "GetLayerName", typeof(int), 0);
                    }
                    var ret = self.GetLayerName(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetLayerName", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetLayerIndex(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Animator self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Animator), "GetLayerIndex", typeof(string), 0);
                    }
                    var ret = self.GetLayerIndex(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetLayerIndex", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetLayerWeight(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Animator self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Animator), "GetLayerWeight", typeof(int), 0);
                    }
                    var ret = self.GetLayerWeight(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetLayerWeight", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetLayerWeight(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Animator self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Animator), "SetLayerWeight", typeof(int), 0);
                    }
                    float arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Animator), "SetLayerWeight", typeof(float), 1);
                    }
                    self.SetLayerWeight(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetLayerWeight", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetCurrentAnimatorStateInfo(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Animator self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Animator), "GetCurrentAnimatorStateInfo", typeof(int), 0);
                    }
                    var ret = self.GetCurrentAnimatorStateInfo(arg0);
                    return Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetCurrentAnimatorStateInfo", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetNextAnimatorStateInfo(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Animator self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Animator), "GetNextAnimatorStateInfo", typeof(int), 0);
                    }
                    var ret = self.GetNextAnimatorStateInfo(arg0);
                    return Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetNextAnimatorStateInfo", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetAnimatorTransitionInfo(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Animator self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Animator), "GetAnimatorTransitionInfo", typeof(int), 0);
                    }
                    var ret = self.GetAnimatorTransitionInfo(arg0);
                    return Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetAnimatorTransitionInfo", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetCurrentAnimatorClipInfoCount(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Animator self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Animator), "GetCurrentAnimatorClipInfoCount", typeof(int), 0);
                    }
                    var ret = self.GetCurrentAnimatorClipInfoCount(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetCurrentAnimatorClipInfoCount", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetNextAnimatorClipInfoCount(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Animator self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Animator), "GetNextAnimatorClipInfoCount", typeof(int), 0);
                    }
                    var ret = self.GetNextAnimatorClipInfoCount(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetNextAnimatorClipInfoCount", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetCurrentAnimatorClipInfo(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        UnityEngine.Animator self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        int arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animator), "GetCurrentAnimatorClipInfo", typeof(int), 0);
                        }
                        System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animator), "GetCurrentAnimatorClipInfo", typeof(System.Collections.Generic.List<UnityEngine.AnimatorClipInfo>), 1);
                        }
                        self.GetCurrentAnimatorClipInfo(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 1)
                    {
                        UnityEngine.Animator self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        int arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animator), "GetCurrentAnimatorClipInfo", typeof(int), 0);
                        }
                        var ret = self.GetCurrentAnimatorClipInfo(arg0);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("GetCurrentAnimatorClipInfo", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetNextAnimatorClipInfo(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        UnityEngine.Animator self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        int arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animator), "GetNextAnimatorClipInfo", typeof(int), 0);
                        }
                        System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animator), "GetNextAnimatorClipInfo", typeof(System.Collections.Generic.List<UnityEngine.AnimatorClipInfo>), 1);
                        }
                        self.GetNextAnimatorClipInfo(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 1)
                    {
                        UnityEngine.Animator self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        int arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animator), "GetNextAnimatorClipInfo", typeof(int), 0);
                        }
                        var ret = self.GetNextAnimatorClipInfo(arg0);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("GetNextAnimatorClipInfo", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_IsInTransition(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Animator self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Animator), "IsInTransition", typeof(int), 0);
                    }
                    var ret = self.IsInTransition(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsInTransition", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetParameter(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Animator self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Animator), "GetParameter", typeof(int), 0);
                    }
                    var ret = self.GetParameter(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetParameter", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_MatchTarget(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 7)
                    {
                        UnityEngine.Animator self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animator), "MatchTarget", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Quaternion arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animator), "MatchTarget", typeof(UnityEngine.Quaternion), 1);
                        }
                        UnityEngine.AvatarTarget arg2;
                        if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animator), "MatchTarget", typeof(UnityEngine.AvatarTarget), 2);
                        }
                        UnityEngine.MatchTargetWeightMask arg3;
                        if (!Values.js_get_structvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animator), "MatchTarget", typeof(UnityEngine.MatchTargetWeightMask), 3);
                        }
                        float arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animator), "MatchTarget", typeof(float), 4);
                        }
                        float arg5;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animator), "MatchTarget", typeof(float), 5);
                        }
                        bool arg6;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[6], out arg6))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animator), "MatchTarget", typeof(bool), 6);
                        }
                        self.MatchTarget(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 6)
                    {
                        UnityEngine.Animator self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animator), "MatchTarget", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Quaternion arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animator), "MatchTarget", typeof(UnityEngine.Quaternion), 1);
                        }
                        UnityEngine.AvatarTarget arg2;
                        if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animator), "MatchTarget", typeof(UnityEngine.AvatarTarget), 2);
                        }
                        UnityEngine.MatchTargetWeightMask arg3;
                        if (!Values.js_get_structvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animator), "MatchTarget", typeof(UnityEngine.MatchTargetWeightMask), 3);
                        }
                        float arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animator), "MatchTarget", typeof(float), 4);
                        }
                        float arg5;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animator), "MatchTarget", typeof(float), 5);
                        }
                        self.MatchTarget(arg0, arg1, arg2, arg3, arg4, arg5);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 5)
                    {
                        UnityEngine.Animator self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animator), "MatchTarget", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Quaternion arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animator), "MatchTarget", typeof(UnityEngine.Quaternion), 1);
                        }
                        UnityEngine.AvatarTarget arg2;
                        if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animator), "MatchTarget", typeof(UnityEngine.AvatarTarget), 2);
                        }
                        UnityEngine.MatchTargetWeightMask arg3;
                        if (!Values.js_get_structvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animator), "MatchTarget", typeof(UnityEngine.MatchTargetWeightMask), 3);
                        }
                        float arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animator), "MatchTarget", typeof(float), 4);
                        }
                        self.MatchTarget(arg0, arg1, arg2, arg3, arg4);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("MatchTarget", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_InterruptMatchTarget(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        UnityEngine.Animator self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        bool arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animator), "InterruptMatchTarget", typeof(bool), 0);
                        }
                        self.InterruptMatchTarget(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 0)
                    {
                        UnityEngine.Animator self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        self.InterruptMatchTarget();
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("InterruptMatchTarget", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_CrossFadeInFixedTime(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 5)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(float)) && Values.js_match_type(ctx, argv[4], typeof(float)))
                        {
                            UnityEngine.Animator self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFadeInFixedTime", typeof(string), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFadeInFixedTime", typeof(float), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFadeInFixedTime", typeof(int), 2);
                            }
                            float arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFadeInFixedTime", typeof(float), 3);
                            }
                            float arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFadeInFixedTime", typeof(float), 4);
                            }
                            self.CrossFadeInFixedTime(arg0, arg1, arg2, arg3, arg4);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(float)) && Values.js_match_type(ctx, argv[4], typeof(float)))
                        {
                            UnityEngine.Animator self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFadeInFixedTime", typeof(int), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFadeInFixedTime", typeof(float), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFadeInFixedTime", typeof(int), 2);
                            }
                            float arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFadeInFixedTime", typeof(float), 3);
                            }
                            float arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFadeInFixedTime", typeof(float), 4);
                            }
                            self.CrossFadeInFixedTime(arg0, arg1, arg2, arg3, arg4);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(float)))
                        {
                            UnityEngine.Animator self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFadeInFixedTime", typeof(string), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFadeInFixedTime", typeof(float), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFadeInFixedTime", typeof(int), 2);
                            }
                            float arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFadeInFixedTime", typeof(float), 3);
                            }
                            self.CrossFadeInFixedTime(arg0, arg1, arg2, arg3);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(float)))
                        {
                            UnityEngine.Animator self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFadeInFixedTime", typeof(int), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFadeInFixedTime", typeof(float), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFadeInFixedTime", typeof(int), 2);
                            }
                            float arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFadeInFixedTime", typeof(float), 3);
                            }
                            self.CrossFadeInFixedTime(arg0, arg1, arg2, arg3);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(int)))
                        {
                            UnityEngine.Animator self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFadeInFixedTime", typeof(string), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFadeInFixedTime", typeof(float), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFadeInFixedTime", typeof(int), 2);
                            }
                            self.CrossFadeInFixedTime(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(int)))
                        {
                            UnityEngine.Animator self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFadeInFixedTime", typeof(int), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFadeInFixedTime", typeof(float), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFadeInFixedTime", typeof(int), 2);
                            }
                            self.CrossFadeInFixedTime(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(float)))
                        {
                            UnityEngine.Animator self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFadeInFixedTime", typeof(string), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFadeInFixedTime", typeof(float), 1);
                            }
                            self.CrossFadeInFixedTime(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(float)))
                        {
                            UnityEngine.Animator self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFadeInFixedTime", typeof(int), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFadeInFixedTime", typeof(float), 1);
                            }
                            self.CrossFadeInFixedTime(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("CrossFadeInFixedTime", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_WriteDefaultValues(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.Animator self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.WriteDefaultValues();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("WriteDefaultValues", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_CrossFade(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 5)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(float)) && Values.js_match_type(ctx, argv[4], typeof(float)))
                        {
                            UnityEngine.Animator self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFade", typeof(string), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFade", typeof(float), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFade", typeof(int), 2);
                            }
                            float arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFade", typeof(float), 3);
                            }
                            float arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFade", typeof(float), 4);
                            }
                            self.CrossFade(arg0, arg1, arg2, arg3, arg4);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(float)) && Values.js_match_type(ctx, argv[4], typeof(float)))
                        {
                            UnityEngine.Animator self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFade", typeof(int), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFade", typeof(float), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFade", typeof(int), 2);
                            }
                            float arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFade", typeof(float), 3);
                            }
                            float arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFade", typeof(float), 4);
                            }
                            self.CrossFade(arg0, arg1, arg2, arg3, arg4);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(float)))
                        {
                            UnityEngine.Animator self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFade", typeof(string), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFade", typeof(float), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFade", typeof(int), 2);
                            }
                            float arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFade", typeof(float), 3);
                            }
                            self.CrossFade(arg0, arg1, arg2, arg3);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(float)))
                        {
                            UnityEngine.Animator self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFade", typeof(int), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFade", typeof(float), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFade", typeof(int), 2);
                            }
                            float arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFade", typeof(float), 3);
                            }
                            self.CrossFade(arg0, arg1, arg2, arg3);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(int)))
                        {
                            UnityEngine.Animator self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFade", typeof(string), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFade", typeof(float), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFade", typeof(int), 2);
                            }
                            self.CrossFade(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(int)))
                        {
                            UnityEngine.Animator self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFade", typeof(int), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFade", typeof(float), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFade", typeof(int), 2);
                            }
                            self.CrossFade(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(float)))
                        {
                            UnityEngine.Animator self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFade", typeof(string), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFade", typeof(float), 1);
                            }
                            self.CrossFade(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(float)))
                        {
                            UnityEngine.Animator self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFade", typeof(int), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "CrossFade", typeof(float), 1);
                            }
                            self.CrossFade(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("CrossFade", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_PlayInFixedTime(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(float)))
                        {
                            UnityEngine.Animator self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "PlayInFixedTime", typeof(string), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "PlayInFixedTime", typeof(int), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "PlayInFixedTime", typeof(float), 2);
                            }
                            self.PlayInFixedTime(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(float)))
                        {
                            UnityEngine.Animator self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "PlayInFixedTime", typeof(int), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "PlayInFixedTime", typeof(int), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "PlayInFixedTime", typeof(float), 2);
                            }
                            self.PlayInFixedTime(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(int)))
                        {
                            UnityEngine.Animator self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "PlayInFixedTime", typeof(string), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "PlayInFixedTime", typeof(int), 1);
                            }
                            self.PlayInFixedTime(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(int)))
                        {
                            UnityEngine.Animator self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "PlayInFixedTime", typeof(int), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "PlayInFixedTime", typeof(int), 1);
                            }
                            self.PlayInFixedTime(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)))
                        {
                            UnityEngine.Animator self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "PlayInFixedTime", typeof(string), 0);
                            }
                            self.PlayInFixedTime(arg0);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)))
                        {
                            UnityEngine.Animator self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "PlayInFixedTime", typeof(int), 0);
                            }
                            self.PlayInFixedTime(arg0);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("PlayInFixedTime", argc);
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
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(float)))
                        {
                            UnityEngine.Animator self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "Play", typeof(string), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "Play", typeof(int), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "Play", typeof(float), 2);
                            }
                            self.Play(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(float)))
                        {
                            UnityEngine.Animator self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "Play", typeof(int), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "Play", typeof(int), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "Play", typeof(float), 2);
                            }
                            self.Play(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(int)))
                        {
                            UnityEngine.Animator self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "Play", typeof(string), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "Play", typeof(int), 1);
                            }
                            self.Play(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(int)))
                        {
                            UnityEngine.Animator self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "Play", typeof(int), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "Play", typeof(int), 1);
                            }
                            self.Play(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)))
                        {
                            UnityEngine.Animator self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "Play", typeof(string), 0);
                            }
                            self.Play(arg0);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)))
                        {
                            UnityEngine.Animator self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Animator), "Play", typeof(int), 0);
                            }
                            self.Play(arg0);
                            return JSApi.JS_UNDEFINED;
                        }
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
        public static JSValue Bind_SetTarget(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Animator self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.AvatarTarget arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Animator), "SetTarget", typeof(UnityEngine.AvatarTarget), 0);
                    }
                    float arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Animator), "SetTarget", typeof(float), 1);
                    }
                    self.SetTarget(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetTarget", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetBoneTransform(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Animator self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.HumanBodyBones arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Animator), "GetBoneTransform", typeof(UnityEngine.HumanBodyBones), 0);
                    }
                    var ret = self.GetBoneTransform(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetBoneTransform", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_StartPlayback(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.Animator self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.StartPlayback();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("StartPlayback", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_StopPlayback(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.Animator self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.StopPlayback();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("StopPlayback", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_StartRecording(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Animator self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Animator), "StartRecording", typeof(int), 0);
                    }
                    self.StartRecording(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("StartRecording", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_StopRecording(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.Animator self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.StopRecording();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("StopRecording", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_HasState(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Animator self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Animator), "HasState", typeof(int), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Animator), "HasState", typeof(int), 1);
                    }
                    var ret = self.HasState(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("HasState", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Update(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Animator self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    float arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Animator), "Update", typeof(float), 0);
                    }
                    self.Update(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Update", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Rebind(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.Animator self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.Rebind();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Rebind", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ApplyBuiltinRootMotion(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.Animator self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.ApplyBuiltinRootMotion();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ApplyBuiltinRootMotion", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_AddJobDependency(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Animator self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    Unity.Jobs.JobHandle arg0;
                    if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Animations.AnimatorJobExtensions), "AddJobDependency", typeof(Unity.Jobs.JobHandle), 0);
                    }
                    UnityEngine.Animations.AnimatorJobExtensions.AddJobDependency(self, arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("AddJobDependency", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_BindStreamTransform(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Animator self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Transform arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Animations.AnimatorJobExtensions), "BindStreamTransform", typeof(UnityEngine.Transform), 0);
                    }
                    var ret = UnityEngine.Animations.AnimatorJobExtensions.BindStreamTransform(self, arg0);
                    return Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("BindStreamTransform", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_BindStreamProperty(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        UnityEngine.Animator self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.Transform arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animations.AnimatorJobExtensions), "BindStreamProperty", typeof(UnityEngine.Transform), 0);
                        }
                        System.Type arg1;
                        if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animations.AnimatorJobExtensions), "BindStreamProperty", typeof(System.Type), 1);
                        }
                        string arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animations.AnimatorJobExtensions), "BindStreamProperty", typeof(string), 2);
                        }
                        bool arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animations.AnimatorJobExtensions), "BindStreamProperty", typeof(bool), 3);
                        }
                        var ret = UnityEngine.Animations.AnimatorJobExtensions.BindStreamProperty(self, arg0, arg1, arg2, arg3);
                        return Values.js_push_structvalue(ctx, ret);
                    }
                    if (argc == 3)
                    {
                        UnityEngine.Animator self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.Transform arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animations.AnimatorJobExtensions), "BindStreamProperty", typeof(UnityEngine.Transform), 0);
                        }
                        System.Type arg1;
                        if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animations.AnimatorJobExtensions), "BindStreamProperty", typeof(System.Type), 1);
                        }
                        string arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animations.AnimatorJobExtensions), "BindStreamProperty", typeof(string), 2);
                        }
                        var ret = UnityEngine.Animations.AnimatorJobExtensions.BindStreamProperty(self, arg0, arg1, arg2);
                        return Values.js_push_structvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("BindStreamProperty", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_BindCustomStreamProperty(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Animator self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Animations.AnimatorJobExtensions), "BindCustomStreamProperty", typeof(string), 0);
                    }
                    UnityEngine.Animations.CustomStreamPropertyType arg1;
                    if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Animations.AnimatorJobExtensions), "BindCustomStreamProperty", typeof(UnityEngine.Animations.CustomStreamPropertyType), 1);
                    }
                    var ret = UnityEngine.Animations.AnimatorJobExtensions.BindCustomStreamProperty(self, arg0, arg1);
                    return Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("BindCustomStreamProperty", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_BindSceneTransform(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Animator self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Transform arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Animations.AnimatorJobExtensions), "BindSceneTransform", typeof(UnityEngine.Transform), 0);
                    }
                    var ret = UnityEngine.Animations.AnimatorJobExtensions.BindSceneTransform(self, arg0);
                    return Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("BindSceneTransform", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_BindSceneProperty(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        UnityEngine.Animator self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.Transform arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animations.AnimatorJobExtensions), "BindSceneProperty", typeof(UnityEngine.Transform), 0);
                        }
                        System.Type arg1;
                        if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animations.AnimatorJobExtensions), "BindSceneProperty", typeof(System.Type), 1);
                        }
                        string arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animations.AnimatorJobExtensions), "BindSceneProperty", typeof(string), 2);
                        }
                        bool arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animations.AnimatorJobExtensions), "BindSceneProperty", typeof(bool), 3);
                        }
                        var ret = UnityEngine.Animations.AnimatorJobExtensions.BindSceneProperty(self, arg0, arg1, arg2, arg3);
                        return Values.js_push_structvalue(ctx, ret);
                    }
                    if (argc == 3)
                    {
                        UnityEngine.Animator self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.Transform arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animations.AnimatorJobExtensions), "BindSceneProperty", typeof(UnityEngine.Transform), 0);
                        }
                        System.Type arg1;
                        if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animations.AnimatorJobExtensions), "BindSceneProperty", typeof(System.Type), 1);
                        }
                        string arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Animations.AnimatorJobExtensions), "BindSceneProperty", typeof(string), 2);
                        }
                        var ret = UnityEngine.Animations.AnimatorJobExtensions.BindSceneProperty(self, arg0, arg1, arg2);
                        return Values.js_push_structvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("BindSceneProperty", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_OpenAnimationStream(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Animator self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Animations.AnimationStream arg0;
                    var refVal0 = Values.js_read_wrap(ctx, argv[0]);
                    if (refVal0.IsException())
                    {
                        return refVal0;
                    }
                    if (!Values.js_get_structvalue(ctx, refVal0, out arg0))
                    {
                        JSApi.JS_FreeValue(ctx, refVal0);
                        throw new ParameterException(typeof(UnityEngine.Animations.AnimatorJobExtensions), "OpenAnimationStream", typeof(UnityEngine.Animations.AnimationStream), 0);
                    }
                    JSApi.JS_FreeValue(ctx, refVal0);
                    var ret = UnityEngine.Animations.AnimatorJobExtensions.OpenAnimationStream(self, ref arg0);
                    var out0 = Values.js_push_structvalue(ctx, arg0);
                    if (JSApi.JS_IsException(out0))
                    {
                        return out0;
                    }
                    var context = ScriptEngine.GetContext(ctx);
                    JSApi.JS_SetProperty(ctx, argv[0], context.GetAtom("value"), out0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("OpenAnimationStream", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_CloseAnimationStream(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Animator self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Animations.AnimationStream arg0;
                    var refVal0 = Values.js_read_wrap(ctx, argv[0]);
                    if (refVal0.IsException())
                    {
                        return refVal0;
                    }
                    if (!Values.js_get_structvalue(ctx, refVal0, out arg0))
                    {
                        JSApi.JS_FreeValue(ctx, refVal0);
                        throw new ParameterException(typeof(UnityEngine.Animations.AnimatorJobExtensions), "CloseAnimationStream", typeof(UnityEngine.Animations.AnimationStream), 0);
                    }
                    JSApi.JS_FreeValue(ctx, refVal0);
                    UnityEngine.Animations.AnimatorJobExtensions.CloseAnimationStream(self, ref arg0);
                    var out0 = Values.js_push_structvalue(ctx, arg0);
                    if (JSApi.JS_IsException(out0))
                    {
                        return out0;
                    }
                    var context = ScriptEngine.GetContext(ctx);
                    JSApi.JS_SetProperty(ctx, argv[0], context.GetAtom("value"), out0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("CloseAnimationStream", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ResolveAllStreamHandles(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.Animator self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Animations.AnimatorJobExtensions.ResolveAllStreamHandles(self);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ResolveAllStreamHandles", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ResolveAllSceneHandles(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.Animator self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Animations.AnimatorJobExtensions.ResolveAllSceneHandles(self);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ResolveAllSceneHandles", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_StringToHash(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Animator), "StringToHash", typeof(string), 0);
                    }
                    var ret = UnityEngine.Animator.StringToHash(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("StringToHash", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_isOptimizable(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.isOptimizable;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_isHuman(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.isHuman;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_hasRootMotion(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.hasRootMotion;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_humanScale(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.humanScale;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_isInitialized(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.isInitialized;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_deltaPosition(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.deltaPosition;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_deltaRotation(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.deltaRotation;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_velocity(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.velocity;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_angularVelocity(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.angularVelocity;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_rootPosition(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.rootPosition;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_rootPosition(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Vector3 value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Animator), "rootPosition", typeof(UnityEngine.Vector3), 0);
                }
                self.rootPosition = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_rootRotation(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.rootRotation;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_rootRotation(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Quaternion value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Animator), "rootRotation", typeof(UnityEngine.Quaternion), 0);
                }
                self.rootRotation = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_applyRootMotion(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.applyRootMotion;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_applyRootMotion(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Animator), "applyRootMotion", typeof(bool), 0);
                }
                self.applyRootMotion = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_updateMode(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.updateMode;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_updateMode(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.AnimatorUpdateMode value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Animator), "updateMode", typeof(UnityEngine.AnimatorUpdateMode), 0);
                }
                self.updateMode = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_hasTransformHierarchy(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.hasTransformHierarchy;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_gravityWeight(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.gravityWeight;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_bodyPosition(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.bodyPosition;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_bodyPosition(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Vector3 value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Animator), "bodyPosition", typeof(UnityEngine.Vector3), 0);
                }
                self.bodyPosition = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_bodyRotation(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.bodyRotation;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_bodyRotation(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Quaternion value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Animator), "bodyRotation", typeof(UnityEngine.Quaternion), 0);
                }
                self.bodyRotation = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_stabilizeFeet(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.stabilizeFeet;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_stabilizeFeet(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Animator), "stabilizeFeet", typeof(bool), 0);
                }
                self.stabilizeFeet = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_layerCount(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.layerCount;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_parameters(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.parameters;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_parameterCount(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.parameterCount;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_feetPivotActive(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.feetPivotActive;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_feetPivotActive(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Animator), "feetPivotActive", typeof(float), 0);
                }
                self.feetPivotActive = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_pivotWeight(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.pivotWeight;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_pivotPosition(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.pivotPosition;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_isMatchingTarget(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.isMatchingTarget;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_speed(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.speed;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_speed(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Animator), "speed", typeof(float), 0);
                }
                self.speed = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_targetPosition(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.targetPosition;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_targetRotation(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.targetRotation;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_cullingMode(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.cullingMode;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_cullingMode(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.AnimatorCullingMode value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Animator), "cullingMode", typeof(UnityEngine.AnimatorCullingMode), 0);
                }
                self.cullingMode = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_playbackTime(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.playbackTime;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_playbackTime(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Animator), "playbackTime", typeof(float), 0);
                }
                self.playbackTime = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_recorderStartTime(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.recorderStartTime;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_recorderStartTime(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Animator), "recorderStartTime", typeof(float), 0);
                }
                self.recorderStartTime = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_recorderStopTime(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.recorderStopTime;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_recorderStopTime(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Animator), "recorderStopTime", typeof(float), 0);
                }
                self.recorderStopTime = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_recorderMode(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.recorderMode;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_runtimeAnimatorController(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.runtimeAnimatorController;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_runtimeAnimatorController(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.RuntimeAnimatorController value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Animator), "runtimeAnimatorController", typeof(UnityEngine.RuntimeAnimatorController), 0);
                }
                self.runtimeAnimatorController = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_hasBoundPlayables(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.hasBoundPlayables;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_avatar(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.avatar;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_avatar(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Avatar value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Animator), "avatar", typeof(UnityEngine.Avatar), 0);
                }
                self.avatar = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_playableGraph(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.playableGraph;
                return Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_layersAffectMassCenter(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.layersAffectMassCenter;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_layersAffectMassCenter(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Animator), "layersAffectMassCenter", typeof(bool), 0);
                }
                self.layersAffectMassCenter = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_leftFeetBottomHeight(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.leftFeetBottomHeight;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_rightFeetBottomHeight(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.rightFeetBottomHeight;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_logWarnings(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.logWarnings;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_logWarnings(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Animator), "logWarnings", typeof(bool), 0);
                }
                self.logWarnings = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_fireEvents(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.fireEvents;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_fireEvents(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Animator), "fireEvents", typeof(bool), 0);
                }
                self.fireEvents = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_keepAnimatorControllerStateOnDisable(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.keepAnimatorControllerStateOnDisable;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_keepAnimatorControllerStateOnDisable(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Animator self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Animator), "keepAnimatorControllerStateOnDisable", typeof(bool), 0);
                }
                self.keepAnimatorControllerStateOnDisable = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("Animator", typeof(UnityEngine.Animator), BindConstructor);
            cls.AddMethod(false, "GetFloat", Bind_GetFloat);
            cls.AddMethod(false, "SetFloat", Bind_SetFloat);
            cls.AddMethod(false, "GetBool", Bind_GetBool);
            cls.AddMethod(false, "SetBool", Bind_SetBool);
            cls.AddMethod(false, "GetInteger", Bind_GetInteger);
            cls.AddMethod(false, "SetInteger", Bind_SetInteger);
            cls.AddMethod(false, "SetTrigger", Bind_SetTrigger);
            cls.AddMethod(false, "ResetTrigger", Bind_ResetTrigger);
            cls.AddMethod(false, "IsParameterControlledByCurve", Bind_IsParameterControlledByCurve);
            cls.AddMethod(false, "GetIKPosition", Bind_GetIKPosition);
            cls.AddMethod(false, "SetIKPosition", Bind_SetIKPosition);
            cls.AddMethod(false, "GetIKRotation", Bind_GetIKRotation);
            cls.AddMethod(false, "SetIKRotation", Bind_SetIKRotation);
            cls.AddMethod(false, "GetIKPositionWeight", Bind_GetIKPositionWeight);
            cls.AddMethod(false, "SetIKPositionWeight", Bind_SetIKPositionWeight);
            cls.AddMethod(false, "GetIKRotationWeight", Bind_GetIKRotationWeight);
            cls.AddMethod(false, "SetIKRotationWeight", Bind_SetIKRotationWeight);
            cls.AddMethod(false, "GetIKHintPosition", Bind_GetIKHintPosition);
            cls.AddMethod(false, "SetIKHintPosition", Bind_SetIKHintPosition);
            cls.AddMethod(false, "GetIKHintPositionWeight", Bind_GetIKHintPositionWeight);
            cls.AddMethod(false, "SetIKHintPositionWeight", Bind_SetIKHintPositionWeight);
            cls.AddMethod(false, "SetLookAtPosition", Bind_SetLookAtPosition);
            cls.AddMethod(false, "SetLookAtWeight", Bind_SetLookAtWeight);
            cls.AddMethod(false, "SetBoneLocalRotation", Bind_SetBoneLocalRotation);
            cls.AddMethod(false, "GetBehaviours", Bind_GetBehaviours);
            cls.AddMethod(false, "GetLayerName", Bind_GetLayerName);
            cls.AddMethod(false, "GetLayerIndex", Bind_GetLayerIndex);
            cls.AddMethod(false, "GetLayerWeight", Bind_GetLayerWeight);
            cls.AddMethod(false, "SetLayerWeight", Bind_SetLayerWeight);
            cls.AddMethod(false, "GetCurrentAnimatorStateInfo", Bind_GetCurrentAnimatorStateInfo);
            cls.AddMethod(false, "GetNextAnimatorStateInfo", Bind_GetNextAnimatorStateInfo);
            cls.AddMethod(false, "GetAnimatorTransitionInfo", Bind_GetAnimatorTransitionInfo);
            cls.AddMethod(false, "GetCurrentAnimatorClipInfoCount", Bind_GetCurrentAnimatorClipInfoCount);
            cls.AddMethod(false, "GetNextAnimatorClipInfoCount", Bind_GetNextAnimatorClipInfoCount);
            cls.AddMethod(false, "GetCurrentAnimatorClipInfo", Bind_GetCurrentAnimatorClipInfo);
            cls.AddMethod(false, "GetNextAnimatorClipInfo", Bind_GetNextAnimatorClipInfo);
            cls.AddMethod(false, "IsInTransition", Bind_IsInTransition);
            cls.AddMethod(false, "GetParameter", Bind_GetParameter);
            cls.AddMethod(false, "MatchTarget", Bind_MatchTarget);
            cls.AddMethod(false, "InterruptMatchTarget", Bind_InterruptMatchTarget);
            cls.AddMethod(false, "CrossFadeInFixedTime", Bind_CrossFadeInFixedTime);
            cls.AddMethod(false, "WriteDefaultValues", Bind_WriteDefaultValues);
            cls.AddMethod(false, "CrossFade", Bind_CrossFade);
            cls.AddMethod(false, "PlayInFixedTime", Bind_PlayInFixedTime);
            cls.AddMethod(false, "Play", Bind_Play);
            cls.AddMethod(false, "SetTarget", Bind_SetTarget);
            cls.AddMethod(false, "GetBoneTransform", Bind_GetBoneTransform);
            cls.AddMethod(false, "StartPlayback", Bind_StartPlayback);
            cls.AddMethod(false, "StopPlayback", Bind_StopPlayback);
            cls.AddMethod(false, "StartRecording", Bind_StartRecording);
            cls.AddMethod(false, "StopRecording", Bind_StopRecording);
            cls.AddMethod(false, "HasState", Bind_HasState);
            cls.AddMethod(false, "Update", Bind_Update);
            cls.AddMethod(false, "Rebind", Bind_Rebind);
            cls.AddMethod(false, "ApplyBuiltinRootMotion", Bind_ApplyBuiltinRootMotion);
            cls.AddMethod(false, "AddJobDependency", Bind_AddJobDependency);
            cls.AddMethod(false, "BindStreamTransform", Bind_BindStreamTransform);
            cls.AddMethod(false, "BindStreamProperty", Bind_BindStreamProperty);
            cls.AddMethod(false, "BindCustomStreamProperty", Bind_BindCustomStreamProperty);
            cls.AddMethod(false, "BindSceneTransform", Bind_BindSceneTransform);
            cls.AddMethod(false, "BindSceneProperty", Bind_BindSceneProperty);
            cls.AddMethod(false, "OpenAnimationStream", Bind_OpenAnimationStream);
            cls.AddMethod(false, "CloseAnimationStream", Bind_CloseAnimationStream);
            cls.AddMethod(false, "ResolveAllStreamHandles", Bind_ResolveAllStreamHandles);
            cls.AddMethod(false, "ResolveAllSceneHandles", Bind_ResolveAllSceneHandles);
            cls.AddMethod(true, "StringToHash", BindStatic_StringToHash);
            cls.AddProperty(false, "isOptimizable", BindRead_isOptimizable, null);
            cls.AddProperty(false, "isHuman", BindRead_isHuman, null);
            cls.AddProperty(false, "hasRootMotion", BindRead_hasRootMotion, null);
            cls.AddProperty(false, "humanScale", BindRead_humanScale, null);
            cls.AddProperty(false, "isInitialized", BindRead_isInitialized, null);
            cls.AddProperty(false, "deltaPosition", BindRead_deltaPosition, null);
            cls.AddProperty(false, "deltaRotation", BindRead_deltaRotation, null);
            cls.AddProperty(false, "velocity", BindRead_velocity, null);
            cls.AddProperty(false, "angularVelocity", BindRead_angularVelocity, null);
            cls.AddProperty(false, "rootPosition", BindRead_rootPosition, BindWrite_rootPosition);
            cls.AddProperty(false, "rootRotation", BindRead_rootRotation, BindWrite_rootRotation);
            cls.AddProperty(false, "applyRootMotion", BindRead_applyRootMotion, BindWrite_applyRootMotion);
            cls.AddProperty(false, "updateMode", BindRead_updateMode, BindWrite_updateMode);
            cls.AddProperty(false, "hasTransformHierarchy", BindRead_hasTransformHierarchy, null);
            cls.AddProperty(false, "gravityWeight", BindRead_gravityWeight, null);
            cls.AddProperty(false, "bodyPosition", BindRead_bodyPosition, BindWrite_bodyPosition);
            cls.AddProperty(false, "bodyRotation", BindRead_bodyRotation, BindWrite_bodyRotation);
            cls.AddProperty(false, "stabilizeFeet", BindRead_stabilizeFeet, BindWrite_stabilizeFeet);
            cls.AddProperty(false, "layerCount", BindRead_layerCount, null);
            cls.AddProperty(false, "parameters", BindRead_parameters, null);
            cls.AddProperty(false, "parameterCount", BindRead_parameterCount, null);
            cls.AddProperty(false, "feetPivotActive", BindRead_feetPivotActive, BindWrite_feetPivotActive);
            cls.AddProperty(false, "pivotWeight", BindRead_pivotWeight, null);
            cls.AddProperty(false, "pivotPosition", BindRead_pivotPosition, null);
            cls.AddProperty(false, "isMatchingTarget", BindRead_isMatchingTarget, null);
            cls.AddProperty(false, "speed", BindRead_speed, BindWrite_speed);
            cls.AddProperty(false, "targetPosition", BindRead_targetPosition, null);
            cls.AddProperty(false, "targetRotation", BindRead_targetRotation, null);
            cls.AddProperty(false, "cullingMode", BindRead_cullingMode, BindWrite_cullingMode);
            cls.AddProperty(false, "playbackTime", BindRead_playbackTime, BindWrite_playbackTime);
            cls.AddProperty(false, "recorderStartTime", BindRead_recorderStartTime, BindWrite_recorderStartTime);
            cls.AddProperty(false, "recorderStopTime", BindRead_recorderStopTime, BindWrite_recorderStopTime);
            cls.AddProperty(false, "recorderMode", BindRead_recorderMode, null);
            cls.AddProperty(false, "runtimeAnimatorController", BindRead_runtimeAnimatorController, BindWrite_runtimeAnimatorController);
            cls.AddProperty(false, "hasBoundPlayables", BindRead_hasBoundPlayables, null);
            cls.AddProperty(false, "avatar", BindRead_avatar, BindWrite_avatar);
            cls.AddProperty(false, "playableGraph", BindRead_playableGraph, null);
            cls.AddProperty(false, "layersAffectMassCenter", BindRead_layersAffectMassCenter, BindWrite_layersAffectMassCenter);
            cls.AddProperty(false, "leftFeetBottomHeight", BindRead_leftFeetBottomHeight, null);
            cls.AddProperty(false, "rightFeetBottomHeight", BindRead_rightFeetBottomHeight, null);
            cls.AddProperty(false, "logWarnings", BindRead_logWarnings, BindWrite_logWarnings);
            cls.AddProperty(false, "fireEvents", BindRead_fireEvents, BindWrite_fireEvents);
            cls.AddProperty(false, "keepAnimatorControllerStateOnDisable", BindRead_keepAnimatorControllerStateOnDisable, BindWrite_keepAnimatorControllerStateOnDisable);
            return cls;
        }
    }
}
#endif
