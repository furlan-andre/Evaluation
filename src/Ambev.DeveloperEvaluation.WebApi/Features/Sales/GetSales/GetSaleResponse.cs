namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSales;

/// <summary>
/// API response model for GetSale operation
/// </summary>
public class GetSaleResponse
{
    /// <summary>
    /// The unique identifier of the sale
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The number of the sale
    /// </summary>
    public int SaleNumber { get; set; }
    
    /// <summary>
    /// The date of the sale
    /// </summary>
    public DateTime SaleDate { get; set; } = DateTime.UtcNow;
    
    /// <summary>
    /// The unique identifier of the customer
    /// </summary>
    public Guid CustomerId { get; set; }

    /// <summary>
    /// The identifier of the branch of the sale
    /// </summary>
    public int BranchId { get; set; }
    
    /// <summary>
    /// The branch name of the sale
    /// </summary>
    public string BranchName { get; set; }
    
    /// <summary>
    /// The total amount of the sale
    /// </summary>
    public decimal TotalAmount { get; set; }
    
    /// <summary>
    /// The value for active of the sale
    /// </summary>
    public bool Active { get; set; }
}