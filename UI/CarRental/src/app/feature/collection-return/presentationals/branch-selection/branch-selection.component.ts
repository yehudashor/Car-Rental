import { Component, Input, Output, EventEmitter } from '@angular/core';
import { BranchSelectionInput } from '../../interfaces/branch-selection-input';
import { BranchForList } from 'src/app/shard/models/branch/branch-for-list';
import { AutocompleteData } from 'src/app/shard/interfaces/autocomplete';

@Component({
  selector: 'branch-selection',
  templateUrl: './branch-selection.component.html',
  styleUrls: ['./branch-selection.component.css']
})
export class BranchSelectionComponent<Value> {

  @Input()
  autocompleteData!: AutocompleteData<Value>[];

  @Input() 
  branchSelectionInput!: BranchSelectionInput;

  @Input()
  branches!: BranchForList[];

  @Output()
  onCheckboxChangeEmitter = new EventEmitter;

  @Output()
  onCollectionBranchSelected = new EventEmitter<BranchForList>;

  @Output()
  onReturnBranchSelected = new EventEmitter<BranchForList>;

  onCheckboxChange(): void{
    this.onCheckboxChangeEmitter.emit();
  }
}
