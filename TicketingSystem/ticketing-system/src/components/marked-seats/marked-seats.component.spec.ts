import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MarkedSeatsComponent } from './marked-seats.component';

describe('MarkedSeatsComponent', () => {
  let component: MarkedSeatsComponent;
  let fixture: ComponentFixture<MarkedSeatsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MarkedSeatsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MarkedSeatsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
