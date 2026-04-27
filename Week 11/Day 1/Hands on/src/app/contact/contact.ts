import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { PhoneFormatPipe } from '../phone-format.pipe';
import { StatusPipe } from '../status.pipe';
import { SearchPipe } from '../search.pipe';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-contact',
  standalone: true,
  imports: [CommonModule, FormsModule, PhoneFormatPipe, StatusPipe, SearchPipe],
  templateUrl: './contact.html',
  styleUrl: './contact.css'
})
export class Contact {

  searchText: string = "";

  contacts = [
    { name: "bharath", email: "bharath@gmail.com", phone: 9876543210, status: true },
    { name: "bhuvan", email: "bhuvan@gmail.com", phone: 9123456780, status: false },
    { name: "sushmita", email: "sushmita@gmail.com", phone: 9988776655, status: true },
    { name: "anil", email: "anil@gmail.com", phone: 9871234567, status: false },
    { name: "kiran", email: "kiran@gmail.com", phone: 9090909090, status: true },
    { name: "meena", email: "meena@gmail.com", phone: 8888888888, status: false },
    { name: "rajesh", email: "rajesh@gmail.com", phone: 7777777777, status: true },
    { name: "divya", email: "divya@gmail.com", phone: 6666666666, status: false },
    { name: "arjun", email: "arjun@gmail.com", phone: 9999999999, status: true },
    { name: "nisha", email: "nisha@gmail.com", phone: 9111111111, status: false }
  ];

  toggleStatus(contact: any) {
    contact.status = !contact.status;
  }
}
