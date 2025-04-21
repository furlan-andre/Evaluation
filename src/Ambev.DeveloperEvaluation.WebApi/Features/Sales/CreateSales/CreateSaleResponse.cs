namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSales;

/// <summary>
/// API response model for CreateSale operation
/// </summary>
public class CreateSaleResponse
{
    /// <summary>
    /// The unique identifier of the created sale
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The number for easy identification for futures reference to the sale
    /// </summary>
    public int SaleNumber { get; set; }
    
    /// <summary>
    /// The date that sale was made
    /// </summary>
    public DateTime SaleDate { get; set; } = DateTime.UtcNow;
    
    /// <summary>
    /// The unique identifier for the customer in the sale 
    /// </summary>
    public Guid CustomerId { get; set; }

    /// <summary>
    /// The identifier of the branch that made the sale
    /// </summary>
    public int BranchId { get; set; }
    
    /// <summary>
    /// The name of the branch that made the sale
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