import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Contact } from '../contact.model';

@Component({
  selector: 'app-contact-form',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './contact-form.html'
})
export class ContactForm {

  contact: Contact = {
    contactId: 0,
    name: '',
    email: '',
    phone: '',
    isActive: false
  };

  contacts: Contact[] = [];

  addContact(form: any): void {
    if(form.valid) {
      this.contacts.push({...this.contact});
      form.reset();
    }
  }
}