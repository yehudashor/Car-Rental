using CarRentalDalCore.DalApi.IEntityDal;
using CarRentalDalCore.DataObjects.Car;
using CarRentalDalEF.CarRentalDBContext;
using CarRentalDalEF.EntityServiceBase;

namespace CarRentalDalEF.CarRentalDal;

public class DalCarImage : EntityServiceBase<CarImage, CarRentalDBContext.CarRentalDBContext>, ICarImage
{
}
