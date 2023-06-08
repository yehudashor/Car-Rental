import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BranchForListComponent } from './branch-for-list/branch-for-list.component';
import { BranchesForListComponent } from './branches-for-list/branches-for-list.component';
import { FilterBranchOpenOrCloseComponent } from './filter-branch-open-or-close/filter-branch-open-or-close.component';
import { BranchRoutingModule } from './branch-routing.module';
import { ShardModule } from 'src/app/shard/shard.module';

@NgModule({
  declarations: [
    BranchForListComponent,
    BranchesForListComponent,
    FilterBranchOpenOrCloseComponent,
  ],
  imports: [CommonModule, BranchRoutingModule,ShardModule],
  exports: [],
})
export class BranchModule {}
