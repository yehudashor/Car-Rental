using CarRentalDalCore.DalApi.IEntityDal;
using CarRentalDalCore.DataObjects.Customer;
using CarRentalDalEF.CarRentalDBContext;
using CarRentalDalEF.EntityServiceBase;

namespace CarRentalDalEF.CarRentalDal;

public class DalCustomerDetails :
    EntityServiceBase<CustomerDetails, CarRentalDBContext.CarRentalDBContext>,
    ICustomerDetails
{
}
