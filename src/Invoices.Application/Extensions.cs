using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Invoices.Application;

public static class Extensions
{
    public static IServiceCollection AddInvoices(this IServiceCollection services)
    {
        return services.AddMediatR(configuration => configuration.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
    }
}
