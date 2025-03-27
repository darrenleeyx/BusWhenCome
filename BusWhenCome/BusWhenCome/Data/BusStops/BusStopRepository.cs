using System.Text.Json;

namespace BusWhenCome.Data.BusStops;

public class BusStopRepository : IBusStopRepository
{
    private readonly List<BusStop> _busStops;

    public BusStopRepository(ILogger<BusStopRepository> logger, IWebHostEnvironment environment)
    {
        var path = Path.Combine(environment.ContentRootPath, "Data", "BusStops", "bus-stops.json");
        var json = File.ReadAllText(path);
        _busStops = JsonSerializer.Deserialize<List<BusStop>>(json) ?? new List<BusStop>();
    }

    public BusStop Get(string id)
    {
        return _busStops.FirstOrDefault(x => x.BusStopId == id) ?? new BusStop();
    }
}
