import { calculateTotal } from "./cart.js";

const products = [
    { name: "Laptop", price: 50000, quantity: 1 },
    { name: "Mouse", price: 500, quantity: 2 },
    { name: "Keyboard", price: 1500, quantity: 1 }
];

const total = calculateTotal(products);

const invoice = products.map(product => {
    return `${product.name} - ${product.quantity} x ${product.price}`;
});

console.log("Invoice:");
invoice.forEach(item => console.log(item));
console.log(`Total Cart Value: ${total}`);