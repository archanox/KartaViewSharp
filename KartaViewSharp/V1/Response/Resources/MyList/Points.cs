using System.Text.Json.Serialization;
using ISO3166;
using KartaViewSharp.Common.Converters;

namespace KartaViewSharp.V1.Response.Resources.MyList;

public class Points
{
    [JsonPropertyName("id")]
    [JsonConverter(typeof(StringAsIntJsonConverter))]
    public int Id { get; set; }

    [JsonPropertyName("upload_history_id")]
    [JsonConverter(typeof(StringAsIntJsonConverter))]
    public int UploadHistoryId { get; set; }

    [JsonPropertyName("sequence_date")]
    [JsonConverter(typeof(StringAsDateTimeJsonConverter))]
    public DateTime SequenceDate { get; set; }

    [JsonPropertyName("country_code")]
    [JsonConverter(typeof(StringAsNullableCountryJsonConverter))]
    public Country? Country { get; set; }

    [JsonPropertyName("state_code")]
    public string StateCode { get; set; }

    [JsonPropertyName("obd_multiple")]
    [JsonConverter(typeof(StringAsIntJsonConverter))]
    public int ObdMultiple { get; set; }

    [JsonPropertyName("signs_total")]
    [JsonConverter(typeof(StringAsIntJsonConverter))]
    public int SignsTotal { get; set; }

    [JsonPropertyName("coverage_total")]
    [JsonConverter(typeof(StringAsIntJsonConverter))]
    public int CoverageTotal { get; set; }

    [JsonPropertyName("client_total")]
    [JsonConverter(typeof(StringAsIntJsonConverter))]
    public int ClientTotal { get; set; }

    [JsonPropertyName("total")]
    [JsonConverter(typeof(StringAsIntJsonConverter))]
    public int Total { get; set; }

    [JsonPropertyName("date_updated")]
    [JsonConverter(typeof(StringAsDateTimeJsonConverter))]
    public DateTime DateUpdated { get; set; }

    [JsonPropertyName("date_added")]
    [JsonConverter(typeof(StringAsDateTimeJsonConverter))]
    public DateTime DateAdded { get; set; }
}