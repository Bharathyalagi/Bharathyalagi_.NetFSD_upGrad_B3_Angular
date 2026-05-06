import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { ProductService } from '../../services/product.service';

@Component({
  selector: 'app-admin',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './admin.html',
  styleUrls: ['./admin.css']
})
export class AdminComponent implements OnInit {

  newProduct: any = {
    name: '',
    description: '',
    price: 0,
    imageUrl: '',
    stock: 0
  };

  products: any[] = [];
  message = '';

  constructor(private productService: ProductService) {}

  ngOnInit() {
    this.load();
  }

  load() {
    this.productService.getAll().subscribe((res: any) => {
      this.products = res;
    });
  }

  add() {
    this.productService.add(this.newProduct).subscribe(() => {
      this.message = "Product added";

      this.load();

      this.newProduct = {
        name: '',
        description: '',
        price: 0,
        imageUrl: '',
        stock: 0
      };

      setTimeout(() => this.message = '', 2000);
    });
  }

  delete(id: number) {
    this.productService.delete(id).subscribe(() => {
      this.message = "Deleted";
      this.load();

      setTimeout(() => this.message = '', 2000);
    });
  }
}