using System.Text.Json.Serialization;

namespace KartaViewSharp.V2.ResponseData;

public sealed class QualityDetail
{
	[JsonPropertyName("")]
	public int label { get; set; }

	[JsonPropertyName("")]
	public float confidence { get; set; }

	[JsonPropertyName("")]
	public int presence_level { get; set; }
}