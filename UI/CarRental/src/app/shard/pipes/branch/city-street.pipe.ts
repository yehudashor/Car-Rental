import { Pipe, PipeTransform } from '@angular/core';
import { BranchForList } from '../../models/branch/branch-for-list';

@Pipe({
  name: 'cityStreet',
})

export class CityStreetPipe implements PipeTransform {
  private amountBranchesInCity!: Map<string, number>;

  transform(branch: BranchForList, branches: BranchForList[]): void {
    if (this.amountBranchesInCity == undefined) {
      this.initAmountBranchesInCity(branches);
    }

    const amount = this.amountBranchesInCity?.get(branch.city)!;

    branch.description =
      amount > 1 ? `${branch.city} - ${branch.street}` : branch.city;
  }

  initAmountBranchesInCity(branches: BranchForList[]): void {
    this.amountBranchesInCity = new Map<string, number>();

    branches.forEach((b) => {
      if (this.amountBranchesInCity?.has(b.city)) {
        let amount = this.amountBranchesInCity.get(b.city)!;

        this.amountBranchesInCity.set(b.city, amount++);
      } else {
        this.amountBranchesInCity?.set(b.city, 1);
      }
    });
  }
}
