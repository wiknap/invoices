using Invoices.Core.Exceptions;

namespace Invoices.Core.ValueObjects;

public sealed record CompanyName
{
    private const int MaxLength = 100;

    public CompanyName(string value)
    {
        if (string.IsNullOrEmpty(value) || value.Length > MaxLength)
            throw new InvalidCompanyNameException(value);

        Value = value;
    }

    public string Value { get; }

    public static implicit operator CompanyName(string value) => new(value);

    public static implicit operator string(CompanyName value) => value.Value;

    public override string ToString() => Value;
}
