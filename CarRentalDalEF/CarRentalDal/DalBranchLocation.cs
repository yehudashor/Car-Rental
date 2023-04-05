using CrudBase;
using DalApi.IEntityDal;
using DO;

namespace CarRentalDal;

public class DalBranchLocation : EFCrudBase<BranchLocation, CarRentalDBContext.CarRentalDBContext>, IBranchLocation
{

}
