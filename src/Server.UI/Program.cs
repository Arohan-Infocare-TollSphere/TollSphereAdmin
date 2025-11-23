using Arohan.TollSphere.Application;
using Arohan.TollSphere.Infrastructure;
using Arohan.TollSphere.Infrastructure.Extensions;
using Arohan.TollSphere.Server.UI;


var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();
builder.RegisterSerilog();
builder.WebHost.UseStaticWebAssets();

builder.Services
    .AddApplication()
    .AddInfrastructure(builder.Configuration)
    .AddServerUI(builder.Configuration);
var app = builder.Build();

app.MapDefaultEndpoints();

app.ConfigureServer(builder.Configuration);

await app.InitializeDatabaseAsync().ConfigureAwait(false);
app.InitializeCacheFactory();
await app.RunAsync().ConfigureAwait(false);
