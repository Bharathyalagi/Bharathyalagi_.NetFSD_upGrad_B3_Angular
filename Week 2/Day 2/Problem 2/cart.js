export const calculateTotal = (products) => {
    return products.reduce((total, product) => {
        return total + product.price * product.quantity;
    }, 0);
};

//export function calculateTotal(products) {
// let total = 0;
// for (let i = 0; i < products.length; i++) {
// total = total + products[i].price * products[i].quantity;
// }
//return total;
// }
