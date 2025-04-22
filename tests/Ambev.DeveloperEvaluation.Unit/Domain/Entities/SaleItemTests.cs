using Ambev.DeveloperEvaluation.Unit.Domain.Entities.TestData;
using Xunit;

namespace Ambev.DeveloperEvaluation.Unit.Domain.Entities;

public class SaleItemTests
{
    [Fact]
    public void Validate_ShouldReturnValid_WhenAllRequiredFieldsAreSet()
    {
        // Arrange
        var saleItem = SaleItemTestData.GenerateValidSale();

        // Act
        var result = saleItem.Validate();

        // Assert
        Assert.True(result.IsValid);
    }

    [Fact]
    public void Validate_shouldReturnInvalid_WhenItemQuantityIsOverTheLimit()
    {
        // Arrange
        var saleItem = SaleItemTestData.GenerateValidSale();
        saleItem.Quantity = 21;
        var sale = SaleTestData.GenerateValidSale();
        sale.Items = [saleItem];
        sale.CalculateTotalAmount();

        // Act
        var result = sale.Validate();

        // Assert
        Assert.False(result.IsValid);
    }
}