namespace Tracker.Domain.Entities.Products;

public record Sku
{
    private const int DefaultLength = 15;
    private Sku(string value) => Value = value;

    public string Value { get; init; }

    //Factory Method
    public static Sku? Create(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            return null;
        }

        return value.Length != DefaultLength ? null : new Sku(value);
    }
}