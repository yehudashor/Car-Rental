import { NgModule } from '@angular/core';
import { NavigtionComponent } from './navigtion/navigtion.component';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: 'feature',
    loadChildren: () =>
      import('../feature/feature.module').then(
        (module) => module.FeatureModule
      ),
  },

  {
    path: '',
    component: NavigtionComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class CoreRoutingModule {}
