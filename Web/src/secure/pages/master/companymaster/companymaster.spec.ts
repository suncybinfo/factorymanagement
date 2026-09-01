import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Companymaster } from './companymaster';

describe('Companymaster', () => {
  let component: Companymaster;
  let fixture: ComponentFixture<Companymaster>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Companymaster],
    }).compileComponents();

    fixture = TestBed.createComponent(Companymaster);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
