import { NgModule } from '@angular/core';
import { BranchesForListComponent } from './branches-for-list/branches-for-list.component';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: 'branchesForList',
    component: BranchesForListComponent,
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class BranchRoutingModule {}
