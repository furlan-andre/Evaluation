using Ambev.DeveloperEvaluation.Common.Validation;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale;

/// <summary>
/// Command for creating a new sale.
/// </summary>
/// <remarks>
/// This command is used to capture the required data for creating a sale, 
/// including  
/// It implements <see cref="IRequest{TResponse}"/> to initiate the request 
/// that returns a <see cref="CreateSaleResult"/>.
/// 
/// The data provided in this command is validated using the 
/// <see cref="CreateSaleCommandValidator"/> which extends 
/// <see cref="AbstractValidator{T}"/> to ensure that the fields are correctly 
/// populated and follow the required rules.
/// </remarks>
public class CreateSaleCommand : IRequest<CreateSaleResult>
{
    /// <summary>
    /// Gets the number of sale
    /// It is a number that identify the sale
    /// </summary>
    public int SaleNumber { get; set; }
    
    /// <summary>
    /// Gets the date of sale
    /// It is a date that identify when the sale was made
    /// </summary>
    public DateTime SaleDate { get; set; } = DateTime.UtcNow;
    
    /// <summary>
    /// Gets the identification of customer
    /// It is an identification code that identify the customer of the sale
    /// </summary>
    public Guid CustomerId  { get; set; }
    
    /// <summary>
    /// Gets the identification of branch
    /// It is an identification code that identify the branch that made the sale
    /// </summary>
    public int BranchId  { get; set; }
    
    /// <summary>
    /// Gets the name of branch
    /// It is a name that identify the branch that made the sale
    /// </summary>
    public string BranchName { get; set; } = string.Empty;

    /// <summary>
    /// Gets the representation of valid state for a sale
    /// It is a boolean value that identify the sale is active or inactive (cancelled)
    /// </summary>
    public bool Active { get; set; } = true;
    
    /// <summary>
    /// Gets the representation of Items for the sale
    /// </summary>
    public IEnumerable<CreateSaleItemCommand> Items { get; set; } = new List<CreateSaleItemCommand>(); 
    
    public ValidationResultDetail Validate()
    {
        var validator = new CreateSaleCommandValidator();
        var result = validator.Validate(this);
        return new ValidationResultDetail
        {
            IsValid = result.IsValid,
            Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
        };
    }
}