using CarRentalDalCore.DalApi.IEntityDal;
using CarRentalDalCore.DataObjects.CarOperations;
using CarRentalDalEF.CarRentalDBContext;
using CarRentalDalEF.EntityServiceBase;

namespace CarRentalDalEF.CarRentalDal;

public class DalCarRental : EntityServiceBase<CarRental, CarRentalDBContext.CarRentalDBContext>, ICarRental
{
}
