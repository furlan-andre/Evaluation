namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSales;

public class CreateSaleRequest
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
    /// Gets or sets the total amount of sale.
    /// </summary>
    public decimal TotalAmount { get; set; }

    /// <summary>
    /// Gets or sets active to the sale.
    /// </summary>
    public bool Active { get; set; }
}