import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class StudentService {

  constructor(private http: HttpClient) {}

  register(data:any){
    return this.http.post('https://jsonplaceholder.typicode.com/users', data);
  }

  getCourses(){
    return this.http.get('https://jsonplaceholder.typicode.com/posts');
  }
}