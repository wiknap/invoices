using Invoices.Application.Interfaces;
using Invoices.Infrastructure.Invoices;
using Microsoft.Extensions.DependencyInjection;

namespace Invoices.Infrastructure;

public static class Extensions
{
    public static IServiceCollection AddInvoicesInfrastructure(this IServiceCollection services)
    {
        return services
            .AddHostedService<QuestPdfInitializer>()
            .AddScoped<IInvoiceGenerator, InvoiceGenerator>();
    }
}
