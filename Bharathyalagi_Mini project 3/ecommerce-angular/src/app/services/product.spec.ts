import { TestBed } from '@angular/core/testing';
import { ProductService } from './product.service';
import { HttpClientTestingModule, HttpTestingController } from '@angular/common/http/testing';

describe('ProductService', () => {
  let service: ProductService;
  let httpMock: HttpTestingController;

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [HttpClientTestingModule],
      providers: [ProductService]
    });

    service = TestBed.inject(ProductService);
    httpMock = TestBed.inject(HttpTestingController);
  });

  it('should fetch products', () => {
    const dummyProducts = [
      { productId: 1, name: 'Laptop', price: 60000 }
    ];

    service.getAll().subscribe(res => {
      expect(res).toEqual(dummyProducts);
    });

    const req = httpMock.expectOne('https://localhost:7256/api/products');
    expect(req.request.method).toBe('GET');

    req.flush(dummyProducts);
  });
});