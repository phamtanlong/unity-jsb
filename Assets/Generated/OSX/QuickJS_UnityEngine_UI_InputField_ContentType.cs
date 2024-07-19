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
    // Assembly: UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Users/longpt/Documents/SkyMavis/unity-jsb-2/Library/ScriptAssemblies/UnityEngine.UI.dll
    // Type: UnityEngine.UI.InputField+ContentType
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_UI_InputField_ContentType
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("ContentType", typeof(UnityEngine.UI.InputField.ContentType));
            cls.AddConstValue("Standard", 0);
            cls.AddConstValue("Autocorrected", 1);
            cls.AddConstValue("IntegerNumber", 2);
            cls.AddConstValue("DecimalNumber", 3);
            cls.AddConstValue("Alphanumeric", 4);
            cls.AddConstValue("Name", 5);
            cls.AddConstValue("EmailAddress", 6);
            cls.AddConstValue("Password", 7);
            cls.AddConstValue("Pin", 8);
            cls.AddConstValue("Custom", 9);
            return cls;
        }
    }
}
#endif
