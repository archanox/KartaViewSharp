using KartaViewSharp.V2;
using KartaViewSharp.V2.Request;

namespace KartaView;

internal static class Program
{
	static async Task Main()
	{
			const int sequenceId = 7068281;

			//Initialize the API client
			var apiClient = new Client();

			// Make the API request
			var result = await apiClient.RetrievePhotos(new PhotoQueryFilters
			{
				SequenceId = sequenceId
			});

			// Process the result
			Console.WriteLine(result.Result.Data.FirstOrDefault()?.Name);

			var result2 = await apiClient.RetrieveSequences(new SequenceQueryFilters()
			{
				Id = [sequenceId]
			});

			Console.WriteLine(result2.Result.Data.FirstOrDefault()?.Address);

			var client = new KartaViewSharp.V1.Client();

			var userDetails = await client.GetUserDetails("Pierce");
			Console.WriteLine(userDetails.Data.FullName);
		}
}