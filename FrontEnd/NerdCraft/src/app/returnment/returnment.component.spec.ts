import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ReturnmentComponent } from './returnment.component';

describe('ReturnmentComponent', () => {
  let component: ReturnmentComponent;
  let fixture: ComponentFixture<ReturnmentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ReturnmentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ReturnmentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
