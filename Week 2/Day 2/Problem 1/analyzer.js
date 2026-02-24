const marks = [78, 85, 62, 90, 55];

const total = marks.reduce((acc, mark) => acc + mark, 0);

const average = total / marks.length;

const result = average >= 60 ? "Pass" : "Fail";

console.log(`Marks: ${marks.join(", ")}`);
console.log(`Total Marks: ${total}`);
console.log(`Average Marks: ${average.toFixed(2)}`);
console.log(`Result: ${result}`);