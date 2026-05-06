import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class CartService {

  private items: any[] = [];

  get() {
    return this.items;
  }

  add(product: any) {
    const existing = this.items.find(i => i.productId === product.productId);

    if (existing) {
      existing.quantity++;
    } else {
      this.items.push({ ...product, quantity: 1 });
    }
  }

  increase(productId: number) {
    const item = this.items.find(i => i.productId === productId);
    if (item) item.quantity++;
  }

  decrease(productId: number) {
    const item = this.items.find(i => i.productId === productId);

    if (!item) return;

    item.quantity--;

    if (item.quantity <= 0) {
      this.remove(productId);
    }
  }

  remove(productId: number) {
    this.items = this.items.filter(i => i.productId !== productId);
  }

  clear() {
    this.items = [];
  }
}