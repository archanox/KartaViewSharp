using System.Text.Json.Serialization;

namespace KartaViewSharp.V2.Response.Resources.Photo;

[JsonSerializable(typeof(PhotoResponse), GenerationMode = JsonSourceGenerationMode.Metadata)]
public partial class PhotoResponseContext : JsonSerializerContext
{
}