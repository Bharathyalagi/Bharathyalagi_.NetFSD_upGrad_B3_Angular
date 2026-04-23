class Employee {
    public id: number;
    protected name: string;
    private salary: number;

    constructor(id: number, name: string, salary: number) {
        this.id = id;
        this.name = name;
        this.salary = salary;
    }

    getSalary(): number {
        return this.salary;
    }

    setSalary(value: number): void {
        if (value > 0) {
            this.salary = value;
        }
    }

    displayDetails(): void {
        console.log(`Id: ${this.id}, Name: ${this.name}, Salary: ${this.salary}`);
    }
}

class Manager extends Employee {
    public teamSize: number;

    constructor(id: number, name: string, salary: number, teamSize: number) {
        super(id, name, salary);
        this.teamSize = teamSize;
    }

    displayDetails(): void {
        console.log(`Id: ${this.id}, Name: ${this.name}, Salary: ${this.getSalary()}, Team Size: ${this.teamSize}`);
    }
}

let emp = new Employee(1, "Bharath", 50000);
let mgr = new Manager(2, "Bhuvan", 70000, 5);

emp.displayDetails();
mgr.displayDetails();