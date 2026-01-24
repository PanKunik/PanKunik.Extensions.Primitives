namespace PanKunik.Extensions.Primitives.Tests;

public class BoolExtensionsTests
{
    [Fact]
    public void IsNull_WhenValueIsNull_ShouldReturnTrue()
    {
        // Arrange
        bool? value = null;
        
        // Act & Assert
        Assert.True(value.IsNull());
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public void IsNull_WhenValueIsNotNull_ShouldReturnFalse(bool? value)
    {
        // Act & Assert
        Assert.False(value.IsNull());
    }
    
    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public void IsNotNull_WhenValueIsNotNull_ShouldReturnTrue(bool? value)
    {
        // Act & Assert
        Assert.True(value.IsNotNull());
    }

    [Fact]
    public void IsNotNull_WhenValueIsNotNull_ShouldReturnFalse()
    {
        // Arrange
        bool? value = null;
        
        // Act & Assert
        Assert.False(value.IsNotNull());
    }
}