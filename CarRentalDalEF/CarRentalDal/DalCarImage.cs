using CarRentalDalCore.DalApi.IEntityDal;
using CarRentalDalCore.DataObjects.CarOperations;
using CarRentalDalEF.EntityServiceBase;

namespace CarRentalDalEF.CarRentalDal;

public class DalCarImage : EntityServiceBase<CarImage, CarRentalDBContext.CarRentalDBContext>, ICarImage
{
}
