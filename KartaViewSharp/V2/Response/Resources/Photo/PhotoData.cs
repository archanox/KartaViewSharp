using System.Text.Json.Serialization;
using System.Xml.Serialization;
using KartaViewSharp.Common.Converters;
using KartaViewSharp.V2.Enums;
using KartaViewSharp.V2.Response.Shared;
using NetTopologySuite.Geometries;

namespace KartaViewSharp.V2.Response.Resources.Photo;

public sealed class PhotoData : IEquatable<PhotoData>
{
	/// <summary>
	/// The status of the new image, after the blurring process, if any blurring occurs -&gt; status will be <see cref="Enums.AutoImgProcessingResult.Blurred"/>.
	/// </summary>
	[JsonPropertyName("autoImgProcessingResult")]
	[JsonConverter(typeof(StringAsAutoImgProcessingResultJsonConverter))]
	public AutoImgProcessingResult? AutoImgProcessingResult { get; set; }

	[JsonPropertyName("autoImgProcessingStatus")]
	public string AutoImgProcessingStatus { get; set; }

	[JsonPropertyName("cameraParameters")]
	[JsonConverter(typeof(JsonStringAsObjectJsonConverter<CameraParameter>))]
	public CameraParameter CameraParameters { get; set; }

	/// <summary>
	/// Datetime when the photo was added.
	/// </summary>
	[JsonPropertyName("dateAdded")]
	[JsonConverter(typeof(StringAsDateTimeJsonConverter))]
	public DateTime DateAdded { get; set; }

	/// <summary>
	/// Datetime of the photo when it was processed.
	/// </summary>
	[JsonPropertyName("dateProcessed")]
	[JsonConverter(typeof(StringAsNullableDateTimeJsonConverter))]
	public DateTime? DateProcessed { get; set; }

	/// <summary>
	/// The distance between the current photo and the next one, in meters.
	/// </summary>
	[JsonPropertyName("distance")]
	[JsonConverter(typeof(StringAsNullableDoubleJsonConverter))]
	public double? Distance { get; set; }

	/// <summary>
	/// The part of the world that is visible through the camera, expressed in degrees.
	/// </summary>
	[JsonPropertyName("fieldOfView")]
	[JsonConverter(typeof(StringAsNullableDoubleJsonConverter))]
	public double? FieldOfView { get; set; }

	/// <summary>
	/// Path to the file.
	/// </summary>
	[JsonPropertyName("filepath")]
	public string? Filepath { get; set; }

	/// <summary>
	/// Path to the large thumbnail version of the file.
	/// </summary>
	[JsonPropertyName("filepathLTh")]
	public string? FilepathLTh { get; set; }

	/// <summary>
	/// Path to the processed version of the file.
	/// </summary>
	[JsonPropertyName("filepathProc")]
	public string? FilepathProc { get; set; }

	/// <summary>
	/// Path to the thumbnail version of the file.
	/// </summary>
	[JsonPropertyName("filepathTh")]
	public string? FilepathTh { get; set; }

	/// <summary>
	/// Url to the file.
	/// </summary>
	[XmlIgnore]
	[JsonPropertyName("fileurl")]
	public Uri Fileurl { get; set; }

	/// <summary>
	/// Url to the large thumbnail version of the file.
	/// </summary>
	[XmlIgnore]
	[JsonPropertyName("fileurlLTh")]
	public Uri FileurlLTh { get; set; }

	/// <summary>
	/// Url to the processed version of the file.
	/// </summary>
	[XmlIgnore]
	[JsonPropertyName("fileurlProc")]
	public Uri FileurlProc { get; set; }

	/// <summary>
	/// Url to the large thumbnail version of the file.
	/// </summary>
	[XmlIgnore]
	[JsonPropertyName("fileurlTh")]
	public Uri FileurlTh { get; set; }

	/// <summary>
	/// The unique identifier of the starting point of a segment, each version of a map has different ids.
	/// </summary>
	[JsonPropertyName("from")]
	[JsonConverter(typeof(StringAsNullableLongJsonConverter))]
	public long? From { get; set; }

	/// <summary>
	/// Horizontal accuracy in meters of the gps tracked photo.
	/// </summary>
	[JsonPropertyName("gpsAccuracy")]
	[JsonConverter(typeof(StringAsDoubleJsonConverter))]
	public double GpsAccuracy { get; set; }

	/// <summary>
	/// A flag that confirms the presence of an obd connection at the time the photo was captured.
	/// </summary>
	[JsonPropertyName("hasObd")]
	[JsonConverter(typeof(StringAsBoolJsonConverter))]
	public bool HasObd { get; set; }

	[JsonPropertyName("headers")]
	[JsonConverter(typeof(StringAsDoubleJsonConverter))]
	public double Headers { get; set; }

	/// <summary>
	/// Heading direction based on compass direction, in degrees.
	/// </summary>
	[JsonPropertyName("heading")]
	[JsonConverter(typeof(StringAsDoubleJsonConverter))]
	public double Heading { get; set; }

	/// <summary>
	/// Photo width in pixels.
	/// </summary>
	[JsonPropertyName("height")]
	[JsonConverter(typeof(StringAsNullableIntJsonConverter))]
	public int? Height { get; set; }

	/// <summary>
	/// Unique identifier representing a specific photo.
	/// </summary>
	[JsonPropertyName("id")]
	[JsonConverter(typeof(StringAsIntJsonConverter))]
	public int Id { get; set; }

	/// <summary>
	/// The image part projection type.
	/// </summary>
	[JsonPropertyName("imagePartProjection")]
	[JsonConverter(typeof(StringAsImagePartProjectionJsonConverter))]
	public ImagePartProjection ImagePartProjection { get; set; } = ImagePartProjection.None;

	/// <summary>
	/// A flag that confirms if the photo is unwrapped or not.
	/// </summary>
	[JsonPropertyName("isUnwrapped")]
	[JsonConverter(typeof(StringAsBoolJsonConverter))]
	public bool IsUnwrapped { get; set; }

	/// <summary>
	/// A flag that confirms if the photo is wrapped or not.
	/// </summary>
	[JsonPropertyName("isWrapped")]
	[JsonConverter(typeof(StringAsBoolJsonConverter))]
	public bool IsWrapped { get; set; }

	/// <summary>
	/// Latitude coordinates of the photo.
	/// </summary>
	[JsonPropertyName("lat")]
	[JsonConverter(typeof(StringAsNullableDoubleJsonConverter))]
	public double? Latitude { get; set; }

	/// <summary>
	/// Longitude coordinates of the photo.
	/// </summary>
	[JsonPropertyName("lng")]
	[JsonConverter(typeof(StringAsNullableDoubleJsonConverter))]
	public double? Longitude { get; set; }

	[JsonIgnore]
	[XmlIgnore]
	public Coordinate? Location
	{
		get => Latitude is not null && Longitude is not null ? new Coordinate(Latitude.Value, Longitude.Value) : null;
		set
		{
			Latitude = value?.X;
			Longitude = value?.Y;
		}
	}

	/// <summary>
	/// The incoming latitude value from the matcher.
	/// </summary>
	[JsonPropertyName("matchLat")]
	[JsonConverter(typeof(StringAsNullableDoubleJsonConverter))]
	public double? MatchLat { get; set; }

	/// <summary>
	/// The incoming longitude value from the matcher.
	/// </summary>
	[JsonPropertyName("matchLng")]
	[JsonConverter(typeof(StringAsNullableDoubleJsonConverter))]
	public double? MatchLng { get; set; }

	[JsonIgnore]
	[XmlIgnore]
	public Coordinate? MatchLocation
	{
		get => MatchLat is not null && MatchLng is not null ? new Coordinate(MatchLat.Value, MatchLng.Value) : null;
		set
		{
			MatchLat = value?.X;
			MatchLng = value?.Y;
		}
	}

	/// <summary>
	/// The unique identifier of the segment used by the matcher, each version of a map has different ids.
	/// </summary>
	[JsonPropertyName("matchSegmentId")]
	[JsonConverter(typeof(StringAsNullableIntJsonConverter))]
	public int? MatchSegmentId { get; set; }

	/// <summary>
	/// Photo name including photo extension.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }

	[JsonPropertyName("orgCode")]
	public string OrgCode { get; set; }

	/// <summary>
	/// The distortion type of the photo.
	/// </summary>
	[JsonPropertyName("projection")]
	[JsonConverter(typeof(StringAsProjectionJsonConverter))]
	public Projection Projection { get; set; } = Projection.Plane;

	/// <summary>
	/// The projection on yaw axis, horizontal rotation in degrees, min -180, max 180.
	/// </summary>
	[JsonPropertyName("projectionYaw")]
	[JsonConverter(typeof(StringAsIntJsonConverter))]
	public int ProjectionYaw { get; set; } = 0;

	[JsonPropertyName("qualityDetails")]
	[JsonConverter(typeof(JsonStringAsArrayJsonConverter<QualityDetail>))]
	public QualityDetail[] QualityDetails { get; set; }

	[JsonPropertyName("qualityLevel")]
	public string QualityLevel { get; set; }

	[JsonPropertyName("qualityStatus")]
	[JsonConverter(typeof(StringAsSequenceStatusJsonConverter))]
	public SequenceStatus QualityStatus { get; set; }

	/// <summary>
	/// Unique identifier representing a specific rawdata.
	/// </summary>
	[JsonPropertyName("rawDataId")]
	[JsonConverter(typeof(StringAsNullableIntJsonConverter))]
	public int? RawDataId { get; set; }

	/// <summary>
	/// Unique identifier representing a specific sequence.
	/// </summary>
	[JsonPropertyName("sequenceId")]
	[JsonConverter(typeof(StringAsIntJsonConverter))]
	public int SequenceId { get; set; }

	/// <summary>
	/// Identifier representing a specific image index.
	/// </summary>
	[JsonPropertyName("sequenceIndex")]
	[JsonConverter(typeof(StringAsNullableIntJsonConverter))]
	public int? SequenceIndex { get; set; }

	/// <summary>
	/// Datetime of the photo when it was shot.
	/// </summary>
	[JsonPropertyName("shotDate")]
	[JsonConverter(typeof(StringAsNullableDateTimeJsonConverter))]
	public DateTime? ShotDate { get; set; }

	/// <summary>
	/// The state of the file,
	/// <list type="bullet">
	/// <item>
	/// <description><see cref="Enums.Status.Active"/> when visible to the client,</description>
	/// </item>
	/// <item>
	/// <description><see cref="Enums.Status.Deleted"/> when hidden,</description>
	/// </item>
	/// <item>
	/// <description><see cref="Enums.Status.DeleteQueue"/> when marked to be made hidden,</description>
	/// </item>
	/// <item>
	/// <description><see cref="Enums.Status.Inactive"/> when the file does not exist on the disk.</description>
	/// </item>
	/// </list>
	/// </summary>
	[JsonPropertyName("status")]
	[JsonConverter(typeof(StringAsStatusJsonConverter))]
	public Status Status { get; set; }

	/// <summary>
	/// The name of storage where the file can be found.
	/// </summary>
	[JsonPropertyName("storage")]
	public string? Storage { get; set; }

	/// <summary>
	/// The unique identifier of the ending point of a segment, each version of a map has different ids.
	/// </summary>
	[JsonPropertyName("to")]
	[JsonConverter(typeof(StringAsNullableLongJsonConverter))]
	public long? To { get; set; }

	/// <summary>
	/// The version of unwrap photo.
	/// </summary>
	[JsonPropertyName("unwrapVersion")]
	[JsonConverter(typeof(StringAsIntJsonConverter))]
	public int UnwrapVersion { get; set; } = 0;

	/// <summary>
	/// Unique identifier representing a specific video.
	/// </summary>
	[JsonPropertyName("videoId")]
	[JsonConverter(typeof(StringAsNullableIntJsonConverter))]
	public int? VideoId { get; set; } = null;

	/// <summary>
	/// Identifier representing a specific video index.
	/// </summary>
	[JsonPropertyName("videoIndex")]
	[JsonConverter(typeof(StringAsNullableIntJsonConverter))]
	public int? VideoIndex { get; set; }

	/// <summary>
	/// The exposing level of the photo based on blurring, e.g if not blurred then private
	/// </summary>
	[JsonPropertyName("visibility")]
	[JsonConverter(typeof(StringAsVisibilityJsonConverter))]
	public Visibility Visibility { get; set; } = Visibility.Private;

	/// <summary>
	/// The unique identifier of the way, on which the photo was matched, each version of a map has different ids.
	/// </summary>
	[JsonPropertyName("wayId")]
	[JsonConverter(typeof(StringAsNullableIntJsonConverter))]
	public int? WayId { get; set; }

	/// <summary>
	/// Photo width in pixels.
	/// </summary>
	[JsonPropertyName("width")]
	[JsonConverter(typeof(StringAsNullableIntJsonConverter))]
	public int? Width { get; set; }

	/// <summary>
	/// The version of wrap photo.
	/// </summary>
	[JsonPropertyName("wrapVersion")]
	[JsonConverter(typeof(StringAsIntJsonConverter))]
	public int WrapVersion { get; set; } = 0;

	/// <inheritdoc />
	public bool Equals(PhotoData? other)
	{
		if (other is null)
		{
			return false;
		}

		if (ReferenceEquals(this, other))
		{
			return true;
		}

		return AutoImgProcessingResult == other.AutoImgProcessingResult &&
		       string.Equals(AutoImgProcessingStatus, other.AutoImgProcessingStatus, StringComparison.InvariantCulture) &&
		       Nullable.Equals(CameraParameters, other.CameraParameters) &&
		       DateAdded.Equals(other.DateAdded) &&
		       Nullable.Equals(DateProcessed, other.DateProcessed) &&
		       Nullable.Equals(Distance, other.Distance) &&
		       Nullable.Equals(FieldOfView, other.FieldOfView) &&
		       string.Equals(Filepath, other.Filepath, StringComparison.InvariantCulture) &&
		       string.Equals(FilepathLTh, other.FilepathLTh, StringComparison.InvariantCulture) &&
		       string.Equals(FilepathProc, other.FilepathProc, StringComparison.InvariantCulture) &&
		       string.Equals(FilepathTh, other.FilepathTh, StringComparison.InvariantCulture) &&
		       string.Equals(Fileurl?.ToString(), other.Fileurl?.ToString(), StringComparison.InvariantCulture) &&
		       string.Equals(FileurlLTh?.ToString(), other.FileurlLTh?.ToString(), StringComparison.InvariantCulture) &&
		       string.Equals(FileurlProc?.ToString(), other.FileurlProc?.ToString(), StringComparison.InvariantCulture) &&
		       string.Equals(FileurlTh?.ToString(), other.FileurlTh?.ToString(), StringComparison.InvariantCulture) &&
		       From == other.From &&
		       GpsAccuracy.Equals(other.GpsAccuracy) &&
		       HasObd == other.HasObd &&
		       Headers.Equals(other.Headers) &&
		       Heading.Equals(other.Heading) &&
		       Height == other.Height &&
		       Id == other.Id &&
		       ImagePartProjection == other.ImagePartProjection &&
		       IsUnwrapped == other.IsUnwrapped &&
		       IsWrapped == other.IsWrapped &&
		       Nullable.Equals(Latitude, other.Latitude) &&
		       Nullable.Equals(Longitude, other.Longitude) &&
		       Nullable.Equals(MatchLat, other.MatchLat) &&
		       Nullable.Equals(MatchLng, other.MatchLng) &&
		       MatchSegmentId == other.MatchSegmentId &&
		       string.Equals(Name, other.Name, StringComparison.InvariantCulture) &&
		       string.Equals(OrgCode, other.OrgCode, StringComparison.InvariantCulture) &&
		       Projection == other.Projection &&
		       ProjectionYaw == other.ProjectionYaw &&
		       Enumerable.SequenceEqual(QualityDetails, other.QualityDetails) &&
		       string.Equals(QualityLevel, other.QualityLevel, StringComparison.InvariantCulture) &&
		       QualityStatus == other.QualityStatus &&
		       RawDataId == other.RawDataId &&
		       SequenceId == other.SequenceId &&
		       SequenceIndex == other.SequenceIndex &&
		       Nullable.Equals(ShotDate, other.ShotDate) &&
		       Status == other.Status &&
		       string.Equals(Storage, other.Storage, StringComparison.InvariantCulture) &&
		       To == other.To &&
		       UnwrapVersion == other.UnwrapVersion &&
		       VideoId == other.VideoId &&
		       VideoIndex == other.VideoIndex &&
		       Visibility == other.Visibility &&
		       WayId == other.WayId &&
		       Width == other.Width &&
		       WrapVersion == other.WrapVersion;
	}

	/// <inheritdoc />
	public override bool Equals(object? obj)
	{
		return ReferenceEquals(this, obj) || (obj is PhotoData other && Equals(other));
	}

	/// <inheritdoc />
	public override int GetHashCode()
	{
		var hashCode = new HashCode();
		hashCode.Add((int?)AutoImgProcessingResult);
		hashCode.Add(AutoImgProcessingStatus, StringComparer.InvariantCulture);
		hashCode.Add(CameraParameters);
		hashCode.Add(DateAdded);
		hashCode.Add(DateProcessed);
		hashCode.Add(Distance);
		hashCode.Add(FieldOfView);
		hashCode.Add(Filepath, StringComparer.InvariantCulture);
		hashCode.Add(FilepathLTh, StringComparer.InvariantCulture);
		hashCode.Add(FilepathProc, StringComparer.InvariantCulture);
		hashCode.Add(FilepathTh, StringComparer.InvariantCulture);
		hashCode.Add(Fileurl?.ToString(), StringComparer.InvariantCulture);
		hashCode.Add(FileurlLTh?.ToString(), StringComparer.InvariantCulture);
		hashCode.Add(FileurlProc?.ToString(), StringComparer.InvariantCulture);
		hashCode.Add(FileurlTh?.ToString(), StringComparer.InvariantCulture);
		hashCode.Add(From);
		hashCode.Add(GpsAccuracy);
		hashCode.Add(HasObd);
		hashCode.Add(Headers);
		hashCode.Add(Heading);
		hashCode.Add(Height);
		hashCode.Add(Id);
		hashCode.Add((int)ImagePartProjection);
		hashCode.Add(IsUnwrapped);
		hashCode.Add(IsWrapped);
		hashCode.Add(Latitude);
		hashCode.Add(Longitude);
		hashCode.Add(MatchLat);
		hashCode.Add(MatchLng);
		hashCode.Add(MatchSegmentId);
		hashCode.Add(Name, StringComparer.InvariantCulture);
		hashCode.Add(OrgCode, StringComparer.InvariantCulture);
		hashCode.Add((int)Projection);
		hashCode.Add(ProjectionYaw);
		hashCode.Add(QualityDetails.Aggregate(0, HashCode.Combine));
		hashCode.Add(QualityLevel, StringComparer.InvariantCulture);
		hashCode.Add((int)QualityStatus);
		hashCode.Add(RawDataId);
		hashCode.Add(SequenceId);
		hashCode.Add(SequenceIndex);
		hashCode.Add(ShotDate);
		hashCode.Add((int)Status);
		hashCode.Add(Storage, StringComparer.InvariantCulture);
		hashCode.Add(To);
		hashCode.Add(UnwrapVersion);
		hashCode.Add(VideoId);
		hashCode.Add(VideoIndex);
		hashCode.Add((int)Visibility);
		hashCode.Add(WayId);
		hashCode.Add(Width);
		hashCode.Add(WrapVersion);
		return hashCode.ToHashCode();
	}
}