using System;
using System.Reflection;

namespace jsb.Editor
{
    using QuickJS.Native;
    using QuickJS.Unity;
    using UnityEngine;
    using UnityEditor;
    using UnityEditor.IMGUI.Controls;

    public class UnityUIBinding : AbstractBindingProcess
    {
        public override string GetBindingProcessName()
        {
            return "UnityUI";
        }

        public bool IsAvailable(MethodInfo methodInfo)
        {
            return methodInfo != null && methodInfo.IsPublic;
        }

        public override void OnPreCollectAssemblies(BindingManager bindingManager)
        {
            bindingManager.SetTypeBlocked(typeof(UnityEngine.UI.ILayoutGroup));
            bindingManager.SetTypeBlocked(typeof(UnityEngine.UI.ILayoutSelfController));
            
            bindingManager.TransformType(typeof(UnityEngine.UI.PositionAsUV1))
                .SetMemberBlocked("ModifyMesh");
            bindingManager.TransformType(typeof(UnityEngine.UI.Shadow))
                .SetMemberBlocked("ModifyMesh");
            bindingManager.TransformType(typeof(UnityEngine.UI.Outline))
                .SetMemberBlocked("ModifyMesh");
            bindingManager.TransformType(typeof(UnityEngine.UI.Graphic))
                .SetMemberBlocked("OnRebuildRequested");
            bindingManager.TransformType(typeof(UnityEngine.UI.Text))
                .SetMemberBlocked("OnRebuildRequested");
        }

        public override void OnPreExporting(BindingManager bindingManager)
        {
        }
    }
}