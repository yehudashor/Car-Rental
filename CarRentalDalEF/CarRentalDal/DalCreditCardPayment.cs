using DataObjects;
using EntityServiceBase;
using IEntityDal;

namespace CarRentalDal;

public class DalCreditCardPayment : EntityServiceBase<CreditCardPayment, CarRentalDBContext.CarRentalDBContext>, ICreditCardPayment
{
}
