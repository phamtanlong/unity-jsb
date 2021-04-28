"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
exports.KingHumanController = void 0;
const UnityEngine_1 = require("UnityEngine");
const inspector_1 = require("../editor/decorators/inspector");
const js_behaviour_base_1 = require("./js_behaviour_base");
// 暂时不支持相对路径
let KingHumanController = class KingHumanController extends js_behaviour_base_1.JSBehaviourBase {
    constructor() {
        super(...arguments);
        this.moving = false;
    }
    Awake() {
        this.transform.localScale = new UnityEngine_1.Vector3(5, 5, 5);
        this.spriteRenderer = this.GetComponent(UnityEngine_1.SpriteRenderer);
    }
    Update() {
        if (UnityEngine_1.Input.anyKey) {
            let hori = 0;
            let vert = 0;
            if (UnityEngine_1.Input.GetKey(UnityEngine_1.KeyCode.A)) {
                hori = -1;
            }
            else if (UnityEngine_1.Input.GetKey(UnityEngine_1.KeyCode.D)) {
                hori = 1;
            }
            if (UnityEngine_1.Input.GetKey(UnityEngine_1.KeyCode.W)) {
                vert = 1;
            }
            else if (UnityEngine_1.Input.GetKey(UnityEngine_1.KeyCode.S)) {
                vert = -1;
            }
            if (hori != 0 || vert != 0) {
                let scale = UnityEngine_1.Time.deltaTime * 5;
                this.transform.Translate(hori * scale, vert * scale, 0);
                if (hori != 0) {
                    this.spriteRenderer.flipX = hori < 0;
                }
                if (!this.moving) {
                    this.moving = true;
                    this.animator.Play("Run", 0);
                }
            }
            else {
                if (this.moving) {
                    this.moving = false;
                    this.animator.Play("Idle", 0);
                }
            }
        }
        else {
            if (this.moving) {
                this.moving = false;
                this.animator.Play("Idle", 0);
            }
        }
    }
};
__decorate([
    inspector_1.SerializedObject()
], KingHumanController.prototype, "animator", void 0);
KingHumanController = __decorate([
    inspector_1.Inspector("game/editor/king_human_controller_inspector", "KingHumanControllerInspector"),
    inspector_1.ScriptType
], KingHumanController);
exports.KingHumanController = KingHumanController;
//# sourceMappingURL=king_human_controller.js.map