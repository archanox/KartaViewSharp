using System.Text.Json;
using System.Text.Json.Serialization;
using KartaViewSharp.V2.Enums;

namespace KartaViewSharp.Common.Converters;

public class StringAsVisibilityJsonConverter : JsonConverter<Visibility>
{
    public override Visibility Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options) =>
        reader.GetString() switch
        {
            "private" => Visibility.Private,
            "public" => Visibility.Public,
            _ => throw new ArgumentOutOfRangeException()
        };

    public override void Write(
        Utf8JsonWriter writer,
        Visibility value,
        JsonSerializerOptions options)
    {
        writer.WriteStringValue(value switch
        {
            Visibility.Private => "private",
            Visibility.Public => "public",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, null)
        });
    }
}