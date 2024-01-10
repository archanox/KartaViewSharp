using System.Text.Json.Serialization;

namespace KartaViewSharp.V2.Response.Resources.Sequence;

[JsonSerializable(typeof(SequenceDetailsResponse), GenerationMode = JsonSourceGenerationMode.Metadata)]
public partial class SequenceDetailsResponseContext : JsonSerializerContext
{
}