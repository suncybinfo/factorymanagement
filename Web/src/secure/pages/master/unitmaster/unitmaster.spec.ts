import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Unitmaster } from './unitmaster';

describe('Unitmaster', () => {
  let component: Unitmaster;
  let fixture: ComponentFixture<Unitmaster>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Unitmaster],
    }).compileComponents();

    fixture = TestBed.createComponent(Unitmaster);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
