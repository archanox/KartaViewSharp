using System.Text.Json.Serialization;
using KartaViewSharp.V2.ResponseData.Resources.Sequence;

namespace KartaViewSharp.V2.ResponseData;

[JsonSerializable(typeof(SequenceResponse), GenerationMode = JsonSourceGenerationMode.Metadata)]
public partial class SequenceResponseContext : JsonSerializerContext
{
}