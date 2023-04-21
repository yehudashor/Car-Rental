using CarRentalBL.BusinessEntities.CarRental;

namespace CarRentalBL.BLApi;

public interface IRentalService
{
    Task<CarRental> GetRentalPriceQuotes(CarRental carRental);
}
