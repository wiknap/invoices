using Invoices.Application.Interfaces;
using MediatR;

namespace Invoices.Application.Requests;

public class GenerateInvoiceRequestHandler : IRequestHandler<GenerateInvoiceRequest, Stream>
{
    private readonly IInvoiceGenerator invoiceGenerator;

    public GenerateInvoiceRequestHandler(IInvoiceGenerator invoiceGenerator)
    {
        this.invoiceGenerator = invoiceGenerator;
    }

    public async Task<Stream> Handle(GenerateInvoiceRequest request, CancellationToken cancellationToken)
        => await invoiceGenerator.GenerateInvoiceAsPdfStreamAsync(request.InvoiceData);
}