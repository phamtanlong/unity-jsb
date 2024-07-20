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
    // Assembly: UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Users/longpt/Documents/SkyMavis/unity-jsb-2021/Library/ScriptAssemblies/UnityEngine.UI.dll
    // Type: UnityEngine.UI.InputField+CharacterValidation
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_UI_InputField_CharacterValidation
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("CharacterValidation", typeof(UnityEngine.UI.InputField.CharacterValidation));
            cls.AddConstValue("None", 0);
            cls.AddConstValue("Integer", 1);
            cls.AddConstValue("Decimal", 2);
            cls.AddConstValue("Alphanumeric", 3);
            cls.AddConstValue("Name", 4);
            cls.AddConstValue("EmailAddress", 5);
            return cls;
        }
    }
}
#endif
