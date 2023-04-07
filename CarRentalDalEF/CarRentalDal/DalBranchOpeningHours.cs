using RepositoryServiceBase;
using DalApi.IEntityDal;
using DO;

namespace CarRentalDal
{
    public class DalBranchOpeningHours : RepositoryServiceBase<BranchOpeningHours, CarRentalDBContext.CarRentalDBContext>, IBranchOpeningHours
    {
    }
}
