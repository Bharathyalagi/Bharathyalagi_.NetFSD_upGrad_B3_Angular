import { Component } from '@angular/core';
import { ProductList } from './product-list/product-list';
import { ProductInfo } from './product-info/product-info';

@Component({
  selector: 'app-root',
  imports: [ProductList, ProductInfo],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
}