using Invoices.Core.ValueObjects;

namespace Invoices.Core.Exceptions;

public sealed class InvalidCompanyNameException : InvalidValueException<CompanyName>
{
    public InvalidCompanyNameException(string value) : base(value)
    {
    }
}
