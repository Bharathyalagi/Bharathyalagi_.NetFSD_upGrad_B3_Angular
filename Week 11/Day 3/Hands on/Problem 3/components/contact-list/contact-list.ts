import { Component, OnInit } from '@angular/core'
import { ContactService } from '../../services/contact.service'
import { Router } from '@angular/router'
import { Contact } from '../../models/contact'

@Component({
  selector: 'app-contact-list',
  templateUrl: './contact-list.html'
})
export class ContactListComponent implements OnInit {

  contacts: Contact[] = []

  constructor(private service: ContactService, private router: Router) {}

  ngOnInit() {
    this.load()
  }

  load() {
    this.service.getContacts().subscribe(res => {
      this.contacts = res
    })
  }

  view(id: number) {
    this.router.navigate(['/contact', id])
  }

  remove(id: number) {
    this.service.deleteContact(id).subscribe(() => {
      this.load()
    })
  }
}