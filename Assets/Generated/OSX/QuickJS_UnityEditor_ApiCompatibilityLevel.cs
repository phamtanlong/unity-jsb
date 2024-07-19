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
    // Type: UnityEditor.ApiCompatibilityLevel
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_ApiCompatibilityLevel
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("ApiCompatibilityLevel", typeof(UnityEditor.ApiCompatibilityLevel));
            cls.AddConstValue("NET_2_0", 1);
            cls.AddConstValue("NET_2_0_Subset", 2);
            cls.AddConstValue("NET_4_6", 3);
            cls.AddConstValue("NET_Web", 4);
            cls.AddConstValue("NET_Micro", 5);
            cls.AddConstValue("NET_Standard_2_0", 6);
            return cls;
        }
    }
}
#endif
#endif
