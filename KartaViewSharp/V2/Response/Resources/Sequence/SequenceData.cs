using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using ISO3166;
using KartaViewSharp.Common.Converters;
using KartaViewSharp.V1.Response.Resources.Authentication;
using KartaViewSharp.V1.Response.Resources.MyList;
using KartaViewSharp.V2.Enums;
using KartaViewSharp.V2.Response.Resources.Photo;
using KartaViewSharp.V2.Response.Shared;
using NetTopologySuite.Geometries;

namespace KartaViewSharp.V2.Response.Resources.Sequence;

[JsonSerializable(typeof(SequenceData), GenerationMode = JsonSourceGenerationMode.Metadata)]
public sealed class SequenceData : IEquatable<SequenceData>
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
	[XmlIgnore]
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
	[XmlIgnore]
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
    [XmlIgnore]
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
	[XmlIgnore]
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
    [JsonConverter(typeof(StringAsNullableSequenceTypeJsonConverter))]
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
    [JsonPropertyName("blurBuild")]
	[JsonConverter(typeof(StringAsIntJsonConverter))]
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
	[XmlIgnore]
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

	[JsonPropertyName("photo")]
	public PhotoData? Photo { get; set; }

	[JsonPropertyName("photos")]
	public PhotoData[]? Photos { get; set; }

	[JsonPropertyName("user")]
	public User? User { get; set; }

	public bool Equals(SequenceData? other)
	{
		if (other is null) return false;
		if (ReferenceEquals(this, other)) return true;
		return Id == other.Id &&
		       DateAdded.Equals(other.DateAdded) &&
		       Nullable.Equals(DateProcessed, other.DateProcessed) &&
		       ImageProcessingStatus == other.ImageProcessingStatus &&
		       IsVideo == other.IsVideo &&
		       Nullable.Equals(CurrentLat, other.CurrentLat) &&
		       Nullable.Equals(CurrentLng, other.CurrentLng) &&
		       NwLat.Equals(other.NwLat) &&
		       NwLng.Equals(other.NwLng) &&
		       SeLat.Equals(other.SeLat) &&
		       SeLng.Equals(other.SeLng) &&
		       string.Equals(CountryCode?.TwoLetterCode, other.CountryCode?.TwoLetterCode, StringComparison.InvariantCulture) &&
		       string.Equals(StateCode, other.StateCode, StringComparison.InvariantCulture) &&
		       string.Equals(Address, other.Address, StringComparison.InvariantCulture) &&
		       SequenceType == other.SequenceType &&
		       CameraParameters.Equals(other.CameraParameters) &&
		       string.Equals(BlurVersion, other.BlurVersion, StringComparison.InvariantCulture) &&
		       BlurBuild == other.BlurBuild &&
		       string.Equals(DeviceName, other.DeviceName, StringComparison.InvariantCulture) &&
		       CountActivePhotos == other.CountActivePhotos &&
		       Nullable.Equals(Distance, other.Distance) &&
		       string.Equals(MetaDataFileName, other.MetaDataFileName, StringComparison.InvariantCulture) &&
		       string.Equals(MetaDataFilePath, other.MetaDataFilePath, StringComparison.InvariantCulture) &&
		       string.Equals(MetaDataFileUrl.ToString(), other.MetaDataFileUrl.ToString(), StringComparison.InvariantCulture) &&
		       ClientTotal == other.ClientTotal &&
		       string.Equals(ObdInfo, other.ObdInfo, StringComparison.InvariantCulture) &&
		       string.Equals(PlatformName, other.PlatformName, StringComparison.InvariantCulture) &&
		       string.Equals(PlatformVersion, other.PlatformVersion, StringComparison.InvariantCulture) &&
		       string.Equals(AppVersion, other.AppVersion, StringComparison.InvariantCulture) &&
		       string.Equals(Matched, other.Matched, StringComparison.InvariantCulture) &&
		       string.Equals(UploadSource, other.UploadSource, StringComparison.InvariantCulture) &&
		       string.Equals(Storage, other.Storage, StringComparison.InvariantCulture) &&
		       CountMetadataPhotos == other.CountMetadataPhotos &&
		       UploadStatus == other.UploadStatus &&
		       ProcessingStatus == other.ProcessingStatus &&
		       MetadataStatus == other.MetadataStatus &&
		       HasRawData == other.HasRawData &&
		       CountMetadataVideos == other.CountMetadataVideos &&
		       QualityStatus == other.QualityStatus &&
		       string.Equals(Quality, other.Quality, StringComparison.InvariantCulture) &&
		       Status == other.Status &&
		       UserId == other.UserId &&
		       Nullable.Equals(FieldOfView, other.FieldOfView) &&
		       MatchStatus == other.MatchStatus &&
			   Equals(Photo, other.Photo) &&
			   //Equals(Photos, other.Photos) &&
               Enumerable.SequenceEqual(Photos, other.Photos) &&
			   Equals(User, other.User);
	}

	public override bool Equals(object? obj)
	{
		return ReferenceEquals(this, obj) || obj is SequenceData other && Equals(other);
	}

	public override int GetHashCode()
	{
		var hashCode = new HashCode();
		hashCode.Add(Id);
		hashCode.Add(DateAdded);
		hashCode.Add(DateProcessed);
		hashCode.Add((int)ImageProcessingStatus);
		hashCode.Add(IsVideo);
		hashCode.Add(CurrentLat);
		hashCode.Add(CurrentLng);
		hashCode.Add(NwLat);
		hashCode.Add(NwLng);
		hashCode.Add(SeLat);
		hashCode.Add(SeLng);
		hashCode.Add(CountryCode?.TwoLetterCode, StringComparer.InvariantCulture);
		hashCode.Add(StateCode, StringComparer.InvariantCulture);
		hashCode.Add(Address, StringComparer.InvariantCulture);
		hashCode.Add(SequenceType);
		hashCode.Add(CameraParameters);
		hashCode.Add(BlurVersion, StringComparer.InvariantCulture);
		hashCode.Add(BlurBuild);
		hashCode.Add(DeviceName, StringComparer.InvariantCulture);
		hashCode.Add(CountActivePhotos);
		hashCode.Add(Distance);
		hashCode.Add(MetaDataFileName, StringComparer.InvariantCulture);
		hashCode.Add(MetaDataFilePath, StringComparer.InvariantCulture);
		hashCode.Add(MetaDataFileUrl?.ToString(), StringComparer.InvariantCulture);
		hashCode.Add(ClientTotal);
		hashCode.Add(ObdInfo, StringComparer.InvariantCulture);
		hashCode.Add(PlatformName, StringComparer.InvariantCulture);
		hashCode.Add(PlatformVersion, StringComparer.InvariantCulture);
		hashCode.Add(AppVersion, StringComparer.InvariantCulture);
		hashCode.Add(Matched, StringComparer.InvariantCulture);
		hashCode.Add(UploadSource, StringComparer.InvariantCulture);
		hashCode.Add(Storage, StringComparer.InvariantCulture);
		hashCode.Add(CountMetadataPhotos);
		hashCode.Add((int)UploadStatus);
		hashCode.Add((int)ProcessingStatus);
		hashCode.Add((int)MetadataStatus);
		hashCode.Add(HasRawData);
		hashCode.Add(CountMetadataVideos);
		hashCode.Add((int)QualityStatus);
		hashCode.Add(Quality, StringComparer.InvariantCulture);
		hashCode.Add((int)Status);
		hashCode.Add(UserId);
		hashCode.Add(FieldOfView);
		hashCode.Add((int)MatchStatus);
		hashCode.Add(Photo);
		//hashCode.Add(Photos);
		hashCode.Add(Photos.Aggregate(0, HashCode.Combine));
		hashCode.Add(User);
		return hashCode.ToHashCode();
	}
}

public class JsonStringAsArrayJsonConverter<T> : JsonConverter<T[]>
{
	public override T[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		switch (reader.TokenType)
		{
			case JsonTokenType.Null:
				return default;
			case JsonTokenType.StartArray:
				return JsonSerializer.Deserialize<T[]>(ref reader, options) ?? throw new JsonException();
			case JsonTokenType.String when string.IsNullOrWhiteSpace(reader.GetString()):
				return default;
			case JsonTokenType.String when !string.IsNullOrWhiteSpace(reader.GetString()):
				var input = reader.GetString();
				var array = JsonSerializer.Deserialize<T[]>(input, options) ?? throw new JsonException();
				return array;
			default:
			{
				var input2 = reader.GetString();
				return Array.Empty<T>();
			}
		}
	}

	public override void Write(Utf8JsonWriter writer, T[] value, JsonSerializerOptions options)
	{
		writer.WriteRawValue(JsonSerializer.Serialize(value, options));
	}
}

public class JsonStringAsObjectJsonConverter<T> : JsonConverter<T>
{
	public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		switch (reader.TokenType)
		{
            case JsonTokenType.Null:
	            return default;
			case JsonTokenType.StartObject:
			{
				return JsonSerializer.Deserialize<T>(ref reader, options) ?? throw new JsonException();
			}
			case JsonTokenType.String when string.IsNullOrWhiteSpace(reader.GetString()):
				return default;
			case JsonTokenType.String when !string.IsNullOrWhiteSpace(reader.GetString()):
				var input = reader.GetString();
				return JsonSerializer.Deserialize<T>(input, options) ?? throw new JsonException();
			default:
				throw new JsonException();
		}
	}

	public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
	{
        writer.WriteRawValue(JsonSerializer.Serialize(value, options));
	}
}

public class User : IEquatable<User>
{
	[JsonPropertyName("id")]
	[JsonConverter(typeof(StringAsIntJsonConverter))]
	public int Id { get; set; }

	[JsonPropertyName("username")]
	public string Username { get; set; }

	[JsonPropertyName("fullName")]
	public string FullName { get; set; }

	[JsonPropertyName("category")]
	[JsonConverter(typeof(StringAsUserCategoryJsonConverter))]
	public UserCategory Category { get; set; }

	[JsonPropertyName("driverType")]
	[JsonConverter(typeof(StringAsDriverTypeJsonConverter))]
	public DriverType DriverType { get; set; }

	public bool Equals(User? other)
	{
		if (ReferenceEquals(null, other)) return false;
		if (ReferenceEquals(this, other)) return true;
		return Id == other.Id && Username == other.Username && FullName == other.FullName && Category == other.Category && DriverType == other.DriverType;
	}

	public override bool Equals(object? obj)
	{
		if (ReferenceEquals(null, obj)) return false;
		if (ReferenceEquals(this, obj)) return true;
		if (obj.GetType() != this.GetType()) return false;
		return Equals((User)obj);
	}

	public override int GetHashCode()
	{
		return HashCode.Combine(Id, Username, FullName, (int)Category, (int)DriverType);
	}
}