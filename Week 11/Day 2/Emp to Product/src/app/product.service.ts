import { Injectable } from '@angular/core';
import { Product } from './product';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  public products: Product[] = [
    { id: 101, name: "bharath laptop", category: "electronics", price: 50000 },
    { id: 102, name: "bhuvan phone", category: "electronics", price: 20000 },
    { id: 103, name: "sushmita bag", category: "fashion", price: 3000 }
  ];

  getProducts(): Product[] {
    return this.products;
  }
}