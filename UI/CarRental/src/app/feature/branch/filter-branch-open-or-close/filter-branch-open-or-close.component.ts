import { ViewChild } from '@angular/core';
import { ElementRef } from '@angular/core';
import { EventEmitter, Input, Output } from '@angular/core';
import { Component } from '@angular/core';

@Component({
  selector: 'app-filter-branch-open-or-close',
  templateUrl: './filter-branch-open-or-close.component.html',
  styleUrls: ['./filter-branch-open-or-close.component.css'],
})
export class FilterBranchOpenOrCloseComponent {
  
  ngAfterViewInit() {}

  @Input() all!: number;
  @Input() closeLen!: number;
  @Input() openLen!: number;

  @Output()
  onSelectedFilterChanged: EventEmitter<string>;

  constructor() {
    this.onSelectedFilterChanged = new EventEmitter<string>();
  }

  onRadioChanged(event: any): void {
   this.onSelectedFilterChanged.emit(event.target.value);
  }
}
