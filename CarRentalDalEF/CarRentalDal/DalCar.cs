using CrudBase;
using DO;
using IEntityDal;

namespace CarRentalDal;

public class DalCar : EFCrudBase<Car, CarRentalDBContext.CarRentalDBContext>, ICar
{
}
