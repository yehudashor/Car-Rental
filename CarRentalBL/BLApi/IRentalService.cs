using BusinessEntities;

namespace BLApi;

public interface IRentalService
{
    Task<CarRental> GetRentalPriceQuotes(CarRental carRental);
}
