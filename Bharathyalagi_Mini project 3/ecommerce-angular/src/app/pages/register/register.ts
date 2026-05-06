import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-register',
  standalone: true,
  imports: [FormsModule, CommonModule, RouterModule],
  templateUrl: './register.html',
  styleUrls: ['./register.css']
})
export class RegisterComponent {

  username = '';
  password = '';
  message = '';
  error = '';  

  constructor(private http: HttpClient) {}

  register() {
    this.http.post('https://localhost:7256/api/Auth/register', {
      username: this.username,
      password: this.password
    }).subscribe(() => {

      this.message = "Registered successfully";
      this.error = '';

    }, () => {

      this.error = "User already exists or something went wrong";
      this.message = '';

    });
  }
}