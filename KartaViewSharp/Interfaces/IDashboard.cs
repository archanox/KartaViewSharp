using KartaViewSharp.ResponseData;

namespace KartaViewSharp.Interfaces;

public interface IDashboard
{
	Task<Response> GetUserTypeMetricIntervalData();

	Task<Response> GetPlatformMetricIntervalData();

	Task<Response> GetUniqueDistanceMetricIntervalData();

	Task<Response> GetTotalDistanceMetricIntervalData();

	Task<Response> GetPlatformMetricIntervalData();

	Task<Response> GetMetricsDataBasedOnMetricType();

	Task<Response> GetTheDetailsOfASequence();

	Task<Response> RetrieveSequences();

	Task<Response> GetTheDetailsOfAUser();

	Task<Response> RetrieveUsers();

	Task<Response> GetTheDetailsOfAnIssue();

	Task<Response> RetrieveIssues();

	Task<Response> GetTheDetailsOfARegion();

	Task<Response> RetrieveVisibleRegions();
}