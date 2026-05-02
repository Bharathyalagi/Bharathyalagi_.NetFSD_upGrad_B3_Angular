import { Component } from '@angular/core'
import { ActivatedRoute } from '@angular/router'
import { ContactService } from '../../services/contact.service'
import { Observable, switchMap } from 'rxjs'
import { Contact } from '../../models/contact'
import { CommonModule } from '@angular/common'

@Component({
  selector: 'app-contact-detail',
  templateUrl: './contact-detail.html',
  standalone: true,
  imports: [CommonModule]
})
export class ContactDetailComponent {

  contact$: Observable<Contact>

  constructor(private route: ActivatedRoute, private service: ContactService) {
    this.contact$ = this.route.paramMap.pipe(
      switchMap(params => this.service.getContactById(Number(params.get('id'))))
    )
  }
}