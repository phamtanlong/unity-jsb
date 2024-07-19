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
    // Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Applications/Unity/Hub/Editor/2019.4.40f1/Unity.app/Contents/Managed/UnityEngine/UnityEngine.CoreModule.dll
    // Type: UnityEngine.KeyCode
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_KeyCode
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("KeyCode", typeof(UnityEngine.KeyCode));
            cls.AddConstValue("None", 0);
            cls.AddConstValue("Backspace", 8);
            cls.AddConstValue("Tab", 9);
            cls.AddConstValue("Clear", 12);
            cls.AddConstValue("Return", 13);
            cls.AddConstValue("Pause", 19);
            cls.AddConstValue("Escape", 27);
            cls.AddConstValue("Space", 32);
            cls.AddConstValue("Exclaim", 33);
            cls.AddConstValue("DoubleQuote", 34);
            cls.AddConstValue("Hash", 35);
            cls.AddConstValue("Dollar", 36);
            cls.AddConstValue("Percent", 37);
            cls.AddConstValue("Ampersand", 38);
            cls.AddConstValue("Quote", 39);
            cls.AddConstValue("LeftParen", 40);
            cls.AddConstValue("RightParen", 41);
            cls.AddConstValue("Asterisk", 42);
            cls.AddConstValue("Plus", 43);
            cls.AddConstValue("Comma", 44);
            cls.AddConstValue("Minus", 45);
            cls.AddConstValue("Period", 46);
            cls.AddConstValue("Slash", 47);
            cls.AddConstValue("Alpha0", 48);
            cls.AddConstValue("Alpha1", 49);
            cls.AddConstValue("Alpha2", 50);
            cls.AddConstValue("Alpha3", 51);
            cls.AddConstValue("Alpha4", 52);
            cls.AddConstValue("Alpha5", 53);
            cls.AddConstValue("Alpha6", 54);
            cls.AddConstValue("Alpha7", 55);
            cls.AddConstValue("Alpha8", 56);
            cls.AddConstValue("Alpha9", 57);
            cls.AddConstValue("Colon", 58);
            cls.AddConstValue("Semicolon", 59);
            cls.AddConstValue("Less", 60);
            cls.AddConstValue("Equals", 61);
            cls.AddConstValue("Greater", 62);
            cls.AddConstValue("Question", 63);
            cls.AddConstValue("At", 64);
            cls.AddConstValue("LeftBracket", 91);
            cls.AddConstValue("Backslash", 92);
            cls.AddConstValue("RightBracket", 93);
            cls.AddConstValue("Caret", 94);
            cls.AddConstValue("Underscore", 95);
            cls.AddConstValue("BackQuote", 96);
            cls.AddConstValue("A", 97);
            cls.AddConstValue("B", 98);
            cls.AddConstValue("C", 99);
            cls.AddConstValue("D", 100);
            cls.AddConstValue("E", 101);
            cls.AddConstValue("F", 102);
            cls.AddConstValue("G", 103);
            cls.AddConstValue("H", 104);
            cls.AddConstValue("I", 105);
            cls.AddConstValue("J", 106);
            cls.AddConstValue("K", 107);
            cls.AddConstValue("L", 108);
            cls.AddConstValue("M", 109);
            cls.AddConstValue("N", 110);
            cls.AddConstValue("O", 111);
            cls.AddConstValue("P", 112);
            cls.AddConstValue("Q", 113);
            cls.AddConstValue("R", 114);
            cls.AddConstValue("S", 115);
            cls.AddConstValue("T", 116);
            cls.AddConstValue("U", 117);
            cls.AddConstValue("V", 118);
            cls.AddConstValue("W", 119);
            cls.AddConstValue("X", 120);
            cls.AddConstValue("Y", 121);
            cls.AddConstValue("Z", 122);
            cls.AddConstValue("LeftCurlyBracket", 123);
            cls.AddConstValue("Pipe", 124);
            cls.AddConstValue("RightCurlyBracket", 125);
            cls.AddConstValue("Tilde", 126);
            cls.AddConstValue("Delete", 127);
            cls.AddConstValue("Keypad0", 256);
            cls.AddConstValue("Keypad1", 257);
            cls.AddConstValue("Keypad2", 258);
            cls.AddConstValue("Keypad3", 259);
            cls.AddConstValue("Keypad4", 260);
            cls.AddConstValue("Keypad5", 261);
            cls.AddConstValue("Keypad6", 262);
            cls.AddConstValue("Keypad7", 263);
            cls.AddConstValue("Keypad8", 264);
            cls.AddConstValue("Keypad9", 265);
            cls.AddConstValue("KeypadPeriod", 266);
            cls.AddConstValue("KeypadDivide", 267);
            cls.AddConstValue("KeypadMultiply", 268);
            cls.AddConstValue("KeypadMinus", 269);
            cls.AddConstValue("KeypadPlus", 270);
            cls.AddConstValue("KeypadEnter", 271);
            cls.AddConstValue("KeypadEquals", 272);
            cls.AddConstValue("UpArrow", 273);
            cls.AddConstValue("DownArrow", 274);
            cls.AddConstValue("RightArrow", 275);
            cls.AddConstValue("LeftArrow", 276);
            cls.AddConstValue("Insert", 277);
            cls.AddConstValue("Home", 278);
            cls.AddConstValue("End", 279);
            cls.AddConstValue("PageUp", 280);
            cls.AddConstValue("PageDown", 281);
            cls.AddConstValue("F1", 282);
            cls.AddConstValue("F2", 283);
            cls.AddConstValue("F3", 284);
            cls.AddConstValue("F4", 285);
            cls.AddConstValue("F5", 286);
            cls.AddConstValue("F6", 287);
            cls.AddConstValue("F7", 288);
            cls.AddConstValue("F8", 289);
            cls.AddConstValue("F9", 290);
            cls.AddConstValue("F10", 291);
            cls.AddConstValue("F11", 292);
            cls.AddConstValue("F12", 293);
            cls.AddConstValue("F13", 294);
            cls.AddConstValue("F14", 295);
            cls.AddConstValue("F15", 296);
            cls.AddConstValue("Numlock", 300);
            cls.AddConstValue("CapsLock", 301);
            cls.AddConstValue("ScrollLock", 302);
            cls.AddConstValue("RightShift", 303);
            cls.AddConstValue("LeftShift", 304);
            cls.AddConstValue("RightControl", 305);
            cls.AddConstValue("LeftControl", 306);
            cls.AddConstValue("RightAlt", 307);
            cls.AddConstValue("LeftAlt", 308);
            cls.AddConstValue("RightCommand", 309);
            cls.AddConstValue("RightApple", 309);
            cls.AddConstValue("LeftCommand", 310);
            cls.AddConstValue("LeftApple", 310);
            cls.AddConstValue("LeftWindows", 311);
            cls.AddConstValue("RightWindows", 312);
            cls.AddConstValue("AltGr", 313);
            cls.AddConstValue("Help", 315);
            cls.AddConstValue("Print", 316);
            cls.AddConstValue("SysReq", 317);
            cls.AddConstValue("Break", 318);
            cls.AddConstValue("Menu", 319);
            cls.AddConstValue("Mouse0", 323);
            cls.AddConstValue("Mouse1", 324);
            cls.AddConstValue("Mouse2", 325);
            cls.AddConstValue("Mouse3", 326);
            cls.AddConstValue("Mouse4", 327);
            cls.AddConstValue("Mouse5", 328);
            cls.AddConstValue("Mouse6", 329);
            cls.AddConstValue("JoystickButton0", 330);
            cls.AddConstValue("JoystickButton1", 331);
            cls.AddConstValue("JoystickButton2", 332);
            cls.AddConstValue("JoystickButton3", 333);
            cls.AddConstValue("JoystickButton4", 334);
            cls.AddConstValue("JoystickButton5", 335);
            cls.AddConstValue("JoystickButton6", 336);
            cls.AddConstValue("JoystickButton7", 337);
            cls.AddConstValue("JoystickButton8", 338);
            cls.AddConstValue("JoystickButton9", 339);
            cls.AddConstValue("JoystickButton10", 340);
            cls.AddConstValue("JoystickButton11", 341);
            cls.AddConstValue("JoystickButton12", 342);
            cls.AddConstValue("JoystickButton13", 343);
            cls.AddConstValue("JoystickButton14", 344);
            cls.AddConstValue("JoystickButton15", 345);
            cls.AddConstValue("JoystickButton16", 346);
            cls.AddConstValue("JoystickButton17", 347);
            cls.AddConstValue("JoystickButton18", 348);
            cls.AddConstValue("JoystickButton19", 349);
            cls.AddConstValue("Joystick1Button0", 350);
            cls.AddConstValue("Joystick1Button1", 351);
            cls.AddConstValue("Joystick1Button2", 352);
            cls.AddConstValue("Joystick1Button3", 353);
            cls.AddConstValue("Joystick1Button4", 354);
            cls.AddConstValue("Joystick1Button5", 355);
            cls.AddConstValue("Joystick1Button6", 356);
            cls.AddConstValue("Joystick1Button7", 357);
            cls.AddConstValue("Joystick1Button8", 358);
            cls.AddConstValue("Joystick1Button9", 359);
            cls.AddConstValue("Joystick1Button10", 360);
            cls.AddConstValue("Joystick1Button11", 361);
            cls.AddConstValue("Joystick1Button12", 362);
            cls.AddConstValue("Joystick1Button13", 363);
            cls.AddConstValue("Joystick1Button14", 364);
            cls.AddConstValue("Joystick1Button15", 365);
            cls.AddConstValue("Joystick1Button16", 366);
            cls.AddConstValue("Joystick1Button17", 367);
            cls.AddConstValue("Joystick1Button18", 368);
            cls.AddConstValue("Joystick1Button19", 369);
            cls.AddConstValue("Joystick2Button0", 370);
            cls.AddConstValue("Joystick2Button1", 371);
            cls.AddConstValue("Joystick2Button2", 372);
            cls.AddConstValue("Joystick2Button3", 373);
            cls.AddConstValue("Joystick2Button4", 374);
            cls.AddConstValue("Joystick2Button5", 375);
            cls.AddConstValue("Joystick2Button6", 376);
            cls.AddConstValue("Joystick2Button7", 377);
            cls.AddConstValue("Joystick2Button8", 378);
            cls.AddConstValue("Joystick2Button9", 379);
            cls.AddConstValue("Joystick2Button10", 380);
            cls.AddConstValue("Joystick2Button11", 381);
            cls.AddConstValue("Joystick2Button12", 382);
            cls.AddConstValue("Joystick2Button13", 383);
            cls.AddConstValue("Joystick2Button14", 384);
            cls.AddConstValue("Joystick2Button15", 385);
            cls.AddConstValue("Joystick2Button16", 386);
            cls.AddConstValue("Joystick2Button17", 387);
            cls.AddConstValue("Joystick2Button18", 388);
            cls.AddConstValue("Joystick2Button19", 389);
            cls.AddConstValue("Joystick3Button0", 390);
            cls.AddConstValue("Joystick3Button1", 391);
            cls.AddConstValue("Joystick3Button2", 392);
            cls.AddConstValue("Joystick3Button3", 393);
            cls.AddConstValue("Joystick3Button4", 394);
            cls.AddConstValue("Joystick3Button5", 395);
            cls.AddConstValue("Joystick3Button6", 396);
            cls.AddConstValue("Joystick3Button7", 397);
            cls.AddConstValue("Joystick3Button8", 398);
            cls.AddConstValue("Joystick3Button9", 399);
            cls.AddConstValue("Joystick3Button10", 400);
            cls.AddConstValue("Joystick3Button11", 401);
            cls.AddConstValue("Joystick3Button12", 402);
            cls.AddConstValue("Joystick3Button13", 403);
            cls.AddConstValue("Joystick3Button14", 404);
            cls.AddConstValue("Joystick3Button15", 405);
            cls.AddConstValue("Joystick3Button16", 406);
            cls.AddConstValue("Joystick3Button17", 407);
            cls.AddConstValue("Joystick3Button18", 408);
            cls.AddConstValue("Joystick3Button19", 409);
            cls.AddConstValue("Joystick4Button0", 410);
            cls.AddConstValue("Joystick4Button1", 411);
            cls.AddConstValue("Joystick4Button2", 412);
            cls.AddConstValue("Joystick4Button3", 413);
            cls.AddConstValue("Joystick4Button4", 414);
            cls.AddConstValue("Joystick4Button5", 415);
            cls.AddConstValue("Joystick4Button6", 416);
            cls.AddConstValue("Joystick4Button7", 417);
            cls.AddConstValue("Joystick4Button8", 418);
            cls.AddConstValue("Joystick4Button9", 419);
            cls.AddConstValue("Joystick4Button10", 420);
            cls.AddConstValue("Joystick4Button11", 421);
            cls.AddConstValue("Joystick4Button12", 422);
            cls.AddConstValue("Joystick4Button13", 423);
            cls.AddConstValue("Joystick4Button14", 424);
            cls.AddConstValue("Joystick4Button15", 425);
            cls.AddConstValue("Joystick4Button16", 426);
            cls.AddConstValue("Joystick4Button17", 427);
            cls.AddConstValue("Joystick4Button18", 428);
            cls.AddConstValue("Joystick4Button19", 429);
            cls.AddConstValue("Joystick5Button0", 430);
            cls.AddConstValue("Joystick5Button1", 431);
            cls.AddConstValue("Joystick5Button2", 432);
            cls.AddConstValue("Joystick5Button3", 433);
            cls.AddConstValue("Joystick5Button4", 434);
            cls.AddConstValue("Joystick5Button5", 435);
            cls.AddConstValue("Joystick5Button6", 436);
            cls.AddConstValue("Joystick5Button7", 437);
            cls.AddConstValue("Joystick5Button8", 438);
            cls.AddConstValue("Joystick5Button9", 439);
            cls.AddConstValue("Joystick5Button10", 440);
            cls.AddConstValue("Joystick5Button11", 441);
            cls.AddConstValue("Joystick5Button12", 442);
            cls.AddConstValue("Joystick5Button13", 443);
            cls.AddConstValue("Joystick5Button14", 444);
            cls.AddConstValue("Joystick5Button15", 445);
            cls.AddConstValue("Joystick5Button16", 446);
            cls.AddConstValue("Joystick5Button17", 447);
            cls.AddConstValue("Joystick5Button18", 448);
            cls.AddConstValue("Joystick5Button19", 449);
            cls.AddConstValue("Joystick6Button0", 450);
            cls.AddConstValue("Joystick6Button1", 451);
            cls.AddConstValue("Joystick6Button2", 452);
            cls.AddConstValue("Joystick6Button3", 453);
            cls.AddConstValue("Joystick6Button4", 454);
            cls.AddConstValue("Joystick6Button5", 455);
            cls.AddConstValue("Joystick6Button6", 456);
            cls.AddConstValue("Joystick6Button7", 457);
            cls.AddConstValue("Joystick6Button8", 458);
            cls.AddConstValue("Joystick6Button9", 459);
            cls.AddConstValue("Joystick6Button10", 460);
            cls.AddConstValue("Joystick6Button11", 461);
            cls.AddConstValue("Joystick6Button12", 462);
            cls.AddConstValue("Joystick6Button13", 463);
            cls.AddConstValue("Joystick6Button14", 464);
            cls.AddConstValue("Joystick6Button15", 465);
            cls.AddConstValue("Joystick6Button16", 466);
            cls.AddConstValue("Joystick6Button17", 467);
            cls.AddConstValue("Joystick6Button18", 468);
            cls.AddConstValue("Joystick6Button19", 469);
            cls.AddConstValue("Joystick7Button0", 470);
            cls.AddConstValue("Joystick7Button1", 471);
            cls.AddConstValue("Joystick7Button2", 472);
            cls.AddConstValue("Joystick7Button3", 473);
            cls.AddConstValue("Joystick7Button4", 474);
            cls.AddConstValue("Joystick7Button5", 475);
            cls.AddConstValue("Joystick7Button6", 476);
            cls.AddConstValue("Joystick7Button7", 477);
            cls.AddConstValue("Joystick7Button8", 478);
            cls.AddConstValue("Joystick7Button9", 479);
            cls.AddConstValue("Joystick7Button10", 480);
            cls.AddConstValue("Joystick7Button11", 481);
            cls.AddConstValue("Joystick7Button12", 482);
            cls.AddConstValue("Joystick7Button13", 483);
            cls.AddConstValue("Joystick7Button14", 484);
            cls.AddConstValue("Joystick7Button15", 485);
            cls.AddConstValue("Joystick7Button16", 486);
            cls.AddConstValue("Joystick7Button17", 487);
            cls.AddConstValue("Joystick7Button18", 488);
            cls.AddConstValue("Joystick7Button19", 489);
            cls.AddConstValue("Joystick8Button0", 490);
            cls.AddConstValue("Joystick8Button1", 491);
            cls.AddConstValue("Joystick8Button2", 492);
            cls.AddConstValue("Joystick8Button3", 493);
            cls.AddConstValue("Joystick8Button4", 494);
            cls.AddConstValue("Joystick8Button5", 495);
            cls.AddConstValue("Joystick8Button6", 496);
            cls.AddConstValue("Joystick8Button7", 497);
            cls.AddConstValue("Joystick8Button8", 498);
            cls.AddConstValue("Joystick8Button9", 499);
            cls.AddConstValue("Joystick8Button10", 500);
            cls.AddConstValue("Joystick8Button11", 501);
            cls.AddConstValue("Joystick8Button12", 502);
            cls.AddConstValue("Joystick8Button13", 503);
            cls.AddConstValue("Joystick8Button14", 504);
            cls.AddConstValue("Joystick8Button15", 505);
            cls.AddConstValue("Joystick8Button16", 506);
            cls.AddConstValue("Joystick8Button17", 507);
            cls.AddConstValue("Joystick8Button18", 508);
            cls.AddConstValue("Joystick8Button19", 509);
            return cls;
        }
    }
}
#endif
