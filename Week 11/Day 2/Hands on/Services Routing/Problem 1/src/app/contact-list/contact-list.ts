import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { ContactService } from '../contact.service';
import { Contact } from '../contact.model';

@Component({
  selector: 'app-contact-list',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './contact-list.html'
})
export class ContactList {

  public contacts: Contact[] = [];

  public newName: string = "";
  public newEmail: string = "";
  public newPhone: string = "";

  public selectedContact: Contact | undefined;

  constructor(private contactService: ContactService) {
    this.contacts = this.contactService.getContacts();
  }

  public addContact(): void {

    if (!this.newName || !this.newEmail || !this.newPhone){
      alert("All fields are req.")
      return;
    }

    const newContact: Contact = {
      id: this.contacts.length + 1,
      name: this.newName,
      email: this.newEmail,
      phone: this.newPhone
    };

    this.contactService.addContact(newContact);

    this.contacts = this.contactService.getContacts();

    this.newName = "";
    this.newEmail = "";
    this.newPhone = "";
  }
  public selectContact(contact: Contact): void {
    this.selectedContact = contact;
  }
}