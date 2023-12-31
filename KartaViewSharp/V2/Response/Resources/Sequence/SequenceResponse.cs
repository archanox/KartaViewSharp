using System.Text.Json.Serialization;
using KartaViewSharp.Common.Response;

namespace KartaViewSharp.V2.Response.Resources.Sequence;

[JsonSerializable(typeof(SequenceResponse), GenerationMode = JsonSourceGenerationMode.Metadata)]
public sealed class SequenceResponse
{
    [JsonPropertyName("status")]
    public ResponseStatus Status { get; set; }

    [JsonPropertyName("result")]
    public SequenceResult Result { get; set; }
}