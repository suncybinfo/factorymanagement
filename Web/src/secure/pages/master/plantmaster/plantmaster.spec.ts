import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Plantmaster } from './plantmaster';

describe('Plantmaster', () => {
  let component: Plantmaster;
  let fixture: ComponentFixture<Plantmaster>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Plantmaster],
    }).compileComponents();

    fixture = TestBed.createComponent(Plantmaster);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
