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
    // Type: UnityEditor.PlayerSettings+WSACapability
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_PlayerSettings_WSACapability
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("WSACapability", typeof(UnityEditor.PlayerSettings.WSACapability));
            cls.AddConstValue("EnterpriseAuthentication", 0);
            cls.AddConstValue("InternetClient", 1);
            cls.AddConstValue("InternetClientServer", 2);
            cls.AddConstValue("MusicLibrary", 3);
            cls.AddConstValue("PicturesLibrary", 4);
            cls.AddConstValue("PrivateNetworkClientServer", 5);
            cls.AddConstValue("RemovableStorage", 6);
            cls.AddConstValue("SharedUserCertificates", 7);
            cls.AddConstValue("VideosLibrary", 8);
            cls.AddConstValue("WebCam", 9);
            cls.AddConstValue("Proximity", 10);
            cls.AddConstValue("Microphone", 11);
            cls.AddConstValue("Location", 12);
            cls.AddConstValue("HumanInterfaceDevice", 13);
            cls.AddConstValue("AllJoyn", 14);
            cls.AddConstValue("BlockedChatMessages", 15);
            cls.AddConstValue("Chat", 16);
            cls.AddConstValue("CodeGeneration", 17);
            cls.AddConstValue("Objects3D", 18);
            cls.AddConstValue("PhoneCall", 19);
            cls.AddConstValue("UserAccountInformation", 20);
            cls.AddConstValue("VoipCall", 21);
            cls.AddConstValue("Bluetooth", 22);
            cls.AddConstValue("SpatialPerception", 23);
            cls.AddConstValue("InputInjectionBrokered", 24);
            cls.AddConstValue("Appointments", 25);
            cls.AddConstValue("BackgroundMediaPlayback", 26);
            cls.AddConstValue("Contacts", 27);
            cls.AddConstValue("LowLevelDevices", 28);
            cls.AddConstValue("OfflineMapsManagement", 29);
            cls.AddConstValue("PhoneCallHistoryPublic", 30);
            cls.AddConstValue("PointOfService", 31);
            cls.AddConstValue("RecordedCallsFolder", 32);
            cls.AddConstValue("RemoteSystem", 33);
            cls.AddConstValue("SystemManagement", 34);
            cls.AddConstValue("UserDataTasks", 35);
            cls.AddConstValue("UserNotificationListener", 36);
            cls.AddConstValue("GazeInput", 37);
            return cls;
        }
    }
}
#endif
#endif
