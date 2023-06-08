import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FilterBranchOpenOrCloseComponent } from './filter-branch-open-or-close.component';

describe('FilterBranchOpenOrCloseComponent', () => {
  let component: FilterBranchOpenOrCloseComponent;
  let fixture: ComponentFixture<FilterBranchOpenOrCloseComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [FilterBranchOpenOrCloseComponent]
    });
    fixture = TestBed.createComponent(FilterBranchOpenOrCloseComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
