using DataObjects;
using EntityServiceBase;
using IEntityDal;

namespace CarRentalDal;

public class DalCarRental : EntityServiceBase<CarRental, CarRentalDBContext.CarRentalDBContext>, ICarRental
{
}
