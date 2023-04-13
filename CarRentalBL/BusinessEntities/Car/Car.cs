namespace BusinessEntities;

public class Car
{
    /// <summary>
    /// Unique identifier for the car
    /// </summary>
    public int CarId { set; get; }

    /// <summary>
    /// Name of the company that produces the car
    /// </summary>
    public string CompanyName { set; get; }

    /// <summary>
    /// Name of the car model
    /// </summary>
    public string ModelName { set; get; }

    /// <summary>
    /// Year the car was published
    /// </summary>
    public int PublishYear { set; get; }

    /// <summary>
    /// Number of seats the car has
    /// </summary>
    public int SeatsNumber { set; get; }

    /// <summary>
    /// Number of kilometers the car has been driven
    /// </summary>
    public int KilometersNumber { set; get; }

    /// <summary>
    /// Gearbox type of the car (automatic or manual)
    /// </summary>
    public Gearbox Gearbox { set; get; }

    /// <summary>
    /// Daily rental price for this car
    /// </summary>
    public double DayPrice { set; get; }

    /// <summary>
    /// Name of the car color CarTypeId.
    /// </summary>
    public string CarColor { set; get; }

    /// <summary>
    /// Collection of images of the car
    /// </summary>
    public ICollection<CarImage> Images { set; get; }
}
