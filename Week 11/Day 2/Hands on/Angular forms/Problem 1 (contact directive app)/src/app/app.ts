import { Component } from '@angular/core';
import { ContactComponent } from './contact/contact';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [ContactComponent],
  template: '<app-contact></app-contact>'
})
export class App {}