using CarRentalDalCore.DalApi.IEntityDal;
using CarRentalDalCore.DataObjects.BranchOperations;
using CarRentalDalEF.EntityServiceBase;

namespace CarRentalDalEF.CarRentalDal
{
    public class DalBranchOpeningHoursEvent : EntityServiceBase<BranchOpeningHoursEvent, CarRentalDBContext.CarRentalDBContext>, IBranchOpeningHoursEvent
    {
    }
}
