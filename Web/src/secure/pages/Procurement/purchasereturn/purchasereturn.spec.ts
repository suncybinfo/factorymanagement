import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Purchasereturn } from './purchasereturn';

describe('Purchasereturn', () => {
  let component: Purchasereturn;
  let fixture: ComponentFixture<Purchasereturn>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Purchasereturn],
    }).compileComponents();

    fixture = TestBed.createComponent(Purchasereturn);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
