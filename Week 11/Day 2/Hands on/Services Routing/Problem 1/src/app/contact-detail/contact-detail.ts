import { Component } from '@angular/core';
import { ContactService } from '../contact.service';
import { Contact } from '../contact.model';

@Component({
  selector: 'app-contact-detail',
  standalone: true,
  templateUrl: './contact-detail.html'
})
export class ContactDetail {

  public contactObj: Contact | undefined;

  constructor(private contactService: ContactService) {
    this.contactObj = this.contactService.getContactById(1);
  }
}