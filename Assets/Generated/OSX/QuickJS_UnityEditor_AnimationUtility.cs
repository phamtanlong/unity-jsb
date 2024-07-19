#if UNITY_EDITOR
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
    // Assembly: UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Applications/Unity/Hub/Editor/2019.4.40f1/Unity.app/Contents/Managed/UnityEditor.dll
    // Type: UnityEditor.AnimationUtility
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_AnimationUtility
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                if (argc == 0)
                {
                    var o = new UnityEditor.AnimationUtility();
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
        public static JSValue BindStatic_GetAnimationClips(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.GameObject arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "GetAnimationClips", typeof(UnityEngine.GameObject), 0);
                    }
                    var ret = UnityEditor.AnimationUtility.GetAnimationClips(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetAnimationClips", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetAnimationClips(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Animation arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "SetAnimationClips", typeof(UnityEngine.Animation), 0);
                    }
                    UnityEngine.AnimationClip[] arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "SetAnimationClips", typeof(UnityEngine.AnimationClip[]), 1);
                    }
                    UnityEditor.AnimationUtility.SetAnimationClips(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetAnimationClips", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetAnimatableBindings(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.GameObject arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "GetAnimatableBindings", typeof(UnityEngine.GameObject), 0);
                    }
                    UnityEngine.GameObject arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "GetAnimatableBindings", typeof(UnityEngine.GameObject), 1);
                    }
                    var ret = UnityEditor.AnimationUtility.GetAnimatableBindings(arg0, arg1);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetAnimatableBindings", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetEditorCurveValueType(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.GameObject arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "GetEditorCurveValueType", typeof(UnityEngine.GameObject), 0);
                    }
                    UnityEditor.EditorCurveBinding arg1;
                    if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "GetEditorCurveValueType", typeof(UnityEditor.EditorCurveBinding), 1);
                    }
                    var ret = UnityEditor.AnimationUtility.GetEditorCurveValueType(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetEditorCurveValueType", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetFloatValue(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.GameObject arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "GetFloatValue", typeof(UnityEngine.GameObject), 0);
                    }
                    UnityEditor.EditorCurveBinding arg1;
                    if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "GetFloatValue", typeof(UnityEditor.EditorCurveBinding), 1);
                    }
                    float arg2;
                    var ret = UnityEditor.AnimationUtility.GetFloatValue(arg0, arg1, out arg2);
                    var out0 = QuickJS.Binding.Values.js_push_primitive(ctx, arg2);
                    if (JSApi.JS_IsException(out0))
                    {
                        return out0;
                    }
                    var context = ScriptEngine.GetContext(ctx);
                    JSApi.JS_SetProperty(ctx, argv[2], context.GetAtom("value"), out0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetFloatValue", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetObjectReferenceValue(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.GameObject arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "GetObjectReferenceValue", typeof(UnityEngine.GameObject), 0);
                    }
                    UnityEditor.EditorCurveBinding arg1;
                    if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "GetObjectReferenceValue", typeof(UnityEditor.EditorCurveBinding), 1);
                    }
                    UnityEngine.Object arg2;
                    var ret = UnityEditor.AnimationUtility.GetObjectReferenceValue(arg0, arg1, out arg2);
                    var out0 = QuickJS.Binding.Values.js_push_classvalue(ctx, arg2);
                    if (JSApi.JS_IsException(out0))
                    {
                        return out0;
                    }
                    var context = ScriptEngine.GetContext(ctx);
                    JSApi.JS_SetProperty(ctx, argv[2], context.GetAtom("value"), out0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetObjectReferenceValue", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetAnimatedObject(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.GameObject arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "GetAnimatedObject", typeof(UnityEngine.GameObject), 0);
                    }
                    UnityEditor.EditorCurveBinding arg1;
                    if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "GetAnimatedObject", typeof(UnityEditor.EditorCurveBinding), 1);
                    }
                    var ret = UnityEditor.AnimationUtility.GetAnimatedObject(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetAnimatedObject", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_PropertyModificationToEditorCurveBinding(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEditor.PropertyModification arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "PropertyModificationToEditorCurveBinding", typeof(UnityEditor.PropertyModification), 0);
                    }
                    UnityEngine.GameObject arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "PropertyModificationToEditorCurveBinding", typeof(UnityEngine.GameObject), 1);
                    }
                    UnityEditor.EditorCurveBinding arg2;
                    var ret = UnityEditor.AnimationUtility.PropertyModificationToEditorCurveBinding(arg0, arg1, out arg2);
                    var out0 = Values.js_push_structvalue(ctx, arg2);
                    if (JSApi.JS_IsException(out0))
                    {
                        return out0;
                    }
                    var context = ScriptEngine.GetContext(ctx);
                    JSApi.JS_SetProperty(ctx, argv[2], context.GetAtom("value"), out0);
                    return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("PropertyModificationToEditorCurveBinding", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetCurveBindings(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.AnimationClip arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "GetCurveBindings", typeof(UnityEngine.AnimationClip), 0);
                    }
                    var ret = UnityEditor.AnimationUtility.GetCurveBindings(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetCurveBindings", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetObjectReferenceCurveBindings(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.AnimationClip arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "GetObjectReferenceCurveBindings", typeof(UnityEngine.AnimationClip), 0);
                    }
                    var ret = UnityEditor.AnimationUtility.GetObjectReferenceCurveBindings(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetObjectReferenceCurveBindings", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetObjectReferenceCurve(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.AnimationClip arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "GetObjectReferenceCurve", typeof(UnityEngine.AnimationClip), 0);
                    }
                    UnityEditor.EditorCurveBinding arg1;
                    if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "GetObjectReferenceCurve", typeof(UnityEditor.EditorCurveBinding), 1);
                    }
                    var ret = UnityEditor.AnimationUtility.GetObjectReferenceCurve(arg0, arg1);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetObjectReferenceCurve", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetObjectReferenceCurve(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.AnimationClip arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "SetObjectReferenceCurve", typeof(UnityEngine.AnimationClip), 0);
                    }
                    UnityEditor.EditorCurveBinding arg1;
                    if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "SetObjectReferenceCurve", typeof(UnityEditor.EditorCurveBinding), 1);
                    }
                    UnityEditor.ObjectReferenceKeyframe[] arg2;
                    if (!Values.js_get_structvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "SetObjectReferenceCurve", typeof(UnityEditor.ObjectReferenceKeyframe[]), 2);
                    }
                    UnityEditor.AnimationUtility.SetObjectReferenceCurve(arg0, arg1, arg2);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetObjectReferenceCurve", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetEditorCurve(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.AnimationClip arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "GetEditorCurve", typeof(UnityEngine.AnimationClip), 0);
                    }
                    UnityEditor.EditorCurveBinding arg1;
                    if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "GetEditorCurve", typeof(UnityEditor.EditorCurveBinding), 1);
                    }
                    var ret = UnityEditor.AnimationUtility.GetEditorCurve(arg0, arg1);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetEditorCurve", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetEditorCurve(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.AnimationClip arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "SetEditorCurve", typeof(UnityEngine.AnimationClip), 0);
                    }
                    UnityEditor.EditorCurveBinding arg1;
                    if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "SetEditorCurve", typeof(UnityEditor.EditorCurveBinding), 1);
                    }
                    UnityEngine.AnimationCurve arg2;
                    if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "SetEditorCurve", typeof(UnityEngine.AnimationCurve), 2);
                    }
                    UnityEditor.AnimationUtility.SetEditorCurve(arg0, arg1, arg2);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetEditorCurve", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetKeyLeftTangentMode(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.AnimationCurve arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "GetKeyLeftTangentMode", typeof(UnityEngine.AnimationCurve), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "GetKeyLeftTangentMode", typeof(int), 1);
                    }
                    var ret = UnityEditor.AnimationUtility.GetKeyLeftTangentMode(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
                }
                throw new NoSuitableMethodException("GetKeyLeftTangentMode", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetKeyRightTangentMode(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.AnimationCurve arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "GetKeyRightTangentMode", typeof(UnityEngine.AnimationCurve), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "GetKeyRightTangentMode", typeof(int), 1);
                    }
                    var ret = UnityEditor.AnimationUtility.GetKeyRightTangentMode(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
                }
                throw new NoSuitableMethodException("GetKeyRightTangentMode", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetKeyBroken(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.AnimationCurve arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "GetKeyBroken", typeof(UnityEngine.AnimationCurve), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "GetKeyBroken", typeof(int), 1);
                    }
                    var ret = UnityEditor.AnimationUtility.GetKeyBroken(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetKeyBroken", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetKeyLeftTangentMode(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.AnimationCurve arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "SetKeyLeftTangentMode", typeof(UnityEngine.AnimationCurve), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "SetKeyLeftTangentMode", typeof(int), 1);
                    }
                    UnityEditor.AnimationUtility.TangentMode arg2;
                    if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "SetKeyLeftTangentMode", typeof(UnityEditor.AnimationUtility.TangentMode), 2);
                    }
                    UnityEditor.AnimationUtility.SetKeyLeftTangentMode(arg0, arg1, arg2);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetKeyLeftTangentMode", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetKeyRightTangentMode(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.AnimationCurve arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "SetKeyRightTangentMode", typeof(UnityEngine.AnimationCurve), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "SetKeyRightTangentMode", typeof(int), 1);
                    }
                    UnityEditor.AnimationUtility.TangentMode arg2;
                    if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "SetKeyRightTangentMode", typeof(UnityEditor.AnimationUtility.TangentMode), 2);
                    }
                    UnityEditor.AnimationUtility.SetKeyRightTangentMode(arg0, arg1, arg2);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetKeyRightTangentMode", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetKeyBroken(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.AnimationCurve arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "SetKeyBroken", typeof(UnityEngine.AnimationCurve), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "SetKeyBroken", typeof(int), 1);
                    }
                    bool arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "SetKeyBroken", typeof(bool), 2);
                    }
                    UnityEditor.AnimationUtility.SetKeyBroken(arg0, arg1, arg2);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetKeyBroken", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetAnimationEvents(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.AnimationClip arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "GetAnimationEvents", typeof(UnityEngine.AnimationClip), 0);
                    }
                    var ret = UnityEditor.AnimationUtility.GetAnimationEvents(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetAnimationEvents", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetAnimationEvents(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.AnimationClip arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "SetAnimationEvents", typeof(UnityEngine.AnimationClip), 0);
                    }
                    UnityEngine.AnimationEvent[] arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "SetAnimationEvents", typeof(UnityEngine.AnimationEvent[]), 1);
                    }
                    UnityEditor.AnimationUtility.SetAnimationEvents(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetAnimationEvents", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CalculateTransformPath(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Transform arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "CalculateTransformPath", typeof(UnityEngine.Transform), 0);
                    }
                    UnityEngine.Transform arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "CalculateTransformPath", typeof(UnityEngine.Transform), 1);
                    }
                    var ret = UnityEditor.AnimationUtility.CalculateTransformPath(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("CalculateTransformPath", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetAnimationClipSettings(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.AnimationClip arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "GetAnimationClipSettings", typeof(UnityEngine.AnimationClip), 0);
                    }
                    var ret = UnityEditor.AnimationUtility.GetAnimationClipSettings(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetAnimationClipSettings", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetAnimationClipSettings(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.AnimationClip arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "SetAnimationClipSettings", typeof(UnityEngine.AnimationClip), 0);
                    }
                    UnityEditor.AnimationClipSettings arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "SetAnimationClipSettings", typeof(UnityEditor.AnimationClipSettings), 1);
                    }
                    UnityEditor.AnimationUtility.SetAnimationClipSettings(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetAnimationClipSettings", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetAdditiveReferencePose(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.AnimationClip arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "SetAdditiveReferencePose", typeof(UnityEngine.AnimationClip), 0);
                    }
                    UnityEngine.AnimationClip arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "SetAdditiveReferencePose", typeof(UnityEngine.AnimationClip), 1);
                    }
                    float arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "SetAdditiveReferencePose", typeof(float), 2);
                    }
                    UnityEditor.AnimationUtility.SetAdditiveReferencePose(arg0, arg1, arg2);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetAdditiveReferencePose", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ConstrainToPolynomialCurve(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.AnimationCurve arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationUtility), "ConstrainToPolynomialCurve", typeof(UnityEngine.AnimationCurve), 0);
                    }
                    UnityEditor.AnimationUtility.ConstrainToPolynomialCurve(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ConstrainToPolynomialCurve", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticDelegate_onCurveWasModified(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                    {
                        UnityEditor.AnimationUtility.OnCurveWasModified value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.AnimationUtility), "onCurveWasModified", typeof(UnityEditor.AnimationUtility.OnCurveWasModified), 1);
                        }
                        UnityEditor.AnimationUtility.onCurveWasModified += value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_REMOVE:
                    {
                        UnityEditor.AnimationUtility.OnCurveWasModified value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.AnimationUtility), "onCurveWasModified", typeof(UnityEditor.AnimationUtility.OnCurveWasModified), 1);
                        }
                        UnityEditor.AnimationUtility.onCurveWasModified -= value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_SET:
                    {
                        UnityEditor.AnimationUtility.OnCurveWasModified value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.AnimationUtility), "onCurveWasModified", typeof(UnityEditor.AnimationUtility.OnCurveWasModified), 1);
                        }
                        UnityEditor.AnimationUtility.onCurveWasModified = value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_GET:
                    {
                        var ret = UnityEditor.AnimationUtility.onCurveWasModified;
                        return Values.js_push_delegate(ctx, ret);
                    }
                    default: throw new JSException("invalid event op");
                }
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("AnimationUtility", typeof(UnityEditor.AnimationUtility), BindConstructor);
            cls.AddMethod(true, "GetAnimationClips", BindStatic_GetAnimationClips);
            cls.AddMethod(true, "SetAnimationClips", BindStatic_SetAnimationClips);
            cls.AddMethod(true, "GetAnimatableBindings", BindStatic_GetAnimatableBindings);
            cls.AddMethod(true, "GetEditorCurveValueType", BindStatic_GetEditorCurveValueType);
            cls.AddMethod(true, "GetFloatValue", BindStatic_GetFloatValue);
            cls.AddMethod(true, "GetObjectReferenceValue", BindStatic_GetObjectReferenceValue);
            cls.AddMethod(true, "GetAnimatedObject", BindStatic_GetAnimatedObject);
            cls.AddMethod(true, "PropertyModificationToEditorCurveBinding", BindStatic_PropertyModificationToEditorCurveBinding);
            cls.AddMethod(true, "GetCurveBindings", BindStatic_GetCurveBindings);
            cls.AddMethod(true, "GetObjectReferenceCurveBindings", BindStatic_GetObjectReferenceCurveBindings);
            cls.AddMethod(true, "GetObjectReferenceCurve", BindStatic_GetObjectReferenceCurve);
            cls.AddMethod(true, "SetObjectReferenceCurve", BindStatic_SetObjectReferenceCurve);
            cls.AddMethod(true, "GetEditorCurve", BindStatic_GetEditorCurve);
            cls.AddMethod(true, "SetEditorCurve", BindStatic_SetEditorCurve);
            cls.AddMethod(true, "GetKeyLeftTangentMode", BindStatic_GetKeyLeftTangentMode);
            cls.AddMethod(true, "GetKeyRightTangentMode", BindStatic_GetKeyRightTangentMode);
            cls.AddMethod(true, "GetKeyBroken", BindStatic_GetKeyBroken);
            cls.AddMethod(true, "SetKeyLeftTangentMode", BindStatic_SetKeyLeftTangentMode);
            cls.AddMethod(true, "SetKeyRightTangentMode", BindStatic_SetKeyRightTangentMode);
            cls.AddMethod(true, "SetKeyBroken", BindStatic_SetKeyBroken);
            cls.AddMethod(true, "GetAnimationEvents", BindStatic_GetAnimationEvents);
            cls.AddMethod(true, "SetAnimationEvents", BindStatic_SetAnimationEvents);
            cls.AddMethod(true, "CalculateTransformPath", BindStatic_CalculateTransformPath);
            cls.AddMethod(true, "GetAnimationClipSettings", BindStatic_GetAnimationClipSettings);
            cls.AddMethod(true, "SetAnimationClipSettings", BindStatic_SetAnimationClipSettings);
            cls.AddMethod(true, "SetAdditiveReferencePose", BindStatic_SetAdditiveReferencePose);
            cls.AddMethod(true, "ConstrainToPolynomialCurve", BindStatic_ConstrainToPolynomialCurve);
            cls.AddMethod(true, "onCurveWasModified", BindStaticDelegate_onCurveWasModified);
            return cls;
        }
    }
}
#endif
#endif
