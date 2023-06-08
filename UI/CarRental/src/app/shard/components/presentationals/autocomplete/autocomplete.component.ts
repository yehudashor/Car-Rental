import { Component, Input, EventEmitter, Output } from '@angular/core';
import { AutocompleteData } from 'src/app/shard/interfaces/autocomplete';
import { FormControl } from '@angular/forms';

@Component({
  selector: 'autocomplete',
  templateUrl: './autocomplete.component.html',
  styleUrls: ['./autocomplete.component.css'],
})
export class AutocompleteComponent<Value> {
  @Input()
  autocompleteData!: AutocompleteData<Value>[];

  @Input()
  formInput!: FormControl;

  @Output()
  onAutocompleteSelectionChangeEmitter = new EventEmitter<
    AutocompleteData<Value>
  >();

  onAutocompleteSelectionChange(
    autocompleteData: AutocompleteData<Value>
  ): void {
    this.onAutocompleteSelectionChangeEmitter.emit(autocompleteData);
  }
}
