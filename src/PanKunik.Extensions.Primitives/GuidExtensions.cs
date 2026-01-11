namespace PanKunik.Extensions.Primitives;

public static class GuidExtensions
{
    public static bool IsEmpty(this Guid guid)
        => guid == Guid.Empty;

    public static bool IsNotEmpty(this Guid guid)
        => !IsEmpty(guid);
}