using CarRentalDalCore.DalApi.IEntityDal;
using CarRentalDalCore.DataObjects.Customer;
using CarRentalDalEF.EntityServiceBase;

namespace CarRentalDalEF.CarRentalDal;

public class DalCustomerDetails :
    EntityServiceBase<CustomerDetails, CarRentalDBContext.CarRentalDBContext>,
    ICustomerDetails
{
}
