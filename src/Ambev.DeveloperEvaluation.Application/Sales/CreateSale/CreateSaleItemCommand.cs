using Ambev.DeveloperEvaluation.Common.Validation;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale;

/// <summary>
/// Command for creating a new sale item.
/// </summary>
/// <remarks>
/// This command is used to capture the required data for creating a sale item, 
/// including  
/// It implements <see cref="IRequest"/> to initiate the request 
/// that returns a <see cref="CreateSaleResult"/>.
/// 
/// The data provided in this command is validated using the 
/// <see cref="CreateSaleItemCommandValidator"/> which extends 
/// <see cref="AbstractValidator{T}"/> to ensure that the fields are correctly 
/// populated and follow the required rules.
/// </remarks>
public class CreateSaleItemCommand : IRequest<CreateSaleItemResult>
{
    /// <summary>
    /// Gets the unified identification of product
    /// It is a unified identification code for the product for sale item
    /// </summary>
    public Guid ProductId { get; set; }
    
    /// <summary>
    /// Gets the quantity of product
    /// It is a quantity  for the product for sale item
    /// </summary>
    public int Quantity { get; set; }
    
    /// <summary>
    /// Gets the unit price of product
    /// It is a unit price for the product for sale item
    /// </summary>
    public decimal UnitPrice { get; set; }
    
    /// <summary>
    /// Gets the value for active
    /// It is a value of active for the product for sale item
    /// </summary>
    public bool Active { get; set; }
    
    public ValidationResultDetail Validate()
    {
        var validator = new CreateSaleItemCommandValidator();
        var result = validator.Validate(this);
        return new ValidationResultDetail
        {
            IsValid = result.IsValid,
            Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
        };
    }
}