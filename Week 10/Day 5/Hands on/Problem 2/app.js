import { getGrade, getTopper } from "./student.service.js";
import { formatName, calculateAverage } from "./utils.js";
import { PASS_MARKS } from "./constants.js";
let students = [
    { id: 1, name: "Bharath", marks: 85 },
    { id: 2, name: "Bhuvan", marks: 65 },
    { id: 3, name: "Sushmita", marks: 92 }
];
for (let s of students) {
    console.log(formatName(s.name), getGrade(s.marks));
}
console.log("Average:", calculateAverage(students));
let topper = getTopper(students);
console.log("Topper:", topper);
console.log("Pass Marks:", PASS_MARKS);
