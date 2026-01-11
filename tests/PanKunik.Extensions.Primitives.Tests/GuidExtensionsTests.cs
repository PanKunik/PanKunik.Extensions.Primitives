namespace PanKunik.Extensions.Primitives.Tests;

public class GuidExtensionsTests
{
    [Theory, MemberData(nameof(IsEmptyTestValues))]
    public void IsEmpty_ForValidGuids_ShouldReturnExpectedValue(string value, bool expectedResult)
    {
        // Arrange
        var guid = Guid.Parse(value);
        
        // Act & Assert
        Assert.Equal(expectedResult, guid.IsEmpty());
    }

    public static IEnumerable<object[]> IsEmptyTestValues()
    {
        yield return new object[] { Guid.Empty.ToString(), true };
        yield return new object[] { "7ecc63e4-57e1-47be-96d7-8e2a0833b4b6", false };
        yield return new object[] { "979b54c0-d720-4f94-929d-c87ce08ef5ab", false };
    }
    
    [Theory, MemberData(nameof(IsNotEmptyTestValues))]
    public void IsNotEmpty_ForValidGuids_ShouldReturnExpectedValue(string value, bool expectedResult)
    {
        // Arrange
        var guid = Guid.Parse(value);
        
        // Act & Assert
        Assert.Equal(expectedResult, guid.IsNotEmpty());
    }

    public static IEnumerable<object[]> IsNotEmptyTestValues()
    {
        yield return new object[] { Guid.Empty.ToString(), false };
        yield return new object[] { "7ecc63e4-57e1-47be-96d7-8e2a0833b4b6", true };
        yield return new object[] { "ae0e28b4-fa5f-4f86-bf57-d89c783bcb3d", true };
    }
}