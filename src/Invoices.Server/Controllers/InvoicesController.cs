using Invoices.Application.Queries;
using Invoices.Core;

using Microsoft.AspNetCore.Mvc;

using Wiknap.CQRS;

namespace Invoices.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class InvoicesController : ControllerBase
{
    private readonly IQueryDispatcher queryDispatcher;

    public InvoicesController(IQueryDispatcher queryDispatcher)
    {
        this.queryDispatcher = queryDispatcher;
    }

    [HttpGet]
    public async Task<IActionResult> GetInvoiceAsync()
    {
        var invoiceStream = await queryDispatcher.DispatchAsync<GenerateInvoiceQuery, Stream>(new GenerateInvoiceQuery(
            new InvoiceData(
                new CompanyInfo("Name", "Street", "StreetNumber", "ApartmentNumber", "City", "PostalCode"),
                new CompanyInfo("Name", "Street", "StreetNumber", "ApartmentNumber", "City", "PostalCode"))));
        return File(invoiceStream, "application/pdf");
    }
}
