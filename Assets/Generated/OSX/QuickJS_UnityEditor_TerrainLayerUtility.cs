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
    // Type: UnityEditor.TerrainLayerUtility
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_TerrainLayerUtility
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ShowTerrainLayersSelectionHelper(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Terrain arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.TerrainLayerUtility), "ShowTerrainLayersSelectionHelper", typeof(UnityEngine.Terrain), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.TerrainLayerUtility), "ShowTerrainLayersSelectionHelper", typeof(int), 1);
                    }
                    var ret = UnityEditor.TerrainLayerUtility.ShowTerrainLayersSelectionHelper(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("ShowTerrainLayersSelectionHelper", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ShowTerrainLayerGUI(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 4)
                {
                    UnityEngine.Terrain arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.TerrainLayerUtility), "ShowTerrainLayerGUI", typeof(UnityEngine.Terrain), 0);
                    }
                    UnityEngine.TerrainLayer arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.TerrainLayerUtility), "ShowTerrainLayerGUI", typeof(UnityEngine.TerrainLayer), 1);
                    }
                    UnityEditor.Editor arg2;
                    var refVal2 = Values.js_read_wrap(ctx, argv[2]);
                    if (refVal2.IsException())
                    {
                        return refVal2;
                    }
                    if (!Values.js_get_classvalue(ctx, refVal2, out arg2))
                    {
                        JSApi.JS_FreeValue(ctx, refVal2);
                        throw new ParameterException(typeof(UnityEditor.TerrainLayerUtility), "ShowTerrainLayerGUI", typeof(UnityEditor.Editor), 2);
                    }
                    JSApi.JS_FreeValue(ctx, refVal2);
                    UnityEditor.ITerrainLayerCustomUI arg3;
                    if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.TerrainLayerUtility), "ShowTerrainLayerGUI", typeof(UnityEditor.ITerrainLayerCustomUI), 3);
                    }
                    UnityEditor.TerrainLayerUtility.ShowTerrainLayerGUI(arg0, arg1, ref arg2, arg3);
                    var out0 = Values.js_push_classvalue(ctx, arg2);
                    if (JSApi.JS_IsException(out0))
                    {
                        return out0;
                    }
                    var context = ScriptEngine.GetContext(ctx);
                    JSApi.JS_SetProperty(ctx, argv[2], context.GetAtom("value"), out0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ShowTerrainLayerGUI", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ValidateDiffuseTextureUI(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Texture2D arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.TerrainLayerUtility), "ValidateDiffuseTextureUI", typeof(UnityEngine.Texture2D), 0);
                    }
                    UnityEditor.TerrainLayerUtility.ValidateDiffuseTextureUI(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ValidateDiffuseTextureUI", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CheckNormalMapTextureType(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Texture2D arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.TerrainLayerUtility), "CheckNormalMapTextureType", typeof(UnityEngine.Texture2D), 0);
                    }
                    var ret = UnityEditor.TerrainLayerUtility.CheckNormalMapTextureType(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("CheckNormalMapTextureType", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ValidateNormalMapTextureUI(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Texture2D arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.TerrainLayerUtility), "ValidateNormalMapTextureUI", typeof(UnityEngine.Texture2D), 0);
                    }
                    bool arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.TerrainLayerUtility), "ValidateNormalMapTextureUI", typeof(bool), 1);
                    }
                    UnityEditor.TerrainLayerUtility.ValidateNormalMapTextureUI(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ValidateNormalMapTextureUI", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ValidateMaskMapTextureUI(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Texture2D arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.TerrainLayerUtility), "ValidateMaskMapTextureUI", typeof(UnityEngine.Texture2D), 0);
                    }
                    UnityEditor.TerrainLayerUtility.ValidateMaskMapTextureUI(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ValidateMaskMapTextureUI", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_TilingSettingsUI(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        UnityEditor.SerializedProperty arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.TerrainLayerUtility), "TilingSettingsUI", typeof(UnityEditor.SerializedProperty), 0);
                        }
                        UnityEditor.SerializedProperty arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.TerrainLayerUtility), "TilingSettingsUI", typeof(UnityEditor.SerializedProperty), 1);
                        }
                        UnityEditor.TerrainLayerUtility.TilingSettingsUI(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 1)
                    {
                        UnityEngine.TerrainLayer arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.TerrainLayerUtility), "TilingSettingsUI", typeof(UnityEngine.TerrainLayer), 0);
                        }
                        UnityEditor.TerrainLayerUtility.TilingSettingsUI(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("TilingSettingsUI", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("TerrainLayerUtility", typeof(UnityEditor.TerrainLayerUtility), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "ShowTerrainLayersSelectionHelper", BindStatic_ShowTerrainLayersSelectionHelper);
            cls.AddMethod(true, "ShowTerrainLayerGUI", BindStatic_ShowTerrainLayerGUI);
            cls.AddMethod(true, "ValidateDiffuseTextureUI", BindStatic_ValidateDiffuseTextureUI);
            cls.AddMethod(true, "CheckNormalMapTextureType", BindStatic_CheckNormalMapTextureType);
            cls.AddMethod(true, "ValidateNormalMapTextureUI", BindStatic_ValidateNormalMapTextureUI);
            cls.AddMethod(true, "ValidateMaskMapTextureUI", BindStatic_ValidateMaskMapTextureUI);
            cls.AddMethod(true, "TilingSettingsUI", BindStatic_TilingSettingsUI);
            return cls;
        }
    }
}
#endif
#endif
