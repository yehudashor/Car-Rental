import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BranchForListComponent } from './branch-for-list.component';

describe('BranchForListComponent', () => {
  let component: BranchForListComponent;
  let fixture: ComponentFixture<BranchForListComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [BranchForListComponent]
    });
    fixture = TestBed.createComponent(BranchForListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
