import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HijabComponent } from './hijab.component';

describe('HijabComponent', () => {
  let component: HijabComponent;
  let fixture: ComponentFixture<HijabComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HijabComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(HijabComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
