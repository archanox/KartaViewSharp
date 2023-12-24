using System.Text.Json.Serialization;
using KartaViewSharp.V2.ResponseData.Shared;

namespace KartaViewSharp.V2.ResponseData;

public sealed class PhotoResponse
{
	[JsonPropertyName("status")]
	public ResponseStatus Status { get; set; }

	[JsonPropertyName("result")]
	public PhotoResult Result { get; set; }
}

[JsonSerializable(typeof(PhotoResponse), GenerationMode = JsonSourceGenerationMode.Metadata)]
public partial class PhotoResponseContext : JsonSerializerContext
{
}