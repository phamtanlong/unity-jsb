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
    // Type: UnityEngine.UI.AspectRatioFitter+AspectMode
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_UI_AspectRatioFitter_AspectMode
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("AspectMode", typeof(UnityEngine.UI.AspectRatioFitter.AspectMode));
            cls.AddConstValue("None", 0);
            cls.AddConstValue("WidthControlsHeight", 1);
            cls.AddConstValue("HeightControlsWidth", 2);
            cls.AddConstValue("FitInParent", 3);
            cls.AddConstValue("EnvelopeParent", 4);
            return cls;
        }
    }
}
#endif
