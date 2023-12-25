using System.Text.Json;
using System.Text.Json.Serialization;
using KartaViewSharp.V2.Enums;

namespace KartaViewSharp.V2.ResponseData.Converters;

public class StringAsStatusJsonConverter : JsonConverter<Status>
{
    public override Status Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options) =>
        reader.GetString() switch
        {
            "active" => Status.Active,
            "deleted" => Status.Deleted,
            "delete_queue" => Status.DeleteQueue,
            "inactive" => Status.Inactive,
            _ => throw new ArgumentOutOfRangeException()
        };

    public override void Write(
        Utf8JsonWriter writer,
        Status value,
        JsonSerializerOptions options)
    {
        writer.WriteStringValue(value switch
        {
            Status.Active => "active",
            Status.Deleted => "deleted",
            Status.DeleteQueue => "delete_queue",
            Status.Inactive => "inactive",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, null)
        });
    }
}