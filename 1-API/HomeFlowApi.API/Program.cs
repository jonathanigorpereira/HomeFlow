using HomeFlowApi.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPresentation();

var app = builder.Build();

app.UsePresentation();

await app.RunAsync();
