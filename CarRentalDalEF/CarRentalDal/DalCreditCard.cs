using CrudBase;
using DO;
using IEntityDal;

namespace CarRentalDal;

public class DalCreditCard : EFCrudBase<CreditCard, CarRentalDBContext.CarRentalDBContext>, ICreditCard
{
}
