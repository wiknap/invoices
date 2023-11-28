using Microsoft.Extensions.Hosting;

using QuestPDF.Infrastructure;

namespace Invoices.Infrastructure.Invoices;

internal sealed class QuestPdfInitializer : BackgroundService
{
    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        QuestPDF.Settings.License = LicenseType.Community;
        return Task.CompletedTask;
    }
}
