import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProductService } from '../product.service';
import {Product} from '../product';


@Component({
  selector: 'app-product-list',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './product-list.html',
  styleUrl: './product-list.css',
})
export class ProductList {
  public products: Product[] =[];
  public selectedProduct: Product | undefined;

  constructor(private productService: ProductService) {
    this.products = this.productService.getProducts();
  }
  selectProduct(p: Product){
    this.selectedProduct = p;
  }
}
