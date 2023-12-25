using System.Text.Json;
using System.Text.Json.Serialization;
using KartaViewSharp.V2.Enums;

namespace KartaViewSharp.V2.ResponseData.Converters;

public class StringAsAutoImgProcessingResultJsonConverter : JsonConverter<AutoImgProcessingResult>
{
    public override AutoImgProcessingResult Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options) =>
        reader.GetString() switch
        {
            "ORIGINAL" => AutoImgProcessingResult.Original,
            "BLURRED" => AutoImgProcessingResult.Blurred,
            _ => throw new ArgumentOutOfRangeException()
        };

    public override void Write(
        Utf8JsonWriter writer,
        AutoImgProcessingResult value,
        JsonSerializerOptions options)
    {
        writer.WriteStringValue(value switch
        {
            AutoImgProcessingResult.Original => "ORIGINAL",
            AutoImgProcessingResult.Blurred => "BLURRED",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, null)
        });
    }
}