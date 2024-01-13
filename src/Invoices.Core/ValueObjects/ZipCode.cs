using Invoices.Core.Exceptions;

namespace Invoices.Core.ValueObjects;

public sealed record ZipCode
{
    private const int MaxLength = 10;

    public ZipCode(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || value.Length > MaxLength)
            throw new InvalidCompanyNameException(value);

        Value = value;
    }

    public string Value { get; }

    public static implicit operator ZipCode(string value) => new(value);

    public static implicit operator string(ZipCode value) => value.Value;

    public override string ToString() => Value;
}
