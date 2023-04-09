using DalApi.IEntityDal;
using DataObjects;
using EntityServiceBase;

namespace CarRentalDal
{
    public class DalBranchOpeningHours : EntityServiceBase<BranchOpeningHours, CarRentalDBContext.CarRentalDBContext>, IBranchOpeningHours
    {
    }
}
