using Invoices.Core.Tests.Fakers;
using Invoices.Core.ValueObjects;

using Shouldly;

using Xunit;

namespace Invoices.Core.Tests.Unit;

public sealed class CompanyDataTests
{
    private readonly CompanyDataFaker faker = new();

    [Fact]
    public void Given_SameValues_When_Equals_Then_ReturnsTrue()
    {
        // Arrange
        var obj1 = new CompanyData("123", "Ulica", "1", "1", "City", "05-870");
        var obj2 = new CompanyData("123", "Ulica", "1", "1", "City", "05-870");

        // Act
        var result = obj1.Equals(obj2);

        // Assert
        result.ShouldBeTrue();
    }

    [Fact]
    public void Given_DifferentStreetName_When_Equals_Then_ReturnsFalse()
    {
        // Arrange
        var obj1 = new CompanyData("123", "Ulica", "1", "1", "City", "05-870");
        var obj2 = new CompanyData("123", "Ulicaa", "1", "1", "City", "05-870");

        // Act
        var result = obj1.Equals(obj2);

        // Assert
        result.ShouldBeFalse();
    }

    [Fact]
    public void Given_DifferentStreetNumber_When_Equals_Then_ReturnsFalse()
    {
        // Arrange
        var obj1 = new CompanyData("123", "Ulica", "1", "1", "City", "05-870");
        var obj2 = new CompanyData("123", "Ulica", "2", "1", "City", "05-870");

        // Act
        var result = obj1.Equals(obj2);

        // Assert
        result.ShouldBeFalse();
    }

    [Fact]
    public void Given_DifferentApartmentNumber_When_Equals_Then_ReturnsFalse()
    {
        // Arrange
        var obj1 = new CompanyData("123", "Ulica", "1", "1", "City", "05-870");
        var obj2 = new CompanyData("123", "Ulica", "1", "2", "City", "05-870");

        // Act
        var result = obj1.Equals(obj2);

        // Assert
        result.ShouldBeFalse();
    }

    [Fact]
    public void Given_DifferentCity_When_Equals_Then_ReturnsFalse()
    {
        // Arrange
        var obj1 = new CompanyData("123", "Ulica", "1", "1", "City", "05-870");
        var obj2 = new CompanyData("123", "Ulica", "1", "1", "City1", "05-870");

        // Act
        var result = obj1.Equals(obj2);

        // Assert
        result.ShouldBeFalse();
    }

    [Fact]
    public void Given_DifferentPostalCode_When_Equals_Then_ReturnsFalse()
    {
        // Arrange
        var obj1 = new CompanyData("123", "Ulica", "1", "1", "City", "05-870");
        var obj2 = new CompanyData("1234", "Ulica", "1", "1", "City", "05-871");

        // Act
        var result = obj1.Equals(obj2);

        // Assert
        result.ShouldBeFalse();
    }

    [Fact]
    public void Given_SameReference_When_Equals_Then_ReturnsTrue()
    {
        // Arrange
        var obj1 = faker.Generate();

        // Act
        var result = obj1.Equals(obj1);

        // Assert
        result.ShouldBeTrue();
    }
    //
    // [Fact]
    // public void Given_Null_When_Equal_Then_ReturnsFalse()
    // {
    //     // Arrange
    //     var obj1 = new CompanyData("123");
    //
    //     // Act
    //     var result = obj1.Equals(null);
    //
    //     // Assert
    //     result.ShouldBeFalse();
    // }
    //
    // [Fact]
    // public void Given_EqualObjects_When_GetHashCode_Then_ReturnsSameHashCode()
    // {
    //     // Arrange
    //     var obj1 = new CompanyData("123");
    //     var obj2 = new CompanyData("123");
    //
    //     // Act
    //     var hash1 = obj1.GetHashCode();
    //     var hash2 = obj2.GetHashCode();
    //
    //     // Assert
    //     hash1.ShouldBe(hash2);
    // }
    //
    // [Fact]
    // public void Given_SameValues_When_ObjectEquals_Then_ReturnsTrue()
    // {
    //     // Arrange
    //     object obj1 = new CompanyData("123");
    //     object obj2 = new CompanyData("123");
    //
    //     // Act
    //     var result = obj1.Equals(obj2);
    //
    //     // Assert
    //     result.ShouldBeTrue();
    // }
    //
    // [Fact]
    // public void Given_DifferentValues_When_ObjectEquals_Then_ReturnsFalse()
    // {
    //     // Arrange
    //     object obj1 = new CompanyData("123");
    //     object obj2 = new CompanyData("1234");
    //
    //     // Act
    //     var result = obj1.Equals(obj2);
    //
    //     // Assert
    //     result.ShouldBeFalse();
    // }
    //
    // [Fact]
    // public void Given_SameReference_When_ObjectEquals_Then_ReturnsTrue()
    // {
    //     // Arrange
    //     object obj1 = new CompanyData("123");
    //
    //     // Act
    //     var result = obj1.Equals(obj1);
    //
    //     // Assert
    //     result.ShouldBeTrue();
    // }
    //
    // [Fact]
    // public void Given_NullValue_When_ObjectEquals_Then_ReturnsFalse()
    // {
    //     // Arrange
    //     object obj1 = new CompanyData("123");
    //
    //     // Act
    //     var result = obj1.Equals(null);
    //
    //     // Assert
    //     result.ShouldBeFalse();
    // }
    //
    // [Fact]
    // public void Given_DifferentType_When_ObjectEquals_Then_ReturnsFalse()
    // {
    //     // Arrange
    //     object obj1 = new CompanyData("123");
    //     var obj2 = new object();
    //
    //     // Act
    //     var result = obj1.Equals(obj2);
    //
    //     // Assert
    //     result.ShouldBeFalse();
    // }
    //
    // [Fact]
    // public void Given_SameValues_When_EqualsOperator_Then_ReturnsTrue()
    // {
    //     // Arrange
    //     var obj1 = new CompanyData("123");
    //     var obj2 = new CompanyData("123");
    //
    //     // Act
    //     var result = obj1 == obj2;
    //
    //     // Assert
    //     result.ShouldBeTrue();
    // }
    //
    // [Fact]
    // public void Given_DifferentValues_When_EqualsOperator_Then_ReturnsFalse()
    // {
    //     // Arrange
    //     var obj1 = new CompanyData("123");
    //     var obj2 = new CompanyData("1234");
    //
    //     // Act
    //     var result = obj1 == obj2;
    //
    //     // Assert
    //     result.ShouldBeFalse();
    // }
    //
    // [Fact]
    // public void Given_SameReference_When_EqualsOperator_Then_ReturnsTrue()
    // {
    //     // Arrange
    //     var obj1 = new CompanyData("123");
    //
    //     // Act
    //     var result = obj1 == obj1;
    //
    //     // Assert
    //     result.ShouldBeTrue();
    // }
    //
    // [Fact]
    // public void Given_Null_When_EqualsOperator_Then_ReturnsFalse()
    // {
    //     // Arrange
    //     var obj1 = new CompanyData("123");
    //
    //     // Act
    //     var result = obj1 == null;
    //
    //     // Assert
    //     result.ShouldBeFalse();
    // }
}
