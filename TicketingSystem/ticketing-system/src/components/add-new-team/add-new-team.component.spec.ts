import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddNewTeamComponent } from './add-new-team.component';

describe('AddNewTeamComponent', () => {
  let component: AddNewTeamComponent;
  let fixture: ComponentFixture<AddNewTeamComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddNewTeamComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AddNewTeamComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
