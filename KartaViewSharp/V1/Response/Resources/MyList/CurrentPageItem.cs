using ISO3166;
using KartaViewSharp.Common.Converters;
using KartaViewSharp.V2.Enums;
using NetTopologySuite.Geometries;
using System.Text.Json.Serialization;

namespace KartaViewSharp.V1.Response.Resources.MyList;

public sealed class CurrentPageItem
{
    [JsonPropertyName("id")]
    [JsonConverter(typeof(StringAsIntJsonConverter))]
    public int Id { get; set; }

    [JsonPropertyName("date_added")]
    [JsonConverter(typeof(StringAsDateTimeV1JsonConverter))]
    public DateTime DateAdded { get; set; }

    [JsonPropertyName("country_code")]
    [JsonConverter(typeof(StringAsNullableCountryJsonConverter))]
    public Country? CountryCode { get; set; }

    [JsonPropertyName("current_lat")]
    [JsonConverter(typeof(StringAsNullableDoubleJsonConverter))]
    public double? CurrentLat { get; set; }

    [JsonPropertyName("current_lng")]
    [JsonConverter(typeof(StringAsNullableDoubleJsonConverter))]
    public double? CurrentLng { get; set; }

    [JsonIgnore]
    public Coordinate? CurrentLocation
    {
        get => CurrentLat is not null && CurrentLng is not null ? new Coordinate(CurrentLat.Value, CurrentLng.Value) : null;
        set
        {
            CurrentLat = value?.X;
            CurrentLng = value?.Y;
        }
    }

    [JsonPropertyName("nw_lat")]
    [JsonConverter(typeof(StringAsDoubleJsonConverter))]
    public double NwLat { get; set; }

    [JsonPropertyName("nw_lng")]
    [JsonConverter(typeof(StringAsDoubleJsonConverter))]
    public double NwLng { get; set; }

    [JsonIgnore]
    public Coordinate NorthWest
    {
        get => new(NwLat, NwLng);
        set
        {
            NwLat = value.X;
            NwLng = value.Y;
        }
    }

    [JsonPropertyName("se_lat")]
    [JsonConverter(typeof(StringAsDoubleJsonConverter))]
    public double SeLat { get; set; }

    [JsonPropertyName("se_lng")]
    [JsonConverter(typeof(StringAsDoubleJsonConverter))]
    public double SeLng { get; set; }

    [JsonIgnore]
    public Coordinate SouthEast
    {
        get => new(SeLat, SeLng);
        set
        {
            SeLat = value.X;
            SeLng = value.Y;
        }
    }

    [JsonPropertyName("location")]
    public string Location { get; set; }

    [JsonPropertyName("photo_no")]
    [JsonConverter(typeof(StringAsIntJsonConverter))]
    public int PhotoNo { get; set; }

    [JsonPropertyName("distance")]
    [JsonConverter(typeof(StringAsNullableDoubleJsonConverter))]
    public double? Distance { get; set; }

    [JsonPropertyName("image_processing_status")]
    [JsonConverter(typeof(StringAsSequenceStatusJsonConverter))]
    public SequenceStatus ImageProcessingStatus { get; set; }

    [JsonPropertyName("obd_info")]
    [JsonConverter(typeof(StringAsNullableBoolJsonConverter))]
    public bool? ObdInfo { get; set; }

    [JsonPropertyName("platform_name")]
    public string PlatformName { get; set; }

    [JsonPropertyName("platform_version")]
    public string PlatformVersion { get; set; }

    [JsonPropertyName("app_version")]
    public string AppVersion { get; set; }

    [JsonPropertyName("reviewed")]
    [JsonConverter(typeof(StringAsNullableIntJsonConverter))]
    public int? Reviewed { get; set; }

    [JsonPropertyName("changes")]
    [JsonConverter(typeof(StringAsNullableIntJsonConverter))]
    public int? Changes { get; set; }

    [JsonPropertyName("recognitions")]
    [JsonConverter(typeof(StringAsNullableIntJsonConverter))]
    public int? Recognitions { get; set; }

    [JsonPropertyName("user_id")]
    [JsonConverter(typeof(StringAsIntJsonConverter))]
    public int UserId { get; set; }

    [JsonPropertyName("th_stripped_path")]
    public string ThStrippedPath { get; set; }

    [JsonPropertyName("meta_data_filename")]
    public string MetaDataFilename { get; set; }

    [JsonPropertyName("thumb_name")]
    public string ThumbName { get; set; }

    [JsonPropertyName("upload_history")]
    public UploadHistory UploadHistory { get; set; }
}