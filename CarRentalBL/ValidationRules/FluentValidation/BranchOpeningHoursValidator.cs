using CarRentalBL.BusinessEntities.Branch;
using FluentValidation;

namespace CarRentalBL.ValidationRules.FluentValidation;

internal class BranchOpeningHoursValidator : AbstractValidator<BranchOpeningHours>
{
    public BranchOpeningHoursValidator()
    {
        // RuleFor(opening => opening.ToDay)
        // .GreaterThan(opening => opening.FromDay);

        RuleFor(opening => opening.EndTime)
           .GreaterThan(opening => opening.StartTime);
    }
}
