using System.Text.Json.Serialization;
using KartaViewSharp.V2.ResponseData.Shared;

namespace KartaViewSharp.V2.ResponseData.Resources.Photo;

public sealed class PhotoResponse
{
    [JsonPropertyName("status")]
    public ResponseStatus Status { get; set; }

    [JsonPropertyName("result")]
    public PhotoResult Result { get; set; }
}