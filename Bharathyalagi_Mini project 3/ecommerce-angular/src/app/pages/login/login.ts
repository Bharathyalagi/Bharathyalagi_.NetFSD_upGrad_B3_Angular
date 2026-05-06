import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Router } from '@angular/router';
import { CommonModule } from '@angular/common';
import { HttpClient } from '@angular/common/http';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [FormsModule, CommonModule, RouterModule],
  templateUrl: './login.html',
  styleUrls: ['./login.css']
})
export class LoginComponent {

  username = '';
  password = '';
  error = '';
  showPassword = false;

  constructor(private http: HttpClient, private router: Router) {}

  login() {
    this.http.post('https://localhost:7256/api/Auth/login', {
      username: this.username,
      password: this.password
    }).subscribe((res: any) => {

      localStorage.setItem('token', res.token);
      this.router.navigate(['/products']);

    }, () => {
      this.error = "Invalid credentials";
    });
  }
}