using DalApi.IEntityDal;
using DataObjects;
using EntityServiceBase;

namespace CarRentalDBContext.CarRentalDal;

public class DalBranch : EntityServiceBase<Branch, CarRentalDBContext>, IBranch
{
}
