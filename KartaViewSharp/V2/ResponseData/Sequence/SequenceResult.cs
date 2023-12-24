using System.Text.Json;
using System;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace KartaViewSharp.V2.ResponseData.Sequence;

public sealed class SequenceResult
{
    [JsonPropertyName("data")]
    public SequenceData[] Data { get; set; }

    /// <summary>
    /// In case there is more data to retrieve (records count &lt;= itemsPerPage), the property will return true.
    /// </summary>
    [JsonPropertyName("hasMoreData")]
    public bool HasMoreData { get; set; }
}