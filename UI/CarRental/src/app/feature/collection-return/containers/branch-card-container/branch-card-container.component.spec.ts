import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BranchCardContainerComponent } from './branch-card-container.component';

describe('BranchCardContainerComponent', () => {
  let component: BranchCardContainerComponent;
  let fixture: ComponentFixture<BranchCardContainerComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [BranchCardContainerComponent]
    });
    fixture = TestBed.createComponent(BranchCardContainerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
