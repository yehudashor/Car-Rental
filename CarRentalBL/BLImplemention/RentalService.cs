using CarRentalBL.BLApi;
using CarRentalBL.BusinessEntities.CarRental;
using CarRentalDalCore.DalApi.IEntityDal;
using FluentValidation;

namespace CarRentalBL.BLImplemention;
public class RentalService : IRentalService
{
    private readonly IValidator _validator;

    private readonly ICarRental _carRental;
    public RentalService(ICarRental carRental)
    {
        _carRental = carRental;
    }

    public async Task<CarRental> GetRentalPriceQuotes(CarRental carRental)
    {
        //_validator.Validate(carRental.RentalRequest);


        return carRental;
    }
}
