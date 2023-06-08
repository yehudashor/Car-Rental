import { OpenClose } from "../enums/enums";


export class BranchForList {
  constructor(
   public branchId: number,
   public country: string,
   public city: string,
   public street: string,
   public openClose: OpenClose,
   public description: string = ""
  ) {}
}
