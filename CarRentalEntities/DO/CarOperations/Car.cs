using CarRentalEntities.IEntity;

namespace DO;

public class Car : IEntity
{
    public Branch? Branch { set; get; }

    public int BranchId { set; get; }
}
