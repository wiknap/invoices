using Invoices.Core.Exceptions;

namespace Invoices.Core.ValueObjects;

public sealed record ApartmentNumber
{
    private const int MaxLength = 10;

    public ApartmentNumber(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || value.Length > MaxLength)
            throw new InvalidCompanyNameException(value);

        Value = value;
    }

    public string Value { get; }

    public static implicit operator ApartmentNumber(string value) => new(value);

    public static implicit operator string(ApartmentNumber value) => value.Value;

    public override string ToString() => Value;
}
