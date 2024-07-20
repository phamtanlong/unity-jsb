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
    // Type: UnityEditor.MathUtils
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_MathUtils
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                if (argc == 0)
                {
                    var o = new UnityEditor.MathUtils();
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
        public static JSValue BindStatic_GetQuatLength(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Quaternion arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.MathUtils), "GetQuatLength", typeof(UnityEngine.Quaternion), 0);
                    }
                    var ret = UnityEditor.MathUtils.GetQuatLength(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetQuatLength", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetQuatConjugate(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Quaternion arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.MathUtils), "GetQuatConjugate", typeof(UnityEngine.Quaternion), 0);
                    }
                    var ret = UnityEditor.MathUtils.GetQuatConjugate(arg0);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetQuatConjugate", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_OrthogonalizeMatrix(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Matrix4x4 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.MathUtils), "OrthogonalizeMatrix", typeof(UnityEngine.Matrix4x4), 0);
                    }
                    var ret = UnityEditor.MathUtils.OrthogonalizeMatrix(arg0);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("OrthogonalizeMatrix", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_QuaternionNormalize(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Quaternion arg0;
                    var refVal0 = Values.js_read_wrap(ctx, argv[0]);
                    if (refVal0.IsException())
                    {
                        return refVal0;
                    }
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, refVal0, out arg0))
                    {
                        JSApi.JS_FreeValue(ctx, refVal0);
                        throw new ParameterException(typeof(UnityEditor.MathUtils), "QuaternionNormalize", typeof(UnityEngine.Quaternion), 0);
                    }
                    JSApi.JS_FreeValue(ctx, refVal0);
                    UnityEditor.MathUtils.QuaternionNormalize(ref arg0);
                    var out0 = QuickJS.Binding.Values.js_push_structvalue(ctx, arg0);
                    if (JSApi.JS_IsException(out0))
                    {
                        return out0;
                    }
                    var context = ScriptEngine.GetContext(ctx);
                    JSApi.JS_SetProperty(ctx, argv[0], context.GetAtom("value"), out0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("QuaternionNormalize", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_QuaternionFromMatrix(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Matrix4x4 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.MathUtils), "QuaternionFromMatrix", typeof(UnityEngine.Matrix4x4), 0);
                    }
                    var ret = UnityEditor.MathUtils.QuaternionFromMatrix(arg0);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("QuaternionFromMatrix", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetQuatLog(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Quaternion arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.MathUtils), "GetQuatLog", typeof(UnityEngine.Quaternion), 0);
                    }
                    var ret = UnityEditor.MathUtils.GetQuatLog(arg0);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetQuatLog", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetQuatExp(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Quaternion arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.MathUtils), "GetQuatExp", typeof(UnityEngine.Quaternion), 0);
                    }
                    var ret = UnityEditor.MathUtils.GetQuatExp(arg0);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetQuatExp", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetQuatSquad(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 5)
                {
                    float arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.MathUtils), "GetQuatSquad", typeof(float), 0);
                    }
                    UnityEngine.Quaternion arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.MathUtils), "GetQuatSquad", typeof(UnityEngine.Quaternion), 1);
                    }
                    UnityEngine.Quaternion arg2;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.MathUtils), "GetQuatSquad", typeof(UnityEngine.Quaternion), 2);
                    }
                    UnityEngine.Quaternion arg3;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.MathUtils), "GetQuatSquad", typeof(UnityEngine.Quaternion), 3);
                    }
                    UnityEngine.Quaternion arg4;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[4], out arg4))
                    {
                        throw new ParameterException(typeof(UnityEditor.MathUtils), "GetQuatSquad", typeof(UnityEngine.Quaternion), 4);
                    }
                    var ret = UnityEditor.MathUtils.GetQuatSquad(arg0, arg1, arg2, arg3, arg4);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetQuatSquad", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetSquadIntermediate(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Quaternion arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.MathUtils), "GetSquadIntermediate", typeof(UnityEngine.Quaternion), 0);
                    }
                    UnityEngine.Quaternion arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.MathUtils), "GetSquadIntermediate", typeof(UnityEngine.Quaternion), 1);
                    }
                    UnityEngine.Quaternion arg2;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.MathUtils), "GetSquadIntermediate", typeof(UnityEngine.Quaternion), 2);
                    }
                    var ret = UnityEditor.MathUtils.GetSquadIntermediate(arg0, arg1, arg2);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetSquadIntermediate", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Ease(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    float arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.MathUtils), "Ease", typeof(float), 0);
                    }
                    float arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.MathUtils), "Ease", typeof(float), 1);
                    }
                    float arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.MathUtils), "Ease", typeof(float), 2);
                    }
                    var ret = UnityEditor.MathUtils.Ease(arg0, arg1, arg2);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("Ease", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Slerp(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Quaternion arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.MathUtils), "Slerp", typeof(UnityEngine.Quaternion), 0);
                    }
                    UnityEngine.Quaternion arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.MathUtils), "Slerp", typeof(UnityEngine.Quaternion), 1);
                    }
                    float arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.MathUtils), "Slerp", typeof(float), 2);
                    }
                    var ret = UnityEditor.MathUtils.Slerp(arg0, arg1, arg2);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("Slerp", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IntersectRayTriangle(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 5)
                {
                    UnityEngine.Ray arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.MathUtils), "IntersectRayTriangle", typeof(UnityEngine.Ray), 0);
                    }
                    UnityEngine.Vector3 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.MathUtils), "IntersectRayTriangle", typeof(UnityEngine.Vector3), 1);
                    }
                    UnityEngine.Vector3 arg2;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.MathUtils), "IntersectRayTriangle", typeof(UnityEngine.Vector3), 2);
                    }
                    UnityEngine.Vector3 arg3;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.MathUtils), "IntersectRayTriangle", typeof(UnityEngine.Vector3), 3);
                    }
                    bool arg4;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                    {
                        throw new ParameterException(typeof(UnityEditor.MathUtils), "IntersectRayTriangle", typeof(bool), 4);
                    }
                    var ret = UnityEditor.MathUtils.IntersectRayTriangle(arg0, arg1, arg2, arg3, arg4);
                    return QuickJS.Binding.Values.js_push_object(ctx, ret);
                }
                throw new NoSuitableMethodException("IntersectRayTriangle", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ClosestPtSegmentRay(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 6)
                {
                    UnityEngine.Vector3 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.MathUtils), "ClosestPtSegmentRay", typeof(UnityEngine.Vector3), 0);
                    }
                    UnityEngine.Vector3 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.MathUtils), "ClosestPtSegmentRay", typeof(UnityEngine.Vector3), 1);
                    }
                    UnityEngine.Ray arg2;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.MathUtils), "ClosestPtSegmentRay", typeof(UnityEngine.Ray), 2);
                    }
                    float arg3;
                    float arg4;
                    UnityEngine.Vector3 arg5;
                    var ret = UnityEditor.MathUtils.ClosestPtSegmentRay(arg0, arg1, arg2, out arg3, out arg4, out arg5);
                    var out0 = QuickJS.Binding.Values.js_push_primitive(ctx, arg3);
                    if (JSApi.JS_IsException(out0))
                    {
                        return out0;
                    }
                    var context = ScriptEngine.GetContext(ctx);
                    JSApi.JS_SetProperty(ctx, argv[3], context.GetAtom("value"), out0);
                    var out1 = QuickJS.Binding.Values.js_push_primitive(ctx, arg4);
                    if (JSApi.JS_IsException(out1))
                    {
                        return out1;
                    }
                    JSApi.JS_SetProperty(ctx, argv[4], context.GetAtom("value"), out1);
                    var out2 = QuickJS.Binding.Values.js_push_structvalue(ctx, arg5);
                    if (JSApi.JS_IsException(out2))
                    {
                        return out2;
                    }
                    JSApi.JS_SetProperty(ctx, argv[5], context.GetAtom("value"), out2);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("ClosestPtSegmentRay", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IntersectRaySphere(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 5)
                {
                    UnityEngine.Ray arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.MathUtils), "IntersectRaySphere", typeof(UnityEngine.Ray), 0);
                    }
                    UnityEngine.Vector3 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.MathUtils), "IntersectRaySphere", typeof(UnityEngine.Vector3), 1);
                    }
                    float arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.MathUtils), "IntersectRaySphere", typeof(float), 2);
                    }
                    float arg3;
                    var refVal3 = Values.js_read_wrap(ctx, argv[3]);
                    if (refVal3.IsException())
                    {
                        return refVal3;
                    }
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, refVal3, out arg3))
                    {
                        JSApi.JS_FreeValue(ctx, refVal3);
                        throw new ParameterException(typeof(UnityEditor.MathUtils), "IntersectRaySphere", typeof(float), 3);
                    }
                    JSApi.JS_FreeValue(ctx, refVal3);
                    UnityEngine.Vector3 arg4;
                    var refVal4 = Values.js_read_wrap(ctx, argv[4]);
                    if (refVal4.IsException())
                    {
                        return refVal4;
                    }
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, refVal4, out arg4))
                    {
                        JSApi.JS_FreeValue(ctx, refVal4);
                        throw new ParameterException(typeof(UnityEditor.MathUtils), "IntersectRaySphere", typeof(UnityEngine.Vector3), 4);
                    }
                    JSApi.JS_FreeValue(ctx, refVal4);
                    var ret = UnityEditor.MathUtils.IntersectRaySphere(arg0, arg1, arg2, ref arg3, ref arg4);
                    var out0 = QuickJS.Binding.Values.js_push_primitive(ctx, arg3);
                    if (JSApi.JS_IsException(out0))
                    {
                        return out0;
                    }
                    var context = ScriptEngine.GetContext(ctx);
                    JSApi.JS_SetProperty(ctx, argv[3], context.GetAtom("value"), out0);
                    var out1 = QuickJS.Binding.Values.js_push_structvalue(ctx, arg4);
                    if (JSApi.JS_IsException(out1))
                    {
                        return out1;
                    }
                    JSApi.JS_SetProperty(ctx, argv[4], context.GetAtom("value"), out1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IntersectRaySphere", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ClosestPtRaySphere(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 5)
                {
                    UnityEngine.Ray arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.MathUtils), "ClosestPtRaySphere", typeof(UnityEngine.Ray), 0);
                    }
                    UnityEngine.Vector3 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.MathUtils), "ClosestPtRaySphere", typeof(UnityEngine.Vector3), 1);
                    }
                    float arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.MathUtils), "ClosestPtRaySphere", typeof(float), 2);
                    }
                    float arg3;
                    var refVal3 = Values.js_read_wrap(ctx, argv[3]);
                    if (refVal3.IsException())
                    {
                        return refVal3;
                    }
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, refVal3, out arg3))
                    {
                        JSApi.JS_FreeValue(ctx, refVal3);
                        throw new ParameterException(typeof(UnityEditor.MathUtils), "ClosestPtRaySphere", typeof(float), 3);
                    }
                    JSApi.JS_FreeValue(ctx, refVal3);
                    UnityEngine.Vector3 arg4;
                    var refVal4 = Values.js_read_wrap(ctx, argv[4]);
                    if (refVal4.IsException())
                    {
                        return refVal4;
                    }
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, refVal4, out arg4))
                    {
                        JSApi.JS_FreeValue(ctx, refVal4);
                        throw new ParameterException(typeof(UnityEditor.MathUtils), "ClosestPtRaySphere", typeof(UnityEngine.Vector3), 4);
                    }
                    JSApi.JS_FreeValue(ctx, refVal4);
                    var ret = UnityEditor.MathUtils.ClosestPtRaySphere(arg0, arg1, arg2, ref arg3, ref arg4);
                    var out0 = QuickJS.Binding.Values.js_push_primitive(ctx, arg3);
                    if (JSApi.JS_IsException(out0))
                    {
                        return out0;
                    }
                    var context = ScriptEngine.GetContext(ctx);
                    JSApi.JS_SetProperty(ctx, argv[3], context.GetAtom("value"), out0);
                    var out1 = QuickJS.Binding.Values.js_push_structvalue(ctx, arg4);
                    if (JSApi.JS_IsException(out1))
                    {
                        return out1;
                    }
                    JSApi.JS_SetProperty(ctx, argv[4], context.GetAtom("value"), out1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("ClosestPtRaySphere", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("MathUtils", typeof(UnityEditor.MathUtils), BindConstructor);
            cls.AddMethod(true, "GetQuatLength", BindStatic_GetQuatLength);
            cls.AddMethod(true, "GetQuatConjugate", BindStatic_GetQuatConjugate);
            cls.AddMethod(true, "OrthogonalizeMatrix", BindStatic_OrthogonalizeMatrix);
            cls.AddMethod(true, "QuaternionNormalize", BindStatic_QuaternionNormalize);
            cls.AddMethod(true, "QuaternionFromMatrix", BindStatic_QuaternionFromMatrix);
            cls.AddMethod(true, "GetQuatLog", BindStatic_GetQuatLog);
            cls.AddMethod(true, "GetQuatExp", BindStatic_GetQuatExp);
            cls.AddMethod(true, "GetQuatSquad", BindStatic_GetQuatSquad);
            cls.AddMethod(true, "GetSquadIntermediate", BindStatic_GetSquadIntermediate);
            cls.AddMethod(true, "Ease", BindStatic_Ease);
            cls.AddMethod(true, "Slerp", BindStatic_Slerp);
            cls.AddMethod(true, "IntersectRayTriangle", BindStatic_IntersectRayTriangle);
            cls.AddMethod(true, "ClosestPtSegmentRay", BindStatic_ClosestPtSegmentRay);
            cls.AddMethod(true, "IntersectRaySphere", BindStatic_IntersectRaySphere);
            cls.AddMethod(true, "ClosestPtRaySphere", BindStatic_ClosestPtRaySphere);
            return cls;
        }
    }
}
#endif
#endif
