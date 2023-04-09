using DataObjects;
using EntityServiceBase;
using IEntityDal;

namespace CarRentalDal;

public class DalCarImage : EntityServiceBase<CarImage, CarRentalDBContext.CarRentalDBContext>, ICarImage
{
}
