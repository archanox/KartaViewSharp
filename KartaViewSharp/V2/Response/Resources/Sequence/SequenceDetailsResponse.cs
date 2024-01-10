using System.Text.Json.Serialization;
using KartaViewSharp.Common.Response;

namespace KartaViewSharp.V2.Response.Resources.Sequence;

[JsonSerializable(typeof(SequenceDetailsResponse), GenerationMode = JsonSourceGenerationMode.Metadata)]
public sealed class SequenceDetailsResponse
{
    [JsonPropertyName("status")]
    public ResponseStatus Status { get; set; }

    [JsonPropertyName("result")]
    public SequenceDetailsResult Result { get; set; }
}