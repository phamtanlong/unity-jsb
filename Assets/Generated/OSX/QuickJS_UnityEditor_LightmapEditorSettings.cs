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
    // Type: UnityEditor.LightmapEditorSettings
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_LightmapEditorSettings
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_reflectionCubemapCompression(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.LightmapEditorSettings.reflectionCubemapCompression;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_reflectionCubemapCompression(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Rendering.ReflectionCubemapCompression value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.LightmapEditorSettings), "reflectionCubemapCompression", typeof(UnityEngine.Rendering.ReflectionCubemapCompression), 0);
                }
                UnityEditor.LightmapEditorSettings.reflectionCubemapCompression = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("LightmapEditorSettings", typeof(UnityEditor.LightmapEditorSettings), QuickJS.JSNative.class_private_ctor);
            cls.AddProperty(true, "reflectionCubemapCompression", BindStaticRead_reflectionCubemapCompression, BindStaticWrite_reflectionCubemapCompression);
            return cls;
        }
    }
}
#endif
#endif
