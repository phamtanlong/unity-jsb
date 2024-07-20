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
    // Type: UnityEditor.StaticEditorFlags
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_StaticEditorFlags
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("StaticEditorFlags", typeof(UnityEditor.StaticEditorFlags));
            cls.AddConstValue("ContributeGI", 1);
            cls.AddConstValue("LightmapStatic", 1);
            cls.AddConstValue("OccluderStatic", 2);
            cls.AddConstValue("BatchingStatic", 4);
            cls.AddConstValue("NavigationStatic", 8);
            cls.AddConstValue("OccludeeStatic", 16);
            cls.AddConstValue("OffMeshLinkGeneration", 32);
            cls.AddConstValue("ReflectionProbeStatic", 64);
            return cls;
        }
    }
}
#endif
#endif
