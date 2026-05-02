import { Component, OnInit } from '@angular/core'
import { ContactService } from '../../services/contact.service'
import { Observable, startWith, debounceTime, distinctUntilChanged, switchMap } from 'rxjs'
import { Contact } from '../../models/contact'
import { FormControl, ReactiveFormsModule } from '@angular/forms'
import { CommonModule } from '@angular/common'

@Component({
  selector: 'app-contact-list',
  templateUrl: './contact-list.html',
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule]
})
export class ContactListComponent implements OnInit {

  contacts$!: Observable<Contact[]>
  search = new FormControl('')

  constructor(private service: ContactService) {}

  ngOnInit() {
    this.contacts$ = this.search.valueChanges.pipe(
      startWith(''),
      debounceTime(300),
      distinctUntilChanged(),
      switchMap(value => this.service.searchContacts(value || ''))
    )
  }
}