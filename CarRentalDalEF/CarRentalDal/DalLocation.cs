using DataObjects;
using EntityServiceBase;
using IEntityDal;

namespace CarRentalDal;

public class DalLocation : EntityServiceBase<Location, CarRentalDBContext.CarRentalDBContext>, ILocation
{
}
