"use strict";
function f1() {
    console.log("Welcome to TypeScript");
}
function greeting(uname) {
    var str = "Welcome to " + uname;
    console.log(str);
}
function sum(x, y) {
    var z;
    z = x + y;
    return z;
}
f1();
greeting("bharath");
var n = sum(10, 20);
console.log("Sum Result : " + n);
