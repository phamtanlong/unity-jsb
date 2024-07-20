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
    // Type: UnityEditor.HandleUtility
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_HandleUtility
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CalcLineTranslation(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 4)
                {
                    UnityEngine.Vector2 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "CalcLineTranslation", typeof(UnityEngine.Vector2), 0);
                    }
                    UnityEngine.Vector2 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "CalcLineTranslation", typeof(UnityEngine.Vector2), 1);
                    }
                    UnityEngine.Vector3 arg2;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "CalcLineTranslation", typeof(UnityEngine.Vector3), 2);
                    }
                    UnityEngine.Vector3 arg3;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "CalcLineTranslation", typeof(UnityEngine.Vector3), 3);
                    }
                    var ret = UnityEditor.HandleUtility.CalcLineTranslation(arg0, arg1, arg2, arg3);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("CalcLineTranslation", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_PointOnLineParameter(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Vector3 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "PointOnLineParameter", typeof(UnityEngine.Vector3), 0);
                    }
                    UnityEngine.Vector3 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "PointOnLineParameter", typeof(UnityEngine.Vector3), 1);
                    }
                    UnityEngine.Vector3 arg2;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "PointOnLineParameter", typeof(UnityEngine.Vector3), 2);
                    }
                    var ret = UnityEditor.HandleUtility.PointOnLineParameter(arg0, arg1, arg2);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("PointOnLineParameter", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ProjectPointLine(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Vector3 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "ProjectPointLine", typeof(UnityEngine.Vector3), 0);
                    }
                    UnityEngine.Vector3 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "ProjectPointLine", typeof(UnityEngine.Vector3), 1);
                    }
                    UnityEngine.Vector3 arg2;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "ProjectPointLine", typeof(UnityEngine.Vector3), 2);
                    }
                    var ret = UnityEditor.HandleUtility.ProjectPointLine(arg0, arg1, arg2);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("ProjectPointLine", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DistancePointLine(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Vector3 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "DistancePointLine", typeof(UnityEngine.Vector3), 0);
                    }
                    UnityEngine.Vector3 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "DistancePointLine", typeof(UnityEngine.Vector3), 1);
                    }
                    UnityEngine.Vector3 arg2;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "DistancePointLine", typeof(UnityEngine.Vector3), 2);
                    }
                    var ret = UnityEditor.HandleUtility.DistancePointLine(arg0, arg1, arg2);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("DistancePointLine", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DistanceToLine(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Vector3 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "DistanceToLine", typeof(UnityEngine.Vector3), 0);
                    }
                    UnityEngine.Vector3 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "DistanceToLine", typeof(UnityEngine.Vector3), 1);
                    }
                    var ret = UnityEditor.HandleUtility.DistanceToLine(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("DistanceToLine", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DistanceToCircle(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        UnityEditor.CameraProjectionCache arg0;
                        if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.HandleUtility), "DistanceToCircle", typeof(UnityEditor.CameraProjectionCache), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.HandleUtility), "DistanceToCircle", typeof(UnityEngine.Vector3), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.HandleUtility), "DistanceToCircle", typeof(float), 2);
                        }
                        var ret = UnityEditor.HandleUtility.DistanceToCircle(arg0, arg1, arg2);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.HandleUtility), "DistanceToCircle", typeof(UnityEngine.Vector3), 0);
                        }
                        float arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.HandleUtility), "DistanceToCircle", typeof(float), 1);
                        }
                        var ret = UnityEditor.HandleUtility.DistanceToCircle(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("DistanceToCircle", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DistanceToCone(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Vector3 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "DistanceToCone", typeof(UnityEngine.Vector3), 0);
                    }
                    UnityEngine.Quaternion arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "DistanceToCone", typeof(UnityEngine.Quaternion), 1);
                    }
                    float arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "DistanceToCone", typeof(float), 2);
                    }
                    var ret = UnityEditor.HandleUtility.DistanceToCone(arg0, arg1, arg2);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("DistanceToCone", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DistanceToCube(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Vector3 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "DistanceToCube", typeof(UnityEngine.Vector3), 0);
                    }
                    UnityEngine.Quaternion arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "DistanceToCube", typeof(UnityEngine.Quaternion), 1);
                    }
                    float arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "DistanceToCube", typeof(float), 2);
                    }
                    var ret = UnityEditor.HandleUtility.DistanceToCube(arg0, arg1, arg2);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("DistanceToCube", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DistanceToRectangle(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Vector3 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "DistanceToRectangle", typeof(UnityEngine.Vector3), 0);
                    }
                    UnityEngine.Quaternion arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "DistanceToRectangle", typeof(UnityEngine.Quaternion), 1);
                    }
                    float arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "DistanceToRectangle", typeof(float), 2);
                    }
                    var ret = UnityEditor.HandleUtility.DistanceToRectangle(arg0, arg1, arg2);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("DistanceToRectangle", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DistancePointToLine(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Vector2 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "DistancePointToLine", typeof(UnityEngine.Vector2), 0);
                    }
                    UnityEngine.Vector2 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "DistancePointToLine", typeof(UnityEngine.Vector2), 1);
                    }
                    UnityEngine.Vector2 arg2;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "DistancePointToLine", typeof(UnityEngine.Vector2), 2);
                    }
                    var ret = UnityEditor.HandleUtility.DistancePointToLine(arg0, arg1, arg2);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("DistancePointToLine", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DistancePointToLineSegment(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Vector2 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "DistancePointToLineSegment", typeof(UnityEngine.Vector2), 0);
                    }
                    UnityEngine.Vector2 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "DistancePointToLineSegment", typeof(UnityEngine.Vector2), 1);
                    }
                    UnityEngine.Vector2 arg2;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "DistancePointToLineSegment", typeof(UnityEngine.Vector2), 2);
                    }
                    var ret = UnityEditor.HandleUtility.DistancePointToLineSegment(arg0, arg1, arg2);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("DistancePointToLineSegment", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DistanceToDisc(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Vector3 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "DistanceToDisc", typeof(UnityEngine.Vector3), 0);
                    }
                    UnityEngine.Vector3 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "DistanceToDisc", typeof(UnityEngine.Vector3), 1);
                    }
                    float arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "DistanceToDisc", typeof(float), 2);
                    }
                    var ret = UnityEditor.HandleUtility.DistanceToDisc(arg0, arg1, arg2);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("DistanceToDisc", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ClosestPointToDisc(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Vector3 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "ClosestPointToDisc", typeof(UnityEngine.Vector3), 0);
                    }
                    UnityEngine.Vector3 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "ClosestPointToDisc", typeof(UnityEngine.Vector3), 1);
                    }
                    float arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "ClosestPointToDisc", typeof(float), 2);
                    }
                    var ret = UnityEditor.HandleUtility.ClosestPointToDisc(arg0, arg1, arg2);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("ClosestPointToDisc", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DistanceToArc(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 5)
                {
                    UnityEngine.Vector3 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "DistanceToArc", typeof(UnityEngine.Vector3), 0);
                    }
                    UnityEngine.Vector3 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "DistanceToArc", typeof(UnityEngine.Vector3), 1);
                    }
                    UnityEngine.Vector3 arg2;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "DistanceToArc", typeof(UnityEngine.Vector3), 2);
                    }
                    float arg3;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "DistanceToArc", typeof(float), 3);
                    }
                    float arg4;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "DistanceToArc", typeof(float), 4);
                    }
                    var ret = UnityEditor.HandleUtility.DistanceToArc(arg0, arg1, arg2, arg3, arg4);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("DistanceToArc", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ClosestPointToArc(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 5)
                {
                    UnityEngine.Vector3 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "ClosestPointToArc", typeof(UnityEngine.Vector3), 0);
                    }
                    UnityEngine.Vector3 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "ClosestPointToArc", typeof(UnityEngine.Vector3), 1);
                    }
                    UnityEngine.Vector3 arg2;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "ClosestPointToArc", typeof(UnityEngine.Vector3), 2);
                    }
                    float arg3;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "ClosestPointToArc", typeof(float), 3);
                    }
                    float arg4;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "ClosestPointToArc", typeof(float), 4);
                    }
                    var ret = UnityEditor.HandleUtility.ClosestPointToArc(arg0, arg1, arg2, arg3, arg4);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("ClosestPointToArc", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DistanceToPolyLine(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (Values.js_match_param_types(ctx, 0, argv, typeof(UnityEngine.Vector3)))
                {
                    UnityEngine.Vector3[] arg0 = null;
                    if (argc > 0)
                    {
                        arg0 = new UnityEngine.Vector3[argc];
                        for (var i = 0; i < argc; i++)
                        {
                            QuickJS.Binding.Values.js_get_structvalue(ctx, argv[i], out arg0[i]);
                        }
                    }
                    var ret = UnityEditor.HandleUtility.DistanceToPolyLine(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("DistanceToPolyLine", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ClosestPointToPolyLine(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (Values.js_match_param_types(ctx, 0, argv, typeof(UnityEngine.Vector3)))
                {
                    UnityEngine.Vector3[] arg0 = null;
                    if (argc > 0)
                    {
                        arg0 = new UnityEngine.Vector3[argc];
                        for (var i = 0; i < argc; i++)
                        {
                            QuickJS.Binding.Values.js_get_structvalue(ctx, argv[i], out arg0[i]);
                        }
                    }
                    var ret = UnityEditor.HandleUtility.ClosestPointToPolyLine(arg0);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("ClosestPointToPolyLine", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_AddControl(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "AddControl", typeof(int), 0);
                    }
                    float arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "AddControl", typeof(float), 1);
                    }
                    UnityEditor.HandleUtility.AddControl(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("AddControl", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_AddDefaultControl(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "AddDefaultControl", typeof(int), 0);
                    }
                    UnityEditor.HandleUtility.AddDefaultControl(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("AddDefaultControl", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetHandleSize(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Vector3 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "GetHandleSize", typeof(UnityEngine.Vector3), 0);
                    }
                    var ret = UnityEditor.HandleUtility.GetHandleSize(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetHandleSize", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_WorldToGUIPoint(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Vector3 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "WorldToGUIPoint", typeof(UnityEngine.Vector3), 0);
                    }
                    var ret = UnityEditor.HandleUtility.WorldToGUIPoint(arg0);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("WorldToGUIPoint", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_WorldToGUIPointWithDepth(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        UnityEngine.Camera arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.HandleUtility), "WorldToGUIPointWithDepth", typeof(UnityEngine.Camera), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.HandleUtility), "WorldToGUIPointWithDepth", typeof(UnityEngine.Vector3), 1);
                        }
                        var ret = UnityEditor.HandleUtility.WorldToGUIPointWithDepth(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.HandleUtility), "WorldToGUIPointWithDepth", typeof(UnityEngine.Vector3), 0);
                        }
                        var ret = UnityEditor.HandleUtility.WorldToGUIPointWithDepth(arg0);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("WorldToGUIPointWithDepth", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GUIPointToScreenPixelCoordinate(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Vector2 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "GUIPointToScreenPixelCoordinate", typeof(UnityEngine.Vector2), 0);
                    }
                    var ret = UnityEditor.HandleUtility.GUIPointToScreenPixelCoordinate(arg0);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GUIPointToScreenPixelCoordinate", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GUIPointToWorldRay(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Vector2 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "GUIPointToWorldRay", typeof(UnityEngine.Vector2), 0);
                    }
                    var ret = UnityEditor.HandleUtility.GUIPointToWorldRay(arg0);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GUIPointToWorldRay", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_WorldPointToSizedRect(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Vector3 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "WorldPointToSizedRect", typeof(UnityEngine.Vector3), 0);
                    }
                    UnityEngine.GUIContent arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "WorldPointToSizedRect", typeof(UnityEngine.GUIContent), 1);
                    }
                    UnityEngine.GUIStyle arg2;
                    if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "WorldPointToSizedRect", typeof(UnityEngine.GUIStyle), 2);
                    }
                    var ret = UnityEditor.HandleUtility.WorldPointToSizedRect(arg0, arg1, arg2);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("WorldPointToSizedRect", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_PickRectObjects(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.HandleUtility), "PickRectObjects", typeof(UnityEngine.Rect), 0);
                        }
                        bool arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.HandleUtility), "PickRectObjects", typeof(bool), 1);
                        }
                        var ret = UnityEditor.HandleUtility.PickRectObjects(arg0, arg1);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.HandleUtility), "PickRectObjects", typeof(UnityEngine.Rect), 0);
                        }
                        var ret = UnityEditor.HandleUtility.PickRectObjects(arg0);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("PickRectObjects", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_FindNearestVertex(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        UnityEngine.Vector2 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.HandleUtility), "FindNearestVertex", typeof(UnityEngine.Vector2), 0);
                        }
                        UnityEngine.Transform[] arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.HandleUtility), "FindNearestVertex", typeof(UnityEngine.Transform[]), 1);
                        }
                        UnityEngine.Transform[] arg2;
                        if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.HandleUtility), "FindNearestVertex", typeof(UnityEngine.Transform[]), 2);
                        }
                        UnityEngine.Vector3 arg3;
                        var ret = UnityEditor.HandleUtility.FindNearestVertex(arg0, arg1, arg2, out arg3);
                        var out0 = QuickJS.Binding.Values.js_push_structvalue(ctx, arg3);
                        if (JSApi.JS_IsException(out0))
                        {
                            return out0;
                        }
                        var context = ScriptEngine.GetContext(ctx);
                        JSApi.JS_SetProperty(ctx, argv[3], context.GetAtom("value"), out0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 3)
                    {
                        UnityEngine.Vector2 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.HandleUtility), "FindNearestVertex", typeof(UnityEngine.Vector2), 0);
                        }
                        UnityEngine.Transform[] arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.HandleUtility), "FindNearestVertex", typeof(UnityEngine.Transform[]), 1);
                        }
                        UnityEngine.Vector3 arg2;
                        var ret = UnityEditor.HandleUtility.FindNearestVertex(arg0, arg1, out arg2);
                        var out0 = QuickJS.Binding.Values.js_push_structvalue(ctx, arg2);
                        if (JSApi.JS_IsException(out0))
                        {
                            return out0;
                        }
                        var context = ScriptEngine.GetContext(ctx);
                        JSApi.JS_SetProperty(ctx, argv[2], context.GetAtom("value"), out0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Vector2 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.HandleUtility), "FindNearestVertex", typeof(UnityEngine.Vector2), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        var ret = UnityEditor.HandleUtility.FindNearestVertex(arg0, out arg1);
                        var out0 = QuickJS.Binding.Values.js_push_structvalue(ctx, arg1);
                        if (JSApi.JS_IsException(out0))
                        {
                            return out0;
                        }
                        var context = ScriptEngine.GetContext(ctx);
                        JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("FindNearestVertex", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_PickGameObject(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 5)
                    {
                        UnityEngine.Vector2 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.HandleUtility), "PickGameObject", typeof(UnityEngine.Vector2), 0);
                        }
                        bool arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.HandleUtility), "PickGameObject", typeof(bool), 1);
                        }
                        UnityEngine.GameObject[] arg2;
                        if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.HandleUtility), "PickGameObject", typeof(UnityEngine.GameObject[]), 2);
                        }
                        UnityEngine.GameObject[] arg3;
                        if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.HandleUtility), "PickGameObject", typeof(UnityEngine.GameObject[]), 3);
                        }
                        int arg4;
                        var ret = UnityEditor.HandleUtility.PickGameObject(arg0, arg1, arg2, arg3, out arg4);
                        var out0 = QuickJS.Binding.Values.js_push_primitive(ctx, arg4);
                        if (JSApi.JS_IsException(out0))
                        {
                            return out0;
                        }
                        var context = ScriptEngine.GetContext(ctx);
                        JSApi.JS_SetProperty(ctx, argv[4], context.GetAtom("value"), out0);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector2)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GameObject[])) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GameObject[])) && Values.js_match_type_hint(ctx, argv[3], typeof(int)))
                        {
                            UnityEngine.Vector2 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.HandleUtility), "PickGameObject", typeof(UnityEngine.Vector2), 0);
                            }
                            UnityEngine.GameObject[] arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.HandleUtility), "PickGameObject", typeof(UnityEngine.GameObject[]), 1);
                            }
                            UnityEngine.GameObject[] arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.HandleUtility), "PickGameObject", typeof(UnityEngine.GameObject[]), 2);
                            }
                            int arg3;
                            var ret = UnityEditor.HandleUtility.PickGameObject(arg0, arg1, arg2, out arg3);
                            var out0 = QuickJS.Binding.Values.js_push_primitive(ctx, arg3);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[3], context.GetAtom("value"), out0);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector2)) && Values.js_match_type(ctx, argv[1], typeof(bool)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GameObject[])) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GameObject[])))
                        {
                            UnityEngine.Vector2 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.HandleUtility), "PickGameObject", typeof(UnityEngine.Vector2), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.HandleUtility), "PickGameObject", typeof(bool), 1);
                            }
                            UnityEngine.GameObject[] arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.HandleUtility), "PickGameObject", typeof(UnityEngine.GameObject[]), 2);
                            }
                            UnityEngine.GameObject[] arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.HandleUtility), "PickGameObject", typeof(UnityEngine.GameObject[]), 3);
                            }
                            var ret = UnityEditor.HandleUtility.PickGameObject(arg0, arg1, arg2, arg3);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector2)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GameObject[])) && Values.js_match_type_hint(ctx, argv[2], typeof(int)))
                        {
                            UnityEngine.Vector2 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.HandleUtility), "PickGameObject", typeof(UnityEngine.Vector2), 0);
                            }
                            UnityEngine.GameObject[] arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.HandleUtility), "PickGameObject", typeof(UnityEngine.GameObject[]), 1);
                            }
                            int arg2;
                            var ret = UnityEditor.HandleUtility.PickGameObject(arg0, arg1, out arg2);
                            var out0 = QuickJS.Binding.Values.js_push_primitive(ctx, arg2);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[2], context.GetAtom("value"), out0);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector2)) && Values.js_match_type(ctx, argv[1], typeof(bool)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GameObject[])))
                        {
                            UnityEngine.Vector2 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.HandleUtility), "PickGameObject", typeof(UnityEngine.Vector2), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.HandleUtility), "PickGameObject", typeof(bool), 1);
                            }
                            UnityEngine.GameObject[] arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.HandleUtility), "PickGameObject", typeof(UnityEngine.GameObject[]), 2);
                            }
                            var ret = UnityEditor.HandleUtility.PickGameObject(arg0, arg1, arg2);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector2)) && Values.js_match_type_hint(ctx, argv[1], typeof(int)))
                        {
                            UnityEngine.Vector2 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.HandleUtility), "PickGameObject", typeof(UnityEngine.Vector2), 0);
                            }
                            int arg1;
                            var ret = UnityEditor.HandleUtility.PickGameObject(arg0, out arg1);
                            var out0 = QuickJS.Binding.Values.js_push_primitive(ctx, arg1);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out0);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector2)) && Values.js_match_type(ctx, argv[1], typeof(bool)))
                        {
                            UnityEngine.Vector2 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.HandleUtility), "PickGameObject", typeof(UnityEngine.Vector2), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.HandleUtility), "PickGameObject", typeof(bool), 1);
                            }
                            var ret = UnityEditor.HandleUtility.PickGameObject(arg0, arg1);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("PickGameObject", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_PushCamera(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Camera arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "PushCamera", typeof(UnityEngine.Camera), 0);
                    }
                    UnityEditor.HandleUtility.PushCamera(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("PushCamera", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_PopCamera(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Camera arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "PopCamera", typeof(UnityEngine.Camera), 0);
                    }
                    UnityEditor.HandleUtility.PopCamera(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("PopCamera", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RaySnap(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Ray arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "RaySnap", typeof(UnityEngine.Ray), 0);
                    }
                    var ret = UnityEditor.HandleUtility.RaySnap(arg0);
                    return QuickJS.Binding.Values.js_push_object(ctx, ret);
                }
                throw new NoSuitableMethodException("RaySnap", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_PlaceObject(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Vector2 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "PlaceObject", typeof(UnityEngine.Vector2), 0);
                    }
                    UnityEngine.Vector3 arg1;
                    UnityEngine.Vector3 arg2;
                    var ret = UnityEditor.HandleUtility.PlaceObject(arg0, out arg1, out arg2);
                    var out0 = QuickJS.Binding.Values.js_push_structvalue(ctx, arg1);
                    if (JSApi.JS_IsException(out0))
                    {
                        return out0;
                    }
                    var context = ScriptEngine.GetContext(ctx);
                    JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out0);
                    var out1 = QuickJS.Binding.Values.js_push_structvalue(ctx, arg2);
                    if (JSApi.JS_IsException(out1))
                    {
                        return out1;
                    }
                    JSApi.JS_SetProperty(ctx, argv[2], context.GetAtom("value"), out1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("PlaceObject", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Repaint(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.HandleUtility.Repaint();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Repaint", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DistancePointBezier(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 5)
                {
                    UnityEngine.Vector3 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "DistancePointBezier", typeof(UnityEngine.Vector3), 0);
                    }
                    UnityEngine.Vector3 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "DistancePointBezier", typeof(UnityEngine.Vector3), 1);
                    }
                    UnityEngine.Vector3 arg2;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "DistancePointBezier", typeof(UnityEngine.Vector3), 2);
                    }
                    UnityEngine.Vector3 arg3;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "DistancePointBezier", typeof(UnityEngine.Vector3), 3);
                    }
                    UnityEngine.Vector3 arg4;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[4], out arg4))
                    {
                        throw new ParameterException(typeof(UnityEditor.HandleUtility), "DistancePointBezier", typeof(UnityEngine.Vector3), 4);
                    }
                    var ret = UnityEditor.HandleUtility.DistancePointBezier(arg0, arg1, arg2, arg3, arg4);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("DistancePointBezier", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_acceleration(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.HandleUtility.acceleration;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_niceMouseDelta(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.HandleUtility.niceMouseDelta;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_niceMouseDeltaZoom(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.HandleUtility.niceMouseDeltaZoom;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_nearestControl(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.HandleUtility.nearestControl;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_nearestControl(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.HandleUtility), "nearestControl", typeof(int), 0);
                }
                UnityEditor.HandleUtility.nearestControl = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_handleMaterial(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.HandleUtility.handleMaterial;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticEvent_pickGameObjectCustomPasses(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                UnityEditor.HandleUtility.PickGameObjectCallback value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.HandleUtility), "pickGameObjectCustomPasses", typeof(UnityEditor.HandleUtility.PickGameObjectCallback), 1);
                        }
                        UnityEditor.HandleUtility.pickGameObjectCustomPasses += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.HandleUtility), "pickGameObjectCustomPasses", typeof(UnityEditor.HandleUtility.PickGameObjectCallback), 1);
                        }
                        UnityEditor.HandleUtility.pickGameObjectCustomPasses -= value;
                        break;
                    default: throw new JSException("invalid event op");
                }
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticEvent_placeObjectCustomPasses(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                UnityEditor.HandleUtility.PlaceObjectDelegate value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.HandleUtility), "placeObjectCustomPasses", typeof(UnityEditor.HandleUtility.PlaceObjectDelegate), 1);
                        }
                        UnityEditor.HandleUtility.placeObjectCustomPasses += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.HandleUtility), "placeObjectCustomPasses", typeof(UnityEditor.HandleUtility.PlaceObjectDelegate), 1);
                        }
                        UnityEditor.HandleUtility.placeObjectCustomPasses -= value;
                        break;
                    default: throw new JSException("invalid event op");
                }
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("HandleUtility", typeof(UnityEditor.HandleUtility), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "CalcLineTranslation", BindStatic_CalcLineTranslation);
            cls.AddMethod(true, "PointOnLineParameter", BindStatic_PointOnLineParameter);
            cls.AddMethod(true, "ProjectPointLine", BindStatic_ProjectPointLine);
            cls.AddMethod(true, "DistancePointLine", BindStatic_DistancePointLine);
            cls.AddMethod(true, "DistanceToLine", BindStatic_DistanceToLine);
            cls.AddMethod(true, "DistanceToCircle", BindStatic_DistanceToCircle);
            cls.AddMethod(true, "DistanceToCone", BindStatic_DistanceToCone);
            cls.AddMethod(true, "DistanceToCube", BindStatic_DistanceToCube);
            cls.AddMethod(true, "DistanceToRectangle", BindStatic_DistanceToRectangle);
            cls.AddMethod(true, "DistancePointToLine", BindStatic_DistancePointToLine);
            cls.AddMethod(true, "DistancePointToLineSegment", BindStatic_DistancePointToLineSegment);
            cls.AddMethod(true, "DistanceToDisc", BindStatic_DistanceToDisc);
            cls.AddMethod(true, "ClosestPointToDisc", BindStatic_ClosestPointToDisc);
            cls.AddMethod(true, "DistanceToArc", BindStatic_DistanceToArc);
            cls.AddMethod(true, "ClosestPointToArc", BindStatic_ClosestPointToArc);
            cls.AddMethod(true, "DistanceToPolyLine", BindStatic_DistanceToPolyLine);
            cls.AddMethod(true, "ClosestPointToPolyLine", BindStatic_ClosestPointToPolyLine);
            cls.AddMethod(true, "AddControl", BindStatic_AddControl);
            cls.AddMethod(true, "AddDefaultControl", BindStatic_AddDefaultControl);
            cls.AddMethod(true, "GetHandleSize", BindStatic_GetHandleSize);
            cls.AddMethod(true, "WorldToGUIPoint", BindStatic_WorldToGUIPoint);
            cls.AddMethod(true, "WorldToGUIPointWithDepth", BindStatic_WorldToGUIPointWithDepth);
            cls.AddMethod(true, "GUIPointToScreenPixelCoordinate", BindStatic_GUIPointToScreenPixelCoordinate);
            cls.AddMethod(true, "GUIPointToWorldRay", BindStatic_GUIPointToWorldRay);
            cls.AddMethod(true, "WorldPointToSizedRect", BindStatic_WorldPointToSizedRect);
            cls.AddMethod(true, "PickRectObjects", BindStatic_PickRectObjects);
            cls.AddMethod(true, "FindNearestVertex", BindStatic_FindNearestVertex);
            cls.AddMethod(true, "PickGameObject", BindStatic_PickGameObject);
            cls.AddMethod(true, "PushCamera", BindStatic_PushCamera);
            cls.AddMethod(true, "PopCamera", BindStatic_PopCamera);
            cls.AddMethod(true, "RaySnap", BindStatic_RaySnap);
            cls.AddMethod(true, "PlaceObject", BindStatic_PlaceObject);
            cls.AddMethod(true, "Repaint", BindStatic_Repaint);
            cls.AddMethod(true, "DistancePointBezier", BindStatic_DistancePointBezier);
            cls.AddProperty(true, "acceleration", BindStaticRead_acceleration, null);
            cls.AddProperty(true, "niceMouseDelta", BindStaticRead_niceMouseDelta, null);
            cls.AddProperty(true, "niceMouseDeltaZoom", BindStaticRead_niceMouseDeltaZoom, null);
            cls.AddProperty(true, "nearestControl", BindStaticRead_nearestControl, BindStaticWrite_nearestControl);
            cls.AddProperty(true, "handleMaterial", BindStaticRead_handleMaterial, null);
            cls.AddMethod(true, "pickGameObjectCustomPasses", BindStaticEvent_pickGameObjectCustomPasses);
            cls.AddMethod(true, "placeObjectCustomPasses", BindStaticEvent_placeObjectCustomPasses);
            return cls;
        }
    }
}
#endif
#endif
