import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: 'collectionReturn',
    loadChildren: () =>
      import('./collection-return/collection-return.module').then(
        (module) => module.CollectionReturnModule
      ),
  },

  {
    path: 'branch',
    loadChildren: () => import('./branch/branch.module').then(m => m.BranchModule),
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})

export class FeatureRoutingModule {}
