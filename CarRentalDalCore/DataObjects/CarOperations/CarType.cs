
using DalApi.IEntity;

namespace DataObjects;

public class CarType : IEntity
{
    public int CarTypeId { get; set; }
    public string Name { get; set; }

    public ICollection<Car> Cars { get; set; }
}