import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatIconModule } from '@angular/material/icon';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatAutocompleteModule } from '@angular/material/autocomplete';
import {MatRadioModule} from '@angular/material/radio';
import {MatCheckboxModule} from '@angular/material/checkbox';
import {MatInputModule} from '@angular/material/input';
import {MatCardModule} from '@angular/material/card';

const materialModules = [
  MatToolbarModule,
  MatIconModule,
  MatFormFieldModule,
  MatAutocompleteModule,
  MatRadioModule,
  MatCheckboxModule,
  MatInputModule,
  MatCardModule,
];

@NgModule({
  declarations: [],
  imports: [materialModules],
  exports: [materialModules],
})

export class AngularMaterialModule {}
