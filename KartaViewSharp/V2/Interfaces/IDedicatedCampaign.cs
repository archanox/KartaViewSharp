namespace KartaViewSharp.V2.Interfaces;

internal interface IDedicatedCampaign
{
    Task<object> RetrieveDedicatedCampaigns();

    Task<object> CreateANewDedicatedCampaign(string authToken);

    Task<object> UpdateTheDetailsOfADedicatedCampaign(int dedicatedCampaignId, string authToken);

    Task<object> GetTheDetailsOfADedicatedCampaign(int dedicatedCampaignId);

    Task<object> DeleteADedicatedCampaign(int dedicatedCampaignId);

    Task<object> RetrieveTheCellsOfADedicatedCampaign(int dedicatedCampaignId);

    Task<object> CreateANewDedicatedCampaignCell(string authToken);

    Task<object> UpdateTheDetailsOfADedicatedCampaignCell(int dedicatedCampaignCellId, string authToken);

    Task<object> GetTheDetailsOfADedicatedCampaignCell(int dedicatedCampaignCellId);

    Task<object> DeleteADedicatedCampaignCell(int dedicatedCampaignCellId);

    Task<object> RetrieveIntervalMetricsUsedForDashboardCharts(int dedicatedCampaignId);
}