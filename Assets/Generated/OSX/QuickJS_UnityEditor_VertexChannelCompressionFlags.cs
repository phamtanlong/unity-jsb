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
    // Type: UnityEditor.VertexChannelCompressionFlags
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_VertexChannelCompressionFlags
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("VertexChannelCompressionFlags", typeof(UnityEditor.VertexChannelCompressionFlags));
            cls.AddConstValue("None", 0);
            cls.AddConstValue("Position", 1);
            cls.AddConstValue("kPosition", 1);
            cls.AddConstValue("Normal", 2);
            cls.AddConstValue("kNormal", 2);
            cls.AddConstValue("Tangent", 4);
            cls.AddConstValue("kColor", 4);
            cls.AddConstValue("Color", 8);
            cls.AddConstValue("kUV0", 8);
            cls.AddConstValue("TexCoord0", 16);
            cls.AddConstValue("kUV1", 16);
            cls.AddConstValue("TexCoord1", 32);
            cls.AddConstValue("kUV2", 32);
            cls.AddConstValue("TexCoord2", 64);
            cls.AddConstValue("kUV3", 64);
            cls.AddConstValue("TexCoord3", 128);
            cls.AddConstValue("kTangent", 128);
            return cls;
        }
    }
}
#endif
#endif
