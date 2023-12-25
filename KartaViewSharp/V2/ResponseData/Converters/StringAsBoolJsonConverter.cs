using System.Text.Json;
using System.Text.Json.Serialization;

namespace KartaViewSharp.V2.ResponseData.Converters;

public class StringAsBoolJsonConverter : JsonConverter<bool>
{
    public override bool Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        var value = reader.GetString();
        return value switch
        {
	        null => false,
	        "1" => true,
	        "0" => false,
	        _ => bool.Parse(value)
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        bool value,
        JsonSerializerOptions options) =>
        writer.WriteStringValue(value.ToString());
}