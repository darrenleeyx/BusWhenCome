using System.Text.Json.Serialization;

public class BusTimingResponse
{
    [JsonPropertyName("time")]
    public DateTime Time { get; set; }

    [JsonPropertyName("duration_ms")]
    public long DurationMs { get; set; }

    [JsonPropertyName("lat")]
    public double Latitude { get; set; }

    [JsonPropertyName("lng")]
    public double Longitude { get; set; }

    [JsonPropertyName("load")]
    public string Load { get; set; } = null!;

    [JsonPropertyName("feature")]
    public string Feature { get; set; } = null!;

    [JsonPropertyName("type")]
    public string Type { get; set; } = null!;

    [JsonPropertyName("visit_number")]
    public int VisitNumber { get; set; }

    [JsonPropertyName("origin_code")]
    public string OriginCode { get; set; } = null!;

    [JsonPropertyName("destination_code")]
    public string DestinationCode { get; set; } = null!;
}