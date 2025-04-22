using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Sales.UpdateSale;

/// <summary>
/// Validator for UpdateSaleItemCommand that defines validation rules for sale update command.
/// </summary>
public class UpdateSaleItemCommandValidator : AbstractValidator<UpdateSaleItemCommand>
{
    /// <summary>
    /// Initializes a new instance of the UpdateSaleItemCommandValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - ProductId: Cannot be null
    /// - Quantity: Cannot be null
    /// - UnitPrice: Cannot be null
    /// - Active: Cannot be null
    /// </remarks>
    public UpdateSaleItemCommandValidator()
    {
        RuleFor(sale => sale.ProductId).NotEmpty();
        RuleFor(sale => sale.Quantity).NotEmpty();
        RuleFor(sale => sale.UnitPrice).NotEmpty();
        RuleFor(sale => sale.Active).NotNull();
    }
}