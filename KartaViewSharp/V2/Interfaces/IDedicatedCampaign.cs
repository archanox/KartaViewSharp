using KartaViewSharp.V2.ResponseData;

namespace KartaViewSharp.V2.Interfaces;

public interface IDedicatedCampaign
{
    Task<SequenceResponse> RetrieveDedicatedCampaigns();

    Task<SequenceResponse> CreateANewDedicatedCampaign(string authToken);

    Task<SequenceResponse> UpdateTheDetailsOfADedicatedCampaign(int dedicatedCampaignId, string authToken);

    Task<SequenceResponse> GetTheDetailsOfADedicatedCampaign(int dedicatedCampaignId);

    Task<SequenceResponse> DeleteADedicatedCampaign(int dedicatedCampaignId);

    Task<SequenceResponse> RetrieveTheCellsOfADedicatedCampaign(int dedicatedCampaignId);

    Task<SequenceResponse> CreateANewDedicatedCampaignCell(string authToken);

    Task<SequenceResponse> UpdateTheDetailsOfADedicatedCampaignCell(int dedicatedCampaignCellId, string authToken);

    Task<SequenceResponse> GetTheDetailsOfADedicatedCampaignCell(int dedicatedCampaignCellId);

    Task<SequenceResponse> DeleteADedicatedCampaignCell(int dedicatedCampaignCellId);

    Task<SequenceResponse> RetrieveIntervalMetricsUsedForDashboardCharts(int dedicatedCampaignId);
}