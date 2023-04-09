using DalApi.IEntityDal;
using DataObjects;
using EntityServiceBase;

namespace CarRentalDal;

public class DalCustomerPayment : EntityServiceBase<CustomerPayment, CarRentalDBContext.CarRentalDBContext>, ICustomerPayment
{
}
