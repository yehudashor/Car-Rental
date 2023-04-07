using RepositoryServiceBase;
using DO;
using IEntityDal;

namespace CarRentalDal;

public class DalCarImage : RepositoryServiceBase<CarImage, CarRentalDBContext.CarRentalDBContext>, ICarImage
{
}
