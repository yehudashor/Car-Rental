using CarRentalBL.BusinessEntities.CarRental;
using FluentValidation;

namespace CarRentalBL.ValidationRules.FluentValidation;

internal class RentalRequestValidator : AbstractValidator<RentalRequest>
{
    public RentalRequestValidator()
    {
        RuleFor(rr => rr.ReturnTime).GreaterThan(rr => rr.CollectionTime);
    }
}
