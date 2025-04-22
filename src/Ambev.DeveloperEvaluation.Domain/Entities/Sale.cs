using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Validation;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

/// <summary>
/// Represents a sale in the system.
/// This entity follows domain-driven design principles and includes business rules validation.
/// </summary>
public class Sale : BaseEntity
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
    /// Gets the total amount of the sale
    /// It is a number that identify the total amount of the sale
    /// </summary>
    public decimal TotalAmount { get; set; }

    /// <summary>
    /// Gets the representation of valid state for a sale
    /// It is a boolean value that identify the sale is active or inactive (cancelled)
    /// </summary>
    public bool Active { get; set; } = true;
  
    /// <summary>
    /// Gets the representation of the items for a sale
    /// </summary>
    public ICollection<SaleItem> Items { get; private set; } = new List<SaleItem>();
    
    /// <summary>
    /// Performs validation of the sale entity using the SaleValidator rules.
    /// </summary>
    /// <returns>
    /// A <see cref="ValidationResultDetail"/> containing:
    /// - IsValid: Indicates whether all validation rules passed
    /// - Errors: Collection of validation errors if any rules failed
    /// </returns>
    /// <remarks>
    /// <listheader>The validation includes checking:</listheader>
    /// <list type="bullet">Sale number is not empty</list>
    /// <list type="bullet">Sale date is not empty</list>
    /// <list type="bullet">Branch identification is not empty</list>
    /// <list type="bullet">Branch name is not empty</list>
    /// <list type="bullet">Customer is not empty</list>
    /// <list type="bullet">Total amount is greater than zero</list>
    /// <list type="bullet">Active is a valid value</list>
    /// </remarks>
    public ValidationResultDetail Validate()
    {
        var validator = new SaleValidator();
        var result = validator.Validate(this);
        return new ValidationResultDetail
        {
            IsValid = result.IsValid,
            Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
        };
    }

    public void CalculateTotalAmount()
    {
        foreach (var saleItem in Items)
        {
            var subtotal = (saleItem.Quantity * saleItem.UnitPrice);
            var discountFactor = GetDiscountFactor(saleItem);
            saleItem.Discount = discountFactor * subtotal;
            saleItem.TotalAmount = subtotal - saleItem.Discount;
        }
        
        TotalAmount = Items.Sum(o => o.TotalAmount);
    }

    public decimal GetDiscountFactor(SaleItem saleItem) =>
        (saleItem.Quantity >= 10) ? (decimal) 0.2 :
        (saleItem.Quantity >= 4 && saleItem.Quantity <= 9) ? (decimal)0.1 :
        0;
}