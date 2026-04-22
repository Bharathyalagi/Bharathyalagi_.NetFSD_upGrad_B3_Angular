class Student{

constructor(name,rollNumber,marks){
this.name=name
this.rollNumber=rollNumber
this.marks=marks
}
getDetails(){
return "Name: "+this.name+", Roll: "+this.rollNumber+", Marks: "+this.marks
}
getGrade(){
if(this.marks>=90) return "A"
else if(this.marks>=75) return "B"
else if(this.marks>=50) return "C"
else return "Fail"
}
}
let s1=new Student("Arjun",101,92)
let s2=new Student("Meena",102,68)

console.log(s1.getDetails())
console.log("Grade:",s1.getGrade())
console.log(s2.getDetails())
console.log("Grade:",s2.getGrade())

/* wrapping data and methods inside class */