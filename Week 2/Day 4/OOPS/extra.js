class Employee{

constructor(name,salary){
this.name=name
this.salary=salary
}
show(){
return "Employee: "+this.name+", Salary: "+this.salary
}}
let e1=new Employee("Ravi",30000)
let e2=new Employee("Anita",45000)

console.log(e1.show())
console.log(e2.show())