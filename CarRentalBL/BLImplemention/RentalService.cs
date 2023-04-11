using BLApi;
using BusinessEntities;
using FluentValidation;
using IEntityDal;

namespace BLImplemention;
public class RentalService : IRentalService
{
    private readonly IValidator _validator;

    private readonly ICarRental _carRental;
    public RentalService(ICarRental carRental, IValidator validator)
    {
        _carRental = carRental;
        _validator = validator;
    }

    public async Task<CarRental> GetRentalPriceQuotes(CarRental carRental)
    {
        //_validator.Validate(carRental.RentalRequest);


        return carRental;
    }
}
