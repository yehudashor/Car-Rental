using RepositoryServiceBase;
using DalApi.IEntityDal;
using DO;

namespace CarRentalDBContext.CarRentalDal;

public class DalBranch : RepositoryServiceBase<Branch, CarRentalDBContext>, IBranch
{
}
