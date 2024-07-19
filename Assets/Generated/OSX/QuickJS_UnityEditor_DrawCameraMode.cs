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
    // Type: UnityEditor.DrawCameraMode
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_DrawCameraMode
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("DrawCameraMode", typeof(UnityEditor.DrawCameraMode));
            cls.AddConstValue("Textured", 0);
            cls.AddConstValue("Wireframe", 1);
            cls.AddConstValue("TexturedWire", 2);
            cls.AddConstValue("ShadowCascades", 3);
            cls.AddConstValue("RenderPaths", 4);
            cls.AddConstValue("AlphaChannel", 5);
            cls.AddConstValue("Overdraw", 6);
            cls.AddConstValue("Mipmaps", 7);
            cls.AddConstValue("DeferredDiffuse", 8);
            cls.AddConstValue("DeferredSpecular", 9);
            cls.AddConstValue("DeferredSmoothness", 10);
            cls.AddConstValue("DeferredNormal", 11);
            cls.AddConstValue("RealtimeCharting", 12);
            cls.AddConstValue("Systems", 13);
            cls.AddConstValue("RealtimeAlbedo", 14);
            cls.AddConstValue("RealtimeEmissive", 15);
            cls.AddConstValue("RealtimeIndirect", 16);
            cls.AddConstValue("RealtimeDirectionality", 17);
            cls.AddConstValue("BakedLightmap", 18);
            cls.AddConstValue("Clustering", 19);
            cls.AddConstValue("LitClustering", 20);
            cls.AddConstValue("ValidateAlbedo", 21);
            cls.AddConstValue("ValidateMetalSpecular", 22);
            cls.AddConstValue("ShadowMasks", 23);
            cls.AddConstValue("LightOverlap", 24);
            cls.AddConstValue("BakedAlbedo", 25);
            cls.AddConstValue("BakedEmissive", 26);
            cls.AddConstValue("BakedDirectionality", 27);
            cls.AddConstValue("BakedTexelValidity", 28);
            cls.AddConstValue("BakedIndices", 29);
            cls.AddConstValue("BakedCharting", 30);
            cls.AddConstValue("SpriteMask", 31);
            cls.AddConstValue("BakedUVOverlap", 32);
            cls.AddConstValue("TextureStreaming", 33);
            cls.AddConstValue("BakedLightmapCulling", 34);
            cls.AddConstValue("UserDefined", -2147483648);
            cls.AddConstValue("Baked", -18);
            cls.AddConstValue("Directionality", -17);
            cls.AddConstValue("Irradiance", -16);
            cls.AddConstValue("Emissive", -15);
            cls.AddConstValue("Albedo", -14);
            cls.AddConstValue("Charting", -12);
            cls.AddConstValue("Normal", -1);
            return cls;
        }
    }
}
#endif
#endif
