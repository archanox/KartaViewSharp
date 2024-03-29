﻿using KartaViewSharp.Common;
using KartaViewSharp.V2.Enums;
using KartaViewSharp.V2.Interfaces;
using KartaViewSharp.V2.Request;
using KartaViewSharp.V2.Response.Resources.Photo;
using KartaViewSharp.V2.Response.Resources.Sequence;
using NetTopologySuite.Geometries;
using RestSharp;

namespace KartaViewSharp.V2;

public class Client : ISequence,
	ISequenceRawData,
	ISequenceAttachment,
	ISequenceBreakdown,
	ISequenceMetrics,
	IPhoto,
	IPhotoPart,
	IVideo,
	IUser,
	IUserMetrics,
	IDedicatedCampaign,
	IDashboard,
	ISimulate,
	IListener
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

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<SequenceResponse> CreateANewSequence(string authToken)
	{
		throw new NotImplementedException();
	}

	public async Task<SequenceDetailsResponse> GetTheDetailsOfASequence(int sequenceId, SequenceJoinResource[]? join)
	{
		var client = RestClientUtil.CreateRestClient<SequenceDetailsResponseContext>(_baseUri);

		var request = new RestRequest($"/sequence/{sequenceId}");
		request.AddParameter("sequenceId", sequenceId);

		if (join is { Length: > 0 })
		{
			request.AddQueryParameter("join", string.Join(',', join.Select(x => x.ToString().ToLower())));
		}

		var response = await client.ExecuteGetAsync<SequenceDetailsResponse>(request);
		return response.Data;
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<SequenceResponse> UpdateTheDetailsOfASequence(int sequenceId, string authToken)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<SequenceResponse> DeleteASequence(int sequenceId)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<SequenceResponse> RetrievePhotosBasedOnTheSequenceId(int sequenceId)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<SequenceResponse> RetrieveVideosBasedOnTheSequenceId(int sequenceId)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<SequenceResponse> RetrieveSequenceRawdatasBasedOnSequenceId(int sequenceId)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<SequenceResponse> RetrieveSequenceAttachmentsBasedOnSequenceId(int sequenceId)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<SequenceResponse> RetrieveSequenceBreakdownsBasedOnSequenceId(int sequenceId)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<SequenceResponse> RetrieveSequenceMetricsBasedOnSequenceId(int sequenceId)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<SequenceResponse> FindAndUpdateSequencesStatusWhenTheUploadIsFinished(int sequenceId)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<SequenceResponse> GetMapMatchedTracksDataWithDifferentOutput(int tileX, int tileY, int zoomLevel)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<SequenceResponse> GetAListOfAllTracksBasedOnASpecificBoundingBox(Coordinate topLeft, Coordinate bottomRight, int zoomLevel)
	{
		throw new NotImplementedException();
	}
	
	/// <summary>
	/// 
	/// </summary>
	/// <param name="userTypeMetrics">Available metrics for user type. Multiple metrics will be separate by ,. Can be combined with other metric types in the same request.</param>
	/// <param name="filters"></param>
	/// <returns></returns>
	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> GetUserTypeMetricIntervalData(UserTypeMetric[] userTypeMetrics, DashboardQueryFilters filters)
	{
		throw new NotImplementedException();
	}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="platformMetrics"></param>
	/// <returns></returns>
	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> GetPlatformMetricIntervalData(PlatformMetric[] platformMetrics)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> GetUniqueDistanceMetricIntervalData()
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> GetTotalDistanceMetricIntervalData()
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> GetPlatformMetricIntervalData(PhotosCountMetric[] photosCountMetrics)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> GetMetricsDataBasedOnMetricType()
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	async Task<object> IDashboard.GetTheDetailsOfASequence(int dashboardSequenceId)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> RetrieveSequences()
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> GetTheDetailsOfAUser(int dashboardUserId)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	async Task<object> IDashboard.RetrieveUsers()
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> GetTheDetailsOfAnIssue(int dashboardIssueId)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> RetrieveIssues()
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> GetTheDetailsOfARegion(int dashboardRegionId)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> RetrieveVisibleRegions()
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	async Task<object> IUser.RetrieveUsers()
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> RetrieveSequenceRawdatas()
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> CreateANewSequenceRawdata(string authToken)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> UpdateTheDetailsOfASequenceRawdata(int sequenceRawDataId, string authToken)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> GetTheDetailsOfASequenceRawdata(int sequenceRawDataId)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> DeleteASequenceRawdata(int sequenceRawDataId)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> RetrieveSequenceAttachments()
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> CreateANewSequenceAttachment(string authToken)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> GetTheDetailsOfASequenceAttachment(int sequenceAttachmentId)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> UpdateTheDetailsOfASequenceAttachment(int sequenceAttachmentId, string authToken)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> DeleteASequenceAttachment(int sequenceAttachementId)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> RetrieveSequenceBreakdowns()
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> GetTheBreakdownDetailsOfASequence(int sequenceId)
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

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<PhotoResponse> CreateANewPhoto(string authToken)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<PhotoResponse> GetTheDetailsOfAPhoto(int photoId)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<PhotoResponse> UpdateTheDetailsOfAPhoto(int photoId, string authToken)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<PhotoResponse> DeleteAPhoto(int photoId)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<PhotoResponse> RetrieveAllPhotoPartsBasedOnThePhotoId(int photoId)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> RetrievePhotoParts()
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> CreateANewPhotoPart(string authToken)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> UpdateTheDetailsOfAPhotoPart(int photoPartId, string authToken)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> GetTheDetailsOfAPhotoPart(int photoPartId)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> DeleteAPhotoPart(int photoPartId)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> RetrieveVideos()
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> CreateANewVideo(string authToken)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> UpdateTheDetailsOfAVideo(int videoId, string authToken)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> GetTheDetailsOfAVideo(int videoId)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> DeleteAVideo(int videoId)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> GetTheMetricsDetailsOfAUser(int userId)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> RetrieveDedicatedCampaigns()
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> CreateANewDedicatedCampaign(string authToken)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> UpdateTheDetailsOfADedicatedCampaign(int dedicatedCampaignId, string authToken)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> GetTheDetailsOfADedicatedCampaign(int dedicatedCampaignId)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> DeleteADedicatedCampaign(int dedicatedCampaignId)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> RetrieveTheCellsOfADedicatedCampaign(int dedicatedCampaignId)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> CreateANewDedicatedCampaignCell(string authToken)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> UpdateTheDetailsOfADedicatedCampaignCell(int dedicatedCampaignCellId, string authToken)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> GetTheDetailsOfADedicatedCampaignCell(int dedicatedCampaignCellId)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> DeleteADedicatedCampaignCell(int dedicatedCampaignCellId)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> RetrieveIntervalMetricsUsedForDashboardCharts(int dedicatedCampaignId)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> TestTheBlurImagesFunctionalityIncludingTheApolloDetectionsPipeline()
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> TestTheBlurImagesFunctionalityIgnoringDetections()
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> NotifyApolloWhenASequenceHasBeenProcessed()
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> CreateTasksToBlurPhotosWhenDetectionsArePresent()
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	public async Task<object> RetrieveMaintenances()
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	Task<object> IUser.GetTheDetailsOfAUser(int userId)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	Task<object> IUser.DeleteAUser(int userId)
	{
		throw new NotImplementedException();
	}

	/// <exception cref="NotImplementedException">Not currently implemented</exception>
	Task<object> IUser.GetTheMetricsDetailsOfAUser(int userId)
	{
		throw new NotImplementedException();
	}
}