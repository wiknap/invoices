using Invoices.Application.Interfaces;
using Invoices.Core;
using Invoices.Infrastructure.Invoices.Documents;
using QuestPDF.Fluent;

namespace Invoices.Infrastructure.Invoices;

public class InvoiceGenerator : IInvoiceGenerator
{
    public Task<Stream> GenerateInvoiceAsPdfStreamAsync(InvoiceData data)
    {
        var document = new InvoiceDocument(data);
        var memoryStream = new MemoryStream();
        document.GeneratePdf(memoryStream);
        memoryStream.Position = 0;
        return Task.FromResult<Stream>(memoryStream);
    }
}