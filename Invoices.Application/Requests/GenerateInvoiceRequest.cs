using Invoices.Core;
using MediatR;

namespace Invoices.Application.Requests;

public record GenerateInvoiceRequest(InvoiceData InvoiceData) : IRequest<Stream>;