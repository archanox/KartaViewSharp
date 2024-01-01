using System.Text.Json.Serialization;
using KartaViewSharp.Common.Response;

namespace KartaViewSharp.V1.Response.Resources.Authentication;

public sealed class AuthenticationResponse
{
    [JsonPropertyName("status")]
    public ResponseStatus Status { get; set; }

    [JsonPropertyName("osv")]
    public AuthenticationData Data { get; set; }
}