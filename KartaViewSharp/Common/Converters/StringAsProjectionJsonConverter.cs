using System.Text.Json;
using System.Text.Json.Serialization;
using KartaViewSharp.V2.Enums;

namespace KartaViewSharp.Common.Converters;

internal class StringAsProjectionJsonConverter : JsonConverter<Projection>
{
    public override Projection Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options) =>
        reader.GetString() switch
        {
            "PLANE" => Projection.Plane,
            "CYLINDER" => Projection.Cylinder,
            "SPHERE" => Projection.Sphere,
            "FISHEYE" => Projection.Fisheye,
            "CUBE" => Projection.Cube,
            _ => throw new ArgumentOutOfRangeException()
        };

    public override void Write(
        Utf8JsonWriter writer,
        Projection value,
        JsonSerializerOptions options)
    {
        writer.WriteStringValue(value switch
        {
            Projection.Plane => "PLANE",
            Projection.Cylinder => "CYLINDER",
            Projection.Sphere => "SPHERE",
            Projection.Fisheye => "FISHEYE",
            Projection.Cube => "CUBE",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, null)
        });
    }
}