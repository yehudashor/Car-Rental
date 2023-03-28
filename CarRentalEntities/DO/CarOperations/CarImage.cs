using CarRentalEntities.IEntity;

namespace DO;

public class CarImage : IEntity
{
    public string CarImageName { set; get; }
    public int CarId { set; get; }
    public Car Car { set; get; }
}
