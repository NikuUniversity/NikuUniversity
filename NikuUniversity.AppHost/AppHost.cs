var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedis("cache");

var apiService = builder.AddProject<Projects.NikuUniversity_ApiService>("apiservice")
    .WithHttpHealthCheck("/health");

builder.AddProject<Projects.NikuUniversity_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithHttpHealthCheck("/health")
    .WithReference(cache)
    .WaitFor(cache)
    .WithReference(apiService)
    .WaitFor(apiService);

builder.AddProject<Projects.NikuUniversity_App>("nikuuniversity-app");

builder.AddProject<Projects.NikuUniversity_Worker>("nikuuniversity-worker");

builder.Build().Run();
