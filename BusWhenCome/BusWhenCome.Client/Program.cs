using BusWhenCome.Client.Services.BusStops;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddHttpClient(nameof(BusWhenCome), client =>
{
    client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
});

builder.Services.AddScoped<IBusArrivalService, BusArrivalService>();
builder.Services.AddScoped<IBusStopService, BusStopService>();

await builder.Build().RunAsync();
