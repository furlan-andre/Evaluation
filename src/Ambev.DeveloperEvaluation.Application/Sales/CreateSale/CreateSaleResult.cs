namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale;

/// <summary>
/// Represents the response returned after successfully creating a new sale.
/// </summary>
/// <remarks>
/// This response contains the unique identifier of the newly created sale,
/// which can be used for subsequent operations or reference.
/// </remarks>
public class CreateSaleResult
{
    /// <summary>
    /// Gets or sets the unique identifier of the newly created sale.
    /// </summary>
    /// <value>A GUID that uniquely identifies the created sale in the system.</value>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Gets or sets the sale number of the newly created sale.
    /// </summary>
    /// <value>An integer that represents the number for the created sale in the system.</value>
    public int SaleNumber { get; set; }
    
    /// <summary>
    /// Gets or sets the date that sale was made.
    /// </summary>
    /// <value>A date that represents when the sale was created in the system.</value>
    public DateTime SaleDate { get; set; } = DateTime.UtcNow;
    
    /// <summary>
    /// Gets or sets the identification for the customer that sale was made.
    /// </summary>
    /// <value>A GUID that uniquely identifies the customer for the sale.</value>
    public Guid CustomerId { get; set; }

    /// <summary>
    /// Gets or sets the id for the branch who made the sale.
    /// </summary>
    /// <value>An integer that represents who created the sale.</value>
    public int BranchId { get; set; }
    
    /// <summary>
    /// Gets or sets the name for the branch who made the sale.
    /// </summary>
    /// <value>A name for the branch who made the sale in the system.</value>
    public string BranchName { get; set; }
    
    /// <summary>
    /// Gets or sets the total amount for the sale was made.
    /// </summary>
    /// <value>A total amount that represents the sum of the amount of the products created in the system.</value>
    public decimal TotalAmount { get; set; }
    
    /// <summary>
    /// Gets or sets the active value that sale was made.
    /// </summary>
    /// <value>A boolean value  that represents if the sale was valid.</value>
    public bool Active { get; set; }
}