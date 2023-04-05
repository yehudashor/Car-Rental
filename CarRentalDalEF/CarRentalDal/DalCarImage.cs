using CrudBase;
using DO;
using IEntityDal;

namespace CarRentalDal;

public class DalCarImage : EFCrudBase<CarImage, CarRentalDBContext.CarRentalDBContext>, ICarImage
{
}
