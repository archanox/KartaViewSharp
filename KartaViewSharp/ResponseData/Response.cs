using System.Text.Json.Serialization;

namespace KartaViewSharp.ResponseData;

public class Response
{
    [JsonPropertyName("status")]
    public Status Status { get; set; }

    [JsonPropertyName("result")]
    public Result Result { get; set; }
}