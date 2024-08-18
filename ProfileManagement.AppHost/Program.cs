var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.PM_Server>("pm-server");

builder.Build().Run();
