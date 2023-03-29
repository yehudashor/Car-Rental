using DalApi.IEntity;

namespace DO;
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
    /// The unique identifier for the location associated with this branch location.
    /// </summary>
    public int LocationId { get; set; }

    /// <summary>
    /// The physical location associated with this branch location.
    /// </summary>
    public Location Location { get; set; }

    /// <summary>
    /// The branch associated with this branch location.
    /// </summary>
    public Branch Branch { set; get; }
}
