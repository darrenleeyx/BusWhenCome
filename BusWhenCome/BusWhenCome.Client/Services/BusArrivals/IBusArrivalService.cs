
public interface IBusArrivalService
{
    Task<BusArrivalResponse> GetBusArrivalsAsync(string id);
}