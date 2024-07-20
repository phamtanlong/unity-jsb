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
    // Assembly: UnityEngine.ParticleSystemModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Applications/Unity/Hub/Editor/2021.3.37f1/Unity.app/Contents/Managed/UnityEngine/UnityEngine.ParticleSystemModule.dll
    // Type: UnityEngine.ParticleSystemSimulationSpace
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_ParticleSystemSimulationSpace
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("ParticleSystemSimulationSpace", typeof(UnityEngine.ParticleSystemSimulationSpace));
            cls.AddConstValue("Local", 0);
            cls.AddConstValue("World", 1);
            cls.AddConstValue("Custom", 2);
            return cls;
        }
    }
}
#endif
