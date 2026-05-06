import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  products: any[] = [];

  get() {
    return this.products;
  }

  add(product: any) {
    product.productId = Date.now();
    this.products.push(product);
  }

  delete(id: number) {
    this.products = this.products.filter(p => p.productId !== id);
  }
}