"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.point = void 0;
var point = /** @class */ (function () {
    //We can replace fields in constractors
    // private x: number;
    // private y: number;
    function point(_x, _y) {
        this._x = _x;
        this._y = _y;
        //They we are make fields in costractors 
        //compiler will generate x and y as class fields
    }
    point.prototype.draw = function () {
        console.log("X is: " + this._x + ", y is: " + this._y);
    };
    point.prototype.getDistance = function (another) {
        return another._x;
    };
    Object.defineProperty(point.prototype, "x", {
        //Properties (get and set)
        get: function () {
            return this._x;
        },
        set: function (value) {
            if (value < 0) {
                console.error("Value can't be less than 0.");
            }
            else {
                this._x = value;
            }
        },
        enumerable: false,
        configurable: true
    });
    return point;
}());
exports.point = point;
