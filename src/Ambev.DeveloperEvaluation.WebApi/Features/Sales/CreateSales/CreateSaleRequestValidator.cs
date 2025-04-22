using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSales;

public class CreateSaleRequestValidator : AbstractValidator<CreateSaleRequest>
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
    public CreateSaleRequestValidator()
    {
        RuleFor(sale => sale.SaleNumber).NotEmpty();
        RuleFor(sale => sale.SaleDate).NotEmpty();
        RuleFor(sale => sale.BranchId).NotEmpty();
        RuleFor(sale => sale.BranchName).NotEmpty();
        RuleFor(sale => sale.CustomerId).NotEmpty();
        RuleFor(sale => sale.Active).NotNull();
        RuleForEach(sale => sale.Items)
            .SetValidator(new CreateSaleItemRequestValidator());
    }
}