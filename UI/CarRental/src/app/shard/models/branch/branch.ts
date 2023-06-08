import { BranchLocation } from './branch-location';
import { BranchOpeningHours } from './branch-opening-hours';

export class Branch {
  branchId!: number;
  phoneNumber!: string;
  branchLocation!: BranchLocation;
  branchOpeningHoursList!: BranchOpeningHours[];
}
