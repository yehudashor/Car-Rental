using CarRentalEntities.IEntity;

namespace DO;

public class Car : IEntity
{
    public int CarId { set; get; }

    public string CompanyName { set; get; }

    public string ModelName { set; get; }

    public int PublishYear { set; get; }

    public int NumOfDoors { set; get; }

    public int SeatsNumber { set; get; }

    public int KilometersNumber { set; get; }

    public DateOnly LastTestDate { set; get; }

    public Gearbox Gearbox { set; get; }

    public ICollection<CarImage> Images { set; get; }

    public ICollection<CarColor> Colors { set; get; }

}
