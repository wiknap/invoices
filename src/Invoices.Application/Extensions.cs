using Microsoft.Extensions.DependencyInjection;

using Wiknap.CQRS.DependencyInjection;

namespace Invoices.Application;

public static class Extensions
{
    public static IServiceCollection AddInvoices(this IServiceCollection services)
    {
        return services.AddCqrs();
    }
}
