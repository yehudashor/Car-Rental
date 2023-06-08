import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BranchesForListComponent } from './branches-for-list.component';

describe('BranchesForListComponent', () => {
  let component: BranchesForListComponent;
  let fixture: ComponentFixture<BranchesForListComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [BranchesForListComponent]
    });
    fixture = TestBed.createComponent(BranchesForListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
