import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Router } from '@angular/router';
import { ContactService } from '../contact.service';

@Component({
  selector: 'app-add-contact',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './add-contact.html'
})
export class AddContact {

  id:number = 0;
  name:string = '';
  email:string = '';
  phone:string = '';

  constructor(private service: ContactService, private router: Router) {}

  add(): void {
    this.service.addContact({
      id: this.id,
      name: this.name,
      email: this.email,
      phone: this.phone
    });

    this.router.navigate(['/contacts']);
  }
}