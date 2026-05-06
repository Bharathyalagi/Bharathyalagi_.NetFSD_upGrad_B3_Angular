import { Component } from '@angular/core';
import { CartService } from '../../services/cart';
import { OrderService } from '../../services/order.service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-checkout',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './checkout.html'
})
export class CheckoutComponent {

  constructor(
    private cartService: CartService,
    private orderService: OrderService
  ) {}

  placeOrder() {
    const cart = this.cartService.get();

    if (cart.length === 0) {
      alert("Cart is empty");
      return;
    }

    const order = {
      userId: 1,
      items: cart.map((item: any) => ({
        productId: item.productId,
        quantity: item.quantity || 1
    }))
  };

    this.orderService.place(order).subscribe(() => {
      alert('Order placed successfully');
      this.cartService.clear();
    });
  }
}