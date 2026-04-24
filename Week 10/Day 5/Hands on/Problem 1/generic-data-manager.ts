function getFirstElement<T>(items: T[]): T {
    return items[0];
}

interface Repository<T> {
    add(item: T): void;
    getAll(): T[];
}

class DataManager<T> implements Repository<T> {
    private store: T[] = [];

    add(item: T): void {
        this.store.push(item);
    }

    getAll(): T[] {
        return this.store;
    }
}

interface User {
    id: number;
    name: string;
}

interface Product {
    id: number;
    title: string;
}

let userManager = new DataManager<User>();
userManager.add({ id: 1, name: "Bharath" });
userManager.add({ id: 2, name: "Bhuvan" });

let productManager = new DataManager<Product>();
productManager.add({ id: 101, title: "Laptop" });
productManager.add({ id: 102, title: "Mobile" });

console.log(getFirstElement(userManager.getAll()));
console.log(userManager.getAll());

console.log(getFirstElement(productManager.getAll()));
console.log(productManager.getAll());