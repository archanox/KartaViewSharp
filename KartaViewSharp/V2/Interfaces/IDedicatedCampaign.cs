using KartaViewSharp.V2.ResponseData;

namespace KartaViewSharp.V2.Interfaces;

public interface IDedicatedCampaign
{
    Task<SequenceResponse> RetrieveDedicatedCampaigns();

    Task<SequenceResponse> CreateANewDedicatedCampaign();

    Task<SequenceResponse> UpdateTheDetailsOfADedicatedCampaign();

    Task<SequenceResponse> GetTheDetailsOfADedicatedCampaign();

    Task<SequenceResponse> DeleteADedicatedCampaign();

    Task<SequenceResponse> RetrieveTheCellsOfADedicatedCampaign();

    Task<SequenceResponse> CreateANewDedicatedCampaignCell();

    Task<SequenceResponse> UpdateTheDetailsOfADedicatedCampaignCell();

    Task<SequenceResponse> GetTheDetailsOfADedicatedCampaignCell();

    Task<SequenceResponse> DeleteADedicatedCampaignCell();

    Task<SequenceResponse> RetrieveIntervalMetricsUsedForDashboardCharts();
}