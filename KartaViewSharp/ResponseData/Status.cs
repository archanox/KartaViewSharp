using System.Text.Json.Serialization;

namespace KartaViewSharp.ResponseData;

public class Status
{
	[JsonPropertyName("apiCode")]
	public int ApiCode { get; set; }

	[JsonPropertyName("apiMessage")]
	public string ApiMessage { get; set; }

	[JsonPropertyName("httpCode")]
	public int HttpCode { get; set; }

	[JsonPropertyName("httpMessage")]
	public string HttpMessage { get; set; }

	[JsonPropertyName("executionTime")]
	public TimeSpan ExecutionTime { get; set; }
}