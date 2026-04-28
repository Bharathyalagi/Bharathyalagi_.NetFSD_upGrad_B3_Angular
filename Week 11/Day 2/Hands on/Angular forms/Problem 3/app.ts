import { Component } from '@angular/core';
import { ContactReactive } from './contact-reactive/contact-reactive';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [ContactReactive],
  template: '<app-contact-reactive></app-contact-reactive>'
})
export class App {}