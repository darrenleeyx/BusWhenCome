namespace BusWhenCome.Data.BusStops;

public interface IBusStopRepository
{
    BusStop Get(string id);
}