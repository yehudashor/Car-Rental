using CarRentalDalCore.DalApi.IEntity;

namespace CarRentalDalCore.DataObjects.CarOperations;

public class CarType : IEntity
{
    public int CarTypeId { get; set; }
    public string Name { get; set; }

    public ICollection<Car> Cars { get; set; }
}