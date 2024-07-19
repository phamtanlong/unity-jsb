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
    // Type: UnityEditor.FontTextureCase
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_FontTextureCase
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("FontTextureCase", typeof(UnityEditor.FontTextureCase));
            cls.AddConstValue("ASCII", 0);
            cls.AddConstValue("ASCIIUpperCase", 1);
            cls.AddConstValue("ASCIILowerCase", 2);
            cls.AddConstValue("CustomSet", 3);
            cls.AddConstValue("Dynamic", -2);
            cls.AddConstValue("Unicode", -1);
            return cls;
        }
    }
}
#endif
#endif
