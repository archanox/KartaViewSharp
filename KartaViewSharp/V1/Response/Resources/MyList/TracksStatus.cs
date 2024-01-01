using System.Text.Json.Serialization;

namespace KartaViewSharp.V1.Response.Resources.MyList;

public sealed class TracksStatus
{
    [JsonPropertyName("uploading")]
    public int Uploading { get; set; }

    [JsonPropertyName("processing")]
    public int Processing { get; set; }
}