using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Sales.UpdateSale;

/// <summary>
/// Validator for CreateSaleCommand that defines validation rules for sale creation command.
/// </summary>
public class UpdateSaleCommandValidator : AbstractValidator<UpdateSaleCommand>
{
    /// <summary>
    /// Initializes a new instance of the CreateSaleCommandValidator with defined validation rules.
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
    public UpdateSaleCommandValidator()
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