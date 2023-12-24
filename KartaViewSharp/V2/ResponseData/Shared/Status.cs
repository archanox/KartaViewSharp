using System.Net;
using System.Text.Json.Serialization;

namespace KartaViewSharp.V2.ResponseData.Shared;

public class ResponseStatus
{
    /// <summary>
    /// API Code
    /// </summary>
    [JsonPropertyName("apiCode")]
    public int ApiCode { get; set; }

    /// <summary>
    /// API Message
    /// </summary>
    [JsonPropertyName("apiMessage")]
    public string ApiMessage { get; set; }

    /// <summary>
    /// HTTP Response Code
    /// </summary>
    [JsonPropertyName("httpCode")]
    public HttpStatusCode HttpCode { get; set; }

    /// <summary>
    /// HTTP Response Message
    /// </summary>
    [JsonPropertyName("httpMessage")]
    public string HttpMessage { get; set; }
}