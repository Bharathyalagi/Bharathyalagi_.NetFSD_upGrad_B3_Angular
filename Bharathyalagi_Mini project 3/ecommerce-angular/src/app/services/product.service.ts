import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  private api = 'https://localhost:7256/api/products';

  constructor(private http: HttpClient) {}

  getAll() {
    return this.http.get(this.api);
  }

  getById(id: number) {
    return this.http.get(this.api + '/' + id);
  }

  add(product: any) {
    return this.http.post(this.api, product);
  }

  update(id: number, product: any) {
    return this.http.put(this.api + '/' + id, product);
  }

  delete(id: number) {
    return this.http.delete(this.api + '/' + id);
  }
}