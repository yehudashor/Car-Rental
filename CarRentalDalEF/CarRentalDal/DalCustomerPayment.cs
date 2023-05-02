using CarRentalDalCore.DalApi.IEntityDal;
using CarRentalDalCore.DataObjects.Customer;
using CarRentalDalEF.EntityServiceBase;

namespace CarRentalDalEF.CarRentalDal;

public class DalCustomerPayment : EntityServiceBase<CustomerPayment, CarRentalDBContext.CarRentalDBContext>, ICustomerPayment
{
}
