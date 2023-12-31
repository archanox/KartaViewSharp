using System.Text.Json.Serialization;
using KartaViewSharp.Common.Converters;

namespace KartaViewSharp.V2.Response.Resources.Sequence;

[JsonSerializable(typeof(SequenceResult), GenerationMode = JsonSourceGenerationMode.Metadata)]
public sealed class SequenceResult
{
    [JsonPropertyName("data")]
	[JsonConverter(typeof(ObjectAsArrayJsonConverter<SequenceData, SequenceDataDictionaryContext>))]
	public SequenceData[] Data { get; set; }

    /// <summary>
    /// In case there is more data to retrieve (records count &lt;= itemsPerPage), the property will return true.
    /// </summary>
    [JsonPropertyName("hasMoreData")]
    public bool HasMoreData { get; set; }
}