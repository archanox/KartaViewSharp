using System.Text.Json.Serialization;
using ISO3166;
using KartaViewSharp.V2.Enums;
using KartaViewSharp.V2.ResponseData.Converters;
using KartaViewSharp.V2.ResponseData.Shared;
using NetTopologySuite.Geometries;

namespace KartaViewSharp.V2.ResponseData.Resources.Sequence;

public sealed class SequenceData
{
    /// <summary>
    /// Unique identifier representing a specific sequence.
    /// </summary>
    [JsonPropertyName("id")]
    [JsonConverter(typeof(StringAsIntJsonConverter))]
    public int Id { get; set; }

    /// <summary>
    /// Datetime of the sequence when it was added.
    /// </summary>
    [JsonPropertyName("dateAdded")]
    [JsonConverter(typeof(StringAsDateTimeJsonConverter))]
    public DateTime DateAdded { get; set; }

    /// <summary>
    /// Datetime of the sequence when it was processed.
    /// </summary>
    [JsonPropertyName("dateProcessed")]
    [JsonConverter(typeof(StringAsNullableDateTimeJsonConverter))]
    public DateTime? DateProcessed { get; set; }

    /// <summary>
    /// Enum: "NEW" "VIDEO_SPLIT" "UPLOAD_FINISHED" "PROCESSING_FINISHED" "PROCESSING_FAILED"
    /// The status of the image processing.
    /// </summary>
    [JsonPropertyName("imageProcessingStatus")]
    [JsonConverter(typeof(StringAsSequenceStatusJsonConverter))]
    public SequenceStatus ImageProcessingStatus { get; set; }

    /// <summary>
    /// Check the sequence if it is a video or not.
    /// </summary>
    [JsonPropertyName("isVideo")]
    [JsonConverter(typeof(StringAsBoolJsonConverter))]
    public bool IsVideo { get; set; }

    /// <summary>
    /// First recorded latitude of the sequence.
    /// </summary>
    [JsonPropertyName("currentLat")]
    [JsonConverter(typeof(StringAsNullableDoubleJsonConverter))]
    public double? CurrentLat { get; set; }

    /// <summary>
    /// First recorded longitude of the sequence.
    /// </summary>
    [JsonPropertyName("currentLng")]
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

    /// <summary>
    /// NW Latitude coordinates of entity, campaign or campaign cell.
    /// </summary>
    [JsonPropertyName("nwLat")]
    [JsonConverter(typeof(StringAsDoubleJsonConverter))]
    public double NwLat { get; set; }

    /// <summary>
    /// NW Longitude coordinates of entity, campaign or campaign cell.
    /// </summary>
    [JsonPropertyName("nwLng")]
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

    /// <summary>
    /// SE Latitude coordinates of entity, campaign or campaign cell, calculated based on NW latitude coordinates.
    /// </summary>
    [JsonPropertyName("seLat")]
    [JsonConverter(typeof(StringAsDoubleJsonConverter))]
    public double SeLat { get; set; }

    /// <summary>
    /// SE Longitude coordinates of entity, campaign or campaign cell, calculated based on NW longitutde coordinates.
    /// </summary>
    [JsonPropertyName("seLng")]
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

    /// <summary>
    /// Country code
    /// </summary>
    [JsonPropertyName("countryCode")]
    [JsonConverter(typeof(StringAsNullableCountryJsonConverter))]
    public Country? CountryCode { get; set; }

    /// <summary>
    /// State code
    /// </summary>
    [JsonPropertyName("stateCode")]
    public string? StateCode { get; set; }

    /// <summary>
    /// Full address of the location, based on coordinates.
    /// </summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>
    /// The type of the recorded sequence, can be VDB or null.
    /// </summary>
    [JsonPropertyName("sequenceType")]
    [JsonConverter(typeof(StringAsNullabeSequenceTypeJsonConverter))]
    public SequenceType? SequenceType { get; set; }

    [JsonPropertyName("cameraParameters")]
    public CameraParameter CameraParameters { get; set; }

    /// <summary>
    /// Blur version used at the time of the blur action.
    /// </summary>
    [JsonPropertyName("blurVersion")]
    public string BlurVersion { get; set; }

    /// <summary>
    /// Build number at the time of the blur action.
    /// </summary>
    [JsonConverter(typeof(StringAsIntJsonConverter))]
    [JsonPropertyName("blurBuild")]
    public int BlurBuild { get; set; }

    /// <summary>
    /// The type of the device that recorded the sequence.
    /// </summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>
    /// Count of active photos in the sequence.
    /// </summary>
    [JsonConverter(typeof(StringAsNullableIntJsonConverter))]
    [JsonPropertyName("countActivePhotos")]
    public int? CountActivePhotos { get; set; }

    /// <summary>
    /// The length for the entire sequence, in km.
    /// </summary>
    [JsonPropertyName("distance")]
    [JsonConverter(typeof(StringAsNullableDoubleJsonConverter))]
    public double? Distance { get; set; }

    /// <summary>
    /// File name of the metadata, including file extension.
    /// </summary>
    [JsonPropertyName("metaDataFilename")]
    public string MetaDataFileName { get; set; }

    /// <summary>
    /// File name of the metadata, including file extension.
    /// </summary>
    [JsonPropertyName("metadataFilePath")]
    public string MetaDataFilePath { get; set; }

    /// <summary>
    /// File name of the metadata, including file extension.
    /// </summary>
    [JsonPropertyName("metadataFileUrl")]
    public Uri MetaDataFileUrl { get; set; }

    /// <summary>
    /// The total sequence score computed based on the coverage info.
    /// </summary>
    [JsonConverter(typeof(StringAsNullableIntJsonConverter))]
    [JsonPropertyName("clientTotal")]
    public int? ClientTotal { get; set; }

    /// <summary>
    /// A flag that confirms the presence of an obd connection at the time the sequence was captured.
    /// </summary>
    [JsonPropertyName("obdInfo")]
    public string? ObdInfo { get; set; }

    /// <summary>
    /// The platform name from which the sequence was recorded.
    /// </summary>
    [JsonPropertyName("platformName")]
    public string PlatformName { get; set; }

    /// <summary>
    /// The platform version from which the sequence was recorded.
    /// </summary>
    [JsonPropertyName("platformVersion")]
    public string PlatformVersion { get; set; }

    /// <summary>
    /// The application version used to record the sequence.
    /// </summary>
    [JsonPropertyName("appVersion")]
    public string AppVersion { get; set; }

    /// <summary>
    /// All locations matched with success.
    /// </summary>
    [JsonPropertyName("matched")]
    public string Matched { get; set; }

    /// <summary>
    /// The device name from which the sequence was uploaded.
    /// </summary>
    [JsonPropertyName("uploadSource")]
    public string UploadSource { get; set; }

    /// <summary>
    /// The name of storage where the file can be found.
    /// </summary>
    [JsonPropertyName("storage")]
    public string Storage { get; set; }

    /// <summary>
    /// The total number of photos found in the metadata file of the sequence.
    /// </summary>
    [JsonConverter(typeof(StringAsNullableIntJsonConverter))]
    [JsonPropertyName("countMetadataPhotos")]
    public int? CountMetadataPhotos { get; set; }

    /// <summary>
    /// The uploading status of the sequence process.
    /// </summary>
    [JsonPropertyName("uploadStatus")]
    [JsonConverter(typeof(StringAsSequenceStatusJsonConverter))]
    public SequenceStatus UploadStatus { get; set; }

    /// <summary>
    /// The processing status of the sequence process.
    /// </summary>
    [JsonPropertyName("processingStatus")]
    [JsonConverter(typeof(StringAsSequenceStatusJsonConverter))]
    public SequenceStatus ProcessingStatus { get; set; }

    /// <summary>
    /// The processing status of the metadata process.
    /// </summary>
    [JsonPropertyName("metadataStatus")]
    [JsonConverter(typeof(StringAsSequenceStatusJsonConverter))]
    public SequenceStatus MetadataStatus { get; set; }

    /// <summary>
    /// A flag that return true if there is rawdata attached to the sequence.
    /// </summary>
    [JsonPropertyName("hasRawData")]
    [JsonConverter(typeof(StringAsBoolJsonConverter))]
    public bool HasRawData { get; set; }

    /// <summary>
    /// The total number of videos found in the metadata file of the sequence.
    /// </summary>
    [JsonPropertyName("countMetadataVideos")]
    [JsonConverter(typeof(StringAsNullableIntJsonConverter))]
    public int? CountMetadataVideos { get; set; }

    /// <summary>
    /// The quality status of the sequence process.
    /// </summary>
    [JsonPropertyName("qualityStatus")]
    [JsonConverter(typeof(StringAsSequenceStatusJsonConverter))]
    public SequenceStatus QualityStatus { get; set; }

    /// <summary>
    /// The average image quality number, in procentages.
    /// </summary>
    [JsonPropertyName("quality")]
    public string Quality { get; set; }

    /// <summary>
    /// The state of the file, active when visible to the client, deleted when hidden, delete_queue when marked to be made hidden, inactive when the file does not exist on the disk.
    /// </summary>
    [JsonPropertyName("status")]
    [JsonConverter(typeof(StringAsStatusJsonConverter))]
    public Status Status { get; set; }

    /// <summary>
    /// The id of the user that recorded the sequence.
    /// </summary>
    [JsonPropertyName("userId")]
    [JsonConverter(typeof(StringAsIntJsonConverter))]
    public int UserId { get; set; }

    [JsonPropertyName("fieldOfView")]
    [JsonConverter(typeof(StringAsNullableDoubleJsonConverter))]
    public double? FieldOfView { get; set; }

    [JsonPropertyName("matchStatus")]
    [JsonConverter(typeof(StringAsSequenceStatusJsonConverter))]
    public SequenceStatus MatchStatus { get; set; }
}