using CarRentalEntities.IEntity;

namespace DO;

public class CarColor : IEntity
{
    public string CarColorName { set; get; }
    public int CarId { set; get; }

    public Car Car { set; get; }
}


