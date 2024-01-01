using System.Text.Json;
using System.Text.Json.Serialization;

namespace KartaViewSharp.Common.Converters;

internal class StringAsNullableIntJsonConverter : JsonConverter<int?>
{
    public override int? Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        var value = reader.GetString();
        if (value == null)
        {
            return null;
        }

        return int.Parse(value);
    }

    public override void Write(
        Utf8JsonWriter writer,
        int? value,
        JsonSerializerOptions options) =>
        writer.WriteStringValue(value.ToString());
}