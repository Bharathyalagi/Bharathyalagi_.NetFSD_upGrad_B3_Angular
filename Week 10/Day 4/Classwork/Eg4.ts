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

class Employee extends Person{
    public empId:number;
    public job:string;

    constructor(name:string, age:number, empId:number, job:string){
        super(name, age);
        this.empId = empId;
        this.job = job;
    }

    showDetails(): void {
         console.log(`[ Employee Details ] \n Name : ${this.name}, Age : ${this.age}, Employee Id : ${this.empId}, Job : ${this.job}`);
    }    
}

let e1 = new Employee("Bharath", 35, 546455, "Lead");
let e2 = new Employee("Rahul", 25, 646455, "Tester");

e1.showDetails();
e2.showDetails();