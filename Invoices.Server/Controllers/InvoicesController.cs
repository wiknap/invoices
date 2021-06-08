using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PuppeteerSharp;

namespace Invoices.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoicesController : ControllerBase
    {
        private readonly PuppeteerConfig _puppeteerConfig;

        public InvoicesController(PuppeteerConfig puppeteerConfig)
        {
            _puppeteerConfig = puppeteerConfig;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            await using var browser = await Puppeteer.LaunchAsync(
                new LaunchOptions
                {
                    Headless = true,
                    ExecutablePath = _puppeteerConfig.BrowserExecutablePath
                });
            await using var page = await browser.NewPageAsync();
            await page.GoToAsync("http://www.google.com");

            return new FileStreamResult(await page.ScreenshotStreamAsync(), "image/png")
            {
                FileDownloadName = "image.png"
            };
        }
    }
}
