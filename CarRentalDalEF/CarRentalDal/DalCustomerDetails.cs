using DO;
using IEntityDal;
using RepositoryServiceBase;

namespace CarRentalDal;

public class DalCustomerDetails :
    RepositoryServiceBase<CustomerDetails, CarRentalDBContext.CarRentalDBContext>,
    ICustomerDetails
{
}
