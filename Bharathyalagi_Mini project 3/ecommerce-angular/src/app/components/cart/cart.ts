import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CartService } from '../../services/cart';
import { OrderService } from '../../services/order.service';

@Component({
  selector: 'app-cart',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './cart.html',
  styleUrls: ['./cart.css']
})
export class CartComponent {

  cart: any[] = [];
  orderPlaced = false;

  constructor(
    private cartService: CartService,
    private orderService: OrderService
  ) {
    this.loadCart();
  }

  loadCart() {
    this.cart = [...this.cartService.get()];
  }

  increase(id: number) {
    this.cartService.increase(id);
    this.loadCart();
  }

  decrease(id: number) {
    this.cartService.decrease(id);
    this.loadCart();
  }

  remove(id: number) {
    this.cartService.remove(id);
    this.loadCart();
  }

  getTotal() {
    return this.cart.reduce((sum, item) => sum + item.price * item.quantity, 0);
  }

  goBack() {
    this.orderPlaced = false;
  }

  checkout() {
  if (this.cart.length === 0) return;

  const order = {
    userId: 1,   // REQUIRED
    items: this.cart.map(item => ({
      productId: item.productId,
      quantity: item.quantity || 1
    }))
  };

  console.log("Sending order:", order);

  this.orderService.place(order).subscribe({
    next: (res) => {
      console.log("Response:", res);

      alert("Order placed successfully");

      this.orderPlaced = true;
      this.cartService.clear();
      this.loadCart();
    },
    error: (err) => {
      console.error(err);
      alert("Order failed");
    }
  });
}
}