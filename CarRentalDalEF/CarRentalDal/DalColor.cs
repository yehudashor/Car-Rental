using CrudBase;
using DO;
using IEntityDal;

namespace CarRentalDal;

public class DalColor : EFCrudBase<CarColor, CarRentalDBContext.CarRentalDBContext>, ICarColor
{
}
