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
    // Type: UnityEditor.TextureImporterFormat
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_TextureImporterFormat
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("TextureImporterFormat", typeof(UnityEditor.TextureImporterFormat));
            cls.AddConstValue("Alpha8", 1);
            cls.AddConstValue("ARGB16", 2);
            cls.AddConstValue("RGB24", 3);
            cls.AddConstValue("RGBA32", 4);
            cls.AddConstValue("ARGB32", 5);
            cls.AddConstValue("RGB16", 7);
            cls.AddConstValue("R16", 9);
            cls.AddConstValue("DXT1", 10);
            cls.AddConstValue("DXT5", 12);
            cls.AddConstValue("RGBA16", 13);
            cls.AddConstValue("RHalf", 15);
            cls.AddConstValue("RGHalf", 16);
            cls.AddConstValue("RGBAHalf", 17);
            cls.AddConstValue("RFloat", 18);
            cls.AddConstValue("RGFloat", 19);
            cls.AddConstValue("RGBAFloat", 20);
            cls.AddConstValue("RGB9E5", 22);
            cls.AddConstValue("BC6H", 24);
            cls.AddConstValue("BC7", 25);
            cls.AddConstValue("BC4", 26);
            cls.AddConstValue("BC5", 27);
            cls.AddConstValue("DXT1Crunched", 28);
            cls.AddConstValue("DXT5Crunched", 29);
            cls.AddConstValue("PVRTC_RGB2", 30);
            cls.AddConstValue("PVRTC_RGBA2", 31);
            cls.AddConstValue("PVRTC_RGB4", 32);
            cls.AddConstValue("PVRTC_RGBA4", 33);
            cls.AddConstValue("ETC_RGB4", 34);
            cls.AddConstValue("ATC_RGB4", 35);
            cls.AddConstValue("ATC_RGBA8", 36);
            cls.AddConstValue("EAC_R", 41);
            cls.AddConstValue("EAC_R_SIGNED", 42);
            cls.AddConstValue("EAC_RG", 43);
            cls.AddConstValue("EAC_RG_SIGNED", 44);
            cls.AddConstValue("ETC2_RGB4", 45);
            cls.AddConstValue("ETC2_RGB4_PUNCHTHROUGH_ALPHA", 46);
            cls.AddConstValue("ETC2_RGBA8", 47);
            cls.AddConstValue("ASTC_RGB_4x4", 48);
            cls.AddConstValue("ASTC_4x4", 48);
            cls.AddConstValue("ASTC_RGB_5x5", 49);
            cls.AddConstValue("ASTC_5x5", 49);
            cls.AddConstValue("ASTC_RGB_6x6", 50);
            cls.AddConstValue("ASTC_6x6", 50);
            cls.AddConstValue("ASTC_RGB_8x8", 51);
            cls.AddConstValue("ASTC_8x8", 51);
            cls.AddConstValue("ASTC_10x10", 52);
            cls.AddConstValue("ASTC_RGB_10x10", 52);
            cls.AddConstValue("ASTC_12x12", 53);
            cls.AddConstValue("ASTC_RGB_12x12", 53);
            cls.AddConstValue("ASTC_RGBA_4x4", 54);
            cls.AddConstValue("ASTC_RGBA_5x5", 55);
            cls.AddConstValue("ASTC_RGBA_6x6", 56);
            cls.AddConstValue("ASTC_RGBA_8x8", 57);
            cls.AddConstValue("ASTC_RGBA_10x10", 58);
            cls.AddConstValue("ASTC_RGBA_12x12", 59);
            cls.AddConstValue("ETC_RGB4_3DS", 60);
            cls.AddConstValue("ETC_RGBA8_3DS", 61);
            cls.AddConstValue("RG16", 62);
            cls.AddConstValue("R8", 63);
            cls.AddConstValue("ETC_RGB4Crunched", 64);
            cls.AddConstValue("ETC2_RGBA8Crunched", 65);
            cls.AddConstValue("ASTC_HDR_4x4", 66);
            cls.AddConstValue("ASTC_HDR_5x5", 67);
            cls.AddConstValue("ASTC_HDR_6x6", 68);
            cls.AddConstValue("ASTC_HDR_8x8", 69);
            cls.AddConstValue("ASTC_HDR_10x10", 70);
            cls.AddConstValue("ASTC_HDR_12x12", 71);
            cls.AddConstValue("RG32", 72);
            cls.AddConstValue("RGB48", 73);
            cls.AddConstValue("RGBA64", 74);
            cls.AddConstValue("AutomaticCompressedHDR", -7);
            cls.AddConstValue("AutomaticHDR", -6);
            cls.AddConstValue("AutomaticCrunched", -5);
            cls.AddConstValue("AutomaticTruecolor", -3);
            cls.AddConstValue("Automatic16bit", -2);
            cls.AddConstValue("AutomaticCompressed", -1);
            cls.AddConstValue("Automatic", -1);
            return cls;
        }
    }
}
#endif
#endif
