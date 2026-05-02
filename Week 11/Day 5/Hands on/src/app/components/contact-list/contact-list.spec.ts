import { TestBed } from '@angular/core/testing'
import { ContactListComponent } from './contact-list'
import { of } from 'rxjs'
import { ContactService } from '../../services/contact.service'

describe('ContactListComponent', () => {

  let component: ContactListComponent
  let service: any

  beforeEach(() => {

    service = {
      searchContacts: jasmine.createSpy().and.returnValue(of([
        { id: 1, name: 'a', email: 'a@mail.com', phone: '123' }
      ]))
    }

    TestBed.configureTestingModule({
      imports: [ContactListComponent],
      providers: [
        { provide: ContactService, useValue: service }
      ]
    })

    const fixture = TestBed.createComponent(ContactListComponent)
    component = fixture.componentInstance
    fixture.detectChanges()
  })

  it('should create component', () => {
    expect(component).toBeTruthy()
  })

  it('should load contacts', () => {
    component.ngOnInit()
    expect(service.searchContacts).toHaveBeenCalled()
  })

})