using System.Text.Json;
using System.Text.Json.Serialization;

namespace KartaViewSharp.Common.Converters;

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
                    return JsonSerializer.Deserialize<Dictionary<string, T>>(ref reader, new JsonSerializerOptions
                    {
                        ReferenceHandler = ReferenceHandler.Preserve,
                        TypeInfoResolver = new T2()
                    })?.Values.Distinct().ToArray() ?? throw new JsonException();
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