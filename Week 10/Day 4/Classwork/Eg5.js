"use strict";
class Person {
    name;
    age;
    constructor(name = "", age = 0) {
        this.name = name;
        this.age = age;
    }
    showDetails() {
        console.log(`[ Person Details ] Name : ${this.name}, Age : ${this.age}`);
    }
}
let p1 = new Person();
let p2 = new Person("Rahul");
let p3 = new Person("Arjun", 27);
p1.showDetails();
p2.showDetails();
p3.showDetails();
