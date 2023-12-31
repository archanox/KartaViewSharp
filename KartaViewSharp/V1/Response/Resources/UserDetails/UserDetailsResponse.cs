using System.Text.Json.Serialization;

namespace KartaViewSharp.V1.Response.Resources.UserDetails;

public class UserDetailsResponse
{
    [JsonPropertyName("status")]
    public Common.Response.ResponseStatus Status { get; set; }

    [JsonPropertyName("osv")]
    public UserDetailsData Data { get; set; }
}