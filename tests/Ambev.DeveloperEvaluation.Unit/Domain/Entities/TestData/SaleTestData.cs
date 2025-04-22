using Ambev.DeveloperEvaluation.Domain.Entities;
using Bogus;

namespace Ambev.DeveloperEvaluation.Unit.Domain.Entities.TestData;

/// <summary>
/// Provides methods for generating test data using the Bogus library.
/// This class centralizes all test data generation to ensure consistency
/// across test cases and provide both valid and invalid data scenarios.
/// </summary>
public class SaleTestData
{
    /// <summary>
    /// Configures the Faker to generate valid Sale entities.
    /// The generated sale will have valid:
    /// - Sale number - random integer number (1-999)
    /// - Sale date - random date
    /// - Active - true
    /// - CustomerId - random Guid
    /// - BranchId - random reference number positive (1-999)
    /// - BranchName - random name
    /// - TotalAmount - valid number (1 - 9999
    /// </summary>
    private static readonly Faker<Sale> SaleFaker = new Faker<Sale>()
        .RuleFor(s => s.SaleNumber, f => f.Random.Int(1, 999))
        .RuleFor(s => s.SaleDate, f => f.Date.Past())
        .RuleFor(s => s.Active, true)
        .RuleFor(s => s.CustomerId, f => f.Random.Guid())
        .RuleFor(s => s.BranchId, f => f.Random.Int(1, 999))
        .RuleFor(s => s.BranchName, f => f.Name.FirstName())
        .RuleFor(s => s.TotalAmount, f => f.Random.Decimal(1, 9999));

    /// <summary>
    /// Generates a valid Sale entity with randomized data.
    /// The generated user will have all properties populated with valid values
    /// that meet the system's validation requirements.
    /// </summary>
    /// <returns>A valid Sale entity with randomly generated data.</returns>
    public static Sale GenerateValidSale()
    {
        return SaleFaker.Generate();
    }
}