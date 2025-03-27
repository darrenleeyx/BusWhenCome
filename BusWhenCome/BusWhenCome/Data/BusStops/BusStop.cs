using System.Text.Json.Serialization;

namespace BusWhenCome.Data.BusStops;

public record BusStop
{
    [JsonPropertyName("bus_stop_id")]
    public string BusStopId { get; init; } = null!;

    [JsonPropertyName("description")]
    public string Description { get; init; } = null!;

    [JsonPropertyName("road")]
    public string Road { get; init; } = null!;

    [JsonPropertyName("lat")]
    public double Lat { get; init; }

    [JsonPropertyName("lng")]
    public double Lng { get; init; }
}