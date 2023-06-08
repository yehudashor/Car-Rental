import { Component, Input } from '@angular/core';
import { map, Observable, startWith } from 'rxjs';
import { AutocompleteData } from 'src/app/shard/interfaces/autocomplete';
import { FormControl } from '@angular/forms';

@Component({
  selector: 'autocomplete-container',
  templateUrl: './autocomplete-container.component.html',
  styleUrls: ['./autocomplete-container.component.css'],
})
export class AutocompleteContainerComponent<Value> {
  constructor() {
    this.formInput = new FormControl('');
    
    this.autocompleteFilterData = this.formInput.valueChanges.pipe(startWith(''),
      map((content) => this.filter(content))
    );
  }

  autocompleteFilterData!: Observable<AutocompleteData<Value>[]>;

  @Input()
  autocompleteAllData!: AutocompleteData<Value>[];

  formInput!: FormControl;

  autocompleteSelectionChange(autocompleteData: AutocompleteData<Value>):void{
    this.formInput.setValue(autocompleteData.content);
  }
  
  filter(content: string): AutocompleteData<Value>[] {
    return this.autocompleteAllData.filter((data) =>
      data.content.toLocaleLowerCase().includes(content || '')
    );
  }
}
