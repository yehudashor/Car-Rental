using CarRentalDalCore.DalApi.IEntityDal;
using CarRentalDalEF;
using CarRentalDalEF.CrudBase;
using DO;

namespace CarRentalDal;

public class DalBranchLocation : EFCrudBase<BranchLocation, CarRentalDBContext>, IBranchLocation
{
}
