using Invoices.Application.Interfaces;

using Wiknap.CQRS;

namespace Invoices.Application.Queries.Handlers;

internal sealed class GenerateInvoiceQueryHandler : IQueryHandler<GenerateInvoiceQuery, Stream>
{
    private readonly IInvoiceGenerator invoiceGenerator;

    public GenerateInvoiceQueryHandler(IInvoiceGenerator invoiceGenerator)
    {
        this.invoiceGenerator = invoiceGenerator;
    }

    public Task<Stream> HandleAsync(GenerateInvoiceQuery command, CancellationToken cancellationToken = default)
        => invoiceGenerator.GenerateInvoiceAsPdfStreamAsync(command.InvoiceData);
}
