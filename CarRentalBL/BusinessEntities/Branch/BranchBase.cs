namespace CarRentalBL.BusinessEntities.Branch;

public abstract class BranchBase
{

    /// <summary>
    /// Unique identifier for the branch.
    /// </summary>
    public int BranchId { set; get; }

    public string PhoneNumber { get; set; }

    /// <summary>
    /// The physical location of the branch.
    /// </summary>
    public BranchLocation BranchLocation { set; get; }

    /// <summary>
    /// The opening hours for the branch, stored as a collection of daily opening hour entities.
    /// </summary>
    public ICollection<BranchOpeningHours> OpeningHoursList { set; get; }
}
