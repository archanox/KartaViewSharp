using System.Text.Json.Serialization;

namespace KartaViewSharp.V2.ResponseData;

public class SequenceResponse
{
    [JsonPropertyName("status")]
    public ResponseStatus Status { get; set; }

    [JsonPropertyName("result")]
    public SequenceResult Result { get; set; }
}

[JsonSerializable(typeof(SequenceResponse), GenerationMode = JsonSourceGenerationMode.Metadata)]
public partial class MyJsonContext : JsonSerializerContext
{
}