using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace KartaViewSharp.V2.ResponseData.Converters;

public class StringAsDoubleJsonConverter : JsonConverter<double>
{
    public override double Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        return double.Parse(reader.GetString()!);
    }

    public override void Write(
        Utf8JsonWriter writer,
        double value,
        JsonSerializerOptions options) =>
        writer.WriteStringValue(value.ToString(CultureInfo.InvariantCulture));
}