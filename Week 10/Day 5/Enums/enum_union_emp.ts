enum Role {
    Developer = "DEVELOPER",
    Manager = "MANAGER",
    Lead = "LEAD"
}

enum Dept {
    IT = "IT",
    Sales = "SALES",
    Accounts = "ACCOUNTS"
}

enum Status {
    Active = "ACTIVE",
    Inactive = "INACTIVE"
}

class Employee {
    public id: number | string;
    public name: string;
    public role: Role;
    public dept: Dept;
    public status: Status;

    constructor(id: number | string, name: string, role: Role, dept: Dept, status: Status) {
        this.id = id;
        this.name = name;
        this.role = role;
        this.dept = dept;
        this.status = status;
    }

    showDetails(): void {
        console.log(`Id: ${this.id}, Name: ${this.name}, Role: ${this.role}, Dept: ${this.dept}, Status: ${this.status}`);
    }
}

let e1 = new Employee(101, "Bharath", Role.Developer, Dept.IT, Status.Active);
let e2 = new Employee("102A", "Bhuvan", Role.Manager, Dept.Sales, Status.Inactive);
let e3 = new Employee(103, "Sushmita", Role.Lead, Dept.Accounts, Status.Active);

e1.showDetails();
e2.showDetails();
e3.showDetails();