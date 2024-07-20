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
    // Type: UnityEditor.MPE.ProcessState
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_MPE_ProcessState
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("ProcessState", typeof(UnityEditor.MPE.ProcessState));
            cls.AddConstValue("UMP_UNKNOWN_PROCESS", 0);
            cls.AddConstValue("UnknownProcess", 0);
            cls.AddConstValue("UMP_FINISHED_SUCCESSFULLY", 1);
            cls.AddConstValue("FinishedSuccessfully", 1);
            cls.AddConstValue("UMP_FINISHED_WITH_ERROR", 2);
            cls.AddConstValue("FinishedWithError", 2);
            cls.AddConstValue("UMP_RUNNING", 3);
            cls.AddConstValue("Running", 3);
            return cls;
        }
    }
}
#endif
#endif
