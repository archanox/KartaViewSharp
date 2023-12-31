using System.Text.Json;
using System.Text.Json.Serialization;

namespace KartaViewSharp.Common.Converters;

public class JsonStringAsObjectJsonConverter<T> : JsonConverter<T>
{
    public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        switch (reader.TokenType)
        {
            case JsonTokenType.Null:
                return default;
            case JsonTokenType.StartObject:
                {
                    return JsonSerializer.Deserialize<T>(ref reader, options) ?? throw new JsonException();
                }
            case JsonTokenType.String when string.IsNullOrWhiteSpace(reader.GetString()):
                return default;
            case JsonTokenType.String when !string.IsNullOrWhiteSpace(reader.GetString()):
                var input = reader.GetString();
                return JsonSerializer.Deserialize<T>(input, options) ?? throw new JsonException();
            default:
                throw new JsonException();
        }
    }

    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
    {
        writer.WriteRawValue(JsonSerializer.Serialize(value, options));
    }
}