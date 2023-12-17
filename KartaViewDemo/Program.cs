using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using KartaViewSharp.V2;
using KartaViewSharp.V2.ResponseData;

namespace KartaView
{
	internal class Program
	{
		static async Task Main()
		{
	//		var testJson = @"{
	//""status"": {
	//			""apiCode"": 600,
 //       ""apiMessage"": ""The request has been processed without incidents"",
 //       ""httpCode"": 200,
 //       ""httpMessage"": ""Success""

	//},
 //   ""result"": {
	//			""data"": [
		
	//		{
	//				""address"": ""7 Waverley Road, Lara Victoria 3212, Australia"",
 //               ""appVersion"": ""4.9.1 2"",
 //               ""blurBuild"": ""0"",
 //               ""blurVersion"": ""v1"",
 //               ""cameraParameters"": {
	//					""fLen"": 5.0999999999999996,
 //                   ""aperture"": 1.6000000238418579,
 //                   ""hFoV"": 67.096040000000002,
 //                   ""vFoV"": 52.884028865180774

	//			},
 //               ""clientTotal"": ""4395"",
 //               ""countActivePhotos"": ""484"",
 //               ""countMetadataPhotos"": ""484"",
 //               ""countMetadataVideos"": ""10"",
 //               ""countryCode"": ""AU"",
 //               ""currentLat"": ""-38.023705"",
 //               ""currentLng"": ""144.409032"",
 //               ""dateAdded"": ""2023-04-06 04:16:15"",
 //               ""dateProcessed"": ""2023-04-06 04:36:51"",
 //               ""deviceName"": ""iPhone13,4"",
 //               ""distance"": ""4.61"",
 //               ""fieldOfView"": null,
 //               ""hasRawData"": ""0"",
 //               ""id"": ""7068281"",
 //               ""imageProcessingStatus"": ""PROCESSING_FINISHED"",
 //               ""isVideo"": ""1"",
 //               ""matchStatus"": ""FINISHED"",
 //               ""matched"": null,
 //               ""metaDataFilename"": ""7068281_b2827_642e478f3681f.txt"",
 //               ""metadataFilePath"": ""2023/4/6/7068281_b2827_642e478f3681f.txt"",
 //               ""metadataFileUrl"": ""https://storage13.openstreetcam.org/files/photo/2023/4/6/7068281_b2827_642e478f3681f.txt"",
 //               ""metadataStatus"": ""FINISHED"",
 //               ""nwLat"": ""-38.018144"",
 //               ""nwLng"": ""144.406030"",
 //               ""obdInfo"": null,
 //               ""orgCode"": ""CMNT"",
 //               ""platformName"": ""iOS"",
 //               ""platformVersion"": ""16.5"",
 //               ""processingStatus"": ""FINISHED"",
 //               ""quality"": null,
 //               ""qualityStatus"": ""NEW"",
 //               ""seLat"": ""-38.024748"",
 //               ""seLng"": ""144.418275"",
 //               ""sequenceType"": ""video"",
 //               ""stateCode"": ""victoria,lara"",
 //               ""status"": ""active"",
 //               ""storage"": ""storage13"",
 //               ""uploadSource"": ""iPhone13,4"",
 //               ""uploadStatus"": ""FINISHED"",
 //               ""userId"": ""304""
		
	//		}
 //       ],
 //       ""hasMoreData"": false

	//}
	//	}";

	//		JsonSerializerOptions options = new()
	//		{
	//			ReferenceHandler = ReferenceHandler.Preserve,
	//		};

	//		// Use your custom options to initialize a context instance.
	//		MyJsonContext context = new(options);

	//		var json = JsonSerializer.Deserialize(testJson, context.SequenceResponse);

	//		var test = System.Text.Json.JsonSerializer.Deserialize<SequenceResult>(testJson, jsonTypeInfo: JsonTypeInfo.CreateJsonTypeInfo<SequenceResult>(new JsonSerializerOptions()));


			// Initialize the API client
			var apiClient = new Client();

			// Create filters
			var filters = new SequenceQueryFilters
			{
				Id = new[] { 7068281 }
			};

			// Make the API request
			var result = await apiClient.RetrieveSequences(filters);

			// Process the result
			Console.WriteLine(result.Result.Data.FirstOrDefault()?.Address);
		}
	}
}
