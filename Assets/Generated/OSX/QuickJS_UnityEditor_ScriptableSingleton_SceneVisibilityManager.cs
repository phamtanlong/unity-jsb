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
    // Type: UnityEditor.ScriptableSingleton`1[[UnityEditor.SceneVisibilityManager, UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_ScriptableSingleton_SceneVisibilityManager
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_instance(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.ScriptableSingleton<UnityEditor.SceneVisibilityManager>.instance;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("ScriptableSingleton_SceneVisibilityManager", typeof(UnityEditor.ScriptableSingleton<UnityEditor.SceneVisibilityManager>), QuickJS.JSNative.class_private_ctor);
            cls.AddProperty(true, "instance", BindStaticRead_instance, null);
            return cls;
        }
    }
}
#endif
#endif
