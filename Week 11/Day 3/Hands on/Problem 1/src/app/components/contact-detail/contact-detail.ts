import { Component, OnInit } from '@angular/core'
import { ActivatedRoute } from '@angular/router'
import { ContactService } from '../../services/contact.service'

@Component({
  selector: 'app-contact-detail',
  templateUrl: './contact-detail.html'
})
export class ContactDetailComponent implements OnInit {

  contact: any

  constructor(private route: ActivatedRoute, private service: ContactService) {}

  ngOnInit() {
    const id = Number(this.route.snapshot.paramMap.get('id'))
    this.service.getContactById(id).subscribe(res => {
      this.contact = res
    })
  }
}