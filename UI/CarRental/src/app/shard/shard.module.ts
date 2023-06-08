import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BranchForCustomerService } from './services/customer/branch-for-customer';
import { CityStreetPipe } from './pipes/branch/city-street.pipe';
import { HttpClientModule } from '@angular/common/http';
import { AngularMaterialModule } from '../angular-material/angular-material.module';
import { AutocompleteContainerComponent } from './components/containers/autocomplete-container/autocomplete-container.component';
import { AutocompleteComponent } from './components/presentationals/autocomplete/autocomplete.component';
import { ReactiveFormsModule } from '@angular/forms';
import { GoogleMapsComponent } from './components/presentationals/google-maps/google-maps.component';
import { GoogleMapsModule } from '@angular/google-maps';

const components = [
  CityStreetPipe,
  AutocompleteContainerComponent,
  GoogleMapsComponent,
];

@NgModule({
  declarations: [components, AutocompleteComponent],
  imports: [
    CommonModule,
    HttpClientModule,
    AngularMaterialModule,
    ReactiveFormsModule,
    GoogleMapsModule,
  ],
  providers: [BranchForCustomerService],
  exports: [components],
})
export class ShardModule {}
