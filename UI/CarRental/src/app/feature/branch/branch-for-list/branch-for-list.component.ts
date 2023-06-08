import { OpenClose } from 'src/app/shard/models/enums/enums';
import { BranchForList } from './../../../shard/models/branch/branch-for-list';
import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-branch-for-list',
  templateUrl: './branch-for-list.component.html',
  styleUrls: ['./branch-for-list.component.css']
})

export class BranchForListComponent {
 @Input() branchForList!: BranchForList;
}
