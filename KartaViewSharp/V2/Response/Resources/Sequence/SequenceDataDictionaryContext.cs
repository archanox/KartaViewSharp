using System.Text.Json.Serialization;

namespace KartaViewSharp.V2.Response.Resources.Sequence;

[JsonSerializable(typeof(Dictionary<string, SequenceData>), GenerationMode = JsonSourceGenerationMode.Metadata)]
public partial class SequenceDataDictionaryContext : JsonSerializerContext
{
}