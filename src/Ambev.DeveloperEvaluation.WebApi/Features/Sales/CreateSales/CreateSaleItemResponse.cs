namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSales;

/// <summary>
/// API response model for CreateSaleItem operation
/// </summary>
public class CreateSaleItemResponse
{
    /// <summary>
    /// Gets the value of the unique identified for sale
    /// </summary>
    public Guid SaleId { get; set; }
    
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
} 