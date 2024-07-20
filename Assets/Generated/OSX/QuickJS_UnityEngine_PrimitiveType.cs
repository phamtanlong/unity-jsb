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
    // Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Applications/Unity/Hub/Editor/2021.3.37f1/Unity.app/Contents/Managed/UnityEngine/UnityEngine.CoreModule.dll
    // Type: UnityEngine.PrimitiveType
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_PrimitiveType
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("PrimitiveType", typeof(UnityEngine.PrimitiveType));
            cls.AddConstValue("Sphere", 0);
            cls.AddConstValue("Capsule", 1);
            cls.AddConstValue("Cylinder", 2);
            cls.AddConstValue("Cube", 3);
            cls.AddConstValue("Plane", 4);
            cls.AddConstValue("Quad", 5);
            return cls;
        }
    }
}
#endif
