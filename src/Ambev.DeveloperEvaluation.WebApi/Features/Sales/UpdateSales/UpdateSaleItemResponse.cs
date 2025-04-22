namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.UpdateSales;

/// <summary>
/// API response model for UpdateSaleItem operation
/// </summary>
public class UpdateSaleItemResponse
{
    /// <summary>
    /// Gets or sets the unique identifier of the updated sale item.
    /// </summary>
    /// <value>A GUID that uniquely identifies the updated sale item in the system.</value>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Gets or sets the unique identifier of the updated sale.
    /// </summary>
    /// <value>A GUID that uniquely identifies the updated sale in the system.</value>
    public Guid SaleId { get; set; }
    
    /// <summary>
    /// Gets or sets the unique identifier of the product from updated sale item.
    /// </summary>
    /// <value>A GUID that uniquely identifies the product from updated sale item in the system.</value>
    public Guid ProductId { get; set; }
    
    /// <summary>
    /// Gets or sets the quantity for product of the updated sale item.
    /// </summary>
    /// <value>A decimal value for quantity in updated sale item in the system.</value>
    public int Quantity { get; set; }
    
    /// <summary>
    /// Gets or sets the unit price for product of the updated sale item.
    /// </summary>
    /// <value>A decimal value for unit price in updated sale item in the system.</value>
    public decimal UnitPrice { get; set; }
    
    /// <summary>
    /// Gets or sets the discount for product of the updated sale item.
    /// </summary>
    /// <value>A decimal value for discount in updated sale item in the system.</value>
    public decimal Discount { get; set; }
    
    /// <summary>
    /// Gets or sets the total amount for product of the updated sale item.
    /// </summary>
    /// <value>A decimal value for total amount in updated sale item in the system.</value>
    public decimal TotalAmount { get; set; }
    
    /// <summary>
    /// Gets or sets the active status of the updated sale item.
    /// </summary>
    /// <value>A boolean value for active in updated sale item in the system.</value>
    public bool Active { get; set; }
}