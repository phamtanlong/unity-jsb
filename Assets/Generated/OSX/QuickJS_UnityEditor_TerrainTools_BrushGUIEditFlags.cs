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
    // Type: UnityEditor.TerrainTools.BrushGUIEditFlags
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_TerrainTools_BrushGUIEditFlags
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("BrushGUIEditFlags", typeof(UnityEditor.TerrainTools.BrushGUIEditFlags));
            cls.AddConstValue("None", 0);
            cls.AddConstValue("Select", 1);
            cls.AddConstValue("Inspect", 2);
            cls.AddConstValue("SelectAndInspect", 3);
            cls.AddConstValue("Size", 4);
            cls.AddConstValue("Opacity", 8);
            cls.AddConstValue("All", 15);
            return cls;
        }
    }
}
#endif
#endif
