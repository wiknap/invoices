using Invoices.Core;

namespace Invoices.Application.Interfaces;

public interface IInvoiceGenerator
{
    Task<Stream> GenerateInvoiceAsPdfStreamAsync(InvoiceData data);
}