using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale;

/// <summary>
/// Validator for CreateSaleItemCommand that defines validation rules for sale creation command.
/// </summary>
public class CreateSaleItemCommandValidator : AbstractValidator<CreateSaleItemCommand>
{
    /// <summary>
    /// Initializes a new instance of the CreateSaleItemCommandValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - ProductId: Cannot be null
    /// - Quantity: Cannot be null
    /// - UnitPrice: Cannot be null
    /// - Active: Cannot be null
    /// </remarks>
    public CreateSaleItemCommandValidator()
    {
        RuleFor(sale => sale.ProductId).NotEmpty();
        RuleFor(sale => sale.Quantity).NotEmpty().LessThanOrEqualTo(20);
        RuleFor(sale => sale.UnitPrice).NotEmpty();
        RuleFor(sale => sale.Active).NotNull();
    }
}