using RepositoryServiceBase;
using DO;
using IEntityDal;

namespace CarRentalDal;

public class DalColor : RepositoryServiceBase<CarColor, CarRentalDBContext.CarRentalDBContext>, ICarColor
{
}
