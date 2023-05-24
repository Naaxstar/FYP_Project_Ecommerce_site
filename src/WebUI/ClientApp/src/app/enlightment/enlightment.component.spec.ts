import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EnlightmentComponent } from './enlightment.component';

describe('EnlightmentComponent', () => {
  let component: EnlightmentComponent;
  let fixture: ComponentFixture<EnlightmentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EnlightmentComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EnlightmentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
