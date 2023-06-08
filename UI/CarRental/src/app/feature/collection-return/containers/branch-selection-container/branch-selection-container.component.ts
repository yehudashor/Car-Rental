import { Component, Input } from '@angular/core';
import { BranchSelectionInput } from '../../interfaces/branch-selection-input';
import { BranchForList } from 'src/app/shard/models/branch/branch-for-list';
import { OpenClose } from 'src/app/shard/models/enums/enums';
import { AutocompleteData } from 'src/app/shard/interfaces/autocomplete';

@Component({
  selector: 'branch-selection-container',
  templateUrl: './branch-selection-container.component.html',
  styleUrls: ['./branch-selection-container.component.css'],
})
export class BranchSelectionContainerComponent {
  branchSelectionInput!: BranchSelectionInput;

  autocompleteData!: AutocompleteData<BranchForList>[];

  constructor() {
    this.autocompleteData = [];
    this.branchSelectionInput = {
      collectionReturnInSameBranch: true,
      collectionPlaceholder: 'gg',
      returnPlaceholder: 'fbgb',
    };

    let countries = ['Afghanistan', 'Albania', 'Albania', 'Andorra', 'Angola'];
    let cities = ['New York', 'Los Angeles', 'Chicago', 'Houston', 'New York'];
    let streets = [
      'Main Street',
      'Broadway',
      'Oak Avenue',
      'Maple Street',
      'Park Place',
    ];

    for (let i = 0; i < 5; i++) {
      this.autocompleteData.push({
        value: new BranchForList(
          i,
          countries[i],
          cities[i],
          streets[i],
          i % 2 == 0 ? OpenClose.open : OpenClose.close
        ),
        content: `${cities[i]} - ${streets[i]}`,
      });
    }
  }

  sameBranchChanged() {
    this.branchSelectionInput.collectionReturnInSameBranch =
      !this.branchSelectionInput.collectionReturnInSameBranch;
  }
}
