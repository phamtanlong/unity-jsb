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
    // Type: UnityEditor.CommandHint
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_CommandHint
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("CommandHint", typeof(UnityEditor.CommandHint));
            cls.AddConstValue("None", 0);
            cls.AddConstValue("Event", 1);
            cls.AddConstValue("Menu", 2);
            cls.AddConstValue("Shortcut", 4);
            cls.AddConstValue("Shelf", 8);
            cls.AddConstValue("UI", 1048576);
            cls.AddConstValue("OnGUI", 3145728);
            cls.AddConstValue("UIElements", 5242880);
            cls.AddConstValue("Validate", 1073741824);
            cls.AddConstValue("UserDefined", -2147483648);
            cls.AddConstValue("Undefined", -1);
            cls.AddConstValue("Any", -1);
            return cls;
        }
    }
}
#endif
#endif
