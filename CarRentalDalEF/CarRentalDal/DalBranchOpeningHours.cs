using CrudBase;
using DalApi.IEntityDal;
using DO;

namespace CarRentalDal
{
    public class DalBranchOpeningHours : EFCrudBase<BranchOpeningHours, CarRentalDBContext.CarRentalDBContext>, IBranchOpeningHours
    {
    }
}
