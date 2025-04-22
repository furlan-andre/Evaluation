using Ambev.DeveloperEvaluation.Common.Validation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales.UpdateSale;

public class UpdateSaleCommand : IRequest<UpdateSaleResult>
{
    /// <summary>
    /// Gets the unique identifier
    /// It is a unique identifier for the sale
    /// </summary>
    public Guid Id { get; set; }
    
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
    /// Gets the representation of items for a sale    
    /// </summary>
    public IEnumerable<UpdateSaleItemCommand> Items { get; set; } = new List<UpdateSaleItemCommand>();
    
    public ValidationResultDetail Validate()
    {
        var validator = new UpdateSaleCommandValidator();
        var result = validator.Validate(this);
        return new ValidationResultDetail
        {
            IsValid = result.IsValid,
            Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
        };
    }
}
public class UpdateSaleItemCommand
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public bool Active { get; set; }
}