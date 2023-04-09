using DataObjects;
using EntityServiceBase;
using IEntityDal;

namespace CarRentalDal;

public class DalColor : EntityServiceBase<CarColor, CarRentalDBContext.CarRentalDBContext>, ICarColor
{
}
