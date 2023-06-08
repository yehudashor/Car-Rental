import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CollectionReturnRoutingModule } from './collection-return-routing.module';
import { BranchSelectionComponent } from './presentationals/branch-selection/branch-selection.component';
import { BranchSelectionContainerComponent } from './containers/branch-selection-container/branch-selection-container.component';
import { BranchCardComponent } from './presentationals/branch-card/branch-card.component';
import { BranchCardContainerComponent } from './containers/branch-card-container/branch-card-container.component';
import { FeatureModule } from '../feature.module';

const modules = [CollectionReturnRoutingModule, ];

@NgModule({
  declarations: [BranchSelectionComponent, BranchSelectionContainerComponent, BranchCardComponent, BranchCardContainerComponent],
  imports: [
    CommonModule, FeatureModule,
  ],
  exports:[modules]

})
export class CollectionReturnModule { }
