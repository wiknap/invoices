using Invoices.Core.ValueObjects;

using Shouldly;

using Xunit;

namespace Invoices.Core.Tests.Unit;

public sealed class CompanyNameTests
{
    [Fact]
    public void Given_SameValues_When_Equals_Then_ReturnsTrue()
    {
        // Arrange
        var obj1 = new CompanyName("123");
        var obj2 = new CompanyName("123");

        // Act
        var result = obj1.Equals(obj2);

        // Assert
        result.ShouldBeTrue();
    }

    [Fact]
    public void Given_DifferentValues_When_Equals_Then_ReturnsFalse()
    {
        // Arrange
        var obj1 = new CompanyName("123");
        var obj2 = new CompanyName("1234");

        // Act
        var result = obj1.Equals(obj2);

        // Assert
        result.ShouldBeFalse();
    }

    [Fact]
    public void Given_SameReference_When_Equals_Then_ReturnsTrue()
    {
        // Arrange
        var obj1 = new CompanyName("123");

        // Act
        var result = obj1.Equals(obj1);

        // Assert
        result.ShouldBeTrue();
    }

    [Fact]
    public void Given_Null_When_Equal_Then_ReturnsFalse()
    {
        // Arrange
        var obj1 = new CompanyName("123");

        // Act
        var result = obj1.Equals(null);

        // Assert
        result.ShouldBeFalse();
    }

    [Fact]
    public void Given_EqualObjects_When_GetHashCode_Then_ReturnsSameHashCode()
    {
        // Arrange
        var obj1 = new CompanyName("123");
        var obj2 = new CompanyName("123");

        // Act
        var hash1 = obj1.GetHashCode();
        var hash2 = obj2.GetHashCode();

        // Assert
        hash1.ShouldBe(hash2);
    }

    [Fact]
    public void Given_SameValues_When_ObjectEquals_Then_ReturnsTrue()
    {
        // Arrange
        object obj1 = new CompanyName("123");
        object obj2 = new CompanyName("123");

        // Act
        var result = obj1.Equals(obj2);

        // Assert
        result.ShouldBeTrue();
    }

    [Fact]
    public void Given_DifferentValues_When_ObjectEquals_Then_ReturnsFalse()
    {
        // Arrange
        object obj1 = new CompanyName("123");
        object obj2 = new CompanyName("1234");

        // Act
        var result = obj1.Equals(obj2);

        // Assert
        result.ShouldBeFalse();
    }

    [Fact]
    public void Given_SameReference_When_ObjectEquals_Then_ReturnsTrue()
    {
        // Arrange
        object obj1 = new CompanyName("123");

        // Act
        var result = obj1.Equals(obj1);

        // Assert
        result.ShouldBeTrue();
    }

    [Fact]
    public void Given_NullValue_When_ObjectEquals_Then_ReturnsFalse()
    {
        // Arrange
        object obj1 = new CompanyName("123");

        // Act
        var result = obj1.Equals(null);

        // Assert
        result.ShouldBeFalse();
    }

    [Fact]
    public void Given_DifferentType_When_ObjectEquals_Then_ReturnsFalse()
    {
        // Arrange
        object obj1 = new CompanyName("123");
        var obj2 = new object();

        // Act
        var result = obj1.Equals(obj2);

        // Assert
        result.ShouldBeFalse();
    }

    [Fact]
    public void Given_SameValues_When_EqualsOperator_Then_ReturnsTrue()
    {
        // Arrange
        var obj1 = new CompanyName("123");
        var obj2 = new CompanyName("123");

        // Act
        var result = obj1 == obj2;

        // Assert
        result.ShouldBeTrue();
    }

    [Fact]
    public void Given_DifferentValues_When_EqualsOperator_Then_ReturnsFalse()
    {
        // Arrange
        var obj1 = new CompanyName("123");
        var obj2 = new CompanyName("1234");

        // Act
        var result = obj1 == obj2;

        // Assert
        result.ShouldBeFalse();
    }

    [Fact]
    public void Given_SameReference_When_EqualsOperator_Then_ReturnsTrue()
    {
        // Arrange
        var obj1 = new CompanyName("123");

        // Act
        var result = obj1 == obj1;

        // Assert
        result.ShouldBeTrue();
    }

    [Fact]
    public void Given_Null_When_EqualsOperator_Then_ReturnsFalse()
    {
        // Arrange
        var obj1 = new CompanyName("123");

        // Act
        var result = obj1 == null;

        // Assert
        result.ShouldBeFalse();
    }
}
