import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GameSeatsComponent } from './game-seats.component';

describe('GameSeatsComponent', () => {
  let component: GameSeatsComponent;
  let fixture: ComponentFixture<GameSeatsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GameSeatsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(GameSeatsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
