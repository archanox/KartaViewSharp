using System.Text.Json.Serialization;
using KartaViewSharp.Common.Converters;
using KartaViewSharp.V1.Enums;

namespace KartaViewSharp.V1.Response.Resources.UserDetails;

public sealed class UserDetailsData
{
    [JsonPropertyName("username")]
    public string Username { get; set; }

    [JsonPropertyName("full_name")]
    public string FullName { get; set; }

    [JsonPropertyName("id")]
    [JsonConverter(typeof(StringAsIntJsonConverter))]
    public int Id { get; set; }

    [JsonPropertyName("driver_type")]
    [JsonConverter(typeof(StringAsDriverTypeJsonConverter))]
    public DriverType DriverType { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("totalDistance")]
    [JsonConverter(typeof(StringAsDoubleJsonConverter))]
    public double TotalDistance { get; set; }

    [JsonPropertyName("totalWaylensDistance")]
    public int TotalWaylensDistance { get; set; }

    [JsonPropertyName("obdDistance")]
    public int ObdDistance { get; set; }

    [JsonPropertyName("totalPhotos")]
    [JsonConverter(typeof(StringAsIntJsonConverter))]
    public int TotalPhotos { get; set; }

    [JsonPropertyName("overallRank")]
    public int OverallRank { get; set; }

    [JsonPropertyName("totalTracks")]
    [JsonConverter(typeof(StringAsIntJsonConverter))]
    public int TotalTracks { get; set; }

    [JsonPropertyName("weeklyRank")]
    public int WeeklyRank { get; set; }

    [JsonPropertyName("gamification")]
    public Gamification Gamification { get; set; }
}