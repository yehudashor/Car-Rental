import { NgModule } from '@angular/core';
import { AngularMaterialModule } from '../angular-material/angular-material.module';
import { FeatureRoutingModule } from './feature-routing.module';
import { ShardModule } from '../shard/shard.module';

const moduels = [AngularMaterialModule, FeatureRoutingModule, ShardModule];

@NgModule({
  declarations: [],
  imports: [moduels],
  exports: [moduels],
})
export class FeatureModule {}
