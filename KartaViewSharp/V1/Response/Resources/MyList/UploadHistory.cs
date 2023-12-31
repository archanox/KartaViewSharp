using System.Text.Json.Serialization;
using KartaViewSharp.Common.Converters;

namespace KartaViewSharp.V1.Response.Resources.MyList;

public class UploadHistory
{
    [JsonPropertyName("id")]
    [JsonConverter(typeof(StringAsIntJsonConverter))]
    public int Id { get; set; }

    [JsonPropertyName("sequence_id")]
    [JsonConverter(typeof(StringAsIntJsonConverter))]
    public int SequenceId { get; set; }

    [JsonPropertyName("user_id")]
    [JsonConverter(typeof(StringAsIntJsonConverter))]
    public int UserId { get; set; }

    [JsonPropertyName("user_category")]
    [JsonConverter(typeof(StringAsUserCategoryJsonConverter))]
    public UserCategory UserCategory { get; set; }

    [JsonPropertyName("distance")]
    [JsonConverter(typeof(StringAsNullableDoubleJsonConverter))]
    public double? Distance { get; set; }

    [JsonPropertyName("has_obd")]
    [JsonConverter(typeof(StringAsBoolJsonConverter))]
    public bool HasObd { get; set; }

    [JsonPropertyName("date_updated")]
    [JsonConverter(typeof(StringAsNullableDateTimeJsonConverter))]
    public DateTime? DateUpdated { get; set; }

    [JsonPropertyName("date_added")]
    [JsonConverter(typeof(StringAsDateTimeJsonConverter))]
    public DateTime DateAdded { get; set; }

    [JsonPropertyName("coverage")]
    public Coverage[] Coverage { get; set; }

    [JsonPropertyName("signs")]
    public object[] Signs { get; set; }

    [JsonPropertyName("points")]
    public Points Points { get; set; }
}

public enum UserCategory
{
    Regular,
    Driver,
    Internal
}