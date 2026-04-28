import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ContactService } from '../contact.service';
import { Contact } from '../contact.model';

@Component({
  selector: 'app-contact-detail',
  standalone: true,
  templateUrl: './contact-detail.html'
})
export class ContactDetail {

  contact: Contact | undefined;

  constructor(private route: ActivatedRoute, private service: ContactService) {

    let id = Number(this.route.snapshot.paramMap.get('id'));
    this.contact = this.service.getContactById(id);
  }
}