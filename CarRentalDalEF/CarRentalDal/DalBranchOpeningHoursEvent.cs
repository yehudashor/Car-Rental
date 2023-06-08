using CarRentalDalCore.DalApi.IEntityDal;
using CarRentalDalCore.DataObjects.Branch;
using CarRentalDalEF.EntityServiceBase;

namespace CarRentalDalEF.CarRentalDal
{
    public class DalBranchOpeningHoursEvent : EntityServiceBase<BranchOpeningHoursEvent, CarRentalDBContext.CarRentalDBContext>, IBranchOpeningHoursEvent
    {
    }
}
