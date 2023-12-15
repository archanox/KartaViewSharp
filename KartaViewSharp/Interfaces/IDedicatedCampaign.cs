using KartaViewSharp.ResponseData;

namespace KartaViewSharp.Interfaces;

public interface IDedicatedCampaign
{
	Task<Response> RetrieveDedicatedCampaigns();

	Task<Response> CreateANewDedicatedCampaign();

	Task<Response> UpdateTheDetailsOfADedicatedCampaign();

	Task<Response> GetTheDetailsOfADedicatedCampaign();

	Task<Response> DeleteADedicatedCampaign();

	Task<Response> RetrieveTheCellsOfADedicatedCampaign();

	Task<Response> CreateANewDedicatedCampaignCell();

	Task<Response> UpdateTheDetailsOfADedicatedCampaignCell();

	Task<Response> GetTheDetailsOfADedicatedCampaignCell();

	Task<Response> DeleteADedicatedCampaignCell();

	Task<Response> RetrieveIntervalMetricsUsedForDashboardCharts();
}