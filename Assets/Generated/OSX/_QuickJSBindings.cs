#if UNITY_STANDALONE_OSX
// Unity: 2019.4.40f1
using System;
using System.Collections.Generic;

// Special: _QuickJSBindings
namespace jsb.gen {
    using QuickJS.Errors;
    using JSValue = QuickJS.Native.JSValue;
    using JSApi = QuickJS.Native.JSApi;
    using JSNative = QuickJS.JSNative;
    using JSContext = QuickJS.Native.JSContext;
    using Values = QuickJS.Binding.Values;
    using ScriptEngine = QuickJS.ScriptEngine;
    using JSBindingAttribute = QuickJS.JSBindingAttribute;
    using MonoPInvokeCallbackAttribute = QuickJS.MonoPInvokeCallbackAttribute;
    using ScriptRuntime = QuickJS.ScriptRuntime;
    [UnityEngine.Scripting.Preserve]
    public class StaticBinder
    {
        public const uint CodeGenVersion = 1997;
        public const string Vendor = "";
        private static void BindAll(ScriptRuntime runtime)
        {
            Values.register_type_caster<Example.Jankfest>(Example.ValueTest.js_get_classvalue);
            Values.register_type_caster<Example.Jankfest>(Example.ValueTest.js_push_classvalue);
            runtime.AddStaticModuleProxy("UnityEngine", (rt, module) =>
            {
                runtime.AddTypeReference(module, typeof(UnityEngine.ParticleSystem), jsb.QuickJS_UnityEngine_ParticleSystem.Bind, "ParticleSystem");
                runtime.AddTypeReference(module, typeof(UnityEngine.ParticleSystemRenderer), jsb.QuickJS_UnityEngine_ParticleSystemRenderer.Bind, "ParticleSystemRenderer");
                runtime.AddTypeReference(module, typeof(UnityEngine.ParticleSystem.MainModule), jsb.QuickJS_UnityEngine_ParticleSystem_MainModule.Bind, "ParticleSystem", "MainModule");
                runtime.AddTypeReference(module, typeof(UnityEngine.ParticleSystemSimulationSpace), jsb.QuickJS_UnityEngine_ParticleSystemSimulationSpace.Bind, "ParticleSystemSimulationSpace");
                runtime.AddTypeReference(module, typeof(UnityEngine.LayerMask), jsb.QuickJS_UnityEngine_LayerMask.Bind, "LayerMask");
                runtime.AddTypeReference(module, typeof(UnityEngine.Color), jsb.QuickJS_UnityEngine_Color.Bind, "Color");
                runtime.AddTypeReference(module, typeof(UnityEngine.Color32), jsb.QuickJS_UnityEngine_Color32.Bind, "Color32");
                runtime.AddTypeReference(module, typeof(UnityEngine.Vector2), jsb.QuickJS_UnityEngine_Vector2.Bind, "Vector2");
                runtime.AddTypeReference(module, typeof(UnityEngine.Vector2Int), jsb.QuickJS_UnityEngine_Vector2Int.Bind, "Vector2Int");
                runtime.AddTypeReference(module, typeof(UnityEngine.Vector3), jsb.QuickJS_UnityEngine_Vector3.Bind, "Vector3");
                runtime.AddTypeReference(module, typeof(UnityEngine.Vector3Int), jsb.QuickJS_UnityEngine_Vector3Int.Bind, "Vector3Int");
                runtime.AddTypeReference(module, typeof(UnityEngine.Vector4), jsb.QuickJS_UnityEngine_Vector4.Bind, "Vector4");
                runtime.AddTypeReference(module, typeof(UnityEngine.Rect), jsb.QuickJS_UnityEngine_Rect.Bind, "Rect");
                runtime.AddTypeReference(module, typeof(UnityEngine.Quaternion), jsb.QuickJS_UnityEngine_Quaternion.Bind, "Quaternion");
                runtime.AddTypeReference(module, typeof(UnityEngine.Matrix4x4), jsb.QuickJS_UnityEngine_Matrix4x4.Bind, "Matrix4x4");
                runtime.AddTypeReference(module, typeof(UnityEngine.PrimitiveType), jsb.QuickJS_UnityEngine_PrimitiveType.Bind, "PrimitiveType");
                runtime.AddTypeReference(module, typeof(UnityEngine.Object), jsb.QuickJS_UnityEngine_Object.Bind, "Object");
                runtime.AddTypeReference(module, typeof(UnityEngine.KeyCode), jsb.QuickJS_UnityEngine_KeyCode.Bind, "KeyCode");
                runtime.AddTypeReference(module, typeof(UnityEngine.Texture), jsb.QuickJS_UnityEngine_Texture.Bind, "Texture");
                runtime.AddTypeReference(module, typeof(UnityEngine.Texture2D), jsb.QuickJS_UnityEngine_Texture2D.Bind, "Texture2D");
                runtime.AddTypeReference(module, typeof(UnityEngine.Material), jsb.QuickJS_UnityEngine_Material.Bind, "Material");
                runtime.AddTypeReference(module, typeof(UnityEngine.Time), jsb.QuickJS_UnityEngine_Time.Bind, "Time");
                // runtime.AddTypeReference(module, typeof(UnityEngine.Random), jsb.QuickJS_UnityEngine_Random.Bind, "Random");
                runtime.AddTypeReference(module, typeof(UnityEngine.GameObject), jsb.QuickJS_UnityEngine_GameObject.Bind, "GameObject");
                runtime.AddTypeReference(module, typeof(UnityEngine.Camera), jsb.QuickJS_UnityEngine_Camera.Bind, "Camera");
                runtime.AddTypeReference(module, typeof(UnityEngine.Behaviour), jsb.QuickJS_UnityEngine_Behaviour.Bind, "Behaviour");
                runtime.AddTypeReference(module, typeof(UnityEngine.Component), jsb.QuickJS_UnityEngine_Component.Bind, "Component");
                runtime.AddTypeReference(module, typeof(UnityEngine.Transform), jsb.QuickJS_UnityEngine_Transform.Bind, "Transform");
                runtime.AddTypeReference(module, typeof(UnityEngine.RectTransform), jsb.QuickJS_UnityEngine_RectTransform.Bind, "RectTransform");
                runtime.AddTypeReference(module, typeof(UnityEngine.MonoBehaviour), jsb.QuickJS_UnityEngine_MonoBehaviour.Bind, "MonoBehaviour");
                runtime.AddTypeReference(module, typeof(UnityEngine.ScriptableObject), jsb.QuickJS_UnityEngine_ScriptableObject.Bind, "ScriptableObject");
                runtime.AddTypeReference(module, typeof(UnityEngine.Sprite), jsb.QuickJS_UnityEngine_Sprite.Bind, "Sprite");
                runtime.AddTypeReference(module, typeof(UnityEngine.SpriteRenderer), jsb.QuickJS_UnityEngine_SpriteRenderer.Bind, "SpriteRenderer");
                runtime.AddTypeReference(module, typeof(UnityEngine.Renderer), jsb.QuickJS_UnityEngine_Renderer.Bind, "Renderer");
                runtime.AddTypeReference(module, typeof(UnityEngine.Animation), jsb.QuickJS_UnityEngine_Animation.Bind, "Animation");
                runtime.AddTypeReference(module, typeof(UnityEngine.AnimationClip), jsb.QuickJS_UnityEngine_AnimationClip.Bind, "AnimationClip");
                runtime.AddTypeReference(module, typeof(UnityEngine.Motion), jsb.QuickJS_UnityEngine_Motion.Bind, "Motion");
                runtime.AddTypeReference(module, typeof(UnityEngine.Animator), jsb.QuickJS_UnityEngine_Animator.Bind, "Animator");
                runtime.AddTypeReference(module, typeof(UnityEngine.AnimationState), jsb.QuickJS_UnityEngine_AnimationState.Bind, "AnimationState");
                runtime.AddTypeReference(module, typeof(UnityEngine.TrackedReference), jsb.QuickJS_UnityEngine_TrackedReference.Bind, "TrackedReference");
                runtime.AddTypeReference(module, typeof(UnityEngine.WrapMode), jsb.QuickJS_UnityEngine_WrapMode.Bind, "WrapMode");
                runtime.AddTypeReference(module, typeof(UnityEngine.Debug), jsb.QuickJS_UnityEngine_Debug.Bind, "Debug");
                runtime.AddTypeReference(module, typeof(UnityEngine.WaitForSeconds), jsb.QuickJS_UnityEngine_WaitForSeconds.Bind, "WaitForSeconds");
                runtime.AddTypeReference(module, typeof(UnityEngine.YieldInstruction), jsb.QuickJS_UnityEngine_YieldInstruction.Bind, "YieldInstruction");
                runtime.AddTypeReference(module, typeof(UnityEngine.WaitForEndOfFrame), jsb.QuickJS_UnityEngine_WaitForEndOfFrame.Bind, "WaitForEndOfFrame");
                runtime.AddTypeReference(module, typeof(UnityEngine.Input), jsb.QuickJS_UnityEngine_Input.Bind, "Input");
                runtime.AddTypeReference(module, typeof(UnityEngine.Application), jsb.QuickJS_UnityEngine_Application.Bind, "Application");
                runtime.AddTypeReference(module, typeof(UnityEngine.Ray), jsb.QuickJS_UnityEngine_Ray.Bind, "Ray");
                runtime.AddTypeReference(module, typeof(UnityEngine.RaycastHit), jsb.QuickJS_UnityEngine_RaycastHit.Bind, "RaycastHit");
                runtime.AddTypeReference(module, typeof(UnityEngine.Physics), jsb.QuickJS_UnityEngine_Physics.Bind, "Physics");
                runtime.AddTypeReference(module, typeof(UnityEngine.Collider), jsb.QuickJS_UnityEngine_Collider.Bind, "Collider");
                runtime.AddTypeReference(module, typeof(UnityEngine.BoxCollider), jsb.QuickJS_UnityEngine_BoxCollider.Bind, "BoxCollider");
                runtime.AddTypeReference(module, typeof(UnityEngine.SphereCollider), jsb.QuickJS_UnityEngine_SphereCollider.Bind, "SphereCollider");
                runtime.AddTypeReference(module, typeof(UnityEngine.Rigidbody), jsb.QuickJS_UnityEngine_Rigidbody.Bind, "Rigidbody");
                runtime.AddTypeReference(module, typeof(UnityEngine.Resources), jsb.QuickJS_UnityEngine_Resources.Bind, "Resources");
                runtime.AddTypeReference(module, typeof(UnityEngine.GUI), jsb.QuickJS_UnityEngine_GUI.Bind, "GUI");
                runtime.AddTypeReference(module, typeof(UnityEngine.GUIUtility), jsb.QuickJS_UnityEngine_GUIUtility.Bind, "GUIUtility");
                runtime.AddTypeReference(module, typeof(UnityEngine.GUILayout), jsb.QuickJS_UnityEngine_GUILayout.Bind, "GUILayout");
                runtime.AddTypeReference(module, typeof(UnityEngine.GUILayoutUtility), jsb.QuickJS_UnityEngine_GUILayoutUtility.Bind, "GUILayoutUtility");
                runtime.AddTypeReference(module, typeof(UnityEngine.GUILayoutOption), jsb.QuickJS_UnityEngine_GUILayoutOption.Bind, "GUILayoutOption");
                runtime.AddTypeReference(module, typeof(UnityEngine.GUIContent), jsb.QuickJS_UnityEngine_GUIContent.Bind, "GUIContent");
                runtime.AddTypeReference(module, typeof(UnityEngine.GUISkin), jsb.QuickJS_UnityEngine_GUISkin.Bind, "GUISkin");
                runtime.AddTypeReference(module, typeof(UnityEngine.GUIStyle), jsb.QuickJS_UnityEngine_GUIStyle.Bind, "GUIStyle");
                runtime.AddTypeReference(module, typeof(UnityEngine.TextAnchor), jsb.QuickJS_UnityEngine_TextAnchor.Bind, "TextAnchor");
                runtime.AddTypeReference(module, typeof(UnityEngine.ScaleMode), jsb.QuickJS_UnityEngine_ScaleMode.Bind, "ScaleMode");
                runtime.AddTypeReference(module, typeof(UnityEngine.FocusType), jsb.QuickJS_UnityEngine_FocusType.Bind, "FocusType");
                runtime.AddTypeReference(module, typeof(UnityEngine.AudioClip), jsb.QuickJS_UnityEngine_AudioClip.Bind, "AudioClip");
                runtime.AddTypeReference(module, typeof(UnityEngine.RectInt), jsb.QuickJS_UnityEngine_RectInt.Bind, "RectInt");
                runtime.AddTypeReference(module, typeof(UnityEngine.Bounds), jsb.QuickJS_UnityEngine_Bounds.Bind, "Bounds");
                runtime.AddTypeReference(module, typeof(UnityEngine.BoundsInt), jsb.QuickJS_UnityEngine_BoundsInt.Bind, "BoundsInt");
                runtime.AddTypeReference(module, typeof(UnityEngine.Gradient), jsb.QuickJS_UnityEngine_Gradient.Bind, "Gradient");
                runtime.AddTypeReference(module, typeof(UnityEngine.AnimationCurve), jsb.QuickJS_UnityEngine_AnimationCurve.Bind, "AnimationCurve");
                runtime.AddTypeReference(module, typeof(UnityEngine.Event), jsb.QuickJS_UnityEngine_Event.Bind, "Event");
                runtime.AddTypeReference(module, typeof(UnityEngine.EventType), jsb.QuickJS_UnityEngine_EventType.Bind, "EventType");
                runtime.AddTypeReference(module, typeof(UnityEngine.Coroutine), jsb.QuickJS_UnityEngine_Coroutine.Bind, "Coroutine");
                runtime.AddTypeReference(module, typeof(UnityEngine.GUI.Scope), jsb.QuickJS_UnityEngine_GUI_Scope.Bind, "GUI", "Scope");
                runtime.AddTypeReference(module, typeof(UnityEngine.TextAsset), jsb.QuickJS_UnityEngine_TextAsset.Bind, "TextAsset");
#if UNITY_EDITOR
                runtime.AddTypeReference(module, typeof(UnityEngine.Hash128), jsb.QuickJS_UnityEngine_Hash128.Bind, "Hash128");
                runtime.AddTypeReference(module, typeof(UnityEngine.AssetBundleManifest), jsb.QuickJS_UnityEngine_AssetBundleManifest.Bind, "AssetBundleManifest");
#endif
            });
            runtime.AddStaticModuleProxy("System.Net", (rt, module) =>
            {
                runtime.AddTypeReference(module, typeof(System.Net.IPHostEntry), jsb.QuickJS_System_Net_IPHostEntry.Bind, "IPHostEntry");
            });
            runtime.AddStaticModuleProxy("System", (rt, module) =>
            {
                runtime.AddTypeReference(module, typeof(System.DateTime), jsb.QuickJS_System_DateTime.Bind, "DateTime");
                runtime.AddTypeReference(module, typeof(object), jsb.QuickJS_System_Object.Bind, "Object");
                runtime.AddTypeReference(module, typeof(System.Enum), jsb.QuickJS_System_Enum.Bind, "Enum");
                runtime.AddTypeReference(module, typeof(System.ValueType), jsb.QuickJS_System_ValueType.Bind, "ValueType");
                runtime.AddTypeReference(module, typeof(byte), jsb.QuickJS_System_Byte.Bind, "Byte");
                runtime.AddTypeReference(module, typeof(sbyte), jsb.QuickJS_System_SByte.Bind, "SByte");
                runtime.AddTypeReference(module, typeof(float), jsb.QuickJS_System_Single.Bind, "Single");
                runtime.AddTypeReference(module, typeof(double), jsb.QuickJS_System_Double.Bind, "Double");
                runtime.AddTypeReference(module, typeof(string), jsb.QuickJS_System_String.Bind, "String");
                runtime.AddTypeReference(module, typeof(int), jsb.QuickJS_System_Int32.Bind, "Int32");
                runtime.AddTypeReference(module, typeof(uint), jsb.QuickJS_System_UInt32.Bind, "UInt32");
                runtime.AddTypeReference(module, typeof(short), jsb.QuickJS_System_Int16.Bind, "Int16");
                runtime.AddTypeReference(module, typeof(ushort), jsb.QuickJS_System_UInt16.Bind, "UInt16");
                runtime.AddTypeReference(module, typeof(System.Array), jsb.QuickJS_System_Array.Bind, "Array");
                runtime.AddTypeReference(module, typeof(System.Delegate), jsb.QuickJS_System_Delegate.Bind, "Delegate");
                runtime.AddTypeReference(module, typeof(System.Exception), jsb.QuickJS_System_Exception.Bind, "Exception");
            });
            runtime.AddStaticModuleProxy("System.IO", (rt, module) =>
            {
                runtime.AddTypeReference(module, typeof(System.IO.FileInfo), jsb.QuickJS_System_IO_FileInfo.Bind, "FileInfo");
                runtime.AddTypeReference(module, typeof(System.IO.File), jsb.QuickJS_System_IO_File.Bind, "File");
            });
            runtime.AddStaticModuleProxy("global", (rt, module) =>
            {
                runtime.AddTypeReference(module, typeof(TWrapper<int>), jsb.QuickJS_TWrapper_Int32.Bind, "TWrapper_Int32");
                runtime.AddTypeReference(module, typeof(TWrapper<UnityEngine.Vector3>), jsb.QuickJS_TWrapper_Vector3.Bind, "TWrapper_Vector3");
                runtime.AddTypeReference(module, typeof(HotfixTest2), jsb.QuickJS_HotfixTest2.Bind, "HotfixTest2");
                runtime.AddTypeReference(module, typeof(MyInterface), jsb.QuickJS_MyInterface.Bind, "MyInterface");
                runtime.AddTypeReference(module, typeof(MyClass), jsb.QuickJS_MyClass.Bind, "MyClass");
                runtime.AddTypeReference(module, typeof(NoNamespaceClass), jsb.QuickJS_NoNamespaceClass.Bind, "NoNamespaceClass");
                runtime.AddTypeReference(module, typeof(NoNamespaceBase), jsb.QuickJS_NoNamespaceBase.Bind, "NoNamespaceBase");
                runtime.AddTypeReference(module, typeof(SampleBehaviour), jsb.QuickJS_SampleBehaviour.Bind, "SampleBehaviour");
            });
            runtime.AddStaticModuleProxy("AnotherNamespace1", (rt, module) =>
            {
                runtime.AddTypeReference(module, typeof(AnotherNamespace1.TSCodeGenTest.InnerClass<int>), jsb.QuickJS_AnotherNamespace1_TSCodeGenTest_InnerClass_Int32.Bind, "TSCodeGenTest", "InnerClass_Int32");
                runtime.AddTypeReference(module, typeof(AnotherNamespace1.TSCodeGenTest2<int>), jsb.QuickJS_AnotherNamespace1_TSCodeGenTest2_Int32.Bind, "TSCodeGenTest2_Int32");
                runtime.AddTypeReference(module, typeof(AnotherNamespace1.TSCodeGenTest2<AnotherNamespace1.Dummy>), jsb.QuickJS_AnotherNamespace1_TSCodeGenTest2_Dummy.Bind, "TSCodeGenTest2_Dummy");
                runtime.AddTypeReference(module, typeof(AnotherNamespace1.TSCodeGenTest2<AnotherNamespace1.Dummy.DummyInner>), jsb.QuickJS_AnotherNamespace1_TSCodeGenTest2_DummyInner.Bind, "TSCodeGenTest2_DummyInner");
                runtime.AddTypeReference(module, typeof(AnotherNamespace1.Dummy), jsb.QuickJS_AnotherNamespace1_Dummy.Bind, "Dummy");
                runtime.AddTypeReference(module, typeof(AnotherNamespace1.Dummy.DummyInner), jsb.QuickJS_AnotherNamespace1_Dummy_DummyInner.Bind, "Dummy", "DummyInner");
            });
            runtime.AddStaticModuleProxy("AnotherNamespace2", (rt, module) =>
            {
                runtime.AddTypeReference(module, typeof(AnotherNamespace2.TSCodeGenTest), jsb.QuickJS_AnotherNamespace2_TSCodeGenTest.Bind, "TSCodeGenTest");
            });
            runtime.AddStaticModuleProxy("Example", (rt, module) =>
            {
                runtime.AddTypeReference(module, typeof(Example.DisposableObject), jsb.QuickJS_Example_DisposableObject.Bind, "DisposableObject");
                runtime.AddTypeReference(module, typeof(Example.ArrayTest), jsb.QuickJS_Example_ArrayTest.Bind, "ArrayTest");
                runtime.AddTypeReference(module, typeof(Example.AsyncTaskTest), jsb.QuickJS_Example_AsyncTaskTest.Bind, "AsyncTaskTest");
                runtime.AddTypeReference(module, typeof(Example.DelegateTest), jsb.QuickJS_Example_DelegateTest.Bind, "DelegateTest");
                runtime.AddTypeReference(module, typeof(Example.NativeFileUtil), jsb.QuickJS_Example_NativeFileUtil.Bind, "NativeFileUtil");
                runtime.AddTypeReference(module, typeof(Example.Jankfest), jsb.QuickJS_Example_Jankfest.Bind, "Jankfest");
                runtime.AddTypeReference(module, typeof(Example.ValueTest), jsb.QuickJS_Example_ValueTest.Bind, "ValueTest");
                runtime.AddTypeReference(module, typeof(Example.DelegateTest.InnerTest), jsb.QuickJS_Example_DelegateTest_InnerTest.Bind, "DelegateTest", "InnerTest");
            });
            runtime.AddStaticModuleProxy("QuickJS.Unity", (rt, module) =>
            {
                runtime.AddTypeReference(module, typeof(QuickJS.Unity.JSSerializationContext), jsb.QuickJS_QuickJS_Unity_JSSerializationContext.Bind, "JSSerializationContext");
#if UNITY_EDITOR
                runtime.AddTypeReference(module, typeof(QuickJS.Unity.UnityHelper), jsb.QuickJS_QuickJS_Unity_UnityHelper.Bind, "UnityHelper");
#endif
            });
            runtime.AddStaticModuleProxy("QuickJS.Binding", (rt, module) =>
            {
#if UNITY_EDITOR
                runtime.AddTypeReference(module, typeof(QuickJS.Binding.Prefs), jsb.QuickJS_QuickJS_Binding_Prefs.Bind, "Prefs");
#endif
            });
            runtime.AddStaticModuleProxy("QuickJS.Utils", (rt, module) =>
            {
#if UNITY_EDITOR
                runtime.AddTypeReference(module, typeof(QuickJS.Utils.TSConfig), jsb.QuickJS_QuickJS_Utils_TSConfig.Bind, "TSConfig");
                runtime.AddTypeReference(module, typeof(QuickJS.Utils.TSConfig.CompilerOptions), jsb.QuickJS_QuickJS_Utils_TSConfig_CompilerOptions.Bind, "TSConfig", "CompilerOptions");
#endif
            });
            runtime.AddStaticModuleProxy("System.Collections", (rt, module) =>
            {
                runtime.AddTypeReference(module, typeof(System.Collections.IEnumerator), jsb.QuickJS_System_Collections_IEnumerator.Bind, "IEnumerator");
            });
            runtime.AddStaticModuleProxy("System.Collections.Generic", (rt, module) =>
            {
                runtime.AddTypeReference(module, typeof(System.Collections.Generic.IEnumerable<string>), jsb.QuickJS_System_Collections_Generic_IEnumerable_String.Bind, "IEnumerable_String");
            });
            runtime.AddStaticModuleProxy("UnityEditor.IMGUI.Controls", (rt, module) =>
            {
#if UNITY_EDITOR
                runtime.AddTypeReference(module, typeof(UnityEditor.IMGUI.Controls.SearchField), jsb.QuickJS_UnityEditor_IMGUI_Controls_SearchField.Bind, "SearchField");
                runtime.AddTypeReference(module, typeof(UnityEditor.IMGUI.Controls.ArcHandle), jsb.QuickJS_UnityEditor_IMGUI_Controls_ArcHandle.Bind, "ArcHandle");
                runtime.AddTypeReference(module, typeof(UnityEditor.IMGUI.Controls.JointAngularLimitHandle), jsb.QuickJS_UnityEditor_IMGUI_Controls_JointAngularLimitHandle.Bind, "JointAngularLimitHandle");
                runtime.AddTypeReference(module, typeof(UnityEditor.IMGUI.Controls.BoxBoundsHandle), jsb.QuickJS_UnityEditor_IMGUI_Controls_BoxBoundsHandle.Bind, "BoxBoundsHandle");
                runtime.AddTypeReference(module, typeof(UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle), jsb.QuickJS_UnityEditor_IMGUI_Controls_PrimitiveBoundsHandle.Bind, "PrimitiveBoundsHandle");
                runtime.AddTypeReference(module, typeof(UnityEditor.IMGUI.Controls.CapsuleBoundsHandle), jsb.QuickJS_UnityEditor_IMGUI_Controls_CapsuleBoundsHandle.Bind, "CapsuleBoundsHandle");
                runtime.AddTypeReference(module, typeof(UnityEditor.IMGUI.Controls.CapsuleBoundsHandle.HeightAxis), jsb.QuickJS_UnityEditor_IMGUI_Controls_CapsuleBoundsHandle_HeightAxis.Bind, "CapsuleBoundsHandle", "HeightAxis");
                runtime.AddTypeReference(module, typeof(UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle.Axes), jsb.QuickJS_UnityEditor_IMGUI_Controls_PrimitiveBoundsHandle_Axes.Bind, "PrimitiveBoundsHandle", "Axes");
                runtime.AddTypeReference(module, typeof(UnityEditor.IMGUI.Controls.SphereBoundsHandle), jsb.QuickJS_UnityEditor_IMGUI_Controls_SphereBoundsHandle.Bind, "SphereBoundsHandle");
                runtime.AddTypeReference(module, typeof(UnityEditor.IMGUI.Controls.MultiColumnHeader), jsb.QuickJS_UnityEditor_IMGUI_Controls_MultiColumnHeader.Bind, "MultiColumnHeader");
                runtime.AddTypeReference(module, typeof(UnityEditor.IMGUI.Controls.MultiColumnHeader.DefaultGUI), jsb.QuickJS_UnityEditor_IMGUI_Controls_MultiColumnHeader_DefaultGUI.Bind, "MultiColumnHeader", "DefaultGUI");
                runtime.AddTypeReference(module, typeof(UnityEditor.IMGUI.Controls.MultiColumnHeader.DefaultStyles), jsb.QuickJS_UnityEditor_IMGUI_Controls_MultiColumnHeader_DefaultStyles.Bind, "MultiColumnHeader", "DefaultStyles");
                runtime.AddTypeReference(module, typeof(UnityEditor.IMGUI.Controls.MultiColumnHeaderState), jsb.QuickJS_UnityEditor_IMGUI_Controls_MultiColumnHeaderState.Bind, "MultiColumnHeaderState");
                runtime.AddTypeReference(module, typeof(UnityEditor.IMGUI.Controls.MultiColumnHeaderState.Column), jsb.QuickJS_UnityEditor_IMGUI_Controls_MultiColumnHeaderState_Column.Bind, "MultiColumnHeaderState", "Column");
                runtime.AddTypeReference(module, typeof(UnityEditor.IMGUI.Controls.TreeViewState), jsb.QuickJS_UnityEditor_IMGUI_Controls_TreeViewState.Bind, "TreeViewState");
                runtime.AddTypeReference(module, typeof(UnityEditor.IMGUI.Controls.TreeViewItem), jsb.QuickJS_UnityEditor_IMGUI_Controls_TreeViewItem.Bind, "TreeViewItem");
                runtime.AddTypeReference(module, typeof(UnityEditor.IMGUI.Controls.TreeView), jsb.QuickJS_UnityEditor_IMGUI_Controls_TreeView.Bind, "TreeView");
                runtime.AddTypeReference(module, typeof(UnityEditor.IMGUI.Controls.TreeView.DefaultGUI), jsb.QuickJS_UnityEditor_IMGUI_Controls_TreeView_DefaultGUI.Bind, "TreeView", "DefaultGUI");
                runtime.AddTypeReference(module, typeof(UnityEditor.IMGUI.Controls.TreeView.DefaultStyles), jsb.QuickJS_UnityEditor_IMGUI_Controls_TreeView_DefaultStyles.Bind, "TreeView", "DefaultStyles");
                runtime.AddTypeReference(module, typeof(UnityEditor.IMGUI.Controls.TreeViewSelectionOptions), jsb.QuickJS_UnityEditor_IMGUI_Controls_TreeViewSelectionOptions.Bind, "TreeViewSelectionOptions");
                runtime.AddTypeReference(module, typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem), jsb.QuickJS_UnityEditor_IMGUI_Controls_AdvancedDropdownItem.Bind, "AdvancedDropdownItem");
                runtime.AddTypeReference(module, typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownState), jsb.QuickJS_UnityEditor_IMGUI_Controls_AdvancedDropdownState.Bind, "AdvancedDropdownState");
                runtime.AddTypeReference(module, typeof(UnityEditor.IMGUI.Controls.AdvancedDropdown), jsb.QuickJS_UnityEditor_IMGUI_Controls_AdvancedDropdown.Bind, "AdvancedDropdown");
#endif
            });
            runtime.AddStaticModuleProxy("UnityEditor", (rt, module) =>
            {
#if UNITY_EDITOR
                runtime.AddTypeReference(module, typeof(UnityEditor.EditorStyles), jsb.QuickJS_UnityEditor_EditorStyles.Bind, "EditorStyles");
                runtime.AddTypeReference(module, typeof(UnityEditor.GenericMenu), jsb.QuickJS_UnityEditor_GenericMenu.Bind, "GenericMenu");
                runtime.AddTypeReference(module, typeof(UnityEditor.PrefabAssetType), jsb.QuickJS_UnityEditor_PrefabAssetType.Bind, "PrefabAssetType");
                runtime.AddTypeReference(module, typeof(UnityEditor.PrefabInstanceStatus), jsb.QuickJS_UnityEditor_PrefabInstanceStatus.Bind, "PrefabInstanceStatus");
                runtime.AddTypeReference(module, typeof(UnityEditor.UIOrientation), jsb.QuickJS_UnityEditor_UIOrientation.Bind, "UIOrientation");
                runtime.AddTypeReference(module, typeof(UnityEditor.MessageType), jsb.QuickJS_UnityEditor_MessageType.Bind, "MessageType");
                runtime.AddTypeReference(module, typeof(UnityEditor.ImportAssetOptions), jsb.QuickJS_UnityEditor_ImportAssetOptions.Bind, "ImportAssetOptions");
                runtime.AddTypeReference(module, typeof(UnityEditor.AssetPostprocessor), jsb.QuickJS_UnityEditor_AssetPostprocessor.Bind, "AssetPostprocessor");
                runtime.AddTypeReference(module, typeof(UnityEditor.AssetImporter), jsb.QuickJS_UnityEditor_AssetImporter.Bind, "AssetImporter");
                runtime.AddTypeReference(module, typeof(UnityEditor.ModelImporter), jsb.QuickJS_UnityEditor_ModelImporter.Bind, "ModelImporter");
                runtime.AddTypeReference(module, typeof(UnityEditor.AudioImporter), jsb.QuickJS_UnityEditor_AudioImporter.Bind, "AudioImporter");
                runtime.AddTypeReference(module, typeof(UnityEditor.VideoClipImporter), jsb.QuickJS_UnityEditor_VideoClipImporter.Bind, "VideoClipImporter");
                runtime.AddTypeReference(module, typeof(UnityEditor.TextureImporter), jsb.QuickJS_UnityEditor_TextureImporter.Bind, "TextureImporter");
                runtime.AddTypeReference(module, typeof(UnityEditor.MouseCursor), jsb.QuickJS_UnityEditor_MouseCursor.Bind, "MouseCursor");
                runtime.AddTypeReference(module, typeof(UnityEditor.PauseState), jsb.QuickJS_UnityEditor_PauseState.Bind, "PauseState");
                runtime.AddTypeReference(module, typeof(UnityEditor.PlayModeStateChange), jsb.QuickJS_UnityEditor_PlayModeStateChange.Bind, "PlayModeStateChange");
                runtime.AddTypeReference(module, typeof(UnityEditor.ExportPackageOptions), jsb.QuickJS_UnityEditor_ExportPackageOptions.Bind, "ExportPackageOptions");
                runtime.AddTypeReference(module, typeof(UnityEditor.ForceReserializeAssetsOptions), jsb.QuickJS_UnityEditor_ForceReserializeAssetsOptions.Bind, "ForceReserializeAssetsOptions");
                runtime.AddTypeReference(module, typeof(UnityEditor.StatusQueryOptions), jsb.QuickJS_UnityEditor_StatusQueryOptions.Bind, "StatusQueryOptions");
                runtime.AddTypeReference(module, typeof(UnityEditor.SerializedObject), jsb.QuickJS_UnityEditor_SerializedObject.Bind, "SerializedObject");
                runtime.AddTypeReference(module, typeof(UnityEditor.SerializedProperty), jsb.QuickJS_UnityEditor_SerializedProperty.Bind, "SerializedProperty");
                runtime.AddTypeReference(module, typeof(UnityEditor.SerializedPropertyType), jsb.QuickJS_UnityEditor_SerializedPropertyType.Bind, "SerializedPropertyType");
                runtime.AddTypeReference(module, typeof(UnityEditor.BuildPlayerOptions), jsb.QuickJS_UnityEditor_BuildPlayerOptions.Bind, "BuildPlayerOptions");
                runtime.AddTypeReference(module, typeof(UnityEditor.BuildAssetBundleOptions), jsb.QuickJS_UnityEditor_BuildAssetBundleOptions.Bind, "BuildAssetBundleOptions");
                runtime.AddTypeReference(module, typeof(UnityEditor.BuildTarget), jsb.QuickJS_UnityEditor_BuildTarget.Bind, "BuildTarget");
                runtime.AddTypeReference(module, typeof(UnityEditor.BuildOptions), jsb.QuickJS_UnityEditor_BuildOptions.Bind, "BuildOptions");
                runtime.AddTypeReference(module, typeof(UnityEditor.ObjectFactory), jsb.QuickJS_UnityEditor_ObjectFactory.Bind, "ObjectFactory");
                runtime.AddTypeReference(module, typeof(UnityEditor.CameraEditor), jsb.QuickJS_UnityEditor_CameraEditor.Bind, "CameraEditor");
                runtime.AddTypeReference(module, typeof(UnityEditor.CameraEditorUtils), jsb.QuickJS_UnityEditor_CameraEditorUtils.Bind, "CameraEditorUtils");
                runtime.AddTypeReference(module, typeof(UnityEditor.TransformUtils), jsb.QuickJS_UnityEditor_TransformUtils.Bind, "TransformUtils");
                runtime.AddTypeReference(module, typeof(UnityEditor.EditorJsonUtility), jsb.QuickJS_UnityEditor_EditorJsonUtility.Bind, "EditorJsonUtility");
                runtime.AddTypeReference(module, typeof(UnityEditor.GameObjectUtility), jsb.QuickJS_UnityEditor_GameObjectUtility.Bind, "GameObjectUtility");
                runtime.AddTypeReference(module, typeof(UnityEditor.EditorPrefs), jsb.QuickJS_UnityEditor_EditorPrefs.Bind, "EditorPrefs");
                runtime.AddTypeReference(module, typeof(UnityEditor.Handles), jsb.QuickJS_UnityEditor_Handles.Bind, "Handles");
                runtime.AddTypeReference(module, typeof(UnityEditor.HandleUtility), jsb.QuickJS_UnityEditor_HandleUtility.Bind, "HandleUtility");
                runtime.AddTypeReference(module, typeof(UnityEditor.SceneView), jsb.QuickJS_UnityEditor_SceneView.Bind, "SceneView");
                runtime.AddTypeReference(module, typeof(UnityEditor.MeshUtility), jsb.QuickJS_UnityEditor_MeshUtility.Bind, "MeshUtility");
                runtime.AddTypeReference(module, typeof(UnityEditor.PrefabUtility), jsb.QuickJS_UnityEditor_PrefabUtility.Bind, "PrefabUtility");
                runtime.AddTypeReference(module, typeof(UnityEditor.FileUtil), jsb.QuickJS_UnityEditor_FileUtil.Bind, "FileUtil");
                runtime.AddTypeReference(module, typeof(UnityEditor.BuildPipeline), jsb.QuickJS_UnityEditor_BuildPipeline.Bind, "BuildPipeline");
                runtime.AddTypeReference(module, typeof(UnityEditor.AssetDatabase), jsb.QuickJS_UnityEditor_AssetDatabase.Bind, "AssetDatabase");
                runtime.AddTypeReference(module, typeof(UnityEditor.ShaderUtil), jsb.QuickJS_UnityEditor_ShaderUtil.Bind, "ShaderUtil");
                // runtime.AddTypeReference(module, typeof(UnityEditor.EditorUtility), jsb.QuickJS_UnityEditor_EditorUtility.Bind, "EditorUtility");
                runtime.AddTypeReference(module, typeof(UnityEditor.EditorGUI), jsb.QuickJS_UnityEditor_EditorGUI.Bind, "EditorGUI");
                runtime.AddTypeReference(module, typeof(UnityEditor.EditorGUIUtility), jsb.QuickJS_UnityEditor_EditorGUIUtility.Bind, "EditorGUIUtility");
                runtime.AddTypeReference(module, typeof(UnityEditor.EditorGUILayout), jsb.QuickJS_UnityEditor_EditorGUILayout.Bind, "EditorGUILayout");
                runtime.AddTypeReference(module, typeof(UnityEditor.EditorApplication), jsb.QuickJS_UnityEditor_EditorApplication.Bind, "EditorApplication");
                runtime.AddTypeReference(module, typeof(UnityEditor.Editor), jsb.QuickJS_UnityEditor_Editor.Bind, "Editor");
                runtime.AddTypeReference(module, typeof(UnityEditor.EditorWindow), jsb.QuickJS_UnityEditor_EditorWindow.Bind, "EditorWindow");
                runtime.AddTypeReference(module, typeof(UnityEditor.ActiveEditorTracker), jsb.QuickJS_UnityEditor_ActiveEditorTracker.Bind, "ActiveEditorTracker");
                runtime.AddTypeReference(module, typeof(UnityEditor.ArrayUtility), jsb.QuickJS_UnityEditor_ArrayUtility.Bind, "ArrayUtility");
                runtime.AddTypeReference(module, typeof(UnityEditor.AssemblyReloadEvents), jsb.QuickJS_UnityEditor_AssemblyReloadEvents.Bind, "AssemblyReloadEvents");
                runtime.AddTypeReference(module, typeof(UnityEditor.AssetDeleteResult), jsb.QuickJS_UnityEditor_AssetDeleteResult.Bind, "AssetDeleteResult");
                runtime.AddTypeReference(module, typeof(UnityEditor.AssetMoveResult), jsb.QuickJS_UnityEditor_AssetMoveResult.Bind, "AssetMoveResult");
                runtime.AddTypeReference(module, typeof(UnityEditor.CanAppendBuild), jsb.QuickJS_UnityEditor_CanAppendBuild.Bind, "CanAppendBuild");
                runtime.AddTypeReference(module, typeof(UnityEditor.AssetBundleBuild), jsb.QuickJS_UnityEditor_AssetBundleBuild.Bind, "AssetBundleBuild");
                runtime.AddTypeReference(module, typeof(UnityEditor.BuildPlayerWindow), jsb.QuickJS_UnityEditor_BuildPlayerWindow.Bind, "BuildPlayerWindow");
                runtime.AddTypeReference(module, typeof(UnityEditor.BuildPlayerWindow.BuildMethodException), jsb.QuickJS_UnityEditor_BuildPlayerWindow_BuildMethodException.Bind, "BuildPlayerWindow", "BuildMethodException");
                runtime.AddTypeReference(module, typeof(UnityEditor.BuildPlayerWindow.DefaultBuildMethods), jsb.QuickJS_UnityEditor_BuildPlayerWindow_DefaultBuildMethods.Bind, "BuildPlayerWindow", "DefaultBuildMethods");
                runtime.AddTypeReference(module, typeof(UnityEditor.BuildTargetGroup), jsb.QuickJS_UnityEditor_BuildTargetGroup.Bind, "BuildTargetGroup");
                runtime.AddTypeReference(module, typeof(UnityEditor.DefaultAsset), jsb.QuickJS_UnityEditor_DefaultAsset.Bind, "DefaultAsset");
                runtime.AddTypeReference(module, typeof(UnityEditor.DragAndDropVisualMode), jsb.QuickJS_UnityEditor_DragAndDropVisualMode.Bind, "DragAndDropVisualMode");
                runtime.AddTypeReference(module, typeof(UnityEditor.DragAndDrop), jsb.QuickJS_UnityEditor_DragAndDrop.Bind, "DragAndDrop");
                runtime.AddTypeReference(module, typeof(UnityEditor.GizmoType), jsb.QuickJS_UnityEditor_GizmoType.Bind, "GizmoType");
                runtime.AddTypeReference(module, typeof(UnityEditor.EditorBuildSettingsScene), jsb.QuickJS_UnityEditor_EditorBuildSettingsScene.Bind, "EditorBuildSettingsScene");
                runtime.AddTypeReference(module, typeof(UnityEditor.EditorBuildSettings), jsb.QuickJS_UnityEditor_EditorBuildSettings.Bind, "EditorBuildSettings");
                runtime.AddTypeReference(module, typeof(UnityEditor.EditorGUI.DisabledGroupScope), jsb.QuickJS_UnityEditor_EditorGUI_DisabledGroupScope.Bind, "EditorGUI", "DisabledGroupScope");
                runtime.AddTypeReference(module, typeof(UnityEditor.EditorGUI.DisabledScope), jsb.QuickJS_UnityEditor_EditorGUI_DisabledScope.Bind, "EditorGUI", "DisabledScope");
                runtime.AddTypeReference(module, typeof(UnityEditor.EditorGUI.ChangeCheckScope), jsb.QuickJS_UnityEditor_EditorGUI_ChangeCheckScope.Bind, "EditorGUI", "ChangeCheckScope");
                runtime.AddTypeReference(module, typeof(UnityEditor.EditorGUI.IndentLevelScope), jsb.QuickJS_UnityEditor_EditorGUI_IndentLevelScope.Bind, "EditorGUI", "IndentLevelScope");
                runtime.AddTypeReference(module, typeof(UnityEditor.EditorGUI.PropertyScope), jsb.QuickJS_UnityEditor_EditorGUI_PropertyScope.Bind, "EditorGUI", "PropertyScope");
                runtime.AddTypeReference(module, typeof(UnityEditor.EditorGUILayout.ToggleGroupScope), jsb.QuickJS_UnityEditor_EditorGUILayout_ToggleGroupScope.Bind, "EditorGUILayout", "ToggleGroupScope");
                runtime.AddTypeReference(module, typeof(UnityEditor.EditorGUILayout.HorizontalScope), jsb.QuickJS_UnityEditor_EditorGUILayout_HorizontalScope.Bind, "EditorGUILayout", "HorizontalScope");
                runtime.AddTypeReference(module, typeof(UnityEditor.EditorGUILayout.VerticalScope), jsb.QuickJS_UnityEditor_EditorGUILayout_VerticalScope.Bind, "EditorGUILayout", "VerticalScope");
                runtime.AddTypeReference(module, typeof(UnityEditor.EditorGUILayout.ScrollViewScope), jsb.QuickJS_UnityEditor_EditorGUILayout_ScrollViewScope.Bind, "EditorGUILayout", "ScrollViewScope");
                runtime.AddTypeReference(module, typeof(UnityEditor.EditorGUILayout.FadeGroupScope), jsb.QuickJS_UnityEditor_EditorGUILayout_FadeGroupScope.Bind, "EditorGUILayout", "FadeGroupScope");
                runtime.AddTypeReference(module, typeof(UnityEditor.EditorSkin), jsb.QuickJS_UnityEditor_EditorSkin.Bind, "EditorSkin");
                runtime.AddTypeReference(module, typeof(UnityEditor.EditorGUIUtility.IconSizeScope), jsb.QuickJS_UnityEditor_EditorGUIUtility_IconSizeScope.Bind, "EditorGUIUtility", "IconSizeScope");
                runtime.AddTypeReference(module, typeof(UnityEditor.SessionState), jsb.QuickJS_UnityEditor_SessionState.Bind, "SessionState");
                runtime.AddTypeReference(module, typeof(UnityEditor.SerializationMode), jsb.QuickJS_UnityEditor_SerializationMode.Bind, "SerializationMode");
                runtime.AddTypeReference(module, typeof(UnityEditor.EditorBehaviorMode), jsb.QuickJS_UnityEditor_EditorBehaviorMode.Bind, "EditorBehaviorMode");
                runtime.AddTypeReference(module, typeof(UnityEditor.SpritePackerMode), jsb.QuickJS_UnityEditor_SpritePackerMode.Bind, "SpritePackerMode");
                runtime.AddTypeReference(module, typeof(UnityEditor.LineEndingsMode), jsb.QuickJS_UnityEditor_LineEndingsMode.Bind, "LineEndingsMode");
                runtime.AddTypeReference(module, typeof(UnityEditor.AssetPipelineMode), jsb.QuickJS_UnityEditor_AssetPipelineMode.Bind, "AssetPipelineMode");
                runtime.AddTypeReference(module, typeof(UnityEditor.CacheServerMode), jsb.QuickJS_UnityEditor_CacheServerMode.Bind, "CacheServerMode");
                runtime.AddTypeReference(module, typeof(UnityEditor.CacheServerValidationMode), jsb.QuickJS_UnityEditor_CacheServerValidationMode.Bind, "CacheServerValidationMode");
                runtime.AddTypeReference(module, typeof(UnityEditor.EnterPlayModeOptions), jsb.QuickJS_UnityEditor_EnterPlayModeOptions.Bind, "EnterPlayModeOptions");
                runtime.AddTypeReference(module, typeof(UnityEditor.ExternalVersionControl), jsb.QuickJS_UnityEditor_ExternalVersionControl.Bind, "ExternalVersionControl");
                // runtime.AddTypeReference(module, typeof(UnityEditor.EditorSettings), jsb.QuickJS_UnityEditor_EditorSettings.Bind, "EditorSettings");
                runtime.AddTypeReference(module, typeof(UnityEditor.PS4BuildSubtarget), jsb.QuickJS_UnityEditor_PS4BuildSubtarget.Bind, "PS4BuildSubtarget");
                // runtime.AddTypeReference(module, typeof(UnityEditor.PS5BuildSubtarget), jsb.QuickJS_UnityEditor_PS5BuildSubtarget.Bind, "PS5BuildSubtarget");
                // runtime.AddTypeReference(module, typeof(UnityEditor.PS5BuildCompressionType), jsb.QuickJS_UnityEditor_PS5BuildCompressionType.Bind, "PS5BuildCompressionType");
                runtime.AddTypeReference(module, typeof(UnityEditor.PS4HardwareTarget), jsb.QuickJS_UnityEditor_PS4HardwareTarget.Bind, "PS4HardwareTarget");
                runtime.AddTypeReference(module, typeof(UnityEditor.XboxBuildSubtarget), jsb.QuickJS_UnityEditor_XboxBuildSubtarget.Bind, "XboxBuildSubtarget");
                runtime.AddTypeReference(module, typeof(UnityEditor.XboxOneDeployMethod), jsb.QuickJS_UnityEditor_XboxOneDeployMethod.Bind, "XboxOneDeployMethod");
                runtime.AddTypeReference(module, typeof(UnityEditor.XboxOneDeployDrive), jsb.QuickJS_UnityEditor_XboxOneDeployDrive.Bind, "XboxOneDeployDrive");
                runtime.AddTypeReference(module, typeof(UnityEditor.MobileTextureSubtarget), jsb.QuickJS_UnityEditor_MobileTextureSubtarget.Bind, "MobileTextureSubtarget");
                runtime.AddTypeReference(module, typeof(UnityEditor.XcodeBuildConfig), jsb.QuickJS_UnityEditor_iOSBuildType.Bind, "iOSBuildType");
                runtime.AddTypeReference(module, typeof(UnityEditor.SwitchRomCompressionType), jsb.QuickJS_UnityEditor_SwitchRomCompressionType.Bind, "SwitchRomCompressionType");
                // runtime.AddTypeReference(module, typeof(UnityEditor.EditorUserBuildSettings), jsb.QuickJS_UnityEditor_EditorUserBuildSettings.Bind, "EditorUserBuildSettings");
                runtime.AddTypeReference(module, typeof(UnityEditor.SemanticMergeMode), jsb.QuickJS_UnityEditor_SemanticMergeMode.Bind, "SemanticMergeMode");
                runtime.AddTypeReference(module, typeof(UnityEditor.EditorUserSettings), jsb.QuickJS_UnityEditor_EditorUserSettings.Bind, "EditorUserSettings");
                runtime.AddTypeReference(module, typeof(UnityEditor.EditorSelectedRenderState), jsb.QuickJS_UnityEditor_EditorSelectedRenderState.Bind, "EditorSelectedRenderState");
                runtime.AddTypeReference(module, typeof(UnityEditor.InteractionMode), jsb.QuickJS_UnityEditor_InteractionMode.Bind, "InteractionMode");
                runtime.AddTypeReference(module, typeof(UnityEditor.TextureCompressionQuality), jsb.QuickJS_UnityEditor_TextureCompressionQuality.Bind, "TextureCompressionQuality");
                runtime.AddTypeReference(module, typeof(UnityEditor.DialogOptOutDecisionType), jsb.QuickJS_UnityEditor_DialogOptOutDecisionType.Bind, "DialogOptOutDecisionType");
                runtime.AddTypeReference(module, typeof(UnityEditor.SceneAsset), jsb.QuickJS_UnityEditor_SceneAsset.Bind, "SceneAsset");
                runtime.AddTypeReference(module, typeof(UnityEditor.GUID), jsb.QuickJS_UnityEditor_GUID.Bind, "GUID");
                runtime.AddTypeReference(module, typeof(UnityEditor.GlobalObjectId), jsb.QuickJS_UnityEditor_GlobalObjectId.Bind, "GlobalObjectId");
                runtime.AddTypeReference(module, typeof(UnityEditor.Handles.DrawingScope), jsb.QuickJS_UnityEditor_Handles_DrawingScope.Bind, "Handles", "DrawingScope");
                runtime.AddTypeReference(module, typeof(UnityEditor.Help), jsb.QuickJS_UnityEditor_Help.Bind, "Help");
                runtime.AddTypeReference(module, typeof(UnityEditor.IHasCustomMenu), jsb.QuickJS_UnityEditor_IHasCustomMenu.Bind, "IHasCustomMenu");
                runtime.AddTypeReference(module, typeof(UnityEditor.MaterialProperty), jsb.QuickJS_UnityEditor_MaterialProperty.Bind, "MaterialProperty");
                runtime.AddTypeReference(module, typeof(UnityEditor.MaterialProperty.PropType), jsb.QuickJS_UnityEditor_MaterialProperty_PropType.Bind, "MaterialProperty", "PropType");
                runtime.AddTypeReference(module, typeof(UnityEditor.MaterialProperty.PropFlags), jsb.QuickJS_UnityEditor_MaterialProperty_PropFlags.Bind, "MaterialProperty", "PropFlags");
                runtime.AddTypeReference(module, typeof(UnityEditor.Menu), jsb.QuickJS_UnityEditor_Menu.Bind, "Menu");
                runtime.AddTypeReference(module, typeof(UnityEditor.MenuCommand), jsb.QuickJS_UnityEditor_MenuCommand.Bind, "MenuCommand");
                runtime.AddTypeReference(module, typeof(UnityEditor.MonoScript), jsb.QuickJS_UnityEditor_MonoScript.Bind, "MonoScript");
                runtime.AddTypeReference(module, typeof(UnityEditor.ObjectNames), jsb.QuickJS_UnityEditor_ObjectNames.Bind, "ObjectNames");
                runtime.AddTypeReference(module, typeof(UnityEditor.PackageInfo), jsb.QuickJS_UnityEditor_PackageInfo.Bind, "PackageInfo");
                runtime.AddTypeReference(module, typeof(UnityEditor.ScriptingImplementation), jsb.QuickJS_UnityEditor_ScriptingImplementation.Bind, "ScriptingImplementation");
                runtime.AddTypeReference(module, typeof(UnityEditor.Il2CppCompilerConfiguration), jsb.QuickJS_UnityEditor_Il2CppCompilerConfiguration.Bind, "Il2CppCompilerConfiguration");
                runtime.AddTypeReference(module, typeof(UnityEditor.AspectRatio), jsb.QuickJS_UnityEditor_AspectRatio.Bind, "AspectRatio");
                runtime.AddTypeReference(module, typeof(UnityEditor.MacFullscreenMode), jsb.QuickJS_UnityEditor_MacFullscreenMode.Bind, "MacFullscreenMode");
                runtime.AddTypeReference(module, typeof(UnityEditor.D3D11FullscreenMode), jsb.QuickJS_UnityEditor_D3D11FullscreenMode.Bind, "D3D11FullscreenMode");
                runtime.AddTypeReference(module, typeof(UnityEditor.StereoRenderingPath), jsb.QuickJS_UnityEditor_StereoRenderingPath.Bind, "StereoRenderingPath");
                runtime.AddTypeReference(module, typeof(UnityEditor.StrippingLevel), jsb.QuickJS_UnityEditor_StrippingLevel.Bind, "StrippingLevel");
                runtime.AddTypeReference(module, typeof(UnityEditor.ScriptCallOptimizationLevel), jsb.QuickJS_UnityEditor_ScriptCallOptimizationLevel.Bind, "ScriptCallOptimizationLevel");
                runtime.AddTypeReference(module, typeof(UnityEditor.ApiCompatibilityLevel), jsb.QuickJS_UnityEditor_ApiCompatibilityLevel.Bind, "ApiCompatibilityLevel");
                runtime.AddTypeReference(module, typeof(UnityEditor.ManagedStrippingLevel), jsb.QuickJS_UnityEditor_ManagedStrippingLevel.Bind, "ManagedStrippingLevel");
                runtime.AddTypeReference(module, typeof(UnityEditor.ActionOnDotNetUnhandledException), jsb.QuickJS_UnityEditor_ActionOnDotNetUnhandledException.Bind, "ActionOnDotNetUnhandledException");
                runtime.AddTypeReference(module, typeof(UnityEditor.GraphicsJobMode), jsb.QuickJS_UnityEditor_GraphicsJobMode.Bind, "GraphicsJobMode");
                runtime.AddTypeReference(module, typeof(UnityEditor.IconKind), jsb.QuickJS_UnityEditor_IconKind.Bind, "IconKind");
                runtime.AddTypeReference(module, typeof(UnityEditor.PlayerSettings), jsb.QuickJS_UnityEditor_PlayerSettings.Bind, "PlayerSettings");
                runtime.AddTypeReference(module, typeof(UnityEditor.PlayerSettings.Android), jsb.QuickJS_UnityEditor_PlayerSettings_Android.Bind, "PlayerSettings", "Android");
                runtime.AddTypeReference(module, typeof(UnityEditor.PlayerSettings.iOS), jsb.QuickJS_UnityEditor_PlayerSettings_iOS.Bind, "PlayerSettings", "iOS");
                runtime.AddTypeReference(module, typeof(UnityEditor.PlayerSettings.Lumin), jsb.QuickJS_UnityEditor_PlayerSettings_Lumin.Bind, "PlayerSettings", "Lumin");
                runtime.AddTypeReference(module, typeof(UnityEditor.PlayerSettings.macOS), jsb.QuickJS_UnityEditor_PlayerSettings_macOS.Bind, "PlayerSettings", "macOS");
                runtime.AddTypeReference(module, typeof(UnityEditor.PlayerSettings.PS4), jsb.QuickJS_UnityEditor_PlayerSettings_PS4.Bind, "PlayerSettings", "PS4");
                runtime.AddTypeReference(module, typeof(UnityEditor.PlayerSettings.PS4.PS4AppCategory), jsb.QuickJS_UnityEditor_PlayerSettings_PS4_PS4AppCategory.Bind, "PlayerSettings", "PS4", "PS4AppCategory");
                runtime.AddTypeReference(module, typeof(UnityEditor.PlayerSettings.PS4.PS4RemotePlayKeyAssignment), jsb.QuickJS_UnityEditor_PlayerSettings_PS4_PS4RemotePlayKeyAssignment.Bind, "PlayerSettings", "PS4", "PS4RemotePlayKeyAssignment");
                runtime.AddTypeReference(module, typeof(UnityEditor.PlayerSettings.PS4.PS4EnterButtonAssignment), jsb.QuickJS_UnityEditor_PlayerSettings_PS4_PS4EnterButtonAssignment.Bind, "PlayerSettings", "PS4", "PS4EnterButtonAssignment");
                runtime.AddTypeReference(module, typeof(UnityEditor.PlayerSettings.PS4.PlayStationVREyeToEyeDistanceSettings), jsb.QuickJS_UnityEditor_PlayerSettings_PS4_PlayStationVREyeToEyeDistanceSettings.Bind, "PlayerSettings", "PS4", "PlayStationVREyeToEyeDistanceSettings");
                // runtime.AddTypeReference(module, typeof(UnityEditor.PlayerSettings.PS5), jsb.QuickJS_UnityEditor_PlayerSettings_PS5.Bind, "PlayerSettings", "PS5");
                runtime.AddTypeReference(module, typeof(UnityEditor.PlayerSettings.SplashScreenLogo), jsb.QuickJS_UnityEditor_PlayerSettings_SplashScreenLogo.Bind, "PlayerSettings", "SplashScreenLogo");
                runtime.AddTypeReference(module, typeof(UnityEditor.PlayerSettings.SplashScreen), jsb.QuickJS_UnityEditor_PlayerSettings_SplashScreen.Bind, "PlayerSettings", "SplashScreen");
                runtime.AddTypeReference(module, typeof(UnityEditor.PlayerSettings.SplashScreen.AnimationMode), jsb.QuickJS_UnityEditor_PlayerSettings_SplashScreen_AnimationMode.Bind, "PlayerSettings", "SplashScreen", "AnimationMode");
                runtime.AddTypeReference(module, typeof(UnityEditor.PlayerSettings.SplashScreen.DrawMode), jsb.QuickJS_UnityEditor_PlayerSettings_SplashScreen_DrawMode.Bind, "PlayerSettings", "SplashScreen", "DrawMode");
                runtime.AddTypeReference(module, typeof(UnityEditor.PlayerSettings.SplashScreen.UnityLogoStyle), jsb.QuickJS_UnityEditor_PlayerSettings_SplashScreen_UnityLogoStyle.Bind, "PlayerSettings", "SplashScreen", "UnityLogoStyle");
                // runtime.AddTypeReference(module, typeof(UnityEditor.PlayerSettings.Switch), jsb.QuickJS_UnityEditor_PlayerSettings_Switch.Bind, "PlayerSettings", "Switch");
                runtime.AddTypeReference(module, typeof(UnityEditor.PlayerSettings.Switch.ScreenResolutionBehavior), jsb.QuickJS_UnityEditor_PlayerSettings_Switch_ScreenResolutionBehavior.Bind, "PlayerSettings", "Switch", "ScreenResolutionBehavior");
                runtime.AddTypeReference(module, typeof(UnityEditor.PlayerSettings.Switch.Languages), jsb.QuickJS_UnityEditor_PlayerSettings_Switch_Languages.Bind, "PlayerSettings", "Switch", "Languages");
                runtime.AddTypeReference(module, typeof(UnityEditor.PlayerSettings.Switch.StartupUserAccount), jsb.QuickJS_UnityEditor_PlayerSettings_Switch_StartupUserAccount.Bind, "PlayerSettings", "Switch", "StartupUserAccount");
                // runtime.AddTypeReference(module, typeof(UnityEditor.PlayerSettings.Switch.TouchScreenUsage), jsb.QuickJS_UnityEditor_PlayerSettings_Switch_TouchScreenUsage.Bind, "PlayerSettings", "Switch", "TouchScreenUsage");
                runtime.AddTypeReference(module, typeof(UnityEditor.PlayerSettings.Switch.LogoHandling), jsb.QuickJS_UnityEditor_PlayerSettings_Switch_LogoHandling.Bind, "PlayerSettings", "Switch", "LogoHandling");
                runtime.AddTypeReference(module, typeof(UnityEditor.PlayerSettings.Switch.LogoType), jsb.QuickJS_UnityEditor_PlayerSettings_Switch_LogoType.Bind, "PlayerSettings", "Switch", "LogoType");
                runtime.AddTypeReference(module, typeof(UnityEditor.PlayerSettings.Switch.ApplicationAttribute), jsb.QuickJS_UnityEditor_PlayerSettings_Switch_ApplicationAttribute.Bind, "PlayerSettings", "Switch", "ApplicationAttribute");
                runtime.AddTypeReference(module, typeof(UnityEditor.PlayerSettings.Switch.RatingCategories), jsb.QuickJS_UnityEditor_PlayerSettings_Switch_RatingCategories.Bind, "PlayerSettings", "Switch", "RatingCategories");
                runtime.AddTypeReference(module, typeof(UnityEditor.PlayerSettings.Switch.SupportedNpadStyle), jsb.QuickJS_UnityEditor_PlayerSettings_Switch_SupportedNpadStyle.Bind, "PlayerSettings", "Switch", "SupportedNpadStyle");
                runtime.AddTypeReference(module, typeof(UnityEditor.PlayerSettings.tvOS), jsb.QuickJS_UnityEditor_PlayerSettings_tvOS.Bind, "PlayerSettings", "tvOS");
                // runtime.AddTypeReference(module, typeof(UnityEditor.PlayerSettings.VRCardboard), jsb.QuickJS_UnityEditor_PlayerSettings_VRCardboard.Bind, "PlayerSettings", "VRCardboard");
                // runtime.AddTypeReference(module, typeof(UnityEditor.PlayerSettings.VRDaydream), jsb.QuickJS_UnityEditor_PlayerSettings_VRDaydream.Bind, "PlayerSettings", "VRDaydream");
                runtime.AddTypeReference(module, typeof(UnityEditor.PlayerSettings.WSAApplicationShowName), jsb.QuickJS_UnityEditor_PlayerSettings_WSAApplicationShowName.Bind, "PlayerSettings", "WSAApplicationShowName");
                runtime.AddTypeReference(module, typeof(UnityEditor.PlayerSettings.WSADefaultTileSize), jsb.QuickJS_UnityEditor_PlayerSettings_WSADefaultTileSize.Bind, "PlayerSettings", "WSADefaultTileSize");
                runtime.AddTypeReference(module, typeof(UnityEditor.PlayerSettings.WSAApplicationForegroundText), jsb.QuickJS_UnityEditor_PlayerSettings_WSAApplicationForegroundText.Bind, "PlayerSettings", "WSAApplicationForegroundText");
                runtime.AddTypeReference(module, typeof(UnityEditor.PlayerSettings.WSACapability), jsb.QuickJS_UnityEditor_PlayerSettings_WSACapability.Bind, "PlayerSettings", "WSACapability");
                runtime.AddTypeReference(module, typeof(UnityEditor.PlayerSettings.WSATargetFamily), jsb.QuickJS_UnityEditor_PlayerSettings_WSATargetFamily.Bind, "PlayerSettings", "WSATargetFamily");
                runtime.AddTypeReference(module, typeof(UnityEditor.PlayerSettings.WSAImageScale), jsb.QuickJS_UnityEditor_PlayerSettings_WSAImageScale.Bind, "PlayerSettings", "WSAImageScale");
                runtime.AddTypeReference(module, typeof(UnityEditor.PlayerSettings.WSAImageType), jsb.QuickJS_UnityEditor_PlayerSettings_WSAImageType.Bind, "PlayerSettings", "WSAImageType");
                runtime.AddTypeReference(module, typeof(UnityEditor.PlayerSettings.WSAInputSource), jsb.QuickJS_UnityEditor_PlayerSettings_WSAInputSource.Bind, "PlayerSettings", "WSAInputSource");
                runtime.AddTypeReference(module, typeof(UnityEditor.PlayerSettings.WSASupportedFileType), jsb.QuickJS_UnityEditor_PlayerSettings_WSASupportedFileType.Bind, "PlayerSettings", "WSASupportedFileType");
                runtime.AddTypeReference(module, typeof(UnityEditor.PlayerSettings.WSAFileTypeAssociations), jsb.QuickJS_UnityEditor_PlayerSettings_WSAFileTypeAssociations.Bind, "PlayerSettings", "WSAFileTypeAssociations");
                // runtime.AddTypeReference(module, typeof(UnityEditor.PlayerSettings.WSA), jsb.QuickJS_UnityEditor_PlayerSettings_WSA.Bind, "PlayerSettings", "WSA");
                runtime.AddTypeReference(module, typeof(UnityEditor.PlayerSettings.WSA.Declarations), jsb.QuickJS_UnityEditor_PlayerSettings_WSA_Declarations.Bind, "PlayerSettings", "WSA", "Declarations");
                // runtime.AddTypeReference(module, typeof(UnityEditor.PlayerSettings.WebGL), jsb.QuickJS_UnityEditor_PlayerSettings_WebGL.Bind, "PlayerSettings", "WebGL");
                runtime.AddTypeReference(module, typeof(UnityEditor.PlayerSettings.VRWindowsMixedReality), jsb.QuickJS_UnityEditor_PlayerSettings_VRWindowsMixedReality.Bind, "PlayerSettings", "VRWindowsMixedReality");
                runtime.AddTypeReference(module, typeof(UnityEditor.PlayerSettings.XboxOne), jsb.QuickJS_UnityEditor_PlayerSettings_XboxOne.Bind, "PlayerSettings", "XboxOne");
                // runtime.AddTypeReference(module, typeof(UnityEditor.PlayerSettings.VROculus), jsb.QuickJS_UnityEditor_PlayerSettings_VROculus.Bind, "PlayerSettings", "VROculus");
                runtime.AddTypeReference(module, typeof(UnityEditor.AndroidTargetDevices), jsb.QuickJS_UnityEditor_AndroidTargetDevices.Bind, "AndroidTargetDevices");
                runtime.AddTypeReference(module, typeof(UnityEditor.iOSSdkVersion), jsb.QuickJS_UnityEditor_iOSSdkVersion.Bind, "iOSSdkVersion");
                runtime.AddTypeReference(module, typeof(UnityEditor.iOSTargetDevice), jsb.QuickJS_UnityEditor_iOSTargetDevice.Bind, "iOSTargetDevice");
                runtime.AddTypeReference(module, typeof(UnityEditor.iOSShowActivityIndicatorOnLoading), jsb.QuickJS_UnityEditor_iOSShowActivityIndicatorOnLoading.Bind, "iOSShowActivityIndicatorOnLoading");
                runtime.AddTypeReference(module, typeof(UnityEditor.iOSStatusBarStyle), jsb.QuickJS_UnityEditor_iOSStatusBarStyle.Bind, "iOSStatusBarStyle");
                runtime.AddTypeReference(module, typeof(UnityEditor.iOSAppInBackgroundBehavior), jsb.QuickJS_UnityEditor_iOSAppInBackgroundBehavior.Bind, "iOSAppInBackgroundBehavior");
                runtime.AddTypeReference(module, typeof(UnityEditor.iOSBackgroundMode), jsb.QuickJS_UnityEditor_iOSBackgroundMode.Bind, "iOSBackgroundMode");
                runtime.AddTypeReference(module, typeof(UnityEditor.iOSLaunchScreenImageType), jsb.QuickJS_UnityEditor_iOSLaunchScreenImageType.Bind, "iOSLaunchScreenImageType");
                runtime.AddTypeReference(module, typeof(UnityEditor.iOSLaunchScreenType), jsb.QuickJS_UnityEditor_iOSLaunchScreenType.Bind, "iOSLaunchScreenType");
                runtime.AddTypeReference(module, typeof(UnityEditor.ProvisioningProfileType), jsb.QuickJS_UnityEditor_ProvisioningProfileType.Bind, "ProvisioningProfileType");
                runtime.AddTypeReference(module, typeof(UnityEditor.iOSDeviceRequirement), jsb.QuickJS_UnityEditor_iOSDeviceRequirement.Bind, "iOSDeviceRequirement");
                // runtime.AddTypeReference(module, typeof(UnityEditor.PS5VRRSupport), jsb.QuickJS_UnityEditor_PS5VRRSupport.Bind, "PS5VRRSupport");
                runtime.AddTypeReference(module, typeof(UnityEditor.tvOSSdkVersion), jsb.QuickJS_UnityEditor_tvOSSdkVersion.Bind, "tvOSSdkVersion");
                runtime.AddTypeReference(module, typeof(UnityEditor.WebGLExceptionSupport), jsb.QuickJS_UnityEditor_WebGLExceptionSupport.Bind, "WebGLExceptionSupport");
                runtime.AddTypeReference(module, typeof(UnityEditor.WebGLCompressionFormat), jsb.QuickJS_UnityEditor_WebGLCompressionFormat.Bind, "WebGLCompressionFormat");
                runtime.AddTypeReference(module, typeof(UnityEditor.WebGLLinkerTarget), jsb.QuickJS_UnityEditor_WebGLLinkerTarget.Bind, "WebGLLinkerTarget");
                runtime.AddTypeReference(module, typeof(UnityEditor.XboxOneEncryptionLevel), jsb.QuickJS_UnityEditor_XboxOneEncryptionLevel.Bind, "XboxOneEncryptionLevel");
                runtime.AddTypeReference(module, typeof(UnityEditor.XboxOnePackageUpdateGranularity), jsb.QuickJS_UnityEditor_XboxOnePackageUpdateGranularity.Bind, "XboxOnePackageUpdateGranularity");
                runtime.AddTypeReference(module, typeof(UnityEditor.XboxOneLoggingLevel), jsb.QuickJS_UnityEditor_XboxOneLoggingLevel.Bind, "XboxOneLoggingLevel");
                runtime.AddTypeReference(module, typeof(UnityEditor.SceneVisibilityManager), jsb.QuickJS_UnityEditor_SceneVisibilityManager.Bind, "SceneVisibilityManager");
                runtime.AddTypeReference(module, typeof(UnityEditor.ScriptableSingleton<UnityEditor.SceneVisibilityManager>), jsb.QuickJS_UnityEditor_ScriptableSingleton_SceneVisibilityManager.Bind, "ScriptableSingleton_SceneVisibilityManager");
                runtime.AddTypeReference(module, typeof(UnityEditor.ScriptableWizard), jsb.QuickJS_UnityEditor_ScriptableWizard.Bind, "ScriptableWizard");
                runtime.AddTypeReference(module, typeof(UnityEditor.SelectionMode), jsb.QuickJS_UnityEditor_SelectionMode.Bind, "SelectionMode");
                runtime.AddTypeReference(module, typeof(UnityEditor.Selection), jsb.QuickJS_UnityEditor_Selection.Bind, "Selection");
                runtime.AddTypeReference(module, typeof(UnityEditor.ShaderInfo), jsb.QuickJS_UnityEditor_ShaderInfo.Bind, "ShaderInfo");
                runtime.AddTypeReference(module, typeof(UnityEditor.ShaderMessage), jsb.QuickJS_UnityEditor_ShaderMessage.Bind, "ShaderMessage");
                runtime.AddTypeReference(module, typeof(UnityEditor.ShaderData), jsb.QuickJS_UnityEditor_ShaderData.Bind, "ShaderData");
                runtime.AddTypeReference(module, typeof(UnityEditor.ShaderData.Subshader), jsb.QuickJS_UnityEditor_ShaderData_Subshader.Bind, "ShaderData", "Subshader");
                runtime.AddTypeReference(module, typeof(UnityEditor.ShaderData.Pass), jsb.QuickJS_UnityEditor_ShaderData_Pass.Bind, "ShaderData", "Pass");
                runtime.AddTypeReference(module, typeof(UnityEditor.StaticEditorFlags), jsb.QuickJS_UnityEditor_StaticEditorFlags.Bind, "StaticEditorFlags");
                runtime.AddTypeReference(module, typeof(UnityEditor.StaticOcclusionCulling), jsb.QuickJS_UnityEditor_StaticOcclusionCulling.Bind, "StaticOcclusionCulling");
                runtime.AddTypeReference(module, typeof(UnityEditor.StaticOcclusionCullingVisualization), jsb.QuickJS_UnityEditor_StaticOcclusionCullingVisualization.Bind, "StaticOcclusionCullingVisualization");
                runtime.AddTypeReference(module, typeof(UnityEditor.Undo), jsb.QuickJS_UnityEditor_Undo.Bind, "Undo");
                runtime.AddTypeReference(module, typeof(UnityEditor.Unsupported), jsb.QuickJS_UnityEditor_Unsupported.Bind, "Unsupported");
                runtime.AddTypeReference(module, typeof(UnityEditor.UnwrapParam), jsb.QuickJS_UnityEditor_UnwrapParam.Bind, "UnwrapParam");
                runtime.AddTypeReference(module, typeof(UnityEditor.Unwrapping), jsb.QuickJS_UnityEditor_Unwrapping.Bind, "Unwrapping");
                runtime.AddTypeReference(module, typeof(UnityEditor.VertexChannelCompressionFlags), jsb.QuickJS_UnityEditor_VertexChannelCompressionFlags.Bind, "VertexChannelCompressionFlags");
                runtime.AddTypeReference(module, typeof(UnityEditor.AnimationClipSettings), jsb.QuickJS_UnityEditor_AnimationClipSettings.Bind, "AnimationClipSettings");
                runtime.AddTypeReference(module, typeof(UnityEditor.AnimationMode), jsb.QuickJS_UnityEditor_AnimationMode.Bind, "AnimationMode");
                runtime.AddTypeReference(module, typeof(UnityEditor.ObjectReferenceKeyframe), jsb.QuickJS_UnityEditor_ObjectReferenceKeyframe.Bind, "ObjectReferenceKeyframe");
                runtime.AddTypeReference(module, typeof(UnityEditor.AnimationClipCurveData), jsb.QuickJS_UnityEditor_AnimationClipCurveData.Bind, "AnimationClipCurveData");
                runtime.AddTypeReference(module, typeof(UnityEditor.AnimationUtility), jsb.QuickJS_UnityEditor_AnimationUtility.Bind, "AnimationUtility");
                runtime.AddTypeReference(module, typeof(UnityEditor.AnimationUtility.CurveModifiedType), jsb.QuickJS_UnityEditor_AnimationUtility_CurveModifiedType.Bind, "AnimationUtility", "CurveModifiedType");
                runtime.AddTypeReference(module, typeof(UnityEditor.AnimationUtility.TangentMode), jsb.QuickJS_UnityEditor_AnimationUtility_TangentMode.Bind, "AnimationUtility", "TangentMode");
                runtime.AddTypeReference(module, typeof(UnityEditor.EditorCurveBinding), jsb.QuickJS_UnityEditor_EditorCurveBinding.Bind, "EditorCurveBinding");
                runtime.AddTypeReference(module, typeof(UnityEditor.DrawCameraMode), jsb.QuickJS_UnityEditor_DrawCameraMode.Bind, "DrawCameraMode");
                runtime.AddTypeReference(module, typeof(UnityEditor.AssetPreview), jsb.QuickJS_UnityEditor_AssetPreview.Bind, "AssetPreview");
                runtime.AddTypeReference(module, typeof(UnityEditor.AssetImporter.SourceAssetIdentifier), jsb.QuickJS_UnityEditor_AssetImporter_SourceAssetIdentifier.Bind, "AssetImporter", "SourceAssetIdentifier");
                runtime.AddTypeReference(module, typeof(UnityEditor.IHVImageFormatImporter), jsb.QuickJS_UnityEditor_IHVImageFormatImporter.Bind, "IHVImageFormatImporter");
                runtime.AddTypeReference(module, typeof(UnityEditor.ShaderImporter), jsb.QuickJS_UnityEditor_ShaderImporter.Bind, "ShaderImporter");
                runtime.AddTypeReference(module, typeof(UnityEditor.SpeedTreeImporter), jsb.QuickJS_UnityEditor_SpeedTreeImporter.Bind, "SpeedTreeImporter");
                runtime.AddTypeReference(module, typeof(UnityEditor.SpeedTreeImporter.MaterialLocation), jsb.QuickJS_UnityEditor_SpeedTreeImporter_MaterialLocation.Bind, "SpeedTreeImporter", "MaterialLocation");
                runtime.AddTypeReference(module, typeof(UnityEditor.TextureImporterFormat), jsb.QuickJS_UnityEditor_TextureImporterFormat.Bind, "TextureImporterFormat");
                runtime.AddTypeReference(module, typeof(UnityEditor.TextureImporterMipFilter), jsb.QuickJS_UnityEditor_TextureImporterMipFilter.Bind, "TextureImporterMipFilter");
                runtime.AddTypeReference(module, typeof(UnityEditor.TextureImporterGenerateCubemap), jsb.QuickJS_UnityEditor_TextureImporterGenerateCubemap.Bind, "TextureImporterGenerateCubemap");
                runtime.AddTypeReference(module, typeof(UnityEditor.TextureImporterNPOTScale), jsb.QuickJS_UnityEditor_TextureImporterNPOTScale.Bind, "TextureImporterNPOTScale");
                runtime.AddTypeReference(module, typeof(UnityEditor.TextureImporterNormalFilter), jsb.QuickJS_UnityEditor_TextureImporterNormalFilter.Bind, "TextureImporterNormalFilter");
                runtime.AddTypeReference(module, typeof(UnityEditor.TextureImporterAlphaSource), jsb.QuickJS_UnityEditor_TextureImporterAlphaSource.Bind, "TextureImporterAlphaSource");
                runtime.AddTypeReference(module, typeof(UnityEditor.TextureImporterSingleChannelComponent), jsb.QuickJS_UnityEditor_TextureImporterSingleChannelComponent.Bind, "TextureImporterSingleChannelComponent");
                runtime.AddTypeReference(module, typeof(UnityEditor.TextureImporterType), jsb.QuickJS_UnityEditor_TextureImporterType.Bind, "TextureImporterType");
                runtime.AddTypeReference(module, typeof(UnityEditor.TextureImporterCompression), jsb.QuickJS_UnityEditor_TextureImporterCompression.Bind, "TextureImporterCompression");
                runtime.AddTypeReference(module, typeof(UnityEditor.TextureResizeAlgorithm), jsb.QuickJS_UnityEditor_TextureResizeAlgorithm.Bind, "TextureResizeAlgorithm");
                runtime.AddTypeReference(module, typeof(UnityEditor.TextureImporterShape), jsb.QuickJS_UnityEditor_TextureImporterShape.Bind, "TextureImporterShape");
                runtime.AddTypeReference(module, typeof(UnityEditor.SpriteImportMode), jsb.QuickJS_UnityEditor_SpriteImportMode.Bind, "SpriteImportMode");
                runtime.AddTypeReference(module, typeof(UnityEditor.SpriteMetaData), jsb.QuickJS_UnityEditor_SpriteMetaData.Bind, "SpriteMetaData");
                runtime.AddTypeReference(module, typeof(UnityEditor.TextureImporterSettings), jsb.QuickJS_UnityEditor_TextureImporterSettings.Bind, "TextureImporterSettings");
                runtime.AddTypeReference(module, typeof(UnityEditor.TextureImporterPlatformSettings), jsb.QuickJS_UnityEditor_TextureImporterPlatformSettings.Bind, "TextureImporterPlatformSettings");
                runtime.AddTypeReference(module, typeof(UnityEditor.AssetStoreAsset), jsb.QuickJS_UnityEditor_AssetStoreAsset.Bind, "AssetStoreAsset");
                runtime.AddTypeReference(module, typeof(UnityEditor.AudioCurveRendering), jsb.QuickJS_UnityEditor_AudioCurveRendering.Bind, "AudioCurveRendering");
                runtime.AddTypeReference(module, typeof(UnityEditor.IAudioEffectPlugin), jsb.QuickJS_UnityEditor_IAudioEffectPlugin.Bind, "IAudioEffectPlugin");
                runtime.AddTypeReference(module, typeof(UnityEditor.IAudioEffectPluginGUI), jsb.QuickJS_UnityEditor_IAudioEffectPluginGUI.Bind, "IAudioEffectPluginGUI");
                runtime.AddTypeReference(module, typeof(UnityEditor.Sysroot), jsb.QuickJS_UnityEditor_Sysroot.Bind, "Sysroot");
                runtime.AddTypeReference(module, typeof(UnityEditor.CommandHint), jsb.QuickJS_UnityEditor_CommandHint.Bind, "CommandHint");
                runtime.AddTypeReference(module, typeof(UnityEditor.CommandExecuteContext), jsb.QuickJS_UnityEditor_CommandExecuteContext.Bind, "CommandExecuteContext");
                runtime.AddTypeReference(module, typeof(UnityEditor.CommandService), jsb.QuickJS_UnityEditor_CommandService.Bind, "CommandService");
                runtime.AddTypeReference(module, typeof(UnityEditor.ModeService), jsb.QuickJS_UnityEditor_ModeService.Bind, "ModeService");
                runtime.AddTypeReference(module, typeof(UnityEditor.ModeService.ModeChangedArgs), jsb.QuickJS_UnityEditor_ModeService_ModeChangedArgs.Bind, "ModeService", "ModeChangedArgs");
                runtime.AddTypeReference(module, typeof(UnityEditor.LightingDataAsset), jsb.QuickJS_UnityEditor_LightingDataAsset.Bind, "LightingDataAsset");
                // runtime.AddTypeReference(module, typeof(UnityEditor.LightmapEditorSettings), jsb.QuickJS_UnityEditor_LightmapEditorSettings.Bind, "LightmapEditorSettings");
                runtime.AddTypeReference(module, typeof(UnityEditor.LightmapEditorSettings.Lightmapper), jsb.QuickJS_UnityEditor_LightmapEditorSettings_Lightmapper.Bind, "LightmapEditorSettings", "Lightmapper");
                runtime.AddTypeReference(module, typeof(UnityEditor.LightmapEditorSettings.Sampling), jsb.QuickJS_UnityEditor_LightmapEditorSettings_Sampling.Bind, "LightmapEditorSettings", "Sampling");
                runtime.AddTypeReference(module, typeof(UnityEditor.LightmapEditorSettings.FilterMode), jsb.QuickJS_UnityEditor_LightmapEditorSettings_FilterMode.Bind, "LightmapEditorSettings", "FilterMode");
                runtime.AddTypeReference(module, typeof(UnityEditor.LightmapEditorSettings.DenoiserType), jsb.QuickJS_UnityEditor_LightmapEditorSettings_DenoiserType.Bind, "LightmapEditorSettings", "DenoiserType");
                runtime.AddTypeReference(module, typeof(UnityEditor.LightmapEditorSettings.FilterType), jsb.QuickJS_UnityEditor_LightmapEditorSettings_FilterType.Bind, "LightmapEditorSettings", "FilterType");
                runtime.AddTypeReference(module, typeof(UnityEditor.LightmapParameters), jsb.QuickJS_UnityEditor_LightmapParameters.Bind, "LightmapParameters");
                runtime.AddTypeReference(module, typeof(UnityEditor.Lightmapping), jsb.QuickJS_UnityEditor_Lightmapping.Bind, "Lightmapping");
                runtime.AddTypeReference(module, typeof(UnityEditor.Lightmapping.GIWorkflowMode), jsb.QuickJS_UnityEditor_Lightmapping_GIWorkflowMode.Bind, "Lightmapping", "GIWorkflowMode");
                runtime.AddTypeReference(module, typeof(UnityEditor.PopupWindowContent), jsb.QuickJS_UnityEditor_PopupWindowContent.Bind, "PopupWindowContent");
                runtime.AddTypeReference(module, typeof(UnityEditor.PopupWindow), jsb.QuickJS_UnityEditor_PopupWindow.Bind, "PopupWindow");
                runtime.AddTypeReference(module, typeof(UnityEditor.ViewTool), jsb.QuickJS_UnityEditor_ViewTool.Bind, "ViewTool");
                runtime.AddTypeReference(module, typeof(UnityEditor.PivotMode), jsb.QuickJS_UnityEditor_PivotMode.Bind, "PivotMode");
                runtime.AddTypeReference(module, typeof(UnityEditor.PivotRotation), jsb.QuickJS_UnityEditor_PivotRotation.Bind, "PivotRotation");
                runtime.AddTypeReference(module, typeof(UnityEditor.Tool), jsb.QuickJS_UnityEditor_Tool.Bind, "Tool");
                runtime.AddTypeReference(module, typeof(UnityEditor.Tools), jsb.QuickJS_UnityEditor_Tools.Bind, "Tools");
                runtime.AddTypeReference(module, typeof(UnityEditor.GameViewSizeGroupType), jsb.QuickJS_UnityEditor_GameViewSizeGroupType.Bind, "GameViewSizeGroupType");
                runtime.AddTypeReference(module, typeof(UnityEditor.EditorMaterialUtility), jsb.QuickJS_UnityEditor_EditorMaterialUtility.Bind, "EditorMaterialUtility");
                runtime.AddTypeReference(module, typeof(UnityEditor.EditorSnapSettings), jsb.QuickJS_UnityEditor_EditorSnapSettings.Bind, "EditorSnapSettings");
                runtime.AddTypeReference(module, typeof(UnityEditor.TextureImporterCubemapConvolution), jsb.QuickJS_UnityEditor_TextureImporterCubemapConvolution.Bind, "TextureImporterCubemapConvolution");
                runtime.AddTypeReference(module, typeof(UnityEditor.TextureImporterRGBMMode), jsb.QuickJS_UnityEditor_TextureImporterRGBMMode.Bind, "TextureImporterRGBMMode");
                runtime.AddTypeReference(module, typeof(UnityEditor.CameraEditor.Settings), jsb.QuickJS_UnityEditor_CameraEditor_Settings.Bind, "CameraEditor", "Settings");
                runtime.AddTypeReference(module, typeof(UnityEditor.ObjectPreview), jsb.QuickJS_UnityEditor_ObjectPreview.Bind, "ObjectPreview");
                runtime.AddTypeReference(module, typeof(UnityEditor.CustomEditorForRenderPipelineAttribute), jsb.QuickJS_UnityEditor_CustomEditorForRenderPipelineAttribute.Bind, "CustomEditorForRenderPipelineAttribute");
                runtime.AddTypeReference(module, typeof(UnityEditor.LightEditor), jsb.QuickJS_UnityEditor_LightEditor.Bind, "LightEditor");
                runtime.AddTypeReference(module, typeof(UnityEditor.LightEditor.Settings), jsb.QuickJS_UnityEditor_LightEditor_Settings.Bind, "LightEditor", "Settings");
                runtime.AddTypeReference(module, typeof(UnityEditor.MaterialPropertyDrawer), jsb.QuickJS_UnityEditor_MaterialPropertyDrawer.Bind, "MaterialPropertyDrawer");
                runtime.AddTypeReference(module, typeof(UnityEditor.PreviewRenderUtility), jsb.QuickJS_UnityEditor_PreviewRenderUtility.Bind, "PreviewRenderUtility");
                runtime.AddTypeReference(module, typeof(UnityEditor.ShaderGUI), jsb.QuickJS_UnityEditor_ShaderGUI.Bind, "ShaderGUI");
                runtime.AddTypeReference(module, typeof(UnityEditor.BodyPart), jsb.QuickJS_UnityEditor_BodyPart.Bind, "BodyPart");
                runtime.AddTypeReference(module, typeof(UnityEditor.BoneState), jsb.QuickJS_UnityEditor_BoneState.Bind, "BoneState");
                runtime.AddTypeReference(module, typeof(UnityEditor.PlatformIcon), jsb.QuickJS_UnityEditor_PlatformIcon.Bind, "PlatformIcon");
                runtime.AddTypeReference(module, typeof(UnityEditor.PlatformIconKind), jsb.QuickJS_UnityEditor_PlatformIconKind.Bind, "PlatformIconKind");
                runtime.AddTypeReference(module, typeof(UnityEditor.PrefabUnpackMode), jsb.QuickJS_UnityEditor_PrefabUnpackMode.Bind, "PrefabUnpackMode");
                runtime.AddTypeReference(module, typeof(UnityEditor.PropertyModification), jsb.QuickJS_UnityEditor_PropertyModification.Bind, "PropertyModification");
                runtime.AddTypeReference(module, typeof(UnityEditor.SaveType), jsb.QuickJS_UnityEditor_SaveType.Bind, "SaveType");
                runtime.AddTypeReference(module, typeof(UnityEditor.ProjectWindowUtil), jsb.QuickJS_UnityEditor_ProjectWindowUtil.Bind, "ProjectWindowUtil");
                runtime.AddTypeReference(module, typeof(UnityEditor.SearchableEditorWindow), jsb.QuickJS_UnityEditor_SearchableEditorWindow.Bind, "SearchableEditorWindow");
                runtime.AddTypeReference(module, typeof(UnityEditor.SearchableEditorWindow.SearchMode), jsb.QuickJS_UnityEditor_SearchableEditorWindow_SearchMode.Bind, "SearchableEditorWindow", "SearchMode");
                runtime.AddTypeReference(module, typeof(UnityEditor.SearchableEditorWindow.SearchModeHierarchyWindow), jsb.QuickJS_UnityEditor_SearchableEditorWindow_SearchModeHierarchyWindow.Bind, "SearchableEditorWindow", "SearchModeHierarchyWindow");
                runtime.AddTypeReference(module, typeof(UnityEditor.DefaultLightingExplorerExtension), jsb.QuickJS_UnityEditor_DefaultLightingExplorerExtension.Bind, "DefaultLightingExplorerExtension");
                runtime.AddTypeReference(module, typeof(UnityEditor.LightingExplorerTab), jsb.QuickJS_UnityEditor_LightingExplorerTab.Bind, "LightingExplorerTab");
                runtime.AddTypeReference(module, typeof(UnityEditor.LightingExplorerTableColumn), jsb.QuickJS_UnityEditor_LightingExplorerTableColumn.Bind, "LightingExplorerTableColumn");
                runtime.AddTypeReference(module, typeof(UnityEditor.LightingExplorerTableColumn.DataType), jsb.QuickJS_UnityEditor_LightingExplorerTableColumn_DataType.Bind, "LightingExplorerTableColumn", "DataType");
                runtime.AddTypeReference(module, typeof(UnityEditor.LightingExplorerExtensionAttribute), jsb.QuickJS_UnityEditor_LightingExplorerExtensionAttribute.Bind, "LightingExplorerExtensionAttribute");
                runtime.AddTypeReference(module, typeof(UnityEditor.ILightingExplorerExtension), jsb.QuickJS_UnityEditor_ILightingExplorerExtension.Bind, "ILightingExplorerExtension");
                runtime.AddTypeReference(module, typeof(UnityEditor.LightingWindowEnvironmentSection), jsb.QuickJS_UnityEditor_LightingWindowEnvironmentSection.Bind, "LightingWindowEnvironmentSection");
                runtime.AddTypeReference(module, typeof(UnityEditor.PhysicsDebugWindow), jsb.QuickJS_UnityEditor_PhysicsDebugWindow.Bind, "PhysicsDebugWindow");
                runtime.AddTypeReference(module, typeof(UnityEditor.SceneModeUtility), jsb.QuickJS_UnityEditor_SceneModeUtility.Bind, "SceneModeUtility");
                runtime.AddTypeReference(module, typeof(UnityEditor.SceneView.CameraMode), jsb.QuickJS_UnityEditor_SceneView_CameraMode.Bind, "SceneView", "CameraMode");
                runtime.AddTypeReference(module, typeof(UnityEditor.SceneView.SceneViewState), jsb.QuickJS_UnityEditor_SceneView_SceneViewState.Bind, "SceneView", "SceneViewState");
                runtime.AddTypeReference(module, typeof(UnityEditor.SceneView.CameraSettings), jsb.QuickJS_UnityEditor_SceneView_CameraSettings.Bind, "SceneView", "CameraSettings");
                runtime.AddTypeReference(module, typeof(UnityEditor.DecoratorDrawer), jsb.QuickJS_UnityEditor_DecoratorDrawer.Bind, "DecoratorDrawer");
                runtime.AddTypeReference(module, typeof(UnityEditor.GUIDrawer), jsb.QuickJS_UnityEditor_GUIDrawer.Bind, "GUIDrawer");
                runtime.AddTypeReference(module, typeof(UnityEditor.PropertyDrawer), jsb.QuickJS_UnityEditor_PropertyDrawer.Bind, "PropertyDrawer");
                runtime.AddTypeReference(module, typeof(UnityEditor.SettingsScope), jsb.QuickJS_UnityEditor_SettingsScope.Bind, "SettingsScope");
                runtime.AddTypeReference(module, typeof(UnityEditor.SettingsProvider), jsb.QuickJS_UnityEditor_SettingsProvider.Bind, "SettingsProvider");
                runtime.AddTypeReference(module, typeof(UnityEditor.SettingsService), jsb.QuickJS_UnityEditor_SettingsService.Bind, "SettingsService");
                runtime.AddTypeReference(module, typeof(UnityEditor.AssetSettingsProvider), jsb.QuickJS_UnityEditor_AssetSettingsProvider.Bind, "AssetSettingsProvider");
                runtime.AddTypeReference(module, typeof(UnityEditor.Highlighter), jsb.QuickJS_UnityEditor_Highlighter.Bind, "Highlighter");
                runtime.AddTypeReference(module, typeof(UnityEditor.HighlightSearchMode), jsb.QuickJS_UnityEditor_HighlightSearchMode.Bind, "HighlightSearchMode");
                runtime.AddTypeReference(module, typeof(UnityEditor.UndoPropertyModification), jsb.QuickJS_UnityEditor_UndoPropertyModification.Bind, "UndoPropertyModification");
                runtime.AddTypeReference(module, typeof(UnityEditor.CloudProjectSettings), jsb.QuickJS_UnityEditor_CloudProjectSettings.Bind, "CloudProjectSettings");
                runtime.AddTypeReference(module, typeof(UnityEditor.ExpressionEvaluator), jsb.QuickJS_UnityEditor_ExpressionEvaluator.Bind, "ExpressionEvaluator");
                runtime.AddTypeReference(module, typeof(UnityEditor.MathUtils), jsb.QuickJS_UnityEditor_MathUtils.Bind, "MathUtils");
                runtime.AddTypeReference(module, typeof(UnityEditor.RemoveAssetOptions), jsb.QuickJS_UnityEditor_RemoveAssetOptions.Bind, "RemoveAssetOptions");
                runtime.AddTypeReference(module, typeof(UnityEditor.AndroidAssetPackImporter), jsb.QuickJS_UnityEditor_AndroidAssetPackImporter.Bind, "AndroidAssetPackImporter");
                runtime.AddTypeReference(module, typeof(UnityEditor.AudioSampleRateSetting), jsb.QuickJS_UnityEditor_AudioSampleRateSetting.Bind, "AudioSampleRateSetting");
                runtime.AddTypeReference(module, typeof(UnityEditor.AudioImporterSampleSettings), jsb.QuickJS_UnityEditor_AudioImporterSampleSettings.Bind, "AudioImporterSampleSettings");
                runtime.AddTypeReference(module, typeof(UnityEditor.MonoImporter), jsb.QuickJS_UnityEditor_MonoImporter.Bind, "MonoImporter");
                runtime.AddTypeReference(module, typeof(UnityEditor.PluginImporter), jsb.QuickJS_UnityEditor_PluginImporter.Bind, "PluginImporter");
                runtime.AddTypeReference(module, typeof(UnityEditor.VideoCodec), jsb.QuickJS_UnityEditor_VideoCodec.Bind, "VideoCodec");
                runtime.AddTypeReference(module, typeof(UnityEditor.VideoBitrateMode), jsb.QuickJS_UnityEditor_VideoBitrateMode.Bind, "VideoBitrateMode");
                runtime.AddTypeReference(module, typeof(UnityEditor.VideoDeinterlaceMode), jsb.QuickJS_UnityEditor_VideoDeinterlaceMode.Bind, "VideoDeinterlaceMode");
                runtime.AddTypeReference(module, typeof(UnityEditor.VideoResizeMode), jsb.QuickJS_UnityEditor_VideoResizeMode.Bind, "VideoResizeMode");
                runtime.AddTypeReference(module, typeof(UnityEditor.VideoSpatialQuality), jsb.QuickJS_UnityEditor_VideoSpatialQuality.Bind, "VideoSpatialQuality");
                runtime.AddTypeReference(module, typeof(UnityEditor.VideoEncodeAspectRatio), jsb.QuickJS_UnityEditor_VideoEncodeAspectRatio.Bind, "VideoEncodeAspectRatio");
                runtime.AddTypeReference(module, typeof(UnityEditor.VideoImporterTargetSettings), jsb.QuickJS_UnityEditor_VideoImporterTargetSettings.Bind, "VideoImporterTargetSettings");
                runtime.AddTypeReference(module, typeof(UnityEditor.MeshOptimizationFlags), jsb.QuickJS_UnityEditor_MeshOptimizationFlags.Bind, "MeshOptimizationFlags");
                runtime.AddTypeReference(module, typeof(UnityEditor.ClipAnimationMaskType), jsb.QuickJS_UnityEditor_ClipAnimationMaskType.Bind, "ClipAnimationMaskType");
                runtime.AddTypeReference(module, typeof(UnityEditor.ClipAnimationInfoCurve), jsb.QuickJS_UnityEditor_ClipAnimationInfoCurve.Bind, "ClipAnimationInfoCurve");
                runtime.AddTypeReference(module, typeof(UnityEditor.ModelImporterClipAnimation), jsb.QuickJS_UnityEditor_ModelImporterClipAnimation.Bind, "ModelImporterClipAnimation");
                runtime.AddTypeReference(module, typeof(UnityEditor.ModelImporterMaterialName), jsb.QuickJS_UnityEditor_ModelImporterMaterialName.Bind, "ModelImporterMaterialName");
                runtime.AddTypeReference(module, typeof(UnityEditor.ModelImporterMaterialSearch), jsb.QuickJS_UnityEditor_ModelImporterMaterialSearch.Bind, "ModelImporterMaterialSearch");
                runtime.AddTypeReference(module, typeof(UnityEditor.ModelImporterMaterialLocation), jsb.QuickJS_UnityEditor_ModelImporterMaterialLocation.Bind, "ModelImporterMaterialLocation");
                runtime.AddTypeReference(module, typeof(UnityEditor.ModelImporterMaterialImportMode), jsb.QuickJS_UnityEditor_ModelImporterMaterialImportMode.Bind, "ModelImporterMaterialImportMode");
                runtime.AddTypeReference(module, typeof(UnityEditor.ModelImporterTangentSpaceMode), jsb.QuickJS_UnityEditor_ModelImporterTangentSpaceMode.Bind, "ModelImporterTangentSpaceMode");
                runtime.AddTypeReference(module, typeof(UnityEditor.ModelImporterNormals), jsb.QuickJS_UnityEditor_ModelImporterNormals.Bind, "ModelImporterNormals");
                runtime.AddTypeReference(module, typeof(UnityEditor.ModelImporterNormalCalculationMode), jsb.QuickJS_UnityEditor_ModelImporterNormalCalculationMode.Bind, "ModelImporterNormalCalculationMode");
                runtime.AddTypeReference(module, typeof(UnityEditor.ModelImporterNormalSmoothingSource), jsb.QuickJS_UnityEditor_ModelImporterNormalSmoothingSource.Bind, "ModelImporterNormalSmoothingSource");
                runtime.AddTypeReference(module, typeof(UnityEditor.ModelImporterTangents), jsb.QuickJS_UnityEditor_ModelImporterTangents.Bind, "ModelImporterTangents");
                runtime.AddTypeReference(module, typeof(UnityEditor.ModelImporterMeshCompression), jsb.QuickJS_UnityEditor_ModelImporterMeshCompression.Bind, "ModelImporterMeshCompression");
                runtime.AddTypeReference(module, typeof(UnityEditor.ModelImporterIndexFormat), jsb.QuickJS_UnityEditor_ModelImporterIndexFormat.Bind, "ModelImporterIndexFormat");
                runtime.AddTypeReference(module, typeof(UnityEditor.ModelImporterAnimationCompression), jsb.QuickJS_UnityEditor_ModelImporterAnimationCompression.Bind, "ModelImporterAnimationCompression");
                runtime.AddTypeReference(module, typeof(UnityEditor.ModelImporterGenerateAnimations), jsb.QuickJS_UnityEditor_ModelImporterGenerateAnimations.Bind, "ModelImporterGenerateAnimations");
                runtime.AddTypeReference(module, typeof(UnityEditor.ModelImporterAnimationType), jsb.QuickJS_UnityEditor_ModelImporterAnimationType.Bind, "ModelImporterAnimationType");
                runtime.AddTypeReference(module, typeof(UnityEditor.ModelImporterHumanoidOversampling), jsb.QuickJS_UnityEditor_ModelImporterHumanoidOversampling.Bind, "ModelImporterHumanoidOversampling");
                runtime.AddTypeReference(module, typeof(UnityEditor.ModelImporterAvatarSetup), jsb.QuickJS_UnityEditor_ModelImporterAvatarSetup.Bind, "ModelImporterAvatarSetup");
                runtime.AddTypeReference(module, typeof(UnityEditor.ModelImporterSkinWeights), jsb.QuickJS_UnityEditor_ModelImporterSkinWeights.Bind, "ModelImporterSkinWeights");
                runtime.AddTypeReference(module, typeof(UnityEditor.PhysicsVisualizationSettings), jsb.QuickJS_UnityEditor_PhysicsVisualizationSettings.Bind, "PhysicsVisualizationSettings");
                runtime.AddTypeReference(module, typeof(UnityEditor.PhysicsVisualizationSettings.FilterWorkflow), jsb.QuickJS_UnityEditor_PhysicsVisualizationSettings_FilterWorkflow.Bind, "PhysicsVisualizationSettings", "FilterWorkflow");
                runtime.AddTypeReference(module, typeof(UnityEditor.PhysicsVisualizationSettings.MeshColliderType), jsb.QuickJS_UnityEditor_PhysicsVisualizationSettings_MeshColliderType.Bind, "PhysicsVisualizationSettings", "MeshColliderType");
                runtime.AddTypeReference(module, typeof(UnityEditor.SketchUpImportCamera), jsb.QuickJS_UnityEditor_SketchUpImportCamera.Bind, "SketchUpImportCamera");
                runtime.AddTypeReference(module, typeof(UnityEditor.SketchUpImportScene), jsb.QuickJS_UnityEditor_SketchUpImportScene.Bind, "SketchUpImportScene");
                runtime.AddTypeReference(module, typeof(UnityEditor.SketchUpImporter), jsb.QuickJS_UnityEditor_SketchUpImporter.Bind, "SketchUpImporter");
                runtime.AddTypeReference(module, typeof(UnityEditor.TerrainLayerInspector), jsb.QuickJS_UnityEditor_TerrainLayerInspector.Bind, "TerrainLayerInspector");
                runtime.AddTypeReference(module, typeof(UnityEditor.ITerrainLayerCustomUI), jsb.QuickJS_UnityEditor_ITerrainLayerCustomUI.Bind, "ITerrainLayerCustomUI");
                runtime.AddTypeReference(module, typeof(UnityEditor.TerrainLayerUtility), jsb.QuickJS_UnityEditor_TerrainLayerUtility.Bind, "TerrainLayerUtility");
                runtime.AddTypeReference(module, typeof(UnityEditor.FontTextureCase), jsb.QuickJS_UnityEditor_FontTextureCase.Bind, "FontTextureCase");
                runtime.AddTypeReference(module, typeof(UnityEditor.FontRenderingMode), jsb.QuickJS_UnityEditor_FontRenderingMode.Bind, "FontRenderingMode");
                runtime.AddTypeReference(module, typeof(UnityEditor.AscentCalculationMode), jsb.QuickJS_UnityEditor_AscentCalculationMode.Bind, "AscentCalculationMode");
                runtime.AddTypeReference(module, typeof(UnityEditor.TrueTypeFontImporter), jsb.QuickJS_UnityEditor_TrueTypeFontImporter.Bind, "TrueTypeFontImporter");
                runtime.AddTypeReference(module, typeof(UnityEditor.GridPalette), jsb.QuickJS_UnityEditor_GridPalette.Bind, "GridPalette");
                runtime.AddTypeReference(module, typeof(UnityEditor.GridPalette.CellSizing), jsb.QuickJS_UnityEditor_GridPalette_CellSizing.Bind, "GridPalette", "CellSizing");
                runtime.AddTypeReference(module, typeof(UnityEditor.EditorAnalytics), jsb.QuickJS_UnityEditor_EditorAnalytics.Bind, "EditorAnalytics");
                runtime.AddTypeReference(module, typeof(UnityEditor.EditorAnalyticsSessionInfo), jsb.QuickJS_UnityEditor_EditorAnalyticsSessionInfo.Bind, "EditorAnalyticsSessionInfo");
                runtime.AddTypeReference(module, typeof(UnityEditor.AssetModificationProcessor), jsb.QuickJS_UnityEditor_AssetModificationProcessor.Bind, "AssetModificationProcessor");
                runtime.AddTypeReference(module, typeof(UnityEditor.InspectorMode), jsb.QuickJS_UnityEditor_InspectorMode.Bind, "InspectorMode");
                runtime.AddTypeReference(module, typeof(UnityEditor.HierarchyType), jsb.QuickJS_UnityEditor_HierarchyType.Bind, "HierarchyType");
                runtime.AddTypeReference(module, typeof(UnityEditor.IconDrawStyle), jsb.QuickJS_UnityEditor_IconDrawStyle.Bind, "IconDrawStyle");
                runtime.AddTypeReference(module, typeof(UnityEditor.HierarchyProperty), jsb.QuickJS_UnityEditor_HierarchyProperty.Bind, "HierarchyProperty");
                runtime.AddTypeReference(module, typeof(UnityEditor.LODUtility), jsb.QuickJS_UnityEditor_LODUtility.Bind, "LODUtility");
                // runtime.AddTypeReference(module, typeof(UnityEditor.UnityStats), jsb.QuickJS_UnityEditor_UnityStats.Bind, "UnityStats");
#endif
            });
            runtime.AddStaticModuleProxy("UnityEditor.Build.Reporting", (rt, module) =>
            {
#if UNITY_EDITOR
                runtime.AddTypeReference(module, typeof(UnityEditor.Build.Reporting.BuildReport), jsb.QuickJS_UnityEditor_Build_Reporting_BuildReport.Bind, "BuildReport");
                runtime.AddTypeReference(module, typeof(UnityEditor.Build.Reporting.BuildFile), jsb.QuickJS_UnityEditor_Build_Reporting_BuildFile.Bind, "BuildFile");
                runtime.AddTypeReference(module, typeof(UnityEditor.Build.Reporting.BuildResult), jsb.QuickJS_UnityEditor_Build_Reporting_BuildResult.Bind, "BuildResult");
                runtime.AddTypeReference(module, typeof(UnityEditor.Build.Reporting.BuildStep), jsb.QuickJS_UnityEditor_Build_Reporting_BuildStep.Bind, "BuildStep");
                runtime.AddTypeReference(module, typeof(UnityEditor.Build.Reporting.BuildStepMessage), jsb.QuickJS_UnityEditor_Build_Reporting_BuildStepMessage.Bind, "BuildStepMessage");
                runtime.AddTypeReference(module, typeof(UnityEditor.Build.Reporting.BuildSummary), jsb.QuickJS_UnityEditor_Build_Reporting_BuildSummary.Bind, "BuildSummary");
                runtime.AddTypeReference(module, typeof(UnityEditor.Build.Reporting.CommonRoles), jsb.QuickJS_UnityEditor_Build_Reporting_CommonRoles.Bind, "CommonRoles");
                runtime.AddTypeReference(module, typeof(UnityEditor.Build.Reporting.PackedAssetInfo), jsb.QuickJS_UnityEditor_Build_Reporting_PackedAssetInfo.Bind, "PackedAssetInfo");
                // runtime.AddTypeReference(module, typeof(UnityEditor.Build.Reporting.PackedAssets), jsb.QuickJS_UnityEditor_Build_Reporting_PackedAssets.Bind, "PackedAssets");
                runtime.AddTypeReference(module, typeof(UnityEditor.Build.Reporting.StrippingInfo), jsb.QuickJS_UnityEditor_Build_Reporting_StrippingInfo.Bind, "StrippingInfo");
#endif
            });
            runtime.AddStaticModuleProxy("Example.New.World", (rt, module) =>
            {
                runtime.AddTypeReference(module, typeof(Example.New.World.Galaxy), jsb.QuickJS_Example_New_World_Galaxy.Bind, "Galaxy");
                runtime.AddTypeReference(module, typeof(Example.New.World.IncompatibleOverloadTest1), jsb.QuickJS_Example_New_World_IncompatibleOverloadTest1.Bind, "IncompatibleOverloadTest1");
                runtime.AddTypeReference(module, typeof(Example.New.World.IncompatibleOverloadTest2), jsb.QuickJS_Example_New_World_IncompatibleOverloadTest2.Bind, "IncompatibleOverloadTest2");
                runtime.AddTypeReference(module, typeof(Example.New.World.Galaxy.Sun), jsb.QuickJS_Example_New_World_Galaxy_Sun.Bind, "Galaxy", "Sun");
                runtime.AddTypeReference(module, typeof(Example.New.World.Galaxy.Earth), jsb.QuickJS_Example_New_World_Galaxy_Earth.Bind, "Galaxy", "Earth");
                runtime.AddTypeReference(module, typeof(Example.New.World.Galaxy.Earth.Ocean), jsb.QuickJS_Example_New_World_Galaxy_Earth_Ocean.Bind, "Galaxy", "Earth", "Ocean");
                runtime.AddTypeReference(module, typeof(Example.New.World.Galaxy.Earth.Continent), jsb.QuickJS_Example_New_World_Galaxy_Earth_Continent.Bind, "Galaxy", "Earth", "Continent");
            });
            runtime.AddStaticModuleProxy("QuickJS.IO", (rt, module) =>
            {
                runtime.AddTypeReference(module, typeof(QuickJS.IO.ByteBuffer), jsb.QuickJS_QuickJS_IO_ByteBuffer.Bind, "ByteBuffer");
            });
            runtime.AddStaticModuleProxy("UnityEditor.Hardware", (rt, module) =>
            {
#if UNITY_EDITOR
                runtime.AddTypeReference(module, typeof(UnityEditor.Hardware.UsbDevice), jsb.QuickJS_UnityEditor_Hardware_UsbDevice.Bind, "UsbDevice");
                runtime.AddTypeReference(module, typeof(UnityEditor.Hardware.Usb), jsb.QuickJS_UnityEditor_Hardware_Usb.Bind, "Usb");
                runtime.AddTypeReference(module, typeof(UnityEditor.Hardware.DevDeviceList), jsb.QuickJS_UnityEditor_Hardware_DevDeviceList.Bind, "DevDeviceList");
                runtime.AddTypeReference(module, typeof(UnityEditor.Hardware.DevDeviceState), jsb.QuickJS_UnityEditor_Hardware_DevDeviceState.Bind, "DevDeviceState");
                runtime.AddTypeReference(module, typeof(UnityEditor.Hardware.DevDeviceFeatures), jsb.QuickJS_UnityEditor_Hardware_DevDeviceFeatures.Bind, "DevDeviceFeatures");
                runtime.AddTypeReference(module, typeof(UnityEditor.Hardware.DevDevice), jsb.QuickJS_UnityEditor_Hardware_DevDevice.Bind, "DevDevice");
#endif
            });
            runtime.AddStaticModuleProxy("UnityEditor.Purchasing", (rt, module) =>
            {
#if UNITY_EDITOR
                runtime.AddTypeReference(module, typeof(UnityEditor.Purchasing.PurchasingSettings), jsb.QuickJS_UnityEditor_Purchasing_PurchasingSettings.Bind, "PurchasingSettings");
#endif
            });
            runtime.AddStaticModuleProxy("UnityEditor.Analytics", (rt, module) =>
            {
#if UNITY_EDITOR
                runtime.AddTypeReference(module, typeof(UnityEditor.Analytics.AnalyticsSettings), jsb.QuickJS_UnityEditor_Analytics_AnalyticsSettings.Bind, "AnalyticsSettings");
                runtime.AddTypeReference(module, typeof(UnityEditor.Analytics.PerformanceReportingSettings), jsb.QuickJS_UnityEditor_Analytics_PerformanceReportingSettings.Bind, "PerformanceReportingSettings");
#endif
            });
            runtime.AddStaticModuleProxy("UnityEditor.Advertisements", (rt, module) =>
            {
#if UNITY_EDITOR
                runtime.AddTypeReference(module, typeof(UnityEditor.Advertisements.AdvertisementSettings), jsb.QuickJS_UnityEditor_Advertisements_AdvertisementSettings.Bind, "AdvertisementSettings");
#endif
            });
            runtime.AddStaticModuleProxy("UnityEditor.Events", (rt, module) =>
            {
#if UNITY_EDITOR
                runtime.AddTypeReference(module, typeof(UnityEditor.Events.UnityEventTools), jsb.QuickJS_UnityEditor_Events_UnityEventTools.Bind, "UnityEventTools");
#endif
            });
            runtime.AddStaticModuleProxy("UnityEditor.Connect", (rt, module) =>
            {
#if UNITY_EDITOR
                runtime.AddTypeReference(module, typeof(UnityEditor.Connect.UnityOAuth), jsb.QuickJS_UnityEditor_Connect_UnityOAuth.Bind, "UnityOAuth");
                runtime.AddTypeReference(module, typeof(UnityEditor.Connect.UnityOAuth.AuthCodeResponse), jsb.QuickJS_UnityEditor_Connect_UnityOAuth_AuthCodeResponse.Bind, "UnityOAuth", "AuthCodeResponse");
#endif
            });
            runtime.AddStaticModuleProxy("UnityEditor.ProjectWindowCallback", (rt, module) =>
            {
#if UNITY_EDITOR
                runtime.AddTypeReference(module, typeof(UnityEditor.ProjectWindowCallback.EndNameEditAction), jsb.QuickJS_UnityEditor_ProjectWindowCallback_EndNameEditAction.Bind, "EndNameEditAction");
#endif
            });
            runtime.AddStaticModuleProxy("UnityEditor.Playables", (rt, module) =>
            {
#if UNITY_EDITOR
                runtime.AddTypeReference(module, typeof(UnityEditor.Playables.PlayableOutputEditorExtensions), jsb.QuickJS_UnityEditor_Playables_PlayableOutputEditorExtensions.Bind, "PlayableOutputEditorExtensions");
                runtime.AddTypeReference(module, typeof(UnityEditor.Playables.Utility), jsb.QuickJS_UnityEditor_Playables_Utility.Bind, "Utility");
#endif
            });
            runtime.AddStaticModuleProxy("UnityEditor.Media", (rt, module) =>
            {
#if UNITY_EDITOR
                runtime.AddTypeReference(module, typeof(UnityEditor.Media.MediaRational), jsb.QuickJS_UnityEditor_Media_MediaRational.Bind, "MediaRational");
                runtime.AddTypeReference(module, typeof(UnityEditor.Media.MediaTime), jsb.QuickJS_UnityEditor_Media_MediaTime.Bind, "MediaTime");
                runtime.AddTypeReference(module, typeof(UnityEditor.Media.VideoTrackAttributes), jsb.QuickJS_UnityEditor_Media_VideoTrackAttributes.Bind, "VideoTrackAttributes");
                runtime.AddTypeReference(module, typeof(UnityEditor.Media.AudioTrackAttributes), jsb.QuickJS_UnityEditor_Media_AudioTrackAttributes.Bind, "AudioTrackAttributes");
                runtime.AddTypeReference(module, typeof(UnityEditor.Media.MediaEncoder), jsb.QuickJS_UnityEditor_Media_MediaEncoder.Bind, "MediaEncoder");
#endif
            });
            runtime.AddStaticModuleProxy("UnityEditor.EditorTools", (rt, module) =>
            {
#if UNITY_EDITOR
                runtime.AddTypeReference(module, typeof(UnityEditor.EditorTools.IDrawSelectedHandles), jsb.QuickJS_UnityEditor_EditorTools_IDrawSelectedHandles.Bind, "IDrawSelectedHandles");
                runtime.AddTypeReference(module, typeof(UnityEditor.EditorTools.EditorTool), jsb.QuickJS_UnityEditor_EditorTools_EditorTool.Bind, "EditorTool");
                runtime.AddTypeReference(module, typeof(UnityEditor.EditorTools.ToolManager), jsb.QuickJS_UnityEditor_EditorTools_EditorTools.Bind, "EditorTools");
#endif
            });
            runtime.AddStaticModuleProxy("UnityEditor.Build", (rt, module) =>
            {
#if UNITY_EDITOR
                runtime.AddTypeReference(module, typeof(UnityEditor.Build.BuildFailedException), jsb.QuickJS_UnityEditor_Build_BuildFailedException.Bind, "BuildFailedException");
                runtime.AddTypeReference(module, typeof(UnityEditor.Build.IOrderedCallback), jsb.QuickJS_UnityEditor_Build_IOrderedCallback.Bind, "IOrderedCallback");
                runtime.AddTypeReference(module, typeof(UnityEditor.Build.IPreprocessBuildWithReport), jsb.QuickJS_UnityEditor_Build_IPreprocessBuildWithReport.Bind, "IPreprocessBuildWithReport");
                runtime.AddTypeReference(module, typeof(UnityEditor.Build.IFilterBuildAssemblies), jsb.QuickJS_UnityEditor_Build_IFilterBuildAssemblies.Bind, "IFilterBuildAssemblies");
                runtime.AddTypeReference(module, typeof(UnityEditor.Build.IPostprocessBuildWithReport), jsb.QuickJS_UnityEditor_Build_IPostprocessBuildWithReport.Bind, "IPostprocessBuildWithReport");
                runtime.AddTypeReference(module, typeof(UnityEditor.Build.IPostBuildPlayerScriptDLLs), jsb.QuickJS_UnityEditor_Build_IPostBuildPlayerScriptDLLs.Bind, "IPostBuildPlayerScriptDLLs");
                runtime.AddTypeReference(module, typeof(UnityEditor.Build.IProcessSceneWithReport), jsb.QuickJS_UnityEditor_Build_IProcessSceneWithReport.Bind, "IProcessSceneWithReport");
                runtime.AddTypeReference(module, typeof(UnityEditor.Build.IActiveBuildTargetChanged), jsb.QuickJS_UnityEditor_Build_IActiveBuildTargetChanged.Bind, "IActiveBuildTargetChanged");
                runtime.AddTypeReference(module, typeof(UnityEditor.Build.IPreprocessShaders), jsb.QuickJS_UnityEditor_Build_IPreprocessShaders.Bind, "IPreprocessShaders");
                // runtime.AddTypeReference(module, typeof(UnityEditor.Build.IUnityLinkerProcessor), jsb.QuickJS_UnityEditor_Build_IUnityLinkerProcessor.Bind, "IUnityLinkerProcessor");
                // runtime.AddTypeReference(module, typeof(UnityEditor.Build.IIl2CppProcessor), jsb.QuickJS_UnityEditor_Build_IIl2CppProcessor.Bind, "IIl2CppProcessor");
#endif
            });
            runtime.AddStaticModuleProxy("UnityEditor.SceneManagement", (rt, module) =>
            {
#if UNITY_EDITOR
                runtime.AddTypeReference(module, typeof(UnityEditor.SceneManagement.EditorSceneManager), jsb.QuickJS_UnityEditor_SceneManagement_EditorSceneManager.Bind, "EditorSceneManager");
                runtime.AddTypeReference(module, typeof(UnityEditor.SceneManagement.OpenSceneMode), jsb.QuickJS_UnityEditor_SceneManagement_OpenSceneMode.Bind, "OpenSceneMode");
                runtime.AddTypeReference(module, typeof(UnityEditor.SceneManagement.NewSceneMode), jsb.QuickJS_UnityEditor_SceneManagement_NewSceneMode.Bind, "NewSceneMode");
                runtime.AddTypeReference(module, typeof(UnityEditor.SceneManagement.NewSceneSetup), jsb.QuickJS_UnityEditor_SceneManagement_NewSceneSetup.Bind, "NewSceneSetup");
                runtime.AddTypeReference(module, typeof(UnityEditor.SceneManagement.SceneHierarchyHooks), jsb.QuickJS_UnityEditor_SceneManagement_SceneHierarchyHooks.Bind, "SceneHierarchyHooks");
                runtime.AddTypeReference(module, typeof(UnityEditor.SceneManagement.SceneHierarchyHooks.SubSceneInfo), jsb.QuickJS_UnityEditor_SceneManagement_SceneHierarchyHooks_SubSceneInfo.Bind, "SceneHierarchyHooks", "SubSceneInfo");
                runtime.AddTypeReference(module, typeof(UnityEditor.SceneManagement.SceneSetup), jsb.QuickJS_UnityEditor_SceneManagement_SceneSetup.Bind, "SceneSetup");
                runtime.AddTypeReference(module, typeof(UnityEditor.SceneManagement.StageHandle), jsb.QuickJS_UnityEditor_SceneManagement_StageHandle.Bind, "StageHandle");
                runtime.AddTypeReference(module, typeof(UnityEditor.SceneManagement.StageUtility), jsb.QuickJS_UnityEditor_SceneManagement_StageUtility.Bind, "StageUtility");
#endif
            });
            runtime.AddStaticModuleProxy("UnityEngine.SceneManagement", (rt, module) =>
            {
                runtime.AddTypeReference(module, typeof(UnityEngine.SceneManagement.SceneManager), jsb.QuickJS_UnityEngine_SceneManagement_SceneManager.Bind, "SceneManager");
            });
            runtime.AddStaticModuleProxy("UnityEditor.Callbacks", (rt, module) =>
            {
#if UNITY_EDITOR
                runtime.AddTypeReference(module, typeof(UnityEditor.Callbacks.PostProcessBuildAttribute), jsb.QuickJS_UnityEditor_Callbacks_PostProcessBuildAttribute.Bind, "PostProcessBuildAttribute");
                runtime.AddTypeReference(module, typeof(UnityEditor.Callbacks.PostProcessSceneAttribute), jsb.QuickJS_UnityEditor_Callbacks_PostProcessSceneAttribute.Bind, "PostProcessSceneAttribute");
                runtime.AddTypeReference(module, typeof(UnityEditor.Callbacks.DidReloadScripts), jsb.QuickJS_UnityEditor_Callbacks_DidReloadScripts.Bind, "DidReloadScripts");
                runtime.AddTypeReference(module, typeof(UnityEditor.Callbacks.OnOpenAssetAttribute), jsb.QuickJS_UnityEditor_Callbacks_OnOpenAssetAttribute.Bind, "OnOpenAssetAttribute");
#endif
            });
            runtime.AddStaticModuleProxy("UnityEngine.UI", (rt, module) =>
            {
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.AnimationTriggers), jsb.QuickJS_UnityEngine_UI_AnimationTriggers.Bind, "AnimationTriggers");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.Button), jsb.QuickJS_UnityEngine_UI_Button.Bind, "Button");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.Selectable), jsb.QuickJS_UnityEngine_UI_Selectable.Bind, "Selectable");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.CanvasUpdate), jsb.QuickJS_UnityEngine_UI_CanvasUpdate.Bind, "CanvasUpdate");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.ICanvasElement), jsb.QuickJS_UnityEngine_UI_ICanvasElement.Bind, "ICanvasElement");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.CanvasUpdateRegistry), jsb.QuickJS_UnityEngine_UI_CanvasUpdateRegistry.Bind, "CanvasUpdateRegistry");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.ColorBlock), jsb.QuickJS_UnityEngine_UI_ColorBlock.Bind, "ColorBlock");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.ClipperRegistry), jsb.QuickJS_UnityEngine_UI_ClipperRegistry.Bind, "ClipperRegistry");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.Clipping), jsb.QuickJS_UnityEngine_UI_Clipping.Bind, "Clipping");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.IClipper), jsb.QuickJS_UnityEngine_UI_IClipper.Bind, "IClipper");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.IClippable), jsb.QuickJS_UnityEngine_UI_IClippable.Bind, "IClippable");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.DefaultControls), jsb.QuickJS_UnityEngine_UI_DefaultControls.Bind, "DefaultControls");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.Dropdown), jsb.QuickJS_UnityEngine_UI_Dropdown.Bind, "Dropdown");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.FontData), jsb.QuickJS_UnityEngine_UI_FontData.Bind, "FontData");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.FontUpdateTracker), jsb.QuickJS_UnityEngine_UI_FontUpdateTracker.Bind, "FontUpdateTracker");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.Graphic), jsb.QuickJS_UnityEngine_UI_Graphic.Bind, "Graphic");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.GraphicRaycaster), jsb.QuickJS_UnityEngine_UI_GraphicRaycaster.Bind, "GraphicRaycaster");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.GraphicRegistry), jsb.QuickJS_UnityEngine_UI_GraphicRegistry.Bind, "GraphicRegistry");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.IMaskable), jsb.QuickJS_UnityEngine_UI_IMaskable.Bind, "IMaskable");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.Image), jsb.QuickJS_UnityEngine_UI_Image.Bind, "Image");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.MaskableGraphic), jsb.QuickJS_UnityEngine_UI_MaskableGraphic.Bind, "MaskableGraphic");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.InputField), jsb.QuickJS_UnityEngine_UI_InputField.Bind, "InputField");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.AspectRatioFitter), jsb.QuickJS_UnityEngine_UI_AspectRatioFitter.Bind, "AspectRatioFitter");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.CanvasScaler), jsb.QuickJS_UnityEngine_UI_CanvasScaler.Bind, "CanvasScaler");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.ContentSizeFitter), jsb.QuickJS_UnityEngine_UI_ContentSizeFitter.Bind, "ContentSizeFitter");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.GridLayoutGroup), jsb.QuickJS_UnityEngine_UI_GridLayoutGroup.Bind, "GridLayoutGroup");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.LayoutGroup), jsb.QuickJS_UnityEngine_UI_LayoutGroup.Bind, "LayoutGroup");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.HorizontalLayoutGroup), jsb.QuickJS_UnityEngine_UI_HorizontalLayoutGroup.Bind, "HorizontalLayoutGroup");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.HorizontalOrVerticalLayoutGroup), jsb.QuickJS_UnityEngine_UI_HorizontalOrVerticalLayoutGroup.Bind, "HorizontalOrVerticalLayoutGroup");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.ILayoutElement), jsb.QuickJS_UnityEngine_UI_ILayoutElement.Bind, "ILayoutElement");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.ILayoutController), jsb.QuickJS_UnityEngine_UI_ILayoutController.Bind, "ILayoutController");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.ILayoutIgnorer), jsb.QuickJS_UnityEngine_UI_ILayoutIgnorer.Bind, "ILayoutIgnorer");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.LayoutElement), jsb.QuickJS_UnityEngine_UI_LayoutElement.Bind, "LayoutElement");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.LayoutRebuilder), jsb.QuickJS_UnityEngine_UI_LayoutRebuilder.Bind, "LayoutRebuilder");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.LayoutUtility), jsb.QuickJS_UnityEngine_UI_LayoutUtility.Bind, "LayoutUtility");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.VerticalLayoutGroup), jsb.QuickJS_UnityEngine_UI_VerticalLayoutGroup.Bind, "VerticalLayoutGroup");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.Mask), jsb.QuickJS_UnityEngine_UI_Mask.Bind, "Mask");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.MaskUtilities), jsb.QuickJS_UnityEngine_UI_MaskUtilities.Bind, "MaskUtilities");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.IMaterialModifier), jsb.QuickJS_UnityEngine_UI_IMaterialModifier.Bind, "IMaterialModifier");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.Navigation), jsb.QuickJS_UnityEngine_UI_Navigation.Bind, "Navigation");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.RawImage), jsb.QuickJS_UnityEngine_UI_RawImage.Bind, "RawImage");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.RectMask2D), jsb.QuickJS_UnityEngine_UI_RectMask2D.Bind, "RectMask2D");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.ScrollRect), jsb.QuickJS_UnityEngine_UI_ScrollRect.Bind, "ScrollRect");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.Scrollbar), jsb.QuickJS_UnityEngine_UI_Scrollbar.Bind, "Scrollbar");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.Slider), jsb.QuickJS_UnityEngine_UI_Slider.Bind, "Slider");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.SpriteState), jsb.QuickJS_UnityEngine_UI_SpriteState.Bind, "SpriteState");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.StencilMaterial), jsb.QuickJS_UnityEngine_UI_StencilMaterial.Bind, "StencilMaterial");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.Text), jsb.QuickJS_UnityEngine_UI_Text.Bind, "Text");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.Toggle), jsb.QuickJS_UnityEngine_UI_Toggle.Bind, "Toggle");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.ToggleGroup), jsb.QuickJS_UnityEngine_UI_ToggleGroup.Bind, "ToggleGroup");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.VertexHelper), jsb.QuickJS_UnityEngine_UI_VertexHelper.Bind, "VertexHelper");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.BaseMeshEffect), jsb.QuickJS_UnityEngine_UI_BaseMeshEffect.Bind, "BaseMeshEffect");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.IMeshModifier), jsb.QuickJS_UnityEngine_UI_IMeshModifier.Bind, "IMeshModifier");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.Outline), jsb.QuickJS_UnityEngine_UI_Outline.Bind, "Outline");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.Shadow), jsb.QuickJS_UnityEngine_UI_Shadow.Bind, "Shadow");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.PositionAsUV1), jsb.QuickJS_UnityEngine_UI_PositionAsUV1.Bind, "PositionAsUV1");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.Button.ButtonClickedEvent), jsb.QuickJS_UnityEngine_UI_Button_ButtonClickedEvent.Bind, "Button", "ButtonClickedEvent");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.DefaultControls.IFactoryControls), jsb.QuickJS_UnityEngine_UI_DefaultControls_IFactoryControls.Bind, "DefaultControls", "IFactoryControls");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.DefaultControls.Resources), jsb.QuickJS_UnityEngine_UI_DefaultControls_Resources.Bind, "DefaultControls", "Resources");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.Dropdown.OptionData), jsb.QuickJS_UnityEngine_UI_Dropdown_OptionData.Bind, "Dropdown", "OptionData");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.Dropdown.OptionDataList), jsb.QuickJS_UnityEngine_UI_Dropdown_OptionDataList.Bind, "Dropdown", "OptionDataList");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.Dropdown.DropdownEvent), jsb.QuickJS_UnityEngine_UI_Dropdown_DropdownEvent.Bind, "Dropdown", "DropdownEvent");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.GraphicRaycaster.BlockingObjects), jsb.QuickJS_UnityEngine_UI_GraphicRaycaster_BlockingObjects.Bind, "GraphicRaycaster", "BlockingObjects");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.Image.Type), jsb.QuickJS_UnityEngine_UI_Image_Type.Bind, "Image", "Type");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.Image.FillMethod), jsb.QuickJS_UnityEngine_UI_Image_FillMethod.Bind, "Image", "FillMethod");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.Image.OriginHorizontal), jsb.QuickJS_UnityEngine_UI_Image_OriginHorizontal.Bind, "Image", "OriginHorizontal");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.Image.OriginVertical), jsb.QuickJS_UnityEngine_UI_Image_OriginVertical.Bind, "Image", "OriginVertical");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.Image.Origin90), jsb.QuickJS_UnityEngine_UI_Image_Origin90.Bind, "Image", "Origin90");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.Image.Origin180), jsb.QuickJS_UnityEngine_UI_Image_Origin180.Bind, "Image", "Origin180");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.Image.Origin360), jsb.QuickJS_UnityEngine_UI_Image_Origin360.Bind, "Image", "Origin360");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.InputField.ContentType), jsb.QuickJS_UnityEngine_UI_InputField_ContentType.Bind, "InputField", "ContentType");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.InputField.InputType), jsb.QuickJS_UnityEngine_UI_InputField_InputType.Bind, "InputField", "InputType");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.InputField.CharacterValidation), jsb.QuickJS_UnityEngine_UI_InputField_CharacterValidation.Bind, "InputField", "CharacterValidation");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.InputField.LineType), jsb.QuickJS_UnityEngine_UI_InputField_LineType.Bind, "InputField", "LineType");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.InputField.SubmitEvent), jsb.QuickJS_UnityEngine_UI_InputField_SubmitEvent.Bind, "InputField", "SubmitEvent");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.InputField.OnChangeEvent), jsb.QuickJS_UnityEngine_UI_InputField_OnChangeEvent.Bind, "InputField", "OnChangeEvent");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.AspectRatioFitter.AspectMode), jsb.QuickJS_UnityEngine_UI_AspectRatioFitter_AspectMode.Bind, "AspectRatioFitter", "AspectMode");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.CanvasScaler.ScaleMode), jsb.QuickJS_UnityEngine_UI_CanvasScaler_ScaleMode.Bind, "CanvasScaler", "ScaleMode");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.CanvasScaler.ScreenMatchMode), jsb.QuickJS_UnityEngine_UI_CanvasScaler_ScreenMatchMode.Bind, "CanvasScaler", "ScreenMatchMode");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.CanvasScaler.Unit), jsb.QuickJS_UnityEngine_UI_CanvasScaler_Unit.Bind, "CanvasScaler", "Unit");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.ContentSizeFitter.FitMode), jsb.QuickJS_UnityEngine_UI_ContentSizeFitter_FitMode.Bind, "ContentSizeFitter", "FitMode");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.GridLayoutGroup.Corner), jsb.QuickJS_UnityEngine_UI_GridLayoutGroup_Corner.Bind, "GridLayoutGroup", "Corner");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.GridLayoutGroup.Axis), jsb.QuickJS_UnityEngine_UI_GridLayoutGroup_Axis.Bind, "GridLayoutGroup", "Axis");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.GridLayoutGroup.Constraint), jsb.QuickJS_UnityEngine_UI_GridLayoutGroup_Constraint.Bind, "GridLayoutGroup", "Constraint");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.MaskableGraphic.CullStateChangedEvent), jsb.QuickJS_UnityEngine_UI_MaskableGraphic_CullStateChangedEvent.Bind, "MaskableGraphic", "CullStateChangedEvent");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.Navigation.Mode), jsb.QuickJS_UnityEngine_UI_Navigation_Mode.Bind, "Navigation", "Mode");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.ScrollRect.MovementType), jsb.QuickJS_UnityEngine_UI_ScrollRect_MovementType.Bind, "ScrollRect", "MovementType");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.ScrollRect.ScrollbarVisibility), jsb.QuickJS_UnityEngine_UI_ScrollRect_ScrollbarVisibility.Bind, "ScrollRect", "ScrollbarVisibility");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.ScrollRect.ScrollRectEvent), jsb.QuickJS_UnityEngine_UI_ScrollRect_ScrollRectEvent.Bind, "ScrollRect", "ScrollRectEvent");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.Scrollbar.Direction), jsb.QuickJS_UnityEngine_UI_Scrollbar_Direction.Bind, "Scrollbar", "Direction");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.Scrollbar.ScrollEvent), jsb.QuickJS_UnityEngine_UI_Scrollbar_ScrollEvent.Bind, "Scrollbar", "ScrollEvent");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.Selectable.Transition), jsb.QuickJS_UnityEngine_UI_Selectable_Transition.Bind, "Selectable", "Transition");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.Slider.Direction), jsb.QuickJS_UnityEngine_UI_Slider_Direction.Bind, "Slider", "Direction");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.Slider.SliderEvent), jsb.QuickJS_UnityEngine_UI_Slider_SliderEvent.Bind, "Slider", "SliderEvent");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.Toggle.ToggleTransition), jsb.QuickJS_UnityEngine_UI_Toggle_ToggleTransition.Bind, "Toggle", "ToggleTransition");
                runtime.AddTypeReference(module, typeof(UnityEngine.UI.Toggle.ToggleEvent), jsb.QuickJS_UnityEngine_UI_Toggle_ToggleEvent.Bind, "Toggle", "ToggleEvent");
            });
            runtime.AddStaticModuleProxy("UnityEngine.EventSystems", (rt, module) =>
            {
                runtime.AddTypeReference(module, typeof(UnityEngine.EventSystems.UIBehaviour), jsb.QuickJS_UnityEngine_EventSystems_UIBehaviour.Bind, "UIBehaviour");
                runtime.AddTypeReference(module, typeof(UnityEngine.EventSystems.BaseRaycaster), jsb.QuickJS_UnityEngine_EventSystems_BaseRaycaster.Bind, "BaseRaycaster");
                runtime.AddTypeReference(module, typeof(UnityEngine.EventSystems.AxisEventData), jsb.QuickJS_UnityEngine_EventSystems_AxisEventData.Bind, "AxisEventData");
                runtime.AddTypeReference(module, typeof(UnityEngine.EventSystems.BaseEventData), jsb.QuickJS_UnityEngine_EventSystems_BaseEventData.Bind, "BaseEventData");
                runtime.AddTypeReference(module, typeof(UnityEngine.EventSystems.AbstractEventData), jsb.QuickJS_UnityEngine_EventSystems_AbstractEventData.Bind, "AbstractEventData");
                runtime.AddTypeReference(module, typeof(UnityEngine.EventSystems.PointerEventData), jsb.QuickJS_UnityEngine_EventSystems_PointerEventData.Bind, "PointerEventData");
                runtime.AddTypeReference(module, typeof(UnityEngine.EventSystems.EventHandle), jsb.QuickJS_UnityEngine_EventSystems_EventHandle.Bind, "EventHandle");
                runtime.AddTypeReference(module, typeof(UnityEngine.EventSystems.IEventSystemHandler), jsb.QuickJS_UnityEngine_EventSystems_IEventSystemHandler.Bind, "IEventSystemHandler");
                runtime.AddTypeReference(module, typeof(UnityEngine.EventSystems.IPointerEnterHandler), jsb.QuickJS_UnityEngine_EventSystems_IPointerEnterHandler.Bind, "IPointerEnterHandler");
                runtime.AddTypeReference(module, typeof(UnityEngine.EventSystems.IPointerExitHandler), jsb.QuickJS_UnityEngine_EventSystems_IPointerExitHandler.Bind, "IPointerExitHandler");
                runtime.AddTypeReference(module, typeof(UnityEngine.EventSystems.IPointerDownHandler), jsb.QuickJS_UnityEngine_EventSystems_IPointerDownHandler.Bind, "IPointerDownHandler");
                runtime.AddTypeReference(module, typeof(UnityEngine.EventSystems.IPointerUpHandler), jsb.QuickJS_UnityEngine_EventSystems_IPointerUpHandler.Bind, "IPointerUpHandler");
                runtime.AddTypeReference(module, typeof(UnityEngine.EventSystems.IPointerClickHandler), jsb.QuickJS_UnityEngine_EventSystems_IPointerClickHandler.Bind, "IPointerClickHandler");
                runtime.AddTypeReference(module, typeof(UnityEngine.EventSystems.IBeginDragHandler), jsb.QuickJS_UnityEngine_EventSystems_IBeginDragHandler.Bind, "IBeginDragHandler");
                runtime.AddTypeReference(module, typeof(UnityEngine.EventSystems.IInitializePotentialDragHandler), jsb.QuickJS_UnityEngine_EventSystems_IInitializePotentialDragHandler.Bind, "IInitializePotentialDragHandler");
                runtime.AddTypeReference(module, typeof(UnityEngine.EventSystems.IDragHandler), jsb.QuickJS_UnityEngine_EventSystems_IDragHandler.Bind, "IDragHandler");
                runtime.AddTypeReference(module, typeof(UnityEngine.EventSystems.IEndDragHandler), jsb.QuickJS_UnityEngine_EventSystems_IEndDragHandler.Bind, "IEndDragHandler");
                runtime.AddTypeReference(module, typeof(UnityEngine.EventSystems.IDropHandler), jsb.QuickJS_UnityEngine_EventSystems_IDropHandler.Bind, "IDropHandler");
                runtime.AddTypeReference(module, typeof(UnityEngine.EventSystems.IScrollHandler), jsb.QuickJS_UnityEngine_EventSystems_IScrollHandler.Bind, "IScrollHandler");
                runtime.AddTypeReference(module, typeof(UnityEngine.EventSystems.IUpdateSelectedHandler), jsb.QuickJS_UnityEngine_EventSystems_IUpdateSelectedHandler.Bind, "IUpdateSelectedHandler");
                runtime.AddTypeReference(module, typeof(UnityEngine.EventSystems.ISelectHandler), jsb.QuickJS_UnityEngine_EventSystems_ISelectHandler.Bind, "ISelectHandler");
                runtime.AddTypeReference(module, typeof(UnityEngine.EventSystems.IDeselectHandler), jsb.QuickJS_UnityEngine_EventSystems_IDeselectHandler.Bind, "IDeselectHandler");
                runtime.AddTypeReference(module, typeof(UnityEngine.EventSystems.IMoveHandler), jsb.QuickJS_UnityEngine_EventSystems_IMoveHandler.Bind, "IMoveHandler");
                runtime.AddTypeReference(module, typeof(UnityEngine.EventSystems.ISubmitHandler), jsb.QuickJS_UnityEngine_EventSystems_ISubmitHandler.Bind, "ISubmitHandler");
                runtime.AddTypeReference(module, typeof(UnityEngine.EventSystems.ICancelHandler), jsb.QuickJS_UnityEngine_EventSystems_ICancelHandler.Bind, "ICancelHandler");
                runtime.AddTypeReference(module, typeof(UnityEngine.EventSystems.EventSystem), jsb.QuickJS_UnityEngine_EventSystems_EventSystem.Bind, "EventSystem");
                runtime.AddTypeReference(module, typeof(UnityEngine.EventSystems.EventTrigger), jsb.QuickJS_UnityEngine_EventSystems_EventTrigger.Bind, "EventTrigger");
                runtime.AddTypeReference(module, typeof(UnityEngine.EventSystems.EventTriggerType), jsb.QuickJS_UnityEngine_EventSystems_EventTriggerType.Bind, "EventTriggerType");
                runtime.AddTypeReference(module, typeof(UnityEngine.EventSystems.ExecuteEvents), jsb.QuickJS_UnityEngine_EventSystems_ExecuteEvents.Bind, "ExecuteEvents");
                runtime.AddTypeReference(module, typeof(UnityEngine.EventSystems.BaseInput), jsb.QuickJS_UnityEngine_EventSystems_BaseInput.Bind, "BaseInput");
                runtime.AddTypeReference(module, typeof(UnityEngine.EventSystems.BaseInputModule), jsb.QuickJS_UnityEngine_EventSystems_BaseInputModule.Bind, "BaseInputModule");
                runtime.AddTypeReference(module, typeof(UnityEngine.EventSystems.PointerInputModule), jsb.QuickJS_UnityEngine_EventSystems_PointerInputModule.Bind, "PointerInputModule");
                runtime.AddTypeReference(module, typeof(UnityEngine.EventSystems.StandaloneInputModule), jsb.QuickJS_UnityEngine_EventSystems_StandaloneInputModule.Bind, "StandaloneInputModule");
                runtime.AddTypeReference(module, typeof(UnityEngine.EventSystems.MoveDirection), jsb.QuickJS_UnityEngine_EventSystems_MoveDirection.Bind, "MoveDirection");
                runtime.AddTypeReference(module, typeof(UnityEngine.EventSystems.RaycastResult), jsb.QuickJS_UnityEngine_EventSystems_RaycastResult.Bind, "RaycastResult");
                runtime.AddTypeReference(module, typeof(UnityEngine.EventSystems.Physics2DRaycaster), jsb.QuickJS_UnityEngine_EventSystems_Physics2DRaycaster.Bind, "Physics2DRaycaster");
                runtime.AddTypeReference(module, typeof(UnityEngine.EventSystems.PhysicsRaycaster), jsb.QuickJS_UnityEngine_EventSystems_PhysicsRaycaster.Bind, "PhysicsRaycaster");
                runtime.AddTypeReference(module, typeof(UnityEngine.EventSystems.PointerEventData.InputButton), jsb.QuickJS_UnityEngine_EventSystems_PointerEventData_InputButton.Bind, "PointerEventData", "InputButton");
                runtime.AddTypeReference(module, typeof(UnityEngine.EventSystems.PointerEventData.FramePressState), jsb.QuickJS_UnityEngine_EventSystems_PointerEventData_FramePressState.Bind, "PointerEventData", "FramePressState");
                runtime.AddTypeReference(module, typeof(UnityEngine.EventSystems.EventTrigger.TriggerEvent), jsb.QuickJS_UnityEngine_EventSystems_EventTrigger_TriggerEvent.Bind, "EventTrigger", "TriggerEvent");
                runtime.AddTypeReference(module, typeof(UnityEngine.EventSystems.EventTrigger.Entry), jsb.QuickJS_UnityEngine_EventSystems_EventTrigger_Entry.Bind, "EventTrigger", "Entry");
                runtime.AddTypeReference(module, typeof(UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData), jsb.QuickJS_UnityEngine_EventSystems_PointerInputModule_MouseButtonEventData.Bind, "PointerInputModule", "MouseButtonEventData");
            });
            runtime.AddStaticModuleProxy("UnityEngine.Events", (rt, module) =>
            {
                runtime.AddTypeReference(module, typeof(UnityEngine.Events.UnityEvent), jsb.QuickJS_UnityEngine_Events_UnityEvent.Bind, "UnityEvent");
                runtime.AddTypeReference(module, typeof(UnityEngine.Events.UnityEventBase), jsb.QuickJS_UnityEngine_Events_UnityEventBase.Bind, "UnityEventBase");
                runtime.AddTypeReference(module, typeof(UnityEngine.Events.UnityEvent<int>), jsb.QuickJS_UnityEngine_Events_UnityEvent_Int32.Bind, "UnityEvent_Int32");
                runtime.AddTypeReference(module, typeof(UnityEngine.Events.UnityEvent<string>), jsb.QuickJS_UnityEngine_Events_UnityEvent_String.Bind, "UnityEvent_String");
                runtime.AddTypeReference(module, typeof(UnityEngine.Events.UnityEvent<bool>), jsb.QuickJS_UnityEngine_Events_UnityEvent_Boolean.Bind, "UnityEvent_Boolean");
                runtime.AddTypeReference(module, typeof(UnityEngine.Events.UnityEvent<UnityEngine.Vector2>), jsb.QuickJS_UnityEngine_Events_UnityEvent_Vector2.Bind, "UnityEvent_Vector2");
                runtime.AddTypeReference(module, typeof(UnityEngine.Events.UnityEvent<float>), jsb.QuickJS_UnityEngine_Events_UnityEvent_Single.Bind, "UnityEvent_Single");
                runtime.AddTypeReference(module, typeof(UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.BaseEventData>), jsb.QuickJS_UnityEngine_Events_UnityEvent_BaseEventData.Bind, "UnityEvent_BaseEventData");
            });
            jsb._QuickJSDelegates.Bind(runtime);
            {
                var register = runtime.GetMainContext().CreateTypeRegister();
                // preload types begin
                register.FindPrototypeOf(typeof(UnityEngine.Color));
                register.FindPrototypeOf(typeof(UnityEngine.Vector2));
                register.FindPrototypeOf(typeof(UnityEngine.Vector2Int));
                register.FindPrototypeOf(typeof(UnityEngine.Vector3));
                register.FindPrototypeOf(typeof(UnityEngine.Vector3Int));
                register.FindPrototypeOf(typeof(UnityEngine.Vector4));
                register.FindPrototypeOf(typeof(UnityEngine.Rect));
                register.FindPrototypeOf(typeof(UnityEngine.Quaternion));
                register.FindPrototypeOf(typeof(UnityEngine.Matrix4x4));
                register.FindPrototypeOf(typeof(UnityEngine.TrackedReference));
                register.FindPrototypeOf(typeof(UnityEngine.Bounds));
                register.FindPrototypeOf(typeof(UnityEngine.BoundsInt));
                register.FindPrototypeOf(typeof(UnityEngine.Hash128));
                register.FindPrototypeOf(typeof(float));
                register.FindPrototypeOf(typeof(double));
                register.FindPrototypeOf(typeof(string));
                register.FindPrototypeOf(typeof(System.Delegate));
                // register.FindPrototypeOf(typeof(UnityEditor.GUID));
                // register.FindPrototypeOf(typeof(UnityEditor.ShaderMessage));
                // register.FindPrototypeOf(typeof(UnityEditor.EditorCurveBinding));
                // register.FindPrototypeOf(typeof(UnityEditor.SceneView.CameraMode));
                // register.FindPrototypeOf(typeof(UnityEditor.SceneManagement.StageHandle));
                register.FindPrototypeOf(typeof(UnityEngine.UI.ColorBlock));
                // preload types end
                if (!register.IsGlobalRegistered("WebSocket"))
                {
                    QuickJS.Extra.WebSocket.Bind(register, "WebSocket");
                }
                if (!register.IsGlobalRegistered("XMLHttpRequest"))
                {
                    QuickJS.Extra.XMLHttpRequest.Bind(register, "XMLHttpRequest");
                }
#if UNITY_EDITOR
                if (!register.IsGlobalRegistered("FSWatcher"))
                {
                    QuickJS.Utils.FSWatcher.Bind(register, "FSWatcher");
                }
#endif
                register.Finish();
            }
        }
    }
}
#endif
