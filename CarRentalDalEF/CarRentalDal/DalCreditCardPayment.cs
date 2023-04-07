using RepositoryServiceBase;
using DO;
using IEntityDal;

namespace CarRentalDal;

public class DalCreditCardPayment : RepositoryServiceBase<CreditCardPayment, CarRentalDBContext.CarRentalDBContext>, ICreditCardPayment
{
}
