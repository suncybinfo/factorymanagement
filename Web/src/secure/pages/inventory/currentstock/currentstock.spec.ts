import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Currentstock } from './currentstock';

describe('Currentstock', () => {
  let component: Currentstock;
  let fixture: ComponentFixture<Currentstock>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Currentstock],
    }).compileComponents();

    fixture = TestBed.createComponent(Currentstock);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
