using System.Text.Json.Serialization;

namespace KartaViewSharp.V2.ResponseData.Resources.Photo;

public sealed class QualityDetail
{
    [JsonPropertyName("label")]
    public int Label { get; set; }

    [JsonPropertyName("confidence")]
    public float Confidence { get; set; }

    [JsonPropertyName("presence_level")]
    public int PresenceLevel { get; set; }
}