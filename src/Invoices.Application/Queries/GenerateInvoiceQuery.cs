using Invoices.Core;

using Wiknap.CQRS;

namespace Invoices.Application.Queries;

public sealed record GenerateInvoiceQuery(InvoiceData InvoiceData) : IQuery<Stream>;
