import { NgModule } from '@angular/core';
import { BranchSelectionContainerComponent } from './containers/branch-selection-container/branch-selection-container.component';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
   path: 'branchSelectionContainer',
   component: BranchSelectionContainerComponent
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})

export class CollectionReturnRoutingModule {}
