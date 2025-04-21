using Ambev.DeveloperEvaluation.Domain.Common;

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
    public DateTime SaleDate { get; set; } = DateTime.Now;
    
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
}