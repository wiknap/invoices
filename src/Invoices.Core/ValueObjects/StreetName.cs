using Invoices.Core.Exceptions;

namespace Invoices.Core.ValueObjects;

public sealed record StreetName
{
    private const int MaxLength = 100;

    public StreetName(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || value.Length > MaxLength)
            throw new InvalidCompanyNameException(value);

        Value = value;
    }

    public string Value { get; }

    public static implicit operator StreetName(string value) => new(value);

    public static implicit operator string(StreetName value) => value.Value;

    public override string ToString() => Value;
}
