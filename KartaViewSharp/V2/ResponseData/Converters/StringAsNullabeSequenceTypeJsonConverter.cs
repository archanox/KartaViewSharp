using System.Text.Json;
using System.Text.Json.Serialization;
using KartaViewSharp.V2.Enums;

namespace KartaViewSharp.V2.ResponseData.Converters;

public class StringAsNullabeSequenceTypeJsonConverter : JsonConverter<SequenceType?>
{
    public override SequenceType? Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options) =>
        reader.GetString() switch
        {
            "photo" => SequenceType.Photo,
            "video" => SequenceType.Video,
            "vdb" => SequenceType.Vdb,
            _ => null
        };

    public override void Write(
        Utf8JsonWriter writer,
        SequenceType? value,
        JsonSerializerOptions options)
    {
        writer.WriteStringValue(value switch
        {
            SequenceType.Photo => "photo",
            SequenceType.Video => "video",
            SequenceType.Vdb => "vdb",
            _ => null
        });
    }
}