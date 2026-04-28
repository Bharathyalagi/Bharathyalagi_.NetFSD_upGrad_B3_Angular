import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Contact } from '../contact.model';

@Component({
  selector: 'app-contact',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './contact.html',
  styleUrl: './contact.css'
})
export class ContactComponent {

  contacts: Contact[] = [
    { contactId: 1, name: 'bharath', email: 'bharath@gmail.com', phone: '9876543210', isActive: true },
    { contactId: 2, name: 'bhuvan', email: 'bhuvan@gmail.com', phone: '9876543211', isActive: false },
    { contactId: 3, name: 'sushmita', email: 'sushmita@gmail.com', phone: '9876543212', isActive: true }
  ];
}