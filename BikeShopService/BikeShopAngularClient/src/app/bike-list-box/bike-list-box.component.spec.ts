import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BikeListBoxComponent } from './bike-list-box.component';

describe('BikeListBoxComponent', () => {
  let component: BikeListBoxComponent;
  let fixture: ComponentFixture<BikeListBoxComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BikeListBoxComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(BikeListBoxComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
