import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NavigtionComponent } from './navigtion.component';

describe('NavigtionComponent', () => {
  let component: NavigtionComponent;
  let fixture: ComponentFixture<NavigtionComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [NavigtionComponent]
    });
    fixture = TestBed.createComponent(NavigtionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
