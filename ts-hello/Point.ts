export class point{
    //We can replace fields in constractors
    // private x: number;
    // private y: number;
   
    constructor(private _x: number, private _y: number) {
        //They we are make fields in costractors 
        //compiler will generate x and y as class fields
    }
    
    draw(){
        console.log("X is: " + this._x + ", y is: " + this._y);
    }

    getDistance(another: point){
        return another._x
    }
    //Properties (get and set)
    get x(){
        return this._x;
    }

    set x(value:number){
        if(value < 0)
        {
             console.error("Value can't be less than 0.");
        }
        else{
            this._x = value;

        }
    }
}
