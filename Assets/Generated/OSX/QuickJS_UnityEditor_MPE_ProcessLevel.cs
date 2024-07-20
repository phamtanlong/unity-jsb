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
    // Type: UnityEditor.MPE.ProcessLevel
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_MPE_ProcessLevel
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("ProcessLevel", typeof(UnityEditor.MPE.ProcessLevel));
            cls.AddConstValue("UMP_UNDEFINED", 0);
            cls.AddConstValue("Undefined", 0);
            cls.AddConstValue("UMP_MASTER", 1);
            cls.AddConstValue("Main", 1);
            cls.AddConstValue("UMP_SLAVE", 2);
            cls.AddConstValue("Slave", 2);
            cls.AddConstValue("Secondary", 2);
            return cls;
        }
    }
}
#endif
#endif
