namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSales;

/// <summary>
/// Represents a request to create a new sale item in the system.
/// </summary>
public class CreateSaleItemRequest
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
}