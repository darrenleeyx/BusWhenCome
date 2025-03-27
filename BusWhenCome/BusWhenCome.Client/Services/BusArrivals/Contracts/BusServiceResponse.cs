using System.Text.Json.Serialization;

public class BusServiceResponse
{
    [JsonPropertyName("no")]
    public string Number { get; set; } = null!;

    [JsonPropertyName("operator")]
    public string Operator { get; set; } = null!;

    [JsonPropertyName("next")]
    public BusTimingResponse? Next { get; set; }

    [JsonPropertyName("subsequent")]
    public BusTimingResponse? Subsequent { get; set; }

    [JsonPropertyName("next2")]
    public BusTimingResponse? Next2 { get; set; }

    [JsonPropertyName("next3")]
    public BusTimingResponse? Next3 { get; set; }
}
