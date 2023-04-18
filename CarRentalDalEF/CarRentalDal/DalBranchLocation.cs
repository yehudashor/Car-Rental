using CarRentalDalCore.DalApi.IEntityDal;
using CarRentalDalCore.DataObjects.BranchOperations;
using CarRentalDalEF.CarRentalDBContext;
using CarRentalDalEF.EntityServiceBase;

namespace CarRentalDalEF.CarRentalDal;

public class DalBranchLocation : EntityServiceBase<BranchLocation, CarRentalDBContext>, IBranchLocation
{

}
