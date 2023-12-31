using System.Text.Json;
using System.Text.Json.Serialization;

namespace KartaViewSharp.Common.Converters;

public class StringAsIntJsonConverter : JsonConverter<int>
{
    public override int Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
	    if (reader.TokenType == JsonTokenType.Number)
	    {
		    return reader.GetInt32();
	    }

	    var value = reader.GetString() ?? "0";
        return int.Parse(value);
    }

    public override void Write(
        Utf8JsonWriter writer,
        int value,
        JsonSerializerOptions options) =>
        writer.WriteStringValue(value.ToString());
}