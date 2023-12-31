using System.Text.Json.Serialization;
using KartaViewSharp.V1.Response.Resources.UserDetails;

namespace KartaViewSharp.V1;

[JsonSerializable(typeof(UserDetailsResponse), GenerationMode = JsonSourceGenerationMode.Metadata)]
public partial class UserDetailsResponseContext : JsonSerializerContext
{
}