import { Component } from '@angular/core';
import { ProductService } from '../product.service';
import { Product } from '../product';

@Component({
  selector: 'app-product-info',
  imports: [],
  standalone: true,
  templateUrl: './product-info.html',
  styleUrl: './product-info.css'
})
export class ProductInfo {

  public productObj: Product | undefined;

  constructor(private productService: ProductService) {
  }

}