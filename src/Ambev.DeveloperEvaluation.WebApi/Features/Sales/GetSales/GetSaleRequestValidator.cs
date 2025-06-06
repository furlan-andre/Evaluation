using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSales;

/// <summary>
/// Validator for GetSaleRequest
/// </summary>
public class GetSaleRequestValidator : AbstractValidator<GetSaleRequest>
{
    /// <summary>
    /// Initializes validation rules for GetSaleRequest
    /// </summary>
    public GetSaleRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("User ID is required");
    }
}