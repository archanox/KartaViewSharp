using System.Text.Json.Serialization;
using KartaViewSharp.V1.Response.Resources.Authentication;

namespace KartaViewSharp.V1;

[JsonSerializable(typeof(AuthenticationResponse), GenerationMode = JsonSourceGenerationMode.Metadata)]
public partial class AuthenticationResponseContext : JsonSerializerContext
{
}