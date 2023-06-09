﻿namespace CarRentalBL.BusinessEntities.Branch;

public class BranchForManager : BranchBase
{
    public BranchBase BranchBase { get; set; }

    /// <summary>
    /// The opening hours for the branch, stored as a collection of daily opening hour entities.
    /// </summary>
    public ICollection<Car.Car> Cars { set; get; }

    public int AvailableCarsNumber { get; set; }

    public int UnavailableCarsNumber { get; set; }
}
