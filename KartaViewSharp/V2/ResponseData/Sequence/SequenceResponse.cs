using System.Text.Json.Serialization;
using KartaViewSharp.V2.ResponseData.Sequence;
using KartaViewSharp.V2.ResponseData.Shared;

namespace KartaViewSharp.V2.ResponseData;

public sealed class SequenceResponse
{
    [JsonPropertyName("status")]
    public ResponseStatus Status { get; set; }

    [JsonPropertyName("result")]
    public SequenceResult Result { get; set; }
}

[JsonSerializable(typeof(SequenceResponse), GenerationMode = JsonSourceGenerationMode.Metadata)]
public partial class SequenceResponseContext : JsonSerializerContext
{
}