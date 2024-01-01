using System.Text.Json.Serialization;
using ISO3166;
using KartaViewSharp.Common.Converters;

namespace KartaViewSharp.V1.Response.Resources.UserDetails;

public sealed class Region
{
    [JsonPropertyName("points")]
    [JsonConverter(typeof(StringAsIntJsonConverter))]
    public int Points { get; set; }

    [JsonPropertyName("country_code")]
    [JsonConverter(typeof(StringAsNullableCountryJsonConverter))]
    public Country? CountryCode { get; set; }

    [JsonPropertyName("rank")]
    public int Rank { get; set; }
}