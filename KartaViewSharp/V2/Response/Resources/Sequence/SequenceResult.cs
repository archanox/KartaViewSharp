using KartaViewSharp.Common.Converters;
using System.Text.Json;
using System.Text.Json.Serialization;

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

[JsonSerializable(typeof(Dictionary<string, SequenceData>), GenerationMode = JsonSourceGenerationMode.Metadata)]
public partial class SequenceDataDictionaryContext : JsonSerializerContext
{
}

public class ObjectAsArrayJsonConverter<T, T2> : JsonConverter<T[]> where T2 : JsonSerializerContext, new()
{
	public override T[] Read(
		ref Utf8JsonReader reader,
		Type typeToConvert,
		JsonSerializerOptions options)
	{
		switch (reader.TokenType)
		{
			case JsonTokenType.StartObject:
			{
				var work = JsonSerializer.Deserialize<Dictionary<string, T>>(ref reader, new JsonSerializerOptions
				{
					ReferenceHandler = ReferenceHandler.Preserve,
					TypeInfoResolver = new T2()
				})?.Values.ToArray() ?? throw new JsonException();
				var work1 = work.Distinct().ToArray();
				return work1;
			}
			case JsonTokenType.StartArray:
				return JsonSerializer.Deserialize<T[]>(ref reader, options) ?? throw new JsonException();
			default:
				throw new JsonException();
		}
	}

	public override void Write(
		Utf8JsonWriter writer,
		T[] value,
		JsonSerializerOptions options) =>
		writer.WriteRawValue(JsonSerializer.Serialize(value, options));
}