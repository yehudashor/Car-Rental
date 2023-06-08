import { Component, Input } from '@angular/core';
import { Branch } from 'src/app/shard/models/branch/branch';

@Component({
  selector: 'app-branch-card',
  templateUrl: './branch-card.component.html',
  styleUrls: ['./branch-card.component.css'],
})
export class BranchCardComponent {
  @Input()
  branch!: Branch;
}
