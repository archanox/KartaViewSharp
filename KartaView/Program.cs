using KartaViewSharp;

namespace KartaView
{
	internal class Program
	{
		static async Task Main()
		{
			// Initialize the API client
			var apiClient = new Client();

			// Create filters
			var filters = new QueryFilters
			{
				Filter1 = "Value1",
				// Add other filter values as needed
			};

			// Make the API request
			var result = await apiClient.GetKartaViewData(filters);

			// Process the result
			Console.WriteLine(result);
		}
	}
}
