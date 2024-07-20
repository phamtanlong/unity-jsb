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
    // Type: UnityEditor.TerrainTools.TerrainPaintUtilityEditor
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_TerrainTools_TerrainPaintUtilityEditor
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ShowDefaultPreviewBrush(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Terrain arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.TerrainTools.TerrainPaintUtilityEditor), "ShowDefaultPreviewBrush", typeof(UnityEngine.Terrain), 0);
                    }
                    UnityEngine.Texture arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.TerrainTools.TerrainPaintUtilityEditor), "ShowDefaultPreviewBrush", typeof(UnityEngine.Texture), 1);
                    }
                    float arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.TerrainTools.TerrainPaintUtilityEditor), "ShowDefaultPreviewBrush", typeof(float), 2);
                    }
                    UnityEditor.TerrainTools.TerrainPaintUtilityEditor.ShowDefaultPreviewBrush(arg0, arg1, arg2);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ShowDefaultPreviewBrush", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetDefaultBrushPreviewMaterial(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.TerrainTools.TerrainPaintUtilityEditor.GetDefaultBrushPreviewMaterial();
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetDefaultBrushPreviewMaterial", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DrawBrushPreview(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 6)
                {
                    UnityEngine.TerrainTools.PaintContext arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.TerrainTools.TerrainPaintUtilityEditor), "DrawBrushPreview", typeof(UnityEngine.TerrainTools.PaintContext), 0);
                    }
                    UnityEditor.TerrainTools.TerrainBrushPreviewMode arg1;
                    if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.TerrainTools.TerrainPaintUtilityEditor), "DrawBrushPreview", typeof(UnityEditor.TerrainTools.TerrainBrushPreviewMode), 1);
                    }
                    UnityEngine.Texture arg2;
                    if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.TerrainTools.TerrainPaintUtilityEditor), "DrawBrushPreview", typeof(UnityEngine.Texture), 2);
                    }
                    UnityEngine.TerrainTools.BrushTransform arg3;
                    if (!Values.js_get_structvalue(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.TerrainTools.TerrainPaintUtilityEditor), "DrawBrushPreview", typeof(UnityEngine.TerrainTools.BrushTransform), 3);
                    }
                    UnityEngine.Material arg4;
                    if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                    {
                        throw new ParameterException(typeof(UnityEditor.TerrainTools.TerrainPaintUtilityEditor), "DrawBrushPreview", typeof(UnityEngine.Material), 4);
                    }
                    int arg5;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                    {
                        throw new ParameterException(typeof(UnityEditor.TerrainTools.TerrainPaintUtilityEditor), "DrawBrushPreview", typeof(int), 5);
                    }
                    UnityEditor.TerrainTools.TerrainPaintUtilityEditor.DrawBrushPreview(arg0, arg1, arg2, arg3, arg4, arg5);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawBrushPreview", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("TerrainPaintUtilityEditor", typeof(UnityEditor.TerrainTools.TerrainPaintUtilityEditor), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "ShowDefaultPreviewBrush", BindStatic_ShowDefaultPreviewBrush);
            cls.AddMethod(true, "GetDefaultBrushPreviewMaterial", BindStatic_GetDefaultBrushPreviewMaterial);
            cls.AddMethod(true, "DrawBrushPreview", BindStatic_DrawBrushPreview);
            return cls;
        }
    }
}
#endif
#endif
