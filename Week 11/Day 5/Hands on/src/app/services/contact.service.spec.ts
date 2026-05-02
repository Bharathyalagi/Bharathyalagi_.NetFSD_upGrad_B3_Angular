import { TestBed } from '@angular/core/testing'
import { ContactService } from './contact.service'
import { HttpClientTestingModule, HttpTestingController } from '@angular/common/http/testing'

describe('ContactService', () => {

  let service: ContactService
  let http: HttpTestingController

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [HttpClientTestingModule]
    })

    service = TestBed.inject(ContactService)
    http = TestBed.inject(HttpTestingController)
  })

  it('should fetch contacts', () => {

    const mockData = [
      { id: 1, name: 'a', email: 'a@mail.com', phone: '123' }
    ]

    service.getContacts().subscribe(res => {
      expect(res.length).toBe(1)
    })

    const req = http.expectOne(service.url)
    req.flush(mockData)
  })

  it('should get contact by id', () => {

    const mock = { id: 1, name: 'a', email: 'a@mail.com', phone: '123' }

    service.getContactById(1).subscribe(res => {
      expect(res.id).toBe(1)
    })

    const req = http.expectOne(`${service.url}/1`)
    req.flush(mock)
  })

  it('should add contact', () => {

    const newContact = { id: 2, name: 'b', email: 'b@mail.com', phone: '456' }

    service.addContact(newContact).subscribe(res => {
      expect(res.name).toBe('b')
    })

    const req = http.expectOne(service.url)
    req.flush(newContact)
  })

})