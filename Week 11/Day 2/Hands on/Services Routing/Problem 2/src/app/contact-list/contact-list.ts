import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { ContactService } from '../contact.service';
import { Contact } from '../contact.model';

@Component({
  selector: 'app-contact-list',
  standalone: true,
  imports: [CommonModule, RouterModule],
  templateUrl: './contact-list.html'
})
export class ContactList {

  contacts: Contact[] = [];

  constructor(private service: ContactService) {
    this.contacts = this.service.getContacts();
  }
}