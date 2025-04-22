namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale;

/// <summary>
/// Represents the response returned after successfully created a sale item.
/// </summary>
/// <remarks>
/// This response contains the unique identifier of the created sale item,
/// which can be used for subsequent operations or reference.
/// </remarks>
public class CreateSaleItemResult
{
    /// <summary>
    /// Gets or sets the unique identifier of the created sale item.
    /// </summary>
    /// <value>A GUID that uniquely identifies the created sale item in the system.</value>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Gets or sets the unique identifier of the created sale.
    /// </summary>
    /// <value>A GUID that uniquely identifies the created sale in the system.</value>
    public Guid SaleId { get; set; }
    
    /// <summary>
    /// Gets or sets the unique identifier of the product from created sale item.
    /// </summary>
    /// <value>A GUID that uniquely identifies the product from created sale item in the system.</value>
    public Guid ProductId { get; set; }
    
    /// <summary>
    /// Gets or sets the quantity for product of the created sale item.
    /// </summary>
    /// <value>A decimal value for quantity in created sale item in the system.</value>
    public int Quantity { get; set; }
    
    /// <summary>
    /// Gets or sets the unit price for product of the created sale item.
    /// </summary>
    /// <value>A decimal value for unit price in created sale item in the system.</value>
    public decimal UnitPrice { get; set; }
    
    /// <summary>
    /// Gets or sets the discount for product of the created sale item.
    /// </summary>
    /// <value>A decimal value for discount in created sale item in the system.</value>
    public decimal Discount { get; set; }
    
    /// <summary>
    /// Gets or sets the total amount for product of the created sale item.
    /// </summary>
    /// <value>A decimal value for total amount in created sale item in the system.</value>
    public decimal TotalAmount { get; set; }
    
    /// <summary>
    /// Gets or sets the active status of the created sale item.
    /// </summary>
    /// <value>A boolean value for active in created sale item in the system.</value>
    public bool Active { get; set; }
}