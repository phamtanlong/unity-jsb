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
    // Type: UnityEditor.XboxOneDeployDrive
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_XboxOneDeployDrive
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("XboxOneDeployDrive", typeof(UnityEditor.XboxOneDeployDrive));
            cls.AddConstValue("Default", 0);
            cls.AddConstValue("Retail", 1);
            cls.AddConstValue("Development", 2);
            cls.AddConstValue("Ext1", 3);
            cls.AddConstValue("Ext2", 4);
            cls.AddConstValue("Ext3", 5);
            cls.AddConstValue("Ext4", 6);
            cls.AddConstValue("Ext5", 7);
            cls.AddConstValue("Ext6", 8);
            cls.AddConstValue("Ext7", 9);
            return cls;
        }
    }
}
#endif
#endif
