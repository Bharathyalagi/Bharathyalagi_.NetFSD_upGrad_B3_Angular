import { Component } from '@angular/core';
import { ContactForm } from './contact-form/contact-form';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [ContactForm],
  template: '<app-contact-form></app-contact-form>'
})
export class App {}