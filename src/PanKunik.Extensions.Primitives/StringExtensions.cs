namespace PanKunik.Extensions.Primitives;

public static class StringExtensions
{
    extension(string? value)
    {
        public bool IsNull()
            => value is null;

        public bool IsNotNull()
            => !value.IsNull();

        public bool IsEmpty()
            => string.IsNullOrEmpty(value);

        public bool IsNotEmpty()
            => !value.IsEmpty();

        public bool IsNullOrWhiteSpace()
            => string.IsNullOrWhiteSpace(value);

        public bool IsNotNullOrWhiteSpace()
            => !value.IsNullOrWhiteSpace();
    }
}