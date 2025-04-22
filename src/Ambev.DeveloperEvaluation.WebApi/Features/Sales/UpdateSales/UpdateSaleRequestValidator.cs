using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.UpdateSales;

public class UpdateSaleRequestValidator : AbstractValidator<UpdateSaleRequest>
{
    /// <summary>
    /// Initializes a new instance of the CreateSaleRequestValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - SaleNumber: Cannot be null
    /// - SaleDate: Cannot be null
    /// - BranchId: Cannot be null
    /// - BranchName: Cannot be null
    /// - CustomerId: Cannot be null
    /// - TotalAmount: Cannot be a negative number
    /// - Active: Cannot be null
    /// </remarks>
    public UpdateSaleRequestValidator()
    {
        RuleFor(user => user.SaleNumber).NotEmpty();
        RuleFor(user => user.SaleDate).NotEmpty();
        RuleFor(user => user.BranchId).NotEmpty();
        RuleFor(user => user.BranchName).NotEmpty();
        RuleFor(user => user.CustomerId).NotEmpty();
        RuleFor(user => user.TotalAmount).GreaterThan(0);
        RuleFor(user => user.Active).NotEmpty();
    }
}