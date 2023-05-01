using CarRentalDalCore.DalApi.IEntityDal;
using CarRentalDalCore.DataObjects.Customer;
using CarRentalDalEF.EntityServiceBase;

namespace CarRentalDalEF.CarRentalDal;

public class DalCreditCard : EntityServiceBase<CreditCard, CarRentalDBContext.CarRentalDBContext>, ICreditCard
{
}
