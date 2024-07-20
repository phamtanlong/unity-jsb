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
    // Assembly: UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Users/longpt/Documents/SkyMavis/unity-jsb-2021/Library/ScriptAssemblies/UnityEngine.UI.dll
    // Type: UnityEngine.UI.MaskUtilities
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_UI_MaskUtilities
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                if (argc == 0)
                {
                    var o = new UnityEngine.UI.MaskUtilities();
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
        public static JSValue BindStatic_Notify2DMaskStateChanged(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Component arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.MaskUtilities), "Notify2DMaskStateChanged", typeof(UnityEngine.Component), 0);
                    }
                    UnityEngine.UI.MaskUtilities.Notify2DMaskStateChanged(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Notify2DMaskStateChanged", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_NotifyStencilStateChanged(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Component arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.MaskUtilities), "NotifyStencilStateChanged", typeof(UnityEngine.Component), 0);
                    }
                    UnityEngine.UI.MaskUtilities.NotifyStencilStateChanged(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("NotifyStencilStateChanged", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_FindRootSortOverrideCanvas(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Transform arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.MaskUtilities), "FindRootSortOverrideCanvas", typeof(UnityEngine.Transform), 0);
                    }
                    var ret = UnityEngine.UI.MaskUtilities.FindRootSortOverrideCanvas(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("FindRootSortOverrideCanvas", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetStencilDepth(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Transform arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.MaskUtilities), "GetStencilDepth", typeof(UnityEngine.Transform), 0);
                    }
                    UnityEngine.Transform arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.MaskUtilities), "GetStencilDepth", typeof(UnityEngine.Transform), 1);
                    }
                    var ret = UnityEngine.UI.MaskUtilities.GetStencilDepth(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetStencilDepth", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsDescendantOrSelf(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Transform arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.MaskUtilities), "IsDescendantOrSelf", typeof(UnityEngine.Transform), 0);
                    }
                    UnityEngine.Transform arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.MaskUtilities), "IsDescendantOrSelf", typeof(UnityEngine.Transform), 1);
                    }
                    var ret = UnityEngine.UI.MaskUtilities.IsDescendantOrSelf(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsDescendantOrSelf", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetRectMaskForClippable(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.UI.IClippable arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.MaskUtilities), "GetRectMaskForClippable", typeof(UnityEngine.UI.IClippable), 0);
                    }
                    var ret = UnityEngine.UI.MaskUtilities.GetRectMaskForClippable(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetRectMaskForClippable", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetRectMasksForClip(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.UI.RectMask2D arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.MaskUtilities), "GetRectMasksForClip", typeof(UnityEngine.UI.RectMask2D), 0);
                    }
                    System.Collections.Generic.List<UnityEngine.UI.RectMask2D> arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.MaskUtilities), "GetRectMasksForClip", typeof(System.Collections.Generic.List<UnityEngine.UI.RectMask2D>), 1);
                    }
                    UnityEngine.UI.MaskUtilities.GetRectMasksForClip(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("GetRectMasksForClip", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("MaskUtilities", typeof(UnityEngine.UI.MaskUtilities), BindConstructor);
            cls.AddMethod(true, "Notify2DMaskStateChanged", BindStatic_Notify2DMaskStateChanged);
            cls.AddMethod(true, "NotifyStencilStateChanged", BindStatic_NotifyStencilStateChanged);
            cls.AddMethod(true, "FindRootSortOverrideCanvas", BindStatic_FindRootSortOverrideCanvas);
            cls.AddMethod(true, "GetStencilDepth", BindStatic_GetStencilDepth);
            cls.AddMethod(true, "IsDescendantOrSelf", BindStatic_IsDescendantOrSelf);
            cls.AddMethod(true, "GetRectMaskForClippable", BindStatic_GetRectMaskForClippable);
            cls.AddMethod(true, "GetRectMasksForClip", BindStatic_GetRectMasksForClip);
            return cls;
        }
    }
}
#endif
