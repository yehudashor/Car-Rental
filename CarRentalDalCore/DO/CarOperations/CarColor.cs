using DalApi.IEntity;

namespace DO;


/// <summary>
/// This class represents a color option for a car
/// </summary>
public class CarColor : IEntity
{
    /// <summary>
    /// Name of the car color
    /// </summary>
    public string CarColorName { set; get; }

    /// <summary>
    /// Foreign key of the car this color belongs to
    /// </summary>
    public int CarId { set; get; }

    /// <summary>
    /// Navigation property to the car this color belongs to
    /// </summary>
    public Car Car { set; get; }
}


