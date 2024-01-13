namespace Invoices.Core.Exceptions;

public abstract class InvoicesException : Exception
{
    protected InvoicesException(string message) : base(message)
    {}
}
