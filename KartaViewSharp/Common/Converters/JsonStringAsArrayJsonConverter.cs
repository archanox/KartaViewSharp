using System.Text.Json;
using System.Text.Json.Serialization;

namespace KartaViewSharp.Common.Converters;

public class JsonStringAsArrayJsonConverter<T> : JsonConverter<T[]>
{
    public override T[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        switch (reader.TokenType)
        {
            case JsonTokenType.Null:
                return default;
            case JsonTokenType.StartArray:
                return JsonSerializer.Deserialize<T[]>(ref reader, options) ?? throw new JsonException();
            case JsonTokenType.String when string.IsNullOrWhiteSpace(reader.GetString()):
                return default;
            case JsonTokenType.String when !string.IsNullOrWhiteSpace(reader.GetString()):
                return JsonSerializer.Deserialize<T[]>(reader.GetString(), options) ?? throw new JsonException();
            default:
                {
                    throw new JsonException($"Unexpected token type {reader.TokenType}");
                }
        }
    }

    public override void Write(Utf8JsonWriter writer, T[] value, JsonSerializerOptions options)
    {
        writer.WriteRawValue(JsonSerializer.Serialize(value, options));
    }
}