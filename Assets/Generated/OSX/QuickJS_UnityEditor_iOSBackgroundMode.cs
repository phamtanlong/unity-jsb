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
    // Type: UnityEditor.iOSBackgroundMode
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_iOSBackgroundMode
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("iOSBackgroundMode", typeof(UnityEditor.iOSBackgroundMode));
            cls.AddConstValue("None", 0);
            cls.AddConstValue("Audio", 1);
            cls.AddConstValue("Location", 2);
            cls.AddConstValue("VOIP", 4);
            cls.AddConstValue("NewsstandContent", 8);
            cls.AddConstValue("ExternalAccessory", 16);
            cls.AddConstValue("BluetoothCentral", 32);
            cls.AddConstValue("BluetoothPeripheral", 64);
            cls.AddConstValue("Fetch", 128);
            cls.AddConstValue("RemoteNotification", 256);
            return cls;
        }
    }
}
#endif
#endif
