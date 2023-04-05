using CrudBase;
using DalApi.IEntityDal;
using DO;

namespace CarRentalDal;

public class DalCustomerPayment : EFCrudBase<CustomerPayment, CarRentalDBContext.CarRentalDBContext>, ICustomerPayment
{
}
