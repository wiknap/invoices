var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Invoices_Server>("invoices.server");

builder.Build().Run();
