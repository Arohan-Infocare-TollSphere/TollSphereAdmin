var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Protos>("protos");

builder.AddProject<Projects.Server_UI>("server-ui");

builder.AddProject<Projects.Server_API>("server-api");

builder.Build().Run();
