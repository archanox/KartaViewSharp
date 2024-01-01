using System.Text.Json.Serialization;
using KartaViewSharp.Common.Converters;

namespace KartaViewSharp.V1.Response.Resources.UserDetails;

public sealed class Gamification
{
    [JsonPropertyName("total_user_points")]
    [JsonConverter(typeof(StringAsIntJsonConverter))]
    public int TotalUserPoints { get; set; }

    [JsonPropertyName("user_id")]
    [JsonConverter(typeof(StringAsIntJsonConverter))]
    public int UserId { get; set; }

    [JsonPropertyName("rank")]
    public int Rank { get; set; }

    [JsonPropertyName("total_user_waylens_points")]
    [JsonConverter(typeof(StringAsIntJsonConverter))]
    public int TotalUserWaylensPoints { get; set; }

    [JsonPropertyName("rank_weekly")]
    public int RankWeekly { get; set; }

    [JsonPropertyName("level")]
    public int Level { get; set; }

    [JsonPropertyName("level_target")]
    public int LevelTarget { get; set; }

    [JsonPropertyName("level_progress")]
    public int LevelProgress { get; set; }

    [JsonPropertyName("level_progress_percent")]
    public float LevelProgressPercent { get; set; }

    [JsonPropertyName("level_name")]
    public string LevelName { get; set; }

    [JsonPropertyName("region")]
    public Region Region { get; set; }
}