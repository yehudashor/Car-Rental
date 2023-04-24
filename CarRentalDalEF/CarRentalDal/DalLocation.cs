using CarRentalDalCore.DalApi.IEntityDal;
using CarRentalDalCore.DataObjects.Locations;
using CarRentalDalEF.CarRentalDBContext;
using CarRentalDalEF.EntityServiceBase;

namespace CarRentalDalEF.CarRentalDal;

public class DalLocation : EntityServiceBase<Location, CarRentalDBContext.CarRentalDBContext>, ILocation
{
}
