using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace KartaViewSharp.Common.Converters;

public class StringAsDateTimeV1JsonConverter : JsonConverter<DateTime>
{
    public override DateTime Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        //"2023-12-26  (06:37)",
        return DateTime.ParseExact(reader.GetString(), "yyyy-MM-dd  (hh:mm)", CultureInfo.InvariantCulture); // 2023-04-06 04:16:15
    }

    public override void Write(
        Utf8JsonWriter writer,
        DateTime value,
        JsonSerializerOptions options) =>
        writer.WriteStringValue(value!.ToString("yyyy-MM-dd  (hh:mm)", CultureInfo.InvariantCulture));
}