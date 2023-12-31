using System.Text.Json.Serialization;
using KartaViewSharp.V1.Response.Resources.MyList;

namespace KartaViewSharp.V1;

[JsonSerializable(typeof(MyListResponse), GenerationMode = JsonSourceGenerationMode.Metadata)]
public partial class MyListResponseContext : JsonSerializerContext
{
}