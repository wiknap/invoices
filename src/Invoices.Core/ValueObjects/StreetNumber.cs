using Invoices.Core.Exceptions;

namespace Invoices.Core.ValueObjects;

public sealed record StreetNumber
{
    private const int MaxLength = 10;

    public StreetNumber(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || value.Length > MaxLength)
            throw new InvalidCompanyNameException(value);

        Value = value;
    }

    public string Value { get; }

    public static implicit operator StreetNumber(string value) => new(value);

    public static implicit operator string(StreetNumber value) => value.Value;

    public override string ToString() => Value;
}
