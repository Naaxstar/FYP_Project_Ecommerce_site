import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BajukurungComponent } from './bajukurung.component';

describe('BajukurungComponent', () => {
  let component: BajukurungComponent;
  let fixture: ComponentFixture<BajukurungComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BajukurungComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(BajukurungComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
