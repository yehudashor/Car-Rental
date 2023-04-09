using DataObjects;
using EntityServiceBase;
using IEntityDal;

namespace CarRentalDal;

public class DalCreditCard : EntityServiceBase<CreditCard, CarRentalDBContext.CarRentalDBContext>, ICreditCard
{
}
