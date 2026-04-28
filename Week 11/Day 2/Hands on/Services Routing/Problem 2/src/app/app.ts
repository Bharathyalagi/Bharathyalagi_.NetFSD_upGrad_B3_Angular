import { Component } from '@angular/core';
import { RouterModule } from '@angular/router';
import { ContactList } from './contact-list/contact-list';
import { AddContact } from './add-contact/add-contact';
import { ContactDetail } from './contact-detail/contact-detail';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [
    RouterModule.forRoot([
      { path: 'contacts', component: ContactList },
      { path: 'add-contact', component: AddContact },
      { path: 'contact/:id', component: ContactDetail },
      { path: '', redirectTo: 'contacts', pathMatch: 'full' }
    ])
  ],
  templateUrl: './app.html'
})
export class App {}