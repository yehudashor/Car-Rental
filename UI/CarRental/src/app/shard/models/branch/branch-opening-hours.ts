import { DayOfWeek } from '../enums/enums';

export class BranchOpeningHours {
  branchOpeningHoursId!: number;
  startDay!: DayOfWeek;
  endDay!: DayOfWeek;
  startTime!: Date;
  endTime!: Date;
}
