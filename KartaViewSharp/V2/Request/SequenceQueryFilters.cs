using ISO3166;
using KartaViewSharp.V2.Enums;
using NetTopologySuite.Geometries;

namespace KartaViewSharp.V2.Request;

public sealed class SequenceQueryFilters : QueryFilters
{
	/// <summary>
	/// Unique identifier of an user entity.
	/// </summary>
	public string[] UserIds { get; set; }

	/// <summary>
	/// Top,Left coordinates for the bounding box.
	/// </summary>
	public Coordinate? TopLeft { get; set; }

	/// <summary>
	/// Bottom,Right coordinates for the bounding box.
	/// </summary>
	public Coordinate? BottomRight { get; set; }

	/// <summary>
	/// Retrieve all sequences that have attachments.
	/// </summary>
	public bool? WithAttachments { get; set; }

	/// <summary>
	/// Example: withPhotos=true
	/// Retrieve all sequences that have photos.
	/// </summary>
	public bool? WithPhotos { get; set; }

	/// <summary>
	/// Default: null
	/// Example: countryCode=US
	/// Country Code initials, ISO-2 format.
	/// </summary>
	public Country? CountryCode { get; set; }

	/// <summary>
	/// The starting point of the date interval.
	/// </summary>
	public DateTime? StartDate { get; set; }

	/// <summary>
	/// The ending point of the date interval.
	/// </summary>
	public DateTime? EndDate { get; set; }

	/// <summary>
	/// The status of the sequence.
	/// </summary>
	public SequenceStatus? SequenceStatus { get; set; }

	/// <summary>
	/// The platform of the device that recorded the file.
	/// </summary>
	public Platform? Platform { get; set; }

	/// <summary>
	/// Type of the user.
	/// </summary>
	public UserType? UserType { get; set; }

	/// <summary>
	/// Type of the sequence.
	/// </summary>
	public SequenceType? SequenceType { get; set; }

	/// <summary>
	/// Unique identifier representing a specific region. Multiple regions can be provided.
	/// </summary>
	public Region[]? Region { get; set; }

	/// <summary>
	/// Default: "null"
	/// Example: join=user,photo
	/// Join resources to bring extra details about another resource, available joinable resource: user, photo, photos, attachment, attachments.
	/// </summary>
	public SequenceJoinResource[]? Join { get; set; }
}

public enum SequenceJoinResource
{
	User = 1,
	Photo = 2,
	Photos = 3,
	Attachment = 4,
	Attachments = 5,
}