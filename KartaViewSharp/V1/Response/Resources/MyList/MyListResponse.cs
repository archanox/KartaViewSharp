using System.Text.Json.Serialization;
using KartaViewSharp.Common.Response;

namespace KartaViewSharp.V1.Response.Resources.MyList;

public sealed class MyListResponse
{
    [JsonPropertyName("status")]
    public ResponseStatus Status { get; set; }

    [JsonPropertyName("currentPageItems")]
    public CurrentPageItem[] CurrentPageItems { get; set; }

    [JsonPropertyName("totalFilteredItems")]
    public string[] TotalFilteredItems { get; set; }

    [JsonPropertyName("tracksStatus")]
    public TracksStatus TracksStatus { get; set; }
}