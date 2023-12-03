namespace Invoices.Core.ValueObjects;

public sealed record FirstName
{
    public string Value { get;  }

    private FirstName(string value)
    {
        Value = value;
    }

    public static FirstName Create(string value) => new(value);

    public static implicit operator FirstName(string value) => Create(value);

    public static implicit operator string(FirstName value) => value.Value;

    public override string ToString() => Value;
}
