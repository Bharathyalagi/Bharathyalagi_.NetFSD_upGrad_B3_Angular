class Person{
    public name:string;
    public age:number;

    constructor(name:string, age:number)
    {
        this.name = name;
        this.age = age;
    }

    showDetails():void
    {
        console.log(`[ Person Details ] Name : ${this.name}, Age : ${this.age}`);
    }
}

let p1 = new Person("Bharath", 25);
let p2 = new Person("Rahul", 26);
let p3 = new Person("Arjun", 27);

p1.showDetails();
p2.showDetails();
p3.showDetails();