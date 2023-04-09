using DalApi.IEntityDal;
using DataObjects;
using EntityServiceBase;

namespace CarRentalDal;

public class DalBranchLocation : EntityServiceBase<BranchLocation, CarRentalDBContext.CarRentalDBContext>, IBranchLocation
{

}
