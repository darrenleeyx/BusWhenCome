using System.Text.Json.Serialization;

public class BusArrivalResponse
{
    [JsonPropertyName("services")]
    public List<BusServiceResponse> Services { get; set; } = new();
}
