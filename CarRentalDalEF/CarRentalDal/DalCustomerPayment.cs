using RepositoryServiceBase;
using DalApi.IEntityDal;
using DO;

namespace CarRentalDal;

public class DalCustomerPayment : RepositoryServiceBase<CustomerPayment, CarRentalDBContext.CarRentalDBContext>, ICustomerPayment
{
}
