import { Component } from '@angular/core'
import { ContactService } from '../../services/contact.service'
import { Router } from '@angular/router'

@Component({
  selector: 'app-contact-form',
  templateUrl: './contact-form.html'
})
export class ContactFormComponent {

  contact = {
    id: 0,
    name: '',
    email: '',
    phone: ''
  }

  constructor(private service: ContactService, private router: Router) {}

  save() {
    this.service.addContact(this.contact).subscribe(() => {
      this.router.navigate(['/contacts'])
    })
  }
}