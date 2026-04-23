"use strict";
class Person {
    name;
    age;
    constructor() {
        this.name = "Bharath";
        this.age = 25;
    }
    showDetails() {
        console.log(`Person Details: Name : ${this.name}, Age : ${this.age}`);
    }
}
let p1 = new Person();
p1.showDetails();
