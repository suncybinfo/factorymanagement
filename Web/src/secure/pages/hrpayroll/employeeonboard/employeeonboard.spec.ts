import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Employeeonboard } from './employeeonboard';

describe('Employeeonboard', () => {
  let component: Employeeonboard;
  let fixture: ComponentFixture<Employeeonboard>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Employeeonboard],
    }).compileComponents();

    fixture = TestBed.createComponent(Employeeonboard);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
