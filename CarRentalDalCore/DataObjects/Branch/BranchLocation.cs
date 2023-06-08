using CarRentalDalCore.DalApi.IEntity;
using CarRentalDalCore.DataObjects.Locations;

namespace CarRentalDalCore.DataObjects.Branch;
/// <summary>
/// Represents a location of a branch for a business.
/// </summary>
public class BranchLocation : IEntity
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
    /// The unique identifier for the location associated with this branch location.
    /// </summary>
    public int LocationId { get; set; }

    /// <summary>
    /// The physical location associated with this branch location.
    /// </summary>
    public Location Location { get; set; }

    /// <summary>
    /// Foreign key to the branch location entity.
    /// </summary>
    public int BranchId { set; get; }

    /// <summary>
    /// The branch associated with this branch location.
    /// </summary>
    public Branch Branch { set; get; }
}
