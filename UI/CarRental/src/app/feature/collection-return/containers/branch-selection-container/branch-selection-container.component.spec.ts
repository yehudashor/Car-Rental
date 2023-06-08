import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BranchSelectionContainerComponent } from './branch-selection-container.component';

describe('BranchSelectionContainerComponent', () => {
  let component: BranchSelectionContainerComponent;
  let fixture: ComponentFixture<BranchSelectionContainerComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [BranchSelectionContainerComponent]
    });
    fixture = TestBed.createComponent(BranchSelectionContainerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
