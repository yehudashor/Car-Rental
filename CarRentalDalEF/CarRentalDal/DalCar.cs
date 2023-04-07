using RepositoryServiceBase;
using DO;
using IEntityDal;

namespace CarRentalDal;

public class DalCar : RepositoryServiceBase<Car, CarRentalDBContext.CarRentalDBContext>, ICar
{
}
