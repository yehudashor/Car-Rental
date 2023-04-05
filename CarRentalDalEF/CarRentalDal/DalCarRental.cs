using CrudBase;
using DO;
using IEntityDal;

namespace CarRentalDal;

public class DalCarRental : EFCrudBase<CarRental, CarRentalDBContext.CarRentalDBContext>, ICarRental
{
}
