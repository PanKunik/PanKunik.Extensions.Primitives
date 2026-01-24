namespace PanKunik.Extensions.Primitives;

public static class BoolExtensions
{
    extension(bool? value)
    {
        public bool IsNull()
            => value is null;

        public bool IsNotNull()
            => !value.IsNull();
    }
}