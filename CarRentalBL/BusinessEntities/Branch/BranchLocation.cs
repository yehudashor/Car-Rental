namespace CarRentalBL.BusinessEntities.Branch;

public class BranchLocation
{
    /// <summary>
    /// The unique identifier for this branch location.
    /// </summary>
    public int BranchLocationId { get; set; }

    /// <summary>
    /// Gets or sets the longitude of the location.
    /// </summary>
    public double Longitude { set; get; }

    /// <summary>
    /// Gets or sets the latitude of the location.
    /// </summary>
    public double Latitude { set; get; }

    /// <summary>
    /// The physical location associated with this branch location.
    /// </summary>
    public Location Location { get; set; }

    /// <summary>
    /// The branch associated with this branch location.
    /// </summary>
    public Branch Branch { set; get; }
}