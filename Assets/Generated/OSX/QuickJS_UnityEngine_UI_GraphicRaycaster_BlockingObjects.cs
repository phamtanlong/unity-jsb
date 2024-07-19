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
    // Assembly: UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Users/longpt/Documents/SkyMavis/unity-jsb-2/Library/ScriptAssemblies/UnityEngine.UI.dll
    // Type: UnityEngine.UI.GraphicRaycaster+BlockingObjects
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_UI_GraphicRaycaster_BlockingObjects
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("BlockingObjects", typeof(UnityEngine.UI.GraphicRaycaster.BlockingObjects));
            cls.AddConstValue("None", 0);
            cls.AddConstValue("TwoD", 1);
            cls.AddConstValue("ThreeD", 2);
            cls.AddConstValue("All", 3);
            return cls;
        }
    }
}
#endif
