using CarRentalDalCore.DalApi.IEntityDal;
using CarRentalDalCore.DataObjects.BranchOperations;
using CarRentalDalEF.CarRentalDBContext;
using CarRentalDalEF.EntityServiceBase;

namespace CarRentalDalEF.CarRentalDal;

public class DalBranch : EntityServiceBase<Branch, CarRentalDBContext>, IBranch
{
}
