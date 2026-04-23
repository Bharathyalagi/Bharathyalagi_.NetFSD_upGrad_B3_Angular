let userName: string = "Bharath";
let age: number = 24;
let email: string = "bharath@gmail.com";
let isSubscribed: boolean = true;

let city = "Bangalore";
let score = 95;

const appName = "UserApp";
age = age + 1;

let message = `Hello ${userName}, you are ${age} years old and your email is ${email}`;

let isEligible = age > 18 && isSubscribed;

console.log(message);
console.log("City:", city);
console.log("Score:", score);
console.log("Eligible for Premium:", isEligible);
