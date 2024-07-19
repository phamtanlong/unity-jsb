"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
console.log("start LONG start");
const UnityEngine_1 = require("UnityEngine");
if (!UnityEngine_1.GameObject.Find("/game_stage")) {
    let path = "prefab/game_stage";
    let prefab = UnityEngine_1.Resources.Load(path);
    if (prefab) {
        let inst = UnityEngine_1.Object.Instantiate(prefab);
        inst.name = "game_stage";
    }
    else {
        console.error("game stage not found:", path);
    }
}
console.log("end LONG end");
//# sourceMappingURL=game_demo.js.map