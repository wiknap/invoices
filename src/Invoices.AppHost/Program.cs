var builder = DistributedApplication.CreateBuilder(args);

//var server = builder.AddProject<ProjectResourceBuilderExtensions>("apiservice");

builder.Build().Run();
