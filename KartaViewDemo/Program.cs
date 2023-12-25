using KartaViewSharp.V2;
using KartaViewSharp.V2.RequestData;

namespace KartaView
{
	internal static class Program
	{
		static async Task Main()
		{
			// Initialize the API client
			var apiClient = new Client();

			// Create filters
			var filters = new PhotoQueryFilters()
			{
				SequenceId = 7068281
			};

			// Make the API request
			var result = await apiClient.RetrievePhotos(filters);

			// Process the result
			Console.WriteLine(result.Result.Data.FirstOrDefault()?.Name);
		}
	}
}
