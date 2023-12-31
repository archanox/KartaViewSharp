using System.Text.Json;
using System.Text.Json.Serialization;

namespace KartaViewSharp.Common.Converters;

public class StringAsNullableDoubleJsonConverter : JsonConverter<double?>
{
    public override double? Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        var value = reader.GetString();
        if (value == null)
        {
            return null;
        }

        return double.Parse(value);
    }

    public override void Write(
        Utf8JsonWriter writer,
        double? value,
        JsonSerializerOptions options) =>
        writer.WriteStringValue(value.ToString());
}