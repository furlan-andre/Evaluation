namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.UpdateSales;

/// <summary>
/// Represents a request to update a sale item in the system.
/// </summary>
public class UpdateSaleItemRequest
{
    /// <summary>
    /// It is a unified identification for the sale item
    /// </summary>
    public Guid Id { get; set; }

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