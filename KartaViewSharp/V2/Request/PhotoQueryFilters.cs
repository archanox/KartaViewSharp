using KartaViewSharp.V2.Enums;
using NetTopologySuite.Geometries;

namespace KartaViewSharp.V2.Request;

public sealed class PhotoQueryFilters : QueryFilters
{
	/// <summary>
	/// Unique identifier representing a specific sequence.
	/// </summary>
	public int? SequenceId { get; set; }

	/// <summary>
	/// Identifier representing a specific image index.
	/// </summary>
	public int? SequenceIndex { get; set; }

	/// <summary>
	/// Enum: "photo" "video" "vdb"
	/// Example: searchSequenceType=vdb
	/// Type of the sequence. Used only for findNearbyPhotos functionality.
	/// </summary>
	public SequenceType? SearchSequenceType { get; set; }

	/// <summary>
	/// The platform of the device that recorded the file. Used only for findNearbyPhotos functionality.
	/// </summary>
	public Platform? SearchPlatform { get; set; }

	/// <summary>
	/// The field of view type. Used only for findNearbyPhotos functionality.
	/// </summary>
	public FieldOfView? SearchFieldOfView { get; set; }

	/// <summary>
	/// Unique identifier of an user entity.
	/// </summary>
	public string[] UserIds { get; set; }

	/// <summary>
	/// Identifier representing a specific video index.
	/// </summary>
	public int? VideoIndex { get; set; }

	/// <summary>
	/// The distortion type of the photo.
	/// </summary>
	public Projection? Projection { get; set; }

	/// <summary>
	/// The projection on yaw axis, horizontal rotation in degrees, min -180, max 180.
	/// </summary>
	public int? ProjectionYaw { get; set; }

	/// <summary>
	/// The field of view type.
	/// </summary>
	public FieldOfView? FieldOfView { get; set; }

	/// <summary>
	/// Coordinates of the photo.
	/// </summary>
	public Coordinate? Location { get; set; }

	/// <summary>
	/// Controls the size of the edges that can be enhanced, where a smaller radius enhances smaller-scale detail.
	/// </summary>
	public string? Radius { get; set; }

	/// <summary>
	/// Value representing zoom level. Default value is 18.
	/// </summary>
	public int? ZoomLevel { get; set; } = 18;

	public PhotoJoinResource[]? Join { get; set; }
}