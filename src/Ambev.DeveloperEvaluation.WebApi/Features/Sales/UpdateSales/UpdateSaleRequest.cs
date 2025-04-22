namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.UpdateSales;

public class UpdateSaleRequest
{
    /// <summary>
    /// Gets or sets the sale number.
    /// </summary>
    public int SaleNumber { get; set; }

    /// <summary>
    /// Gets or sets the sale date.
    /// </summary>
    public DateTime SaleDate { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Gets or sets the customer identification.
    /// </summary>
    public Guid CustomerId { get; set; }

    /// <summary>
    /// Gets or sets the identification of the branch.
    /// </summary>
    public int BranchId { get; set; }

    /// <summary>
    /// Gets or sets the name of the branch.
    /// </summary>
    public string BranchName { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets active to the sale.
    /// </summary>
    public bool Active { get; set; }

    /// <summary>
    /// Get or sets the representation of Items for the sale
    /// </summary>
    public IEnumerable<UpdateSaleItemRequest> Items { get; set; } = new List<UpdateSaleItemRequest>();
}