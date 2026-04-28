import { Injectable } from '@angular/core';
import { Contact } from './contact.model';

@Injectable({
  providedIn: 'root'
})
export class ContactService {

  private contacts: Contact[] = [
    { id: 1, name: 'bharath', email: 'bharath@gmail.com', phone: '9876543210' },
    { id: 2, name: 'bhuvan', email: 'bhuvan@gmail.com', phone: '9876543211' },
    { id: 3, name: 'sushmita', email: 'sushmita@gmail.com', phone: '9876543212' }
  ];

  getContacts(): Contact[] {
    return this.contacts;
  }

  addContact(contact: Contact): void {
    this.contacts.push(contact);
  }

  getContactById(id: number): Contact | undefined {
    return this.contacts.find(c => c.id === id);
  }
}