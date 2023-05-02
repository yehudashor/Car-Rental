using CarRentalDalCore.DalApi.IEntityDal;
using CarRentalDalCore.DataObjects.BranchOperations;
using CarRentalDalEF.EntityServiceBase;

namespace CarRentalDalEF.CarRentalDal;

public class DalBranch : EntityServiceBase<Branch, CarRentalDBContext.CarRentalDBContext>, IBranch
{
}
