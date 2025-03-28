using BusWhenCome.Client.Services.BusStops;
using BusWhenCome.Components;
using BusWhenCome.Data.BusStops;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddScoped<IBusArrivalService, BusArrivalService>();
builder.Services.AddScoped<IBusStopService, BusStopService>();
builder.Services.AddSingleton<IBusStopRepository, BusStopRepository>();

builder.Services.AddHttpClient(nameof(BusWhenCome), client =>
{
    client.BaseAddress = new Uri("https://localhost:7289");
});

builder.Services.AddReverseProxy()
    .LoadFromConfig(builder.Configuration.GetSection("ReverseProxy"));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(BusWhenCome.Client._Imports).Assembly);

app.MapReverseProxy();

app.MapGet("/bus-stops", async ([FromQuery] string id, [FromServices] IBusStopRepository repository) =>
{
    var busStop = repository.Get(id);
    return Results.Ok(busStop);
});

app.Run();
