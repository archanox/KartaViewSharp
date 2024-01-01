using KartaViewSharp.Common.Converters;
using System.Text.Json.Serialization;

namespace KartaViewSharp.V1.Response.Resources.MyList;

public sealed class Coverage
{
    [JsonPropertyName("coverage_value")]
    public string CoverageValue { get; set; }

    [JsonPropertyName("coverage_distance")]
    [JsonConverter(typeof(StringAsDoubleJsonConverter))]
    public double CoverageDistance { get; set; }

    [JsonPropertyName("coverage_points")]
    [JsonConverter(typeof(StringAsIntJsonConverter))]
    public int CoveragePoints { get; set; }

    [JsonPropertyName("coverage_photos_count")]
    [JsonConverter(typeof(StringAsIntJsonConverter))]
    public int CoveragePhotosCount { get; set; }
}