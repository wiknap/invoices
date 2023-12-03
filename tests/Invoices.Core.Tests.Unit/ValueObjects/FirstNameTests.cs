using Invoices.Core.ValueObjects;

using Shouldly;

using Xunit;

namespace Invoices.Core.Tests.Unit.ValueObjects;

public sealed class FirstNameTests
{
    // [Theory]
    // [InlineData(null)]
    // [InlineData("")]
    // [InlineData("                    ")]
    // [InlineData("ThisIsAFirstNameThatExceedsOneHundredCharactersInLengthAndIsThereforeInvalidAccordingToOurBusinessRules")]
    // public void Given_InvalidInput_When_CreatingFirstName_Then_ThrowsException(string? invalidInput)
    // {
    //     // Act
    //     var exception = Should.Throw<InvalidFirstNameException>(() => FirstName.Create(invalidInput));
    //
    //     // Assert
    //     exception.Value.ShouldBe(invalidInput);
    // }

    [Fact]
    public void Given_ValidInput_When_CreatingFirstName_Then_SetsValueCorrectly()
    {
        // Arrange
        const string validInput = "MyProduct";

        // Act
        var productName = FirstName.Create(validInput);

        // Assert
        productName.Value.ShouldBe(validInput);
    }

    [Fact]
    public void Given_String_When_ImplicitlyConvertedToFirstName_Then_ReturnsValidFirstName()
    {
        // Arrange
        const string validInput = "MyProduct";

        // Act
        FirstName productName = validInput;

        // Assert
        productName.Value.ShouldBe(validInput);
    }

    [Fact]
    public void Given_FirstName_When_ImplicitlyConvertedToString_Then_ReturnsCorrectString()
    {
        // Arrange
        const string validInput = "MyProduct";
        var productName = FirstName.Create(validInput);

        // Act
        string productString = productName;

        // Assert
        productString.ShouldBe(validInput);
    }

    [Fact]
    public void Given_FirstName_When_CallingToString_Then_ReturnsCorrectString()
    {
        // Arrange
        const string validInput = "MyProduct";
        var productName = FirstName.Create(validInput);

        // Act
        var result = productName.ToString();

        // Assert
        result.ShouldBe(validInput);
    }

    [Fact]
    public void Given_SameStringValue_When_EquatingFirstNames_Then_ReturnTrue()
    {
        // Arrange
        const string stringValue = "MyProduct";
        var productName1 = FirstName.Create(stringValue);
        var productName2 = FirstName.Create(stringValue);

        // Act
        var result = productName1.Equals(productName2);

        // Assert
        result.ShouldBeTrue();
    }

    [Fact]
    public void Given_SameFirstName_When_EquatingFirstNames_Then_ReturnTrue()
    {
        // Arrange
        const string stringValue = "MyProduct";
        var productName = FirstName.Create(stringValue);

        // Act
        var result = productName.Equals(productName);

        // Assert
        result.ShouldBeTrue();
    }

    [Fact]
    public void Given_Null_When_EquatingFirstNames_Then_ReturnFalse()
    {
        // Arrange
        const string stringValue = "MyProduct";
        var productName = FirstName.Create(stringValue);

        // Act
        var result = productName.Equals(null);

        // Assert
        result.ShouldBeFalse();
    }

    [Fact]
    public void Given_DifferentStringValue_When_EquatingFirstNames_Then_ReturnFalse()
    {
        // Arrange
        const string stringValue1 = "MyProduct";
        const string stringValue2 = "MyOtherProduct";
        var productName1 = FirstName.Create(stringValue1);
        var productName2 = FirstName.Create(stringValue2);

        // Act
        var result = productName1.Equals(productName2);

        // Assert
        result.ShouldBeFalse();
    }

    [Fact]
    public void Given_SameStringValue_When_GeneratingHashCodes_Then_TheyAreEqual()
    {
        // Arrange
        const string stringValue = "MyProduct";
        var productName1 = FirstName.Create(stringValue);
        var productName2 = FirstName.Create(stringValue);

        // Act
        var hashCode1 = productName1.GetHashCode();
        var hashCode2 = productName2.GetHashCode();

        // Assert
        hashCode1.ShouldBe(hashCode2.GetHashCode());
    }

    [Fact]
    public void Given_DifferentStringValue_When_GeneratingHashCodes_Then_TheyAreDifferent()
    {
        // Arrange
        const string stringValue1 = "MyProduct";
        const string stringValue2 = "MyOtherProduct";
        var productName1 = FirstName.Create(stringValue1);
        var productName2 = FirstName.Create(stringValue2);

        // Act
        var hashCode1 = productName1.GetHashCode();
        var hashCode2 = productName2.GetHashCode();

        // Assert
        hashCode1.ShouldNotBe(hashCode2);
    }

    [Fact]
    public void Given_SameValues_When_ObjectEquals_Then_ReturnsTrue()
    {
        // Arrange
        object obj1 = FirstName.Create("MyProduct");
        object obj2 = FirstName.Create("MyProduct");

        // Act
        var result = obj1.Equals(obj2);

        // Assert
        result.ShouldBeTrue();
    }

    [Fact]
    public void Given_SameValues2_When_ObjectEquals_Then_ReturnsTrue()
    {
        // Arrange
        var obj1 = FirstName.Create("MyProduct");
        var obj2 = FirstName.Create("MyProduct");

        // Act
        var result = obj1 == obj2;

        // Assert
        result.ShouldBeTrue();
    }

    [Fact]
    public void Given_SameValues_When_ObjectEquals2_Then_ReturnsTrue()
    {
        // Arrange
        object obj1 = FirstName.Create("MyProduct");
        var obj2 = FirstName.Create("MyProduct");

        // Act
        var result = obj1.Equals(obj2);

        // Assert
        result.ShouldBeTrue();
    }

    [Fact]
    public void Given_SameValues_When_ObjectEquals3_Then_ReturnsTrue()
    {
        // Arrange
        var obj1 = FirstName.Create("MyProduct");
        object obj2 = FirstName.Create("MyProduct");

        // Act
        var result = obj1.Equals(obj2);

        // Assert
        result.ShouldBeTrue();
    }

    [Fact]
    public void Given_DifferentValues_When_ObjectEquals_Then_ReturnsFalse()
    {
        // Arrange
        object obj1 = FirstName.Create("MyProduct");
        object obj2 = FirstName.Create("MyOtherProduct");

        // Act
        var result = obj1.Equals(obj2);

        // Assert
        result.ShouldBeFalse();
    }

    [Fact]
    public void Given_DifferentValues2_When_ObjectEquals_Then_ReturnsFalse()
    {
        // Arrange
        object obj1 = FirstName.Create("MyProduct");
        var obj2 = FirstName.Create("MyOtherProduct");

        // Act
        var result = obj1.Equals(obj2);

        // Assert
        result.ShouldBeFalse();
    }

    [Fact]
    public void Given_DifferentValues3_When_ObjectEquals_Then_ReturnsFalse()
    {
        // Arrange
        var obj1 = FirstName.Create("MyProduct");
        object obj2 = FirstName.Create("MyOtherProduct");

        // Act
        var result = obj1.Equals(obj2);

        // Assert
        result.ShouldBeFalse();
    }

    [Fact]
    public void Given_SameReference_When_ObjectEquals_Then_ReturnsTrue()
    {
        // Arrange
        object obj1 = FirstName.Create("MyProduct");

        // Act
        var result = obj1.Equals(obj1);

        // Assert
        result.ShouldBeTrue();
    }

    [Fact]
    public void Given_NullValue_When_ObjectEquals_Then_ReturnsFalse()
    {
        // Arrange
        object obj1 = FirstName.Create("MyProduct");

        // Act
        var result = obj1.Equals(null);

        // Assert
        result.ShouldBeFalse();
    }

    [Fact]
    public void Given_DifferentType_When_ObjectEquals_Then_ReturnsFalse()
    {
        // Arrange
        object obj1 = FirstName.Create("MyProduct");
        var obj2 = new object();

        // Act
        var result = obj1.Equals(obj2);

        // Assert
        result.ShouldBeFalse();
    }
}
