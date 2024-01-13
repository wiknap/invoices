using Invoices.Core.Exceptions;

namespace Invoices.Core.ValueObjects;

public sealed record City
{
    private const int MaxLength = 50;

    public City(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || value.Length > MaxLength)
            throw new InvalidCompanyNameException(value);

        Value = value;
    }

    public string Value { get; }

    public static implicit operator City(string value) => new(value);

    public static implicit operator string(City value) => value.Value;

    public override string ToString() => Value;
}
