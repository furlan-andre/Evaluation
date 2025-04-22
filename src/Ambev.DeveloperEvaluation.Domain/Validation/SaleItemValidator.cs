using Ambev.DeveloperEvaluation.Domain.Entities;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Domain.Validation;

public class SaleItemValidator : AbstractValidator<SaleItem>
{
    public SaleItemValidator()
    {
        RuleFor(x => x.SaleId)
            .NotEmpty()
            .WithMessage("Sale Id cannot be empty");
        
        RuleFor(x => x.ProductId)
            .NotEmpty()
            .WithMessage("Product Id cannot be empty");
        
        RuleFor(x => x.Quantity)
            .NotEmpty().WithMessage("Quantity cannot be empty")
            .GreaterThan(20).WithMessage("Quantity cannot be greater than 20");

        RuleFor(x => x.UnitPrice)
            .NotEmpty().WithMessage("Unit price cannot be empty");
        
        RuleFor(x => x.TotalAmount)
            .NotEmpty().WithMessage("Total amount cannot be empty");

        RuleFor(x => x.Active)
            .NotEmpty()
            .WithMessage("Active cannot be empty");
                
        RuleFor(x => x.Discount)
            .Must((item, discount) => item.Quantity >= 4 ||  discount == 0)
            .WithMessage("Discount it is just allowed for items above 4");
    }
}