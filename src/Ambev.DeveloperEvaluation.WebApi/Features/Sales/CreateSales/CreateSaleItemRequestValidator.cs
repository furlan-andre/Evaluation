using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSales;

public class CreateSaleItemRequestValidator : AbstractValidator<CreateSaleItemRequest>
{
    /// <summary>
    /// Initializes a new instance of the CreateSaleRequestValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - ProductId: Cannot be null
    /// - Quantity: Cannot be null
    /// - UnitPrice: Cannot be null
    /// - Active: Cannot be null
    /// </remarks>
    public CreateSaleItemRequestValidator()
    {
        RuleFor(sale => sale.ProductId).NotEmpty();
        RuleFor(sale => sale.Quantity).NotEmpty();
        RuleFor(sale => sale.UnitPrice).NotEmpty();
        RuleFor(sale => sale.Active).NotNull();
    }
}