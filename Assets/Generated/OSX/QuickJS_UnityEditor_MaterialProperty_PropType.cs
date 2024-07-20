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
    // Type: UnityEditor.MaterialProperty+PropType
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_MaterialProperty_PropType
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("PropType", typeof(UnityEditor.MaterialProperty.PropType));
            cls.AddConstValue("Color", 0);
            cls.AddConstValue("Vector", 1);
            cls.AddConstValue("Float", 2);
            cls.AddConstValue("Range", 3);
            cls.AddConstValue("Texture", 4);
            cls.AddConstValue("Int", 5);
            return cls;
        }
    }
}
#endif
#endif
