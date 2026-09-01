import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Securelayout } from './securelayout';

describe('Securelayout', () => {
  let component: Securelayout;
  let fixture: ComponentFixture<Securelayout>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Securelayout],
    }).compileComponents();

    fixture = TestBed.createComponent(Securelayout);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
