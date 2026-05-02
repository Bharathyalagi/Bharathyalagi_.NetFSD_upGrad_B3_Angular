import { Injectable } from '@angular/core'
import { HttpClient } from '@angular/common/http'
import { Observable, of } from 'rxjs'
import { Contact } from '../models/contact'
import { catchError } from 'rxjs/operators'

@Injectable({
  providedIn: 'root'
})
export class ContactService {

  url = 'https://localhost:5001/api/contacts'

  constructor(private http: HttpClient) {}

  getContacts(): Observable<Contact[]> {
    return this.http.get<Contact[]>(this.url).pipe(
      catchError(() => of([]))
    )
  }

  searchContacts(term: string): Observable<Contact[]> {
    return this.http.get<Contact[]>(`${this.url}?search=${term}`).pipe(
      catchError(() => of([]))
    )
  }

  getContactById(id: number): Observable<Contact> {
    return this.http.get<Contact>(`${this.url}/${id}`)
  }

  addContact(contact: Contact): Observable<Contact> {
    return this.http.post<Contact>(this.url, contact)
  }
}