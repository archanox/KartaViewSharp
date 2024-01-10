using System.Text.Json.Serialization;
using KartaViewSharp.Common.Converters;

namespace KartaViewSharp.V2.Response.Resources.Sequence;

[JsonSerializable(typeof(SequenceDetailsResult), GenerationMode = JsonSourceGenerationMode.Metadata)]
public sealed class SequenceDetailsResult
{
    [JsonPropertyName("data")]
	public SequenceData Data { get; set; }
}