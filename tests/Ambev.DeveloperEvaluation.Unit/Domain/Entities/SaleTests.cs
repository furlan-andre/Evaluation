using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Unit.Domain.Entities.TestData;
using Xunit;

namespace Ambev.DeveloperEvaluation.Unit.Domain.Entities;


public class SaleTests
{
    [Fact]
    public void Validate_ShouldReturnInvalid_WhenRequiredFieldsAreMissing()
    {
        // Arrange
        var sale = new Sale(); 

        // Act
        var result = sale.Validate();

        // Assert
        Assert.False(result.IsValid);
        Assert.NotEmpty(result.Errors);
    }

    [Fact]
    public void Validate_ShouldReturnValid_WhenAllRequiredFieldsAreSet()
    {
        // Arrange
        var saleItem = SaleItemTestData.GenerateValidSale();
        var sale = SaleTestData.GenerateValidSale();
        sale.Items = [saleItem];
        sale.CalculateTotalAmount();
        
        // Act
        var result = sale.Validate();

        // Assert
        Assert.True(result.IsValid);
    }

    [Theory]
    [InlineData(3, 10, 0, 30)] // sem desconto
    [InlineData(4, 10, 0.1, 36)] // 10%
    [InlineData(10, 10, 0.2, 80)] // 20%
    public void CalculateTotalAmount_ShouldApplyCorrectDiscounts(
        int quantity, decimal unitPrice, decimal expectedDiscountFactor, decimal expectedTotal)
    {
        // Arrange
        var validSaleItem = SaleItemTestData.GenerateValidSale();
        validSaleItem.Quantity = quantity;
        validSaleItem.UnitPrice = unitPrice;

        var validSale = SaleTestData.GenerateValidSale();
        validSale.Items = [validSaleItem];

        // Act
        validSale.CalculateTotalAmount();

        // Assert
        var discount = expectedDiscountFactor * quantity * unitPrice;
        Assert.Equal(discount, validSaleItem.Discount);
        Assert.Equal(expectedTotal, validSaleItem.TotalAmount);
        Assert.Equal(expectedTotal, validSale.TotalAmount);
    }

    [Fact]
    public void CalculateTotalAmount_ShouldIgnoreInactiveItems()
    {
        // Arrange
        var activeItem = SaleItemTestData.GenerateValidSale();
        var inactiveItem = SaleItemTestData.GenerateValidSale();
        inactiveItem.Active = false;
        var sale = SaleTestData.GenerateValidSale();
        sale.Items = [activeItem, inactiveItem];
        
        // Act
        sale.CalculateTotalAmount();

        // Assert
        Assert.True(sale.TotalAmount > 0);
        Assert.Equal(sale.TotalAmount, activeItem.TotalAmount);
    }
}
