using DalApi.IEntity;

namespace DataObjects;

/// <summary>
/// Represents a branch location for a car rental company.
/// </summary>
public class Branch : IEntity
{
    /// <summary>
    /// Unique identifier for the branch.
    /// </summary>
    public int BranchId { set; get; }

    /// <summary>
    /// The physical location of the branch.
    /// </summary>
    public BranchLocation BranchLocation { set; get; }

    /// <summary>
    /// The opening hours for the branch, stored as a collection of daily opening hour entities.
    /// </summary>
    public ICollection<BranchOpeningHours> OpeningHoursList { set; get; }

    /// <summary>
    /// The cars currently available at the branch, including those that are currently rented out.
    /// </summary>
    public ICollection<CarRental> CarRentals { set; get; }
}