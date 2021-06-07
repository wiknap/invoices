using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Invoices.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoicesController : ControllerBase
    {
        [HttpGet]
        public async Task<string> Get()
        {
            return await Task.FromResult("Hello from server");
        }
    }
}
