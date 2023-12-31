using System.Text.Json;
using System.Text.Json.Serialization;
using KartaViewSharp.Common;
using KartaViewSharp.V2.Interfaces;
using KartaViewSharp.V2.Request;
using KartaViewSharp.V2.Response;
using KartaViewSharp.V2.Response.Resources.Photo;
using KartaViewSharp.V2.Response.Resources.Sequence;
using NetTopologySuite.Geometries;
using RestSharp;
using RestSharp.Serializers.Json;

namespace KartaViewSharp.V2
{
	public class Client : ISequence, ISequenceRawData, ISequenceAttachment, ISequenceBreakdown, ISequenceMetrics, IPhoto, IPhotoPart, IVideo, IUser, IUserMetrics, IDedicatedCampaign, IDashboard, ISimulate, IListener
	{
		private const string _baseUri = "https://api.openstreetcam.org/2.0";

		public async Task<SequenceResponse> RetrieveSequences(SequenceQueryFilters filters)
		{
			var client = RestClientUtil.CreateRestClient<SequenceResponseContext>(_baseUri);

			var request = new RestRequest("/sequence/");

			filters.AddSequenceFilters(request);

			var response = await client.ExecuteGetAsync<SequenceResponse>(request);
			return response.Data;
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

		public async Task<SequenceResponse> GetUserTypeMetricIntervalData(UserTypeMetric[] userTypeMetrics, DashboardQueryFilters filters)
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> GetPlatformMetricIntervalData(PlatformMatric[] platformMetrics)
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

		public async Task<SequenceResponse> GetPlatformMetricIntervalData(PhotosCountMetric[] photosCountMetrics)
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

		public async Task<SequenceResponse> RetrieveSequences()
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> GetTheDetailsOfAUser(int dashboardUserId)
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

		public async Task<SequenceResponse> RetrieveIssues()
		{
			throw new NotImplementedException();
		}

		public async Task<SequenceResponse> GetTheDetailsOfARegion(int dashboardRegionId)
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

		public async Task<PhotoResponse> RetrievePhotos(PhotoQueryFilters filters)
		{
			if (filters.Id == null && filters.IdInterval == null && filters.SequenceId == null && filters.Location == null)
			{
				throw new ArgumentNullException("Restricted access on GET list if there isn't at least one query parameter provided from the following: id, idInterval, sequenceId, lat and lng.");
			}

			var client = RestClientUtil.CreateRestClient<PhotoResponseContext>(_baseUri);

			var request = new RestRequest("/photo/");

			filters.AddPhotoFilters(request);

			var response = await client.ExecuteGetAsync<PhotoResponse>(request);
			return response.Data;
		}

		public async Task<PhotoResponse> CreateANewPhoto(string authToken)
		{
			throw new NotImplementedException();
		}

		public async Task<PhotoResponse> GetTheDetailsOfAPhoto(int photoId)
		{
			throw new NotImplementedException();
		}

		public async Task<PhotoResponse> UpdateTheDetailsOfAPhoto(int photoId, string authToken)
		{
			throw new NotImplementedException();
		}

		public async Task<PhotoResponse> DeleteAPhoto(int photoId)
		{
			throw new NotImplementedException();
		}

		public async Task<PhotoResponse> RetrieveAllPhotoPartsBasedOnThePhotoId(int photoId)
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
