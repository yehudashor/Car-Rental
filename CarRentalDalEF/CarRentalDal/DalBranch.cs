using CrudBase;
using DalApi.IEntityDal;
using DO;

namespace CarRentalDBContext.CarRentalDal;

public class DalBranch : EFCrudBase<Branch, CarRentalDBContext>, IBranch
{
}
