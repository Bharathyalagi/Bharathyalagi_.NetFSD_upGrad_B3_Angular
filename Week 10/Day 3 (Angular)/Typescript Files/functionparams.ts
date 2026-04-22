function showDetails(sname: string, course: string, age?: number) {
    console.log(sname);
    console.log(course);
    if (age != undefined) {
        console.log(age);
    }
}

function getTotal(price: number, qty: number = 1) {
    var total: number = price * qty;
    var str: string = `Unit Price : ${price} , Quantity : ${qty}, Total Amount : ${total}`;
    console.log(str);
}

function sum2(...ar: number[]) {
    var s: number = 0;
    for (let i in ar) {
        s = s + ar[i];
    }
    console.log("Sum Result : " + s);
}

showDetails("bharath", "Angular", 20);
showDetails("bhuvan", "NodeJS");

getTotal(2500, 3);
getTotal(2500);

sum2(10);
sum2(10, 20, 70);
sum2(10, 20, 40, 50);