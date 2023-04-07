using RepositoryServiceBase;
using DO;
using IEntityDal;

namespace CarRentalDal;

public class DalLocation : RepositoryServiceBase<Location, CarRentalDBContext.CarRentalDBContext>, ILocation
{
}
