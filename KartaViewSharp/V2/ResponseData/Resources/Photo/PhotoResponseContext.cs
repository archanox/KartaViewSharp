using System.Text.Json.Serialization;
using KartaViewSharp.V2.ResponseData.Resources.Photo;

namespace KartaViewSharp.V2.ResponseData;

[JsonSerializable(typeof(PhotoResponse), GenerationMode = JsonSourceGenerationMode.Metadata)]
public partial class PhotoResponseContext : JsonSerializerContext
{
}