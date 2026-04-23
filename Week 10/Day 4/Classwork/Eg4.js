"use strict";
class Person {
    name;
    age;
    constructor(name, age) {
        this.name = name;
        this.age = age;
    }
    showDetails() {
        console.log(`[ Person Details ] Name : ${this.name}, Age : ${this.age}`);
    }
}
class Employee extends Person {
    empId;
    job;
    constructor(name, age, empId, job) {
        super(name, age);
        this.empId = empId;
        this.job = job;
    }
    showDetails() {
        console.log(`[ Employee Details ] \n Name : ${this.name}, Age : ${this.age}, Employee Id : ${this.empId}, Job : ${this.job}`);
    }
}
let e1 = new Employee("Bharath", 35, 546455, "Lead");
let e2 = new Employee("Rahul", 25, 646455, "Tester");
e1.showDetails();
e2.showDetails();
