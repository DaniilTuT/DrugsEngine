using Domain.Entities;
using FluentValidation;

namespace Domain.Validators;

public class DrugItemValidator: AbstractValidator<DrugItem>
{
    public DrugItemValidator()
    {
        RuleFor(di => di.Cost)
            .GreaterThan(0).WithMessage(ValidationMessage.InvalidCost)
            .PrecisionScale(15,2,true).WithMessage(ValidationMessage.InvalidCost);
        RuleFor(di => di.Count)
            .InclusiveBetween(0,10000).WithMessage(ValidationMessage.OutOfRangeCount);}
}
