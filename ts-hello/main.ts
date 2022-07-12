import { point } from './Point';
let p = new point(90, 82);
p.x = 1000;
p.draw();

import { Likes } from "./like.component"; 

let component = new Likes(10, true);

component.getLikeCounts();

console.log(`LikeCount: ${component.LikeCount}, isSelected: ${component.isSelected}`);