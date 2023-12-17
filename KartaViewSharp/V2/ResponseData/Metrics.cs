using System.Text.Json.Serialization;

namespace KartaViewSharp.V2.ResponseData;

public class Metrics
{
    [JsonPropertyName("totalDistance")]
    public string TotalDistance { get; set; }

    [JsonPropertyName("photoCount")]
    public string PhotoCount { get; set; }

    [JsonPropertyName("uniqueDistance")]
    public string UniqueDistance { get; set; }

    [JsonPropertyName("zeroCoverage")]
    public string ZeroCoverage { get; set; }
}