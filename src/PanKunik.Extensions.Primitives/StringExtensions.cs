namespace PanKunik.Extensions.Primitives;

public static class StringExtensions
{
    public static bool IsNull(this string? value)
        => value is null;
    
    public static bool IsNotNull(this string? value)
        => value is not null;
    
    public static bool IsEmpty(this string? value)
        => string.IsNullOrEmpty(value);
    
    public static bool IsNotEmpty(this string? value)
        => !string.IsNullOrEmpty(value);
    
    public static bool IsNullOrWhiteSpace(this string? value)
        => string.IsNullOrWhiteSpace(value);
    
    public static bool IsNotNullOrWhiteSpace(this string? value)
        => !string.IsNullOrWhiteSpace(value);
}