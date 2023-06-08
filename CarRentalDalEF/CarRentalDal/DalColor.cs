using CarRentalDalCore.DalApi.IEntityDal;
using CarRentalDalCore.DataObjects.Car;
using CarRentalDalEF.CarRentalDBContext;
using CarRentalDalEF.EntityServiceBase;

namespace CarRentalDalEF.CarRentalDal;

public class DalColor : EntityServiceBase<CarColor, CarRentalDBContext.CarRentalDBContext>, ICarColor
{
}
