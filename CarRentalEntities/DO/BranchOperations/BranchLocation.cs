﻿using CarRentalEntities.IEntity;

namespace DO;
public class BranchLocation : IEntity
{
    public int BranchLocationId { get; set; }
    public Location Location { get; set; }
    public int LocationId { get; set; }
    public Branch Branch { set; get; }
}
