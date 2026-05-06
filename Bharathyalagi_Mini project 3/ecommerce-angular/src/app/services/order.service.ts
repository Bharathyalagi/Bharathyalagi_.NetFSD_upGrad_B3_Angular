import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class OrderService {

  private api = 'https://localhost:7256/api/orders';

  constructor(private http: HttpClient) {}

  place(order: any) {
    return this.http.post(this.api, order);
  }

  getAll() {
    return this.http.get(this.api);
  }
}