"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Likes = void 0;
var Likes = /** @class */ (function () {
    /**
     *
     */
    function Likes(LikeCount, isSelected) {
        this.LikeCount = LikeCount;
        this.isSelected = isSelected;
    }
    Likes.prototype.getLikeCounts = function () {
        this.LikeCount += (this.isSelected) ? -1 : 1;
        this.isSelected = !this.isSelected;
    };
    return Likes;
}());
exports.Likes = Likes;
