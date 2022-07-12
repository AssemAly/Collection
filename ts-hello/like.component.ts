export class Likes{

    /**
     *
     */
    constructor(public LikeCount: number, public isSelected: boolean) {
        
        
    }

    getLikeCounts(){
        this.LikeCount += (this.isSelected)? -1 : 1;
        this.isSelected = !this.isSelected;
    }
}