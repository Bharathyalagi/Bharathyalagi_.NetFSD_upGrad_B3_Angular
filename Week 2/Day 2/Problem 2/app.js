import { calculateTotal } from "./cart.js";

const products = [
    { name: "Laptop", price: 50000, quantity: 1 },
    { name: "Mouse", price: 500, quantity: 2 },
    { name: "Keyboard", price: 1500, quantity: 1 }
];

const button = document.getElementById("showCartBtn");
const outputDiv = document.getElementById("output");

button.addEventListener("click", function () {

    const total = calculateTotal(products);

    let invoiceHTML = "<h3>Invoice:</h3><ul>";

    products.forEach(function(product) {
        invoiceHTML += `<li>${product.name} - ${product.quantity} x ${product.price}</li>`;
    });

    invoiceHTML += "</ul>";

    invoiceHTML += `<p><strong>Total Cart Value: ${total}</strong></p>`;

    outputDiv.innerHTML = invoiceHTML;
});