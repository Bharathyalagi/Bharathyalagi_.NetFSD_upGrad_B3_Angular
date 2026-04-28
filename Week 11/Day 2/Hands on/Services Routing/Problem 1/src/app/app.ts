import { Component } from '@angular/core';
import { ContactList } from './contact-list/contact-list';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [ContactList],
  templateUrl: './app.html'
})
export class App {
}