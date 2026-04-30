import { Injectable } from '@angular/core'
import { HttpClient } from '@angular/common/http'
import { Observable } from 'rxjs'
import { Contact } from '../models/contact'

@Injectable({
  providedIn: 'root'
})
export class ContactService {

  url = 'https://localhost:5001/api/contacts'

  constructor(private http: HttpClient) {}

  getContacts(): Observable<Contact[]> {
    return this.http.get<Contact[]>(this.url)
  }

  getContactById(id: number): Observable<Contact> {
    return this.http.get<Contact>(`${this.url}/${id}`)
  }

  addContact(contact: Contact): Observable<Contact> {
    return this.http.post<Contact>(this.url, contact)
  }

  updateContact(contact: Contact): Observable<any> {
    return this.http.put(`${this.url}/${contact.id}`, contact)
  }

  deleteContact(id: number): Observable<any> {
    return this.http.delete(`${this.url}/${id}`)
  }
}