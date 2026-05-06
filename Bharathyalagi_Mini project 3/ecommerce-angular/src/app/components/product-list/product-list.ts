import { Component, OnInit, ChangeDetectorRef } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CartService } from '../../services/cart';
import { ProductService } from '../../services/product.service';

@Component({
  selector: 'app-product-list',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './product-list.html',
  styleUrls: ['./product-list.css']
})
export class ProductListComponent implements OnInit {

  products: any[] = [];
  toastMsg = '';

  constructor(
    private cartService: CartService,
    private productService: ProductService,
    private cdr: ChangeDetectorRef
  ) {}

  ngOnInit() {
    this.loadProducts();
  }

  loadProducts() {
    this.productService.getAll().subscribe((res: any) => {
      this.products = res;
      this.cdr.detectChanges(); 
    });
  }

  addToCart(p: any) {
    this.cartService.add(p);
    this.toastMsg = p.name + ' added to cart';
    setTimeout(() => this.toastMsg = '', 2000);
  }
}