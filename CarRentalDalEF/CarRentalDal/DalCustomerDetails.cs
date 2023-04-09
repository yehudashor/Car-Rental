using DataObjects;
using EntityServiceBase;
using IEntityDal;

namespace CarRentalDal;

public class DalCustomerDetails :
    EntityServiceBase<CustomerDetails, CarRentalDBContext.CarRentalDBContext>,
    ICustomerDetails
{
}
