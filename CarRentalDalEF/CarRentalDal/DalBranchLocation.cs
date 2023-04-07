using RepositoryServiceBase;
using DalApi.IEntityDal;
using DO;

namespace CarRentalDal;

public class DalBranchLocation : RepositoryServiceBase<BranchLocation, CarRentalDBContext.CarRentalDBContext>, IBranchLocation
{

}
