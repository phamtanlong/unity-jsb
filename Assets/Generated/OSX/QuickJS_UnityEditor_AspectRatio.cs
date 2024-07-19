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
    // Type: UnityEditor.AspectRatio
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_AspectRatio
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("AspectRatio", typeof(UnityEditor.AspectRatio));
            cls.AddConstValue("AspectOthers", 0);
            cls.AddConstValue("Aspect4by3", 1);
            cls.AddConstValue("Aspect5by4", 2);
            cls.AddConstValue("Aspect16by10", 3);
            cls.AddConstValue("Aspect16by9", 4);
            return cls;
        }
    }
}
#endif
#endif
