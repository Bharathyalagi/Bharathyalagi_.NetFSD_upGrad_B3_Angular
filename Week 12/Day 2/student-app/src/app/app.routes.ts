import { Routes } from '@angular/router';
import { RegisterComponent } from './register/register';
import { CoursesComponent } from './courses/courses';

export const routes: Routes = [
  { path: '', component: RegisterComponent },
  { path: 'courses', component: CoursesComponent }
];