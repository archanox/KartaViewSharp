using System.Text.Json.Serialization;
using KartaViewSharp.V2.ResponseData.Shared;

namespace KartaViewSharp.V2.ResponseData.Resources.Sequence;

public sealed class SequenceResponse
{
    [JsonPropertyName("status")]
    public ResponseStatus Status { get; set; }

    [JsonPropertyName("result")]
    public SequenceResult Result { get; set; }
}