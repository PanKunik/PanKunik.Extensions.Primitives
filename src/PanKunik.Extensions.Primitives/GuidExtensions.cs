namespace PanKunik.Extensions.Primitives;

public static class GuidExtensions
{
    extension(Guid guid)
    {
        public bool IsEmpty()
            => guid == Guid.Empty;

        public bool IsNotEmpty()
            => !guid.IsEmpty();
    }
}