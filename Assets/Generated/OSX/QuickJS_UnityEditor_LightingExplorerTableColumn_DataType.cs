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
    // Type: UnityEditor.LightingExplorerTableColumn+DataType
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_LightingExplorerTableColumn_DataType
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("DataType", typeof(UnityEditor.LightingExplorerTableColumn.DataType));
            cls.AddConstValue("Name", 0);
            cls.AddConstValue("Checkbox", 1);
            cls.AddConstValue("Enum", 2);
            cls.AddConstValue("Int", 3);
            cls.AddConstValue("Float", 4);
            cls.AddConstValue("Color", 5);
            cls.AddConstValue("Custom", 20);
            return cls;
        }
    }
}
#endif
#endif
