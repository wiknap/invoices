using Invoices.Application.Interfaces;
using Invoices.Core;
using Invoices.Infrastructure.Invoices.Documents;
using QuestPDF.Fluent;

namespace Invoices.Infrastructure.Invoices;

public class InvoiceGenerator : IInvoiceGenerator
{
    public async Task<Stream> GenerateInvoiceAsPdfStreamAsync(InvoiceData data)
    {
        var document = new InvoiceDocument(data);
        await using var memoryStream = new MemoryStream();
        document.GeneratePdf(memoryStream);
        return new MemoryStream(memoryStream.ToArray());
    }
}
