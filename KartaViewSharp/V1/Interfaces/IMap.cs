using NetTopologySuite.Geometries;

namespace KartaViewSharp.V1.Interfaces;

/// <summary>
/// Map methods provide access to information and operations relating to the map.
/// All the uploaded sequences are maped to the map's segments.
/// So each map's segement belongs to one or multiple sequences.
/// </summary>
public interface IMap
{
	/// <summary>
	/// Get list of nearby sequences, in radius of specified distance and location.
	/// </summary>
	/// <param name="location"></param>
	/// <returns></returns>
	Task<object> NearbySequences(Coordinate location);

	/// <summary>
	/// Returns the nearby photos of a specified location and radius distance.
	/// </summary>
	/// <param name="location"></param>
	/// <param name="radius"></param>
	/// <returns></returns>
	Task<object> GetNearbyPhotos(Coordinate location, double radius);

    /// <summary>
    /// All sequences are mapped to the map's segments.
    /// This method is used to display all the matched segments on the map.
    /// Each segment is represented by its geometry(a list of geolocations).
    /// </summary>
    /// <param name="bbTopLeft">Boundig box's top-left corner coordinates. ('lat,lng' Format)</param>
    /// <param name="bbBottomRight">Boundig box's bottom-right corner coordinates. ('lat,lng' Format)</param>
    /// <returns></returns>
    Task<object> MatchedTracks(Coordinate bbTopLeft, Coordinate bbBottomRight);
}