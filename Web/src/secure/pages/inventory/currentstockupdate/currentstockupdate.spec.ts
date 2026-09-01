import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Currentstockupdate } from './currentstockupdate';

describe('Currentstockupdate', () => {
  let component: Currentstockupdate;
  let fixture: ComponentFixture<Currentstockupdate>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Currentstockupdate],
    }).compileComponents();

    fixture = TestBed.createComponent(Currentstockupdate);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
