using DataObjects;
using EntityServiceBase;
using IEntityDal;

namespace CarRentalDal;

public class DalCar : EntityServiceBase<Car, CarRentalDBContext.CarRentalDBContext>, ICar
{
}
