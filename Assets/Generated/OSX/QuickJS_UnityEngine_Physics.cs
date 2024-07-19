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
    // Assembly: UnityEngine.PhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Applications/Unity/Hub/Editor/2019.4.40f1/Unity.app/Contents/Managed/UnityEngine/UnityEngine.PhysicsModule.dll
    // Type: UnityEngine.Physics
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_Physics
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                if (argc == 0)
                {
                    var o = new UnityEngine.Physics();
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
        public static JSValue BindStatic_IgnoreCollision(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        UnityEngine.Collider arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "IgnoreCollision", typeof(UnityEngine.Collider), 0);
                        }
                        UnityEngine.Collider arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "IgnoreCollision", typeof(UnityEngine.Collider), 1);
                        }
                        bool arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "IgnoreCollision", typeof(bool), 2);
                        }
                        UnityEngine.Physics.IgnoreCollision(arg0, arg1, arg2);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Collider arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "IgnoreCollision", typeof(UnityEngine.Collider), 0);
                        }
                        UnityEngine.Collider arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "IgnoreCollision", typeof(UnityEngine.Collider), 1);
                        }
                        UnityEngine.Physics.IgnoreCollision(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("IgnoreCollision", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IgnoreLayerCollision(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        int arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "IgnoreLayerCollision", typeof(int), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "IgnoreLayerCollision", typeof(int), 1);
                        }
                        bool arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "IgnoreLayerCollision", typeof(bool), 2);
                        }
                        UnityEngine.Physics.IgnoreLayerCollision(arg0, arg1, arg2);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 2)
                    {
                        int arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "IgnoreLayerCollision", typeof(int), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "IgnoreLayerCollision", typeof(int), 1);
                        }
                        UnityEngine.Physics.IgnoreLayerCollision(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("IgnoreLayerCollision", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetIgnoreLayerCollision(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Physics), "GetIgnoreLayerCollision", typeof(int), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Physics), "GetIgnoreLayerCollision", typeof(int), 1);
                    }
                    var ret = UnityEngine.Physics.GetIgnoreLayerCollision(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetIgnoreLayerCollision", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetIgnoreCollision(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Collider arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Physics), "GetIgnoreCollision", typeof(UnityEngine.Collider), 0);
                    }
                    UnityEngine.Collider arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Physics), "GetIgnoreCollision", typeof(UnityEngine.Collider), 1);
                    }
                    var ret = UnityEngine.Physics.GetIgnoreCollision(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetIgnoreCollision", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Raycast(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 6)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "Raycast", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "Raycast", typeof(UnityEngine.Vector3), 1);
                        }
                        UnityEngine.RaycastHit arg2;
                        float arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "Raycast", typeof(float), 3);
                        }
                        int arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "Raycast", typeof(int), 4);
                        }
                        UnityEngine.QueryTriggerInteraction arg5;
                        if (!Values.js_get_enumvalue(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "Raycast", typeof(UnityEngine.QueryTriggerInteraction), 5);
                        }
                        var ret = UnityEngine.Physics.Raycast(arg0, arg1, out arg2, arg3, arg4, arg5);
                        var out0 = Values.js_push_structvalue(ctx, arg2);
                        if (JSApi.JS_IsException(out0))
                        {
                            return out0;
                        }
                        var context = ScriptEngine.GetContext(ctx);
                        JSApi.JS_SetProperty(ctx, argv[2], context.GetAtom("value"), out0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 5)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(int)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.QueryTriggerInteraction)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Raycast", typeof(UnityEngine.Vector3), 0);
                            }
                            UnityEngine.Vector3 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Raycast", typeof(UnityEngine.Vector3), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Raycast", typeof(float), 2);
                            }
                            int arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Raycast", typeof(int), 3);
                            }
                            UnityEngine.QueryTriggerInteraction arg4;
                            if (!Values.js_get_enumvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Raycast", typeof(UnityEngine.QueryTriggerInteraction), 4);
                            }
                            var ret = UnityEngine.Physics.Raycast(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector3)) && Values.js_match_type_hint(ctx, argv[2], typeof(UnityEngine.RaycastHit)) && Values.js_match_type(ctx, argv[3], typeof(float)) && Values.js_match_type(ctx, argv[4], typeof(int)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Raycast", typeof(UnityEngine.Vector3), 0);
                            }
                            UnityEngine.Vector3 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Raycast", typeof(UnityEngine.Vector3), 1);
                            }
                            UnityEngine.RaycastHit arg2;
                            float arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Raycast", typeof(float), 3);
                            }
                            int arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Raycast", typeof(int), 4);
                            }
                            var ret = UnityEngine.Physics.Raycast(arg0, arg1, out arg2, arg3, arg4);
                            var out0 = Values.js_push_structvalue(ctx, arg2);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[2], context.GetAtom("value"), out0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Ray)) && Values.js_match_type_hint(ctx, argv[1], typeof(UnityEngine.RaycastHit)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(int)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.QueryTriggerInteraction)))
                        {
                            UnityEngine.Ray arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Raycast", typeof(UnityEngine.Ray), 0);
                            }
                            UnityEngine.RaycastHit arg1;
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Raycast", typeof(float), 2);
                            }
                            int arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Raycast", typeof(int), 3);
                            }
                            UnityEngine.QueryTriggerInteraction arg4;
                            if (!Values.js_get_enumvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Raycast", typeof(UnityEngine.QueryTriggerInteraction), 4);
                            }
                            var ret = UnityEngine.Physics.Raycast(arg0, out arg1, arg2, arg3, arg4);
                            var out0 = Values.js_push_structvalue(ctx, arg1);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(int)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Raycast", typeof(UnityEngine.Vector3), 0);
                            }
                            UnityEngine.Vector3 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Raycast", typeof(UnityEngine.Vector3), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Raycast", typeof(float), 2);
                            }
                            int arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Raycast", typeof(int), 3);
                            }
                            var ret = UnityEngine.Physics.Raycast(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector3)) && Values.js_match_type_hint(ctx, argv[2], typeof(UnityEngine.RaycastHit)) && Values.js_match_type(ctx, argv[3], typeof(float)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Raycast", typeof(UnityEngine.Vector3), 0);
                            }
                            UnityEngine.Vector3 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Raycast", typeof(UnityEngine.Vector3), 1);
                            }
                            UnityEngine.RaycastHit arg2;
                            float arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Raycast", typeof(float), 3);
                            }
                            var ret = UnityEngine.Physics.Raycast(arg0, arg1, out arg2, arg3);
                            var out0 = Values.js_push_structvalue(ctx, arg2);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[2], context.GetAtom("value"), out0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Ray)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.QueryTriggerInteraction)))
                        {
                            UnityEngine.Ray arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Raycast", typeof(UnityEngine.Ray), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Raycast", typeof(float), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Raycast", typeof(int), 2);
                            }
                            UnityEngine.QueryTriggerInteraction arg3;
                            if (!Values.js_get_enumvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Raycast", typeof(UnityEngine.QueryTriggerInteraction), 3);
                            }
                            var ret = UnityEngine.Physics.Raycast(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Ray)) && Values.js_match_type_hint(ctx, argv[1], typeof(UnityEngine.RaycastHit)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(int)))
                        {
                            UnityEngine.Ray arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Raycast", typeof(UnityEngine.Ray), 0);
                            }
                            UnityEngine.RaycastHit arg1;
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Raycast", typeof(float), 2);
                            }
                            int arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Raycast", typeof(int), 3);
                            }
                            var ret = UnityEngine.Physics.Raycast(arg0, out arg1, arg2, arg3);
                            var out0 = Values.js_push_structvalue(ctx, arg1);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[2], typeof(float)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Raycast", typeof(UnityEngine.Vector3), 0);
                            }
                            UnityEngine.Vector3 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Raycast", typeof(UnityEngine.Vector3), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Raycast", typeof(float), 2);
                            }
                            var ret = UnityEngine.Physics.Raycast(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector3)) && Values.js_match_type_hint(ctx, argv[2], typeof(UnityEngine.RaycastHit)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Raycast", typeof(UnityEngine.Vector3), 0);
                            }
                            UnityEngine.Vector3 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Raycast", typeof(UnityEngine.Vector3), 1);
                            }
                            UnityEngine.RaycastHit arg2;
                            var ret = UnityEngine.Physics.Raycast(arg0, arg1, out arg2);
                            var out0 = Values.js_push_structvalue(ctx, arg2);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[2], context.GetAtom("value"), out0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Ray)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(int)))
                        {
                            UnityEngine.Ray arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Raycast", typeof(UnityEngine.Ray), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Raycast", typeof(float), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Raycast", typeof(int), 2);
                            }
                            var ret = UnityEngine.Physics.Raycast(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Ray)) && Values.js_match_type_hint(ctx, argv[1], typeof(UnityEngine.RaycastHit)) && Values.js_match_type(ctx, argv[2], typeof(float)))
                        {
                            UnityEngine.Ray arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Raycast", typeof(UnityEngine.Ray), 0);
                            }
                            UnityEngine.RaycastHit arg1;
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Raycast", typeof(float), 2);
                            }
                            var ret = UnityEngine.Physics.Raycast(arg0, out arg1, arg2);
                            var out0 = Values.js_push_structvalue(ctx, arg1);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector3)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Raycast", typeof(UnityEngine.Vector3), 0);
                            }
                            UnityEngine.Vector3 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Raycast", typeof(UnityEngine.Vector3), 1);
                            }
                            var ret = UnityEngine.Physics.Raycast(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Ray)) && Values.js_match_type(ctx, argv[1], typeof(float)))
                        {
                            UnityEngine.Ray arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Raycast", typeof(UnityEngine.Ray), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Raycast", typeof(float), 1);
                            }
                            var ret = UnityEngine.Physics.Raycast(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Ray)) && Values.js_match_type_hint(ctx, argv[1], typeof(UnityEngine.RaycastHit)))
                        {
                            UnityEngine.Ray arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Raycast", typeof(UnityEngine.Ray), 0);
                            }
                            UnityEngine.RaycastHit arg1;
                            var ret = UnityEngine.Physics.Raycast(arg0, out arg1);
                            var out0 = Values.js_push_structvalue(ctx, arg1);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 1)
                    {
                        UnityEngine.Ray arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "Raycast", typeof(UnityEngine.Ray), 0);
                        }
                        var ret = UnityEngine.Physics.Raycast(arg0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("Raycast", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Linecast(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 5)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "Linecast", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "Linecast", typeof(UnityEngine.Vector3), 1);
                        }
                        UnityEngine.RaycastHit arg2;
                        int arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "Linecast", typeof(int), 3);
                        }
                        UnityEngine.QueryTriggerInteraction arg4;
                        if (!Values.js_get_enumvalue(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "Linecast", typeof(UnityEngine.QueryTriggerInteraction), 4);
                        }
                        var ret = UnityEngine.Physics.Linecast(arg0, arg1, out arg2, arg3, arg4);
                        var out0 = Values.js_push_structvalue(ctx, arg2);
                        if (JSApi.JS_IsException(out0))
                        {
                            return out0;
                        }
                        var context = ScriptEngine.GetContext(ctx);
                        JSApi.JS_SetProperty(ctx, argv[2], context.GetAtom("value"), out0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.QueryTriggerInteraction)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Linecast", typeof(UnityEngine.Vector3), 0);
                            }
                            UnityEngine.Vector3 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Linecast", typeof(UnityEngine.Vector3), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Linecast", typeof(int), 2);
                            }
                            UnityEngine.QueryTriggerInteraction arg3;
                            if (!Values.js_get_enumvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Linecast", typeof(UnityEngine.QueryTriggerInteraction), 3);
                            }
                            var ret = UnityEngine.Physics.Linecast(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector3)) && Values.js_match_type_hint(ctx, argv[2], typeof(UnityEngine.RaycastHit)) && Values.js_match_type(ctx, argv[3], typeof(int)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Linecast", typeof(UnityEngine.Vector3), 0);
                            }
                            UnityEngine.Vector3 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Linecast", typeof(UnityEngine.Vector3), 1);
                            }
                            UnityEngine.RaycastHit arg2;
                            int arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Linecast", typeof(int), 3);
                            }
                            var ret = UnityEngine.Physics.Linecast(arg0, arg1, out arg2, arg3);
                            var out0 = Values.js_push_structvalue(ctx, arg2);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[2], context.GetAtom("value"), out0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[2], typeof(int)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Linecast", typeof(UnityEngine.Vector3), 0);
                            }
                            UnityEngine.Vector3 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Linecast", typeof(UnityEngine.Vector3), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Linecast", typeof(int), 2);
                            }
                            var ret = UnityEngine.Physics.Linecast(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector3)) && Values.js_match_type_hint(ctx, argv[2], typeof(UnityEngine.RaycastHit)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Linecast", typeof(UnityEngine.Vector3), 0);
                            }
                            UnityEngine.Vector3 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "Linecast", typeof(UnityEngine.Vector3), 1);
                            }
                            UnityEngine.RaycastHit arg2;
                            var ret = UnityEngine.Physics.Linecast(arg0, arg1, out arg2);
                            var out0 = Values.js_push_structvalue(ctx, arg2);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[2], context.GetAtom("value"), out0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "Linecast", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "Linecast", typeof(UnityEngine.Vector3), 1);
                        }
                        var ret = UnityEngine.Physics.Linecast(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("Linecast", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CapsuleCast(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 8)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCast", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCast", typeof(UnityEngine.Vector3), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCast", typeof(float), 2);
                        }
                        UnityEngine.Vector3 arg3;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCast", typeof(UnityEngine.Vector3), 3);
                        }
                        UnityEngine.RaycastHit arg4;
                        float arg5;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCast", typeof(float), 5);
                        }
                        int arg6;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[6], out arg6))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCast", typeof(int), 6);
                        }
                        UnityEngine.QueryTriggerInteraction arg7;
                        if (!Values.js_get_enumvalue(ctx, argv[7], out arg7))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCast", typeof(UnityEngine.QueryTriggerInteraction), 7);
                        }
                        var ret = UnityEngine.Physics.CapsuleCast(arg0, arg1, arg2, arg3, out arg4, arg5, arg6, arg7);
                        var out0 = Values.js_push_structvalue(ctx, arg4);
                        if (JSApi.JS_IsException(out0))
                        {
                            return out0;
                        }
                        var context = ScriptEngine.GetContext(ctx);
                        JSApi.JS_SetProperty(ctx, argv[4], context.GetAtom("value"), out0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 7)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[4], typeof(float)) && Values.js_match_type(ctx, argv[5], typeof(int)) && Values.js_match_type(ctx, argv[6], typeof(UnityEngine.QueryTriggerInteraction)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCast", typeof(UnityEngine.Vector3), 0);
                            }
                            UnityEngine.Vector3 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCast", typeof(UnityEngine.Vector3), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCast", typeof(float), 2);
                            }
                            UnityEngine.Vector3 arg3;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCast", typeof(UnityEngine.Vector3), 3);
                            }
                            float arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCast", typeof(float), 4);
                            }
                            int arg5;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCast", typeof(int), 5);
                            }
                            UnityEngine.QueryTriggerInteraction arg6;
                            if (!Values.js_get_enumvalue(ctx, argv[6], out arg6))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCast", typeof(UnityEngine.QueryTriggerInteraction), 6);
                            }
                            var ret = UnityEngine.Physics.CapsuleCast(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.Vector3)) && Values.js_match_type_hint(ctx, argv[4], typeof(UnityEngine.RaycastHit)) && Values.js_match_type(ctx, argv[5], typeof(float)) && Values.js_match_type(ctx, argv[6], typeof(int)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCast", typeof(UnityEngine.Vector3), 0);
                            }
                            UnityEngine.Vector3 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCast", typeof(UnityEngine.Vector3), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCast", typeof(float), 2);
                            }
                            UnityEngine.Vector3 arg3;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCast", typeof(UnityEngine.Vector3), 3);
                            }
                            UnityEngine.RaycastHit arg4;
                            float arg5;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCast", typeof(float), 5);
                            }
                            int arg6;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[6], out arg6))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCast", typeof(int), 6);
                            }
                            var ret = UnityEngine.Physics.CapsuleCast(arg0, arg1, arg2, arg3, out arg4, arg5, arg6);
                            var out0 = Values.js_push_structvalue(ctx, arg4);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[4], context.GetAtom("value"), out0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 6)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[4], typeof(float)) && Values.js_match_type(ctx, argv[5], typeof(int)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCast", typeof(UnityEngine.Vector3), 0);
                            }
                            UnityEngine.Vector3 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCast", typeof(UnityEngine.Vector3), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCast", typeof(float), 2);
                            }
                            UnityEngine.Vector3 arg3;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCast", typeof(UnityEngine.Vector3), 3);
                            }
                            float arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCast", typeof(float), 4);
                            }
                            int arg5;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCast", typeof(int), 5);
                            }
                            var ret = UnityEngine.Physics.CapsuleCast(arg0, arg1, arg2, arg3, arg4, arg5);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.Vector3)) && Values.js_match_type_hint(ctx, argv[4], typeof(UnityEngine.RaycastHit)) && Values.js_match_type(ctx, argv[5], typeof(float)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCast", typeof(UnityEngine.Vector3), 0);
                            }
                            UnityEngine.Vector3 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCast", typeof(UnityEngine.Vector3), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCast", typeof(float), 2);
                            }
                            UnityEngine.Vector3 arg3;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCast", typeof(UnityEngine.Vector3), 3);
                            }
                            UnityEngine.RaycastHit arg4;
                            float arg5;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCast", typeof(float), 5);
                            }
                            var ret = UnityEngine.Physics.CapsuleCast(arg0, arg1, arg2, arg3, out arg4, arg5);
                            var out0 = Values.js_push_structvalue(ctx, arg4);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[4], context.GetAtom("value"), out0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 5)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[4], typeof(float)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCast", typeof(UnityEngine.Vector3), 0);
                            }
                            UnityEngine.Vector3 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCast", typeof(UnityEngine.Vector3), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCast", typeof(float), 2);
                            }
                            UnityEngine.Vector3 arg3;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCast", typeof(UnityEngine.Vector3), 3);
                            }
                            float arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCast", typeof(float), 4);
                            }
                            var ret = UnityEngine.Physics.CapsuleCast(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.Vector3)) && Values.js_match_type_hint(ctx, argv[4], typeof(UnityEngine.RaycastHit)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCast", typeof(UnityEngine.Vector3), 0);
                            }
                            UnityEngine.Vector3 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCast", typeof(UnityEngine.Vector3), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCast", typeof(float), 2);
                            }
                            UnityEngine.Vector3 arg3;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCast", typeof(UnityEngine.Vector3), 3);
                            }
                            UnityEngine.RaycastHit arg4;
                            var ret = UnityEngine.Physics.CapsuleCast(arg0, arg1, arg2, arg3, out arg4);
                            var out0 = Values.js_push_structvalue(ctx, arg4);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[4], context.GetAtom("value"), out0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 4)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCast", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCast", typeof(UnityEngine.Vector3), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCast", typeof(float), 2);
                        }
                        UnityEngine.Vector3 arg3;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCast", typeof(UnityEngine.Vector3), 3);
                        }
                        var ret = UnityEngine.Physics.CapsuleCast(arg0, arg1, arg2, arg3);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("CapsuleCast", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SphereCast(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 7)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "SphereCast", typeof(UnityEngine.Vector3), 0);
                        }
                        float arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "SphereCast", typeof(float), 1);
                        }
                        UnityEngine.Vector3 arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "SphereCast", typeof(UnityEngine.Vector3), 2);
                        }
                        UnityEngine.RaycastHit arg3;
                        float arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "SphereCast", typeof(float), 4);
                        }
                        int arg5;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "SphereCast", typeof(int), 5);
                        }
                        UnityEngine.QueryTriggerInteraction arg6;
                        if (!Values.js_get_enumvalue(ctx, argv[6], out arg6))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "SphereCast", typeof(UnityEngine.QueryTriggerInteraction), 6);
                        }
                        var ret = UnityEngine.Physics.SphereCast(arg0, arg1, arg2, out arg3, arg4, arg5, arg6);
                        var out0 = Values.js_push_structvalue(ctx, arg3);
                        if (JSApi.JS_IsException(out0))
                        {
                            return out0;
                        }
                        var context = ScriptEngine.GetContext(ctx);
                        JSApi.JS_SetProperty(ctx, argv[3], context.GetAtom("value"), out0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 6)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Vector3)) && Values.js_match_type_hint(ctx, argv[3], typeof(UnityEngine.RaycastHit)) && Values.js_match_type(ctx, argv[4], typeof(float)) && Values.js_match_type(ctx, argv[5], typeof(int)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCast", typeof(UnityEngine.Vector3), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCast", typeof(float), 1);
                            }
                            UnityEngine.Vector3 arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCast", typeof(UnityEngine.Vector3), 2);
                            }
                            UnityEngine.RaycastHit arg3;
                            float arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCast", typeof(float), 4);
                            }
                            int arg5;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCast", typeof(int), 5);
                            }
                            var ret = UnityEngine.Physics.SphereCast(arg0, arg1, arg2, out arg3, arg4, arg5);
                            var out0 = Values.js_push_structvalue(ctx, arg3);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[3], context.GetAtom("value"), out0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Ray)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type_hint(ctx, argv[2], typeof(UnityEngine.RaycastHit)) && Values.js_match_type(ctx, argv[3], typeof(float)) && Values.js_match_type(ctx, argv[4], typeof(int)) && Values.js_match_type(ctx, argv[5], typeof(UnityEngine.QueryTriggerInteraction)))
                        {
                            UnityEngine.Ray arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCast", typeof(UnityEngine.Ray), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCast", typeof(float), 1);
                            }
                            UnityEngine.RaycastHit arg2;
                            float arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCast", typeof(float), 3);
                            }
                            int arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCast", typeof(int), 4);
                            }
                            UnityEngine.QueryTriggerInteraction arg5;
                            if (!Values.js_get_enumvalue(ctx, argv[5], out arg5))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCast", typeof(UnityEngine.QueryTriggerInteraction), 5);
                            }
                            var ret = UnityEngine.Physics.SphereCast(arg0, arg1, out arg2, arg3, arg4, arg5);
                            var out0 = Values.js_push_structvalue(ctx, arg2);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[2], context.GetAtom("value"), out0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 5)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Vector3)) && Values.js_match_type_hint(ctx, argv[3], typeof(UnityEngine.RaycastHit)) && Values.js_match_type(ctx, argv[4], typeof(float)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCast", typeof(UnityEngine.Vector3), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCast", typeof(float), 1);
                            }
                            UnityEngine.Vector3 arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCast", typeof(UnityEngine.Vector3), 2);
                            }
                            UnityEngine.RaycastHit arg3;
                            float arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCast", typeof(float), 4);
                            }
                            var ret = UnityEngine.Physics.SphereCast(arg0, arg1, arg2, out arg3, arg4);
                            var out0 = Values.js_push_structvalue(ctx, arg3);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[3], context.GetAtom("value"), out0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Ray)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(int)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.QueryTriggerInteraction)))
                        {
                            UnityEngine.Ray arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCast", typeof(UnityEngine.Ray), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCast", typeof(float), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCast", typeof(float), 2);
                            }
                            int arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCast", typeof(int), 3);
                            }
                            UnityEngine.QueryTriggerInteraction arg4;
                            if (!Values.js_get_enumvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCast", typeof(UnityEngine.QueryTriggerInteraction), 4);
                            }
                            var ret = UnityEngine.Physics.SphereCast(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Ray)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type_hint(ctx, argv[2], typeof(UnityEngine.RaycastHit)) && Values.js_match_type(ctx, argv[3], typeof(float)) && Values.js_match_type(ctx, argv[4], typeof(int)))
                        {
                            UnityEngine.Ray arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCast", typeof(UnityEngine.Ray), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCast", typeof(float), 1);
                            }
                            UnityEngine.RaycastHit arg2;
                            float arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCast", typeof(float), 3);
                            }
                            int arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCast", typeof(int), 4);
                            }
                            var ret = UnityEngine.Physics.SphereCast(arg0, arg1, out arg2, arg3, arg4);
                            var out0 = Values.js_push_structvalue(ctx, arg2);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[2], context.GetAtom("value"), out0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Vector3)) && Values.js_match_type_hint(ctx, argv[3], typeof(UnityEngine.RaycastHit)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCast", typeof(UnityEngine.Vector3), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCast", typeof(float), 1);
                            }
                            UnityEngine.Vector3 arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCast", typeof(UnityEngine.Vector3), 2);
                            }
                            UnityEngine.RaycastHit arg3;
                            var ret = UnityEngine.Physics.SphereCast(arg0, arg1, arg2, out arg3);
                            var out0 = Values.js_push_structvalue(ctx, arg3);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[3], context.GetAtom("value"), out0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Ray)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(int)))
                        {
                            UnityEngine.Ray arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCast", typeof(UnityEngine.Ray), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCast", typeof(float), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCast", typeof(float), 2);
                            }
                            int arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCast", typeof(int), 3);
                            }
                            var ret = UnityEngine.Physics.SphereCast(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Ray)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type_hint(ctx, argv[2], typeof(UnityEngine.RaycastHit)) && Values.js_match_type(ctx, argv[3], typeof(float)))
                        {
                            UnityEngine.Ray arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCast", typeof(UnityEngine.Ray), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCast", typeof(float), 1);
                            }
                            UnityEngine.RaycastHit arg2;
                            float arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCast", typeof(float), 3);
                            }
                            var ret = UnityEngine.Physics.SphereCast(arg0, arg1, out arg2, arg3);
                            var out0 = Values.js_push_structvalue(ctx, arg2);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[2], context.GetAtom("value"), out0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Ray)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(float)))
                        {
                            UnityEngine.Ray arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCast", typeof(UnityEngine.Ray), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCast", typeof(float), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCast", typeof(float), 2);
                            }
                            var ret = UnityEngine.Physics.SphereCast(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Ray)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type_hint(ctx, argv[2], typeof(UnityEngine.RaycastHit)))
                        {
                            UnityEngine.Ray arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCast", typeof(UnityEngine.Ray), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCast", typeof(float), 1);
                            }
                            UnityEngine.RaycastHit arg2;
                            var ret = UnityEngine.Physics.SphereCast(arg0, arg1, out arg2);
                            var out0 = Values.js_push_structvalue(ctx, arg2);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[2], context.GetAtom("value"), out0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Ray arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "SphereCast", typeof(UnityEngine.Ray), 0);
                        }
                        float arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "SphereCast", typeof(float), 1);
                        }
                        var ret = UnityEngine.Physics.SphereCast(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("SphereCast", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_BoxCast(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 8)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(UnityEngine.Vector3), 1);
                        }
                        UnityEngine.Vector3 arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(UnityEngine.Vector3), 2);
                        }
                        UnityEngine.RaycastHit arg3;
                        UnityEngine.Quaternion arg4;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(UnityEngine.Quaternion), 4);
                        }
                        float arg5;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(float), 5);
                        }
                        int arg6;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[6], out arg6))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(int), 6);
                        }
                        UnityEngine.QueryTriggerInteraction arg7;
                        if (!Values.js_get_enumvalue(ctx, argv[7], out arg7))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(UnityEngine.QueryTriggerInteraction), 7);
                        }
                        var ret = UnityEngine.Physics.BoxCast(arg0, arg1, arg2, out arg3, arg4, arg5, arg6, arg7);
                        var out0 = Values.js_push_structvalue(ctx, arg3);
                        if (JSApi.JS_IsException(out0))
                        {
                            return out0;
                        }
                        var context = ScriptEngine.GetContext(ctx);
                        JSApi.JS_SetProperty(ctx, argv[3], context.GetAtom("value"), out0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 7)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.Quaternion)) && Values.js_match_type(ctx, argv[4], typeof(float)) && Values.js_match_type(ctx, argv[5], typeof(int)) && Values.js_match_type(ctx, argv[6], typeof(UnityEngine.QueryTriggerInteraction)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(UnityEngine.Vector3), 0);
                            }
                            UnityEngine.Vector3 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(UnityEngine.Vector3), 1);
                            }
                            UnityEngine.Vector3 arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(UnityEngine.Vector3), 2);
                            }
                            UnityEngine.Quaternion arg3;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(UnityEngine.Quaternion), 3);
                            }
                            float arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(float), 4);
                            }
                            int arg5;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(int), 5);
                            }
                            UnityEngine.QueryTriggerInteraction arg6;
                            if (!Values.js_get_enumvalue(ctx, argv[6], out arg6))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(UnityEngine.QueryTriggerInteraction), 6);
                            }
                            var ret = UnityEngine.Physics.BoxCast(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Vector3)) && Values.js_match_type_hint(ctx, argv[3], typeof(UnityEngine.RaycastHit)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.Quaternion)) && Values.js_match_type(ctx, argv[5], typeof(float)) && Values.js_match_type(ctx, argv[6], typeof(int)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(UnityEngine.Vector3), 0);
                            }
                            UnityEngine.Vector3 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(UnityEngine.Vector3), 1);
                            }
                            UnityEngine.Vector3 arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(UnityEngine.Vector3), 2);
                            }
                            UnityEngine.RaycastHit arg3;
                            UnityEngine.Quaternion arg4;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(UnityEngine.Quaternion), 4);
                            }
                            float arg5;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(float), 5);
                            }
                            int arg6;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[6], out arg6))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(int), 6);
                            }
                            var ret = UnityEngine.Physics.BoxCast(arg0, arg1, arg2, out arg3, arg4, arg5, arg6);
                            var out0 = Values.js_push_structvalue(ctx, arg3);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[3], context.GetAtom("value"), out0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 6)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.Quaternion)) && Values.js_match_type(ctx, argv[4], typeof(float)) && Values.js_match_type(ctx, argv[5], typeof(int)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(UnityEngine.Vector3), 0);
                            }
                            UnityEngine.Vector3 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(UnityEngine.Vector3), 1);
                            }
                            UnityEngine.Vector3 arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(UnityEngine.Vector3), 2);
                            }
                            UnityEngine.Quaternion arg3;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(UnityEngine.Quaternion), 3);
                            }
                            float arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(float), 4);
                            }
                            int arg5;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(int), 5);
                            }
                            var ret = UnityEngine.Physics.BoxCast(arg0, arg1, arg2, arg3, arg4, arg5);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Vector3)) && Values.js_match_type_hint(ctx, argv[3], typeof(UnityEngine.RaycastHit)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.Quaternion)) && Values.js_match_type(ctx, argv[5], typeof(float)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(UnityEngine.Vector3), 0);
                            }
                            UnityEngine.Vector3 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(UnityEngine.Vector3), 1);
                            }
                            UnityEngine.Vector3 arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(UnityEngine.Vector3), 2);
                            }
                            UnityEngine.RaycastHit arg3;
                            UnityEngine.Quaternion arg4;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(UnityEngine.Quaternion), 4);
                            }
                            float arg5;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(float), 5);
                            }
                            var ret = UnityEngine.Physics.BoxCast(arg0, arg1, arg2, out arg3, arg4, arg5);
                            var out0 = Values.js_push_structvalue(ctx, arg3);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[3], context.GetAtom("value"), out0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 5)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.Quaternion)) && Values.js_match_type(ctx, argv[4], typeof(float)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(UnityEngine.Vector3), 0);
                            }
                            UnityEngine.Vector3 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(UnityEngine.Vector3), 1);
                            }
                            UnityEngine.Vector3 arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(UnityEngine.Vector3), 2);
                            }
                            UnityEngine.Quaternion arg3;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(UnityEngine.Quaternion), 3);
                            }
                            float arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(float), 4);
                            }
                            var ret = UnityEngine.Physics.BoxCast(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Vector3)) && Values.js_match_type_hint(ctx, argv[3], typeof(UnityEngine.RaycastHit)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.Quaternion)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(UnityEngine.Vector3), 0);
                            }
                            UnityEngine.Vector3 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(UnityEngine.Vector3), 1);
                            }
                            UnityEngine.Vector3 arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(UnityEngine.Vector3), 2);
                            }
                            UnityEngine.RaycastHit arg3;
                            UnityEngine.Quaternion arg4;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(UnityEngine.Quaternion), 4);
                            }
                            var ret = UnityEngine.Physics.BoxCast(arg0, arg1, arg2, out arg3, arg4);
                            var out0 = Values.js_push_structvalue(ctx, arg3);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[3], context.GetAtom("value"), out0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.Quaternion)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(UnityEngine.Vector3), 0);
                            }
                            UnityEngine.Vector3 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(UnityEngine.Vector3), 1);
                            }
                            UnityEngine.Vector3 arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(UnityEngine.Vector3), 2);
                            }
                            UnityEngine.Quaternion arg3;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(UnityEngine.Quaternion), 3);
                            }
                            var ret = UnityEngine.Physics.BoxCast(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Vector3)) && Values.js_match_type_hint(ctx, argv[3], typeof(UnityEngine.RaycastHit)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(UnityEngine.Vector3), 0);
                            }
                            UnityEngine.Vector3 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(UnityEngine.Vector3), 1);
                            }
                            UnityEngine.Vector3 arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(UnityEngine.Vector3), 2);
                            }
                            UnityEngine.RaycastHit arg3;
                            var ret = UnityEngine.Physics.BoxCast(arg0, arg1, arg2, out arg3);
                            var out0 = Values.js_push_structvalue(ctx, arg3);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[3], context.GetAtom("value"), out0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 3)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(UnityEngine.Vector3), 1);
                        }
                        UnityEngine.Vector3 arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCast", typeof(UnityEngine.Vector3), 2);
                        }
                        var ret = UnityEngine.Physics.BoxCast(arg0, arg1, arg2);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("BoxCast", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RaycastAll(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 5)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "RaycastAll", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "RaycastAll", typeof(UnityEngine.Vector3), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "RaycastAll", typeof(float), 2);
                        }
                        int arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "RaycastAll", typeof(int), 3);
                        }
                        UnityEngine.QueryTriggerInteraction arg4;
                        if (!Values.js_get_enumvalue(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "RaycastAll", typeof(UnityEngine.QueryTriggerInteraction), 4);
                        }
                        var ret = UnityEngine.Physics.RaycastAll(arg0, arg1, arg2, arg3, arg4);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(int)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "RaycastAll", typeof(UnityEngine.Vector3), 0);
                            }
                            UnityEngine.Vector3 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "RaycastAll", typeof(UnityEngine.Vector3), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "RaycastAll", typeof(float), 2);
                            }
                            int arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "RaycastAll", typeof(int), 3);
                            }
                            var ret = UnityEngine.Physics.RaycastAll(arg0, arg1, arg2, arg3);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Ray)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.QueryTriggerInteraction)))
                        {
                            UnityEngine.Ray arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "RaycastAll", typeof(UnityEngine.Ray), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "RaycastAll", typeof(float), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "RaycastAll", typeof(int), 2);
                            }
                            UnityEngine.QueryTriggerInteraction arg3;
                            if (!Values.js_get_enumvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "RaycastAll", typeof(UnityEngine.QueryTriggerInteraction), 3);
                            }
                            var ret = UnityEngine.Physics.RaycastAll(arg0, arg1, arg2, arg3);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[2], typeof(float)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "RaycastAll", typeof(UnityEngine.Vector3), 0);
                            }
                            UnityEngine.Vector3 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "RaycastAll", typeof(UnityEngine.Vector3), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "RaycastAll", typeof(float), 2);
                            }
                            var ret = UnityEngine.Physics.RaycastAll(arg0, arg1, arg2);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Ray)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(int)))
                        {
                            UnityEngine.Ray arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "RaycastAll", typeof(UnityEngine.Ray), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "RaycastAll", typeof(float), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "RaycastAll", typeof(int), 2);
                            }
                            var ret = UnityEngine.Physics.RaycastAll(arg0, arg1, arg2);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector3)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "RaycastAll", typeof(UnityEngine.Vector3), 0);
                            }
                            UnityEngine.Vector3 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "RaycastAll", typeof(UnityEngine.Vector3), 1);
                            }
                            var ret = UnityEngine.Physics.RaycastAll(arg0, arg1);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Ray)) && Values.js_match_type(ctx, argv[1], typeof(float)))
                        {
                            UnityEngine.Ray arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "RaycastAll", typeof(UnityEngine.Ray), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "RaycastAll", typeof(float), 1);
                            }
                            var ret = UnityEngine.Physics.RaycastAll(arg0, arg1);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                    if (argc == 1)
                    {
                        UnityEngine.Ray arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "RaycastAll", typeof(UnityEngine.Ray), 0);
                        }
                        var ret = UnityEngine.Physics.RaycastAll(arg0);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("RaycastAll", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RaycastNonAlloc(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 6)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "RaycastNonAlloc", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "RaycastNonAlloc", typeof(UnityEngine.Vector3), 1);
                        }
                        UnityEngine.RaycastHit[] arg2;
                        if (!Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "RaycastNonAlloc", typeof(UnityEngine.RaycastHit[]), 2);
                        }
                        float arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "RaycastNonAlloc", typeof(float), 3);
                        }
                        int arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "RaycastNonAlloc", typeof(int), 4);
                        }
                        UnityEngine.QueryTriggerInteraction arg5;
                        if (!Values.js_get_enumvalue(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "RaycastNonAlloc", typeof(UnityEngine.QueryTriggerInteraction), 5);
                        }
                        var ret = UnityEngine.Physics.RaycastNonAlloc(arg0, arg1, arg2, arg3, arg4, arg5);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 5)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Ray)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.RaycastHit[])) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(int)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.QueryTriggerInteraction)))
                        {
                            UnityEngine.Ray arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "RaycastNonAlloc", typeof(UnityEngine.Ray), 0);
                            }
                            UnityEngine.RaycastHit[] arg1;
                            if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "RaycastNonAlloc", typeof(UnityEngine.RaycastHit[]), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "RaycastNonAlloc", typeof(float), 2);
                            }
                            int arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "RaycastNonAlloc", typeof(int), 3);
                            }
                            UnityEngine.QueryTriggerInteraction arg4;
                            if (!Values.js_get_enumvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "RaycastNonAlloc", typeof(UnityEngine.QueryTriggerInteraction), 4);
                            }
                            var ret = UnityEngine.Physics.RaycastNonAlloc(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.RaycastHit[])) && Values.js_match_type(ctx, argv[3], typeof(float)) && Values.js_match_type(ctx, argv[4], typeof(int)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "RaycastNonAlloc", typeof(UnityEngine.Vector3), 0);
                            }
                            UnityEngine.Vector3 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "RaycastNonAlloc", typeof(UnityEngine.Vector3), 1);
                            }
                            UnityEngine.RaycastHit[] arg2;
                            if (!Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "RaycastNonAlloc", typeof(UnityEngine.RaycastHit[]), 2);
                            }
                            float arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "RaycastNonAlloc", typeof(float), 3);
                            }
                            int arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "RaycastNonAlloc", typeof(int), 4);
                            }
                            var ret = UnityEngine.Physics.RaycastNonAlloc(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Ray)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.RaycastHit[])) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(int)))
                        {
                            UnityEngine.Ray arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "RaycastNonAlloc", typeof(UnityEngine.Ray), 0);
                            }
                            UnityEngine.RaycastHit[] arg1;
                            if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "RaycastNonAlloc", typeof(UnityEngine.RaycastHit[]), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "RaycastNonAlloc", typeof(float), 2);
                            }
                            int arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "RaycastNonAlloc", typeof(int), 3);
                            }
                            var ret = UnityEngine.Physics.RaycastNonAlloc(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.RaycastHit[])) && Values.js_match_type(ctx, argv[3], typeof(float)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "RaycastNonAlloc", typeof(UnityEngine.Vector3), 0);
                            }
                            UnityEngine.Vector3 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "RaycastNonAlloc", typeof(UnityEngine.Vector3), 1);
                            }
                            UnityEngine.RaycastHit[] arg2;
                            if (!Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "RaycastNonAlloc", typeof(UnityEngine.RaycastHit[]), 2);
                            }
                            float arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "RaycastNonAlloc", typeof(float), 3);
                            }
                            var ret = UnityEngine.Physics.RaycastNonAlloc(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Ray)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.RaycastHit[])) && Values.js_match_type(ctx, argv[2], typeof(float)))
                        {
                            UnityEngine.Ray arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "RaycastNonAlloc", typeof(UnityEngine.Ray), 0);
                            }
                            UnityEngine.RaycastHit[] arg1;
                            if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "RaycastNonAlloc", typeof(UnityEngine.RaycastHit[]), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "RaycastNonAlloc", typeof(float), 2);
                            }
                            var ret = UnityEngine.Physics.RaycastNonAlloc(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.RaycastHit[])))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "RaycastNonAlloc", typeof(UnityEngine.Vector3), 0);
                            }
                            UnityEngine.Vector3 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "RaycastNonAlloc", typeof(UnityEngine.Vector3), 1);
                            }
                            UnityEngine.RaycastHit[] arg2;
                            if (!Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "RaycastNonAlloc", typeof(UnityEngine.RaycastHit[]), 2);
                            }
                            var ret = UnityEngine.Physics.RaycastNonAlloc(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Ray arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "RaycastNonAlloc", typeof(UnityEngine.Ray), 0);
                        }
                        UnityEngine.RaycastHit[] arg1;
                        if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "RaycastNonAlloc", typeof(UnityEngine.RaycastHit[]), 1);
                        }
                        var ret = UnityEngine.Physics.RaycastNonAlloc(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("RaycastNonAlloc", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CapsuleCastAll(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 7)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCastAll", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCastAll", typeof(UnityEngine.Vector3), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCastAll", typeof(float), 2);
                        }
                        UnityEngine.Vector3 arg3;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCastAll", typeof(UnityEngine.Vector3), 3);
                        }
                        float arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCastAll", typeof(float), 4);
                        }
                        int arg5;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCastAll", typeof(int), 5);
                        }
                        UnityEngine.QueryTriggerInteraction arg6;
                        if (!Values.js_get_enumvalue(ctx, argv[6], out arg6))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCastAll", typeof(UnityEngine.QueryTriggerInteraction), 6);
                        }
                        var ret = UnityEngine.Physics.CapsuleCastAll(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 6)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCastAll", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCastAll", typeof(UnityEngine.Vector3), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCastAll", typeof(float), 2);
                        }
                        UnityEngine.Vector3 arg3;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCastAll", typeof(UnityEngine.Vector3), 3);
                        }
                        float arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCastAll", typeof(float), 4);
                        }
                        int arg5;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCastAll", typeof(int), 5);
                        }
                        var ret = UnityEngine.Physics.CapsuleCastAll(arg0, arg1, arg2, arg3, arg4, arg5);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 5)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCastAll", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCastAll", typeof(UnityEngine.Vector3), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCastAll", typeof(float), 2);
                        }
                        UnityEngine.Vector3 arg3;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCastAll", typeof(UnityEngine.Vector3), 3);
                        }
                        float arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCastAll", typeof(float), 4);
                        }
                        var ret = UnityEngine.Physics.CapsuleCastAll(arg0, arg1, arg2, arg3, arg4);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 4)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCastAll", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCastAll", typeof(UnityEngine.Vector3), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCastAll", typeof(float), 2);
                        }
                        UnityEngine.Vector3 arg3;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCastAll", typeof(UnityEngine.Vector3), 3);
                        }
                        var ret = UnityEngine.Physics.CapsuleCastAll(arg0, arg1, arg2, arg3);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("CapsuleCastAll", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SphereCastAll(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 6)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastAll", typeof(UnityEngine.Vector3), 0);
                        }
                        float arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastAll", typeof(float), 1);
                        }
                        UnityEngine.Vector3 arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastAll", typeof(UnityEngine.Vector3), 2);
                        }
                        float arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastAll", typeof(float), 3);
                        }
                        int arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastAll", typeof(int), 4);
                        }
                        UnityEngine.QueryTriggerInteraction arg5;
                        if (!Values.js_get_enumvalue(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastAll", typeof(UnityEngine.QueryTriggerInteraction), 5);
                        }
                        var ret = UnityEngine.Physics.SphereCastAll(arg0, arg1, arg2, arg3, arg4, arg5);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 5)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[3], typeof(float)) && Values.js_match_type(ctx, argv[4], typeof(int)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastAll", typeof(UnityEngine.Vector3), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastAll", typeof(float), 1);
                            }
                            UnityEngine.Vector3 arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastAll", typeof(UnityEngine.Vector3), 2);
                            }
                            float arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastAll", typeof(float), 3);
                            }
                            int arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastAll", typeof(int), 4);
                            }
                            var ret = UnityEngine.Physics.SphereCastAll(arg0, arg1, arg2, arg3, arg4);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Ray)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(int)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.QueryTriggerInteraction)))
                        {
                            UnityEngine.Ray arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastAll", typeof(UnityEngine.Ray), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastAll", typeof(float), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastAll", typeof(float), 2);
                            }
                            int arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastAll", typeof(int), 3);
                            }
                            UnityEngine.QueryTriggerInteraction arg4;
                            if (!Values.js_get_enumvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastAll", typeof(UnityEngine.QueryTriggerInteraction), 4);
                            }
                            var ret = UnityEngine.Physics.SphereCastAll(arg0, arg1, arg2, arg3, arg4);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[3], typeof(float)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastAll", typeof(UnityEngine.Vector3), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastAll", typeof(float), 1);
                            }
                            UnityEngine.Vector3 arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastAll", typeof(UnityEngine.Vector3), 2);
                            }
                            float arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastAll", typeof(float), 3);
                            }
                            var ret = UnityEngine.Physics.SphereCastAll(arg0, arg1, arg2, arg3);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Ray)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(int)))
                        {
                            UnityEngine.Ray arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastAll", typeof(UnityEngine.Ray), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastAll", typeof(float), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastAll", typeof(float), 2);
                            }
                            int arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastAll", typeof(int), 3);
                            }
                            var ret = UnityEngine.Physics.SphereCastAll(arg0, arg1, arg2, arg3);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Vector3)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastAll", typeof(UnityEngine.Vector3), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastAll", typeof(float), 1);
                            }
                            UnityEngine.Vector3 arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastAll", typeof(UnityEngine.Vector3), 2);
                            }
                            var ret = UnityEngine.Physics.SphereCastAll(arg0, arg1, arg2);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Ray)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(float)))
                        {
                            UnityEngine.Ray arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastAll", typeof(UnityEngine.Ray), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastAll", typeof(float), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastAll", typeof(float), 2);
                            }
                            var ret = UnityEngine.Physics.SphereCastAll(arg0, arg1, arg2);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Ray arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastAll", typeof(UnityEngine.Ray), 0);
                        }
                        float arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastAll", typeof(float), 1);
                        }
                        var ret = UnityEngine.Physics.SphereCastAll(arg0, arg1);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("SphereCastAll", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_OverlapCapsule(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 5)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapCapsule", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapCapsule", typeof(UnityEngine.Vector3), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapCapsule", typeof(float), 2);
                        }
                        int arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapCapsule", typeof(int), 3);
                        }
                        UnityEngine.QueryTriggerInteraction arg4;
                        if (!Values.js_get_enumvalue(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapCapsule", typeof(UnityEngine.QueryTriggerInteraction), 4);
                        }
                        var ret = UnityEngine.Physics.OverlapCapsule(arg0, arg1, arg2, arg3, arg4);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 4)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapCapsule", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapCapsule", typeof(UnityEngine.Vector3), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapCapsule", typeof(float), 2);
                        }
                        int arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapCapsule", typeof(int), 3);
                        }
                        var ret = UnityEngine.Physics.OverlapCapsule(arg0, arg1, arg2, arg3);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 3)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapCapsule", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapCapsule", typeof(UnityEngine.Vector3), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapCapsule", typeof(float), 2);
                        }
                        var ret = UnityEngine.Physics.OverlapCapsule(arg0, arg1, arg2);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("OverlapCapsule", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_OverlapSphere(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapSphere", typeof(UnityEngine.Vector3), 0);
                        }
                        float arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapSphere", typeof(float), 1);
                        }
                        int arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapSphere", typeof(int), 2);
                        }
                        UnityEngine.QueryTriggerInteraction arg3;
                        if (!Values.js_get_enumvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapSphere", typeof(UnityEngine.QueryTriggerInteraction), 3);
                        }
                        var ret = UnityEngine.Physics.OverlapSphere(arg0, arg1, arg2, arg3);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 3)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapSphere", typeof(UnityEngine.Vector3), 0);
                        }
                        float arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapSphere", typeof(float), 1);
                        }
                        int arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapSphere", typeof(int), 2);
                        }
                        var ret = UnityEngine.Physics.OverlapSphere(arg0, arg1, arg2);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapSphere", typeof(UnityEngine.Vector3), 0);
                        }
                        float arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapSphere", typeof(float), 1);
                        }
                        var ret = UnityEngine.Physics.OverlapSphere(arg0, arg1);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("OverlapSphere", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Simulate(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    float arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Physics), "Simulate", typeof(float), 0);
                    }
                    UnityEngine.Physics.Simulate(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Simulate", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SyncTransforms(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.Physics.SyncTransforms();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SyncTransforms", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ComputePenetration(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 8)
                {
                    UnityEngine.Collider arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Physics), "ComputePenetration", typeof(UnityEngine.Collider), 0);
                    }
                    UnityEngine.Vector3 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Physics), "ComputePenetration", typeof(UnityEngine.Vector3), 1);
                    }
                    UnityEngine.Quaternion arg2;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEngine.Physics), "ComputePenetration", typeof(UnityEngine.Quaternion), 2);
                    }
                    UnityEngine.Collider arg3;
                    if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEngine.Physics), "ComputePenetration", typeof(UnityEngine.Collider), 3);
                    }
                    UnityEngine.Vector3 arg4;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[4], out arg4))
                    {
                        throw new ParameterException(typeof(UnityEngine.Physics), "ComputePenetration", typeof(UnityEngine.Vector3), 4);
                    }
                    UnityEngine.Quaternion arg5;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[5], out arg5))
                    {
                        throw new ParameterException(typeof(UnityEngine.Physics), "ComputePenetration", typeof(UnityEngine.Quaternion), 5);
                    }
                    UnityEngine.Vector3 arg6;
                    float arg7;
                    var ret = UnityEngine.Physics.ComputePenetration(arg0, arg1, arg2, arg3, arg4, arg5, out arg6, out arg7);
                    var out0 = QuickJS.Binding.Values.js_push_structvalue(ctx, arg6);
                    if (JSApi.JS_IsException(out0))
                    {
                        return out0;
                    }
                    var context = ScriptEngine.GetContext(ctx);
                    JSApi.JS_SetProperty(ctx, argv[6], context.GetAtom("value"), out0);
                    var out1 = QuickJS.Binding.Values.js_push_primitive(ctx, arg7);
                    if (JSApi.JS_IsException(out1))
                    {
                        return out1;
                    }
                    JSApi.JS_SetProperty(ctx, argv[7], context.GetAtom("value"), out1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("ComputePenetration", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ClosestPoint(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 4)
                {
                    UnityEngine.Vector3 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Physics), "ClosestPoint", typeof(UnityEngine.Vector3), 0);
                    }
                    UnityEngine.Collider arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Physics), "ClosestPoint", typeof(UnityEngine.Collider), 1);
                    }
                    UnityEngine.Vector3 arg2;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEngine.Physics), "ClosestPoint", typeof(UnityEngine.Vector3), 2);
                    }
                    UnityEngine.Quaternion arg3;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEngine.Physics), "ClosestPoint", typeof(UnityEngine.Quaternion), 3);
                    }
                    var ret = UnityEngine.Physics.ClosestPoint(arg0, arg1, arg2, arg3);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("ClosestPoint", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_OverlapSphereNonAlloc(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 5)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapSphereNonAlloc", typeof(UnityEngine.Vector3), 0);
                        }
                        float arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapSphereNonAlloc", typeof(float), 1);
                        }
                        UnityEngine.Collider[] arg2;
                        if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapSphereNonAlloc", typeof(UnityEngine.Collider[]), 2);
                        }
                        int arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapSphereNonAlloc", typeof(int), 3);
                        }
                        UnityEngine.QueryTriggerInteraction arg4;
                        if (!Values.js_get_enumvalue(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapSphereNonAlloc", typeof(UnityEngine.QueryTriggerInteraction), 4);
                        }
                        var ret = UnityEngine.Physics.OverlapSphereNonAlloc(arg0, arg1, arg2, arg3, arg4);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 4)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapSphereNonAlloc", typeof(UnityEngine.Vector3), 0);
                        }
                        float arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapSphereNonAlloc", typeof(float), 1);
                        }
                        UnityEngine.Collider[] arg2;
                        if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapSphereNonAlloc", typeof(UnityEngine.Collider[]), 2);
                        }
                        int arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapSphereNonAlloc", typeof(int), 3);
                        }
                        var ret = UnityEngine.Physics.OverlapSphereNonAlloc(arg0, arg1, arg2, arg3);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 3)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapSphereNonAlloc", typeof(UnityEngine.Vector3), 0);
                        }
                        float arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapSphereNonAlloc", typeof(float), 1);
                        }
                        UnityEngine.Collider[] arg2;
                        if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapSphereNonAlloc", typeof(UnityEngine.Collider[]), 2);
                        }
                        var ret = UnityEngine.Physics.OverlapSphereNonAlloc(arg0, arg1, arg2);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("OverlapSphereNonAlloc", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CheckSphere(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CheckSphere", typeof(UnityEngine.Vector3), 0);
                        }
                        float arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CheckSphere", typeof(float), 1);
                        }
                        int arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CheckSphere", typeof(int), 2);
                        }
                        UnityEngine.QueryTriggerInteraction arg3;
                        if (!Values.js_get_enumvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CheckSphere", typeof(UnityEngine.QueryTriggerInteraction), 3);
                        }
                        var ret = UnityEngine.Physics.CheckSphere(arg0, arg1, arg2, arg3);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 3)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CheckSphere", typeof(UnityEngine.Vector3), 0);
                        }
                        float arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CheckSphere", typeof(float), 1);
                        }
                        int arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CheckSphere", typeof(int), 2);
                        }
                        var ret = UnityEngine.Physics.CheckSphere(arg0, arg1, arg2);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CheckSphere", typeof(UnityEngine.Vector3), 0);
                        }
                        float arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CheckSphere", typeof(float), 1);
                        }
                        var ret = UnityEngine.Physics.CheckSphere(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("CheckSphere", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CapsuleCastNonAlloc(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 8)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCastNonAlloc", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCastNonAlloc", typeof(UnityEngine.Vector3), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCastNonAlloc", typeof(float), 2);
                        }
                        UnityEngine.Vector3 arg3;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCastNonAlloc", typeof(UnityEngine.Vector3), 3);
                        }
                        UnityEngine.RaycastHit[] arg4;
                        if (!Values.js_get_structvalue(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCastNonAlloc", typeof(UnityEngine.RaycastHit[]), 4);
                        }
                        float arg5;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCastNonAlloc", typeof(float), 5);
                        }
                        int arg6;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[6], out arg6))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCastNonAlloc", typeof(int), 6);
                        }
                        UnityEngine.QueryTriggerInteraction arg7;
                        if (!Values.js_get_enumvalue(ctx, argv[7], out arg7))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCastNonAlloc", typeof(UnityEngine.QueryTriggerInteraction), 7);
                        }
                        var ret = UnityEngine.Physics.CapsuleCastNonAlloc(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 7)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCastNonAlloc", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCastNonAlloc", typeof(UnityEngine.Vector3), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCastNonAlloc", typeof(float), 2);
                        }
                        UnityEngine.Vector3 arg3;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCastNonAlloc", typeof(UnityEngine.Vector3), 3);
                        }
                        UnityEngine.RaycastHit[] arg4;
                        if (!Values.js_get_structvalue(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCastNonAlloc", typeof(UnityEngine.RaycastHit[]), 4);
                        }
                        float arg5;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCastNonAlloc", typeof(float), 5);
                        }
                        int arg6;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[6], out arg6))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCastNonAlloc", typeof(int), 6);
                        }
                        var ret = UnityEngine.Physics.CapsuleCastNonAlloc(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 6)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCastNonAlloc", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCastNonAlloc", typeof(UnityEngine.Vector3), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCastNonAlloc", typeof(float), 2);
                        }
                        UnityEngine.Vector3 arg3;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCastNonAlloc", typeof(UnityEngine.Vector3), 3);
                        }
                        UnityEngine.RaycastHit[] arg4;
                        if (!Values.js_get_structvalue(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCastNonAlloc", typeof(UnityEngine.RaycastHit[]), 4);
                        }
                        float arg5;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCastNonAlloc", typeof(float), 5);
                        }
                        var ret = UnityEngine.Physics.CapsuleCastNonAlloc(arg0, arg1, arg2, arg3, arg4, arg5);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 5)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCastNonAlloc", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCastNonAlloc", typeof(UnityEngine.Vector3), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCastNonAlloc", typeof(float), 2);
                        }
                        UnityEngine.Vector3 arg3;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCastNonAlloc", typeof(UnityEngine.Vector3), 3);
                        }
                        UnityEngine.RaycastHit[] arg4;
                        if (!Values.js_get_structvalue(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CapsuleCastNonAlloc", typeof(UnityEngine.RaycastHit[]), 4);
                        }
                        var ret = UnityEngine.Physics.CapsuleCastNonAlloc(arg0, arg1, arg2, arg3, arg4);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("CapsuleCastNonAlloc", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SphereCastNonAlloc(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 7)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastNonAlloc", typeof(UnityEngine.Vector3), 0);
                        }
                        float arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastNonAlloc", typeof(float), 1);
                        }
                        UnityEngine.Vector3 arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastNonAlloc", typeof(UnityEngine.Vector3), 2);
                        }
                        UnityEngine.RaycastHit[] arg3;
                        if (!Values.js_get_structvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastNonAlloc", typeof(UnityEngine.RaycastHit[]), 3);
                        }
                        float arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastNonAlloc", typeof(float), 4);
                        }
                        int arg5;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastNonAlloc", typeof(int), 5);
                        }
                        UnityEngine.QueryTriggerInteraction arg6;
                        if (!Values.js_get_enumvalue(ctx, argv[6], out arg6))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastNonAlloc", typeof(UnityEngine.QueryTriggerInteraction), 6);
                        }
                        var ret = UnityEngine.Physics.SphereCastNonAlloc(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 6)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.RaycastHit[])) && Values.js_match_type(ctx, argv[4], typeof(float)) && Values.js_match_type(ctx, argv[5], typeof(int)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastNonAlloc", typeof(UnityEngine.Vector3), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastNonAlloc", typeof(float), 1);
                            }
                            UnityEngine.Vector3 arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastNonAlloc", typeof(UnityEngine.Vector3), 2);
                            }
                            UnityEngine.RaycastHit[] arg3;
                            if (!Values.js_get_structvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastNonAlloc", typeof(UnityEngine.RaycastHit[]), 3);
                            }
                            float arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastNonAlloc", typeof(float), 4);
                            }
                            int arg5;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastNonAlloc", typeof(int), 5);
                            }
                            var ret = UnityEngine.Physics.SphereCastNonAlloc(arg0, arg1, arg2, arg3, arg4, arg5);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Ray)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.RaycastHit[])) && Values.js_match_type(ctx, argv[3], typeof(float)) && Values.js_match_type(ctx, argv[4], typeof(int)) && Values.js_match_type(ctx, argv[5], typeof(UnityEngine.QueryTriggerInteraction)))
                        {
                            UnityEngine.Ray arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastNonAlloc", typeof(UnityEngine.Ray), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastNonAlloc", typeof(float), 1);
                            }
                            UnityEngine.RaycastHit[] arg2;
                            if (!Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastNonAlloc", typeof(UnityEngine.RaycastHit[]), 2);
                            }
                            float arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastNonAlloc", typeof(float), 3);
                            }
                            int arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastNonAlloc", typeof(int), 4);
                            }
                            UnityEngine.QueryTriggerInteraction arg5;
                            if (!Values.js_get_enumvalue(ctx, argv[5], out arg5))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastNonAlloc", typeof(UnityEngine.QueryTriggerInteraction), 5);
                            }
                            var ret = UnityEngine.Physics.SphereCastNonAlloc(arg0, arg1, arg2, arg3, arg4, arg5);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 5)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.RaycastHit[])) && Values.js_match_type(ctx, argv[4], typeof(float)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastNonAlloc", typeof(UnityEngine.Vector3), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastNonAlloc", typeof(float), 1);
                            }
                            UnityEngine.Vector3 arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastNonAlloc", typeof(UnityEngine.Vector3), 2);
                            }
                            UnityEngine.RaycastHit[] arg3;
                            if (!Values.js_get_structvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastNonAlloc", typeof(UnityEngine.RaycastHit[]), 3);
                            }
                            float arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastNonAlloc", typeof(float), 4);
                            }
                            var ret = UnityEngine.Physics.SphereCastNonAlloc(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Ray)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.RaycastHit[])) && Values.js_match_type(ctx, argv[3], typeof(float)) && Values.js_match_type(ctx, argv[4], typeof(int)))
                        {
                            UnityEngine.Ray arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastNonAlloc", typeof(UnityEngine.Ray), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastNonAlloc", typeof(float), 1);
                            }
                            UnityEngine.RaycastHit[] arg2;
                            if (!Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastNonAlloc", typeof(UnityEngine.RaycastHit[]), 2);
                            }
                            float arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastNonAlloc", typeof(float), 3);
                            }
                            int arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastNonAlloc", typeof(int), 4);
                            }
                            var ret = UnityEngine.Physics.SphereCastNonAlloc(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.RaycastHit[])))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastNonAlloc", typeof(UnityEngine.Vector3), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastNonAlloc", typeof(float), 1);
                            }
                            UnityEngine.Vector3 arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastNonAlloc", typeof(UnityEngine.Vector3), 2);
                            }
                            UnityEngine.RaycastHit[] arg3;
                            if (!Values.js_get_structvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastNonAlloc", typeof(UnityEngine.RaycastHit[]), 3);
                            }
                            var ret = UnityEngine.Physics.SphereCastNonAlloc(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Ray)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.RaycastHit[])) && Values.js_match_type(ctx, argv[3], typeof(float)))
                        {
                            UnityEngine.Ray arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastNonAlloc", typeof(UnityEngine.Ray), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastNonAlloc", typeof(float), 1);
                            }
                            UnityEngine.RaycastHit[] arg2;
                            if (!Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastNonAlloc", typeof(UnityEngine.RaycastHit[]), 2);
                            }
                            float arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastNonAlloc", typeof(float), 3);
                            }
                            var ret = UnityEngine.Physics.SphereCastNonAlloc(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 3)
                    {
                        UnityEngine.Ray arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastNonAlloc", typeof(UnityEngine.Ray), 0);
                        }
                        float arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastNonAlloc", typeof(float), 1);
                        }
                        UnityEngine.RaycastHit[] arg2;
                        if (!Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "SphereCastNonAlloc", typeof(UnityEngine.RaycastHit[]), 2);
                        }
                        var ret = UnityEngine.Physics.SphereCastNonAlloc(arg0, arg1, arg2);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("SphereCastNonAlloc", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CheckCapsule(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 5)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CheckCapsule", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CheckCapsule", typeof(UnityEngine.Vector3), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CheckCapsule", typeof(float), 2);
                        }
                        int arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CheckCapsule", typeof(int), 3);
                        }
                        UnityEngine.QueryTriggerInteraction arg4;
                        if (!Values.js_get_enumvalue(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CheckCapsule", typeof(UnityEngine.QueryTriggerInteraction), 4);
                        }
                        var ret = UnityEngine.Physics.CheckCapsule(arg0, arg1, arg2, arg3, arg4);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 4)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CheckCapsule", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CheckCapsule", typeof(UnityEngine.Vector3), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CheckCapsule", typeof(float), 2);
                        }
                        int arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CheckCapsule", typeof(int), 3);
                        }
                        var ret = UnityEngine.Physics.CheckCapsule(arg0, arg1, arg2, arg3);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 3)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CheckCapsule", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CheckCapsule", typeof(UnityEngine.Vector3), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CheckCapsule", typeof(float), 2);
                        }
                        var ret = UnityEngine.Physics.CheckCapsule(arg0, arg1, arg2);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("CheckCapsule", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CheckBox(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 5)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CheckBox", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CheckBox", typeof(UnityEngine.Vector3), 1);
                        }
                        UnityEngine.Quaternion arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CheckBox", typeof(UnityEngine.Quaternion), 2);
                        }
                        int arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CheckBox", typeof(int), 3);
                        }
                        UnityEngine.QueryTriggerInteraction arg4;
                        if (!Values.js_get_enumvalue(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CheckBox", typeof(UnityEngine.QueryTriggerInteraction), 4);
                        }
                        var ret = UnityEngine.Physics.CheckBox(arg0, arg1, arg2, arg3, arg4);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 4)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CheckBox", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CheckBox", typeof(UnityEngine.Vector3), 1);
                        }
                        UnityEngine.Quaternion arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CheckBox", typeof(UnityEngine.Quaternion), 2);
                        }
                        int arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CheckBox", typeof(int), 3);
                        }
                        var ret = UnityEngine.Physics.CheckBox(arg0, arg1, arg2, arg3);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 3)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CheckBox", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CheckBox", typeof(UnityEngine.Vector3), 1);
                        }
                        UnityEngine.Quaternion arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CheckBox", typeof(UnityEngine.Quaternion), 2);
                        }
                        var ret = UnityEngine.Physics.CheckBox(arg0, arg1, arg2);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CheckBox", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "CheckBox", typeof(UnityEngine.Vector3), 1);
                        }
                        var ret = UnityEngine.Physics.CheckBox(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("CheckBox", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_OverlapBox(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 5)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapBox", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapBox", typeof(UnityEngine.Vector3), 1);
                        }
                        UnityEngine.Quaternion arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapBox", typeof(UnityEngine.Quaternion), 2);
                        }
                        int arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapBox", typeof(int), 3);
                        }
                        UnityEngine.QueryTriggerInteraction arg4;
                        if (!Values.js_get_enumvalue(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapBox", typeof(UnityEngine.QueryTriggerInteraction), 4);
                        }
                        var ret = UnityEngine.Physics.OverlapBox(arg0, arg1, arg2, arg3, arg4);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 4)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapBox", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapBox", typeof(UnityEngine.Vector3), 1);
                        }
                        UnityEngine.Quaternion arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapBox", typeof(UnityEngine.Quaternion), 2);
                        }
                        int arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapBox", typeof(int), 3);
                        }
                        var ret = UnityEngine.Physics.OverlapBox(arg0, arg1, arg2, arg3);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 3)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapBox", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapBox", typeof(UnityEngine.Vector3), 1);
                        }
                        UnityEngine.Quaternion arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapBox", typeof(UnityEngine.Quaternion), 2);
                        }
                        var ret = UnityEngine.Physics.OverlapBox(arg0, arg1, arg2);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapBox", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapBox", typeof(UnityEngine.Vector3), 1);
                        }
                        var ret = UnityEngine.Physics.OverlapBox(arg0, arg1);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("OverlapBox", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_OverlapBoxNonAlloc(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 6)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapBoxNonAlloc", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapBoxNonAlloc", typeof(UnityEngine.Vector3), 1);
                        }
                        UnityEngine.Collider[] arg2;
                        if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapBoxNonAlloc", typeof(UnityEngine.Collider[]), 2);
                        }
                        UnityEngine.Quaternion arg3;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapBoxNonAlloc", typeof(UnityEngine.Quaternion), 3);
                        }
                        int arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapBoxNonAlloc", typeof(int), 4);
                        }
                        UnityEngine.QueryTriggerInteraction arg5;
                        if (!Values.js_get_enumvalue(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapBoxNonAlloc", typeof(UnityEngine.QueryTriggerInteraction), 5);
                        }
                        var ret = UnityEngine.Physics.OverlapBoxNonAlloc(arg0, arg1, arg2, arg3, arg4, arg5);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 5)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapBoxNonAlloc", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapBoxNonAlloc", typeof(UnityEngine.Vector3), 1);
                        }
                        UnityEngine.Collider[] arg2;
                        if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapBoxNonAlloc", typeof(UnityEngine.Collider[]), 2);
                        }
                        UnityEngine.Quaternion arg3;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapBoxNonAlloc", typeof(UnityEngine.Quaternion), 3);
                        }
                        int arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapBoxNonAlloc", typeof(int), 4);
                        }
                        var ret = UnityEngine.Physics.OverlapBoxNonAlloc(arg0, arg1, arg2, arg3, arg4);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 4)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapBoxNonAlloc", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapBoxNonAlloc", typeof(UnityEngine.Vector3), 1);
                        }
                        UnityEngine.Collider[] arg2;
                        if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapBoxNonAlloc", typeof(UnityEngine.Collider[]), 2);
                        }
                        UnityEngine.Quaternion arg3;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapBoxNonAlloc", typeof(UnityEngine.Quaternion), 3);
                        }
                        var ret = UnityEngine.Physics.OverlapBoxNonAlloc(arg0, arg1, arg2, arg3);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 3)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapBoxNonAlloc", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapBoxNonAlloc", typeof(UnityEngine.Vector3), 1);
                        }
                        UnityEngine.Collider[] arg2;
                        if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapBoxNonAlloc", typeof(UnityEngine.Collider[]), 2);
                        }
                        var ret = UnityEngine.Physics.OverlapBoxNonAlloc(arg0, arg1, arg2);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("OverlapBoxNonAlloc", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_BoxCastNonAlloc(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 8)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastNonAlloc", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastNonAlloc", typeof(UnityEngine.Vector3), 1);
                        }
                        UnityEngine.Vector3 arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastNonAlloc", typeof(UnityEngine.Vector3), 2);
                        }
                        UnityEngine.RaycastHit[] arg3;
                        if (!Values.js_get_structvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastNonAlloc", typeof(UnityEngine.RaycastHit[]), 3);
                        }
                        UnityEngine.Quaternion arg4;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastNonAlloc", typeof(UnityEngine.Quaternion), 4);
                        }
                        float arg5;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastNonAlloc", typeof(float), 5);
                        }
                        int arg6;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[6], out arg6))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastNonAlloc", typeof(int), 6);
                        }
                        UnityEngine.QueryTriggerInteraction arg7;
                        if (!Values.js_get_enumvalue(ctx, argv[7], out arg7))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastNonAlloc", typeof(UnityEngine.QueryTriggerInteraction), 7);
                        }
                        var ret = UnityEngine.Physics.BoxCastNonAlloc(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 7)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastNonAlloc", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastNonAlloc", typeof(UnityEngine.Vector3), 1);
                        }
                        UnityEngine.Vector3 arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastNonAlloc", typeof(UnityEngine.Vector3), 2);
                        }
                        UnityEngine.RaycastHit[] arg3;
                        if (!Values.js_get_structvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastNonAlloc", typeof(UnityEngine.RaycastHit[]), 3);
                        }
                        UnityEngine.Quaternion arg4;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastNonAlloc", typeof(UnityEngine.Quaternion), 4);
                        }
                        float arg5;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastNonAlloc", typeof(float), 5);
                        }
                        int arg6;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[6], out arg6))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastNonAlloc", typeof(int), 6);
                        }
                        var ret = UnityEngine.Physics.BoxCastNonAlloc(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 6)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastNonAlloc", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastNonAlloc", typeof(UnityEngine.Vector3), 1);
                        }
                        UnityEngine.Vector3 arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastNonAlloc", typeof(UnityEngine.Vector3), 2);
                        }
                        UnityEngine.RaycastHit[] arg3;
                        if (!Values.js_get_structvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastNonAlloc", typeof(UnityEngine.RaycastHit[]), 3);
                        }
                        UnityEngine.Quaternion arg4;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastNonAlloc", typeof(UnityEngine.Quaternion), 4);
                        }
                        float arg5;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastNonAlloc", typeof(float), 5);
                        }
                        var ret = UnityEngine.Physics.BoxCastNonAlloc(arg0, arg1, arg2, arg3, arg4, arg5);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 5)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastNonAlloc", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastNonAlloc", typeof(UnityEngine.Vector3), 1);
                        }
                        UnityEngine.Vector3 arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastNonAlloc", typeof(UnityEngine.Vector3), 2);
                        }
                        UnityEngine.RaycastHit[] arg3;
                        if (!Values.js_get_structvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastNonAlloc", typeof(UnityEngine.RaycastHit[]), 3);
                        }
                        UnityEngine.Quaternion arg4;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastNonAlloc", typeof(UnityEngine.Quaternion), 4);
                        }
                        var ret = UnityEngine.Physics.BoxCastNonAlloc(arg0, arg1, arg2, arg3, arg4);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 4)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastNonAlloc", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastNonAlloc", typeof(UnityEngine.Vector3), 1);
                        }
                        UnityEngine.Vector3 arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastNonAlloc", typeof(UnityEngine.Vector3), 2);
                        }
                        UnityEngine.RaycastHit[] arg3;
                        if (!Values.js_get_structvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastNonAlloc", typeof(UnityEngine.RaycastHit[]), 3);
                        }
                        var ret = UnityEngine.Physics.BoxCastNonAlloc(arg0, arg1, arg2, arg3);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("BoxCastNonAlloc", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_BoxCastAll(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 7)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastAll", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastAll", typeof(UnityEngine.Vector3), 1);
                        }
                        UnityEngine.Vector3 arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastAll", typeof(UnityEngine.Vector3), 2);
                        }
                        UnityEngine.Quaternion arg3;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastAll", typeof(UnityEngine.Quaternion), 3);
                        }
                        float arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastAll", typeof(float), 4);
                        }
                        int arg5;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastAll", typeof(int), 5);
                        }
                        UnityEngine.QueryTriggerInteraction arg6;
                        if (!Values.js_get_enumvalue(ctx, argv[6], out arg6))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastAll", typeof(UnityEngine.QueryTriggerInteraction), 6);
                        }
                        var ret = UnityEngine.Physics.BoxCastAll(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 6)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastAll", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastAll", typeof(UnityEngine.Vector3), 1);
                        }
                        UnityEngine.Vector3 arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastAll", typeof(UnityEngine.Vector3), 2);
                        }
                        UnityEngine.Quaternion arg3;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastAll", typeof(UnityEngine.Quaternion), 3);
                        }
                        float arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastAll", typeof(float), 4);
                        }
                        int arg5;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastAll", typeof(int), 5);
                        }
                        var ret = UnityEngine.Physics.BoxCastAll(arg0, arg1, arg2, arg3, arg4, arg5);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 5)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastAll", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastAll", typeof(UnityEngine.Vector3), 1);
                        }
                        UnityEngine.Vector3 arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastAll", typeof(UnityEngine.Vector3), 2);
                        }
                        UnityEngine.Quaternion arg3;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastAll", typeof(UnityEngine.Quaternion), 3);
                        }
                        float arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastAll", typeof(float), 4);
                        }
                        var ret = UnityEngine.Physics.BoxCastAll(arg0, arg1, arg2, arg3, arg4);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 4)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastAll", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastAll", typeof(UnityEngine.Vector3), 1);
                        }
                        UnityEngine.Vector3 arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastAll", typeof(UnityEngine.Vector3), 2);
                        }
                        UnityEngine.Quaternion arg3;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastAll", typeof(UnityEngine.Quaternion), 3);
                        }
                        var ret = UnityEngine.Physics.BoxCastAll(arg0, arg1, arg2, arg3);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 3)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastAll", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastAll", typeof(UnityEngine.Vector3), 1);
                        }
                        UnityEngine.Vector3 arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "BoxCastAll", typeof(UnityEngine.Vector3), 2);
                        }
                        var ret = UnityEngine.Physics.BoxCastAll(arg0, arg1, arg2);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("BoxCastAll", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_OverlapCapsuleNonAlloc(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 6)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapCapsuleNonAlloc", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapCapsuleNonAlloc", typeof(UnityEngine.Vector3), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapCapsuleNonAlloc", typeof(float), 2);
                        }
                        UnityEngine.Collider[] arg3;
                        if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapCapsuleNonAlloc", typeof(UnityEngine.Collider[]), 3);
                        }
                        int arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapCapsuleNonAlloc", typeof(int), 4);
                        }
                        UnityEngine.QueryTriggerInteraction arg5;
                        if (!Values.js_get_enumvalue(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapCapsuleNonAlloc", typeof(UnityEngine.QueryTriggerInteraction), 5);
                        }
                        var ret = UnityEngine.Physics.OverlapCapsuleNonAlloc(arg0, arg1, arg2, arg3, arg4, arg5);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 5)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapCapsuleNonAlloc", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapCapsuleNonAlloc", typeof(UnityEngine.Vector3), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapCapsuleNonAlloc", typeof(float), 2);
                        }
                        UnityEngine.Collider[] arg3;
                        if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapCapsuleNonAlloc", typeof(UnityEngine.Collider[]), 3);
                        }
                        int arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapCapsuleNonAlloc", typeof(int), 4);
                        }
                        var ret = UnityEngine.Physics.OverlapCapsuleNonAlloc(arg0, arg1, arg2, arg3, arg4);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 4)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapCapsuleNonAlloc", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapCapsuleNonAlloc", typeof(UnityEngine.Vector3), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapCapsuleNonAlloc", typeof(float), 2);
                        }
                        UnityEngine.Collider[] arg3;
                        if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Physics), "OverlapCapsuleNonAlloc", typeof(UnityEngine.Collider[]), 3);
                        }
                        var ret = UnityEngine.Physics.OverlapCapsuleNonAlloc(arg0, arg1, arg2, arg3);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("OverlapCapsuleNonAlloc", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RebuildBroadphaseRegions(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Bounds arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Physics), "RebuildBroadphaseRegions", typeof(UnityEngine.Bounds), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Physics), "RebuildBroadphaseRegions", typeof(int), 1);
                    }
                    UnityEngine.Physics.RebuildBroadphaseRegions(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RebuildBroadphaseRegions", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_BakeMesh(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Physics), "BakeMesh", typeof(int), 0);
                    }
                    bool arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Physics), "BakeMesh", typeof(bool), 1);
                    }
                    UnityEngine.Physics.BakeMesh(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("BakeMesh", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_gravity(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Physics.gravity;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_gravity(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Vector3 value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Physics), "gravity", typeof(UnityEngine.Vector3), 0);
                }
                UnityEngine.Physics.gravity = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_defaultContactOffset(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Physics.defaultContactOffset;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_defaultContactOffset(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Physics), "defaultContactOffset", typeof(float), 0);
                }
                UnityEngine.Physics.defaultContactOffset = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_sleepThreshold(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Physics.sleepThreshold;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_sleepThreshold(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Physics), "sleepThreshold", typeof(float), 0);
                }
                UnityEngine.Physics.sleepThreshold = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_queriesHitTriggers(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Physics.queriesHitTriggers;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_queriesHitTriggers(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Physics), "queriesHitTriggers", typeof(bool), 0);
                }
                UnityEngine.Physics.queriesHitTriggers = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_queriesHitBackfaces(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Physics.queriesHitBackfaces;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_queriesHitBackfaces(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Physics), "queriesHitBackfaces", typeof(bool), 0);
                }
                UnityEngine.Physics.queriesHitBackfaces = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_bounceThreshold(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Physics.bounceThreshold;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_bounceThreshold(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Physics), "bounceThreshold", typeof(float), 0);
                }
                UnityEngine.Physics.bounceThreshold = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_defaultSolverIterations(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Physics.defaultSolverIterations;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_defaultSolverIterations(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Physics), "defaultSolverIterations", typeof(int), 0);
                }
                UnityEngine.Physics.defaultSolverIterations = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_defaultSolverVelocityIterations(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Physics.defaultSolverVelocityIterations;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_defaultSolverVelocityIterations(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Physics), "defaultSolverVelocityIterations", typeof(int), 0);
                }
                UnityEngine.Physics.defaultSolverVelocityIterations = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_defaultMaxAngularSpeed(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Physics.defaultMaxAngularSpeed;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_defaultMaxAngularSpeed(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Physics), "defaultMaxAngularSpeed", typeof(float), 0);
                }
                UnityEngine.Physics.defaultMaxAngularSpeed = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_defaultPhysicsScene(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Physics.defaultPhysicsScene;
                return Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_autoSimulation(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Physics.autoSimulation;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_autoSimulation(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Physics), "autoSimulation", typeof(bool), 0);
                }
                UnityEngine.Physics.autoSimulation = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_autoSyncTransforms(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Physics.autoSyncTransforms;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_autoSyncTransforms(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Physics), "autoSyncTransforms", typeof(bool), 0);
                }
                UnityEngine.Physics.autoSyncTransforms = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_reuseCollisionCallbacks(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Physics.reuseCollisionCallbacks;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_reuseCollisionCallbacks(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Physics), "reuseCollisionCallbacks", typeof(bool), 0);
                }
                UnityEngine.Physics.reuseCollisionCallbacks = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_interCollisionDistance(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Physics.interCollisionDistance;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_interCollisionDistance(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Physics), "interCollisionDistance", typeof(float), 0);
                }
                UnityEngine.Physics.interCollisionDistance = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_interCollisionStiffness(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Physics.interCollisionStiffness;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_interCollisionStiffness(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Physics), "interCollisionStiffness", typeof(float), 0);
                }
                UnityEngine.Physics.interCollisionStiffness = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_interCollisionSettingsToggle(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Physics.interCollisionSettingsToggle;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_interCollisionSettingsToggle(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Physics), "interCollisionSettingsToggle", typeof(bool), 0);
                }
                UnityEngine.Physics.interCollisionSettingsToggle = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_clothGravity(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Physics.clothGravity;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_clothGravity(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Vector3 value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Physics), "clothGravity", typeof(UnityEngine.Vector3), 0);
                }
                UnityEngine.Physics.clothGravity = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("Physics", typeof(UnityEngine.Physics), BindConstructor);
            cls.AddMethod(true, "IgnoreCollision", BindStatic_IgnoreCollision);
            cls.AddMethod(true, "IgnoreLayerCollision", BindStatic_IgnoreLayerCollision);
            cls.AddMethod(true, "GetIgnoreLayerCollision", BindStatic_GetIgnoreLayerCollision);
            cls.AddMethod(true, "GetIgnoreCollision", BindStatic_GetIgnoreCollision);
            cls.AddMethod(true, "Raycast", BindStatic_Raycast);
            cls.AddMethod(true, "Linecast", BindStatic_Linecast);
            cls.AddMethod(true, "CapsuleCast", BindStatic_CapsuleCast);
            cls.AddMethod(true, "SphereCast", BindStatic_SphereCast);
            cls.AddMethod(true, "BoxCast", BindStatic_BoxCast);
            cls.AddMethod(true, "RaycastAll", BindStatic_RaycastAll);
            cls.AddMethod(true, "RaycastNonAlloc", BindStatic_RaycastNonAlloc);
            cls.AddMethod(true, "CapsuleCastAll", BindStatic_CapsuleCastAll);
            cls.AddMethod(true, "SphereCastAll", BindStatic_SphereCastAll);
            cls.AddMethod(true, "OverlapCapsule", BindStatic_OverlapCapsule);
            cls.AddMethod(true, "OverlapSphere", BindStatic_OverlapSphere);
            cls.AddMethod(true, "Simulate", BindStatic_Simulate);
            cls.AddMethod(true, "SyncTransforms", BindStatic_SyncTransforms);
            cls.AddMethod(true, "ComputePenetration", BindStatic_ComputePenetration);
            cls.AddMethod(true, "ClosestPoint", BindStatic_ClosestPoint);
            cls.AddMethod(true, "OverlapSphereNonAlloc", BindStatic_OverlapSphereNonAlloc);
            cls.AddMethod(true, "CheckSphere", BindStatic_CheckSphere);
            cls.AddMethod(true, "CapsuleCastNonAlloc", BindStatic_CapsuleCastNonAlloc);
            cls.AddMethod(true, "SphereCastNonAlloc", BindStatic_SphereCastNonAlloc);
            cls.AddMethod(true, "CheckCapsule", BindStatic_CheckCapsule);
            cls.AddMethod(true, "CheckBox", BindStatic_CheckBox);
            cls.AddMethod(true, "OverlapBox", BindStatic_OverlapBox);
            cls.AddMethod(true, "OverlapBoxNonAlloc", BindStatic_OverlapBoxNonAlloc);
            cls.AddMethod(true, "BoxCastNonAlloc", BindStatic_BoxCastNonAlloc);
            cls.AddMethod(true, "BoxCastAll", BindStatic_BoxCastAll);
            cls.AddMethod(true, "OverlapCapsuleNonAlloc", BindStatic_OverlapCapsuleNonAlloc);
            cls.AddMethod(true, "RebuildBroadphaseRegions", BindStatic_RebuildBroadphaseRegions);
            cls.AddMethod(true, "BakeMesh", BindStatic_BakeMesh);
            cls.AddProperty(true, "gravity", BindStaticRead_gravity, BindStaticWrite_gravity);
            cls.AddProperty(true, "defaultContactOffset", BindStaticRead_defaultContactOffset, BindStaticWrite_defaultContactOffset);
            cls.AddProperty(true, "sleepThreshold", BindStaticRead_sleepThreshold, BindStaticWrite_sleepThreshold);
            cls.AddProperty(true, "queriesHitTriggers", BindStaticRead_queriesHitTriggers, BindStaticWrite_queriesHitTriggers);
            cls.AddProperty(true, "queriesHitBackfaces", BindStaticRead_queriesHitBackfaces, BindStaticWrite_queriesHitBackfaces);
            cls.AddProperty(true, "bounceThreshold", BindStaticRead_bounceThreshold, BindStaticWrite_bounceThreshold);
            cls.AddProperty(true, "defaultSolverIterations", BindStaticRead_defaultSolverIterations, BindStaticWrite_defaultSolverIterations);
            cls.AddProperty(true, "defaultSolverVelocityIterations", BindStaticRead_defaultSolverVelocityIterations, BindStaticWrite_defaultSolverVelocityIterations);
            cls.AddProperty(true, "defaultMaxAngularSpeed", BindStaticRead_defaultMaxAngularSpeed, BindStaticWrite_defaultMaxAngularSpeed);
            cls.AddProperty(true, "defaultPhysicsScene", BindStaticRead_defaultPhysicsScene, null);
            cls.AddProperty(true, "autoSimulation", BindStaticRead_autoSimulation, BindStaticWrite_autoSimulation);
            cls.AddProperty(true, "autoSyncTransforms", BindStaticRead_autoSyncTransforms, BindStaticWrite_autoSyncTransforms);
            cls.AddProperty(true, "reuseCollisionCallbacks", BindStaticRead_reuseCollisionCallbacks, BindStaticWrite_reuseCollisionCallbacks);
            cls.AddProperty(true, "interCollisionDistance", BindStaticRead_interCollisionDistance, BindStaticWrite_interCollisionDistance);
            cls.AddProperty(true, "interCollisionStiffness", BindStaticRead_interCollisionStiffness, BindStaticWrite_interCollisionStiffness);
            cls.AddProperty(true, "interCollisionSettingsToggle", BindStaticRead_interCollisionSettingsToggle, BindStaticWrite_interCollisionSettingsToggle);
            cls.AddProperty(true, "clothGravity", BindStaticRead_clothGravity, BindStaticWrite_clothGravity);
            cls.AddConstValue("IgnoreRaycastLayer", 4);
            cls.AddConstValue("DefaultRaycastLayers", -5);
            cls.AddConstValue("AllLayers", -1);
            return cls;
        }
    }
}
#endif
