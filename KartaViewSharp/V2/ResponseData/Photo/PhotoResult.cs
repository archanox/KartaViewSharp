using KartaViewSharp.V2.ResponseData.Sequence;
using NetTopologySuite.Geometries;
using System.Text.Json.Serialization;
using KartaViewSharp.V2.ResponseData.Photo;

namespace KartaViewSharp.V2.ResponseData;

public sealed class PhotoResult
{
	[JsonPropertyName("data")]
	public PhotoData[] Data { get; set; }

	/// <summary>
	/// In case there is more data to retrieve (records count &lt;= itemsPerPage), the property will return true.
	/// </summary>
	[JsonPropertyName("hasMoreData")]
	public bool HasMoreData { get; set; }
}