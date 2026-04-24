"use strict";
function getFirstElement(items) {
    return items[0];
}
class DataManager {
    store = [];
    add(item) {
        this.store.push(item);
    }
    getAll() {
        return this.store;
    }
}
let userManager = new DataManager();
userManager.add({ id: 1, name: "Bharath" });
userManager.add({ id: 2, name: "Bhuvan" });
let productManager = new DataManager();
productManager.add({ id: 101, title: "Laptop" });
productManager.add({ id: 102, title: "Mobile" });
console.log(getFirstElement(userManager.getAll()));
console.log(userManager.getAll());
console.log(getFirstElement(productManager.getAll()));
console.log(productManager.getAll());
