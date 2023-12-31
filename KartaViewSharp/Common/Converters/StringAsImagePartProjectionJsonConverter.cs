using System.Text.Json;
using System.Text.Json.Serialization;
using KartaViewSharp.V2.Enums;

namespace KartaViewSharp.Common.Converters;

public class StringAsImagePartProjectionJsonConverter : JsonConverter<ImagePartProjection>
{
    public override ImagePartProjection Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options) =>
        reader.GetString() switch
        {
            "NONE" => ImagePartProjection.None,
            "DUAL_FISHEYE" => ImagePartProjection.DualFisheye,
            "FISHEYE_180" => ImagePartProjection.Fisheye180,
            "FISHEYE_360" => ImagePartProjection.Fisheye360,
            _ => throw new ArgumentOutOfRangeException()
        };

    public override void Write(
        Utf8JsonWriter writer,
        ImagePartProjection value,
        JsonSerializerOptions options)
    {
        writer.WriteStringValue(value switch
        {
            ImagePartProjection.None => "NONE",
            ImagePartProjection.DualFisheye => "DUAL_FISHEYE",
            ImagePartProjection.Fisheye180 => "FISHEYE_180",
            ImagePartProjection.Fisheye360 => "FISHEYE_360",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, null)
        });
    }
}