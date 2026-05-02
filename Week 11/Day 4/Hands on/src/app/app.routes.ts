import { Routes } from '@angular/router'
import { ContactListComponent } from './components/contact-list/contact-list'
import { ContactFormComponent } from './components/contact-form/contact-form'
import { ContactDetailComponent } from './components/contact-detail/contact-detail'

export const routes: Routes = [
  { path: 'contacts', component: ContactListComponent },
  { path: 'add', component: ContactFormComponent },
  { path: 'contact/:id', component: ContactDetailComponent },
  { path: '', redirectTo: 'contacts', pathMatch: 'full' }
]