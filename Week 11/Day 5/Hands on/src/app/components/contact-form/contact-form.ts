import { Component } from '@angular/core'
import { FormBuilder, ReactiveFormsModule } from '@angular/forms'
import { ContactService } from '../../services/contact.service'
import { Router } from '@angular/router'
import { CommonModule } from '@angular/common'

@Component({
  selector: 'app-contact-form',
  templateUrl: './contact-form.html',
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule]
})
export class ContactFormComponent {

  form: any

  constructor(private fb: FormBuilder, private service: ContactService, private router: Router) {
    this.form = this.fb.group({
      id: [0],
      name: [''],
      email: [''],
      phone: ['']
    })
  }

  save() {
    this.service.addContact(this.form.value).subscribe(() => {
      this.router.navigate(['/contacts'])
    })
  }
}