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
    // Type: UnityEditor.SerializedPropertyType
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_SerializedPropertyType
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("SerializedPropertyType", typeof(UnityEditor.SerializedPropertyType));
            cls.AddConstValue("Integer", 0);
            cls.AddConstValue("Boolean", 1);
            cls.AddConstValue("Float", 2);
            cls.AddConstValue("String", 3);
            cls.AddConstValue("Color", 4);
            cls.AddConstValue("ObjectReference", 5);
            cls.AddConstValue("LayerMask", 6);
            cls.AddConstValue("Enum", 7);
            cls.AddConstValue("Vector2", 8);
            cls.AddConstValue("Vector3", 9);
            cls.AddConstValue("Vector4", 10);
            cls.AddConstValue("Rect", 11);
            cls.AddConstValue("ArraySize", 12);
            cls.AddConstValue("Character", 13);
            cls.AddConstValue("AnimationCurve", 14);
            cls.AddConstValue("Bounds", 15);
            cls.AddConstValue("Gradient", 16);
            cls.AddConstValue("Quaternion", 17);
            cls.AddConstValue("ExposedReference", 18);
            cls.AddConstValue("FixedBufferSize", 19);
            cls.AddConstValue("Vector2Int", 20);
            cls.AddConstValue("Vector3Int", 21);
            cls.AddConstValue("RectInt", 22);
            cls.AddConstValue("BoundsInt", 23);
            cls.AddConstValue("ManagedReference", 24);
            cls.AddConstValue("Hash128", 25);
            cls.AddConstValue("Generic", -1);
            return cls;
        }
    }
}
#endif
#endif
