using KartaViewSharp.Interfaces;
using KartaViewSharp.ResponseData;
using RestSharp;

namespace KartaViewSharp
{
    public class Client : IUser
	{
		private readonly RestClient _client = new("https://api.openstreetcam.org/2.0");

		private static void AddFilters(QueryFilters filters, RestRequest request)
		{
			if (!string.IsNullOrEmpty(filters.Id))
				request.AddQueryParameter("id", filters.Id);
		}

		public Task<Response> RetrieveSequences(QueryFilters filters)
		{
			var request = new RestRequest("/sequence/");

			AddFilters(filters, request);
		}

		public async Task<Response> GetTheDetailsOfAUser(string userId)
		{
			var request = new RestRequest("/user/{userId}");
			request.AddUrlSegment("userId", userId);
			var response = await _client.ExecuteGetAsync<Response>(request);
			return response.Data;
		}
	}
}
