var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Traversal>("traversal");


builder.Build().Run();
