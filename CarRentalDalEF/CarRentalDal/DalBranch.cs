using CarRentalDalEF.CrudBase;
using DalApi.IEntityDal;
using DO;

namespace CarRentalDalEF.CarRentalDal;

public class DalBranch : EFCrudBase<Branch, CarRentalDBContext>, IBranch
{

}
