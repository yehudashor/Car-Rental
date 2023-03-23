using CarRentalEntities.IEntity;

namespace DO;

public class BranchOpeningHours : IEntity
{
    public Branch? Branch { set; get; }

    public int BranchId { set; get; }

}
