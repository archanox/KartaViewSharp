using System.Text.Json;
using System.Text.Json.Serialization;

namespace KartaViewSharp.Common.Converters;

internal class StringAsNullableLongJsonConverter : JsonConverter<long?>
{
    public override long? Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        var value = reader.GetString();
        if (value == null)
        {
            return null;
        }

        return long.Parse(value);
    }

    public override void Write(
        Utf8JsonWriter writer,
        long? value,
        JsonSerializerOptions options) =>
        writer.WriteStringValue(value.ToString());
}