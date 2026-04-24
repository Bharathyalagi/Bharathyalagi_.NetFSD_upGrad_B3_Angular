"use strict";
var Role;
(function (Role) {
    Role["Developer"] = "DEVELOPER";
    Role["Manager"] = "MANAGER";
    Role["Lead"] = "LEAD";
})(Role || (Role = {}));
var Dept;
(function (Dept) {
    Dept["IT"] = "IT";
    Dept["Sales"] = "SALES";
    Dept["Accounts"] = "ACCOUNTS";
})(Dept || (Dept = {}));
var Status;
(function (Status) {
    Status["Active"] = "ACTIVE";
    Status["Inactive"] = "INACTIVE";
})(Status || (Status = {}));
class Employee {
    id;
    name;
    role;
    dept;
    status;
    constructor(id, name, role, dept, status) {
        this.id = id;
        this.name = name;
        this.role = role;
        this.dept = dept;
        this.status = status;
    }
    showDetails() {
        console.log(`Id: ${this.id}, Name: ${this.name}, Role: ${this.role}, Dept: ${this.dept}, Status: ${this.status}`);
    }
}
let e1 = new Employee(101, "Bharath", Role.Developer, Dept.IT, Status.Active);
let e2 = new Employee("102A", "Bhuvan", Role.Manager, Dept.Sales, Status.Inactive);
let e3 = new Employee(103, "Sushmita", Role.Lead, Dept.Accounts, Status.Active);
e1.showDetails();
e2.showDetails();
e3.showDetails();
