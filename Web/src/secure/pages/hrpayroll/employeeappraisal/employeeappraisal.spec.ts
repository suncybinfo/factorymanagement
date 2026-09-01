import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Employeeappraisal } from './employeeappraisal';

describe('Employeeappraisal', () => {
  let component: Employeeappraisal;
  let fixture: ComponentFixture<Employeeappraisal>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Employeeappraisal],
    }).compileComponents();

    fixture = TestBed.createComponent(Employeeappraisal);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
