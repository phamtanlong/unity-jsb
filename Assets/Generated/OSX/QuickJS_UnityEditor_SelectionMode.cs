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
    // Type: UnityEditor.SelectionMode
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_SelectionMode
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("SelectionMode", typeof(UnityEditor.SelectionMode));
            cls.AddConstValue("Unfiltered", 0);
            cls.AddConstValue("TopLevel", 1);
            cls.AddConstValue("Deep", 2);
            cls.AddConstValue("ExcludePrefab", 4);
            cls.AddConstValue("Editable", 8);
            cls.AddConstValue("OnlyUserModifiable", 8);
            cls.AddConstValue("Assets", 16);
            cls.AddConstValue("DeepAssets", 32);
            return cls;
        }
    }
}
#endif
#endif
