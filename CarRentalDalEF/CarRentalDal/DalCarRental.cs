using RepositoryServiceBase;
using DO;
using IEntityDal;

namespace CarRentalDal;

public class DalCarRental : RepositoryServiceBase<CarRental, CarRentalDBContext.CarRentalDBContext>, ICarRental
{
}
