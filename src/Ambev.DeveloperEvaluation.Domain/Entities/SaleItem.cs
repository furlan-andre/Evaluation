using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Validation;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

public class SaleItem : BaseEntity
{
    /// <summary>
    /// Gets the value of the unique identified for sale
    /// </summary>
    public Guid SaleId { get; set; }
    
    /// <summary>
    /// Gets the sale
    /// </summary>
    public virtual Sale Sale { get; set; }
    
    /// <summary>
    /// Gets the value of the product unique identified for sale item
    /// </summary>
    public Guid ProductId { get; set; }
    
    /// <summary>
    /// Gets the value of quantity for sale item
    /// </summary>
    public int Quantity { get; set; }
    
    /// <summary>
    /// Gets the value of unit price for sale item
    /// </summary>
    public decimal UnitPrice { get; set; }
    
    /// <summary>
    /// Gets the value of discount for sale item
    /// </summary>
    public decimal Discount { get; set; }
    
    /// <summary>
    /// Gets the value of total amount for sale item
    /// </summary>
    public decimal TotalAmount { get; set; }
    
    /// <summary>
    /// Gets the representation of valid state for a sale item
    /// It is a boolean value that identify the sale item is active or inactive (cancelled)
    /// </summary>
    public bool Active { get; set; } = true;

    /// <summary>
    /// Performs validation of the sale item entity using the SaleItemValidator rules.
    /// </summary>
    /// <returns>
    /// A <see cref="ValidationResultDetail"/> containing:
    /// - IsValid: Indicates whether all validation rules passed
    /// - Errors: Collection of validation errors if any rules failed
    /// </returns>
    /// <remarks>
    /// <listheader>The validation includes checking:</listheader>
    /// <list type="bullet">Sale id is not empty</list>
    /// <list type="bullet">Product id is not empty</list>
    /// <list type="bullet">Quantity of the product is not empty and permited [1 - 20]</list>
    /// <list type="bullet">Unit price is not empty</list>
    /// <list type="bullet">Discount is permited for quantity of items</list>
    /// <list type="bullet">Total amount is greater than zero</list>
    /// <list type="bullet">Active is a valid value</list>
    /// </remarks>
    public ValidationResultDetail Validate()
    {
        var validator = new SaleItemValidator();
        var result = validator.Validate(this);
        return new ValidationResultDetail
        {
            IsValid = result.IsValid,
            Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
        };
    }
}