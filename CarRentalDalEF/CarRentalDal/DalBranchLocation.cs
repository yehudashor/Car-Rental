using CarRentalDalCore.DalApi.IEntityDal;
using CarRentalDalCore.DataObjects.BranchOperations;
using CarRentalDalEF.EntityServiceBase;

namespace CarRentalDalEF.CarRentalDal;

public class DalBranchLocation : EntityServiceBase<BranchLocation, CarRentalDBContext.CarRentalDBContext>, IBranchLocation
{

}
