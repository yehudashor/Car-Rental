using CrudBase;
using DO;
using IEntityDal;

namespace CarRentalDal;

public class DalLocation : EFCrudBase<Location, CarRentalDBContext.CarRentalDBContext>, ILocation
{
}
