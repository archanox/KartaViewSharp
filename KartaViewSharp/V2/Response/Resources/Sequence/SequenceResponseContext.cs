using System.Text.Json.Serialization;

namespace KartaViewSharp.V2.Response.Resources.Sequence;

[JsonSerializable(typeof(SequenceResponse), GenerationMode = JsonSourceGenerationMode.Metadata)]
public partial class SequenceResponseContext : JsonSerializerContext
{
}