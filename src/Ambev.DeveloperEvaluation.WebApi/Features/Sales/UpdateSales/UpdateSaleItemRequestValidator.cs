using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.UpdateSales;

/// <summary>
/// Validator for UpdateSaleItemRequest that defines validation rules for sale creation command.
/// </summary>
public class UpdateSaleItemRequestValidator : AbstractValidator<UpdateSaleItemRequest>
{
    /// <summary>
    /// Initializes a new instance of the SaleItemCommandValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - ProductId: Cannot be null
    /// - Quantity: Cannot be null
    /// - UnitPrice: Cannot be null
    /// - Active: Cannot be null
    /// </remarks>
    public UpdateSaleItemRequestValidator()
    {
        RuleFor(sale => sale.ProductId).NotEmpty();
        RuleFor(sale => sale.Quantity).NotEmpty();
        RuleFor(sale => sale.UnitPrice).NotEmpty();
        RuleFor(sale => sale.Active).NotNull();
    }
}