namespace Ambev.DeveloperEvaluation.Application.Sales.GetSale;

/// <summary>
/// Response model for GetSale operation
/// </summary>
public class GetSaleResult
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
    public DateTime SaleDate { get; set; }
    
    /// <summary>
    /// The unique identifier of the customer from sale
    /// </summary>
    public Guid CustomerId { get; set; }
    
    /// <summary>
    /// The reference for the branch
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
    /// The boolean value for active for the sale
    /// </summary>
    public bool Active { get; set; }
}