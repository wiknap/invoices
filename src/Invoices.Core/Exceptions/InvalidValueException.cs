namespace Invoices.Core.Exceptions;

public abstract class InvalidValueException<T> : InvoicesException
{
    protected InvalidValueException(string value) : base($"{value} is invalid {typeof(T).Name} value")
    {
        Value = value;
    }

    public string Value { get; }
}
