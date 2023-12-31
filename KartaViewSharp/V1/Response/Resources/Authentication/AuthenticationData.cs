using KartaViewSharp.Common.Converters;
using System.Text.Json.Serialization;

namespace KartaViewSharp.V1.Response.Resources.Authentication;

public class AuthenticationData
{
    [JsonPropertyName("access_token")]
    public string AccessToken { get; set; }

    [JsonPropertyName("id")]
    [JsonConverter(typeof(StringAsIntJsonConverter))]
    public int Id { get; set; }

    [JsonPropertyName("username")]
    public string Username { get; set; }

    [JsonPropertyName("full_name")]
    public string FullName { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("externalUserId")]
    [JsonConverter(typeof(StringAsNullableIntJsonConverter))]
    public int? ExternalUserId { get; set; }

    [JsonPropertyName("driver_type")]
    [JsonConverter(typeof(StringAsDriverTypeJsonConverter))]
    public DriverType DriverType { get; set; }

    [JsonPropertyName("role")]
    public string Role { get; set; }
}

public enum DriverType
{
    Dedicated,
    Byod,
    Bau
}