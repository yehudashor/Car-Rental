import { OnInit } from '@angular/core';
import { Component } from '@angular/core';
import { BranchForList } from 'src/app/shard/models/branch/branch-for-list';
import { OpenClose } from 'src/app/shard/models/enums/enums';
import { BranchForCustomerService } from 'src/app/shard/services/customer/branch-for-customer';

@Component({
  selector: 'app-branches-for-list',
  templateUrl: './branches-for-list.component.html',
  styleUrls: ['./branches-for-list.component.css'],
})
export class BranchesForListComponent implements OnInit {
  branchesForList: BranchForList[] = [];
  closeLen!: number;
  openLen!: number;
  filterName: string = 'All';

  constructor(private branchForCustomerService: BranchForCustomerService) {
    /*  let countries = ["Afghanistan","Albania","Albania","Andorra","Angola"];
    let cities = ["New York", "Los Angeles", "Chicago", "Houston", "New York"];
    let streets = ["Main Street", "Broadway", "Oak Avenue", "Maple Street", "Park Place"];
    
    for (let i = 0; i < 5; i++) {
      this.branchesForList[i] = new BranchForList(
        i,
        countries[i],
        cities[i],
        streets[i],
        i % 2 == 0 ? OpenClose.open : OpenClose.close
      );
    } */

    this.closeLen = this.getBranchesWith(
      (branch) => branch.openClose == OpenClose.close
    );

    this.openLen = this.getBranchesWith(
      (branch) => branch.openClose == OpenClose.open
    );
  }
  ngOnInit(): void {
    this.branchForCustomerService
    .getBranchesByCountry('isreal')
    .subscribe((data) => {
      console.log(data);
      this.branchesForList = data;
    });

  }

  getBranchesWith(filter: (branch: BranchForList) => boolean): number {
    return this.branchesForList.filter(filter).length;
  }

  onFilterSelected(filterName: string): void {
    this.filterName = filterName;
  }
}
