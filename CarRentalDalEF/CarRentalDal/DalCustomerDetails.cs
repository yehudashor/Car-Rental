using CrudBase;
using DO;
using IEntityDal;

namespace CarRentalDal;

public class DalCustomerDetails :
    EFCrudBase<CustomerDetails, CarRentalDBContext.CarRentalDBContext>,
    ICustomerDetails
{
}
