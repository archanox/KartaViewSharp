using System.Text.Json.Serialization;
using KartaViewSharp.Common.Response;

namespace KartaViewSharp.V2.Response.Resources.Photo;

public sealed class PhotoResponse
{
    [JsonPropertyName("status")]
    public ResponseStatus Status { get; set; }

    [JsonPropertyName("result")]
    public PhotoResult Result { get; set; }
}