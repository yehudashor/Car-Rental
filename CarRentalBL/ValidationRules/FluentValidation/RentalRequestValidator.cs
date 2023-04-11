using BusinessEntities;
using FluentValidation;

namespace ValidationRules.FluentValidation;

internal class RentalRequestValidator : AbstractValidator<RentalRequest>
{
    public RentalRequestValidator()
    {
        RuleFor(rr => rr.ReturnTime).GreaterThan(rr => rr.CollectionTime);
    }
}
