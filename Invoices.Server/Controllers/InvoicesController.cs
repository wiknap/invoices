using System.Threading.Tasks;
using Invoices.Application.Requests;
using Invoices.Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Invoices.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class InvoicesController : ControllerBase
{
    private readonly IMediator mediator;

    public InvoicesController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetInvoiceAsync()
    {
        var invoiceStream = await mediator.Send(new GenerateInvoiceRequest(
            new InvoiceData(
                new CompanyInfo("Name", "Street", "StreetNumber", "ApartmentNumber", "City", "PostalCode"),
                new CompanyInfo("Name", "Street", "StreetNumber", "ApartmentNumber", "City", "PostalCode"))));
        return File(invoiceStream, "application/pdf");
    }
}