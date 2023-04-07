using RepositoryServiceBase;
using DO;
using IEntityDal;

namespace CarRentalDal;

public class DalCreditCard : RepositoryServiceBase<CreditCard, CarRentalDBContext.CarRentalDBContext>, ICreditCard
{
}
