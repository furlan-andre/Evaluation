using Ambev.DeveloperEvaluation.Domain.Entities;
using Bogus;

namespace Ambev.DeveloperEvaluation.Unit.Domain.Entities.TestData;

public class SaleItemTestData
{
    /// <summary>
    /// Configures the Faker to generate valid SaleItem entities.
    /// The generated SaleItem will have valid:
    /// - ProductId - GUID
    /// - Quantity - lesser or equal to 20
    /// - Unit price - any decimal positive
    /// - Active - true
    /// </summary>
    private static readonly Faker<SaleItem> SaleItemFaker = new Faker<SaleItem>()
        .RuleFor(s => s.SaleId, f => f.Random.Guid())
        .RuleFor(s => s.ProductId, f => f.Random.Guid())
        .RuleFor(s => s.Quantity, f => f.Random.Int(1, 19))
        .RuleFor(s => s.UnitPrice, f => Math.Round(f.Random.Decimal(0, 999.99m), 2))
        .RuleFor(s => s.TotalAmount, f => Math.Round(f.Random.Decimal(0, 999.99m), 2))
        .RuleFor(s => s.Active, true);

    /// <summary>
    /// Generates a valid SaleItem entity with randomized data.
    /// The generated user will have all properties populated with valid values
    /// that meet the system's validation requirements.
    /// </summary>
    /// <returns>A valid SaleItem entity with randomly generated data.</returns>
    public static SaleItem GenerateValidSale()
    {
        return SaleItemFaker.Generate();
    }
}