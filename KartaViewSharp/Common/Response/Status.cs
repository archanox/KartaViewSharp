using KartaViewSharp.Common.Converters;
using System.Net;
using System.Text.Json.Serialization;

namespace KartaViewSharp.Common.Response;

public class ResponseStatus
{
    /// <summary>
    /// API Code
    /// </summary>
    [JsonPropertyName("apiCode")]
    [JsonConverter(typeof(StringAsIntJsonConverter))]
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