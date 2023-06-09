﻿using CarRentalEntities.IEntity;

namespace DO;

/// <summary>
/// Car rental branch entity.
/// </summary>
public class Branch : IEntity
{
    /// <summary>
    /// Branch id.
    /// </summary>
    public int BranchId { set; get; }

    /// <summary>
    /// Branch location.
    /// </summary>
    public BranchLocation Location { set; get; }

    /// <summary>
    /// Foreign key to branch location entity.
    /// </summary>
    public int LocationId { set; get; }

    /// <summary>
    /// List of branch opening hours, each entity describes daily opening hours. 
    /// </summary>
    public ICollection<BranchOpeningHours> OpeningHoursList { set; get; }

    /// <summary>
    /// The list of cars currently in the branch includes the cars actually rented from the branch.
    /// </summary>
    public ICollection<Car> Cars { set; get; }
}
