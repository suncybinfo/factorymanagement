import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Manageemployee } from './manageemployee';

describe('Manageemployee', () => {
  let component: Manageemployee;
  let fixture: ComponentFixture<Manageemployee>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Manageemployee],
    }).compileComponents();

    fixture = TestBed.createComponent(Manageemployee);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
