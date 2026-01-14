namespace PanKunik.Extensions.Primitives.Tests;

public class StringExtensionsTests
{
    [Fact]
    public void IsNull_WhenValueIsNull_ShouldReturnTrue()
    {
        // Arrange
        string? value = null;
        
        // Act && Assert
        Assert.True(value.IsNull());
    }

    [Theory]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("A")]
    public void IsNull_WhenValueIsNotNull_ShouldReturnFalse(string value)
    {
        // Act & Assert
        Assert.False(value.IsNull());
    }
    
    [Fact]
    public void IsNotNull_WhenValueIsNull_ShouldReturnFalse()
    {
        // Arrange
        string? value = null;
        
        // Act && Assert
        Assert.False(value.IsNotNull());
    }

    [Theory]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("A")]
    public void IsNotNull_WhenValueIsNotNull_ShouldReturnTrue(string value)
    {
        // Act & Assert
        Assert.True(value.IsNotNull());
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void IsEmpty_WhenValueIsNullOrEmptyString_ShouldReturnTrue(string? value)
    {
        // Act & Assert
        Assert.True(value.IsEmpty());
    }

    [Theory]
    [InlineData("A")]
    [InlineData(" ")]
    public void IsEmpty_WhenValueIsAnyString_ShouldReturnFalse(string? value)
    {
        // Act & Assert
        Assert.False(value.IsEmpty());
    }

    [Theory]
    [InlineData("A")]
    [InlineData(" ")]
    public void IsNotEmpty_WhenValueIsAnyString_ShouldReturnTrue(string? value)
    {
        // Act & Assert
        Assert.True(value.IsNotEmpty());
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void IsNotEmpty_WhenValueIsNullOrEmpty_ShouldReturnFalse(string? value)
    {
        // Act & Assert
        Assert.False(value.IsNotEmpty());
    }

    [Theory]
    [InlineData("a")]
    [InlineData("A")]
    [InlineData("bc")]
    public void IsNullOrWhiteSpace_WhenValueIsNotEmptyOrWhiteSpaceString_ShouldReturnFalse(string? value)
    {
        // Act & Assert
        Assert.False(value.IsNullOrWhiteSpace());
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    public void IsNullOrWhiteSpace_WhenValueIsNullOrEmptyStringOrWhiteSpace_ShouldReturnTrue(string? value)
    {
        // Act & Assert
        Assert.True(value.IsNullOrWhiteSpace());
    }

    [Theory]
    [InlineData("a")]
    [InlineData("A")]
    [InlineData("bc")]
    public void IsNotNullOrWhiteSpace_WhenValueIsNotEmptyOrWhiteSpaceString_ShouldReturnTrue(string? value)
    {
        // Act & Assert
        Assert.True(value.IsNotNullOrWhiteSpace());
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    public void IsNotNullOrWhiteSpace_WhenValueIsNullOrEmptyStringOrWhiteSpace_ShouldReturnFalse(string? value)
    {
        // Act & Assert
        Assert.False(value.IsNotNullOrWhiteSpace());
    }
}