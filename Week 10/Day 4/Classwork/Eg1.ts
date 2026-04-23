class Person{
    public name:string;
    public age:number;

    constructor()
    {
        this.name = "Bharath";
        this.age = 25;
    }

    showDetails():void
    {
        console.log(`Person Details: Name : ${this.name}, Age : ${this.age}`);
    }
}

let p1 = new Person();
p1.showDetails();