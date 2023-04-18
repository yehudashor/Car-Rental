using CarRentalBL.BusinessEntities.Branch;

namespace CarRentalBL.BusinessEntities.CarRental;

public class RentalRequest
{
    public BranchBase CollectionBranch { get; set; }
    public BranchBase ReturnBranch { get; set; }

    /// <summary>
    /// The start date of the rental period.
    /// </summary>
    public DateTime CollectionTime { set; get; }

    /// <summary>
    /// The end date of the rental period.
    /// </summary>
    public DateTime ReturnTime { set; get; }

    public int TotalDaysNumber { set; get; }
}
