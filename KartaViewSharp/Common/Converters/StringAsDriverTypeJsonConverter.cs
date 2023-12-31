using System.Text.Json;
using System.Text.Json.Serialization;
using KartaViewSharp.V1.Response.Resources.Authentication;

namespace KartaViewSharp.Common.Converters;

public class StringAsDriverTypeJsonConverter : JsonConverter<DriverType>
{
    public override DriverType Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options) =>
        reader.GetString() switch
        {
            "DEDICATED" => DriverType.Dedicated,
            "BYOD" => DriverType.Byod,
            "BAU" => DriverType.Bau,
            _ => throw new ArgumentOutOfRangeException()
        };

    public override void Write(
        Utf8JsonWriter writer,
        DriverType value,
        JsonSerializerOptions options)
    {
        writer.WriteStringValue(value switch
        {
            DriverType.Dedicated => "DEDICATED",
            DriverType.Byod => "BYOD",
            DriverType.Bau => "BAU",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, null)
        });
    }
}