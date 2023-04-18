using CarRentalDalCore.DalApi.IEntity;

namespace CarRentalDalCore.DataObjects.CarOperations;

/// <summary>
/// This class represents a color option for a cars
/// </summary>
public class CarColor : IEntity
{
    /// <summary>
    /// Name of the car color CarTypeId.
    /// </summary>
    public string CarColorId { set; get; }

    /// <summary>
    /// Collection of cars with this color.
    /// </summary>
    public ICollection<Car> Cars { get; set; }
}


