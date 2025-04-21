using Ambev.DeveloperEvaluation.Domain.Entities;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Domain.Validation;

public class SaleValidator : AbstractValidator<Sale>
{
    public SaleValidator()
    {
        RuleFor(sale => sale.SaleNumber)
            .NotEmpty()
            .WithMessage("Sale number cannot be empty");
        
        RuleFor(sale => sale.SaleDate)
            .NotEmpty()
            .WithMessage("Sale date cannot be empty");
        
        RuleFor(sale => sale.BranchId)
            .NotEmpty()
            .WithMessage("Branch id cannot be empty");
        
        RuleFor(sale => sale.BranchName)
            .NotEmpty()
            .WithMessage("Branch name cannot be empty");

        RuleFor(sale => sale.CustomerId)
            .NotEmpty()
            .WithMessage("Customer id cannot be empty");
        
        RuleFor(sale => sale.TotalAmount)
            .NotNull()
            .GreaterThan(0)
            .WithMessage("Total amount must be a positive number");
        
        RuleFor(sale => sale.Active)
            .NotEmpty()
            .WithMessage("Active cannot be empty");
    }
}