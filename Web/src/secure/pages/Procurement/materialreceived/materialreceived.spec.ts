import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Materialreceived } from './materialreceived';

describe('Materialreceived', () => {
  let component: Materialreceived;
  let fixture: ComponentFixture<Materialreceived>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Materialreceived],
    }).compileComponents();

    fixture = TestBed.createComponent(Materialreceived);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
