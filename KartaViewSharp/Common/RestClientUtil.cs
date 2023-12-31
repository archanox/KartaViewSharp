using System.Text.Json;
using System.Text.Json.Serialization;
using RestSharp;
using RestSharp.Serializers.Json;

namespace KartaViewSharp.Common;

public abstract class RestClientUtil
{
    internal static RestClient CreateRestClient<T>(string baseUrl) where T : JsonSerializerContext, new()
    {
        return new RestClient(baseUrl,
            configureSerialization: s => s.UseSystemTextJson(new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve,
                TypeInfoResolver = new T()
            }));
    }
}