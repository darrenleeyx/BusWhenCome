using BusWhenCome.Client.Services.BusStops.Contracts;
using System.Net.Http.Json;

namespace BusWhenCome.Client.Services.BusStops;

public class BusStopService : IBusStopService
{
    private readonly HttpClient _httpClient;

    public BusStopService(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient(nameof(BusWhenCome));
    }

    public async Task<BusStopResponse?> GetBusStop(string id)
    {
        return await _httpClient.GetFromJsonAsync<BusStopResponse>($"/bus-stops/?id={id}");
    }
}
