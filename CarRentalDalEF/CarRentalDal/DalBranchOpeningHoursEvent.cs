using DalApi.IEntityDal;
using DataObjects;
using EntityServiceBase;

namespace CarRentalDalEF.CarRentalDal
{
    public class DalBranchOpeningHoursEvent : EntityServiceBase<BranchOpeningHoursEvent, CarRentalDBContext.CarRentalDBContext>, IBranchOpeningHoursEvent
    {
    }
}
