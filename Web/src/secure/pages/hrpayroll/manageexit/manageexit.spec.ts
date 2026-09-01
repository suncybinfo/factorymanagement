import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Manageexit } from './manageexit';

describe('Manageexit', () => {
  let component: Manageexit;
  let fixture: ComponentFixture<Manageexit>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Manageexit],
    }).compileComponents();

    fixture = TestBed.createComponent(Manageexit);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
