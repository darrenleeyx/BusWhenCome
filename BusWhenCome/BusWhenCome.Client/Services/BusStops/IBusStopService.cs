using BusWhenCome.Client.Services.BusStops.Contracts;

namespace BusWhenCome.Client.Services.BusStops;

public interface IBusStopService
{
    Task<BusStopResponse?> GetBusStop(string id);
}
