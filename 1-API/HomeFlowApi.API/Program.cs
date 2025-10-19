using HomeFlowApi.API.Extensions;
using HomeFlowApi.Infrastructure.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddPresentation();

var app = builder.Build();

app.UsePresentation();

await app.RunAsync();
