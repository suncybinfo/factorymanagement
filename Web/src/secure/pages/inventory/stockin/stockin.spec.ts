import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Stockin } from './stockin';

describe('Stockin', () => {
  let component: Stockin;
  let fixture: ComponentFixture<Stockin>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Stockin],
    }).compileComponents();

    fixture = TestBed.createComponent(Stockin);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
