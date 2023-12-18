using System.Text.Json;
using System.Text.Json.Serialization;
using KartaViewSharp.V2.Interfaces;
using KartaViewSharp.V2.ResponseData;
using NetTopologySuite.Geometries;
using RestSharp;
using RestSharp.Serializers.Json;

namespace KartaViewSharp.V2
{
	public class Client : ISequence, ISequenceRawData, ISequenceAttachment, ISequenceBreakdown, ISequenceMetrics, IPhoto, IPhotoPart, IVideo, IUser, IUserMetrics, IDedicatedCampaign, IDashboard, ISimulate, IListener
	{
		private const string _baseUri = "https://api.openstreetcam.org/2.0";

		private static void AddFilters(SequenceQueryFilters filters, RestRequest request)
		{
			if (filters.Id?.Length > 0)
				request.AddQueryParameter("id", string.Join(',', filters.Id));

			if (filters.IdInterval.HasValue)
				request.AddQueryParameter("idInterval", $"{filters.IdInterval.Value.Start}-{filters.IdInterval.Value.End}");

			if (filters.Page.HasValue)
				request.AddQueryParameter("page", filters.Page.Value);

			if (filters.ItemsPerPage != 40)
				request.AddQueryParameter("itemsPerPage", filters.ItemsPerPage);

			if (!string.IsNullOrWhiteSpace(filters.OrderBy))
				request.AddQueryParameter("orderBy", filters.OrderBy);

			if (filters.OrderDirection == OrderDirection.Descending)
				request.AddQueryParameter("orderDirection", "desc");

			if (filters.Units == Units.Imperial)
				request.AddQueryParameter("units", "imperial");

			if (filters.Join is { Length: > 0 })
				request.AddQueryParameter("join", string.Join(',', filters.Join));

			if (filters.UserIds is { Length: > 0 })
				request.AddQueryParameter("userId", string.Join(',', filters.UserIds));

			if (filters.TopLeft is { IsValid: true })
				request.AddQueryParameter("tLeft", filters.TopLeft.X + ',' + filters.TopLeft.Y);

			if (filters.BottomRight is { IsValid: true })
				request.AddQueryParameter("bRight", filters.BottomRight.X + ',' + filters.BottomRight.Y);

			if (filters.WithAttachments.HasValue)
				request.AddQueryParameter("withAttachments", filters.WithAttachments.Value);

			if (filters.WithPhotos.HasValue)
				request.AddQueryParameter("withPhotos", filters.WithPhotos.Value);

			if (filters.CountryCode != null)
				request.AddQueryParameter("countryCode", filters.CountryCode.TwoLetterCode);

			if (filters.StartDate != null)
				request.AddQueryParameter("startDate", filters.StartDate.Value);

			if (filters.EndDate != null)
				request.AddQueryParameter("endDate", filters.EndDate.Value);

			if (filters.SequenceStatus != null)
			{
				var sequenceStatus = filters.SequenceStatus switch
				{
					SequenceStatus.Public => "public",
					SequenceStatus.Uploading => "uploading",
					SequenceStatus.Processing => "processing",
					SequenceStatus.Failed => "failed",
					SequenceStatus.Deleted => "deleted",
					_ => throw new ArgumentOutOfRangeException(nameof(filters.SequenceStatus))
				};
				request.AddQueryParameter("sequenceStatus", sequenceStatus);
			}

			if (filters.Platform != null)
			{
				var platform = filters.Platform switch
				{
					Platform.IOS => "ios",
					Platform.Android => "android",
					Platform.Waylens => "waylens",
					Platform.GoPro => "gopro",
					Platform.Other => "other",
					_ => throw new ArgumentOutOfRangeException(nameof(filters.Platform))
				};
				request.AddQueryParameter("platform", platform);
			}

			if (filters.UserType != null)
			{
				var userType = filters.UserType switch
				{
					UserType.Regular => "regular",
					UserType.Driver => "driver",
					UserType.Byod => "byod",
					UserType.Dedicated => "dedicated",
					UserType.Internal => "internal",
					_ => throw new ArgumentOutOfRangeException(nameof(filters.UserType))
				};
				request.AddQueryParameter("userType", userType);
			}

			if (filters.SequenceType != null)
			{
				var sequenceType = filters.SequenceType switch
				{
					SequenceType.Vdb => "vdb",
					SequenceType.Video => "video",
					SequenceType.Photo => "photo",
					_ => throw new ArgumentOutOfRangeException(nameof(filters.SequenceType))
				};
				request.AddQueryParameter("sequenceType", sequenceType);
			}

			if (filters.Region is { Length: > 0 })
				request.AddQueryParameter("region", string.Join(',', filters.Region));
		}

		public async Task<SequenceResponse> RetrieveSequences(SequenceQueryFilters filters)
		{
			var client = CreateRestClient<MyJsonContext>();

			var request = new RestRequest("/sequence/");

			AddFilters(filters, request);

			var response = await client.ExecuteGetAsync<SequenceResponse>(request);
			return response.Data;
		}

		private static RestClient CreateRestClient<T>() where T : JsonSerializerContext, new()
		{
			return new RestClient(_baseUri,
				configureSerialization: s => s.UseSystemTextJson(new JsonSerializerOptions
				{
					ReferenceHandler = ReferenceHandler.Preserve,
					TypeInfoResolver = new T()
				}));
		}

		public async Task<SequenceResponse> CreateANewSequence()
		{
			throw new NotImplementedException();
		}

		async Task<SequenceResponse> ISequence.GetTheDetailsOfASequence(int sequenceId)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> UpdateTheDetailsOfASequence(int sequenceId, string authToken)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> DeleteASequence(int sequenceId)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> RetrievePhotosBasedOnTheSequenceId(int sequenceId)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> RetrieveVideosBasedOnTheSequenceId(int sequenceId)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> RetrieveSequenceRawdatasBasedOnSequenceId(int sequenceId)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> RetrieveSequenceAttachmentsBasedOnSequenceId(int sequenceId)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> RetrieveSequenceBreakdownsBasedOnSequenceId(int sequenceId)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> RetrieveSequenceMetricsBasedOnSequenceId(int sequenceId)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> FindAndUpdateSequencesStatusWhenTheUploadIsFinished(int sequenceId)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> GetMapMatchedTracksDataWithDifferentOutput(int tileX, int tileY, int zoomLevel)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> GetAListOfAllTracksBasedOnASpecificBoundingBox(Coordinate topLeft, Coordinate bottomRight, int zoomLevel)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> GetUserTypeMetricIntervalData()
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> GetPlatformMetricIntervalData(PlatformMatric platformMetrics)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> GetUniqueDistanceMetricIntervalData()
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> GetTotalDistanceMetricIntervalData()
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> GetPlatformMetricIntervalData(PhotosCountMetric photosCountMetrics)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> GetMetricsDataBasedOnMetricType()
		{
			throw new NotImplementedException();
		}

		async Task<SequenceResponse> IDashboard.GetTheDetailsOfASequence(int dashboardSequenceId)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> GetTheDetailsOfASequence()
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> RetrieveSequences()
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> GetTheDetailsOfAUser(int dashboardUserId)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> GetTheDetailsOfAUser()
		{
			throw new NotImplementedException();
		}

		async Task<SequenceResponse> IDashboard.RetrieveUsers()
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> GetTheDetailsOfAnIssue(int dashboardIssueId)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> GetTheDetailsOfAnIssue()
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> RetrieveIssues()
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> GetTheDetailsOfARegion(int dashboardRegionId)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> GetTheDetailsOfARegion()
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> RetrieveVisibleRegions()
		{
			throw new NotImplementedException();
		}

		async Task<SequenceResponse> IUser.RetrieveUsers()
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> GetTheDetailsOfAUser(string userId)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> DeleteAUser(string userId)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> GetTheMetricsDetailsOfAUser(string userId)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> DeleteAUser()
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> GetTheMetricsDetailsOfAUser()
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> RetrieveSequenceRawdatas()
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> CreateANewSequenceRawdata(string authToken)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> UpdateTheDetailsOfASequenceRawdata(int sequenceRawDataId, string authToken)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> GetTheDetailsOfASequenceRawdata(int sequenceRawDataId)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> DeleteASequenceRawdata(int sequenceRawDataId)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> RetrieveSequenceAttachments()
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> CreateANewSequenceAttachment(string authToken)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> GetTheDetailsOfASequenceAttachment(int sequenceAttachmentId)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> UpdateTheDetailsOfASequenceAttachment(int sequenceAttachmentId, string authToken)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> DeleteASequenceAttachment(int sequenceAttachementId)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> RetrieveSequenceBreakdowns()
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> GetTheBreakdownDetailsOfASequence(int sequenceId)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> RetrievePhotos()
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> CreateANewPhoto(string authToken)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> GetTheDetailsOfAPhoto(int photoId)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> UpdateTheDetailsOfAPhoto(int photoId, string authToken)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> DeleteAPhoto(int photoId)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> RetrieveAllPhotoPartsBasedOnThePhotoId(int photoId)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> RetrievePhotoParts()
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> CreateANewPhotoPart(string authToken)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> UpdateTheDetailsOfAPhotoPart(int photoPartId, string authToken)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> GetTheDetailsOfAPhotoPart(int photoPartId)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> DeleteAPhotoPart(int photoPartId)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> CreateANewPhotoPart()
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> UpdateTheDetailsOfAPhotoPart()
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> GetTheDetailsOfAPhotoPart()
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> DeleteAPhotoPart()
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> RetrieveVideos()
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> CreateANewVideo(string authToken)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> UpdateTheDetailsOfAVideo(int videoId, string authToken)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> GetTheDetailsOfAVideo(int videoId)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> DeleteAVideo(int videoId)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> GetTheDetailsOfAVideo()
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> DeleteAVideo()
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> GetTheMetricsDetailsOfAUser(int userId)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> RetrieveDedicatedCampaigns()
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> CreateANewDedicatedCampaign(string authToken)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> UpdateTheDetailsOfADedicatedCampaign(int dedicatedCampaignId, string authToken)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> GetTheDetailsOfADedicatedCampaign(int dedicatedCampaignId)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> DeleteADedicatedCampaign(int dedicatedCampaignId)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> RetrieveTheCellsOfADedicatedCampaign(int dedicatedCampaignId)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> CreateANewDedicatedCampaignCell(string authToken)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> UpdateTheDetailsOfADedicatedCampaignCell(int dedicatedCampaignCellId, string authToken)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> GetTheDetailsOfADedicatedCampaignCell(int dedicatedCampaignCellId)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> DeleteADedicatedCampaignCell(int dedicatedCampaignCellId)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> RetrieveIntervalMetricsUsedForDashboardCharts(int dedicatedCampaignId)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> CreateANewDedicatedCampaign()
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> UpdateTheDetailsOfADedicatedCampaign()
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> GetTheDetailsOfADedicatedCampaign()
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> DeleteADedicatedCampaign()
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> RetrieveTheCellsOfADedicatedCampaign()
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> CreateANewDedicatedCampaignCell()
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> UpdateTheDetailsOfADedicatedCampaignCell()
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> GetTheDetailsOfADedicatedCampaignCell()
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> DeleteADedicatedCampaignCell()
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> RetrieveIntervalMetricsUsedForDashboardCharts()
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> TestTheBlurImagesFunctionalityIncludingTheApolloDetectionsPipeline()
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> TestTheBlurImagesFunctionalityIgnoringDetections()
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> NotifyApolloWhenASequenceHasBeenProcessed()
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> CreateTasksToBlurPhotosWhenDetectionsArePresent()
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> RetrieveMaintenances()
		{
			throw new NotImplementedException();
		}
	}
}
