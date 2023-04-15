using DalApi.IEntityDal;
using DataObjects;
using EntityServiceBase;

namespace CarRentalDal;

public class DalBranch : EntityServiceBase<Branch, CarRentalDBContext.CarRentalDBContext>, IBranch
{
}
