using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;
using ISO3166;
using NetTopologySuite.Geometries;

namespace KartaViewSharp.V2.ResponseData;

public class Data
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
	    get => this.CurrentLat is not null && this.CurrentLng is not null ? new Coordinate(this.CurrentLat.Value, this.CurrentLng.Value) : null;
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
	    get => new(this.NwLat, this.NwLng);
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
		get => new(this.SeLat, this.SeLng);
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

public enum Status
{
	Active,
	Deleted,
	DeleteQueue,
	Inactive,
}

public class StringAsNullableIntJsonConverter : JsonConverter<int?>
{
	public override int? Read(
		ref Utf8JsonReader reader,
		Type typeToConvert,
		JsonSerializerOptions options)
	{
		var value = reader.GetString();
		if (value == null)
			return null;
		return int.Parse(value);
	}

	public override void Write(
		Utf8JsonWriter writer,
		int? value,
		JsonSerializerOptions options) =>
		writer.WriteStringValue(value.ToString());
}

public class StringAsNullableDoubleJsonConverter : JsonConverter<double?>
{
	public override double? Read(
		ref Utf8JsonReader reader,
		Type typeToConvert,
		JsonSerializerOptions options)
	{
		var value = reader.GetString();
		if (value == null)
			return null;
		return double.Parse(value);
	}

	public override void Write(
		Utf8JsonWriter writer,
		double? value,
		JsonSerializerOptions options) =>
		writer.WriteStringValue(value.ToString());
}

public class StringAsNullableCountryJsonConverter : JsonConverter<Country?>
{
	public override Country? Read(
		ref Utf8JsonReader reader,
		Type typeToConvert,
		JsonSerializerOptions options)
	{
		var value = reader.GetString();
		if (value == null)
			return null;
		else
			return ISO3166.Country.List.SingleOrDefault(x=>x.TwoLetterCode == value);
	}

	public override void Write(
		Utf8JsonWriter writer,
		Country? value,
		JsonSerializerOptions options) =>
		writer.WriteStringValue(value?.TwoLetterCode);
}

public class StringAsDoubleJsonConverter : JsonConverter<double>
{
	public override double Read(
		ref Utf8JsonReader reader,
		Type typeToConvert,
		JsonSerializerOptions options)
	{
		return double.Parse(reader.GetString()!);
	}

	public override void Write(
		Utf8JsonWriter writer,
		double value,
		JsonSerializerOptions options) =>
		writer.WriteStringValue(value.ToString(CultureInfo.InvariantCulture));
}

public class StringAsIntJsonConverter : JsonConverter<int>
{
	public override int Read(
		ref Utf8JsonReader reader,
		Type typeToConvert,
		JsonSerializerOptions options)
	{
		var value = reader.GetString() ?? "0";
		return int.Parse(value);
	}

	public override void Write(
		Utf8JsonWriter writer,
		int value,
		JsonSerializerOptions options) =>
		writer.WriteStringValue(value.ToString());
}

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

public class StringAsSequenceStatusJsonConverter : JsonConverter<SequenceStatus>
{
	public override SequenceStatus Read(
		ref Utf8JsonReader reader,
		Type typeToConvert,
		JsonSerializerOptions options) =>
		reader.GetString() switch
		{
			"FINISHED" => SequenceStatus.Finished,
            "NEW" => SequenceStatus.New,
			"VIDEO_SPLIT" => SequenceStatus.VideoSplit,
			"UPLOAD_FINISHED" => SequenceStatus.UploadFinished,
			"PROCESSING_FINISHED" => SequenceStatus.ProcessingFinished,
			"PROCESSING_FAILED" => SequenceStatus.ProcessingFailed,
			"UPLOADING" => SequenceStatus.Uploading,
            "PROCESSING" => SequenceStatus.Processing,
            "FAILED" => SequenceStatus.Failed,
			_ => throw new ArgumentOutOfRangeException()
		};

	public override void Write(
		Utf8JsonWriter writer,
		SequenceStatus value,
		JsonSerializerOptions options)
	{
		writer.WriteStringValue(value switch
		{
			SequenceStatus.Finished => "FINISHED",
            SequenceStatus.New => "NEW",
			SequenceStatus.VideoSplit => "VIDEO_SPLIT",
			SequenceStatus.UploadFinished => "UPLOAD_FINISHED",
			SequenceStatus.ProcessingFinished => "PROCESSING_FINISHED",
			SequenceStatus.ProcessingFailed => "PROCESSING_FAILED",
            SequenceStatus.Uploading => "UPLOADING",
            SequenceStatus.Processing => "PROCESSING",
            SequenceStatus.Failed => "FAILED",
			_ => throw new ArgumentOutOfRangeException(nameof(value), value, null)
		});
	}
}

public class StringAsBoolJsonConverter : JsonConverter<bool>
{
	public override bool Read(
		ref Utf8JsonReader reader,
		Type typeToConvert,
		JsonSerializerOptions options)
	{
		var value = reader.GetString();
		if (value is null) return false;
		if (value == "1") return true;
		if (value == "0") return false;
		return bool.Parse(value);
	}

	public override void Write(
		Utf8JsonWriter writer,
		bool value,
		JsonSerializerOptions options) =>
		writer.WriteStringValue(value.ToString());
}

public class StringAsDateTimeJsonConverter : JsonConverter<DateTime>
{
	public override DateTime Read(
		ref Utf8JsonReader reader,
		Type typeToConvert,
		JsonSerializerOptions options)
	{
		return DateTime.ParseExact(reader.GetString(), "yyyy-MM-dd hh:mm:ss", CultureInfo.InvariantCulture); // 2023-04-06 04:16:15
	}

	public override void Write(
		Utf8JsonWriter writer,
		DateTime value,
		JsonSerializerOptions options) =>
		writer.WriteStringValue(value!.ToString("yyyy-MM-dd hh:mm:ss", CultureInfo.InvariantCulture));
}

public class StringAsNullableDateTimeJsonConverter : JsonConverter<DateTime?>
{
	public override DateTime? Read(
		ref Utf8JsonReader reader,
		Type typeToConvert,
		JsonSerializerOptions options)
	{
		var value = reader.GetString();
        if (value == null)
            return null;
		return DateTime.ParseExact(value, "yyyy-MM-dd hh:mm:ss", CultureInfo.InvariantCulture); // 2023-04-06 04:16:15
	}

	public override void Write(
		Utf8JsonWriter writer,
		DateTime? value,
		JsonSerializerOptions options) =>
		writer.WriteStringValue(value?.ToString("yyyy-MM-dd hh:mm:ss", CultureInfo.InvariantCulture));
}