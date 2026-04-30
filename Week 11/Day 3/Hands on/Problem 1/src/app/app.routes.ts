import { Routes } from '@angular/router'
import { ContactListComponent } from './components/contact-list/contact-list'
import { ContactFormComponent } from './components/contact-form/contact-form'
import { ContactDetailComponent } from './components/contact-detail/contact-detail'
import { AuthGuard } from './guards/auth-guard'

export const routes: Routes = [
  { path: 'contacts', component: ContactListComponent },
  { path: 'add', component: ContactFormComponent, canActivate: [AuthGuard] },
  { path: 'contact/:id', component: ContactDetailComponent, canActivate: [AuthGuard] },
  { path: '', redirectTo: 'contacts', pathMatch: 'full' }
]