using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Invoices.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddInvoices(this IServiceCollection services)
    {
        return services.AddMediatR(Assembly.GetExecutingAssembly());
    }
}