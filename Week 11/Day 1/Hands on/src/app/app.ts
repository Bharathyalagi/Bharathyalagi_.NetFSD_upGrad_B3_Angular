import { Component } from '@angular/core';
import { Contact } from './contact/contact';

@Component({
  selector: 'app-root',
  imports: [Contact],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {}