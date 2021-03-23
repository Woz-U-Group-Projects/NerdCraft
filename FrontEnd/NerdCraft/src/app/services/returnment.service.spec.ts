import { TestBed } from '@angular/core/testing';

import { ReturnmentService } from './returnment.service';

describe('ReturnmentService', () => {
  let service: ReturnmentService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ReturnmentService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
