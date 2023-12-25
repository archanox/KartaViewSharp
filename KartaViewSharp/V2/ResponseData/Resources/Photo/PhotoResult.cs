using System.Text.Json.Serialization;

namespace KartaViewSharp.V2.ResponseData.Resources.Photo;

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