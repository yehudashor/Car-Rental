using CarRentalDalCore.DalApi.IEntityDal;
using CarRentalDalCore.DataObjects.CarOperations;
using CarRentalDalEF.CarRentalDBContext;
using CarRentalDalEF.EntityServiceBase;

namespace CarRentalDalEF.CarRentalDal;

public class DalColor : EntityServiceBase<CarColor, CarRentalDBContext.CarRentalDBContext>, ICarColor
{
}
