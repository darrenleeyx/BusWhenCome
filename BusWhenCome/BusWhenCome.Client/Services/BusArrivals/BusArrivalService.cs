using System.Text.Json;

public class BusArrivalService : IBusArrivalService
{

    private readonly HttpClient _httpClient;

    public BusArrivalService(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient(nameof(BusWhenCome));
    }

    public async Task<BusArrivalResponse> GetBusArrivalsAsync(string id)
    {
        var json = await _httpClient.GetStringAsync($"/bus-arrivals/?id={id}");

        return JsonSerializer.Deserialize<BusArrivalResponse>(json) ?? new BusArrivalResponse();
    }
}