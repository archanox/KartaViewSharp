using System.Text.Json.Serialization;

namespace KartaViewSharp.ResponseData;

public class Result
{
	[JsonPropertyName("data")]
	public Data Data { get; set; }
}