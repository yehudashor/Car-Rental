using CrudBase;
using DO;
using IEntityDal;

namespace CarRentalDal;

public class DalCreditCardPayment : EFCrudBase<CreditCardPayment, CarRentalDBContext.CarRentalDBContext>, ICreditCardPayment
{
}
