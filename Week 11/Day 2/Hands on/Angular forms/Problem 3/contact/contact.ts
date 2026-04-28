import { Component } from '@angular/core';
import { ReactiveFormsModule, FormBuilder, Validators } from '@angular/forms';
import { Contact } from '../contact.model';

@Component({
  selector: 'app-contact-reactive',
  standalone: true,
  imports: [ReactiveFormsModule],
  templateUrl: './contact-reactive.html'
})
export class ContactReactive {

  contacts: Contact[] = [];

  constructor(private fb: FormBuilder) {}

  form = this.fb.group({
    name: ['', Validators.required],
    email: ['', [Validators.required, Validators.email]],
    phone: ['', [Validators.required, Validators.minLength(10)]],
    isActive: [false]
  });

  submit(): void {
    if(this.form.valid) {
      this.contacts.push(this.form.value as Contact);
      this.form.reset();
    }
  }
}